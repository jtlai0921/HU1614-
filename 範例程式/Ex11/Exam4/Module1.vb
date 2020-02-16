Module Module1
    Class Hello
        Sub SayHello()
            Console.WriteLine("Hello！World！")
        End Sub
    End Class
    Sub Main()
        Dim obj As New Hello
        obj.SayHello()
        Console.Read() '暫停
    End Sub
End Module
