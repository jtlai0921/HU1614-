Imports System.IO
Public Class 取得檔案資訊
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用File類別來取得檔案資訊
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = InputBox("請輸入檔案所在的位置：")
        If Not TextBox6.Text = "" Then
            TextBox1.Text = File.Exists(TextBox6.Text)            '顯示檔案是否存在 
            TextBox2.Text = File.GetAttributes(TextBox6.Text)     '取得檔案屬性
            TextBox3.Text = File.GetCreationTime(TextBox6.Text)   '取得檔案建立日期
            TextBox4.Text = File.GetLastAccessTime(TextBox6.Text) '取得檔案存取日期
            TextBox5.Text = File.GetLastWriteTime(TextBox6.Text)  '取得檔案修改日期
        Else
            MsgBox("警告！！您輸入的是空字串：")
        End If
    End Sub
End Class