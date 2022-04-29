Public Class Form4
    Private Sub CURSOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CURSOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CURSOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGADataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.CURSO'. Você pode movê-la ou removê-la conforme necessário.
        Me.CURSOTableAdapter.Fill(Me.SGADataSet.CURSO)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
End Class