Module Module1
    Sub Main()
        Try
            Throw New DivideByZeroException("發生除零的錯誤")
        Catch e As DivideByZeroException
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub
End Module