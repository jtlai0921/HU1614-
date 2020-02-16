Imports System.IO
Public Class 建立檔案
    '-------------------------------------------------------------------------------------------------
    ' 功能：使用FileInfo類別來建立檔案
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFile As New FileInfo(TextBox1.Text)
        Dim fs As FileStream = myFile.Create
        Label2.Text = "檔案名稱: " & myFile.Name
        Label3.Text = "建立日期: " & myFile.CreationTime.ToString
        Label4.Text = "檔案大小: " & myFile.Length
        Label5.Text = "檔案屬性: " & myFile.Attributes
        fs.Close()
    End Sub
End Class