Module Module1

    Sub Main()
        Dim input As Char
        Dim str As String
        Dim count As Integer = 1
        str = ""
        Console.WriteLine("請輸入一句英文：")
        While input <> "."
            input = Chr(Console.Read())
            '** 利用空白判斷是否為一個單字
            If input = " " Then
                count += 1
            End If
            str &= input
        End While
        Console.WriteLine("所輸入的句子為：" & str)
        Console.WriteLine("共有" & count & "英文單字。")
        Console.ReadLine()
        Console.Read()
    End Sub

End Module
