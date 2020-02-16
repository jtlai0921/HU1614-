Public Class FontDialog
    '-------------------------------------------------------------------------------------------------
    ' 功能：FontDialog控制項範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With FontDialog1
            .ShowDialog() '開啟字型對話方塊
            TextBox1.Font = .Font '以在字型對話方塊內所指定的字型來指定給TextBox1
            TextBox1.ForeColor = .Color '以在字型對話方塊內所指定的顏色來指定給TextBox1
        End With
    End Sub
End Class