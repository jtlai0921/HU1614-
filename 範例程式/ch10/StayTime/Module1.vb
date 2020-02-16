'範例：計算停留時間
'
Module Module1
    Sub Main()
        Dim LoginTime, LogoffTime, a As DateTime
        Dim StayTime As New TimeSpan()
        Dim YesNo As String
        Dim Loop1, Loop2 As Integer
        LoginTime = DateTime.Now '取得目前登入的時間
        Console.WriteLine("登入時間：" & LoginTime)
        Do
            Console.WriteLine("檔案下載中！請稍待！")
            For Loop1 = 0 To 200000
                If Loop1 Mod 8000 = 0 Then
                    For Loop2 = 0 To 6000000
                    Next
                    Console.Write(Chr(16))
                End If
            Next
            Console.Write(Chr(10) & "下載完成！是否繼續下載？(Y/N)")
            YesNo = Console.ReadLine '取得所輸入的值
            If YesNo.ToLower = "n" Then '假如輸入為「n」時，則顯示登出及停留時間
                LogoffTime = DateTime.Now
                Console.WriteLine("登出時間：" & LogoffTime)
                StayTime = LogoffTime.Subtract(LoginTime)
                Console.WriteLine("您在此停留了 " & StayTime.Hours _
                & "小時" & StayTime.Minutes & "分鐘" _
                & StayTime.Seconds & "秒")
            End If
        Loop Until YesNo.ToLower = "n"
        Console.ReadLine()
    End Sub
End Module