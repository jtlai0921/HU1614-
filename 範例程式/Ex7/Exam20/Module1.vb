Module Module1

    Sub Main()
        Dim intA, intB As Integer
        Dim i, j As Integer
        Dim intAns As Integer
        Console.Write("請輸入數字一：")
        intA = CInt(Console.ReadLine())
        Console.Write("請輸入數字二：")
        intB = CInt(Console.ReadLine())
        For i = 1 To intB
            intAns += intA
        Next
        Console.WriteLine(intA & " * " & intB & " = " & intAns)
        Console.Read()
    End Sub

End Module
