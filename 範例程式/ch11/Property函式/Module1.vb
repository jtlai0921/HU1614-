Module Module1
    Class circle
        Private r As Single
        Private Pi As Single = 3.14
        Private a As Single
        Property radius() As Single
            Get
                Return r
            End Get
            Set(ByVal value As Single)
                r = value
                a = Pi * r * r
            End Set
        End Property
        Property area() As Single
            Get
                Return a
            End Get
            Set(ByVal value As Single)
                a = value
                r = Math.Sqrt(a / Pi)
            End Set
        End Property
    End Class

    Sub Main()
        Dim objC1 As New circle
        Console.Write("請輸入半徑資訊：")
        objC1.radius = CSng(Console.ReadLine())
        Console.WriteLine("半徑：" & objC1.radius)
        Console.WriteLine("面積：" & objC1.area)
        Console.Write("請輸入面積資訊：")
        objC1.area = CSng(Console.ReadLine())
        Console.WriteLine("半徑：" & objC1.radius)
        Console.WriteLine("面積：" & objC1.area)
        Console.Read() '暫停
    End Sub
End Module