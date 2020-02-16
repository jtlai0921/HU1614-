Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private myBrush As Drawing2D.HatchBrush
    Private G As Graphics
    Private p1, p2, p3 As Single
    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        p1 = 180
        p2 = 125
        p3 = 160
        myBrush = New Drawing2D.HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.White, Color.Red)
        G.FillRectangle(myBrush, 70, 250 - p1, 30, p1)
        myBrush = New Drawing2D.HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.White, Color.Blue)
        G.FillRectangle(myBrush, 120, 250 - p2, 30, p2)
        myBrush = New Drawing2D.HatchBrush(HatchStyle.DiagonalCross, Color.White, Color.Green)
        G.FillRectangle(myBrush, 170, 250 - p3, 30, p3)
        G.DrawLine(New Pen(Color.Black, 2), New Point(10, 250), New Point(280, 250))
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class