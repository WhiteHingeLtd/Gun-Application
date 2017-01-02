<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemActioner
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Execute = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.shortsku = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.shelf = New System.Windows.Forms.Label()
        Me.labelshort = New System.Windows.Forms.Label()
        Me.Action = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Export = New System.Windows.Forms.Button()
        Me.Area = New System.Windows.Forms.Label()
        Me.Priority = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Title.Size = New System.Drawing.Size(153, 30)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Item Action-er"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "This app lets you give actions to items in the warehouse, then export the lot as " &
    "a CSV to Steve's Desktop." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SearchBox
        '
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(12, 100)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(202, 36)
        Me.SearchBox.TabIndex = 4
        '
        'Execute
        '
        Me.Execute.Location = New System.Drawing.Point(214, 99)
        Me.Execute.Name = "Execute"
        Me.Execute.Size = New System.Drawing.Size(94, 38)
        Me.Execute.TabIndex = 5
        Me.Execute.Text = "Lookup"
        Me.Execute.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.shortsku)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 142)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(296, 51)
        Me.Panel3.TabIndex = 6
        '
        'shortsku
        '
        Me.shortsku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shortsku.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortsku.Location = New System.Drawing.Point(150, 0)
        Me.shortsku.Name = "shortsku"
        Me.shortsku.Size = New System.Drawing.Size(144, 49)
        Me.shortsku.TabIndex = 1
        Me.shortsku.Text = "1001000"
        Me.shortsku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.shelf)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 49)
        Me.Panel4.TabIndex = 0
        '
        'shelf
        '
        Me.shelf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shelf.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelf.Location = New System.Drawing.Point(0, 0)
        Me.shelf.Name = "shelf"
        Me.shelf.Size = New System.Drawing.Size(150, 49)
        Me.shelf.TabIndex = 7
        Me.shelf.Text = "A00-00"
        Me.shelf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelshort
        '
        Me.labelshort.BackColor = System.Drawing.Color.White
        Me.labelshort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelshort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelshort.Location = New System.Drawing.Point(12, 192)
        Me.labelshort.Name = "labelshort"
        Me.labelshort.Size = New System.Drawing.Size(296, 48)
        Me.labelshort.TabIndex = 7
        Me.labelshort.Text = "ROSSETTE & PLATE SOLID BRASS TIE BACK"
        Me.labelshort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelshort.UseMnemonic = False
        '
        'Action
        '
        Me.Action.BackColor = System.Drawing.Color.White
        Me.Action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Action.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Action.Location = New System.Drawing.Point(12, 239)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(143, 31)
        Me.Action.TabIndex = 8
        Me.Action.Text = "1. BARCODE"
        Me.Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Action.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 47)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Press F1-F7 for the actions. Press F8 to indicate priority" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Export
        '
        Me.Export.Location = New System.Drawing.Point(195, 269)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(114, 39)
        Me.Export.TabIndex = 10
        Me.Export.Text = "Export"
        Me.Export.UseVisualStyleBackColor = True
        '
        'Area
        '
        Me.Area.BackColor = System.Drawing.Color.White
        Me.Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Area.Location = New System.Drawing.Point(153, 239)
        Me.Area.Name = "Area"
        Me.Area.Size = New System.Drawing.Size(155, 31)
        Me.Area.TabIndex = 11
        Me.Area.Text = "Thomas"
        Me.Area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Area.UseMnemonic = False
        '
        'Priority
        '
        Me.Priority.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Priority.AutoSize = True
        Me.Priority.BackColor = System.Drawing.Color.White
        Me.Priority.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Priority.Location = New System.Drawing.Point(284, 248)
        Me.Priority.Name = "Priority"
        Me.Priority.Size = New System.Drawing.Size(15, 14)
        Me.Priority.TabIndex = 12
        Me.Priority.UseVisualStyleBackColor = False
        '
        'ItemActioner
        '
        Me.AcceptButton = Me.Execute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GunStockCheck.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Priority)
        Me.Controls.Add(Me.Area)
        Me.Controls.Add(Me.Action)
        Me.Controls.Add(Me.labelshort)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Execute)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ItemActioner"
        Me.Text = "ItemActioner"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetButton As Label
    Friend WithEvents Title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Execute As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents shortsku As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents shelf As Label
    Friend WithEvents labelshort As Label
    Friend WithEvents Action As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Export As Button
    Friend WithEvents Area As Label
    Friend WithEvents Priority As CheckBox
End Class
