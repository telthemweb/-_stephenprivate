Public Class BookList

    Public Sub Cb_load()
        bookfindthis("select DISTINCT(publisher) from books")
        fillcombo(cbpublisher, "publisher", "publisher")

        bookfindthis("select DISTINCT(author) from books")
        fillcombo(cbAuthor, "author", "author")

        bookfindthis("select DISTINCT(title) from books")
        fillcombo(cbTitle, "title", "title")
    End Sub

    Public Sub refress()
        bookfindthis("SELECT `bookID`, `isbn`,`title`,`author`, `publisher`,`serial`, `Desrciption`, `status` FROM `books`")
        LoadData(booksList, "bookList")
    End Sub
    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refress()
        Cb_load()

        bookfindthis("SELECT count(*) FROM `books`")
        Dim numberOfBook = GetCount()
        lblTotal.Text = numberOfBook

    End Sub

    Private Sub booksList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles booksList.CellClick
        txtBookNumber.Text = booksList.CurrentRow.Cells(0).Value.ToString
        txISNB.Text = booksList.CurrentRow.Cells(1).Value.ToString
        txtTitle.Text = booksList.CurrentRow.Cells(2).Value.ToString
        txtAuth.Text = booksList.CurrentRow.Cells(3).Value.ToString
        txtPublisher.Text = booksList.CurrentRow.Cells(4).Value.ToString
        txtSerial.Text = booksList.CurrentRow.Cells(5).Value.ToString
        rtDescription.Text = booksList.CurrentRow.Cells(6).Value.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        issucess = book_insert("UPDATE `books` SET `isbn`='" & txISNB.Text & "',`title`= '" & txtTitle.Text & "',`author`='" & txtAuth.Text & "',`publisher`= '" & txtPublisher.Text & "',`serial`=  '" & txtSerial.Text & "',`Desrciption`='" & rtDescription.Text & "' WHERE `bookID`='" & txtBookNumber.Text & "'")
        If issucess = True Then
            MsgBox("Book has been updated successfully!", MsgBoxStyle.Information)
            refress()
        Else
            MsgBox("No Book has been updated!")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bookfindthis("SELECT * FROM `books` WHERE `isbn`='" & txtSearch.Text & "' ")
        LoadData(booksList, "bookList")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        issucess = book_delete("DELETE From books  Where isbn='" & txISNB.Text & "'")
        If issucess = True Then
            MsgBox("Book has been deleted successfully!", MsgBoxStyle.Information)
            refress()

        End If
    End Sub

    Private Sub cbpublisher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpublisher.SelectedIndexChanged
        bookfindthis("SELECT * FROM `books` WHERE `publisher`='" & cbpublisher.Text & "' ")
        LoadData(booksList, "bookList")
    End Sub

    Private Sub cbAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAuthor.SelectedIndexChanged
        bookfindthis("SELECT * FROM `books` WHERE `author`='" & cbAuthor.Text & "' ")
        LoadData(booksList, "bookList")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        refress()
    End Sub
End Class