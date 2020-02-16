Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Structure pot
    Dim pX, pY As Integer  '** 頂點的X,Y位置
    Dim dX, dY As Integer  '** 頂點的X方向,Y方向移動速度
End Structure

Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents Timer1 As New Timer '** Timer1與Timer2分別控制二個多邊形
    Private WithEvents Timer2 As New Timer
    Private WithEvents Timer3 As New Timer '** 定時清除螢幕

    Private G As Graphics
    Private objPen1 As New Pen(Color.White, 1)
    Private objPen2 As New Pen(Color.Red, 1)
    Private objPen3 As New Pen(Color.Yellow, 1)
    Private redPot(3) As pot
    Private whitePot(3) As pot

    Sub New()
        InitializeComponent()
        Timer1.Interval = 80
        Timer1.Enabled = True
        Timer2.Interval = 80
        Timer2.Enabled = True
        Timer3.Interval = 10000
        Timer3.Enabled = True
        Dim i As Integer
        '** 初始多邊形頂點位置與X、Y速度分量
        Randomize()
        For i = 0 To redPot.Length - 1
            redPot(i).pX = Rnd() * Me.Size.Height / 2
            redPot(i).pY = Rnd() * Me.Size.Width / 2
            redPot(i).dX = Rnd() * 20 - 10
            redPot(i).dY = Rnd() * 20 - 10
        Next
        For i = 0 To whitePot.Length - 1
            whitePot(i).pX = Rnd() * Me.Size.Height / 2
            whitePot(i).pY = Rnd() * Me.Size.Width / 2
            whitePot(i).dX = Rnd() * 20 - 10
            whitePot(i).dY = Rnd() * 20 - 10
        Next
        Me.BackColor = Color.Black
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        G = Me.CreateGraphics
    End Sub

    '** 檢查是否碰撞至邊界
    Private Sub Check_edge(ByRef Pots() As pot)
        Dim i As Integer
        For i = 0 To Pots.Length - 1
            If (Pots(i).pX < 10 Or Pots(i).pX > Me.Size.Width - 10) Then
                Pots(i).dX = (-Pots(i).dX)
            End If
            If (Pots(i).pY < 10 Or Pots(i).pY > Me.Size.Height - 40) Then
                Pots(i).dY = (-Pots(i).dY)
            End If
        Next
    End Sub

    '** 連接頂點繪製多邊形
    Private Sub ShowLine(ByRef Pots() As pot, ByRef objpen As Pen)
        Dim P() As Point = {New Point(Pots(0).pX, Pots(0).pY), _
                          New Point(Pots(1).pX, Pots(1).pY), _
                          New Point(Pots(2).pX, Pots(2).pY), _
                          New Point(Pots(3).pX, Pots(3).pY)}
        G.DrawPolygon(objPen, P)
    End Sub

    '** 移動多邊形頂點
    Private Sub MovePot(ByRef Pots() As pot)
        Dim i As Integer
        For i = 0 To Pots.Length - 1
            Pots(i).pX += Pots(i).dX
            Pots(i).pY += Pots(i).dY
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Check_edge(redPot)
        MovePot(redPot)
        ShowLine(redPot, objPen1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Check_edge(whitePot)
        MovePot(whitePot)
        ShowLine(whitePot, objPen2)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        G.Clear(Color.Black)
    End Sub
End Class