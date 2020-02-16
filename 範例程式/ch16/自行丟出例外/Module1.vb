Module Module1
    Sub Main()
        Try
            Throw New DivideByZeroException
        Catch e As DivideByZeroException
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub
End Module