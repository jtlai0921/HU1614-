'範例：例外類別的應用
'
Module Module1
    Sub Divide(ByVal x As Integer, ByVal y As Byte) '建立Divide程序來截取例外狀況
        Try
            Console.WriteLine(x \ y)
        Catch e1 As Exception '當發生例外狀況時顯示相關訊息
            Console.WriteLine("例外類型：" & e1.GetType.ToString)
            Console.WriteLine("錯誤訊息：" & e1.Message)
            Console.WriteLine("程式或物件名稱：" & e1.Source)
            Console.WriteLine("產生錯誤的模組：" & e1.TargetSite.Name)
        End Try
    End Sub

    Sub Main()
        Divide(33, 0) '呼叫Divide程序
        Console.ReadLine()
    End Sub
End Module