Public Class Form1
    Private SizeX As Integer = 200
    Private SizeY As Integer = 100
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 100
            SizeX += 1
            SizeY += 1
            Me.Size = New Size(SizeX, SizeY)
        Next
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = 1 To 100
            SizeX -= 1
            SizeY -= 1
            Me.Size = New Size(SizeX, SizeY)
        Next
    End Sub
End Class
