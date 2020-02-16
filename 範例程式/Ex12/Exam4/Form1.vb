Public Class Form1
    Private SizeX As Integer = 200
    Private SizeY As Integer = 100

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Dim i As Integer
        If e.Button = MouseButtons.Left Then
            For i = 1 To 100
                SizeX += 1
                SizeY += 1
                Me.Size = New Size(SizeX, SizeY)
            Next
        Else
            For i = 1 To 100
                SizeX -= 1
                SizeY -= 1
                Me.Size = New Size(SizeX, SizeY)
            Next
        End If
    End Sub
End Class
