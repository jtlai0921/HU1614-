Public Class 剪貼簿
    '-------------------------------------------------------------------------------------------------
    ' 功能：剪貼簿範例 - 文字
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetDataObject(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim text1 As IDataObject
        text1 = Clipboard.GetDataObject()
        TextBox2.Text = text1.GetData(DataFormats.Text)
    End Sub
End Class