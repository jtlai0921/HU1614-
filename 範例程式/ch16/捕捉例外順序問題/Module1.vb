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
        Catch e As Exception
            Console.WriteLine("一般例外發生")
            '** 以下的例外處理將不會被執行
        Catch e As OverflowException
            Console.WriteLine("溢值錯誤")
            Console.WriteLine(e.Message)
        Catch e As InvalidCastException
            Console.WriteLine("資料型態錯誤")
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub
End Module