﻿Module Module1

    Sub Main()
        Dim intA As Integer = 10
        Dim intB As Integer = 3
        Dim input As Char
        Console.Write("請輸入運算元（例如+ - * /）：")
        input = Chr(Console.Read())
        If input = "+" Then
            Console.WriteLine("10 + 3 = " & intA + intB)
        ElseIf input = "-" Then
            Console.WriteLine("10 - 3 = " & intA - intB)
        ElseIf input = "*" Then
            Console.WriteLine("10 * 3 = " & intA * intB)
        ElseIf input = "/" Then
            Console.WriteLine("10 / 3 = " & intA / intB)
        Else
            Console.WriteLine("未知的運算元！")
        End If
        Console.ReadLine()
        Console.Read()
    End Sub

End Module
