<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewBorrower))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCourseLabel = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRemoveRegistry = New System.Windows.Forms.Button()
        Me.btnUpdateRegistry = New System.Windows.Forms.Button()
        Me.btnAddToCurrentSY = New System.Windows.Forms.Button()
        Me.dgvRegistry = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBorrowerPhoto = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labelEMPSCHLYR = New System.Windows.Forms.Label()
        Me.labelPOSITION = New System.Windows.Forms.Label()
        Me.LabelSCHOOLYEAR = New System.Windows.Forms.Label()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSemesterLabel = New System.Windows.Forms.Label()
        Me.labelSECTION = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.LabelLEVEL = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblBorrowerType = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblBorrowerId = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpPersonalInfo.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvRegistry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picBorrowerPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAddress.AutoEllipsis = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(169, 148)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(227, 77)
        Me.lblAddress.TabIndex = 437
        Me.lblAddress.Text = "Address"
        '
        'lblCourseLabel
        '
        Me.lblCourseLabel.AutoSize = True
        Me.lblCourseLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseLabel.ForeColor = System.Drawing.Color.Black
        Me.lblCourseLabel.Location = New System.Drawing.Point(92, 86)
        Me.lblCourseLabel.Name = "lblCourseLabel"
        Me.lblCourseLabel.Size = New System.Drawing.Size(61, 15)
        Me.lblCourseLabel.TabIndex = 426
        Me.lblCourseLabel.Text = "Course :"
        Me.lblCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(919, 697)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 26)
        Me.btnClose.TabIndex = 426
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPersonalInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpPersonalInfo.Controls.Add(Me.Panel5)
        Me.grpPersonalInfo.Controls.Add(Me.Panel4)
        Me.grpPersonalInfo.Controls.Add(Me.Panel3)
        Me.grpPersonalInfo.Controls.Add(Me.Panel2)
        Me.grpPersonalInfo.Location = New System.Drawing.Point(31, 54)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(1010, 637)
        Me.grpPersonalInfo.TabIndex = 424
        Me.grpPersonalInfo.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnRemoveRegistry)
        Me.Panel5.Controls.Add(Me.btnUpdateRegistry)
        Me.Panel5.Controls.Add(Me.btnAddToCurrentSY)
        Me.Panel5.Controls.Add(Me.dgvRegistry)
        Me.Panel5.Location = New System.Drawing.Point(486, 28)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(505, 349)
        Me.Panel5.TabIndex = 440
        '
        'btnRemoveRegistry
        '
        Me.btnRemoveRegistry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveRegistry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemoveRegistry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRemoveRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveRegistry.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveRegistry.Image = CType(resources.GetObject("btnRemoveRegistry.Image"), System.Drawing.Image)
        Me.btnRemoveRegistry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveRegistry.Location = New System.Drawing.Point(342, 310)
        Me.btnRemoveRegistry.Name = "btnRemoveRegistry"
        Me.btnRemoveRegistry.Size = New System.Drawing.Size(146, 26)
        Me.btnRemoveRegistry.TabIndex = 424
        Me.btnRemoveRegistry.Text = "Remove"
        Me.btnRemoveRegistry.UseVisualStyleBackColor = False
        '
        'btnUpdateRegistry
        '
        Me.btnUpdateRegistry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateRegistry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateRegistry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUpdateRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateRegistry.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRegistry.Image = CType(resources.GetObject("btnUpdateRegistry.Image"), System.Drawing.Image)
        Me.btnUpdateRegistry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateRegistry.Location = New System.Drawing.Point(203, 310)
        Me.btnUpdateRegistry.Name = "btnUpdateRegistry"
        Me.btnUpdateRegistry.Size = New System.Drawing.Size(133, 26)
        Me.btnUpdateRegistry.TabIndex = 423
        Me.btnUpdateRegistry.Text = "Update"
        Me.btnUpdateRegistry.UseVisualStyleBackColor = False
        '
        'btnAddToCurrentSY
        '
        Me.btnAddToCurrentSY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddToCurrentSY.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddToCurrentSY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAddToCurrentSY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCurrentSY.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCurrentSY.Image = CType(resources.GetObject("btnAddToCurrentSY.Image"), System.Drawing.Image)
        Me.btnAddToCurrentSY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddToCurrentSY.Location = New System.Drawing.Point(197, 12)
        Me.btnAddToCurrentSY.Name = "btnAddToCurrentSY"
        Me.btnAddToCurrentSY.Size = New System.Drawing.Size(291, 26)
        Me.btnAddToCurrentSY.TabIndex = 422
        Me.btnAddToCurrentSY.Text = "Add To Current School Year"
        Me.btnAddToCurrentSY.UseVisualStyleBackColor = False
        '
        'dgvRegistry
        '
        Me.dgvRegistry.AllowUserToAddRows = False
        Me.dgvRegistry.AllowUserToDeleteRows = False
        Me.dgvRegistry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistry.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRegistry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistry.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistry.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRegistry.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvRegistry.Location = New System.Drawing.Point(18, 47)
        Me.dgvRegistry.MultiSelect = False
        Me.dgvRegistry.Name = "dgvRegistry"
        Me.dgvRegistry.ReadOnly = True
        Me.dgvRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistry.Size = New System.Drawing.Size(470, 250)
        Me.dgvRegistry.TabIndex = 318
        '
        'Column1
        '
        Me.Column1.FillWeight = 70.0!
        Me.Column1.HeaderText = "Registration ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "School Year"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Semester"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Location = New System.Drawing.Point(20, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(443, 296)
        Me.Panel4.TabIndex = 439
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(57, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 404
        Me.Label5.Text = "Photo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.picBorrowerPhoto)
        Me.Panel1.Location = New System.Drawing.Point(60, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 238)
        Me.Panel1.TabIndex = 403
        '
        'picBorrowerPhoto
        '
        Me.picBorrowerPhoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBorrowerPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBorrowerPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBorrowerPhoto.Location = New System.Drawing.Point(55, 16)
        Me.picBorrowerPhoto.Name = "picBorrowerPhoto"
        Me.picBorrowerPhoto.Size = New System.Drawing.Size(208, 199)
        Me.picBorrowerPhoto.TabIndex = 0
        Me.picBorrowerPhoto.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.labelEMPSCHLYR)
        Me.Panel3.Controls.Add(Me.labelPOSITION)
        Me.Panel3.Controls.Add(Me.LabelSCHOOLYEAR)
        Me.Panel3.Controls.Add(Me.lblSchoolYear)
        Me.Panel3.Controls.Add(Me.lblSemester)
        Me.Panel3.Controls.Add(Me.lblSemesterLabel)
        Me.Panel3.Controls.Add(Me.labelSECTION)
        Me.Panel3.Controls.Add(Me.lblSection)
        Me.Panel3.Controls.Add(Me.lblCourse)
        Me.Panel3.Controls.Add(Me.lblDepartment)
        Me.Panel3.Controls.Add(Me.LabelLEVEL)
        Me.Panel3.Controls.Add(Me.lblLevel)
        Me.Panel3.Controls.Add(Me.lblCourseLabel)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Location = New System.Drawing.Point(486, 383)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(505, 232)
        Me.Panel3.TabIndex = 439
        '
        'labelEMPSCHLYR
        '
        Me.labelEMPSCHLYR.AutoSize = True
        Me.labelEMPSCHLYR.BackColor = System.Drawing.Color.Transparent
        Me.labelEMPSCHLYR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEMPSCHLYR.ForeColor = System.Drawing.Color.Black
        Me.labelEMPSCHLYR.Location = New System.Drawing.Point(61, 67)
        Me.labelEMPSCHLYR.Name = "labelEMPSCHLYR"
        Me.labelEMPSCHLYR.Size = New System.Drawing.Size(92, 15)
        Me.labelEMPSCHLYR.TabIndex = 446
        Me.labelEMPSCHLYR.Text = "School Year :"
        Me.labelEMPSCHLYR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelEMPSCHLYR.Visible = False
        '
        'labelPOSITION
        '
        Me.labelPOSITION.AutoSize = True
        Me.labelPOSITION.BackColor = System.Drawing.Color.Transparent
        Me.labelPOSITION.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPOSITION.ForeColor = System.Drawing.Color.Black
        Me.labelPOSITION.Location = New System.Drawing.Point(86, 48)
        Me.labelPOSITION.Name = "labelPOSITION"
        Me.labelPOSITION.Size = New System.Drawing.Size(67, 15)
        Me.labelPOSITION.TabIndex = 445
        Me.labelPOSITION.Text = "Position :"
        Me.labelPOSITION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelPOSITION.Visible = False
        '
        'LabelSCHOOLYEAR
        '
        Me.LabelSCHOOLYEAR.AutoSize = True
        Me.LabelSCHOOLYEAR.BackColor = System.Drawing.Color.Transparent
        Me.LabelSCHOOLYEAR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSCHOOLYEAR.ForeColor = System.Drawing.Color.Black
        Me.LabelSCHOOLYEAR.Location = New System.Drawing.Point(61, 105)
        Me.LabelSCHOOLYEAR.Name = "LabelSCHOOLYEAR"
        Me.LabelSCHOOLYEAR.Size = New System.Drawing.Size(92, 15)
        Me.LabelSCHOOLYEAR.TabIndex = 443
        Me.LabelSCHOOLYEAR.Text = "School Year :"
        Me.LabelSCHOOLYEAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolYear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.ForeColor = System.Drawing.Color.Black
        Me.lblSchoolYear.Location = New System.Drawing.Point(171, 105)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(50, 15)
        Me.lblSchoolYear.TabIndex = 444
        Me.lblSchoolYear.Text = "SchlYr"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.BackColor = System.Drawing.Color.Transparent
        Me.lblSemester.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.Color.Black
        Me.lblSemester.Location = New System.Drawing.Point(171, 124)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(70, 15)
        Me.lblSemester.TabIndex = 442
        Me.lblSemester.Text = "Semester"
        '
        'lblSemesterLabel
        '
        Me.lblSemesterLabel.AutoSize = True
        Me.lblSemesterLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblSemesterLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemesterLabel.ForeColor = System.Drawing.Color.Black
        Me.lblSemesterLabel.Location = New System.Drawing.Point(76, 124)
        Me.lblSemesterLabel.Name = "lblSemesterLabel"
        Me.lblSemesterLabel.Size = New System.Drawing.Size(77, 15)
        Me.lblSemesterLabel.TabIndex = 441
        Me.lblSemesterLabel.Text = "Semester :"
        Me.lblSemesterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelSECTION
        '
        Me.labelSECTION.AutoSize = True
        Me.labelSECTION.BackColor = System.Drawing.Color.Transparent
        Me.labelSECTION.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSECTION.ForeColor = System.Drawing.Color.Black
        Me.labelSECTION.Location = New System.Drawing.Point(89, 67)
        Me.labelSECTION.Name = "labelSECTION"
        Me.labelSECTION.Size = New System.Drawing.Size(64, 15)
        Me.labelSECTION.TabIndex = 439
        Me.labelSECTION.Text = "Section :"
        Me.labelSECTION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(171, 67)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(57, 15)
        Me.lblSection.TabIndex = 440
        Me.lblSection.Text = "Section"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.Black
        Me.lblCourse.Location = New System.Drawing.Point(171, 86)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(54, 15)
        Me.lblCourse.TabIndex = 438
        Me.lblCourse.Text = "Course"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.Black
        Me.lblDepartment.Location = New System.Drawing.Point(171, 29)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(85, 15)
        Me.lblDepartment.TabIndex = 433
        Me.lblDepartment.Text = "Department"
        '
        'LabelLEVEL
        '
        Me.LabelLEVEL.AutoSize = True
        Me.LabelLEVEL.BackColor = System.Drawing.Color.Transparent
        Me.LabelLEVEL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLEVEL.ForeColor = System.Drawing.Color.Black
        Me.LabelLEVEL.Location = New System.Drawing.Point(104, 48)
        Me.LabelLEVEL.Name = "LabelLEVEL"
        Me.LabelLEVEL.Size = New System.Drawing.Size(49, 15)
        Me.LabelLEVEL.TabIndex = 425
        Me.LabelLEVEL.Text = "Level :"
        Me.LabelLEVEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.Black
        Me.lblLevel.Location = New System.Drawing.Point(171, 48)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(42, 15)
        Me.lblLevel.TabIndex = 437
        Me.lblLevel.Text = "Level"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(61, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 15)
        Me.Label19.TabIndex = 421
        Me.Label19.Text = "Department :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblAddress)
        Me.Panel2.Controls.Add(Me.lblBorrowerType)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.lblGender)
        Me.Panel2.Controls.Add(Me.lblMiddle)
        Me.Panel2.Controls.Add(Me.lblBorrowerId)
        Me.Panel2.Controls.Add(Me.lblPhone)
        Me.Panel2.Controls.Add(Me.lblFirst)
        Me.Panel2.Controls.Add(Me.lblLast)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(20, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(443, 285)
        Me.Panel2.TabIndex = 415
        '
        'lblBorrowerType
        '
        Me.lblBorrowerType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBorrowerType.AutoSize = True
        Me.lblBorrowerType.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowerType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerType.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerType.Location = New System.Drawing.Point(169, 133)
        Me.lblBorrowerType.Name = "lblBorrowerType"
        Me.lblBorrowerType.Size = New System.Drawing.Size(103, 15)
        Me.lblBorrowerType.TabIndex = 436
        Me.lblBorrowerType.Text = "Borrower Type"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(75, 148)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 15)
        Me.Label21.TabIndex = 312
        Me.Label21.Text = "Address :"
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(169, 99)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(55, 15)
        Me.lblGender.TabIndex = 432
        Me.lblGender.Text = "Gender"
        '
        'lblMiddle
        '
        Me.lblMiddle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.ForeColor = System.Drawing.Color.Black
        Me.lblMiddle.Location = New System.Drawing.Point(169, 65)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(91, 15)
        Me.lblMiddle.TabIndex = 431
        Me.lblMiddle.Text = "Middle Name"
        '
        'lblBorrowerId
        '
        Me.lblBorrowerId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBorrowerId.AutoSize = True
        Me.lblBorrowerId.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowerId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerId.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerId.Location = New System.Drawing.Point(169, 31)
        Me.lblBorrowerId.Name = "lblBorrowerId"
        Me.lblBorrowerId.Size = New System.Drawing.Size(86, 15)
        Me.lblBorrowerId.TabIndex = 430
        Me.lblBorrowerId.Text = "Borrower ID"
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Black
        Me.lblPhone.Location = New System.Drawing.Point(169, 116)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(114, 15)
        Me.lblPhone.TabIndex = 429
        Me.lblPhone.Text = "Contact Number"
        '
        'lblFirst
        '
        Me.lblFirst.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFirst.AutoSize = True
        Me.lblFirst.BackColor = System.Drawing.Color.Transparent
        Me.lblFirst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.Color.Black
        Me.lblFirst.Location = New System.Drawing.Point(169, 48)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(78, 15)
        Me.lblFirst.TabIndex = 428
        Me.lblFirst.Text = "First Name"
        '
        'lblLast
        '
        Me.lblLast.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLast.AutoSize = True
        Me.lblLast.BackColor = System.Drawing.Color.Transparent
        Me.lblLast.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.ForeColor = System.Drawing.Color.Black
        Me.lblLast.Location = New System.Drawing.Point(169, 82)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(76, 15)
        Me.lblLast.TabIndex = 427
        Me.lblLast.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(32, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 15)
        Me.Label9.TabIndex = 424
        Me.Label9.Text = "Borrower Type :"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(80, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 15)
        Me.Label17.TabIndex = 420
        Me.Label17.Text = "Gender :"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(44, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 15)
        Me.Label16.TabIndex = 419
        Me.Label16.Text = "Middle Name :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 418
        Me.Label1.Text = "Borrower ID :"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(21, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 15)
        Me.Label11.TabIndex = 417
        Me.Label11.Text = "Contact Number :"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(57, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 416
        Me.Label12.Text = "First Name :"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(59, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 415
        Me.Label13.Text = "Last Name :"
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
        Me.Label10.Size = New System.Drawing.Size(161, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "      Borrower Details"
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
        Me.Panel6.Size = New System.Drawing.Size(1065, 37)
        Me.Panel6.TabIndex = 425
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
        Me.Button3.Location = New System.Drawing.Point(1022, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FormViewBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 727)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormViewBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormViewBorrower"
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvRegistry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBorrowerPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCourseLabel As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpPersonalInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnRemoveRegistry As System.Windows.Forms.Button
    Friend WithEvents btnUpdateRegistry As System.Windows.Forms.Button
    Friend WithEvents btnAddToCurrentSY As System.Windows.Forms.Button
    Friend WithEvents dgvRegistry As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picBorrowerPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labelEMPSCHLYR As System.Windows.Forms.Label
    Friend WithEvents labelPOSITION As System.Windows.Forms.Label
    Friend WithEvents LabelSCHOOLYEAR As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblSemesterLabel As System.Windows.Forms.Label
    Friend WithEvents labelSECTION As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents LabelLEVEL As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblBorrowerType As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblMiddle As System.Windows.Forms.Label
    Friend WithEvents lblBorrowerId As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
