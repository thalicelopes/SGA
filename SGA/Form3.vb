Public Class Form3
    Private Sub ALUNOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ALUNOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUNOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGADataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUNOTableAdapter.Fill(Me.SGADataSet.ALUNO)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
End Class