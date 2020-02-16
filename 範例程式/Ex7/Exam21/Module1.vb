Module Module1

    Sub Main()
        Dim input As Char
        Console.Write("請輸入選項 A - D：")
        input = Chr(Console.Read())
        Select Case input
            Case "A", "a"
                Console.WriteLine("Apple")
            Case "B", "b"
                Console.WriteLine("Banana")
            Case "C", "c"
                Console.WriteLine("Candice")
            Case "D", "d"
                Console.WriteLine("Dig")
            Case Else
                Console.WriteLine("選項超出範圍！")
        End Select
        Console.ReadLine()
        Console.Read()
    End Sub

End Module
