
Imports WHLClasses
Public Class Delivery

    Dim Delivery As New ArrayList
    Dim search As Boolean = False
    Dim Found As Boolean = False

    Dim SkuColl As WHLClasses.SkuCollection


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Delivery = MSSQLPublic.SelectData("SELECT * FROM whldata.deliverydata")
        Me.BackgroundImage = My.Resources.Background
        Dim loader As New WHLClasses.GenericDataController

        SkuColl = loader.LoadSkuColl("T:\AppData\Collections\Skudata.skuc")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        page.Text = "..."
        boxvalue.Text = "..."
        boxcount.Text = "..."
        counted.Text = "..."
        search = True
        NewSticker.Visible = False
        Application.DoEvents()
        Found = False


        For Each item As ArrayList In Delivery
            If search Then
                If TextBox1.Text = item(1) Then

                    'This is it.
                    search = False
                    barcode.Text = item(1)
                    page.Text = Math.Floor((item(0) - 1) / 10) + 1
                    If item(2).ToString.Contains("+") Then
                        boxcount.Text = Convert.ToInt32(item(2).ToString.Split("+")(0)) / Convert.ToInt32(item(2).ToString.Split("+")(1))
                        boxvalue.Text = Convert.ToInt32(item(2).ToString.Split("+")(1))
                    Else

                        boxcount.Text = 1
                        boxvalue.Text = item(2)
                    End If
                    If item.Count = 4 Then
                        item(3) = item(3) + 1
                        counted.Text = item(3)
                    Else
                        item.Add(1)
                        counted.Text = item(3)
                    End If

                    'Check if it exists./ 
                    Application.DoEvents()

                    Dim response As WHLClasses.SkuCollection = SkuColl.SearchSKUS(item(1))
                    If response.Count > 0 Then
                        'Not new
                        Me.BackgroundImage = My.Resources.Background
                    Else
                        'New
                        NewSticker.Visible = True
                        Me.BackgroundImage = My.Resources.BackgroundGreen
                    End If
                    Found = True
                    TotalCountedI += 1
                    totalcounted.Text = TotalCountedI
                End If
            End If
        Next
        If Found = False Then
            Me.BackgroundImage = My.Resources.BackgroundRed
            barcode.Text = TextBox1.Text
            page.Text = "None"
            boxvalue.Text = "None"
            boxcount.Text = "None"
            counted.Text = "TOO MANY"
        End If
        TextBox1.Focus()
        TextBox1.Clear()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Me.Close()
    End Sub

    Dim TotalTotal As Integer = 0
    Dim TotalCountedI As Integer = 0


    Private Sub totalboxes_Click(sender As Object, e As EventArgs) Handles totalboxes.Click
        TotalTotal = 0
        For Each item As ArrayList In Delivery
            If item(2).ToString.Contains("+") Then
                TotalTotal += Convert.ToInt32(item(2).ToString.Split("+")(0)) / Convert.ToInt32(item(2).ToString.Split("+")(1))
            Else
                TotalTotal += 1
            End If
        Next
        sender.text = TotalTotal.ToString
    End Sub

    Private Sub totalcounted_Click(sender As Object, e As EventArgs) Handles totalcounted.Click
        TotalCountedI = 0
        sender.text = TotalCountedI.ToString
    End Sub
End Class