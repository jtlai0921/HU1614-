Public Class Form1
    Dim a1 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a1 = CInt(TextBox1.Text)
        square()
    End Sub
    Sub square()
        Label2.Text = "其結果為：" & a1 & "*" & a1 & "=" & a1 * a1
    End Sub
End Class
