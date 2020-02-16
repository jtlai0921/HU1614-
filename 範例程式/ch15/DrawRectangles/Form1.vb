Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private myPen As New Pen(Color.Black, 1)
    Private G As Graphics
    Private x_center, y_center, hwidth As Integer
    Private R(24) As Rectangle
    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        Dim i As Integer
        x_center = 150
        y_center = 60
        hwidth = 50
        For i = 0 To 24
            R(i) = New Rectangle(x_center - hwidth, y_center - hwidth, 2 * hwidth, 2 * hwidth)
            y_center += 4
            hwidth += 2
        Next
        G.DrawRectangles(myPen, R)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class