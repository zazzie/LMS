<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarangayCity
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBarangay = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBarangay = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveBrgy = New System.Windows.Forms.Button()
        Me.btnEditBrgy = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.dgvCity = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemoveCity = New System.Windows.Forms.Button()
        Me.btnEditCity = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddCity = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBarangay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 395)
        Me.Panel1.TabIndex = 417
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dgvBarangay)
        Me.Panel2.Controls.Add(Me.txtBarangay)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnRemoveBrgy)
        Me.Panel2.Controls.Add(Me.btnEditBrgy)
        Me.Panel2.Location = New System.Drawing.Point(311, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(307, 381)
        Me.Panel2.TabIndex = 3
        '
        'dgvBarangay
        '
        Me.dgvBarangay.AllowUserToAddRows = False
        Me.dgvBarangay.AllowUserToDeleteRows = False
        Me.dgvBarangay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBarangay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBarangay.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBarangay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBarangay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarangay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBarangay.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBarangay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBarangay.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvBarangay.Location = New System.Drawing.Point(3, 43)
        Me.dgvBarangay.MultiSelect = False
        Me.dgvBarangay.Name = "dgvBarangay"
        Me.dgvBarangay.ReadOnly = True
        Me.dgvBarangay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarangay.Size = New System.Drawing.Size(299, 263)
        Me.dgvBarangay.TabIndex = 421
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Barangay"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'txtBarangay
        '
        Me.txtBarangay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarangay.Enabled = False
        Me.txtBarangay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarangay.Location = New System.Drawing.Point(19, 315)
        Me.txtBarangay.MaxLength = 256
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(262, 26)
        Me.txtBarangay.TabIndex = 420
        Me.txtBarangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(305, 43)
        Me.Panel4.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(102, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Barangay"
        '
        'btnRemoveBrgy
        '
        Me.btnRemoveBrgy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveBrgy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveBrgy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveBrgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveBrgy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveBrgy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveBrgy.Location = New System.Drawing.Point(119, 347)
        Me.btnRemoveBrgy.Name = "btnRemoveBrgy"
        Me.btnRemoveBrgy.Size = New System.Drawing.Size(161, 26)
        Me.btnRemoveBrgy.TabIndex = 419
        Me.btnRemoveBrgy.Text = "Remove"
        Me.btnRemoveBrgy.UseVisualStyleBackColor = False
        '
        'btnEditBrgy
        '
        Me.btnEditBrgy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditBrgy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditBrgy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditBrgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBrgy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBrgy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditBrgy.Location = New System.Drawing.Point(19, 347)
        Me.btnEditBrgy.Name = "btnEditBrgy"
        Me.btnEditBrgy.Size = New System.Drawing.Size(94, 26)
        Me.btnEditBrgy.TabIndex = 418
        Me.btnEditBrgy.Text = "Edit"
        Me.btnEditBrgy.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtCity)
        Me.Panel3.Controls.Add(Me.dgvCity)
        Me.Panel3.Controls.Add(Me.btnRemoveCity)
        Me.Panel3.Controls.Add(Me.btnEditCity)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.btnAddCity)
        Me.Panel3.Location = New System.Drawing.Point(6, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 381)
        Me.Panel3.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCity.Enabled = False
        Me.txtCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(23, 315)
        Me.txtCity.MaxLength = 256
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(251, 26)
        Me.txtCity.TabIndex = 415
        Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvCity
        '
        Me.dgvCity.AllowUserToAddRows = False
        Me.dgvCity.AllowUserToDeleteRows = False
        Me.dgvCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCity.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCity.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCity.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvCity.Location = New System.Drawing.Point(3, 43)
        Me.dgvCity.MultiSelect = False
        Me.dgvCity.Name = "dgvCity"
        Me.dgvCity.ReadOnly = True
        Me.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCity.Size = New System.Drawing.Size(292, 263)
        Me.dgvCity.TabIndex = 317
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
        Me.Column2.HeaderText = "City"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btnRemoveCity
        '
        Me.btnRemoveCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveCity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveCity.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveCity.Location = New System.Drawing.Point(195, 350)
        Me.btnRemoveCity.Name = "btnRemoveCity"
        Me.btnRemoveCity.Size = New System.Drawing.Size(79, 26)
        Me.btnRemoveCity.TabIndex = 414
        Me.btnRemoveCity.Text = "Remove"
        Me.btnRemoveCity.UseVisualStyleBackColor = False
        '
        'btnEditCity
        '
        Me.btnEditCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditCity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCity.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditCity.Location = New System.Drawing.Point(109, 350)
        Me.btnEditCity.Name = "btnEditCity"
        Me.btnEditCity.Size = New System.Drawing.Size(79, 26)
        Me.btnEditCity.TabIndex = 413
        Me.btnEditCity.Text = "Edit"
        Me.btnEditCity.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(298, 43)
        Me.Panel5.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(128, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "City"
        '
        'btnAddCity
        '
        Me.btnAddCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCity.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddCity.Location = New System.Drawing.Point(23, 350)
        Me.btnAddCity.Name = "btnAddCity"
        Me.btnAddCity.Size = New System.Drawing.Size(79, 26)
        Me.btnAddCity.TabIndex = 412
        Me.btnAddCity.Text = "Add"
        Me.btnAddCity.UseVisualStyleBackColor = False
        '
        'FormBarangayCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 404)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormBarangayCity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBarangayCity"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvBarangay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvCity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvBarangay As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBarangay As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveBrgy As System.Windows.Forms.Button
    Friend WithEvents btnEditBrgy As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents dgvCity As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveCity As System.Windows.Forms.Button
    Friend WithEvents btnEditCity As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddCity As System.Windows.Forms.Button
End Class
