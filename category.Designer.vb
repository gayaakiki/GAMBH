﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(category))
        Dim Cat_idLabel As System.Windows.Forms.Label
        Dim Sd_idLabel As System.Windows.Forms.Label
        Dim I_idLabel As System.Windows.Forms.Label
        Dim Cat_nameLabel As System.Windows.Forms.Label
        Me.PetshopdbDataSet = New WindowsApplication17.petshopdbDataSet()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.CategoryTableAdapter()
        Me.TableAdapterManager = New WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager()
        Me.CategoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CategoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Cat_idTextBox = New System.Windows.Forms.TextBox()
        Me.Sd_idTextBox = New System.Windows.Forms.TextBox()
        Me.I_idTextBox = New System.Windows.Forms.TextBox()
        Me.Cat_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Cat_idLabel = New System.Windows.Forms.Label()
        Sd_idLabel = New System.Windows.Forms.Label()
        I_idLabel = New System.Windows.Forms.Label()
        Cat_nameLabel = New System.Windows.Forms.Label()
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PetshopdbDataSet
        '
        Me.PetshopdbDataSet.DataSetName = "petshopdbDataSet"
        Me.PetshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.PetshopdbDataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Order1TableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ServiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'CategoryBindingNavigator
        '
        Me.CategoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoryBindingNavigator.BindingSource = Me.CategoryBindingSource
        Me.CategoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoryBindingNavigatorSaveItem})
        Me.CategoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoryBindingNavigator.Name = "CategoryBindingNavigator"
        Me.CategoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategoryBindingNavigator.Size = New System.Drawing.Size(724, 25)
        Me.CategoryBindingNavigator.TabIndex = 0
        Me.CategoryBindingNavigator.Text = "BindingNavigator1"
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
        'CategoryBindingNavigatorSaveItem
        '
        Me.CategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoryBindingNavigatorSaveItem.Name = "CategoryBindingNavigatorSaveItem"
        Me.CategoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CategoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryComboBox.DisplayMember = "sd_id"
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(57, 28)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(300, 21)
        Me.CategoryComboBox.TabIndex = 1
        Me.CategoryComboBox.ValueMember = "cat_id"
        '
        'Cat_idLabel
        '
        Cat_idLabel.AutoSize = True
        Cat_idLabel.Location = New System.Drawing.Point(68, 93)
        Cat_idLabel.Name = "Cat_idLabel"
        Cat_idLabel.Size = New System.Drawing.Size(36, 13)
        Cat_idLabel.TabIndex = 2
        Cat_idLabel.Text = "cat id:"
        '
        'Cat_idTextBox
        '
        Me.Cat_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "cat_id", True))
        Me.Cat_idTextBox.Location = New System.Drawing.Point(128, 90)
        Me.Cat_idTextBox.Name = "Cat_idTextBox"
        Me.Cat_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cat_idTextBox.TabIndex = 3
        '
        'Sd_idLabel
        '
        Sd_idLabel.AutoSize = True
        Sd_idLabel.Location = New System.Drawing.Point(68, 119)
        Sd_idLabel.Name = "Sd_idLabel"
        Sd_idLabel.Size = New System.Drawing.Size(32, 13)
        Sd_idLabel.TabIndex = 4
        Sd_idLabel.Text = "sd id:"
        '
        'Sd_idTextBox
        '
        Me.Sd_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "sd_id", True))
        Me.Sd_idTextBox.Location = New System.Drawing.Point(128, 116)
        Me.Sd_idTextBox.Name = "Sd_idTextBox"
        Me.Sd_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sd_idTextBox.TabIndex = 5
        '
        'I_idLabel
        '
        I_idLabel.AutoSize = True
        I_idLabel.Location = New System.Drawing.Point(68, 145)
        I_idLabel.Name = "I_idLabel"
        I_idLabel.Size = New System.Drawing.Size(23, 13)
        I_idLabel.TabIndex = 6
        I_idLabel.Text = "i id:"
        '
        'I_idTextBox
        '
        Me.I_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "i_id", True))
        Me.I_idTextBox.Location = New System.Drawing.Point(128, 142)
        Me.I_idTextBox.Name = "I_idTextBox"
        Me.I_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.I_idTextBox.TabIndex = 7
        '
        'Cat_nameLabel
        '
        Cat_nameLabel.AutoSize = True
        Cat_nameLabel.Location = New System.Drawing.Point(68, 171)
        Cat_nameLabel.Name = "Cat_nameLabel"
        Cat_nameLabel.Size = New System.Drawing.Size(54, 13)
        Cat_nameLabel.TabIndex = 8
        Cat_nameLabel.Text = "cat name:"
        '
        'Cat_nameTextBox
        '
        Me.Cat_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "cat_name", True))
        Me.Cat_nameTextBox.Location = New System.Drawing.Point(128, 168)
        Me.Cat_nameTextBox.Name = "Cat_nameTextBox"
        Me.Cat_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cat_nameTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 340)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Cat_idLabel)
        Me.Controls.Add(Me.Cat_idTextBox)
        Me.Controls.Add(Sd_idLabel)
        Me.Controls.Add(Me.Sd_idTextBox)
        Me.Controls.Add(I_idLabel)
        Me.Controls.Add(Me.I_idTextBox)
        Me.Controls.Add(Cat_nameLabel)
        Me.Controls.Add(Me.Cat_nameTextBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.CategoryBindingNavigator)
        Me.Name = "category"
        Me.Text = "category"
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoryBindingNavigator.ResumeLayout(False)
        Me.CategoryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PetshopdbDataSet As WindowsApplication17.petshopdbDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CategoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cat_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sd_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents I_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cat_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
