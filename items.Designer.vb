<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class items
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim I_idLabel As System.Windows.Forms.Label
        Dim I_descreptionLabel As System.Windows.Forms.Label
        Dim I_priceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(items))
        Me.PetshopdbDataSet = New WindowsApplication17.petshopdbDataSet()
        Me.ItemsTableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager()
        Me.ItemsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsComboBox = New System.Windows.Forms.ComboBox()
        Me.I_idTextBox = New System.Windows.Forms.TextBox()
        Me.I_descreptionTextBox = New System.Windows.Forms.TextBox()
        Me.I_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        I_idLabel = New System.Windows.Forms.Label()
        I_descreptionLabel = New System.Windows.Forms.Label()
        I_priceLabel = New System.Windows.Forms.Label()
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsBindingNavigator.SuspendLayout()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'I_idLabel
        '
        I_idLabel.AutoSize = True
        I_idLabel.Location = New System.Drawing.Point(141, 81)
        I_idLabel.Name = "I_idLabel"
        I_idLabel.Size = New System.Drawing.Size(23, 13)
        I_idLabel.TabIndex = 2
        I_idLabel.Text = "i id:"
        '
        'I_descreptionLabel
        '
        I_descreptionLabel.AutoSize = True
        I_descreptionLabel.Location = New System.Drawing.Point(141, 107)
        I_descreptionLabel.Name = "I_descreptionLabel"
        I_descreptionLabel.Size = New System.Drawing.Size(70, 13)
        I_descreptionLabel.TabIndex = 4
        I_descreptionLabel.Text = "i descreption:"
        '
        'I_priceLabel
        '
        I_priceLabel.AutoSize = True
        I_priceLabel.Location = New System.Drawing.Point(141, 133)
        I_priceLabel.Name = "I_priceLabel"
        I_priceLabel.Size = New System.Drawing.Size(38, 13)
        I_priceLabel.TabIndex = 6
        I_priceLabel.Text = "i price:"
        '
        'PetshopdbDataSet
        '
        Me.PetshopdbDataSet.DataSetName = "petshopdbDataSet"
        Me.PetshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager.Order1TableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ServiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'ItemsBindingNavigator
        '
        Me.ItemsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ItemsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ItemsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ItemsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ItemsBindingNavigatorSaveItem})
        Me.ItemsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ItemsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ItemsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ItemsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ItemsBindingNavigator.Name = "ItemsBindingNavigator"
        Me.ItemsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ItemsBindingNavigator.Size = New System.Drawing.Size(485, 25)
        Me.ItemsBindingNavigator.TabIndex = 0
        Me.ItemsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ItemsBindingNavigatorSaveItem
        '
        Me.ItemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItemsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemsBindingNavigatorSaveItem.Name = "ItemsBindingNavigatorSaveItem"
        Me.ItemsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ItemsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.PetshopdbDataSet
        '
        'ItemsComboBox
        '
        Me.ItemsComboBox.DataSource = Me.ItemsBindingSource
        Me.ItemsComboBox.DisplayMember = "i_descreption"
        Me.ItemsComboBox.FormattingEnabled = True
        Me.ItemsComboBox.Location = New System.Drawing.Point(12, 38)
        Me.ItemsComboBox.Name = "ItemsComboBox"
        Me.ItemsComboBox.Size = New System.Drawing.Size(453, 21)
        Me.ItemsComboBox.TabIndex = 1
        Me.ItemsComboBox.ValueMember = "i_id"
        '
        'I_idTextBox
        '
        Me.I_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "i_id", True))
        Me.I_idTextBox.Location = New System.Drawing.Point(217, 78)
        Me.I_idTextBox.Name = "I_idTextBox"
        Me.I_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.I_idTextBox.TabIndex = 3
        '
        'I_descreptionTextBox
        '
        Me.I_descreptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "i_descreption", True))
        Me.I_descreptionTextBox.Location = New System.Drawing.Point(217, 104)
        Me.I_descreptionTextBox.Name = "I_descreptionTextBox"
        Me.I_descreptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.I_descreptionTextBox.TabIndex = 5
        '
        'I_priceTextBox
        '
        Me.I_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "i_price", True))
        Me.I_priceTextBox.Location = New System.Drawing.Point(217, 130)
        Me.I_priceTextBox.Name = "I_priceTextBox"
        Me.I_priceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.I_priceTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 326)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(I_idLabel)
        Me.Controls.Add(Me.I_idTextBox)
        Me.Controls.Add(I_descreptionLabel)
        Me.Controls.Add(Me.I_descreptionTextBox)
        Me.Controls.Add(I_priceLabel)
        Me.Controls.Add(Me.I_priceTextBox)
        Me.Controls.Add(Me.ItemsComboBox)
        Me.Controls.Add(Me.ItemsBindingNavigator)
        Me.Name = "items"
        Me.Text = "items"
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsBindingNavigator.ResumeLayout(False)
        Me.ItemsBindingNavigator.PerformLayout()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PetshopdbDataSet As WindowsApplication17.petshopdbDataSet
    Friend WithEvents ItemsTableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ItemsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents I_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents I_descreptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents I_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
