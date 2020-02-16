Imports System.IO
Public Class 顯示檔案
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用DirectoryInfo類別顯示檔案清單
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear() '清除ListBox1控制項內的項目
        Dim dir1 As New DirectoryInfo(TextBox1.Text)
        If Not dir1.Exists Then '判斷輸入的目錄名稱是否存在
            MsgBox("您所輸入的目錄名稱並不存在，請重新輸入!!")
            End
        End If
        Dim FileList1() As FileInfo
        FileList1 = dir1.GetFiles("*.*") '取得所有的檔案
        Dim SubFile As FileInfo
        For Each SubFile In FileList1 '將取得的所有檔案名稱加至ListBox1控制項中
            ListBox1.Items.Add(SubFile.Name)
        Next
    End Sub
End Class