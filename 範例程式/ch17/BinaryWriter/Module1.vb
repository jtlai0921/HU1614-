Imports System
Imports System.IO
Module Module1
    Sub Main(ByVal Args() As String)
        Dim objWriter As IO.BinaryWriter
        Dim objStream As FileStream
        'Dim input As String
        'Dim count As Integer
        Try
            objStream = New FileStream(Args(0), FileMode.Append, FileAccess.Write)
            objWriter = New IO.BinaryWriter(objStream)
            '* 寫入字串
            objWriter.Write("字串")
            '* 寫入數值
            objWriter.Write(640526)
            ObjWriter.Close()
        Catch e As IndexOutOfRangeException
            Console.WriteLine("沒有指定檔案")
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
    End Sub
End Module