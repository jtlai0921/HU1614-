Public Class SetBook
    Private Title As String
    Private Price As Integer
    Protected Sub GetInfo()
        Console.Write("請輸入出版品名稱：")
        Title = Console.ReadLine
        Console.Write("請輸入出版品定價：")
        Price = Console.ReadLine
    End Sub
    Protected Sub DisplayInfo()
        Console.WriteLine("此出版品的名稱為" & Title)
        Console.WriteLine("此出版品的定價為" & Price)
    End Sub
End Class

Public Class Books
    Inherits SetBook
    Private BookName As String
    Public Sub GetData()
        GetInfo()
        Console.Write("輸入作者姓名:")
        BookName = Console.ReadLine
    End Sub
    Public Sub DisplayData()
        DisplayInfo()
        Console.WriteLine("此出版品的作者為" & BookName)
    End Sub
End Class


