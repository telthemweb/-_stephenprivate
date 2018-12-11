Public Class IssueBook
    Public Sub Cb_load()
        bookfindthis("select DISTINCT(author) from books")
        fillcombo(cbAuthor, "author", "author")

        bookfindthis("select DISTINCT(title) from books")
        fillcombo(cbTitle, "title", "title")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            bookfindthis("SELECT * FROM `books` WHERE `bookID`='" & txtSearch.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtBookNumber.Text = dReader("bookID")
                txISNB.Text = dReader("isbn")
                txtTitle.Text = dReader("title")
                txtAuth.Text = dReader("author")
                txtPublisher.Text = dReader("publisher")
                txtSerial.Text = dReader("serial")
                txtSearch.Text = ""
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            bookfindthis("SELECT * FROM students WHERE studentID = '" & txtSearch2.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtReg.Text = dReader("studentID")
                txtNam.Text = dReader("name")
                txtSurname.Text = dReader("surname")
                cbClass.Text = dReader("class")
                cbGender.Text = dReader("gender")
                txtSearch2.Text = ""

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim ts As TimeSpan = DateTimePicker2.Value.Date - DateTime.Today.Date

        Dim total As Integer = ts.Days
        lblNumofDays.Text = total.ToString()

        If Val(lblNumofDays.Text) < 0 Then
            lblNumofDays.Text = 0
        End If

        dtpReturned.Value = DateTimePicker2.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sql = "SELECT * FROM `loan` WHERE `isbn`='" & txISNB.Text & "' "
        bookfindthis(sql)

        If GetNumRows() = 1 Then
            MsgBox("This book has been Borrowed ", MsgBoxStyle.Critical)
        Else

            issucess = book_insert("INSERT INTO `loan` (`studentID`, `isbn`, `issuedate`, `dateReturned`,`numberOfday`)  VALUES ('" & txtReg.Text & "','" & txISNB.Text & "','" & dtpBorrwed.Text & "', '" & dtpReturned.Text & "', '" & lblNumofDays.Text & "');")
            If issucess = True Then
                MsgBox("You have Issued book to '" & txtNam.Text & "'  successfully! Book will be return on  '" & DateTimePicker2.Text & "'", MsgBoxStyle.Information)
                book_insert("UPDATE books SET status= 'Unvailable' WHERE isbn='" & txISNB.Text & "'")

                book_insert("INSERT INTO `tbtransaction` (`bookID`,`isbn`, `studentID`, `issuedate`, `dateReturned`,`dateAdded`)  VALUES ('" & txtBookNumber.Text & "','" & txISNB.Text & "','" & txtReg.Text & "','" & dtpBorrwed.Text & "', '" & dtpReturned.Text & "', '" & dtpRegistered.Text & "');")

            Else
                MsgBox("No Book has been issued to '" & txtNam.Text & "'!")
            End If
        End If
    End Sub

    Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cb_load()
    End Sub

    Private Sub cbTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTitle.SelectedIndexChanged

    End Sub

    Private Sub cbAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAuthor.SelectedIndexChanged

    End Sub

    Private Sub cbpublisher_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            bookfindthis("SELECT * FROM `books` WHERE `author`='" & cbAuthor.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtBookNumber.Text = dReader("bookID")
                txISNB.Text = dReader("isbn")
                txtTitle.Text = dReader("title")
                txtAuth.Text = dReader("author")
                txtPublisher.Text = dReader("publisher")
                txtSerial.Text = dReader("serial")
                txtSearch.Text = ""
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            bookfindthis("SELECT * FROM `books` WHERE `title`='" & cbTitle.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtBookNumber.Text = dReader("bookID")
                txISNB.Text = dReader("isbn")
                txtTitle.Text = dReader("title")
                txtAuth.Text = dReader("author")
                txtPublisher.Text = dReader("publisher")
                txtSerial.Text = dReader("serial")
                txtSearch.Text = ""
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub
End Class