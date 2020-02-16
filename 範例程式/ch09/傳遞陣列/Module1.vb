Module Module1
    Sub Main()
        Dim MyArray() As Integer = {1, 2, 3, 4, 5}
        Dim i As Integer
        SetZero(MyArray)
        Console.WriteLine("陣列內容：")
        For Each i In MyArray
            Console.Write(i & " ")
        Next
        Console.WriteLine()
        Console.Read() '暫停
    End Sub

    Sub SetZero(ByVal Arr() As Integer)
        Dim i As Integer
        For i = 0 To Arr.Length - 1
            Arr(i) = 0
        Next
    End Sub
End Module
