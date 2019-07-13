<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudentRegistry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudentRegistry))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSemesterLabel = New System.Windows.Forms.Label()
        Me.lblBorrowerId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbtCol = New System.Windows.Forms.RadioButton()
        Me.rbtSH = New System.Windows.Forms.RadioButton()
        Me.rbtJH = New System.Windows.Forms.RadioButton()
        Me.rbtElem = New System.Windows.Forms.RadioButton()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.btnDept = New System.Windows.Forms.Button()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLevelSection = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblSchoolYear)
        Me.Panel2.Controls.Add(Me.lblSemester)
        Me.Panel2.Controls.Add(Me.lblSemesterLabel)
        Me.Panel2.Controls.Add(Me.lblBorrowerId)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(12, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(987, 58)
        Me.Panel2.TabIndex = 429
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(726, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 447
        Me.Label7.Text = "School Year :"
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolYear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.ForeColor = System.Drawing.Color.Black
        Me.lblSchoolYear.Location = New System.Drawing.Point(824, 12)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(50, 15)
        Me.lblSchoolYear.TabIndex = 448
        Me.lblSchoolYear.Text = "SchlYr"
        '
        'lblSemester
        '
        Me.lblSemester.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSemester.AutoSize = True
        Me.lblSemester.BackColor = System.Drawing.Color.Transparent
        Me.lblSemester.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.Color.Black
        Me.lblSemester.Location = New System.Drawing.Point(824, 31)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(70, 15)
        Me.lblSemester.TabIndex = 446
        Me.lblSemester.Text = "Semester"
        '
        'lblSemesterLabel
        '
        Me.lblSemesterLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSemesterLabel.AutoSize = True
        Me.lblSemesterLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblSemesterLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemesterLabel.ForeColor = System.Drawing.Color.Black
        Me.lblSemesterLabel.Location = New System.Drawing.Point(741, 31)
        Me.lblSemesterLabel.Name = "lblSemesterLabel"
        Me.lblSemesterLabel.Size = New System.Drawing.Size(77, 15)
        Me.lblSemesterLabel.TabIndex = 445
        Me.lblSemesterLabel.Text = "Semester :"
        '
        'lblBorrowerId
        '
        Me.lblBorrowerId.AutoSize = True
        Me.lblBorrowerId.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowerId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerId.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerId.Location = New System.Drawing.Point(120, 12)
        Me.lblBorrowerId.Name = "lblBorrowerId"
        Me.lblBorrowerId.Size = New System.Drawing.Size(86, 15)
        Me.lblBorrowerId.TabIndex = 434
        Me.lblBorrowerId.Text = "Borrower ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(120, 27)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 15)
        Me.lblName.TabIndex = 433
        Me.lblName.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 432
        Me.Label6.Text = "Borrower ID :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(62, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 431
        Me.Label12.Text = "Name :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.rbtCol)
        Me.Panel3.Controls.Add(Me.rbtSH)
        Me.Panel3.Controls.Add(Me.rbtJH)
        Me.Panel3.Controls.Add(Me.rbtElem)
        Me.Panel3.Location = New System.Drawing.Point(28, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(918, 39)
        Me.Panel3.TabIndex = 460
        '
        'rbtCol
        '
        Me.rbtCol.AutoSize = True
        Me.rbtCol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtCol.Location = New System.Drawing.Point(752, 10)
        Me.rbtCol.Name = "rbtCol"
        Me.rbtCol.Size = New System.Drawing.Size(75, 19)
        Me.rbtCol.TabIndex = 3
        Me.rbtCol.TabStop = True
        Me.rbtCol.Text = "College"
        Me.rbtCol.UseVisualStyleBackColor = True
        Me.rbtCol.Visible = False
        '
        'rbtSH
        '
        Me.rbtSH.AutoSize = True
        Me.rbtSH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtSH.Location = New System.Drawing.Point(515, 10)
        Me.rbtSH.Name = "rbtSH"
        Me.rbtSH.Size = New System.Drawing.Size(101, 19)
        Me.rbtSH.TabIndex = 2
        Me.rbtSH.TabStop = True
        Me.rbtSH.Text = "Senior High"
        Me.rbtSH.UseVisualStyleBackColor = True
        Me.rbtSH.Visible = False
        '
        'rbtJH
        '
        Me.rbtJH.AutoSize = True
        Me.rbtJH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtJH.Location = New System.Drawing.Point(278, 10)
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
        Me.rbtElem.Location = New System.Drawing.Point(41, 10)
        Me.rbtElem.Name = "rbtElem"
        Me.rbtElem.Size = New System.Drawing.Size(100, 19)
        Me.rbtElem.TabIndex = 0
        Me.rbtElem.TabStop = True
        Me.rbtElem.Text = "Elementary"
        Me.rbtElem.UseVisualStyleBackColor = True
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.BackColor = System.Drawing.Color.Transparent
        Me.lblDept.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.Black
        Me.lblDept.Location = New System.Drawing.Point(490, 100)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(92, 15)
        Me.lblDept.TabIndex = 459
        Me.lblDept.Text = "Department :"
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(588, 96)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(306, 23)
        Me.cboDepartment.TabIndex = 458
        '
        'btnDept
        '
        Me.btnDept.BackColor = System.Drawing.Color.Maroon
        Me.btnDept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDept.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDept.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDept.Location = New System.Drawing.Point(905, 96)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(31, 23)
        Me.btnDept.TabIndex = 457
        Me.btnDept.Text = "..."
        Me.btnDept.UseVisualStyleBackColor = False
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.Black
        Me.lblCourse.Location = New System.Drawing.Point(521, 132)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(61, 15)
        Me.lblCourse.TabIndex = 456
        Me.lblCourse.Text = "Course :"
        '
        'cboCourse
        '
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(588, 128)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(306, 23)
        Me.cboCourse.TabIndex = 455
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.Maroon
        Me.btnCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCourse.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCourse.Location = New System.Drawing.Point(905, 128)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(31, 23)
        Me.btnCourse.TabIndex = 454
        Me.btnCourse.Text = "..."
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(40, 132)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(64, 15)
        Me.lblSection.TabIndex = 453
        Me.lblSection.Text = "Section :"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.Black
        Me.lblLevel.Location = New System.Drawing.Point(55, 100)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(49, 15)
        Me.lblLevel.TabIndex = 451
        Me.lblLevel.Text = "Level :"
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(110, 96)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(306, 23)
        Me.cboLevel.TabIndex = 450
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Image = CType(resources.GetObject("btnRegister.Image"), System.Drawing.Image)
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(693, 398)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(154, 26)
        Me.btnRegister.TabIndex = 430
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnLevelSection
        '
        Me.btnLevelSection.BackColor = System.Drawing.Color.Maroon
        Me.btnLevelSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLevelSection.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLevelSection.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelSection.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLevelSection.Location = New System.Drawing.Point(427, 96)
        Me.btnLevelSection.Name = "btnLevelSection"
        Me.btnLevelSection.Size = New System.Drawing.Size(31, 23)
        Me.btnLevelSection.TabIndex = 449
        Me.btnLevelSection.Text = "..."
        Me.btnLevelSection.UseVisualStyleBackColor = False
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
        Me.Label10.Size = New System.Drawing.Size(190, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "      Student Registration"
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
        Me.Panel6.Size = New System.Drawing.Size(1011, 37)
        Me.Panel6.TabIndex = 428
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
        Me.Button3.Location = New System.Drawing.Point(968, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(110, 128)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(306, 23)
        Me.cboSection.TabIndex = 448
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
        Me.btnCancel.Location = New System.Drawing.Point(853, 398)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 26)
        Me.btnCancel.TabIndex = 431
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblDept)
        Me.Panel1.Controls.Add(Me.cboDepartment)
        Me.Panel1.Controls.Add(Me.btnDept)
        Me.Panel1.Controls.Add(Me.lblCourse)
        Me.Panel1.Controls.Add(Me.cboCourse)
        Me.Panel1.Controls.Add(Me.btnCourse)
        Me.Panel1.Controls.Add(Me.lblSection)
        Me.Panel1.Controls.Add(Me.lblLevel)
        Me.Panel1.Controls.Add(Me.cboLevel)
        Me.Panel1.Controls.Add(Me.btnLevelSection)
        Me.Panel1.Controls.Add(Me.cboSection)
        Me.Panel1.Location = New System.Drawing.Point(12, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 256)
        Me.Panel1.TabIndex = 427
        '
        'FormStudentRegistry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 430)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormStudentRegistry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStudentRegistry"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblSemesterLabel As System.Windows.Forms.Label
    Friend WithEvents lblBorrowerId As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbtCol As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSH As System.Windows.Forms.RadioButton
    Friend WithEvents rbtJH As System.Windows.Forms.RadioButton
    Friend WithEvents rbtElem As System.Windows.Forms.RadioButton
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents btnDept As System.Windows.Forms.Button
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents btnCourse As System.Windows.Forms.Button
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnLevelSection As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
