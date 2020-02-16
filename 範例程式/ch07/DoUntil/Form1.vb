Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I, J, I_End As Integer
        Dim sing1 As String
        I = 1
        sing1 = ""
        RichTextBox1.Text = ""
        I_End = InputBox("請輸入層次數:")
        Do Until I > I_End
            For J = 1 To I
                sing1 = sing1 & "*"
            Next J
            sing1 = sing1 & Chr(13)
            I = I + 1
        Loop
        RichTextBox1.Text = sing1
    End Sub
End Class
