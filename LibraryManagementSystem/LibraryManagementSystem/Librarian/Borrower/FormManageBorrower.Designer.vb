<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageBorrower))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearchBorrowerId = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnSearchAll = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvBorrower = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteBorrower = New System.Windows.Forms.Button()
        Me.btnUpdateBorrower = New System.Windows.Forms.Button()
        Me.rbtShowCurrent = New System.Windows.Forms.RadioButton()
        Me.rbtShowAll = New System.Windows.Forms.RadioButton()
        Me.btnAddBorrower = New System.Windows.Forms.Button()
        Me.btnViewBorrower = New System.Windows.Forms.Button()
        Me.btnImportBorrower = New System.Windows.Forms.Button()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvBorrower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchBorrowerId
        '
        Me.btnSearchBorrowerId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchBorrowerId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchBorrowerId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchBorrowerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBorrowerId.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrowerId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBorrowerId.Location = New System.Drawing.Point(746, 64)
        Me.btnSearchBorrowerId.Name = "btnSearchBorrowerId"
        Me.btnSearchBorrowerId.Size = New System.Drawing.Size(157, 26)
        Me.btnSearchBorrowerId.TabIndex = 444
        Me.btnSearchBorrowerId.Text = "Search Borrower ID"
        Me.btnSearchBorrowerId.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(88, 64)
        Me.txtSearch.MaxLength = 256
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(489, 26)
        Me.txtSearch.TabIndex = 441
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblDate)
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 658)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1084, 40)
        Me.Panel3.TabIndex = 439
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
        'btnSearchAll
        '
        Me.btnSearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchAll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchAll.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAll.Location = New System.Drawing.Point(583, 64)
        Me.btnSearchAll.Name = "btnSearchAll"
        Me.btnSearchAll.Size = New System.Drawing.Size(157, 26)
        Me.btnSearchAll.TabIndex = 443
        Me.btnSearchAll.Text = "Search All"
        Me.btnSearchAll.UseVisualStyleBackColor = False
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
        Me.Panel6.Size = New System.Drawing.Size(1084, 37)
        Me.Panel6.TabIndex = 438
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
        Me.btnBack.Location = New System.Drawing.Point(944, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(138, 35)
        Me.btnBack.TabIndex = 219
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(21, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 19)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "      Borrower List"
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 440
        Me.Label10.Text = "Search"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.dgvBorrower)
        Me.Panel4.Location = New System.Drawing.Point(15, 141)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1054, 454)
        Me.Panel4.TabIndex = 436
        '
        'dgvBorrower
        '
        Me.dgvBorrower.AllowUserToAddRows = False
        Me.dgvBorrower.AllowUserToDeleteRows = False
        Me.dgvBorrower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBorrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBorrower.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBorrower.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrower.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrower.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBorrower.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBorrower.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvBorrower.Location = New System.Drawing.Point(13, 16)
        Me.dgvBorrower.MultiSelect = False
        Me.dgvBorrower.Name = "dgvBorrower"
        Me.dgvBorrower.ReadOnly = True
        Me.dgvBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrower.Size = New System.Drawing.Size(1026, 423)
        Me.dgvBorrower.TabIndex = 316
        '
        'Column1
        '
        Me.Column1.FillWeight = 20.0!
        Me.Column1.HeaderText = "Borrower ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btnDeleteBorrower
        '
        Me.btnDeleteBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteBorrower.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnDeleteBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBorrower.Image = CType(resources.GetObject("btnDeleteBorrower.Image"), System.Drawing.Image)
        Me.btnDeleteBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteBorrower.Location = New System.Drawing.Point(932, 611)
        Me.btnDeleteBorrower.Name = "btnDeleteBorrower"
        Me.btnDeleteBorrower.Size = New System.Drawing.Size(134, 32)
        Me.btnDeleteBorrower.TabIndex = 437
        Me.btnDeleteBorrower.Text = "Delete"
        Me.btnDeleteBorrower.UseVisualStyleBackColor = False
        '
        'btnUpdateBorrower
        '
        Me.btnUpdateBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateBorrower.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUpdateBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBorrower.Image = CType(resources.GetObject("btnUpdateBorrower.Image"), System.Drawing.Image)
        Me.btnUpdateBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateBorrower.Location = New System.Drawing.Point(473, 611)
        Me.btnUpdateBorrower.Name = "btnUpdateBorrower"
        Me.btnUpdateBorrower.Size = New System.Drawing.Size(189, 32)
        Me.btnUpdateBorrower.TabIndex = 450
        Me.btnUpdateBorrower.Text = "Update Borrower"
        Me.btnUpdateBorrower.UseVisualStyleBackColor = False
        '
        'rbtShowCurrent
        '
        Me.rbtShowCurrent.AutoSize = True
        Me.rbtShowCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtShowCurrent.Location = New System.Drawing.Point(260, 107)
        Me.rbtShowCurrent.Name = "rbtShowCurrent"
        Me.rbtShowCurrent.Size = New System.Drawing.Size(182, 18)
        Me.rbtShowCurrent.TabIndex = 449
        Me.rbtShowCurrent.TabStop = True
        Me.rbtShowCurrent.Text = "Show Currently Registered"
        Me.rbtShowCurrent.UseVisualStyleBackColor = True
        '
        'rbtShowAll
        '
        Me.rbtShowAll.AutoSize = True
        Me.rbtShowAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtShowAll.Location = New System.Drawing.Point(90, 107)
        Me.rbtShowAll.Name = "rbtShowAll"
        Me.rbtShowAll.Size = New System.Drawing.Size(133, 18)
        Me.rbtShowAll.TabIndex = 448
        Me.rbtShowAll.TabStop = True
        Me.rbtShowAll.Text = "Show All Borrower"
        Me.rbtShowAll.UseVisualStyleBackColor = True
        '
        'btnAddBorrower
        '
        Me.btnAddBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBorrower.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBorrower.Image = CType(resources.GetObject("btnAddBorrower.Image"), System.Drawing.Image)
        Me.btnAddBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBorrower.Location = New System.Drawing.Point(190, 611)
        Me.btnAddBorrower.Name = "btnAddBorrower"
        Me.btnAddBorrower.Size = New System.Drawing.Size(133, 32)
        Me.btnAddBorrower.TabIndex = 447
        Me.btnAddBorrower.Text = "Add New"
        Me.btnAddBorrower.UseVisualStyleBackColor = False
        '
        'btnViewBorrower
        '
        Me.btnViewBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewBorrower.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnViewBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBorrower.Image = CType(resources.GetObject("btnViewBorrower.Image"), System.Drawing.Image)
        Me.btnViewBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewBorrower.Location = New System.Drawing.Point(329, 611)
        Me.btnViewBorrower.Name = "btnViewBorrower"
        Me.btnViewBorrower.Size = New System.Drawing.Size(138, 32)
        Me.btnViewBorrower.TabIndex = 446
        Me.btnViewBorrower.Text = "View Details"
        Me.btnViewBorrower.UseVisualStyleBackColor = False
        '
        'btnImportBorrower
        '
        Me.btnImportBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportBorrower.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImportBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnImportBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportBorrower.Image = CType(resources.GetObject("btnImportBorrower.Image"), System.Drawing.Image)
        Me.btnImportBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportBorrower.Location = New System.Drawing.Point(668, 611)
        Me.btnImportBorrower.Name = "btnImportBorrower"
        Me.btnImportBorrower.Size = New System.Drawing.Size(258, 32)
        Me.btnImportBorrower.TabIndex = 445
        Me.btnImportBorrower.Text = "    Add To Current School Year"
        Me.btnImportBorrower.UseVisualStyleBackColor = False
        '
        'btnSearchName
        '
        Me.btnSearchName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchName.Location = New System.Drawing.Point(909, 64)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(157, 26)
        Me.btnSearchName.TabIndex = 442
        Me.btnSearchName.Text = "Search Name"
        Me.btnSearchName.UseVisualStyleBackColor = False
        '
        'FormManageBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 698)
        Me.Controls.Add(Me.btnSearchBorrowerId)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSearchAll)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnDeleteBorrower)
        Me.Controls.Add(Me.btnUpdateBorrower)
        Me.Controls.Add(Me.rbtShowCurrent)
        Me.Controls.Add(Me.rbtShowAll)
        Me.Controls.Add(Me.btnAddBorrower)
        Me.Controls.Add(Me.btnViewBorrower)
        Me.Controls.Add(Me.btnImportBorrower)
        Me.Controls.Add(Me.btnSearchName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManageBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormManageBorrower"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvBorrower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchBorrowerId As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnSearchAll As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgvBorrower As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteBorrower As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBorrower As System.Windows.Forms.Button
    Friend WithEvents rbtShowCurrent As System.Windows.Forms.RadioButton
    Friend WithEvents rbtShowAll As System.Windows.Forms.RadioButton
    Friend WithEvents btnAddBorrower As System.Windows.Forms.Button
    Friend WithEvents btnViewBorrower As System.Windows.Forms.Button
    Friend WithEvents btnImportBorrower As System.Windows.Forms.Button
    Friend WithEvents btnSearchName As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
