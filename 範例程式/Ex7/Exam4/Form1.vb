Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num1 As Integer
        Dim Str1 As String
        Num1 = CInt(TextBox1.Text)
        Str1 = ""
        Select Case Num1
            Case 1
                Str1 = "壹"
            Case 2
                Str1 = "貳"
            Case 3
                Str1 = "參"
            Case 4
                Str1 = "肆"
            Case 5
                Str1 = "伍"
            Case 6
                Str1 = "陸"
            Case 7
                Str1 = "柒"
            Case 8
                Str1 = "捌"
            Case 9
                Str1 = "玖"
            Case 0
                Str1 = "零"
        End Select
        Label2.Text = Num1 & "相對應的國字為：" & Str1
    End Sub
End Class
