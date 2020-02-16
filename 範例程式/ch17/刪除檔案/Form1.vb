Imports System.IO
Public Class 刪除檔案
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用FileInfo類別來刪除檔案
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFile As New FileInfo(TextBox1.Text)
        If myFile.Exists Then '假如檔案存在時
            myFile.Delete() '使用Delete方法將檔案刪除
        Else
            MsgBox("您所指定的來源檔案不存在!!無法刪除檔案")
        End If

    End Sub
End Class