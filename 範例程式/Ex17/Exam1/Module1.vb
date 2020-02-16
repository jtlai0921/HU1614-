Imports System.IO
Module Module1

    Sub Main()
        Dim filewriter As New StreamWriter("C:\temp\33.txt")
        filewriter.WriteLine("鳳凰臺上鳳凰遊，鳳去臺空江自流")
        filewriter.WriteLine("吳宮花草埋幽徑，晉代衣冠成古邱")
        filewriter.WriteLine("三山半落青又外，二水中分白鷺洲")
        filewriter.WriteLine("總為浮雲能蔽日，長安不見使人愁")
        filewriter.Close()
    End Sub

End Module
