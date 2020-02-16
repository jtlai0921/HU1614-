Module Module1

    Sub Main()
        Dim Day, Height As Integer
        While (True)
            Day += 1
            Height += 5
            If Height < 15 Then
                Height -= 2
            Else
                Exit While
            End If
        End While
        Console.WriteLine("蝸牛共花 " & Day & " 天爬上牆頭。")
        Console.Read()
    End Sub

End Module
