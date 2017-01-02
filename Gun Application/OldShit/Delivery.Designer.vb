<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delivery
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResetButton = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.barcode = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.page = New System.Windows.Forms.Label()
        Me.boxvalue = New System.Windows.Forms.Label()
        Me.boxcount = New System.Windows.Forms.Label()
        Me.counted = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NewSticker = New System.Windows.Forms.Label()
        Me.totalboxes = New System.Windows.Forms.Button()
        Me.totalcounted = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 31)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.ResetButton)
        Me.Panel2.Location = New System.Drawing.Point(292, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(25, 25)
        Me.Panel2.TabIndex = 2
        '
        'ResetButton
        '
        Me.ResetButton.AutoSize = True
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(3, -1)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(23, 25)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.Text = "X"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(2, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(69, 30)
        Me.Title.TabIndex = 0
        Me.Title.Text = "EDCO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "GET DATA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "This is ugly, deal with it."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 23)
        Me.TextBox1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(233, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'barcode
        '
        Me.barcode.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcode.Location = New System.Drawing.Point(74, 122)
        Me.barcode.Name = "barcode"
        Me.barcode.Size = New System.Drawing.Size(240, 41)
        Me.barcode.TabIndex = 7
        Me.barcode.Text = "8711252017358"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Page"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Amount in box"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Boxes"
        '
        'page
        '
        Me.page.AutoSize = True
        Me.page.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.page.Location = New System.Drawing.Point(130, 181)
        Me.page.Name = "page"
        Me.page.Size = New System.Drawing.Size(197, 32)
        Me.page.TabIndex = 11
        Me.page.Text = "8711252017358"
        '
        'boxvalue
        '
        Me.boxvalue.AutoSize = True
        Me.boxvalue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxvalue.Location = New System.Drawing.Point(130, 213)
        Me.boxvalue.Name = "boxvalue"
        Me.boxvalue.Size = New System.Drawing.Size(184, 32)
        Me.boxvalue.TabIndex = 12
        Me.boxvalue.Text = "8711252017358"
        '
        'boxcount
        '
        Me.boxcount.AutoSize = True
        Me.boxcount.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxcount.Location = New System.Drawing.Point(130, 245)
        Me.boxcount.Name = "boxcount"
        Me.boxcount.Size = New System.Drawing.Size(197, 32)
        Me.boxcount.TabIndex = 13
        Me.boxcount.Text = "8711252017358"
        '
        'counted
        '
        Me.counted.AutoSize = True
        Me.counted.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.counted.Location = New System.Drawing.Point(130, 277)
        Me.counted.Name = "counted"
        Me.counted.Size = New System.Drawing.Size(184, 32)
        Me.counted.TabIndex = 15
        Me.counted.Text = "8711252017358"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Counted"
        '
        'NewSticker
        '
        Me.NewSticker.BackColor = System.Drawing.Color.Black
        Me.NewSticker.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSticker.ForeColor = System.Drawing.Color.White
        Me.NewSticker.Location = New System.Drawing.Point(7, 122)
        Me.NewSticker.Name = "NewSticker"
        Me.NewSticker.Size = New System.Drawing.Size(64, 41)
        Me.NewSticker.TabIndex = 16
        Me.NewSticker.Text = "New!"
        Me.NewSticker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalboxes
        '
        Me.totalboxes.Location = New System.Drawing.Point(6, 255)
        Me.totalboxes.Name = "totalboxes"
        Me.totalboxes.Size = New System.Drawing.Size(75, 23)
        Me.totalboxes.TabIndex = 17
        Me.totalboxes.Text = "Total"
        Me.totalboxes.UseVisualStyleBackColor = True
        '
        'totalcounted
        '
        Me.totalcounted.Location = New System.Drawing.Point(6, 283)
        Me.totalcounted.Name = "totalcounted"
        Me.totalcounted.Size = New System.Drawing.Size(75, 23)
        Me.totalcounted.TabIndex = 18
        Me.totalcounted.Text = "Counted"
        Me.totalcounted.UseVisualStyleBackColor = True
        '
        'Delivery
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.GunStockCheck.My.Resources.Resources.BackgroundGreen
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.totalcounted)
        Me.Controls.Add(Me.totalboxes)
        Me.Controls.Add(Me.NewSticker)
        Me.Controls.Add(Me.counted)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.boxcount)
        Me.Controls.Add(Me.boxvalue)
        Me.Controls.Add(Me.page)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.barcode)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Delivery"
        Me.Text = "Delivery"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetButton As Label
    Friend WithEvents Title As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents barcode As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents page As Label
    Friend WithEvents boxvalue As Label
    Friend WithEvents boxcount As Label
    Friend WithEvents counted As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NewSticker As Label
    Friend WithEvents totalboxes As Button
    Friend WithEvents totalcounted As Button
End Class
