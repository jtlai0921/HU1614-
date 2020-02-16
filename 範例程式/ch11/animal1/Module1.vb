'範例：使用Me、Mybase及Myclass
'
Imports System

Public MustInherit Class anal '定義一個必須被繼承的ana1類別
    Dim a_str As String = "動物會移動"
    Public MustOverride Sub voice() '宣告必須被重寫的類別函式
    Public Overridable Sub action() '宣告可以被重寫的類別函式
        Console.WriteLine(a_str)
    End Sub

    Public Sub usemyclass() '定義usemyclass方法
        MyClass.action()
    End Sub

    Public Sub useaction() '定義useaction方法
        action()
    End Sub

End Class

Class bird '定義bird類別
    Inherits anal '繼承自ana1
    Public b_str1 As String = "鳥兒啾啾叫"
    Overrides Sub voice()
        Console.WriteLine(b_str1)
    End Sub

    Public Sub useme()
        Me.voice() '呼叫原來的voice方法
    End Sub

    Public Sub usemybase()
        MyBase.action() '使用MyBase呼叫父類別的action方法
    End Sub

End Class

Class dog '定義dos類別
    Inherits anal '繼承自ana1
    Public d_str As String = "狗兒汪汪叫"
    Public d_str1 As String = "狗兒會跑喔"
    Overrides Sub voice()
        Console.WriteLine(d_str)
    End Sub

    Overrides Sub action()
        Console.WriteLine(d_str1)
    End Sub

    Public Sub useme()
        Me.voice()

    End Sub

    Public Sub usemybase()
        MyBase.action()
    End Sub

    Public Sub useclass()
        MyClass.action()
    End Sub


End Class

Module Module1

    Sub Main()
        Dim bd As bird = New bird '定義名為bd的bird類別
        Dim dg As dog = New dog '定義名為dg的dog類別

        Console.WriteLine("以下是bird類別")
        Console.Write("使用me------>")
        bd.useme()
        Console.Write("使用mybase-->")
        bd.usemybase()
        Console.Write("使用myclass->")
        bd.usemyclass()

        Console.WriteLine("以下是dog類別")
        Console.Write("使用me------>")
        dg.useme()
        Console.Write("使用mybase-->")
        dg.usemybase()
        Console.Write("使用myclass->")
        dg.useclass()
        Console.Write("使用dog父類別 ")
        dg.usemyclass()
        Console.Write("使用dog useaction ")
        dg.useaction()
        Console.ReadLine()
    End Sub

End Module