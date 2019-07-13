<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1StudentLevelSection
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.panelStudentType = New System.Windows.Forms.Panel()
        Me.rbtJuniorHigh = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtElementary = New System.Windows.Forms.RadioButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.panelOrder = New System.Windows.Forms.Panel()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.cboLevelOrder = New System.Windows.Forms.ComboBox()
        Me.rbtBefore = New System.Windows.Forms.RadioButton()
        Me.rbtAfter = New System.Windows.Forms.RadioButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumberSections = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvSection = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.btnViewArchive = New System.Windows.Forms.Button()
        Me.btnRemoveSec = New System.Windows.Forms.Button()
        Me.btnEditSec = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvLevel = New System.Windows.Forms.DataGridView()
        Me.panelStudentType.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.panelOrder.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Student Level"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 247
        Me.Label3.Text = "Level"
        '
        'txtLevel
        '
        Me.txtLevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLevel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Location = New System.Drawing.Point(101, 6)
        Me.txtLevel.MaxLength = 256
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(310, 26)
        Me.txtLevel.TabIndex = 246
        Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panelStudentType
        '
        Me.panelStudentType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelStudentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelStudentType.Controls.Add(Me.rbtJuniorHigh)
        Me.panelStudentType.Controls.Add(Me.Label4)
        Me.panelStudentType.Controls.Add(Me.rbtElementary)
        Me.panelStudentType.Location = New System.Drawing.Point(13, 70)
        Me.panelStudentType.Name = "panelStudentType"
        Me.panelStudentType.Size = New System.Drawing.Size(421, 45)
        Me.panelStudentType.TabIndex = 434
        '
        'rbtJuniorHigh
        '
        Me.rbtJuniorHigh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtJuniorHigh.AutoSize = True
        Me.rbtJuniorHigh.Location = New System.Drawing.Point(286, 14)
        Me.rbtJuniorHigh.Name = "rbtJuniorHigh"
        Me.rbtJuniorHigh.Size = New System.Drawing.Size(78, 17)
        Me.rbtJuniorHigh.TabIndex = 259
        Me.rbtJuniorHigh.TabStop = True
        Me.rbtJuniorHigh.Text = "Junior High"
        Me.rbtJuniorHigh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "Student Type"
        '
        'rbtElementary
        '
        Me.rbtElementary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtElementary.AutoSize = True
        Me.rbtElementary.Location = New System.Drawing.Point(151, 14)
        Me.rbtElementary.Name = "rbtElementary"
        Me.rbtElementary.Size = New System.Drawing.Size(77, 17)
        Me.rbtElementary.TabIndex = 258
        Me.rbtElementary.TabStop = True
        Me.rbtElementary.Text = "Elementary"
        Me.rbtElementary.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.btnRemove)
        Me.Panel7.Controls.Add(Me.btnEdit)
        Me.Panel7.Controls.Add(Me.btnAdd)
        Me.Panel7.Location = New System.Drawing.Point(13, 167)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(96, 170)
        Me.Panel7.TabIndex = 434
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(10, 129)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(74, 32)
        Me.btnRemove.TabIndex = 50
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(10, 91)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(74, 32)
        Me.btnEdit.TabIndex = 49
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(10, 53)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(74, 32)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'panelOrder
        '
        Me.panelOrder.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOrder.Controls.Add(Me.lblOrder)
        Me.panelOrder.Controls.Add(Me.cboLevelOrder)
        Me.panelOrder.Controls.Add(Me.rbtBefore)
        Me.panelOrder.Controls.Add(Me.rbtAfter)
        Me.panelOrder.Location = New System.Drawing.Point(115, 343)
        Me.panelOrder.Name = "panelOrder"
        Me.panelOrder.Size = New System.Drawing.Size(319, 63)
        Me.panelOrder.TabIndex = 433
        '
        'lblOrder
        '
        Me.lblOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblOrder.Location = New System.Drawing.Point(16, 35)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(51, 20)
        Me.lblOrder.TabIndex = 252
        Me.lblOrder.Text = "Order :"
        '
        'cboLevelOrder
        '
        Me.cboLevelOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLevelOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevelOrder.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLevelOrder.FormattingEnabled = True
        Me.cboLevelOrder.Items.AddRange(New Object() {"Administrator", "Librarian", "Staff", "Student Assistant"})
        Me.cboLevelOrder.Location = New System.Drawing.Point(79, 35)
        Me.cboLevelOrder.Name = "cboLevelOrder"
        Me.cboLevelOrder.Size = New System.Drawing.Size(230, 23)
        Me.cboLevelOrder.TabIndex = 251
        '
        'rbtBefore
        '
        Me.rbtBefore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtBefore.AutoSize = True
        Me.rbtBefore.Location = New System.Drawing.Point(184, 12)
        Me.rbtBefore.Name = "rbtBefore"
        Me.rbtBefore.Size = New System.Drawing.Size(59, 17)
        Me.rbtBefore.TabIndex = 249
        Me.rbtBefore.TabStop = True
        Me.rbtBefore.Text = "Berfore"
        Me.rbtBefore.UseVisualStyleBackColor = True
        '
        'rbtAfter
        '
        Me.rbtAfter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtAfter.AutoSize = True
        Me.rbtAfter.Location = New System.Drawing.Point(79, 12)
        Me.rbtAfter.Name = "rbtAfter"
        Me.rbtAfter.Size = New System.Drawing.Size(47, 17)
        Me.rbtAfter.TabIndex = 250
        Me.rbtAfter.TabStop = True
        Me.rbtAfter.Text = "After"
        Me.rbtAfter.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.txtLevel)
        Me.Panel9.Location = New System.Drawing.Point(13, 121)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(421, 40)
        Me.Panel9.TabIndex = 435
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(682, 434)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 32)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(114, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Section"
        '
        'lblNumberSections
        '
        Me.lblNumberSections.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNumberSections.AutoSize = True
        Me.lblNumberSections.BackColor = System.Drawing.Color.Transparent
        Me.lblNumberSections.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberSections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblNumberSections.Location = New System.Drawing.Point(9, 49)
        Me.lblNumberSections.Name = "lblNumberSections"
        Me.lblNumberSections.Size = New System.Drawing.Size(128, 15)
        Me.lblNumberSections.TabIndex = 207
        Me.lblNumberSections.Text = "Number of Section/s: "
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvSection)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.lblNumberSections)
        Me.Panel3.Controls.Add(Me.btnViewArchive)
        Me.Panel3.Controls.Add(Me.btnRemoveSec)
        Me.Panel3.Controls.Add(Me.btnEditSec)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(462, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(328, 417)
        Me.Panel3.TabIndex = 50
        '
        'dgvSection
        '
        Me.dgvSection.AllowUserToAddRows = False
        Me.dgvSection.AllowUserToDeleteRows = False
        Me.dgvSection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSection.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSection.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSection.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvSection.Location = New System.Drawing.Point(12, 69)
        Me.dgvSection.MultiSelect = False
        Me.dgvSection.Name = "dgvSection"
        Me.dgvSection.ReadOnly = True
        Me.dgvSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSection.Size = New System.Drawing.Size(301, 246)
        Me.dgvSection.TabIndex = 437
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Section Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.txtSection)
        Me.Panel5.Location = New System.Drawing.Point(12, 321)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(301, 40)
        Me.Panel5.TabIndex = 436
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 247
        Me.Label5.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(75, 6)
        Me.txtSection.MaxLength = 256
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(216, 26)
        Me.txtSection.TabIndex = 246
        Me.txtSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnViewArchive
        '
        Me.btnViewArchive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewArchive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnViewArchive.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewArchive.ForeColor = System.Drawing.Color.Black
        Me.btnViewArchive.Location = New System.Drawing.Point(219, 46)
        Me.btnViewArchive.Name = "btnViewArchive"
        Me.btnViewArchive.Size = New System.Drawing.Size(104, 21)
        Me.btnViewArchive.TabIndex = 43
        Me.btnViewArchive.Text = "View Archive"
        Me.btnViewArchive.UseVisualStyleBackColor = True
        '
        'btnRemoveSec
        '
        Me.btnRemoveSec.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRemoveSec.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveSec.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSec.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveSec.Location = New System.Drawing.Point(111, 367)
        Me.btnRemoveSec.Name = "btnRemoveSec"
        Me.btnRemoveSec.Size = New System.Drawing.Size(202, 26)
        Me.btnRemoveSec.TabIndex = 216
        Me.btnRemoveSec.Text = "Remove Section"
        Me.btnRemoveSec.UseVisualStyleBackColor = False
        '
        'btnEditSec
        '
        Me.btnEditSec.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditSec.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSec.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSec.ForeColor = System.Drawing.Color.Black
        Me.btnEditSec.Location = New System.Drawing.Point(12, 367)
        Me.btnEditSec.Name = "btnEditSec"
        Me.btnEditSec.Size = New System.Drawing.Size(93, 26)
        Me.btnEditSec.TabIndex = 215
        Me.btnEditSec.Text = "Edit Section"
        Me.btnEditSec.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 43)
        Me.Panel4.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(148, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Student Level"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 43)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dgvLevel)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.panelStudentType)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.panelOrder)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 417)
        Me.Panel2.TabIndex = 49
        '
        'dgvLevel
        '
        Me.dgvLevel.AllowUserToAddRows = False
        Me.dgvLevel.AllowUserToDeleteRows = False
        Me.dgvLevel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLevel.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvLevel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLevel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLevel.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLevel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLevel.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvLevel.Location = New System.Drawing.Point(115, 167)
        Me.dgvLevel.MultiSelect = False
        Me.dgvLevel.Name = "dgvLevel"
        Me.dgvLevel.ReadOnly = True
        Me.dgvLevel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLevel.Size = New System.Drawing.Size(319, 170)
        Me.dgvLevel.TabIndex = 436
        '
        'Form1StudentLevelSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 479)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1StudentLevelSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1StudentLevelSection"
        Me.panelStudentType.ResumeLayout(False)
        Me.panelStudentType.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.panelOrder.ResumeLayout(False)
        Me.panelOrder.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents panelStudentType As System.Windows.Forms.Panel
    Friend WithEvents rbtJuniorHigh As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtElementary As System.Windows.Forms.RadioButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents panelOrder As System.Windows.Forms.Panel
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents cboLevelOrder As System.Windows.Forms.ComboBox
    Friend WithEvents rbtBefore As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAfter As System.Windows.Forms.RadioButton
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumberSections As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvSection As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents btnViewArchive As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSec As System.Windows.Forms.Button
    Friend WithEvents btnEditSec As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvLevel As System.Windows.Forms.DataGridView
End Class
