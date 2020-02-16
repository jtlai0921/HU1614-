Public Class 數字格式化
    '功能：數字格式化範例

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var1 As Integer = "12345678"
        RichTextBox1.Text = "一般格式: " & var1.ToString("g") & vbNewLine
        RichTextBox1.Text &= "貨幣格式: " & var1.ToString("C") & vbNewLine
        RichTextBox1.Text &= "固定格式: " & var1.ToString("F") & vbNewLine
        RichTextBox1.Text &= "標準格式: " & var1.ToString("N") & vbNewLine
        RichTextBox1.Text &= "百分比格式: " & var1.ToString("p") & vbNewLine
        RichTextBox1.Text &= "10進位格式: " & var1.ToString("d") & vbNewLine
        RichTextBox1.Text &= "16進位格式: " & var1.ToString("X") & vbNewLine
    End Sub
End Class
