Public Class MainMenu
    '-------------------------------------------------------------------------------------------------
    ' 功能：功能表範例
    ' 
    '-------------------------------------------------------------------------------------------------
    Dim StrFontSize As Single '表字串大小
    Dim StrFont As String '表字串樣式
    Dim StrFontStyle As FontStyle '表字串字型
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StrFont = "新細明體" '預設將字型設定為新細明體
        StrFontSize = 8 '預設將字型大小設定為8
        StrFontStyle = FontStyle.Regular '預設將字型樣式設定為標準體
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles MenuItem4.Click
        StrFont = "標楷體" '將字型設定為標楷體
        MenuItem4.Checked = True '設定標楷體為預設字體
        MenuItem5.Checked = False '取消新細明體字型為預設字型
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub
    Private Sub MenuItem5_Click(sender As Object, e As EventArgs) Handles MenuItem5.Click
        StrFont = "新細明體" '將字型設定為新細明體
        MenuItem4.Checked = False '取消標楷體字型為預設字型
        MenuItem5.Checked = True '設定新細明體為字型
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub
    Private Sub MenuItem11_Click(sender As Object, e As EventArgs) Handles MenuItem11.Click
        StrFontSize = 8 '將字型大小設定為8
        MenuItem11.Checked = True '設定字型大小8為預設字型大小
        MenuItem12.Checked = False '取消字型大小10為預設字型大小
        MenuItem13.Checked = False '取消字型大小12為預設字型大小
        MenuItem14.Checked = False '取消字型大小14為預設字型大小
        MenuItem15.Checked = False '取消字型大小16為預設字型大小
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem12_Click(sender As Object, e As EventArgs) Handles MenuItem12.Click
        StrFontSize = 10 '將字型大小設定為10
        MenuItem12.Checked = True '設定字型大小10為預設字型大小
        MenuItem11.Checked = False '取消字型大小8為預設字型大小
        MenuItem13.Checked = False '取消字型大小12為預設字型大小
        MenuItem14.Checked = False '取消字型大小14為預設字型大小
        MenuItem15.Checked = False '取消字型大小16為預設字型大小
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem13_Click(sender As Object, e As EventArgs) Handles MenuItem13.Click
        StrFontSize = 12 '將字型大小設定為12
        MenuItem13.Checked = True '設定字型大小12為預設字型大小
        MenuItem11.Checked = False '取消字型大小8為預設字型大小
        MenuItem12.Checked = False '取消字型大小10為預設字型大小
        MenuItem14.Checked = False '取消字型大小14為預設字型大小
        MenuItem15.Checked = False '取消字型大小16為預設字型大小
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem14_Click(sender As Object, e As EventArgs) Handles MenuItem14.Click
        StrFontSize = 14 '將字型大小設定為14
        MenuItem14.Checked = True '設定字型大小14為預設字型大小
        MenuItem11.Checked = False '取消字型大小8為預設字型大小
        MenuItem12.Checked = False '取消字型大小10為預設字型大小
        MenuItem13.Checked = False '取消字型大小12為預設字型大小
        MenuItem15.Checked = False '取消字型大小16為預設字型大小
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem15_Click(sender As Object, e As EventArgs) Handles MenuItem15.Click
        StrFontSize = 16 '將字型大小設定為16
        MenuItem15.Checked = True '設定字型大小16為預設字型大小
        MenuItem11.Checked = False '取消字型大小8為預設字型大小
        MenuItem12.Checked = False '取消字型大小10為預設字型大小
        MenuItem13.Checked = False '取消字型大小12為預設字型大小
        MenuItem14.Checked = False '取消字型大小14為預設字型大小
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem7_Click(sender As Object, e As EventArgs) Handles MenuItem7.Click
        StrFontStyle = FontStyle.Bold '設定預設字型樣式為粗體
        MenuItem7.Checked = True '設定預設字型樣式為粗體
        MenuItem8.Checked = False '取消斜體字型為預設字型
        MenuItem16.Checked = False '取消標準體為預設字型
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem8_Click(sender As Object, e As EventArgs) Handles MenuItem8.Click
        StrFontStyle = FontStyle.Italic '設定預設字型樣式為斜體
        MenuItem8.Checked = True '設定預設字型樣式為斜體
        MenuItem7.Checked = False '取消粗體字型為預設字型
        MenuItem16.Checked = False '取消標準體為預設字型
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem16_Click(sender As Object, e As EventArgs) Handles MenuItem16.Click
        StrFontStyle = FontStyle.Regular '設定預設字型樣式為標準體
        MenuItem16.Checked = True '設定預設字型樣式為標準體
        MenuItem7.Checked = False '取消粗體字型為預設字型
        MenuItem8.Checked = False '取消斜體字型為預設字型
        RichTextBox1.Font = New Font(StrFont, StrFontSize, StrFontStyle) '更新TextBox1控制項內的文字樣式
    End Sub

    Private Sub MenuItem2_Click(sender As Object, e As EventArgs) Handles MenuItem2.Click
        RichTextBox1.Text = UCase(RichTextBox1.Text) '將文字轉換為大寫字元
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        RichTextBox1.Text = LCase(RichTextBox1.Text) '將文字轉換為小寫字元
    End Sub
End Class
