'範例：運用可視關係
'
Class mycls '建立mycls類別
    Private str As String = "我愛Visual Basic"
    Protected str1 As String = "Visual Basic愛我"
    Public str2 As String = "大家都愛Visual Basic"
    Friend str3 As String = "Visual Basic好用"
    Protected Friend str4 As String = "Visual Basic好學"
End Class

Module Module1

    Sub Main()
        Dim cls As mycls = New mycls '宣告mycls類別的實體物件cls
        Console.WriteLine(cls.str)
        Console.WriteLine(cls.str1)
        Console.WriteLine(cls.str2)
        Console.WriteLine(cls.str3)
        Console.WriteLine(cls.str4)
        Console.ReadLine()
    End Sub

End Module
