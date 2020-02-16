Module Module1
    Sub Main()
        Dim score() As Integer = New Integer(4) {99, 100, 59, 58, 75}
        Dim total, avg As Double
        Dim i As Integer
        For i = 0 To UBound(score)
            total += score(i) '進行成績相加的運算
        Next
        avg = total / (UBound(score) + 1) '求出平均成績
        '將結果顯示出來
        Console.WriteLine("共有" & UBound(score) + 1 & "位同學")
        Console.WriteLine("國文總成績度為： " & total)
        Console.WriteLine("國文總平均為： " & avg)
        Console.Read() '暫時
    End Sub
End Module
