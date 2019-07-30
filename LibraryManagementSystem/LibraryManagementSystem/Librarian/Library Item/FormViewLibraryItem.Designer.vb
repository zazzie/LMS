<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewLibraryItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewLibraryItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.pictItemPhoto = New System.Windows.Forms.PictureBox()
        Me.pnlForPhoto = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMaxBorrowLABEL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblItemAvailability = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblItemQuantity = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        Me.lblMaxBorrow = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblitemBorrowType = New System.Windows.Forms.Label()
        Me.lblItemId = New System.Windows.Forms.Label()
        Me.lblItemType = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.linkViewItemHist = New System.Windows.Forms.LinkLabel()
        Me.dgvItemUnit = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pictItemPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForPhoto.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 49)
        Me.Panel1.TabIndex = 388
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblItemName.Location = New System.Drawing.Point(23, 15)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(77, 19)
        Me.lblItemName.TabIndex = 206
        Me.lblItemName.Text = "Item Title"
        '
        'pictItemPhoto
        '
        Me.pictItemPhoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictItemPhoto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pictItemPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictItemPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictItemPhoto.Location = New System.Drawing.Point(73, 14)
        Me.pictItemPhoto.Name = "pictItemPhoto"
        Me.pictItemPhoto.Size = New System.Drawing.Size(185, 242)
        Me.pictItemPhoto.TabIndex = 1
        Me.pictItemPhoto.TabStop = False
        '
        'pnlForPhoto
        '
        Me.pnlForPhoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlForPhoto.BackColor = System.Drawing.Color.PaleTurquoise
        Me.pnlForPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlForPhoto.Controls.Add(Me.pictItemPhoto)
        Me.pnlForPhoto.Location = New System.Drawing.Point(3, 3)
        Me.pnlForPhoto.Name = "pnlForPhoto"
        Me.pnlForPhoto.Size = New System.Drawing.Size(333, 277)
        Me.pnlForPhoto.TabIndex = 318
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.pnlForPhoto)
        Me.Panel3.Location = New System.Drawing.Point(564, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(341, 285)
        Me.Panel3.TabIndex = 390
        '
        'lblMaxBorrowLABEL
        '
        Me.lblMaxBorrowLABEL.AutoSize = True
        Me.lblMaxBorrowLABEL.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxBorrowLABEL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBorrowLABEL.ForeColor = System.Drawing.Color.Black
        Me.lblMaxBorrowLABEL.Location = New System.Drawing.Point(68, 64)
        Me.lblMaxBorrowLABEL.Name = "lblMaxBorrowLABEL"
        Me.lblMaxBorrowLABEL.Size = New System.Drawing.Size(163, 15)
        Me.lblMaxBorrowLABEL.TabIndex = 440
        Me.lblMaxBorrowLABEL.Text = "Max Borrow Duration     :"
        Me.lblMaxBorrowLABEL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(123, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 439
        Me.Label5.Text = "Borrow Type     :"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(748, 703)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(157, 26)
        Me.btnClose.TabIndex = 392
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblItemAvailability)
        Me.Panel2.Controls.Add(Me.lblMaxBorrowLABEL)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblItemQuantity)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.lblItemDescription)
        Me.Panel2.Controls.Add(Me.lblMaxBorrow)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.lblitemBorrowType)
        Me.Panel2.Controls.Add(Me.lblItemId)
        Me.Panel2.Controls.Add(Me.lblItemType)
        Me.Panel2.Location = New System.Drawing.Point(12, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 285)
        Me.Panel2.TabIndex = 389
        '
        'lblItemAvailability
        '
        Me.lblItemAvailability.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemAvailability.AutoSize = True
        Me.lblItemAvailability.BackColor = System.Drawing.Color.Transparent
        Me.lblItemAvailability.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemAvailability.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemAvailability.Location = New System.Drawing.Point(248, 98)
        Me.lblItemAvailability.Name = "lblItemAvailability"
        Me.lblItemAvailability.Size = New System.Drawing.Size(70, 16)
        Me.lblItemAvailability.TabIndex = 302
        Me.lblItemAvailability.Text = "Quantity"
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(97, 95)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(134, 16)
        Me.Label28.TabIndex = 300
        Me.Label28.Text = "Available Copy     :"
        '
        'lblItemQuantity
        '
        Me.lblItemQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemQuantity.AutoSize = True
        Me.lblItemQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblItemQuantity.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemQuantity.Location = New System.Drawing.Point(248, 82)
        Me.lblItemQuantity.Name = "lblItemQuantity"
        Me.lblItemQuantity.Size = New System.Drawing.Size(70, 16)
        Me.lblItemQuantity.TabIndex = 299
        Me.lblItemQuantity.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(125, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 16)
        Me.Label6.TabIndex = 297
        Me.Label6.Text = "Total Copy     :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(159, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 15)
        Me.Label18.TabIndex = 437
        Me.Label18.Text = "Item ID     :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(142, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 15)
        Me.Label23.TabIndex = 435
        Me.Label23.Text = "Item Type     :"
        '
        'lblItemDescription
        '
        Me.lblItemDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemDescription.AutoEllipsis = True
        Me.lblItemDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemDescription.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemDescription.Location = New System.Drawing.Point(27, 151)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(484, 120)
        Me.lblItemDescription.TabIndex = 306
        Me.lblItemDescription.Text = "Descriptions"
        '
        'lblMaxBorrow
        '
        Me.lblMaxBorrow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaxBorrow.AutoSize = True
        Me.lblMaxBorrow.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxBorrow.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBorrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMaxBorrow.Location = New System.Drawing.Point(248, 66)
        Me.lblMaxBorrow.Name = "lblMaxBorrow"
        Me.lblMaxBorrow.Size = New System.Drawing.Size(48, 16)
        Me.lblMaxBorrow.TabIndex = 305
        Me.lblMaxBorrow.Text = "0 Day"
        '
        'Label36
        '
        Me.Label36.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label36.Location = New System.Drawing.Point(24, 135)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 16)
        Me.Label36.TabIndex = 298
        Me.Label36.Text = "Description :"
        '
        'lblitemBorrowType
        '
        Me.lblitemBorrowType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblitemBorrowType.AutoSize = True
        Me.lblitemBorrowType.BackColor = System.Drawing.Color.Transparent
        Me.lblitemBorrowType.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemBorrowType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblitemBorrowType.Location = New System.Drawing.Point(248, 50)
        Me.lblitemBorrowType.Name = "lblitemBorrowType"
        Me.lblitemBorrowType.Size = New System.Drawing.Size(117, 16)
        Me.lblitemBorrowType.TabIndex = 297
        Me.lblitemBorrowType.Text = "Borrowing Type"
        '
        'lblItemId
        '
        Me.lblItemId.AutoSize = True
        Me.lblItemId.BackColor = System.Drawing.Color.Transparent
        Me.lblItemId.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemId.Location = New System.Drawing.Point(248, 18)
        Me.lblItemId.Name = "lblItemId"
        Me.lblItemId.Size = New System.Drawing.Size(57, 16)
        Me.lblItemId.TabIndex = 247
        Me.lblItemId.Text = "Item ID"
        '
        'lblItemType
        '
        Me.lblItemType.AutoSize = True
        Me.lblItemType.BackColor = System.Drawing.Color.Transparent
        Me.lblItemType.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemType.Location = New System.Drawing.Point(248, 34)
        Me.lblItemType.Name = "lblItemType"
        Me.lblItemType.Size = New System.Drawing.Size(41, 16)
        Me.lblItemType.TabIndex = 245
        Me.lblItemType.Text = "Type"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.linkViewItemHist)
        Me.Panel5.Controls.Add(Me.dgvItemUnit)
        Me.Panel5.Controls.Add(Me.txtSearch)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(12, 358)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(893, 331)
        Me.Panel5.TabIndex = 391
        '
        'linkViewItemHist
        '
        Me.linkViewItemHist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.linkViewItemHist.AutoSize = True
        Me.linkViewItemHist.Location = New System.Drawing.Point(16, 304)
        Me.linkViewItemHist.Name = "linkViewItemHist"
        Me.linkViewItemHist.Size = New System.Drawing.Size(88, 13)
        Me.linkViewItemHist.TabIndex = 342
        Me.linkViewItemHist.TabStop = True
        Me.linkViewItemHist.Text = "View Item History"
        '
        'dgvItemUnit
        '
        Me.dgvItemUnit.AllowUserToAddRows = False
        Me.dgvItemUnit.AllowUserToDeleteRows = False
        Me.dgvItemUnit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemUnit.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvItemUnit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvItemUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemUnit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column8})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemUnit.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemUnit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItemUnit.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvItemUnit.Location = New System.Drawing.Point(19, 40)
        Me.dgvItemUnit.MultiSelect = False
        Me.dgvItemUnit.Name = "dgvItemUnit"
        Me.dgvItemUnit.ReadOnly = True
        Me.dgvItemUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemUnit.Size = New System.Drawing.Size(856, 261)
        Me.dgvItemUnit.TabIndex = 341
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Condition"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Status"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Aquisition"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Date Added"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(77, 12)
        Me.txtSearch.MaxLength = 256
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(798, 22)
        Me.txtSearch.TabIndex = 340
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(16, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 304
        Me.Label15.Text = "Search"
        '
        'FormViewLibraryItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormViewLibraryItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormViewLibraryItem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictItemPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForPhoto.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents pictItemPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents pnlForPhoto As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblMaxBorrowLABEL As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblItemAvailability As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblItemQuantity As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblItemDescription As System.Windows.Forms.Label
    Friend WithEvents lblMaxBorrow As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblitemBorrowType As System.Windows.Forms.Label
    Friend WithEvents lblItemId As System.Windows.Forms.Label
    Friend WithEvents lblItemType As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents linkViewItemHist As System.Windows.Forms.LinkLabel
    Friend WithEvents dgvItemUnit As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
