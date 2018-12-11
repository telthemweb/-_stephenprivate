Public Class MainPage
    Private Sub lblAvtar_Click(sender As Object, e As EventArgs) Handles lblAvtar.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        User_Registration.ShowDialog()
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBookToolStripMenuItem.Click
        Book_Entry.ShowDialog()
    End Sub

    Private Sub ViewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewsToolStripMenuItem.Click
        BookList.Show()

    End Sub

    Private Sub ViewUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUsersToolStripMenuItem.Click
        UsersList.ShowDialog()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        addStudent.ShowDialog()
    End Sub

    Private Sub ViewStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentsToolStripMenuItem.Click
        studentList.ShowDialog()
    End Sub

    Private Sub IssuesBooksToolStripMenuItem_Click(sender As Object, e As EventArgs)
        IssueBook.ShowDialog()
    End Sub


    Private Sub ReturnBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnBooksToolStripMenuItem.Click
        finelist.ShowDialog()
    End Sub


    Private Sub SuppliersRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersRegistrationToolStripMenuItem.Click
        supplierEntry.ShowDialog()
    End Sub

    Private Sub BoorrowedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoorrowedBooksToolStripMenuItem.Click
        issuedBooks.ShowDialog()
    End Sub

    Private Sub TechnicalSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnicalSupportToolStripMenuItem.Click
        TransactionList.Show()
    End Sub

    Private Sub IssueBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueBookToolStripMenuItem.Click
        IssueBook.Show()
    End Sub
End Class