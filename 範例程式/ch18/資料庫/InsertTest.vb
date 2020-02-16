Imports System.Data.OleDb

Public Class InsertTest
    '-------------------------------------------------------------------------------------------------
    ' 功能：測式Command物件-Insert 指令
    ' 
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Oledb1 As New OleDbConnection
        Oledb1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\範例程式\ch18\Library.mdb"
        Oledb1.Open() '開啟資料庫
        If ConnectionState.Open Then '判斷資料庫目前的狀態是否已開啟
            Dim Cmd1 As New OleDbCommand
            Cmd1.Connection = Oledb1 '建立連結
            Cmd1.CommandText = "Insert into 借書人(姓名,電話) values('" + TextBox1.Text + "'" + ",'" + TextBox2.Text + "')" '建立新增資料的SQL字串
            Cmd1.ExecuteNonQuery() '執行不會傳回任何值的查詢
            Oledb1.Close() '關閉資料庫
        End If
    End Sub
End Class