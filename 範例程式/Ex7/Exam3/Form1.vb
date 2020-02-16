Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N1, Sum, J As Integer
        Sum = 1
        N1 = CInt(TextBox1.Text) '取得階層數
        For J = 1 To N1
            Sum = Sum * J
        Next
        Label2.Text = N1 & "階層的結果為：" & Sum.ToString
    End Sub
End Class
