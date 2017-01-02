Imports WHLClasses

Public Class BC_SKUDownload

    Public SkuColl As SkuCollection

    Private Sub BC_SKUDownload_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Start the thing. 
        SKUCollProgTimer.Enabled = True
        SkuColl = New SkuCollection(True)
        SkuColl.DownloadSKUs()
        SKUCollProgTimer.Enabled = False


        Dim BCMain As New BC_Main
        BCMain.ParentF = Me
        BCMain.Show()
        Me.TopMost = False

    End Sub

    Private Sub SKUCollProgTimer_Tick(sender As Object, e As EventArgs) Handles SKUCollProgTimer.Tick
        Try
            SkuCollProg.Maximum = SkuColl.Total
            SkuCollProg.Value = SkuColl.Progress
        Catch ex As Exception

        End Try

    End Sub
End Class
