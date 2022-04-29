Public Class Form6
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUNOTableAdapter.Fill(Me.SGADataSet.ALUNO)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.CONSULTABOLETIMTableAdapter.Fill(Me.SGADataSet.CONSULTABOLETIM, ComboBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class