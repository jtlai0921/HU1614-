Module Module1
    Class CustomException
        Inherits ApplicationException
        Dim message1, message2 As String
        Sub New(ByVal message1 As String, ByVal message2 As String)
            Me.message1 = message1
            Me.message2 = message2
        End Sub
        Overrides ReadOnly Property Message() As String
            Get
                Return "代碼：" & message1 & " 訊息：" & message2
            End Get
        End Property
    End Class
    Sub Main()
        Try
            Throw New CustomException("1", "自訂錯誤訊息")
        Catch e As CustomException
            Console.WriteLine(e.Message)
        End Try
        Console.Read()
    End Sub
End Module