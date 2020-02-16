Module Module1
    '-------------------------------------------------------------------------------------------------
    '功能：使用「&」串接運算子
    '-------------------------------------------------------------------------------------------------        
    Sub Main()
        Dim a, b As Integer
        Dim c, d, result1, result2 As String
        a = 350
        b = 450
        c = "Hello "
        d = "Everybody"
        result1 = a & b '將變數a及b的值進行轉換並結合在一起
        result2 = c & d '將變數c與d的值結合在一起
        Console.WriteLine(result1) '將result1顯示出來
        Console.WriteLine(result2) '將result2顯示出來
        Console.Read() '暫時
    End Sub
End Module
