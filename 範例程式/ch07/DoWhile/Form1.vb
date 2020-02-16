Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I, J, sum As Integer
        I = TextBox1.Text
        J = 1
        sum = 0
        Do While J <= I
            sum = sum + J
            J = J + 1
        Loop
        Label2.Text = sum.ToString
    End Sub
End Class
