<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.code = New System.Windows.Forms.TextBox()
        Me.scan = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StockLevel = New System.Windows.Forms.Label()
        Me.RetailPrice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.packet = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sku = New System.Windows.Forms.Label()
        Me.shorttitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 31)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Checker"
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(13, 39)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(41, 25)
        Me.code.TabIndex = 2
        '
        'scan
        '
        Me.scan.Location = New System.Drawing.Point(36, 59)
        Me.scan.Name = "scan"
        Me.scan.Size = New System.Drawing.Size(41, 23)
        Me.scan.TabIndex = 3
        Me.scan.Text = "Button1"
        Me.scan.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.title.Location = New System.Drawing.Point(12, 102)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(296, 78)
        Me.title.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(0, 184)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 2)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Stock Level:"
        '
        'StockLevel
        '
        Me.StockLevel.AutoSize = True
        Me.StockLevel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockLevel.Location = New System.Drawing.Point(155, 204)
        Me.StockLevel.Name = "StockLevel"
        Me.StockLevel.Size = New System.Drawing.Size(0, 21)
        Me.StockLevel.TabIndex = 7
        '
        'RetailPrice
        '
        Me.RetailPrice.AutoSize = True
        Me.RetailPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailPrice.Location = New System.Drawing.Point(155, 225)
        Me.RetailPrice.Name = "RetailPrice"
        Me.RetailPrice.Size = New System.Drawing.Size(0, 21)
        Me.RetailPrice.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Retail Price:"
        '
        'packet
        '
        Me.packet.AutoSize = True
        Me.packet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.packet.Location = New System.Drawing.Point(155, 246)
        Me.packet.Name = "packet"
        Me.packet.Size = New System.Drawing.Size(0, 21)
        Me.packet.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Packaging:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "SKU:"
        '
        'sku
        '
        Me.sku.AutoSize = True
        Me.sku.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sku.Location = New System.Drawing.Point(155, 267)
        Me.sku.Name = "sku"
        Me.sku.Size = New System.Drawing.Size(0, 21)
        Me.sku.TabIndex = 13
        '
        'shorttitle
        '
        Me.shorttitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shorttitle.Location = New System.Drawing.Point(83, 39)
        Me.shorttitle.Name = "shorttitle"
        Me.shorttitle.Size = New System.Drawing.Size(225, 59)
        Me.shorttitle.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GunStockCheck.My.Resources.Resources.logoicon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(14, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 59)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.scan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.shorttitle)
        Me.Controls.Add(Me.sku)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.packet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RetailPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StockLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.scan)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "WHL Stock checker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents code As TextBox
    Friend WithEvents scan As Button
    Friend WithEvents title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents StockLevel As Label
    Friend WithEvents RetailPrice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents packet As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents sku As Label
    Friend WithEvents shorttitle As Label
    Friend WithEvents Button1 As Button
End Class
