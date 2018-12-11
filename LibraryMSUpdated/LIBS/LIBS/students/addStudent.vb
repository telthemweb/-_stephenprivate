Public Class addStudent
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            bookfindthis("SELECT Max(studentID) FROM `students`")
            con.Open()
            Dim a As Integer = cmd.ExecuteScalar
            txtReg.Text = a + 1
            If txtReg.Text = "" Then

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtReg.Text = "" Then
            MsgBox("Student ID is required", MsgBoxStyle.Critical)

        ElseIf txtNam.Text = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical)

        ElseIf txtSurname.Text = "" Then
            MsgBox("Surname is required", MsgBoxStyle.Critical)

        ElseIf cbGender.Text = "" Then
            MsgBox("Please select Gender", MsgBoxStyle.Critical)
        ElseIf cbClass.Text = "" Then
            MsgBox("Class required", MsgBoxStyle.Critical)
        ElseIf txtAddres.Text = "" Then
            MsgBox("Address required", MsgBoxStyle.Critical)
        Else
            issucess = book_insert("INSERT INTO `students` (`studentID`, `name`, `surname`,`gender`,`dob`, `class`,`address`)   VALUES ('" & txtReg.Text & "','" & txtNam.Text & "', '" & txtSurname.Text & "', '" & cbGender.Text & "','" & dtpDOB.Text & "', '" & cbClass.Text & "', '" & txtAddres.Text & "' );")
            If issucess = True Then
                MsgBox("New student has been added successfully!", MsgBoxStyle.Information)
                txtAddres.Clear()
                txtNam.Clear()
                txtReg.Clear()
                BookList.Show()
                Me.Hide()
            Else
                MsgBox("No student added into the database!", MsgBoxStyle.Critical)

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtAddres.Clear()
        txtNam.Clear()
        txtReg.Clear()
    End Sub

    Private Sub txtNam_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNam.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please we need characters not numbers!!!", MsgBoxStyle.Critical)
            txtNam.Text = ""
        End If
    End Sub

    Private Sub txtSurname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSurname.KeyUp
        If Char.IsNumber(ChrW(e.KeyCode)) Then
            MsgBox("Please surname should contain characters not numbers", MsgBoxStyle.Critical)
            txtSurname.Text = ""
        End If
    End Sub
End Class