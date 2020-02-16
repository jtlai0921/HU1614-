Imports System.IO
Public Class 目錄變更
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用Directory類別變更目錄
    '
    '-------------------------------------------------------------------------------------------------


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Directory.SetCurrentDirectory(TextBox1.Text) '設定變更後的目錄名稱
        TextBox3.Text = Directory.GetCurrentDirectory '取得變更後的目錄名稱
    End Sub
    Private Sub 目錄變更_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = Directory.GetCurrentDirectory '取得目前的目錄名稱
    End Sub
End Class