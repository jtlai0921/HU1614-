Public Class 例外處理
    '-------------------------------------------------------------------------------------------------
    ' 功能：Try...Catch...Finally範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 10
        Dim y As Integer = 0
        Try
            x /= y
        Catch ex As Exception When y = 0
            MsgBox(ex.ToString)
        Finally
            MsgBox("結束截取例外狀況的執行")
        End Try
    End Sub
End Class
