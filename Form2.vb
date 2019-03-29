Public Class Form2

    Private Sub Order1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Order1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PetshopdbDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.PetshopdbDataSet.Items)
        'TODO: This line of code loads data into the 'PetshopdbDataSet.Order1' table. You can move, or remove it, as needed.
        Me.Order1TableAdapter.Fill(Me.PetshopdbDataSet.Order1)

    End Sub
End Class