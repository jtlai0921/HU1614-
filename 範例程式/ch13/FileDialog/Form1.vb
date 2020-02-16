Imports System.IO
Public Class FileDialog
    '-------------------------------------------------------------------------------------------------
    ' 功能：FileDialog控制項範例
    ' 
    '-------------------------------------------------------------------------------------------------
    Dim filename As String
    Dim fileread As StreamReader
    Dim filewriter As StreamWriter
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click '按下開啟檔案按鈕時觸發的事件程序
        With OpenFileDialog1
            .InitialDirectory = "c:\" '設定預設目錄
            .Filter = "純文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*" '預設開啟的檔案類型
            .Title = "開啟舊檔" '設定對話方塊的標題
            .RestoreDirectory = True '設定是否在關閉之前要還原至目前的目錄
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then '假如按下開啟按鈕時
            filename = OpenFileDialog1.FileName  '設定檔案名稱
            fileread = New StreamReader(filename) '讀取檔案
            TextBox1.Text = fileread.ReadToEnd() '自檔案目前位置讀至檔案尾端
            fileread.Close() '將檔案關閉
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
    Handles Button2.Click '按下儲存檔案按鈕時觸發的事件程序
        With SaveFileDialog1
            .InitialDirectory = "D:\" '設定預設目錄
            .Filter = "純文字檔(*.txt)|*.txt" '預設欲儲存的檔案類型
            .RestoreDirectory = True '設定是否在關閉之前要還原至目前的目錄
            .Title = "存檔" '設定對話方塊的標題
        End With
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then '假如按下儲存按鈕時
            filename = SaveFileDialog1.FileName '設定檔案名稱
            filewriter = New StreamWriter(filename, False)
            filewriter.Write(TextBox1.Text) '將資料流寫入指定的檔案中
            filewriter.Close() '關閉檔案
        End If
    End Sub
End Class