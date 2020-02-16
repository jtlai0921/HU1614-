Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private im As Image
    Private myBrush As HatchBrush
    Private myFont As Font
    Private G As Graphics

    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawGraphic()
        myBrush = New HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Black, Color.Red)
        myFont = New Font("標楷體", 25, FontStyle.Bold)
        G.DrawString("Visual Basic", myFont, myBrush, New PointF(20, 10))
        myBrush = New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Black, Color.Blue)
        myFont = New Font("標楷體", 15, FontStyle.Strikeout)
        G.DrawString("Visual Basic.NET", myFont, myBrush, New PointF(10, 60))
        myBrush = New HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Black, Color.Green)
        myFont = New Font("標楷體", 20, FontStyle.Underline)
        G.DrawString(".NET Framework", myFont, myBrush, New PointF(30, 100))
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class