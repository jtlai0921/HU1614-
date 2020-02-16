'範例：踩地雷
'
Module Module1
    Sub Main()
        Dim Ans, MyAns, PcAns, UpBound, LowBound As Integer
        Dim GetNum As New Random
        UpBound = 100 : LowBound = 0
        Ans = GetNum.Next(1, 99) '使用Random類別的Next方法來產生0-100之間的數值
        Console.WriteLine("答案不包含 0 及 100 ")
        Console.WriteLine("範  圍" & Space(4) & "使用者猜" & Space(4) & "電  腦")
        Console.Write(LowBound & " ~ " & UpBound)
        Do
            Console.Write(Space(4) & "：")
            MyAns = Console.ReadLine() '輸入一個值
            Do While MyAns = LowBound Or MyAns = UpBound Or MyAns <= LowBound Or MyAns >= UpBound
                Console.WriteLine("你輸入了不合規定的數值")
                Console.Write(LowBound & " ~ " & UpBound & Space(4) & "數字：")
                MyAns = Console.ReadLine()
            Loop
            If MyAns < Ans Then
                LowBound = MyAns
                Console.Write(LowBound & " ~ " & UpBound)
                PcAns = GetPcNuM(LowBound, UpBound) '使用GetPcNum函數來取得電腦所猜測的數字
                Console.WriteLine(Space(17) & PcAns)
            ElseIf MyAns > Ans Then
                UpBound = MyAns
                Console.Write(LowBound & " ~ " & UpBound)
                PcAns = GetPcNuM(LowBound, UpBound)
                Console.WriteLine(Space(17) & PcAns)
            Else
                Console.WriteLine("您踩中地雷了！您已經輸了！")
                Exit Do
            End If

            If PcAns < Ans Then
                LowBound = PcAns
                Console.Write(LowBound & " ~ " & UpBound)
            ElseIf PcAns > Ans Then
                UpBound = PcAns
                Console.Write(LowBound & " ~ " & UpBound)
            Else
                Console.WriteLine("恭喜您！電腦踩中地雷了！您贏了！")
                Exit Do
            End If
        Loop
        Console.ReadLine()
    End Sub
    Function GetPcNuM(ByVal Low As Integer, ByVal Up As Integer) As Integer
        Dim I As New Random
        Dim Tmp As Integer
        Tmp = I.Next(Low, Up)
        Do While Tmp = Up Or Tmp = Low
            Tmp = I.Next(Low, Up)
        Loop
        Return Tmp
    End Function

End Module