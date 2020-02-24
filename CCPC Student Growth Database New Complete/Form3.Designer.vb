<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teacherAddClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(teacherAddClass))
        Me.loginTab = New System.Windows.Forms.LinkLabel()
        Me.studentTab = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.classIDInput = New System.Windows.Forms.TextBox()
        Me.teacherSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.addClass = New System.Windows.Forms.Label()
        Me.downloadReports = New System.Windows.Forms.LinkLabel()
        Me.deleteTeacher = New System.Windows.Forms.LinkLabel()
        Me.editTeacher = New System.Windows.Forms.LinkLabel()
        Me.studentListbox = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.classTypeName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.siteInput = New System.Windows.Forms.TextBox()
        Me.addClassButton = New System.Windows.Forms.Button()
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
        Me.loginTab.TabIndex = 13
        Me.loginTab.TabStop = True
        Me.loginTab.Text = "Logins"
        '
        'studentTab
        '
        Me.studentTab.AutoSize = True
        Me.studentTab.BackColor = System.Drawing.Color.Transparent
        Me.studentTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentTab.Location = New System.Drawing.Point(495, 538)
        Me.studentTab.Name = "studentTab"
        Me.studentTab.Size = New System.Drawing.Size(74, 20)
        Me.studentTab.TabIndex = 11
        Me.studentTab.TabStop = True
        Me.studentTab.Text = "Students"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class ID:"
        '
        'classIDInput
        '
        Me.classIDInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classIDInput.Location = New System.Drawing.Point(364, 75)
        Me.classIDInput.Name = "classIDInput"
        Me.classIDInput.Size = New System.Drawing.Size(196, 26)
        Me.classIDInput.TabIndex = 5
        '
        'teacherSelect
        '
        Me.teacherSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherSelect.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.teacherSelect.FormattingEnabled = True
        Me.teacherSelect.Location = New System.Drawing.Point(364, 9)
        Me.teacherSelect.Name = "teacherSelect"
        Me.teacherSelect.Size = New System.Drawing.Size(484, 28)
        Me.teacherSelect.TabIndex = 3
        Me.teacherSelect.Text = "Teacher Select"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.addClass)
        Me.GroupBox1.Controls.Add(Me.downloadReports)
        Me.GroupBox1.Controls.Add(Me.deleteTeacher)
        Me.GroupBox1.Controls.Add(Me.editTeacher)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'addClass
        '
        Me.addClass.AutoSize = True
        Me.addClass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addClass.Location = New System.Drawing.Point(6, 37)
        Me.addClass.Name = "addClass"
        Me.addClass.Size = New System.Drawing.Size(119, 25)
        Me.addClass.TabIndex = 0
        Me.addClass.Text = "Add Class"
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
        'editTeacher
        '
        Me.editTeacher.AutoSize = True
        Me.editTeacher.Location = New System.Drawing.Point(6, 81)
        Me.editTeacher.Name = "editTeacher"
        Me.editTeacher.Size = New System.Drawing.Size(146, 25)
        Me.editTeacher.TabIndex = 1
        Me.editTeacher.TabStop = True
        Me.editTeacher.Text = "Edit Teacher"
        '
        'studentListbox
        '
        Me.studentListbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentListbox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.studentListbox.FormattingEnabled = True
        Me.studentListbox.ItemHeight = 20
        Me.studentListbox.Items.AddRange(New Object() {"Pull students from database"})
        Me.studentListbox.Location = New System.Drawing.Point(364, 147)
        Me.studentListbox.Name = "studentListbox"
        Me.studentListbox.Size = New System.Drawing.Size(583, 324)
        Me.studentListbox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(268, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Class Type:"
        '
        'classTypeName
        '
        Me.classTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classTypeName.Location = New System.Drawing.Point(364, 107)
        Me.classTypeName.Name = "classTypeName"
        Me.classTypeName.Size = New System.Drawing.Size(484, 26)
        Me.classTypeName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(317, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Site:"
        '
        'siteInput
        '
        Me.siteInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siteInput.Location = New System.Drawing.Point(364, 43)
        Me.siteInput.Name = "siteInput"
        Me.siteInput.Size = New System.Drawing.Size(484, 26)
        Me.siteInput.TabIndex = 4
        '
        'addClassButton
        '
        Me.addClassButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addClassButton.Location = New System.Drawing.Point(835, 477)
        Me.addClassButton.Name = "addClassButton"
        Me.addClassButton.Size = New System.Drawing.Size(112, 58)
        Me.addClassButton.TabIndex = 8
        Me.addClassButton.Text = "Add Class"
        Me.addClassButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 4)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 9
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'teachersReturnLabel
        '
        Me.teachersReturnLabel.AutoSize = True
        Me.teachersReturnLabel.BackColor = System.Drawing.Color.Transparent
        Me.teachersReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teachersReturnLabel.LinkColor = System.Drawing.Color.White
        Me.teachersReturnLabel.Location = New System.Drawing.Point(642, 538)
        Me.teachersReturnLabel.Name = "teachersReturnLabel"
        Me.teachersReturnLabel.Size = New System.Drawing.Size(186, 20)
        Me.teachersReturnLabel.TabIndex = 12
        Me.teachersReturnLabel.TabStop = True
        Me.teachersReturnLabel.Text = "Teachers (Click to return)"
        '
        'teacherAddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.teachersReturnLabel)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.addClassButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.siteInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.classTypeName)
        Me.Controls.Add(Me.studentListbox)
        Me.Controls.Add(Me.loginTab)
        Me.Controls.Add(Me.studentTab)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classIDInput)
        Me.Controls.Add(Me.teacherSelect)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "teacherAddClass"
        Me.Text = "CCPC Student Growth Database Teachers - Add Class"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginTab As LinkLabel
    Friend WithEvents studentTab As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents classIDInput As TextBox
    Friend WithEvents teacherSelect As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents addClass As Label
    Friend WithEvents downloadReports As LinkLabel
    Friend WithEvents deleteTeacher As LinkLabel
    Friend WithEvents editTeacher As LinkLabel
    Friend WithEvents studentListbox As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents classTypeName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents siteInput As TextBox
    Friend WithEvents addClassButton As Button
    Friend WithEvents logOutButton As Button
    Friend WithEvents teachersReturnLabel As LinkLabel
End Class
