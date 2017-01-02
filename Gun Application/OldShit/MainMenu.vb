Imports System.Deployment.Application

Public Class MainMenu
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Application.Restart()
    End Sub

    Private Sub UpdateCheck_Tick(sender As Object, e As EventArgs) Handles UpdateCheck.Tick
        Try
            If ApplicationDeployment.CurrentDeployment.CheckForDetailedUpdate.UpdateAvailable Then
                'Install the update and restart.
                ApplicationDeployment.CurrentDeployment.Update()
                Application.Restart()
                End
                UpdateCheck.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            versiontext.Text = "Version " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Catch ex As Exception
            versiontext.Text = "Debug Version. Do not use."
        End Try

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ItemActioner.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Delivery.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewBCSkuD As New BC_SKUDownload
        NewBCSkuD.Show()
    End Sub
End Class