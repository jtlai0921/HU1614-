'範例：建構子實作
'
Imports System

Namespace myname '定義一個名為myname的命名空間

    Class animal '定義一個名為animal類別
        Private hand As Integer, leg As Integer
        Private kind As String

        Sub New() '建立不接受參數的建構子
            MyBase.New()

            leg = 4
            hand = 0
            kind = "animal"
        End Sub

        Sub New(ByRef x As Integer, ByRef y As Integer, ByVal z As String) '建立接受三個參數的建構子
            MyBase.New()
            leg = y
            hand = x
            kind = z
        End Sub

        Public Sub saysomething() '建立一個名為saysomething類別函式
            If hand = 0 Then
                Console.WriteLine("您建立了一個具有 " & leg & "隻腳的" & kind)
            Else
                Console.WriteLine("您建立了一個具有 " & hand & "隻手" & leg & "隻腳的" & kind)
            End If

        End Sub
    End Class


End Namespace

Module Module1

    Sub Main()
        Dim hand As Integer, leg As Integer, name As String
        Dim animal As New myname.animal '使用建構子(無參數)

        Console.WriteLine("您想建立什麼樣的物件")
        Console.Write("幾隻手===>")
        hand = CInt(Console.ReadLine())
        Console.Write("幾隻腳===>")
        leg = CInt(Console.ReadLine())
        Console.Write("什麼名稱=>")
        name = Console.ReadLine()

        Dim selfdef As New myname.animal(hand, leg, name) '使用建構子(三個參數)
        selfdef.saysomething()
        Console.ReadLine()
    End Sub

End Module