Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, end1 As Integer
        Dim sum As Integer = 0
        end1 = TextBox1.Text
        For i = 1 To end1
            sum = sum + i
        Next
        Label2.Text = sum.ToString
    End Sub
End Class
