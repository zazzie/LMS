<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewBook
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewBook))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.linkViewBookHist = New System.Windows.Forms.LinkLabel()
        Me.dgvBookCopy = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblBookPublisher = New System.Windows.Forms.Label()
        Me.lblBookIsbn = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.listAuthor = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblBookAvailability = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblBookQuantity = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblBookDescription = New System.Windows.Forms.Label()
        Me.lblMaxLABEL = New System.Windows.Forms.Label()
        Me.lblMaxBorrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblBookBorrowType = New System.Windows.Forms.Label()
        Me.lblBookId = New System.Windows.Forms.Label()
        Me.lblBookCategory = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlForPhoto = New System.Windows.Forms.Panel()
        Me.pictBookPhoto = New System.Windows.Forms.PictureBox()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvBookCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlForPhoto.SuspendLayout()
        CType(Me.pictBookPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.linkViewBookHist)
        Me.Panel5.Controls.Add(Me.dgvBookCopy)
        Me.Panel5.Controls.Add(Me.txtSearch)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(12, 358)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(698, 239)
        Me.Panel5.TabIndex = 386
        '
        'linkViewBookHist
        '
        Me.linkViewBookHist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.linkViewBookHist.AutoSize = True
        Me.linkViewBookHist.Location = New System.Drawing.Point(16, 212)
        Me.linkViewBookHist.Name = "linkViewBookHist"
        Me.linkViewBookHist.Size = New System.Drawing.Size(93, 13)
        Me.linkViewBookHist.TabIndex = 342
        Me.linkViewBookHist.TabStop = True
        Me.linkViewBookHist.Text = "View Book History"
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
        Me.dgvBookCopy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column8, Me.Column6, Me.Column7})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookCopy.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBookCopy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBookCopy.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvBookCopy.Location = New System.Drawing.Point(19, 40)
        Me.dgvBookCopy.MultiSelect = False
        Me.dgvBookCopy.Name = "dgvBookCopy"
        Me.dgvBookCopy.ReadOnly = True
        Me.dgvBookCopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookCopy.Size = New System.Drawing.Size(661, 169)
        Me.dgvBookCopy.TabIndex = 341
        '
        'Column1
        '
        Me.Column1.HeaderText = "Accession No."
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
        'Column6
        '
        Me.Column6.HeaderText = "Shelf"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Shelf Section"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
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
        Me.txtSearch.Size = New System.Drawing.Size(603, 22)
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
        'lblBookPublisher
        '
        Me.lblBookPublisher.AutoSize = True
        Me.lblBookPublisher.BackColor = System.Drawing.Color.Transparent
        Me.lblBookPublisher.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookPublisher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookPublisher.Location = New System.Drawing.Point(195, 50)
        Me.lblBookPublisher.Name = "lblBookPublisher"
        Me.lblBookPublisher.Size = New System.Drawing.Size(75, 16)
        Me.lblBookPublisher.TabIndex = 245
        Me.lblBookPublisher.Text = "Publisher"
        '
        'lblBookIsbn
        '
        Me.lblBookIsbn.AutoSize = True
        Me.lblBookIsbn.BackColor = System.Drawing.Color.Transparent
        Me.lblBookIsbn.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookIsbn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookIsbn.Location = New System.Drawing.Point(195, 34)
        Me.lblBookIsbn.Name = "lblBookIsbn"
        Me.lblBookIsbn.Size = New System.Drawing.Size(41, 16)
        Me.lblBookIsbn.TabIndex = 242
        Me.lblBookIsbn.Text = "ISBN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(106, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 233
        Me.Label11.Text = "Book ID :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(97, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 232
        Me.Label12.Text = "Category :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(93, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 231
        Me.Label13.Text = "Publisher :"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(18, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 230
        Me.Label14.Text = "Author :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(126, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 16)
        Me.Label16.TabIndex = 228
        Me.Label16.Text = "ISBN :"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.listAuthor)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Location = New System.Drawing.Point(716, 398)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(366, 199)
        Me.Panel6.TabIndex = 388
        '
        'listAuthor
        '
        Me.listAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.listAuthor.BackColor = System.Drawing.SystemColors.Control
        Me.listAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listAuthor.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.listAuthor.FormattingEnabled = True
        Me.listAuthor.ItemHeight = 16
        Me.listAuthor.Items.AddRange(New Object() {"Author1", "Author2", "Author3"})
        Me.listAuthor.Location = New System.Drawing.Point(21, 30)
        Me.listAuthor.Name = "listAuthor"
        Me.listAuthor.Size = New System.Drawing.Size(326, 82)
        Me.listAuthor.TabIndex = 296
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblBookAvailability)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.lblBookQuantity)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(21, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 66)
        Me.Panel4.TabIndex = 374
        '
        'lblBookAvailability
        '
        Me.lblBookAvailability.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookAvailability.AutoSize = True
        Me.lblBookAvailability.BackColor = System.Drawing.Color.Transparent
        Me.lblBookAvailability.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookAvailability.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookAvailability.Location = New System.Drawing.Point(157, 34)
        Me.lblBookAvailability.Name = "lblBookAvailability"
        Me.lblBookAvailability.Size = New System.Drawing.Size(70, 16)
        Me.lblBookAvailability.TabIndex = 302
        Me.lblBookAvailability.Text = "Quantity"
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(16, 34)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(118, 16)
        Me.Label28.TabIndex = 300
        Me.Label28.Text = "Available Copy :"
        '
        'lblBookQuantity
        '
        Me.lblBookQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookQuantity.AutoSize = True
        Me.lblBookQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblBookQuantity.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookQuantity.Location = New System.Drawing.Point(157, 18)
        Me.lblBookQuantity.Name = "lblBookQuantity"
        Me.lblBookQuantity.Size = New System.Drawing.Size(70, 16)
        Me.lblBookQuantity.TabIndex = 299
        Me.lblBookQuantity.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(44, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 297
        Me.Label6.Text = "Total Copy :"
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
        Me.btnClose.Location = New System.Drawing.Point(925, 610)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(157, 26)
        Me.btnClose.TabIndex = 387
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblBookDescription)
        Me.Panel2.Controls.Add(Me.lblMaxLABEL)
        Me.Panel2.Controls.Add(Me.lblMaxBorrow)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.lblBookBorrowType)
        Me.Panel2.Controls.Add(Me.lblBookId)
        Me.Panel2.Controls.Add(Me.lblBookCategory)
        Me.Panel2.Controls.Add(Me.lblBookPublisher)
        Me.Panel2.Controls.Add(Me.lblBookIsbn)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(12, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 285)
        Me.Panel2.TabIndex = 384
        '
        'lblBookDescription
        '
        Me.lblBookDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookDescription.AutoEllipsis = True
        Me.lblBookDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblBookDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookDescription.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookDescription.Location = New System.Drawing.Point(27, 151)
        Me.lblBookDescription.Name = "lblBookDescription"
        Me.lblBookDescription.Size = New System.Drawing.Size(632, 120)
        Me.lblBookDescription.TabIndex = 306
        Me.lblBookDescription.Text = "Descriptions"
        '
        'lblMaxLABEL
        '
        Me.lblMaxLABEL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaxLABEL.AutoSize = True
        Me.lblMaxLABEL.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxLABEL.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxLABEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMaxLABEL.Location = New System.Drawing.Point(13, 98)
        Me.lblMaxLABEL.Name = "lblMaxLABEL"
        Me.lblMaxLABEL.Size = New System.Drawing.Size(162, 16)
        Me.lblMaxLABEL.TabIndex = 304
        Me.lblMaxLABEL.Text = "Max Borrow Duration :"
        '
        'lblMaxBorrow
        '
        Me.lblMaxBorrow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaxBorrow.AutoSize = True
        Me.lblMaxBorrow.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxBorrow.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBorrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMaxBorrow.Location = New System.Drawing.Point(195, 98)
        Me.lblMaxBorrow.Name = "lblMaxBorrow"
        Me.lblMaxBorrow.Size = New System.Drawing.Size(48, 16)
        Me.lblMaxBorrow.TabIndex = 305
        Me.lblMaxBorrow.Text = "0 Day"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(53, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 289
        Me.Label3.Text = "Borrowing Type :"
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
        'lblBookBorrowType
        '
        Me.lblBookBorrowType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookBorrowType.AutoSize = True
        Me.lblBookBorrowType.BackColor = System.Drawing.Color.Transparent
        Me.lblBookBorrowType.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookBorrowType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookBorrowType.Location = New System.Drawing.Point(195, 82)
        Me.lblBookBorrowType.Name = "lblBookBorrowType"
        Me.lblBookBorrowType.Size = New System.Drawing.Size(117, 16)
        Me.lblBookBorrowType.TabIndex = 297
        Me.lblBookBorrowType.Text = "Borrowing Type"
        '
        'lblBookId
        '
        Me.lblBookId.AutoSize = True
        Me.lblBookId.BackColor = System.Drawing.Color.Transparent
        Me.lblBookId.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookId.Location = New System.Drawing.Point(195, 18)
        Me.lblBookId.Name = "lblBookId"
        Me.lblBookId.Size = New System.Drawing.Size(99, 16)
        Me.lblBookId.TabIndex = 247
        Me.lblBookId.Text = "Book Number"
        '
        'lblBookCategory
        '
        Me.lblBookCategory.AutoSize = True
        Me.lblBookCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblBookCategory.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookCategory.Location = New System.Drawing.Point(195, 66)
        Me.lblBookCategory.Name = "lblBookCategory"
        Me.lblBookCategory.Size = New System.Drawing.Size(70, 16)
        Me.lblBookCategory.TabIndex = 246
        Me.lblBookCategory.Text = "Category"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.pnlForPhoto)
        Me.Panel3.Location = New System.Drawing.Point(716, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(366, 325)
        Me.Panel3.TabIndex = 385
        '
        'pnlForPhoto
        '
        Me.pnlForPhoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlForPhoto.BackColor = System.Drawing.Color.PaleTurquoise
        Me.pnlForPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlForPhoto.Controls.Add(Me.pictBookPhoto)
        Me.pnlForPhoto.Location = New System.Drawing.Point(3, 3)
        Me.pnlForPhoto.Name = "pnlForPhoto"
        Me.pnlForPhoto.Size = New System.Drawing.Size(358, 317)
        Me.pnlForPhoto.TabIndex = 318
        '
        'pictBookPhoto
        '
        Me.pictBookPhoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictBookPhoto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pictBookPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictBookPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictBookPhoto.Location = New System.Drawing.Point(73, 14)
        Me.pictBookPhoto.Name = "pictBookPhoto"
        Me.pictBookPhoto.Size = New System.Drawing.Size(210, 282)
        Me.pictBookPhoto.TabIndex = 1
        Me.pictBookPhoto.TabStop = False
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBookTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblBookTitle.Location = New System.Drawing.Point(23, 15)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(86, 19)
        Me.lblBookTitle.TabIndex = 206
        Me.lblBookTitle.Text = "Book Title"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblBookTitle)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1070, 49)
        Me.Panel1.TabIndex = 383
        '
        'FormViewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 649)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormViewBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormViewBook"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvBookCopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnlForPhoto.ResumeLayout(False)
        CType(Me.pictBookPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents linkViewBookHist As System.Windows.Forms.LinkLabel
    Friend WithEvents dgvBookCopy As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblBookPublisher As System.Windows.Forms.Label
    Friend WithEvents lblBookIsbn As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents listAuthor As System.Windows.Forms.ListBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblBookAvailability As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblBookQuantity As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblBookDescription As System.Windows.Forms.Label
    Friend WithEvents lblMaxLABEL As System.Windows.Forms.Label
    Friend WithEvents lblMaxBorrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblBookBorrowType As System.Windows.Forms.Label
    Friend WithEvents lblBookId As System.Windows.Forms.Label
    Friend WithEvents lblBookCategory As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlForPhoto As System.Windows.Forms.Panel
    Friend WithEvents pictBookPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblBookTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
