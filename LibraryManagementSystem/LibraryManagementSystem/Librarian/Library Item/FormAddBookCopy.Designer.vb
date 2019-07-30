<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddBookCopy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddBookCopy))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rbtManualList = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtAutoGenerate = New System.Windows.Forms.RadioButton()
        Me.btnShelf = New System.Windows.Forms.Button()
        Me.cboShelfSection = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboShelf = New System.Windows.Forms.ComboBox()
        Me.lblPhp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboAquisition = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCopyNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboQuality = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddBookCopy = New System.Windows.Forms.Button()
        Me.pnlManualList = New System.Windows.Forms.Panel()
        Me.chbSelectAll = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccessionID = New System.Windows.Forms.TextBox()
        Me.btnRemoveFromList = New System.Windows.Forms.Button()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.dgvAccessionList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlManualList.SuspendLayout()
        CType(Me.dgvAccessionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtManualList
        '
        Me.rbtManualList.AutoSize = True
        Me.rbtManualList.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtManualList.Location = New System.Drawing.Point(543, 12)
        Me.rbtManualList.Name = "rbtManualList"
        Me.rbtManualList.Size = New System.Drawing.Size(119, 19)
        Me.rbtManualList.TabIndex = 290
        Me.rbtManualList.TabStop = True
        Me.rbtManualList.Text = "Manual Listing"
        Me.rbtManualList.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtManualList)
        Me.Panel1.Controls.Add(Me.rbtAutoGenerate)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 44)
        Me.Panel1.TabIndex = 450
        '
        'rbtAutoGenerate
        '
        Me.rbtAutoGenerate.AutoSize = True
        Me.rbtAutoGenerate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAutoGenerate.Location = New System.Drawing.Point(150, 12)
        Me.rbtAutoGenerate.Name = "rbtAutoGenerate"
        Me.rbtAutoGenerate.Size = New System.Drawing.Size(136, 19)
        Me.rbtAutoGenerate.TabIndex = 291
        Me.rbtAutoGenerate.TabStop = True
        Me.rbtAutoGenerate.Text = "Auto Generate ID"
        Me.rbtAutoGenerate.UseVisualStyleBackColor = True
        '
        'btnShelf
        '
        Me.btnShelf.BackColor = System.Drawing.Color.Maroon
        Me.btnShelf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnShelf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShelf.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShelf.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnShelf.Location = New System.Drawing.Point(388, 130)
        Me.btnShelf.Name = "btnShelf"
        Me.btnShelf.Size = New System.Drawing.Size(31, 23)
        Me.btnShelf.TabIndex = 460
        Me.btnShelf.Text = "..."
        Me.btnShelf.UseVisualStyleBackColor = False
        '
        'cboShelfSection
        '
        Me.cboShelfSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShelfSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShelfSection.FormattingEnabled = True
        Me.cboShelfSection.Location = New System.Drawing.Point(150, 161)
        Me.cboShelfSection.Name = "cboShelfSection"
        Me.cboShelfSection.Size = New System.Drawing.Size(226, 23)
        Me.cboShelfSection.TabIndex = 459
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 15)
        Me.Label7.TabIndex = 458
        Me.Label7.Text = "Book Shelf Section"
        '
        'cboShelf
        '
        Me.cboShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShelf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShelf.FormattingEnabled = True
        Me.cboShelf.Location = New System.Drawing.Point(150, 131)
        Me.cboShelf.Name = "cboShelf"
        Me.cboShelf.Size = New System.Drawing.Size(226, 23)
        Me.cboShelf.TabIndex = 457
        '
        'lblPhp
        '
        Me.lblPhp.AutoSize = True
        Me.lblPhp.BackColor = System.Drawing.Color.Transparent
        Me.lblPhp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhp.ForeColor = System.Drawing.Color.Black
        Me.lblPhp.Location = New System.Drawing.Point(383, 103)
        Me.lblPhp.Name = "lblPhp"
        Me.lblPhp.Size = New System.Drawing.Size(99, 15)
        Me.lblPhp.TabIndex = 456
        Me.lblPhp.Text = "Php (per item)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(11, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "        Add Book Copy"
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
        Me.Button3.Location = New System.Drawing.Point(722, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(765, 37)
        Me.Panel6.TabIndex = 448
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(150, 100)
        Me.txtPrice.MaxLength = 10
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(226, 23)
        Me.txtPrice.TabIndex = 455
        '
        'cboAquisition
        '
        Me.cboAquisition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAquisition.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAquisition.FormattingEnabled = True
        Me.cboAquisition.Items.AddRange(New Object() {"BOUGHT BY SCHOOL", "DONATED", "GOVERNMENT ISSUED", "REPLACED COPY"})
        Me.cboAquisition.Location = New System.Drawing.Point(150, 71)
        Me.cboAquisition.Name = "cboAquisition"
        Me.cboAquisition.Size = New System.Drawing.Size(226, 23)
        Me.cboAquisition.TabIndex = 454
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(69, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 437
        Me.Label1.Text = "Book Shelf"
        '
        'txtCopyNumber
        '
        Me.txtCopyNumber.BackColor = System.Drawing.Color.White
        Me.txtCopyNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopyNumber.Location = New System.Drawing.Point(150, 21)
        Me.txtCopyNumber.MaxLength = 10
        Me.txtCopyNumber.Name = "txtCopyNumber"
        Me.txtCopyNumber.Size = New System.Drawing.Size(140, 23)
        Me.txtCopyNumber.TabIndex = 434
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(72, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 432
        Me.Label2.Text = "Aquisition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 433
        Me.Label3.Text = "Number of Copies"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Black
        Me.lblPrice.Location = New System.Drawing.Point(87, 108)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(57, 15)
        Me.lblPrice.TabIndex = 436
        Me.lblPrice.Text = "Amount"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cboQuality)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnShelf)
        Me.Panel2.Controls.Add(Me.cboShelfSection)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cboShelf)
        Me.Panel2.Controls.Add(Me.lblPhp)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.cboAquisition)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCopyNumber)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Location = New System.Drawing.Point(12, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 341)
        Me.Panel2.TabIndex = 449
        '
        'cboQuality
        '
        Me.cboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuality.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuality.FormattingEnabled = True
        Me.cboQuality.Items.AddRange(New Object() {"EXCELLENT", "GOOD", "FAIR", "POOR (NOT USABLE)"})
        Me.cboQuality.Location = New System.Drawing.Point(150, 188)
        Me.cboQuality.Name = "cboQuality"
        Me.cboQuality.Size = New System.Drawing.Size(226, 23)
        Me.cboQuality.TabIndex = 462
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 461
        Me.Label5.Text = "Condition/Quality"
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
        Me.btnCancel.Location = New System.Drawing.Point(627, 449)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 27)
        Me.btnCancel.TabIndex = 447
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAddBookCopy
        '
        Me.btnAddBookCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBookCopy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBookCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBookCopy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBookCopy.Image = CType(resources.GetObject("btnAddBookCopy.Image"), System.Drawing.Image)
        Me.btnAddBookCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBookCopy.Location = New System.Drawing.Point(441, 449)
        Me.btnAddBookCopy.Name = "btnAddBookCopy"
        Me.btnAddBookCopy.Size = New System.Drawing.Size(182, 27)
        Me.btnAddBookCopy.TabIndex = 446
        Me.btnAddBookCopy.Text = "Add Book Copy"
        Me.btnAddBookCopy.UseVisualStyleBackColor = False
        '
        'pnlManualList
        '
        Me.pnlManualList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlManualList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlManualList.Controls.Add(Me.chbSelectAll)
        Me.pnlManualList.Controls.Add(Me.Label4)
        Me.pnlManualList.Controls.Add(Me.txtAccessionID)
        Me.pnlManualList.Controls.Add(Me.btnRemoveFromList)
        Me.pnlManualList.Controls.Add(Me.btnAddToList)
        Me.pnlManualList.Controls.Add(Me.dgvAccessionList)
        Me.pnlManualList.Location = New System.Drawing.Point(506, 102)
        Me.pnlManualList.Name = "pnlManualList"
        Me.pnlManualList.Size = New System.Drawing.Size(243, 341)
        Me.pnlManualList.TabIndex = 451
        '
        'chbSelectAll
        '
        Me.chbSelectAll.AutoSize = True
        Me.chbSelectAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.chbSelectAll.Location = New System.Drawing.Point(3, 315)
        Me.chbSelectAll.Name = "chbSelectAll"
        Me.chbSelectAll.Size = New System.Drawing.Size(88, 19)
        Me.chbSelectAll.TabIndex = 463
        Me.chbSelectAll.Text = "Select All"
        Me.chbSelectAll.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 461
        Me.Label4.Text = "Accession ID"
        '
        'txtAccessionID
        '
        Me.txtAccessionID.BackColor = System.Drawing.Color.White
        Me.txtAccessionID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessionID.Location = New System.Drawing.Point(109, 3)
        Me.txtAccessionID.MaxLength = 10
        Me.txtAccessionID.Name = "txtAccessionID"
        Me.txtAccessionID.Size = New System.Drawing.Size(127, 25)
        Me.txtAccessionID.TabIndex = 465
        '
        'btnRemoveFromList
        '
        Me.btnRemoveFromList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveFromList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveFromList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFromList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFromList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFromList.Location = New System.Drawing.Point(92, 310)
        Me.btnRemoveFromList.Name = "btnRemoveFromList"
        Me.btnRemoveFromList.Size = New System.Drawing.Size(146, 26)
        Me.btnRemoveFromList.TabIndex = 464
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
        Me.btnAddToList.Location = New System.Drawing.Point(5, 30)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(233, 26)
        Me.btnAddToList.TabIndex = 463
        Me.btnAddToList.Text = "Add to List"
        Me.btnAddToList.UseVisualStyleBackColor = False
        '
        'dgvAccessionList
        '
        Me.dgvAccessionList.AllowUserToAddRows = False
        Me.dgvAccessionList.AllowUserToDeleteRows = False
        Me.dgvAccessionList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAccessionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAccessionList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAccessionList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAccessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccessionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccessionList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAccessionList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAccessionList.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAccessionList.Location = New System.Drawing.Point(5, 60)
        Me.dgvAccessionList.MultiSelect = False
        Me.dgvAccessionList.Name = "dgvAccessionList"
        Me.dgvAccessionList.ReadOnly = True
        Me.dgvAccessionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccessionList.Size = New System.Drawing.Size(233, 244)
        Me.dgvAccessionList.TabIndex = 462
        '
        'Column1
        '
        Me.Column1.FillWeight = 20.0!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 60.0!
        Me.Column2.HeaderText = "Accession ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'FormAddBookCopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 489)
        Me.Controls.Add(Me.pnlManualList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddBookCopy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAddBookCopy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddBookCopy"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlManualList.ResumeLayout(False)
        Me.pnlManualList.PerformLayout()
        CType(Me.dgvAccessionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbtManualList As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtAutoGenerate As System.Windows.Forms.RadioButton
    Friend WithEvents btnShelf As System.Windows.Forms.Button
    Friend WithEvents cboShelfSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboShelf As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhp As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents cboAquisition As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCopyNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddBookCopy As System.Windows.Forms.Button
    Friend WithEvents pnlManualList As System.Windows.Forms.Panel
    Friend WithEvents dgvAccessionList As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAccessionID As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveFromList As System.Windows.Forms.Button
    Friend WithEvents btnAddToList As System.Windows.Forms.Button
    Friend WithEvents cboQuality As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chbSelectAll As System.Windows.Forms.CheckBox
End Class
