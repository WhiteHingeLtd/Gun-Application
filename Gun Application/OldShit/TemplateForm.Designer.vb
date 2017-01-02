<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Header = New System.Windows.Forms.Panel()
        Me.ClsoeButton = New System.Windows.Forms.Label()
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Header.Controls.Add(Me.ClsoeButton)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.ForeColor = System.Drawing.Color.White
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(320, 30)
        Me.Header.TabIndex = 0
        '
        'ClsoeButton
        '
        Me.ClsoeButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClsoeButton.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsoeButton.ForeColor = System.Drawing.Color.White
        Me.ClsoeButton.Location = New System.Drawing.Point(293, 3)
        Me.ClsoeButton.Name = "ClsoeButton"
        Me.ClsoeButton.Size = New System.Drawing.Size(24, 24)
        Me.ClsoeButton.TabIndex = 1
        Me.ClsoeButton.Text = "X"
        Me.ClsoeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TemplateForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.GunStockCheck.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Header)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TemplateForm"
        Me.Text = "TemplateForm"
        Me.TopMost = True
        Me.Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents ClsoeButton As Label
End Class
