'範例：使用FirstClass1類別
'
Imports FirstClass1 '匯入FirstCalss1類別
Module Module1
    Sub Main()
        Dim Class1(9) As Double '宣告陣列元素為10的Class1陣列
        Dim Student As New FirstClass1.MyClass1   '宣告MyClass1的物件Student
        Student.GetScore(Class1) '使用GetScore方法來取得學生的成績
        Console.ReadLine()
    End Sub
End Module