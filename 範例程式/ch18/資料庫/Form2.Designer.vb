<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim 編號Label As System.Windows.Forms.Label
        Dim 姓名Label As System.Windows.Forms.Label
        Dim 性別Label As System.Windows.Forms.Label
        Dim 身分證字號Label As System.Windows.Forms.Label
        Dim 電話Label As System.Windows.Forms.Label
        Dim 住址Label As System.Windows.Forms.Label
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
        Me.編號TextBox = New System.Windows.Forms.TextBox()
        Me.姓名TextBox = New System.Windows.Forms.TextBox()
        Me.性別TextBox = New System.Windows.Forms.TextBox()
        Me.身分證字號TextBox = New System.Windows.Forms.TextBox()
        Me.電話TextBox = New System.Windows.Forms.TextBox()
        Me.住址TextBox = New System.Windows.Forms.TextBox()
        編號Label = New System.Windows.Forms.Label()
        姓名Label = New System.Windows.Forms.Label()
        性別Label = New System.Windows.Forms.Label()
        身分證字號Label = New System.Windows.Forms.Label()
        電話Label = New System.Windows.Forms.Label()
        住址Label = New System.Windows.Forms.Label()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.借書人BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.借書人BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.借書人BindingNavigator.SuspendLayout()
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
        Me.借書人BindingNavigator.Size = New System.Drawing.Size(387, 25)
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
        '編號Label
        '
        編號Label.AutoSize = True
        編號Label.Location = New System.Drawing.Point(105, 76)
        編號Label.Name = "編號Label"
        編號Label.Size = New System.Drawing.Size(32, 12)
        編號Label.TabIndex = 1
        編號Label.Text = "編號:"
        '
        '編號TextBox
        '
        Me.編號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.借書人BindingSource, "編號", True))
        Me.編號TextBox.Location = New System.Drawing.Point(179, 73)
        Me.編號TextBox.Name = "編號TextBox"
        Me.編號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.編號TextBox.TabIndex = 2
        '
        '姓名Label
        '
        姓名Label.AutoSize = True
        姓名Label.Location = New System.Drawing.Point(105, 104)
        姓名Label.Name = "姓名Label"
        姓名Label.Size = New System.Drawing.Size(32, 12)
        姓名Label.TabIndex = 3
        姓名Label.Text = "姓名:"
        '
        '姓名TextBox
        '
        Me.姓名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.借書人BindingSource, "姓名", True))
        Me.姓名TextBox.Location = New System.Drawing.Point(179, 101)
        Me.姓名TextBox.Name = "姓名TextBox"
        Me.姓名TextBox.Size = New System.Drawing.Size(100, 22)
        Me.姓名TextBox.TabIndex = 4
        '
        '性別Label
        '
        性別Label.AutoSize = True
        性別Label.Location = New System.Drawing.Point(105, 132)
        性別Label.Name = "性別Label"
        性別Label.Size = New System.Drawing.Size(32, 12)
        性別Label.TabIndex = 5
        性別Label.Text = "性別:"
        '
        '性別TextBox
        '
        Me.性別TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.借書人BindingSource, "性別", True))
        Me.性別TextBox.Location = New System.Drawing.Point(179, 129)
        Me.性別TextBox.Name = "性別TextBox"
        Me.性別TextBox.Size = New System.Drawing.Size(100, 22)
        Me.性別TextBox.TabIndex = 6
        '
        '身分證字號Label
        '
        身分證字號Label.AutoSize = True
        身分證字號Label.Location = New System.Drawing.Point(105, 160)
        身分證字號Label.Name = "身分證字號Label"
        身分證字號Label.Size = New System.Drawing.Size(68, 12)
        身分證字號Label.TabIndex = 7
        身分證字號Label.Text = "身分證字號:"
        '
        '身分證字號TextBox
        '
        Me.身分證字號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.借書人BindingSource, "身分證字號", True))
        Me.身分證字號TextBox.Location = New System.Drawing.Point(179, 157)
        Me.身分證字號TextBox.Name = "身分證字號TextBox"
        Me.身分證字號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.身分證字號TextBox.TabIndex = 8
        '
        '電話Label
        '
        電話Label.AutoSize = True
        電話Label.Location = New System.Drawing.Point(105, 188)
        電話Label.Name = "電話Label"
        電話Label.Size = New System.Drawing.Size(32, 12)
        電話Label.TabIndex = 9
        電話Label.Text = "電話:"
        '
        '電話TextBox
        '
        Me.電話TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.借書人BindingSource, "電話", True))
        Me.電話TextBox.Location = New System.Drawing.Point(179, 185)
        Me.電話TextBox.Name = "電話TextBox"
        Me.電話TextBox.Size = New System.Drawing.Size(100, 22)
        Me.電話TextBox.TabIndex = 10
        '
        '住址Label
        '
        住址Label.AutoSize = True
        住址Label.Location = New System.Drawing.Point(105, 216)
        住址Label.Name = "住址Label"
        住址Label.Size = New System.Drawing.Size(32, 12)
        住址Label.TabIndex = 11
        住址Label.Text = "住址:"
        '
        '住址TextBox
        '
        Me.住址TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.借書人BindingSource, "住址", True))
        Me.住址TextBox.Location = New System.Drawing.Point(179, 213)
        Me.住址TextBox.Name = "住址TextBox"
        Me.住址TextBox.Size = New System.Drawing.Size(100, 22)
        Me.住址TextBox.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 290)
        Me.Controls.Add(編號Label)
        Me.Controls.Add(Me.編號TextBox)
        Me.Controls.Add(姓名Label)
        Me.Controls.Add(Me.姓名TextBox)
        Me.Controls.Add(性別Label)
        Me.Controls.Add(Me.性別TextBox)
        Me.Controls.Add(身分證字號Label)
        Me.Controls.Add(Me.身分證字號TextBox)
        Me.Controls.Add(電話Label)
        Me.Controls.Add(Me.電話TextBox)
        Me.Controls.Add(住址Label)
        Me.Controls.Add(Me.住址TextBox)
        Me.Controls.Add(Me.借書人BindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.借書人BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.借書人BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.借書人BindingNavigator.ResumeLayout(False)
        Me.借書人BindingNavigator.PerformLayout()
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
    Friend WithEvents 編號TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 姓名TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 性別TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 身分證字號TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 電話TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 住址TextBox As System.Windows.Forms.TextBox
End Class
