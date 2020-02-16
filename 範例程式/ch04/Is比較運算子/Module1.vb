Module Module1
    Sub Main()
        Dim Object1 As New Object
        Dim Object2 As New Object
        Dim objX, objY, objZ As Object
        objX = Object1
        objY = Object1
        objZ = Object2
        Console.WriteLine("obj1與obj2是否參考同一物件？ " & CStr(objX Is objY))
        Console.WriteLine("obj1與obj3是否參考同一物件？ " & CStr(objX Is objZ))
        Console.WriteLine("obj2與obj3是否參考同一物件？ " & CStr(objY Is objZ))
        Console.Read() '暫停
    End Sub
End Module
