<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookShelfSectionNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBookShelfSectionNew))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookshelfSection = New System.Windows.Forms.TextBox()
        Me.dgvBookshelfSection = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSaveAll = New System.Windows.Forms.Button()
        Me.btnRemoveFromList = New System.Windows.Forms.Button()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvBookshelfSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(306, 49)
        Me.Panel4.TabIndex = 431
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 24)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Add New Bookshelf Section"
        '
        'txtBookshelfSection
        '
        Me.txtBookshelfSection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookshelfSection.Location = New System.Drawing.Point(10, 68)
        Me.txtBookshelfSection.MaxLength = 256
        Me.txtBookshelfSection.Name = "txtBookshelfSection"
        Me.txtBookshelfSection.Size = New System.Drawing.Size(284, 26)
        Me.txtBookshelfSection.TabIndex = 435
        Me.txtBookshelfSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvBookshelfSection
        '
        Me.dgvBookshelfSection.AllowUserToAddRows = False
        Me.dgvBookshelfSection.AllowUserToDeleteRows = False
        Me.dgvBookshelfSection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBookshelfSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookshelfSection.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBookshelfSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBookshelfSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookshelfSection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookshelfSection.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBookshelfSection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBookshelfSection.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvBookshelfSection.Location = New System.Drawing.Point(10, 132)
        Me.dgvBookshelfSection.MultiSelect = False
        Me.dgvBookshelfSection.Name = "dgvBookshelfSection"
        Me.dgvBookshelfSection.ReadOnly = True
        Me.dgvBookshelfSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookshelfSection.Size = New System.Drawing.Size(284, 226)
        Me.dgvBookshelfSection.TabIndex = 432
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
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bookshelf Section"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'btnSaveAll
        '
        Me.btnSaveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAll.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAll.Image = CType(resources.GetObject("btnSaveAll.Image"), System.Drawing.Image)
        Me.btnSaveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveAll.Location = New System.Drawing.Point(115, 364)
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(179, 32)
        Me.btnSaveAll.TabIndex = 436
        Me.btnSaveAll.Text = "Save All"
        Me.btnSaveAll.UseVisualStyleBackColor = False
        '
        'btnRemoveFromList
        '
        Me.btnRemoveFromList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveFromList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveFromList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFromList.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFromList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveFromList.Location = New System.Drawing.Point(136, 100)
        Me.btnRemoveFromList.Name = "btnRemoveFromList"
        Me.btnRemoveFromList.Size = New System.Drawing.Size(158, 26)
        Me.btnRemoveFromList.TabIndex = 434
        Me.btnRemoveFromList.Text = "Remove From List"
        Me.btnRemoveFromList.UseVisualStyleBackColor = False
        '
        'btnAddToList
        '
        Me.btnAddToList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddToList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToList.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddToList.Location = New System.Drawing.Point(10, 100)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(120, 26)
        Me.btnAddToList.TabIndex = 433
        Me.btnAddToList.Text = "Add To List"
        Me.btnAddToList.UseVisualStyleBackColor = False
        '
        'FormBookShelfSectionNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 402)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtBookshelfSection)
        Me.Controls.Add(Me.dgvBookshelfSection)
        Me.Controls.Add(Me.btnSaveAll)
        Me.Controls.Add(Me.btnRemoveFromList)
        Me.Controls.Add(Me.btnAddToList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormBookShelfSectionNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvBookshelfSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookshelfSection As System.Windows.Forms.TextBox
    Friend WithEvents dgvBookshelfSection As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSaveAll As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFromList As System.Windows.Forms.Button
    Friend WithEvents btnAddToList As System.Windows.Forms.Button
End Class
