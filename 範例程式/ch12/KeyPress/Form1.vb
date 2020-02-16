Public Class KeyPress
    '-------------------------------------------------------------------------------------------------
    ' 功能：KeyPress事件範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim ch1 As Integer
        ch1 = Asc(UCase(e.KeyChar))
        If ch1 < 65 Or ch1 > 90 Then '判斷是否輸入字元為A~Z
            MsgBox("必須要輸入A~Z")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim ch1 As Integer
        ch1 = Asc(e.KeyChar)
        If ch1 < 48 Or ch1 > 57 Then  '判斷是否輸入字元為0~9
            MsgBox("必須要輸入0~9")
            e.Handled = True
        End If
    End Sub
End Class