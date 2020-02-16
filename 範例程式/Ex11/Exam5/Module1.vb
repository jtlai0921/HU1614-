Module Module1
    MustInherit Class Line
        Protected L As Double
        Sub New(ByVal L As Double)
            Me.L = L
        End Sub

        MustOverride ReadOnly Property getLength() As Double
        MustOverride Function getArea() As Double
    End Class

    Class Square
        Inherits Line
        Sub New(ByVal W As Double)
            MyBase.New(W)
        End Sub

        Overrides ReadOnly Property getLength() As Double
            Get
                Return 4 * L
            End Get
        End Property

        Overrides Function getArea() As Double
            Return L * L
        End Function
    End Class

    Class Circle
        Inherits Line
        Sub New(ByVal R As Double)
            MyBase.New(R)
        End Sub

        Overrides ReadOnly Property getLength() As Double
            Get
                Return 2 * Math.PI * L
            End Get
        End Property

        Overrides Function getArea() As Double
            Return Math.PI * L * L
        End Function
    End Class

    Sub Main()
        Dim S1 As New Square(5.3)
        Dim B1 As New Circle(3.1)
        Console.WriteLine("正方形周長：" & S1.getLength())
        Console.WriteLine("正方形面積：" & S1.getArea())
        Console.WriteLine("圓形周長：" & B1.getLength())
        Console.WriteLine("圓形面積：" & B1.getArea())
        Console.Read() '暫停
    End Sub
End Module
