Imports System
Imports System.IO
Module Module1
    Sub Main(ByVal Args() As String)
        Dim objReader As BinaryReader
        Dim objStream As FileStream
        Try
            objStream = New FileStream(Args(0), FileMode.Open, FileAccess.Read)
            objReader = New BinaryReader(objStream)
            Console.WriteLine(objReader.ReadString())
            Console.WriteLine(objReader.ReadInt32())
            objReader.Close()
        Catch e As IndexOutOfRangeException
            Console.WriteLine("沒有指定檔案")
        Catch e As EndOfStreamException
            Console.WriteLine("檔案讀取完畢")
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
    End Sub
End Module