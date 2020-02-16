Imports System.Data.OleDb

Public Class ConnectionTest
    '-------------------------------------------------------------------------------------------------
    ' 功能：連線測試
    ' 
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Oledb1 As New OleDbConnection
        Oledb1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\範例程式\ch18\Library.mdb"
        Oledb1.Open() '開啟資料庫
        If ConnectionState.Open Then '判斷資料庫目前的狀態是否已開啟
            MsgBox("資料庫已開啟")
            Oledb1.Close() '關閉資料庫
            End
        End If
    End Sub
End Class