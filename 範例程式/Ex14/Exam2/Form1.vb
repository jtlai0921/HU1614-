Public Class Form1
    Private Sub MenuItem1_Click(sender As Object, e As EventArgs) Handles MenuItem1.Click
        RichTextBox1.ForeColor = Color.Green '選擇「綠色」項目時將前景顏色變更為綠色
        RichTextBox1.BackColor = Color.Yellow '選擇「黃色」項目時將背景顏色變更為黃色
    End Sub

    Private Sub MenuItem2_Click(sender As Object, e As EventArgs) Handles MenuItem2.Click
        RichTextBox1.ForeColor = Color.Black '選擇「黑色」項目時將前景顏色變更為黑色
        RichTextBox1.BackColor = Color.Red '選擇「紅色」項目時將背景顏色變更為紅色
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        RichTextBox1.ForeColor = Color.Yellow '選擇「黃色」項目時將前景顏色變更為黃色
        RichTextBox1.BackColor = Color.Blue '選擇「藍色」項目時將背景顏色變更為藍色
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles MenuItem4.Click
        RichTextBox1.ForeColor = Color.Red '選擇「紅色」項目時將前景顏色變更為紅色
        RichTextBox1.BackColor = Color.Green '選擇「綠色」項目時將背景顏色變更為綠色
    End Sub
End Class
