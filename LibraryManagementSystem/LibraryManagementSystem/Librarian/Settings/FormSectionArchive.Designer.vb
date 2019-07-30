<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSectionArchive
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblLevelName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvSectionArchived = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvSectionArchived, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblLevelName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(317, 43)
        Me.Panel5.TabIndex = 427
        '
        'lblLevelName
        '
        Me.lblLevelName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLevelName.AutoSize = True
        Me.lblLevelName.BackColor = System.Drawing.Color.Transparent
        Me.lblLevelName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelName.ForeColor = System.Drawing.Color.White
        Me.lblLevelName.Location = New System.Drawing.Point(109, 9)
        Me.lblLevelName.Name = "lblLevelName"
        Me.lblLevelName.Size = New System.Drawing.Size(89, 24)
        Me.lblLevelName.TabIndex = 206
        Me.lblLevelName.Text = "Grade 1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvSectionArchived)
        Me.Panel3.Location = New System.Drawing.Point(12, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 292)
        Me.Panel3.TabIndex = 428
        '
        'dgvSectionArchived
        '
        Me.dgvSectionArchived.AllowUserToAddRows = False
        Me.dgvSectionArchived.AllowUserToDeleteRows = False
        Me.dgvSectionArchived.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSectionArchived.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSectionArchived.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSectionArchived.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSectionArchived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSectionArchived.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSectionArchived.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSectionArchived.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSectionArchived.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvSectionArchived.Location = New System.Drawing.Point(15, 14)
        Me.dgvSectionArchived.MultiSelect = False
        Me.dgvSectionArchived.Name = "dgvSectionArchived"
        Me.dgvSectionArchived.ReadOnly = True
        Me.dgvSectionArchived.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSectionArchived.Size = New System.Drawing.Size(264, 263)
        Me.dgvSectionArchived.TabIndex = 317
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
        Me.Column2.HeaderText = "Section Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnRestore)
        Me.Panel1.Location = New System.Drawing.Point(12, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 48)
        Me.Panel1.TabIndex = 429
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(152, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 26)
        Me.btnClose.TabIndex = 430
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRestore.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestore.Location = New System.Drawing.Point(35, 10)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(104, 26)
        Me.btnRestore.TabIndex = 429
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'FormSectionArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 416)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSectionArchive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSectionArchive"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvSectionArchived, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblLevelName As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvSectionArchived As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
End Class
