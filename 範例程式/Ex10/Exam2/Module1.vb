Public Class Exam2
    Public Name As String
    Public Age As Integer
    Public Function Change_Age() As Integer
        Age = 20
        Change_Age = Age
    End Function
    Public Function Change_name() As String
        Name = "丁大同"
        Change_name = Name
    End Function
End Class
Module module1
    Sub main()
        Dim MyClass1 As New Exam2
        MyClass1.Name = "劉小同"
        MyClass1.Age = 18
        Console.WriteLine("原本的姓名：" & MyClass1.Name)
        Console.WriteLine("原本的年齡：" & MyClass1.Age)
        Console.WriteLine("修改後的姓名：" & MyClass1.Change_name)
        Console.WriteLine("修改後的姓名：" & MyClass1.Change_Age)
        Console.ReadLine()
    End Sub
End Module

