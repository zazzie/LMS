<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSemester
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSemester))
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtSecondSem = New System.Windows.Forms.RadioButton()
        Me.rbtFirstSem = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGo.Location = New System.Drawing.Point(81, 132)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(157, 26)
        Me.btnGo.TabIndex = 370
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtSecondSem)
        Me.Panel1.Controls.Add(Me.rbtFirstSem)
        Me.Panel1.Location = New System.Drawing.Point(25, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 77)
        Me.Panel1.TabIndex = 369
        '
        'rbtSecondSem
        '
        Me.rbtSecondSem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbtSecondSem.AutoSize = True
        Me.rbtSecondSem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtSecondSem.Location = New System.Drawing.Point(31, 39)
        Me.rbtSecondSem.Name = "rbtSecondSem"
        Me.rbtSecondSem.Size = New System.Drawing.Size(140, 19)
        Me.rbtSecondSem.TabIndex = 346
        Me.rbtSecondSem.TabStop = True
        Me.rbtSecondSem.Text = "Second Semester"
        Me.rbtSecondSem.UseVisualStyleBackColor = True
        '
        'rbtFirstSem
        '
        Me.rbtFirstSem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbtFirstSem.AutoSize = True
        Me.rbtFirstSem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.rbtFirstSem.Location = New System.Drawing.Point(31, 14)
        Me.rbtFirstSem.Name = "rbtFirstSem"
        Me.rbtFirstSem.Size = New System.Drawing.Size(121, 19)
        Me.rbtFirstSem.TabIndex = 345
        Me.rbtFirstSem.TabStop = True
        Me.rbtFirstSem.Text = "First Semester"
        Me.rbtFirstSem.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(22, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 368
        Me.Label10.Text = "Semester"
        '
        'FormSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 169)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSemester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSemester"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtSecondSem As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFirstSem As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
