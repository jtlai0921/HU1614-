Public Class Form1
    Dim I, Sum As Integer
    Dim AVG As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sum += TextBox1.Text
        I += 1
        Label2.Text = I
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        I = 1
        Sum = 0
        Label2.Text = I
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AVG = Sum / (I - 1)
        Label4.Text = "共有" & (I - 1) & "位同學，其總成績為：" & Sum & vbNewLine
        Label4.Text &= "其平均成績為：" & AVG
    End Sub
End Class
