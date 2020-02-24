<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginChange))
        Me.teacherTab = New System.Windows.Forms.LinkLabel()
        Me.studentTab = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addLogin = New System.Windows.Forms.LinkLabel()
        Me.oldPassword = New System.Windows.Forms.TextBox()
        Me.oldUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newPassword = New System.Windows.Forms.TextBox()
        Me.newUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.loginsReturnLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'teacherTab
        '
        Me.teacherTab.AutoSize = True
        Me.teacherTab.BackColor = System.Drawing.Color.Transparent
        Me.teacherTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherTab.Location = New System.Drawing.Point(646, 537)
        Me.teacherTab.Name = "teacherTab"
        Me.teacherTab.Size = New System.Drawing.Size(75, 20)
        Me.teacherTab.TabIndex = 12
        Me.teacherTab.TabStop = True
        Me.teacherTab.Text = "Teachers"
        '
        'studentTab
        '
        Me.studentTab.AutoSize = True
        Me.studentTab.BackColor = System.Drawing.Color.Transparent
        Me.studentTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentTab.Location = New System.Drawing.Point(492, 537)
        Me.studentTab.Name = "studentTab"
        Me.studentTab.Size = New System.Drawing.Size(74, 20)
        Me.studentTab.TabIndex = 11
        Me.studentTab.TabStop = True
        Me.studentTab.Text = "Students"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.addLogin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Login"
        '
        'addLogin
        '
        Me.addLogin.AutoSize = True
        Me.addLogin.Location = New System.Drawing.Point(6, 126)
        Me.addLogin.Name = "addLogin"
        Me.addLogin.Size = New System.Drawing.Size(118, 25)
        Me.addLogin.TabIndex = 1
        Me.addLogin.TabStop = True
        Me.addLogin.Text = "Add Login"
        '
        'oldPassword
        '
        Me.oldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldPassword.Location = New System.Drawing.Point(473, 74)
        Me.oldPassword.Name = "oldPassword"
        Me.oldPassword.Size = New System.Drawing.Size(365, 26)
        Me.oldPassword.TabIndex = 5
        '
        'oldUsername
        '
        Me.oldUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldUsername.Location = New System.Drawing.Point(473, 12)
        Me.oldUsername.Name = "oldUsername"
        Me.oldUsername.Size = New System.Drawing.Size(365, 26)
        Me.oldUsername.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Current Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current Username:"
        '
        'newPassword
        '
        Me.newPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassword.Location = New System.Drawing.Point(473, 194)
        Me.newPassword.Name = "newPassword"
        Me.newPassword.Size = New System.Drawing.Size(365, 26)
        Me.newPassword.TabIndex = 7
        '
        'newUsername
        '
        Me.newUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newUsername.Location = New System.Drawing.Point(473, 132)
        Me.newUsername.Name = "newUsername"
        Me.newUsername.Size = New System.Drawing.Size(365, 26)
        Me.newUsername.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "New Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(345, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "New Username:"
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(611, 265)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(110, 66)
        Me.saveButton.TabIndex = 8
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 6)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 9
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'loginsReturnLabel
        '
        Me.loginsReturnLabel.AutoSize = True
        Me.loginsReturnLabel.BackColor = System.Drawing.Color.Transparent
        Me.loginsReturnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginsReturnLabel.LinkColor = System.Drawing.Color.White
        Me.loginsReturnLabel.Location = New System.Drawing.Point(791, 537)
        Me.loginsReturnLabel.Name = "loginsReturnLabel"
        Me.loginsReturnLabel.Size = New System.Drawing.Size(167, 20)
        Me.loginsReturnLabel.TabIndex = 13
        Me.loginsReturnLabel.TabStop = True
        Me.loginsReturnLabel.Text = "Logins (Click to return)"
        '
        'loginChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.loginsReturnLabel)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.newPassword)
        Me.Controls.Add(Me.newUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.oldPassword)
        Me.Controls.Add(Me.oldUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.teacherTab)
        Me.Controls.Add(Me.studentTab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "loginChange"
        Me.Text = "CCPC Student Growth Database Logins - Change Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents teacherTab As LinkLabel
    Friend WithEvents studentTab As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addLogin As LinkLabel
    Friend WithEvents oldPassword As TextBox
    Friend WithEvents oldUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents newPassword As TextBox
    Friend WithEvents newUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents saveButton As Button
    Friend WithEvents logOutButton As Button
    Friend WithEvents loginsReturnLabel As LinkLabel
End Class
