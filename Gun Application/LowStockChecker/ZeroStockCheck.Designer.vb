<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZeroStockCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZeroStockCheck))
        Me.Title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResetButton = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.frombox = New System.Windows.Forms.TextBox()
        Me.tobox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.startbutton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(1, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(228, 30)
        Me.Title.TabIndex = 2
        Me.Title.Text = "Minimum Stock Check"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.ResetButton)
        Me.Panel2.Location = New System.Drawing.Point(291, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(25, 25)
        Me.Panel2.TabIndex = 3
        '
        'ResetButton
        '
        Me.ResetButton.AutoSize = True
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(3, -1)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(23, 25)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.Text = "X"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 102)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From:"
        '
        'frombox
        '
        Me.frombox.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frombox.Location = New System.Drawing.Point(12, 173)
        Me.frombox.Name = "frombox"
        Me.frombox.Size = New System.Drawing.Size(61, 47)
        Me.frombox.TabIndex = 6
        '
        'tobox
        '
        Me.tobox.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tobox.Location = New System.Drawing.Point(97, 173)
        Me.tobox.Name = "tobox"
        Me.tobox.Size = New System.Drawing.Size(61, 47)
        Me.tobox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(94, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "To:"
        '
        'startbutton
        '
        Me.startbutton.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startbutton.Location = New System.Drawing.Point(180, 173)
        Me.startbutton.Name = "startbutton"
        Me.startbutton.Size = New System.Drawing.Size(128, 46)
        Me.startbutton.TabIndex = 9
        Me.startbutton.Text = "Start"
        Me.startbutton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 84)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Press ALPHA to enable letters, then press it again to type the numbers. If your a" &
    "rea starts at A00, press ALPHA, Left Arrow, ALPHA, 0, 0, then do where it ends"
        '
        'ZeroStockCheck
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.GunStockCheck.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.startbutton)
        Me.Controls.Add(Me.tobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.frombox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Title)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ZeroStockCheck"
        Me.Text = "Minimum Stock Check"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetButton As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents frombox As TextBox
    Friend WithEvents tobox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents startbutton As Button
    Friend WithEvents Label4 As Label
End Class
