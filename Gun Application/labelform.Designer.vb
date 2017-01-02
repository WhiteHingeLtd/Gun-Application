<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class magnetlabel
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
        Me.components = New System.ComponentModel.Container()
        Me.barcode = New Spire.Barcode.Forms.BarCodeControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.shortsku = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.shelftitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datebox = New System.Windows.Forms.Label()
        Me.suppcode = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.shelfno = New System.Windows.Forms.Label()
        Me.shelfbg = New System.Windows.Forms.Panel()
        Me.main = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.shelfbg.SuspendLayout()
        Me.main.SuspendLayout()
        Me.SuspendLayout()
        '
        'barcode
        '
        Me.barcode.BarHeight = 20.0!
        Me.barcode.BorderWidth = 0!
        Me.barcode.BottomMargin = 0!
        Me.barcode.Data = "1001066"
        Me.barcode.Data2D = "1001066"
        Me.barcode.DpiX = 96.0!
        Me.barcode.DpiY = 96.0!
        Me.barcode.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.barcode.ImageHeight = 20.0!
        Me.barcode.ImageWidth = 450.0!
        Me.barcode.LeftMargin = 0!
        Me.barcode.Location = New System.Drawing.Point(91, 171)
        Me.barcode.Margin = New System.Windows.Forms.Padding(0)
        Me.barcode.Name = "barcode"
        Me.barcode.ResolutionType = Spire.Barcode.ResolutionType.UseDpi
        Me.barcode.RightMargin = 0!
        Me.barcode.Rotate = 0!
        Me.barcode.ShowTextOnBottom = True
        Me.barcode.Size = New System.Drawing.Size(270, 89)
        Me.barcode.SupSpace = 0!
        Me.barcode.TabIndex = 0
        Me.barcode.TextFont = New System.Drawing.Font("Arial", 8.0!)
        Me.barcode.TextMargin = 0!
        Me.barcode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel
        Me.barcode.TopMargin = 0!
        Me.barcode.TopText = ""
        Me.barcode.TopTextAligment = System.Drawing.StringAlignment.Near
        Me.barcode.TopTextFont = New System.Drawing.Font("Arial", 8.0!)
        Me.barcode.UseChecksum = Spire.Barcode.CheckSumMode.[Auto]
        Me.barcode.WideNarrowRatio = 3.0!
        Me.barcode.X = 0.9!
        Me.barcode.XYRatio = 0!
        Me.barcode.Y = 3.0!
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.shortsku)
        Me.Panel1.Location = New System.Drawing.Point(10, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 61)
        Me.Panel1.TabIndex = 2
        '
        'shortsku
        '
        Me.shortsku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shortsku.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortsku.Location = New System.Drawing.Point(0, 0)
        Me.shortsku.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.shortsku.Name = "shortsku"
        Me.shortsku.Size = New System.Drawing.Size(183, 59)
        Me.shortsku.TabIndex = 0
        Me.shortsku.Text = "1001066"
        Me.shortsku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.shelftitle)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(10, 98)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(423, 67)
        Me.Panel2.TabIndex = 3
        '
        'shelftitle
        '
        Me.shelftitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shelftitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelftitle.Location = New System.Drawing.Point(0, 0)
        Me.shelftitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.shelftitle.Name = "shelftitle"
        Me.shelftitle.Size = New System.Drawing.Size(421, 65)
        Me.shelftitle.TabIndex = 1
        Me.shelftitle.Text = "522: 4""x2.75 CHROME HINGES C8356 MORE MORE MORE"
        Me.shelftitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "01066"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datebox
        '
        Me.datebox.BackColor = System.Drawing.Color.Transparent
        Me.datebox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datebox.Location = New System.Drawing.Point(6, 9)
        Me.datebox.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.datebox.Name = "datebox"
        Me.datebox.Size = New System.Drawing.Size(143, 24)
        Me.datebox.TabIndex = 4
        Me.datebox.Text = "22/09/2015"
        Me.datebox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'suppcode
        '
        Me.suppcode.BackColor = System.Drawing.Color.Transparent
        Me.suppcode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppcode.Location = New System.Drawing.Point(207, 9)
        Me.suppcode.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.suppcode.Name = "suppcode"
        Me.suppcode.Size = New System.Drawing.Size(224, 23)
        Me.suppcode.TabIndex = 5
        Me.suppcode.Text = "C8356"
        Me.suppcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintDocument1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'shelfno
        '
        Me.shelfno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shelfno.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelfno.ForeColor = System.Drawing.Color.White
        Me.shelfno.Location = New System.Drawing.Point(0, 0)
        Me.shelfno.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.shelfno.Name = "shelfno"
        Me.shelfno.Size = New System.Drawing.Size(238, 61)
        Me.shelfno.TabIndex = 0
        Me.shelfno.Text = "A05-22"
        Me.shelfno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.shelfno.UseCompatibleTextRendering = True
        '
        'shelfbg
        '
        Me.shelfbg.BackColor = System.Drawing.Color.Black
        Me.shelfbg.Controls.Add(Me.shelfno)
        Me.shelfbg.Location = New System.Drawing.Point(195, 32)
        Me.shelfbg.Margin = New System.Windows.Forms.Padding(6)
        Me.shelfbg.Name = "shelfbg"
        Me.shelfbg.Size = New System.Drawing.Size(238, 61)
        Me.shelfbg.TabIndex = 1
        '
        'main
        '
        Me.main.Controls.Add(Me.Panel1)
        Me.main.Controls.Add(Me.barcode)
        Me.main.Controls.Add(Me.Panel2)
        Me.main.Controls.Add(Me.datebox)
        Me.main.Controls.Add(Me.suppcode)
        Me.main.Controls.Add(Me.shelfbg)
        Me.main.Location = New System.Drawing.Point(0, 0)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(439, 243)
        Me.main.TabIndex = 6
        '
        'magnetlabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 243)
        Me.Controls.Add(Me.main)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "magnetlabel"
        Me.Text = "labelform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.shelfbg.ResumeLayout(False)
        Me.main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barcode As Spire.Barcode.Forms.BarCodeControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents shortsku As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents shelftitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents suppcode As Label
    Friend WithEvents datebox As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
    Friend WithEvents shelfno As Label
    Friend WithEvents shelfbg As Panel
    Friend WithEvents main As Panel
End Class
