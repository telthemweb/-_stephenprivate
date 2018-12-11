Public Class Book_Entry
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txISNB.Text = "" Then
            MsgBox("ISNB is required", MsgBoxStyle.Critical)

        ElseIf txtTitle.Text = "" Then
            MsgBox("Title is required", MsgBoxStyle.Critical)

        ElseIf txtAuth.Text = "" Then
            MsgBox("Author is required", MsgBoxStyle.Critical)

        ElseIf txtSerial.Text = "" Then
            MsgBox("Book Serial Number is required", MsgBoxStyle.Critical)
        ElseIf rtDescription.Text = "" Then
            MsgBox("Please make sure you have provide description of the book", MsgBoxStyle.Critical)
        ElseIf txtPublisher.Text = "" Then
            MsgBox("Publisher required", MsgBoxStyle.Critical)
        Else
            issucess = book_insert("INSERT INTO `books` (`bookID`,`isbn`, `title`, `author`,`publisher`,`serial`, `Desrciption`)   VALUES ('" & txtBookNumber.Text & "','" & txISNB.Text & "','" & txtTitle.Text & "', '" & txtAuth.Text & "', '" & txtPublisher.Text & "','" & txtSerial.Text & "', '" & rtDescription.Text & "' );")
            If issucess = True Then
                MsgBox("New Book has been added successfully!", MsgBoxStyle.Information)
                txtAuth.Clear()
                txtPublisher.Clear()
                txtSerial.Clear()
                txtTitle.Clear()
                txISNB.Clear()
                BookList.Show()
                Me.Hide()
            Else
                MsgBox("No Book added into the database!", MsgBoxStyle.Critical)

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtAuth.Clear()
        txtPublisher.Clear()
        txtSerial.Clear()
        txtTitle.Clear()
        txISNB.Clear()
    End Sub

    Private Sub Book_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            bookfindthis("SELECT Max(bookID) FROM `books`")
            con.Open()
            Dim a As Integer = cmd.ExecuteScalar
            txtBookNumber.Text = a + 1
                If txtBookNumber.Text = "" Then

                End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try

    End Sub
End Class