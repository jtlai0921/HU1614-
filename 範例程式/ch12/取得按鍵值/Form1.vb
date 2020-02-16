Public Class 取得按鍵值
    '-------------------------------------------------------------------------------------------------
    ' 功能：取得鍵盤值範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub 取得按鍵值_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                Label2.Text = "←"
            Case Keys.Right
                Label2.Text = "→"
            Case Keys.Up
                Label2.Text = "↑"
            Case Keys.Down
                Label2.Text = "↓"
            Case Keys.ControlKey
                Label2.Text = "Control鍵"
            Case Keys.Tab
                Label2.Text = "Tab鍵"
            Case Keys.D0 To Keys.D9
                Label2.Text = "數字鍵"
            Case Keys.CapsLock
                Label2.Text = "Caps Lock鍵"
            Case Keys.ShiftKey
                Label2.Text = "Shift鍵"
            Case Keys.F1 To Keys.F12
                Label2.Text = "F1~F12鍵"
            Case Keys.A To Keys.Z
                Label2.Text = "A~Z鍵"
            Case Keys.Enter
                Label2.Text = "Enter鍵"
            Case Keys.NumLock
                Label2.Text = "Num Lock鍵"
            Case Keys.Escape
                Label2.Text = "Escape鍵"
            Case Keys.PageDown
                Label2.Text = "PageDown鍵"
            Case Keys.PageUp
                Label2.Text = "PageUp鍵"
        End Select
    End Sub
End Class