<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class servicedetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(servicedetails))
        Dim Sd_idLabel As System.Windows.Forms.Label
        Dim Sd_descreptionLabel As System.Windows.Forms.Label
        Me.PetshopdbDataSet = New WindowsApplication17.petshopdbDataSet()
        Me.ServiceDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiceDetailsTableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.ServiceDetailsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager()
        Me.ServiceDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ServiceDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Sd_idTextBox = New System.Windows.Forms.TextBox()
        Me.Sd_descreptionTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ServiceDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiceDetailsComboBox = New System.Windows.Forms.ComboBox()
        Sd_idLabel = New System.Windows.Forms.Label()
        Sd_descreptionLabel = New System.Windows.Forms.Label()
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServiceDetailsBindingNavigator.SuspendLayout()
        CType(Me.ServiceDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PetshopdbDataSet
        '
        Me.PetshopdbDataSet.DataSetName = "petshopdbDataSet"
        Me.PetshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiceDetailsBindingSource
        '
        Me.ServiceDetailsBindingSource.DataMember = "ServiceDetails"
        Me.ServiceDetailsBindingSource.DataSource = Me.PetshopdbDataSet
        '
        'ServiceDetailsTableAdapter
        '
        Me.ServiceDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Order1TableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ServiceDetailsTableAdapter = Me.ServiceDetailsTableAdapter
        Me.TableAdapterManager.suppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'ServiceDetailsBindingNavigator
        '
        Me.ServiceDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ServiceDetailsBindingNavigator.BindingSource = Me.ServiceDetailsBindingSource
        Me.ServiceDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ServiceDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ServiceDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ServiceDetailsBindingNavigatorSaveItem})
        Me.ServiceDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ServiceDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ServiceDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ServiceDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ServiceDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ServiceDetailsBindingNavigator.Name = "ServiceDetailsBindingNavigator"
        Me.ServiceDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ServiceDetailsBindingNavigator.Size = New System.Drawing.Size(402, 25)
        Me.ServiceDetailsBindingNavigator.TabIndex = 0
        Me.ServiceDetailsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
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
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ServiceDetailsBindingNavigatorSaveItem
        '
        Me.ServiceDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ServiceDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ServiceDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ServiceDetailsBindingNavigatorSaveItem.Name = "ServiceDetailsBindingNavigatorSaveItem"
        Me.ServiceDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ServiceDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Sd_idLabel
        '
        Sd_idLabel.AutoSize = True
        Sd_idLabel.Location = New System.Drawing.Point(42, 89)
        Sd_idLabel.Name = "Sd_idLabel"
        Sd_idLabel.Size = New System.Drawing.Size(32, 13)
        Sd_idLabel.TabIndex = 1
        Sd_idLabel.Text = "sd id:"
        '
        'Sd_idTextBox
        '
        Me.Sd_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceDetailsBindingSource, "sd_id", True))
        Me.Sd_idTextBox.Location = New System.Drawing.Point(129, 82)
        Me.Sd_idTextBox.Name = "Sd_idTextBox"
        Me.Sd_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sd_idTextBox.TabIndex = 2
        '
        'Sd_descreptionLabel
        '
        Sd_descreptionLabel.AutoSize = True
        Sd_descreptionLabel.Location = New System.Drawing.Point(28, 126)
        Sd_descreptionLabel.Name = "Sd_descreptionLabel"
        Sd_descreptionLabel.Size = New System.Drawing.Size(79, 13)
        Sd_descreptionLabel.TabIndex = 3
        Sd_descreptionLabel.Text = "sd descreption:"
        '
        'Sd_descreptionTextBox
        '
        Me.Sd_descreptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceDetailsBindingSource, "sd_descreption", True))
        Me.Sd_descreptionTextBox.Location = New System.Drawing.Point(129, 123)
        Me.Sd_descreptionTextBox.Name = "Sd_descreptionTextBox"
        Me.Sd_descreptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sd_descreptionTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ServiceDetailsBindingSource1
        '
        Me.ServiceDetailsBindingSource1.DataMember = "ServiceDetails"
        Me.ServiceDetailsBindingSource1.DataSource = Me.PetshopdbDataSet
        '
        'ServiceDetailsComboBox
        '
        Me.ServiceDetailsComboBox.DataSource = Me.ServiceDetailsBindingSource1
        Me.ServiceDetailsComboBox.DisplayMember = "sd_descreption"
        Me.ServiceDetailsComboBox.FormattingEnabled = True
        Me.ServiceDetailsComboBox.Location = New System.Drawing.Point(45, 28)
        Me.ServiceDetailsComboBox.Name = "ServiceDetailsComboBox"
        Me.ServiceDetailsComboBox.Size = New System.Drawing.Size(300, 21)
        Me.ServiceDetailsComboBox.TabIndex = 6
        Me.ServiceDetailsComboBox.ValueMember = "sd_id"
        '
        'servicedetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 261)
        Me.Controls.Add(Me.ServiceDetailsComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Sd_idLabel)
        Me.Controls.Add(Me.Sd_idTextBox)
        Me.Controls.Add(Sd_descreptionLabel)
        Me.Controls.Add(Me.Sd_descreptionTextBox)
        Me.Controls.Add(Me.ServiceDetailsBindingNavigator)
        Me.Name = "servicedetails"
        Me.Text = "servicedetails"
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServiceDetailsBindingNavigator.ResumeLayout(False)
        Me.ServiceDetailsBindingNavigator.PerformLayout()
        CType(Me.ServiceDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PetshopdbDataSet As WindowsApplication17.petshopdbDataSet
    Friend WithEvents ServiceDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceDetailsTableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.ServiceDetailsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServiceDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ServiceDetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sd_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sd_descreptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ServiceDetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceDetailsComboBox As System.Windows.Forms.ComboBox
End Class
