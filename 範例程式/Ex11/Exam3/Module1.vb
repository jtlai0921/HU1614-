Imports System

Interface Car '定義一個名為Car介面
    Function Carwool() As Integer  '定義成員
End Interface

Class bike '定義一個名為bike類別
    Implements Car '實作Car介面

    Public Function Carwool() As Integer Implements Car.Carwool
        Carwool = 2
    End Function
End Class

Class race '定義一個名為dog類別
    Implements Car '實作animal介面

    Public Function Carwool() As Integer Implements Car.Carwool
        Carwool = 4
    End Function
End Class

Module Module1

    Sub Main()
        Dim input As Integer
        Console.Write("您想瞭解那一種車型的輪胎數呢？(1)腳踏車(2)汽車？")
        input = CInt(Console.ReadLine()) '取得所輸入的值
        Select Case input
            Case 1 '腳踏車
                Dim bike1 As New bike
                Console.WriteLine("腳踏車的輪胎數為：" & bike1.Carwool)
            Case 2 '汽車
                Dim race1 As New race
                Console.WriteLine("汽車的輪胎數為：" & race1.Carwool)
        End Select
        Console.Read()
    End Sub

End Module

