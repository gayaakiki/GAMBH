<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suppliers
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
        Dim S_idLabel As System.Windows.Forms.Label
        Dim V_idLabel As System.Windows.Forms.Label
        Dim S_first_nameLabel As System.Windows.Forms.Label
        Dim S_last_nameLabel As System.Windows.Forms.Label
        Dim S_addressLabel As System.Windows.Forms.Label
        Dim S_dobLabel As System.Windows.Forms.Label
        Me.PetshopdbDataSet = New WindowsApplication17.petshopdbDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.suppliersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager()
        Me.S_idTextBox = New System.Windows.Forms.TextBox()
        Me.V_idTextBox = New System.Windows.Forms.TextBox()
        Me.S_first_nameTextBox = New System.Windows.Forms.TextBox()
        Me.S_last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.S_addressTextBox = New System.Windows.Forms.TextBox()
        Me.S_dobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuppliersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        S_idLabel = New System.Windows.Forms.Label()
        V_idLabel = New System.Windows.Forms.Label()
        S_first_nameLabel = New System.Windows.Forms.Label()
        S_last_nameLabel = New System.Windows.Forms.Label()
        S_addressLabel = New System.Windows.Forms.Label()
        S_dobLabel = New System.Windows.Forms.Label()
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PetshopdbDataSet
        '
        Me.PetshopdbDataSet.DataSetName = "petshopdbDataSet"
        Me.PetshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "suppliers"
        Me.SuppliersBindingSource.DataSource = Me.PetshopdbDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.Order1TableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ServiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'S_idLabel
        '
        S_idLabel.AutoSize = True
        S_idLabel.Location = New System.Drawing.Point(21, 46)
        S_idLabel.Name = "S_idLabel"
        S_idLabel.Size = New System.Drawing.Size(26, 13)
        S_idLabel.TabIndex = 1
        S_idLabel.Text = "s id:"
        '
        'S_idTextBox
        '
        Me.S_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "s_id", True))
        Me.S_idTextBox.Location = New System.Drawing.Point(90, 43)
        Me.S_idTextBox.Name = "S_idTextBox"
        Me.S_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_idTextBox.TabIndex = 2
        '
        'V_idLabel
        '
        V_idLabel.AutoSize = True
        V_idLabel.Location = New System.Drawing.Point(21, 72)
        V_idLabel.Name = "V_idLabel"
        V_idLabel.Size = New System.Drawing.Size(27, 13)
        V_idLabel.TabIndex = 3
        V_idLabel.Text = "v id:"
        '
        'V_idTextBox
        '
        Me.V_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "v_id", True))
        Me.V_idTextBox.Location = New System.Drawing.Point(90, 69)
        Me.V_idTextBox.Name = "V_idTextBox"
        Me.V_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.V_idTextBox.TabIndex = 4
        '
        'S_first_nameLabel
        '
        S_first_nameLabel.AutoSize = True
        S_first_nameLabel.Location = New System.Drawing.Point(21, 98)
        S_first_nameLabel.Name = "S_first_nameLabel"
        S_first_nameLabel.Size = New System.Drawing.Size(63, 13)
        S_first_nameLabel.TabIndex = 5
        S_first_nameLabel.Text = "s first name:"
        '
        'S_first_nameTextBox
        '
        Me.S_first_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "s_first_name", True))
        Me.S_first_nameTextBox.Location = New System.Drawing.Point(90, 95)
        Me.S_first_nameTextBox.Name = "S_first_nameTextBox"
        Me.S_first_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_first_nameTextBox.TabIndex = 6
        '
        'S_last_nameLabel
        '
        S_last_nameLabel.AutoSize = True
        S_last_nameLabel.Location = New System.Drawing.Point(21, 124)
        S_last_nameLabel.Name = "S_last_nameLabel"
        S_last_nameLabel.Size = New System.Drawing.Size(63, 13)
        S_last_nameLabel.TabIndex = 7
        S_last_nameLabel.Text = "s last name:"
        '
        'S_last_nameTextBox
        '
        Me.S_last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "s_last_name", True))
        Me.S_last_nameTextBox.Location = New System.Drawing.Point(90, 121)
        Me.S_last_nameTextBox.Name = "S_last_nameTextBox"
        Me.S_last_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_last_nameTextBox.TabIndex = 8
        '
        'S_addressLabel
        '
        S_addressLabel.AutoSize = True
        S_addressLabel.Location = New System.Drawing.Point(21, 150)
        S_addressLabel.Name = "S_addressLabel"
        S_addressLabel.Size = New System.Drawing.Size(55, 13)
        S_addressLabel.TabIndex = 9
        S_addressLabel.Text = "s address:"
        '
        'S_addressTextBox
        '
        Me.S_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "s_address", True))
        Me.S_addressTextBox.Location = New System.Drawing.Point(90, 147)
        Me.S_addressTextBox.Name = "S_addressTextBox"
        Me.S_addressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.S_addressTextBox.TabIndex = 10
        '
        'S_dobLabel
        '
        S_dobLabel.AutoSize = True
        S_dobLabel.Location = New System.Drawing.Point(21, 177)
        S_dobLabel.Name = "S_dobLabel"
        S_dobLabel.Size = New System.Drawing.Size(36, 13)
        S_dobLabel.TabIndex = 11
        S_dobLabel.Text = "s dob:"
        '
        'S_dobDateTimePicker
        '
        Me.S_dobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SuppliersBindingSource, "s_dob", True))
        Me.S_dobDateTimePicker.Location = New System.Drawing.Point(90, 173)
        Me.S_dobDateTimePicker.Name = "S_dobDateTimePicker"
        Me.S_dobDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.S_dobDateTimePicker.TabIndex = 12
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(438, 139)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 35)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "Delete"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(438, 89)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 35)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Save Changes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(438, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 35)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Add Supplier"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(320, 46)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "First"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Last"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(320, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SuppliersDataGridView
        '
        Me.SuppliersDataGridView.AutoGenerateColumns = False
        Me.SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppliersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SuppliersDataGridView.DataSource = Me.SuppliersBindingSource
        Me.SuppliersDataGridView.Location = New System.Drawing.Point(24, 199)
        Me.SuppliersDataGridView.Name = "SuppliersDataGridView"
        Me.SuppliersDataGridView.Size = New System.Drawing.Size(639, 162)
        Me.SuppliersDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "s_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "s_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "v_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "v_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "s_first_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "s_first_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "s_last_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "s_last_name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "s_address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "s_address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "s_dob"
        Me.DataGridViewTextBoxColumn6.HeaderText = "s_dob"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 474)
        Me.Controls.Add(Me.SuppliersDataGridView)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(S_idLabel)
        Me.Controls.Add(Me.S_idTextBox)
        Me.Controls.Add(V_idLabel)
        Me.Controls.Add(Me.V_idTextBox)
        Me.Controls.Add(S_first_nameLabel)
        Me.Controls.Add(Me.S_first_nameTextBox)
        Me.Controls.Add(S_last_nameLabel)
        Me.Controls.Add(Me.S_last_nameTextBox)
        Me.Controls.Add(S_addressLabel)
        Me.Controls.Add(Me.S_addressTextBox)
        Me.Controls.Add(S_dobLabel)
        Me.Controls.Add(Me.S_dobDateTimePicker)
        Me.Name = "suppliers"
        Me.Text = "suppliers"
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PetshopdbDataSet As WindowsApplication17.petshopdbDataSet
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.suppliersTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents S_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents V_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_first_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_last_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_dobDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SuppliersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
