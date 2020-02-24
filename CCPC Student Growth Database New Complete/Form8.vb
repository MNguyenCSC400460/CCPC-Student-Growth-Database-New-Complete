Public Class loginChange
    Private Sub addLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addLogin.LinkClicked
        Me.Hide()
        loginAdd.Show()
    End Sub

    Private Sub studentTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles studentTab.LinkClicked
        Me.Hide()
        mainStudents.Show()
    End Sub

    Private Sub teacherTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles teacherTab.LinkClicked
        Me.Hide()
        mainTeacher.Show()
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Me.Hide()
        LogInScreen.Show()
    End Sub

    Private Sub loginsReturnLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginsReturnLabel.LinkClicked
        Me.Hide()
        mainLogin.Show()
    End Sub
End Class