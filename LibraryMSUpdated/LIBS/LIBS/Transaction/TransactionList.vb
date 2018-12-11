Imports System.Drawing.Printing
Imports System.Drawing.Bitmap
Public Class TransactionList
    Dim newpage As Boolean

    Private Sub transpicker_ValueChanged(sender As Object, e As EventArgs) Handles transpicker.ValueChanged
        bookfindthis("SELECT ID,bookID,isbn,studentID,issuedate,dateReturned,dateAdded FROM tbtransaction WHERE dateAdded = '" & transpicker.Text & "' Order by isbn ASC ")

        LoadData(GridTrans, "transaction")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With GridTrans
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)

            Dim text As String = ("Powered by: Cloudious Stephen")
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            e.Graphics.DrawString(text, New Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 350, 30)
            Dim y As Single = e.MarginBounds.Top
            Dim mRow As Integer = Nothing

            Do While mRow < GridTrans.RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)


                    If (newpage) Then
                        e.Graphics.DrawString(GridTrans.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(GridTrans.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next




                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 0
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ev.Graphics.DrawString(GridTrans.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, New Point(0, 0))

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Beep()
        End Try
    End Sub

    Private Sub TransactionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class