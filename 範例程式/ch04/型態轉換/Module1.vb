Module Module1

    Sub Main()
        Dim strA As String = "1000"
        Dim intB, intC As Integer
        Dim blnD As Boolean
        intB = 100 + CInt(strA) '將字串變數strA轉換為整數型態
        intC = 15
        blnD = CBool(intC) '將整數變數intCA轉換為布林型態
        Console.WriteLine(intB) '將變數intB顯示出來
        Console.WriteLine(blnD) '將變數blnD顯示出來
        Console.ReadLine() '暫停
        Dim c1 As Integer
        c1 = 100 + "100"
        Console.WriteLine(c1) '將變數c1顯示出來
        Console.Read()
    End Sub

End Module
