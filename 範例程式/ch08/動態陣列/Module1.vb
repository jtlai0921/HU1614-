Module Module1
    '-------------------------------------------------------------------------------------------------
    '功能：改變陣列大小
    '-------------------------------------------------------------------------------------------------    
    Sub Main()
        Dim a() As Integer = {30, 40, 50} '宣告陣列a
        Dim i As Integer
        Console.WriteLine("原陣列大小為 " & UBound(a) + 1)
        Console.Write("元素為 :")
        '將陣列a內的元素顯示出來
        For i = 0 To UBound(a)
            Console.Write(a(i) & " ")
        Next
        ReDim a(5) '更改陣列a的元素值
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("執行 ReDim a(5) 後，陣列大小為 " & UBound(a) + 1)
        Console.Write("改變大小後，元素為 :")
        '將改變元素值之後其陣列a的內容
        For i = 0 To UBound(a)
            Console.Write(a(i) & " ")
        Next
        Console.WriteLine() '空一行
        Console.Read() '暫時
    End Sub
End Module
