Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private im As Image
    Private myBrush As Drawing.TextureBrush
    Private G As Graphics

    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
        im = Image.FromFile("001.jpg")
        myBrush = New Drawing.TextureBrush(im, WrapMode.TileFlipXY)
    End Sub

    Private Sub DrawGraphic()
        G.FillRectangle(myBrush, 0, 0, Me.Size.Width, Me.Size.Height)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class