Imports WHLClasses
Public Class ShelfMenu
    Private Sub CoolButton2_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Dim _AC As SkuCollection
    Dim _AS As WhlSKU


    Friend Sub ShelfOptions(ActiveCollection As SkuCollection, ActiveSingle As WhlSKU)
        TitleText.Text = ActiveSingle.Title.Label
        _AC = ActiveCollection
        For Each item As WhlSKU In _AC
            Try
                item.RefreshLocations()
            Catch ex As Exception

            End Try
        Next
        _AS = ActiveSingle
        ExistingShelvesDialog.Controls.Clear()
        For Each location As SKULocation In _AS.GetLocationsByType(SKULocation.SKULocationType.Prepack)
            ExistingShelvesDialog.Controls.Add(CreateButton(location.LocationText, location.LocationID))
        Next
        'ExistingShelvesDialog.Controls.Add(CreateButton("A01-21", 122))
        'ExistingShelvesDialog.Controls.Add(CreateButton("A02-32", 233))
        Me.ShowDialog()
    End Sub
    Dim TabindexP As Integer = 0
    Friend Function CreateButton(Text As String, tag As Object)
        Dim NewButton As New WHLClasses.Controls.CoolButton
        NewButton.BackColor = Color.Silver
        NewButton.TextAlign = ContentAlignment.MiddleLeft
        NewButton.Text = Text
        NewButton.Tag = tag
        NewButton.Size = New Size(292, 32)
        NewButton.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular)
        TabindexP += 1
        NewButton.TabIndex = TabindexP

        AddHandler NewButton.Click, AddressOf ButtonClick
        AddHandler NewButton.Enter, AddressOf Buttons_Enter
        AddHandler NewButton.Leave, AddressOf Buttons_Leave
        Return NewButton
    End Function

    Private Sub ButtonClick(sender As WHLClasses.Controls.CoolButton, e As EventArgs)
        'We need ti know if we're mocing or deleting.
        Dim Move As Boolean = ShelfMoveOrDelete(sender.Text)
        Dim continuedel As Boolean = True
        If Move Then
            'Ask for a new scan to get a new location.
            Dim scan As String = Main.RequestScan("Scan new location")
            If scan.StartsWith("qlo") Then
                For Each item As WhlSKU In _AC
                    item.AddNewLocation(Convert.ToInt32(scan.Replace("qlo", "")), Main.authd, Main.Newstockval)
                Next
                Me.Close()
                Scanbox.Text = ""
            Else
                Scanbox.Text = ""
                IMSgC.iMsg("You must scan a location!" + vbNewLine + vbNewLine + "Move cancelled")
                continuedel = False
            End If
        End If
        If continuedel Then
            For Each item As WhlSKU In _AC
                item.RemoveLocation(sender.Tag, Main.authd)
            Next
        End If
        Me.Close()
    End Sub

    Private Sub Buttons_Enter(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles CancelButton.Enter

        If sender.Tag.ToString = "cancel" Then
            Cursor.Position = New Point(Me.Location.X + sender.Location.X + 15, Me.Location.Y + sender.Location.Y + 15)
        Else
            Cursor.Position = New Point(Me.Location.X + sender.Location.X + 15, Me.Location.Y + sender.Location.Y + 15 + 73)

        End If

    End Sub

    Private Sub Buttons_Leave(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles CancelButton.Leave
        Cursor.Position = New Point(0, 0)
    End Sub


    ''' <summary>
    ''' Asks if they want to remove or delete a selected shelf.
    ''' </summary>
    ''' <param name="PromptText"></param>
    ''' <returns>True for move, false for just delete.</returns>
    Private Function ShelfMoveOrDelete(PromptText As String)
        Dim Prompt As New ShelfMoveDialog
        Prompt.TitleText.Text = PromptText
        If Prompt.ShowDialog() = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Scanbox_KeyUp(sender As Object, e As KeyEventArgs) Handles Scanbox.KeyDown
        If e.KeyCode = Keys.Enter And Scanbox.Text.Length > 0 Then
            'Gogogo
            If Scanbox.Text.StartsWith("qlo") Then
                For Each item As WhlSKU In _AC
                    item.AddNewLocation(Convert.ToInt32(Scanbox.Text.Replace("qlo", "")), Main.authd, Main.Newstockval)
                Next
                Me.Close()
                Scanbox.Text = ""
            Else
                Scanbox.Text = ""
                IMSgC.iMsg("You must scan a location!" + vbNewLine + vbNewLine + "Please try again!")
            End If
        End If

    End Sub



    Private Sub ShelfMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        Scanbox.Focus()
        Scanbox.Text = ""
    End Sub
End Class

