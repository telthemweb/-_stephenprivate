Public Class finelist
    Private Sub finelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookfindthis("SELECT `ID`, `receipt`,`studentID`, `totalPaid`, `isbn`,`numDays`,`amtperday`,`changeleft`,`datePayed` FROM `penalty`")
        LoadData(finList, "fine")

        Dim totalAmmount = GetGrossTotal()
        lblTotal.Text = totalAmmount


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bookfindthis("SELECT * FROM `students` WHERE `studentID`='" & txtSearch.Text & "' Or `receipt`='" & txtSearch.Text & "' Or `isbn`='" & txtSearch.Text & "'")
        LoadData(finList, "fine")
    End Sub
End Class