Module Module1
    Sub Main()
        Dim IntX, IntY, IntAns As Integer
        Dim Flag As Boolean
        Do
            Try
                Console.Write("請輸入被除數：")
                IntX = CInt(Console.ReadLine())
                Console.Write("請輸入除數：")
                IntY = CInt(Console.ReadLine())
                IntAns = IntX / Inty
                Console.WriteLine("{0} / {1} = {2} ", IntX, IntY, IntAns)
            Catch e As OverflowException
                Console.WriteLine("溢位")
            Catch e As InvalidCastException
                Console.WriteLine("資料型態有誤")
            Finally
                Console.Write("是否重試？(輸入 0 離開)")
                Flag = CBool(Console.ReadLine())
            End Try
        Loop Until Flag = False
        Console.Read()
    End Sub
End Module