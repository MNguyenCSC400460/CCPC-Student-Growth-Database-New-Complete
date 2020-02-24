<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentDeleteStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentDeleteStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentSelect = New System.Windows.Forms.ComboBox()
        Me.childIDInput = New System.Windows.Forms.TextBox()
        Me.loginTab = New System.Windows.Forms.LinkLabel()
        Me.teacherTab = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calculateStudentGrowth = New System.Windows.Forms.LinkLabel()
        Me.downloadStudentReports = New System.Windows.Forms.LinkLabel()
        Me.editStudent = New System.Windows.Forms.LinkLabel()
        Me.addStudent = New System.Windows.Forms.LinkLabel()
        Me.noDelete = New System.Windows.Forms.Button()
        Me.yesDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.studentsReturnLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Child ID:"
        '
        'studentSelect
        '
        Me.studentSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentSelect.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.studentSelect.FormattingEnabled = True
        Me.studentSelect.Location = New System.Drawing.Point(368, 10)
        Me.studentSelect.Name = "studentSelect"
        Me.studentSelect.Size = New System.Drawing.Size(484, 28)
        Me.studentSelect.TabIndex = 2
        Me.studentSelect.Text = "Student Select"
        '
        'childIDInput
        '
        Me.childIDInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childIDInput.Location = New System.Drawing.Point(368, 44)
        Me.childIDInput.Name = "childIDInput"
        Me.childIDInput.Size = New System.Drawing.Size(191, 26)
        Me.childIDInput.TabIndex = 3
        '
        'loginTab
        '
        Me.loginTab.AutoSize = True
        Me.loginTab.BackColor = System.Drawing.Color.Transparent
        Me.loginTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginTab.Location = New System.Drawing.Point(891, 536)
        Me.loginTab.Name = "loginTab"
        Me.loginTab.Size = New System.Drawing.Size(56, 20)
        Me.loginTab.TabIndex = 10
        Me.loginTab.TabStop = True
        Me.loginTab.Text = "Logins"
        '
        'teacherTab
        '
        Me.teacherTab.AutoSize = True
        Me.teacherTab.BackColor = System.Drawing.Color.Transparent
        Me.teacherTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherTab.Location = New System.Drawing.Point(753, 535)
        Me.teacherTab.Name = "teacherTab"
        Me.teacherTab.Size = New System.Drawing.Size(75, 20)
        Me.teacherTab.TabIndex = 9
        Me.teacherTab.TabStop = True
        Me.teacherTab.Text = "Teachers"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.calculateStudentGrowth)
        Me.GroupBox1.Controls.Add(Me.downloadStudentReports)
        Me.GroupBox1.Controls.Add(Me.editStudent)
        Me.GroupBox1.Controls.Add(Me.addStudent)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(6, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Delete Student"
        '
        'calculateStudentGrowth
        '
        Me.calculateStudentGrowth.AutoSize = True
        Me.calculateStudentGrowth.Location = New System.Drawing.Point(5, 39)
        Me.calculateStudentGrowth.Name = "calculateStudentGrowth"
        Me.calculateStudentGrowth.Size = New System.Drawing.Size(192, 25)
        Me.calculateStudentGrowth.TabIndex = 0
        Me.calculateStudentGrowth.TabStop = True
        Me.calculateStudentGrowth.Text = "Calculate Growth"
        '
        'downloadStudentReports
        '
        Me.downloadStudentReports.AutoSize = True
        Me.downloadStudentReports.Location = New System.Drawing.Point(5, 181)
        Me.downloadStudentReports.Name = "downloadStudentReports"
        Me.downloadStudentReports.Size = New System.Drawing.Size(204, 25)
        Me.downloadStudentReports.TabIndex = 4
        Me.downloadStudentReports.TabStop = True
        Me.downloadStudentReports.Text = "Download Reports"
        '
        'editStudent
        '
        Me.editStudent.AutoSize = True
        Me.editStudent.Location = New System.Drawing.Point(6, 111)
        Me.editStudent.Name = "editStudent"
        Me.editStudent.Size = New System.Drawing.Size(141, 25)
        Me.editStudent.TabIndex = 2
        Me.editStudent.TabStop = True
        Me.editStudent.Text = "Edit Student"
        '
        'addStudent
        '
        Me.addStudent.AutoSize = True
        Me.addStudent.Location = New System.Drawing.Point(5, 74)
        Me.addStudent.Name = "addStudent"
        Me.addStudent.Size = New System.Drawing.Size(141, 25)
        Me.addStudent.TabIndex = 1
        Me.addStudent.TabStop = True
        Me.addStudent.Text = "Add Student"
        '
        'noDelete
        '
        Me.noDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noDelete.Location = New System.Drawing.Point(532, 210)
        Me.noDelete.Name = "noDelete"
        Me.noDelete.Size = New System.Drawing.Size(89, 50)
        Me.noDelete.TabIndex = 5
        Me.noDelete.Text = "No"
        Me.noDelete.UseVisualStyleBackColor = True
        '
        'yesDelete
        '
        Me.yesDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesDelete.Location = New System.Drawing.Point(532, 132)
        Me.yesDelete.Name = "yesDelete"
        Me.yesDelete.Size = New System.Drawing.Size(89, 50)
        Me.yesDelete.TabIndex = 4
        Me.yesDelete.Text = "Yes"
        Me.yesDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Are you sure?"
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 5)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 6
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'studentsReturnLabel
        '
        Me.studentsReturnLabel.AutoSize = True
        Me.studentsReturnLabel.BackColor = System.Drawing.Color.Transparent
        Me.studentsReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentsReturnLabel.LinkColor = System.Drawing.Color.White
        Me.studentsReturnLabel.Location = New System.Drawing.Point(499, 535)
        Me.studentsReturnLabel.Name = "studentsReturnLabel"
        Me.studentsReturnLabel.Size = New System.Drawing.Size(185, 20)
        Me.studentsReturnLabel.TabIndex = 8
        Me.studentsReturnLabel.TabStop = True
        Me.studentsReturnLabel.Text = "Students (Click to return)"
        '
        'studentDeleteStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.studentsReturnLabel)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.noDelete)
        Me.Controls.Add(Me.yesDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.studentSelect)
        Me.Controls.Add(Me.childIDInput)
        Me.Controls.Add(Me.loginTab)
        Me.Controls.Add(Me.teacherTab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "studentDeleteStudent"
        Me.Text = "CCPC Student Growth Database Students - Delete Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents studentSelect As ComboBox
    Friend WithEvents childIDInput As TextBox
    Friend WithEvents loginTab As LinkLabel
    Friend WithEvents teacherTab As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents calculateStudentGrowth As LinkLabel
    Friend WithEvents downloadStudentReports As LinkLabel
    Friend WithEvents editStudent As LinkLabel
    Friend WithEvents addStudent As LinkLabel
    Friend WithEvents noDelete As Button
    Friend WithEvents yesDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents logOutButton As Button
    Friend WithEvents studentsReturnLabel As LinkLabel
End Class
