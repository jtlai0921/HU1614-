Module Module1
    Sub Main()
        Dim str1 As String = "Visual Basic"
        Dim str2 As String = "程式設計實務"
        Dim str3 As String = ".NET"
        Dim str4 As String = "C#"
        Dim str As String
        str = str1 + str2
        Console.WriteLine("字串串接：" & str)
        Console.WriteLine("字串長度：" & str.Length)
        str = str.Insert(12, str3)
        Console.WriteLine("字串插入：" & str)
        Console.WriteLine("字串長度：" & str.Length)
        str = str.Replace(str1, str4)
        Console.WriteLine("字串取代：" & str)
        Console.WriteLine("字串長度：" & str.Length)
        str = str.Remove(2, 4)
        Console.WriteLine("字串刪除：" & str)
        Console.WriteLine("字串長度：" & str.Length)
        Console.Read() '暫停
    End Sub
End Module
