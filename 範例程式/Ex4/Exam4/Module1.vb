Module Module1

    Sub Main()
        Dim strA As String = "12345"
        Dim intB As Integer = 54321
        intB = intB + CInt(strA) '將字串變數strA轉換為整數型態
        Console.WriteLine("12345+ 54321=" & intB) '將變數intB顯示出來
        Console.Read()
    End Sub

End Module