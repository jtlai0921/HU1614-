Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '顯示三角型
        Dim I, J As Integer
        For I = 1 To 5 '第一層
            For J = 1 To I '第二層
                TextBox1.Text &= "*"
            Next J
            TextBox1.Text &= vbNewLine
        Next I
    End Sub
End Class
