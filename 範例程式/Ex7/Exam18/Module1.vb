Module Module1

    Sub Main()
        Dim input As Integer
        Console.Write("請輸入西元年份：")
        input = CInt(Console.ReadLine())
        If (input Mod 4 = 0) And (input Mod 100 <> 0) Then
            Console.WriteLine(input & " 為閏年")
        ElseIf (input Mod 100 = 0) And (input Mod 400 = 0) Then
            Console.WriteLine(input & " 為閏年")
        Else
            Console.WriteLine(input & " 不為閏年")
        End If
        Console.Read()
    End Sub

End Module
