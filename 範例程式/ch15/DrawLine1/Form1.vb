Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private myPen As New Pen(Color.Black, 1)
    Private G As Graphics
    Private x_center, y_center, radius As Integer
    Private x(9), y(9) As Integer
    Sub New()
        InitializeComponent()
        x_center = Me.Size.Width / 2
        y_center = Me.Size.Height / 2 - 20
        radius = 100
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        Dim i, j As Integer
        For i = 0 To 9
            x(i) = x_center + radius * Math.Sin(36 * i * Math.PI / 180)
            y(i) = y_center + radius * Math.Cos(36 * i * Math.PI / 180)
        Next
        For i = 0 To 9
            For j = 0 To 9
                G.DrawLine(myPen, x(i), y(i), x(j), y(j))
            Next
        Next
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class
