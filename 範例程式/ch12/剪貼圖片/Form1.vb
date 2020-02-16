Public Class 剪貼圖片
    '-------------------------------------------------------------------------------------------------
    ' 功能：剪貼簿範例 - 圖片
    '
    '-------------------------------------------------------------------------------------------------

    Private Sub 剪貼圖片_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PictName As String
        PictName = InputBox("請輸入圖片名稱")
        PictureBox1.Image = Image.FromFile(PictName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetDataObject(PictureBox1.Image)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pict1 As IDataObject
        pict1 = Clipboard.GetDataObject()
        PictureBox2.Image = pict1.GetData(DataFormats.Bitmap)
    End Sub
End Class