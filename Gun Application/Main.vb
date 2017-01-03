Imports WHLClasses
Imports System.Drawing
Public Class Main
    Public Sub ResetMouse()
        Cursor.Position = New Point(0, 0)
    End Sub

    Public Skus As SkuCollection

    Private Sub CoolButton1_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Process.Start("C:\Windows\explorer.exe")
        Me.Close()

    End Sub

    Private Sub CoolButton2_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        Try
            If My.Application.Deployment.CheckForUpdate() Then
                IMSgC.iMsg("An update is being installed before restarting.", "Updater")
                My.Application.Deployment.Update()
            End If

        Catch ex As Exception

        End Try
        Application.Restart()
    End Sub

    Private Sub Instruct(Message As String, Optional color As Color = Nothing)
        If color = Nothing Then color = Color.DarkBlue
        InstructBox.Text = Message
        InstructBox.ForeColor = color
    End Sub

    Private Sub CoolButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Scanbox_Leave(sender As Object, e As EventArgs) Handles Scanbox.Leave
        Scanbox.BackColor = Color.Red
    End Sub

    Private Sub Scanbox_Enter(sender As Object, e As EventArgs) Handles Scanbox.Enter
        Scanbox.BackColor = Color.Black
    End Sub

    Private Sub ScanButton_Click(sender As Object, e As EventArgs) Handles ScanButton.Click
        My.Computer.Audio.Play(My.Resources.Beep, AudioPlayMode.Background)
        ProcessScan(Scanbox.Text)
        Scanbox.Text = ""
    End Sub
    Dim emps As New EmployeeCollection
    Friend authd As Employee


    '=============================================================================
    '=============================================================================
    '=============================================================================
    '=============================================================================


    Dim ActiveCollection As SkuCollection
    Dim ActiveSingle As WhlSKU
    Friend Newstockval As Integer


    '=============================================================================
    '=============================================================================
    '=============================================================================
    '=============================================================================

    ''' <summary>
    ''' The main function which runs when we scan.
    ''' </summary>
    Friend Sub ProcessScan(Data As String)
        If Data.StartsWith("qzu") Then
            Try
                authd = emps.FindEmployeeByID(Convert.ToInt32(Data.Replace("qzu", "")))
                Instruct("Scan shelf or item")
            Catch ex As Exception
                IMSgC.iMsg(ex.Message, "Couldn't log in!")
                Instruct("Scan User ID", Color.Red)
            End Try
        ElseIf Data.StartsWith("qlo") Then
            If Not IsNothing(authd) Then
                'Lookup the location
                Dim Location As String = MySQL.SelectData("SELECT locText FROM whldata.locationreference WHERE locID=" + Data.Replace("qlo", "") + ";")(0)(0)
                ItemsInLocationLabel.Text = "Items at " + Location + ":."
                ItemsInLocation.Items.Clear()
                Dim items As SkuCollection = Skus.SearchLocationIDs(Convert.ToInt32(Data.Replace("qlo", ""))).MakeMixdown
                For Each item As WhlSKU In items
                    Dim newstock As string = item.Locations.Where(Function(x As SKULocation) x.LocationID.ToString = Data.Replace("qlo", ""))(0).Additional
                    Dim addstring As String = ""
                    Try
                        item.UpdateStock()
                    Catch ex As Exception

                    End Try


                    Try
                        addstring = item.Title.Label + " (week " + Math.Ceiling(Now.AddDays((item.Stock.Total - Convert.ToInt32(newstock)) / item.SalesData.CombinedWeekly * 7).DayOfYear / 7).ToString() + ")"
                    Catch ex As Exception
                        addstring = item.Title.Label
                    End Try


                    For i As Integer = 0 To addstring.Length - 1 Step 36
                        Try
                            ItemsInLocation.Items.Add(addstring.Substring(i, 36))
                        Catch ex As Exception
                            ItemsInLocation.Items.Add(addstring.Substring(i))
                        End Try

                    Next
                    ItemsInLocation.Items.Add("")
                Next
                LocationPanel.Visible = True
                ItemPanel.Visible = False
                Instruct("Scan shelf or item")
            Else
                IMSgC.iMsg("You need to scan your user ID.", "User Error")
                Instruct("Scan User ID", Color.Red)
            End If


        ElseIf Data.StartsWith("10") And (Data.Length = 7 Or Data.Length = 11) Then
            If Not IsNothing(authd) Then
                'Item
                ActiveCollection = Skus.GatherChildren(Data.Substring(0, 7))

                'Ask user how much new stock there is.
                Dim NewStock As Integer = AskNewStock()
                Newstockval = NewStock
                'Iterate through each packsize and check the prepack setting - If it's listed
                Dim prepack As String = ""
                For Each item As WhlSKU In ActiveCollection
                    If item.PackSize = 1 Then
                        ActiveSingle = item
                        Dim response As ArrayList = MySQL.SelectData("SELECT * FROM whldata.prepack_type WHERE Sku='" + item.ShortSku + "';")
                        If response.Count = 0 Then
                            prepack = PrepackTypeChooser.ChoosePrepack(item.Title.Label)
                            If Not prepack = "Cancel" Then
                                MySQL.insertUpdate("REPLACE INTO whldata.prepack_type (Sku, Type) VALUES ('" + item.ShortSku + "','" + prepack + "')")
                            End If
                        Else
                            prepack = response(0)(1).ToString
                        End If
                    End If
                Next

                'Update stpck
                Try
                    ActiveSingle.UpdateStock()
                Catch ex As Exception

                End Try

                'Calcualte weeks remaining and worth.
                Dim WeeksRemaining As Single = (ActiveSingle.Stock.Total - NewStock) / ActiveSingle.SalesData.CombinedWeekly
                Dim Newweeks As Single = (NewStock / ActiveSingle.SalesData.CombinedWeekly)

                'Upodate the UI with stuff.
                ItemTitle.Text = ActiveSingle.Title.Label
                PrepackLabel.Text = prepack
                WeeksWorthLabel.Text = Math.Floor(Newweeks).ToString
                PackByLabel.Text = Math.Ceiling(Now.AddDays(WeeksRemaining * 7).DayOfYear / 7).ToString

                UpdateLocations()

                LocationPanel.Visible = False
                ItemPanel.Visible = True
                Scanbox.Focus()
                Instruct("Choose an action or scan another item")
            Else
                IMSgC.iMsg("You need to scan your user ID.", "User Error")
                Instruct("Scan User ID", Color.Red)
            End If
        End If
    End Sub

    Private Sub Buttons_Enter(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles PrintLabelButton.Enter, ShelfMenuButton.Enter, ChangePrepackButton.Enter
        Cursor.Position = New Point(Me.Location.X + sender.Location.X + 7, Me.Location.Y + sender.Location.Y + 60)
    End Sub

    Private Sub Buttons_Leave(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles PrintLabelButton.Leave, ShelfMenuButton.Leave, ChangePrepackButton.Leave
        Cursor.Position = New Point(0, 0)
    End Sub

    Private Sub Buttons_Enter(sender As Object, e As EventArgs) Handles ShelfMenuButton.Enter, PrintLabelButton.Enter, ChangePrepackButton.Enter

    End Sub

    Private Sub Buttons_Leave(sender As Object, e As EventArgs) Handles ShelfMenuButton.Leave, PrintLabelButton.Leave, ChangePrepackButton.Leave

    End Sub

    Private Sub ScanBoxProxyButton_Enter(sender As Object, e As EventArgs) Handles ScanBoxProxyButton.Enter
        Scanbox.Focus()
    End Sub

    Dim labels As New LabelMaker

    Private Sub PrintLabelButton_Click(sender As Object, e As EventArgs) Handles PrintLabelButton.Click
        'IMSgC.iMsg("You can't do that yet", "Incomplete feature")
        labels.PrepackDelivery(ActiveSingle.Title.Label, GetIntials(PrepackLabel.Text), PackByLabel.Text, WeeksWorthLabel.Text + " weeks worth", ActiveSingle.GetLocation(SKULocation.SKULocationType.Pickable).LocationText, (New Printing.PrinterSettings).PrinterName)
        refox()
    End Sub

    Public Function AskNewStock() As Integer
        Dim Stockwin As New AskNewStockDialog
        Stockwin.ShowDialog()
        Return Stockwin.result
    End Function

    Public Function RequestScan(Optional title As String = "Scan Now") As String
        Dim Stockwin As New ScanDialog
        Stockwin.TitleText.Text = title
        Stockwin.ShowDialog()
        Return Stockwin.result
    End Function

    Private Sub ChangePrepackButton_Click(sender As Object, e As EventArgs) Handles ChangePrepackButton.Click
        Dim prepack As String
        prepack = PrepackTypeChooser.ChoosePrepack(ActiveSingle.PackSize.ToString + " pack - Prepack type")
        If Not prepack = "Cancel" Then
            MySQL.insertUpdate("REPLACE INTO whldata.prepack_type (Sku, Type) VALUES ('" + ActiveSingle.ShortSku + "','" + prepack + "')")
        End If
        PrepackLabel.Text = prepack
        Instruct("Done. Choose an action or scan")
        refox()
    End Sub

    Public Sub UpdateLocations()
        LocationsLabel.Text = ""
        For Each item As WhlSKU In ActiveCollection

            Try
                item.RefreshLocations()
            Catch ex As Exception
            End Try
        Next
        For Each location As SKULocation In ActiveSingle.GetLocationsByType(SKULocation.SKULocationType.Prepack)
            LocationsLabel.Text += location.LocationText + " "
        Next

    End Sub

    Private Function GetIntials(Source As String) As String
        Dim subs() As String = Source.Split(" ")
        Dim Returnable As String = ""
        For Each substr As String In subs
            Returnable += substr.Substring(0, 1)
        Next
        Return Returnable
    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PackByHint.Text = "Pack By (Now " + Math.Ceiling(Now.DayOfYear / 7).ToString + ")"
    End Sub

    Private Sub Scanbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Scanbox.KeyDown
        If e.KeyCode = Keys.Down And ItemPanel.Visible = True Then
            PrintLabelButton.Focus()
        End If
    End Sub

    Private Sub ShelfMenuButton_Click(sender As Object, e As EventArgs) Handles ShelfMenuButton.Click
        Dim Shelfmenu As New ShelfMenu
        Shelfmenu.ShelfOptions(ActiveCollection, ActiveSingle)
        UpdateLocations()
        Instruct("Done. Scan next item.")
        refox()
    End Sub

    Private Sub refox()
        Scanbox.Text = ""
        Scanbox.Focus()
    End Sub
End Class