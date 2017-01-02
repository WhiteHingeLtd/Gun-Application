<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShelfMoveDialog
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
        Me.CoolButton1 = New WHLClasses.Controls.CoolButton()
        Me.Coolbutton6 = New WHLClasses.Controls.CoolButton()
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
        Me.Panel1.Controls.Add(Me.CoolButton1)
        Me.Panel1.Controls.Add(Me.Coolbutton6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(8, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 118)
        Me.Panel1.TabIndex = 6
        '
        'CoolButton1
        '
        Me.CoolButton1.BackColor = System.Drawing.Color.Silver
        Me.CoolButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CoolButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CoolButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CoolButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CoolButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CoolButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoolButton1.Location = New System.Drawing.Point(3, 80)
        Me.CoolButton1.Name = "CoolButton1"
        Me.CoolButton1.Size = New System.Drawing.Size(292, 32)
        Me.CoolButton1.TabIndex = 1
        Me.CoolButton1.Text = "Delete"
        Me.CoolButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CoolButton1.UseVisualStyleBackColor = False
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
        Me.Coolbutton6.Location = New System.Drawing.Point(3, 42)
        Me.Coolbutton6.Name = "Coolbutton6"
        Me.Coolbutton6.Size = New System.Drawing.Size(292, 32)
        Me.Coolbutton6.TabIndex = 0
        Me.Coolbutton6.Text = "Move"
        Me.Coolbutton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Coolbutton6.UseVisualStyleBackColor = False
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
        Me.TitleText.Size = New System.Drawing.Size(275, 23)
        Me.TitleText.TabIndex = 0
        Me.TitleText.Text = "Move or delete?"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(14, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 118)
        Me.Panel3.TabIndex = 7
        '
        'ShelfMoveDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShelfMoveDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShelfMoveDialog"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CoolButton1 As WHLClasses.Controls.CoolButton
    Friend WithEvents Coolbutton6 As WHLClasses.Controls.CoolButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents Panel3 As Panel
End Class
