Module Module1

    Sub Main()
        Dim input As Integer
        Console.Write("請輸入一個字元：")
        input = Console.Read()
        Select Case input
            Case 48 To 57
                '** Unicode數字編碼範圍
                Console.WriteLine("您所輸入的是數字。")
            Case 65 To 90
                '** Unicode大寫字母編碼範圍
                Console.WriteLine("您所輸入的是大寫字母。")
            Case 97 To 122
                '** Unicode小寫字母編碼範圍
                Console.WriteLine("您所輸入的是小寫字母。")
            Case Else
                Console.WriteLine("非數字或字母字元。")
        End Select
        Console.ReadLine()
        Console.Read()
    End Sub

End Module
