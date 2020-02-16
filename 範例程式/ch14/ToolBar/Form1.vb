Public Class ToolBar
    '-------------------------------------------------------------------------------------------------
    ' 功能：工具列控制項範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub ToolBar1_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0  '粗體
                RichTextBox1.Font = New Font("新細明體", 12, FontStyle.Bold)
            Case 1 '斜體
                RichTextBox1.Font = New Font("新細明體", 12, FontStyle.Italic)
            Case 2 '底線
                RichTextBox1.Font = New Font("新細明體", 12, FontStyle.Underline)
        End Select
    End Sub
End Class