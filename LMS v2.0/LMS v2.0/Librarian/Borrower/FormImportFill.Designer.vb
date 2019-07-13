<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportFill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImportFill))
        Me.btnViewImportList = New System.Windows.Forms.Button()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.cboStudentDepartment = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbtCol = New System.Windows.Forms.RadioButton()
        Me.rbtSH = New System.Windows.Forms.RadioButton()
        Me.rbtJH = New System.Windows.Forms.RadioButton()
        Me.rbtElem = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboEmployeeDept = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlSchoolEmployee = New System.Windows.Forms.Panel()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtSchoolEmployee = New System.Windows.Forms.RadioButton()
        Me.rbtStudent = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboToLevel = New System.Windows.Forms.ComboBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.pnlSchoolEmployee.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewImportList
        '
        Me.btnViewImportList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewImportList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewImportList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnViewImportList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewImportList.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewImportList.Image = CType(resources.GetObject("btnViewImportList.Image"), System.Drawing.Image)
        Me.btnViewImportList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewImportList.Location = New System.Drawing.Point(249, 510)
        Me.btnViewImportList.Name = "btnViewImportList"
        Me.btnViewImportList.Size = New System.Drawing.Size(154, 26)
        Me.btnViewImportList.TabIndex = 434
        Me.btnViewImportList.Text = "View List"
        Me.btnViewImportList.UseVisualStyleBackColor = False
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.BackColor = System.Drawing.Color.Transparent
        Me.lblDept.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.Black
        Me.lblDept.Location = New System.Drawing.Point(34, 171)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(92, 15)
        Me.lblDept.TabIndex = 466
        Me.lblDept.Text = "Department :"
        '
        'cboStudentDepartment
        '
        Me.cboStudentDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudentDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentDepartment.FormattingEnabled = True
        Me.cboStudentDepartment.Location = New System.Drawing.Point(132, 167)
        Me.cboStudentDepartment.Name = "cboStudentDepartment"
        Me.cboStudentDepartment.Size = New System.Drawing.Size(306, 23)
        Me.cboStudentDepartment.TabIndex = 465
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.Black
        Me.lblCourse.Location = New System.Drawing.Point(65, 203)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(61, 15)
        Me.lblCourse.TabIndex = 464
        Me.lblCourse.Text = "Course :"
        '
        'cboCourse
        '
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(132, 199)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(306, 23)
        Me.cboCourse.TabIndex = 463
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.rbtCol)
        Me.Panel3.Controls.Add(Me.rbtSH)
        Me.Panel3.Controls.Add(Me.rbtJH)
        Me.Panel3.Controls.Add(Me.rbtElem)
        Me.Panel3.Location = New System.Drawing.Point(23, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 41)
        Me.Panel3.TabIndex = 462
        '
        'rbtCol
        '
        Me.rbtCol.AutoSize = True
        Me.rbtCol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtCol.Location = New System.Drawing.Point(382, 10)
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
        Me.rbtSH.Location = New System.Drawing.Point(261, 10)
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
        Me.rbtJH.Location = New System.Drawing.Point(142, 10)
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
        Me.rbtElem.Location = New System.Drawing.Point(22, 10)
        Me.rbtElem.Name = "rbtElem"
        Me.rbtElem.Size = New System.Drawing.Size(100, 19)
        Me.rbtElem.TabIndex = 0
        Me.rbtElem.TabStop = True
        Me.rbtElem.Text = "Elementary"
        Me.rbtElem.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(37, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 469
        Me.Label5.Text = "Department :"
        '
        'cboEmployeeDept
        '
        Me.cboEmployeeDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployeeDept.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmployeeDept.FormattingEnabled = True
        Me.cboEmployeeDept.Location = New System.Drawing.Point(135, 39)
        Me.cboEmployeeDept.Name = "cboEmployeeDept"
        Me.cboEmployeeDept.Size = New System.Drawing.Size(306, 23)
        Me.cboEmployeeDept.TabIndex = 468
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(135, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 467
        Me.Label6.Text = "IMPORT TO"
        '
        'pnlSchoolEmployee
        '
        Me.pnlSchoolEmployee.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlSchoolEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSchoolEmployee.Controls.Add(Me.Label5)
        Me.pnlSchoolEmployee.Controls.Add(Me.cboEmployeeDept)
        Me.pnlSchoolEmployee.Controls.Add(Me.Label6)
        Me.pnlSchoolEmployee.Location = New System.Drawing.Point(33, 394)
        Me.pnlSchoolEmployee.Name = "pnlSchoolEmployee"
        Me.pnlSchoolEmployee.Size = New System.Drawing.Size(522, 92)
        Me.pnlSchoolEmployee.TabIndex = 432
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(62, 142)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(64, 15)
        Me.lblSection.TabIndex = 461
        Me.lblSection.Text = "Section :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(77, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 460
        Me.Label4.Text = "Level :"
        '
        'rbtSchoolEmployee
        '
        Me.rbtSchoolEmployee.AutoSize = True
        Me.rbtSchoolEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtSchoolEmployee.Location = New System.Drawing.Point(33, 369)
        Me.rbtSchoolEmployee.Name = "rbtSchoolEmployee"
        Me.rbtSchoolEmployee.Size = New System.Drawing.Size(137, 19)
        Me.rbtSchoolEmployee.TabIndex = 433
        Me.rbtSchoolEmployee.TabStop = True
        Me.rbtSchoolEmployee.Text = "School Employee"
        Me.rbtSchoolEmployee.UseVisualStyleBackColor = True
        '
        'rbtStudent
        '
        Me.rbtStudent.AutoSize = True
        Me.rbtStudent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtStudent.Location = New System.Drawing.Point(33, 77)
        Me.rbtStudent.Name = "rbtStudent"
        Me.rbtStudent.Size = New System.Drawing.Size(76, 19)
        Me.rbtStudent.TabIndex = 431
        Me.rbtStudent.TabStop = True
        Me.rbtStudent.Text = "Student"
        Me.rbtStudent.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(210, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 24)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Import Borrower"
        '
        'cboToLevel
        '
        Me.cboToLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToLevel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboToLevel.FormattingEnabled = True
        Me.cboToLevel.Location = New System.Drawing.Point(132, 106)
        Me.cboToLevel.Name = "cboToLevel"
        Me.cboToLevel.Size = New System.Drawing.Size(306, 23)
        Me.cboToLevel.TabIndex = 459
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(132, 138)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(306, 23)
        Me.cboSection.TabIndex = 458
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(132, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 457
        Me.Label3.Text = "IMPORT TO"
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
        Me.btnCancel.Location = New System.Drawing.Point(409, 510)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 26)
        Me.btnCancel.TabIndex = 435
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 43)
        Me.Panel2.TabIndex = 430
        '
        'pnlStudent
        '
        Me.pnlStudent.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStudent.Controls.Add(Me.lblDept)
        Me.pnlStudent.Controls.Add(Me.cboStudentDepartment)
        Me.pnlStudent.Controls.Add(Me.lblCourse)
        Me.pnlStudent.Controls.Add(Me.cboCourse)
        Me.pnlStudent.Controls.Add(Me.Panel3)
        Me.pnlStudent.Controls.Add(Me.lblSection)
        Me.pnlStudent.Controls.Add(Me.Label4)
        Me.pnlStudent.Controls.Add(Me.cboToLevel)
        Me.pnlStudent.Controls.Add(Me.cboSection)
        Me.pnlStudent.Controls.Add(Me.Label3)
        Me.pnlStudent.Location = New System.Drawing.Point(33, 102)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(522, 249)
        Me.pnlStudent.TabIndex = 429
        '
        'FormImportFill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 542)
        Me.Controls.Add(Me.btnViewImportList)
        Me.Controls.Add(Me.pnlSchoolEmployee)
        Me.Controls.Add(Me.rbtSchoolEmployee)
        Me.Controls.Add(Me.rbtStudent)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormImportFill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormImportFill"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlSchoolEmployee.ResumeLayout(False)
        Me.pnlSchoolEmployee.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnViewImportList As System.Windows.Forms.Button
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents cboStudentDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbtCol As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSH As System.Windows.Forms.RadioButton
    Friend WithEvents rbtJH As System.Windows.Forms.RadioButton
    Friend WithEvents rbtElem As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboEmployeeDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlSchoolEmployee As System.Windows.Forms.Panel
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtSchoolEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents rbtStudent As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboToLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlStudent As System.Windows.Forms.Panel
End Class
