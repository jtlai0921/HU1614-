Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private myPen As New Pen(Color.Black, 1)
    Private G As Graphics
    Private x_center, y_center, hwidth, hheight As Integer

    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        Dim i As Integer
        x_center = 60
        y_center = 80
        hwidth = 50
        hheight = 40
        For i = 0 To 29
            G.DrawArc(myPen, x_center - hwidth, y_center - hheight, 2 * hwidth, 2 * hheight, 0, -180)
            x_center += 4
            y_center += 4
            hwidth += 2
            hheight += 2
        Next
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class