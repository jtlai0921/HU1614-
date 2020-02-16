Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I, J As Integer
        Dim sing1 As String
        sing1 = ""
        For I = 1 To 10
            For J = 1 To I
                sing1 = sing1 & "*"
            Next J
            sing1 = sing1 & Chr(13)
        Next I
        RichTextBox1.Text = sing1
    End Sub
End Class
