Public Class Form1
    '-------------------------------------------------------------------------------------------------
    ' 功能：MsgBox控制項範例
    ' 
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MsgResult As Integer
        MsgResult = MessageBox.Show("您是否常使用Visual Basic呢?", "詢問", _
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, _
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        If DialogResult.Yes = MsgResult Then '按下「是」按鈕
            TextBox1.Text = "感謝您的愛用"
        ElseIf DialogResult.No = MsgResult Then '按下「否」按鈕
            TextBox1.Text = "多使用會發現它的好處唷"
        ElseIf DialogResult.Cancel = MsgResult Then '按下「取消」按鈕
            TextBox1.Text = "您按了取消鍵"
        End If
    End Sub
End Class
