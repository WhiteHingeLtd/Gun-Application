Imports WHLClasses

Public Class BC_Main

    Dim OutputList As New List(Of ArrayList)

    Public ParentF As BC_SKUDownload

    Private Sub BC_Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ParentF.Close()
    End Sub
    Dim ActiveItem As WhlSKU

    Dim IsNewEntry As Boolean = False
    Dim NewEntryCode As String = ""
    Dim NewEntryItemCode As String = ""
    Private Sub ScanButton_Click(sender As Object, e As EventArgs) Handles ScanButton.Click
        If IsNewEntry Then
            StandardSearch()
            NewEntryCode = ScanBox.Text
            Comment.Text = "The previous scan was saved. If this is the correct item, press correct and it will be recorded in the spreadsheet. Press Incorrect to cancel. "
        Else
            StandardSearch()
        End If


    End Sub

    Private Sub StandardSearch()

        If Not ScanBox.TextLength = 0 Then
            Dim results As SkuCollection = ParentF.SkuColl.SearchSKUS(ScanBox.Text)
            If results.Count = 0 Then
                'Nothinf found. We'll have to add a new entry. 
                Comment.Text = "No item found. Try scanning the magnet/shelf label."
                IsNewEntry = True
                NewEntryItemCode = ScanBox.Text
                Me.BackgroundImage = My.Resources.BackgroundRed
            Else
                ActiveItem = results(0)
                LabelShort.Text = ActiveItem.Title.Label
                SKUStock.Text = ActiveItem.Stock.Level.ToString + " Level + " + ActiveItem.Stock.Minimum.ToString + " Min."
                UnDisable()
                Me.BackgroundImage = My.Resources.Background
            End If
        Else
            ResultCorrect.PerformClick()
            Me.BackgroundImage = My.Resources.Background
        End If
        ScanBox.Text = ""
    End Sub

    Private Sub ClearBoxes()
        LabelShort.Text = ""
        SKUStock.Text = ""
        ScanBox.Text = ""
        ScanBox.Focus()
        ResultCorrect.Enabled = False
        ResultIncorrect.Enabled = False
        Comment.Text = ""
    End Sub

    Private Sub UnDisable()
        ResultCorrect.Enabled = True
        ResultIncorrect.Enabled = True
    End Sub

    Private Sub BC_Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ClearBoxes()
    End Sub

    Private Sub ResultIncorrect_Click(sender As Object, e As EventArgs) Handles ResultIncorrect.Click
        If IsNewEntry Then
            IsNewEntry = False
            NewEntryCode = ""
            NewEntryItemCode = ""
            ClearBoxes()
        Else
            Comment.Text = "Scan the magnet, and the correct entry will be recorded probably if it is correct."
            IsNewEntry = True
            NewEntryItemCode = ScanBox.Text
        End If
        ScanBox.Focus()
    End Sub

    Private Sub ResultCorrect_Click(sender As Object, e As EventArgs) Handles ResultCorrect.Click
        If IsNewEntry Then
            Dim NewArrl As New ArrayList
            NewArrl.Add(NewEntryCode)
            NewArrl.Add(NewEntryItemCode)
            NewArrl.Add(ActiveItem.Title.Label)
            OutputList.Add(NewArrl)
            ClearBoxes()
            Comment.Text = "Added to list"
            IsNewEntry = False
        Else
            ClearBoxes()
        End If
        ScanBox.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As MsgBoxResult = MsgBox("Exporting will overwrite any previous version of the file. Are you sure you want to do that?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            Try
                Dim filename As String = "\\PPRETAILSTEVE\Desktop\ItemActioner\Checky-" + Now.ToString("dd-MMM_HH-mm-ss") + ".csv"
                My.Computer.FileSystem.WriteAllText(filename, "", False)
                For Each record As ArrayList In OutputList
                    My.Computer.FileSystem.WriteAllText(filename, record(0) + ", " + record(1) + ", " + record(2) + vbCrLf, True)
                Next

                Comment.Text = "Exported file sucessfully To """ + filename + """."
            Catch ex As Exception
                MsgBox("Error: " + vbNewLine + ex.Message)
            End Try
        Else
            MsgBox("Export Cancelled.")
        End If

        ScanBox.Focus()
    End Sub
End Class
