<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim C_idLabel As System.Windows.Forms.Label
        Dim C_first_nameLabel As System.Windows.Forms.Label
        Dim C_last_nameLabel As System.Windows.Forms.Label
        Dim C_addressLabel As System.Windows.Forms.Label
        Dim C_dobLabel As System.Windows.Forms.Label
        Me.PetshopdbDataSet = New WindowsApplication17.petshopdbDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New WindowsApplication17.petshopdbDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        C_idLabel = New System.Windows.Forms.Label()
        C_first_nameLabel = New System.Windows.Forms.Label()
        C_last_nameLabel = New System.Windows.Forms.Label()
        C_addressLabel = New System.Windows.Forms.Label()
        C_dobLabel = New System.Windows.Forms.Label()
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AllowUserToAddRows = False
        Me.CustomersDataGridView.AllowUserToDeleteRows = False
        Me.CustomersDataGridView.AllowUserToOrderColumns = True
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Location = New System.Drawing.Point(20, 144)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.ReadOnly = True
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
        C_idLabel.Location = New System.Drawing.Point(30, 17)
        C_idLabel.Name = "C_idLabel"
        C_idLabel.Size = New System.Drawing.Size(27, 13)
        C_idLabel.TabIndex = 2
        C_idLabel.Text = "c id:"
        '
        'C_idTextBox
        '
        Me.C_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_id", True))
        Me.C_idTextBox.Location = New System.Drawing.Point(100, 14)
        Me.C_idTextBox.Name = "C_idTextBox"
        Me.C_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_idTextBox.TabIndex = 3
        '
        'C_first_nameLabel
        '
        C_first_nameLabel.AutoSize = True
        C_first_nameLabel.Location = New System.Drawing.Point(30, 43)
        C_first_nameLabel.Name = "C_first_nameLabel"
        C_first_nameLabel.Size = New System.Drawing.Size(64, 13)
        C_first_nameLabel.TabIndex = 4
        C_first_nameLabel.Text = "c first name:"
        '
        'C_first_nameTextBox
        '
        Me.C_first_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_first_name", True))
        Me.C_first_nameTextBox.Location = New System.Drawing.Point(100, 40)
        Me.C_first_nameTextBox.Name = "C_first_nameTextBox"
        Me.C_first_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_first_nameTextBox.TabIndex = 5
        '
        'C_last_nameLabel
        '
        C_last_nameLabel.AutoSize = True
        C_last_nameLabel.Location = New System.Drawing.Point(30, 69)
        C_last_nameLabel.Name = "C_last_nameLabel"
        C_last_nameLabel.Size = New System.Drawing.Size(64, 13)
        C_last_nameLabel.TabIndex = 6
        C_last_nameLabel.Text = "c last name:"
        '
        'C_last_nameTextBox
        '
        Me.C_last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_last_name", True))
        Me.C_last_nameTextBox.Location = New System.Drawing.Point(100, 66)
        Me.C_last_nameTextBox.Name = "C_last_nameTextBox"
        Me.C_last_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_last_nameTextBox.TabIndex = 7
        '
        'C_addressLabel
        '
        C_addressLabel.AutoSize = True
        C_addressLabel.Location = New System.Drawing.Point(30, 95)
        C_addressLabel.Name = "C_addressLabel"
        C_addressLabel.Size = New System.Drawing.Size(56, 13)
        C_addressLabel.TabIndex = 8
        C_addressLabel.Text = "c address:"
        '
        'C_addressTextBox
        '
        Me.C_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "c_address", True))
        Me.C_addressTextBox.Location = New System.Drawing.Point(100, 92)
        Me.C_addressTextBox.Name = "C_addressTextBox"
        Me.C_addressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_addressTextBox.TabIndex = 9
        '
        'C_dobLabel
        '
        C_dobLabel.AutoSize = True
        C_dobLabel.Location = New System.Drawing.Point(30, 122)
        C_dobLabel.Name = "C_dobLabel"
        C_dobLabel.Size = New System.Drawing.Size(37, 13)
        C_dobLabel.TabIndex = 10
        C_dobLabel.Text = "c dob:"
        '
        'C_dobDateTimePicker
        '
        Me.C_dobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersBindingSource, "c_dob", True))
        Me.C_dobDateTimePicker.Location = New System.Drawing.Point(100, 118)
        Me.C_dobDateTimePicker.Name = "C_dobDateTimePicker"
        Me.C_dobDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.C_dobDateTimePicker.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(325, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(325, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Last"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(325, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "First"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(443, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 35)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Add Customer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(443, 55)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 35)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Save Changes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(443, 100)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 35)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Delete"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(307, 336)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 27
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 371)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
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
        Me.Name = "Form1"
        Me.Text = "PET SHOP"
        CType(Me.PetshopdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PetshopdbDataSet As WindowsApplication17.petshopdbDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As WindowsApplication17.petshopdbDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication17.petshopdbDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
