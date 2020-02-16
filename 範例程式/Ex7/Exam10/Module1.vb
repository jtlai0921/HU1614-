Module Module1

    Sub Main()
        Dim intTmp As Integer
        Console.Write("請輸入一個英文字母：")
        intTmp = Console.Read()
        If intTmp > 64 And intTmp < 91 Then
            Console.WriteLine("輸入字元為大寫字母。")
            intTmp += 32
            Console.WriteLine("轉為小寫字母：" & Chr(intTmp))

        Else
            Console.WriteLine("輸入字元不是大寫字母。")
            Console.WriteLine("輸入字元：" & Chr(intTmp))
        End If
        Console.ReadLine()
        Console.Read()
    End Sub

End Module
