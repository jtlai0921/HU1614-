Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private myBrush As Drawing.SolidBrush
    Private G As Graphics
    Private p1, p2, p3 As Single

    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        p1 = 0.3
        p2 = 0.4
        p3 = 0.3
        myBrush = New Drawing.SolidBrush(Color.Red)
        G.FillPie(myBrush, 40, 30, 200, 200, 0, 360 * p1)
        myBrush = New Drawing.SolidBrush(Color.Blue)
        G.FillPie(myBrush, 40, 30, 200, 200, 360 * p1, 360 * p2)
        myBrush = New Drawing.SolidBrush(Color.Green)
        G.FillPie(myBrush, 40, 30, 200, 200, 360 * p1 + 360 * p2, 360 * p3)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class
