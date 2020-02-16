Module Module1
    Structure circle
        Dim cRadius As Single
        Dim cColor As String
    End Structure
    Structure wheel
        Dim circle1 As circle
        Dim usage As String
    End Structure
    Sub Main()
        Dim wheel1 As wheel
        wheel1.circle1.cRadius = 50
        wheel1.circle1.cColor = "黑色"
        wheel1.usage = "汽車"
        Console.WriteLine("輪胎半徑：" & wheel1.circle1.cRadius)
        Console.WriteLine("輪胎顏色：" & wheel1.circle1.cColor)
        Console.WriteLine("輪胎用途：" & wheel1.usage)
        Console.Read()
    End Sub
End Module
