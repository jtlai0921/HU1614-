Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Structure pot
    Dim state As Boolean  '** 是否存活
    Dim x As Integer      '** 碎片目前X位置
    Dim y As Integer      '** 碎片目前Y位置
    Dim Vx As Integer     '** 碎片的水平速度
    Dim Vy As Integer     '** 碎片的垂直速度
    Dim px As Integer     '** 碎片的前一秒X位置（清除先前繪圖用）
    Dim py As Integer     '** 碎片的前一秒Y位置（清除先前繪圖用）
    Dim Mypen As Pen      '** 繪製碎片用的Pen物件，用於產生不同顏色
End Structure

Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents Timer1 As New Timer
    Private WithEvents Timer2 As New Timer
    Private WithEvents Timer3 As New Timer
    Private Const Max As Integer = 300  '** 定義碎片數目

    Private f1(Max), f2(Max), f3(Max) As pot '** 三個煙火
    Private T1, T2, T3 As Long   '** 煙火施放後的時間

    Private G As Graphics

    Sub New()
        InitializeComponent()
        Timer1.Interval = 300
        Timer1.Enabled = True
        Timer2.Interval = 250
        Timer2.Enabled = True
        Timer3.Interval = 280
        Timer3.Enabled = True
        '** 設定全螢幕
        Me.BackColor = Color.Black
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        G = Me.CreateGraphics
    End Sub

    '** 啟始所有碎片狀態                                                                                
    Sub StartParticles(ByRef p() As pot)
        Dim i, x_center, y_center As Integer
        Randomize()
        x_center = Rnd() * Me.Size.Height
        y_center = Rnd() * Me.Size.Height
        For i = 0 To Max - 1
            p(i).x = x_center
            p(i).y = y_center
            p(i).state = True
            p(i).Mypen = New Pen(Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255), 2)
            p(i).Vx = Rnd() * 40 - Rnd() * 40
            p(i).Vy = Rnd() * 40 - Rnd() * 40
        Next
    End Sub

    '** 檢查每個碎片狀態，判斷是否要重新施放煙火                                                                            
    Sub CheckState(ByRef p() As pot, ByRef time As Integer)
        Dim i As Integer
        Dim Play As Boolean
        For i = 0 To Max - 1
            '** 如果還有碎片存活，就離開迴圈
            If p(i).state = True Then
                Play = True
                Exit For
            End If
        Next
        If Not Play Then
            '** 設定時間為0，並重新初始碎片狀態
            time = 0
            StartParticles(p)
        Else
            time += 1
        End If
    End Sub

    '** 移動每個碎片                                                                            
    Sub ShowMove(ByRef p() As pot, ByRef time As Integer)
        Dim i As Integer
        For i = 0 To Max - 1
            If p(i).state Then
                '** 清除前一次繪圖
                G.DrawLine(New Pen(Color.Black, 2), New Point(p(i).px, p(i).py), New Point(p(i).px, p(i).py + 1))
                '** 繪製所有碎片
                G.DrawLine(p(i).Mypen, New Point(p(i).x, p(i).y), New Point(p(i).x, p(i).y + 1))
                '** 如果超出螢幕，表示碎片燃燒完畢
                If (p(i).x > Me.Size.Width Or p(i).x < 0 Or p(i).y > Me.Size.Height) Then
                    p(i).state = False
                End If
                '** 記錄目前碎片位置，作為清除繪圖用
                p(i).px = p(i).x
                p(i).py = p(i).y
                '** 水平移動與垂直移動
                p(i).x += p(i).Vx
                p(i).y += p(i).Vy
                '** 重力加速度
                p(i).Vy += 9 * time
            End If
        Next
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckState(f1, T1)
        ShowMove(f1, T1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        CheckState(f2, T2)
        ShowMove(f2, T2)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        CheckState(f3, T3)
        ShowMove(f3, T3)
    End Sub

    '** 按下按鍵就中止程式                                                                                
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        End
    End Sub
End Class