Public Class RadioButton
    '-------------------------------------------------------------------------------------------------
    ' 功能：RadioButton控制項範例
    '
    '-------------------------------------------------------------------------------------------------
    Public train, ticket As Integer
    Private Sub RadioButton1_CheckedChanged(sender As Object, e _
    As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            train = 1000   '票價為1000
        End If
        TextBox1.Text = "新台幣" & train * ticket & "元"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e _
    As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            train = 800    '票價為800
        End If
        TextBox1.Text = "新台幣" & train * ticket & "元"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e _
    As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ticket = 1     '票數為一張
        End If
        TextBox1.Text = "新台幣" & train * ticket & "元"
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e _
    As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ticket = 2     '票數為兩張
        End If
        TextBox1.Text = "新台幣" & train * ticket & "元"
    End Sub
End Class