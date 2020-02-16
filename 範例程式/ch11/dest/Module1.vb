'解構子的使用
Imports System
Imports System.IO

Class cls '定義一個名為cls的類別

    Private iname As String, ifile As String

    Sub New(ByVal name As String, ByVal file As String) '建立接受二個參數的建構子
        MyBase.New()
        iname = name
        ifile = file
    End Sub

    Sub destruct() '建立解構子
        Dim stream As New StreamWriter(ifile, True) '宣告一個名為stream的StreamWriter物件
        Dim str As String
        str = iname & " 物件結束"
        stream.WriteLine(str)
        stream.Close()
        Console.WriteLine("物件結束")
        Console.Read()
    End Sub
End Class

Module Module1

    Sub Main()
        Const cfile As String = "C:\temp\doc1.txt"

        Dim cls1 As New cls("程式產生的物件", cfile) '
        cls1 = Nothing '執行解構子
        System.GC.Collect() '強制使用資源回收的方式 

        Dim stream As New StreamWriter(cfile, True)
        Dim str As String
        str = "整個程式結束 "
        stream.WriteLine(str)
        stream.Close()
    End Sub

End Module