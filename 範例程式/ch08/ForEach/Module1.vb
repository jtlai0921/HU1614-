Module Module1
    Sub Main()
        Dim UserName() As String = {"吳政華", "郭子儀", "李商俊", "廖本來"}
        Dim strName As String
        For Each strName In UserName
            Console.WriteLine("使用者：" & strName)
        Next
        Console.Read() '暫停
    End Sub
End Module
