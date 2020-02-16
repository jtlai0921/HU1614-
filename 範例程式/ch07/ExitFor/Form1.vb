Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I, J As Integer
        For I = 1 To 100
            J = InputBox("請輸入一個值(當值為50時則中斷執行!)")
            If J = 50 Then
                Exit For
            End If
        Next
    End Sub
End Class
