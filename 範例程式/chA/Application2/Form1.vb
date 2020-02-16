Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.GoHome()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscil As Short = Asc(e.KeyChar)
        If KeyAscil = Keys.Return Then
            WebBrowser1.Navigate(TextBox1.Text)
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        ProgressBar1.Value = (e.CurrentProgress / e.MaximumProgress) * 100
        If ProgressBar1.Value = 100 Then
            Me.Text = WebBrowser1.DocumentTitle
            Timer1.Enabled = False
        End If
    End Sub

    Dim i As Boolean
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i Then
            PictureBox1.Image = Image.FromFile("001.jpg")
            i = False
        Else
            PictureBox1.Image = Image.FromFile("002.jpg")
            i = True
        End If
    End Sub


    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case ToolStrip1.Items.IndexOf(e.ClickedItem)
            Case 0
                Timer1.Enabled = True
                WebBrowser1.GoBack()
            Case 1
                Timer1.Enabled = False
                WebBrowser1.Stop()
            Case 2
                Timer1.Enabled = True
                WebBrowser1.GoForward()
            Case 3
                Timer1.Enabled = True
                WebBrowser1.Refresh()
            Case 4
                Timer1.Enabled = True
                WebBrowser1.GoHome()
            Case 5
                OpenFileDialog1.Filter = "圖片檔案(*.jpg,*.gif,*.bmp)|*.*;*.gif;*.bmp"
                OpenFileDialog1.ShowDialog()
                If OpenFileDialog1.FileName <> "" Then
                    Me.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                End If
        End Select
    End Sub



End Class