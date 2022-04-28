<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim PROFESSORLabel As System.Windows.Forms.Label
        Dim CURSOLabel As System.Windows.Forms.Label
        Dim CAPACIDADELabel As System.Windows.Forms.Label
        Dim DTINICIOLabel As System.Windows.Forms.Label
        Dim DTFIMLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim MEDIALabel As System.Windows.Forms.Label
        Me.SGADataSet = New SGA.SGADataSet()
        Me.TURMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURMATableAdapter = New SGA.SGADataSetTableAdapters.TURMATableAdapter()
        Me.TableAdapterManager = New SGA.SGADataSetTableAdapters.TableAdapterManager()
        Me.TURMABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TURMABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.PROFESSORComboBox = New System.Windows.Forms.ComboBox()
        Me.CURSOComboBox = New System.Windows.Forms.ComboBox()
        Me.CAPACIDADETextBox = New System.Windows.Forms.TextBox()
        Me.DTINICIODateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DTFIMDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.PROFESSORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFESSORTableAdapter = New SGA.SGADataSetTableAdapters.PROFESSORTableAdapter()
        Me.CURSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CURSOTableAdapter = New SGA.SGADataSetTableAdapters.CURSOTableAdapter()
        Me.MATRICULABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATRICULATableAdapter = New SGA.SGADataSetTableAdapters.MATRICULATableAdapter()
        Me.MATRICULADataGridView = New System.Windows.Forms.DataGridView()
        Me.ALUNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUNOTableAdapter = New SGA.SGADataSetTableAdapters.ALUNOTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDIATextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CODIGOLabel = New System.Windows.Forms.Label()
        PROFESSORLabel = New System.Windows.Forms.Label()
        CURSOLabel = New System.Windows.Forms.Label()
        CAPACIDADELabel = New System.Windows.Forms.Label()
        DTINICIOLabel = New System.Windows.Forms.Label()
        DTFIMLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        MEDIALabel = New System.Windows.Forms.Label()
        CType(Me.SGADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURMABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TURMABindingNavigator.SuspendLayout()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SGADataSet
        '
        Me.SGADataSet.DataSetName = "SGADataSet"
        Me.SGADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TURMABindingSource
        '
        Me.TURMABindingSource.DataMember = "TURMA"
        Me.TURMABindingSource.DataSource = Me.SGADataSet
        '
        'TURMATableAdapter
        '
        Me.TURMATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Me.ALUNOTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Me.CURSOTableAdapter
        Me.TableAdapterManager.MATRICULATableAdapter = Me.MATRICULATableAdapter
        Me.TableAdapterManager.PROFESSORTableAdapter = Me.PROFESSORTableAdapter
        Me.TableAdapterManager.TURMATableAdapter = Me.TURMATableAdapter
        Me.TableAdapterManager.UpdateOrder = SGA.SGADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TURMABindingNavigator
        '
        Me.TURMABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TURMABindingNavigator.BindingSource = Me.TURMABindingSource
        Me.TURMABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TURMABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TURMABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TURMABindingNavigatorSaveItem})
        Me.TURMABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TURMABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TURMABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TURMABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TURMABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TURMABindingNavigator.Name = "TURMABindingNavigator"
        Me.TURMABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TURMABindingNavigator.Size = New System.Drawing.Size(424, 25)
        Me.TURMABindingNavigator.TabIndex = 0
        Me.TURMABindingNavigator.Text = "BindingNavigator1"
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
        'TURMABindingNavigatorSaveItem
        '
        Me.TURMABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TURMABindingNavigatorSaveItem.Image = CType(resources.GetObject("TURMABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TURMABindingNavigatorSaveItem.Name = "TURMABindingNavigatorSaveItem"
        Me.TURMABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TURMABindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(62, 53)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(146, 50)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'PROFESSORLabel
        '
        PROFESSORLabel.AutoSize = True
        PROFESSORLabel.Location = New System.Drawing.Point(62, 79)
        PROFESSORLabel.Name = "PROFESSORLabel"
        PROFESSORLabel.Size = New System.Drawing.Size(76, 13)
        PROFESSORLabel.TabIndex = 3
        PROFESSORLabel.Text = "PROFESSOR:"
        '
        'PROFESSORComboBox
        '
        Me.PROFESSORComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "PROFESSOR", True))
        Me.PROFESSORComboBox.DataSource = Me.PROFESSORBindingSource
        Me.PROFESSORComboBox.DisplayMember = "NOME"
        Me.PROFESSORComboBox.FormattingEnabled = True
        Me.PROFESSORComboBox.Location = New System.Drawing.Point(146, 76)
        Me.PROFESSORComboBox.Name = "PROFESSORComboBox"
        Me.PROFESSORComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PROFESSORComboBox.TabIndex = 4
        '
        'CURSOLabel
        '
        CURSOLabel.AutoSize = True
        CURSOLabel.Location = New System.Drawing.Point(62, 106)
        CURSOLabel.Name = "CURSOLabel"
        CURSOLabel.Size = New System.Drawing.Size(48, 13)
        CURSOLabel.TabIndex = 5
        CURSOLabel.Text = "CURSO:"
        '
        'CURSOComboBox
        '
        Me.CURSOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CURSO", True))
        Me.CURSOComboBox.DataSource = Me.CURSOBindingSource
        Me.CURSOComboBox.DisplayMember = "NOME"
        Me.CURSOComboBox.FormattingEnabled = True
        Me.CURSOComboBox.Location = New System.Drawing.Point(146, 103)
        Me.CURSOComboBox.Name = "CURSOComboBox"
        Me.CURSOComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CURSOComboBox.TabIndex = 6
        '
        'CAPACIDADELabel
        '
        CAPACIDADELabel.AutoSize = True
        CAPACIDADELabel.Location = New System.Drawing.Point(62, 133)
        CAPACIDADELabel.Name = "CAPACIDADELabel"
        CAPACIDADELabel.Size = New System.Drawing.Size(78, 13)
        CAPACIDADELabel.TabIndex = 7
        CAPACIDADELabel.Text = "CAPACIDADE:"
        '
        'CAPACIDADETextBox
        '
        Me.CAPACIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CAPACIDADE", True))
        Me.CAPACIDADETextBox.Location = New System.Drawing.Point(146, 130)
        Me.CAPACIDADETextBox.Name = "CAPACIDADETextBox"
        Me.CAPACIDADETextBox.Size = New System.Drawing.Size(200, 20)
        Me.CAPACIDADETextBox.TabIndex = 8
        '
        'DTINICIOLabel
        '
        DTINICIOLabel.AutoSize = True
        DTINICIOLabel.Location = New System.Drawing.Point(62, 160)
        DTINICIOLabel.Name = "DTINICIOLabel"
        DTINICIOLabel.Size = New System.Drawing.Size(57, 13)
        DTINICIOLabel.TabIndex = 9
        DTINICIOLabel.Text = "DTINICIO:"
        '
        'DTINICIODateTimePicker
        '
        Me.DTINICIODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TURMABindingSource, "DTINICIO", True))
        Me.DTINICIODateTimePicker.Location = New System.Drawing.Point(146, 156)
        Me.DTINICIODateTimePicker.Name = "DTINICIODateTimePicker"
        Me.DTINICIODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DTINICIODateTimePicker.TabIndex = 10
        '
        'DTFIMLabel
        '
        DTFIMLabel.AutoSize = True
        DTFIMLabel.Location = New System.Drawing.Point(62, 186)
        DTFIMLabel.Name = "DTFIMLabel"
        DTFIMLabel.Size = New System.Drawing.Size(43, 13)
        DTFIMLabel.TabIndex = 11
        DTFIMLabel.Text = "DTFIM:"
        '
        'DTFIMDateTimePicker
        '
        Me.DTFIMDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TURMABindingSource, "DTFIM", True))
        Me.DTFIMDateTimePicker.Location = New System.Drawing.Point(146, 182)
        Me.DTFIMDateTimePicker.Name = "DTFIMDateTimePicker"
        Me.DTFIMDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DTFIMDateTimePicker.TabIndex = 12
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(62, 211)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 13
        OBSLabel.Text = "OBS:"
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(146, 208)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(200, 58)
        Me.OBSTextBox.TabIndex = 14
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
        'CURSOBindingSource
        '
        Me.CURSOBindingSource.DataMember = "CURSO"
        Me.CURSOBindingSource.DataSource = Me.SGADataSet
        '
        'CURSOTableAdapter
        '
        Me.CURSOTableAdapter.ClearBeforeFill = True
        '
        'MATRICULABindingSource
        '
        Me.MATRICULABindingSource.DataMember = "TURMA_MATRICULA"
        Me.MATRICULABindingSource.DataSource = Me.TURMABindingSource
        '
        'MATRICULATableAdapter
        '
        Me.MATRICULATableAdapter.ClearBeforeFill = True
        '
        'MATRICULADataGridView
        '
        Me.MATRICULADataGridView.AutoGenerateColumns = False
        Me.MATRICULADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MATRICULADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MATRICULADataGridView.DataSource = Me.MATRICULABindingSource
        Me.MATRICULADataGridView.Location = New System.Drawing.Point(82, 272)
        Me.MATRICULADataGridView.Name = "MATRICULADataGridView"
        Me.MATRICULADataGridView.Size = New System.Drawing.Size(243, 220)
        Me.MATRICULADataGridView.TabIndex = 15
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TURMA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TURMA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ALUNO"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ALUNOBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "NOME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ALUNO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOTA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOTA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'MEDIALabel
        '
        MEDIALabel.AutoSize = True
        MEDIALabel.Location = New System.Drawing.Point(126, 517)
        MEDIALabel.Name = "MEDIALabel"
        MEDIALabel.Size = New System.Drawing.Size(44, 13)
        MEDIALabel.TabIndex = 16
        MEDIALabel.Text = "MEDIA:"
        '
        'MEDIATextBox
        '
        Me.MEDIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "MEDIA", True))
        Me.MEDIATextBox.Enabled = False
        Me.MEDIATextBox.Location = New System.Drawing.Point(176, 514)
        Me.MEDIATextBox.Name = "MEDIATextBox"
        Me.MEDIATextBox.Size = New System.Drawing.Size(100, 20)
        Me.MEDIATextBox.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 598)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MEDIALabel)
        Me.Controls.Add(Me.MEDIATextBox)
        Me.Controls.Add(Me.MATRICULADataGridView)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(PROFESSORLabel)
        Me.Controls.Add(Me.PROFESSORComboBox)
        Me.Controls.Add(CURSOLabel)
        Me.Controls.Add(Me.CURSOComboBox)
        Me.Controls.Add(CAPACIDADELabel)
        Me.Controls.Add(Me.CAPACIDADETextBox)
        Me.Controls.Add(DTINICIOLabel)
        Me.Controls.Add(Me.DTINICIODateTimePicker)
        Me.Controls.Add(DTFIMLabel)
        Me.Controls.Add(Me.DTFIMDateTimePicker)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.TURMABindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Cadastro de Turmas"
        CType(Me.SGADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURMABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TURMABindingNavigator.ResumeLayout(False)
        Me.TURMABindingNavigator.PerformLayout()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SGADataSet As SGADataSet
    Friend WithEvents TURMABindingSource As BindingSource
    Friend WithEvents TURMATableAdapter As SGADataSetTableAdapters.TURMATableAdapter
    Friend WithEvents TableAdapterManager As SGADataSetTableAdapters.TableAdapterManager
    Friend WithEvents TURMABindingNavigator As BindingNavigator
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
    Friend WithEvents TURMABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PROFESSORTableAdapter As SGADataSetTableAdapters.PROFESSORTableAdapter
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents PROFESSORComboBox As ComboBox
    Friend WithEvents CURSOComboBox As ComboBox
    Friend WithEvents CAPACIDADETextBox As TextBox
    Friend WithEvents DTINICIODateTimePicker As DateTimePicker
    Friend WithEvents DTFIMDateTimePicker As DateTimePicker
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents PROFESSORBindingSource As BindingSource
    Friend WithEvents CURSOTableAdapter As SGADataSetTableAdapters.CURSOTableAdapter
    Friend WithEvents CURSOBindingSource As BindingSource
    Friend WithEvents MATRICULATableAdapter As SGADataSetTableAdapters.MATRICULATableAdapter
    Friend WithEvents MATRICULABindingSource As BindingSource
    Friend WithEvents ALUNOTableAdapter As SGADataSetTableAdapters.ALUNOTableAdapter
    Friend WithEvents MATRICULADataGridView As DataGridView
    Friend WithEvents ALUNOBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents MEDIATextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
