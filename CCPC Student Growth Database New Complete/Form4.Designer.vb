<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teacherEditTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(teacherEditTeacher))
        Me.loginTab = New System.Windows.Forms.LinkLabel()
        Me.studentTab = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.siteInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.editTeacher = New System.Windows.Forms.Label()
        Me.downloadReports = New System.Windows.Forms.LinkLabel()
        Me.deleteTeacher = New System.Windows.Forms.LinkLabel()
        Me.addClass = New System.Windows.Forms.LinkLabel()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.middleInitial = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.classTypeName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.specialtyInput = New System.Windows.Forms.TextBox()
        Me.teacherSelect = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.classIDInput = New System.Windows.Forms.TextBox()
        Me.clearTeachInfoButton = New System.Windows.Forms.Button()
        Me.confirmTeachInformation = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.teachersReturnLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginTab
        '
        Me.loginTab.AutoSize = True
        Me.loginTab.BackColor = System.Drawing.Color.Transparent
        Me.loginTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginTab.Location = New System.Drawing.Point(891, 538)
        Me.loginTab.Name = "loginTab"
        Me.loginTab.Size = New System.Drawing.Size(56, 20)
        Me.loginTab.TabIndex = 23
        Me.loginTab.TabStop = True
        Me.loginTab.Text = "Logins"
        '
        'studentTab
        '
        Me.studentTab.AutoSize = True
        Me.studentTab.BackColor = System.Drawing.Color.Transparent
        Me.studentTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentTab.Location = New System.Drawing.Point(490, 538)
        Me.studentTab.Name = "studentTab"
        Me.studentTab.Size = New System.Drawing.Size(74, 20)
        Me.studentTab.TabIndex = 21
        Me.studentTab.TabStop = True
        Me.studentTab.Text = "Students"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Site:"
        '
        'siteInput
        '
        Me.siteInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siteInput.Location = New System.Drawing.Point(364, 46)
        Me.siteInput.Name = "siteInput"
        Me.siteInput.Size = New System.Drawing.Size(484, 26)
        Me.siteInput.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.editTeacher)
        Me.GroupBox1.Controls.Add(Me.downloadReports)
        Me.GroupBox1.Controls.Add(Me.deleteTeacher)
        Me.GroupBox1.Controls.Add(Me.addClass)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'editTeacher
        '
        Me.editTeacher.AutoSize = True
        Me.editTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.editTeacher.Location = New System.Drawing.Point(6, 80)
        Me.editTeacher.Name = "editTeacher"
        Me.editTeacher.Size = New System.Drawing.Size(146, 25)
        Me.editTeacher.TabIndex = 1
        Me.editTeacher.Text = "Edit Teacher"
        '
        'downloadReports
        '
        Me.downloadReports.AutoSize = True
        Me.downloadReports.Location = New System.Drawing.Point(6, 168)
        Me.downloadReports.Name = "downloadReports"
        Me.downloadReports.Size = New System.Drawing.Size(204, 25)
        Me.downloadReports.TabIndex = 3
        Me.downloadReports.TabStop = True
        Me.downloadReports.Text = "Download Reports"
        '
        'deleteTeacher
        '
        Me.deleteTeacher.AutoSize = True
        Me.deleteTeacher.Location = New System.Drawing.Point(6, 123)
        Me.deleteTeacher.Name = "deleteTeacher"
        Me.deleteTeacher.Size = New System.Drawing.Size(173, 25)
        Me.deleteTeacher.TabIndex = 2
        Me.deleteTeacher.TabStop = True
        Me.deleteTeacher.Text = "Delete Teacher"
        '
        'addClass
        '
        Me.addClass.AutoSize = True
        Me.addClass.Location = New System.Drawing.Point(6, 36)
        Me.addClass.Name = "addClass"
        Me.addClass.Size = New System.Drawing.Size(119, 25)
        Me.addClass.TabIndex = 0
        Me.addClass.TabStop = True
        Me.addClass.Text = "Add Class"
        '
        'firstName
        '
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(364, 89)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(200, 26)
        Me.firstName.TabIndex = 10
        '
        'middleInitial
        '
        Me.middleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middleInitial.Location = New System.Drawing.Point(591, 89)
        Me.middleInitial.Name = "middleInitial"
        Me.middleInitial.Size = New System.Drawing.Size(31, 26)
        Me.middleInitial.TabIndex = 11
        '
        'lastName
        '
        Me.lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(648, 89)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(200, 26)
        Me.lastName.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Edit Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "First"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(588, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Middle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(645, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Last"
        '
        'classTypeName
        '
        Me.classTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classTypeName.Location = New System.Drawing.Point(364, 192)
        Me.classTypeName.Name = "classTypeName"
        Me.classTypeName.Size = New System.Drawing.Size(484, 26)
        Me.classTypeName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(243, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Class Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(256, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Specialty:"
        '
        'specialtyInput
        '
        Me.specialtyInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialtyInput.Location = New System.Drawing.Point(364, 238)
        Me.specialtyInput.Name = "specialtyInput"
        Me.specialtyInput.Size = New System.Drawing.Size(484, 26)
        Me.specialtyInput.TabIndex = 15
        '
        'teacherSelect
        '
        Me.teacherSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherSelect.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.teacherSelect.FormattingEnabled = True
        Me.teacherSelect.Location = New System.Drawing.Point(364, 9)
        Me.teacherSelect.Name = "teacherSelect"
        Me.teacherSelect.Size = New System.Drawing.Size(484, 28)
        Me.teacherSelect.TabIndex = 8
        Me.teacherSelect.Text = "Teacher Select"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(260, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Class ID:"
        '
        'classIDInput
        '
        Me.classIDInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classIDInput.Location = New System.Drawing.Point(364, 148)
        Me.classIDInput.Name = "classIDInput"
        Me.classIDInput.Size = New System.Drawing.Size(200, 26)
        Me.classIDInput.TabIndex = 13
        '
        'clearTeachInfoButton
        '
        Me.clearTeachInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearTeachInfoButton.Location = New System.Drawing.Point(657, 313)
        Me.clearTeachInfoButton.Name = "clearTeachInfoButton"
        Me.clearTeachInfoButton.Size = New System.Drawing.Size(112, 70)
        Me.clearTeachInfoButton.TabIndex = 17
        Me.clearTeachInfoButton.Text = "Clear"
        Me.clearTeachInfoButton.UseVisualStyleBackColor = True
        '
        'confirmTeachInformation
        '
        Me.confirmTeachInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmTeachInformation.Location = New System.Drawing.Point(462, 313)
        Me.confirmTeachInformation.Name = "confirmTeachInformation"
        Me.confirmTeachInformation.Size = New System.Drawing.Size(112, 70)
        Me.confirmTeachInformation.TabIndex = 16
        Me.confirmTeachInformation.Text = "Confirm Information"
        Me.confirmTeachInformation.UseVisualStyleBackColor = True
        '
        'helpButton
        '
        Me.helpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpButton.Location = New System.Drawing.Point(12, 39)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(112, 33)
        Me.helpButton.TabIndex = 19
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 4)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 18
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'teachersReturnLabel
        '
        Me.teachersReturnLabel.AutoSize = True
        Me.teachersReturnLabel.BackColor = System.Drawing.Color.Transparent
        Me.teachersReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teachersReturnLabel.LinkColor = System.Drawing.Color.White
        Me.teachersReturnLabel.Location = New System.Drawing.Point(644, 538)
        Me.teachersReturnLabel.Name = "teachersReturnLabel"
        Me.teachersReturnLabel.Size = New System.Drawing.Size(186, 20)
        Me.teachersReturnLabel.TabIndex = 22
        Me.teachersReturnLabel.TabStop = True
        Me.teachersReturnLabel.Text = "Teachers (Click to return)"
        '
        'teacherEditTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.teachersReturnLabel)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.clearTeachInfoButton)
        Me.Controls.Add(Me.confirmTeachInformation)
        Me.Controls.Add(Me.classIDInput)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.specialtyInput)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.classTypeName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.middleInitial)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.loginTab)
        Me.Controls.Add(Me.studentTab)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.siteInput)
        Me.Controls.Add(Me.teacherSelect)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "teacherEditTeacher"
        Me.Text = "CCPC Student Growth Database Teachers - Edit Teacher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginTab As LinkLabel
    Friend WithEvents studentTab As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents siteInput As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents editTeacher As Label
    Friend WithEvents downloadReports As LinkLabel
    Friend WithEvents deleteTeacher As LinkLabel
    Friend WithEvents addClass As LinkLabel
    Friend WithEvents firstName As TextBox
    Friend WithEvents middleInitial As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents classTypeName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents specialtyInput As TextBox
    Friend WithEvents teacherSelect As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents classIDInput As TextBox
    Friend WithEvents clearTeachInfoButton As Button
    Friend WithEvents confirmTeachInformation As Button
    Friend WithEvents helpButton As Button
    Friend WithEvents logOutButton As Button
    Friend WithEvents teachersReturnLabel As LinkLabel
End Class
