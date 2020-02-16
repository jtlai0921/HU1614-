Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        Dim length, width As Integer
        length = CInt(TextBox1.Text)
        width = CInt(TextBox2.Text)
        result = Area(length, width)
        Label3.Text = "長方形面積= " & result
    End Sub
    Function Area(ByVal intL As Integer, ByVal intW As Integer)
        Return intL * intW
    End Function
End Class
