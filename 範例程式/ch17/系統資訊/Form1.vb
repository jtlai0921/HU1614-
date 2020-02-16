Imports System.IO
Public Class 系統資訊
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用Directory類別取得系統目錄相關資訊
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Logic_Drives As String()
        Dim Drive As String
        TextBox1.Text = Directory.GetCurrentDirectory  '取得目前的目錄
        Logic_Drives = Directory.GetLogicalDrives '取得目前系統上存在的邏輯磁碟機
        For Each Drive In Logic_Drives '利用For迴圈將取得的邏輯磁碟機代號顯示在TextBox2控制項中
            TextBox2.Text = TextBox2.Text & Drive & "  "
        Next
    End Sub
End Class