<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageAccount
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageAccount))
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSearchId = New System.Windows.Forms.Button()
        Me.btnSearchAll = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnViewUser = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearchName
        '
        Me.btnSearchName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchName.Location = New System.Drawing.Point(910, 54)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(159, 26)
        Me.btnSearchName.TabIndex = 463
        Me.btnSearchName.Text = "Search Name"
        Me.btnSearchName.UseVisualStyleBackColor = False
        '
        'Column3
        '
        Me.Column3.FillWeight = 20.0!
        Me.Column3.HeaderText = "Login Status"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 30.0!
        Me.Column1.HeaderText = "Username"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUser.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvUser.Location = New System.Drawing.Point(13, 16)
        Me.dgvUser.MultiSelect = False
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.Size = New System.Drawing.Size(1026, 464)
        Me.dgvUser.TabIndex = 316
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
        Me.Label2.Size = New System.Drawing.Size(145, 19)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "      User Accounts"
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
        'btnSearchId
        '
        Me.btnSearchId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchId.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchId.Location = New System.Drawing.Point(748, 54)
        Me.btnSearchId.Name = "btnSearchId"
        Me.btnSearchId.Size = New System.Drawing.Size(157, 26)
        Me.btnSearchId.TabIndex = 459
        Me.btnSearchId.Text = "Searh Username"
        Me.btnSearchId.UseVisualStyleBackColor = False
        '
        'btnSearchAll
        '
        Me.btnSearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchAll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchAll.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAll.Location = New System.Drawing.Point(586, 54)
        Me.btnSearchAll.Name = "btnSearchAll"
        Me.btnSearchAll.Size = New System.Drawing.Size(157, 26)
        Me.btnSearchAll.TabIndex = 458
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
        Me.Panel6.TabIndex = 454
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
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.dgvUser)
        Me.Panel4.Location = New System.Drawing.Point(15, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1054, 495)
        Me.Panel4.TabIndex = 452
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
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(89, 54)
        Me.txtSearch.MaxLength = 256
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(491, 26)
        Me.txtSearch.TabIndex = 457
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
        Me.Panel3.TabIndex = 455
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Image = CType(resources.GetObject("btnDeleteUser.Image"), System.Drawing.Image)
        Me.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteUser.Location = New System.Drawing.Point(932, 611)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(134, 32)
        Me.btnDeleteUser.TabIndex = 453
        Me.btnDeleteUser.Text = "Delete"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateUser.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.Image = CType(resources.GetObject("btnUpdateUser.Image"), System.Drawing.Image)
        Me.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateUser.Location = New System.Drawing.Point(758, 611)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(168, 32)
        Me.btnUpdateUser.TabIndex = 462
        Me.btnUpdateUser.Text = "Update Details"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(475, 611)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(133, 32)
        Me.btnAddUser.TabIndex = 461
        Me.btnAddUser.Text = "Add New"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'btnViewUser
        '
        Me.btnViewUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewUser.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewUser.Image = CType(resources.GetObject("btnViewUser.Image"), System.Drawing.Image)
        Me.btnViewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewUser.Location = New System.Drawing.Point(614, 611)
        Me.btnViewUser.Name = "btnViewUser"
        Me.btnViewUser.Size = New System.Drawing.Size(138, 32)
        Me.btnViewUser.TabIndex = 460
        Me.btnViewUser.Text = "View Details"
        Me.btnViewUser.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 456
        Me.Label10.Text = "Search"
        '
        'FormManageAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 698)
        Me.Controls.Add(Me.btnSearchName)
        Me.Controls.Add(Me.btnSearchId)
        Me.Controls.Add(Me.btnSearchAll)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnViewUser)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManageAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormManageAccount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchName As System.Windows.Forms.Button
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSearchId As System.Windows.Forms.Button
    Friend WithEvents btnSearchAll As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnUpdateUser As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnViewUser As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
