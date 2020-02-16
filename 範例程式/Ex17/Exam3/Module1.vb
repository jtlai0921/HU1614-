Imports System
Imports System.IO
Module Module1
    Sub Main(ByVal Args() As String)
        Dim name(2) As String
        Dim score(2) As Integer
        Dim objWriter As BinaryWriter
        Dim objReader As BinaryReader
        Dim objStream As FileStream
        Dim i As Integer
        Try
            objStream = New FileStream(Args(0), FileMode.Append, FileAccess.Write)
            objWriter = New BinaryWriter(objStream)
            For i = 0 To 2
                Console.Write("姓名>")
                name(i) = Console.ReadLine()
                Console.Write("成績>")
                score(i) = CInt(Console.ReadLine())
            Next
            For i = 0 To 2
                objWriter.Write(name(i))
                objWriter.Write(score(i))
            Next
            objWriter.Close()

            objStream = New FileStream(Args(0), FileMode.Open, FileAccess.Read)
            objReader = New BinaryReader(objStream)

            Do
                Console.WriteLine("{0,3}  {1,3}", objReader.ReadString(), objReader.ReadInt32())
            Loop While True
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