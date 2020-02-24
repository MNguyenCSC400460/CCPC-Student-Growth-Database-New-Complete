<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.logIn = New System.Windows.Forms.Button()
        Me.forgotPassword = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(315, 12)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(247, 20)
        Me.userName.TabIndex = 2
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(315, 49)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(247, 20)
        Me.password.TabIndex = 3
        '
        'logIn
        '
        Me.logIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logIn.Location = New System.Drawing.Point(459, 104)
        Me.logIn.Name = "logIn"
        Me.logIn.Size = New System.Drawing.Size(103, 50)
        Me.logIn.TabIndex = 4
        Me.logIn.Text = "Login"
        Me.logIn.UseVisualStyleBackColor = True
        '
        'forgotPassword
        '
        Me.forgotPassword.AutoSize = True
        Me.forgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.forgotPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotPassword.Location = New System.Drawing.Point(312, 104)
        Me.forgotPassword.Name = "forgotPassword"
        Me.forgotPassword.Size = New System.Drawing.Size(123, 18)
        Me.forgotPassword.TabIndex = 5
        Me.forgotPassword.TabStop = True
        Me.forgotPassword.Text = "Forgot Password"
        '
        'LogInScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(574, 315)
        Me.Controls.Add(Me.forgotPassword)
        Me.Controls.Add(Me.logIn)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "LogInScreen"
        Me.Text = "CCPC Student Growth Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userName As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents logIn As Button
    Friend WithEvents forgotPassword As LinkLabel
End Class
