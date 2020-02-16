'範例：事件的建立及觸發
'
Public Class Class1 '建立Class1類別
    Public Event RunAway() '定義RunAway事件
    Public Sub Steal() '建立Stea1方法
        Console.WriteLine("正當小偷專心在偷車時")
    End Sub
    Public Sub Hear(ByVal word As String) '建立Hear方法
        Console.WriteLine("他聽到了" & word & "的聲音")
        RaiseEvent RunAway() '觸發RunAway事件
    End Sub
End Class
Module Module1
    WithEvents Thief As New Class1 '建立事件的實體物件Thief
    Private Sub Thief_Run() Handles Thief.RunAway '建立處理RunAway事件程序
        Console.WriteLine("他知道警察發現它了，於是他拔腿就跑")
    End Sub
    Sub Main()
        Thief.Steal() '使用Stea1方法
        Thief.Hear("嗶嗶嗶") '使用Hear方法
        Console.ReadLine()
    End Sub
End Module