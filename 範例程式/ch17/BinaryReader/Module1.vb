Imports System
Imports System.IO
Module Module1
    Sub Main(ByVal Args() As String)
        Dim objReader As IO.BinaryReader
        Dim objStream As FileStream
        Dim count As Integer
        Try
            objStream = New FileStream(Args(0), FileMode.Open, FileAccess.Read)
            objReader = New IO.BinaryReader(objStream)
            Do
                '** 以位元組為單位讀取檔案內容，並以16進位方式顯示
                Console.Write("{0,2:X} ", objReader.ReadByte)
                count += 1
                '** 換行
                If count = 10 Then
                    Console.WriteLine()
                    count = 0
                End If
            Loop While True
            ObjReader.Close()
        Catch e As IndexOutOfRangeException
            Console.WriteLine("沒有指定檔案")
        Catch e As EndOfStreamException
            Console.WriteLine("檔案讀取完畢")
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
    End Sub
End Module
