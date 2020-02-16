Public Class 選擇性參數
    '功能：選擇性參數範例
    '建立一個名為Test的程序，其第二個參數為選擇性參數

    Sub Test(ByVal a1 As Integer, Optional ByVal a2 As Integer = 0)
        a1 += 10
        a2 += a1
        TextBox1.Text &= " a1= " & a1 & " a2= " & a2 & vbNewLine
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "呼叫Test程序，並省略第二個參數" & vbNewLine
        Call Test(30) '呼叫Test程序，並忽略第二個參數
        TextBox1.Text &= "呼叫Test程序，並傳入第二個參數" & vbNewLine
        Call Test(30, 100) '呼叫Test程序，並傳遞第二個參數
    End Sub
End Class
