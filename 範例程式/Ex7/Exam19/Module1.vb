Module Module1

    Sub Main()
        Dim input As Integer
        Dim sngX1 As Single = 0
        Dim sngX2 As Single = 15
        Dim middle As Single
        Do
            Console.Write("請輸入開根號數字（0～15）：")
            input = CInt(Console.ReadLine())
        Loop While input > 15
        Do
            middle = (sngX1 + sngX2) / 2
            If (middle * middle > input) Then
                sngX2 = middle
            Else
                sngX1 = middle
            End If
        Loop While (sngX2 - sngX1 > 0.00001)
        Console.WriteLine(input & " 開根號值：" & middle)
        Console.Read()
    End Sub

End Module
