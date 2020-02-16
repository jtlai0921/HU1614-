Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim S, StrLen As Integer
        Dim I As Integer = 1
        Dim StrRes As String
        StrRes = ""
        StrLen = Len(TextBox1.Text)
        While (I <= StrLen)
            S = Asc(Mid(TextBox1.Text, I, 1))
            Select Case S
                Case 65 To 90 '大寫
                    StrRes = StrRes & LCase(Mid(TextBox1.Text, I, 1))
                Case 97 To 122 '小寫
                    StrRes = StrRes & UCase(Mid(TextBox1.Text, I, 1))
            End Select
            I = I + 1
        End While
        TextBox2.Text = StrRes
    End Sub
End Class
