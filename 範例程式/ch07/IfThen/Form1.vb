Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text > 10 Then
            Label2.Text = "您所輸入的值大於10"
        End If
        If TextBox1.Text <= 10 Then
            Label2.Text = "您所輸入的值小於或等於10"
        End If
    End Sub
End Class
