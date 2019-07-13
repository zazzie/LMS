<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormItemType))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvItemType = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtItemType = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddItemType = New System.Windows.Forms.Button()
        Me.btnRemoveItemType = New System.Windows.Forms.Button()
        Me.btnEditItemType = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvItemType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvItemType)
        Me.Panel3.Location = New System.Drawing.Point(12, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(362, 254)
        Me.Panel3.TabIndex = 434
        '
        'dgvItemType
        '
        Me.dgvItemType.AllowUserToAddRows = False
        Me.dgvItemType.AllowUserToDeleteRows = False
        Me.dgvItemType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemType.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvItemType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemType.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItemType.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvItemType.Location = New System.Drawing.Point(15, 14)
        Me.dgvItemType.MultiSelect = False
        Me.dgvItemType.Name = "dgvItemType"
        Me.dgvItemType.ReadOnly = True
        Me.dgvItemType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemType.Size = New System.Drawing.Size(333, 225)
        Me.dgvItemType.TabIndex = 317
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
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(386, 43)
        Me.Panel5.TabIndex = 435
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(140, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Item Type"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtItemType)
        Me.Panel1.Location = New System.Drawing.Point(12, 326)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 48)
        Me.Panel1.TabIndex = 436
        '
        'txtItemType
        '
        Me.txtItemType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItemType.Enabled = False
        Me.txtItemType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemType.Location = New System.Drawing.Point(11, 10)
        Me.txtItemType.MaxLength = 256
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(339, 26)
        Me.txtItemType.TabIndex = 420
        Me.txtItemType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddItemType)
        Me.Panel2.Controls.Add(Me.btnRemoveItemType)
        Me.Panel2.Controls.Add(Me.btnEditItemType)
        Me.Panel2.Location = New System.Drawing.Point(12, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 48)
        Me.Panel2.TabIndex = 437
        '
        'btnAddItemType
        '
        Me.btnAddItemType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItemType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddItemType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItemType.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItemType.Image = CType(resources.GetObject("btnAddItemType.Image"), System.Drawing.Image)
        Me.btnAddItemType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItemType.Location = New System.Drawing.Point(11, 10)
        Me.btnAddItemType.Name = "btnAddItemType"
        Me.btnAddItemType.Size = New System.Drawing.Size(104, 26)
        Me.btnAddItemType.TabIndex = 428
        Me.btnAddItemType.Text = "Add"
        Me.btnAddItemType.UseVisualStyleBackColor = False
        '
        'btnRemoveItemType
        '
        Me.btnRemoveItemType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveItemType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveItemType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItemType.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItemType.Image = CType(resources.GetObject("btnRemoveItemType.Image"), System.Drawing.Image)
        Me.btnRemoveItemType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveItemType.Location = New System.Drawing.Point(237, 10)
        Me.btnRemoveItemType.Name = "btnRemoveItemType"
        Me.btnRemoveItemType.Size = New System.Drawing.Size(111, 26)
        Me.btnRemoveItemType.TabIndex = 430
        Me.btnRemoveItemType.Text = "Remove"
        Me.btnRemoveItemType.UseVisualStyleBackColor = False
        '
        'btnEditItemType
        '
        Me.btnEditItemType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditItemType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditItemType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditItemType.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditItemType.Image = CType(resources.GetObject("btnEditItemType.Image"), System.Drawing.Image)
        Me.btnEditItemType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditItemType.Location = New System.Drawing.Point(124, 10)
        Me.btnEditItemType.Name = "btnEditItemType"
        Me.btnEditItemType.Size = New System.Drawing.Size(104, 26)
        Me.btnEditItemType.TabIndex = 429
        Me.btnEditItemType.Text = "Edit"
        Me.btnEditItemType.UseVisualStyleBackColor = False
        '
        'FormItemType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 435)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormItemType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormItemType"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvItemType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvItemType As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtItemType As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddItemType As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItemType As System.Windows.Forms.Button
    Friend WithEvents btnEditItemType As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
