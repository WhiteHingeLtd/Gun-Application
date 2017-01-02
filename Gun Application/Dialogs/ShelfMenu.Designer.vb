<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShelfMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CancelButton = New WHLClasses.Controls.CoolButton()
        Me.ExistingShelvesDialog = New System.Windows.Forms.FlowLayoutPanel()
        Me.Coolbutton6 = New WHLClasses.Controls.CoolButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CoolButton4 = New WHLClasses.Controls.CoolButton()
        Me.Scanbox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.ExistingShelvesDialog.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Controls.Add(Me.ExistingShelvesDialog)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 300)
        Me.Panel1.TabIndex = 6
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Silver
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(3, 263)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(292, 32)
        Me.CancelButton.TabIndex = 99
        Me.CancelButton.Tag = "cancel"
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'ExistingShelvesDialog
        '
        Me.ExistingShelvesDialog.Controls.Add(Me.Coolbutton6)
        Me.ExistingShelvesDialog.Location = New System.Drawing.Point(-1, 73)
        Me.ExistingShelvesDialog.Name = "ExistingShelvesDialog"
        Me.ExistingShelvesDialog.Size = New System.Drawing.Size(300, 192)
        Me.ExistingShelvesDialog.TabIndex = 1
        '
        'Coolbutton6
        '
        Me.Coolbutton6.BackColor = System.Drawing.Color.Silver
        Me.Coolbutton6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Coolbutton6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Coolbutton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Coolbutton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Coolbutton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Coolbutton6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coolbutton6.Location = New System.Drawing.Point(3, 3)
        Me.Coolbutton6.Name = "Coolbutton6"
        Me.Coolbutton6.Size = New System.Drawing.Size(292, 32)
        Me.Coolbutton6.TabIndex = 0
        Me.Coolbutton6.Text = "TEMPALTE"
        Me.Coolbutton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Coolbutton6.UseVisualStyleBackColor = False
        Me.Coolbutton6.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 33)
        Me.Panel2.TabIndex = 0
        '
        'TitleText
        '
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.ForeColor = System.Drawing.Color.White
        Me.TitleText.Location = New System.Drawing.Point(3, 4)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(284, 23)
        Me.TitleText.TabIndex = 0
        Me.TitleText.Text = "TitleText"
        Me.TitleText.UseMnemonic = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tap or select a shelf you want to remove, or just scan a new one to add another"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(13, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 300)
        Me.Panel3.TabIndex = 7
        '
        'CoolButton4
        '
        Me.CoolButton4.BackColor = System.Drawing.Color.Silver
        Me.CoolButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CoolButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CoolButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CoolButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CoolButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CoolButton4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolButton4.Location = New System.Drawing.Point(315, 3)
        Me.CoolButton4.Name = "CoolButton4"
        Me.CoolButton4.Size = New System.Drawing.Size(292, 32)
        Me.CoolButton4.TabIndex = 8
        Me.CoolButton4.Text = "TEMPALTE"
        Me.CoolButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CoolButton4.UseVisualStyleBackColor = False
        Me.CoolButton4.Visible = False
        '
        'Scanbox
        '
        Me.Scanbox.Location = New System.Drawing.Point(217, 3)
        Me.Scanbox.Name = "Scanbox"
        Me.Scanbox.Size = New System.Drawing.Size(100, 20)
        Me.Scanbox.TabIndex = 9
        '
        'ShelfMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Scanbox)
        Me.Controls.Add(Me.CoolButton4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShelfMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShelfMenu"
        Me.TransparencyKey = System.Drawing.Color.Cyan
        Me.Panel1.ResumeLayout(False)
        Me.ExistingShelvesDialog.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExistingShelvesDialog As FlowLayoutPanel
    Friend WithEvents Coolbutton6 As WHLClasses.Controls.CoolButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CancelButton As WHLClasses.Controls.CoolButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CoolButton4 As WHLClasses.Controls.CoolButton
    Friend WithEvents Scanbox As TextBox
End Class
