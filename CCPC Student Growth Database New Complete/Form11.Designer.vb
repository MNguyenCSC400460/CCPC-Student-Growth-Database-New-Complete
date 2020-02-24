<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentCalculateGrowth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentCalculateGrowth))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentSelect = New System.Windows.Forms.ComboBox()
        Me.childIDInput = New System.Windows.Forms.TextBox()
        Me.loginTab = New System.Windows.Forms.LinkLabel()
        Me.teacherTab = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.downloadStudentReports = New System.Windows.Forms.LinkLabel()
        Me.deleteStudent = New System.Windows.Forms.LinkLabel()
        Me.editStudent = New System.Windows.Forms.LinkLabel()
        Me.addStudent = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentObjective1 = New System.Windows.Forms.TextBox()
        Me.studentObjective2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentObjective3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.studentObjective4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.studentObjective5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.studentObjective10 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.studentObjective9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.studentObjective8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.studentObjective7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.studentObjective6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.calculateStudGrowth = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.studentGrowthResult = New System.Windows.Forms.TextBox()
        Me.studentGrowthSave = New System.Windows.Forms.Button()
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
        Me.studentSelect.TabIndex = 12
        Me.studentSelect.Text = "Student Select"
        '
        'childIDInput
        '
        Me.childIDInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childIDInput.Location = New System.Drawing.Point(368, 44)
        Me.childIDInput.Name = "childIDInput"
        Me.childIDInput.Size = New System.Drawing.Size(191, 26)
        Me.childIDInput.TabIndex = 13
        '
        'loginTab
        '
        Me.loginTab.AutoSize = True
        Me.loginTab.BackColor = System.Drawing.Color.Transparent
        Me.loginTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginTab.Location = New System.Drawing.Point(891, 536)
        Me.loginTab.Name = "loginTab"
        Me.loginTab.Size = New System.Drawing.Size(56, 20)
        Me.loginTab.TabIndex = 31
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
        Me.teacherTab.TabIndex = 30
        Me.teacherTab.TabStop = True
        Me.teacherTab.Text = "Teachers"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.downloadStudentReports)
        Me.GroupBox1.Controls.Add(Me.deleteStudent)
        Me.GroupBox1.Controls.Add(Me.editStudent)
        Me.GroupBox1.Controls.Add(Me.addStudent)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(6, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Calculate Growth"
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
        'deleteStudent
        '
        Me.deleteStudent.AutoSize = True
        Me.deleteStudent.Location = New System.Drawing.Point(6, 146)
        Me.deleteStudent.Name = "deleteStudent"
        Me.deleteStudent.Size = New System.Drawing.Size(168, 25)
        Me.deleteStudent.TabIndex = 3
        Me.deleteStudent.TabStop = True
        Me.deleteStudent.Text = "Delete Student"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Objective 1:"
        '
        'studentObjective1
        '
        Me.studentObjective1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective1.Location = New System.Drawing.Point(368, 87)
        Me.studentObjective1.Name = "studentObjective1"
        Me.studentObjective1.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective1.TabIndex = 14
        '
        'studentObjective2
        '
        Me.studentObjective2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective2.Location = New System.Drawing.Point(368, 123)
        Me.studentObjective2.Name = "studentObjective2"
        Me.studentObjective2.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Objective 2:"
        '
        'studentObjective3
        '
        Me.studentObjective3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective3.Location = New System.Drawing.Point(368, 162)
        Me.studentObjective3.Name = "studentObjective3"
        Me.studentObjective3.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective3.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(249, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Objective 3:"
        '
        'studentObjective4
        '
        Me.studentObjective4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective4.Location = New System.Drawing.Point(368, 200)
        Me.studentObjective4.Name = "studentObjective4"
        Me.studentObjective4.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective4.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Objective 4:"
        '
        'studentObjective5
        '
        Me.studentObjective5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective5.Location = New System.Drawing.Point(368, 244)
        Me.studentObjective5.Name = "studentObjective5"
        Me.studentObjective5.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective5.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Objective 5:"
        '
        'studentObjective10
        '
        Me.studentObjective10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective10.Location = New System.Drawing.Point(676, 244)
        Me.studentObjective10.Name = "studentObjective10"
        Me.studentObjective10.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective10.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(557, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Objective 10:"
        '
        'studentObjective9
        '
        Me.studentObjective9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective9.Location = New System.Drawing.Point(676, 200)
        Me.studentObjective9.Name = "studentObjective9"
        Me.studentObjective9.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective9.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(557, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Objective 9:"
        '
        'studentObjective8
        '
        Me.studentObjective8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective8.Location = New System.Drawing.Point(676, 162)
        Me.studentObjective8.Name = "studentObjective8"
        Me.studentObjective8.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective8.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(557, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Objective 8:"
        '
        'studentObjective7
        '
        Me.studentObjective7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective7.Location = New System.Drawing.Point(676, 123)
        Me.studentObjective7.Name = "studentObjective7"
        Me.studentObjective7.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective7.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(557, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Objective 7:"
        '
        'studentObjective6
        '
        Me.studentObjective6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentObjective6.Location = New System.Drawing.Point(676, 87)
        Me.studentObjective6.Name = "studentObjective6"
        Me.studentObjective6.Size = New System.Drawing.Size(72, 26)
        Me.studentObjective6.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(557, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Objective 6:"
        '
        'calculateStudGrowth
        '
        Me.calculateStudGrowth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateStudGrowth.Location = New System.Drawing.Point(610, 295)
        Me.calculateStudGrowth.Name = "calculateStudGrowth"
        Me.calculateStudGrowth.Size = New System.Drawing.Size(138, 66)
        Me.calculateStudGrowth.TabIndex = 24
        Me.calculateStudGrowth.Text = "Calculate Growth"
        Me.calculateStudGrowth.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(403, 397)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(207, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Total Growth of Student:"
        '
        'studentGrowthResult
        '
        Me.studentGrowthResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentGrowthResult.Location = New System.Drawing.Point(676, 391)
        Me.studentGrowthResult.Name = "studentGrowthResult"
        Me.studentGrowthResult.Size = New System.Drawing.Size(72, 26)
        Me.studentGrowthResult.TabIndex = 25
        '
        'studentGrowthSave
        '
        Me.studentGrowthSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentGrowthSave.Location = New System.Drawing.Point(610, 453)
        Me.studentGrowthSave.Name = "studentGrowthSave"
        Me.studentGrowthSave.Size = New System.Drawing.Size(138, 66)
        Me.studentGrowthSave.TabIndex = 26
        Me.studentGrowthSave.Text = "Save to Records"
        Me.studentGrowthSave.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 5)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 27
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'studentsReturnLabel
        '
        Me.studentsReturnLabel.AutoSize = True
        Me.studentsReturnLabel.BackColor = System.Drawing.Color.Transparent
        Me.studentsReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentsReturnLabel.LinkColor = System.Drawing.Color.White
        Me.studentsReturnLabel.Location = New System.Drawing.Point(497, 535)
        Me.studentsReturnLabel.Name = "studentsReturnLabel"
        Me.studentsReturnLabel.Size = New System.Drawing.Size(185, 20)
        Me.studentsReturnLabel.TabIndex = 29
        Me.studentsReturnLabel.TabStop = True
        Me.studentsReturnLabel.Text = "Students (Click to return)"
        '
        'studentCalculateGrowth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.studentsReturnLabel)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.studentGrowthSave)
        Me.Controls.Add(Me.studentGrowthResult)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.calculateStudGrowth)
        Me.Controls.Add(Me.studentObjective10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.studentObjective9)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.studentObjective8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.studentObjective7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.studentObjective6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.studentObjective5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.studentObjective4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.studentObjective3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.studentObjective2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.studentObjective1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.studentSelect)
        Me.Controls.Add(Me.childIDInput)
        Me.Controls.Add(Me.loginTab)
        Me.Controls.Add(Me.teacherTab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "studentCalculateGrowth"
        Me.Text = "CCPC Student Growth Database Students - Calculate Growth"
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
    Friend WithEvents downloadStudentReports As LinkLabel
    Friend WithEvents deleteStudent As LinkLabel
    Friend WithEvents editStudent As LinkLabel
    Friend WithEvents addStudent As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents studentObjective1 As TextBox
    Friend WithEvents studentObjective2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents studentObjective3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents studentObjective4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents studentObjective5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents studentObjective10 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents studentObjective9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents studentObjective8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents studentObjective7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents studentObjective6 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents calculateStudGrowth As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents studentGrowthResult As TextBox
    Friend WithEvents studentGrowthSave As Button
    Friend WithEvents logOutButton As Button
    Friend WithEvents studentsReturnLabel As LinkLabel
End Class
