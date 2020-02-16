Module Module1
    Sub Main()
        Dim MyArray() As Integer = {55, 1, 312, 2, 3, 156, 36, 12, 32, 4}
        Dim i As Integer
        BubbleSort(MyArray)
        Console.WriteLine("陣列元素排序：")
        For Each i In MyArray
            Console.Write(i & " ")
        Next
        Console.WriteLine()
        Console.Read() '暫停
    End Sub

    Sub BubbleSort(ByVal Arr() As Integer)
        Dim i, j As Integer
        Dim temp As Integer
        For i = Arr.Length - 1 To 1 Step -1
            For j = 0 To i - 1
                If Arr(j) > Arr(j + 1) Then
                    temp = Arr(j + 1)
                    Arr(j + 1) = Arr(j)
                    Arr(j) = temp
                End If
            Next
        Next
    End Sub
End Module
