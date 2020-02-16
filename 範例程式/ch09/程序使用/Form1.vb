Public Class 程序使用
    '功能：程序使用範例

    Sub ChangeForeColor()
        Label1.ForeColor = Color.Blue '將前景顏色設定為藍色
    End Sub
    Sub ChangeBackColor()
        Label1.BackColor = Color.Yellow '將背景顏色設定為黃色
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ChangeForeColor() '使用Call指令
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ChangeBackColor()  '直接呼叫
    End Sub
End Class
