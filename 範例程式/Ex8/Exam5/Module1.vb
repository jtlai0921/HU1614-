Module Module1
    Dim count As Integer
    Sub Main()
        Dim n As Integer
        Console.Write("請輸入n值：")
        n = CInt(Console.ReadLine())
        Console.WriteLine("求解費氏數列 F({0}) = {1}", n, Fibonacci(n))
        Console.ReadLine()
    End Sub

    Function Fibonacci(ByVal n As Integer) As Integer
        If n <= 1 Then
            Return n
        Else
            Return Fibonacci(n - 1) + Fibonacci(n - 2)
        End If
    End Function
End Module
