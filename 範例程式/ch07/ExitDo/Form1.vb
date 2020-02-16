Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a1, a2 As Integer
        a2 = 100
        Do While True
            a1 = InputBox("請輸入一個數值:")
            If (a1 = a2) Then
                Exit Do
            End If
        Loop
        End
    End Sub
End Class
