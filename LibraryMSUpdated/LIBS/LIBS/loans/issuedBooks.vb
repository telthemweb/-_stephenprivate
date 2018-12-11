Public Class issuedBooks
    Private Sub issuedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookfindthis("SELECT loan.bookID,loan.isbn,loan.studentID,books.title,books.author,books.publisher,loan.issuedate from loan INNER Join books on loan.bookID= books.bookID order by loan.bookID ")

        LoadData(grdBorrw, "issuedBooks")


        Try
            bookfindthis("SELECT Max(receipt) FROM `penalty`")
            con.Open()
            Dim a As Integer = cmd.ExecuteScalar
            txtReceipt.Text = a + 1
            If txtReceipt.Text = "" Then

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try



    End Sub

    Private Sub grdBorrw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdBorrw.CellClick
        txtBookNumber.Text = grdBorrw.CurrentRow.Cells(0).Value.ToString
        txISNB.Text = grdBorrw.CurrentRow.Cells(1).Value.ToString
        txtReg.Text = grdBorrw.CurrentRow.Cells(2).Value.ToString
        txtTitle.Text = grdBorrw.CurrentRow.Cells(3).Value.ToString
        txtAuth.Text = grdBorrw.CurrentRow.Cells(4).Value.ToString
        txtPublisher.Text = grdBorrw.CurrentRow.Cells(5).Value.ToString
        dtpBorrwed.Text = grdBorrw.CurrentRow.Cells(6).Value.ToString
    End Sub

    Private Sub txtReg_TextChanged(sender As Object, e As EventArgs) Handles txtReg.TextChanged
        Try
            bookfindthis("SELECT * FROM students WHERE studentID = '" & txtReg.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtReg.Text = dReader("studentID")
                txtNam.Text = dReader("name")
                txtSurname.Text = dReader("surname")
                cbClass.Text = dReader("class")
                cbGender.Text = dReader("gender")

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim book = grdBorrw.CurrentRow.Cells("b_title").Value
        Dim stdntID = grdBorrw.CurrentRow.Cells("studentId").Value
        Dim bISBN = grdBorrw.CurrentRow.Cells("bISBN").Value


        Dim OverLappedRentDays As Integer = 0
        Dim RentExpiration As Date = CDate(dtpReturned.Value)
        Dim OverLappedPenalty As Integer = 1.0
        Dim TotalOverLappedPenalty As Integer = 0



        OverLappedRentDays = Date.Now.Day - RentExpiration.Day
        TotalOverLappedPenalty = OverLappedRentDays * OverLappedPenalty


        If OverLappedRentDays > 0 Then
                MessageBox.Show(book & " OverDue Book " & OverLappedRentDays & " days." & vbNewLine &
                    "You have exceeded number of days with book, so you should pay fine.", "Library system", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Penalty.Enabled = True
                txtNum.Text = OverLappedRentDays
                txtTot.Text = OverLappedPenalty
                txtRg.Text = stdntID
                txtIsbn.Text = bISBN
                txtTotal.Text = TotalOverLappedPenalty
                btnReturn.Enabled = False

            ElseIf OverLappedRentDays <= 0 Then
                issucess = book_insert("UPDATE books SET status= 'Available' WHERE isbn='" & txISNB.Text & "'")
                book_insert("UPDATE tbtransaction SET isbn= '" & txISNB.Text & "', studentID= '" & txtReg.Text & "', issuedate= '" & dtpBorrwed.Text & "', dateReturned= '" & dtpReturned.Text & "',dateAdded= '" & dtpRegistered.Text & "' WHERE isbn='" & txISNB.Text & "'")

                If issucess = True Then
                    MsgBox("book returned")
                    book_delete("DELETE From loan  Where isbn='" & txISNB.Text & "'")
                Else
                    MsgBox("Book error ................", MsgBoxStyle.Critical)
                End If
            Else



            End If









    End Sub

    Private Sub txtAmt_TextChanged(sender As Object, e As EventArgs) Handles txtAmt.TextChanged
        lblChange.Text = Val(txtAmt.Text) - Val(txtTotal.Text)

        If Val(lblChange.Text) < 0 Then
            lblChange.Text = 0.0
        End If
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        txtTotal.Text = Val(txtNum.Text) * Val(txtTot.Text)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        issucess = book_insert("INSERT INTO `penalty` (`receipt`, `studentID`, `totalPaid`,`isbn`,`numDays`, `datePayed`,`amtperday`,`changeleft`)   VALUES ('" & txtReceipt.Text & "','" & txtReg.Text & "', '" & txtTotal.Text & "', '" & txtIsbn.Text & "','" & txtNum.Text & "', '" & dtpaid.Value & "' , '" & txtTot.Text & "', '" & lblChange.Text & "');")
        If issucess = True Then

            MsgBox("New fine has been paid successfully!", MsgBoxStyle.Information)
            issucess = book_insert("UPDATE books SET status= 'Available' WHERE isbn='" & txISNB.Text & "'")
            book_insert("INSERT INTO `tbtransaction` (`bookID`,`isbn`, `studentID`, `issuedate`, `dateReturned`,`dateAdded`)  VALUES ('" & txtBookNumber.Text & "','" & txISNB.Text & "','" & txtReg.Text & "','" & dtpBorrwed.Text & "', '" & dtpReturned.Text & "', '" & dtpRegistered.Text & "');")

            If issucess = True Then
                MsgBox("book returned")
                book_delete("DELETE From loan  Where isbn='" & txISNB.Text & "'")
            Else
                MsgBox("Book error ................", MsgBoxStyle.Critical)
            End If
            Receipt.Show()
            Me.Hide()
            Receipt.rtReceipt.Clear()

            Receipt.rtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab + "Library Management System" + vbNewLine)
            Receipt.rtReceipt.AppendText("==================================================================================================================" + vbTab + vbTab + vbTab + vbTab + vbTab + vbNewLine)
            Receipt.rtReceipt.AppendText("Receipt Number" + vbTab + vbTab + vbTab + vbTab + txtReceipt.Text + vbNewLine)
            Receipt.rtReceipt.AppendText("Student ID Number" + vbTab + vbTab + vbTab + txtReg.Text + vbNewLine)
            Receipt.rtReceipt.AppendText("Book ISBN" + vbTab + vbTab + vbTab + vbTab + txtIsbn.Text + vbNewLine)
            Receipt.rtReceipt.AppendText("Number of Overdue days" + vbTab + vbTab + txtNum.Text + "days" + vbNewLine)
            Receipt.rtReceipt.AppendText("Amount Per day" + vbTab + vbTab + vbTab + vbTab + "$" + txtAmt.Text + ".00" + vbNewLine)
            Receipt.rtReceipt.AppendText("Amount Paid" + vbTab + vbTab + vbTab + vbTab + "$" + txtAmt.Text + ".00" + vbNewLine)
            Receipt.rtReceipt.AppendText("Total Fine" + vbTab + vbTab + vbTab + vbTab + "$" + txtTotal.Text + ".00" + vbNewLine)
            Receipt.rtReceipt.AppendText("Change" + vbTab + vbTab + vbTab + vbTab + vbTab + "$" + lblChange.Text + ".00" + vbNewLine)
            Receipt.rtReceipt.AppendText("==================================================================================================================" + vbTab + vbTab + vbTab + vbTab + vbTab + vbNewLine)


            btnReturn.Visible = False
            Penalty.Visible = False
            btnBnow.Visible = True
        Else
            MsgBox("Error to pay your amount..............!", MsgBoxStyle.Critical)

        End If


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnBnow.Click
        issucess = book_insert("UPDATE books SET status= 'Available' WHERE isbn='" & txISNB.Text & "'")
        book_insert("INSERT INTO `tbtransaction` (`bookID`,`isbn`, `studentID`, `issuedate`, `dateReturned`,`dateAdded`)  VALUES ('" & txtBookNumber.Text & "','" & txISNB.Text & "','" & txtReg.Text & "','" & dtpBorrwed.Text & "', '" & dtpReturned.Text & "', '" & dtpRegistered.Text & "');")

        If issucess = True Then
            MsgBox("book returned")
            book_delete("DELETE From loan  Where isbn='" & txISNB.Text & "'")
        Else
            MsgBox("Book error ................", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            bookfindthis("SELECT * FROM `loan` WHERE `bookID`='" & txtSearch.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtBookNumber.Text = dReader("bookID")
                txtReg.Text = dReader("studentID")
                dtpBorrwed.Text = dReader("issuedate")
                dtpReturned.Text = dReader("dateReturned")
                txtSearch.Text = ""
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub txtBookNumber_TextChanged(sender As Object, e As EventArgs) Handles txtBookNumber.TextChanged
        Try
            bookfindthis("SELECT * FROM `books` WHERE `bookID`='" & txtBookNumber.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txISNB.Text = dReader("isbn")
                txtTitle.Text = dReader("title")
                txtAuth.Text = dReader("author")
                txtPublisher.Text = dReader("publisher")

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try

        Try
            bookfindthis("SELECT * FROM `loan` WHERE `bookID`='" & txtBookNumber.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read

                dtpReturned.Text = dReader("dateReturned")

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub
End Class