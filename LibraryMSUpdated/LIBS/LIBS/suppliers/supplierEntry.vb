Public Class supplierEntry

    Public Sub RefreshGrid()
        bookfindthis("SELECT sid,name,surname,city,address,phone,email FROM supplier")
        LoadData(supGrid, "supplier")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtAddres.Clear()
        txtCity.Clear()
        txtEmail.Clear()
        txtFname.Clear()
        txtPhone.Clear()
        txtSurname.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtAddres.Text = "" Then
            MsgBox("Address is required", MsgBoxStyle.Critical)

        ElseIf txtCity.Text = "" Then
            MsgBox("City is required", MsgBoxStyle.Critical)

        ElseIf txtEmail.Text = "" Then
            MsgBox("Email is required", MsgBoxStyle.Critical)

        ElseIf txtFname.Text = "" Then
            MsgBox("Name Serial Number is required", MsgBoxStyle.Critical)
        ElseIf txtPhone.Text = "" Then
            MsgBox("Phone is required", MsgBoxStyle.Critical)
        ElseIf txtSurname.Text = "" Then
            MsgBox("Surname required", MsgBoxStyle.Critical)
        Else
            issucess = book_insert("INSERT INTO `supplier` (`name`, `surname`, `city`,`address`,`phone`, `email`)   VALUES ('" & txtFname.Text & "','" & txtSurname.Text & "', '" & txtCity.Text & "', '" & txtAddres.Text & "','" & txtPhone.Text & "', '" & txtEmail.Text & "' );")
            If issucess = True Then
                MsgBox("New supplier has been added successfully!", MsgBoxStyle.Information)
                RefreshGrid()
            Else
                MsgBox("No supplier added into the database!", MsgBoxStyle.Critical)

            End If
        End If
    End Sub

    Private Sub supplierEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()



        bookfindthis("SELECT DISTINCT(city) FROM supplier  ")
        fillcombo(cbCity, "city", "city")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bookfindthis("SELECT * FROM supplier WHERE city = '" & txtSearch.Text & "' ")
        LoadData(supGrid, "supplier")
    End Sub



    Private Sub supGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles supGrid.CellClick
        lblSupp.Text = supGrid.CurrentRow.Cells(0).Value.ToString
        txtFname.Text = supGrid.CurrentRow.Cells(1).Value.ToString
        txtSurname.Text = supGrid.CurrentRow.Cells(2).Value.ToString
        txtCity.Text = supGrid.CurrentRow.Cells(3).Value.ToString
        txtAddres.Text = supGrid.CurrentRow.Cells(4).Value.ToString
        txtPhone.Text = supGrid.CurrentRow.Cells(5).Value.ToString
        txtEmail.Text = supGrid.CurrentRow.Cells(6).Value.ToString

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        issucess = book_insert("UPDATE supplier SET name='" & txtFname.Text & "', surname='" & txtSurname.Text & "',city='" & txtCity.Text & "',address='" & txtAddres.Text & "',phone='" & txtPhone.Text & "',email='" & txtEmail.Text & "'  WHERE phone='" & txtPhone.Text & "'")
        If issucess = True Then
            MsgBox("New supplier has been updated successfully!", MsgBoxStyle.Information)
            RefreshGrid()
        Else
            MsgBox("No supplier updated into the database!", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub cbCity_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCity.SelectedValueChanged
        bookfindthis("SELECT * FROM supplier WHERE city = '" & cbCity.Text & "' ")
        LoadData(supGrid, "supplier")
    End Sub

    Private Sub txtPhone_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyUp
        If Not Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please Only numbers allowed here for phone Number!!!", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub txtFname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFname.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please Only characters allowed here for first name!!!", MsgBoxStyle.Critical)
            txtFname.Text = ""
        End If
    End Sub

    Private Sub txtSurname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSurname.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please Only characters allowed here for surname!!!", MsgBoxStyle.Critical)
            txtSurname.Text = ""
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        Try
            bookfindthis("SELECT * FROM supplier WHERE phone = '" & txtPhone.Text & "' ")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                lblSupp.Text = dReader("sid")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        issucess = book_delete("DELETE From supplier  Where phone='" & txtPhone.Text & "'")
        If issucess = True Then
            MsgBox("Supplier has been deleted successfully!", MsgBoxStyle.Information)
            RefreshGrid()

        End If
    End Sub

    Private Sub txtEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyUp



    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress

        Dim ac As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If ac.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else

                            If txtEmail.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If


                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged

    End Sub

    Private Sub txtCity_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCity.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please Only characters allowed here for City!!!", MsgBoxStyle.Critical)
            txtCity.Text = ""
        End If
    End Sub
End Class