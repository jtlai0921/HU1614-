'範例：建立類別庫類型之專案
'
Public Class MyClass1 '建立MyClass1類別
    Private Total As Double '建立Total欄位
    Public Function Salary(ByVal Days As Double, ByVal OverTime As Double) As Double '建立Salary方法
        Total = Days * 1000 + OverTime * 1000 / 3
        Return Total
    End Function
    Public Sub GetScore(ByRef Score() As Double) '建立GetScore方法
        Dim temp As Integer = 0
        For temp = 0 To UBound(Score)
            Console.Write("請輸入第 " & temp + 1 & "位同學的成績：")
            Score(temp) = Console.ReadLine()
            Total += Score(temp)
        Next
        Console.WriteLine("全班總成績：" & Total)
        Console.WriteLine("全班總平均：" & Total / (UBound(Score) + 1))
    End Sub
End Class
