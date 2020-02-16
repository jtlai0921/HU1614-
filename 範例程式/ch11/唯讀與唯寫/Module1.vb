Module Module1
    Class square
        Private a As Single
        ReadOnly Property area() As Single
            Get
                Return a
            End Get
        End Property

        WriteOnly Property length() As Single
            Set(ByVal w As Single)
                a = w * w
            End Set
        End Property
    End Class

    Sub Main()
        Dim objS1 As New square
        Console.Write("請輸入邊長資訊：")
        objS1.length = CSng(Console.ReadLine())
        Console.WriteLine("面積：" & objS1.area)
        Console.Read() '暫停
    End Sub
End Module