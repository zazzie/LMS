<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageItem))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.btnViewItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnSearchItemID = New System.Windows.Forms.Button()
        Me.btnSearchItemName = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchAllItem = New System.Windows.Forms.Button()
        Me.txtSearchItem = New System.Windows.Forms.TextBox()
        Me.btnSearchAuthor = New System.Windows.Forms.Button()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnUpdateBook = New System.Windows.Forms.Button()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearchTitle = New System.Windows.Forms.Button()
        Me.btnSearchISBN = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnViewBook = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearchBookId = New System.Windows.Forms.Button()
        Me.btnSearchCategory = New System.Windows.Forms.Button()
        Me.btnSearchAllBook = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddItem
        '
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Image = CType(resources.GetObject("btnAddItem.Image"), System.Drawing.Image)
        Me.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItem.Location = New System.Drawing.Point(287, 549)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(171, 32)
        Me.btnAddItem.TabIndex = 423
        Me.btnAddItem.Text = "Add New"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 15)
        Me.Label3.TabIndex = 318
        Me.Label3.Text = "FOR INSIDE READING ONLY"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.btnUpdateItem)
        Me.TabPage2.Controls.Add(Me.btnAddItem)
        Me.TabPage2.Controls.Add(Me.btnViewItem)
        Me.TabPage2.Controls.Add(Me.btnDeleteItem)
        Me.TabPage2.Controls.Add(Me.btnSearchItemID)
        Me.TabPage2.Controls.Add(Me.btnSearchItemName)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnSearchAllItem)
        Me.TabPage2.Controls.Add(Me.txtSearchItem)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1046, 601)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Non-Book Item"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.dgvItem)
        Me.Panel5.Location = New System.Drawing.Point(18, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1005, 437)
        Me.Panel5.TabIndex = 425
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(242, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 15)
        Me.Label5.TabIndex = 323
        Me.Label5.Text = "FOR INSIDE AND OUTSIDE USE"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 15)
        Me.Label6.TabIndex = 322
        Me.Label6.Text = "FOR INSIDE USE ONLY"
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(216, 408)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(20, 20)
        Me.Panel8.TabIndex = 321
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.MistyRose
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Location = New System.Drawing.Point(15, 408)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(20, 20)
        Me.Panel9.TabIndex = 320
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItem.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItem.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvItem.Location = New System.Drawing.Point(3, 3)
        Me.dgvItem.MultiSelect = False
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.ReadOnly = True
        Me.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItem.Size = New System.Drawing.Size(999, 399)
        Me.dgvItem.TabIndex = 315
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Item ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Item Type"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Availability"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
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
        Me.btnUpdateItem.Location = New System.Drawing.Point(665, 549)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(171, 32)
        Me.btnUpdateItem.TabIndex = 424
        Me.btnUpdateItem.Text = "Update Item"
        Me.btnUpdateItem.UseVisualStyleBackColor = False
        '
        'btnViewItem
        '
        Me.btnViewItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnViewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewItem.Image = CType(resources.GetObject("btnViewItem.Image"), System.Drawing.Image)
        Me.btnViewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewItem.Location = New System.Drawing.Point(473, 549)
        Me.btnViewItem.Name = "btnViewItem"
        Me.btnViewItem.Size = New System.Drawing.Size(171, 32)
        Me.btnViewItem.TabIndex = 422
        Me.btnViewItem.Text = "View Details"
        Me.btnViewItem.UseVisualStyleBackColor = False
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Image = CType(resources.GetObject("btnDeleteItem.Image"), System.Drawing.Image)
        Me.btnDeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteItem.Location = New System.Drawing.Point(852, 549)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(171, 32)
        Me.btnDeleteItem.TabIndex = 421
        Me.btnDeleteItem.Text = "Delete"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'btnSearchItemID
        '
        Me.btnSearchItemID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchItemID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchItemID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchItemID.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchItemID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchItemID.Location = New System.Drawing.Point(464, 52)
        Me.btnSearchItemID.Name = "btnSearchItemID"
        Me.btnSearchItemID.Size = New System.Drawing.Size(178, 26)
        Me.btnSearchItemID.TabIndex = 416
        Me.btnSearchItemID.Text = "Search Item ID"
        Me.btnSearchItemID.UseVisualStyleBackColor = False
        '
        'btnSearchItemName
        '
        Me.btnSearchItemName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchItemName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchItemName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchItemName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchItemName.Location = New System.Drawing.Point(286, 52)
        Me.btnSearchItemName.Name = "btnSearchItemName"
        Me.btnSearchItemName.Size = New System.Drawing.Size(178, 26)
        Me.btnSearchItemName.TabIndex = 418
        Me.btnSearchItemName.Text = "Search Item Name"
        Me.btnSearchItemName.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 412
        Me.Label1.Text = "Search"
        '
        'btnSearchAllItem
        '
        Me.btnSearchAllItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchAllItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchAllItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchAllItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAllItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAllItem.Location = New System.Drawing.Point(108, 52)
        Me.btnSearchAllItem.Name = "btnSearchAllItem"
        Me.btnSearchAllItem.Size = New System.Drawing.Size(178, 26)
        Me.btnSearchAllItem.TabIndex = 417
        Me.btnSearchAllItem.Text = "Search All"
        Me.btnSearchAllItem.UseVisualStyleBackColor = False
        '
        'txtSearchItem
        '
        Me.txtSearchItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchItem.ForeColor = System.Drawing.Color.Black
        Me.txtSearchItem.Location = New System.Drawing.Point(108, 20)
        Me.txtSearchItem.MaxLength = 256
        Me.txtSearchItem.Name = "txtSearchItem"
        Me.txtSearchItem.Size = New System.Drawing.Size(900, 26)
        Me.txtSearchItem.TabIndex = 413
        '
        'btnSearchAuthor
        '
        Me.btnSearchAuthor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchAuthor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAuthor.Location = New System.Drawing.Point(519, 57)
        Me.btnSearchAuthor.Name = "btnSearchAuthor"
        Me.btnSearchAuthor.Size = New System.Drawing.Size(137, 26)
        Me.btnSearchAuthor.TabIndex = 358
        Me.btnSearchAuthor.Text = "Search Author"
        Me.btnSearchAuthor.UseVisualStyleBackColor = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Available Copies"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Category"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(41, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 355
        Me.Label10.Text = "Search"
        '
        'btnUpdateBook
        '
        Me.btnUpdateBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBook.Image = CType(resources.GetObject("btnUpdateBook.Image"), System.Drawing.Image)
        Me.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateBook.Location = New System.Drawing.Point(675, 554)
        Me.btnUpdateBook.Name = "btnUpdateBook"
        Me.btnUpdateBook.Size = New System.Drawing.Size(171, 32)
        Me.btnUpdateBook.TabIndex = 411
        Me.btnUpdateBook.Text = "Update Book"
        Me.btnUpdateBook.UseVisualStyleBackColor = False
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBook.Image = CType(resources.GetObject("btnDeleteBook.Image"), System.Drawing.Image)
        Me.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteBook.Location = New System.Drawing.Point(852, 554)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(171, 32)
        Me.btnDeleteBook.TabIndex = 407
        Me.btnDeleteBook.Text = "Delete"
        Me.btnDeleteBook.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDate.Location = New System.Drawing.Point(11, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(205, 18)
        Me.lblDate.TabIndex = 216
        Me.lblDate.Text = "Saturday, February 02, 2018"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTime.Location = New System.Drawing.Point(979, 12)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(92, 18)
        Me.lblTime.TabIndex = 215
        Me.lblTime.Text = "1:30: 27 AM"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Book ID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'btnSearchTitle
        '
        Me.btnSearchTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTitle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchTitle.Location = New System.Drawing.Point(382, 57)
        Me.btnSearchTitle.Name = "btnSearchTitle"
        Me.btnSearchTitle.Size = New System.Drawing.Size(137, 26)
        Me.btnSearchTitle.TabIndex = 359
        Me.btnSearchTitle.Text = "Search Title"
        Me.btnSearchTitle.UseVisualStyleBackColor = False
        '
        'btnSearchISBN
        '
        Me.btnSearchISBN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchISBN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchISBN.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchISBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchISBN.Location = New System.Drawing.Point(245, 57)
        Me.btnSearchISBN.Name = "btnSearchISBN"
        Me.btnSearchISBN.Size = New System.Drawing.Size(137, 26)
        Me.btnSearchISBN.TabIndex = 361
        Me.btnSearchISBN.Text = "Search ISBN"
        Me.btnSearchISBN.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.btnUpdateBook)
        Me.TabPage1.Controls.Add(Me.btnAddBook)
        Me.TabPage1.Controls.Add(Me.btnViewBook)
        Me.TabPage1.Controls.Add(Me.btnDeleteBook)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.btnSearchBookId)
        Me.TabPage1.Controls.Add(Me.btnSearchCategory)
        Me.TabPage1.Controls.Add(Me.btnSearchAuthor)
        Me.TabPage1.Controls.Add(Me.btnSearchTitle)
        Me.TabPage1.Controls.Add(Me.btnSearchISBN)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btnSearchAllBook)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1046, 601)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manage Book"
        '
        'btnAddBook
        '
        Me.btnAddBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Image = CType(resources.GetObject("btnAddBook.Image"), System.Drawing.Image)
        Me.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBook.Location = New System.Drawing.Point(321, 554)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(171, 32)
        Me.btnAddBook.TabIndex = 410
        Me.btnAddBook.Text = "Add New"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'btnViewBook
        '
        Me.btnViewBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBook.Image = CType(resources.GetObject("btnViewBook.Image"), System.Drawing.Image)
        Me.btnViewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewBook.Location = New System.Drawing.Point(498, 554)
        Me.btnViewBook.Name = "btnViewBook"
        Me.btnViewBook.Size = New System.Drawing.Size(171, 32)
        Me.btnViewBook.TabIndex = 409
        Me.btnViewBook.Text = "View Details"
        Me.btnViewBook.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.dgvBook)
        Me.Panel4.Location = New System.Drawing.Point(23, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 459)
        Me.Panel4.TabIndex = 363
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 15)
        Me.Label4.TabIndex = 319
        Me.Label4.Text = "FOR INSIDE AND OUTSIDE USE"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(220, 428)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(20, 20)
        Me.Panel7.TabIndex = 317
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(19, 428)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 20)
        Me.Panel2.TabIndex = 316
        '
        'dgvBook
        '
        Me.dgvBook.AllowUserToAddRows = False
        Me.dgvBook.AllowUserToDeleteRows = False
        Me.dgvBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBook.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.Column8, Me.Column5, Me.Column6})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBook.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBook.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvBook.Location = New System.Drawing.Point(3, 3)
        Me.dgvBook.MultiSelect = False
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBook.Size = New System.Drawing.Size(994, 414)
        Me.dgvBook.TabIndex = 315
        '
        'Column1
        '
        Me.Column1.HeaderText = "ISBN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Title"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Author"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Copies"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btnSearchBookId
        '
        Me.btnSearchBookId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchBookId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchBookId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBookId.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBookId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBookId.Location = New System.Drawing.Point(793, 57)
        Me.btnSearchBookId.Name = "btnSearchBookId"
        Me.btnSearchBookId.Size = New System.Drawing.Size(137, 26)
        Me.btnSearchBookId.TabIndex = 362
        Me.btnSearchBookId.Text = "Search Book ID"
        Me.btnSearchBookId.UseVisualStyleBackColor = False
        '
        'btnSearchCategory
        '
        Me.btnSearchCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchCategory.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchCategory.Location = New System.Drawing.Point(656, 57)
        Me.btnSearchCategory.Name = "btnSearchCategory"
        Me.btnSearchCategory.Size = New System.Drawing.Size(137, 26)
        Me.btnSearchCategory.TabIndex = 357
        Me.btnSearchCategory.Text = "Search Category"
        Me.btnSearchCategory.UseVisualStyleBackColor = False
        '
        'btnSearchAllBook
        '
        Me.btnSearchAllBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchAllBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchAllBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchAllBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAllBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAllBook.Location = New System.Drawing.Point(108, 57)
        Me.btnSearchAllBook.Name = "btnSearchAllBook"
        Me.btnSearchAllBook.Size = New System.Drawing.Size(137, 26)
        Me.btnSearchAllBook.TabIndex = 360
        Me.btnSearchAllBook.Text = "Search All"
        Me.btnSearchAllBook.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(108, 25)
        Me.txtSearch.MaxLength = 256
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(900, 26)
        Me.txtSearch.TabIndex = 356
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblDate)
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 707)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1084, 40)
        Me.Panel3.TabIndex = 400
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1054, 632)
        Me.TabControl1.TabIndex = 382
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1041, -462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 27)
        Me.Button1.TabIndex = 213
        Me.Button1.Text = "Logout"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "      Library Items"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 638)
        Me.Panel1.TabIndex = 399
        '
        'Timer1
        '
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(937, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(145, 42)
        Me.btnBack.TabIndex = 220
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnBack)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1084, 44)
        Me.Panel6.TabIndex = 398
        '
        'FormManageItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 747)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManageItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateItem As System.Windows.Forms.Button
    Friend WithEvents btnViewItem As System.Windows.Forms.Button
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnSearchItemID As System.Windows.Forms.Button
    Friend WithEvents btnSearchItemName As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearchAllItem As System.Windows.Forms.Button
    Friend WithEvents txtSearchItem As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchAuthor As System.Windows.Forms.Button
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateBook As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBook As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearchTitle As System.Windows.Forms.Button
    Friend WithEvents btnSearchISBN As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents btnViewBook As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearchBookId As System.Windows.Forms.Button
    Friend WithEvents btnSearchCategory As System.Windows.Forms.Button
    Friend WithEvents btnSearchAllBook As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
End Class
