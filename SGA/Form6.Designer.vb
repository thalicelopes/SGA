<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SGADataSet = New SGA.SGADataSet()
        Me.ALUNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUNOTableAdapter = New SGA.SGADataSetTableAdapters.ALUNOTableAdapter()
        Me.CONSULTABOLETIMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTABOLETIMTableAdapter = New SGA.SGADataSetTableAdapters.CONSULTABOLETIMTableAdapter()
        Me.TableAdapterManager = New SGA.SGADataSetTableAdapters.TableAdapterManager()
        Me.CONSULTABOLETIMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SGADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTABOLETIMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTABOLETIMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(366, 385)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Voltar à Página Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecione o Aluno: "
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ALUNOBindingSource
        Me.ComboBox1.DisplayMember = "NOME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "NOME"
        '
        'SGADataSet
        '
        Me.SGADataSet.DataSetName = "SGADataSet"
        Me.SGADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUNOBindingSource
        '
        Me.ALUNOBindingSource.DataMember = "ALUNO"
        Me.ALUNOBindingSource.DataSource = Me.SGADataSet
        '
        'ALUNOTableAdapter
        '
        Me.ALUNOTableAdapter.ClearBeforeFill = True
        '
        'CONSULTABOLETIMBindingSource
        '
        Me.CONSULTABOLETIMBindingSource.DataMember = "CONSULTABOLETIM"
        Me.CONSULTABOLETIMBindingSource.DataSource = Me.SGADataSet
        '
        'CONSULTABOLETIMTableAdapter
        '
        Me.CONSULTABOLETIMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Me.ALUNOTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Nothing
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Nothing
        Me.TableAdapterManager.TURMATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGA.SGADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONSULTABOLETIMDataGridView
        '
        Me.CONSULTABOLETIMDataGridView.AutoGenerateColumns = False
        Me.CONSULTABOLETIMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTABOLETIMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CONSULTABOLETIMDataGridView.DataSource = Me.CONSULTABOLETIMBindingSource
        Me.CONSULTABOLETIMDataGridView.Location = New System.Drawing.Point(98, 91)
        Me.CONSULTABOLETIMDataGridView.Name = "CONSULTABOLETIMDataGridView"
        Me.CONSULTABOLETIMDataGridView.Size = New System.Drawing.Size(341, 220)
        Me.CONSULTABOLETIMDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ALUNO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ALUNO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CURSO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CURSO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOTA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOTA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 418)
        Me.Controls.Add(Me.CONSULTABOLETIMDataGridView)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Name = "Form6"
        Me.Text = "Emissão de Boletins"
        CType(Me.SGADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTABOLETIMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTABOLETIMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SGADataSet As SGADataSet
    Friend WithEvents ALUNOBindingSource As BindingSource
    Friend WithEvents ALUNOTableAdapter As SGADataSetTableAdapters.ALUNOTableAdapter
    Friend WithEvents CONSULTABOLETIMBindingSource As BindingSource
    Friend WithEvents CONSULTABOLETIMTableAdapter As SGADataSetTableAdapters.CONSULTABOLETIMTableAdapter
    Friend WithEvents TableAdapterManager As SGADataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTABOLETIMDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
