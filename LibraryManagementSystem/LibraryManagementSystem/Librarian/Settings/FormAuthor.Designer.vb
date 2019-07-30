<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuthor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuthor))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAuthorFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvAuthor = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAuthorMiddle = New System.Windows.Forms.TextBox()
        Me.txtAuthorId = New System.Windows.Forms.TextBox()
        Me.txtAuthorLast = New System.Windows.Forms.TextBox()
        Me.btnRemoveAuthor = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddAuthor = New System.Windows.Forms.Button()
        Me.btnEditAuthor = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 15)
        Me.Label16.TabIndex = 454
        Me.Label16.Text = "Middle Name"
        '
        'txtAuthorFirst
        '
        Me.txtAuthorFirst.BackColor = System.Drawing.Color.White
        Me.txtAuthorFirst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorFirst.Location = New System.Drawing.Point(105, 86)
        Me.txtAuthorFirst.MaxLength = 256
        Me.txtAuthorFirst.Name = "txtAuthorFirst"
        Me.txtAuthorFirst.Size = New System.Drawing.Size(325, 23)
        Me.txtAuthorFirst.TabIndex = 453
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 450
        Me.Label1.Text = "Author ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(21, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 15)
        Me.Label12.TabIndex = 449
        Me.Label12.Text = "First Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(23, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 15)
        Me.Label13.TabIndex = 448
        Me.Label13.Text = "Last Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvAuthor)
        Me.Panel3.Location = New System.Drawing.Point(12, 173)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(418, 265)
        Me.Panel3.TabIndex = 447
        '
        'dgvAuthor
        '
        Me.dgvAuthor.AllowUserToAddRows = False
        Me.dgvAuthor.AllowUserToDeleteRows = False
        Me.dgvAuthor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAuthor.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAuthor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAuthor.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAuthor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAuthor.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAuthor.Location = New System.Drawing.Point(15, 14)
        Me.dgvAuthor.MultiSelect = False
        Me.dgvAuthor.Name = "dgvAuthor"
        Me.dgvAuthor.ReadOnly = True
        Me.dgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAuthor.Size = New System.Drawing.Size(389, 236)
        Me.dgvAuthor.TabIndex = 317
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
        Me.Column2.HeaderText = "Author Name"
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
        Me.Panel5.Size = New System.Drawing.Size(446, 43)
        Me.Panel5.TabIndex = 446
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(182, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Author"
        '
        'txtAuthorMiddle
        '
        Me.txtAuthorMiddle.BackColor = System.Drawing.Color.White
        Me.txtAuthorMiddle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorMiddle.Location = New System.Drawing.Point(105, 115)
        Me.txtAuthorMiddle.MaxLength = 256
        Me.txtAuthorMiddle.Name = "txtAuthorMiddle"
        Me.txtAuthorMiddle.Size = New System.Drawing.Size(325, 23)
        Me.txtAuthorMiddle.TabIndex = 451
        '
        'txtAuthorId
        '
        Me.txtAuthorId.BackColor = System.Drawing.Color.White
        Me.txtAuthorId.Enabled = False
        Me.txtAuthorId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorId.Location = New System.Drawing.Point(105, 57)
        Me.txtAuthorId.MaxLength = 10
        Me.txtAuthorId.Name = "txtAuthorId"
        Me.txtAuthorId.Size = New System.Drawing.Size(325, 23)
        Me.txtAuthorId.TabIndex = 452
        '
        'txtAuthorLast
        '
        Me.txtAuthorLast.BackColor = System.Drawing.Color.White
        Me.txtAuthorLast.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorLast.Location = New System.Drawing.Point(105, 144)
        Me.txtAuthorLast.MaxLength = 256
        Me.txtAuthorLast.Name = "txtAuthorLast"
        Me.txtAuthorLast.Size = New System.Drawing.Size(325, 23)
        Me.txtAuthorLast.TabIndex = 455
        '
        'btnRemoveAuthor
        '
        Me.btnRemoveAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveAuthor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveAuthor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveAuthor.Image = CType(resources.GetObject("btnRemoveAuthor.Image"), System.Drawing.Image)
        Me.btnRemoveAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveAuthor.Location = New System.Drawing.Point(277, 10)
        Me.btnRemoveAuthor.Name = "btnRemoveAuthor"
        Me.btnRemoveAuthor.Size = New System.Drawing.Size(126, 26)
        Me.btnRemoveAuthor.TabIndex = 430
        Me.btnRemoveAuthor.Text = "Remove"
        Me.btnRemoveAuthor.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAddAuthor)
        Me.Panel2.Controls.Add(Me.btnRemoveAuthor)
        Me.Panel2.Controls.Add(Me.btnEditAuthor)
        Me.Panel2.Location = New System.Drawing.Point(12, 444)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 48)
        Me.Panel2.TabIndex = 456
        '
        'btnAddAuthor
        '
        Me.btnAddAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAuthor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAuthor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAuthor.Image = CType(resources.GetObject("btnAddAuthor.Image"), System.Drawing.Image)
        Me.btnAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAuthor.Location = New System.Drawing.Point(15, 10)
        Me.btnAddAuthor.Name = "btnAddAuthor"
        Me.btnAddAuthor.Size = New System.Drawing.Size(126, 26)
        Me.btnAddAuthor.TabIndex = 428
        Me.btnAddAuthor.Text = "Add"
        Me.btnAddAuthor.UseVisualStyleBackColor = False
        '
        'btnEditAuthor
        '
        Me.btnEditAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditAuthor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAuthor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAuthor.Image = CType(resources.GetObject("btnEditAuthor.Image"), System.Drawing.Image)
        Me.btnEditAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditAuthor.Location = New System.Drawing.Point(146, 10)
        Me.btnEditAuthor.Name = "btnEditAuthor"
        Me.btnEditAuthor.Size = New System.Drawing.Size(126, 26)
        Me.btnEditAuthor.TabIndex = 429
        Me.btnEditAuthor.Text = "Edit"
        Me.btnEditAuthor.UseVisualStyleBackColor = False
        '
        'FormAuthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 505)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtAuthorFirst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtAuthorMiddle)
        Me.Controls.Add(Me.txtAuthorId)
        Me.Controls.Add(Me.txtAuthorLast)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAuthor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAuthor"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvAuthor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAuthorFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvAuthor As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAuthorMiddle As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorId As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorLast As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveAuthor As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddAuthor As System.Windows.Forms.Button
    Friend WithEvents btnEditAuthor As System.Windows.Forms.Button
End Class
