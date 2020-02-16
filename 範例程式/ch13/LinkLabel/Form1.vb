Public Class LinkLabel
    '-------------------------------------------------------------------------------------------------
    ' 功能：LinkLabel控制項範例
    '-------------------------------------------------------------------------------------------------
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("IExplore.exe", "http://www.yahoo.com.tw")
    End Sub
End Class