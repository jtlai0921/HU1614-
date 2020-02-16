Module Module1
    Sub Main(ByVal Args() As String)
        Dim intX, intY, intZ As Integer

        On Error GoTo ErrHandle
        Console.Write("請輸入被除數：")
        intX = CInt(Console.ReadLine())
        Console.Write("請輸入除數：")
        intY = CInt(Console.ReadLine())
        intZ = intX \ intY

ErrHandle:
        Select Case Err.Number
            Case 6   '** 溢位錯誤代碼
                Console.WriteLine("超出整數可存放的範圍！")
            Case 11  '** 除零錯誤代碼
                Console.WriteLine("除數不得為 0！")
        End Select
        Console.Read()
    End Sub
End Module