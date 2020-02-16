Module Module1
    Sub Main()
        Try
            ThrowException()
        Catch e As DivideByZeroException
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub

    Sub ThrowException()
        Try
            Throw New DivideByZeroException
        Catch e As Exception
            Console.WriteLine("捕捉例外")
            Throw e
        End Try
    End Sub
End Module