<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPlanilla
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim HorasextrasLabel As System.Windows.Forms.Label
        Dim IhssLabel As System.Windows.Forms.Label
        Dim RapLabel As System.Windows.Forms.Label
        Dim HorasLabel As System.Windows.Forms.Label
        Dim lbl_prestamo As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim BonosLabel As System.Windows.Forms.Label
        Dim lbl_uniforme As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim AdelantoLabel As System.Windows.Forms.Label
        Dim UniformeLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim TotalapagarLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim AsignacionLabel As System.Windows.Forms.Label
        Dim DiasLabel As System.Windows.Forms.Label
        Dim VacacionesLabel As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim IdentidadLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim NumdecuentaLabel As System.Windows.Forms.Label
        Dim NomdebancoLabel As System.Windows.Forms.Label
        Dim FechadeingresoLabel As System.Windows.Forms.Label
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Txt_NuevoUniforme = New System.Windows.Forms.TextBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.cmdNuevoUniforme = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Txt_NuevoSalario = New System.Windows.Forms.TextBox()
        Me.cmdCambiar = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Txt_NuevoPrestamo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_deducciones = New System.Windows.Forms.TextBox()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalapagarTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bisiesto = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.GroupBox()
        Me.txt_depreciacion = New System.Windows.Forms.TextBox()
        Me.txt_bhoras = New System.Windows.Forms.TextBox()
        Me.cmdBuscarEmpleado = New System.Windows.Forms.PictureBox()
        Me.txt_bono = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.SalarioTextBox = New System.Windows.Forms.TextBox()
        Me.msj = New System.Windows.Forms.Label()
        Me.cmdCalcular = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_phoras = New System.Windows.Forms.TextBox()
        Me.txt_ajustes = New System.Windows.Forms.TextBox()
        Me.txt_vacaciones = New System.Windows.Forms.TextBox()
        Me.Precio = New System.Windows.Forms.TextBox()
        Me.AsignacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorasextrasTextBox = New System.Windows.Forms.TextBox()
        Me.txt_pextras = New System.Windows.Forms.TextBox()
        Me.HorasTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DiasTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_saluniforme = New System.Windows.Forms.TextBox()
        Me.txt_uniforme = New System.Windows.Forms.TextBox()
        Me.txtsaldopres = New System.Windows.Forms.TextBox()
        Me.txtprestamo = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_valorturnoextra = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txt_hferiado = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_pagoferiado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.horassep = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_septimo = New System.Windows.Forms.TextBox()
        Me.txt_turnoextra = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtOtraDeduccion = New System.Windows.Forms.TextBox()
        Me.AdelantoTextBox = New System.Windows.Forms.TextBox()
        Me.UniformeTextBox = New System.Windows.Forms.TextBox()
        Me.txt_anticipo = New System.Windows.Forms.TextBox()
        Me.RapTextBox = New System.Windows.Forms.TextBox()
        Me.IhssTextBox = New System.Windows.Forms.TextBox()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.txtturno = New System.Windows.Forms.TextBox()
        Me.FECHAFINAL = New System.Windows.Forms.TextBox()
        Me.FECHAINICIAL = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanillaDePagosPorUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarUnVoucherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeduccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanillaDeDeduccionesPorUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionesDeEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionesGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeImpresionDeCarnetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobanteEntregaUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobanteDevolucionUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesGerencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleDePlanillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleDePlanillaUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelempleados = New System.Windows.Forms.Panel()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bhoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depreciacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idasignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MESINICIAL = New System.Windows.Forms.TextBox()
        Me.MESFINAL = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Paneldetalles = New System.Windows.Forms.Panel()
        Me.txtJornada = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtIdPago = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.AsignacionesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.AsignacionesTableAdapter()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.PagosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.PagosTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AnticiposDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnticiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdEliminarAnticipo = New System.Windows.Forms.Button()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.fechaanticipo = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.FechadeingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.AnticiposTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.AnticiposTableAdapter()
        CodigoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        HorasextrasLabel = New System.Windows.Forms.Label()
        IhssLabel = New System.Windows.Forms.Label()
        RapLabel = New System.Windows.Forms.Label()
        HorasLabel = New System.Windows.Forms.Label()
        lbl_prestamo = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        BonosLabel = New System.Windows.Forms.Label()
        lbl_uniforme = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        AdelantoLabel = New System.Windows.Forms.Label()
        UniformeLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        TotalapagarLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        AsignacionLabel = New System.Windows.Forms.Label()
        DiasLabel = New System.Windows.Forms.Label()
        VacacionesLabel = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        IdentidadLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        NumdecuentaLabel = New System.Windows.Forms.Label()
        NomdebancoLabel = New System.Windows.Forms.Label()
        FechadeingresoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Empleado.SuspendLayout()
        CType(Me.cmdBuscarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelempleados.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneldetalles.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnticiposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(12, 23)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(41, 13)
        Label1.TabIndex = 32
        Label1.Text = "Desde:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(19, 47)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(38, 13)
        Label2.TabIndex = 33
        Label2.Text = "Hasta:"
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Location = New System.Drawing.Point(56, 93)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(69, 13)
        SalarioLabel.TabIndex = 51
        SalarioLabel.Text = "Salario Base:"
        '
        'HorasextrasLabel
        '
        HorasextrasLabel.AutoSize = True
        HorasextrasLabel.Location = New System.Drawing.Point(171, 53)
        HorasextrasLabel.Name = "HorasextrasLabel"
        HorasextrasLabel.Size = New System.Drawing.Size(70, 13)
        HorasextrasLabel.TabIndex = 57
        HorasextrasLabel.Text = "Horas Extras:"
        '
        'IhssLabel
        '
        IhssLabel.AutoSize = True
        IhssLabel.Location = New System.Drawing.Point(64, 22)
        IhssLabel.Name = "IhssLabel"
        IhssLabel.Size = New System.Drawing.Size(35, 13)
        IhssLabel.TabIndex = 61
        IhssLabel.Text = "IHSS:"
        '
        'RapLabel
        '
        RapLabel.AutoSize = True
        RapLabel.Location = New System.Drawing.Point(67, 47)
        RapLabel.Name = "RapLabel"
        RapLabel.Size = New System.Drawing.Size(32, 13)
        RapLabel.TabIndex = 62
        RapLabel.Text = "RAP:"
        '
        'HorasLabel
        '
        HorasLabel.AutoSize = True
        HorasLabel.Location = New System.Drawing.Point(147, 28)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(94, 13)
        HorasLabel.TabIndex = 65
        HorasLabel.Text = "Horas Trabajadas:"
        '
        'lbl_prestamo
        '
        lbl_prestamo.AutoSize = True
        lbl_prestamo.Location = New System.Drawing.Point(14, 22)
        lbl_prestamo.Name = "lbl_prestamo"
        lbl_prestamo.Size = New System.Drawing.Size(51, 13)
        lbl_prestamo.TabIndex = 73
        lbl_prestamo.Text = "Prestamo"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(14, 60)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(81, 13)
        Label12.TabIndex = 76
        Label12.Text = "Saldo Prestamo"
        '
        'BonosLabel
        '
        BonosLabel.AutoSize = True
        BonosLabel.Location = New System.Drawing.Point(85, 166)
        BonosLabel.Name = "BonosLabel"
        BonosLabel.Size = New System.Drawing.Size(40, 13)
        BonosLabel.TabIndex = 77
        BonosLabel.Text = "Bonos:"
        '
        'lbl_uniforme
        '
        lbl_uniforme.AutoSize = True
        lbl_uniforme.Location = New System.Drawing.Point(96, 21)
        lbl_uniforme.Name = "lbl_uniforme"
        lbl_uniforme.Size = New System.Drawing.Size(49, 13)
        lbl_uniforme.TabIndex = 78
        lbl_uniforme.Text = "Uniforme"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(96, 59)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(79, 13)
        Label16.TabIndex = 80
        Label16.Text = "Saldo Uniforme"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(52, 72)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(48, 13)
        Label11.TabIndex = 66
        Label11.Text = "Anticipo:"
        '
        'AdelantoLabel
        '
        AdelantoLabel.AutoSize = True
        AdelantoLabel.Location = New System.Drawing.Point(9, 123)
        AdelantoLabel.Name = "AdelantoLabel"
        AdelantoLabel.Size = New System.Drawing.Size(90, 13)
        AdelantoLabel.TabIndex = 70
        AdelantoLabel.Text = "Abono/Prestamo:"
        '
        'UniformeLabel
        '
        UniformeLabel.AutoSize = True
        UniformeLabel.Location = New System.Drawing.Point(11, 99)
        UniformeLabel.Name = "UniformeLabel"
        UniformeLabel.Size = New System.Drawing.Size(88, 13)
        UniformeLabel.TabIndex = 68
        UniformeLabel.Text = "Abono/Uniforme:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(11, 48)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 13)
        Label4.TabIndex = 78
        Label4.Text = "Total Deducciones:"
        '
        'TotalapagarLabel
        '
        TotalapagarLabel.AutoSize = True
        TotalapagarLabel.Location = New System.Drawing.Point(20, 74)
        TotalapagarLabel.Name = "TotalapagarLabel"
        TotalapagarLabel.Size = New System.Drawing.Size(93, 13)
        TotalapagarLabel.TabIndex = 74
        TotalapagarLabel.Text = "Total Devengado:"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Location = New System.Drawing.Point(62, 22)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(49, 13)
        SubtotalLabel.TabIndex = 76
        SubtotalLabel.Text = "Subtotal:"
        '
        'AsignacionLabel
        '
        AsignacionLabel.AutoSize = True
        AsignacionLabel.Location = New System.Drawing.Point(400, 77)
        AsignacionLabel.Name = "AsignacionLabel"
        AsignacionLabel.Size = New System.Drawing.Size(39, 13)
        AsignacionLabel.TabIndex = 95
        AsignacionLabel.Text = "Ajuste:"
        '
        'DiasLabel
        '
        DiasLabel.AutoSize = True
        DiasLabel.Location = New System.Drawing.Point(9, 27)
        DiasLabel.Name = "DiasLabel"
        DiasLabel.Size = New System.Drawing.Size(83, 13)
        DiasLabel.TabIndex = 89
        DiasLabel.Text = "Dias trabajados:"
        '
        'VacacionesLabel
        '
        VacacionesLabel.AutoSize = True
        VacacionesLabel.Location = New System.Drawing.Point(26, 53)
        VacacionesLabel.Name = "VacacionesLabel"
        VacacionesLabel.Size = New System.Drawing.Size(66, 13)
        VacacionesLabel.TabIndex = 93
        VacacionesLabel.Text = "Vacaciones:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(45, 117)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(80, 13)
        Label22.TabIndex = 79
        Label22.Text = "Base de Horas:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(52, 141)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(73, 13)
        Label23.TabIndex = 81
        Label23.Text = "Depreciacion:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(342, 25)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(97, 13)
        Label8.TabIndex = 86
        Label8.Text = "Devengado Horas:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(341, 49)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(98, 13)
        Label5.TabIndex = 87
        Label5.Text = "Devengado Extras:"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Location = New System.Drawing.Point(13, 150)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(87, 13)
        Label35.TabIndex = 73
        Label35.Text = "Otra/Deduccion:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(78, 156)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 23
        EstadoLabel.Text = "Estado:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(11, 16)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(110, 13)
        Label6.TabIndex = 0
        Label6.Text = "Codigo del Empleado:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(69, 68)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 4
        CantidadLabel.Text = "Cantidad:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(51, 96)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 6
        ObservacionLabel.Text = "Observacion:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(81, 42)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 2
        FechaLabel.Text = "Fecha:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(57, 25)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(52, 13)
        NombresLabel.TabIndex = 13
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(57, 51)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 14
        ApellidosLabel.Text = "Apellidos:"
        '
        'IdentidadLabel
        '
        IdentidadLabel.AutoSize = True
        IdentidadLabel.Location = New System.Drawing.Point(55, 77)
        IdentidadLabel.Name = "IdentidadLabel"
        IdentidadLabel.Size = New System.Drawing.Size(54, 13)
        IdentidadLabel.TabIndex = 15
        IdentidadLabel.Text = "Identidad:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(67, 103)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(42, 13)
        Label7.TabIndex = 16
        Label7.Text = "Salario:"
        '
        'NumdecuentaLabel
        '
        NumdecuentaLabel.AutoSize = True
        NumdecuentaLabel.Location = New System.Drawing.Point(10, 22)
        NumdecuentaLabel.Name = "NumdecuentaLabel"
        NumdecuentaLabel.Size = New System.Drawing.Size(99, 13)
        NumdecuentaLabel.TabIndex = 17
        NumdecuentaLabel.Text = "Numero de Cuenta:"
        '
        'NomdebancoLabel
        '
        NomdebancoLabel.AutoSize = True
        NomdebancoLabel.Location = New System.Drawing.Point(13, 50)
        NomdebancoLabel.Name = "NomdebancoLabel"
        NomdebancoLabel.Size = New System.Drawing.Size(96, 13)
        NomdebancoLabel.TabIndex = 19
        NomdebancoLabel.Text = "Nombre de Banco:"
        '
        'FechadeingresoLabel
        '
        FechadeingresoLabel.AutoSize = True
        FechadeingresoLabel.Location = New System.Drawing.Point(16, 74)
        FechadeingresoLabel.Name = "FechadeingresoLabel"
        FechadeingresoLabel.Size = New System.Drawing.Size(93, 13)
        FechadeingresoLabel.TabIndex = 21
        FechadeingresoLabel.Text = "Fecha de Ingreso:"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CodigoTextBox.Location = New System.Drawing.Point(61, 20)
        Me.CodigoTextBox.MaxLength = 6
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(108, 20)
        Me.CodigoTextBox.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txt_comentario)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Empleado)
        Me.GroupBox1.Controls.Add(Me.msj)
        Me.GroupBox1.Controls.Add(Me.cmdCalcular)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(941, 368)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox13)
        Me.Panel1.Controls.Add(Me.GroupBox11)
        Me.Panel1.Controls.Add(Me.GroupBox12)
        Me.Panel1.Location = New System.Drawing.Point(424, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 109)
        Me.Panel1.TabIndex = 90
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Txt_NuevoUniforme)
        Me.GroupBox13.Controls.Add(Me.cmdNuevoUniforme)
        Me.GroupBox13.Location = New System.Drawing.Point(350, 11)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(155, 80)
        Me.GroupBox13.TabIndex = 89
        Me.GroupBox13.TabStop = False
        '
        'Txt_NuevoUniforme
        '
        Me.Txt_NuevoUniforme.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.Txt_NuevoUniforme.Location = New System.Drawing.Point(43, 18)
        Me.Txt_NuevoUniforme.Name = "Txt_NuevoUniforme"
        Me.Txt_NuevoUniforme.Size = New System.Drawing.Size(66, 20)
        Me.Txt_NuevoUniforme.TabIndex = 86
        Me.Txt_NuevoUniforme.Text = "0"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdNuevoUniforme
        '
        Me.cmdNuevoUniforme.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdNuevoUniforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdNuevoUniforme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNuevoUniforme.FlatAppearance.BorderSize = 0
        Me.cmdNuevoUniforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdNuevoUniforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdNuevoUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNuevoUniforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevoUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdNuevoUniforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevoUniforme.Location = New System.Drawing.Point(18, 44)
        Me.cmdNuevoUniforme.Name = "cmdNuevoUniforme"
        Me.cmdNuevoUniforme.Size = New System.Drawing.Size(118, 26)
        Me.cmdNuevoUniforme.TabIndex = 86
        Me.cmdNuevoUniforme.Text = "Nuevo Uniforme"
        Me.cmdNuevoUniforme.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Txt_NuevoSalario)
        Me.GroupBox11.Controls.Add(Me.cmdCambiar)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(165, 80)
        Me.GroupBox11.TabIndex = 87
        Me.GroupBox11.TabStop = False
        '
        'Txt_NuevoSalario
        '
        Me.Txt_NuevoSalario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.Txt_NuevoSalario.Location = New System.Drawing.Point(49, 18)
        Me.Txt_NuevoSalario.Name = "Txt_NuevoSalario"
        Me.Txt_NuevoSalario.Size = New System.Drawing.Size(66, 20)
        Me.Txt_NuevoSalario.TabIndex = 83
        Me.Txt_NuevoSalario.Text = "0"
        '
        'cmdCambiar
        '
        Me.cmdCambiar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdCambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCambiar.FlatAppearance.BorderSize = 0
        Me.cmdCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCambiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCambiar.Location = New System.Drawing.Point(21, 44)
        Me.cmdCambiar.Name = "cmdCambiar"
        Me.cmdCambiar.Size = New System.Drawing.Size(118, 26)
        Me.cmdCambiar.TabIndex = 51
        Me.cmdCambiar.Text = "Cambiar Salario"
        Me.cmdCambiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCambiar.UseVisualStyleBackColor = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Txt_NuevoPrestamo)
        Me.GroupBox12.Controls.Add(Me.Button1)
        Me.GroupBox12.Location = New System.Drawing.Point(179, 11)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(165, 80)
        Me.GroupBox12.TabIndex = 88
        Me.GroupBox12.TabStop = False
        '
        'Txt_NuevoPrestamo
        '
        Me.Txt_NuevoPrestamo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.Txt_NuevoPrestamo.Location = New System.Drawing.Point(49, 16)
        Me.Txt_NuevoPrestamo.Name = "Txt_NuevoPrestamo"
        Me.Txt_NuevoPrestamo.Size = New System.Drawing.Size(66, 20)
        Me.Txt_NuevoPrestamo.TabIndex = 84
        Me.Txt_NuevoPrestamo.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(21, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 27)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Nuevo Prestamo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txt_deducciones)
        Me.GroupBox9.Controls.Add(Label4)
        Me.GroupBox9.Controls.Add(TotalapagarLabel)
        Me.GroupBox9.Controls.Add(Me.TotalapagarTextBox)
        Me.GroupBox9.Controls.Add(Me.SubtotalTextBox)
        Me.GroupBox9.Controls.Add(SubtotalLabel)
        Me.GroupBox9.Location = New System.Drawing.Point(548, 254)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(210, 98)
        Me.GroupBox9.TabIndex = 84
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Calculo de Totales"
        '
        'txt_deducciones
        '
        Me.txt_deducciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "salario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txt_deducciones.DataBindings.Add(New System.Windows.Forms.Binding("Size", Me.PagosBindingSource, "horasextras", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txt_deducciones.Location = New System.Drawing.Point(118, 45)
        Me.txt_deducciones.Name = "txt_deducciones"
        Me.txt_deducciones.ReadOnly = True
        Me.txt_deducciones.Size = New System.Drawing.Size(66, 20)
        Me.txt_deducciones.TabIndex = 79
        Me.txt_deducciones.Text = "0"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.ABASDataSet
        '
        'TotalapagarTextBox
        '
        Me.TotalapagarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "totalapagar", True))
        Me.TotalapagarTextBox.Location = New System.Drawing.Point(118, 71)
        Me.TotalapagarTextBox.Name = "TotalapagarTextBox"
        Me.TotalapagarTextBox.ReadOnly = True
        Me.TotalapagarTextBox.Size = New System.Drawing.Size(66, 20)
        Me.TotalapagarTextBox.TabIndex = 75
        Me.TotalapagarTextBox.Text = "0"
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "subtotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(117, 19)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(66, 20)
        Me.SubtotalTextBox.TabIndex = 77
        Me.SubtotalTextBox.Text = "0"
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
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(856, 201)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 30)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "Gerencia"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(294, 255)
        Me.txt_comentario.MaxLength = 200
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(248, 65)
        Me.txt_comentario.TabIndex = 86
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bisiesto)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 101)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fecha"
        '
        'Bisiesto
        '
        Me.Bisiesto.AutoSize = True
        Me.Bisiesto.Location = New System.Drawing.Point(134, 71)
        Me.Bisiesto.Name = "Bisiesto"
        Me.Bisiesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Bisiesto.Size = New System.Drawing.Size(62, 17)
        Me.Bisiesto.TabIndex = 34
        Me.Bisiesto.Text = "Bisiesto"
        Me.Bisiesto.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Bisiesto.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(63, 45)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePicker2.TabIndex = 31
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(63, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(228, 255)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 13)
        Me.Label24.TabIndex = 85
        Me.Label24.Text = "Comentario:"
        '
        'Empleado
        '
        Me.Empleado.Controls.Add(Label23)
        Me.Empleado.Controls.Add(Me.txt_depreciacion)
        Me.Empleado.Controls.Add(Label22)
        Me.Empleado.Controls.Add(Me.txt_bhoras)
        Me.Empleado.Controls.Add(CodigoLabel)
        Me.Empleado.Controls.Add(Me.cmdBuscarEmpleado)
        Me.Empleado.Controls.Add(BonosLabel)
        Me.Empleado.Controls.Add(Me.CodigoTextBox)
        Me.Empleado.Controls.Add(Me.txt_bono)
        Me.Empleado.Controls.Add(Me.NombresTextBox)
        Me.Empleado.Controls.Add(Me.ApellidosTextBox)
        Me.Empleado.Controls.Add(Me.SalarioTextBox)
        Me.Empleado.Controls.Add(SalarioLabel)
        Me.Empleado.Location = New System.Drawing.Point(12, 128)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(210, 192)
        Me.Empleado.TabIndex = 81
        Me.Empleado.TabStop = False
        Me.Empleado.Text = "Datos del Empleado"
        '
        'txt_depreciacion
        '
        Me.txt_depreciacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.txt_depreciacion.Location = New System.Drawing.Point(127, 139)
        Me.txt_depreciacion.Name = "txt_depreciacion"
        Me.txt_depreciacion.Size = New System.Drawing.Size(66, 20)
        Me.txt_depreciacion.TabIndex = 82
        Me.txt_depreciacion.Text = "0"
        '
        'txt_bhoras
        '
        Me.txt_bhoras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.txt_bhoras.Location = New System.Drawing.Point(127, 114)
        Me.txt_bhoras.Name = "txt_bhoras"
        Me.txt_bhoras.ReadOnly = True
        Me.txt_bhoras.Size = New System.Drawing.Size(66, 20)
        Me.txt_bhoras.TabIndex = 80
        Me.txt_bhoras.Text = "0"
        '
        'cmdBuscarEmpleado
        '
        Me.cmdBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscarEmpleado.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.cmdBuscarEmpleado.Location = New System.Drawing.Point(170, 19)
        Me.cmdBuscarEmpleado.Name = "cmdBuscarEmpleado"
        Me.cmdBuscarEmpleado.Size = New System.Drawing.Size(25, 21)
        Me.cmdBuscarEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmdBuscarEmpleado.TabIndex = 29
        Me.cmdBuscarEmpleado.TabStop = False
        '
        'txt_bono
        '
        Me.txt_bono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.txt_bono.Location = New System.Drawing.Point(127, 164)
        Me.txt_bono.Name = "txt_bono"
        Me.txt_bono.Size = New System.Drawing.Size(66, 20)
        Me.txt_bono.TabIndex = 78
        Me.txt_bono.Text = "0"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(61, 43)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.ReadOnly = True
        Me.NombresTextBox.Size = New System.Drawing.Size(134, 20)
        Me.NombresTextBox.TabIndex = 38
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(61, 65)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.ReadOnly = True
        Me.ApellidosTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ApellidosTextBox.TabIndex = 39
        '
        'SalarioTextBox
        '
        Me.SalarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "salario", True))
        Me.SalarioTextBox.Location = New System.Drawing.Point(127, 90)
        Me.SalarioTextBox.Name = "SalarioTextBox"
        Me.SalarioTextBox.ReadOnly = True
        Me.SalarioTextBox.Size = New System.Drawing.Size(66, 20)
        Me.SalarioTextBox.TabIndex = 52
        Me.SalarioTextBox.Text = "0"
        '
        'msj
        '
        Me.msj.AutoSize = True
        Me.msj.ForeColor = System.Drawing.Color.Red
        Me.msj.Location = New System.Drawing.Point(12, 9)
        Me.msj.Name = "msj"
        Me.msj.Size = New System.Drawing.Size(409, 13)
        Me.msj.TabIndex = 49
        Me.msj.Text = "*Advertencia: Se debe seleccionar los rangos entre fechas antes de realizar un pa" &
    "go!"
        '
        'cmdCalcular
        '
        Me.cmdCalcular.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCalcular.FlatAppearance.BorderSize = 0
        Me.cmdCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCalcular.Location = New System.Drawing.Point(112, 325)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.Size = New System.Drawing.Size(94, 33)
        Me.cmdCalcular.TabIndex = 47
        Me.cmdCalcular.Text = "Calcular"
        Me.cmdCalcular.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(209, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(AsignacionLabel)
        Me.GroupBox4.Controls.Add(Me.txt_phoras)
        Me.GroupBox4.Controls.Add(Me.txt_ajustes)
        Me.GroupBox4.Controls.Add(Me.txt_vacaciones)
        Me.GroupBox4.Controls.Add(Label8)
        Me.GroupBox4.Controls.Add(Me.Precio)
        Me.GroupBox4.Controls.Add(Me.HorasextrasTextBox)
        Me.GroupBox4.Controls.Add(Me.txt_pextras)
        Me.GroupBox4.Controls.Add(HorasextrasLabel)
        Me.GroupBox4.Controls.Add(Label5)
        Me.GroupBox4.Controls.Add(VacacionesLabel)
        Me.GroupBox4.Controls.Add(Me.HorasTextBox)
        Me.GroupBox4.Controls.Add(HorasLabel)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DiasTextBox)
        Me.GroupBox4.Controls.Add(DiasLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(228, 143)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(530, 105)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de Horas"
        '
        'txt_phoras
        '
        Me.txt_phoras.Location = New System.Drawing.Point(441, 21)
        Me.txt_phoras.Name = "txt_phoras"
        Me.txt_phoras.ReadOnly = True
        Me.txt_phoras.Size = New System.Drawing.Size(66, 20)
        Me.txt_phoras.TabIndex = 84
        Me.txt_phoras.Text = "0"
        '
        'txt_ajustes
        '
        Me.txt_ajustes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "asignacion", True))
        Me.txt_ajustes.Location = New System.Drawing.Point(441, 74)
        Me.txt_ajustes.Name = "txt_ajustes"
        Me.txt_ajustes.Size = New System.Drawing.Size(66, 20)
        Me.txt_ajustes.TabIndex = 96
        Me.txt_ajustes.Text = "0"
        '
        'txt_vacaciones
        '
        Me.txt_vacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "vacaciones", True))
        Me.txt_vacaciones.Location = New System.Drawing.Point(94, 50)
        Me.txt_vacaciones.Name = "txt_vacaciones"
        Me.txt_vacaciones.Size = New System.Drawing.Size(47, 20)
        Me.txt_vacaciones.TabIndex = 94
        Me.txt_vacaciones.Text = "0"
        '
        'Precio
        '
        Me.Precio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "horasextras", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "t"))
        Me.Precio.Location = New System.Drawing.Point(247, 74)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(84, 20)
        Me.Precio.TabIndex = 68
        Me.Precio.Text = "0"
        '
        'AsignacionesBindingSource
        '
        Me.AsignacionesBindingSource.DataMember = "Asignaciones"
        Me.AsignacionesBindingSource.DataSource = Me.ABASDataSet
        '
        'HorasextrasTextBox
        '
        Me.HorasextrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "horasextras", True))
        Me.HorasextrasTextBox.Location = New System.Drawing.Point(247, 49)
        Me.HorasextrasTextBox.Name = "HorasextrasTextBox"
        Me.HorasextrasTextBox.ReadOnly = True
        Me.HorasextrasTextBox.Size = New System.Drawing.Size(84, 20)
        Me.HorasextrasTextBox.TabIndex = 58
        '
        'txt_pextras
        '
        Me.txt_pextras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "salario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txt_pextras.DataBindings.Add(New System.Windows.Forms.Binding("Size", Me.PagosBindingSource, "horasextras", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txt_pextras.Location = New System.Drawing.Point(441, 46)
        Me.txt_pextras.Name = "txt_pextras"
        Me.txt_pextras.ReadOnly = True
        Me.txt_pextras.Size = New System.Drawing.Size(66, 20)
        Me.txt_pextras.TabIndex = 85
        Me.txt_pextras.Text = "0"
        '
        'HorasTextBox
        '
        Me.HorasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignacionesBindingSource, "horas", True))
        Me.HorasTextBox.Location = New System.Drawing.Point(247, 24)
        Me.HorasTextBox.Name = "HorasTextBox"
        Me.HorasTextBox.ReadOnly = True
        Me.HorasTextBox.Size = New System.Drawing.Size(84, 20)
        Me.HorasTextBox.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Valor Hora Extras:"
        '
        'DiasTextBox
        '
        Me.DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "dias", True))
        Me.DiasTextBox.Location = New System.Drawing.Point(94, 25)
        Me.DiasTextBox.Name = "DiasTextBox"
        Me.DiasTextBox.Size = New System.Drawing.Size(47, 20)
        Me.DiasTextBox.TabIndex = 90
        Me.DiasTextBox.Text = "0"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_saluniforme)
        Me.GroupBox6.Controls.Add(lbl_uniforme)
        Me.GroupBox6.Controls.Add(Me.txt_uniforme)
        Me.GroupBox6.Controls.Add(Label16)
        Me.GroupBox6.Controls.Add(Me.txtsaldopres)
        Me.GroupBox6.Controls.Add(lbl_prestamo)
        Me.GroupBox6.Controls.Add(Me.txtprestamo)
        Me.GroupBox6.Controls.Add(Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(563, 23)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(194, 117)
        Me.GroupBox6.TabIndex = 78
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cuentas por cobrar"
        '
        'txt_saluniforme
        '
        Me.txt_saluniforme.Location = New System.Drawing.Point(103, 75)
        Me.txt_saluniforme.Name = "txt_saluniforme"
        Me.txt_saluniforme.ReadOnly = True
        Me.txt_saluniforme.Size = New System.Drawing.Size(66, 20)
        Me.txt_saluniforme.TabIndex = 81
        Me.txt_saluniforme.Text = "0"
        '
        'txt_uniforme
        '
        Me.txt_uniforme.Location = New System.Drawing.Point(103, 36)
        Me.txt_uniforme.Name = "txt_uniforme"
        Me.txt_uniforme.ReadOnly = True
        Me.txt_uniforme.Size = New System.Drawing.Size(66, 20)
        Me.txt_uniforme.TabIndex = 79
        Me.txt_uniforme.Text = "0"
        '
        'txtsaldopres
        '
        Me.txtsaldopres.Location = New System.Drawing.Point(21, 76)
        Me.txtsaldopres.Name = "txtsaldopres"
        Me.txtsaldopres.ReadOnly = True
        Me.txtsaldopres.Size = New System.Drawing.Size(66, 20)
        Me.txtsaldopres.TabIndex = 77
        Me.txtsaldopres.Text = "0"
        '
        'txtprestamo
        '
        Me.txtprestamo.Location = New System.Drawing.Point(21, 37)
        Me.txtprestamo.Name = "txtprestamo"
        Me.txtprestamo.ReadOnly = True
        Me.txtprestamo.Size = New System.Drawing.Size(66, 20)
        Me.txtprestamo.TabIndex = 75
        Me.txtprestamo.Text = "0"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.txt_valorturnoextra)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.txt_turnoextra)
        Me.GroupBox7.Location = New System.Drawing.Point(228, 23)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(314, 117)
        Me.GroupBox7.TabIndex = 83
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Datos de Roles"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(145, 84)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 13)
        Me.Label31.TabIndex = 87
        Me.Label31.Text = "Valor Turnos Extras"
        '
        'txt_valorturnoextra
        '
        Me.txt_valorturnoextra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "dialibre", True))
        Me.txt_valorturnoextra.Location = New System.Drawing.Point(251, 81)
        Me.txt_valorturnoextra.Name = "txt_valorturnoextra"
        Me.txt_valorturnoextra.ReadOnly = True
        Me.txt_valorturnoextra.Size = New System.Drawing.Size(46, 20)
        Me.txt_valorturnoextra.TabIndex = 86
        Me.txt_valorturnoextra.Text = "0"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txt_hferiado)
        Me.GroupBox10.Controls.Add(Me.Label17)
        Me.GroupBox10.Controls.Add(Me.Label18)
        Me.GroupBox10.Controls.Add(Me.txt_pagoferiado)
        Me.GroupBox10.Location = New System.Drawing.Point(157, 15)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(140, 64)
        Me.GroupBox10.TabIndex = 85
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Feriados"
        '
        'txt_hferiado
        '
        Me.txt_hferiado.Location = New System.Drawing.Point(11, 30)
        Me.txt_hferiado.Name = "txt_hferiado"
        Me.txt_hferiado.Size = New System.Drawing.Size(55, 20)
        Me.txt_hferiado.TabIndex = 79
        Me.txt_hferiado.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Horas"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(69, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Devengado"
        '
        'txt_pagoferiado
        '
        Me.txt_pagoferiado.Location = New System.Drawing.Point(72, 30)
        Me.txt_pagoferiado.Name = "txt_pagoferiado"
        Me.txt_pagoferiado.ReadOnly = True
        Me.txt_pagoferiado.Size = New System.Drawing.Size(56, 20)
        Me.txt_pagoferiado.TabIndex = 80
        Me.txt_pagoferiado.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Turnos Extras"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.horassep)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.txt_septimo)
        Me.GroupBox8.Location = New System.Drawing.Point(11, 15)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(140, 64)
        Me.GroupBox8.TabIndex = 84
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Dias Libres / Septimos"
        '
        'horassep
        '
        Me.horassep.Location = New System.Drawing.Point(11, 30)
        Me.horassep.Name = "horassep"
        Me.horassep.ReadOnly = True
        Me.horassep.Size = New System.Drawing.Size(55, 20)
        Me.horassep.TabIndex = 79
        Me.horassep.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Horas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(69, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Devengado"
        '
        'txt_septimo
        '
        Me.txt_septimo.Location = New System.Drawing.Point(72, 30)
        Me.txt_septimo.Name = "txt_septimo"
        Me.txt_septimo.ReadOnly = True
        Me.txt_septimo.Size = New System.Drawing.Size(56, 20)
        Me.txt_septimo.TabIndex = 80
        Me.txt_septimo.Text = "0"
        '
        'txt_turnoextra
        '
        Me.txt_turnoextra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "dialibre", True))
        Me.txt_turnoextra.Location = New System.Drawing.Point(93, 81)
        Me.txt_turnoextra.Name = "txt_turnoextra"
        Me.txt_turnoextra.ReadOnly = True
        Me.txt_turnoextra.Size = New System.Drawing.Size(46, 20)
        Me.txt_turnoextra.TabIndex = 59
        Me.txt_turnoextra.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Label35)
        Me.GroupBox5.Controls.Add(Me.txtOtraDeduccion)
        Me.GroupBox5.Controls.Add(Me.AdelantoTextBox)
        Me.GroupBox5.Controls.Add(AdelantoLabel)
        Me.GroupBox5.Controls.Add(Me.UniformeTextBox)
        Me.GroupBox5.Controls.Add(UniformeLabel)
        Me.GroupBox5.Controls.Add(Me.txt_anticipo)
        Me.GroupBox5.Controls.Add(Label11)
        Me.GroupBox5.Controls.Add(Me.RapTextBox)
        Me.GroupBox5.Controls.Add(Me.IhssTextBox)
        Me.GroupBox5.Controls.Add(IhssLabel)
        Me.GroupBox5.Controls.Add(RapLabel)
        Me.GroupBox5.Location = New System.Drawing.Point(764, 23)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(165, 175)
        Me.GroupBox5.TabIndex = 84
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Deducciones"
        '
        'txtOtraDeduccion
        '
        Me.txtOtraDeduccion.Location = New System.Drawing.Point(105, 147)
        Me.txtOtraDeduccion.Name = "txtOtraDeduccion"
        Me.txtOtraDeduccion.Size = New System.Drawing.Size(54, 20)
        Me.txtOtraDeduccion.TabIndex = 72
        Me.txtOtraDeduccion.Text = "0"
        '
        'AdelantoTextBox
        '
        Me.AdelantoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "adelanto", True))
        Me.AdelantoTextBox.Location = New System.Drawing.Point(105, 120)
        Me.AdelantoTextBox.Name = "AdelantoTextBox"
        Me.AdelantoTextBox.Size = New System.Drawing.Size(54, 20)
        Me.AdelantoTextBox.TabIndex = 71
        Me.AdelantoTextBox.Text = "0"
        '
        'UniformeTextBox
        '
        Me.UniformeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "uniforme", True))
        Me.UniformeTextBox.Location = New System.Drawing.Point(105, 96)
        Me.UniformeTextBox.Name = "UniformeTextBox"
        Me.UniformeTextBox.Size = New System.Drawing.Size(54, 20)
        Me.UniformeTextBox.TabIndex = 69
        Me.UniformeTextBox.Text = "0"
        '
        'txt_anticipo
        '
        Me.txt_anticipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "rap", True))
        Me.txt_anticipo.Location = New System.Drawing.Point(105, 69)
        Me.txt_anticipo.Name = "txt_anticipo"
        Me.txt_anticipo.ReadOnly = True
        Me.txt_anticipo.Size = New System.Drawing.Size(54, 20)
        Me.txt_anticipo.TabIndex = 67
        Me.txt_anticipo.Text = "0"
        '
        'RapTextBox
        '
        Me.RapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "rap", True))
        Me.RapTextBox.Location = New System.Drawing.Point(105, 44)
        Me.RapTextBox.Name = "RapTextBox"
        Me.RapTextBox.Size = New System.Drawing.Size(54, 20)
        Me.RapTextBox.TabIndex = 63
        Me.RapTextBox.Text = "0"
        '
        'IhssTextBox
        '
        Me.IhssTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "ihss", True))
        Me.IhssTextBox.Location = New System.Drawing.Point(105, 19)
        Me.IhssTextBox.Name = "IhssTextBox"
        Me.IhssTextBox.Size = New System.Drawing.Size(54, 20)
        Me.IhssTextBox.TabIndex = 62
        Me.IhssTextBox.Text = "0"
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
        Me.cmdNuevo.Location = New System.Drawing.Point(15, 325)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(94, 33)
        Me.cmdNuevo.TabIndex = 72
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'txtturno
        '
        Me.txtturno.Location = New System.Drawing.Point(220, 8)
        Me.txtturno.Name = "txtturno"
        Me.txtturno.Size = New System.Drawing.Size(68, 20)
        Me.txtturno.TabIndex = 85
        '
        'FECHAFINAL
        '
        Me.FECHAFINAL.Location = New System.Drawing.Point(61, 34)
        Me.FECHAFINAL.Name = "FECHAFINAL"
        Me.FECHAFINAL.Size = New System.Drawing.Size(66, 20)
        Me.FECHAFINAL.TabIndex = 85
        '
        'FECHAINICIAL
        '
        Me.FECHAINICIAL.Location = New System.Drawing.Point(61, 8)
        Me.FECHAINICIAL.Name = "FECHAINICIAL"
        Me.FECHAINICIAL.Size = New System.Drawing.Size(66, 20)
        Me.FECHAINICIAL.TabIndex = 84
        '
        'EstadoTextBox1
        '
        Me.EstadoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "estado", True))
        Me.EstadoTextBox1.Location = New System.Drawing.Point(330, 8)
        Me.EstadoTextBox1.Name = "EstadoTextBox1"
        Me.EstadoTextBox1.Size = New System.Drawing.Size(46, 20)
        Me.EstadoTextBox1.TabIndex = 65
        Me.EstadoTextBox1.Text = "Pagado"
        Me.EstadoTextBox1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.ReportesGerencia})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanillaDePagosPorUsuarioToolStripMenuItem, Me.GenerarUnVoucherToolStripMenuItem, Me.PagosPorFechaToolStripMenuItem, Me.ReporteDeduccionesToolStripMenuItem, Me.PlanillaDeDeduccionesPorUsuarioToolStripMenuItem, Me.AsignacionesDeEmpleadoToolStripMenuItem, Me.AsignacionPorClienteToolStripMenuItem, Me.AsignacionesGeneralesToolStripMenuItem, Me.HistorialDeImpresionDeCarnetToolStripMenuItem, Me.ComprobanteEntregaUniformeToolStripMenuItem, Me.ComprobanteDevolucionUniformeToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes Admon"
        '
        'PlanillaDePagosPorUsuarioToolStripMenuItem
        '
        Me.PlanillaDePagosPorUsuarioToolStripMenuItem.Name = "PlanillaDePagosPorUsuarioToolStripMenuItem"
        Me.PlanillaDePagosPorUsuarioToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.PlanillaDePagosPorUsuarioToolStripMenuItem.Text = "Planilla de Pagos / Por Usuario"
        '
        'GenerarUnVoucherToolStripMenuItem
        '
        Me.GenerarUnVoucherToolStripMenuItem.Name = "GenerarUnVoucherToolStripMenuItem"
        Me.GenerarUnVoucherToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.GenerarUnVoucherToolStripMenuItem.Text = "Voucher de Pagos / Por Planilla"
        '
        'PagosPorFechaToolStripMenuItem
        '
        Me.PagosPorFechaToolStripMenuItem.Name = "PagosPorFechaToolStripMenuItem"
        Me.PagosPorFechaToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.PagosPorFechaToolStripMenuItem.Text = "Planilla de Pagos General"
        '
        'ReporteDeduccionesToolStripMenuItem
        '
        Me.ReporteDeduccionesToolStripMenuItem.Name = "ReporteDeduccionesToolStripMenuItem"
        Me.ReporteDeduccionesToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ReporteDeduccionesToolStripMenuItem.Text = "Planilla de Deducciones General"
        '
        'PlanillaDeDeduccionesPorUsuarioToolStripMenuItem
        '
        Me.PlanillaDeDeduccionesPorUsuarioToolStripMenuItem.Name = "PlanillaDeDeduccionesPorUsuarioToolStripMenuItem"
        Me.PlanillaDeDeduccionesPorUsuarioToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.PlanillaDeDeduccionesPorUsuarioToolStripMenuItem.Text = "Planilla de Deducciones / Por Usuario"
        '
        'AsignacionesDeEmpleadoToolStripMenuItem
        '
        Me.AsignacionesDeEmpleadoToolStripMenuItem.Name = "AsignacionesDeEmpleadoToolStripMenuItem"
        Me.AsignacionesDeEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.AsignacionesDeEmpleadoToolStripMenuItem.Text = "Asignaciones de Empleado"
        '
        'AsignacionPorClienteToolStripMenuItem
        '
        Me.AsignacionPorClienteToolStripMenuItem.Name = "AsignacionPorClienteToolStripMenuItem"
        Me.AsignacionPorClienteToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.AsignacionPorClienteToolStripMenuItem.Text = "Asignacion por Cliente"
        '
        'AsignacionesGeneralesToolStripMenuItem
        '
        Me.AsignacionesGeneralesToolStripMenuItem.Name = "AsignacionesGeneralesToolStripMenuItem"
        Me.AsignacionesGeneralesToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.AsignacionesGeneralesToolStripMenuItem.Text = "Asignaciones Generales"
        '
        'HistorialDeImpresionDeCarnetToolStripMenuItem
        '
        Me.HistorialDeImpresionDeCarnetToolStripMenuItem.Name = "HistorialDeImpresionDeCarnetToolStripMenuItem"
        Me.HistorialDeImpresionDeCarnetToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.HistorialDeImpresionDeCarnetToolStripMenuItem.Text = "Historial de Impresion de Carnet"
        '
        'ComprobanteEntregaUniformeToolStripMenuItem
        '
        Me.ComprobanteEntregaUniformeToolStripMenuItem.Name = "ComprobanteEntregaUniformeToolStripMenuItem"
        Me.ComprobanteEntregaUniformeToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ComprobanteEntregaUniformeToolStripMenuItem.Text = "Comprobante Entrega Uniforme"
        '
        'ComprobanteDevolucionUniformeToolStripMenuItem
        '
        Me.ComprobanteDevolucionUniformeToolStripMenuItem.Name = "ComprobanteDevolucionUniformeToolStripMenuItem"
        Me.ComprobanteDevolucionUniformeToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ComprobanteDevolucionUniformeToolStripMenuItem.Text = "Comprobante Devolucion Uniforme"
        '
        'ReportesGerencia
        '
        Me.ReportesGerencia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalleDePlanillaToolStripMenuItem, Me.DetalleDePlanillaUsuarioToolStripMenuItem})
        Me.ReportesGerencia.Name = "ReportesGerencia"
        Me.ReportesGerencia.Size = New System.Drawing.Size(69, 20)
        Me.ReportesGerencia.Text = "Gerencia"
        '
        'DetalleDePlanillaToolStripMenuItem
        '
        Me.DetalleDePlanillaToolStripMenuItem.Name = "DetalleDePlanillaToolStripMenuItem"
        Me.DetalleDePlanillaToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.DetalleDePlanillaToolStripMenuItem.Text = "Detalle de Planilla"
        '
        'DetalleDePlanillaUsuarioToolStripMenuItem
        '
        Me.DetalleDePlanillaUsuarioToolStripMenuItem.Name = "DetalleDePlanillaUsuarioToolStripMenuItem"
        Me.DetalleDePlanillaUsuarioToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.DetalleDePlanillaUsuarioToolStripMenuItem.Text = "Detalle de Planilla / Usuario"
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad", "Ubicacion", "Planilla"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(119, 20)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.Location = New System.Drawing.Point(259, 20)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(197, 20)
        Me.txtbusqueda.TabIndex = 8
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(256, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(457, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'panelempleados
        '
        Me.panelempleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelempleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelempleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelempleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelempleados.Controls.Add(Me.PictureBox1)
        Me.panelempleados.Controls.Add(Me.Panel2)
        Me.panelempleados.Controls.Add(Me.txtbusqueda)
        Me.panelempleados.Controls.Add(Me.tipodebusqueda)
        Me.panelempleados.Location = New System.Drawing.Point(183, 84)
        Me.panelempleados.Name = "panelempleados"
        Me.panelempleados.Size = New System.Drawing.Size(652, 449)
        Me.panelempleados.TabIndex = 12
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToOrderColumns = True
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.planilla, Me.bhoras, Me.depreciacion, Me.bonos})
        Me.EmpleadosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 52)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(650, 395)
        Me.EmpleadosDataGridView.TabIndex = 0
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "salario"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Salario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 64
        '
        'planilla
        '
        Me.planilla.DataPropertyName = "planilla"
        Me.planilla.HeaderText = "Planilla"
        Me.planilla.Name = "planilla"
        Me.planilla.Width = 65
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
        'bonos
        '
        Me.bonos.DataPropertyName = "bonos"
        Me.bonos.HeaderText = "Bonos"
        Me.bonos.Name = "bonos"
        Me.bonos.Width = 62
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
        Me.AsignacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.idasignacion, Me.DataGridViewTextBoxColumn6, Me.horas, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.turno, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn17})
        Me.AsignacionesDataGridView.DataSource = Me.AsignacionesBindingSource
        Me.AsignacionesDataGridView.Location = New System.Drawing.Point(0, 380)
        Me.AsignacionesDataGridView.Name = "AsignacionesDataGridView"
        Me.AsignacionesDataGridView.RowHeadersVisible = False
        Me.AsignacionesDataGridView.ShowCellErrors = False
        Me.AsignacionesDataGridView.ShowRowErrors = False
        Me.AsignacionesDataGridView.Size = New System.Drawing.Size(942, 245)
        Me.AsignacionesDataGridView.TabIndex = 37
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 62
        '
        'idasignacion
        '
        Me.idasignacion.DataPropertyName = "idasignacion"
        Me.idasignacion.HeaderText = "idasignacion"
        Me.idasignacion.Name = "idasignacion"
        Me.idasignacion.ReadOnly = True
        Me.idasignacion.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Codigo del Empleado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 121
        '
        'horas
        '
        Me.horas.DataPropertyName = "horas"
        Me.horas.HeaderText = "Horas"
        Me.horas.Name = "horas"
        Me.horas.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "horasextras"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Horas Extras"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 85
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cliente"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 64
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "sucursal"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Sucursal"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 73
        '
        'turno
        '
        Me.turno.DataPropertyName = "turno"
        Me.turno.HeaderText = "Turno"
        Me.turno.Name = "turno"
        Me.turno.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "autoriza"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Autoriza"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 92
        '
        'MESINICIAL
        '
        Me.MESINICIAL.Location = New System.Drawing.Point(61, 60)
        Me.MESINICIAL.Name = "MESINICIAL"
        Me.MESINICIAL.Size = New System.Drawing.Size(66, 20)
        Me.MESINICIAL.TabIndex = 79
        '
        'MESFINAL
        '
        Me.MESFINAL.Location = New System.Drawing.Point(61, 86)
        Me.MESFINAL.Name = "MESFINAL"
        Me.MESFINAL.Size = New System.Drawing.Size(66, 20)
        Me.MESFINAL.TabIndex = 80
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Checked = False
        Me.DateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker3.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(283, 37)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker3.TabIndex = 34
        '
        'Paneldetalles
        '
        Me.Paneldetalles.Controls.Add(Me.txtJornada)
        Me.Paneldetalles.Controls.Add(Me.Label36)
        Me.Paneldetalles.Controls.Add(Me.txtIdPago)
        Me.Paneldetalles.Controls.Add(Me.Label29)
        Me.Paneldetalles.Controls.Add(Me.Label28)
        Me.Paneldetalles.Controls.Add(Me.Label27)
        Me.Paneldetalles.Controls.Add(Me.Label26)
        Me.Paneldetalles.Controls.Add(Me.Label25)
        Me.Paneldetalles.Controls.Add(Me.EstadoTextBox1)
        Me.Paneldetalles.Controls.Add(Me.MESFINAL)
        Me.Paneldetalles.Controls.Add(Me.DateTimePicker3)
        Me.Paneldetalles.Controls.Add(Me.FECHAFINAL)
        Me.Paneldetalles.Controls.Add(Me.FECHAINICIAL)
        Me.Paneldetalles.Controls.Add(Me.MESINICIAL)
        Me.Paneldetalles.Controls.Add(Me.txtturno)
        Me.Paneldetalles.Location = New System.Drawing.Point(6, 440)
        Me.Paneldetalles.Name = "Paneldetalles"
        Me.Paneldetalles.Size = New System.Drawing.Size(409, 156)
        Me.Paneldetalles.TabIndex = 86
        Me.Paneldetalles.Visible = False
        '
        'txtJornada
        '
        Me.txtJornada.Location = New System.Drawing.Point(283, 63)
        Me.txtJornada.Name = "txtJornada"
        Me.txtJornada.Size = New System.Drawing.Size(100, 20)
        Me.txtJornada.TabIndex = 94
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(228, 92)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(79, 13)
        Me.Label36.TabIndex = 93
        Me.Label36.Text = "idpago variable"
        '
        'txtIdPago
        '
        Me.txtIdPago.Location = New System.Drawing.Point(307, 89)
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.Size = New System.Drawing.Size(76, 20)
        Me.txtIdPago.TabIndex = 92
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(173, 11)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 90
        Me.Label29.Text = "Turno"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(12, 89)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 13)
        Me.Label28.TabIndex = 89
        Me.Label28.Text = "MesF"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(12, 63)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 13)
        Me.Label27.TabIndex = 88
        Me.Label27.Text = "MesI"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(12, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 87
        Me.Label26.Text = "FechaI"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 37)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "FechaF"
        '
        'AsignacionesTableAdapter
        '
        Me.AsignacionesTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(953, 653)
        Me.TabControl1.TabIndex = 87
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panelempleados)
        Me.TabPage1.Controls.Add(Me.Paneldetalles)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.AsignacionesDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(945, 627)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generar Planilla"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.AnticiposDataGridView)
        Me.TabPage2.Controls.Add(Me.GroupBox14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(954, 619)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Asignar Anticipo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Location = New System.Drawing.Point(194, 141)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(597, 354)
        Me.Panel3.TabIndex = 77
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.DataGridView1.DataSource = Me.EmpleadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(597, 301)
        Me.DataGridView1.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "identidad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Identidad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "salario"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Salario"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "numdecuenta"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Numero de Cuenta"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "nomdebanco"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Nombre del Banco"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "fechadeingreso"
        Me.DataGridViewTextBoxColumn32.HeaderText = "F. de Ingreso"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(431, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(230, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 1)
        Me.Panel4.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox2.Location = New System.Drawing.Point(233, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(197, 20)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad", "Ubicacion", "Planilla"})
        Me.ComboBox1.Location = New System.Drawing.Point(93, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'AnticiposDataGridView
        '
        Me.AnticiposDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnticiposDataGridView.AutoGenerateColumns = False
        Me.AnticiposDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AnticiposDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.AnticiposDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.AnticiposDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnticiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnticiposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.estado})
        Me.AnticiposDataGridView.DataSource = Me.AnticiposBindingSource
        Me.AnticiposDataGridView.Location = New System.Drawing.Point(2, 288)
        Me.AnticiposDataGridView.Name = "AnticiposDataGridView"
        Me.AnticiposDataGridView.RowHeadersVisible = False
        Me.AnticiposDataGridView.Size = New System.Drawing.Size(952, 337)
        Me.AnticiposDataGridView.TabIndex = 83
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Codigo de Empleado"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 119
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Fecha de Anticipo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 108
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 74
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 92
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Width = 65
        '
        'AnticiposBindingSource
        '
        Me.AnticiposBindingSource.DataMember = "Anticipos"
        Me.AnticiposBindingSource.DataSource = Me.ABASDataSet
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.GroupBox3)
        Me.GroupBox14.Controls.Add(Me.GroupBox15)
        Me.GroupBox14.Controls.Add(Me.GroupBox16)
        Me.GroupBox14.Location = New System.Drawing.Point(17, 6)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(708, 279)
        Me.GroupBox14.TabIndex = 78
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Agregar de Anticipo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(EstadoLabel)
        Me.GroupBox3.Controls.Add(Label6)
        Me.GroupBox3.Controls.Add(Me.cmdEliminarAnticipo)
        Me.GroupBox3.Controls.Add(Me.EstadoComboBox)
        Me.GroupBox3.Controls.Add(Me.cmdActualizar)
        Me.GroupBox3.Controls.Add(CantidadLabel)
        Me.GroupBox3.Controls.Add(Me.cmdGuardar)
        Me.GroupBox3.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.fechaanticipo)
        Me.GroupBox3.Controls.Add(Me.PictureBox4)
        Me.GroupBox3.Controls.Add(ObservacionLabel)
        Me.GroupBox3.Controls.Add(FechaLabel)
        Me.GroupBox3.Controls.Add(Me.ObservacionTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 249)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        '
        'cmdEliminarAnticipo
        '
        Me.cmdEliminarAnticipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminarAnticipo.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdEliminarAnticipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdEliminarAnticipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEliminarAnticipo.FlatAppearance.BorderSize = 0
        Me.cmdEliminarAnticipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdEliminarAnticipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdEliminarAnticipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminarAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarAnticipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEliminarAnticipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminarAnticipo.Location = New System.Drawing.Point(260, 201)
        Me.cmdEliminarAnticipo.Name = "cmdEliminarAnticipo"
        Me.cmdEliminarAnticipo.Size = New System.Drawing.Size(73, 33)
        Me.cmdEliminarAnticipo.TabIndex = 82
        Me.cmdEliminarAnticipo.Text = "Eliminar"
        Me.cmdEliminarAnticipo.UseVisualStyleBackColor = False
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
        Me.cmdActualizar.Location = New System.Drawing.Point(164, 201)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(89, 33)
        Me.cmdActualizar.TabIndex = 81
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
        Me.cmdGuardar.Location = New System.Drawing.Point(82, 201)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(76, 33)
        Me.cmdGuardar.TabIndex = 80
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(127, 65)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Button4.Location = New System.Drawing.Point(11, 201)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 33)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "Nuevo"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'fechaanticipo
        '
        Me.fechaanticipo.CustomFormat = "dd-MM-yyyy"
        Me.fechaanticipo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaanticipo.Location = New System.Drawing.Point(127, 39)
        Me.fechaanticipo.Name = "fechaanticipo"
        Me.fechaanticipo.Size = New System.Drawing.Size(100, 20)
        Me.fechaanticipo.TabIndex = 3
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
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(127, 93)
        Me.ObservacionTextBox.Multiline = True
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(201, 54)
        Me.ObservacionTextBox.TabIndex = 7
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox15.Controls.Add(Me.TextBox3)
        Me.GroupBox15.Controls.Add(Me.TextBox4)
        Me.GroupBox15.Controls.Add(NombresLabel)
        Me.GroupBox15.Controls.Add(Me.TextBox5)
        Me.GroupBox15.Controls.Add(ApellidosLabel)
        Me.GroupBox15.Controls.Add(IdentidadLabel)
        Me.GroupBox15.Controls.Add(Me.TextBox6)
        Me.GroupBox15.Controls.Add(Label7)
        Me.GroupBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox15.Location = New System.Drawing.Point(360, 136)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(336, 132)
        Me.GroupBox15.TabIndex = 23
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Datos del Oficial de Seguridad"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "identidad", True))
        Me.TextBox3.Location = New System.Drawing.Point(118, 74)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nombres", True))
        Me.TextBox4.Location = New System.Drawing.Point(118, 22)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(192, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "apellidos", True))
        Me.TextBox5.Location = New System.Drawing.Point(118, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(192, 20)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "salario", True))
        Me.TextBox6.Location = New System.Drawing.Point(118, 100)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(192, 20)
        Me.TextBox6.TabIndex = 17
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(NumdecuentaLabel)
        Me.GroupBox16.Controls.Add(Me.TextBox7)
        Me.GroupBox16.Controls.Add(NomdebancoLabel)
        Me.GroupBox16.Controls.Add(Me.FechadeingresoDateTimePicker)
        Me.GroupBox16.Controls.Add(FechadeingresoLabel)
        Me.GroupBox16.Controls.Add(Me.TextBox8)
        Me.GroupBox16.Location = New System.Drawing.Point(360, 19)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(336, 111)
        Me.GroupBox16.TabIndex = 24
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Datos Bancarios"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "numdecuenta", True))
        Me.TextBox7.Location = New System.Drawing.Point(118, 19)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(192, 20)
        Me.TextBox7.TabIndex = 18
        '
        'FechadeingresoDateTimePicker
        '
        Me.FechadeingresoDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechadeingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechadeingreso", True))
        Me.FechadeingresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechadeingresoDateTimePicker.Location = New System.Drawing.Point(118, 74)
        Me.FechadeingresoDateTimePicker.Name = "FechadeingresoDateTimePicker"
        Me.FechadeingresoDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechadeingresoDateTimePicker.TabIndex = 22
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nomdebanco", True))
        Me.TextBox8.Location = New System.Drawing.Point(118, 47)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(192, 20)
        Me.TextBox8.TabIndex = 20
        '
        'AnticiposTableAdapter
        '
        Me.AnticiposTableAdapter.ClearBeforeFill = True
        '
        'FormPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 692)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPlanilla"
        Me.Text = "FormPlanilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Empleado.ResumeLayout(False)
        Me.Empleado.PerformLayout()
        CType(Me.cmdBuscarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.AsignacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelempleados.ResumeLayout(False)
        Me.panelempleados.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneldetalles.ResumeLayout(False)
        Me.Paneldetalles.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnticiposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AsignacionesTableAdapter As ABASDataSetTableAdapters.AsignacionesTableAdapter
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscarEmpleado As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents cmdCalcular As Button
    Friend WithEvents msj As Label
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As ABASDataSetTableAdapters.PagosTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionesDeEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarUnVoucherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosPorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdCambiar As Button
    Friend WithEvents AsignacionesBindingSource As BindingSource
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelempleados As Panel
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents AsignacionesDataGridView As DataGridView
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents HorasTextBox As TextBox
    Friend WithEvents EstadoTextBox1 As TextBox
    Friend WithEvents RapTextBox As TextBox
    Friend WithEvents IhssTextBox As TextBox
    Friend WithEvents txt_turnoextra As TextBox
    Friend WithEvents HorasextrasTextBox As TextBox
    Friend WithEvents SalarioTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Precio As TextBox
    Friend WithEvents ReporteDeduccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents txtsaldopres As TextBox
    Friend WithEvents txtprestamo As TextBox
    Friend WithEvents txt_bono As TextBox
    Friend WithEvents MESFINAL As TextBox
    Friend WithEvents MESINICIAL As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Empleado As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents FECHAFINAL As TextBox
    Friend WithEvents FECHAINICIAL As TextBox
    Friend WithEvents txtturno As TextBox
    Friend WithEvents txt_saluniforme As TextBox
    Friend WithEvents txt_uniforme As TextBox
    Friend WithEvents txt_anticipo As TextBox
    Friend WithEvents AdelantoTextBox As TextBox
    Friend WithEvents UniformeTextBox As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txt_deducciones As TextBox
    Friend WithEvents TotalapagarTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents txt_hferiado As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_pagoferiado As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents horassep As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_septimo As TextBox
    Friend WithEvents txt_ajustes As TextBox
    Friend WithEvents txt_vacaciones As TextBox
    Friend WithEvents DiasTextBox As TextBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_bhoras As TextBox
    Friend WithEvents txt_depreciacion As TextBox
    Friend WithEvents txt_comentario As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_phoras As TextBox
    Friend WithEvents txt_pextras As TextBox
    Friend WithEvents Paneldetalles As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_valorturnoextra As TextBox
    Friend WithEvents AsignacionPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionesGeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanillaDePagosPorUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanillaDeDeduccionesPorUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdNuevoUniforme As Button
    Friend WithEvents HistorialDeImpresionDeCarnetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtOtraDeduccion As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtIdPago As TextBox
    Friend WithEvents ReportesGerencia As ToolStripMenuItem
    Friend WithEvents DetalleDePlanillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalleDePlanillaUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Bisiesto As CheckBox
    Friend WithEvents txtJornada As TextBox
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents idasignacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents horas As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents turno As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Txt_NuevoSalario As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Txt_NuevoPrestamo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Txt_NuevoUniforme As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmdEliminarAnticipo As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents fechaanticipo As DateTimePicker
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents FechadeingresoDateTimePicker As DateTimePicker
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents AnticiposBindingSource As BindingSource
    Friend WithEvents AnticiposTableAdapter As ABASDataSetTableAdapters.AnticiposTableAdapter
    Friend WithEvents AnticiposDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteEntregaUniformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobanteDevolucionUniformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents planilla As DataGridViewTextBoxColumn
    Friend WithEvents bhoras As DataGridViewTextBoxColumn
    Friend WithEvents depreciacion As DataGridViewTextBoxColumn
    Friend WithEvents bonos As DataGridViewTextBoxColumn
End Class
