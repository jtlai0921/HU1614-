Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private R As Rectangle
    Private myBrush As Drawing2D.LinearGradientBrush
    Private G As Graphics

    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        R = New Rectangle(20, 50, 80, 80)
        myBrush = New Drawing2D.LinearGradientBrush(R, Color.Green, Color.Yellow, -45)
        G.FillPie(myBrush, R, 30, 300)
        R = New Rectangle(120, 70, 50, 50)
        myBrush = New Drawing2D.LinearGradientBrush(R, Color.Green, Color.Yellow, -45)
        G.FillPie(myBrush, R, 30, 300)
        R = New Rectangle(190, 85, 30, 30)
        myBrush = New Drawing2D.LinearGradientBrush(R, Color.Green, Color.Yellow, -45)
        G.FillPie(myBrush, R, 30, 300)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class