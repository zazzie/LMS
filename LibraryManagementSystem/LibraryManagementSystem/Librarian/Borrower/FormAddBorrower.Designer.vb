<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddBorrower))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddBorrower = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.txtBorrowerMiddle = New System.Windows.Forms.TextBox()
        Me.txtBorrowerId = New System.Windows.Forms.TextBox()
        Me.btnCity = New System.Windows.Forms.Button()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBorrowerPhoto = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtBorrowerLast = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBorrowerFirst = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.rbtSchlEmployee = New System.Windows.Forms.RadioButton()
        Me.rbtStudent = New System.Windows.Forms.RadioButton()
        Me.grpBorrowerType = New System.Windows.Forms.GroupBox()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picBorrowerPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGender.SuspendLayout()
        Me.grpBorrowerType.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnCancel.Location = New System.Drawing.Point(807, 452)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 26)
        Me.btnCancel.TabIndex = 412
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAddBorrower
        '
        Me.btnAddBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBorrower.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBorrower.Image = CType(resources.GetObject("btnAddBorrower.Image"), System.Drawing.Image)
        Me.btnAddBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBorrower.Location = New System.Drawing.Point(641, 452)
        Me.btnAddBorrower.Name = "btnAddBorrower"
        Me.btnAddBorrower.Size = New System.Drawing.Size(157, 26)
        Me.btnAddBorrower.TabIndex = 411
        Me.btnAddBorrower.Text = "Add Borrower"
        Me.btnAddBorrower.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cboCity)
        Me.Panel2.Controls.Add(Me.txtBorrowerMiddle)
        Me.Panel2.Controls.Add(Me.txtBorrowerId)
        Me.Panel2.Controls.Add(Me.btnCity)
        Me.Panel2.Controls.Add(Me.cboBrgy)
        Me.Panel2.Controls.Add(Me.btnUploadPhoto)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtStreet)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtContact)
        Me.Panel2.Controls.Add(Me.txtBorrowerLast)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txtBorrowerFirst)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.grpGender)
        Me.Panel2.Controls.Add(Me.grpBorrowerType)
        Me.Panel2.Location = New System.Drawing.Point(29, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 391)
        Me.Panel2.TabIndex = 413
        '
        'cboCity
        '
        Me.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Location = New System.Drawing.Point(198, 274)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(306, 23)
        Me.cboCity.TabIndex = 434
        '
        'txtBorrowerMiddle
        '
        Me.txtBorrowerMiddle.BackColor = System.Drawing.Color.White
        Me.txtBorrowerMiddle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerMiddle.Location = New System.Drawing.Point(201, 83)
        Me.txtBorrowerMiddle.MaxLength = 256
        Me.txtBorrowerMiddle.Name = "txtBorrowerMiddle"
        Me.txtBorrowerMiddle.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerMiddle.TabIndex = 408
        '
        'txtBorrowerId
        '
        Me.txtBorrowerId.BackColor = System.Drawing.Color.White
        Me.txtBorrowerId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerId.Location = New System.Drawing.Point(201, 19)
        Me.txtBorrowerId.MaxLength = 4
        Me.txtBorrowerId.Name = "txtBorrowerId"
        Me.txtBorrowerId.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerId.TabIndex = 409
        '
        'btnCity
        '
        Me.btnCity.BackColor = System.Drawing.Color.Maroon
        Me.btnCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCity.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCity.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCity.Location = New System.Drawing.Point(510, 274)
        Me.btnCity.Name = "btnCity"
        Me.btnCity.Size = New System.Drawing.Size(31, 23)
        Me.btnCity.TabIndex = 433
        Me.btnCity.Text = "..."
        Me.btnCity.UseVisualStyleBackColor = False
        '
        'cboBrgy
        '
        Me.cboBrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrgy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Location = New System.Drawing.Point(197, 303)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(306, 23)
        Me.cboBrgy.TabIndex = 432
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUploadPhoto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUploadPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadPhoto.Location = New System.Drawing.Point(643, 322)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(157, 26)
        Me.btnUploadPhoto.TabIndex = 431
        Me.btnUploadPhoto.Text = "Upload Photo"
        Me.btnUploadPhoto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(608, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 430
        Me.Label5.Text = "Photo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.picBorrowerPhoto)
        Me.Panel1.Location = New System.Drawing.Point(555, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 279)
        Me.Panel1.TabIndex = 429
        '
        'picBorrowerPhoto
        '
        Me.picBorrowerPhoto.BackColor = System.Drawing.Color.White
        Me.picBorrowerPhoto.BackgroundImage = CType(resources.GetObject("picBorrowerPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picBorrowerPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBorrowerPhoto.Location = New System.Drawing.Point(42, 20)
        Me.picBorrowerPhoto.Name = "picBorrowerPhoto"
        Me.picBorrowerPhoto.Size = New System.Drawing.Size(242, 242)
        Me.picBorrowerPhoto.TabIndex = 0
        Me.picBorrowerPhoto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(202, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 419
        Me.Label7.Text = "+63"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(254, 256)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 15)
        Me.Label21.TabIndex = 424
        Me.Label21.Text = "ADDRESS"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(103, 311)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 15)
        Me.Label18.TabIndex = 423
        Me.Label18.Text = "Barangay"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(140, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 15)
        Me.Label15.TabIndex = 422
        Me.Label15.Text = "City"
        '
        'txtStreet
        '
        Me.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStreet.BackColor = System.Drawing.Color.White
        Me.txtStreet.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(197, 332)
        Me.txtStreet.MaxLength = 256
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(305, 23)
        Me.txtStreet.TabIndex = 421
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(70, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 420
        Me.Label9.Text = "Borrower Type"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        Me.txtContact.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(245, 217)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(259, 23)
        Me.txtContact.TabIndex = 416
        '
        'txtBorrowerLast
        '
        Me.txtBorrowerLast.BackColor = System.Drawing.Color.White
        Me.txtBorrowerLast.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerLast.Location = New System.Drawing.Point(201, 115)
        Me.txtBorrowerLast.MaxLength = 256
        Me.txtBorrowerLast.Name = "txtBorrowerLast"
        Me.txtBorrowerLast.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerLast.TabIndex = 414
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(118, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 15)
        Me.Label17.TabIndex = 412
        Me.Label17.Text = "Gender"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(82, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 15)
        Me.Label16.TabIndex = 411
        Me.Label16.Text = "Middle Name"
        '
        'txtBorrowerFirst
        '
        Me.txtBorrowerFirst.BackColor = System.Drawing.Color.White
        Me.txtBorrowerFirst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerFirst.Location = New System.Drawing.Point(201, 51)
        Me.txtBorrowerFirst.MaxLength = 256
        Me.txtBorrowerFirst.Name = "txtBorrowerFirst"
        Me.txtBorrowerFirst.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerFirst.TabIndex = 410
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(122, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 407
        Me.Label3.Text = "Street"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(87, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 406
        Me.Label1.Text = "Borrower ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(58, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 15)
        Me.Label11.TabIndex = 405
        Me.Label11.Text = "Contact Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(95, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 15)
        Me.Label12.TabIndex = 404
        Me.Label12.Text = "First Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(97, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 15)
        Me.Label13.TabIndex = 403
        Me.Label13.Text = "Last Name"
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.rbtSchlEmployee)
        Me.grpGender.Controls.Add(Me.rbtStudent)
        Me.grpGender.Location = New System.Drawing.Point(201, 176)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(303, 35)
        Me.grpGender.TabIndex = 427
        Me.grpGender.TabStop = False
        '
        'rbtSchlEmployee
        '
        Me.rbtSchlEmployee.AutoSize = True
        Me.rbtSchlEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSchlEmployee.Location = New System.Drawing.Point(148, 11)
        Me.rbtSchlEmployee.Name = "rbtSchlEmployee"
        Me.rbtSchlEmployee.Size = New System.Drawing.Size(137, 19)
        Me.rbtSchlEmployee.TabIndex = 296
        Me.rbtSchlEmployee.TabStop = True
        Me.rbtSchlEmployee.Text = "School Employee"
        Me.rbtSchlEmployee.UseVisualStyleBackColor = True
        '
        'rbtStudent
        '
        Me.rbtStudent.AutoSize = True
        Me.rbtStudent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStudent.Location = New System.Drawing.Point(6, 11)
        Me.rbtStudent.Name = "rbtStudent"
        Me.rbtStudent.Size = New System.Drawing.Size(76, 19)
        Me.rbtStudent.TabIndex = 295
        Me.rbtStudent.TabStop = True
        Me.rbtStudent.Text = "Student"
        Me.rbtStudent.UseVisualStyleBackColor = True
        '
        'grpBorrowerType
        '
        Me.grpBorrowerType.Controls.Add(Me.rbtFemale)
        Me.grpBorrowerType.Controls.Add(Me.rbtMale)
        Me.grpBorrowerType.Location = New System.Drawing.Point(201, 137)
        Me.grpBorrowerType.Name = "grpBorrowerType"
        Me.grpBorrowerType.Size = New System.Drawing.Size(303, 33)
        Me.grpBorrowerType.TabIndex = 428
        Me.grpBorrowerType.TabStop = False
        '
        'rbtFemale
        '
        Me.rbtFemale.AutoSize = True
        Me.rbtFemale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemale.Location = New System.Drawing.Point(148, 8)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(73, 19)
        Me.rbtFemale.TabIndex = 289
        Me.rbtFemale.TabStop = True
        Me.rbtFemale.Text = "Female"
        Me.rbtFemale.UseVisualStyleBackColor = True
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMale.Location = New System.Drawing.Point(6, 11)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(56, 19)
        Me.rbtMale.TabIndex = 288
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "Male"
        Me.rbtMale.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(11, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "      New Borrower"
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
        Me.Button3.Location = New System.Drawing.Point(924, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(967, 37)
        Me.Panel6.TabIndex = 410
        '
        'FormAddBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 488)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddBorrower)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAddBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddBorrower"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBorrowerPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.grpBorrowerType.ResumeLayout(False)
        Me.grpBorrowerType.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddBorrower As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboCity As System.Windows.Forms.ComboBox
    Friend WithEvents txtBorrowerMiddle As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowerId As System.Windows.Forms.TextBox
    Friend WithEvents btnCity As System.Windows.Forms.Button
    Friend WithEvents cboBrgy As System.Windows.Forms.ComboBox
    Friend WithEvents btnUploadPhoto As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picBorrowerPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowerLast As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBorrowerFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grpGender As System.Windows.Forms.GroupBox
    Friend WithEvents rbtSchlEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents rbtStudent As System.Windows.Forms.RadioButton
    Friend WithEvents grpBorrowerType As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
End Class
