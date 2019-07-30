<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserType))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtStaff = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtSemiAdmin = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbtAdmin = New System.Windows.Forms.RadioButton()
        Me.btnAddUserType = New System.Windows.Forms.Button()
        Me.txtUserType = New System.Windows.Forms.TextBox()
        Me.btnRemoveUserType = New System.Windows.Forms.Button()
        Me.btnEditUserType = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvUserType = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvUserType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(52, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Access Type"
        '
        'rbtStaff
        '
        Me.rbtStaff.AutoSize = True
        Me.rbtStaff.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbtStaff.Location = New System.Drawing.Point(26, 205)
        Me.rbtStaff.Name = "rbtStaff"
        Me.rbtStaff.Size = New System.Drawing.Size(47, 20)
        Me.rbtStaff.TabIndex = 42
        Me.rbtStaff.TabStop = True
        Me.rbtStaff.Text = "Staff"
        Me.rbtStaff.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 68)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Access limited to processing book borrowing and returning trasactions."
        '
        'rbtSemiAdmin
        '
        Me.rbtSemiAdmin.AutoSize = True
        Me.rbtSemiAdmin.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSemiAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbtSemiAdmin.Location = New System.Drawing.Point(26, 128)
        Me.rbtSemiAdmin.Name = "rbtSemiAdmin"
        Me.rbtSemiAdmin.Size = New System.Drawing.Size(84, 20)
        Me.rbtSemiAdmin.TabIndex = 44
        Me.rbtSemiAdmin.TabStop = True
        Me.rbtSemiAdmin.Text = "Semi-Admin"
        Me.rbtSemiAdmin.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 40)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "All access of privileges available."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(38, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 47)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "With all access of privileges except with deleting of any record."
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.rbtStaff)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.rbtSemiAdmin)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.rbtAdmin)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(380, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(194, 308)
        Me.Panel4.TabIndex = 447
        '
        'rbtAdmin
        '
        Me.rbtAdmin.AutoSize = True
        Me.rbtAdmin.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbtAdmin.Location = New System.Drawing.Point(26, 52)
        Me.rbtAdmin.Name = "rbtAdmin"
        Me.rbtAdmin.Size = New System.Drawing.Size(57, 20)
        Me.rbtAdmin.TabIndex = 45
        Me.rbtAdmin.TabStop = True
        Me.rbtAdmin.Text = "Admin"
        Me.rbtAdmin.UseVisualStyleBackColor = True
        '
        'btnAddUserType
        '
        Me.btnAddUserType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddUserType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddUserType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUserType.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUserType.Image = CType(resources.GetObject("btnAddUserType.Image"), System.Drawing.Image)
        Me.btnAddUserType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUserType.Location = New System.Drawing.Point(211, 10)
        Me.btnAddUserType.Name = "btnAddUserType"
        Me.btnAddUserType.Size = New System.Drawing.Size(104, 26)
        Me.btnAddUserType.TabIndex = 428
        Me.btnAddUserType.Text = "Add"
        Me.btnAddUserType.UseVisualStyleBackColor = False
        '
        'txtUserType
        '
        Me.txtUserType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserType.Enabled = False
        Me.txtUserType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserType.Location = New System.Drawing.Point(11, 10)
        Me.txtUserType.MaxLength = 256
        Me.txtUserType.Name = "txtUserType"
        Me.txtUserType.Size = New System.Drawing.Size(339, 26)
        Me.txtUserType.TabIndex = 420
        Me.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRemoveUserType
        '
        Me.btnRemoveUserType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveUserType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveUserType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveUserType.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveUserType.Image = CType(resources.GetObject("btnRemoveUserType.Image"), System.Drawing.Image)
        Me.btnRemoveUserType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveUserType.Location = New System.Drawing.Point(437, 10)
        Me.btnRemoveUserType.Name = "btnRemoveUserType"
        Me.btnRemoveUserType.Size = New System.Drawing.Size(111, 26)
        Me.btnRemoveUserType.TabIndex = 430
        Me.btnRemoveUserType.Text = "Remove"
        Me.btnRemoveUserType.UseVisualStyleBackColor = False
        '
        'btnEditUserType
        '
        Me.btnEditUserType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditUserType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditUserType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUserType.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUserType.Image = CType(resources.GetObject("btnEditUserType.Image"), System.Drawing.Image)
        Me.btnEditUserType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditUserType.Location = New System.Drawing.Point(324, 10)
        Me.btnEditUserType.Name = "btnEditUserType"
        Me.btnEditUserType.Size = New System.Drawing.Size(104, 26)
        Me.btnEditUserType.TabIndex = 429
        Me.btnEditUserType.Text = "Edit"
        Me.btnEditUserType.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtUserType)
        Me.Panel1.Location = New System.Drawing.Point(12, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 48)
        Me.Panel1.TabIndex = 445
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(233, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "User Type"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(586, 43)
        Me.Panel5.TabIndex = 444
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
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'dgvUserType
        '
        Me.dgvUserType.AllowUserToAddRows = False
        Me.dgvUserType.AllowUserToDeleteRows = False
        Me.dgvUserType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUserType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUserType.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUserType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUserType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserType.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUserType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUserType.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvUserType.Location = New System.Drawing.Point(15, 14)
        Me.dgvUserType.MultiSelect = False
        Me.dgvUserType.Name = "dgvUserType"
        Me.dgvUserType.ReadOnly = True
        Me.dgvUserType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserType.Size = New System.Drawing.Size(333, 225)
        Me.dgvUserType.TabIndex = 317
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvUserType)
        Me.Panel3.Location = New System.Drawing.Point(12, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(362, 254)
        Me.Panel3.TabIndex = 443
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddUserType)
        Me.Panel2.Controls.Add(Me.btnRemoveUserType)
        Me.Panel2.Controls.Add(Me.btnEditUserType)
        Me.Panel2.Location = New System.Drawing.Point(12, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 48)
        Me.Panel2.TabIndex = 446
        '
        'FormUserType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 435)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUserType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUserType"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvUserType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtStaff As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtSemiAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbtAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents btnAddUserType As System.Windows.Forms.Button
    Friend WithEvents txtUserType As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveUserType As System.Windows.Forms.Button
    Friend WithEvents btnEditUserType As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvUserType As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
