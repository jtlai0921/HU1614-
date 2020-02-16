Module Module1
    '-------------------------------------------------------------------------------------------------
    '功能：用陣列來計算班級成績總平均
    '-------------------------------------------------------------------------------------------------
    Sub Main()
        Dim score() As Integer = New Integer(10) {60, 76, 93, 93, 32, 71, 63, 98, 46, 84, 87}
        Dim total, avg As Double
        Dim i As Integer
        For i = 0 To UBound(score)
            total += score(i) '進行分數相加的運算
        Next
        avg = total / (UBound(score) + 1) '求出平均值
        '將結果顯示出來
        Console.WriteLine("全班共有 " & UBound(score) + 1)
        Console.WriteLine("班級總分為 " & total)
        Console.WriteLine("班級總平均 = " & avg)
        Console.Read() '暫時
    End Sub
End Module
