Public Class order

    Private Sub Order1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Order1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)

    End Sub

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PetshopdbDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.PetshopdbDataSet.Payment)
        'TODO: This line of code loads data into the 'PetshopdbDataSet.Order1' table. You can move, or remove it, as needed.
        Me.Order1TableAdapter.Fill(Me.PetshopdbDataSet.Order1)
       


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Order1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        P_idTextBox.Visible = True
        O_idTextBox1.Visible = True
        P_dateDateTimePicker.Visible = True
        P_methodTextBox.Visible = True





    End Sub

    Private Sub P_idLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class