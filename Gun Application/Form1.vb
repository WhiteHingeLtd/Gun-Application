Public Class Form1
    Dim result As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        code.Focus()
    End Sub

    Private Sub scan_Click(sender As Object, e As EventArgs) Handles scan.Click
        result = SelectData("SELECT * FROM whldata.whlnew WHERE sku LIKE '%" + code.Text + "%' OR primarysuppbarcode LIKE '%" + code.Text + "%' OR primarysuppcase LIKE '%" + code.Text + "%' OR altsuppbarcode LIKE '%" + code.Text + "%' OR altsuppcase LIKE '%" + code.Text + "%' LIMIT 1")
        If result.Count = 0 Then
            sku.Text = ""
            title.Text = "No results found. Try scanning something else."
            RetailPrice.Text = ""
            packet.Text = ""
            shorttitle.Text = ""
            StockLevel.Text = ""
            code.Clear()
            code.Focus()
        Else
            sku.Text = result(0)(0)
            title.Text = result(0)(5)
            RetailPrice.Text = result(0)(8)
            packet.Text = result(0)(12)
            shorttitle.Text = result(0)(98)
            StockLevel.Text = (result(0)(4)).ToString + " (" + result(0)(1).ToString + " + " + result(0)(2).ToString + "min.)"
            code.Clear()
            code.Focus()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        magnetlabel.Show()
        code.Focus()
        code.Clear()
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles code.KeyDown

        If e.KeyCode = Keys.F10 Then
            e.SuppressKeyPress = True
            magnetlabel.Show()

            magnetlabel.barcode.Data = result(0)(80)
            magnetlabel.barcode.Refresh()

            magnetlabel.shelfno.Text = result(0)(51)
            magnetlabel.shortsku.Text = result(0)(80)
            magnetlabel.shelftitle.Text = result(0)(11)
            magnetlabel.suppcode.Text = result(0)(20) + " / " + result(0)(24) + " / " + result(0)(28)
        ElseIf e.KeyCode = Keys.F9 Then
            e.SuppressKeyPress = True
            shelflabel.Show()

            shelflabel.barcode.Data = result(0)(80)
            shelflabel.barcode.Refresh()

            shelflabel.shelfno.Text = result(0)(51)
            shelflabel.shortsku.Text = result(0)(80).ToString.Substring(2)
            shelflabel.shelftitle.Text = result(0)(98)
            shelflabel.primarysupplier.Text = result(0)(19) + ": " + result(0)(20)
            shelflabel.altsupplier.Text = result(0)(23) + ": " + result(0)(24)
            shelflabel.supp3.Text = result(0)(27) + ": " + result(0)(28)

            If result(0)(108).ToString.Length > 0 Then
                shelflabel.Packsizes.Text = result(0)(108)
            Else
                Dim newspacksizes As String = ""
                If Not result(0)(60) = "NSL" Then newspacksizes = newspacksizes + result(0)(60)
                If result(0)(61).ToString.Length > 0 Then newspacksizes = newspacksizes + " | " + result(0)(61)
                If result(0)(62).ToString.Length > 0 Then newspacksizes = newspacksizes + " | " + result(0)(62)
                If result(0)(63).ToString.Length > 0 Then newspacksizes = newspacksizes + " | " + result(0)(63)
                If result(0)(64).ToString.Length > 0 Then newspacksizes = newspacksizes + " | " + result(0)(64)
                shelflabel.Packsizes.Text = newspacksizes
            End If

        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        code.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MainMenu.Activate()
    End Sub
End Class
