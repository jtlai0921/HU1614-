Public Class Timer
    '-------------------------------------------------------------------------------------------------
    ' 功能：Timer控制項範例
    '
    '-------------------------------------------------------------------------------------------------
    Dim min As Integer = 0 : Dim sec As Integer
    Dim a As Integer = 0 : Dim b As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As  _
    EventArgs) Handles Timer1.Tick
        Timer1.Interval = 10
        b += 1
        If b = 10 Then
            b = 0
            a += 1
            If a = 10 Then
                a = 0
                sec += 1
                TrackBar1.Value += 1
                If TrackBar1.Value = 60 Then
                    TrackBar1.Value = 0
                    If sec = 60 Then
                        sec = 0
                        min += 1
                    End If
                End If
            End If
        End If
        TextBox1.Text = min & "分" & sec & "秒" & a & b
    End Sub
    Private Sub Button1_Click(sender As Object, e As  _
    EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As  _
    EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As  _
    EventArgs) Handles Button3.Click
        min = 0 : sec = 0 : a = 0 : b = 0 : TrackBar1.Value = 0
        TextBox1.Text = min & "分" & sec & "秒" & a & b
    End Sub
End Class