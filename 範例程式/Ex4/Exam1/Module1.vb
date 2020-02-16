Module Module1

    Sub Main()
        Dim binResult As Boolean
        Dim numResult As Integer
        binResult = (8 > 3) And (9 > 12)
        Console.WriteLine("(8 > 3) And (9 > 12) -> " & CStr(binResult))
        numResult = 20 And 21
        Console.WriteLine("20 And 21 -> " & CStr(numResult))
        Console.Read() '暫停
    End Sub

End Module