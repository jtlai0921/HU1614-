Module Module1
    Sub Main()
        Dim binResult As Boolean
        Dim numResult As Integer
        binResult = (3 > 1) And (5 > 4)
        Console.WriteLine("(3>1) And (5>4) -> " & CStr(binResult))
        numResult = 10 And 9
        Console.WriteLine("10 And 9 -> " & CStr(numResult))
        Console.Read() '暫停
    End Sub
End Module
