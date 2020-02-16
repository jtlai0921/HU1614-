Imports System.IO
Public Class 路徑資訊
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用Path類別顯示所選取檔案的完整路徑
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim S1 As String
        S1 = ListBox1.SelectedItem '將所選取的檔案名稱傳至變數S1
        TextBox2.Text = Path.GetFullPath(TextBox1.Text) & "\" & S1 '將選取的檔案名稱目前的完整目錄名稱顯示出來
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then '判斷是否按下Enter鍵
            ListBox1.Items.Clear() '將ListBox1控制項內的項目清除
            Dim dir1 As New DirectoryInfo(TextBox1.Text)
            If Not dir1.Exists Then '判斷輸入的目錄名稱是否存在
                MsgBox("您所輸入的目錄名稱並不存在!!")
                Return
            End If
            Dim FileList1() As FileInfo
            FileList1 = dir1.GetFiles("*.*") '取得所有的檔案名稱
            Dim SubFile As FileInfo
            For Each SubFile In FileList1
                ListBox1.Items.Add(SubFile.Name) '將取得的所有檔案名稱逐一加至ListBox1控制項中
            Next
        End If
    End Sub
End Class