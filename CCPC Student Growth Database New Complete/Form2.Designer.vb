<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainTeacher))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.downloadReports = New System.Windows.Forms.LinkLabel()
        Me.deleteTeacher = New System.Windows.Forms.LinkLabel()
        Me.editTeacher = New System.Windows.Forms.LinkLabel()
        Me.addClass = New System.Windows.Forms.LinkLabel()
        Me.teacherSelect = New System.Windows.Forms.ComboBox()
        Me.classIDInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentTab = New System.Windows.Forms.LinkLabel()
        Me.loginTab = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.viewTeacherInfoButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.downloadReports)
        Me.GroupBox1.Controls.Add(Me.deleteTeacher)
        Me.GroupBox1.Controls.Add(Me.editTeacher)
        Me.GroupBox1.Controls.Add(Me.addClass)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
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
        'teacherSelect
        '
        Me.teacherSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherSelect.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.teacherSelect.FormattingEnabled = True
        Me.teacherSelect.Location = New System.Drawing.Point(364, 12)
        Me.teacherSelect.Name = "teacherSelect"
        Me.teacherSelect.Size = New System.Drawing.Size(484, 28)
        Me.teacherSelect.TabIndex = 1
        Me.teacherSelect.Text = "Teacher Select"
        '
        'classIDInput
        '
        Me.classIDInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classIDInput.Location = New System.Drawing.Point(364, 46)
        Me.classIDInput.Name = "classIDInput"
        Me.classIDInput.Size = New System.Drawing.Size(195, 26)
        Me.classIDInput.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class ID:"
        '
        'studentTab
        '
        Me.studentTab.AutoSize = True
        Me.studentTab.BackColor = System.Drawing.Color.Transparent
        Me.studentTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentTab.Location = New System.Drawing.Point(607, 541)
        Me.studentTab.Name = "studentTab"
        Me.studentTab.Size = New System.Drawing.Size(74, 20)
        Me.studentTab.TabIndex = 6
        Me.studentTab.TabStop = True
        Me.studentTab.Text = "Students"
        '
        'loginTab
        '
        Me.loginTab.AutoSize = True
        Me.loginTab.BackColor = System.Drawing.Color.Transparent
        Me.loginTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginTab.Location = New System.Drawing.Point(891, 541)
        Me.loginTab.Name = "loginTab"
        Me.loginTab.Size = New System.Drawing.Size(56, 20)
        Me.loginTab.TabIndex = 8
        Me.loginTab.TabStop = True
        Me.loginTab.Text = "Logins"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(753, 541)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Teachers"
        '
        'viewTeacherInfoButton
        '
        Me.viewTeacherInfoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewTeacherInfoButton.Location = New System.Drawing.Point(581, 46)
        Me.viewTeacherInfoButton.Name = "viewTeacherInfoButton"
        Me.viewTeacherInfoButton.Size = New System.Drawing.Size(267, 26)
        Me.viewTeacherInfoButton.TabIndex = 3
        Me.viewTeacherInfoButton.Text = "View Information"
        Me.viewTeacherInfoButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 7)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 4
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'mainTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.viewTeacherInfoButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loginTab)
        Me.Controls.Add(Me.studentTab)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classIDInput)
        Me.Controls.Add(Me.teacherSelect)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mainTeacher"
        Me.Text = "CCPC Student Growth Database Teachers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents downloadReports As LinkLabel
    Friend WithEvents deleteTeacher As LinkLabel
    Friend WithEvents editTeacher As LinkLabel
    Friend WithEvents addClass As LinkLabel
    Friend WithEvents teacherSelect As ComboBox
    Friend WithEvents classIDInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents studentTab As LinkLabel
    Friend WithEvents loginTab As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents viewTeacherInfoButton As Button
    Friend WithEvents logOutButton As Button
End Class
