Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        num1 = CInt(TextBox1.Text)
        num2 = CInt(TextBox2.Text)
        test(num1, num2)
        Label3.Text = "數字1加10=" & num1 & " 數字2+加10=" & num2
    End Sub
    Sub test(ByRef a1 As Integer, ByRef a2 As Integer)
        a1 += 10
        a2 += 10
    End Sub
End Class
