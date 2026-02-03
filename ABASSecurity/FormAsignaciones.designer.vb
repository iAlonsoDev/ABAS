<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAsignaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza RRHH Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim HorasLabel As System.Windows.Forms.Label
        Dim HorasextrasLabel As System.Windows.Forms.Label
        Dim DialibreLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.cmdInsertar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCancelarAsignacion = New System.Windows.Forms.Button()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.AsignacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.FechaDateTime = New System.Windows.Forms.DateTimePicker()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.txtfecha2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.OficialesAsignados = New System.Windows.Forms.TextBox()
        Me.Oficiales = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Horasextrasasignadas = New System.Windows.Forms.TextBox()
        Me.extras = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.HorasTextBox = New System.Windows.Forms.TextBox()
        Me.HorasAsignadas = New System.Windows.Forms.TextBox()
        Me.Habilitar = New System.Windows.Forms.Button()
        Me.HorasExtrasComparacion = New System.Windows.Forms.TextBox()
        Me.HorasComparacion = New System.Windows.Forms.TextBox()
        Me.HorasBase = New System.Windows.Forms.TextBox()
        Me.DialibreTextBox = New System.Windows.Forms.TextBox()
        Me.txtfcambio = New System.Windows.Forms.TextBox()
        Me.txtcambio = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.diadelasemana = New System.Windows.Forms.DateTimePicker()
        Me.AsignacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autoriza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horasextras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fcambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dialibre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteAsignacionesPorCodigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionesClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionesGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteFaltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.HextrasasignadasConvertidas = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.AsignacionesTableAdapter1 = New ABASSecurity.ABASDataSetTableAdapters.AsignacionesTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtEstado_Asignacion = New System.Windows.Forms.TextBox()
        HorasLabel = New System.Windows.Forms.Label()
        HorasextrasLabel = New System.Windows.Forms.Label()
        DialibreLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtfecha2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.cmdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.panelEmpleados.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HorasLabel
        '
        HorasLabel.AutoSize = True
        HorasLabel.Location = New System.Drawing.Point(38, 17)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(78, 13)
        HorasLabel.TabIndex = 10
        HorasLabel.Text = "Horas Clientes:"
        '
        'HorasextrasLabel
        '
        HorasextrasLabel.AutoSize = True
        HorasextrasLabel.Location = New System.Drawing.Point(46, 18)
        HorasextrasLabel.Name = "HorasextrasLabel"
        HorasextrasLabel.Size = New System.Drawing.Size(70, 13)
        HorasextrasLabel.TabIndex = 29
        HorasextrasLabel.Text = "Horas Extras:"
        '
        'DialibreLabel
        '
        DialibreLabel.AutoSize = True
        DialibreLabel.Location = New System.Drawing.Point(89, 79)
        DialibreLabel.Name = "DialibreLabel"
        DialibreLabel.Size = New System.Drawing.Size(43, 13)
        DialibreLabel.TabIndex = 30
        DialibreLabel.Text = "dialibre:"
        DialibreLabel.Visible = False
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(15, 21)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 23
        CodigoLabel.Text = "Codigo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(37, 17)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 13)
        Label1.TabIndex = 33
        Label1.Text = "N. de Oficiales:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(26, 43)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(90, 13)
        Label2.TabIndex = 37
        Label2.Text = "Horas Asignadas:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 44)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(91, 13)
        Label3.TabIndex = 38
        Label3.Text = "Extras Asignadas:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(14, 43)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(102, 13)
        Label4.TabIndex = 35
        Label4.Text = "Oficiales Asignados:"
        '
        'cmdInsertar
        '
        Me.cmdInsertar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdInsertar.FlatAppearance.BorderSize = 0
        Me.cmdInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInsertar.Location = New System.Drawing.Point(291, 126)
        Me.cmdInsertar.Name = "cmdInsertar"
        Me.cmdInsertar.Size = New System.Drawing.Size(79, 28)
        Me.cmdInsertar.TabIndex = 4
        Me.cmdInsertar.Text = "Insertar"
        Me.cmdInsertar.UseVisualStyleBackColor = False
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
        Me.cmdGuardar.Location = New System.Drawing.Point(382, 126)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(79, 28)
        Me.cmdGuardar.TabIndex = 5
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'cmdCancelarAsignacion
        '
        Me.cmdCancelarAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelarAsignacion.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdCancelarAsignacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCancelarAsignacion.FlatAppearance.BorderSize = 0
        Me.cmdCancelarAsignacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCancelarAsignacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdCancelarAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelarAsignacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelarAsignacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCancelarAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelarAsignacion.Location = New System.Drawing.Point(7, 651)
        Me.cmdCancelarAsignacion.Name = "cmdCancelarAsignacion"
        Me.cmdCancelarAsignacion.Size = New System.Drawing.Size(170, 35)
        Me.cmdCancelarAsignacion.TabIndex = 6
        Me.cmdCancelarAsignacion.Text = "Cancelar Asignaciones"
        Me.cmdCancelarAsignacion.UseVisualStyleBackColor = False
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(6, 15)
        Me.ObservacionTextBox.MaxLength = 200
        Me.ObservacionTextBox.Multiline = True
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(433, 55)
        Me.ObservacionTextBox.TabIndex = 13
        Me.ObservacionTextBox.Text = "Ninguna"
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
        'FechaDateTime
        '
        Me.FechaDateTime.Checked = False
        Me.FechaDateTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FechaDateTime.CustomFormat = "dd-MM-yyyy"
        Me.FechaDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTime.Location = New System.Drawing.Point(8, 19)
        Me.FechaDateTime.Name = "FechaDateTime"
        Me.FechaDateTime.Size = New System.Drawing.Size(197, 20)
        Me.FechaDateTime.TabIndex = 23
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(62, 18)
        Me.CodigoTextBox.MaxLength = 6
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(135, 20)
        Me.CodigoTextBox.TabIndex = 24
        '
        'txtfecha2
        '
        Me.txtfecha2.Controls.Add(Me.GroupBox7)
        Me.txtfecha2.Controls.Add(Me.GroupBox2)
        Me.txtfecha2.Controls.Add(Me.GroupBox1)
        Me.txtfecha2.Location = New System.Drawing.Point(473, 28)
        Me.txtfecha2.Name = "txtfecha2"
        Me.txtfecha2.Size = New System.Drawing.Size(483, 299)
        Me.txtfecha2.TabIndex = 25
        Me.txtfecha2.TabStop = False
        Me.txtfecha2.Text = "Datos del Empleado"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtapellido)
        Me.GroupBox7.Controls.Add(Me.txtnombre)
        Me.GroupBox7.Controls.Add(Me.cmdBuscar)
        Me.GroupBox7.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox7.Controls.Add(CodigoLabel)
        Me.GroupBox7.Location = New System.Drawing.Point(9, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(239, 114)
        Me.GroupBox7.TabIndex = 42
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Datos del Oficial"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(10, 71)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.ReadOnly = True
        Me.txtapellido.Size = New System.Drawing.Size(218, 20)
        Me.txtapellido.TabIndex = 29
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(10, 45)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(218, 20)
        Me.txtnombre.TabIndex = 29
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscar.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.cmdBuscar.Location = New System.Drawing.Point(199, 17)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(25, 21)
        Me.cmdBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmdBuscar.TabIndex = 28
        Me.cmdBuscar.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.FechaDateTime)
        Me.GroupBox2.Location = New System.Drawing.Point(254, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 115)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Turno Empleado"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(8, 93)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox3.TabIndex = 40
        Me.CheckBox3.Text = "Comodin"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 47)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.Text = "Diurno"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 70)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox2.TabIndex = 39
        Me.CheckBox2.Text = "Nocturno"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox10)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.cmdInsertar)
        Me.GroupBox1.Controls.Add(Me.cmdGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 162)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario del Cliente"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.OficialesAsignados)
        Me.GroupBox10.Controls.Add(Me.Oficiales)
        Me.GroupBox10.Controls.Add(Label4)
        Me.GroupBox10.Controls.Add(Label1)
        Me.GroupBox10.Location = New System.Drawing.Point(13, 88)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(226, 68)
        Me.GroupBox10.TabIndex = 41
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Oficiales"
        '
        'OficialesAsignados
        '
        Me.OficialesAsignados.Location = New System.Drawing.Point(122, 40)
        Me.OficialesAsignados.Name = "OficialesAsignados"
        Me.OficialesAsignados.ReadOnly = True
        Me.OficialesAsignados.Size = New System.Drawing.Size(93, 20)
        Me.OficialesAsignados.TabIndex = 34
        '
        'Oficiales
        '
        Me.Oficiales.Location = New System.Drawing.Point(122, 14)
        Me.Oficiales.Name = "Oficiales"
        Me.Oficiales.ReadOnly = True
        Me.Oficiales.Size = New System.Drawing.Size(93, 20)
        Me.Oficiales.TabIndex = 32
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Horasextrasasignadas)
        Me.GroupBox9.Controls.Add(Label3)
        Me.GroupBox9.Controls.Add(Me.extras)
        Me.GroupBox9.Controls.Add(HorasextrasLabel)
        Me.GroupBox9.Location = New System.Drawing.Point(244, 14)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(217, 72)
        Me.GroupBox9.TabIndex = 40
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Extras"
        '
        'Horasextrasasignadas
        '
        Me.Horasextrasasignadas.Location = New System.Drawing.Point(113, 41)
        Me.Horasextrasasignadas.Name = "Horasextrasasignadas"
        Me.Horasextrasasignadas.ReadOnly = True
        Me.Horasextrasasignadas.Size = New System.Drawing.Size(93, 20)
        Me.Horasextrasasignadas.TabIndex = 35
        '
        'extras
        '
        Me.extras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "horasextras", True))
        Me.extras.Location = New System.Drawing.Point(113, 15)
        Me.extras.Name = "extras"
        Me.extras.Size = New System.Drawing.Size(93, 20)
        Me.extras.TabIndex = 30
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.HorasTextBox)
        Me.GroupBox8.Controls.Add(Me.HorasAsignadas)
        Me.GroupBox8.Controls.Add(HorasLabel)
        Me.GroupBox8.Controls.Add(Label2)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(226, 68)
        Me.GroupBox8.TabIndex = 39
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Horas"
        '
        'HorasTextBox
        '
        Me.HorasTextBox.Location = New System.Drawing.Point(122, 14)
        Me.HorasTextBox.Name = "HorasTextBox"
        Me.HorasTextBox.Size = New System.Drawing.Size(93, 20)
        Me.HorasTextBox.TabIndex = 31
        '
        'HorasAsignadas
        '
        Me.HorasAsignadas.Location = New System.Drawing.Point(122, 40)
        Me.HorasAsignadas.Name = "HorasAsignadas"
        Me.HorasAsignadas.ReadOnly = True
        Me.HorasAsignadas.Size = New System.Drawing.Size(93, 20)
        Me.HorasAsignadas.TabIndex = 34
        '
        'Habilitar
        '
        Me.Habilitar.BackColor = System.Drawing.Color.SteelBlue
        Me.Habilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Habilitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Habilitar.FlatAppearance.BorderSize = 0
        Me.Habilitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Habilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Habilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Habilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Habilitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Habilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Habilitar.Location = New System.Drawing.Point(226, 71)
        Me.Habilitar.Name = "Habilitar"
        Me.Habilitar.Size = New System.Drawing.Size(167, 28)
        Me.Habilitar.TabIndex = 43
        Me.Habilitar.Text = "Habilitar Horas"
        Me.Habilitar.UseVisualStyleBackColor = False
        Me.Habilitar.Visible = False
        '
        'HorasExtrasComparacion
        '
        Me.HorasExtrasComparacion.Location = New System.Drawing.Point(308, 45)
        Me.HorasExtrasComparacion.Name = "HorasExtrasComparacion"
        Me.HorasExtrasComparacion.Size = New System.Drawing.Size(85, 20)
        Me.HorasExtrasComparacion.TabIndex = 41
        Me.HorasExtrasComparacion.Visible = False
        '
        'HorasComparacion
        '
        Me.HorasComparacion.Location = New System.Drawing.Point(226, 45)
        Me.HorasComparacion.Name = "HorasComparacion"
        Me.HorasComparacion.Size = New System.Drawing.Size(76, 20)
        Me.HorasComparacion.TabIndex = 44
        Me.HorasComparacion.Visible = False
        '
        'HorasBase
        '
        Me.HorasBase.Location = New System.Drawing.Point(226, 20)
        Me.HorasBase.Name = "HorasBase"
        Me.HorasBase.Size = New System.Drawing.Size(76, 20)
        Me.HorasBase.TabIndex = 42
        '
        'DialibreTextBox
        '
        Me.DialibreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "dialibre", True))
        Me.DialibreTextBox.Location = New System.Drawing.Point(138, 72)
        Me.DialibreTextBox.Name = "DialibreTextBox"
        Me.DialibreTextBox.Size = New System.Drawing.Size(79, 20)
        Me.DialibreTextBox.TabIndex = 31
        Me.DialibreTextBox.Visible = False
        '
        'txtfcambio
        '
        Me.txtfcambio.Location = New System.Drawing.Point(11, 20)
        Me.txtfcambio.Name = "txtfcambio"
        Me.txtfcambio.Size = New System.Drawing.Size(100, 20)
        Me.txtfcambio.TabIndex = 32
        '
        'txtcambio
        '
        Me.txtcambio.Location = New System.Drawing.Point(117, 20)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.Size = New System.Drawing.Size(100, 20)
        Me.txtcambio.TabIndex = 31
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 299)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Asignacion de Cliente/Sucursal"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.ListBox2)
        Me.GroupBox6.Location = New System.Drawing.Point(181, 35)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(271, 181)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sucursales"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(259, 20)
        Me.TextBox2.TabIndex = 37
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(6, 39)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(259, 130)
        Me.ListBox2.TabIndex = 33
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 36)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(173, 180)
        Me.GroupBox5.TabIndex = 43
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cliente"
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(161, 130)
        Me.ListBox1.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 20)
        Me.TextBox1.TabIndex = 36
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ObservacionTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 218)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(445, 78)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Observacion"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.ForeColor = System.Drawing.Color.Red
        Me.TextBox3.Location = New System.Drawing.Point(5, 19)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(299, 22)
        Me.TextBox3.TabIndex = 40
        Me.TextBox3.Text = "Debe guardar registros para seleccionar otro cliente o sucursal"
        Me.TextBox3.Visible = False
        '
        'panelEmpleados
        '
        Me.panelEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelEmpleados.Controls.Add(Me.PictureBox1)
        Me.panelEmpleados.Controls.Add(Me.Panel2)
        Me.panelEmpleados.Controls.Add(Me.tipodebusqueda)
        Me.panelEmpleados.Controls.Add(Me.txtbusqueda)
        Me.panelEmpleados.Location = New System.Drawing.Point(104, 150)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(784, 464)
        Me.panelEmpleados.TabIndex = 29
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.identidad, Me.ubicacion, Me.planilla, Me.estado})
        Me.EmpleadosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpleadosDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(782, 424)
        Me.EmpleadosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn2.FillWeight = 106.6581!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo de Empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 119
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn3.FillWeight = 75.43207!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 74
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn4.FillWeight = 87.49759!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 74
        '
        'identidad
        '
        Me.identidad.DataPropertyName = "identidad"
        Me.identidad.FillWeight = 101.0799!
        Me.identidad.HeaderText = "Identidad"
        Me.identidad.Name = "identidad"
        Me.identidad.Width = 76
        '
        'ubicacion
        '
        Me.ubicacion.DataPropertyName = "ubicacion"
        Me.ubicacion.FillWeight = 116.8165!
        Me.ubicacion.HeaderText = "Ubicacion"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.Width = 80
        '
        'planilla
        '
        Me.planilla.DataPropertyName = "planilla"
        Me.planilla.FillWeight = 102.0672!
        Me.planilla.HeaderText = "Planilla"
        Me.planilla.Name = "planilla"
        Me.planilla.Width = 65
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.FillWeight = 110.4486!
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Width = 65
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(480, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(279, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 9
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad", "Ubicacion", "Planilla"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(140, 12)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtbusqueda.Location = New System.Drawing.Point(282, 12)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(197, 20)
        Me.txtbusqueda.TabIndex = 8
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'diadelasemana
        '
        Me.diadelasemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.diadelasemana.CustomFormat = "dddd"
        Me.diadelasemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.diadelasemana.Location = New System.Drawing.Point(-211, 21)
        Me.diadelasemana.Name = "diadelasemana"
        Me.diadelasemana.Size = New System.Drawing.Size(76, 20)
        Me.diadelasemana.TabIndex = 29
        '
        'AsignacionesDataGridView
        '
        Me.AsignacionesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AsignacionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AsignacionesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.AsignacionesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.AsignacionesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AsignacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AsignacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Cliente, Me.Sucursal, Me.Turno, Me.Fecha, Me.Horas, Me.Autoriza, Me.Observacion, Me.Horasextras, Me.cambio, Me.fcambio, Me.dialibre, Me.nombre, Me.apellido, Me.EstadoAsignacion})
        Me.AsignacionesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AsignacionesDataGridView.Location = New System.Drawing.Point(0, 330)
        Me.AsignacionesDataGridView.Name = "AsignacionesDataGridView"
        Me.AsignacionesDataGridView.ReadOnly = True
        Me.AsignacionesDataGridView.RowHeadersVisible = False
        Me.AsignacionesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.AsignacionesDataGridView.Size = New System.Drawing.Size(965, 315)
        Me.AsignacionesDataGridView.TabIndex = 28
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 65
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 64
        '
        'Sucursal
        '
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        Me.Sucursal.Width = 73
        '
        'Turno
        '
        Me.Turno.HeaderText = "Turno"
        Me.Turno.Name = "Turno"
        Me.Turno.ReadOnly = True
        Me.Turno.Width = 60
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'Horas
        '
        Me.Horas.HeaderText = "Horas"
        Me.Horas.Name = "Horas"
        Me.Horas.ReadOnly = True
        Me.Horas.Width = 60
        '
        'Autoriza
        '
        Me.Autoriza.HeaderText = "Autoriza"
        Me.Autoriza.Name = "Autoriza"
        Me.Autoriza.ReadOnly = True
        Me.Autoriza.Width = 70
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 92
        '
        'Horasextras
        '
        Me.Horasextras.HeaderText = "Horasextras"
        Me.Horasextras.Name = "Horasextras"
        Me.Horasextras.ReadOnly = True
        Me.Horasextras.Width = 88
        '
        'cambio
        '
        Me.cambio.HeaderText = "Cambio"
        Me.cambio.Name = "cambio"
        Me.cambio.ReadOnly = True
        Me.cambio.Visible = False
        Me.cambio.Width = 67
        '
        'fcambio
        '
        Me.fcambio.HeaderText = "Fcambio"
        Me.fcambio.Name = "fcambio"
        Me.fcambio.ReadOnly = True
        Me.fcambio.Visible = False
        Me.fcambio.Width = 72
        '
        'dialibre
        '
        Me.dialibre.HeaderText = "dialibre"
        Me.dialibre.Name = "dialibre"
        Me.dialibre.ReadOnly = True
        Me.dialibre.Visible = False
        Me.dialibre.Width = 65
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 69
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 69
        '
        'EstadoAsignacion
        '
        Me.EstadoAsignacion.HeaderText = "Estado"
        Me.EstadoAsignacion.Name = "EstadoAsignacion"
        Me.EstadoAsignacion.ReadOnly = True
        Me.EstadoAsignacion.Width = 65
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteAsignacionesPorCodigoToolStripMenuItem, Me.AsignacionesClienteToolStripMenuItem, Me.AsignacionesGeneralesToolStripMenuItem, Me.ReporteFaltasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteAsignacionesPorCodigoToolStripMenuItem
        '
        Me.ReporteAsignacionesPorCodigoToolStripMenuItem.Name = "ReporteAsignacionesPorCodigoToolStripMenuItem"
        Me.ReporteAsignacionesPorCodigoToolStripMenuItem.Size = New System.Drawing.Size(416, 22)
        Me.ReporteAsignacionesPorCodigoToolStripMenuItem.Text = "Generar Reporte de Asiganciones, Segun Codigo de Empleado"
        '
        'AsignacionesClienteToolStripMenuItem
        '
        Me.AsignacionesClienteToolStripMenuItem.Name = "AsignacionesClienteToolStripMenuItem"
        Me.AsignacionesClienteToolStripMenuItem.Size = New System.Drawing.Size(416, 22)
        Me.AsignacionesClienteToolStripMenuItem.Text = "Generar Reporte de Asignaciones por Cliente"
        '
        'AsignacionesGeneralesToolStripMenuItem
        '
        Me.AsignacionesGeneralesToolStripMenuItem.Name = "AsignacionesGeneralesToolStripMenuItem"
        Me.AsignacionesGeneralesToolStripMenuItem.Size = New System.Drawing.Size(416, 22)
        Me.AsignacionesGeneralesToolStripMenuItem.Text = "Reporte de Asignaciones Generales"
        '
        'ReporteFaltasToolStripMenuItem
        '
        Me.ReporteFaltasToolStripMenuItem.Name = "ReporteFaltasToolStripMenuItem"
        Me.ReporteFaltasToolStripMenuItem.Size = New System.Drawing.Size(416, 22)
        Me.ReporteFaltasToolStripMenuItem.Text = "Reporte Faltas"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(183, 651)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 35)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Ver Empleados no Asignados"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'HextrasasignadasConvertidas
        '
        Me.HextrasasignadasConvertidas.Location = New System.Drawing.Point(308, 20)
        Me.HextrasasignadasConvertidas.Name = "HextrasasignadasConvertidas"
        Me.HextrasasignadasConvertidas.Size = New System.Drawing.Size(85, 20)
        Me.HextrasasignadasConvertidas.TabIndex = 40
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(138, 46)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(79, 20)
        Me.TextBox4.TabIndex = 43
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlmacenesTableAdapter = Nothing
        Me.TableAdapterManager.AnticiposTableAdapter = Nothing
        Me.TableAdapterManager.ArmeriaFotosTableAdapter = Nothing
        Me.TableAdapterManager.ArmeriaTableAdapter = Nothing
        Me.TableAdapterManager.AsignacionesTableAdapter = Nothing
        Me.TableAdapterManager.AspirantesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BloqueoInventarioTableAdapter = Nothing
        Me.TableAdapterManager.CarnetTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeTableAdapter = Nothing
        Me.TableAdapterManager.DiasTableAdapter = Nothing
        Me.TableAdapterManager.DocumentosEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EquiposFotosTableAdapter = Nothing
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
        Me.TableAdapterManager.MovimientoMunicionTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoUniformesTableAdapter = Nothing
        Me.TableAdapterManager.MunicionFotosTableAdapter = Nothing
        Me.TableAdapterManager.MunicionTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.PreciosCarnetTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RecordatorioTableAdapter = Nothing
        Me.TableAdapterManager.RegistroCarnetTableAdapter = Nothing
        Me.TableAdapterManager.RegistroLoginTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudUniformeTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.TipoDocumentosEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.TipoMaterialesTableAdapter = Nothing
        Me.TableAdapterManager.TipoMunicionTableAdapter = Nothing
        Me.TableAdapterManager.UbicacionesTableAdapter = Nothing
        Me.TableAdapterManager.UniformesRIngresosTableAdapter = Nothing
        Me.TableAdapterManager.UniformesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateNVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosModulosTableAdapter = Nothing
        Me.TableAdapterManager.VehiculosFotosTableAdapter = Nothing
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        '
        'AsignacionesTableAdapter1
        '
        Me.AsignacionesTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtEstado_Asignacion)
        Me.Panel1.Controls.Add(Me.Habilitar)
        Me.Panel1.Controls.Add(Me.HorasComparacion)
        Me.Panel1.Controls.Add(Me.DialibreTextBox)
        Me.Panel1.Controls.Add(Me.HorasExtrasComparacion)
        Me.Panel1.Controls.Add(DialibreLabel)
        Me.Panel1.Controls.Add(Me.txtfcambio)
        Me.Panel1.Controls.Add(Me.diadelasemana)
        Me.Panel1.Controls.Add(Me.txtcambio)
        Me.Panel1.Controls.Add(Me.HorasBase)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.HextrasasignadasConvertidas)
        Me.Panel1.Location = New System.Drawing.Point(12, 494)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 136)
        Me.Panel1.TabIndex = 44
        Me.Panel1.Visible = False
        '
        'TxtEstado_Asignacion
        '
        Me.TxtEstado_Asignacion.Location = New System.Drawing.Point(293, 105)
        Me.TxtEstado_Asignacion.Name = "TxtEstado_Asignacion"
        Me.TxtEstado_Asignacion.Size = New System.Drawing.Size(100, 20)
        Me.TxtEstado_Asignacion.TabIndex = 45
        Me.TxtEstado_Asignacion.Text = "No Pagada"
        '
        'FormAsignaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 692)
        Me.Controls.Add(Me.panelEmpleados)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdCancelarAsignacion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtfecha2)
        Me.Controls.Add(Me.AsignacionesDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormAsignaciones"
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtfecha2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.cmdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelEmpleados.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents AsignacionesBindingSource As BindingSource
    Friend WithEvents AsignacionesTableAdapter As ABASDataSetTableAdapters.AsignacionesTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmdInsertar As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdCancelarAsignacion As Button
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents FechaDateTime As DateTimePicker
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents txtfecha2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdBuscar As PictureBox
    Friend WithEvents AsignacionesDataGridView As DataGridView
    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents diadelasemana As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteAsignacionesPorCodigoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionesClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionesGeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents identidad As DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents planilla As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents extras As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents ClienteTableAdapter As ABASDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents HorasTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtcambio As TextBox
    Friend WithEvents txtfcambio As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DialibreTextBox As TextBox
    Friend WithEvents AsignacionesTableAdapter1 As ABASDataSetTableAdapters.AsignacionesTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Oficiales As TextBox
    Friend WithEvents Horasextrasasignadas As TextBox
    Friend WithEvents HorasAsignadas As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents OficialesAsignados As TextBox
    Friend WithEvents HorasBase As TextBox
    Friend WithEvents HorasComparacion As TextBox
    Friend WithEvents HextrasasignadasConvertidas As TextBox
    Friend WithEvents HorasExtrasComparacion As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Habilitar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtEstado_Asignacion As TextBox
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As DataGridViewTextBoxColumn
    Friend WithEvents Turno As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Horas As DataGridViewTextBoxColumn
    Friend WithEvents Autoriza As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
    Friend WithEvents Horasextras As DataGridViewTextBoxColumn
    Friend WithEvents cambio As DataGridViewTextBoxColumn
    Friend WithEvents fcambio As DataGridViewTextBoxColumn
    Friend WithEvents dialibre As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents EstadoAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents ReporteFaltasToolStripMenuItem As ToolStripMenuItem
End Class
