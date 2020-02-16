Public Class 顯示座標
    '-------------------------------------------------------------------------------------------------
    ' 功能：MouseUp、MouseDown事件範例
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub 顯示座標_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub 顯示座標_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Label2.Text = Chr(12) & Chr(13) & "X：" & e.X.ToString & " Y:" & e.Y.ToString
    End Sub

    Private Sub 顯示座標_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Label2.Text = ""
        Select Case e.Button
            Case MouseButtons.Left
                Label2.Text = "您所按下的按鍵是左鍵" & Chr(10) & Chr(13)
            Case MouseButtons.Right
                Label2.Text = "您所按下的按鍵是右鍵" & Chr(10) & Chr(13)
            Case MouseButtons.Middle
                Label2.Text = "您所按下的按鍵是中鍵" & Chr(10) & Chr(13)
        End Select
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        Label2.Text = Chr(12) & Chr(13) & "X：" & e.X.ToString & " Y:" & e.Y.ToString
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        Label2.Text = ""
        Select Case e.Button
            Case MouseButtons.Left
                Label2.Text = "您所按下的按鍵是左鍵" & Chr(10) & Chr(13)
            Case MouseButtons.Right
                Label2.Text = "您所按下的按鍵是右鍵" & Chr(10) & Chr(13)
            Case MouseButtons.Middle
                Label2.Text = "您所按下的按鍵是中鍵" & Chr(10) & Chr(13)
        End Select
    End Sub
End Class