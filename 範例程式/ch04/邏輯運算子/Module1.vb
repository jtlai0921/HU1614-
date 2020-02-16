Module Module1
    '-------------------------------------------------------------------------------------------------
    '功能：使用邏輯運算子
    '-------------------------------------------------------------------------------------------------
    Sub Main()
        Dim a, b, c, d As Boolean
        a = (3 > 5) Or (15 < 40)
        b = (3 > 5) And (15 < 40)
        c = (3 > 5) Xor (15 < 40)
        d = Not (3 > 5)
        Console.WriteLine("a=" & a) '將變數a顯示出來
        Console.WriteLine("b=" & b) '將變數b顯示出來
        Console.WriteLine("c=" & c) '將變數c顯示出來
        Console.WriteLine("d=" & d) '將變數d顯示出來
        Console.Read() '暫停
    End Sub
End Module
