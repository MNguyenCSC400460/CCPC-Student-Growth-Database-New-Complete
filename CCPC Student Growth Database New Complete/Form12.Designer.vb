<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentAddStudent))
        Me.loginTab = New System.Windows.Forms.LinkLabel()
        Me.teacherTab = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.calculateStudentGrowth = New System.Windows.Forms.LinkLabel()
        Me.downloadStudentReports = New System.Windows.Forms.LinkLabel()
        Me.deleteStudent = New System.Windows.Forms.LinkLabel()
        Me.editStudent = New System.Windows.Forms.LinkLabel()
        Me.studentFirstName = New System.Windows.Forms.TextBox()
        Me.studentMiddleInitial = New System.Windows.Forms.TextBox()
        Me.studentLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.programType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.siteName = New System.Windows.Forms.TextBox()
        Me.teacherSelect = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.childIDInput = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.otherRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ethnicityDropbox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fundingSourceDropbox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.noRadioButton = New System.Windows.Forms.RadioButton()
        Me.yesRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.noRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.yesRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.studentDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.confirmStudInformation = New System.Windows.Forms.Button()
        Me.clearStudInfoButton = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.studentsReturnLabel = New System.Windows.Forms.LinkLabel()
        Me.otherEthnicTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginTab
        '
        Me.loginTab.AutoSize = True
        Me.loginTab.BackColor = System.Drawing.Color.Transparent
        Me.loginTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginTab.Location = New System.Drawing.Point(891, 536)
        Me.loginTab.Name = "loginTab"
        Me.loginTab.Size = New System.Drawing.Size(56, 20)
        Me.loginTab.TabIndex = 42
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
        Me.teacherTab.TabIndex = 41
        Me.teacherTab.TabStop = True
        Me.teacherTab.Text = "Teachers"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.calculateStudentGrowth)
        Me.GroupBox1.Controls.Add(Me.downloadStudentReports)
        Me.GroupBox1.Controls.Add(Me.deleteStudent)
        Me.GroupBox1.Controls.Add(Me.editStudent)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(6, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(141, 25)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Add Student"
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
        'studentFirstName
        '
        Me.studentFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentFirstName.Location = New System.Drawing.Point(368, 12)
        Me.studentFirstName.Name = "studentFirstName"
        Me.studentFirstName.Size = New System.Drawing.Size(161, 26)
        Me.studentFirstName.TabIndex = 15
        '
        'studentMiddleInitial
        '
        Me.studentMiddleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentMiddleInitial.Location = New System.Drawing.Point(566, 12)
        Me.studentMiddleInitial.Name = "studentMiddleInitial"
        Me.studentMiddleInitial.Size = New System.Drawing.Size(40, 26)
        Me.studentMiddleInitial.TabIndex = 16
        '
        'studentLastName
        '
        Me.studentLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentLastName.Location = New System.Drawing.Point(640, 12)
        Me.studentLastName.Name = "studentLastName"
        Me.studentLastName.Size = New System.Drawing.Size(212, 26)
        Me.studentLastName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(563, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Int."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(637, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Last Name"
        '
        'programType
        '
        Me.programType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programType.Location = New System.Drawing.Point(368, 57)
        Me.programType.Name = "programType"
        Me.programType.Size = New System.Drawing.Size(484, 26)
        Me.programType.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(276, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Program:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(276, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Site Name:"
        '
        'siteName
        '
        Me.siteName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siteName.Location = New System.Drawing.Point(368, 89)
        Me.siteName.Name = "siteName"
        Me.siteName.Size = New System.Drawing.Size(484, 26)
        Me.siteName.TabIndex = 19
        '
        'teacherSelect
        '
        Me.teacherSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherSelect.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.teacherSelect.FormattingEnabled = True
        Me.teacherSelect.Location = New System.Drawing.Point(368, 123)
        Me.teacherSelect.Name = "teacherSelect"
        Me.teacherSelect.Size = New System.Drawing.Size(484, 28)
        Me.teacherSelect.TabIndex = 20
        Me.teacherSelect.Text = "Teacher Select"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(368, 162)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 26)
        Me.TextBox1.TabIndex = 21
        '
        'childIDInput
        '
        Me.childIDInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childIDInput.Location = New System.Drawing.Point(661, 162)
        Me.childIDInput.Name = "childIDInput"
        Me.childIDInput.Size = New System.Drawing.Size(191, 26)
        Me.childIDInput.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(585, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Child ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(277, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Class ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(277, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Gender:"
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.maleRadioButton.Location = New System.Drawing.Point(368, 198)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.maleRadioButton.TabIndex = 23
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "Male"
        Me.maleRadioButton.UseVisualStyleBackColor = False
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.femaleRadioButton.Location = New System.Drawing.Point(588, 198)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.femaleRadioButton.TabIndex = 24
        Me.femaleRadioButton.TabStop = True
        Me.femaleRadioButton.Text = "Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = False
        '
        'otherRadioButton
        '
        Me.otherRadioButton.AutoSize = True
        Me.otherRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.otherRadioButton.Location = New System.Drawing.Point(793, 198)
        Me.otherRadioButton.Name = "otherRadioButton"
        Me.otherRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.otherRadioButton.TabIndex = 25
        Me.otherRadioButton.TabStop = True
        Me.otherRadioButton.Text = "Other"
        Me.otherRadioButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(277, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Ethnicity:"
        '
        'ethnicityDropbox
        '
        Me.ethnicityDropbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ethnicityDropbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ethnicityDropbox.FormattingEnabled = True
        Me.ethnicityDropbox.Items.AddRange(New Object() {"White/Caucasian", "Hispanic/Latino", "Black/African American", "Asian/Island Pacific", "Mixed/Other"})
        Me.ethnicityDropbox.Location = New System.Drawing.Point(368, 224)
        Me.ethnicityDropbox.Name = "ethnicityDropbox"
        Me.ethnicityDropbox.Size = New System.Drawing.Size(484, 28)
        Me.ethnicityDropbox.TabIndex = 26
        Me.ethnicityDropbox.Text = "Select ethnicity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(242, 266)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "*If other, please specify:"
        '
        'fundingSourceDropbox
        '
        Me.fundingSourceDropbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fundingSourceDropbox.FormattingEnabled = True
        Me.fundingSourceDropbox.Location = New System.Drawing.Point(368, 292)
        Me.fundingSourceDropbox.Name = "fundingSourceDropbox"
        Me.fundingSourceDropbox.Size = New System.Drawing.Size(484, 28)
        Me.fundingSourceDropbox.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(277, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Funding Source:"
        '
        'noRadioButton
        '
        Me.noRadioButton.AutoSize = True
        Me.noRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.noRadioButton.Location = New System.Drawing.Point(810, 337)
        Me.noRadioButton.Name = "noRadioButton"
        Me.noRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.noRadioButton.TabIndex = 31
        Me.noRadioButton.TabStop = True
        Me.noRadioButton.Text = "No"
        Me.noRadioButton.UseVisualStyleBackColor = False
        '
        'yesRadioButton
        '
        Me.yesRadioButton.AutoSize = True
        Me.yesRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.yesRadioButton.Location = New System.Drawing.Point(590, 337)
        Me.yesRadioButton.Name = "yesRadioButton"
        Me.yesRadioButton.Size = New System.Drawing.Size(43, 17)
        Me.yesRadioButton.TabIndex = 30
        Me.yesRadioButton.TabStop = True
        Me.yesRadioButton.Text = "Yes"
        Me.yesRadioButton.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(499, 337)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "IEP?"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(368, 364)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(54, 26)
        Me.TextBox2.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(277, 372)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Age (in months):"
        '
        'noRadioButton2
        '
        Me.noRadioButton2.AutoSize = True
        Me.noRadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.noRadioButton2.Location = New System.Drawing.Point(810, 372)
        Me.noRadioButton2.Name = "noRadioButton2"
        Me.noRadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.noRadioButton2.TabIndex = 33
        Me.noRadioButton2.TabStop = True
        Me.noRadioButton2.Text = "No"
        Me.noRadioButton2.UseVisualStyleBackColor = False
        '
        'yesRadioButton2
        '
        Me.yesRadioButton2.AutoSize = True
        Me.yesRadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.yesRadioButton2.Location = New System.Drawing.Point(590, 372)
        Me.yesRadioButton2.Name = "yesRadioButton2"
        Me.yesRadioButton2.Size = New System.Drawing.Size(43, 17)
        Me.yesRadioButton2.TabIndex = 32
        Me.yesRadioButton2.TabStop = True
        Me.yesRadioButton2.Text = "Yes"
        Me.yesRadioButton2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(499, 372)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "ELL?"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(276, 409)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Date Added:"
        '
        'studentDateTimePicker
        '
        Me.studentDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentDateTimePicker.Location = New System.Drawing.Point(368, 399)
        Me.studentDateTimePicker.Name = "studentDateTimePicker"
        Me.studentDateTimePicker.Size = New System.Drawing.Size(484, 26)
        Me.studentDateTimePicker.TabIndex = 34
        '
        'confirmStudInformation
        '
        Me.confirmStudInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmStudInformation.Location = New System.Drawing.Point(598, 444)
        Me.confirmStudInformation.Name = "confirmStudInformation"
        Me.confirmStudInformation.Size = New System.Drawing.Size(112, 70)
        Me.confirmStudInformation.TabIndex = 35
        Me.confirmStudInformation.Text = "Confirm Information"
        Me.confirmStudInformation.UseVisualStyleBackColor = True
        '
        'clearStudInfoButton
        '
        Me.clearStudInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearStudInfoButton.Location = New System.Drawing.Point(793, 444)
        Me.clearStudInfoButton.Name = "clearStudInfoButton"
        Me.clearStudInfoButton.Size = New System.Drawing.Size(112, 70)
        Me.clearStudInfoButton.TabIndex = 36
        Me.clearStudInfoButton.Text = "Clear"
        Me.clearStudInfoButton.UseVisualStyleBackColor = True
        '
        'helpButton
        '
        Me.helpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpButton.Location = New System.Drawing.Point(12, 41)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(112, 33)
        Me.helpButton.TabIndex = 38
        Me.helpButton.Text = "Help"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 5)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 37
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'studentsReturnLabel
        '
        Me.studentsReturnLabel.AutoSize = True
        Me.studentsReturnLabel.BackColor = System.Drawing.Color.Transparent
        Me.studentsReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentsReturnLabel.LinkColor = System.Drawing.Color.White
        Me.studentsReturnLabel.Location = New System.Drawing.Point(498, 536)
        Me.studentsReturnLabel.Name = "studentsReturnLabel"
        Me.studentsReturnLabel.Size = New System.Drawing.Size(185, 20)
        Me.studentsReturnLabel.TabIndex = 40
        Me.studentsReturnLabel.TabStop = True
        Me.studentsReturnLabel.Text = "Students (Click to return)"
        '
        'otherEthnicTextbox
        '
        Me.otherEthnicTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherEthnicTextbox.Location = New System.Drawing.Point(368, 260)
        Me.otherEthnicTextbox.Name = "otherEthnicTextbox"
        Me.otherEthnicTextbox.Size = New System.Drawing.Size(484, 26)
        Me.otherEthnicTextbox.TabIndex = 27
        '
        'studentAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.otherEthnicTextbox)
        Me.Controls.Add(Me.studentsReturnLabel)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.clearStudInfoButton)
        Me.Controls.Add(Me.confirmStudInformation)
        Me.Controls.Add(Me.studentDateTimePicker)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.noRadioButton2)
        Me.Controls.Add(Me.yesRadioButton2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.noRadioButton)
        Me.Controls.Add(Me.yesRadioButton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.fundingSourceDropbox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ethnicityDropbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.otherRadioButton)
        Me.Controls.Add(Me.femaleRadioButton)
        Me.Controls.Add(Me.maleRadioButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.childIDInput)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.teacherSelect)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.siteName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.programType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.studentLastName)
        Me.Controls.Add(Me.studentMiddleInitial)
        Me.Controls.Add(Me.studentFirstName)
        Me.Controls.Add(Me.loginTab)
        Me.Controls.Add(Me.teacherTab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "studentAddStudent"
        Me.Text = "CCPC Student Growth Database Students - Add Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginTab As LinkLabel
    Friend WithEvents teacherTab As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents calculateStudentGrowth As LinkLabel
    Friend WithEvents downloadStudentReports As LinkLabel
    Friend WithEvents deleteStudent As LinkLabel
    Friend WithEvents editStudent As LinkLabel
    Friend WithEvents studentFirstName As TextBox
    Friend WithEvents studentMiddleInitial As TextBox
    Friend WithEvents studentLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents programType As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents siteName As TextBox
    Friend WithEvents teacherSelect As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents childIDInput As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents otherRadioButton As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents ethnicityDropbox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents fundingSourceDropbox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents noRadioButton As RadioButton
    Friend WithEvents yesRadioButton As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents noRadioButton2 As RadioButton
    Friend WithEvents yesRadioButton2 As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents studentDateTimePicker As DateTimePicker
    Friend WithEvents confirmStudInformation As Button
    Friend WithEvents clearStudInfoButton As Button
    Friend WithEvents helpButton As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents logOutButton As Button
    Friend WithEvents studentsReturnLabel As LinkLabel
    Friend WithEvents otherEthnicTextbox As TextBox
End Class
