Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a1(3) As Integer
        a1(0) = CInt(TextBox1.Text)
        a1(1) = CInt(TextBox2.Text)
        a1(2) = CInt(TextBox3.Text)
        a1(3) = CInt(TextBox4.Text)
        Array.Sort(a1)
        Label5.Text = "最大值為：" & a1(3)
    End Sub
End Class
