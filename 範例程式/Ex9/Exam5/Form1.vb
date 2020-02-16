Public Class Form1
    Dim a1 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        a1 = CInt(TextBox1.Text)
        result = square()
        Label2.Text = "其結果為：" & a1 & "*" & a1 & "=" & result
    End Sub
    Function square() As Integer
        Return a1 * a1
    End Function
End Class
