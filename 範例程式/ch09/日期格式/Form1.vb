Public Class 日期格式
    '功能：日期/時間格式範例

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1 As DateTime
        d1 = DateTime.Now
        RichTextBox1.Text = "一般日期: " & d1.ToString("g") & vbNewLine
        RichTextBox1.Text &= "完整日期: " & d1.ToString("D") & vbNewLine
        RichTextBox1.Text &= "簡短日期: " & d1.ToString("d") & vbNewLine
        RichTextBox1.Text &= "完整時間: " & d1.ToString("T") & vbNewLine
        RichTextBox1.Text &= "簡短時間: " & d1.ToString("t") & vbNewLine
        RichTextBox1.Text &= "日期時間1: " & d1.ToString("f") & vbNewLine
        RichTextBox1.Text &= "日期時間2: " & d1.ToString("F") & vbNewLine
    End Sub
End Class
