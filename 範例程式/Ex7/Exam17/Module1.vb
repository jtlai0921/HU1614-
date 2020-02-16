Module Module1

    Sub Main()
        Dim number, numMod As Integer
        Dim count As Integer = 2
        Console.Write("請輸入一數字：")
        number = CInt(Console.ReadLine())
        If number <> 2 Then
            Do
                numMod = number Mod count
                If ((numMod = 0) And (number <> 2)) Then
                    Console.WriteLine(number & " 不是質數。")
                    Exit Do
                End If
                count += 1
            Loop Until count = number
        End If
        If count = number Then
            Console.WriteLine(number & " 是質數。")
        End If
        Console.Read()
    End Sub

End Module
