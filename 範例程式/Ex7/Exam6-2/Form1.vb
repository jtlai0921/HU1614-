Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '繪製正三角型
        Dim I, J, K, N As Integer
        N = 1
        For I = 16 To 1 Step -1  '第一層
            For J = 1 To I  '第二層
                '控制星號列印的位置
                If J = I Then
                    For K = 1 To N  '第三層
                        TextBox1.Text &= "*"
                    Next K
                Else
                    TextBox1.Text &= "  " '列印空白字元
                End If
            Next J
            N += 2 '設定左右位置每次增加二個字元
            TextBox1.Text &= vbNewLine '換行顯示
        Next I
    End Sub
End Class
