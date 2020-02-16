Public Class autonumber
    '-------------------------------------------------------------------------------------------------
    ' 功能：建立自動編號的欄位
    ' 
    '-------------------------------------------------------------------------------------------------

    Private Sub autonumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds1 As New DataSet("dsCus")
        Dim dt1 As New DataTable("dtCus")
        ds1.Tables.Add(dt1) '在DataSet中新增一個dsCus Table
        Dim col1 As DataColumn = dt1.Columns.Add("CusNo", GetType(System.String))
        col1.ColumnName = "客戶編號"
        Dim col2 As DataColumn = dt1.Columns.Add("CusName", GetType(System.String))
        col2.ColumnName = "客戶名稱"
        col1.AllowDBNull = False '不允許Null值
        col1.AutoIncrement = True '設定為自動編碼欄位
        col1.AutoIncrementSeed = 1000 '從1000開始編起
        col1.AutoIncrementStep = 1 '遞增值為1
        col2.DefaultValue = "" '設定預設值
        DataGrid1.DataSource = ds1.Tables("dtCus").DefaultView
    End Sub
End Class