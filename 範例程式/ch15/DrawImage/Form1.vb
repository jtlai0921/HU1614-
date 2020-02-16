Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private im As Image
    Private myBrush As TextureBrush
    Private sR, dR As Rectangle
    Private G As Graphics

    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
        im = Image.FromFile("002.jpg")
        sR = New Rectangle(400, 80, 400, 400)
        dR = New Rectangle(0, 0, Me.Size.Width, Me.Size.Height)
    End Sub

    Private Sub DrawGraphic()
        G.DrawImage(im, dR, sR, GraphicsUnit.pixel)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class