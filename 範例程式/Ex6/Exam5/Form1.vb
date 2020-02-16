Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, s, Ans As Single
        a = Val(TextBox1.Text) : b = Val(TextBox2.Text) : c = Val(TextBox3.Text)
        s = (a + b + c) / 2
        Ans = Math.Sqrt(s * (s - a) * (s - b) * (s - c))
        TextBox4.Text = Ans & "平方公分"
    End Sub
End Class
