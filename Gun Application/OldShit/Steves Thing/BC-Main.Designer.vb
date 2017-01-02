<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BC_Main
    Inherits GunStockCheck.TemplateForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScanBox = New System.Windows.Forms.TextBox()
        Me.ScanButton = New System.Windows.Forms.Button()
        Me.LabelShort = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SKUStock = New System.Windows.Forms.Label()
        Me.ResultIncorrect = New System.Windows.Forms.Button()
        Me.ResultCorrect = New System.Windows.Forms.Button()
        Me.Comment = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BarcodeChecky"
        '
        'ScanBox
        '
        Me.ScanBox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanBox.Location = New System.Drawing.Point(12, 53)
        Me.ScanBox.Name = "ScanBox"
        Me.ScanBox.Size = New System.Drawing.Size(194, 27)
        Me.ScanBox.TabIndex = 3
        '
        'ScanButton
        '
        Me.ScanButton.Location = New System.Drawing.Point(212, 53)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(96, 27)
        Me.ScanButton.TabIndex = 4
        Me.ScanButton.Text = "Scan"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'LabelShort
        '
        Me.LabelShort.BackColor = System.Drawing.Color.White
        Me.LabelShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelShort.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShort.Location = New System.Drawing.Point(12, 87)
        Me.LabelShort.Name = "LabelShort"
        Me.LabelShort.Size = New System.Drawing.Size(296, 39)
        Me.LabelShort.TabIndex = 5
        Me.LabelShort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Stock:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SKUStock
        '
        Me.SKUStock.AutoSize = True
        Me.SKUStock.BackColor = System.Drawing.Color.White
        Me.SKUStock.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SKUStock.Location = New System.Drawing.Point(68, 126)
        Me.SKUStock.Name = "SKUStock"
        Me.SKUStock.Size = New System.Drawing.Size(65, 20)
        Me.SKUStock.TabIndex = 7
        Me.SKUStock.Text = "1520+-1"
        '
        'ResultIncorrect
        '
        Me.ResultIncorrect.Enabled = False
        Me.ResultIncorrect.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultIncorrect.Location = New System.Drawing.Point(12, 153)
        Me.ResultIncorrect.Name = "ResultIncorrect"
        Me.ResultIncorrect.Size = New System.Drawing.Size(144, 42)
        Me.ResultIncorrect.TabIndex = 8
        Me.ResultIncorrect.Text = "✘ Incorrect"
        Me.ResultIncorrect.UseVisualStyleBackColor = True
        '
        'ResultCorrect
        '
        Me.ResultCorrect.Enabled = False
        Me.ResultCorrect.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultCorrect.Location = New System.Drawing.Point(164, 153)
        Me.ResultCorrect.Name = "ResultCorrect"
        Me.ResultCorrect.Size = New System.Drawing.Size(144, 42)
        Me.ResultCorrect.TabIndex = 9
        Me.ResultCorrect.Text = "✔️ Correct"
        Me.ResultCorrect.UseVisualStyleBackColor = True
        '
        'Comment
        '
        Me.Comment.Location = New System.Drawing.Point(13, 257)
        Me.Comment.Name = "Comment"
        Me.Comment.Padding = New System.Windows.Forms.Padding(3)
        Me.Comment.Size = New System.Drawing.Size(295, 51)
        Me.Comment.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(164, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "👍 Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BC_Main
        '
        Me.AcceptButton = Me.ScanButton
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.ResultCorrect)
        Me.Controls.Add(Me.ResultIncorrect)
        Me.Controls.Add(Me.SKUStock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelShort)
        Me.Controls.Add(Me.ScanButton)
        Me.Controls.Add(Me.ScanBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BC_Main"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ScanBox, 0)
        Me.Controls.SetChildIndex(Me.ScanButton, 0)
        Me.Controls.SetChildIndex(Me.LabelShort, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.SKUStock, 0)
        Me.Controls.SetChildIndex(Me.ResultIncorrect, 0)
        Me.Controls.SetChildIndex(Me.ResultCorrect, 0)
        Me.Controls.SetChildIndex(Me.Comment, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ScanBox As TextBox
    Friend WithEvents ScanButton As Button
    Friend WithEvents LabelShort As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SKUStock As Label
    Friend WithEvents ResultCorrect As Button
    Friend WithEvents ResultIncorrect As Button
    Friend WithEvents Comment As Label
    Friend WithEvents Button1 As Button
End Class
