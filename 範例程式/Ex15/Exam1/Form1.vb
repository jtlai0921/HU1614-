Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Math
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private G As Graphics
    Private objPen As New Pen(Color.Black, 2)
    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawHeart()
        Dim i, j As Integer
        Dim X, Y, R As Double
        For i = 0 To 90
            For j = 0 To 90
                R = PI / 45 * i * (1 - Sin(PI / 45 * j)) * 18
                X = R * Cos(PI / 45 * j) * Sin(PI / 45 * i) + Me.Size.Width / 2
                Y = -R * Sin(PI / 45 * j) + Me.Size.Height / 8
                G.DrawLine(objPen, New Point(X, Y), New Point(X + 1, Y + 1))
            Next
        Next
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawHeart()
    End Sub
End Class

