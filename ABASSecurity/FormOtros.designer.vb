<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOtros
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
        Dim FechadeingresoLabel As System.Windows.Forms.Label
        Dim NomdebancoLabel As System.Windows.Forms.Label
        Dim NumdecuentaLabel As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim IdentidadLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.FaltasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.RecordatorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsignacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnticiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FaltasTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.FaltasTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.RecordatorioTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.RecordatorioTableAdapter()
        Me.RegistroLoginTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.RegistroLoginTableAdapter()
        Me.AnticiposTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.AnticiposTableAdapter()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.DiasTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.DiasTableAdapter()
        Me.AsignacionesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.AsignacionesTableAdapter()
        Me.DiasLibres = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IniciosdeSesion = New System.Windows.Forms.TabPage()
        Me.RegistroLoginDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Recordatorios = New System.Windows.Forms.TabPage()
        Me.RecordatorioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbIdRecordatorio = New System.Windows.Forms.TextBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.FaltasEmpleado = New System.Windows.Forms.TabPage()
        Me.txtbuscarfalta = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FaltasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TapOtros = New System.Windows.Forms.TabControl()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NomdebancoTextBox = New System.Windows.Forms.TextBox()
        Me.FechadeingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumdecuentaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalarioTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.IdentidadTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.fechaanticipo = New System.Windows.Forms.DateTimePicker()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FechadeingresoLabel = New System.Windows.Forms.Label()
        NomdebancoLabel = New System.Windows.Forms.Label()
        NumdecuentaLabel = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        IdentidadLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.FaltasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordatorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DiasLibres.SuspendLayout()
        CType(Me.DiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IniciosdeSesion.SuspendLayout()
        CType(Me.RegistroLoginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Recordatorios.SuspendLayout()
        CType(Me.RecordatorioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.FaltasEmpleado.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaltasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TapOtros.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FaltasBindingSource
        '
        Me.FaltasBindingSource.DataMember = "Faltas"
        Me.FaltasBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordatorioBindingSource
        '
        Me.RecordatorioBindingSource.DataMember = "Recordatorio"
        Me.RecordatorioBindingSource.DataSource = Me.ABASDataSet
        '
        'RegistroLoginBindingSource
        '
        Me.RegistroLoginBindingSource.DataMember = "RegistroLogin"
        Me.RegistroLoginBindingSource.DataSource = Me.ABASDataSet
        '
        'AsignacionesBindingSource
        '
        Me.AsignacionesBindingSource.DataMember = "Asignaciones"
        Me.AsignacionesBindingSource.DataSource = Me.ABASDataSet
        '
        'DiasBindingSource
        '
        Me.DiasBindingSource.DataMember = "Dias"
        Me.DiasBindingSource.DataSource = Me.ABASDataSet
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'AnticiposBindingSource
        '
        Me.AnticiposBindingSource.DataMember = "Anticipos"
        Me.AnticiposBindingSource.DataSource = Me.ABASDataSet
        '
        'FaltasTableAdapter
        '
        Me.FaltasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnticiposTableAdapter = Nothing
        Me.TableAdapterManager.ArmeriaTableAdapter = Nothing
        Me.TableAdapterManager.AsignacionesTableAdapter = Nothing
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
        Me.TableAdapterManager.FaltasTableAdapter = Me.FaltasTableAdapter
        Me.TableAdapterManager.FormaPagoTableAdapter = Nothing
        Me.TableAdapterManager.ImagenesTableAdapter = Nothing
        Me.TableAdapterManager.InactivosTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoArmasTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoUniformesTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RecordatorioTableAdapter = Me.RecordatorioTableAdapter
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
        'RecordatorioTableAdapter
        '
        Me.RecordatorioTableAdapter.ClearBeforeFill = True
        '
        'RegistroLoginTableAdapter
        '
        Me.RegistroLoginTableAdapter.ClearBeforeFill = True
        '
        'AnticiposTableAdapter
        '
        Me.AnticiposTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'DiasTableAdapter
        '
        Me.DiasTableAdapter.ClearBeforeFill = True
        '
        'AsignacionesTableAdapter
        '
        Me.AsignacionesTableAdapter.ClearBeforeFill = True
        '
        'DiasLibres
        '
        Me.DiasLibres.AutoScroll = True
        Me.DiasLibres.BackColor = System.Drawing.SystemColors.Control
        Me.DiasLibres.Controls.Add(Me.AsignacionesDataGridView)
        Me.DiasLibres.Controls.Add(Me.DiasDataGridView)
        Me.DiasLibres.Controls.Add(Me.Label5)
        Me.DiasLibres.Location = New System.Drawing.Point(4, 22)
        Me.DiasLibres.Name = "DiasLibres"
        Me.DiasLibres.Padding = New System.Windows.Forms.Padding(3)
        Me.DiasLibres.Size = New System.Drawing.Size(933, 627)
        Me.DiasLibres.TabIndex = 3
        Me.DiasLibres.Text = "Dias Libres"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(927, 30)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dias Libres No Descansados"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DiasDataGridView
        '
        Me.DiasDataGridView.AutoGenerateColumns = False
        Me.DiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn26})
        Me.DiasDataGridView.DataSource = Me.DiasBindingSource
        Me.DiasDataGridView.Location = New System.Drawing.Point(853, 6)
        Me.DiasDataGridView.Name = "DiasDataGridView"
        Me.DiasDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.DiasDataGridView.TabIndex = 10
        Me.DiasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn26.HeaderText = "observacion"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "descanso"
        Me.DataGridViewTextBoxColumn19.HeaderText = "descanso"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "autoriza"
        Me.DataGridViewTextBoxColumn18.HeaderText = "autoriza"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "dia"
        Me.DataGridViewTextBoxColumn17.HeaderText = "dia"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn16.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "iddialibre"
        Me.DataGridViewTextBoxColumn12.HeaderText = "iddialibre"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
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
        Me.AsignacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.nombre, Me.apellido, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn43})
        Me.AsignacionesDataGridView.DataSource = Me.AsignacionesBindingSource
        Me.AsignacionesDataGridView.Location = New System.Drawing.Point(2, 60)
        Me.AsignacionesDataGridView.Name = "AsignacionesDataGridView"
        Me.AsignacionesDataGridView.RowHeadersVisible = False
        Me.AsignacionesDataGridView.Size = New System.Drawing.Size(928, 561)
        Me.AsignacionesDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "dialibre"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Dia Libre"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 69
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 92
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "autoriza"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Autorizo"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 70
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 62
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "turno"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Turno"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 60
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "sucursal"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Sucursal"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 73
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "cliente"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 64
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellidos"
        Me.apellido.Name = "apellido"
        Me.apellido.Width = 74
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombres"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 74
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Codigo De Empleado"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 121
        '
        'IniciosdeSesion
        '
        Me.IniciosdeSesion.BackColor = System.Drawing.SystemColors.Control
        Me.IniciosdeSesion.Controls.Add(Me.Panel3)
        Me.IniciosdeSesion.Controls.Add(Me.Label4)
        Me.IniciosdeSesion.Controls.Add(Me.RegistroLoginDataGridView)
        Me.IniciosdeSesion.Location = New System.Drawing.Point(4, 22)
        Me.IniciosdeSesion.Name = "IniciosdeSesion"
        Me.IniciosdeSesion.Padding = New System.Windows.Forms.Padding(3)
        Me.IniciosdeSesion.Size = New System.Drawing.Size(933, 627)
        Me.IniciosdeSesion.TabIndex = 2
        Me.IniciosdeSesion.Text = "Ultimo Inicio de Sesion"
        '
        'RegistroLoginDataGridView
        '
        Me.RegistroLoginDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroLoginDataGridView.AutoGenerateColumns = False
        Me.RegistroLoginDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RegistroLoginDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.RegistroLoginDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.RegistroLoginDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistroLoginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistroLoginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14})
        Me.RegistroLoginDataGridView.DataSource = Me.RegistroLoginBindingSource
        Me.RegistroLoginDataGridView.Location = New System.Drawing.Point(155, 107)
        Me.RegistroLoginDataGridView.Name = "RegistroLoginDataGridView"
        Me.RegistroLoginDataGridView.RowHeadersVisible = False
        Me.RegistroLoginDataGridView.Size = New System.Drawing.Size(611, 499)
        Me.RegistroLoginDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 62
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 68
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(927, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ultimo Inicio de Sesion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ShapeContainer2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(927, 62)
        Me.Panel3.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Escriba el Usuario:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(112, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 16)
        Me.TextBox1.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox3.Location = New System.Drawing.Point(335, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Recordatorios
        '
        Me.Recordatorios.BackColor = System.Drawing.SystemColors.Control
        Me.Recordatorios.Controls.Add(Me.Panel4)
        Me.Recordatorios.Controls.Add(Me.Label2)
        Me.Recordatorios.Controls.Add(Me.RecordatorioDataGridView)
        Me.Recordatorios.Location = New System.Drawing.Point(4, 22)
        Me.Recordatorios.Name = "Recordatorios"
        Me.Recordatorios.Padding = New System.Windows.Forms.Padding(3)
        Me.Recordatorios.Size = New System.Drawing.Size(933, 627)
        Me.Recordatorios.TabIndex = 1
        Me.Recordatorios.Text = "Recordatorios"
        '
        'RecordatorioDataGridView
        '
        Me.RecordatorioDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecordatorioDataGridView.AutoGenerateColumns = False
        Me.RecordatorioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RecordatorioDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.RecordatorioDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.RecordatorioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecordatorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordatorioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.RecordatorioDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RecordatorioDataGridView.DataSource = Me.RecordatorioBindingSource
        Me.RecordatorioDataGridView.Location = New System.Drawing.Point(188, 75)
        Me.RecordatorioDataGridView.Name = "RecordatorioDataGridView"
        Me.RecordatorioDataGridView.RowHeadersVisible = False
        Me.RecordatorioDataGridView.Size = New System.Drawing.Size(564, 435)
        Me.RecordatorioDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nota"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nota"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 55
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 55
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 62
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idrecordatorio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 41
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(927, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Recordatorios"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmdAgregar)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.cmdEliminar)
        Me.Panel4.Controls.Add(Me.lbIdRecordatorio)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 553)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(927, 71)
        Me.Panel4.TabIndex = 11
        '
        'lbIdRecordatorio
        '
        Me.lbIdRecordatorio.Location = New System.Drawing.Point(396, 3)
        Me.lbIdRecordatorio.Name = "lbIdRecordatorio"
        Me.lbIdRecordatorio.Size = New System.Drawing.Size(100, 20)
        Me.lbIdRecordatorio.TabIndex = 7
        Me.lbIdRecordatorio.Visible = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdEliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEliminar.FlatAppearance.BorderSize = 0
        Me.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.Location = New System.Drawing.Point(562, 28)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(155, 31)
        Me.cmdEliminar.TabIndex = 6
        Me.cmdEliminar.Text = "Eliminar Recordatorio"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(401, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Actualizar Tabla"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAgregar.FlatAppearance.BorderSize = 0
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAgregar.Location = New System.Drawing.Point(216, 28)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(156, 31)
        Me.cmdAgregar.TabIndex = 9
        Me.cmdAgregar.Text = "Agregar Recordatorio"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'FaltasEmpleado
        '
        Me.FaltasEmpleado.BackColor = System.Drawing.SystemColors.Control
        Me.FaltasEmpleado.Controls.Add(Me.Label3)
        Me.FaltasEmpleado.Controls.Add(Me.FaltasDataGridView)
        Me.FaltasEmpleado.Controls.Add(Me.Label1)
        Me.FaltasEmpleado.Controls.Add(Me.PictureBox2)
        Me.FaltasEmpleado.Controls.Add(Me.Panel1)
        Me.FaltasEmpleado.Controls.Add(Me.txtbuscarfalta)
        Me.FaltasEmpleado.Location = New System.Drawing.Point(4, 22)
        Me.FaltasEmpleado.Name = "FaltasEmpleado"
        Me.FaltasEmpleado.Padding = New System.Windows.Forms.Padding(3)
        Me.FaltasEmpleado.Size = New System.Drawing.Size(933, 627)
        Me.FaltasEmpleado.TabIndex = 0
        Me.FaltasEmpleado.Text = "Faltas de Empleados"
        '
        'txtbuscarfalta
        '
        Me.txtbuscarfalta.BackColor = System.Drawing.SystemColors.Control
        Me.txtbuscarfalta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscarfalta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbuscarfalta.Location = New System.Drawing.Point(407, 52)
        Me.txtbuscarfalta.MaxLength = 6
        Me.txtbuscarfalta.Multiline = True
        Me.txtbuscarfalta.Name = "txtbuscarfalta"
        Me.txtbuscarfalta.Size = New System.Drawing.Size(197, 20)
        Me.txtbuscarfalta.TabIndex = 22
        Me.txtbuscarfalta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(404, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 23
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(605, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Codigo de Empleado:"
        '
        'FaltasDataGridView
        '
        Me.FaltasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaltasDataGridView.AutoGenerateColumns = False
        Me.FaltasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.FaltasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.FaltasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.FaltasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FaltasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FaltasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FaltasDataGridView.DataSource = Me.FaltasBindingSource
        Me.FaltasDataGridView.Location = New System.Drawing.Point(-4, 85)
        Me.FaltasDataGridView.Name = "FaltasDataGridView"
        Me.FaltasDataGridView.RowHeadersVisible = False
        Me.FaltasDataGridView.Size = New System.Drawing.Size(937, 539)
        Me.FaltasDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "autoriza"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Autoriza"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 92
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechadefalta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "F. de Falta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 82
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(927, 26)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Faltas de Empleados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TapOtros
        '
        Me.TapOtros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TapOtros.Controls.Add(Me.FaltasEmpleado)
        Me.TapOtros.Controls.Add(Me.Recordatorios)
        Me.TapOtros.Controls.Add(Me.IniciosdeSesion)
        Me.TapOtros.Controls.Add(Me.DiasLibres)
        Me.TapOtros.Location = New System.Drawing.Point(12, 20)
        Me.TapOtros.Name = "TapOtros"
        Me.TapOtros.SelectedIndex = 0
        Me.TapOtros.Size = New System.Drawing.Size(941, 653)
        Me.TapOtros.TabIndex = 0
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(927, 62)
        Me.ShapeContainer2.TabIndex = 12
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 109
        Me.LineShape1.X2 = 337
        Me.LineShape1.Y1 = 35
        Me.LineShape1.Y2 = 35
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(360, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 111)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'NomdebancoTextBox
        '
        Me.NomdebancoTextBox.Location = New System.Drawing.Point(118, 47)
        Me.NomdebancoTextBox.Name = "NomdebancoTextBox"
        Me.NomdebancoTextBox.ReadOnly = True
        Me.NomdebancoTextBox.Size = New System.Drawing.Size(192, 20)
        Me.NomdebancoTextBox.TabIndex = 20
        '
        'FechadeingresoLabel
        '
        FechadeingresoLabel.AutoSize = True
        FechadeingresoLabel.Location = New System.Drawing.Point(16, 74)
        FechadeingresoLabel.Name = "FechadeingresoLabel"
        FechadeingresoLabel.Size = New System.Drawing.Size(93, 13)
        FechadeingresoLabel.TabIndex = 21
        '
        'FechadeingresoDateTimePicker
        '
        Me.FechadeingresoDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechadeingresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechadeingresoDateTimePicker.Location = New System.Drawing.Point(118, 74)
        Me.FechadeingresoDateTimePicker.Name = "FechadeingresoDateTimePicker"
        Me.FechadeingresoDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechadeingresoDateTimePicker.TabIndex = 22
        '
        'NomdebancoLabel
        '
        NomdebancoLabel.AutoSize = True
        NomdebancoLabel.Location = New System.Drawing.Point(13, 50)
        NomdebancoLabel.Name = "NomdebancoLabel"
        NomdebancoLabel.Size = New System.Drawing.Size(96, 13)
        NomdebancoLabel.TabIndex = 19
        '
        'NumdecuentaTextBox
        '
        Me.NumdecuentaTextBox.Location = New System.Drawing.Point(118, 19)
        Me.NumdecuentaTextBox.Name = "NumdecuentaTextBox"
        Me.NumdecuentaTextBox.ReadOnly = True
        Me.NumdecuentaTextBox.Size = New System.Drawing.Size(192, 20)
        Me.NumdecuentaTextBox.TabIndex = 18
        '
        'NumdecuentaLabel
        '
        NumdecuentaLabel.AutoSize = True
        NumdecuentaLabel.Location = New System.Drawing.Point(10, 22)
        NumdecuentaLabel.Name = "NumdecuentaLabel"
        NumdecuentaLabel.Size = New System.Drawing.Size(99, 13)
        NumdecuentaLabel.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(360, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 132)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Location = New System.Drawing.Point(67, 103)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(42, 13)
        SalarioLabel.TabIndex = 16
        '
        'SalarioTextBox
        '
        Me.SalarioTextBox.Location = New System.Drawing.Point(118, 100)
        Me.SalarioTextBox.Name = "SalarioTextBox"
        Me.SalarioTextBox.ReadOnly = True
        Me.SalarioTextBox.Size = New System.Drawing.Size(192, 20)
        Me.SalarioTextBox.TabIndex = 17
        '
        'IdentidadLabel
        '
        IdentidadLabel.AutoSize = True
        IdentidadLabel.Location = New System.Drawing.Point(55, 77)
        IdentidadLabel.Name = "IdentidadLabel"
        IdentidadLabel.Size = New System.Drawing.Size(54, 13)
        IdentidadLabel.TabIndex = 15
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(57, 51)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 14
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.Location = New System.Drawing.Point(118, 48)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.ReadOnly = True
        Me.ApellidosTextBox.Size = New System.Drawing.Size(192, 20)
        Me.ApellidosTextBox.TabIndex = 15
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(57, 25)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(52, 13)
        NombresLabel.TabIndex = 13
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Location = New System.Drawing.Point(118, 22)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.ReadOnly = True
        Me.NombresTextBox.Size = New System.Drawing.Size(192, 20)
        Me.NombresTextBox.TabIndex = 14
        '
        'IdentidadTextBox
        '
        Me.IdentidadTextBox.Location = New System.Drawing.Point(118, 74)
        Me.IdentidadTextBox.Name = "IdentidadTextBox"
        Me.IdentidadTextBox.ReadOnly = True
        Me.IdentidadTextBox.Size = New System.Drawing.Size(192, 20)
        Me.IdentidadTextBox.TabIndex = 16
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(348, 249)
        Me.GroupBox5.TabIndex = 77
        Me.GroupBox5.TabStop = False
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(127, 93)
        Me.ObservacionTextBox.Multiline = True
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(201, 54)
        Me.ObservacionTextBox.TabIndex = 7
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(81, 39)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 2
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(51, 93)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 6
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox4.Location = New System.Drawing.Point(233, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'fechaanticipo
        '
        Me.fechaanticipo.CustomFormat = "dd-MM-yyyy"
        Me.fechaanticipo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaanticipo.Location = New System.Drawing.Point(127, 39)
        Me.fechaanticipo.Name = "fechaanticipo"
        Me.fechaanticipo.Size = New System.Drawing.Size(100, 20)
        Me.fechaanticipo.TabIndex = 3
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Location = New System.Drawing.Point(127, 13)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 1
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(127, 65)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 5
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(69, 65)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 4
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"Pendiente", "Pagado"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(127, 153)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EstadoComboBox.TabIndex = 24
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(11, 16)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(110, 13)
        CodigoLabel.TabIndex = 0
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(71, 156)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 23
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad", "Ubicacion", "Planilla"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(93, 19)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.Location = New System.Drawing.Point(233, 19)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(197, 20)
        Me.txtbusqueda.TabIndex = 8
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(230, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(431, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 61)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(597, 301)
        Me.EmpleadosDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "fechadeingreso"
        Me.DataGridViewTextBoxColumn32.HeaderText = "F. de Ingreso"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "nomdebanco"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Nombre del Banco"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "numdecuenta"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Numero de Cuenta"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "salario"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Salario"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "identidad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Identidad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 64
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 59
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 73
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.Width = 90
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Width = 64
        '
        'FormOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(965, 692)
        Me.Controls.Add(Me.TapOtros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormOtros"
        CType(Me.FaltasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordatorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DiasLibres.ResumeLayout(False)
        CType(Me.DiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IniciosdeSesion.ResumeLayout(False)
        CType(Me.RegistroLoginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Recordatorios.ResumeLayout(False)
        CType(Me.RecordatorioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.FaltasEmpleado.ResumeLayout(False)
        Me.FaltasEmpleado.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaltasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TapOtros.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents FaltasBindingSource As BindingSource
    Friend WithEvents FaltasTableAdapter As ABASDataSetTableAdapters.FaltasTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordatorioTableAdapter As ABASDataSetTableAdapters.RecordatorioTableAdapter
    Friend WithEvents RecordatorioBindingSource As BindingSource
    Friend WithEvents RegistroLoginBindingSource As BindingSource
    Friend WithEvents RegistroLoginTableAdapter As ABASDataSetTableAdapters.RegistroLoginTableAdapter
    Friend WithEvents AnticiposBindingSource As BindingSource
    Friend WithEvents AnticiposTableAdapter As ABASDataSetTableAdapters.AnticiposTableAdapter
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents DiasBindingSource As BindingSource
    Friend WithEvents DiasTableAdapter As ABASDataSetTableAdapters.DiasTableAdapter
    Friend WithEvents AsignacionesBindingSource As BindingSource
    Friend WithEvents AsignacionesTableAdapter As ABASDataSetTableAdapters.AsignacionesTableAdapter
    Friend WithEvents DiasLibres As TabPage
    Friend WithEvents AsignacionesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents IniciosdeSesion As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Label4 As Label
    Friend WithEvents RegistroLoginDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Recordatorios As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmdAgregar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents lbIdRecordatorio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RecordatorioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents FaltasEmpleado As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents FaltasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbuscarfalta As TextBox
    Friend WithEvents TapOtros As TabControl
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NomdebancoTextBox As TextBox
    Friend WithEvents FechadeingresoDateTimePicker As DateTimePicker
    Friend WithEvents NumdecuentaTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SalarioTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents IdentidadTextBox As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents fechaanticipo As DateTimePicker
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
