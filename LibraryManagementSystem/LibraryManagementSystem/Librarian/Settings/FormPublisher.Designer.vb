<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPublisher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPublisher))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvPublisher = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddPublisher = New System.Windows.Forms.Button()
        Me.btnRemovePublisher = New System.Windows.Forms.Button()
        Me.btnEditPublisher = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPublisher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvPublisher)
        Me.Panel3.Location = New System.Drawing.Point(12, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(448, 254)
        Me.Panel3.TabIndex = 434
        '
        'dgvPublisher
        '
        Me.dgvPublisher.AllowUserToAddRows = False
        Me.dgvPublisher.AllowUserToDeleteRows = False
        Me.dgvPublisher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPublisher.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPublisher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPublisher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPublisher.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPublisher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPublisher.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvPublisher.Location = New System.Drawing.Point(15, 14)
        Me.dgvPublisher.MultiSelect = False
        Me.dgvPublisher.Name = "dgvPublisher"
        Me.dgvPublisher.ReadOnly = True
        Me.dgvPublisher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPublisher.Size = New System.Drawing.Size(419, 225)
        Me.dgvPublisher.TabIndex = 317
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(472, 43)
        Me.Panel5.TabIndex = 435
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(183, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Publisher"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPublisher)
        Me.Panel1.Location = New System.Drawing.Point(12, 319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 48)
        Me.Panel1.TabIndex = 436
        '
        'txtPublisher
        '
        Me.txtPublisher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPublisher.Enabled = False
        Me.txtPublisher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(54, 10)
        Me.txtPublisher.MaxLength = 256
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(339, 26)
        Me.txtPublisher.TabIndex = 420
        Me.txtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddPublisher)
        Me.Panel2.Controls.Add(Me.btnRemovePublisher)
        Me.Panel2.Controls.Add(Me.btnEditPublisher)
        Me.Panel2.Location = New System.Drawing.Point(12, 373)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 48)
        Me.Panel2.TabIndex = 437
        '
        'btnAddPublisher
        '
        Me.btnAddPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPublisher.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddPublisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPublisher.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPublisher.Image = CType(resources.GetObject("btnAddPublisher.Image"), System.Drawing.Image)
        Me.btnAddPublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPublisher.Location = New System.Drawing.Point(49, 10)
        Me.btnAddPublisher.Name = "btnAddPublisher"
        Me.btnAddPublisher.Size = New System.Drawing.Size(107, 26)
        Me.btnAddPublisher.TabIndex = 428
        Me.btnAddPublisher.Text = "Add"
        Me.btnAddPublisher.UseVisualStyleBackColor = False
        '
        'btnRemovePublisher
        '
        Me.btnRemovePublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemovePublisher.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemovePublisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemovePublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemovePublisher.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovePublisher.Image = CType(resources.GetObject("btnRemovePublisher.Image"), System.Drawing.Image)
        Me.btnRemovePublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemovePublisher.Location = New System.Drawing.Point(275, 10)
        Me.btnRemovePublisher.Name = "btnRemovePublisher"
        Me.btnRemovePublisher.Size = New System.Drawing.Size(114, 26)
        Me.btnRemovePublisher.TabIndex = 430
        Me.btnRemovePublisher.Text = "Remove"
        Me.btnRemovePublisher.UseVisualStyleBackColor = False
        '
        'btnEditPublisher
        '
        Me.btnEditPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditPublisher.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditPublisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPublisher.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPublisher.Image = CType(resources.GetObject("btnEditPublisher.Image"), System.Drawing.Image)
        Me.btnEditPublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditPublisher.Location = New System.Drawing.Point(162, 10)
        Me.btnEditPublisher.Name = "btnEditPublisher"
        Me.btnEditPublisher.Size = New System.Drawing.Size(107, 26)
        Me.btnEditPublisher.TabIndex = 429
        Me.btnEditPublisher.Text = "Edit"
        Me.btnEditPublisher.UseVisualStyleBackColor = False
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
        Me.Column2.HeaderText = "Publisher"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'FormPublisher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 429)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormPublisher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPublisher"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvPublisher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvPublisher As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddPublisher As System.Windows.Forms.Button
    Friend WithEvents btnRemovePublisher As System.Windows.Forms.Button
    Friend WithEvents btnEditPublisher As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
