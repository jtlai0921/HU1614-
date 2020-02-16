Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Math
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private G As Graphics
    Private im As Image
    Private sR As Rectangle
    Private dR As Rectangle
    Private WithEvents Timer1 As New Timer
    Sub New()
        InitializeComponent()
        Me.BackColor = Color.Black
        Me.Size = New Size(200, 200)
        sR = New Rectangle(0, 0, 128, 96)
        dR = New Rectangle(0, 0, Me.Size.Width, Me.Size.Height - 20)
        im = Image.FromFile("Cg0430.jpg")
        Timer1.Interval = 100
        Timer1.Enabled = True
        G = Me.CreateGraphics
    End Sub

    Private Sub DrawAni()
        G.DrawImage(im, dR, sR, GraphicsUnit.Pixel)
        sR.X += 128
        If sR.X = 640 Then
            sR.Y += 96
            sR.X = 0
            If sR.Y = 480 Then
                sR.Y = 0
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DrawAni()
    End Sub
End Class

