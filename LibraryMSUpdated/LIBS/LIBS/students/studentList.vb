Public Class studentList
    Private Sub studentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookfindthis("SELECT `ID`, `studentID`,`name`,`surname`, `gender`, `dob`,`class`, `address` FROM `students`")
        LoadData(studnt, "studentList")


        bookfindthis("SELECT count(*) FROM `students`")
        Dim numberOfBook = GetCount()
        lblTotal.Text = numberOfBook
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            bookfindthis("SELECT * FROM `students` WHERE `studentID`='" & txtSearch.Text & "'")
            LoadData(studnt, "studentList")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
End Class