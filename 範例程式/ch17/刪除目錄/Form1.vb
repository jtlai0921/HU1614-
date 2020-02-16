Imports System.IO
Public Class 刪除目錄

    '-------------------------------------------------------------------------------------------------
    ' 功能：使用DirectoryInfo類別刪除目錄
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ParDir As New DirectoryInfo(TextBox1.Text)
        If Not ParDir.Exists Then '判斷輸入的目錄名稱是否存在
            MsgBox("您輸入的目錄名稱並不存在!!無法刪除目錄")
            End
        Else
            ParDir.Delete() '將指定的目錄刪除
        End If
    End Sub
End Class