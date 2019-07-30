<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.lblLibraryMenu = New System.Windows.Forms.Label()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSearchBorrower = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnIssueBook = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblVision = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblMission = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlUp = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLibraryMenu
        '
        Me.lblLibraryMenu.AutoSize = True
        Me.lblLibraryMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblLibraryMenu.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibraryMenu.ForeColor = System.Drawing.Color.Black
        Me.lblLibraryMenu.Image = CType(resources.GetObject("lblLibraryMenu.Image"), System.Drawing.Image)
        Me.lblLibraryMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLibraryMenu.Location = New System.Drawing.Point(19, 18)
        Me.lblLibraryMenu.Name = "lblLibraryMenu"
        Me.lblLibraryMenu.Size = New System.Drawing.Size(86, 19)
        Me.lblLibraryMenu.TabIndex = 18
        Me.lblLibraryMenu.Text = "       Menu"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateReport.BackColor = System.Drawing.Color.White
        Me.btnGenerateReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.Image = CType(resources.GetObject("btnGenerateReport.Image"), System.Drawing.Image)
        Me.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateReport.Location = New System.Drawing.Point(14, 189)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(226, 35)
        Me.btnGenerateReport.TabIndex = 17
        Me.btnGenerateReport.Text = "      Generate Report"
        Me.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.White
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(14, 224)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(226, 35)
        Me.btnSettings.TabIndex = 16
        Me.btnSettings.Text = "      Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDate.Location = New System.Drawing.Point(11, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(205, 18)
        Me.lblDate.TabIndex = 216
        Me.lblDate.Text = "Saturday, February 02, 2018"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTime.Location = New System.Drawing.Point(979, 12)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(92, 18)
        Me.lblTime.TabIndex = 215
        Me.lblTime.Text = "1:30: 27 AM"
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchBook.BackColor = System.Drawing.Color.White
        Me.btnSearchBook.FlatAppearance.BorderSize = 0
        Me.btnSearchBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.Image = CType(resources.GetObject("btnSearchBook.Image"), System.Drawing.Image)
        Me.btnSearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBook.Location = New System.Drawing.Point(14, 49)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(226, 35)
        Me.btnSearchBook.TabIndex = 12
        Me.btnSearchBook.Text = "      Search Item"
        Me.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBook.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblLibraryMenu)
        Me.Panel4.Controls.Add(Me.btnGenerateReport)
        Me.Panel4.Controls.Add(Me.btnSearchBook)
        Me.Panel4.Controls.Add(Me.btnSettings)
        Me.Panel4.Controls.Add(Me.btnSearchBorrower)
        Me.Panel4.Controls.Add(Me.btnReturnBook)
        Me.Panel4.Controls.Add(Me.btnIssueBook)
        Me.Panel4.Location = New System.Drawing.Point(810, 201)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(253, 276)
        Me.Panel4.TabIndex = 226
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchBorrower.BackColor = System.Drawing.Color.White
        Me.btnSearchBorrower.FlatAppearance.BorderSize = 0
        Me.btnSearchBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnSearchBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrower.Image = CType(resources.GetObject("btnSearchBorrower.Image"), System.Drawing.Image)
        Me.btnSearchBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBorrower.Location = New System.Drawing.Point(14, 84)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(226, 35)
        Me.btnSearchBorrower.TabIndex = 13
        Me.btnSearchBorrower.Text = "      Search Borrower"
        Me.btnSearchBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBorrower.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReturnBook.BackColor = System.Drawing.Color.White
        Me.btnReturnBook.FlatAppearance.BorderSize = 0
        Me.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Image = CType(resources.GetObject("btnReturnBook.Image"), System.Drawing.Image)
        Me.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnBook.Location = New System.Drawing.Point(14, 154)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(226, 35)
        Me.btnReturnBook.TabIndex = 15
        Me.btnReturnBook.Text = "      Return Item"
        Me.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnIssueBook
        '
        Me.btnIssueBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIssueBook.BackColor = System.Drawing.Color.White
        Me.btnIssueBook.FlatAppearance.BorderSize = 0
        Me.btnIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssueBook.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueBook.Image = CType(resources.GetObject("btnIssueBook.Image"), System.Drawing.Image)
        Me.btnIssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssueBook.Location = New System.Drawing.Point(14, 119)
        Me.btnIssueBook.Name = "btnIssueBook"
        Me.btnIssueBook.Size = New System.Drawing.Size(226, 35)
        Me.btnIssueBook.TabIndex = 14
        Me.btnIssueBook.Text = "      Issue Item"
        Me.btnIssueBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssueBook.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblDate)
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 748)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1084, 40)
        Me.Panel3.TabIndex = 227
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel6.Controls.Add(Me.lblVision)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(23, 483)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(781, 244)
        Me.Panel6.TabIndex = 228
        '
        'lblVision
        '
        Me.lblVision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVision.AutoEllipsis = True
        Me.lblVision.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblVision.Location = New System.Drawing.Point(25, 68)
        Me.lblVision.Name = "lblVision"
        Me.lblVision.Size = New System.Drawing.Size(726, 155)
        Me.lblVision.TabIndex = 213
        Me.lblVision.Text = resources.GetString("lblVision.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 29)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "VISION     "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel5.Controls.Add(Me.lblMission)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(23, 201)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(781, 276)
        Me.Panel5.TabIndex = 230
        '
        'lblMission
        '
        Me.lblMission.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMission.AutoEllipsis = True
        Me.lblMission.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblMission.Location = New System.Drawing.Point(29, 49)
        Me.lblMission.Name = "lblMission"
        Me.lblMission.Size = New System.Drawing.Size(726, 212)
        Me.lblMission.TabIndex = 212
        Me.lblMission.Text = resources.GetString("lblMission.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "MISSION     "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(14, 119)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(226, 35)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "      View Due Today Items (0)"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Controls.Add(Me.Button5)
        Me.Panel7.Controls.Add(Me.Button6)
        Me.Panel7.Location = New System.Drawing.Point(810, 483)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(253, 222)
        Me.Panel7.TabIndex = 229
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(19, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "     Notification"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(14, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(226, 35)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "      View Reservation (0)"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(14, 84)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(226, 35)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "      View Almost Due Items (0)"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(14, 154)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(226, 35)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "      View  Overdue Items (0)"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 141)
        Me.Panel1.TabIndex = 233
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(284, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 20)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "Tel  No.  (062)  xxx  xxxx    https://www.facebook.com/RecodoNHSOfficial/"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(284, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Recodo,  Zamboanga  City"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(266, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(773, 51)
        Me.Label6.TabIndex = 216
        Me.Label6.Text = "RECODO NATIONAL HIGH SCHOOL"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 141)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlUp
        '
        Me.pnlUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUp.Controls.Add(Me.lblUsername)
        Me.pnlUp.Controls.Add(Me.lblPosition)
        Me.pnlUp.Controls.Add(Me.lblWelcome)
        Me.pnlUp.Controls.Add(Me.btnLogout)
        Me.pnlUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUp.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.pnlUp.Location = New System.Drawing.Point(0, 141)
        Me.pnlUp.Name = "pnlUp"
        Me.pnlUp.Size = New System.Drawing.Size(1084, 37)
        Me.pnlUp.TabIndex = 234
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUsername.Location = New System.Drawing.Point(98, 7)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(85, 19)
        Me.lblUsername.TabIndex = 220
        Me.lblUsername.Text = "Jane Doe!"
        '
        'lblPosition
        '
        Me.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPosition.Location = New System.Drawing.Point(486, 9)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(112, 19)
        Me.lblPosition.TabIndex = 219
        Me.lblPosition.Text = "Administrator"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblWelcome.Location = New System.Drawing.Point(18, 7)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(83, 19)
        Me.lblWelcome.TabIndex = 218
        Me.lblWelcome.Text = "Welcome,"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(960, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(122, 35)
        Me.btnLogout.TabIndex = 217
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1084, 788)
        Me.Controls.Add(Me.pnlUp)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUp.ResumeLayout(False)
        Me.pnlUp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLibraryMenu As System.Windows.Forms.Label
    Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSearchBorrower As System.Windows.Forms.Button
    Friend WithEvents btnReturnBook As System.Windows.Forms.Button
    Friend WithEvents btnIssueBook As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblVision As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblMission As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlUp As System.Windows.Forms.Panel
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
