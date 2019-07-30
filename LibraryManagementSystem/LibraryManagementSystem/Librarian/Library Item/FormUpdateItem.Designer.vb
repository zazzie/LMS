<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.btnEditQuantity = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveQuantity = New System.Windows.Forms.Button()
        Me.btnAddQuantity = New System.Windows.Forms.Button()
        Me.dgvItemQuantity = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bntUploadPhoto = New System.Windows.Forms.Button()
        Me.pictItem = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnItemType = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbItemDescription = New System.Windows.Forms.RichTextBox()
        Me.cboBorrowType = New System.Windows.Forms.ComboBox()
        Me.cboItemType = New System.Windows.Forms.ComboBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtMaxDuration = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.lblMaxDuration = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        CType(Me.dgvItemQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.pictItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItem.Image = CType(resources.GetObject("btnUpdateItem.Image"), System.Drawing.Image)
        Me.btnUpdateItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateItem.Location = New System.Drawing.Point(616, 639)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(171, 26)
        Me.btnUpdateItem.TabIndex = 425
        Me.btnUpdateItem.Text = "Confirm Update"
        Me.btnUpdateItem.UseVisualStyleBackColor = False
        '
        'btnEditQuantity
        '
        Me.btnEditQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditQuantity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditQuantity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditQuantity.Location = New System.Drawing.Point(708, 67)
        Me.btnEditQuantity.Name = "btnEditQuantity"
        Me.btnEditQuantity.Size = New System.Drawing.Size(146, 26)
        Me.btnEditQuantity.TabIndex = 464
        Me.btnEditQuantity.Text = "Edit Unit"
        Me.btnEditQuantity.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 463
        Me.Label1.Text = "Unit Description"
        '
        'btnRemoveQuantity
        '
        Me.btnRemoveQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveQuantity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveQuantity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveQuantity.Location = New System.Drawing.Point(708, 102)
        Me.btnRemoveQuantity.Name = "btnRemoveQuantity"
        Me.btnRemoveQuantity.Size = New System.Drawing.Size(146, 26)
        Me.btnRemoveQuantity.TabIndex = 462
        Me.btnRemoveQuantity.Text = "Remove"
        Me.btnRemoveQuantity.UseVisualStyleBackColor = False
        '
        'btnAddQuantity
        '
        Me.btnAddQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddQuantity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQuantity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddQuantity.Location = New System.Drawing.Point(708, 32)
        Me.btnAddQuantity.Name = "btnAddQuantity"
        Me.btnAddQuantity.Size = New System.Drawing.Size(146, 26)
        Me.btnAddQuantity.TabIndex = 461
        Me.btnAddQuantity.Text = "Add New Unit"
        Me.btnAddQuantity.UseVisualStyleBackColor = False
        '
        'dgvItemQuantity
        '
        Me.dgvItemQuantity.AllowUserToAddRows = False
        Me.dgvItemQuantity.AllowUserToDeleteRows = False
        Me.dgvItemQuantity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemQuantity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemQuantity.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvItemQuantity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvItemQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemQuantity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column7, Me.Column6, Me.Column5})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemQuantity.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemQuantity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItemQuantity.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvItemQuantity.Location = New System.Drawing.Point(13, 32)
        Me.dgvItemQuantity.MultiSelect = False
        Me.dgvItemQuantity.Name = "dgvItemQuantity"
        Me.dgvItemQuantity.ReadOnly = True
        Me.dgvItemQuantity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemQuantity.Size = New System.Drawing.Size(689, 139)
        Me.dgvItemQuantity.TabIndex = 316
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Aqusition"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Price"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date Added"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.bntUploadPhoto)
        Me.Panel4.Controls.Add(Me.pictItem)
        Me.Panel4.Location = New System.Drawing.Point(504, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(377, 348)
        Me.Panel4.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(144, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 465
        Me.Label4.Text = "Book Photo"
        '
        'bntUploadPhoto
        '
        Me.bntUploadPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bntUploadPhoto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bntUploadPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.bntUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntUploadPhoto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntUploadPhoto.Location = New System.Drawing.Point(119, 307)
        Me.bntUploadPhoto.Name = "bntUploadPhoto"
        Me.bntUploadPhoto.Size = New System.Drawing.Size(157, 26)
        Me.bntUploadPhoto.TabIndex = 403
        Me.bntUploadPhoto.Text = "Upload Photo"
        Me.bntUploadPhoto.UseVisualStyleBackColor = False
        '
        'pictItem
        '
        Me.pictItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pictItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pictItem.BackgroundImage = CType(resources.GetObject("pictItem.BackgroundImage"), System.Drawing.Image)
        Me.pictItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictItem.ErrorImage = Nothing
        Me.pictItem.Location = New System.Drawing.Point(74, 49)
        Me.pictItem.Name = "pictItem"
        Me.pictItem.Size = New System.Drawing.Size(235, 252)
        Me.pictItem.TabIndex = 1
        Me.pictItem.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(934, 37)
        Me.Panel6.TabIndex = 423
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(11, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 19)
        Me.Label10.TabIndex = 214
        Me.Label10.Text = "        Update Library Item"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(891, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnEditQuantity)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.btnRemoveQuantity)
        Me.Panel5.Controls.Add(Me.btnAddQuantity)
        Me.Panel5.Controls.Add(Me.dgvItemQuantity)
        Me.Panel5.Location = New System.Drawing.Point(14, 372)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(867, 189)
        Me.Panel5.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(793, 638)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 27)
        Me.btnCancel.TabIndex = 424
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(16, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 580)
        Me.Panel1.TabIndex = 422
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnItemType)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.rtbItemDescription)
        Me.Panel2.Controls.Add(Me.cboBorrowType)
        Me.Panel2.Controls.Add(Me.cboItemType)
        Me.Panel2.Controls.Add(Me.lblDays)
        Me.Panel2.Controls.Add(Me.txtMaxDuration)
        Me.Panel2.Controls.Add(Me.txtItemName)
        Me.Panel2.Controls.Add(Me.txtItemId)
        Me.Panel2.Controls.Add(Me.lblMaxDuration)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Location = New System.Drawing.Point(14, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 348)
        Me.Panel2.TabIndex = 0
        '
        'btnItemType
        '
        Me.btnItemType.BackColor = System.Drawing.Color.Maroon
        Me.btnItemType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnItemType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnItemType.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnItemType.Location = New System.Drawing.Point(428, 108)
        Me.btnItemType.Name = "btnItemType"
        Me.btnItemType.Size = New System.Drawing.Size(31, 23)
        Me.btnItemType.TabIndex = 415
        Me.btnItemType.Text = "..."
        Me.btnItemType.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(101, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 465
        Me.Label3.Text = "Item Information"
        '
        'rtbItemDescription
        '
        Me.rtbItemDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rtbItemDescription.Location = New System.Drawing.Point(102, 199)
        Me.rtbItemDescription.Name = "rtbItemDescription"
        Me.rtbItemDescription.Size = New System.Drawing.Size(320, 130)
        Me.rtbItemDescription.TabIndex = 454
        Me.rtbItemDescription.Text = ""
        '
        'cboBorrowType
        '
        Me.cboBorrowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorrowType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBorrowType.FormattingEnabled = True
        Me.cboBorrowType.Items.AddRange(New Object() {"FOR INSIDE USE ONLY", "FOR INSIDE AND OUTSIDE USE"})
        Me.cboBorrowType.Location = New System.Drawing.Point(103, 139)
        Me.cboBorrowType.Name = "cboBorrowType"
        Me.cboBorrowType.Size = New System.Drawing.Size(319, 23)
        Me.cboBorrowType.TabIndex = 453
        '
        'cboItemType
        '
        Me.cboItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemType.FormattingEnabled = True
        Me.cboItemType.Location = New System.Drawing.Point(103, 109)
        Me.cboItemType.Name = "cboItemType"
        Me.cboItemType.Size = New System.Drawing.Size(319, 23)
        Me.cboItemType.TabIndex = 408
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.BackColor = System.Drawing.Color.Transparent
        Me.lblDays.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.ForeColor = System.Drawing.Color.Black
        Me.lblDays.Location = New System.Drawing.Point(428, 172)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(49, 15)
        Me.lblDays.TabIndex = 448
        Me.lblDays.Text = "Day(s)"
        '
        'txtMaxDuration
        '
        Me.txtMaxDuration.BackColor = System.Drawing.Color.White
        Me.txtMaxDuration.Enabled = False
        Me.txtMaxDuration.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxDuration.Location = New System.Drawing.Point(103, 169)
        Me.txtMaxDuration.MaxLength = 10
        Me.txtMaxDuration.Name = "txtMaxDuration"
        Me.txtMaxDuration.Size = New System.Drawing.Size(319, 23)
        Me.txtMaxDuration.TabIndex = 445
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.White
        Me.txtItemName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(104, 79)
        Me.txtItemName.MaxLength = 256
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(318, 23)
        Me.txtItemName.TabIndex = 438
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.Color.White
        Me.txtItemId.Enabled = False
        Me.txtItemId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemId.Location = New System.Drawing.Point(104, 49)
        Me.txtItemId.MaxLength = 10
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(179, 23)
        Me.txtItemId.TabIndex = 437
        '
        'lblMaxDuration
        '
        Me.lblMaxDuration.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxDuration.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDuration.ForeColor = System.Drawing.Color.Black
        Me.lblMaxDuration.Location = New System.Drawing.Point(6, 166)
        Me.lblMaxDuration.Name = "lblMaxDuration"
        Me.lblMaxDuration.Size = New System.Drawing.Size(91, 32)
        Me.lblMaxDuration.TabIndex = 434
        Me.lblMaxDuration.Text = "Max Borrow Duration"
        Me.lblMaxDuration.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 430
        Me.Label5.Text = "Borrow Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 428
        Me.Label8.Text = "Description"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(44, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 15)
        Me.Label18.TabIndex = 425
        Me.Label18.Text = "Item ID"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(20, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 15)
        Me.Label22.TabIndex = 423
        Me.Label22.Text = "Item Name"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(27, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 15)
        Me.Label23.TabIndex = 422
        Me.Label23.Text = "Item Type"
        '
        'FormUpdateItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 672)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUpdateItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateItem"
        CType(Me.dgvItemQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pictItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdateItem As System.Windows.Forms.Button
    Friend WithEvents btnEditQuantity As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveQuantity As System.Windows.Forms.Button
    Friend WithEvents btnAddQuantity As System.Windows.Forms.Button
    Friend WithEvents dgvItemQuantity As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bntUploadPhoto As System.Windows.Forms.Button
    Friend WithEvents pictItem As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnItemType As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbItemDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents cboBorrowType As System.Windows.Forms.ComboBox
    Friend WithEvents cboItemType As System.Windows.Forms.ComboBox
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents txtMaxDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxDuration As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
