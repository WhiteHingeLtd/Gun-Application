<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.QuitButton = New WHLClasses.Controls.CoolButton()
        Me.RestartButton = New WHLClasses.Controls.CoolButton()
        Me.Scanbox = New System.Windows.Forms.TextBox()
        Me.ScanButton = New WHLClasses.Controls.CoolButton()
        Me.LocationPanel = New System.Windows.Forms.Panel()
        Me.RemoveAllButton = New WHLClasses.Controls.CoolButton()
        Me.ItemsInLocationLabel = New System.Windows.Forms.Label()
        Me.ItemsInLocation = New System.Windows.Forms.ListBox()
        Me.ItemPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PackByHint = New System.Windows.Forms.Label()
        Me.ItemTitle = New System.Windows.Forms.Label()
        Me.LocationsLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WeeksWorthLabel = New System.Windows.Forms.Label()
        Me.PackByLabel = New System.Windows.Forms.Label()
        Me.PrepackLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ScanBoxProxyButton = New WHLClasses.Controls.CoolButton()
        Me.ShelfMenuButton = New WHLClasses.Controls.CoolButton()
        Me.PrintLabelButton = New WHLClasses.Controls.CoolButton()
        Me.ChangePrepackButton = New WHLClasses.Controls.CoolButton()
        Me.InstructBox = New System.Windows.Forms.Label()
        Me._90MinRestart = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateLocationsWorker = New System.ComponentModel.BackgroundWorker()
        Me.WorkerSku = New System.Windows.Forms.Label()
        Me.LocationPanel.SuspendLayout()
        Me.ItemPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuitButton.BackColor = System.Drawing.Color.Black
        Me.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Location = New System.Drawing.Point(272, 3)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(47, 23)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "QUIT"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'RestartButton
        '
        Me.RestartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestartButton.BackColor = System.Drawing.Color.Black
        Me.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RestartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestartButton.Location = New System.Drawing.Point(197, 3)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(72, 23)
        Me.RestartButton.TabIndex = 2
        Me.RestartButton.Text = "RESTART"
        Me.RestartButton.UseVisualStyleBackColor = False
        '
        'Scanbox
        '
        Me.Scanbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Scanbox.BackColor = System.Drawing.Color.Black
        Me.Scanbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scanbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scanbox.ForeColor = System.Drawing.Color.White
        Me.Scanbox.Location = New System.Drawing.Point(2, 3)
        Me.Scanbox.Name = "Scanbox"
        Me.Scanbox.Size = New System.Drawing.Size(154, 23)
        Me.Scanbox.TabIndex = 0
        '
        'ScanButton
        '
        Me.ScanButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanButton.BackColor = System.Drawing.Color.Black
        Me.ScanButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ScanButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ScanButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ScanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScanButton.Location = New System.Drawing.Point(158, 3)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(36, 23)
        Me.ScanButton.TabIndex = 1
        Me.ScanButton.Text = "GO"
        Me.ScanButton.UseVisualStyleBackColor = False
        '
        'LocationPanel
        '
        Me.LocationPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LocationPanel.Controls.Add(Me.RemoveAllButton)
        Me.LocationPanel.Controls.Add(Me.ItemsInLocationLabel)
        Me.LocationPanel.Controls.Add(Me.ItemsInLocation)
        Me.LocationPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationPanel.Location = New System.Drawing.Point(2, 55)
        Me.LocationPanel.Name = "LocationPanel"
        Me.LocationPanel.Size = New System.Drawing.Size(317, 265)
        Me.LocationPanel.TabIndex = 4
        Me.LocationPanel.Visible = False
        '
        'RemoveAllButton
        '
        Me.RemoveAllButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.RemoveAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.RemoveAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.RemoveAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveAllButton.Location = New System.Drawing.Point(167, 4)
        Me.RemoveAllButton.Name = "RemoveAllButton"
        Me.RemoveAllButton.Size = New System.Drawing.Size(150, 30)
        Me.RemoveAllButton.TabIndex = 80
        Me.RemoveAllButton.Text = "Remove All"
        Me.RemoveAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveAllButton.UseVisualStyleBackColor = True
        '
        'ItemsInLocationLabel
        '
        Me.ItemsInLocationLabel.AutoSize = True
        Me.ItemsInLocationLabel.Location = New System.Drawing.Point(8, 11)
        Me.ItemsInLocationLabel.Name = "ItemsInLocationLabel"
        Me.ItemsInLocationLabel.Size = New System.Drawing.Size(132, 18)
        Me.ItemsInLocationLabel.TabIndex = 1
        Me.ItemsInLocationLabel.Text = "Items At Yorke 000"
        '
        'ItemsInLocation
        '
        Me.ItemsInLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsInLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ItemsInLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemsInLocation.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsInLocation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ItemsInLocation.FormattingEnabled = True
        Me.ItemsInLocation.ItemHeight = 18
        Me.ItemsInLocation.Items.AddRange(New Object() {"1234567890123456789012345678901234567890"})
        Me.ItemsInLocation.Location = New System.Drawing.Point(4, 38)
        Me.ItemsInLocation.Name = "ItemsInLocation"
        Me.ItemsInLocation.ScrollAlwaysVisible = True
        Me.ItemsInLocation.Size = New System.Drawing.Size(310, 218)
        Me.ItemsInLocation.TabIndex = 0
        '
        'ItemPanel
        '
        Me.ItemPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemPanel.Controls.Add(Me.WorkerSku)
        Me.ItemPanel.Controls.Add(Me.Label3)
        Me.ItemPanel.Controls.Add(Me.PackByHint)
        Me.ItemPanel.Controls.Add(Me.ItemTitle)
        Me.ItemPanel.Controls.Add(Me.LocationsLabel)
        Me.ItemPanel.Controls.Add(Me.Label4)
        Me.ItemPanel.Controls.Add(Me.WeeksWorthLabel)
        Me.ItemPanel.Controls.Add(Me.PackByLabel)
        Me.ItemPanel.Controls.Add(Me.PrepackLabel)
        Me.ItemPanel.Controls.Add(Me.Label2)
        Me.ItemPanel.Controls.Add(Me.ScanBoxProxyButton)
        Me.ItemPanel.Controls.Add(Me.ShelfMenuButton)
        Me.ItemPanel.Controls.Add(Me.PrintLabelButton)
        Me.ItemPanel.Controls.Add(Me.ChangePrepackButton)
        Me.ItemPanel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemPanel.Location = New System.Drawing.Point(2, 55)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Size = New System.Drawing.Size(317, 265)
        Me.ItemPanel.TabIndex = 4
        Me.ItemPanel.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(159, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Weeks Worth"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PackByHint
        '
        Me.PackByHint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PackByHint.BackColor = System.Drawing.Color.White
        Me.PackByHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PackByHint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackByHint.ForeColor = System.Drawing.Color.Black
        Me.PackByHint.Location = New System.Drawing.Point(0, 86)
        Me.PackByHint.Name = "PackByHint"
        Me.PackByHint.Size = New System.Drawing.Size(158, 20)
        Me.PackByHint.TabIndex = 10
        Me.PackByHint.Text = "Pack By (Now )"
        Me.PackByHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemTitle
        '
        Me.ItemTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemTitle.Location = New System.Drawing.Point(0, 0)
        Me.ItemTitle.Name = "ItemTitle"
        Me.ItemTitle.Size = New System.Drawing.Size(317, 46)
        Me.ItemTitle.TabIndex = 0
        Me.ItemTitle.Text = "Label1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Label2"
        Me.ItemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ItemTitle.UseMnemonic = False
        '
        'LocationsLabel
        '
        Me.LocationsLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LocationsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LocationsLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationsLabel.Location = New System.Drawing.Point(121, 135)
        Me.LocationsLabel.Name = "LocationsLabel"
        Me.LocationsLabel.Size = New System.Drawing.Size(196, 20)
        Me.LocationsLabel.TabIndex = 15
        Me.LocationsLabel.Text = "LocationsLabel"
        Me.LocationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Locations"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WeeksWorthLabel
        '
        Me.WeeksWorthLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WeeksWorthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeeksWorthLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeeksWorthLabel.Location = New System.Drawing.Point(159, 33)
        Me.WeeksWorthLabel.Name = "WeeksWorthLabel"
        Me.WeeksWorthLabel.Size = New System.Drawing.Size(158, 57)
        Me.WeeksWorthLabel.TabIndex = 13
        Me.WeeksWorthLabel.Text = "000"
        Me.WeeksWorthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PackByLabel
        '
        Me.PackByLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PackByLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PackByLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackByLabel.Location = New System.Drawing.Point(0, 33)
        Me.PackByLabel.Name = "PackByLabel"
        Me.PackByLabel.Size = New System.Drawing.Size(158, 57)
        Me.PackByLabel.TabIndex = 11
        Me.PackByLabel.Text = "000"
        Me.PackByLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PrepackLabel
        '
        Me.PrepackLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrepackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrepackLabel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrepackLabel.Location = New System.Drawing.Point(121, 106)
        Me.PrepackLabel.Name = "PrepackLabel"
        Me.PrepackLabel.Size = New System.Drawing.Size(196, 29)
        Me.PrepackLabel.TabIndex = 9
        Me.PrepackLabel.Text = "PrepackLabel"
        Me.PrepackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Prepack"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ScanBoxProxyButton
        '
        Me.ScanBoxProxyButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanBoxProxyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ScanBoxProxyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ScanBoxProxyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ScanBoxProxyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScanBoxProxyButton.Location = New System.Drawing.Point(10, 265)
        Me.ScanBoxProxyButton.Name = "ScanBoxProxyButton"
        Me.ScanBoxProxyButton.Size = New System.Drawing.Size(296, 30)
        Me.ScanBoxProxyButton.TabIndex = 7
        Me.ScanBoxProxyButton.Text = "Print Label"
        Me.ScanBoxProxyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ScanBoxProxyButton.UseVisualStyleBackColor = True
        '
        'ShelfMenuButton
        '
        Me.ShelfMenuButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShelfMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ShelfMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ShelfMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ShelfMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShelfMenuButton.Location = New System.Drawing.Point(20, 195)
        Me.ShelfMenuButton.Name = "ShelfMenuButton"
        Me.ShelfMenuButton.Size = New System.Drawing.Size(296, 30)
        Me.ShelfMenuButton.TabIndex = 5
        Me.ShelfMenuButton.Text = "Shelf..."
        Me.ShelfMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShelfMenuButton.UseVisualStyleBackColor = True
        '
        'PrintLabelButton
        '
        Me.PrintLabelButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintLabelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PrintLabelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PrintLabelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PrintLabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintLabelButton.Location = New System.Drawing.Point(20, 160)
        Me.PrintLabelButton.Name = "PrintLabelButton"
        Me.PrintLabelButton.Size = New System.Drawing.Size(296, 30)
        Me.PrintLabelButton.TabIndex = 4
        Me.PrintLabelButton.Text = "Print Label"
        Me.PrintLabelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintLabelButton.UseVisualStyleBackColor = True
        '
        'ChangePrepackButton
        '
        Me.ChangePrepackButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangePrepackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ChangePrepackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ChangePrepackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ChangePrepackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePrepackButton.Location = New System.Drawing.Point(20, 230)
        Me.ChangePrepackButton.Name = "ChangePrepackButton"
        Me.ChangePrepackButton.Size = New System.Drawing.Size(296, 30)
        Me.ChangePrepackButton.TabIndex = 6
        Me.ChangePrepackButton.Text = "Change Prepack"
        Me.ChangePrepackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangePrepackButton.UseVisualStyleBackColor = True
        '
        'InstructBox
        '
        Me.InstructBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstructBox.BackColor = System.Drawing.Color.Gainsboro
        Me.InstructBox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructBox.ForeColor = System.Drawing.Color.Red
        Me.InstructBox.Location = New System.Drawing.Point(2, 29)
        Me.InstructBox.Name = "InstructBox"
        Me.InstructBox.Size = New System.Drawing.Size(317, 23)
        Me.InstructBox.TabIndex = 5
        Me.InstructBox.Text = "Scan User ID"
        Me.InstructBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_90MinRestart
        '
        Me._90MinRestart.Interval = 5400000
        '
        'UpdateLocationsWorker
        '
        Me.UpdateLocationsWorker.WorkerReportsProgress = True
        Me.UpdateLocationsWorker.WorkerSupportsCancellation = True
        '
        'WorkerSku
        '
        Me.WorkerSku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkerSku.Location = New System.Drawing.Point(4, 160)
        Me.WorkerSku.Name = "WorkerSku"
        Me.WorkerSku.Size = New System.Drawing.Size(10, 97)
        Me.WorkerSku.TabIndex = 16
        Me.WorkerSku.Text = "1005630"
        '
        'Main
        '
        Me.AcceptButton = Me.ScanButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.ItemPanel)
        Me.Controls.Add(Me.InstructBox)
        Me.Controls.Add(Me.LocationPanel)
        Me.Controls.Add(Me.ScanButton)
        Me.Controls.Add(Me.Scanbox)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.QuitButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.LocationPanel.ResumeLayout(False)
        Me.LocationPanel.PerformLayout()
        Me.ItemPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuitButton As WHLClasses.Controls.CoolButton
    Friend WithEvents RestartButton As WHLClasses.Controls.CoolButton
    Friend WithEvents Scanbox As TextBox
    Friend WithEvents ScanButton As WHLClasses.Controls.CoolButton
    Friend WithEvents LocationPanel As Panel
    Friend WithEvents InstructBox As Label
    Friend WithEvents ItemsInLocationLabel As Label
    Friend WithEvents ItemsInLocation As ListBox
    Friend WithEvents ItemPanel As Panel
    Friend WithEvents ItemTitle As Label
    Friend WithEvents ShelfMenuButton As WHLClasses.Controls.CoolButton
    Friend WithEvents PrintLabelButton As WHLClasses.Controls.CoolButton
    Friend WithEvents ChangePrepackButton As WHLClasses.Controls.CoolButton
    Friend WithEvents ScanBoxProxyButton As WHLClasses.Controls.CoolButton
    Friend WithEvents PackByLabel As Label
    Friend WithEvents PackByHint As Label
    Friend WithEvents PrepackLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LocationsLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WeeksWorthLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RemoveAllButton As WHLClasses.Controls.CoolButton
    Friend WithEvents _90MinRestart As Timer
    Friend WithEvents WorkerSku As Label
    Friend WithEvents UpdateLocationsWorker As System.ComponentModel.BackgroundWorker
End Class
