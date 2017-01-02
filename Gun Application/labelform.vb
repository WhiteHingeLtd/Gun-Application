Public Class magnetlabel
    Private Sub labelform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datebox.Text = Now.ToShortDateString

    End Sub

    Private Sub labelform_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Focus()
        Me.Location = New Point(0, 0)
        PrintDocument1.PrintController = New System.Drawing.Printing.StandardPrintController
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.CopyFromScreen(New Point(0, 0), New Point(0, 0), New Size(320, 243))
        main.Location = New Point(-320, 0)
        e.Graphics.CopyFromScreen(New Point(0, 0), New Point(320, 0), New Size(119, 243))
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub


End Class