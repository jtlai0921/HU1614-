Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim S1, S2, M1, M2, D As Double
        Dim v1, v2, v3, v4, v5, v6 As Integer
        v1 = TextBox1.Text
        v2 = TextBox2.Text
        v3 = TextBox3.Text
        v4 = TextBox4.Text
        v5 = TextBox5.Text
        v6 = TextBox6.Text
        S1 = v1 + v2 + v3 + v4 + v5 + v6
        S2 = v1 ^ 2 + v2 ^ 2 + v3 ^ 2 + v4 ^ 2 + v5 ^ 2 + v6 ^ 2
        M1 = S1 / 6 '平均值
        TextBox7.Text = M1
        M2 = S2 / 6
        D = (M2 - M1 * M1) ^ 0.5 '標準差
        TextBox8.Text = D
    End Sub
End Class
