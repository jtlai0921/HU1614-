Module Module1
    Sub Main()
        Dim UserName1() As String = {"吳政華", "郭子儀", "李商俊", "廖本來"}
        Dim UserName2(3) As String
        Dim strName As String
        UserName2 = UserName1
        Console.WriteLine("陣列UserName1()內容......")
        For Each strName In UserName1
            Console.Write(strName & " ")
        Next
        UserName2(0) = "Delete"
        UserName2(1) = "Delete"
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("陣列UserName1()內容......")
        For Each strName In UserName1
            Console.Write(strName & " ")
        Next
        Console.WriteLine()
        Console.Read() '暫停
    End Sub
End Module
