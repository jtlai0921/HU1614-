Module Module1
    Dim count As Integer
    Sub Main()
        Dim sheet As Integer
        Console.Write("請輸入盤數：")
        sheet = CInt(Console.ReadLine())
        Console.WriteLine("河內塔解答：")
        Hanoi("A", "C", "B", sheet)
        Console.ReadLine()
    End Sub

    Function Hanoi(ByVal sMove As Char, ByVal sTo As Char, ByVal sAux As Char, ByVal n As Integer) As Integer
        If n = 1 Then
            count += 1
            Console.Write("步驟 {0,-3:D}：", count)
            Console.WriteLine("盤 {0,-2:D} 由 {1} 移至 {2}", n, sMove, sTo)
        Else
            Hanoi(sMove, sAux, sTo, n - 1)
            count += 1
            Console.Write("步驟 {0,-3:D}：", count)
            Console.WriteLine("盤 {0,-2:D} 由 {1} 移至 {2}", n, sMove, sTo)
            Hanoi(sAux, sTo, sMove, n - 1)
        End If
    End Function
End Module
