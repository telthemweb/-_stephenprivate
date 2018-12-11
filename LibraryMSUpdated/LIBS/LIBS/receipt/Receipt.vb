Imports System.Drawing.Printing
Public Class Receipt
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(rtReceipt.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, New Point(0, 0))

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Beep()
        End Try
    End Sub

    Private Sub printTxt_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim printDoc As New PrintDocument
            AddHandler printDoc.PrintPage, AddressOf Me.PrintText
            printDoc.Print()
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Beep()
        End Try
    End Sub
    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ev.Graphics.DrawString(rtReceipt.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, New Point(0, 0))

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Beep()
        End Try
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class