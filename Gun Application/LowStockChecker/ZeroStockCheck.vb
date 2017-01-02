Public Class ZeroStockCheck
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles frombox.TextChanged
        If frombox.TextLength = 3 Then
            tobox.Focus()
        End If
    End Sub

    Private Sub tobox_TextChanged(sender As Object, e As EventArgs) Handles tobox.TextChanged
        If tobox.TextLength = 3 Then
            startbutton.Focus()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Me.Close()
        MainMenu.Activate()
    End Sub

    Private Sub startbutton_Click(sender As Object, e As EventArgs) Handles startbutton.Click
        ZeroStockCheckMain.Show()
        ZeroStockCheckMain.SearchForMinis(frombox.Text.ToUpper, tobox.Text.ToUpper)
        Me.Close()
    End Sub
End Class