Module Module1
    Sub Main()
        Dim ArrayNum, Sum As Integer
        Dim i As Integer
        Console.Write("請輸入學生人數：")
        ArrayNum = CInt(Console.ReadLine())
        Dim Score(ArrayNum - 1) As Single
        For i = 0 To UBound(Score)
            Console.Write("學生編號 " & i + 1 & " 成績：")
            Score(i) = CInt(Console.ReadLine())
        Next
        Console.WriteLine()
        Console.WriteLine("以下為成績紀錄：")
        For i = 0 To UBound(Score)
            Console.WriteLine("學生編號 " & i + 1 & " 成績：" & Score(i))
            Sum += Score(i)
        Next
        Console.WriteLine("--------------------")
        Console.WriteLine("平均成績：" & Sum / i)
        Console.Read() '暫停
    End Sub
End Module
