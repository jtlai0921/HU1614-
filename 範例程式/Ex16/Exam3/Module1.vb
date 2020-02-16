Module Module1
    Class PortException
        Inherits ApplicationException
        Private str_message As String
        Sub New()
            str_message = "連接埠已佔用"
        End Sub
        Sub New(ByVal message As String)
            str_message = message
        End Sub
        Overrides ReadOnly Property Message() As String
            Get
                Return str_message
            End Get
        End Property
    End Class
    Sub Main()
        Dim Port() As Integer = {0, 1, 0, 1, 0, 1, 1, 1, 0, 1}
        Dim i As Integer
        For i = 0 To Port.Length - 1
            Try
                If Port(i) = 1 Then
                    Throw New PortException
                End If
            Catch e As PortException
                Console.WriteLine(e.Message & "：" & i)
            End Try
        Next
        Console.Read()
    End Sub
End Module
