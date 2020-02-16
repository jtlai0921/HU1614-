Module Module1
    Sub Main()
        Dim name As New ArrayList
        Dim str_tmp As String
        Console.WriteLine("請輸入學生姓名(輸入 . 結束輸入)：")
        Do
            Console.Write(">")
            str_tmp = Console.ReadLine()
            name.Add(str_tmp)
        Loop Until (str_tmp = ".")
        Console.WriteLine("共輸入" & name.Count - 1 & "筆資料：")
        For Each str_tmp In name
            Console.Write("-->")
            Console.WriteLine(str_tmp)
        Next
        Console.Read() '暫停
    End Sub
End Module
