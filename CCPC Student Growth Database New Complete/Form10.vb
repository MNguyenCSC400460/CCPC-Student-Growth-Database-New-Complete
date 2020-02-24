Public Class mainStudents

    Private Sub calculateStudentGrowth_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles calculateStudentGrowth.LinkClicked
        Me.Hide()
        studentCalculateGrowth.Show()
    End Sub

    Private Sub addStudent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addStudent.LinkClicked
        Me.Hide()
        studentAddStudent.Show()
    End Sub

    Private Sub editStudent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles editStudent.LinkClicked
        Me.Hide()
        studentEditStudent.Show()
    End Sub

    Private Sub deleteStudent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles deleteStudent.LinkClicked
        Me.Hide()
        studentDeleteStudent.Show()
    End Sub

    Private Sub downloadStudentReports_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles downloadStudentReports.LinkClicked
        Me.Hide()
        studentDownloadReports.Show()
    End Sub

    Private Sub teacherTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles teacherTab.LinkClicked
        Me.Hide()
        mainTeacher.Show()
    End Sub

    Private Sub loginTab_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginTab.LinkClicked
        Me.Hide()
        mainLogin.Show()
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Me.Hide()
        LogInScreen.Show()
    End Sub
End Class