Public Class IMsg
    Private Sub IMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        OKButton.Focus()
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class

Public Module IMSgC
    Public Sub iMsg(Body As String, Optional title As String = "Message")
        Dim NewMsg As New IMsg
        NewMsg.Body.Text = Body
        NewMsg.TitleText.Text = title
        NewMsg.ShowDialog()
    End Sub
End Module