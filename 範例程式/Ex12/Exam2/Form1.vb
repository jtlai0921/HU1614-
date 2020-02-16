Public Class Form1
    Private Sub ch10_11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim key1 As Integer
        key1 = Asc(e.KeyChar)
        If key1 = 71 Then 'G
            Label1.BackColor = Color.Green
            Label2.BackColor = Color.White
            Label3.BackColor = Color.White
        End If
        If key1 = 89 Then 'Y
            Label2.BackColor = Color.Yellow
            Label1.BackColor = Color.White
            Label3.BackColor = Color.White
        End If
        If key1 = 82 Then
            Label3.BackColor = Color.Red
            Label1.BackColor = Color.White
            Label2.BackColor = Color.White
        End If
    End Sub
End Class
