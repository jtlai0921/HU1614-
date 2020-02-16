Public Class Click滑鼠事件
    '-------------------------------------------------------------------------------------------------
    ' 功能：Click、DbClick事件範例
    '
    '-------------------------------------------------------------------------------------------------
    Dim i As Integer = 0
    Dim color1(4) As System.Drawing.Color

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.Text = i.ToString
        i += 1
        If i > 4 Then
            i = 0
        End If
    End Sub

    Private Sub Label2_DoubleClick(sender As Object, e As EventArgs) Handles Label2.DoubleClick
        Label2.Text = ""
        Label2.BackColor = color1(i)
    End Sub

    Private Sub Click滑鼠事件_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        color1(0) = Color.Brown
        color1(1) = Color.Azure
        color1(2) = Color.Chartreuse
        color1(3) = Color.Cyan
        color1(4) = Color.Gainsboro
    End Sub
End Class