﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim C_idLabel As System.Windows.Forms.Label
        Dim C_first_nameLabel As System.Windows.Forms.Label
        Dim C_last_nameLabel As System.Windows.Forms.Label
        Dim C_addressLabel As System.Windows.Forms.Label
        Dim C_dobLabel As System.Windows.Forms.Label
        Me.PetshopdbDataSet = New WindowsApplication17.petshopdbDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_idTextBox = New System.Windows.Forms.TextBox()
        Me.C_first_nameTextBox = New System.Windows.Forms.TextBox()
        Me.C_last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.C_addressTextBox = New System.Windows.Forms.TextBox()
        Me.C_dobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        C_idLabel = New System.Windows.Forms.Label()
        C_first_nameLabel = New System.Windows.Forms.Label()
        C_last_nameLabel = New System.Windows.Forms.Label()
        C_addressLabel = New System.Windows.Forms.Label()
        C_dobLabel = New System.Windows.Forms.Label()
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PetshopdbDataSet
        '
        Me.PetshopdbDataSet.DataSetName = "petshopdbDataSet"
        Me.PetshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.PetshopdbDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Order1TableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ServiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(595, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
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
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AllowUserToOrderColumns = True
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Location = New System.Drawing.Point(12, 174)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.Size = New System.Drawing.Size(563, 177)
        Me.CustomersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "c_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "c_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "c_first_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "c_first_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "c_last_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "c_last_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "c_address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "c_address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "c_dob"
        Me.DataGridViewTextBoxColumn5.HeaderText = "c_dob"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'C_idLabel
        '
        C_idLabel.AutoSize = True
        C_idLabel.Location = New System.Drawing.Point(15, 45)
        C_idLabel.Name = "C_idLabel"
        C_idLabel.Size = New System.Drawing.Size(27, 13)
        C_idLabel.TabIndex = 2
        C_idLabel.Text = "c id:"
        '
        'C_idTextBox
        '
        Me.C_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_id", True))
        Me.C_idTextBox.Location = New System.Drawing.Point(85, 42)
        Me.C_idTextBox.Name = "C_idTextBox"
        Me.C_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_idTextBox.TabIndex = 3
        '
        'C_first_nameLabel
        '
        C_first_nameLabel.AutoSize = True
        C_first_nameLabel.Location = New System.Drawing.Point(15, 71)
        C_first_nameLabel.Name = "C_first_nameLabel"
        C_first_nameLabel.Size = New System.Drawing.Size(64, 13)
        C_first_nameLabel.TabIndex = 4
        C_first_nameLabel.Text = "c first name:"
        '
        'C_first_nameTextBox
        '
        Me.C_first_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_first_name", True))
        Me.C_first_nameTextBox.Location = New System.Drawing.Point(85, 68)
        Me.C_first_nameTextBox.Name = "C_first_nameTextBox"
        Me.C_first_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_first_nameTextBox.TabIndex = 5
        '
        'C_last_nameLabel
        '
        C_last_nameLabel.AutoSize = True
        C_last_nameLabel.Location = New System.Drawing.Point(15, 97)
        C_last_nameLabel.Name = "C_last_nameLabel"
        C_last_nameLabel.Size = New System.Drawing.Size(64, 13)
        C_last_nameLabel.TabIndex = 6
        C_last_nameLabel.Text = "c last name:"
        '
        'C_last_nameTextBox
        '
        Me.C_last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_last_name", True))
        Me.C_last_nameTextBox.Location = New System.Drawing.Point(85, 94)
        Me.C_last_nameTextBox.Name = "C_last_nameTextBox"
        Me.C_last_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_last_nameTextBox.TabIndex = 7
        '
        'C_addressLabel
        '
        C_addressLabel.AutoSize = True
        C_addressLabel.Location = New System.Drawing.Point(15, 123)
        C_addressLabel.Name = "C_addressLabel"
        C_addressLabel.Size = New System.Drawing.Size(56, 13)
        C_addressLabel.TabIndex = 8
        C_addressLabel.Text = "c address:"
        '
        'C_addressTextBox
        '
        Me.C_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_address", True))
        Me.C_addressTextBox.Location = New System.Drawing.Point(85, 120)
        Me.C_addressTextBox.Name = "C_addressTextBox"
        Me.C_addressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_addressTextBox.TabIndex = 9
        '
        'C_dobLabel
        '
        C_dobLabel.AutoSize = True
        C_dobLabel.Location = New System.Drawing.Point(15, 150)
        C_dobLabel.Name = "C_dobLabel"
        C_dobLabel.Size = New System.Drawing.Size(37, 13)
        C_dobLabel.TabIndex = 10
        C_dobLabel.Text = "c dob:"
        '
        'C_dobDateTimePicker
        '
        Me.C_dobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersBindingSource, "c_dob", True))
        Me.C_dobDateTimePicker.Location = New System.Drawing.Point(85, 146)
        Me.C_dobDateTimePicker.Name = "C_dobDateTimePicker"
        Me.C_dobDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.C_dobDateTimePicker.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(C_idLabel)
        Me.Controls.Add(Me.C_idTextBox)
        Me.Controls.Add(C_first_nameLabel)
        Me.Controls.Add(Me.C_first_nameTextBox)
        Me.Controls.Add(C_last_nameLabel)
        Me.Controls.Add(Me.C_last_nameTextBox)
        Me.Controls.Add(C_addressLabel)
        Me.Controls.Add(Me.C_addressTextBox)
        Me.Controls.Add(C_dobLabel)
        Me.Controls.Add(Me.C_dobDateTimePicker)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "PET SHOP"
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PetshopdbDataSet As WindowsApplication17.petshopdbDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_first_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_last_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_dobDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
