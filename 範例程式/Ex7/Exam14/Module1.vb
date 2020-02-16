Module Module1

    Sub Main()
        Dim code, word As Integer
        For code = 33 To 126
            Console.Write(Chr(code) & "  ")
            word += 1
            '** 進行換行
            If word = 15 Then
                Console.WriteLine()
                word = 0
            End If
        Next
        Console.Read()
    End Sub

End Module
