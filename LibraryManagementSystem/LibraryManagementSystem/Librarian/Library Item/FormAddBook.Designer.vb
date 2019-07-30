<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddBook))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvAuthorList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemoveFromList = New System.Windows.Forms.Button()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.btnAuthor = New System.Windows.Forms.Button()
        Me.cboAuthor = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.chbSelectAll = New System.Windows.Forms.CheckBox()
        Me.btnEditBookCopy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveBookCopy = New System.Windows.Forms.Button()
        Me.btnAddBookCopy = New System.Windows.Forms.Button()
        Me.dgvBookCopy = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bntUploadPhoto = New System.Windows.Forms.Button()
        Me.pictBook = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbBookDescription = New System.Windows.Forms.RichTextBox()
        Me.cboBorrowType = New System.Windows.Forms.ComboBox()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.btnPublisher = New System.Windows.Forms.Button()
        Me.cboPublisher = New System.Windows.Forms.ComboBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtMaxDuration = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtBookId = New System.Windows.Forms.TextBox()
        Me.lblMaxDuration = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.lblNumberOfCopy = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvAuthorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvBookCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.pictBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(164, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 465
        Me.Label4.Text = "Book Photo"
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
        Me.Panel6.Size = New System.Drawing.Size(1350, 37)
        Me.Panel6.TabIndex = 411
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
        Me.Label10.Size = New System.Drawing.Size(120, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "        New Book"
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
        Me.Button3.Location = New System.Drawing.Point(1307, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dgvAuthorList
        '
        Me.dgvAuthorList.AllowUserToAddRows = False
        Me.dgvAuthorList.AllowUserToDeleteRows = False
        Me.dgvAuthorList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAuthorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAuthorList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAuthorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAuthorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAuthorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAuthorList.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAuthorList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAuthorList.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAuthorList.Location = New System.Drawing.Point(13, 95)
        Me.dgvAuthorList.MultiSelect = False
        Me.dgvAuthorList.Name = "dgvAuthorList"
        Me.dgvAuthorList.ReadOnly = True
        Me.dgvAuthorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAuthorList.Size = New System.Drawing.Size(342, 190)
        Me.dgvAuthorList.TabIndex = 461
        '
        'Column1
        '
        Me.Column1.FillWeight = 40.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 60.0!
        Me.Column2.HeaderText = "Author"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvAuthorList)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnRemoveFromList)
        Me.Panel3.Controls.Add(Me.btnAddToList)
        Me.Panel3.Controls.Add(Me.btnAuthor)
        Me.Panel3.Controls.Add(Me.cboAuthor)
        Me.Panel3.Location = New System.Drawing.Point(504, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 327)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 464
        Me.Label2.Text = "Author"
        '
        'btnRemoveFromList
        '
        Me.btnRemoveFromList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveFromList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveFromList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFromList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFromList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFromList.Location = New System.Drawing.Point(13, 291)
        Me.btnRemoveFromList.Name = "btnRemoveFromList"
        Me.btnRemoveFromList.Size = New System.Drawing.Size(342, 26)
        Me.btnRemoveFromList.TabIndex = 460
        Me.btnRemoveFromList.Text = "Remove From List"
        Me.btnRemoveFromList.UseVisualStyleBackColor = False
        '
        'btnAddToList
        '
        Me.btnAddToList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddToList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddToList.Location = New System.Drawing.Point(13, 63)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(342, 26)
        Me.btnAddToList.TabIndex = 407
        Me.btnAddToList.Text = "Add to List"
        Me.btnAddToList.UseVisualStyleBackColor = False
        '
        'btnAuthor
        '
        Me.btnAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAuthor.BackColor = System.Drawing.Color.Maroon
        Me.btnAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAuthor.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuthor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAuthor.Location = New System.Drawing.Point(324, 33)
        Me.btnAuthor.Name = "btnAuthor"
        Me.btnAuthor.Size = New System.Drawing.Size(31, 23)
        Me.btnAuthor.TabIndex = 458
        Me.btnAuthor.Text = "..."
        Me.btnAuthor.UseVisualStyleBackColor = False
        '
        'cboAuthor
        '
        Me.cboAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAuthor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAuthor.FormattingEnabled = True
        Me.cboAuthor.Location = New System.Drawing.Point(13, 34)
        Me.cboAuthor.Name = "cboAuthor"
        Me.cboAuthor.Size = New System.Drawing.Size(305, 23)
        Me.cboAuthor.TabIndex = 457
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(16, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 626)
        Me.Panel1.TabIndex = 412
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblNumberOfCopy)
        Me.Panel5.Controls.Add(Me.chbSelectAll)
        Me.Panel5.Controls.Add(Me.btnEditBookCopy)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.btnRemoveBookCopy)
        Me.Panel5.Controls.Add(Me.btnAddBookCopy)
        Me.Panel5.Controls.Add(Me.dgvBookCopy)
        Me.Panel5.Location = New System.Drawing.Point(14, 351)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1285, 256)
        Me.Panel5.TabIndex = 2
        '
        'chbSelectAll
        '
        Me.chbSelectAll.AutoSize = True
        Me.chbSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSelectAll.Location = New System.Drawing.Point(16, 28)
        Me.chbSelectAll.Name = "chbSelectAll"
        Me.chbSelectAll.Size = New System.Drawing.Size(83, 20)
        Me.chbSelectAll.TabIndex = 465
        Me.chbSelectAll.Text = "Select All"
        Me.chbSelectAll.UseVisualStyleBackColor = True
        '
        'btnEditBookCopy
        '
        Me.btnEditBookCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditBookCopy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditBookCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBookCopy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBookCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditBookCopy.Location = New System.Drawing.Point(1159, 86)
        Me.btnEditBookCopy.Name = "btnEditBookCopy"
        Me.btnEditBookCopy.Size = New System.Drawing.Size(113, 26)
        Me.btnEditBookCopy.TabIndex = 464
        Me.btnEditBookCopy.Text = "Edit Copy"
        Me.btnEditBookCopy.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 463
        Me.Label1.Text = "Book Copy"
        '
        'btnRemoveBookCopy
        '
        Me.btnRemoveBookCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveBookCopy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveBookCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveBookCopy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveBookCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveBookCopy.Location = New System.Drawing.Point(1159, 121)
        Me.btnRemoveBookCopy.Name = "btnRemoveBookCopy"
        Me.btnRemoveBookCopy.Size = New System.Drawing.Size(113, 26)
        Me.btnRemoveBookCopy.TabIndex = 462
        Me.btnRemoveBookCopy.Text = "Remove Copy"
        Me.btnRemoveBookCopy.UseVisualStyleBackColor = False
        '
        'btnAddBookCopy
        '
        Me.btnAddBookCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBookCopy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBookCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBookCopy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBookCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBookCopy.Location = New System.Drawing.Point(1159, 51)
        Me.btnAddBookCopy.Name = "btnAddBookCopy"
        Me.btnAddBookCopy.Size = New System.Drawing.Size(113, 26)
        Me.btnAddBookCopy.TabIndex = 461
        Me.btnAddBookCopy.Text = "Add Copy"
        Me.btnAddBookCopy.UseVisualStyleBackColor = False
        '
        'dgvBookCopy
        '
        Me.dgvBookCopy.AllowUserToAddRows = False
        Me.dgvBookCopy.AllowUserToDeleteRows = False
        Me.dgvBookCopy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBookCopy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookCopy.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBookCopy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBookCopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookCopy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.DataGridViewTextBoxColumn1, Me.Column6, Me.Column8, Me.Column11, Me.Column3, Me.Column7, Me.Column5, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookCopy.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBookCopy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBookCopy.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvBookCopy.Location = New System.Drawing.Point(13, 51)
        Me.dgvBookCopy.MultiSelect = False
        Me.dgvBookCopy.Name = "dgvBookCopy"
        Me.dgvBookCopy.ReadOnly = True
        Me.dgvBookCopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookCopy.Size = New System.Drawing.Size(1140, 187)
        Me.dgvBookCopy.TabIndex = 316
        '
        'Column4
        '
        Me.Column4.FillWeight = 20.0!
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Accession Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Shelf"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Shelf Section"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Condition"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Aqusition"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Amount"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date Added"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "ShelfID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "ShelfSectionId"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.bntUploadPhoto)
        Me.Panel4.Controls.Add(Me.pictBook)
        Me.Panel4.Location = New System.Drawing.Point(878, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(421, 327)
        Me.Panel4.TabIndex = 1
        '
        'bntUploadPhoto
        '
        Me.bntUploadPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bntUploadPhoto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bntUploadPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.bntUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntUploadPhoto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntUploadPhoto.Location = New System.Drawing.Point(132, 272)
        Me.bntUploadPhoto.Name = "bntUploadPhoto"
        Me.bntUploadPhoto.Size = New System.Drawing.Size(157, 26)
        Me.bntUploadPhoto.TabIndex = 403
        Me.bntUploadPhoto.Text = "Upload Photo"
        Me.bntUploadPhoto.UseVisualStyleBackColor = False
        '
        'pictBook
        '
        Me.pictBook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pictBook.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pictBook.BackgroundImage = CType(resources.GetObject("pictBook.BackgroundImage"), System.Drawing.Image)
        Me.pictBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictBook.ErrorImage = Nothing
        Me.pictBook.Location = New System.Drawing.Point(116, 35)
        Me.pictBook.Name = "pictBook"
        Me.pictBook.Size = New System.Drawing.Size(188, 232)
        Me.pictBook.TabIndex = 1
        Me.pictBook.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnGenerate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.rtbBookDescription)
        Me.Panel2.Controls.Add(Me.cboBorrowType)
        Me.Panel2.Controls.Add(Me.btnCategory)
        Me.Panel2.Controls.Add(Me.cboCategory)
        Me.Panel2.Controls.Add(Me.btnPublisher)
        Me.Panel2.Controls.Add(Me.cboPublisher)
        Me.Panel2.Controls.Add(Me.lblDays)
        Me.Panel2.Controls.Add(Me.txtMaxDuration)
        Me.Panel2.Controls.Add(Me.txtISBN)
        Me.Panel2.Controls.Add(Me.txtTitle)
        Me.Panel2.Controls.Add(Me.txtBookId)
        Me.Panel2.Controls.Add(Me.lblMaxDuration)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Location = New System.Drawing.Point(14, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 327)
        Me.Panel2.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.Location = New System.Drawing.Point(326, 106)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(113, 23)
        Me.btnGenerate.TabIndex = 466
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(101, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 465
        Me.Label3.Text = "Book Information"
        '
        'rtbBookDescription
        '
        Me.rtbBookDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rtbBookDescription.Location = New System.Drawing.Point(102, 258)
        Me.rtbBookDescription.Name = "rtbBookDescription"
        Me.rtbBookDescription.Size = New System.Drawing.Size(320, 50)
        Me.rtbBookDescription.TabIndex = 454
        Me.rtbBookDescription.Text = ""
        '
        'cboBorrowType
        '
        Me.cboBorrowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorrowType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBorrowType.FormattingEnabled = True
        Me.cboBorrowType.Items.AddRange(New Object() {"FOR INSIDE READING ONLY", "FOR INSIDE AND OUTSIDE USE"})
        Me.cboBorrowType.Location = New System.Drawing.Point(103, 199)
        Me.cboBorrowType.Name = "cboBorrowType"
        Me.cboBorrowType.Size = New System.Drawing.Size(302, 23)
        Me.cboBorrowType.TabIndex = 453
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.Maroon
        Me.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCategory.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCategory.Location = New System.Drawing.Point(407, 169)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(31, 23)
        Me.btnCategory.TabIndex = 450
        Me.btnCategory.Text = "..."
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(103, 169)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(302, 23)
        Me.cboCategory.TabIndex = 449
        '
        'btnPublisher
        '
        Me.btnPublisher.BackColor = System.Drawing.Color.Maroon
        Me.btnPublisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnPublisher.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPublisher.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublisher.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPublisher.Location = New System.Drawing.Point(408, 139)
        Me.btnPublisher.Name = "btnPublisher"
        Me.btnPublisher.Size = New System.Drawing.Size(31, 23)
        Me.btnPublisher.TabIndex = 409
        Me.btnPublisher.Text = "..."
        Me.btnPublisher.UseVisualStyleBackColor = False
        '
        'cboPublisher
        '
        Me.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPublisher.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPublisher.FormattingEnabled = True
        Me.cboPublisher.Location = New System.Drawing.Point(103, 139)
        Me.cboPublisher.Name = "cboPublisher"
        Me.cboPublisher.Size = New System.Drawing.Size(302, 23)
        Me.cboPublisher.TabIndex = 408
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.BackColor = System.Drawing.Color.Transparent
        Me.lblDays.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.ForeColor = System.Drawing.Color.Black
        Me.lblDays.Location = New System.Drawing.Point(425, 233)
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
        Me.txtMaxDuration.Location = New System.Drawing.Point(103, 229)
        Me.txtMaxDuration.MaxLength = 10
        Me.txtMaxDuration.Name = "txtMaxDuration"
        Me.txtMaxDuration.Size = New System.Drawing.Size(319, 23)
        Me.txtMaxDuration.TabIndex = 445
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.White
        Me.txtISBN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(103, 50)
        Me.txtISBN.MaxLength = 13
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(336, 23)
        Me.txtISBN.TabIndex = 439
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.White
        Me.txtTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(104, 79)
        Me.txtTitle.MaxLength = 256
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(335, 23)
        Me.txtTitle.TabIndex = 438
        '
        'txtBookId
        '
        Me.txtBookId.BackColor = System.Drawing.Color.White
        Me.txtBookId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookId.Location = New System.Drawing.Point(104, 106)
        Me.txtBookId.MaxLength = 10
        Me.txtBookId.Name = "txtBookId"
        Me.txtBookId.Size = New System.Drawing.Size(216, 23)
        Me.txtBookId.TabIndex = 437
        '
        'lblMaxDuration
        '
        Me.lblMaxDuration.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxDuration.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDuration.ForeColor = System.Drawing.Color.Black
        Me.lblMaxDuration.Location = New System.Drawing.Point(9, 229)
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
        Me.Label5.Location = New System.Drawing.Point(11, 203)
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
        Me.Label8.Location = New System.Drawing.Point(14, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 428
        Me.Label8.Text = "Description"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(61, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 426
        Me.Label15.Text = "ISBN"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(42, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 15)
        Me.Label18.TabIndex = 425
        Me.Label18.Text = "Book ID"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(33, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 15)
        Me.Label21.TabIndex = 424
        Me.Label21.Text = "Category"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(62, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 15)
        Me.Label22.TabIndex = 423
        Me.Label22.Text = "Title"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(31, 143)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 15)
        Me.Label23.TabIndex = 422
        Me.Label23.Text = "Publisher"
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
        Me.btnCancel.Location = New System.Drawing.Point(1211, 685)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 27)
        Me.btnCancel.TabIndex = 414
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
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
        Me.btnAddBook.Location = New System.Drawing.Point(1050, 685)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(157, 27)
        Me.btnAddBook.TabIndex = 413
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'lblNumberOfCopy
        '
        Me.lblNumberOfCopy.AutoSize = True
        Me.lblNumberOfCopy.BackColor = System.Drawing.Color.Transparent
        Me.lblNumberOfCopy.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfCopy.ForeColor = System.Drawing.Color.Black
        Me.lblNumberOfCopy.Location = New System.Drawing.Point(1009, 28)
        Me.lblNumberOfCopy.Name = "lblNumberOfCopy"
        Me.lblNumberOfCopy.Size = New System.Drawing.Size(144, 20)
        Me.lblNumberOfCopy.TabIndex = 466
        Me.lblNumberOfCopy.Text = "Number of Copies: 0"
        Me.lblNumberOfCopy.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FormAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 722)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddBook"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvAuthorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvBookCopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pictBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgvAuthorList As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveFromList As System.Windows.Forms.Button
    Friend WithEvents btnAddToList As System.Windows.Forms.Button
    Friend WithEvents btnAuthor As System.Windows.Forms.Button
    Friend WithEvents cboAuthor As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnEditBookCopy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveBookCopy As System.Windows.Forms.Button
    Friend WithEvents btnAddBookCopy As System.Windows.Forms.Button
    Friend WithEvents dgvBookCopy As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents bntUploadPhoto As System.Windows.Forms.Button
    Friend WithEvents pictBook As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbBookDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents cboBorrowType As System.Windows.Forms.ComboBox
    Friend WithEvents btnCategory As System.Windows.Forms.Button
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnPublisher As System.Windows.Forms.Button
    Friend WithEvents cboPublisher As System.Windows.Forms.ComboBox
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents txtMaxDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtBookId As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxDuration As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chbSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfCopy As System.Windows.Forms.Label
End Class
