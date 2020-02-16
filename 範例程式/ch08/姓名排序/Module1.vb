Module Module1
    Sub Main()
        Dim strName() As String = {"Justin Lin", "BeckyDay Hwang", "Momor Hwang", "David Chu"}
        Dim i As Integer
        Console.WriteLine("以名字為主排序：")
        SortByFirst(strName)
        For i = 0 To strName.Length - 1
            Console.WriteLine(strName(i) & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("以姓氏為主排序：")
        SortByLast(strName)
        For i = 0 To strName.Length - 1
            Console.WriteLine(strName(i) & " ")
        Next
        Console.Read() '暫停
    End Sub

    Sub SortByFirst(ByRef Arr() As String)
        Array.Sort(Arr)
    End Sub

    Sub SortByLast(ByRef Arr() As String)
        Dim m, n As Integer
        Dim temp As String
        Dim i, j As Integer
        For i = Arr.Length - 1 To 1 Step -1
            For j = 0 To i - 1
                m = Arr(j).Indexof(" ")
                n = Arr(j + 1).Indexof(" ")
                If Arr(j).SubString(m + 1) > Arr(j + 1).SubString(n + 1) Then
                    temp = Arr(j + 1)
                    Arr(j + 1) = Arr(j)
                    Arr(j) = temp
                End If
            Next
        Next
    End Sub
End Module
