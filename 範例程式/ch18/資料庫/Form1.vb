Public Class Form1

    Private Sub 借書人BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 借書人BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.借書人BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  這行程式碼會將資料載入 'LibraryDataSet.借書人' 資料表。您可以視需要進行移動或移除。
        Me.借書人TableAdapter.Fill(Me.LibraryDataSet.借書人)

    End Sub
End Class
