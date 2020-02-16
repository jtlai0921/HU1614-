Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Month1 As Integer
        Month1 = TextBox1.Text
        If Month1 >= 1 And Month1 <= 3 Then
            Label2.Text = "現在是第一季"
        ElseIf Month1 > 3 And Month1 <= 6 Then
            Label2.Text = "現在是第二季"
        ElseIf Month1 > 6 And Month1 <= 9 Then
            Label2.Text = "現在是第三季"
        Else
            Label2.Text = "現在是第四季"
        End If
    End Sub
End Class
