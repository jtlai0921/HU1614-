Module Module1
    '-------------------------------------------------------------------------------------------------
    '功能：使用「+」串接運算子
    '-------------------------------------------------------------------------------------------------
    Sub Main()
        Dim a, b, c As Integer
        Dim d, e, f As String
        a = 200
        b = 500
        c = a + b
        d = "Today is "
        e = "wonderful day"
        f = d + e
        Console.WriteLine(c) '將變數a與b的相加結果顯示出來
        Console.WriteLine(f) '將變數d與e的字串內容結合在一起並顯示出來
        Console.Read() '暫停
    End Sub
End Module
