Module Module1
    Structure circle
        Dim cX, cY As Integer
        Dim cRadius As Single
        Dim cColor As String
    End Structure
    Sub Main()
        Dim circle1 As circle
        circle1.cX = 100
        circle1.cY = 100
        circle1.cRadius = 1.414
        circle1.cColor = "紅色"
        Console.WriteLine("圓心 X 座標：" & circle1.cX)
        Console.WriteLine("圓心 Y 座標：" & circle1.cY)
        Console.WriteLine("圓半徑：" & circle1.cRadius)
        Console.WriteLine("填色：" & circle1.cColor)
        Console.Read()
    End Sub
End Module
