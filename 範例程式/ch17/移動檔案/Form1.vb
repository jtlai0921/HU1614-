Imports System.IO
Public Class 移動檔案
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用FileInfo類別來移動檔案
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFile As New FileInfo(TextBox1.Text)
        If myFile.Exists Then '假如檔案存在時
            myFile.MoveTo(TextBox2.Text) '將資料移至指定的目錄
        Else
            MsgBox("您所指定的來源檔案不存在!!無法移動檔案")
        End If

    End Sub
End Class