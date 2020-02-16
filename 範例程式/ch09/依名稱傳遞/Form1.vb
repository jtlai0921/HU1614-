Public Class 依名稱傳遞
    '功能：依順序或名稱來傳遞參數範例

    Sub Sub1(ByVal A1 As Integer, ByVal A2 As Integer, ByVal S1 As String, ByVal A3 As Integer)
        Dim Sum As Integer = 0
        Sum = A1 + A2 + A3
        TextBox1.Text &= "呼叫Sub1程序，其總和為：" & Sum.ToString & vbNewLine
        TextBox1.Text &= "呼叫Sub1程序，其字串為：" & S1 & vbNewLine
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "呼叫Sub1程序，並依順序傳遞參數"
        Call Sub1(10, 20, "Hello", 30)
        TextBox1.Text &= "呼叫Sub1程序，並依名稱來傳遞參數"
        Call Sub1(A3:=40, A2:=10, A1:=20, S1:="您好")
    End Sub
End Class
