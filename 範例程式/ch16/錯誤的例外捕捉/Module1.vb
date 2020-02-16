Module Module1
    Sub Main()
        Try
            Throw New DivideByZeroException
        Catch e As Exception
            Console.WriteLine("捕捉例外")
            Throw e
        Catch e As DivideByZeroException
            Console.WriteLine(e.Message)
        End Try
    End Sub
End Module