Public Class Form1
    Private Ans(2) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyAns(2), i, j, ACount, Bcount As Integer
        Dim TmpAns As String
        MyAns(0) = NumericUpDown1.Value
        MyAns(1) = NumericUpDown2.Value
        MyAns(2) = NumericUpDown3.Value
        TmpAns = MyAns(0) & MyAns(1) & MyAns(2)

        '**檢查使用者的猜測情況
        For i = 0 To 2
            For j = 0 To 2

                '**如果數字與位置都相同，則為A，並跳出第二層迴圈
                If (MyAns(i) = Ans(j)) And (i = j) Then
                    ACount += 1
                    Exit For
                    '**如果數字相同但位置不同，則為B，並跳出第二層迴圈
                ElseIf MyAns(i) = Ans(j) Then
                    Bcount += 1
                    Exit For
                End If
            Next
        Next

        TextBox1.Text += TmpAns & " → " & ACount & "A, " & Bcount & " B" & vbNewLine

        '**判斷是否完全猜中
        If ACount = 3 Then
            Button1.Enabled = False
            MessageBox.Show("恭喜您猜中了！", "過關")
        End If
    End Sub

    Private Sub Form1_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        GetAns()
    End Sub

    Private Sub Button2_Click(sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        GetAns()
        Button1.Enabled = True
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show(Ans(0) & Ans(1) & Ans(2), "哦哦！您偷看答案！")
    End Sub

    Private Sub GetAns()
        Dim Rnd As New Random()
        Dim i As Integer

        '**第一個數字需介於0到9之間
        Ans(0) = Rnd.Next(1, 10)
        For i = 1 To 2
            Ans(i) = Rnd.Next(0, 10)
        Next

        '**檢查三個數值是否有重複的情況，若有則重新取亂數值
        While Ans(0) = Ans(1)
            Ans(1) = Rnd.Next(0, 10)
        End While

        While Ans(0) = Ans(2) Or Ans(1) = Ans(2)
            Ans(2) = Rnd.Next(0, 10)
        End While
    End Sub

End Class
