Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, sum As Integer
        Do While i < 10
            i = i + 1
            If i Mod 2 = 0 Then
                Continue Do
            End If
            sum = sum + i
        Loop
        TextBox1.Text = sum
    End Sub
End Class
