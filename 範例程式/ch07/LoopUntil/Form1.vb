Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, s2 As String
        Dim yn_same As Boolean = True
        Dim i As Integer = 1
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        If Len(s1) = Len(s2) Then
            Do
                If (Mid(s1, i, 1) = Mid(s2, i, 1)) Then
                    i = i + 1
                Else
                    Label3.Text = "二個字串內容不一樣"
                    yn_same = False
                    Exit Do
                End If
            Loop Until Len(s1) < i
        Else
            MsgBox("請輸入長度一樣的字串")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
            yn_same = False
        End If
        If yn_same Then
            Label3.Text = "二個字串內容一樣"
        End If
    End Sub
End Class
