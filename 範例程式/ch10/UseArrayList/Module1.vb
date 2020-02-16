'範例：ArrayList類別的例子
'
Module Module1
    Sub Main()
        Dim Tmp As Object
        Dim i, NameCount As Integer
        Dim UserName As New ArrayList()
        Console.Write("請輸入總人數：")
        NameCount = Console.ReadLine '取得所輸入的人數
        For i = 0 To NameCount - 1 '依次輸入每一位的姓名
            Console.Write("第" & i + 1 & "位姓名：")
            Tmp = Console.ReadLine
            UserName.Add(Tmp)
        Next
        Console.Write("請輸入您要尋找的名字：")
        Tmp = Console.ReadLine '取得所輸入的名字
        If UserName.IndexOf(Tmp) < 0 Then '若超過陣列索引值則表示找不到符合的姓名
            Console.WriteLine("找不到您所輸入的名字！")
        Else
            Console.WriteLine("您所尋找的名字在陣列中的第" & UserName.IndexOf(Tmp) & "位！")
        End If
        Console.WriteLine("排序後的陣列內容為：")
        UserName.Sort() '使用Sort方法將陣列元素進行排序
        For i = 0 To UserName.Count - 1 '將排序後的陣列元素依序顯示在螢幕上
            Console.WriteLine(UserName.Item(i))
        Next
        Console.WriteLine("在陣列第1位加入一個使用者David後，陣列的內容為：")
        UserName.Insert(1, "David") '插入一個元素
        For i = 0 To UserName.Count - 1 '重新將陣列元素顯示在螢幕上
            Console.WriteLine(UserName.Item(i))
        Next
        Console.ReadLine()
    End Sub
End Module