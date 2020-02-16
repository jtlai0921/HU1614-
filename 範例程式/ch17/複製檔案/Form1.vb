Imports System.IO
Public Class 複製檔案
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用FileInfo類別來複製檔案
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFile As New FileInfo(TextBox1.Text)
        If myFile.Exists Then '假如檔案存在時
            myFile.CopyTo(TextBox2.Text, True) '將資料複製到指定的目錄，並指定進行覆寫
        Else
            MsgBox("您所指定的來源檔案不存在!!無法進行複製")
        End If

    End Sub
End Class