Public Class suppliers

    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)

    End Sub

    Private Sub suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PetshopdbDataSet.suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.PetshopdbDataSet.suppliers)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.SuppliersBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SuppliersBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SuppliersBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.SuppliersBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.SuppliersBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.SuppliersBindingSource.RemoveCurrent()
    End Sub
End Class