Module Module1
    Sub Main()
        Dim IntX, IntY, IntAns As Integer
        intY = -1
        Try
            Console.Write("請輸入被除數：")
            IntX = CInt(Console.ReadLine())
            Console.Write("請輸入除數：")
            IntY = CInt(Console.ReadLine())
            IntAns = IntX / Inty
            Console.WriteLine("{0} / {1} = {2} ", IntX, IntY, IntAns)
        Catch e As OverflowException When IntY = 0
            Console.WriteLine("除零錯誤")
        Catch e As OverflowException
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub
End Module