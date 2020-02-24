Public Class teacherEditTeacher
    Private Sub addClass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addClass.LinkClicked
        Me.Hide()
        teacherAddClass.Show()
    End Sub

    Private Sub deleteTeacher_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles deleteTeacher.LinkClicked
        Me.Hide()
        teacherDeleteTeacher.Show()
    End Sub

    Private Sub downloadReports_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles downloadReports.LinkClicked
        Me.Hide()
        teacherDownloadReports.Show()
    End Sub

    Private Sub studentTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles studentTab.LinkClicked
        Me.Hide()
        mainStudents.Show()
    End Sub

    Private Sub loginTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginTab.LinkClicked
        Me.Hide()
        mainLogin.Show()
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Me.Hide()
        LogInScreen.Show()
    End Sub

    Private Sub teachersReturnLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles teachersReturnLabel.LinkClicked
        Me.Hide()
        mainTeacher.Show()
    End Sub
End Class