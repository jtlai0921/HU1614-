Module Module1

    Sub Main()
        Dim chrX, chrY, chrZ As Char
        chrX = "X"
        chrY = "Y"
        chrZ = "Z"
        Console.WriteLine(chrX & " 的Unicode編碼為 " & AscW(chrX))
        Console.WriteLine(chrY & " 的Unicode編碼為 " & AscW(chrY))
        Console.WriteLine(chrZ & " 的Unicode編碼為 " & AscW(chrZ))
        Console.Read() '暫停
    End Sub

End Module