Module Module1
    Class foo
        Public strData As String
        Public intData As Integer
    End Class

    Sub Main()
        Dim Obj1 As New foo
        obj1.strData = "字串資料設定"
        obj1.intData = 100
        Console.WriteLine("foo 類別的 strData 成員：" & obj1.strData)
        Console.WriteLine("foo 類別的 intData 成員：" & Obj1.intData)
        Console.Read()
    End Sub
End Module