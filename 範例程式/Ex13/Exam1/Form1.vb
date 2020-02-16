Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListBox1.SelectedIndex = -1 And ListBox2.SelectedIndex = -1) Then '假如沒有選擇任何項目
            Label1.Text = "無法執行交換動作，因為沒有選擇任何項目"
        End If
        If (ListBox1.SelectedIndex <> -1 And ListBox2.SelectedIndex = -1) Then '假如Listbox1有而ListBox2沒有選擇任何項目
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
        If (ListBox1.SelectedIndex = -1 And ListBox2.SelectedIndex <> -1) Then '假如Listbox2有而ListBox1沒有選擇任何項目
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
        If (ListBox1.SelectedIndex <> -1 And ListBox2.SelectedIndex <> -1) Then '假如Listbox2有而ListBox1沒有選擇任何項目
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items(0) = "國文"
        ListBox1.Items(1) = "英文"
        ListBox1.Items(2) = "體育"
        ListBox1.Items(3) = "音樂"
        ListBox1.Items(4) = "數學"
        ListBox2.Items(0) = "科目1"
        ListBox2.Items(1) = "科目2"
        ListBox2.Items(2) = "科目3"
        ListBox2.Items(3) = "科目4"
        ListBox2.Items(4) = "科目5"
    End Sub
End Class
