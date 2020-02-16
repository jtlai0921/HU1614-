Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Res1, Dis1, Tax, Res2 As Integer
        Dim TaxRate As Single
        'Res1 : 表綜所稅淨額  Taxrate：表稅率  Dis1：表累進差額  Tax：表稅金  Res2:表應繳稅金

        Res1 = TextBox1.Text
        Select Case Res1
            Case Is <= 370000
                TaxRate = 0.06
                Dis1 = 0
            Case 370001 To 990000
                TaxRate = 0.13
                Dis1 = 25900
            Case 990001 To 1980000
                TaxRate = 0.21
                Dis1 = 105100
            Case 1980001 To 3720000
                TaxRate = -0.3
                Dis1 = 283300
            Case Is >= 3720001
                TaxRate = 0.4
                Dis1 = 655300
        End Select
        Tax = Res1 * TaxRate  '所得稅-稅率
        Res2 = Tax - Dis1 '稅金-累進差額
        TextBox2.Text = "您今年的綜所稅淨額為：" & Res1 & "元" & vbNewLine
        TextBox2.Text &= "稅率為：" & TaxRate.ToString & vbNewLine
        TextBox2.Text &= "稅金為：" & Tax & "元" & vbNewLine
        TextBox2.Text &= "累進差額為：" & Dis1 & "元" & vbNewLine
        TextBox2.Text &= "您今年應繳金額為：" & Res2 & "元" & vbNewLine
    End Sub
End Class
