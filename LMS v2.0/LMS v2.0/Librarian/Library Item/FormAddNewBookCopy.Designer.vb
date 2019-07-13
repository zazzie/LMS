<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddNewBookCopy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddNewBookCopy))
        Me.rbtSingleCopy = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtMultiCopy = New System.Windows.Forms.RadioButton()
        Me.lblNumberCopy = New System.Windows.Forms.Label()
        Me.btnShelf = New System.Windows.Forms.Button()
        Me.cboShelfSection = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboShelf = New System.Windows.Forms.ComboBox()
        Me.lblPhp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboAquisition = New System.Windows.Forms.ComboBox()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccession1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAccession2 = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtSingleCopy
        '
        Me.rbtSingleCopy.AutoSize = True
        Me.rbtSingleCopy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSingleCopy.Location = New System.Drawing.Point(13, 10)
        Me.rbtSingleCopy.Name = "rbtSingleCopy"
        Me.rbtSingleCopy.Size = New System.Drawing.Size(102, 19)
        Me.rbtSingleCopy.TabIndex = 290
        Me.rbtSingleCopy.TabStop = True
        Me.rbtSingleCopy.Text = "Single Copy"
        Me.rbtSingleCopy.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtMultiCopy)
        Me.Panel1.Controls.Add(Me.rbtSingleCopy)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 44)
        Me.Panel1.TabIndex = 450
        '
        'rbtMultiCopy
        '
        Me.rbtMultiCopy.AutoSize = True
        Me.rbtMultiCopy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMultiCopy.Location = New System.Drawing.Point(166, 10)
        Me.rbtMultiCopy.Name = "rbtMultiCopy"
        Me.rbtMultiCopy.Size = New System.Drawing.Size(129, 19)
        Me.rbtMultiCopy.TabIndex = 291
        Me.rbtMultiCopy.TabStop = True
        Me.rbtMultiCopy.Text = "Mulltiple Copies"
        Me.rbtMultiCopy.UseVisualStyleBackColor = True
        '
        'lblNumberCopy
        '
        Me.lblNumberCopy.AutoSize = True
        Me.lblNumberCopy.BackColor = System.Drawing.Color.Transparent
        Me.lblNumberCopy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberCopy.ForeColor = System.Drawing.Color.Black
        Me.lblNumberCopy.Location = New System.Drawing.Point(163, 37)
        Me.lblNumberCopy.Name = "lblNumberCopy"
        Me.lblNumberCopy.Size = New System.Drawing.Size(50, 12)
        Me.lblNumberCopy.TabIndex = 461
        Me.lblNumberCopy.Text = "(1 copy)"
        '
        'btnShelf
        '
        Me.btnShelf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShelf.BackColor = System.Drawing.Color.Maroon
        Me.btnShelf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnShelf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShelf.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShelf.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnShelf.Location = New System.Drawing.Point(398, 122)
        Me.btnShelf.Name = "btnShelf"
        Me.btnShelf.Size = New System.Drawing.Size(31, 23)
        Me.btnShelf.TabIndex = 460
        Me.btnShelf.Text = "..."
        Me.btnShelf.UseVisualStyleBackColor = False
        '
        'cboShelfSection
        '
        Me.cboShelfSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShelfSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShelfSection.FormattingEnabled = True
        Me.cboShelfSection.Location = New System.Drawing.Point(166, 152)
        Me.cboShelfSection.Name = "cboShelfSection"
        Me.cboShelfSection.Size = New System.Drawing.Size(226, 23)
        Me.cboShelfSection.TabIndex = 459
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(32, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 15)
        Me.Label7.TabIndex = 458
        Me.Label7.Text = "Book Shelf Section"
        '
        'cboShelf
        '
        Me.cboShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShelf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShelf.FormattingEnabled = True
        Me.cboShelf.Location = New System.Drawing.Point(166, 122)
        Me.cboShelf.Name = "cboShelf"
        Me.cboShelf.Size = New System.Drawing.Size(226, 23)
        Me.cboShelf.TabIndex = 457
        '
        'lblPhp
        '
        Me.lblPhp.AutoSize = True
        Me.lblPhp.BackColor = System.Drawing.Color.Transparent
        Me.lblPhp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhp.ForeColor = System.Drawing.Color.Black
        Me.lblPhp.Location = New System.Drawing.Point(393, 95)
        Me.lblPhp.Name = "lblPhp"
        Me.lblPhp.Size = New System.Drawing.Size(99, 15)
        Me.lblPhp.TabIndex = 456
        Me.lblPhp.Text = "Php (per item)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(11, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(199, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "        Add New Book Copy"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(500, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(543, 37)
        Me.Panel6.TabIndex = 448
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(166, 91)
        Me.txtPrice.MaxLength = 10
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(226, 23)
        Me.txtPrice.TabIndex = 455
        '
        'cboAquisition
        '
        Me.cboAquisition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAquisition.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAquisition.FormattingEnabled = True
        Me.cboAquisition.Items.AddRange(New Object() {"BOUGHT BY SCHOOL", "DONATED", "REPLACED COPY"})
        Me.cboAquisition.Location = New System.Drawing.Point(166, 62)
        Me.cboAquisition.Name = "cboAquisition"
        Me.cboAquisition.Size = New System.Drawing.Size(226, 23)
        Me.cboAquisition.TabIndex = 454
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.BackColor = System.Drawing.Color.Transparent
        Me.lblDash.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDash.ForeColor = System.Drawing.Color.Black
        Me.lblDash.Location = New System.Drawing.Point(312, 15)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(11, 15)
        Me.lblDash.TabIndex = 438
        Me.lblDash.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(85, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 437
        Me.Label1.Text = "Book Shelf"
        '
        'txtAccession1
        '
        Me.txtAccession1.BackColor = System.Drawing.Color.White
        Me.txtAccession1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccession1.Location = New System.Drawing.Point(166, 11)
        Me.txtAccession1.MaxLength = 10
        Me.txtAccession1.Name = "txtAccession1"
        Me.txtAccession1.Size = New System.Drawing.Size(140, 23)
        Me.txtAccession1.TabIndex = 434
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(88, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 432
        Me.Label2.Text = "Aquisition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 15)
        Me.Label3.TabIndex = 433
        Me.Label3.Text = "Accession Number"
        '
        'txtAccession2
        '
        Me.txtAccession2.BackColor = System.Drawing.Color.White
        Me.txtAccession2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccession2.Location = New System.Drawing.Point(329, 11)
        Me.txtAccession2.MaxLength = 256
        Me.txtAccession2.Name = "txtAccession2"
        Me.txtAccession2.Size = New System.Drawing.Size(140, 23)
        Me.txtAccession2.TabIndex = 435
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Black
        Me.lblPrice.Location = New System.Drawing.Point(118, 95)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(42, 15)
        Me.lblPrice.TabIndex = 436
        Me.lblPrice.Text = "Price"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblNumberCopy)
        Me.Panel2.Controls.Add(Me.btnShelf)
        Me.Panel2.Controls.Add(Me.cboShelfSection)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cboShelf)
        Me.Panel2.Controls.Add(Me.lblPhp)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.cboAquisition)
        Me.Panel2.Controls.Add(Me.lblDash)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtAccession1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtAccession2)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Location = New System.Drawing.Point(12, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 199)
        Me.Panel2.TabIndex = 449
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(405, 315)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 27)
        Me.btnCancel.TabIndex = 447
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAddBook
        '
        Me.btnAddBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Image = CType(resources.GetObject("btnAddBook.Image"), System.Drawing.Image)
        Me.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBook.Location = New System.Drawing.Point(193, 315)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(208, 27)
        Me.btnAddBook.TabIndex = 446
        Me.btnAddBook.Text = "Add New Book Copy"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'FormAddNewBookCopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 354)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAddNewBookCopy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbtSingleCopy As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtMultiCopy As System.Windows.Forms.RadioButton
    Friend WithEvents lblNumberCopy As System.Windows.Forms.Label
    Friend WithEvents btnShelf As System.Windows.Forms.Button
    Friend WithEvents cboShelfSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboShelf As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhp As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents cboAquisition As System.Windows.Forms.ComboBox
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccession1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAccession2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
End Class
