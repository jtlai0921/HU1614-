Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '列印9*9乘法表
        Dim I, J As Integer
        For I = 1 To 9 Step 3
            For J = 1 To 10
                If J = 10 Then
                    TextBox1.Text &= " "
                    Exit For
                End If
                TextBox1.Text &= I & " " & "x" & " " & J & "=" & I * J & "    " & _
                                 I + 1 & " " & "x" & " " & J & "=" & (I + 1) * J & "    " & _
                                 I + 2 & " " & "x" & " " & J & "=" & (I + 2) * J & "    " & vbNewLine
            Next
            TextBox1.Text &= vbNewLine
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class