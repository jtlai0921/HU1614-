'範例：多重繼承
'

Imports System

Namespace myname '定義一個名為myname的命名空間
    Interface baseinte '定義一個名為baseinte的介面
        Sub s() '定義一個名為s的成員
    End Interface

    Interface inte1 '定義一個名為inte1的介面
        Sub s2() '定義一個名為s2的成員
    End Interface

    Interface inte '定義一個名為inte的介面
        Inherits baseinte, inte1 '繼承自baseinte及inte1介面
        Sub s1()
    End Interface

    Class cls '定義一個名為cls的類別
        Implements inte '實作inte介面

        Public Sub s() Implements baseinte.s '實作baseinte介面的s函式
            Console.WriteLine("這是baseinte介面的實作")
        End Sub

        Public Sub s1() Implements inte.s1 '實作inte介面的s1函式
            Console.WriteLine("這是實做inte介面的 s1 函式")
        End Sub

        Public Sub s2() Implements inte1.s2 '實作inte1介面的s2函式
            Console.WriteLine("這是 inte1介面函式實作")
        End Sub
    End Class

End Namespace

Module Module1

    Sub Main()
        Dim cls1 As New myname.cls
        cls1.s()
        cls1.s1()
        cls1.s2()
        Console.Read()
    End Sub

End Module
