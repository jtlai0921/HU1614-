Public Class 跳出程序
    '功能：Exit Sub/Function使用範例

    Sub Add1() '建立一個名為Add1的程序
        Dim I As Integer
        For I = 1 To 10
            TextBox1.Text &= "目前的I值為：" & I & vbNewLine
            If I = 6 Then '假如I=6時則跳出迴圈
                Exit Sub '跳出迴圈
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Add1() '呼叫Add1程序
        TextBox1.Text &= "已執行結束" & vbNewLine
    End Sub
End Class
