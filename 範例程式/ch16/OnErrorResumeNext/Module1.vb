Module Module1
    Sub Main(ByVal Args() As String)
        Dim intX As Integer = 10
        Dim i As Integer

        On Error Resume Next
        For i = -3 To 3
            Console.WriteLine("intX \ {0} = {1}", i, intX \ i)
        Next
        Console.Read()
    End Sub
End Module