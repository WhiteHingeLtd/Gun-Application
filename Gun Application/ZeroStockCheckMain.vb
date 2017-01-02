Public Class ZeroStockCheckMain

    Public Sub SearchForMinis(starts As String, ends As String)
        Me.WhlnewTableAdapter.GetLows(Me.WhldataDataSet.whlnew, starts, ends)
        AstatusTextBox.Focus()
    End Sub

    Private Sub WhlnewBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WhlnewBindingNavigatorSaveItem1.Click
        Me.Validate()
        Me.WhlnewBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WhldataDataSet)

    End Sub

    Private Sub ZeroStockCheckMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WhldataDataSet.whlnew' table. You can move, or remove it, as needed.

    End Sub

    Private Sub AstatusTextBox_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.Validate()
            Me.WhlnewBindingSource.EndEdit()
            Try
                Me.TableAdapterManager.UpdateAll(Me.WhldataDataSet)
            Catch ex As System.Data.DBConcurrencyException
                Me.WhlnewTableAdapter.Update(Me.WhldataDataSet)
            End Try

            BindingNavigatorMoveNextItem1.PerformClick()

            AstatusTextBox.Text = ""
            AstatusTextBox.Focus()
        End If
    End Sub


    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        WhlnewBindingNavigatorSaveItem1.PerformClick()
        Me.Close()
        MainMenu.Activate()
    End Sub

    Private Sub MinTextBox_TextChanged(sender As Object, e As EventArgs)
        If MinTextBox.Text = "-1" Then
            BindingNavigatorMoveNextItem.PerformClick()
        End If
    End Sub

    Private Sub WhlnewBindingNavigatorSaveItem1_Click(sender As Object, e As EventArgs) Handles WhlnewBindingNavigatorSaveItem1.Click
        Me.Validate()
        Me.WhlnewBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WhldataDataSet)

    End Sub

    Private Sub ZeroStockCheckMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub

    Private Sub LabelshortTextBox_TextChanged(sender As Object, e As EventArgs) Handles LabelshortTextBox.TextChanged

    End Sub

    Private Sub AstatusTextBox_KeyUp_1(sender As Object, e As KeyEventArgs) Handles AstatusTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BindingNavigatorMoveNextItem1.PerformClick()
        End If
    End Sub
End Class