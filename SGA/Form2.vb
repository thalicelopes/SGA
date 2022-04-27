Public Class Form2
    Private Sub PROFESSORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PROFESSORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PROFESSORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGADataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.PROFESSOR'. Você pode movê-la ou removê-la conforme necessário.
        Me.PROFESSORTableAdapter.Fill(Me.SGADataSet.PROFESSOR)

    End Sub
End Class