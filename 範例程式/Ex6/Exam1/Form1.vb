Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c1, Tem1 As Single
        c1 = Val(TextBox1.Text)
        Tem1 = (9 * c1) / 5.0 + 32
        Label2.Text = "華氏溫度為：" & Tem1.ToString
    End Sub
End Class