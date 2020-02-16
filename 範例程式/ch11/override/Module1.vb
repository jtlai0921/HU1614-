'範例：使用過載與重寫
'
Imports System

Public Class addtion '宣告一個addtion類別
    Public Overloads Sub add() '宣告一個名為add的過載函式，不接收參數
        Console.WriteLine("輸入錯誤")
    End Sub

    Public Overloads Sub add(ByVal x As Integer, ByVal y As Integer) '宣告一個名為add的過載函式，接收二個參數
        Console.WriteLine("加法運算結果=" & (x + y))
    End Sub

    Public Overloads Sub add(ByVal x As String, ByVal y As String) '宣告一個名為add的過載函式，接收二個參數
        Console.WriteLine("字串連結結果=" & (x + y))
    End Sub

    Overridable Sub add1(ByVal x As Integer, ByVal y As String) '宣告一個名為add的重寫函式，接收二個參數
        Console.WriteLine("轉成字串相加結果 " & CStr(x) + y)
    End Sub
End Class

Class add '宣告一個名為add的類別
    Inherits addtion '繼承自addtion類別

    Public Overrides Sub add1(ByVal x As Integer, ByVal y As String) '宣告一個名為add1的重寫函式，接收二個參數
        Console.WriteLine("轉成數字相加結果 " & (x + Len(y)))
    End Sub
End Class

Module Module1

    Sub Main()
        Dim ad As New addtion '宣告一個名為ad的衍生addtion類別
        Dim ad1 As New add '宣告一個名為ad1的衍生add類別
        Dim s1 As String = "我愛妳", s2 As String = "VERY MARCH", rd As String

        Console.WriteLine("您想進行什麼操作(1)數字加法(2)字串連結")
        Console.WriteLine("                (3)數字轉字串相加(4)數字與字串長度相加")
        rd = Console.ReadLine() '取得所輸入的值

        Select Case CInt(rd)
            Case 1 '執行數字加法
                ad.add(3, 5)
            Case 2 '執行字串連結
                ad.add(s1, s2)
            Case 3 '執行數字轉字串相加
                ad.add1(3, s1)
            Case 4 '執行數字與字串長度相加
                ad1.add1(3, s1)
            Case Else '輸入錯誤
                ad.add()
        End Select
        Console.ReadLine()
    End Sub
End Module