Imports System.IO
Public Class 建立目錄
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用DirectoryInfo類別建立目錄
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ParDir As New DirectoryInfo(TextBox1.Text)
        If Not ParDir.Exists Then '判斷輸入的目錄名稱是否存在
            MsgBox("您輸入的目錄名稱並不存在!!無法建立子目錄")
            End
        Else
            ParDir.CreateSubdirectory(TextBox2.Text) '建立所指定的子目錄
        End If
    End Sub
End Class