Module Module1
    Sub Main()
        Dim input As Integer
        Try
            Try
                Console.Write("請輸入一個整數：")
                input = CInt(Console.ReadLine())
                Console.WriteLine("您輸入的整數為：" & input)
            Catch e As InvalidCastException
                Throw New InvalidCastException("輸入錯誤！")
            End Try
        Catch e As InvalidCastException
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub
End Module
