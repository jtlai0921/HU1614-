Module Module1

    Sub Main()
        Dim chrA, chrB, chrC As Char
        chrA = "A"
        chrB = "B"
        chrC = "C"
        Console.WriteLine(chrA & " 的Unicode編碼為 " & AscW(chrA))
        Console.WriteLine(chrB & " 的Unicode編碼為 " & AscW(chrB))
        Console.WriteLine(chrC & " 的Unicode編碼為 " & AscW(chrC))
        Console.Read() '暫停
    End Sub

End Module
