<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagos
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
        Dim IdpagoLabel As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim BonosLabel As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim AsignacionLabel As System.Windows.Forms.Label
        Dim DiasLabel As System.Windows.Forms.Label
        Dim VacacionesLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim lbl_uniforme As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim lbl_prestamo As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim HorasextrasLabel As System.Windows.Forms.Label
        Dim HorasLabel As System.Windows.Forms.Label
        Dim AdelantoLabel As System.Windows.Forms.Label
        Dim UniformeLabel As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim IhssLabel As System.Windows.Forms.Label
        Dim RapLabel As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim TotalapagarLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarVoucherDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeDeduccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbuscarEmp = New System.Windows.Forms.TextBox()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.lblpago = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Empleado = New System.Windows.Forms.GroupBox()
        Me.txt_depreciacion = New System.Windows.Forms.TextBox()
        Me.txt_bhoras = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.txt_bono = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Salariobase = New System.Windows.Forms.TextBox()
        Me.cmdCambiar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.valor_horasextras = New System.Windows.Forms.TextBox()
        Me.txt_vacaciones = New System.Windows.Forms.TextBox()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dias_Trabajados = New System.Windows.Forms.TextBox()
        Me.txt_ajustes = New System.Windows.Forms.TextBox()
        Me.txt_pagohoras = New System.Windows.Forms.TextBox()
        Me.Horasextras_trabajadas = New System.Windows.Forms.TextBox()
        Me.Horas_Trabajadas = New System.Windows.Forms.TextBox()
        Me.txt_pagohorasextras = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txt_hferiado = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_pagoferiado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.horas_septimo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_septimo = New System.Windows.Forms.TextBox()
        Me.DialibreTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_saluniforme = New System.Windows.Forms.TextBox()
        Me.txt_uniforme = New System.Windows.Forms.TextBox()
        Me.txtsaldopres = New System.Windows.Forms.TextBox()
        Me.txtprestamo = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt_deducciones = New System.Windows.Forms.TextBox()
        Me.TotalapagarTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtOtraDeduccion = New System.Windows.Forms.TextBox()
        Me.AdelantoTextBox = New System.Windows.Forms.TextBox()
        Me.UniformeTextBox = New System.Windows.Forms.TextBox()
        Me.txt_anticipo = New System.Windows.Forms.TextBox()
        Me.RapTextBox = New System.Windows.Forms.TextBox()
        Me.IhssTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bhoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depreciacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hferiado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagoferiado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dialibre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uniformeant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uniformeact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anticipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totdeducciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaanticipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivoajuste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otradeduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.Txt_NuevoSalario = New System.Windows.Forms.TextBox()
        Me.Txt_NuevoPestamo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        IdpagoLabel = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        BonosLabel = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        AsignacionLabel = New System.Windows.Forms.Label()
        DiasLabel = New System.Windows.Forms.Label()
        VacacionesLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        lbl_uniforme = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        lbl_prestamo = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        HorasextrasLabel = New System.Windows.Forms.Label()
        HorasLabel = New System.Windows.Forms.Label()
        AdelantoLabel = New System.Windows.Forms.Label()
        UniformeLabel = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        IhssLabel = New System.Windows.Forms.Label()
        RapLabel = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        TotalapagarLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.panelEmpleados.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Empleado.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdpagoLabel
        '
        IdpagoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        IdpagoLabel.AutoSize = True
        IdpagoLabel.Location = New System.Drawing.Point(758, 28)
        IdpagoLabel.Name = "IdpagoLabel"
        IdpagoLabel.Size = New System.Drawing.Size(49, 13)
        IdpagoLabel.TabIndex = 94
        IdpagoLabel.Text = "ID Pago:"
        '
        'Label16
        '
        Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(724, 16)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(83, 13)
        Label16.TabIndex = 112
        Label16.Text = "Fecha de Pago:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 39
        Label1.Text = "Hasta:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(9, 20)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(41, 13)
        Label3.TabIndex = 38
        Label3.Text = "Desde:"
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
        'BonosLabel
        '
        BonosLabel.AutoSize = True
        BonosLabel.Location = New System.Drawing.Point(87, 173)
        BonosLabel.Name = "BonosLabel"
        BonosLabel.Size = New System.Drawing.Size(40, 13)
        BonosLabel.TabIndex = 77
        BonosLabel.Text = "Bonos:"
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Location = New System.Drawing.Point(57, 95)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(69, 13)
        SalarioLabel.TabIndex = 51
        SalarioLabel.Text = "Salario Base:"
        '
        'AsignacionLabel
        '
        AsignacionLabel.AutoSize = True
        AsignacionLabel.Location = New System.Drawing.Point(394, 69)
        AsignacionLabel.Name = "AsignacionLabel"
        AsignacionLabel.Size = New System.Drawing.Size(39, 13)
        AsignacionLabel.TabIndex = 95
        AsignacionLabel.Text = "Ajuste:"
        '
        'DiasLabel
        '
        DiasLabel.AutoSize = True
        DiasLabel.Location = New System.Drawing.Point(9, 19)
        DiasLabel.Name = "DiasLabel"
        DiasLabel.Size = New System.Drawing.Size(83, 13)
        DiasLabel.TabIndex = 89
        DiasLabel.Text = "Dias trabajados:"
        '
        'VacacionesLabel
        '
        VacacionesLabel.AutoSize = True
        VacacionesLabel.Location = New System.Drawing.Point(26, 45)
        VacacionesLabel.Name = "VacacionesLabel"
        VacacionesLabel.Size = New System.Drawing.Size(66, 13)
        VacacionesLabel.TabIndex = 93
        VacacionesLabel.Text = "Vacaciones:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(336, 18)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(97, 13)
        Label8.TabIndex = 82
        Label8.Text = "Devengado Horas:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(335, 42)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(98, 13)
        Label5.TabIndex = 83
        Label5.Text = "Devengado Extras:"
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
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(96, 59)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(79, 13)
        Label12.TabIndex = 80
        Label12.Text = "Saldo Uniforme"
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
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(14, 60)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(81, 13)
        Label19.TabIndex = 76
        Label19.Text = "Saldo Prestamo"
        '
        'HorasextrasLabel
        '
        HorasextrasLabel.AutoSize = True
        HorasextrasLabel.Location = New System.Drawing.Point(167, 44)
        HorasextrasLabel.Name = "HorasextrasLabel"
        HorasextrasLabel.Size = New System.Drawing.Size(70, 13)
        HorasextrasLabel.TabIndex = 57
        HorasextrasLabel.Text = "Horas Extras:"
        '
        'HorasLabel
        '
        HorasLabel.AutoSize = True
        HorasLabel.Location = New System.Drawing.Point(143, 19)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(94, 13)
        HorasLabel.TabIndex = 65
        HorasLabel.Text = "Horas Trabajadas:"
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
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(52, 72)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(48, 13)
        Label17.TabIndex = 66
        Label17.Text = "Anticipo:"
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
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(44, 124)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(80, 13)
        Label25.TabIndex = 81
        Label25.Text = "Base de Horas:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(53, 148)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(73, 13)
        Label26.TabIndex = 83
        Label26.Text = "Depreciacion:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(24, 45)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(100, 13)
        Label9.TabIndex = 78
        Label9.Text = "Total Deducciones:"
        '
        'TotalapagarLabel
        '
        TotalapagarLabel.AutoSize = True
        TotalapagarLabel.Location = New System.Drawing.Point(33, 71)
        TotalapagarLabel.Name = "TotalapagarLabel"
        TotalapagarLabel.Size = New System.Drawing.Size(93, 13)
        TotalapagarLabel.TabIndex = 74
        TotalapagarLabel.Text = "Total Devengado:"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Location = New System.Drawing.Point(75, 19)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(49, 13)
        SubtotalLabel.TabIndex = 76
        SubtotalLabel.Text = "Subtotal:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Location = New System.Drawing.Point(15, 149)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(85, 13)
        Label28.TabIndex = 73
        Label28.Text = "Otra Deduccion:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarVoucherDePagoToolStripMenuItem, Me.PagosPorFechaToolStripMenuItem, Me.ReportesDeDeduccionesToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'GenerarVoucherDePagoToolStripMenuItem
        '
        Me.GenerarVoucherDePagoToolStripMenuItem.Name = "GenerarVoucherDePagoToolStripMenuItem"
        Me.GenerarVoucherDePagoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.GenerarVoucherDePagoToolStripMenuItem.Text = "Voucher de Pago"
        '
        'PagosPorFechaToolStripMenuItem
        '
        Me.PagosPorFechaToolStripMenuItem.Name = "PagosPorFechaToolStripMenuItem"
        Me.PagosPorFechaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PagosPorFechaToolStripMenuItem.Text = "Planilla de Pagos"
        '
        'ReportesDeDeduccionesToolStripMenuItem
        '
        Me.ReportesDeDeduccionesToolStripMenuItem.Name = "ReportesDeDeduccionesToolStripMenuItem"
        Me.ReportesDeDeduccionesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReportesDeDeduccionesToolStripMenuItem.Text = "Planilla de Deducciones"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCalcular.Location = New System.Drawing.Point(802, 368)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(118, 31)
        Me.btnCalcular.TabIndex = 113
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'panelEmpleados
        '
        Me.panelEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelEmpleados.Controls.Add(Me.PictureBox2)
        Me.panelEmpleados.Controls.Add(Me.Panel2)
        Me.panelEmpleados.Controls.Add(Me.txtbuscarEmp)
        Me.panelEmpleados.Controls.Add(Me.tipodebusqueda)
        Me.panelEmpleados.Location = New System.Drawing.Point(171, 95)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(603, 354)
        Me.panelEmpleados.TabIndex = 97
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.identidad, Me.planilla, Me.DataGridViewTextBoxColumn17})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 53)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(601, 299)
        Me.EmpleadosDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
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
        'identidad
        '
        Me.identidad.DataPropertyName = "identidad"
        Me.identidad.HeaderText = "Identidad"
        Me.identidad.Name = "identidad"
        Me.identidad.Width = 76
        '
        'planilla
        '
        Me.planilla.DataPropertyName = "planilla"
        Me.planilla.HeaderText = "Planilla"
        Me.planilla.Name = "planilla"
        Me.planilla.Width = 65
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ubicacion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 80
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
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(417, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(217, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 9
        '
        'txtbuscarEmp
        '
        Me.txtbuscarEmp.BackColor = System.Drawing.SystemColors.Control
        Me.txtbuscarEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscarEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbuscarEmp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtbuscarEmp.Location = New System.Drawing.Point(219, 25)
        Me.txtbuscarEmp.Multiline = True
        Me.txtbuscarEmp.Name = "txtbuscarEmp"
        Me.txtbuscarEmp.Size = New System.Drawing.Size(197, 20)
        Me.txtbuscarEmp.TabIndex = 8
        Me.txtbuscarEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Identidad", "Nombre", "Ubicacion", "Planilla"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(79, 25)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'lblpago
        '
        Me.lblpago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblpago.AutoSize = True
        Me.lblpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpago.ForeColor = System.Drawing.Color.Red
        Me.lblpago.Location = New System.Drawing.Point(810, 29)
        Me.lblpago.Name = "lblpago"
        Me.lblpago.Size = New System.Drawing.Size(20, 13)
        Me.lblpago.TabIndex = 99
        Me.lblpago.Text = "ID"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.Red
        Me.lblfecha.Location = New System.Drawing.Point(810, 16)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(38, 13)
        Me.lblfecha.TabIndex = 100
        Me.lblfecha.Text = "fecha"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label4.Location = New System.Drawing.Point(0, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(965, 19)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Actualizar un Pago"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 77)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pagos"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(53, 46)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(153, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(53, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Codigo del Empleado:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(561, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.Location = New System.Drawing.Point(377, 36)
        Me.txtbusqueda.MaxLength = 6
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.ReadOnly = True
        Me.txtbusqueda.Size = New System.Drawing.Size(180, 23)
        Me.txtbusqueda.TabIndex = 106
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.Red
        Me.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEliminar.FlatAppearance.BorderSize = 0
        Me.cmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.Location = New System.Drawing.Point(13, 405)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(114, 33)
        Me.cmdEliminar.TabIndex = 98
        Me.cmdEliminar.Text = "Eliminar Pago"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'Empleado
        '
        Me.Empleado.Controls.Add(Label26)
        Me.Empleado.Controls.Add(Me.txt_depreciacion)
        Me.Empleado.Controls.Add(Label25)
        Me.Empleado.Controls.Add(Me.txt_bhoras)
        Me.Empleado.Controls.Add(CodigoLabel)
        Me.Empleado.Controls.Add(BonosLabel)
        Me.Empleado.Controls.Add(Me.CodigoTextBox)
        Me.Empleado.Controls.Add(Me.txt_bono)
        Me.Empleado.Controls.Add(Me.NombresTextBox)
        Me.Empleado.Controls.Add(Me.ApellidosTextBox)
        Me.Empleado.Controls.Add(Me.Salariobase)
        Me.Empleado.Controls.Add(SalarioLabel)
        Me.Empleado.Location = New System.Drawing.Point(13, 102)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(209, 207)
        Me.Empleado.TabIndex = 103
        Me.Empleado.TabStop = False
        Me.Empleado.Text = "Datos del Empleado"
        '
        'txt_depreciacion
        '
        Me.txt_depreciacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.txt_depreciacion.Location = New System.Drawing.Point(128, 146)
        Me.txt_depreciacion.Name = "txt_depreciacion"
        Me.txt_depreciacion.Size = New System.Drawing.Size(66, 20)
        Me.txt_depreciacion.TabIndex = 84
        Me.txt_depreciacion.Text = "0"
        '
        'txt_bhoras
        '
        Me.txt_bhoras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "bonos", True))
        Me.txt_bhoras.Location = New System.Drawing.Point(128, 121)
        Me.txt_bhoras.Name = "txt_bhoras"
        Me.txt_bhoras.ReadOnly = True
        Me.txt_bhoras.Size = New System.Drawing.Size(66, 20)
        Me.txt_bhoras.TabIndex = 82
        Me.txt_bhoras.Text = "0"
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
        'txt_bono
        '
        Me.txt_bono.Location = New System.Drawing.Point(128, 173)
        Me.txt_bono.Name = "txt_bono"
        Me.txt_bono.Size = New System.Drawing.Size(66, 20)
        Me.txt_bono.TabIndex = 78
        Me.txt_bono.Text = "0"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.Location = New System.Drawing.Point(61, 42)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.ReadOnly = True
        Me.NombresTextBox.Size = New System.Drawing.Size(134, 20)
        Me.NombresTextBox.TabIndex = 38
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.Location = New System.Drawing.Point(61, 64)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.ReadOnly = True
        Me.ApellidosTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ApellidosTextBox.TabIndex = 39
        '
        'Salariobase
        '
        Me.Salariobase.Location = New System.Drawing.Point(128, 92)
        Me.Salariobase.Name = "Salariobase"
        Me.Salariobase.ReadOnly = True
        Me.Salariobase.Size = New System.Drawing.Size(66, 20)
        Me.Salariobase.TabIndex = 52
        Me.Salariobase.Text = "0"
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
        Me.cmdCambiar.Location = New System.Drawing.Point(29, 43)
        Me.cmdCambiar.Name = "cmdCambiar"
        Me.cmdCambiar.Size = New System.Drawing.Size(149, 32)
        Me.cmdCambiar.TabIndex = 101
        Me.cmdCambiar.Text = "Cambiar Salario"
        Me.cmdCambiar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCambiar.UseVisualStyleBackColor = False
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
        Me.cmdActualizar.Location = New System.Drawing.Point(801, 409)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(118, 31)
        Me.cmdActualizar.TabIndex = 96
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_comentario)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox9)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(228, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(540, 336)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Roles"
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(82, 238)
        Me.txt_comentario.MaxLength = 200
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(223, 87)
        Me.txt_comentario.TabIndex = 88
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 238)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 13)
        Me.Label27.TabIndex = 87
        Me.Label27.Text = "Comentario:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.valor_horasextras)
        Me.GroupBox4.Controls.Add(Me.txt_vacaciones)
        Me.GroupBox4.Controls.Add(AsignacionLabel)
        Me.GroupBox4.Controls.Add(VacacionesLabel)
        Me.GroupBox4.Controls.Add(Me.Dias_Trabajados)
        Me.GroupBox4.Controls.Add(Me.txt_ajustes)
        Me.GroupBox4.Controls.Add(DiasLabel)
        Me.GroupBox4.Controls.Add(Me.txt_pagohoras)
        Me.GroupBox4.Controls.Add(Me.Horasextras_trabajadas)
        Me.GroupBox4.Controls.Add(HorasextrasLabel)
        Me.GroupBox4.Controls.Add(Label8)
        Me.GroupBox4.Controls.Add(Me.Horas_Trabajadas)
        Me.GroupBox4.Controls.Add(Me.txt_pagohorasextras)
        Me.GroupBox4.Controls.Add(HorasLabel)
        Me.GroupBox4.Controls.Add(Label5)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(525, 105)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de Horas"
        '
        'valor_horasextras
        '
        Me.valor_horasextras.Location = New System.Drawing.Point(243, 65)
        Me.valor_horasextras.Name = "valor_horasextras"
        Me.valor_horasextras.Size = New System.Drawing.Size(84, 20)
        Me.valor_horasextras.TabIndex = 68
        Me.valor_horasextras.Text = "0"
        '
        'txt_vacaciones
        '
        Me.txt_vacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "vacaciones", True))
        Me.txt_vacaciones.Location = New System.Drawing.Point(94, 42)
        Me.txt_vacaciones.Name = "txt_vacaciones"
        Me.txt_vacaciones.Size = New System.Drawing.Size(47, 20)
        Me.txt_vacaciones.TabIndex = 94
        Me.txt_vacaciones.Text = "0"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.ABASDataSet
        '
        'Dias_Trabajados
        '
        Me.Dias_Trabajados.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "dias", True))
        Me.Dias_Trabajados.Location = New System.Drawing.Point(94, 17)
        Me.Dias_Trabajados.Name = "Dias_Trabajados"
        Me.Dias_Trabajados.Size = New System.Drawing.Size(47, 20)
        Me.Dias_Trabajados.TabIndex = 90
        Me.Dias_Trabajados.Text = "0"
        '
        'txt_ajustes
        '
        Me.txt_ajustes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "asignacion", True))
        Me.txt_ajustes.Location = New System.Drawing.Point(435, 66)
        Me.txt_ajustes.Name = "txt_ajustes"
        Me.txt_ajustes.Size = New System.Drawing.Size(66, 20)
        Me.txt_ajustes.TabIndex = 96
        Me.txt_ajustes.Text = "0"
        '
        'txt_pagohoras
        '
        Me.txt_pagohoras.Location = New System.Drawing.Point(434, 14)
        Me.txt_pagohoras.Name = "txt_pagohoras"
        Me.txt_pagohoras.ReadOnly = True
        Me.txt_pagohoras.Size = New System.Drawing.Size(66, 20)
        Me.txt_pagohoras.TabIndex = 80
        Me.txt_pagohoras.Text = "0"
        '
        'Horasextras_trabajadas
        '
        Me.Horasextras_trabajadas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "horasextras", True))
        Me.Horasextras_trabajadas.Location = New System.Drawing.Point(243, 40)
        Me.Horasextras_trabajadas.Name = "Horasextras_trabajadas"
        Me.Horasextras_trabajadas.ReadOnly = True
        Me.Horasextras_trabajadas.Size = New System.Drawing.Size(84, 20)
        Me.Horasextras_trabajadas.TabIndex = 58
        '
        'Horas_Trabajadas
        '
        Me.Horas_Trabajadas.Location = New System.Drawing.Point(243, 15)
        Me.Horas_Trabajadas.Name = "Horas_Trabajadas"
        Me.Horas_Trabajadas.ReadOnly = True
        Me.Horas_Trabajadas.Size = New System.Drawing.Size(84, 20)
        Me.Horas_Trabajadas.TabIndex = 66
        '
        'txt_pagohorasextras
        '
        Me.txt_pagohorasextras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "salario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txt_pagohorasextras.DataBindings.Add(New System.Windows.Forms.Binding("Size", Me.PagosBindingSource, "horasextras", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txt_pagohorasextras.Location = New System.Drawing.Point(434, 39)
        Me.txt_pagohorasextras.Name = "txt_pagohorasextras"
        Me.txt_pagohorasextras.ReadOnly = True
        Me.txt_pagohorasextras.Size = New System.Drawing.Size(66, 20)
        Me.txt_pagohorasextras.TabIndex = 81
        Me.txt_pagohorasextras.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(146, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 13)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Valor Hora Extras:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.DialibreTextBox)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(309, 106)
        Me.GroupBox7.TabIndex = 83
        Me.GroupBox7.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txt_hferiado)
        Me.GroupBox10.Controls.Add(Me.Label11)
        Me.GroupBox10.Controls.Add(Me.Label18)
        Me.GroupBox10.Controls.Add(Me.txt_pagoferiado)
        Me.GroupBox10.Location = New System.Drawing.Point(157, 9)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Horas"
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
        Me.Label15.Location = New System.Drawing.Point(31, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Turnos Extras"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.horas_septimo)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.txt_septimo)
        Me.GroupBox8.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(140, 64)
        Me.GroupBox8.TabIndex = 84
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Dias Libres / Septimos"
        '
        'horas_septimo
        '
        Me.horas_septimo.Location = New System.Drawing.Point(11, 30)
        Me.horas_septimo.Name = "horas_septimo"
        Me.horas_septimo.ReadOnly = True
        Me.horas_septimo.Size = New System.Drawing.Size(55, 20)
        Me.horas_septimo.TabIndex = 79
        Me.horas_septimo.Text = "0"
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
        'DialibreTextBox
        '
        Me.DialibreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "dialibre", True))
        Me.DialibreTextBox.Location = New System.Drawing.Point(109, 79)
        Me.DialibreTextBox.Name = "DialibreTextBox"
        Me.DialibreTextBox.ReadOnly = True
        Me.DialibreTextBox.Size = New System.Drawing.Size(30, 20)
        Me.DialibreTextBox.TabIndex = 59
        Me.DialibreTextBox.Text = "0"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_saluniforme)
        Me.GroupBox6.Controls.Add(lbl_uniforme)
        Me.GroupBox6.Controls.Add(Me.txt_uniforme)
        Me.GroupBox6.Controls.Add(Label12)
        Me.GroupBox6.Controls.Add(Me.txtsaldopres)
        Me.GroupBox6.Controls.Add(lbl_prestamo)
        Me.GroupBox6.Controls.Add(Me.txtprestamo)
        Me.GroupBox6.Controls.Add(Label19)
        Me.GroupBox6.Location = New System.Drawing.Point(338, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(194, 106)
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
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txt_deducciones)
        Me.GroupBox9.Controls.Add(Label9)
        Me.GroupBox9.Controls.Add(TotalapagarLabel)
        Me.GroupBox9.Controls.Add(Me.TotalapagarTextBox)
        Me.GroupBox9.Controls.Add(Me.SubtotalTextBox)
        Me.GroupBox9.Controls.Add(SubtotalLabel)
        Me.GroupBox9.Location = New System.Drawing.Point(323, 232)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(210, 98)
        Me.GroupBox9.TabIndex = 120
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Calculo de Totales"
        '
        'txt_deducciones
        '
        Me.txt_deducciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "salario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txt_deducciones.DataBindings.Add(New System.Windows.Forms.Binding("Size", Me.PagosBindingSource, "horasextras", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txt_deducciones.Location = New System.Drawing.Point(131, 42)
        Me.txt_deducciones.Name = "txt_deducciones"
        Me.txt_deducciones.ReadOnly = True
        Me.txt_deducciones.Size = New System.Drawing.Size(66, 20)
        Me.txt_deducciones.TabIndex = 79
        Me.txt_deducciones.Text = "0"
        '
        'TotalapagarTextBox
        '
        Me.TotalapagarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "totalapagar", True))
        Me.TotalapagarTextBox.Location = New System.Drawing.Point(131, 68)
        Me.TotalapagarTextBox.Name = "TotalapagarTextBox"
        Me.TotalapagarTextBox.ReadOnly = True
        Me.TotalapagarTextBox.Size = New System.Drawing.Size(66, 20)
        Me.TotalapagarTextBox.TabIndex = 75
        Me.TotalapagarTextBox.Text = "0"
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "subtotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(130, 16)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(66, 20)
        Me.SubtotalTextBox.TabIndex = 77
        Me.SubtotalTextBox.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Label28)
        Me.GroupBox5.Controls.Add(Me.txtOtraDeduccion)
        Me.GroupBox5.Controls.Add(Me.AdelantoTextBox)
        Me.GroupBox5.Controls.Add(AdelantoLabel)
        Me.GroupBox5.Controls.Add(Me.UniformeTextBox)
        Me.GroupBox5.Controls.Add(UniformeLabel)
        Me.GroupBox5.Controls.Add(Me.txt_anticipo)
        Me.GroupBox5.Controls.Add(Label17)
        Me.GroupBox5.Controls.Add(Me.RapTextBox)
        Me.GroupBox5.Controls.Add(Me.IhssTextBox)
        Me.GroupBox5.Controls.Add(IhssLabel)
        Me.GroupBox5.Controls.Add(RapLabel)
        Me.GroupBox5.Location = New System.Drawing.Point(772, 102)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(165, 181)
        Me.GroupBox5.TabIndex = 116
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Deducciones"
        '
        'txtOtraDeduccion
        '
        Me.txtOtraDeduccion.Location = New System.Drawing.Point(105, 146)
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
        Me.UniformeTextBox.Location = New System.Drawing.Point(106, 96)
        Me.UniformeTextBox.Name = "UniformeTextBox"
        Me.UniformeTextBox.Size = New System.Drawing.Size(54, 20)
        Me.UniformeTextBox.TabIndex = 69
        Me.UniformeTextBox.Text = "0"
        '
        'txt_anticipo
        '
        Me.txt_anticipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosBindingSource, "rap", True))
        Me.txt_anticipo.Location = New System.Drawing.Point(106, 69)
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(29, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 29)
        Me.Button2.TabIndex = 118
        Me.Button2.Text = "Nuevo Prestamo"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Checked = False
        Me.DateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker3.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(346, 0)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker3.TabIndex = 119
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PagosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PagosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PagosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn31, Me.bhoras, Me.depreciacion, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.hferiado, Me.pagoferiado, Me.dialibre, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn50, Me.uniformeant, Me.DataGridViewTextBoxColumn41, Me.uniformeact, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.anticipo, Me.DataGridViewTextBoxColumn33, Me.totdeducciones, Me.DataGridViewTextBoxColumn42, Me.fechaanticipo, Me.motivoajuste, Me.DataGridViewTextBoxColumn44, Me.otradeduccion})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(0, 501)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.RowHeadersVisible = False
        Me.PagosDataGridView.Size = New System.Drawing.Size(965, 191)
        Me.PagosDataGridView.TabIndex = 114
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "idpago"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 41
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "desde"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Desde"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 63
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "fechadepago"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Hasta"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 60
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Codigo de Empleado"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 119
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "salario"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Salario"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 64
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
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "bonos"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Bonos"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Width = 62
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "horasdialibre"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Horas Dias Libres"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Width = 105
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "horassept"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Devengado Dias Libres"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 105
        '
        'hferiado
        '
        Me.hferiado.DataPropertyName = "hferiado"
        Me.hferiado.HeaderText = "Horas feriado"
        Me.hferiado.Name = "hferiado"
        Me.hferiado.Width = 87
        '
        'pagoferiado
        '
        Me.pagoferiado.DataPropertyName = "pagoferiado"
        Me.pagoferiado.HeaderText = "Pago feriado"
        Me.pagoferiado.Name = "pagoferiado"
        Me.pagoferiado.Width = 85
        '
        'dialibre
        '
        Me.dialibre.DataPropertyName = "dialibre"
        Me.dialibre.HeaderText = "Turnos Extras"
        Me.dialibre.Name = "dialibre"
        Me.dialibre.Width = 89
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "dias"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Dias Trabajados"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "horas"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Horas Trabajadas"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 106
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "preciodeh"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Devengado de Horas"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.Width = 97
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "horasextras"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Horas Extras"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 85
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "valordehe"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Valor H.Extra"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 87
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "preciodehe"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Devengado de H.Extras"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 97
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "vacaciones"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Vacaciones"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 88
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "asignacion"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Ajustes"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 66
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "saldoant"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Prestamo"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 76
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "adelanto"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Abono pretamo"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 96
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "saldoact"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Saldo prestamo"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 96
        '
        'uniformeant
        '
        Me.uniformeant.DataPropertyName = "uniformeant"
        Me.uniformeant.HeaderText = "Uniforme"
        Me.uniformeant.Name = "uniformeant"
        Me.uniformeant.Width = 74
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "uniforme"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Abono Uniforme"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 99
        '
        'uniformeact
        '
        Me.uniformeact.DataPropertyName = "uniformeact"
        Me.uniformeact.HeaderText = "Saldo Uniforme"
        Me.uniformeact.Name = "uniformeact"
        Me.uniformeact.Width = 96
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ihss"
        Me.DataGridViewTextBoxColumn38.HeaderText = "IHSS"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 57
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "rap"
        Me.DataGridViewTextBoxColumn39.HeaderText = "RAP"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 54
        '
        'anticipo
        '
        Me.anticipo.DataPropertyName = "anticipo"
        Me.anticipo.HeaderText = "Anticipo"
        Me.anticipo.Name = "anticipo"
        Me.anticipo.Width = 70
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "subtotal"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 71
        '
        'totdeducciones
        '
        Me.totdeducciones.DataPropertyName = "totdeducciones"
        Me.totdeducciones.HeaderText = "Deducciones"
        Me.totdeducciones.Name = "totdeducciones"
        Me.totdeducciones.Width = 95
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "totalapagar"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Total RRHH Pagar"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 112
        '
        'fechaanticipo
        '
        Me.fechaanticipo.DataPropertyName = "fechaanticipo"
        Me.fechaanticipo.HeaderText = "Fecha Anticipo"
        Me.fechaanticipo.Name = "fechaanticipo"
        Me.fechaanticipo.Visible = False
        '
        'motivoajuste
        '
        Me.motivoajuste.DataPropertyName = "motivoajuste"
        Me.motivoajuste.HeaderText = "Comentario"
        Me.motivoajuste.Name = "motivoajuste"
        Me.motivoajuste.Width = 85
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 65
        '
        'otradeduccion
        '
        Me.otradeduccion.DataPropertyName = "otradeduccion"
        Me.otradeduccion.HeaderText = "Otra Deduccion"
        Me.otradeduccion.Name = "otradeduccion"
        Me.otradeduccion.Width = 98
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
        'Txt_NuevoSalario
        '
        Me.Txt_NuevoSalario.Location = New System.Drawing.Point(69, 19)
        Me.Txt_NuevoSalario.Name = "Txt_NuevoSalario"
        Me.Txt_NuevoSalario.Size = New System.Drawing.Size(66, 20)
        Me.Txt_NuevoSalario.TabIndex = 85
        Me.Txt_NuevoSalario.Text = "0"
        '
        'Txt_NuevoPestamo
        '
        Me.Txt_NuevoPestamo.Location = New System.Drawing.Point(49, 14)
        Me.Txt_NuevoPestamo.Name = "Txt_NuevoPestamo"
        Me.Txt_NuevoPestamo.Size = New System.Drawing.Size(66, 20)
        Me.Txt_NuevoPestamo.TabIndex = 120
        Me.Txt_NuevoPestamo.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_NuevoSalario)
        Me.GroupBox2.Controls.Add(Me.cmdCambiar)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 89)
        Me.GroupBox2.TabIndex = 121
        Me.GroupBox2.TabStop = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button2)
        Me.GroupBox11.Controls.Add(Me.Txt_NuevoPestamo)
        Me.GroupBox11.Location = New System.Drawing.Point(772, 286)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(165, 76)
        Me.GroupBox11.TabIndex = 122
        Me.GroupBox11.TabStop = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox12.Controls.Add(Me.panelEmpleados)
        Me.GroupBox12.Controls.Add(Me.GroupBox1)
        Me.GroupBox12.Controls.Add(Me.GroupBox5)
        Me.GroupBox12.Controls.Add(IdpagoLabel)
        Me.GroupBox12.Controls.Add(Me.GroupBox11)
        Me.GroupBox12.Controls.Add(Label16)
        Me.GroupBox12.Controls.Add(Me.lblpago)
        Me.GroupBox12.Controls.Add(Me.GroupBox3)
        Me.GroupBox12.Controls.Add(Me.lblfecha)
        Me.GroupBox12.Controls.Add(Me.GroupBox2)
        Me.GroupBox12.Controls.Add(Me.Empleado)
        Me.GroupBox12.Controls.Add(Me.cmdActualizar)
        Me.GroupBox12.Controls.Add(Me.Label2)
        Me.GroupBox12.Controls.Add(Me.cmdEliminar)
        Me.GroupBox12.Controls.Add(Me.PictureBox1)
        Me.GroupBox12.Controls.Add(Me.btnCalcular)
        Me.GroupBox12.Controls.Add(Me.txtbusqueda)
        Me.GroupBox12.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox12.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(941, 449)
        Me.GroupBox12.TabIndex = 123
        Me.GroupBox12.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(935, 430)
        Me.ShapeContainer1.TabIndex = 123
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1179
        Me.LineShape1.X2 = 1367
        Me.LineShape1.Y1 = 43
        Me.LineShape1.Y2 = 43
        '
        'FormPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 692)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.PagosDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPagos"
        Me.Text = "FormPagos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelEmpleados.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Empleado.ResumeLayout(False)
        Me.Empleado.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarVoucherDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosPorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesDeDeduccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCalcular As Button
    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbuscarEmp As TextBox
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents lblpago As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents Empleado As GroupBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents txt_bono As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents Salariobase As TextBox
    Friend WithEvents cmdCambiar As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents identidad As DataGridViewTextBoxColumn
    Friend WithEvents planilla As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_ajustes As TextBox
    Friend WithEvents txt_vacaciones As TextBox
    Friend WithEvents Dias_Trabajados As TextBox
    Friend WithEvents txt_pagohoras As TextBox
    Friend WithEvents txt_pagohorasextras As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents txt_hferiado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_pagoferiado As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents horas_septimo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_septimo As TextBox
    Friend WithEvents DialibreTextBox As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txt_saluniforme As TextBox
    Friend WithEvents txt_uniforme As TextBox
    Friend WithEvents txtsaldopres As TextBox
    Friend WithEvents txtprestamo As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents valor_horasextras As TextBox
    Friend WithEvents Horasextras_trabajadas As TextBox
    Friend WithEvents Horas_Trabajadas As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents AdelantoTextBox As TextBox
    Friend WithEvents UniformeTextBox As TextBox
    Friend WithEvents txt_anticipo As TextBox
    Friend WithEvents RapTextBox As TextBox
    Friend WithEvents IhssTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_bhoras As TextBox
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents txt_depreciacion As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txt_deducciones As TextBox
    Friend WithEvents TotalapagarTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents txt_comentario As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents PagosDataGridView As DataGridView
    Friend WithEvents txtOtraDeduccion As TextBox
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents bhoras As DataGridViewTextBoxColumn
    Friend WithEvents depreciacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents hferiado As DataGridViewTextBoxColumn
    Friend WithEvents pagoferiado As DataGridViewTextBoxColumn
    Friend WithEvents dialibre As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents uniformeant As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents uniformeact As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents anticipo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents totdeducciones As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents fechaanticipo As DataGridViewTextBoxColumn
    Friend WithEvents motivoajuste As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents otradeduccion As DataGridViewTextBoxColumn
    Friend WithEvents Txt_NuevoSalario As TextBox
    Friend WithEvents Txt_NuevoPestamo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
