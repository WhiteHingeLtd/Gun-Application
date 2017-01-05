Imports WHLClasses
Public Class ExistingShelfPrompt

    Friend PrimaryLocationID As Integer
    Friend ActiveCollection As SkuCollection
    Friend user As Employee

    Private Sub IMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
        OKButton.Focus()
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        For Each item As WhlSKU In ActiveCollection
            item.RemoveLocation(PrimaryLocationID, user)
        Next
        Me.Close()
    End Sub
End Class

