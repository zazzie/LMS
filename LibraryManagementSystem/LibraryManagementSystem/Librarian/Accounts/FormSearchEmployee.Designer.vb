<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearchEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearchEmployee))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSearchName = New System.Windows.Forms.Button()
        Me.btnSearchBorrowerId = New System.Windows.Forms.Button()
        Me.btnSearchAll = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(907, 37)
        Me.Panel6.TabIndex = 448
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 19)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "      Search Employee"
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
        Me.Button3.Location = New System.Drawing.Point(864, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnSearchName
        '
        Me.btnSearchName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchName.Location = New System.Drawing.Point(772, 54)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(111, 26)
        Me.btnSearchName.TabIndex = 445
        Me.btnSearchName.Text = "Search Name"
        Me.btnSearchName.UseVisualStyleBackColor = False
        '
        'btnSearchBorrowerId
        '
        Me.btnSearchBorrowerId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchBorrowerId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchBorrowerId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchBorrowerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBorrowerId.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrowerId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBorrowerId.Location = New System.Drawing.Point(609, 54)
        Me.btnSearchBorrowerId.Name = "btnSearchBorrowerId"
        Me.btnSearchBorrowerId.Size = New System.Drawing.Size(157, 26)
        Me.btnSearchBorrowerId.TabIndex = 447
        Me.btnSearchBorrowerId.Text = "Search Employee ID"
        Me.btnSearchBorrowerId.UseVisualStyleBackColor = False
        '
        'btnSearchAll
        '
        Me.btnSearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchAll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchAll.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchAll.Location = New System.Drawing.Point(492, 54)
        Me.btnSearchAll.Name = "btnSearchAll"
        Me.btnSearchAll.Size = New System.Drawing.Size(111, 26)
        Me.btnSearchAll.TabIndex = 446
        Me.btnSearchAll.Text = "Search All"
        Me.btnSearchAll.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(73, 54)
        Me.txtSearch.MaxLength = 256
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(413, 26)
        Me.txtSearch.TabIndex = 444
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 443
        Me.Label10.Text = "Search"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.dgvEmployee)
        Me.Panel4.Location = New System.Drawing.Point(16, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(867, 396)
        Me.Panel4.TabIndex = 449
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployee.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmployee.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmployee.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvEmployee.Location = New System.Drawing.Point(13, 16)
        Me.dgvEmployee.MultiSelect = False
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        Me.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployee.Size = New System.Drawing.Size(839, 365)
        Me.dgvEmployee.TabIndex = 316
        '
        'Column1
        '
        Me.Column1.FillWeight = 30.0!
        Me.Column1.HeaderText = "Employee ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
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
        Me.btnCancel.Location = New System.Drawing.Point(760, 489)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 26)
        Me.btnCancel.TabIndex = 451
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(627, 489)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(127, 26)
        Me.btnImport.TabIndex = 450
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'FormSearchEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 528)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnSearchName)
        Me.Controls.Add(Me.btnSearchBorrowerId)
        Me.Controls.Add(Me.btnSearchAll)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnImport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSearchEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSearchEmployee"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnSearchName As System.Windows.Forms.Button
    Friend WithEvents btnSearchBorrowerId As System.Windows.Forms.Button
    Friend WithEvents btnSearchAll As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
End Class
