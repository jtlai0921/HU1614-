Public Class ListBox
    '-------------------------------------------------------------------------------------------------
    ' 功能：ListBox控制項範例
    '-------------------------------------------------------------------------------------------------
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Add(ListBox1.Items(ListBox1.SelectedIndex))
    End Sub
End Class