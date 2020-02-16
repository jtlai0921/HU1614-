Module Module1
    Class circle
        Private r As Single
        Property radius() As Single
            Get
                Return r
            End Get
            Set(ByVal value As Single)
                r = value
            End Set
        End Property
    End Class

    Sub Main()
        Dim objC1 As New circle
        Console.Write("請輸入半徑資訊：")
        objC1.radius = CSng(Console.ReadLine())
        Console.WriteLine("半徑：" & objC1.radius)
        Console.Read() '暫停
    End Sub
End Module