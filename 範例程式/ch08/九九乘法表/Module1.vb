Module Module1
    Sub Main()
        Dim i, j As Integer
        For i = 2 To 9
            For j = 2 To 9
                Console.Write("{0:D}*{1:D}={2,2:D} ", j, i, i * j)
            Next
            Console.WriteLine()
        Next
        Console.Read() '暫停
    End Sub
End Module
