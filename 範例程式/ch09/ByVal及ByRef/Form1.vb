Public Class ByVal及ByRef
    '功能：ByVal/ByRef使用範例

    Sub Sub1(ByVal A1 As Integer) '建立一個名為Sub1的傳值程序，
        A1 += 10
        TextBox1.Text &= "在Sub1傳值程序中，A1為:" & A1 & vbNewLine
    End Sub
    Sub sub2(ByRef A2 As Integer) '建立一個名為sub2的傳址程序，
        A2 += 10 '
        TextBox2.Text &= "在Sub2傳址程序中，A2為:" & A2 & vbNewLine
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A1 As Integer
        A1 = 1
        TextBox1.Text &= "在呼叫Sub1傳值程序之前，A1為:" & A1 & vbNewLine
        Call Sub1(A1) '呼叫Sub1程序
        A1 += 1
        TextBox1.Text &= "呼叫後的A1:" & A1 & vbNewLine
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A2 As Integer
        A2 = 20
        TextBox2.Text &= "在呼叫Sub2傳址程序之前，A2為:" & A2 & vbNewLine
        Call sub2(A2) '呼叫sub2程序
        A2 += 1
        TextBox2.Text &= "呼叫後的A2:" & A2 & vbNewLine
    End Sub
End Class
