Public Class UsersList
    Private Sub UsersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookfindthis("SELECT `userID`, `name`,`surname`, `username`, `password`,`usertype` FROM `user`")
        LoadData(userlist, "users")


        bookfindthis("SELECT count(*) FROM `user`")
        Dim numberOfBook = GetCount()
        lblTotal.Text = numberOfBook
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class