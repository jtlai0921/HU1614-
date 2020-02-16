Module Module1
    Class MyString
        Private MyLength As Integer

        Public Sub HowLong(ByVal str As String)
            strLen(str)
            Console.WriteLine("輸入的字串長度為：" & MyLength)
        End Sub

        Private Sub strLen(ByVal str As String)
            Dim chrtmp As Char
            Dim Count As Integer
            For Each chrtmp In str
                Count += 1
            Next
            MyLength = Count
        End Sub
    End Class

    Sub Main()
        Dim objStr As New MyString
        Console.Write("請輸入一字串：")
        objStr.HowLong(Console.ReadLine())
        Console.Read() '暫停
    End Sub
End Module