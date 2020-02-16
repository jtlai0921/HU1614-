'用Property來存取Fields的值
'
Imports System
Class AccountData
    Private UserName As String '建立UserName欄位
    Private Password As String '建立Password欄位
    Property Id() As String '建立Id屬性
        Set(ByVal Value As String) '設定Id屬性值
            UserName = Value
        End Set
        Get  '取得Id屬性值
            Id = UserName
        End Get
    End Property
    Property Pwd() As String '建立Pwd屬性
        Set(ByVal Value As String) '設定Pwd屬性值
            Password = Value
        End Set
        Get '取得Pwd屬性值
            Pwd = Password
        End Get
    End Property
End Class
Module Module1
    Sub Main()
        Dim Account As New AccountData   '建立Account類別
        Account.Id = "David" '設定Id屬性值
        Account.Pwd = "jiey4361" '設定Pwd屬性值
        Console.WriteLine(Account.Id & " 您好！")
        Console.WriteLine("您的帳號是： " & Account.Id)
        Console.WriteLine("您的密碼是： " & Account.Pwd)
        Console.WriteLine("請牢記您的帳號與密碼！！")
        Console.ReadLine()
    End Sub
End Module
