Public Class StatusBar
    '-------------------------------------------------------------------------------------------------
    ' 功能：狀態列控制項範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub ToolBar1_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0  '粗體
                RichTextBox1.Font = New Font("新細明體", 12, FontStyle.Bold)
                StatusBar1.Text = "您已選擇粗體功能"
            Case 1 '斜體
                RichTextBox1.Font = New Font("新細明體", 12, FontStyle.Italic)
                StatusBar1.Text = "您已選擇斜體功能"
            Case 2 '底線
                RichTextBox1.Font = New Font("新細明體", 12, FontStyle.Underline)
                StatusBar1.Text = "您已選擇底線功能"
        End Select
    End Sub
End Class