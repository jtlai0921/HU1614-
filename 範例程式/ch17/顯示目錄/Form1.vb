Imports System.IO
Public Class 顯示目錄
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用DirectoryInfo類別顯示目錄清單
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear() '清除ListBox1控制項內的項目
        Dim dir1 As New DirectoryInfo(TextBox1.Text)
        If Not dir1.Exists Then '判斷輸入的目錄名稱是否存在
            MsgBox("您所輸入的目錄名稱並不存在，請重新輸入!!")
            End
        End If
        Dim dir2 As DirectoryInfo()
        dir2 = dir1.GetDirectories '取得系統所傳回的子目錄清單
        Dim subdir As DirectoryInfo
        For Each subdir In dir2
            ListBox1.Items.Add(subdir.Name) '將所取得的子目錄清單逐一加至ListBox1控制項中
        Next
    End Sub
End Class