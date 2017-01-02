Public Class ShelfMoveDialog

    Private Sub Buttons_Enter(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles CoolButton1.Enter, Coolbutton6.Enter
        Cursor.Position = New Point(Me.Location.X + sender.Location.X + 15, Me.Location.Y + sender.Location.Y + 15)
    End Sub

    Private Sub Buttons_Leave(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles CoolButton1.Leave, Coolbutton6.Leave
        Cursor.Position = New Point(0, 0)
    End Sub

    Private Sub Coolbutton6_Click(sender As Object, e As EventArgs) Handles Coolbutton6.Click
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub CoolButton1_Click(sender As Object, e As EventArgs) Handles CoolButton1.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
End Class