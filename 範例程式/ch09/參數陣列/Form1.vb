Public Class 參數陣列
    '功能：ByVal Parameter參數範例
    '建立一個名為Sub1的程序，其參數為參數陣列

    Sub Sub1(ByVal ParamArray s1() As Integer)
        Dim I As Integer
        Dim Sum As Integer = 0
        For I = 0 To s1.Length - 1
            Sum += s1(I) '求總和
        Next
        TextBox1.Text &= "呼叫Sub1程序之總和為：" & Sum.ToString & vbNewLine
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "呼叫Sub1程序，並傳入3個參數"
        Call Sub1(10, 20, 30)
        TextBox1.Text &= "呼叫Sub1程序，並傳入5個參數"
        Call Sub1(10, 20, 30, 40, 50)
    End Sub
End Class
