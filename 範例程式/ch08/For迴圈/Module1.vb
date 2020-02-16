Module Module1
    Sub Main()
        Dim UserName() As String = {"吳政華", "郭子儀", "李商俊", "廖本來"}
        Dim i As Integer
        For i = 0 To UBound(UserName)
            Console.WriteLine("使用者：" & UserName(i))
        Next
        Console.Read() '暫停
    End Sub
End Module
