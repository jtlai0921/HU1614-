﻿Module Module1
    Sub Main()
        Dim JaggedArray(3)
        Dim i As Integer
        Dim inArray As Char
        JaggedArray(0) = New Char() {"J", "u", "s", "t"}
        JaggedArray(1) = New Char() {"m", "o", "m", "o", "r"}
        JaggedArray(2) = New Char() {"J", "K"}
        JaggedArray(3) = New Char() {"J", "o", "e", ""}
        For i = 0 To JaggedArray.Length - 1
            Console.WriteLine("JaggedArray(" & i & ") 陣列長度：" & JaggedArray(i).Length)
            Console.Write("JaggedArray(" & i & ") 陣列內容：")
            For Each inArray In JaggedArray(i)
                Console.Write(inArray)
            Next
            Console.WriteLine()
        Next
        Console.Read() '暫停
    End Sub
End Module
