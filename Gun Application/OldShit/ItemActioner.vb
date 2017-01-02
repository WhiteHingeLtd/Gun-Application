
Imports WHLClasses
Public Class ItemActioner
    Dim confirm As System.Windows.Forms.Keys
    Dim queryresp As New ArrayList
    Dim thecsv As New ArrayList
    Dim employees As New ArrayList



    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Execute.Click
        queryresp = MySql.SelectData("SELECT binrack,shortsku,labelshort FROM whldata.whlnew WHERE shortsku='" + SearchBox.Text + "' ORDER BY sku ASC LIMIT 1")
        If queryresp.Count = 0 Then
            labelshort.Text = "Nothing found with that ShortSKU"
        Else
            shelf.Text = queryresp(0)(0)
            shortsku.Text = queryresp(0)(1)
            labelshort.Text = queryresp(0)(2)

            For Each employee As ArrayList In employees
                If (shelf.Text.Remove(3).CompareTo(employee(3).ToString) > -1) And (shelf.Text.Remove(3).CompareTo(employee(4).ToString) < 0) Then
                    'This is the employee we need
                    Area.Text = employee(1)
                End If
            Next

        End If
        SearchBox.Focus()
        SearchBox.Clear()
    End Sub

    Private Sub ItemActioner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetThing()
        employees = MySql.SelectData("SELECT * FROM whldata.employees")
        Dim newline As New ArrayList
        newline.Add("Area")
        newline.Add("Action")
        newline.Add("Shelf")
        newline.Add("Label Short")
        newline.Add("Short SKU")
        newline.Add("Priority")
        thecsv.Add(newline)

    End Sub
    Private Sub ResetThing()
        shelf.Text = ""
        shortsku.Text = ""
        Action.Text = ""
        labelshort.Text = ""
        SearchBox.Focus()
        SearchBox.Text = ""
        Area.Text = ""
        Priority.CheckState = CheckState.Unchecked
        confirm = Keys.F24
    End Sub

    Private Sub SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        If e.KeyCode = confirm Then
            'Save it to the list
            Dim newline As New ArrayList
            newline.Add(Area.Text)
            newline.Add(Action.Text)
            newline.Add(shelf.Text)
            newline.Add(labelshort.Text)
            newline.Add(shortsku.Text)
            newline.Add(Priority.CheckState.ToString)
            thecsv.Add(newline)
            ResetThing()
        ElseIf e.KeyCode = Keys.F1 Then
            Action.Text = "1 Barcode"
            confirm = Keys.F1
        ElseIf e.KeyCode = Keys.F2 Then
            Action.Text = "2 New Box"
            confirm = Keys.F2
        ElseIf e.KeyCode = Keys.F3 Then
            Action.Text = "3 Dividers"
            confirm = Keys.F3
        ElseIf e.KeyCode = Keys.F4 Then
            Action.Text = "4 Bring Down"
            confirm = Keys.F4
        ElseIf e.KeyCode = Keys.F5 Then
            Action.Text = "5 Magnet"
            confirm = Keys.F5
        ElseIf e.KeyCode = Keys.F6 Then
            Action.Text = "6 Other"
            confirm = Keys.F6
        ElseIf e.KeyCode = Keys.F7 Then
            Action.Text = "7 Prepack"
            confirm = Keys.F7
        ElseIf e.KeyCode = Keys.F8 Then
            Priority.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim response As MsgBoxResult = MsgBox("Exporting will overwrite any previous version of the file. Are you sure you want to do that?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Try
                Dim filename As String = "\\PPRETAILSTEVE\Desktop\ItemActioner\Export-" + Now.ToString("dd-MMM_HH-mm-ss") + ".csv"
                My.Computer.FileSystem.WriteAllText(filename, "", False)
                For Each record As ArrayList In thecsv
                    My.Computer.FileSystem.WriteAllText(filename, record(0) + ", " + record(1) + ", " + record(2) + ", " + record(3) + ", " + record(4) + ", " + record(5) + vbCrLf, True)
                Next

                MsgBox("Exported file sucessfully To """ + filename + """.")
            Catch ex As Exception
                MsgBox("Error: " + vbNewLine + ex.Message)
            End Try
        Else
            MsgBox("Export Cancelled.")
        End If

        SearchBox.Focus()
    End Sub
End Class