'範例：繼承類別
'
Imports System
Class mycls '建立mycls類別
    Private str As String = "我愛Visual Basic"
    Protected str1 As String = "Visual Basic愛我"
    Public str2 As String = "大家都愛Visual Basic"
    Friend str3 As String = "Visual Basic好用"
    Protected Friend str4 As String = "Visual Basic好學"
End Class
Class clss '建立clss類別
    Inherits mycls '繼承自mycls類別
    Public str5 As String

    Public Sub ptr() '建立ptr方法
        str5 = str1
        Console.WriteLine(str5)
    End Sub
End Class

Module Module1
    Sub Main()
        Dim cls As mycls = New mycls '定義名為cls的mycls類別實體
        Dim cls1 As clss = New clss '定義名為cls1的clss類別實體

        cls1.ptr() '呼叫cls1的ptr方法
        Console.WriteLine(cls.str2)
        Console.WriteLine(cls.str3)
        Console.WriteLine(cls.str4)
        Console.ReadLine()
    End Sub
End Module
