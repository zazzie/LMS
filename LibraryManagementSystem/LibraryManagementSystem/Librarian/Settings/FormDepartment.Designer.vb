<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDepartment))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddDepartment = New System.Windows.Forms.Button()
        Me.btnRemoveDepartment = New System.Windows.Forms.Button()
        Me.btnEditDepartment = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlLevel = New System.Windows.Forms.Panel()
        Me.rbtCol = New System.Windows.Forms.RadioButton()
        Me.rbtSH = New System.Windows.Forms.RadioButton()
        Me.rbtJH = New System.Windows.Forms.RadioButton()
        Me.rbtElem = New System.Windows.Forms.RadioButton()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvDepartment = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.pnlLevel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddDepartment)
        Me.Panel2.Controls.Add(Me.btnRemoveDepartment)
        Me.Panel2.Controls.Add(Me.btnEditDepartment)
        Me.Panel2.Location = New System.Drawing.Point(12, 425)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 48)
        Me.Panel2.TabIndex = 470
        '
        'btnAddDepartment
        '
        Me.btnAddDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDepartment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDepartment.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDepartment.Image = CType(resources.GetObject("btnAddDepartment.Image"), System.Drawing.Image)
        Me.btnAddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDepartment.Location = New System.Drawing.Point(15, 10)
        Me.btnAddDepartment.Name = "btnAddDepartment"
        Me.btnAddDepartment.Size = New System.Drawing.Size(143, 26)
        Me.btnAddDepartment.TabIndex = 428
        Me.btnAddDepartment.Text = "Add"
        Me.btnAddDepartment.UseVisualStyleBackColor = False
        '
        'btnRemoveDepartment
        '
        Me.btnRemoveDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveDepartment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveDepartment.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveDepartment.Image = CType(resources.GetObject("btnRemoveDepartment.Image"), System.Drawing.Image)
        Me.btnRemoveDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveDepartment.Location = New System.Drawing.Point(361, 10)
        Me.btnRemoveDepartment.Name = "btnRemoveDepartment"
        Me.btnRemoveDepartment.Size = New System.Drawing.Size(143, 26)
        Me.btnRemoveDepartment.TabIndex = 430
        Me.btnRemoveDepartment.Text = "Remove"
        Me.btnRemoveDepartment.UseVisualStyleBackColor = False
        '
        'btnEditDepartment
        '
        Me.btnEditDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditDepartment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditDepartment.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDepartment.Image = CType(resources.GetObject("btnEditDepartment.Image"), System.Drawing.Image)
        Me.btnEditDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditDepartment.Location = New System.Drawing.Point(187, 10)
        Me.btnEditDepartment.Name = "btnEditDepartment"
        Me.btnEditDepartment.Size = New System.Drawing.Size(143, 26)
        Me.btnEditDepartment.TabIndex = 429
        Me.btnEditDepartment.Text = "Edit"
        Me.btnEditDepartment.UseVisualStyleBackColor = False
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
        Me.Column2.HeaderText = "Department"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'pnlLevel
        '
        Me.pnlLevel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLevel.Controls.Add(Me.rbtCol)
        Me.pnlLevel.Controls.Add(Me.rbtSH)
        Me.pnlLevel.Controls.Add(Me.rbtJH)
        Me.pnlLevel.Controls.Add(Me.rbtElem)
        Me.pnlLevel.Location = New System.Drawing.Point(12, 59)
        Me.pnlLevel.Name = "pnlLevel"
        Me.pnlLevel.Size = New System.Drawing.Size(518, 39)
        Me.pnlLevel.TabIndex = 471
        '
        'rbtCol
        '
        Me.rbtCol.AutoSize = True
        Me.rbtCol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtCol.Location = New System.Drawing.Point(429, 10)
        Me.rbtCol.Name = "rbtCol"
        Me.rbtCol.Size = New System.Drawing.Size(75, 19)
        Me.rbtCol.TabIndex = 3
        Me.rbtCol.TabStop = True
        Me.rbtCol.Text = "College"
        Me.rbtCol.UseVisualStyleBackColor = True
        '
        'rbtSH
        '
        Me.rbtSH.AutoSize = True
        Me.rbtSH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtSH.Location = New System.Drawing.Point(290, 10)
        Me.rbtSH.Name = "rbtSH"
        Me.rbtSH.Size = New System.Drawing.Size(101, 19)
        Me.rbtSH.TabIndex = 2
        Me.rbtSH.TabStop = True
        Me.rbtSH.Text = "Senior High"
        Me.rbtSH.UseVisualStyleBackColor = True
        '
        'rbtJH
        '
        Me.rbtJH.AutoSize = True
        Me.rbtJH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtJH.Location = New System.Drawing.Point(153, 10)
        Me.rbtJH.Name = "rbtJH"
        Me.rbtJH.Size = New System.Drawing.Size(99, 19)
        Me.rbtJH.TabIndex = 1
        Me.rbtJH.TabStop = True
        Me.rbtJH.Text = "Junior High"
        Me.rbtJH.UseVisualStyleBackColor = True
        '
        'rbtElem
        '
        Me.rbtElem.AutoSize = True
        Me.rbtElem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtElem.Location = New System.Drawing.Point(15, 10)
        Me.rbtElem.Name = "rbtElem"
        Me.rbtElem.Size = New System.Drawing.Size(100, 19)
        Me.rbtElem.TabIndex = 0
        Me.rbtElem.TabStop = True
        Me.rbtElem.Text = "Elementary"
        Me.rbtElem.UseVisualStyleBackColor = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Level"
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
        Me.Panel5.Size = New System.Drawing.Size(542, 43)
        Me.Panel5.TabIndex = 468
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(206, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Department"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDepartment)
        Me.Panel1.Location = New System.Drawing.Point(12, 371)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 48)
        Me.Panel1.TabIndex = 469
        '
        'txtDepartment
        '
        Me.txtDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDepartment.Enabled = False
        Me.txtDepartment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(11, 10)
        Me.txtDepartment.MaxLength = 256
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(493, 26)
        Me.txtDepartment.TabIndex = 420
        Me.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvDepartment)
        Me.Panel3.Location = New System.Drawing.Point(12, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(518, 261)
        Me.Panel3.TabIndex = 467
        '
        'dgvDepartment
        '
        Me.dgvDepartment.AllowUserToAddRows = False
        Me.dgvDepartment.AllowUserToDeleteRows = False
        Me.dgvDepartment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDepartment.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDepartment.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDepartment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDepartment.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvDepartment.Location = New System.Drawing.Point(15, 14)
        Me.dgvDepartment.MultiSelect = False
        Me.dgvDepartment.Name = "dgvDepartment"
        Me.dgvDepartment.ReadOnly = True
        Me.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartment.Size = New System.Drawing.Size(489, 232)
        Me.dgvDepartment.TabIndex = 317
        '
        'FormDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 488)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlLevel)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDepartment"
        Me.Panel2.ResumeLayout(False)
        Me.pnlLevel.ResumeLayout(False)
        Me.pnlLevel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddDepartment As System.Windows.Forms.Button
    Friend WithEvents btnRemoveDepartment As System.Windows.Forms.Button
    Friend WithEvents btnEditDepartment As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlLevel As System.Windows.Forms.Panel
    Friend WithEvents rbtCol As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSH As System.Windows.Forms.RadioButton
    Friend WithEvents rbtJH As System.Windows.Forms.RadioButton
    Friend WithEvents rbtElem As System.Windows.Forms.RadioButton
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvDepartment As System.Windows.Forms.DataGridView
End Class
