Public Class PrepackTypeChooser
    Friend Result As String = ""

    Private Sub CoolButton5_Click(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles CoolButton1.Click, CoolButton2.Click, CoolButton3.Click, CoolButton4.Click, CoolButton5.Click, Coolbutton6.Click, CoolButton7.Click
        Result = sender.Text
        Me.Close()
    End Sub

    Public Function ChoosePrepack(Optional title As String = "Choose Prepack Type") As String
        Dim NewChooser As New PrepackTypeChooser
        Main.ResetMouse()
        NewChooser.TitleText.Text = title
        NewChooser.ShowDialog()
        Return NewChooser.Result

    End Function

    Private Sub Buttons_Enter(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles CoolButton1.Enter, CoolButton2.Enter, CoolButton3.Enter, CoolButton4.Enter, CoolButton5.Enter, Coolbutton6.Enter, CoolButton7.Enter
        Cursor.Position = New Point(Me.Location.X + sender.Location.X + 15, Me.Location.Y + sender.Location.Y + 15)
    End Sub

    Private Sub Buttons_Leave(sender As WHLClasses.Controls.CoolButton, e As EventArgs) Handles CoolButton1.Leave, CoolButton2.Leave, CoolButton3.Leave, CoolButton4.Leave, CoolButton5.Leave, Coolbutton6.Leave, CoolButton7.Leave
        Cursor.Position = New Point(0, 0)
    End Sub

End Class

