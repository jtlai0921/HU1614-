Module Module1

    Sub Main()
        Dim a, b As Integer
        Dim result1 As Boolean
        a = 13
        b = 12
        result1 = (a < b)  '判斷a是否等於b
        Console.WriteLine("a=13")
        Console.WriteLine("b=12")
        Console.WriteLine("a< b的比較結果=" & result1) '將result1顯示出來
        Console.Read() '暫停
    End Sub

End Module