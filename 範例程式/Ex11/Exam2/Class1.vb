Public Class Bicycle
    Private Color As String
    Private Style As String
    Private Price As Integer
    Public Sub GetData()
        Console.Write("請輸入顏色：")
        Color = Console.ReadLine
        Console.Write("請輸入車型：")
        Style = Console.ReadLine
        Console.Write("請輸入價格：")
        Price = Console.ReadLine
    End Sub
    Public Sub DispData()
        Console.WriteLine("車的顏色為：" & Color)
        Console.WriteLine("車的型式為：" & Style)
        Console.WriteLine("車的價格為：" & Price)
    End Sub
End Class
Public Class RaceBike
    Inherits Bicycle
    Private Speed As Integer
    Public Sub GetSpeed()
        GetData()
        Console.Write("輸入幾段變速:")
        Speed = Console.ReadLine
    End Sub
    Public Sub DispCarData()
        DispData()
        Console.WriteLine("此車為" & Speed & "段變速車")
    End Sub
End Class
