<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookShelf
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShelf = New System.Windows.Forms.TextBox()
        Me.dgvBookShelf = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvShelfSection = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRemoveShelf = New System.Windows.Forms.Button()
        Me.btnEditShelf = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddShelf = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShelfSection = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnRemoveShelfSection = New System.Windows.Forms.Button()
        Me.btnEditShelfSection = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvBookShelf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvShelfSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Book Shelf"
        '
        'txtShelf
        '
        Me.txtShelf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShelf.Enabled = False
        Me.txtShelf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShelf.Location = New System.Drawing.Point(23, 315)
        Me.txtShelf.MaxLength = 256
        Me.txtShelf.Name = "txtShelf"
        Me.txtShelf.Size = New System.Drawing.Size(251, 26)
        Me.txtShelf.TabIndex = 415
        Me.txtShelf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvBookShelf
        '
        Me.dgvBookShelf.AllowUserToAddRows = False
        Me.dgvBookShelf.AllowUserToDeleteRows = False
        Me.dgvBookShelf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBookShelf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookShelf.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBookShelf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBookShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookShelf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookShelf.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBookShelf.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBookShelf.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvBookShelf.Location = New System.Drawing.Point(3, 43)
        Me.dgvBookShelf.MultiSelect = False
        Me.dgvBookShelf.Name = "dgvBookShelf"
        Me.dgvBookShelf.ReadOnly = True
        Me.dgvBookShelf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookShelf.Size = New System.Drawing.Size(292, 263)
        Me.dgvBookShelf.TabIndex = 317
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
        Me.Column2.HeaderText = "Book Shelf"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'dgvShelfSection
        '
        Me.dgvShelfSection.AllowUserToAddRows = False
        Me.dgvShelfSection.AllowUserToDeleteRows = False
        Me.dgvShelfSection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShelfSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShelfSection.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvShelfSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvShelfSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShelfSection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvShelfSection.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvShelfSection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvShelfSection.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvShelfSection.Location = New System.Drawing.Point(3, 43)
        Me.dgvShelfSection.MultiSelect = False
        Me.dgvShelfSection.Name = "dgvShelfSection"
        Me.dgvShelfSection.ReadOnly = True
        Me.dgvShelfSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShelfSection.Size = New System.Drawing.Size(355, 263)
        Me.dgvShelfSection.TabIndex = 421
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
        Me.DataGridViewTextBoxColumn2.HeaderText = "Shelf Section"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtShelf)
        Me.Panel3.Controls.Add(Me.dgvBookShelf)
        Me.Panel3.Controls.Add(Me.btnRemoveShelf)
        Me.Panel3.Controls.Add(Me.btnEditShelf)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.btnAddShelf)
        Me.Panel3.Location = New System.Drawing.Point(6, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 381)
        Me.Panel3.TabIndex = 2
        '
        'btnRemoveShelf
        '
        Me.btnRemoveShelf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveShelf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveShelf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveShelf.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveShelf.Location = New System.Drawing.Point(195, 350)
        Me.btnRemoveShelf.Name = "btnRemoveShelf"
        Me.btnRemoveShelf.Size = New System.Drawing.Size(79, 26)
        Me.btnRemoveShelf.TabIndex = 414
        Me.btnRemoveShelf.Text = "Remove"
        Me.btnRemoveShelf.UseVisualStyleBackColor = False
        '
        'btnEditShelf
        '
        Me.btnEditShelf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditShelf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditShelf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditShelf.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditShelf.Location = New System.Drawing.Point(109, 350)
        Me.btnEditShelf.Name = "btnEditShelf"
        Me.btnEditShelf.Size = New System.Drawing.Size(79, 26)
        Me.btnEditShelf.TabIndex = 413
        Me.btnEditShelf.Text = "Edit"
        Me.btnEditShelf.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(298, 43)
        Me.Panel5.TabIndex = 28
        '
        'btnAddShelf
        '
        Me.btnAddShelf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddShelf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddShelf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddShelf.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddShelf.Location = New System.Drawing.Point(23, 350)
        Me.btnAddShelf.Name = "btnAddShelf"
        Me.btnAddShelf.Size = New System.Drawing.Size(79, 26)
        Me.btnAddShelf.TabIndex = 412
        Me.btnAddShelf.Text = "Add"
        Me.btnAddShelf.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(111, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Shelf Section"
        '
        'txtShelfSection
        '
        Me.txtShelfSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShelfSection.Enabled = False
        Me.txtShelfSection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShelfSection.Location = New System.Drawing.Point(19, 315)
        Me.txtShelfSection.MaxLength = 256
        Me.txtShelfSection.Name = "txtShelfSection"
        Me.txtShelfSection.Size = New System.Drawing.Size(318, 26)
        Me.txtShelfSection.TabIndex = 420
        Me.txtShelfSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(361, 43)
        Me.Panel4.TabIndex = 29
        '
        'btnRemoveShelfSection
        '
        Me.btnRemoveShelfSection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveShelfSection.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveShelfSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveShelfSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveShelfSection.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveShelfSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveShelfSection.Location = New System.Drawing.Point(119, 347)
        Me.btnRemoveShelfSection.Name = "btnRemoveShelfSection"
        Me.btnRemoveShelfSection.Size = New System.Drawing.Size(217, 26)
        Me.btnRemoveShelfSection.TabIndex = 419
        Me.btnRemoveShelfSection.Text = "Remove"
        Me.btnRemoveShelfSection.UseVisualStyleBackColor = False
        '
        'btnEditShelfSection
        '
        Me.btnEditShelfSection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditShelfSection.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditShelfSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditShelfSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditShelfSection.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditShelfSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditShelfSection.Location = New System.Drawing.Point(19, 347)
        Me.btnEditShelfSection.Name = "btnEditShelfSection"
        Me.btnEditShelfSection.Size = New System.Drawing.Size(94, 26)
        Me.btnEditShelfSection.TabIndex = 418
        Me.btnEditShelfSection.Text = "Edit"
        Me.btnEditShelfSection.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dgvShelfSection)
        Me.Panel2.Controls.Add(Me.txtShelfSection)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnRemoveShelfSection)
        Me.Panel2.Controls.Add(Me.btnEditShelfSection)
        Me.Panel2.Location = New System.Drawing.Point(311, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 381)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 395)
        Me.Panel1.TabIndex = 416
        '
        'FormBookShelf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 404)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormBookShelf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvBookShelf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvShelfSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShelf As System.Windows.Forms.TextBox
    Friend WithEvents dgvBookShelf As System.Windows.Forms.DataGridView
    Friend WithEvents dgvShelfSection As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnRemoveShelf As System.Windows.Forms.Button
    Friend WithEvents btnEditShelf As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnAddShelf As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShelfSection As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnRemoveShelfSection As System.Windows.Forms.Button
    Friend WithEvents btnEditShelfSection As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
