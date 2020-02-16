Public Class 鍵盤事件
    '-------------------------------------------------------------------------------------------------
    ' 功能：鍵盤事件範例
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub 鍵盤事件_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Label2.Text = "KeyDown"
    End Sub

    Private Sub 鍵盤事件_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Label2.Text = "KeyPress"
    End Sub

    Private Sub 鍵盤事件_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Label2.Text = "KeyUp"
    End Sub

End Class