<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCourse
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCourse))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvCourse = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnRemoveCourse = New System.Windows.Forms.Button()
        Me.btnEditCourse = New System.Windows.Forms.Button()
        Me.pnlDept = New System.Windows.Forms.Panel()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.btnDept = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlDept.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvCourse)
        Me.Panel3.Location = New System.Drawing.Point(12, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 210)
        Me.Panel3.TabIndex = 426
        '
        'dgvCourse
        '
        Me.dgvCourse.AllowUserToAddRows = False
        Me.dgvCourse.AllowUserToDeleteRows = False
        Me.dgvCourse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCourse.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCourse.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCourse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCourse.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvCourse.Location = New System.Drawing.Point(15, 14)
        Me.dgvCourse.MultiSelect = False
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.ReadOnly = True
        Me.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourse.Size = New System.Drawing.Size(443, 181)
        Me.dgvCourse.TabIndex = 317
        '
        'Column1
        '
        Me.Column1.FillWeight = 30.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Course/Program"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Department"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(496, 43)
        Me.Panel5.TabIndex = 427
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(207, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Course"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCourse)
        Me.Panel1.Location = New System.Drawing.Point(12, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 48)
        Me.Panel1.TabIndex = 428
        '
        'txtCourse
        '
        Me.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse.Enabled = False
        Me.txtCourse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(15, 10)
        Me.txtCourse.MaxLength = 256
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(443, 26)
        Me.txtCourse.TabIndex = 420
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddCourse)
        Me.Panel2.Controls.Add(Me.btnRemoveCourse)
        Me.Panel2.Controls.Add(Me.btnEditCourse)
        Me.Panel2.Location = New System.Drawing.Point(12, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 47)
        Me.Panel2.TabIndex = 429
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCourse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCourse.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.Image = CType(resources.GetObject("btnAddCourse.Image"), System.Drawing.Image)
        Me.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddCourse.Location = New System.Drawing.Point(15, 10)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(140, 26)
        Me.btnAddCourse.TabIndex = 428
        Me.btnAddCourse.Text = "Add"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'btnRemoveCourse
        '
        Me.btnRemoveCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveCourse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveCourse.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveCourse.Image = CType(resources.GetObject("btnRemoveCourse.Image"), System.Drawing.Image)
        Me.btnRemoveCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveCourse.Location = New System.Drawing.Point(325, 10)
        Me.btnRemoveCourse.Name = "btnRemoveCourse"
        Me.btnRemoveCourse.Size = New System.Drawing.Size(140, 26)
        Me.btnRemoveCourse.TabIndex = 430
        Me.btnRemoveCourse.Text = "Remove"
        Me.btnRemoveCourse.UseVisualStyleBackColor = False
        '
        'btnEditCourse
        '
        Me.btnEditCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditCourse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCourse.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCourse.Image = CType(resources.GetObject("btnEditCourse.Image"), System.Drawing.Image)
        Me.btnEditCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditCourse.Location = New System.Drawing.Point(170, 10)
        Me.btnEditCourse.Name = "btnEditCourse"
        Me.btnEditCourse.Size = New System.Drawing.Size(140, 26)
        Me.btnEditCourse.TabIndex = 429
        Me.btnEditCourse.Text = "Edit"
        Me.btnEditCourse.UseVisualStyleBackColor = False
        '
        'pnlDept
        '
        Me.pnlDept.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDept.Controls.Add(Me.cboDepartment)
        Me.pnlDept.Controls.Add(Me.btnDept)
        Me.pnlDept.Location = New System.Drawing.Point(12, 319)
        Me.pnlDept.Name = "pnlDept"
        Me.pnlDept.Size = New System.Drawing.Size(472, 49)
        Me.pnlDept.TabIndex = 429
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(15, 12)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(406, 23)
        Me.cboDepartment.TabIndex = 460
        '
        'btnDept
        '
        Me.btnDept.BackColor = System.Drawing.Color.Maroon
        Me.btnDept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDept.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDept.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDept.Location = New System.Drawing.Point(427, 12)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(31, 23)
        Me.btnDept.TabIndex = 459
        Me.btnDept.Text = "..."
        Me.btnDept.UseVisualStyleBackColor = False
        '
        'FormCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 436)
        Me.Controls.Add(Me.pnlDept)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCourse"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlDept.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvCourse As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddCourse As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCourse As System.Windows.Forms.Button
    Friend WithEvents btnEditCourse As System.Windows.Forms.Button
    Friend WithEvents pnlDept As System.Windows.Forms.Panel
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents btnDept As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
