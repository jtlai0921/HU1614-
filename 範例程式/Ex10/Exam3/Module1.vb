Public Class Exam3
    Dim Name As String
    Dim Price As Integer
    Property BookName() As String
        Get
            BookName = Name
        End Get
        Set(ByVal Value As String)
            Name = Value
        End Set
    End Property
    Property BookPrice() As Integer
        Get
            BookPrice = Price
        End Get
        Set(ByVal Value As Integer)
            Price = Value
        End Set
    End Property
End Class
Module module1
    Sub Main()
        Dim ComputerBook As New Exam3
        Dim Sum As Double = 0
        Dim unit1 As Integer
        Console.Write("請輸入電腦書籍名稱:")
        ComputerBook.BookName = Console.ReadLine
        Console.Write("請輸入電腦書籍價格:")
        ComputerBook.BookPrice = Console.ReadLine
        Console.Write("請輸入購買量:")
        unit1 = Console.ReadLine
        Sum = ComputerBook.BookPrice * unit1
        Console.WriteLine("您購買" & ComputerBook.BookName & "共須付" & Sum.ToString & "元")
        Console.ReadLine()
    End Sub
End Module
