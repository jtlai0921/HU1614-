Imports System.IO
Public Class 記事本
    '-------------------------------------------------------------------------------------------------
    ' 功能：建立模擬記事本程式
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = "" '清除內容
        TextBox1.Text = "" '清除檔案名稱
        TextBox1.Focus() '將游標移至「檔案名稱」文字方塊中以便輸入檔案名稱

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then '判斷是否輸入檔案名稱
            MsgBox("請先輸入檔案名稱!!")
            TextBox1.Focus() '將游標移至「檔案名稱」文字方塊中以便輸入檔案名稱
        Else
            Dim myFile As New FileInfo(TextBox1.Text)
            Dim fs As FileStream = myFile.Create '建立所指定的檔案名稱
            Dim ds As New StreamWriter(fs, System.Text.Encoding.Default)
            ds.Write(TextBox2.Text) '將TextBox2控制項的內容全部寫入資料流中
            ds.Close()
            fs.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim myFile As New FileInfo(TextBox1.Text)
            Dim fs As FileStream
            fs = myFile.Open(FileMode.Open) '將指定的檔案名稱開啟
            Dim ds As New StreamReader(fs, System.Text.Encoding.Default)
            If fs.Length > 0 Then '判斷檔案的內容是否為空的
                TextBox2.Text = ""
                Do
                    TextBox2.Text = TextBox2.Text & ds.ReadLine '將檔案內容在TextBox2控制項中顯示
                Loop While ds.Peek <> -1 '使用peek來讀取檔案內容
            End If
            TextBox2.Focus()
            ds.Close()
            fs.Close()
        Catch err1 As Exception '截取例外狀況
            MsgBox(err1.Message) '顯示錯誤訊息
            TextBox1.Focus()
        End Try

    End Sub
End Class