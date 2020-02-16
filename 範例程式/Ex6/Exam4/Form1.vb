Public Class Form1
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MsgResult As Integer
        MsgResult = MessageBox.Show("您是否常使用中文輸入法呢?", "詢問", _
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, _
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        If DialogResult.Yes = MsgResult Then '按下「是」按鈕
            TextBox1.Text = "建議您多使用倉頡"
        ElseIf DialogResult.No = MsgResult Then '按下「否」按鈕
            TextBox1.Text = "可以從注音輸入法開始學起"
        ElseIf DialogResult.Cancel = MsgResult Then '按下「取消」按鈕
            TextBox1.Text = "您按了取消鍵"
        End If
    End Sub
End Class