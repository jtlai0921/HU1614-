Imports System.Data.OleDb

Public Class DataAdapter
    '-------------------------------------------------------------------------------------------------
    ' 功能：測試 DataAdapter
    ' 
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Oledb1 As New OleDbConnection
        Dim OleDataSet1 As New DataSet
        Oledb1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\範例程式\ch18\Library.mdb"
        Oledb1.Open() '開啟資料庫
        If ConnectionState.Open Then '判斷資料庫目前的狀態是否已開啟
            Dim OleDataAdapter1 As OleDbDataAdapter = New OleDbDataAdapter("Select * From 借書人", Oledb1)
            OleDataAdapter1.Fill(OleDataSet1, "借書人") '使用Fill方法將查詢結果填入DataSet物件中
            DataGrid1.DataSource = OleDataSet1.Tables("借書人") '指定要瀏覽資料表內容
            Oledb1.Close() '關閉資料庫
        End If
    End Sub
End Class