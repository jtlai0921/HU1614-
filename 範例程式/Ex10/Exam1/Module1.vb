Public Class Exam1
    Public Name As String
    Public Age As Integer
End Class
Module Module1
    Sub main()
        Dim E1 As New Exam1
        E1.Name = "劉超仁"
        E1.Age = "18"
        Console.WriteLine("姓名為：" & E1.Name)
        Console.WriteLine("年齡為：" & E1.Age.ToString)
        Console.ReadLine()
    End Sub
End Module