Public Class 執行時期錯誤
    '-------------------------------------------------------------------------------------------------
    ' 功能：測試執行時期的錯誤
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim a1(4) As Integer
        For i = 0 To 5
            a1(i) = 10 + i
        Next
        TextBox1.Text = i.ToString
    End Sub
End Class
