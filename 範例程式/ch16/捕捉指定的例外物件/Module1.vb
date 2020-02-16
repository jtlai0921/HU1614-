Module Module1
    Sub Main()
        Dim IntX, IntY, IntAns As Integer
        Try
            Console.Write("請輸入被除數：")
            IntX = CInt(Console.ReadLine())
            Console.Write("請輸入除數：")
            IntY = CInt(Console.ReadLine())
            IntAns = IntX / Inty
            Console.WriteLine("{0} / {1} = {2} ", IntX, IntY, IntAns)
        Catch e As OverflowException
            Console.WriteLine(e.Message)
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub
End Module
