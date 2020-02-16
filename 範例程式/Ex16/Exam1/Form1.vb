Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a1, a2 As Integer

        a1 = Val(TextBox1.Text)
        Try
            a2 = Int(10 / a1)
            Label2.Text = a2.ToString
        Catch Exception As OverflowException
            Label2.Text = "除數為0"
        End Try
    End Sub
End Class
