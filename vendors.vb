﻿Public Class vendors

    Private Sub VendorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VendorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)

    End Sub

    Private Sub vendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PetshopdbDataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.PetshopdbDataSet.Vendors)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.VendorsBindingSource.MoveFirst()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        items.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VendorsBindingSource.MoveNext()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.VendorsBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.VendorsBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.VendorsBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Validate()
        Me.VendorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PetshopdbDataSet)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.VendorsBindingSource.RemoveCurrent()
    End Sub
End Class