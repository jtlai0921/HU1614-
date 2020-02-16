Public Class 資料型別判斷
    '功能：資料型別判斷函數範例

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2 As Boolean
        t1 = False
        t2 = False
        If IsDate(TextBox1.Text) Then '判斷輸入的資料型別是否為日期資料型別
            Label1.Text = "為日期資料型別"
            t1 = True
        End If
        If IsNumeric(TextBox1.Text) Then  '判斷輸入的資料型別是否為數字資料型別
            Label1.Text = "為數字資料型別"
            t2 = True
        End If
        If (t1 = False And t2 = False) Then
            Label1.Text = "既不是日期也不是數字資料型別"
        End If
    End Sub
End Class
