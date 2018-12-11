Public Class User_Registration
    Private Sub User_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtCon.Text = "" Then
            MsgBox("Con Password is required", MsgBoxStyle.Critical)

        ElseIf txtPass.Text = "" Then
            MsgBox("Password is required", MsgBoxStyle.Critical)

        ElseIf txtFname.Text = "" Then
            MsgBox("Name is required", MsgBoxStyle.Critical)

        ElseIf txtSurname.Text = "" Then
            MsgBox("Surname is required", MsgBoxStyle.Critical)
        ElseIf txtUser.Text = "" Then
            MsgBox("Username is required", MsgBoxStyle.Critical)
        ElseIf cbUserType.Text = "" Then
            MsgBox("Select usertype required", MsgBoxStyle.Critical)
        Else
            If Not txtPass.Text = txtCon.Text Then
                MsgBox("Password do not Match")
            Else
                issucess = book_insert("INSERT INTO `user` (`name`, `surname`, `username`,`password`,`usertype`)   VALUES ('" & txtFname.Text & "','" & txtSurname.Text & "', '" & txtUser.Text & "', '" & txtPass.Text & "','" & cbUserType.Text & "' );")
                If issucess = True Then
                    MsgBox("New user has been added successfully!", MsgBoxStyle.Information)
                    BookList.Show()
                    Me.Hide()
                Else
                    MsgBox("No user added into the database!", MsgBoxStyle.Critical)

                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCon.Clear()
        txtFname.Clear()
        txtSurname.Clear()
        txtPass.Clear()
        txtUser.Clear()
        cbUserType.ResetText()

    End Sub
End Class