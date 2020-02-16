'範例：實作介面多型
'
Imports System

Interface animal '定義一個名為animal介面
    Function introduction() As String '定義成員
End Interface

Class bird '定義一個名為bird類別
    Implements animal '實作animal介面

    Public Function introduction() As String Implements animal.introduction '實作animal介面的introduction函式
        introduction = "鳥會啾啾叫而且會飛"
    End Function
End Class

Class dog '定義一個名為dog類別
    Implements animal '實作animal介面

    Public Function introduction() As String Implements animal.introduction '實作animal介面的introduction函式
        introduction = "狗會汪汪叫而且會跑"
    End Function
End Class

Module Module1

    Sub Main()
        Dim input As Integer
        Console.WriteLine("您想瞭解那一種動物的特性呢？(1)鳥(2)狗")
        input = CInt(Console.ReadLine()) '取得所輸入的值
        Select Case input
            Case 1 '鳥
                Dim bd As New bird
                Console.WriteLine(bd.introduction())
            Case 2 '狗
                Dim dg As New dog
                Console.WriteLine(dg.introduction())
        End Select
        Console.Read()
    End Sub

End Module
