Module Module1
    Sub Main()
        Dim MyArray(1, 2) As Integer
        Dim i, j As Integer
        Dim ArrayD1, ArrayD2 As Integer
        ArrayD1 = UBound(MyArray, 1)
        ArrayD2 = UBound(MyArray, 2)
        For i = 0 To ArrayD1
            For j = 0 To ArrayD2
                MyArray(i, j) = (i + 1) * (j + 1)
            Next
        Next
        For i = 0 To ArrayD1
            For j = 0 To ArrayD2
                Console.WriteLine("MyArray(" & i & "," & j & ") = " & MyArray(i, j))
            Next
        Next
        Console.Read() '暫停
    End Sub
End Module
