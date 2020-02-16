'範例：重寫程式碼
'
Imports System
Public MustInherit Class anal '宣告ana1類別必須被繼承
    Dim a_str As String = "動物會移動"
    Public MustOverride Sub voice() '宣告必須被重寫的類別函式
    Public Overridable Sub action() '宣告可以被重寫的類別函式
        Console.WriteLine(a_str)
    End Sub
End Class

Class bird '建立bird類別
    Inherits anal '繼承自ana1類別
    Public b_str1 As String = "鳥兒啾啾叫"
    Overrides Sub voice() '重寫voice函式
        Console.WriteLine(b_str1)
    End Sub

End Class

Class dog '建立dog類別
    Inherits anal '繼承自ana1類別
    Public d_str As String = "狗兒汪汪叫"
    Public d_str1 As String = "狗兒會跑喔"
    Overrides Sub voice() '重寫voice函式
        Console.WriteLine(d_str)
    End Sub

    Overrides Sub action() '重寫action函式
        Console.WriteLine(d_str1)
    End Sub

End Class

Module Module1

    Sub Main()
        Dim bd As bird = New bird '宣告名為bd的bird類別
        Dim dg As dog = New dog '宣告名為dg的dog類別
        bd.voice()
        bd.action()
        dg.voice()
        dg.action()
        Console.ReadLine()
    End Sub

End Module
