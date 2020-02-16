'範例：在同一份程式中使用類別
'
Imports System
Class Book '建立Book類別
    Dim name As String '建立name欄位
    Dim price As Integer '建立price欄位
    Property BookName() As String '建立BookName屬性
        Set(ByVal Value As String) '設定BookName屬性值
            name = Value
        End Set
        Get '取得BookName屬性值
            BookName = name
        End Get
    End Property
    Property BookPrice() As Integer '建立BookPrice屬性
        Set(ByVal Value As Integer) '設定BookPrice屬性值
            price = Value
        End Set
        Get '取得BookPrice屬性值
            BookPrice = price
        End Get
    End Property
    Public Function discount() As Double '建立discount方法
        discount = price * 0.85
    End Function
End Class
Module Module1
    Sub Main()
        Dim PcBook As New Book '建立PcBook類別
        PcBook.BookName = "Visual Basic" '指定BookName屬性值
        PcBook.BookPrice = 500 '指定Bookprice屬性值
        Console.WriteLine("書名：" & PcBook.BookName)
        Console.WriteLine("售價：" & PcBook.BookPrice)
        Console.WriteLine("打85折後的售價為：" & PcBook.discount)
        Console.ReadLine()
    End Sub
End Module
