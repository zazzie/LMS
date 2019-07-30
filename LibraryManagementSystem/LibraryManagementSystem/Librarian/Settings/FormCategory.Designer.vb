<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCategory))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.btnRemoveCategory = New System.Windows.Forms.Button()
        Me.btnEditCategory = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.txtCategoryId = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvCategory)
        Me.Panel3.Location = New System.Drawing.Point(13, 247)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(484, 234)
        Me.Panel3.TabIndex = 445
        '
        'dgvCategory
        '
        Me.dgvCategory.AllowUserToAddRows = False
        Me.dgvCategory.AllowUserToDeleteRows = False
        Me.dgvCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCategory.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategory.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCategory.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvCategory.Location = New System.Drawing.Point(15, 14)
        Me.dgvCategory.MultiSelect = False
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.Size = New System.Drawing.Size(455, 205)
        Me.dgvCategory.TabIndex = 317
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(666, 43)
        Me.Panel5.TabIndex = 444
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(287, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Category"
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCategory.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCategory.Image = CType(resources.GetObject("btnAddCategory.Image"), System.Drawing.Image)
        Me.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddCategory.Location = New System.Drawing.Point(12, 307)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(126, 26)
        Me.btnAddCategory.TabIndex = 428
        Me.btnAddCategory.Text = "Add"
        Me.btnAddCategory.UseVisualStyleBackColor = False
        '
        'btnRemoveCategory
        '
        Me.btnRemoveCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveCategory.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveCategory.Image = CType(resources.GetObject("btnRemoveCategory.Image"), System.Drawing.Image)
        Me.btnRemoveCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveCategory.Location = New System.Drawing.Point(12, 371)
        Me.btnRemoveCategory.Name = "btnRemoveCategory"
        Me.btnRemoveCategory.Size = New System.Drawing.Size(126, 26)
        Me.btnRemoveCategory.TabIndex = 430
        Me.btnRemoveCategory.Text = "Remove"
        Me.btnRemoveCategory.UseVisualStyleBackColor = False
        '
        'btnEditCategory
        '
        Me.btnEditCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCategory.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCategory.Image = CType(resources.GetObject("btnEditCategory.Image"), System.Drawing.Image)
        Me.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditCategory.Location = New System.Drawing.Point(12, 339)
        Me.btnEditCategory.Name = "btnEditCategory"
        Me.btnEditCategory.Size = New System.Drawing.Size(126, 26)
        Me.btnEditCategory.TabIndex = 429
        Me.btnEditCategory.Text = "Edit"
        Me.btnEditCategory.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddCategory)
        Me.Panel2.Controls.Add(Me.btnRemoveCategory)
        Me.Panel2.Controls.Add(Me.btnEditCategory)
        Me.Panel2.Location = New System.Drawing.Point(502, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(153, 423)
        Me.Panel2.TabIndex = 447
        '
        'rtbDescription
        '
        Me.rtbDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rtbDescription.Location = New System.Drawing.Point(123, 73)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(348, 94)
        Me.rtbDescription.TabIndex = 437
        Me.rtbDescription.Text = ""
        '
        'txtCategoryId
        '
        Me.txtCategoryId.BackColor = System.Drawing.Color.White
        Me.txtCategoryId.Enabled = False
        Me.txtCategoryId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryId.Location = New System.Drawing.Point(123, 14)
        Me.txtCategoryId.MaxLength = 10
        Me.txtCategoryId.Name = "txtCategoryId"
        Me.txtCategoryId.Size = New System.Drawing.Size(229, 23)
        Me.txtCategoryId.TabIndex = 434
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 15)
        Me.Label12.TabIndex = 432
        Me.Label12.Text = "Category Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(35, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 436
        Me.Label8.Text = "Description"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.rtbDescription)
        Me.Panel1.Controls.Add(Me.txtCategoryId)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCategoryName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 183)
        Me.Panel1.TabIndex = 446
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(34, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 433
        Me.Label1.Text = "Category ID"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.BackColor = System.Drawing.Color.White
        Me.txtCategoryName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryName.Location = New System.Drawing.Point(123, 44)
        Me.txtCategoryName.MaxLength = 256
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(348, 23)
        Me.txtCategoryName.TabIndex = 435
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.Location = New System.Drawing.Point(358, 12)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(113, 26)
        Me.btnGenerate.TabIndex = 462
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 40.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Category"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'FormCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 494)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCategory"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvCategory As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddCategory As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCategory As System.Windows.Forms.Button
    Friend WithEvents btnEditCategory As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCategoryId As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
End Class
