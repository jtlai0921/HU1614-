Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim StrMsg As String
        StrMsg = ""
        '**判斷第一題的答題情況
        If RadioButton1.Checked Then
            i += 1
        Else
            StrMsg += "第一題答錯！" & vbNewLine
        End If

        '**判斷第二題的答題情況
        If RadioButton4.Checked Then
            i += 1
        Else
            StrMsg += "第二題答錯！" & vbNewLine
        End If

        If i = 2 Then StrMsg = "恭喜您全部答對！"
        MessageBox.Show(StrMsg, "測驗結果")
    End Sub
End Class
