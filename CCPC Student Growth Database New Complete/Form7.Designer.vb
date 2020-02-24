<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainLogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentTab = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.addLogin = New System.Windows.Forms.LinkLabel()
        Me.changeLogin = New System.Windows.Forms.LinkLabel()
        Me.teacherTab = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usernameDisplay = New System.Windows.Forms.TextBox()
        Me.passwordDisplay = New System.Windows.Forms.TextBox()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(891, 537)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Logins"
        '
        'studentTab
        '
        Me.studentTab.AutoSize = True
        Me.studentTab.BackColor = System.Drawing.Color.Transparent
        Me.studentTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentTab.Location = New System.Drawing.Point(607, 538)
        Me.studentTab.Name = "studentTab"
        Me.studentTab.Size = New System.Drawing.Size(74, 20)
        Me.studentTab.TabIndex = 7
        Me.studentTab.TabStop = True
        Me.studentTab.Text = "Students"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.addLogin)
        Me.GroupBox1.Controls.Add(Me.changeLogin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 218)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
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
        'changeLogin
        '
        Me.changeLogin.AutoSize = True
        Me.changeLogin.Location = New System.Drawing.Point(6, 60)
        Me.changeLogin.Name = "changeLogin"
        Me.changeLogin.Size = New System.Drawing.Size(158, 25)
        Me.changeLogin.TabIndex = 0
        Me.changeLogin.TabStop = True
        Me.changeLogin.Text = "Change Login"
        '
        'teacherTab
        '
        Me.teacherTab.AutoSize = True
        Me.teacherTab.BackColor = System.Drawing.Color.Transparent
        Me.teacherTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teacherTab.Location = New System.Drawing.Point(753, 537)
        Me.teacherTab.Name = "teacherTab"
        Me.teacherTab.Size = New System.Drawing.Size(75, 20)
        Me.teacherTab.TabIndex = 8
        Me.teacherTab.TabStop = True
        Me.teacherTab.Text = "Teachers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password:"
        '
        'usernameDisplay
        '
        Me.usernameDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameDisplay.Location = New System.Drawing.Point(463, 70)
        Me.usernameDisplay.Name = "usernameDisplay"
        Me.usernameDisplay.Size = New System.Drawing.Size(365, 26)
        Me.usernameDisplay.TabIndex = 3
        '
        'passwordDisplay
        '
        Me.passwordDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordDisplay.Location = New System.Drawing.Point(463, 132)
        Me.passwordDisplay.Name = "passwordDisplay"
        Me.passwordDisplay.Size = New System.Drawing.Size(365, 26)
        Me.passwordDisplay.TabIndex = 4
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(12, 5)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(112, 33)
        Me.logOutButton.TabIndex = 5
        Me.logOutButton.Text = "Log-out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'mainLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(959, 566)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.passwordDisplay)
        Me.Controls.Add(Me.usernameDisplay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.teacherTab)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.studentTab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mainLogin"
        Me.Text = "CCPC Student Growth Database Logins"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents studentTab As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents teacherTab As LinkLabel
    Friend WithEvents addLogin As LinkLabel
    Friend WithEvents changeLogin As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents usernameDisplay As TextBox
    Friend WithEvents passwordDisplay As TextBox
    Friend WithEvents logOutButton As Button
End Class
