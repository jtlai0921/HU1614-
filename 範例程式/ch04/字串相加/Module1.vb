Module Module1
    '-------------------------------------------------------------------------------------------------
    '功能：使用「&=」來執行字串的相加
    '-------------------------------------------------------------------------------------------------    
    Sub Main()
        Dim A, B As String
        Dim a1, a2 As Integer
        A = "Hello"
        B = " David"
        A &= B '將字串變數A與B的內容結合在一起
        Console.WriteLine(A) '將變數intB顯示出來
        a1 = 10
        a2 = 1
        a2 = a1 + a2
        Console.WriteLine("a2=" & a2) '將變數a2B顯示出來
        Console.WriteLine("a2*6 Mod 2 + 5 *10=" & a2 * 6 Mod 2 + 5 * 10)
        Console.Read() '暫停
    End Sub
End Module
