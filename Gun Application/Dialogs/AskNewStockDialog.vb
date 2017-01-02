Public Class AskNewStockDialog
    Friend result As Integer = 0
    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        Try
            If Not ValueBox.Text = "" Then
                result = Convert.ToInt32(ValueBox.Text)
            End If
            Me.Close()
        Catch ex As Exception
            IMSgC.iMsg("You need to enter a number. ", "Invalid value entered")
            ValueBox.Text = ""
            ValueBox.Focus()
        End Try

    End Sub

    Private Sub AskNewStockDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        ValueBox.Focus()
    End Sub
End Class