Imports WHLClasses
Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.Start("C:\Windows\System32\Taskkill.exe", "/F /IM explorer.exe")


    End Sub

    Private Sub Starter_Tick(sender As Object, e As EventArgs) Handles Starter.Tick
        Starter.Enabled = False
        Dim loader As New GenericDataController
        Main.Skus = loader.SmartSkuCollLoad(True)
    End Sub
End Class