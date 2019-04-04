<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
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
        Dim O_idLabel As System.Windows.Forms.Label
        Dim Cat_idLabel As System.Windows.Forms.Label
        Dim O_descreptionLabel As System.Windows.Forms.Label
        Dim O_dateLabel As System.Windows.Forms.Label
        Dim P_idLabel As System.Windows.Forms.Label
        Dim O_idLabel1 As System.Windows.Forms.Label
        Dim P_dateLabel As System.Windows.Forms.Label
        Dim P_methodLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(order))
        Me.PetshopdbDataSet = New WindowsApplication17.petshopdbDataSet()
        Me.Order1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order1TableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.Order1TableAdapter()
        Me.TableAdapterManager = New WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager()
        Me.PaymentTableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.PaymentTableAdapter()
        Me.O_idTextBox = New System.Windows.Forms.TextBox()
        Me.Cat_idTextBox = New System.Windows.Forms.TextBox()
        Me.O_descreptionTextBox = New System.Windows.Forms.TextBox()
        Me.O_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_idTextBox = New System.Windows.Forms.TextBox()
        Me.O_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.P_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_methodTextBox = New System.Windows.Forms.TextBox()
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
        Me.Order1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Order1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        O_idLabel = New System.Windows.Forms.Label()
        Cat_idLabel = New System.Windows.Forms.Label()
        O_descreptionLabel = New System.Windows.Forms.Label()
        O_dateLabel = New System.Windows.Forms.Label()
        P_idLabel = New System.Windows.Forms.Label()
        O_idLabel1 = New System.Windows.Forms.Label()
        P_dateLabel = New System.Windows.Forms.Label()
        P_methodLabel = New System.Windows.Forms.Label()
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'O_idLabel
        '
        O_idLabel.AutoSize = True
        O_idLabel.Location = New System.Drawing.Point(22, 41)
        O_idLabel.Name = "O_idLabel"
        O_idLabel.Size = New System.Drawing.Size(27, 13)
        O_idLabel.TabIndex = 1
        O_idLabel.Text = "o id:"
        '
        'Cat_idLabel
        '
        Cat_idLabel.AutoSize = True
        Cat_idLabel.Location = New System.Drawing.Point(22, 67)
        Cat_idLabel.Name = "Cat_idLabel"
        Cat_idLabel.Size = New System.Drawing.Size(36, 13)
        Cat_idLabel.TabIndex = 3
        Cat_idLabel.Text = "cat id:"
        '
        'O_descreptionLabel
        '
        O_descreptionLabel.AutoSize = True
        O_descreptionLabel.Location = New System.Drawing.Point(22, 93)
        O_descreptionLabel.Name = "O_descreptionLabel"
        O_descreptionLabel.Size = New System.Drawing.Size(74, 13)
        O_descreptionLabel.TabIndex = 5
        O_descreptionLabel.Text = "o descreption:"
        '
        'O_dateLabel
        '
        O_dateLabel.AutoSize = True
        O_dateLabel.Location = New System.Drawing.Point(22, 120)
        O_dateLabel.Name = "O_dateLabel"
        O_dateLabel.Size = New System.Drawing.Size(40, 13)
        O_dateLabel.TabIndex = 7
        O_dateLabel.Text = "o date:"
        '
        'P_idLabel
        '
        P_idLabel.AutoSize = True
        P_idLabel.Location = New System.Drawing.Point(406, 44)
        P_idLabel.Name = "P_idLabel"
        P_idLabel.Size = New System.Drawing.Size(27, 13)
        P_idLabel.TabIndex = 11
        P_idLabel.Text = "p id:"
        AddHandler P_idLabel.Click, AddressOf Me.P_idLabel_Click
        '
        'O_idLabel1
        '
        O_idLabel1.AutoSize = True
        O_idLabel1.Location = New System.Drawing.Point(406, 70)
        O_idLabel1.Name = "O_idLabel1"
        O_idLabel1.Size = New System.Drawing.Size(27, 13)
        O_idLabel1.TabIndex = 13
        O_idLabel1.Text = "o id:"
        '
        'P_dateLabel
        '
        P_dateLabel.AutoSize = True
        P_dateLabel.Location = New System.Drawing.Point(406, 97)
        P_dateLabel.Name = "P_dateLabel"
        P_dateLabel.Size = New System.Drawing.Size(40, 13)
        P_dateLabel.TabIndex = 15
        P_dateLabel.Text = "p date:"
        '
        'P_methodLabel
        '
        P_methodLabel.AutoSize = True
        P_methodLabel.Location = New System.Drawing.Point(406, 122)
        P_methodLabel.Name = "P_methodLabel"
        P_methodLabel.Size = New System.Drawing.Size(54, 13)
        P_methodLabel.TabIndex = 17
        P_methodLabel.Text = "p method:"
        '
        'PetshopdbDataSet
        '
        Me.PetshopdbDataSet.DataSetName = "petshopdbDataSet"
        Me.PetshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order1BindingSource
        '
        Me.Order1BindingSource.DataMember = "Order1"
        Me.Order1BindingSource.DataSource = Me.PetshopdbDataSet
        '
        'Order1TableAdapter
        '
        Me.Order1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Order1TableAdapter = Me.Order1TableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Me.PaymentTableAdapter
        Me.TableAdapterManager.ServiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'O_idTextBox
        '
        Me.O_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order1BindingSource, "o_id", True))
        Me.O_idTextBox.Location = New System.Drawing.Point(102, 38)
        Me.O_idTextBox.Name = "O_idTextBox"
        Me.O_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.O_idTextBox.TabIndex = 2
        '
        'Cat_idTextBox
        '
        Me.Cat_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order1BindingSource, "cat_id", True))
        Me.Cat_idTextBox.Location = New System.Drawing.Point(102, 60)
        Me.Cat_idTextBox.Name = "Cat_idTextBox"
        Me.Cat_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cat_idTextBox.TabIndex = 4
        '
        'O_descreptionTextBox
        '
        Me.O_descreptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order1BindingSource, "o_descreption", True))
        Me.O_descreptionTextBox.Location = New System.Drawing.Point(102, 86)
        Me.O_descreptionTextBox.Name = "O_descreptionTextBox"
        Me.O_descreptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.O_descreptionTextBox.TabIndex = 6
        '
        'O_dateDateTimePicker
        '
        Me.O_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Order1BindingSource, "o_date", True))
        Me.O_dateDateTimePicker.Location = New System.Drawing.Point(102, 116)
        Me.O_dateDateTimePicker.Name = "O_dateDateTimePicker"
        Me.O_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.O_dateDateTimePicker.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Payment"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.PetshopdbDataSet
        '
        'P_idTextBox
        '
        Me.P_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "p_id", True))
        Me.P_idTextBox.Location = New System.Drawing.Point(466, 41)
        Me.P_idTextBox.Name = "P_idTextBox"
        Me.P_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_idTextBox.TabIndex = 12
        Me.P_idTextBox.Visible = False
        '
        'O_idTextBox1
        '
        Me.O_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "o_id", True))
        Me.O_idTextBox1.Location = New System.Drawing.Point(466, 67)
        Me.O_idTextBox1.Name = "O_idTextBox1"
        Me.O_idTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.O_idTextBox1.TabIndex = 14
        Me.O_idTextBox1.Visible = False
        '
        'P_dateDateTimePicker
        '
        Me.P_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentBindingSource, "p_date", True))
        Me.P_dateDateTimePicker.Location = New System.Drawing.Point(466, 93)
        Me.P_dateDateTimePicker.Name = "P_dateDateTimePicker"
        Me.P_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.P_dateDateTimePicker.TabIndex = 16
        Me.P_dateDateTimePicker.Visible = False
        '
        'P_methodTextBox
        '
        Me.P_methodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "p_method", True))
        Me.P_methodTextBox.Location = New System.Drawing.Point(466, 119)
        Me.P_methodTextBox.Name = "P_methodTextBox"
        Me.P_methodTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_methodTextBox.TabIndex = 18
        Me.P_methodTextBox.Visible = False
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Order1BindingNavigatorSaveItem
        '
        Me.Order1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Order1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Order1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Order1BindingNavigatorSaveItem.Name = "Order1BindingNavigatorSaveItem"
        Me.Order1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Order1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Order1BindingNavigator
        '
        Me.Order1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Order1BindingNavigator.BindingSource = Me.Order1BindingSource
        Me.Order1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Order1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Order1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Order1BindingNavigatorSaveItem})
        Me.Order1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Order1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Order1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Order1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Order1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Order1BindingNavigator.Name = "Order1BindingNavigator"
        Me.Order1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Order1BindingNavigator.Size = New System.Drawing.Size(771, 25)
        Me.Order1BindingNavigator.TabIndex = 0
        Me.Order1BindingNavigator.Text = "BindingNavigator1"
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 296)
        Me.Controls.Add(P_idLabel)
        Me.Controls.Add(Me.P_idTextBox)
        Me.Controls.Add(O_idLabel1)
        Me.Controls.Add(Me.O_idTextBox1)
        Me.Controls.Add(P_dateLabel)
        Me.Controls.Add(Me.P_dateDateTimePicker)
        Me.Controls.Add(P_methodLabel)
        Me.Controls.Add(Me.P_methodTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(O_idLabel)
        Me.Controls.Add(Me.O_idTextBox)
        Me.Controls.Add(Cat_idLabel)
        Me.Controls.Add(Me.Cat_idTextBox)
        Me.Controls.Add(O_descreptionLabel)
        Me.Controls.Add(Me.O_descreptionTextBox)
        Me.Controls.Add(O_dateLabel)
        Me.Controls.Add(Me.O_dateDateTimePicker)
        Me.Controls.Add(Me.Order1BindingNavigator)
        Me.Name = "order"
        Me.Text = "order"
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order1BindingNavigator.ResumeLayout(False)
        Me.Order1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PetshopdbDataSet As WindowsApplication17.petshopdbDataSet
    Friend WithEvents Order1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Order1TableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.Order1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents O_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents O_descreptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents O_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PaymentTableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents PaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents O_idTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents P_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents P_methodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Order1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Order1BindingNavigator As System.Windows.Forms.BindingNavigator
End Class
