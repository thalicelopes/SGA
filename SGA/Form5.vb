Public Class Form5
    Private Sub TURMABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TURMABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TURMABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGADataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUNOTableAdapter.Fill(Me.SGADataSet.ALUNO)
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.MATRICULA'. Você pode movê-la ou removê-la conforme necessário.
        Me.MATRICULATableAdapter.Fill(Me.SGADataSet.MATRICULA)
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.CURSO'. Você pode movê-la ou removê-la conforme necessário.
        Me.CURSOTableAdapter.Fill(Me.SGADataSet.CURSO)
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.PROFESSOR'. Você pode movê-la ou removê-la conforme necessário.
        Me.PROFESSORTableAdapter.Fill(Me.SGADataSet.PROFESSOR)
        'TODO: esta linha de código carrega dados na tabela 'SGADataSet.TURMA'. Você pode movê-la ou removê-la conforme necessário.
        Me.TURMATableAdapter.Fill(Me.SGADataSet.TURMA)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim linha As DataGridViewRow
        Dim media As Double
        Dim cont As Integer

    End Sub
End Class