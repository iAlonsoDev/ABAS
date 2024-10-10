<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsignacionesCambios
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
        Dim IdasignacionLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim TurnoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim HorasLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim SucursalLabel As System.Windows.Forms.Label
        Dim HorasextrasLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupdeFiltro = New System.Windows.Forms.GroupBox()
        Me.panelCambioAsignacion = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SucursalComboBox = New System.Windows.Forms.ComboBox()
        Me.AsignacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdOcultar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TurnoComboBox = New System.Windows.Forms.ComboBox()
        Me.HorasTextBox = New System.Windows.Forms.TextBox()
        Me.HorasextrasTextBox = New System.Windows.Forms.TextBox()
        Me.IdasignacionTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.AsignacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horasextras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Day = New System.Windows.Forms.DateTimePicker()
        Me.Day2 = New System.Windows.Forms.DateTimePicker()
        Me.AsignacionesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.AsignacionesTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        IdasignacionLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        TurnoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        HorasLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        SucursalLabel = New System.Windows.Forms.Label()
        HorasextrasLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupdeFiltro.SuspendLayout()
        Me.panelCambioAsignacion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdasignacionLabel
        '
        IdasignacionLabel.AutoSize = True
        IdasignacionLabel.Location = New System.Drawing.Point(11, 104)
        IdasignacionLabel.Name = "IdasignacionLabel"
        IdasignacionLabel.Size = New System.Drawing.Size(69, 13)
        IdasignacionLabel.TabIndex = 0
        IdasignacionLabel.Text = "idasignacion:"
        IdasignacionLabel.Visible = False
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(19, 30)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(108, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo de Empleado:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(14, 21)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 4
        ClienteLabel.Text = "Cliente:"
        '
        'TurnoLabel
        '
        TurnoLabel.AutoSize = True
        TurnoLabel.Location = New System.Drawing.Point(42, 77)
        TurnoLabel.Name = "TurnoLabel"
        TurnoLabel.Size = New System.Drawing.Size(38, 13)
        TurnoLabel.TabIndex = 6
        TurnoLabel.Text = "Turno:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(16, 75)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 8
        FechaLabel.Text = "Fecha:"
        '
        'HorasLabel
        '
        HorasLabel.AutoSize = True
        HorasLabel.Location = New System.Drawing.Point(42, 30)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(38, 13)
        HorasLabel.TabIndex = 10
        HorasLabel.Text = "Horas:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(19, 307)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 12
        ObservacionLabel.Text = "Observacion:"
        '
        'SucursalLabel
        '
        SucursalLabel.AutoSize = True
        SucursalLabel.Location = New System.Drawing.Point(5, 48)
        SucursalLabel.Name = "SucursalLabel"
        SucursalLabel.Size = New System.Drawing.Size(51, 13)
        SucursalLabel.TabIndex = 16
        SucursalLabel.Text = "Sucursal:"
        '
        'HorasextrasLabel
        '
        HorasextrasLabel.AutoSize = True
        HorasextrasLabel.Location = New System.Drawing.Point(10, 53)
        HorasextrasLabel.Name = "HorasextrasLabel"
        HorasextrasLabel.Size = New System.Drawing.Size(70, 13)
        HorasextrasLabel.TabIndex = 40
        HorasextrasLabel.Text = "Horas Extras:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(15, 57)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(112, 13)
        Label3.TabIndex = 42
        Label3.Text = "Nombre de Empleado:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(43, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(43, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(232, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'GroupdeFiltro
        '
        Me.GroupdeFiltro.Controls.Add(Me.DateTimePicker1)
        Me.GroupdeFiltro.Controls.Add(Me.DateTimePicker2)
        Me.GroupdeFiltro.Location = New System.Drawing.Point(12, 9)
        Me.GroupdeFiltro.Name = "GroupdeFiltro"
        Me.GroupdeFiltro.Size = New System.Drawing.Size(321, 92)
        Me.GroupdeFiltro.TabIndex = 4
        Me.GroupdeFiltro.TabStop = False
        Me.GroupdeFiltro.Text = "Filtro de Asignaciones por Fecha"
        '
        'panelCambioAsignacion
        '
        Me.panelCambioAsignacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelCambioAsignacion.BackColor = System.Drawing.SystemColors.Control
        Me.panelCambioAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCambioAsignacion.Controls.Add(Me.Label1)
        Me.panelCambioAsignacion.Controls.Add(Me.GroupBox2)
        Me.panelCambioAsignacion.Controls.Add(Me.GroupBox1)
        Me.panelCambioAsignacion.Controls.Add(Me.cmdEliminar)
        Me.panelCambioAsignacion.Controls.Add(Me.cmdOcultar)
        Me.panelCambioAsignacion.Controls.Add(Me.cmdActualizar)
        Me.panelCambioAsignacion.Controls.Add(Me.ObservacionTextBox)
        Me.panelCambioAsignacion.Controls.Add(ObservacionLabel)
        Me.panelCambioAsignacion.Controls.Add(Me.GroupBox3)
        Me.panelCambioAsignacion.Location = New System.Drawing.Point(118, 135)
        Me.panelCambioAsignacion.Name = "panelCambioAsignacion"
        Me.panelCambioAsignacion.Size = New System.Drawing.Size(711, 458)
        Me.panelCambioAsignacion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(709, 29)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Cambio de Asignaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SucursalComboBox)
        Me.GroupBox2.Controls.Add(SucursalLabel)
        Me.GroupBox2.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox2.Controls.Add(ClienteLabel)
        Me.GroupBox2.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox2.Controls.Add(FechaLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 108)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Asignacion"
        '
        'SucursalComboBox
        '
        Me.SucursalComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SucursalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "sucursal", True))
        Me.SucursalComboBox.DropDownHeight = 100
        Me.SucursalComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SucursalComboBox.FormattingEnabled = True
        Me.SucursalComboBox.IntegralHeight = False
        Me.SucursalComboBox.Location = New System.Drawing.Point(62, 45)
        Me.SucursalComboBox.Name = "SucursalComboBox"
        Me.SucursalComboBox.Size = New System.Drawing.Size(343, 21)
        Me.SucursalComboBox.Sorted = True
        Me.SucursalComboBox.TabIndex = 17
        '
        'AsignacionesBindingSource
        '
        Me.AsignacionesBindingSource.DataMember = "Asignaciones"
        Me.AsignacionesBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "cliente", True))
        Me.ClienteComboBox.DropDownHeight = 100
        Me.ClienteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.IntegralHeight = False
        Me.ClienteComboBox.Location = New System.Drawing.Point(62, 18)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(343, 21)
        Me.ClienteComboBox.Sorted = True
        Me.ClienteComboBox.TabIndex = 5
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FechaDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsignacionesBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(62, 71)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(112, 20)
        Me.FechaDateTimePicker.TabIndex = 9
        Me.FechaDateTimePicker.Value = New Date(2021, 8, 6, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox1.Controls.Add(CodigoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 147)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Empleado"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(133, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(164, 20)
        Me.TextBox2.TabIndex = 41
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(164, 20)
        Me.TextBox1.TabIndex = 40
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(133, 27)
        Me.CodigoTextBox.MaxLength = 6
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(86, 20)
        Me.CodigoTextBox.TabIndex = 3
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEliminar.FlatAppearance.BorderSize = 0
        Me.cmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.Location = New System.Drawing.Point(223, 410)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(96, 28)
        Me.cmdEliminar.TabIndex = 40
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdOcultar
        '
        Me.cmdOcultar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdOcultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOcultar.FlatAppearance.BorderSize = 0
        Me.cmdOcultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdOcultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOcultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOcultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdOcultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOcultar.Location = New System.Drawing.Point(23, 410)
        Me.cmdOcultar.Name = "cmdOcultar"
        Me.cmdOcultar.Size = New System.Drawing.Size(96, 28)
        Me.cmdOcultar.TabIndex = 20
        Me.cmdOcultar.Text = "Ocultar"
        Me.cmdOcultar.UseVisualStyleBackColor = False
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
        Me.cmdActualizar.Location = New System.Drawing.Point(123, 410)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(96, 28)
        Me.cmdActualizar.TabIndex = 19
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(22, 323)
        Me.ObservacionTextBox.MaxLength = 200
        Me.ObservacionTextBox.Multiline = True
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(422, 71)
        Me.ObservacionTextBox.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TurnoComboBox)
        Me.GroupBox3.Controls.Add(Me.HorasTextBox)
        Me.GroupBox3.Controls.Add(HorasLabel)
        Me.GroupBox3.Controls.Add(TurnoLabel)
        Me.GroupBox3.Controls.Add(HorasextrasLabel)
        Me.GroupBox3.Controls.Add(Me.HorasextrasTextBox)
        Me.GroupBox3.Controls.Add(Me.IdasignacionTextBox)
        Me.GroupBox3.Controls.Add(IdasignacionLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(450, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 147)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Horarios"
        '
        'TurnoComboBox
        '
        Me.TurnoComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TurnoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "turno", True))
        Me.TurnoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TurnoComboBox.FormattingEnabled = True
        Me.TurnoComboBox.Items.AddRange(New Object() {"Diurno", "Nocturno", "Mixto"})
        Me.TurnoComboBox.Location = New System.Drawing.Point(86, 74)
        Me.TurnoComboBox.Name = "TurnoComboBox"
        Me.TurnoComboBox.Size = New System.Drawing.Size(113, 21)
        Me.TurnoComboBox.TabIndex = 38
        '
        'HorasTextBox
        '
        Me.HorasTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HorasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "horas", True))
        Me.HorasTextBox.Location = New System.Drawing.Point(86, 27)
        Me.HorasTextBox.Name = "HorasTextBox"
        Me.HorasTextBox.Size = New System.Drawing.Size(112, 20)
        Me.HorasTextBox.TabIndex = 11
        '
        'HorasextrasTextBox
        '
        Me.HorasextrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "horasextras", True))
        Me.HorasextrasTextBox.Location = New System.Drawing.Point(86, 50)
        Me.HorasextrasTextBox.Name = "HorasextrasTextBox"
        Me.HorasextrasTextBox.Size = New System.Drawing.Size(112, 20)
        Me.HorasextrasTextBox.TabIndex = 41
        '
        'IdasignacionTextBox
        '
        Me.IdasignacionTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IdasignacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "idasignacion", True))
        Me.IdasignacionTextBox.Location = New System.Drawing.Point(86, 101)
        Me.IdasignacionTextBox.Name = "IdasignacionTextBox"
        Me.IdasignacionTextBox.Size = New System.Drawing.Size(112, 20)
        Me.IdasignacionTextBox.TabIndex = 1
        Me.IdasignacionTextBox.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(689, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(377, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 1)
        Me.Panel1.TabIndex = 9
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.Location = New System.Drawing.Point(380, 56)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(306, 20)
        Me.txtbusqueda.TabIndex = 8
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboCliente
        '
        Me.ComboCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Items.AddRange(New Object() {"Seleccionar", "Codigo de Empleado", "Cliente"})
        Me.ComboCliente.Location = New System.Drawing.Point(253, 55)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(121, 21)
        Me.ComboCliente.TabIndex = 39
        '
        'AsignacionesDataGridView
        '
        Me.AsignacionesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AsignacionesDataGridView.AutoGenerateColumns = False
        Me.AsignacionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AsignacionesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.AsignacionesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.AsignacionesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AsignacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AsignacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.horasextras, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.nombre, Me.apellido})
        Me.AsignacionesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AsignacionesDataGridView.DataSource = Me.AsignacionesBindingSource
        Me.AsignacionesDataGridView.Location = New System.Drawing.Point(0, 121)
        Me.AsignacionesDataGridView.Name = "AsignacionesDataGridView"
        Me.AsignacionesDataGridView.RowHeadersVisible = False
        Me.AsignacionesDataGridView.ShowCellErrors = False
        Me.AsignacionesDataGridView.ShowRowErrors = False
        Me.AsignacionesDataGridView.Size = New System.Drawing.Size(965, 571)
        Me.AsignacionesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idasignacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo de Empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 119
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 64
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "turno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Turno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 62
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "horas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Horas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'horasextras
        '
        Me.horasextras.DataPropertyName = "horasextras"
        Me.horasextras.HeaderText = "Horas Extras"
        Me.horasextras.Name = "horasextras"
        Me.horasextras.Width = 85
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 92
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "autoriza"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Autoriza"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "sucursal"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Sucursal"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 73
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 69
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.Width = 69
        '
        'Day
        '
        Me.Day.CustomFormat = "yyyy-MM-dd"
        Me.Day.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Day.Location = New System.Drawing.Point(631, 12)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(158, 20)
        Me.Day.TabIndex = 46
        Me.Day.Visible = False
        '
        'Day2
        '
        Me.Day2.CustomFormat = "yyyy-MM-dd"
        Me.Day2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Day2.Location = New System.Drawing.Point(795, 12)
        Me.Day2.Name = "Day2"
        Me.Day2.Size = New System.Drawing.Size(158, 20)
        Me.Day2.TabIndex = 47
        Me.Day2.Visible = False
        '
        'AsignacionesTableAdapter
        '
        Me.AsignacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnticiposTableAdapter = Nothing
        Me.TableAdapterManager.ArmeriaTableAdapter = Nothing
        Me.TableAdapterManager.AsignacionesTableAdapter = Me.AsignacionesTableAdapter
        Me.TableAdapterManager.AspirantesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarnetTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeTableAdapter = Nothing
        Me.TableAdapterManager.DiasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.ExpedientesTableAdapter = Nothing
        Me.TableAdapterManager.FaltasTableAdapter = Nothing
        Me.TableAdapterManager.ImagenesTableAdapter = Nothing
        Me.TableAdapterManager.InactivosTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoArmasTableAdapter = Nothing
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupdeFiltro)
        Me.Panel2.Controls.Add(Me.ComboCliente)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.txtbusqueda)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Day)
        Me.Panel2.Controls.Add(Me.Day2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(965, 115)
        Me.Panel2.TabIndex = 48
        '
        'FormAsignacionesCambios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 692)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelCambioAsignacion)
        Me.Controls.Add(Me.AsignacionesDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAsignacionesCambios"
        Me.Text = "FormCambio"
        Me.GroupdeFiltro.ResumeLayout(False)
        Me.panelCambioAsignacion.ResumeLayout(False)
        Me.panelCambioAsignacion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents AsignacionesBindingSource As BindingSource
    Friend WithEvents AsignacionesTableAdapter As ABASDataSetTableAdapters.AsignacionesTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupdeFiltro As GroupBox
    Friend WithEvents panelCambioAsignacion As Panel
    Friend WithEvents IdasignacionTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents ClienteComboBox As ComboBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents HorasTextBox As TextBox
    Friend WithEvents SucursalComboBox As ComboBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents cmdOcultar As Button
    Friend WithEvents TurnoComboBox As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents ComboCliente As ComboBox
    Friend WithEvents HorasextrasTextBox As TextBox
    Friend WithEvents AsignacionesDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Day As DateTimePicker
    Friend WithEvents Day2 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents horasextras As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
End Class
