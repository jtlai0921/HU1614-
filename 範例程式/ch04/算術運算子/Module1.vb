Module Module1
    Sub Main()
        Dim intX As Integer
        Dim sngY As Single
        intX = 1 + 3
        Console.WriteLine("1 + 3 = " & intX)
        intX = 3 - 2
        Console.WriteLine("3 - 2 = " & intX)
        intX = 9 * 9
        Console.WriteLine("9 * 9 = " & intX)
        intX = 10 / 3
        Console.WriteLine("10 / 3 = " & intX)
        sngY = 10 / 3
        Console.WriteLine("10 / 3 = " & sngY)
        sngY = 10 \ 3
        Console.WriteLine("10 \ 3 = " & sngY)
        sngY = 10 Mod 3
        Console.WriteLine("10 / 3 = " & sngY)
        sngY = 3 ^ 2
        Console.WriteLine("3^2 = " & sngY)
        Console.Read()
    End Sub
End Module
