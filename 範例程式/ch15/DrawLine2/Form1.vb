Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private myPen As New Pen(Color.Black, 1)
    Private G As Graphics
    Private x_center, y_center, radius As Integer
    Private x, y As Integer
    Private p(99) As Point
    Sub New()
        InitializeComponent()
        x_center = Me.Size.Width / 2
        y_center = Me.Size.Height / 2 - 20
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        radius = 100
        Dim i As Integer
        For i = 0 To 99
            x = x_center + radius * Math.Sin(36 * i * Math.PI / 180)
            y = y_center + radius * Math.Cos(36 * i * Math.PI / 180)
            p(i) = New Point(x, y)
            radius -= 1
        Next
        G.DrawLines(myPen, p)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class