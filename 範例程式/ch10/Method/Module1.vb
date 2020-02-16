Class name
    Private strName As String '建立strName欄位
    Public strFavorites As String '建立strFavorites欄位
    Public Sub setName(ByVal name As String) '使用程序來建立setName方法
        strName = name
    End Sub
    Public Sub setFavorites(ByVal favorites As String) '使用程序來建立setFavorites方法
        strFavorites = favorites
    End Sub
    Public Function getName() As String '使用函數來建立getName方法
        getName = strName
    End Function
    Public Function getFavorites() As String '使用函數來建立getFavorites方法
        getFavorites = strFavorites
    End Function
End Class

Module Module1

    Sub Main()
        Dim MyName As New name, YourName As New name     '建立MyName及YourName類別
        MyName.setName("David") '使用setName方法取得欄位值
        MyName.setFavorites("唱歌、上網") '使用setFavorites方法取得欄位值
        YourName.setName("Eric") '使用setName方法取得欄位值
        YourName.setFavorites("打球、跳舞") '使用setFavorites方法取得欄位值
        Console.WriteLine("我的英文名字是： " & MyName.getName) '使用getName方法取得欄位值
        Console.WriteLine("我的興趣是： " & MyName.getFavorites) '使用getFavorites方法取得欄位值
        Console.WriteLine("您的英文名字是： " & YourName.getName) '使用getName方法取得欄位值
        Console.WriteLine("您的興趣是： " & YourName.getFavorites) '使用getFavorites方法取得欄位值
        Console.ReadLine()
    End Sub

End Module
