'範例：介面實作
'

Imports System

Interface inte '定義一個名為inte的介面
    Overloads Sub s1() '定義一個名為s1且不接收參數的過載函式成員
    Overloads Sub s1(ByVal x As String) '定義一個名為s1且接受一個參數的過載函式成員
End Interface

Class cls '定義一個名為cls的類別

    Implements inte '實作inte介面
    Public Overloads Sub s1() Implements inte.s1 '定義實作介面的s1函式，但不接受參數
        Console.WriteLine("這是實作介面的 s1 函式")
    End Sub

    Public Overloads Sub s1(ByVal x As String) Implements inte.s1 '定義實作介面的s1函式，但接受一個參數
        Console.WriteLine("輸入參數 " & x)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim cls1 As New cls
        cls1.s1()
        cls1.s1("Hello")
        Console.Read()
    End Sub

End Module