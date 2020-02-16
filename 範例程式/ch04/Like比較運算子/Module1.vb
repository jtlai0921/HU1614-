Module Module1
    Sub Main()
        Dim result As Boolean
        result = "J" Like "J"
        Console.WriteLine("J Like J > " & CStr(result))
        result = "J" Like "Justin"
        Console.WriteLine("J Like Justin > " & CStr(result))
        result = "Jason" Like "J?n"
        Console.WriteLine("Jason Like J?n > " & CStr(result))
        result = "Jason" Like "J*n"
        Console.WriteLine("Jason Like J*n > " & CStr(result))
        result = "J" Like "[A-M]"
        Console.WriteLine("Jason Like [A-M] > " & CStr(result))
        result = "J" Like "[!A-M]"
        Console.WriteLine("'J' Like [!A-M] > " & CStr(result))
        Console.Read() '暫停
    End Sub
End Module
