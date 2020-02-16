'使用Shared Method
'
Imports System
Class name '建立name類別
    Public Shared Sub SayHi(ByVal name As String) '建立Shared的SayHi方法
        Console.WriteLine("Hi " & name & "，來自Shared Method 的問候")
    End Sub
    Public Sub Hi(ByVal name As String) '建立Hi方法
        Console.WriteLine("Hi " & name & "，來自一般 Method 的問候")
    End Sub
End Class

Module Module1

    Sub Main()
        Dim MyName As New name '建立MyName類別
        MyName.Hi("Eric") '使用Hi方法將訊息顯示在螢幕上
        name.SayHi("Dvaid") '使用Shared的SayHi方法將訊息顯示在螢幕上
        Console.ReadLine()
    End Sub

End Module