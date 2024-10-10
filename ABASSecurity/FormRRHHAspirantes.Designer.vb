<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRRHHAspirantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza RRHH Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombrecompletoLabel As System.Windows.Forms.Label
        Dim IdentidadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim Telefono1Label As System.Windows.Forms.Label
        Dim Telefono2Label As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim AreadeaplicacionLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim IdaspiranteLabel As System.Windows.Forms.Label
        Me.NombrecompletoTextBox = New System.Windows.Forms.TextBox()
        Me.AspirantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.IdentidadTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono1TextBox = New System.Windows.Forms.TextBox()
        Me.Telefono2TextBox = New System.Windows.Forms.TextBox()
        Me.AreadeaplicacionTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.AspirantesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idaspirante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.Ciudad = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.IdaspiranteTextBox = New System.Windows.Forms.TextBox()
        Me.AspirantesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.AspirantesTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        NombrecompletoLabel = New System.Windows.Forms.Label()
        IdentidadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        Telefono1Label = New System.Windows.Forms.Label()
        Telefono2Label = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        AreadeaplicacionLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        IdaspiranteLabel = New System.Windows.Forms.Label()
        CType(Me.AspirantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AspirantesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombrecompletoLabel
        '
        NombrecompletoLabel.AutoSize = True
        NombrecompletoLabel.Location = New System.Drawing.Point(11, 49)
        NombrecompletoLabel.Name = "NombrecompletoLabel"
        NombrecompletoLabel.Size = New System.Drawing.Size(94, 13)
        NombrecompletoLabel.TabIndex = 1
        NombrecompletoLabel.Text = "Nombre Completo:"
        '
        'IdentidadLabel
        '
        IdentidadLabel.AutoSize = True
        IdentidadLabel.Location = New System.Drawing.Point(19, 22)
        IdentidadLabel.Name = "IdentidadLabel"
        IdentidadLabel.Size = New System.Drawing.Size(86, 13)
        IdentidadLabel.TabIndex = 2
        IdentidadLabel.Text = "No de Identidad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(50, 74)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 4
        DireccionLabel.Text = "Direccion:"
        '
        'Telefono1Label
        '
        Telefono1Label.AutoSize = True
        Telefono1Label.Location = New System.Drawing.Point(47, 101)
        Telefono1Label.Name = "Telefono1Label"
        Telefono1Label.Size = New System.Drawing.Size(58, 13)
        Telefono1Label.TabIndex = 6
        Telefono1Label.Text = "Telefono1:"
        '
        'Telefono2Label
        '
        Telefono2Label.AutoSize = True
        Telefono2Label.Location = New System.Drawing.Point(47, 127)
        Telefono2Label.Name = "Telefono2Label"
        Telefono2Label.Size = New System.Drawing.Size(58, 13)
        Telefono2Label.TabIndex = 8
        Telefono2Label.Text = "Telefono2:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(68, 24)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 10
        CiudadLabel.Text = "Ciudad:"
        '
        'AreadeaplicacionLabel
        '
        AreadeaplicacionLabel.AutoSize = True
        AreadeaplicacionLabel.Location = New System.Drawing.Point(12, 49)
        AreadeaplicacionLabel.Name = "AreadeaplicacionLabel"
        AreadeaplicacionLabel.Size = New System.Drawing.Size(99, 13)
        AreadeaplicacionLabel.TabIndex = 12
        AreadeaplicacionLabel.Text = "Area de Aplicacion:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(41, 74)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 14
        ObservacionLabel.Text = "Observacion:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(240, 51)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(93, 13)
        FechaLabel.TabIndex = 15
        FechaLabel.Text = "Fecha que Aplico:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(68, 128)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 54
        EstadoLabel.Text = "Estado:"
        '
        'IdaspiranteLabel
        '
        IdaspiranteLabel.AutoSize = True
        IdaspiranteLabel.Location = New System.Drawing.Point(700, 193)
        IdaspiranteLabel.Name = "IdaspiranteLabel"
        IdaspiranteLabel.Size = New System.Drawing.Size(61, 13)
        IdaspiranteLabel.TabIndex = 34
        IdaspiranteLabel.Text = "idaspirante:"
        IdaspiranteLabel.Visible = False
        '
        'NombrecompletoTextBox
        '
        Me.NombrecompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "nombrecompleto", True))
        Me.NombrecompletoTextBox.Location = New System.Drawing.Point(111, 46)
        Me.NombrecompletoTextBox.Name = "NombrecompletoTextBox"
        Me.NombrecompletoTextBox.Size = New System.Drawing.Size(198, 20)
        Me.NombrecompletoTextBox.TabIndex = 2
        '
        'AspirantesBindingSource
        '
        Me.AspirantesBindingSource.DataMember = "Aspirantes"
        Me.AspirantesBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdentidadTextBox
        '
        Me.IdentidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "identidad", True))
        Me.IdentidadTextBox.Location = New System.Drawing.Point(111, 19)
        Me.IdentidadTextBox.MaxLength = 15
        Me.IdentidadTextBox.Name = "IdentidadTextBox"
        Me.IdentidadTextBox.Size = New System.Drawing.Size(198, 20)
        Me.IdentidadTextBox.TabIndex = 3
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(111, 72)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(198, 20)
        Me.DireccionTextBox.TabIndex = 5
        '
        'Telefono1TextBox
        '
        Me.Telefono1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "telefono1", True))
        Me.Telefono1TextBox.Location = New System.Drawing.Point(111, 98)
        Me.Telefono1TextBox.MaxLength = 9
        Me.Telefono1TextBox.Name = "Telefono1TextBox"
        Me.Telefono1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono1TextBox.TabIndex = 7
        '
        'Telefono2TextBox
        '
        Me.Telefono2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "telefono2", True))
        Me.Telefono2TextBox.Location = New System.Drawing.Point(111, 124)
        Me.Telefono2TextBox.MaxLength = 9
        Me.Telefono2TextBox.Name = "Telefono2TextBox"
        Me.Telefono2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono2TextBox.TabIndex = 9
        '
        'AreadeaplicacionTextBox
        '
        Me.AreadeaplicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "areadeaplicacion", True))
        Me.AreadeaplicacionTextBox.Location = New System.Drawing.Point(117, 46)
        Me.AreadeaplicacionTextBox.Name = "AreadeaplicacionTextBox"
        Me.AreadeaplicacionTextBox.Size = New System.Drawing.Size(117, 20)
        Me.AreadeaplicacionTextBox.TabIndex = 13
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(117, 74)
        Me.ObservacionTextBox.MaxLength = 200
        Me.ObservacionTextBox.Multiline = True
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(304, 45)
        Me.ObservacionTextBox.TabIndex = 15
        '
        'AspirantesDataGridView
        '
        Me.AspirantesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AspirantesDataGridView.AutoGenerateColumns = False
        Me.AspirantesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AspirantesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.AspirantesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.AspirantesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AspirantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AspirantesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.fecha, Me.DataGridViewTextBoxColumn8, Me.estado, Me.idaspirante})
        Me.AspirantesDataGridView.DataSource = Me.AspirantesBindingSource
        Me.AspirantesDataGridView.Location = New System.Drawing.Point(0, 272)
        Me.AspirantesDataGridView.Name = "AspirantesDataGridView"
        Me.AspirantesDataGridView.RowHeadersVisible = False
        Me.AspirantesDataGridView.Size = New System.Drawing.Size(965, 410)
        Me.AspirantesDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nombrecompleto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Completo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 106
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "identidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "No de Identidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 99
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefono1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefono2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telefono2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "areadeaplicacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Area de Aplicacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 111
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 62
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 92
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Width = 65
        '
        'idaspirante
        '
        Me.idaspirante.DataPropertyName = "idaspirante"
        Me.idaspirante.HeaderText = "idaspirante"
        Me.idaspirante.Name = "idaspirante"
        Me.idaspirante.ReadOnly = True
        Me.idaspirante.Visible = False
        Me.idaspirante.Width = 83
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(965, 34)
        Me.Label35.TabIndex = 28
        Me.Label35.Text = "Registro de Aspirantes"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NombrecompletoTextBox)
        Me.GroupBox1.Controls.Add(NombrecompletoLabel)
        Me.GroupBox1.Controls.Add(Me.IdentidadTextBox)
        Me.GroupBox1.Controls.Add(IdentidadLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.Telefono1TextBox)
        Me.GroupBox1.Controls.Add(Telefono1Label)
        Me.GroupBox1.Controls.Add(Me.Telefono2TextBox)
        Me.GroupBox1.Controls.Add(Telefono2Label)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 165)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNuevo.FlatAppearance.BorderSize = 0
        Me.cmdNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(16, 190)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(105, 27)
        Me.cmdNuevo.TabIndex = 33
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(EstadoLabel)
        Me.GroupBox2.Controls.Add(Me.EstadoComboBox)
        Me.GroupBox2.Controls.Add(Me.Ciudad)
        Me.GroupBox2.Controls.Add(FechaLabel)
        Me.GroupBox2.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.ObservacionTextBox)
        Me.GroupBox2.Controls.Add(CiudadLabel)
        Me.GroupBox2.Controls.Add(Me.AreadeaplicacionTextBox)
        Me.GroupBox2.Controls.Add(AreadeaplicacionLabel)
        Me.GroupBox2.Controls.Add(ObservacionLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(380, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 165)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Aplicacion"
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "estado", True))
        Me.EstadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"Seleccionar", "Pendiente", "Aprobado", "Rechazado"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(117, 125)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EstadoComboBox.TabIndex = 55
        '
        'Ciudad
        '
        Me.Ciudad.DropDownHeight = 100
        Me.Ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ciudad.FormattingEnabled = True
        Me.Ciudad.IntegralHeight = False
        Me.Ciudad.ItemHeight = 13
        Me.Ciudad.Items.AddRange(New Object() {"Azacualpa", "Choloma", "Copan Ruinas", "Cuyamel", "El Progreso", "La Ceiba", "La entrada, Copan", "La Esperanza, Intibuca", "Olanchito", "Omoa", "Peña Blanca", "Puerto Cortes", "Quimistan", "Saba, Colon", "San Juan Pueblo", "San Pedro Sula", "Santa Barbara", "Santa Cruz De Yojoa", "Santa Rita De Copan", "Santa Rosa De Copan", "Sonaguera", "Tela", "Tocoa", "Trinidad", "Villanueva", "Yamaranguila", "Yoro"})
        Me.Ciudad.Location = New System.Drawing.Point(117, 19)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(304, 21)
        Me.Ciudad.Sorted = True
        Me.Ciudad.TabIndex = 54
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AspirantesBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(339, 49)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(82, 20)
        Me.FechaDateTimePicker.TabIndex = 16
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdActualizar.Location = New System.Drawing.Point(260, 190)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(105, 27)
        Me.cmdActualizar.TabIndex = 56
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGuardar.FlatAppearance.BorderSize = 0
        Me.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.Location = New System.Drawing.Point(138, 190)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(105, 27)
        Me.cmdGuardar.TabIndex = 31
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'IdaspiranteTextBox
        '
        Me.IdaspiranteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AspirantesBindingSource, "idaspirante", True))
        Me.IdaspiranteTextBox.Location = New System.Drawing.Point(767, 190)
        Me.IdaspiranteTextBox.Name = "IdaspiranteTextBox"
        Me.IdaspiranteTextBox.Size = New System.Drawing.Size(51, 20)
        Me.IdaspiranteTextBox.TabIndex = 35
        Me.IdaspiranteTextBox.Visible = False
        '
        'AspirantesTableAdapter
        '
        Me.AspirantesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnticiposTableAdapter = Nothing
        Me.TableAdapterManager.ArmeriaTableAdapter = Nothing
        Me.TableAdapterManager.AsignacionesTableAdapter = Nothing
        Me.TableAdapterManager.AspirantesTableAdapter = Me.AspirantesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BloqueoInventarioTableAdapter = Nothing
        Me.TableAdapterManager.CarnetTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeTableAdapter = Nothing
        Me.TableAdapterManager.DiasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EquiposTableAdapter = Nothing
        Me.TableAdapterManager.ExpedientesTableAdapter = Nothing
        Me.TableAdapterManager.FaltasTableAdapter = Nothing
        Me.TableAdapterManager.FormaPagoTableAdapter = Nothing
        Me.TableAdapterManager.ImagenesTableAdapter = Nothing
        Me.TableAdapterManager.InactivosTableAdapter = Nothing
        Me.TableAdapterManager.MaterialesRIngresosTableAdapter = Nothing
        Me.TableAdapterManager.MaterialesTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoArmasTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoEquiposTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoMaterialesTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoUniformesTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RecordatorioTableAdapter = Nothing
        Me.TableAdapterManager.RegistroCarnetTableAdapter = Nothing
        Me.TableAdapterManager.RegistroLoginTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudUniformeTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UbicacionesTableAdapter = Nothing
        Me.TableAdapterManager.UniformesRIngresosTableAdapter = Nothing
        Me.TableAdapterManager.UniformesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateNVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosModulosTableAdapter = Nothing
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdActualizar)
        Me.GroupBox3.Controls.Add(IdaspiranteLabel)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.IdaspiranteTextBox)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.cmdNuevo)
        Me.GroupBox3.Controls.Add(Me.cmdGuardar)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 229)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "*Para cargar los datos, escriba la identidad o seleccione una ciudad."
        '
        'FormRRHHAspirantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 684)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.AspirantesDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRRHHAspirantes"
        Me.Text = "FormAspirantes"
        CType(Me.AspirantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AspirantesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents AspirantesBindingSource As BindingSource
    Friend WithEvents AspirantesTableAdapter As ABASDataSetTableAdapters.AspirantesTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombrecompletoTextBox As TextBox
    Friend WithEvents IdentidadTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents Telefono1TextBox As TextBox
    Friend WithEvents Telefono2TextBox As TextBox
    Friend WithEvents AreadeaplicacionTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents AspirantesDataGridView As DataGridView
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents Ciudad As ComboBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents idaspirante As DataGridViewTextBoxColumn
    Friend WithEvents IdaspiranteTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
