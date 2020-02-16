Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I, N, Sum, Sum1 As Integer
        Sum = 0
        Sum1 = 0
        N = TextBox1.Text
        '求總和
        For I = 1 To N
            Sum = Sum + I
        Next
        '求偶數和
        I = 0
        Do
            Sum1 = Sum1 + I
            I += 2
        Loop While I <= N
        Label2.Text = "總和為：" & Sum & vbNewLine
        Label2.Text &= "偶數和為：" & Sum1
    End Sub
End Class
