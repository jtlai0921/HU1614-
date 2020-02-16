'範例：使用過載
'
Imports System

Public Class addtion '定義addtion類別
    Public Overloads Sub add() '宣告一個過載的add函式，但不接收參數
        Console.WriteLine("輸入錯誤")
    End Sub

    Public Overloads Sub add(ByVal x As Integer, ByRef y As Integer) '宣告一個過載的add函式，且接收二個參數
        Console.WriteLine("加法運算結果=" & (x + y))
    End Sub

    Public Overloads Sub add(ByVal x As String, ByRef y As String) '宣告一個過載的add函式，且接收二個參數
        Console.WriteLine("字串連結結果=" & (x + y))
    End Sub

End Class


Module Module1

    Sub Main()
        Dim ad As New addtion '定義ad為addtion類別
        Dim s1 As String = "生日快樂", s2 As String = "我的好友", rd As String

        Console.WriteLine("您想進行什麼操作(1)數字加法(2)字串連結")
        rd = Console.ReadLine() '取得所輸入的值

        Select Case CInt(rd)
            Case 1 '執行數字加法
                ad.add(3, 5)
            Case 2 '執行字串連結
                ad.add(s1, s2)
            Case Else '顯示輸入錯誤
                ad.add()
        End Select
        Console.ReadLine()
    End Sub

End Module