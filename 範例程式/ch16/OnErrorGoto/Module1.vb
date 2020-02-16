Module Module1
    Sub Main(ByVal Args() As String)
        On Error GoTo ErrHandle
        Console.WriteLine("命令列參數：" & Args(0))

ErrHandle:
        Console.WriteLine("錯誤代碼：" & Err.Number)
        Console.WriteLine("錯誤訊息：" & Err.Description)
        Console.Read()
    End Sub
End Module