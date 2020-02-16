Module Module1
    Sub Main()
        Dim str As String
        Console.Write("請輸入字串：")
        str = Console.ReadLine()
        Console.WriteLine("反轉字串：" & strReverse(str))
        Console.ReadLine()
    End Sub

    Function strReverse(ByRef str As String) As String
        Dim charArray() As Char
        Dim strR As String = ""
        Dim i As Integer
        charArray = str.ToCharArray()
        For i = charArray.Length - 1 To 0 Step -1
            strR &= charArray(i)
        Next
        Return strR
    End Function
End Module
