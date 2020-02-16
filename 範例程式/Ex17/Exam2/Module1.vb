Imports System
Imports System.IO
Module Module1
    Sub Main(ByVal Args() As String)
        Dim student(9, 1) As String
        Dim i As Integer
        Dim objWriter As StreamWriter
        Try
            objWriter = New StreamWriter(Args(0), True)
            For i = 0 To 9
                Console.Write("姓名>")
                student(i, 0) = Console.ReadLine()
                Console.Write("成績>")
                student(i, 1) = Console.ReadLine()
            Next
            For i = 0 To 9
                objWriter.WriteLine("{0,3}  {1,3}", student(i, 0), student(i, 1))
            Next
            objWriter.Close()
        Catch e As IndexOutOfRangeException
            Console.WriteLine("沒有指定檔案")
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
    End Sub
End Module