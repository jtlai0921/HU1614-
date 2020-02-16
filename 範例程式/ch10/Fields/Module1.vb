'範例：設定Fields
'
Imports System
Class name
    Public strName As String  '建立Public的strName欄位
    Public Shared strFavorites As String '建立Public Shared的strFavorites欄位
End Class

Module Module1

    Sub Main()
        Dim MyName As New name, YourName As New name    '建立MyName及YourName類別
        MyName.strName = "David" '指定MyName的strName欄位值
        name.strFavorites = "唱歌、上網" '指定MyName的strFavorites欄位值
        Console.WriteLine("我的英文名字是： " & MyName.strName)
        Console.WriteLine("我的興趣是： " & name.strFavorites)
        YourName.strName = "Eric" '指定YouName的strName欄位值
        name.strFavorites = "打球、跳舞" '指定YourName的strFavorites欄位值   
        Console.WriteLine("您的英文名字是： " & YourName.strName)
        Console.WriteLine("您的興趣是： " & name.strFavorites)
        Console.ReadLine()
    End Sub

End Module
