<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddNewItemUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddNewItemUnit))
        Me.rbtSingleQuantity = New System.Windows.Forms.RadioButton()
        Me.lblNumberCopy = New System.Windows.Forms.Label()
        Me.lblPhp = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboAquisition = New System.Windows.Forms.ComboBox()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.txtID1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtMultiQuantity = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtID2 = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddQuantity = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtSingleQuantity
        '
        Me.rbtSingleQuantity.AutoSize = True
        Me.rbtSingleQuantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSingleQuantity.Location = New System.Drawing.Point(13, 10)
        Me.rbtSingleQuantity.Name = "rbtSingleQuantity"
        Me.rbtSingleQuantity.Size = New System.Drawing.Size(124, 19)
        Me.rbtSingleQuantity.TabIndex = 290
        Me.rbtSingleQuantity.TabStop = True
        Me.rbtSingleQuantity.Text = "Single Quantity"
        Me.rbtSingleQuantity.UseVisualStyleBackColor = True
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
        'lblPhp
        '
        Me.lblPhp.AutoSize = True
        Me.lblPhp.BackColor = System.Drawing.Color.Transparent
        Me.lblPhp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhp.ForeColor = System.Drawing.Color.Black
        Me.lblPhp.Location = New System.Drawing.Point(393, 95)
        Me.lblPhp.Name = "lblPhp"
        Me.lblPhp.Size = New System.Drawing.Size(95, 15)
        Me.lblPhp.TabIndex = 456
        Me.lblPhp.Text = "Php (per unit)"
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
        'txtID1
        '
        Me.txtID1.BackColor = System.Drawing.Color.White
        Me.txtID1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID1.Location = New System.Drawing.Point(166, 11)
        Me.txtID1.MaxLength = 10
        Me.txtID1.Name = "txtID1"
        Me.txtID1.Size = New System.Drawing.Size(140, 23)
        Me.txtID1.TabIndex = 434
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
        Me.Label3.Location = New System.Drawing.Point(82, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 433
        Me.Label3.Text = "ID per Unit"
        '
        'rbtMultiQuantity
        '
        Me.rbtMultiQuantity.AutoSize = True
        Me.rbtMultiQuantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMultiQuantity.Location = New System.Drawing.Point(166, 10)
        Me.rbtMultiQuantity.Name = "rbtMultiQuantity"
        Me.rbtMultiQuantity.Size = New System.Drawing.Size(139, 19)
        Me.rbtMultiQuantity.TabIndex = 291
        Me.rbtMultiQuantity.TabStop = True
        Me.rbtMultiQuantity.Text = "Mulltiple Quantity"
        Me.rbtMultiQuantity.UseVisualStyleBackColor = True
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
        Me.Label10.Size = New System.Drawing.Size(144, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "        Add New Unit"
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
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(543, 37)
        Me.Panel6.TabIndex = 458
        '
        'txtID2
        '
        Me.txtID2.BackColor = System.Drawing.Color.White
        Me.txtID2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID2.Location = New System.Drawing.Point(329, 11)
        Me.txtID2.MaxLength = 256
        Me.txtID2.Name = "txtID2"
        Me.txtID2.Size = New System.Drawing.Size(140, 23)
        Me.txtID2.TabIndex = 435
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
        Me.btnCancel.Location = New System.Drawing.Point(405, 242)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 27)
        Me.btnCancel.TabIndex = 457
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
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
        Me.Panel2.Controls.Add(Me.lblPhp)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.cboAquisition)
        Me.Panel2.Controls.Add(Me.lblDash)
        Me.Panel2.Controls.Add(Me.txtID1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtID2)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Location = New System.Drawing.Point(12, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 131)
        Me.Panel2.TabIndex = 459
        '
        'btnAddQuantity
        '
        Me.btnAddQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddQuantity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQuantity.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddQuantity.Image = CType(resources.GetObject("btnAddQuantity.Image"), System.Drawing.Image)
        Me.btnAddQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddQuantity.Location = New System.Drawing.Point(219, 242)
        Me.btnAddQuantity.Name = "btnAddQuantity"
        Me.btnAddQuantity.Size = New System.Drawing.Size(182, 27)
        Me.btnAddQuantity.TabIndex = 456
        Me.btnAddQuantity.Text = "Add New Unit"
        Me.btnAddQuantity.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtMultiQuantity)
        Me.Panel1.Controls.Add(Me.rbtSingleQuantity)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 44)
        Me.Panel1.TabIndex = 460
        '
        'FormAddNewItemUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 281)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnAddQuantity)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAddNewItemUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddNewItemUnit"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbtSingleQuantity As System.Windows.Forms.RadioButton
    Friend WithEvents lblNumberCopy As System.Windows.Forms.Label
    Friend WithEvents lblPhp As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents cboAquisition As System.Windows.Forms.ComboBox
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents txtID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbtMultiQuantity As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtID2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddQuantity As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
