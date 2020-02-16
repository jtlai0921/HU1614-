Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '實作1
        Dim Yearpon As Integer
        Dim Work_age As Single
        Work_age = TextBox1.Text
        Select Case Work_age
            Case Is < 1 '未滿一年
                Yearpon = 0
            Case 1 To 3 '滿1年未滿3年
                Yearpon = 1
            Case 3.1 To 6 '滿3年未滿6年
                Yearpon = 3
            Case Is > 6 '滿6年以上
                Yearpon = 5
        End Select
        TextBox2.Text = "此員工的年終獎金為：" & Yearpon & "個月"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
