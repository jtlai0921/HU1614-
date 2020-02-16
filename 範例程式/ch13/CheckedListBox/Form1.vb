Public Class CheckedListBox
    '-------------------------------------------------------------------------------------------------
    ' 功能：CheckedListBox控制項範例
    '
    '-------------------------------------------------------------------------------------------------
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        TextBox1.Text = CheckedListBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckedListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckedListBox1.Items.Remove(TextBox1.Text)
    End Sub
End Class