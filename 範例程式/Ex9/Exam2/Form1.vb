Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a1, S2 As Integer
        a1 = CInt(TextBox1.Text)
        S2 = Res_Sum(a1)
        Label2.Text = "總購買金額為：" & S2.ToString & "元"
    End Sub
    Private Function Res_Sum(ByVal Unit1 As Integer)
        Dim S1 As Integer = 0
        Select Case Unit1
            Case Is <= 10
                S1 = (560 * Unit1) * 0.95
            Case 11 To 30
                S1 = (560 * Unit1) * 0.8
            Case 31 To 50
                S1 = (560 * Unit1) * 0.7
            Case Is > 50
                S1 = (560 * Unit1) * 0.5
        End Select
        Return S1
    End Function
End Class
