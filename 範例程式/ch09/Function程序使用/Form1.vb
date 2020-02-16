Public Class Function程序使用
    '功能：Function使用範例

    Function Add1() '建立一個名為Add1的函數
        Dim sum1 As Integer = 0
        Dim i As Integer
        For i = 1 To 100
            sum1 = sum1 + i '求1~100的總和
        Next
        Return sum1 '以關鍵字Return將值傳回的方式
    End Function
    Function Add2() '建立一個名為Add2的函數
        Dim sum2 As Integer
        Dim i As Integer
        For i = 1 To 10
            sum2 = sum2 + i '求1~10的總和
        Next
        Add2 = sum2  '直接以函式名稱來傳回值的方式
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Add1() '傳回1~100的總和
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = Add2() '傳回1~10的總和
    End Sub
End Class
