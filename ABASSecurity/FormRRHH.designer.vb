<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRRHH
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
        Dim LatitudLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim CodigoLabel1 As System.Windows.Forms.Label
        Dim FechadesalidaLabel As System.Windows.Forms.Label
        Dim MotivoLabel As System.Windows.Forms.Label
        Dim ComentarioLabel As System.Windows.Forms.Label
        Dim CarnetLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim IdempleadoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim PlanillaLabel As System.Windows.Forms.Label
        Dim FechadeingresoLabel As System.Windows.Forms.Label
        Dim BonosLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim NumdecuentaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel1 As System.Windows.Forms.Label
        Dim DireccionLabel1 As System.Windows.Forms.Label
        Dim HijosLabel As System.Windows.Forms.Label
        Dim EstadocivilLabel As System.Windows.Forms.Label
        Dim ParentescoLabel As System.Windows.Forms.Label
        Dim Telefono3Label As System.Windows.Forms.Label
        Dim FechadenacimientoLabel As System.Windows.Forms.Label
        Dim Telefono2Label As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TipodesangreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim IdentidadLabel As System.Windows.Forms.Label
        Dim PrecioCarnetLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRRHH))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosLosEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoDeEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeExpedientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCumpleañerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeInactivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollDiarioDeEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionesPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionesGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaltasDeEmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoucherDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanillaDeDeduccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanillaDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteAniversariosEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeCarnetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_Coordenadas = New System.Windows.Forms.TextBox()
        Me.UbicacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.CmdCSalario = New System.Windows.Forms.Button()
        Me.CmdCBono = New System.Windows.Forms.Button()
        Me.dlgBox = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PlanillasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelValidaCarnet = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.CmdCarnetGratis = New System.Windows.Forms.Button()
        Me.txtClaveGer = New System.Windows.Forms.TextBox()
        Me.txtUsuarioGer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservacionCarnet = New System.Windows.Forms.TextBox()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.InactivosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.InactivosTableAdapter()
        Me.UbicacionesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.UbicacionesTableAdapter()
        Me.PlanillasTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.PlanillasTableAdapter()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PlanillasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panelnuevoregistro = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdImprimirCarnet = New System.Windows.Forms.PictureBox()
        Me.cmdSeleccionarImagen = New System.Windows.Forms.Button()
        Me.PictureFoto = New System.Windows.Forms.PictureBox()
        Me.IdentidadTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TipodesangreTextBox = New System.Windows.Forms.ComboBox()
        Me.Telefono1TextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono2TextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.FechadenacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Telefono3TextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cmdReparar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ParentescoComboBox = New System.Windows.Forms.ComboBox()
        Me.EstadocivilComboBox = New System.Windows.Forms.ComboBox()
        Me.HijosTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox1 = New System.Windows.Forms.TextBox()
        Me.Telefono4TextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumdecuentaTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxQR = New System.Windows.Forms.TextBox()
        Me.NomdebancoComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox_BHORAS = New System.Windows.Forms.ComboBox()
        Me.txt_depreciacion = New System.Windows.Forms.TextBox()
        Me.PictureQR = New System.Windows.Forms.PictureBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.BonosTextBox = New System.Windows.Forms.TextBox()
        Me.FechadeingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.PlanillaComboBox = New System.Windows.Forms.ComboBox()
        Me.labelsalario = New System.Windows.Forms.Label()
        Me.SalarioTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.IdempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.cmdnuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadocivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hijos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parentesco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bhoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depreciacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panelinactivos = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.uniformecombo = New System.Windows.Forms.ComboBox()
        Me.CarnetComboBox = New System.Windows.Forms.ComboBox()
        Me.ComentarioTextBox = New System.Windows.Forms.TextBox()
        Me.MotivoComboBox = New System.Windows.Forms.ComboBox()
        Me.FechadesalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CodigoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ButtonActualizarIncativos = New System.Windows.Forms.Button()
        Me.ButtonGuardarInactivos = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PreciosCarnetDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciosCarnetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrecioCarnetTextBox = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PreciosCarnetTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.PreciosCarnetTableAdapter()
        LatitudLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CodigoLabel1 = New System.Windows.Forms.Label()
        FechadesalidaLabel = New System.Windows.Forms.Label()
        MotivoLabel = New System.Windows.Forms.Label()
        ComentarioLabel = New System.Windows.Forms.Label()
        CarnetLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        IdempleadoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        PlanillaLabel = New System.Windows.Forms.Label()
        FechadeingresoLabel = New System.Windows.Forms.Label()
        BonosLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NumdecuentaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel1 = New System.Windows.Forms.Label()
        DireccionLabel1 = New System.Windows.Forms.Label()
        HijosLabel = New System.Windows.Forms.Label()
        EstadocivilLabel = New System.Windows.Forms.Label()
        ParentescoLabel = New System.Windows.Forms.Label()
        Telefono3Label = New System.Windows.Forms.Label()
        FechadenacimientoLabel = New System.Windows.Forms.Label()
        Telefono2Label = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TipodesangreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        IdentidadLabel = New System.Windows.Forms.Label()
        PrecioCarnetLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.UbicacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelValidaCarnet.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PlanillasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.panelnuevoregistro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmdImprimirCarnet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelinactivos.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PreciosCarnetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCarnetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'LatitudLabel
        '
        LatitudLabel.AutoSize = True
        LatitudLabel.Location = New System.Drawing.Point(14, 10)
        LatitudLabel.Name = "LatitudLabel"
        LatitudLabel.Size = New System.Drawing.Size(58, 13)
        LatitudLabel.TabIndex = 9
        LatitudLabel.Text = "Ubicacion:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(17, 100)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(70, 13)
        Label4.TabIndex = 12
        Label4.Text = "Observacion:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 47)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(109, 13)
        Label2.TabIndex = 42
        Label2.Text = "Nombre de la Planilla:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(107, 21)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 43
        IdLabel.Text = "Id:"
        '
        'CodigoLabel1
        '
        CodigoLabel1.AutoSize = True
        CodigoLabel1.Location = New System.Drawing.Point(47, 21)
        CodigoLabel1.Name = "CodigoLabel1"
        CodigoLabel1.Size = New System.Drawing.Size(43, 13)
        CodigoLabel1.TabIndex = 0
        CodigoLabel1.Text = "Codigo:"
        '
        'FechadesalidaLabel
        '
        FechadesalidaLabel.AutoSize = True
        FechadesalidaLabel.Location = New System.Drawing.Point(24, 53)
        FechadesalidaLabel.Name = "FechadesalidaLabel"
        FechadesalidaLabel.Size = New System.Drawing.Size(66, 13)
        FechadesalidaLabel.TabIndex = 2
        FechadesalidaLabel.Text = "F. de Salida:"
        '
        'MotivoLabel
        '
        MotivoLabel.AutoSize = True
        MotivoLabel.Location = New System.Drawing.Point(48, 77)
        MotivoLabel.Name = "MotivoLabel"
        MotivoLabel.Size = New System.Drawing.Size(42, 13)
        MotivoLabel.TabIndex = 4
        MotivoLabel.Text = "Motivo:"
        '
        'ComentarioLabel
        '
        ComentarioLabel.AutoSize = True
        ComentarioLabel.Location = New System.Drawing.Point(15, 163)
        ComentarioLabel.Name = "ComentarioLabel"
        ComentarioLabel.Size = New System.Drawing.Size(128, 13)
        ComentarioLabel.TabIndex = 10
        ComentarioLabel.Text = "Comentario/Observacion:"
        '
        'CarnetLabel
        '
        CarnetLabel.AutoSize = True
        CarnetLabel.Location = New System.Drawing.Point(49, 103)
        CarnetLabel.Name = "CarnetLabel"
        CarnetLabel.Size = New System.Drawing.Size(41, 13)
        CarnetLabel.TabIndex = 11
        CarnetLabel.Text = "Carnet:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(698, 468)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(108, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo de Empleado:"
        CodigoLabel.Visible = False
        '
        'IdempleadoLabel
        '
        IdempleadoLabel.AutoSize = True
        IdempleadoLabel.Location = New System.Drawing.Point(742, 442)
        IdempleadoLabel.Name = "IdempleadoLabel"
        IdempleadoLabel.Size = New System.Drawing.Size(64, 13)
        IdempleadoLabel.TabIndex = 0
        IdempleadoLabel.Text = "idempleado:"
        IdempleadoLabel.Visible = False
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(22, 351)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(110, 13)
        EstadoLabel.TabIndex = 20
        EstadoLabel.Text = "Estado del Empleado:"
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Location = New System.Drawing.Point(90, 163)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(42, 13)
        SalarioLabel.TabIndex = 12
        SalarioLabel.Text = "Salario:"
        '
        'UbicacionLabel
        '
        UbicacionLabel.AutoSize = True
        UbicacionLabel.Location = New System.Drawing.Point(21, 51)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(111, 13)
        UbicacionLabel.TabIndex = 47
        UbicacionLabel.Text = "Ubicacion del Puesto:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(94, 115)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(38, 13)
        CargoLabel.TabIndex = 42
        CargoLabel.Text = "Cargo:"
        '
        'PlanillaLabel
        '
        PlanillaLabel.AutoSize = True
        PlanillaLabel.Location = New System.Drawing.Point(89, 139)
        PlanillaLabel.Name = "PlanillaLabel"
        PlanillaLabel.Size = New System.Drawing.Size(43, 13)
        PlanillaLabel.TabIndex = 48
        PlanillaLabel.Text = "Planilla:"
        '
        'FechadeingresoLabel
        '
        FechadeingresoLabel.AutoSize = True
        FechadeingresoLabel.Location = New System.Drawing.Point(60, 24)
        FechadeingresoLabel.Name = "FechadeingresoLabel"
        FechadeingresoLabel.Size = New System.Drawing.Size(72, 13)
        FechadeingresoLabel.TabIndex = 18
        FechadeingresoLabel.Text = "F. de Ingreso:"
        '
        'BonosLabel
        '
        BonosLabel.AutoSize = True
        BonosLabel.Location = New System.Drawing.Point(92, 258)
        BonosLabel.Name = "BonosLabel"
        BonosLabel.Size = New System.Drawing.Size(40, 13)
        BonosLabel.TabIndex = 49
        BonosLabel.Text = "Bonos:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(62, 380)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 51
        ObservacionLabel.Text = "Observacion:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(52, 230)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(80, 13)
        Label7.TabIndex = 54
        Label7.Text = "Base de Horas:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(59, 323)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(73, 13)
        Label8.TabIndex = 56
        Label8.Text = "Depreciacion:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(11, 45)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(98, 13)
        Label1.TabIndex = 22
        Label1.Text = "Nombre del Banco:"
        '
        'NumdecuentaLabel
        '
        NumdecuentaLabel.AutoSize = True
        NumdecuentaLabel.Location = New System.Drawing.Point(40, 21)
        NumdecuentaLabel.Name = "NumdecuentaLabel"
        NumdecuentaLabel.Size = New System.Drawing.Size(69, 13)
        NumdecuentaLabel.TabIndex = 14
        NumdecuentaLabel.Text = "# de Cuenta:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(11, 22)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(93, 13)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Nombre completo:"
        '
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.Location = New System.Drawing.Point(49, 70)
        TelefonoLabel1.Name = "TelefonoLabel1"
        TelefonoLabel1.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel1.TabIndex = 2
        TelefonoLabel1.Text = "Telefono:"
        '
        'DireccionLabel1
        '
        DireccionLabel1.AutoSize = True
        DireccionLabel1.Location = New System.Drawing.Point(49, 45)
        DireccionLabel1.Name = "DireccionLabel1"
        DireccionLabel1.Size = New System.Drawing.Size(55, 13)
        DireccionLabel1.TabIndex = 8
        DireccionLabel1.Text = "Direccion:"
        '
        'HijosLabel
        '
        HijosLabel.AutoSize = True
        HijosLabel.Location = New System.Drawing.Point(362, 72)
        HijosLabel.Name = "HijosLabel"
        HijosLabel.Size = New System.Drawing.Size(33, 13)
        HijosLabel.TabIndex = 10
        HijosLabel.Text = "Hijos:"
        '
        'EstadocivilLabel
        '
        EstadocivilLabel.AutoSize = True
        EstadocivilLabel.Location = New System.Drawing.Point(329, 46)
        EstadocivilLabel.Name = "EstadocivilLabel"
        EstadocivilLabel.Size = New System.Drawing.Size(64, 13)
        EstadocivilLabel.TabIndex = 11
        EstadocivilLabel.Text = "Estado civil:"
        '
        'ParentescoLabel
        '
        ParentescoLabel.AutoSize = True
        ParentescoLabel.Location = New System.Drawing.Point(329, 21)
        ParentescoLabel.Name = "ParentescoLabel"
        ParentescoLabel.Size = New System.Drawing.Size(64, 13)
        ParentescoLabel.TabIndex = 12
        ParentescoLabel.Text = "Parentesco:"
        '
        'Telefono3Label
        '
        Telefono3Label.AutoSize = True
        Telefono3Label.Location = New System.Drawing.Point(53, 192)
        Telefono3Label.Name = "Telefono3Label"
        Telefono3Label.Size = New System.Drawing.Size(58, 13)
        Telefono3Label.TabIndex = 38
        Telefono3Label.Text = "Telefono3:"
        '
        'FechadenacimientoLabel
        '
        FechadenacimientoLabel.AutoSize = True
        FechadenacimientoLabel.Location = New System.Drawing.Point(21, 98)
        FechadenacimientoLabel.Name = "FechadenacimientoLabel"
        FechadenacimientoLabel.Size = New System.Drawing.Size(90, 13)
        FechadenacimientoLabel.TabIndex = 10
        FechadenacimientoLabel.Text = "F. de Nacimiento:"
        '
        'Telefono2Label
        '
        Telefono2Label.AutoSize = True
        Telefono2Label.Location = New System.Drawing.Point(53, 168)
        Telefono2Label.Name = "Telefono2Label"
        Telefono2Label.Size = New System.Drawing.Size(58, 13)
        Telefono2Label.TabIndex = 36
        Telefono2Label.Text = "Telefono2:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(59, 24)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(52, 13)
        NombresLabel.TabIndex = 4
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(59, 48)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 6
        ApellidosLabel.Text = "Apellidos:"
        '
        'TipodesangreLabel
        '
        TipodesangreLabel.AutoSize = True
        TipodesangreLabel.Location = New System.Drawing.Point(30, 212)
        TipodesangreLabel.Name = "TipodesangreLabel"
        TipodesangreLabel.Size = New System.Drawing.Size(81, 13)
        TipodesangreLabel.TabIndex = 40
        TipodesangreLabel.Text = "Tipo de sangre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(53, 144)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(58, 13)
        TelefonoLabel.TabIndex = 31
        TelefonoLabel.Text = "Telefono1:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(13, 120)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(96, 13)
        DireccionLabel.TabIndex = 49
        DireccionLabel.Text = "Direccion de casa:"
        '
        'IdentidadLabel
        '
        IdentidadLabel.AutoSize = True
        IdentidadLabel.Location = New System.Drawing.Point(57, 72)
        IdentidadLabel.Name = "IdentidadLabel"
        IdentidadLabel.Size = New System.Drawing.Size(54, 13)
        IdentidadLabel.TabIndex = 8
        IdentidadLabel.Text = "Identidad:"
        '
        'PrecioCarnetLabel
        '
        PrecioCarnetLabel.AutoSize = True
        PrecioCarnetLabel.Location = New System.Drawing.Point(22, 22)
        PrecioCarnetLabel.Name = "PrecioCarnetLabel"
        PrecioCarnetLabel.Size = New System.Drawing.Size(74, 13)
        PrecioCarnetLabel.TabIndex = 43
        PrecioCarnetLabel.Text = "Precio Carnet:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(56, 49)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 44
        FechaLabel.Text = "Fecha:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadoDeEmpleadosToolStripMenuItem, Me.TodosLosEmpleadosToolStripMenuItem, Me.HistoricoDeEmpleadoToolStripMenuItem, Me.ReporteDeExpedientesToolStripMenuItem, Me.ReporteDeCumpleañerosToolStripMenuItem, Me.ReporteDeInactivosToolStripMenuItem, Me.RollDiarioDeEmpleadoToolStripMenuItem, Me.AsignacionesPorClienteToolStripMenuItem, Me.AsignacionesGeneralesToolStripMenuItem, Me.FaltasDeEmpleadoToolStripMenuItem1, Me.VoucherDePagoToolStripMenuItem, Me.PlanillaDeDeduccionesToolStripMenuItem, Me.PlanillaDePagosToolStripMenuItem, Me.ReporteAniversariosEmpleadosToolStripMenuItem, Me.HistorialDeCarnetToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EstadoDeEmpleadosToolStripMenuItem
        '
        Me.EstadoDeEmpleadosToolStripMenuItem.Name = "EstadoDeEmpleadosToolStripMenuItem"
        Me.EstadoDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.EstadoDeEmpleadosToolStripMenuItem.Text = "Empleados Segun Estado - Activo/Inactivos/Prueba"
        '
        'TodosLosEmpleadosToolStripMenuItem
        '
        Me.TodosLosEmpleadosToolStripMenuItem.Name = "TodosLosEmpleadosToolStripMenuItem"
        Me.TodosLosEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.TodosLosEmpleadosToolStripMenuItem.Text = "Todos Los Empleados - Rango de Fechas"
        '
        'HistoricoDeEmpleadoToolStripMenuItem
        '
        Me.HistoricoDeEmpleadoToolStripMenuItem.Name = "HistoricoDeEmpleadoToolStripMenuItem"
        Me.HistoricoDeEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.HistoricoDeEmpleadoToolStripMenuItem.Text = "Cambios de Puesto Segun Empleado"
        '
        'ReporteDeExpedientesToolStripMenuItem
        '
        Me.ReporteDeExpedientesToolStripMenuItem.Name = "ReporteDeExpedientesToolStripMenuItem"
        Me.ReporteDeExpedientesToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.ReporteDeExpedientesToolStripMenuItem.Text = "Documentacion de Expedientes"
        '
        'ReporteDeCumpleañerosToolStripMenuItem
        '
        Me.ReporteDeCumpleañerosToolStripMenuItem.Name = "ReporteDeCumpleañerosToolStripMenuItem"
        Me.ReporteDeCumpleañerosToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.ReporteDeCumpleañerosToolStripMenuItem.Text = "Cumpleañeros del Mes"
        '
        'ReporteDeInactivosToolStripMenuItem
        '
        Me.ReporteDeInactivosToolStripMenuItem.Name = "ReporteDeInactivosToolStripMenuItem"
        Me.ReporteDeInactivosToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.ReporteDeInactivosToolStripMenuItem.Text = "Empleados Inactivos"
        '
        'RollDiarioDeEmpleadoToolStripMenuItem
        '
        Me.RollDiarioDeEmpleadoToolStripMenuItem.Name = "RollDiarioDeEmpleadoToolStripMenuItem"
        Me.RollDiarioDeEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.RollDiarioDeEmpleadoToolStripMenuItem.Text = "Roll diario de Empleado"
        '
        'AsignacionesPorClienteToolStripMenuItem
        '
        Me.AsignacionesPorClienteToolStripMenuItem.Name = "AsignacionesPorClienteToolStripMenuItem"
        Me.AsignacionesPorClienteToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.AsignacionesPorClienteToolStripMenuItem.Text = "Asignaciones por Cliente"
        '
        'AsignacionesGeneralesToolStripMenuItem
        '
        Me.AsignacionesGeneralesToolStripMenuItem.Name = "AsignacionesGeneralesToolStripMenuItem"
        Me.AsignacionesGeneralesToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.AsignacionesGeneralesToolStripMenuItem.Text = "Asignaciones Generales"
        '
        'FaltasDeEmpleadoToolStripMenuItem1
        '
        Me.FaltasDeEmpleadoToolStripMenuItem1.Name = "FaltasDeEmpleadoToolStripMenuItem1"
        Me.FaltasDeEmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(356, 22)
        Me.FaltasDeEmpleadoToolStripMenuItem1.Text = "Faltas de Empleado / 45"
        '
        'VoucherDePagoToolStripMenuItem
        '
        Me.VoucherDePagoToolStripMenuItem.Name = "VoucherDePagoToolStripMenuItem"
        Me.VoucherDePagoToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.VoucherDePagoToolStripMenuItem.Text = "Voucher de Pago"
        '
        'PlanillaDeDeduccionesToolStripMenuItem
        '
        Me.PlanillaDeDeduccionesToolStripMenuItem.Name = "PlanillaDeDeduccionesToolStripMenuItem"
        Me.PlanillaDeDeduccionesToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.PlanillaDeDeduccionesToolStripMenuItem.Text = "Planilla de deducciones"
        '
        'PlanillaDePagosToolStripMenuItem
        '
        Me.PlanillaDePagosToolStripMenuItem.Name = "PlanillaDePagosToolStripMenuItem"
        Me.PlanillaDePagosToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.PlanillaDePagosToolStripMenuItem.Text = "Planilla de Pagos"
        '
        'ReporteAniversariosEmpleadosToolStripMenuItem
        '
        Me.ReporteAniversariosEmpleadosToolStripMenuItem.Name = "ReporteAniversariosEmpleadosToolStripMenuItem"
        Me.ReporteAniversariosEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.ReporteAniversariosEmpleadosToolStripMenuItem.Text = "Aniversarios Empleados"
        '
        'HistorialDeCarnetToolStripMenuItem
        '
        Me.HistorialDeCarnetToolStripMenuItem.Name = "HistorialDeCarnetToolStripMenuItem"
        Me.HistorialDeCarnetToolStripMenuItem.Size = New System.Drawing.Size(356, 22)
        Me.HistorialDeCarnetToolStripMenuItem.Text = "Historial de Carnet"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Notificacion"
        '
        'txt_Coordenadas
        '
        Me.txt_Coordenadas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UbicacionesBindingSource, "latitud", True))
        Me.txt_Coordenadas.Location = New System.Drawing.Point(77, 7)
        Me.txt_Coordenadas.Name = "txt_Coordenadas"
        Me.txt_Coordenadas.Size = New System.Drawing.Size(201, 20)
        Me.txt_Coordenadas.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txt_Coordenadas, "Si desea ver las ubicacion con lineas de seguimiento copie la cadena de numeros y" &
        " peguela en el buscador de https://www.google.com/maps/")
        '
        'UbicacionesBindingSource
        '
        Me.UbicacionesBindingSource.DataMember = "Ubicaciones"
        Me.UbicacionesBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(325, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 33)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Recordatorios"
        Me.ToolTip1.SetToolTip(Me.Button1, "Agregar un recordatorio para una determinada fecha.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdCargar
        '
        Me.cmdCargar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmdCargar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCargar.FlatAppearance.BorderSize = 0
        Me.cmdCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCargar.Location = New System.Drawing.Point(196, 5)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(124, 33)
        Me.cmdCargar.TabIndex = 8
        Me.cmdCargar.Text = "Cargar Registros"
        Me.ToolTip1.SetToolTip(Me.cmdCargar, "Muestra la informacion de todos los empleados." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activos y en periodo de prueba.")
        Me.cmdCargar.UseVisualStyleBackColor = False
        '
        'CmdCSalario
        '
        Me.CmdCSalario.BackColor = System.Drawing.Color.SteelBlue
        Me.CmdCSalario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdCSalario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdCSalario.FlatAppearance.BorderSize = 0
        Me.CmdCSalario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdCSalario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdCSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCSalario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CmdCSalario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdCSalario.Location = New System.Drawing.Point(133, 187)
        Me.CmdCSalario.Name = "CmdCSalario"
        Me.CmdCSalario.Size = New System.Drawing.Size(98, 28)
        Me.CmdCSalario.TabIndex = 35
        Me.CmdCSalario.Text = "Cambiar Salario"
        Me.ToolTip1.SetToolTip(Me.CmdCSalario, "Se necesita permiso del gerente para realizar esta operacion.")
        Me.CmdCSalario.UseVisualStyleBackColor = False
        '
        'CmdCBono
        '
        Me.CmdCBono.BackColor = System.Drawing.Color.SteelBlue
        Me.CmdCBono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdCBono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdCBono.FlatAppearance.BorderSize = 0
        Me.CmdCBono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdCBono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdCBono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCBono.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CmdCBono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdCBono.Location = New System.Drawing.Point(133, 281)
        Me.CmdCBono.Name = "CmdCBono"
        Me.CmdCBono.Size = New System.Drawing.Size(98, 28)
        Me.CmdCBono.TabIndex = 62
        Me.CmdCBono.Text = "Cambiar Bono"
        Me.ToolTip1.SetToolTip(Me.CmdCBono, "Se necesita permiso del gerente para realizar esta operacion.")
        Me.CmdCBono.UseVisualStyleBackColor = False
        '
        'dlgBox
        '
        Me.dlgBox.FileName = "dlgBox"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(LatitudLabel)
        Me.Panel2.Controls.Add(Me.txt_Coordenadas)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(9, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 68)
        Me.Panel2.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(78, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 24)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Guardar/Actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PlanillasBindingSource
        '
        Me.PlanillasBindingSource.DataMember = "Planillas"
        Me.PlanillasBindingSource.DataSource = Me.ABASDataSet
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'PanelValidaCarnet
        '
        Me.PanelValidaCarnet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelValidaCarnet.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelValidaCarnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelValidaCarnet.Controls.Add(Me.Button11)
        Me.PanelValidaCarnet.Controls.Add(Me.CmdCarnetGratis)
        Me.PanelValidaCarnet.Controls.Add(Me.txtClaveGer)
        Me.PanelValidaCarnet.Controls.Add(Me.txtUsuarioGer)
        Me.PanelValidaCarnet.Controls.Add(Me.Label9)
        Me.PanelValidaCarnet.Controls.Add(Me.Label10)
        Me.PanelValidaCarnet.Controls.Add(Me.Label5)
        Me.PanelValidaCarnet.Controls.Add(Label4)
        Me.PanelValidaCarnet.Controls.Add(Me.txtObservacionCarnet)
        Me.PanelValidaCarnet.Location = New System.Drawing.Point(316, 160)
        Me.PanelValidaCarnet.Name = "PanelValidaCarnet"
        Me.PanelValidaCarnet.Size = New System.Drawing.Size(273, 211)
        Me.PanelValidaCarnet.TabIndex = 65
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(150, 164)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(99, 29)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "Cancelar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'CmdCarnetGratis
        '
        Me.CmdCarnetGratis.Location = New System.Drawing.Point(29, 164)
        Me.CmdCarnetGratis.Name = "CmdCarnetGratis"
        Me.CmdCarnetGratis.Size = New System.Drawing.Size(99, 29)
        Me.CmdCarnetGratis.TabIndex = 18
        Me.CmdCarnetGratis.Text = "Gratis"
        Me.CmdCarnetGratis.UseVisualStyleBackColor = True
        '
        'txtClaveGer
        '
        Me.txtClaveGer.Location = New System.Drawing.Point(91, 66)
        Me.txtClaveGer.Name = "txtClaveGer"
        Me.txtClaveGer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveGer.Size = New System.Drawing.Size(149, 20)
        Me.txtClaveGer.TabIndex = 17
        '
        'txtUsuarioGer
        '
        Me.txtUsuarioGer.Location = New System.Drawing.Point(91, 36)
        Me.txtUsuarioGer.Name = "txtUsuarioGer"
        Me.txtUsuarioGer.Size = New System.Drawing.Size(149, 20)
        Me.txtUsuarioGer.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Clave:"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(271, 21)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Datos de Gerencia"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Usuario:"
        '
        'txtObservacionCarnet
        '
        Me.txtObservacionCarnet.Location = New System.Drawing.Point(91, 97)
        Me.txtObservacionCarnet.MaxLength = 500
        Me.txtObservacionCarnet.Multiline = True
        Me.txtObservacionCarnet.Name = "txtObservacionCarnet"
        Me.txtObservacionCarnet.Size = New System.Drawing.Size(149, 53)
        Me.txtObservacionCarnet.TabIndex = 18
        Me.txtObservacionCarnet.Text = "Ninguna"
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeTableAdapter = Nothing
        Me.TableAdapterManager.DiasTableAdapter = Nothing
        Me.TableAdapterManager.DocumentosEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
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
        'InactivosTableAdapter
        '
        Me.InactivosTableAdapter.ClearBeforeFill = True
        '
        'UbicacionesTableAdapter
        '
        Me.UbicacionesTableAdapter.ClearBeforeFill = True
        '
        'PlanillasTableAdapter
        '
        Me.PlanillasTableAdapter.ClearBeforeFill = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.PlanillasDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(957, 631)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Crear Planilla"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PlanillaTextBox)
        Me.GroupBox5.Controls.Add(Me.IdTextBox)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(IdLabel)
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(452, 144)
        Me.GroupBox5.TabIndex = 46
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle de las Planillas"
        '
        'PlanillaTextBox
        '
        Me.PlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillasBindingSource, "Planilla", True))
        Me.PlanillaTextBox.Location = New System.Drawing.Point(132, 44)
        Me.PlanillaTextBox.Name = "PlanillaTextBox"
        Me.PlanillaTextBox.Size = New System.Drawing.Size(260, 20)
        Me.PlanillaTextBox.TabIndex = 45
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanillasBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(132, 18)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 44
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(226, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 33)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Actualizar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.SteelBlue
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(54, 105)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 33)
        Me.Button7.TabIndex = 42
        Me.Button7.Text = "Nuevo"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.SteelBlue
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(140, 105)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 33)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Guardar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.SteelBlue
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(312, 105)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 33)
        Me.Button9.TabIndex = 41
        Me.Button9.Text = "Eliminar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PlanillasDataGridView
        '
        Me.PlanillasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlanillasDataGridView.AutoGenerateColumns = False
        Me.PlanillasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PlanillasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PlanillasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PlanillasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlanillasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.PlanillasDataGridView.DataSource = Me.PlanillasBindingSource
        Me.PlanillasDataGridView.Location = New System.Drawing.Point(8, 156)
        Me.PlanillasDataGridView.Name = "PlanillasDataGridView"
        Me.PlanillasDataGridView.RowHeadersVisible = False
        Me.PlanillasDataGridView.Size = New System.Drawing.Size(943, 472)
        Me.PlanillasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 40
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Planilla"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Planilla"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 65
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panelnuevoregistro)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.EmpleadosDataGridView)
        Me.TabPage1.Controls.Add(Me.Panelinactivos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(957, 631)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro de Empleados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panelnuevoregistro
        '
        Me.panelnuevoregistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelnuevoregistro.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.panelnuevoregistro.Controls.Add(Me.PanelValidaCarnet)
        Me.panelnuevoregistro.Controls.Add(Me.GroupBox1)
        Me.panelnuevoregistro.Controls.Add(Me.Button6)
        Me.panelnuevoregistro.Controls.Add(Me.cmdReparar)
        Me.panelnuevoregistro.Controls.Add(Me.GroupBox4)
        Me.panelnuevoregistro.Controls.Add(Me.GroupBox3)
        Me.panelnuevoregistro.Controls.Add(Me.GroupBox2)
        Me.panelnuevoregistro.Controls.Add(Me.Button2)
        Me.panelnuevoregistro.Controls.Add(Me.Label3)
        Me.panelnuevoregistro.Controls.Add(Me.cmdActualizar)
        Me.panelnuevoregistro.Controls.Add(IdempleadoLabel)
        Me.panelnuevoregistro.Controls.Add(Me.cmdGuardar)
        Me.panelnuevoregistro.Controls.Add(Me.IdempleadoTextBox)
        Me.panelnuevoregistro.Controls.Add(Me.CodigoTextBox)
        Me.panelnuevoregistro.Controls.Add(CodigoLabel)
        Me.panelnuevoregistro.Location = New System.Drawing.Point(15, 52)
        Me.panelnuevoregistro.Name = "panelnuevoregistro"
        Me.panelnuevoregistro.Size = New System.Drawing.Size(924, 573)
        Me.panelnuevoregistro.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox1.Controls.Add(Me.cmdImprimirCarnet)
        Me.GroupBox1.Controls.Add(Me.cmdSeleccionarImagen)
        Me.GroupBox1.Controls.Add(Me.PictureFoto)
        Me.GroupBox1.Controls.Add(Me.IdentidadTextBox)
        Me.GroupBox1.Controls.Add(IdentidadLabel)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(Me.TipodesangreTextBox)
        Me.GroupBox1.Controls.Add(Me.Telefono1TextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(TipodesangreLabel)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Controls.Add(Me.Telefono2TextBox)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Telefono2Label)
        Me.GroupBox1.Controls.Add(Me.FechadenacimientoDateTimePicker)
        Me.GroupBox1.Controls.Add(FechadenacimientoLabel)
        Me.GroupBox1.Controls.Add(Me.Telefono3TextBox)
        Me.GroupBox1.Controls.Add(Telefono3Label)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 307)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'cmdImprimirCarnet
        '
        Me.cmdImprimirCarnet.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Print_48px_2
        Me.cmdImprimirCarnet.Location = New System.Drawing.Point(465, 236)
        Me.cmdImprimirCarnet.Name = "cmdImprimirCarnet"
        Me.cmdImprimirCarnet.Size = New System.Drawing.Size(34, 34)
        Me.cmdImprimirCarnet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmdImprimirCarnet.TabIndex = 53
        Me.cmdImprimirCarnet.TabStop = False
        '
        'cmdSeleccionarImagen
        '
        Me.cmdSeleccionarImagen.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdSeleccionarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdSeleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSeleccionarImagen.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSeleccionarImagen.ForeColor = System.Drawing.Color.White
        Me.cmdSeleccionarImagen.Location = New System.Drawing.Point(321, 236)
        Me.cmdSeleccionarImagen.Name = "cmdSeleccionarImagen"
        Me.cmdSeleccionarImagen.Size = New System.Drawing.Size(138, 23)
        Me.cmdSeleccionarImagen.TabIndex = 52
        Me.cmdSeleccionarImagen.Text = "Seleccionar Imagen"
        Me.cmdSeleccionarImagen.UseVisualStyleBackColor = False
        '
        'PictureFoto
        '
        Me.PictureFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureFoto.Location = New System.Drawing.Point(321, 21)
        Me.PictureFoto.Name = "PictureFoto"
        Me.PictureFoto.Size = New System.Drawing.Size(178, 209)
        Me.PictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureFoto.TabIndex = 51
        Me.PictureFoto.TabStop = False
        '
        'IdentidadTextBox
        '
        Me.IdentidadTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IdentidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "identidad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.IdentidadTextBox.Location = New System.Drawing.Point(115, 69)
        Me.IdentidadTextBox.MaxLength = 15
        Me.IdentidadTextBox.Name = "IdentidadTextBox"
        Me.IdentidadTextBox.Size = New System.Drawing.Size(99, 20)
        Me.IdentidadTextBox.TabIndex = 9
        Me.IdentidadTextBox.Tag = ""
        Me.IdentidadTextBox.Text = "0000-0000-00000"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(115, 45)
        Me.ApellidosTextBox.MaxLength = 50
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidosTextBox.TabIndex = 7
        '
        'TipodesangreTextBox
        '
        Me.TipodesangreTextBox.FormattingEnabled = True
        Me.TipodesangreTextBox.Items.AddRange(New Object() {"Seleccionar", "O Positivo", "O Negativo", "RRHH Positivo", "RRHH Negativo", "B Positivo", "B Negativo", "AB Positivo", "AB Negativo", "A Positivo", "A Negativo"})
        Me.TipodesangreTextBox.Location = New System.Drawing.Point(115, 213)
        Me.TipodesangreTextBox.Name = "TipodesangreTextBox"
        Me.TipodesangreTextBox.Size = New System.Drawing.Size(99, 21)
        Me.TipodesangreTextBox.TabIndex = 47
        '
        'Telefono1TextBox
        '
        Me.Telefono1TextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Telefono1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "telefono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0000-0000", "N0"))
        Me.Telefono1TextBox.Location = New System.Drawing.Point(115, 141)
        Me.Telefono1TextBox.MaxLength = 9
        Me.Telefono1TextBox.Name = "Telefono1TextBox"
        Me.Telefono1TextBox.Size = New System.Drawing.Size(99, 20)
        Me.Telefono1TextBox.TabIndex = 32
        Me.Telefono1TextBox.Text = "0000-0000"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(115, 117)
        Me.DireccionTextBox.MaxLength = 100
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DireccionTextBox.TabIndex = 50
        '
        'Telefono2TextBox
        '
        Me.Telefono2TextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Telefono2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "telefono2", True))
        Me.Telefono2TextBox.Location = New System.Drawing.Point(115, 165)
        Me.Telefono2TextBox.MaxLength = 9
        Me.Telefono2TextBox.Name = "Telefono2TextBox"
        Me.Telefono2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono2TextBox.TabIndex = 37
        Me.Telefono2TextBox.Text = "0000-0000"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(115, 21)
        Me.NombresTextBox.MaxLength = 50
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombresTextBox.TabIndex = 5
        '
        'FechadenacimientoDateTimePicker
        '
        Me.FechadenacimientoDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FechadenacimientoDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechadenacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechadenacimiento", True))
        Me.FechadenacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechadenacimientoDateTimePicker.Location = New System.Drawing.Point(115, 93)
        Me.FechadenacimientoDateTimePicker.Name = "FechadenacimientoDateTimePicker"
        Me.FechadenacimientoDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.FechadenacimientoDateTimePicker.TabIndex = 11
        '
        'Telefono3TextBox
        '
        Me.Telefono3TextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Telefono3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "telefono3", True))
        Me.Telefono3TextBox.Location = New System.Drawing.Point(115, 189)
        Me.Telefono3TextBox.MaxLength = 9
        Me.Telefono3TextBox.Name = "Telefono3TextBox"
        Me.Telefono3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono3TextBox.TabIndex = 39
        Me.Telefono3TextBox.Text = "0000-0000"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SteelBlue
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(12, 528)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 33)
        Me.Button6.TabIndex = 59
        Me.Button6.Text = "Limpiar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'cmdReparar
        '
        Me.cmdReparar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdReparar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdReparar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdReparar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReparar.FlatAppearance.BorderSize = 0
        Me.cmdReparar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdReparar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdReparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReparar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReparar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdReparar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReparar.Location = New System.Drawing.Point(282, 528)
        Me.cmdReparar.Name = "cmdReparar"
        Me.cmdReparar.Size = New System.Drawing.Size(149, 33)
        Me.cmdReparar.TabIndex = 58
        Me.cmdReparar.Text = "Reparar CODIGO"
        Me.cmdReparar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox4.Controls.Add(ParentescoLabel)
        Me.GroupBox4.Controls.Add(Me.ParentescoComboBox)
        Me.GroupBox4.Controls.Add(EstadocivilLabel)
        Me.GroupBox4.Controls.Add(Me.EstadocivilComboBox)
        Me.GroupBox4.Controls.Add(HijosLabel)
        Me.GroupBox4.Controls.Add(Me.HijosTextBox)
        Me.GroupBox4.Controls.Add(DireccionLabel1)
        Me.GroupBox4.Controls.Add(Me.DireccionTextBox1)
        Me.GroupBox4.Controls.Add(TelefonoLabel1)
        Me.GroupBox4.Controls.Add(Me.Telefono4TextBox)
        Me.GroupBox4.Controls.Add(NombreLabel)
        Me.GroupBox4.Controls.Add(Me.NombreTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 424)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(512, 100)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Familiares"
        '
        'ParentescoComboBox
        '
        Me.ParentescoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParentescoComboBox.FormattingEnabled = True
        Me.ParentescoComboBox.Items.AddRange(New Object() {"Seleccionar", "Mama", "Papa", "Esposo/a", "Hijo/a", "Hermano/a", "Tio/a", "Sobrino/a", "Cuñado/a", "Abuelo/a"})
        Me.ParentescoComboBox.Location = New System.Drawing.Point(399, 17)
        Me.ParentescoComboBox.Name = "ParentescoComboBox"
        Me.ParentescoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ParentescoComboBox.TabIndex = 13
        '
        'EstadocivilComboBox
        '
        Me.EstadocivilComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadocivilComboBox.FormattingEnabled = True
        Me.EstadocivilComboBox.Items.AddRange(New Object() {"Seleccionar", "Soltero/a", "UnionLibre", "Comprometido/a", "Casado/a", "Divorciado/a", "Viudo/a"})
        Me.EstadocivilComboBox.Location = New System.Drawing.Point(399, 42)
        Me.EstadocivilComboBox.Name = "EstadocivilComboBox"
        Me.EstadocivilComboBox.Size = New System.Drawing.Size(100, 21)
        Me.EstadocivilComboBox.TabIndex = 12
        '
        'HijosTextBox
        '
        Me.HijosTextBox.Location = New System.Drawing.Point(399, 68)
        Me.HijosTextBox.Name = "HijosTextBox"
        Me.HijosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HijosTextBox.TabIndex = 11
        '
        'DireccionTextBox1
        '
        Me.DireccionTextBox1.Location = New System.Drawing.Point(115, 44)
        Me.DireccionTextBox1.MaxLength = 100
        Me.DireccionTextBox1.Name = "DireccionTextBox1"
        Me.DireccionTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.DireccionTextBox1.TabIndex = 9
        '
        'Telefono4TextBox
        '
        Me.Telefono4TextBox.Location = New System.Drawing.Point(115, 67)
        Me.Telefono4TextBox.MaxLength = 9
        Me.Telefono4TextBox.Name = "Telefono4TextBox"
        Me.Telefono4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono4TextBox.TabIndex = 3
        Me.Telefono4TextBox.Text = "0000-0000"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(115, 19)
        Me.NombreTextBox.MaxLength = 100
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox3.Controls.Add(Me.NumdecuentaTextBox)
        Me.GroupBox3.Controls.Add(Me.TextBoxQR)
        Me.GroupBox3.Controls.Add(NumdecuentaLabel)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.NomdebancoComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 74)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Bancarios"
        '
        'NumdecuentaTextBox
        '
        Me.NumdecuentaTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NumdecuentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "numdecuenta", True))
        Me.NumdecuentaTextBox.Location = New System.Drawing.Point(115, 18)
        Me.NumdecuentaTextBox.MaxLength = 30
        Me.NumdecuentaTextBox.Name = "NumdecuentaTextBox"
        Me.NumdecuentaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NumdecuentaTextBox.TabIndex = 15
        '
        'TextBoxQR
        '
        Me.TextBoxQR.Location = New System.Drawing.Point(332, 19)
        Me.TextBoxQR.Multiline = True
        Me.TextBoxQR.Name = "TextBoxQR"
        Me.TextBoxQR.Size = New System.Drawing.Size(167, 44)
        Me.TextBoxQR.TabIndex = 57
        Me.TextBoxQR.Visible = False
        '
        'NomdebancoComboBox
        '
        Me.NomdebancoComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NomdebancoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nomdebanco", True))
        Me.NomdebancoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NomdebancoComboBox.FormattingEnabled = True
        Me.NomdebancoComboBox.Items.AddRange(New Object() {"Seleccionar", "BAC | Honduras", "Banco Atlántida", "Banco Azteca", "Banco Citibank de Honduras", "Banco Continental", "Banco Promerica", "Banco Ficensa", "Banco Ficohsa", "Banco Lafise", "Banco de los Trabajadores", "BANHCAFE", "Banco de Occidente", "Banco Procredit", "BANPAIS", "Davivienda", "BANADESA", "Banhprovi", "RAP"})
        Me.NomdebancoComboBox.Location = New System.Drawing.Point(115, 42)
        Me.NomdebancoComboBox.Name = "NomdebancoComboBox"
        Me.NomdebancoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NomdebancoComboBox.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox2.Controls.Add(Me.CmdCBono)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox_BHORAS)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Me.txt_depreciacion)
        Me.GroupBox2.Controls.Add(Me.PictureQR)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(ObservacionLabel)
        Me.GroupBox2.Controls.Add(Me.ObservacionTextBox)
        Me.GroupBox2.Controls.Add(BonosLabel)
        Me.GroupBox2.Controls.Add(Me.BonosTextBox)
        Me.GroupBox2.Controls.Add(Me.FechadeingresoDateTimePicker)
        Me.GroupBox2.Controls.Add(FechadeingresoLabel)
        Me.GroupBox2.Controls.Add(Me.CargoTextBox)
        Me.GroupBox2.Controls.Add(Me.CmdCSalario)
        Me.GroupBox2.Controls.Add(PlanillaLabel)
        Me.GroupBox2.Controls.Add(CargoLabel)
        Me.GroupBox2.Controls.Add(Me.PlanillaComboBox)
        Me.GroupBox2.Controls.Add(UbicacionLabel)
        Me.GroupBox2.Controls.Add(Me.labelsalario)
        Me.GroupBox2.Controls.Add(Me.SalarioTextBox)
        Me.GroupBox2.Controls.Add(SalarioLabel)
        Me.GroupBox2.Controls.Add(Me.EstadoComboBox)
        Me.GroupBox2.Controls.Add(EstadoLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(527, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 541)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos laborales dentro de la Empresa"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_add_96
        Me.PictureBox2.Location = New System.Drawing.Point(260, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(133, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 39)
        Me.ListBox1.TabIndex = 60
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 20)
        Me.TextBox1.TabIndex = 59
        '
        'ComboBox_BHORAS
        '
        Me.ComboBox_BHORAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_BHORAS.FormattingEnabled = True
        Me.ComboBox_BHORAS.Items.AddRange(New Object() {"120", "180"})
        Me.ComboBox_BHORAS.Location = New System.Drawing.Point(133, 225)
        Me.ComboBox_BHORAS.Name = "ComboBox_BHORAS"
        Me.ComboBox_BHORAS.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox_BHORAS.TabIndex = 58
        '
        'txt_depreciacion
        '
        Me.txt_depreciacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "observacion", True))
        Me.txt_depreciacion.Location = New System.Drawing.Point(133, 318)
        Me.txt_depreciacion.Name = "txt_depreciacion"
        Me.txt_depreciacion.Size = New System.Drawing.Size(98, 20)
        Me.txt_depreciacion.TabIndex = 57
        Me.txt_depreciacion.Text = "0"
        '
        'PictureQR
        '
        Me.PictureQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureQR.Location = New System.Drawing.Point(6, 412)
        Me.PictureQR.Name = "PictureQR"
        Me.PictureQR.Size = New System.Drawing.Size(122, 122)
        Me.PictureQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureQR.TabIndex = 56
        Me.PictureQR.TabStop = False
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(133, 377)
        Me.ObservacionTextBox.MaxLength = 500
        Me.ObservacionTextBox.Multiline = True
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(230, 158)
        Me.ObservacionTextBox.TabIndex = 52
        '
        'BonosTextBox
        '
        Me.BonosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.BonosTextBox.Location = New System.Drawing.Point(133, 253)
        Me.BonosTextBox.Name = "BonosTextBox"
        Me.BonosTextBox.Size = New System.Drawing.Size(98, 20)
        Me.BonosTextBox.TabIndex = 50
        Me.BonosTextBox.Text = "0"
        '
        'FechadeingresoDateTimePicker
        '
        Me.FechadeingresoDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FechadeingresoDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechadeingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechadeingreso", True))
        Me.FechadeingresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechadeingresoDateTimePicker.Location = New System.Drawing.Point(133, 21)
        Me.FechadeingresoDateTimePicker.Name = "FechadeingresoDateTimePicker"
        Me.FechadeingresoDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.FechadeingresoDateTimePicker.TabIndex = 19
        '
        'CargoTextBox
        '
        Me.CargoTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(133, 112)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(148, 20)
        Me.CargoTextBox.TabIndex = 43
        '
        'PlanillaComboBox
        '
        Me.PlanillaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "planilla", True))
        Me.PlanillaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlanillaComboBox.FormattingEnabled = True
        Me.PlanillaComboBox.Location = New System.Drawing.Point(133, 136)
        Me.PlanillaComboBox.Name = "PlanillaComboBox"
        Me.PlanillaComboBox.Size = New System.Drawing.Size(148, 21)
        Me.PlanillaComboBox.TabIndex = 49
        '
        'labelsalario
        '
        Me.labelsalario.AutoSize = True
        Me.labelsalario.ForeColor = System.Drawing.Color.Red
        Me.labelsalario.Location = New System.Drawing.Point(218, 165)
        Me.labelsalario.Name = "labelsalario"
        Me.labelsalario.Size = New System.Drawing.Size(103, 13)
        Me.labelsalario.TabIndex = 29
        Me.labelsalario.Text = "*Numeros sin comas"
        '
        'SalarioTextBox
        '
        Me.SalarioTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "salario", True))
        Me.SalarioTextBox.Location = New System.Drawing.Point(133, 161)
        Me.SalarioTextBox.MaxLength = 6
        Me.SalarioTextBox.Name = "SalarioTextBox"
        Me.SalarioTextBox.Size = New System.Drawing.Size(80, 20)
        Me.SalarioTextBox.TabIndex = 13
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "estado", True))
        Me.EstadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"Seleccionar", "Activo", "Inactivo", "Prueba"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(133, 346)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(98, 21)
        Me.EstadoComboBox.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 26)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Ocultar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(924, 26)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Registro de Empleado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.cmdActualizar.Location = New System.Drawing.Point(193, 528)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(85, 33)
        Me.cmdActualizar.TabIndex = 24
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.cmdGuardar.Location = New System.Drawing.Point(104, 528)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(85, 33)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'IdempleadoTextBox
        '
        Me.IdempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "idempleado", True))
        Me.IdempleadoTextBox.Location = New System.Drawing.Point(812, 439)
        Me.IdempleadoTextBox.Name = "IdempleadoTextBox"
        Me.IdempleadoTextBox.Size = New System.Drawing.Size(31, 20)
        Me.IdempleadoTextBox.TabIndex = 1
        Me.IdempleadoTextBox.Visible = False
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(812, 465)
        Me.CodigoTextBox.MaxLength = 6
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(31, 20)
        Me.CodigoTextBox.TabIndex = 3
        Me.CodigoTextBox.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.cmdCargar)
        Me.Panel3.Controls.Add(Me.tipodebusqueda)
        Me.Panel3.Controls.Add(Me.cmdnuevo)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.txtbusqueda)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(951, 43)
        Me.Panel3.TabIndex = 63
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.tipodebusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad", "Ubicacion", "Planilla"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(457, 14)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(159, 21)
        Me.tipodebusqueda.TabIndex = 3
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmdnuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdnuevo.FlatAppearance.BorderSize = 0
        Me.cmdnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdnuevo.Image = CType(resources.GetObject("cmdnuevo.Image"), System.Drawing.Image)
        Me.cmdnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdnuevo.Location = New System.Drawing.Point(12, 5)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(180, 33)
        Me.cmdnuevo.TabIndex = 2
        Me.cmdnuevo.Text = "Nuevo Registro"
        Me.cmdnuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(910, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.Location = New System.Drawing.Point(623, 15)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(281, 22)
        Me.txtbusqueda.TabIndex = 4
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(623, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 1)
        Me.Panel1.TabIndex = 5
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmpleadosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.direccion, Me.bonos, Me.observacion, Me.nombre, Me.estadocivil, Me.hijos, Me.parentesco, Me.direccion2, Me.telefono4, Me.bhoras, Me.depreciacion})
        Me.EmpleadosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmpleadosDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.EmpleadosDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(3, 44)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmpleadosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(951, 584)
        Me.EmpleadosDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idempleado"
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
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 119
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 74
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 74
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "identidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Identidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 76
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cargo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 74
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "telefono2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Telefono2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "telefono3"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Telefono3"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "tipodesangre"
        Me.DataGridViewTextBoxColumn10.HeaderText = "T. de Sangre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 87
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fechadenacimiento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "F. de Nacimiento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 103
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "salario"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Salario Base"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 84
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "numdecuenta"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Num. de Cuenta"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "nomdebanco"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nom. de Banco"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 97
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fechadeingreso"
        Me.DataGridViewTextBoxColumn15.HeaderText = "F. de Ingreso"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 87
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 65
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ubicacion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 80
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "planilla"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Planilla"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 65
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 77
        '
        'bonos
        '
        Me.bonos.DataPropertyName = "bonos"
        Me.bonos.HeaderText = "Bonos"
        Me.bonos.Name = "bonos"
        Me.bonos.Width = 62
        '
        'observacion
        '
        Me.observacion.DataPropertyName = "observacion"
        Me.observacion.HeaderText = "Observacion"
        Me.observacion.Name = "observacion"
        Me.observacion.Width = 92
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre de Familiar"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 112
        '
        'estadocivil
        '
        Me.estadocivil.DataPropertyName = "estadocivil"
        Me.estadocivil.HeaderText = "Estado Civil"
        Me.estadocivil.Name = "estadocivil"
        Me.estadocivil.Width = 80
        '
        'hijos
        '
        Me.hijos.DataPropertyName = "hijos"
        Me.hijos.HeaderText = "Hijos"
        Me.hijos.Name = "hijos"
        Me.hijos.Width = 55
        '
        'parentesco
        '
        Me.parentesco.DataPropertyName = "parentesco"
        Me.parentesco.HeaderText = "Parentesco"
        Me.parentesco.Name = "parentesco"
        Me.parentesco.Width = 86
        '
        'direccion2
        '
        Me.direccion2.DataPropertyName = "direccion2"
        Me.direccion2.HeaderText = "Direccion de Familiar"
        Me.direccion2.Name = "direccion2"
        Me.direccion2.Width = 88
        '
        'telefono4
        '
        Me.telefono4.DataPropertyName = "telefono4"
        Me.telefono4.HeaderText = "Telefono de Familiar"
        Me.telefono4.Name = "telefono4"
        Me.telefono4.Width = 85
        '
        'bhoras
        '
        Me.bhoras.DataPropertyName = "bhoras"
        Me.bhoras.HeaderText = "Base Horas"
        Me.bhoras.Name = "bhoras"
        Me.bhoras.Width = 80
        '
        'depreciacion
        '
        Me.depreciacion.DataPropertyName = "depreciacion"
        Me.depreciacion.HeaderText = "Depreciacion"
        Me.depreciacion.Name = "depreciacion"
        Me.depreciacion.Width = 95
        '
        'Panelinactivos
        '
        Me.Panelinactivos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panelinactivos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panelinactivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panelinactivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelinactivos.Controls.Add(Me.GroupBox8)
        Me.Panelinactivos.Controls.Add(Me.Button4)
        Me.Panelinactivos.Controls.Add(Me.Label35)
        Me.Panelinactivos.Controls.Add(Me.ButtonActualizarIncativos)
        Me.Panelinactivos.Controls.Add(Me.ButtonGuardarInactivos)
        Me.Panelinactivos.Location = New System.Drawing.Point(250, 100)
        Me.Panelinactivos.Name = "Panelinactivos"
        Me.Panelinactivos.Size = New System.Drawing.Size(432, 385)
        Me.Panelinactivos.TabIndex = 56
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.uniformecombo)
        Me.GroupBox8.Controls.Add(CarnetLabel)
        Me.GroupBox8.Controls.Add(Me.CarnetComboBox)
        Me.GroupBox8.Controls.Add(ComentarioLabel)
        Me.GroupBox8.Controls.Add(Me.ComentarioTextBox)
        Me.GroupBox8.Controls.Add(MotivoLabel)
        Me.GroupBox8.Controls.Add(Me.MotivoComboBox)
        Me.GroupBox8.Controls.Add(FechadesalidaLabel)
        Me.GroupBox8.Controls.Add(Me.FechadesalidaDateTimePicker)
        Me.GroupBox8.Controls.Add(CodigoLabel1)
        Me.GroupBox8.Controls.Add(Me.CodigoTextBox1)
        Me.GroupBox8.Location = New System.Drawing.Point(47, 52)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(339, 253)
        Me.GroupBox8.TabIndex = 52
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Datos De Salida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Uniforme:"
        '
        'uniformecombo
        '
        Me.uniformecombo.FormattingEnabled = True
        Me.uniformecombo.Items.AddRange(New Object() {"No", "Si", "Incompleto"})
        Me.uniformecombo.Location = New System.Drawing.Point(102, 127)
        Me.uniformecombo.Name = "uniformecombo"
        Me.uniformecombo.Size = New System.Drawing.Size(121, 21)
        Me.uniformecombo.TabIndex = 13
        '
        'CarnetComboBox
        '
        Me.CarnetComboBox.FormattingEnabled = True
        Me.CarnetComboBox.Items.AddRange(New Object() {"No", "Si"})
        Me.CarnetComboBox.Location = New System.Drawing.Point(102, 100)
        Me.CarnetComboBox.Name = "CarnetComboBox"
        Me.CarnetComboBox.Size = New System.Drawing.Size(41, 21)
        Me.CarnetComboBox.TabIndex = 12
        '
        'ComentarioTextBox
        '
        Me.ComentarioTextBox.Location = New System.Drawing.Point(17, 178)
        Me.ComentarioTextBox.Multiline = True
        Me.ComentarioTextBox.Name = "ComentarioTextBox"
        Me.ComentarioTextBox.Size = New System.Drawing.Size(314, 69)
        Me.ComentarioTextBox.TabIndex = 11
        '
        'MotivoComboBox
        '
        Me.MotivoComboBox.FormattingEnabled = True
        Me.MotivoComboBox.Items.AddRange(New Object() {"Despido", "Renuncia", "Abandono", "Otros..."})
        Me.MotivoComboBox.Location = New System.Drawing.Point(102, 74)
        Me.MotivoComboBox.Name = "MotivoComboBox"
        Me.MotivoComboBox.Size = New System.Drawing.Size(114, 21)
        Me.MotivoComboBox.TabIndex = 5
        '
        'FechadesalidaDateTimePicker
        '
        Me.FechadesalidaDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechadesalidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechadesalidaDateTimePicker.Location = New System.Drawing.Point(102, 49)
        Me.FechadesalidaDateTimePicker.Name = "FechadesalidaDateTimePicker"
        Me.FechadesalidaDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechadesalidaDateTimePicker.TabIndex = 3
        '
        'CodigoTextBox1
        '
        Me.CodigoTextBox1.Enabled = False
        Me.CodigoTextBox1.Location = New System.Drawing.Point(102, 18)
        Me.CodigoTextBox1.Name = "CodigoTextBox1"
        Me.CodigoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 28)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Ocultar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(430, 28)
        Me.Label35.TabIndex = 27
        Me.Label35.Text = "Empleado Inactivo"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonActualizarIncativos
        '
        Me.ButtonActualizarIncativos.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonActualizarIncativos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonActualizarIncativos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonActualizarIncativos.FlatAppearance.BorderSize = 0
        Me.ButtonActualizarIncativos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonActualizarIncativos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonActualizarIncativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizarIncativos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActualizarIncativos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonActualizarIncativos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonActualizarIncativos.Location = New System.Drawing.Point(226, 312)
        Me.ButtonActualizarIncativos.Name = "ButtonActualizarIncativos"
        Me.ButtonActualizarIncativos.Size = New System.Drawing.Size(100, 33)
        Me.ButtonActualizarIncativos.TabIndex = 24
        Me.ButtonActualizarIncativos.Text = "Actualizar"
        Me.ButtonActualizarIncativos.UseVisualStyleBackColor = False
        '
        'ButtonGuardarInactivos
        '
        Me.ButtonGuardarInactivos.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonGuardarInactivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonGuardarInactivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGuardarInactivos.FlatAppearance.BorderSize = 0
        Me.ButtonGuardarInactivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonGuardarInactivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonGuardarInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarInactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarInactivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGuardarInactivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGuardarInactivos.Location = New System.Drawing.Point(120, 312)
        Me.ButtonGuardarInactivos.Name = "ButtonGuardarInactivos"
        Me.ButtonGuardarInactivos.Size = New System.Drawing.Size(100, 33)
        Me.ButtonGuardarInactivos.TabIndex = 8
        Me.ButtonGuardarInactivos.Text = "Guardar"
        Me.ButtonGuardarInactivos.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(965, 657)
        Me.TabControl1.TabIndex = 64
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PreciosCarnetDataGridView)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(957, 631)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Precio Carnet"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PreciosCarnetDataGridView
        '
        Me.PreciosCarnetDataGridView.AutoGenerateColumns = False
        Me.PreciosCarnetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PreciosCarnetDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PreciosCarnetDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PreciosCarnetDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PreciosCarnetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PreciosCarnetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.PreciosCarnetDataGridView.DataSource = Me.PreciosCarnetBindingSource
        Me.PreciosCarnetDataGridView.Location = New System.Drawing.Point(9, 141)
        Me.PreciosCarnetDataGridView.Name = "PreciosCarnetDataGridView"
        Me.PreciosCarnetDataGridView.RowHeadersVisible = False
        Me.PreciosCarnetDataGridView.Size = New System.Drawing.Size(300, 225)
        Me.PreciosCarnetDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PrecioCarnet"
        Me.DataGridViewTextBoxColumn21.HeaderText = "PrecioCarnet"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 93
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 62
        '
        'PreciosCarnetBindingSource
        '
        Me.PreciosCarnetBindingSource.DataMember = "PreciosCarnet"
        Me.PreciosCarnetBindingSource.DataSource = Me.ABASDataSet
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(FechaLabel)
        Me.GroupBox6.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox6.Controls.Add(PrecioCarnetLabel)
        Me.GroupBox6.Controls.Add(Me.PrecioCarnetTextBox)
        Me.GroupBox6.Controls.Add(Me.Button10)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(236, 128)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Valor del precio de Carnet"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PreciosCarnetBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(102, 45)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechaDateTimePicker.TabIndex = 45
        '
        'PrecioCarnetTextBox
        '
        Me.PrecioCarnetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PreciosCarnetBindingSource, "PrecioCarnet", True))
        Me.PrecioCarnetTextBox.Location = New System.Drawing.Point(102, 19)
        Me.PrecioCarnetTextBox.Name = "PrecioCarnetTextBox"
        Me.PrecioCarnetTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioCarnetTextBox.TabIndex = 44
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.SteelBlue
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(81, 77)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 33)
        Me.Button10.TabIndex = 43
        Me.Button10.Text = "Guardar"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'PreciosCarnetTableAdapter
        '
        Me.PreciosCarnetTableAdapter.ClearBeforeFill = True
        '
        'FormRRHH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 684)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormRRHH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRRHH"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.UbicacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelValidaCarnet.ResumeLayout(False)
        Me.PanelValidaCarnet.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PlanillasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.panelnuevoregistro.ResumeLayout(False)
        Me.panelnuevoregistro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmdImprimirCarnet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelinactivos.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PreciosCarnetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCarnetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadoDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoricoDeEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ReporteDeExpedientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InactivosTableAdapter As ABASDataSetTableAdapters.InactivosTableAdapter
    Friend WithEvents ReporteDeCumpleañerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeInactivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RollDiarioDeEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionesPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionesGeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaltasDeEmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VoucherDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanillaDeDeduccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanillaDePagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteAniversariosEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosLosEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgBox As OpenFileDialog
    Friend WithEvents HistorialDeCarnetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UbicacionesBindingSource As BindingSource
    Friend WithEvents UbicacionesTableAdapter As ABASDataSetTableAdapters.UbicacionesTableAdapter
    Friend WithEvents txt_Coordenadas As TextBox
    Friend WithEvents PlanillasBindingSource As BindingSource
    Friend WithEvents PlanillasTableAdapter As ABASDataSetTableAdapters.PlanillasTableAdapter
    Friend WithEvents PanelValidaCarnet As Panel
    Friend WithEvents CmdCarnetGratis As Button
    Friend WithEvents txtClaveGer As TextBox
    Friend WithEvents txtUsuarioGer As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtObservacionCarnet As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PlanillaTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents PlanillasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents panelnuevoregistro As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdImprimirCarnet As PictureBox
    Friend WithEvents cmdSeleccionarImagen As Button
    Friend WithEvents PictureFoto As PictureBox
    Friend WithEvents IdentidadTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents TipodesangreTextBox As ComboBox
    Friend WithEvents Telefono1TextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents Telefono2TextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents FechadenacimientoDateTimePicker As DateTimePicker
    Friend WithEvents Telefono3TextBox As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents cmdReparar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ParentescoComboBox As ComboBox
    Friend WithEvents EstadocivilComboBox As ComboBox
    Friend WithEvents HijosTextBox As TextBox
    Friend WithEvents DireccionTextBox1 As TextBox
    Friend WithEvents Telefono4TextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NumdecuentaTextBox As TextBox
    Friend WithEvents TextBoxQR As TextBox
    Friend WithEvents NomdebancoComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmdCBono As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox_BHORAS As ComboBox
    Friend WithEvents txt_depreciacion As TextBox
    Friend WithEvents PictureQR As PictureBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents BonosTextBox As TextBox
    Friend WithEvents FechadeingresoDateTimePicker As DateTimePicker
    Friend WithEvents CargoTextBox As TextBox
    Friend WithEvents CmdCSalario As Button
    Friend WithEvents PlanillaComboBox As ComboBox
    Friend WithEvents labelsalario As Label
    Friend WithEvents SalarioTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents IdempleadoTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmdCargar As Button
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents cmdnuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents bonos As DataGridViewTextBoxColumn
    Friend WithEvents observacion As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents estadocivil As DataGridViewTextBoxColumn
    Friend WithEvents hijos As DataGridViewTextBoxColumn
    Friend WithEvents parentesco As DataGridViewTextBoxColumn
    Friend WithEvents direccion2 As DataGridViewTextBoxColumn
    Friend WithEvents telefono4 As DataGridViewTextBoxColumn
    Friend WithEvents bhoras As DataGridViewTextBoxColumn
    Friend WithEvents depreciacion As DataGridViewTextBoxColumn
    Friend WithEvents Panelinactivos As Panel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents uniformecombo As ComboBox
    Friend WithEvents CarnetComboBox As ComboBox
    Friend WithEvents ComentarioTextBox As TextBox
    Friend WithEvents MotivoComboBox As ComboBox
    Friend WithEvents FechadesalidaDateTimePicker As DateTimePicker
    Friend WithEvents CodigoTextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents ButtonActualizarIncativos As Button
    Friend WithEvents ButtonGuardarInactivos As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button10 As Button
    Friend WithEvents PreciosCarnetBindingSource As BindingSource
    Friend WithEvents PreciosCarnetTableAdapter As ABASDataSetTableAdapters.PreciosCarnetTableAdapter
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents PrecioCarnetTextBox As TextBox
    Friend WithEvents PreciosCarnetDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents Button11 As Button
End Class
