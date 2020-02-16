Public Class CheckBox
    '-------------------------------------------------------------------------------------------------
    ' 功能：CheckBox控制項範例
    '
    '-------------------------------------------------------------------------------------------------
    Dim Sum1 As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '按下總計按鈕之後所觸發的事件程序
        Label3.Text = Sum1.ToString '顯示總金額
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Sum1 = Sum1 + 10 '點選綠茶時，將Sum1變數10
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Sum1 = Sum1 + 10 '點選紅茶時，將Sum1變數10
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Sum1 = Sum1 + 20 '點選檸檬紅茶時，將Sum1變數20
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Sum1 = Sum1 + 25 '點選奶茶時，將Sum1變數25
    End Sub
End Class