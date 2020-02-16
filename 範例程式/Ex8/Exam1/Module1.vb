Module Module1
    Sub Main()
        Dim temp() As Integer = New Integer(11) {26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18}
        Dim total, avg As Double
        Dim i As Integer
        For i = 0 To UBound(temp)
            total += temp(i) '進行溫度相加的運算
        Next
        avg = total / (UBound(temp) + 1) '求出平均溫度
        '將結果顯示出來
        Console.WriteLine("共有" & UBound(temp) + 1 & "月份")
        Console.WriteLine("年度總溫度為： " & total)
        Console.WriteLine("年度平均溫度為： " & avg)
        Console.Read() '暫時
    End Sub
End Module
