Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a1, a2 As Integer
        a1 = CInt(TextBox1.Text)
        a2 = N_Sum(a1)
        Label2.Text = "其結果為：" & a2.ToString
    End Sub
    Private Function N_Sum(ByVal b1 As Integer)
        Dim I As Integer
        Dim N1 As Integer = 1
        For I = 1 To b1
            N1 = N1 * I
        Next
        Return N1
    End Function
End Class
