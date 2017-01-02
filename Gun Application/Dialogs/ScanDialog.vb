Public Class ScanDialog

    Friend result As String = ""
    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        If ValueBox.Text.Length = 0 Then
            IMSgC.iMsg("You must scan something.")
        End If
        result = ValueBox.Text
    End Sub

    Private Sub ScanDialog_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ValueBox.Focus()
    End Sub
End Class