Module Module1
    '-------------------------------------------------------------------------------------------------
    '功能：運算子優先順序的應用
    '-------------------------------------------------------------------------------------------------
    Sub Main()
        Dim price As Integer = 450
        Dim result1, result2, onsale As Boolean
        onsale = False
        result1 = (5 + 11) * 10 / 2 >= 50 / 2 * 3
        result2 = (price <= 450) Or (onsale = True)
        '將運算的結果顯示出來
        Console.WriteLine("(5 + 11) * 10 / 2 >= 50 / 2 * 3=" & result1)
        Console.WriteLine("(price <= 450) Or (onsale = True)=" & result2)
        Console.Read() '暫停
    End Sub
End Module
