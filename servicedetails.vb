Public Class servicedetails

    Private Sub ServiceDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ServiceDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ServiceDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)

    End Sub

    Private Sub servicedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PetshopdbDataSet.ServiceDetails' table. You can move, or remove it, as needed.
        Me.ServiceDetailsTableAdapter.Fill(Me.PetshopdbDataSet.ServiceDetails)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ServiceDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)
    End Sub
End Class