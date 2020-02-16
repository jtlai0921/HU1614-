Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Class Form1
    Inherits System.Windows.Forms.Form
    Private im As Image
    Private G As Graphics

    Sub New()
        InitializeComponent()
        Me.BackColor = Color.White
        G = Me.CreateGraphics
        im = Image.FromFile("003.jpg")
    End Sub

    Private Sub DrawGraphic()
        G.DrawImageUnscaled(im, 20, 20)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawGraphic()
    End Sub
End Class