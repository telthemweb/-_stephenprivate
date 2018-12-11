Imports System.Data.OleDb
Module sqlstatements
    Public Sub bookfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub LoadSingleResult(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param

                Case "login"
                    Do While dReader.Read = True

                        ACCOUNT_NAME = dReader("name") & " " & dReader("surname")
                        ACCOUNT_USERNAME = dReader("username")
                        ACCOUNT_TYPE = dReader("usertype")



                        If ACCOUNT_TYPE = "Administrator" Then
                            MainPage.Show()
                            MainPage.btnLogout.Text = ACCOUNT_NAME
                            MainPage.lblAvtar.Text = ACCOUNT_TYPE
                            Login.Hide()

                        ElseIf ACCOUNT_TYPE = "Librarian" Then
                            MainPage.Show()
                            MainPage.btnLogout.Text = ACCOUNT_NAME
                            MainPage.lblAvtar.Text = ACCOUNT_TYPE
                            MainPage.UsersT.Visible = False
                            Login.Hide()

                        Else
                            MsgBox("Please contact the IT Department for Account Activation", MsgBoxStyle.Exclamation)
                        End If
                    Loop



            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub


End Module
