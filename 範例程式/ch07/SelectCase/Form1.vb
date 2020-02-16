Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Month1 As Integer
        Month1 = TextBox1.Text
        Select Month1
            Case 1, 2, 3
                Label2.Text = "現在是第一季"
            Case 4 To 6
                Label2.Text = "現在是第二季"
            Case 7
                Label2.Text = "現在是第三季"
            Case 8, 9
                Label2.Text = "現在是第三季"
            Case 10 To 12
                Label2.Text = "現在是第四季"
            Case Is > 12
                Label2.Text = "一年只有12個月!!"
        End Select
    End Sub
End Class
