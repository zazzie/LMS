<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployeePosition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployeePosition))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvPosition = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddPosition = New System.Windows.Forms.Button()
        Me.btnRemovePosition = New System.Windows.Forms.Button()
        Me.btnEditPosition = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvPosition)
        Me.Panel3.Location = New System.Drawing.Point(12, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(362, 254)
        Me.Panel3.TabIndex = 438
        '
        'dgvPosition
        '
        Me.dgvPosition.AllowUserToAddRows = False
        Me.dgvPosition.AllowUserToDeleteRows = False
        Me.dgvPosition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPosition.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPosition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosition.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPosition.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPosition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPosition.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvPosition.Location = New System.Drawing.Point(15, 14)
        Me.dgvPosition.MultiSelect = False
        Me.dgvPosition.Name = "dgvPosition"
        Me.dgvPosition.ReadOnly = True
        Me.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPosition.Size = New System.Drawing.Size(333, 225)
        Me.dgvPosition.TabIndex = 317
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
        Me.Column2.HeaderText = "Position"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(386, 43)
        Me.Panel5.TabIndex = 439
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(97, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Employee Position"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPosition)
        Me.Panel1.Location = New System.Drawing.Point(12, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 48)
        Me.Panel1.TabIndex = 440
        '
        'txtPosition
        '
        Me.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPosition.Enabled = False
        Me.txtPosition.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(11, 10)
        Me.txtPosition.MaxLength = 256
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(339, 26)
        Me.txtPosition.TabIndex = 420
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddPosition)
        Me.Panel2.Controls.Add(Me.btnRemovePosition)
        Me.Panel2.Controls.Add(Me.btnEditPosition)
        Me.Panel2.Location = New System.Drawing.Point(12, 372)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 48)
        Me.Panel2.TabIndex = 441
        '
        'btnAddPosition
        '
        Me.btnAddPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPosition.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPosition.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPosition.Image = CType(resources.GetObject("btnAddPosition.Image"), System.Drawing.Image)
        Me.btnAddPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPosition.Location = New System.Drawing.Point(11, 10)
        Me.btnAddPosition.Name = "btnAddPosition"
        Me.btnAddPosition.Size = New System.Drawing.Size(104, 26)
        Me.btnAddPosition.TabIndex = 428
        Me.btnAddPosition.Text = "Add"
        Me.btnAddPosition.UseVisualStyleBackColor = False
        '
        'btnRemovePosition
        '
        Me.btnRemovePosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemovePosition.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemovePosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemovePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemovePosition.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovePosition.Image = CType(resources.GetObject("btnRemovePosition.Image"), System.Drawing.Image)
        Me.btnRemovePosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemovePosition.Location = New System.Drawing.Point(237, 10)
        Me.btnRemovePosition.Name = "btnRemovePosition"
        Me.btnRemovePosition.Size = New System.Drawing.Size(111, 26)
        Me.btnRemovePosition.TabIndex = 430
        Me.btnRemovePosition.Text = "Remove"
        Me.btnRemovePosition.UseVisualStyleBackColor = False
        '
        'btnEditPosition
        '
        Me.btnEditPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditPosition.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPosition.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPosition.Image = CType(resources.GetObject("btnEditPosition.Image"), System.Drawing.Image)
        Me.btnEditPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditPosition.Location = New System.Drawing.Point(124, 10)
        Me.btnEditPosition.Name = "btnEditPosition"
        Me.btnEditPosition.Size = New System.Drawing.Size(104, 26)
        Me.btnEditPosition.TabIndex = 429
        Me.btnEditPosition.Text = "Edit"
        Me.btnEditPosition.UseVisualStyleBackColor = False
        '
        'FormEmployeePosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 429)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormEmployeePosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEmployeePosition"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvPosition As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddPosition As System.Windows.Forms.Button
    Friend WithEvents btnRemovePosition As System.Windows.Forms.Button
    Friend WithEvents btnEditPosition As System.Windows.Forms.Button
End Class
