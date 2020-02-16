<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LibraryDataSet = New 資料庫.LibraryDataSet()
        Me.借書人BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.借書人TableAdapter = New 資料庫.LibraryDataSetTableAdapters.借書人TableAdapter()
        Me.TableAdapterManager = New 資料庫.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.借書人BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.借書人BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.借書人DataGridView = New System.Windows.Forms.DataGridView()
        Me.編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.姓名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.性別DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.身分證字號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.電話DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.住址DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.借書人BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.借書人BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.借書人BindingNavigator.SuspendLayout()
        CType(Me.借書人DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '借書人BindingSource
        '
        Me.借書人BindingSource.DataMember = "借書人"
        Me.借書人BindingSource.DataSource = Me.LibraryDataSet
        '
        '借書人TableAdapter
        '
        Me.借書人TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._2003年4月借閱證TableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 資料庫.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.借書人TableAdapter = Me.借書人TableAdapter
        Me.TableAdapterManager.借閱證TableAdapter = Nothing
        Me.TableAdapterManager.圖書TableAdapter = Nothing
        Me.TableAdapterManager.管理員TableAdapter = Nothing
        Me.TableAdapterManager.職掌TableAdapter = Nothing
        Me.TableAdapterManager.閱覽TableAdapter = Nothing
        Me.TableAdapterManager.類別TableAdapter = Nothing
        '
        '借書人BindingNavigator
        '
        Me.借書人BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.借書人BindingNavigator.BindingSource = Me.借書人BindingSource
        Me.借書人BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.借書人BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.借書人BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.借書人BindingNavigatorSaveItem})
        Me.借書人BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.借書人BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.借書人BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.借書人BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.借書人BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.借書人BindingNavigator.Name = "借書人BindingNavigator"
        Me.借書人BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.借書人BindingNavigator.Size = New System.Drawing.Size(873, 25)
        Me.借書人BindingNavigator.TabIndex = 0
        Me.借書人BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(28, 16)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "加入新的"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "刪除"
        '
        '借書人BindingNavigatorSaveItem
        '
        Me.借書人BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.借書人BindingNavigatorSaveItem.Image = CType(resources.GetObject("借書人BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.借書人BindingNavigatorSaveItem.Name = "借書人BindingNavigatorSaveItem"
        Me.借書人BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.借書人BindingNavigatorSaveItem.Text = "儲存資料"
        '
        '借書人DataGridView
        '
        Me.借書人DataGridView.AutoGenerateColumns = False
        Me.借書人DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.借書人DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.編號DataGridViewTextBoxColumn, Me.姓名DataGridViewTextBoxColumn, Me.性別DataGridViewTextBoxColumn, Me.身分證字號DataGridViewTextBoxColumn, Me.電話DataGridViewTextBoxColumn, Me.住址DataGridViewTextBoxColumn})
        Me.借書人DataGridView.DataSource = Me.借書人BindingSource
        Me.借書人DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.借書人DataGridView.Location = New System.Drawing.Point(0, 25)
        Me.借書人DataGridView.Name = "借書人DataGridView"
        Me.借書人DataGridView.RowTemplate.Height = 24
        Me.借書人DataGridView.Size = New System.Drawing.Size(873, 362)
        Me.借書人DataGridView.TabIndex = 1
        '
        '編號DataGridViewTextBoxColumn
        '
        Me.編號DataGridViewTextBoxColumn.DataPropertyName = "編號"
        Me.編號DataGridViewTextBoxColumn.HeaderText = "編號"
        Me.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn"
        '
        '姓名DataGridViewTextBoxColumn
        '
        Me.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名"
        Me.姓名DataGridViewTextBoxColumn.HeaderText = "姓名"
        Me.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn"
        '
        '性別DataGridViewTextBoxColumn
        '
        Me.性別DataGridViewTextBoxColumn.DataPropertyName = "性別"
        Me.性別DataGridViewTextBoxColumn.HeaderText = "性別"
        Me.性別DataGridViewTextBoxColumn.Name = "性別DataGridViewTextBoxColumn"
        '
        '身分證字號DataGridViewTextBoxColumn
        '
        Me.身分證字號DataGridViewTextBoxColumn.DataPropertyName = "身分證字號"
        Me.身分證字號DataGridViewTextBoxColumn.HeaderText = "身分證字號"
        Me.身分證字號DataGridViewTextBoxColumn.Name = "身分證字號DataGridViewTextBoxColumn"
        '
        '電話DataGridViewTextBoxColumn
        '
        Me.電話DataGridViewTextBoxColumn.DataPropertyName = "電話"
        Me.電話DataGridViewTextBoxColumn.HeaderText = "電話"
        Me.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn"
        '
        '住址DataGridViewTextBoxColumn
        '
        Me.住址DataGridViewTextBoxColumn.DataPropertyName = "住址"
        Me.住址DataGridViewTextBoxColumn.HeaderText = "住址"
        Me.住址DataGridViewTextBoxColumn.Name = "住址DataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 387)
        Me.Controls.Add(Me.借書人DataGridView)
        Me.Controls.Add(Me.借書人BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.借書人BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.借書人BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.借書人BindingNavigator.ResumeLayout(False)
        Me.借書人BindingNavigator.PerformLayout()
        CType(Me.借書人DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LibraryDataSet As 資料庫.LibraryDataSet
    Friend WithEvents 借書人BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 借書人TableAdapter As 資料庫.LibraryDataSetTableAdapters.借書人TableAdapter
    Friend WithEvents TableAdapterManager As 資料庫.LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 借書人BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 借書人BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents 借書人DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents 編號DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 姓名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 性別DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 身分證字號DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 電話DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 住址DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
