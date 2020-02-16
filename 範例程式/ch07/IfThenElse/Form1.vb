Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text < 60 Then
            Label2.Text = "您的評等是不及格!!"
        Else
            Label2.Text = "您的評等是及格!!"
        End If
    End Sub
End Class
