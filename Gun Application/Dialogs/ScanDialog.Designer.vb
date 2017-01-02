<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanDialog
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
        Me.ValueBox = New System.Windows.Forms.TextBox()
        Me.DoneButton = New WHLClasses.Controls.CoolButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ValueBox)
        Me.Panel1.Controls.Add(Me.DoneButton)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(13, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 170)
        Me.Panel1.TabIndex = 8
        '
        'ValueBox
        '
        Me.ValueBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ValueBox.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueBox.Location = New System.Drawing.Point(3, 56)
        Me.ValueBox.Name = "ValueBox"
        Me.ValueBox.Size = New System.Drawing.Size(282, 50)
        Me.ValueBox.TabIndex = 7
        Me.ValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DoneButton
        '
        Me.DoneButton.BackColor = System.Drawing.Color.Silver
        Me.DoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DoneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoneButton.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneButton.Location = New System.Drawing.Point(3, 128)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(282, 37)
        Me.DoneButton.TabIndex = 5
        Me.DoneButton.Text = "DONE"
        Me.DoneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DoneButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TitleText)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(282, 33)
        Me.Panel2.TabIndex = 0
        '
        'TitleText
        '
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.ForeColor = System.Drawing.Color.White
        Me.TitleText.Location = New System.Drawing.Point(3, 4)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(275, 23)
        Me.TitleText.TabIndex = 0
        Me.TitleText.Text = "Scan Now"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(21, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(289, 169)
        Me.Panel3.TabIndex = 9
        '
        'ScanDialog
        '
        Me.AcceptButton = Me.DoneButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScanDialog"
        Me.Text = "ScanDialog"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ValueBox As TextBox
    Friend WithEvents DoneButton As WHLClasses.Controls.CoolButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents Panel3 As Panel
End Class
