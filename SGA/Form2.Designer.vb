<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim MATRICULALabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim SOBRENOMELabel As System.Windows.Forms.Label
        Dim TELEFONELabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim ESPECIALIDADELabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim FOTOLabel As System.Windows.Forms.Label
        Me.SGADataSet = New SGA.SGADataSet()
        Me.PROFESSORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFESSORTableAdapter = New SGA.SGADataSetTableAdapters.PROFESSORTableAdapter()
        Me.TableAdapterManager = New SGA.SGADataSetTableAdapters.TableAdapterManager()
        Me.PROFESSORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PROFESSORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MATRICULATextBox = New System.Windows.Forms.TextBox()
        Me.NOMETextBox = New System.Windows.Forms.TextBox()
        Me.SOBRENOMETextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONEMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.ESPECIALIDADETextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.FOTOPictureBox = New System.Windows.Forms.PictureBox()
        MATRICULALabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        SOBRENOMELabel = New System.Windows.Forms.Label()
        TELEFONELabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        ESPECIALIDADELabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        FOTOLabel = New System.Windows.Forms.Label()
        CType(Me.SGADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFESSORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PROFESSORBindingNavigator.SuspendLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SGADataSet
        '
        Me.SGADataSet.DataSetName = "SGADataSet"
        Me.SGADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROFESSORBindingSource
        '
        Me.PROFESSORBindingSource.DataMember = "PROFESSOR"
        Me.PROFESSORBindingSource.DataSource = Me.SGADataSet
        '
        'PROFESSORTableAdapter
        '
        Me.PROFESSORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Nothing
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Me.PROFESSORTableAdapter
        Me.TableAdapterManager.TURMATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGA.SGADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PROFESSORBindingNavigator
        '
        Me.PROFESSORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PROFESSORBindingNavigator.BindingSource = Me.PROFESSORBindingSource
        Me.PROFESSORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PROFESSORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PROFESSORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PROFESSORBindingNavigatorSaveItem})
        Me.PROFESSORBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PROFESSORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PROFESSORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PROFESSORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PROFESSORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PROFESSORBindingNavigator.Name = "PROFESSORBindingNavigator"
        Me.PROFESSORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PROFESSORBindingNavigator.Size = New System.Drawing.Size(520, 25)
        Me.PROFESSORBindingNavigator.TabIndex = 0
        Me.PROFESSORBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'PROFESSORBindingNavigatorSaveItem
        '
        Me.PROFESSORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PROFESSORBindingNavigatorSaveItem.Image = CType(resources.GetObject("PROFESSORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PROFESSORBindingNavigatorSaveItem.Name = "PROFESSORBindingNavigatorSaveItem"
        Me.PROFESSORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PROFESSORBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'MATRICULALabel
        '
        MATRICULALabel.AutoSize = True
        MATRICULALabel.Location = New System.Drawing.Point(146, 47)
        MATRICULALabel.Name = "MATRICULALabel"
        MATRICULALabel.Size = New System.Drawing.Size(72, 13)
        MATRICULALabel.TabIndex = 1
        MATRICULALabel.Text = "MATRICULA:"
        '
        'MATRICULATextBox
        '
        Me.MATRICULATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROFESSORBindingSource, "MATRICULA", True))
        Me.MATRICULATextBox.Location = New System.Drawing.Point(246, 44)
        Me.MATRICULATextBox.Name = "MATRICULATextBox"
        Me.MATRICULATextBox.Size = New System.Drawing.Size(100, 20)
        Me.MATRICULATextBox.TabIndex = 2
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(146, 73)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROFESSORBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(246, 70)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'SOBRENOMELabel
        '
        SOBRENOMELabel.AutoSize = True
        SOBRENOMELabel.Location = New System.Drawing.Point(146, 99)
        SOBRENOMELabel.Name = "SOBRENOMELabel"
        SOBRENOMELabel.Size = New System.Drawing.Size(79, 13)
        SOBRENOMELabel.TabIndex = 5
        SOBRENOMELabel.Text = "SOBRENOME:"
        '
        'SOBRENOMETextBox
        '
        Me.SOBRENOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROFESSORBindingSource, "SOBRENOME", True))
        Me.SOBRENOMETextBox.Location = New System.Drawing.Point(246, 96)
        Me.SOBRENOMETextBox.Name = "SOBRENOMETextBox"
        Me.SOBRENOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.SOBRENOMETextBox.TabIndex = 6
        '
        'TELEFONELabel
        '
        TELEFONELabel.AutoSize = True
        TELEFONELabel.Location = New System.Drawing.Point(146, 125)
        TELEFONELabel.Name = "TELEFONELabel"
        TELEFONELabel.Size = New System.Drawing.Size(66, 13)
        TELEFONELabel.TabIndex = 7
        TELEFONELabel.Text = "TELEFONE:"
        '
        'TELEFONEMaskedTextBox
        '
        Me.TELEFONEMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROFESSORBindingSource, "TELEFONE", True))
        Me.TELEFONEMaskedTextBox.Location = New System.Drawing.Point(246, 122)
        Me.TELEFONEMaskedTextBox.Name = "TELEFONEMaskedTextBox"
        Me.TELEFONEMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TELEFONEMaskedTextBox.TabIndex = 8
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(146, 151)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(42, 13)
        EMAILLabel.TabIndex = 9
        EMAILLabel.Text = "EMAIL:"
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROFESSORBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(246, 148)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EMAILTextBox.TabIndex = 10
        '
        'ESPECIALIDADELabel
        '
        ESPECIALIDADELabel.AutoSize = True
        ESPECIALIDADELabel.Location = New System.Drawing.Point(146, 177)
        ESPECIALIDADELabel.Name = "ESPECIALIDADELabel"
        ESPECIALIDADELabel.Size = New System.Drawing.Size(94, 13)
        ESPECIALIDADELabel.TabIndex = 11
        ESPECIALIDADELabel.Text = "ESPECIALIDADE:"
        '
        'ESPECIALIDADETextBox
        '
        Me.ESPECIALIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROFESSORBindingSource, "ESPECIALIDADE", True))
        Me.ESPECIALIDADETextBox.Location = New System.Drawing.Point(246, 174)
        Me.ESPECIALIDADETextBox.Name = "ESPECIALIDADETextBox"
        Me.ESPECIALIDADETextBox.Size = New System.Drawing.Size(100, 20)
        Me.ESPECIALIDADETextBox.TabIndex = 12
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(146, 203)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 13
        OBSLabel.Text = "OBS:"
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROFESSORBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(246, 200)
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OBSTextBox.TabIndex = 14
        '
        'FOTOLabel
        '
        FOTOLabel.AutoSize = True
        FOTOLabel.Location = New System.Drawing.Point(146, 226)
        FOTOLabel.Name = "FOTOLabel"
        FOTOLabel.Size = New System.Drawing.Size(39, 13)
        FOTOLabel.TabIndex = 15
        FOTOLabel.Text = "FOTO:"
        '
        'FOTOPictureBox
        '
        Me.FOTOPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PROFESSORBindingSource, "FOTO", True))
        Me.FOTOPictureBox.Location = New System.Drawing.Point(246, 226)
        Me.FOTOPictureBox.Name = "FOTOPictureBox"
        Me.FOTOPictureBox.Size = New System.Drawing.Size(100, 75)
        Me.FOTOPictureBox.TabIndex = 16
        Me.FOTOPictureBox.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 358)
        Me.Controls.Add(MATRICULALabel)
        Me.Controls.Add(Me.MATRICULATextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(SOBRENOMELabel)
        Me.Controls.Add(Me.SOBRENOMETextBox)
        Me.Controls.Add(TELEFONELabel)
        Me.Controls.Add(Me.TELEFONEMaskedTextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(ESPECIALIDADELabel)
        Me.Controls.Add(Me.ESPECIALIDADETextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(FOTOLabel)
        Me.Controls.Add(Me.FOTOPictureBox)
        Me.Controls.Add(Me.PROFESSORBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Cadastro de Professores"
        CType(Me.SGADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFESSORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PROFESSORBindingNavigator.ResumeLayout(False)
        Me.PROFESSORBindingNavigator.PerformLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SGADataSet As SGADataSet
    Friend WithEvents PROFESSORBindingSource As BindingSource
    Friend WithEvents PROFESSORTableAdapter As SGADataSetTableAdapters.PROFESSORTableAdapter
    Friend WithEvents TableAdapterManager As SGADataSetTableAdapters.TableAdapterManager
    Friend WithEvents PROFESSORBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PROFESSORBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MATRICULATextBox As TextBox
    Friend WithEvents NOMETextBox As TextBox
    Friend WithEvents SOBRENOMETextBox As TextBox
    Friend WithEvents TELEFONEMaskedTextBox As MaskedTextBox
    Friend WithEvents EMAILTextBox As TextBox
    Friend WithEvents ESPECIALIDADETextBox As TextBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents FOTOPictureBox As PictureBox
End Class
