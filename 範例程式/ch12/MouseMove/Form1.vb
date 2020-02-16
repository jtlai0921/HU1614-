Public Class MouseMove
    '-------------------------------------------------------------------------------------------------
    ' 功能：MouseEnter、MouseMove以及MouseLeave事件範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.BackColor = Color.Ivory
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.DarkOliveGreen
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        Label1.Left = Label1.Left + e.X - (Label1.Width / 2)
        Label1.Top = Label1.Top + e.Y - (Label1.Top / 2)
    End Sub
End Class