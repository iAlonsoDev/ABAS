<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventarioUniformes
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
        Dim EstiloLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel1 As System.Windows.Forms.Label
        Dim IduniformeLabel As System.Windows.Forms.Label
        Dim EstadoLabel1 As System.Windows.Forms.Label
        Dim IduniformeLabel1 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim IdsolicitudLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim EntregaLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim EstiloLabel1 As System.Windows.Forms.Label
        Dim EstadoLabel2 As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim TallaLabel1 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim IddevolucionLabel As System.Windows.Forms.Label
        Dim CarnetLabel As System.Windows.Forms.Label
        Dim CodigoLabel1 As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim RecibeLabel As System.Windows.Forms.Label
        Dim FechaLabel1 As System.Windows.Forms.Label
        Dim EstadoLabel3 As System.Windows.Forms.Label
        Dim RembolsoLabel As System.Windows.Forms.Label
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim TipoLabel1 As System.Windows.Forms.Label
        Dim CantidadLabel1 As System.Windows.Forms.Label
        Dim TallaLabel As System.Windows.Forms.Label
        Dim EstiloLabel2 As System.Windows.Forms.Label
        Dim EstadoLabel4 As System.Windows.Forms.Label
        Dim TallaLabel2 As System.Windows.Forms.Label
        Dim TallaLabel3 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UniformesDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmb_RUIalm = New System.Windows.Forms.ComboBox()
        Me.Cmb_RUalm = New System.Windows.Forms.ComboBox()
        Me.Cmd_Limpiar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CantFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CantUniforme = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CantInicial = New System.Windows.Forms.TextBox()
        Me.Cmd_RegistrarUniforme = New System.Windows.Forms.Button()
        Me.CmdAgregarUniforme = New System.Windows.Forms.Button()
        Me.Cmb_TipoUniforme = New System.Windows.Forms.ComboBox()
        Me.DetalleSolicitudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.Cmb_EstadoUniforme = New System.Windows.Forms.ComboBox()
        Me.TallaTextBox2 = New System.Windows.Forms.TextBox()
        Me.UniformesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.IduniformeTextBox = New System.Windows.Forms.TextBox()
        Me.EstiloTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.EstiloRecibe = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DescripcionRecibe = New System.Windows.Forms.TextBox()
        Me.IdMov = New System.Windows.Forms.TextBox()
        Me.EstadoRecibe = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboRecibe = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CantRecibe = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Cmd_Recibir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Cmd_Nuevo = New System.Windows.Forms.Button()
        Me.Cmd_Transferir = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CantFinRecibe = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CantMovRecibe = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CantIniRecibe = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboHacia = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboDesde = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TallaTextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EstiloEnvia = New System.Windows.Forms.TextBox()
        Me.EstadoMovimiento = New System.Windows.Forms.TextBox()
        Me.MovimientoUniformesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionMovimiento = New System.Windows.Forms.TextBox()
        Me.IduniformeMovimiento = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CantFinalEnvia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CantMoverEnvia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CantIniEnvia = New System.Windows.Forms.TextBox()
        Me.MovimientoUniformesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recibe_mov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DetalleSolicitudDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDSolicitudDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUniformeDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstiloDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDSolicitudUniforme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoFormaDePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Veces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cmd_ImprimirSolicitud = New System.Windows.Forms.PictureBox()
        Me.Txt_TotalPagar = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.TallaTextBox = New System.Windows.Forms.TextBox()
        Me.EstiloTextBox1 = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Cmd_CancelarSolicitud = New System.Windows.Forms.Button()
        Me.Cmd_NuevaSolicitud = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.IdsolicitudTextBox = New System.Windows.Forms.TextBox()
        Me.SolicitudUniformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmd_CrearSolicitud = New System.Windows.Forms.Button()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.EntregaTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IddevolucionTextBox = New System.Windows.Forms.TextBox()
        Me.DevolucionUniformeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RembolsoTextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.EstadoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CodigoTextBox1 = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.RecibeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.EstadoComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DevolucionUniformeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstiloTextBox2 = New System.Windows.Forms.TextBox()
        Me.TallaTextBox1 = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox1 = New System.Windows.Forms.TextBox()
        Me.TipoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.AlmacenComboBox = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DevolucionUniformeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.iddevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.almacendetalledevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipodetalledevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadetalledevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.talladetalledevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estilodetalledevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadodetalledevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbuscarEmp = New System.Windows.Forms.TextBox()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosDeUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosDeUniformesPorTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobanteEntregaUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobanteDevolucionUniformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UniformesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.UniformesTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.MovimientoUniformesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.MovimientoUniformesTableAdapter()
        Me.SolicitudUniformeTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.SolicitudUniformeTableAdapter()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.DetalleSolicitudTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.DetalleSolicitudTableAdapter()
        Me.DevolucionUniformeDetalleTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.DevolucionUniformeDetalleTableAdapter()
        Me.DevolucionUniformeTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.DevolucionUniformeTableAdapter()
        EstiloLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        DescripcionLabel1 = New System.Windows.Forms.Label()
        IduniformeLabel = New System.Windows.Forms.Label()
        EstadoLabel1 = New System.Windows.Forms.Label()
        IduniformeLabel1 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        IdsolicitudLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        EntregaLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        EstiloLabel1 = New System.Windows.Forms.Label()
        EstadoLabel2 = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        TallaLabel1 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        IddevolucionLabel = New System.Windows.Forms.Label()
        CarnetLabel = New System.Windows.Forms.Label()
        CodigoLabel1 = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        RecibeLabel = New System.Windows.Forms.Label()
        FechaLabel1 = New System.Windows.Forms.Label()
        EstadoLabel3 = New System.Windows.Forms.Label()
        RembolsoLabel = New System.Windows.Forms.Label()
        AlmacenLabel = New System.Windows.Forms.Label()
        TipoLabel1 = New System.Windows.Forms.Label()
        CantidadLabel1 = New System.Windows.Forms.Label()
        TallaLabel = New System.Windows.Forms.Label()
        EstiloLabel2 = New System.Windows.Forms.Label()
        EstadoLabel4 = New System.Windows.Forms.Label()
        TallaLabel2 = New System.Windows.Forms.Label()
        TallaLabel3 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.UniformesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DetalleSolicitudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniformesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoUniformesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.MovimientoUniformesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DetalleSolicitudDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cmd_ImprimirSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolicitudUniformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevolucionUniformeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevolucionUniformeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevolucionUniformeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEmpleados.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EstiloLabel
        '
        EstiloLabel.AutoSize = True
        EstiloLabel.Location = New System.Drawing.Point(62, 55)
        EstiloLabel.Name = "EstiloLabel"
        EstiloLabel.Size = New System.Drawing.Size(35, 13)
        EstiloLabel.TabIndex = 4
        EstiloLabel.Text = "Estilo:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(54, 85)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 6
        EstadoLabel.Text = "Estado:"
        '
        'DescripcionLabel1
        '
        DescripcionLabel1.AutoSize = True
        DescripcionLabel1.Location = New System.Drawing.Point(22, 25)
        DescripcionLabel1.Name = "DescripcionLabel1"
        DescripcionLabel1.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel1.TabIndex = 11
        DescripcionLabel1.Text = "Descripcion:"
        '
        'IduniformeLabel
        '
        IduniformeLabel.AutoSize = True
        IduniformeLabel.Location = New System.Drawing.Point(22, 51)
        IduniformeLabel.Name = "IduniformeLabel"
        IduniformeLabel.Size = New System.Drawing.Size(66, 13)
        IduniformeLabel.TabIndex = 12
        IduniformeLabel.Text = "ID Uniforme:"
        '
        'EstadoLabel1
        '
        EstadoLabel1.AutoSize = True
        EstadoLabel1.Location = New System.Drawing.Point(45, 104)
        EstadoLabel1.Name = "EstadoLabel1"
        EstadoLabel1.Size = New System.Drawing.Size(43, 13)
        EstadoLabel1.TabIndex = 16
        EstadoLabel1.Text = "Estado:"
        '
        'IduniformeLabel1
        '
        IduniformeLabel1.AutoSize = True
        IduniformeLabel1.Location = New System.Drawing.Point(76, 158)
        IduniformeLabel1.Name = "IduniformeLabel1"
        IduniformeLabel1.Size = New System.Drawing.Size(21, 13)
        IduniformeLabel1.TabIndex = 7
        IduniformeLabel1.Text = "ID:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(22, 43)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(66, 13)
        Label12.TabIndex = 11
        Label12.Text = "Descripcion:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(45, 126)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(43, 13)
        Label18.TabIndex = 16
        Label18.Text = "Estado:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(53, 130)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(35, 13)
        Label22.TabIndex = 16
        Label22.Text = "Estilo:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(53, 152)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(35, 13)
        Label23.TabIndex = 16
        Label23.Text = "Estilo:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(43, 178)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(45, 13)
        Label25.TabIndex = 12
        Label25.Text = "ID Mov:"
        '
        'IdsolicitudLabel
        '
        IdsolicitudLabel.AutoSize = True
        IdsolicitudLabel.Location = New System.Drawing.Point(54, 70)
        IdsolicitudLabel.Name = "IdsolicitudLabel"
        IdsolicitudLabel.Size = New System.Drawing.Size(64, 13)
        IdsolicitudLabel.TabIndex = 0
        IdsolicitudLabel.Text = "ID Solicitud:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(35, 47)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(83, 13)
        FechaLabel.TabIndex = 2
        FechaLabel.Text = "Fecha Solicitud:"
        '
        'EntregaLabel
        '
        EntregaLabel.AutoSize = True
        EntregaLabel.Location = New System.Drawing.Point(230, 24)
        EntregaLabel.Name = "EntregaLabel"
        EntregaLabel.Size = New System.Drawing.Size(47, 13)
        EntregaLabel.TabIndex = 4
        EntregaLabel.Text = "Entrega:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(10, 24)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(108, 13)
        CodigoLabel.TabIndex = 8
        CodigoLabel.Text = "Codigo de Empleado:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(6, 22)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(76, 13)
        TipoLabel.TabIndex = 1
        TipoLabel.Text = "Tipo Uniforme:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(296, 74)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(70, 13)
        CantidadLabel.TabIndex = 3
        CantidadLabel.Text = "Cant Asignar:"
        '
        'EstiloLabel1
        '
        EstiloLabel1.AutoSize = True
        EstiloLabel1.Location = New System.Drawing.Point(48, 100)
        EstiloLabel1.Name = "EstiloLabel1"
        EstiloLabel1.Size = New System.Drawing.Size(35, 13)
        EstiloLabel1.TabIndex = 7
        EstiloLabel1.Text = "Estilo:"
        '
        'EstadoLabel2
        '
        EstadoLabel2.AutoSize = True
        EstadoLabel2.Location = New System.Drawing.Point(40, 48)
        EstadoLabel2.Name = "EstadoLabel2"
        EstadoLabel2.Size = New System.Drawing.Size(43, 13)
        EstadoLabel2.TabIndex = 9
        EstadoLabel2.Text = "Estado:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(332, 103)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 11
        ValorLabel.Text = "Valor:"
        '
        'TallaLabel1
        '
        TallaLabel1.AutoSize = True
        TallaLabel1.Location = New System.Drawing.Point(49, 74)
        TallaLabel1.Name = "TallaLabel1"
        TallaLabel1.Size = New System.Drawing.Size(33, 13)
        TallaLabel1.TabIndex = 12
        TallaLabel1.Text = "Talla:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(21, 28)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(76, 13)
        Label24.TabIndex = 66
        Label24.Text = "Tipo Uniforme:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(301, 49)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(65, 13)
        Label26.TabIndex = 3
        Label26.Text = "Cant Actual:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(442, 49)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(57, 13)
        Label27.TabIndex = 3
        Label27.Text = "Cant Final:"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Location = New System.Drawing.Point(297, 130)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(74, 13)
        Label29.TabIndex = 12
        Label29.Text = "Total a Pagar:"
        '
        'IddevolucionLabel
        '
        IddevolucionLabel.AutoSize = True
        IddevolucionLabel.Location = New System.Drawing.Point(32, 19)
        IddevolucionLabel.Name = "IddevolucionLabel"
        IddevolucionLabel.Size = New System.Drawing.Size(78, 13)
        IddevolucionLabel.TabIndex = 0
        IddevolucionLabel.Text = "ID Devolucion:"
        '
        'CarnetLabel
        '
        CarnetLabel.AutoSize = True
        CarnetLabel.Location = New System.Drawing.Point(69, 46)
        CarnetLabel.Name = "CarnetLabel"
        CarnetLabel.Size = New System.Drawing.Size(41, 13)
        CarnetLabel.TabIndex = 2
        CarnetLabel.Text = "Carnet:"
        '
        'CodigoLabel1
        '
        CodigoLabel1.AutoSize = True
        CodigoLabel1.Location = New System.Drawing.Point(17, 71)
        CodigoLabel1.Name = "CodigoLabel1"
        CodigoLabel1.Size = New System.Drawing.Size(93, 13)
        CodigoLabel1.TabIndex = 6
        CodigoLabel1.Text = "Codigo Empleado:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(40, 203)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 8
        ObservacionLabel.Text = "Observacion:"
        '
        'RecibeLabel
        '
        RecibeLabel.AutoSize = True
        RecibeLabel.Location = New System.Drawing.Point(66, 176)
        RecibeLabel.Name = "RecibeLabel"
        RecibeLabel.Size = New System.Drawing.Size(44, 13)
        RecibeLabel.TabIndex = 10
        RecibeLabel.Text = "Recibe:"
        '
        'FechaLabel1
        '
        FechaLabel1.AutoSize = True
        FechaLabel1.Location = New System.Drawing.Point(70, 97)
        FechaLabel1.Name = "FechaLabel1"
        FechaLabel1.Size = New System.Drawing.Size(40, 13)
        FechaLabel1.TabIndex = 12
        FechaLabel1.Text = "Fecha:"
        '
        'EstadoLabel3
        '
        EstadoLabel3.AutoSize = True
        EstadoLabel3.Location = New System.Drawing.Point(70, 123)
        EstadoLabel3.Name = "EstadoLabel3"
        EstadoLabel3.Size = New System.Drawing.Size(43, 13)
        EstadoLabel3.TabIndex = 14
        EstadoLabel3.Text = "Estado:"
        '
        'RembolsoLabel
        '
        RembolsoLabel.AutoSize = True
        RembolsoLabel.Location = New System.Drawing.Point(26, 150)
        RembolsoLabel.Name = "RembolsoLabel"
        RembolsoLabel.Size = New System.Drawing.Size(84, 13)
        RembolsoLabel.TabIndex = 16
        RembolsoLabel.Text = "Rembolso Total:"
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(17, 47)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(51, 13)
        AlmacenLabel.TabIndex = 2
        AlmacenLabel.Text = "Almacen:"
        '
        'TipoLabel1
        '
        TipoLabel1.AutoSize = True
        TipoLabel1.Location = New System.Drawing.Point(37, 20)
        TipoLabel1.Name = "TipoLabel1"
        TipoLabel1.Size = New System.Drawing.Size(31, 13)
        TipoLabel1.TabIndex = 4
        TipoLabel1.Text = "Tipo:"
        '
        'CantidadLabel1
        '
        CantidadLabel1.AutoSize = True
        CantidadLabel1.Location = New System.Drawing.Point(16, 97)
        CantidadLabel1.Name = "CantidadLabel1"
        CantidadLabel1.Size = New System.Drawing.Size(52, 13)
        CantidadLabel1.TabIndex = 6
        CantidadLabel1.Text = "Cantidad:"
        '
        'TallaLabel
        '
        TallaLabel.AutoSize = True
        TallaLabel.Location = New System.Drawing.Point(33, 123)
        TallaLabel.Name = "TallaLabel"
        TallaLabel.Size = New System.Drawing.Size(33, 13)
        TallaLabel.TabIndex = 8
        TallaLabel.Text = "Talla:"
        '
        'EstiloLabel2
        '
        EstiloLabel2.AutoSize = True
        EstiloLabel2.Location = New System.Drawing.Point(31, 150)
        EstiloLabel2.Name = "EstiloLabel2"
        EstiloLabel2.Size = New System.Drawing.Size(35, 13)
        EstiloLabel2.TabIndex = 10
        EstiloLabel2.Text = "Estilo:"
        '
        'EstadoLabel4
        '
        EstadoLabel4.AutoSize = True
        EstadoLabel4.Location = New System.Drawing.Point(25, 71)
        EstadoLabel4.Name = "EstadoLabel4"
        EstadoLabel4.Size = New System.Drawing.Size(43, 13)
        EstadoLabel4.TabIndex = 12
        EstadoLabel4.Text = "Estado:"
        '
        'TallaLabel2
        '
        TallaLabel2.AutoSize = True
        TallaLabel2.Location = New System.Drawing.Point(64, 109)
        TallaLabel2.Name = "TallaLabel2"
        TallaLabel2.Size = New System.Drawing.Size(33, 13)
        TallaLabel2.TabIndex = 67
        TallaLabel2.Text = "Talla:"
        '
        'TallaLabel3
        '
        TallaLabel3.AutoSize = True
        TallaLabel3.Location = New System.Drawing.Point(53, 79)
        TallaLabel3.Name = "TallaLabel3"
        TallaLabel3.Size = New System.Drawing.Size(33, 13)
        TallaLabel3.TabIndex = 18
        TallaLabel3.Text = "Talla:"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Location = New System.Drawing.Point(53, 98)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(33, 13)
        Label30.TabIndex = 18
        Label30.Text = "Talla:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(0, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(965, 642)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.UniformesDataGridView)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(957, 616)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar / Agregar"
        '
        'UniformesDataGridView
        '
        Me.UniformesDataGridView.AllowUserToDeleteRows = False
        Me.UniformesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UniformesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.UniformesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.UniformesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.UniformesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UniformesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UniformesDataGridView.Location = New System.Drawing.Point(0, 238)
        Me.UniformesDataGridView.Name = "UniformesDataGridView"
        Me.UniformesDataGridView.ReadOnly = True
        Me.UniformesDataGridView.RowHeadersVisible = False
        Me.UniformesDataGridView.Size = New System.Drawing.Size(954, 375)
        Me.UniformesDataGridView.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox15)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(945, 226)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Uniforme"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.GroupBox1)
        Me.GroupBox15.Controls.Add(Me.Cmd_Limpiar)
        Me.GroupBox15.Controls.Add(Me.GroupBox3)
        Me.GroupBox15.Controls.Add(Me.Cmd_RegistrarUniforme)
        Me.GroupBox15.Controls.Add(TallaLabel2)
        Me.GroupBox15.Controls.Add(Me.CmdAgregarUniforme)
        Me.GroupBox15.Controls.Add(Me.Cmb_TipoUniforme)
        Me.GroupBox15.Controls.Add(Me.Cmb_EstadoUniforme)
        Me.GroupBox15.Controls.Add(Me.TallaTextBox2)
        Me.GroupBox15.Controls.Add(Label24)
        Me.GroupBox15.Controls.Add(Me.Label5)
        Me.GroupBox15.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox15.Controls.Add(Me.IduniformeTextBox)
        Me.GroupBox15.Controls.Add(EstiloLabel)
        Me.GroupBox15.Controls.Add(IduniformeLabel1)
        Me.GroupBox15.Controls.Add(EstadoLabel)
        Me.GroupBox15.Controls.Add(Me.EstiloTextBox)
        Me.GroupBox15.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(777, 200)
        Me.GroupBox15.TabIndex = 68
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Uniformes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_RUIalm)
        Me.GroupBox1.Controls.Add(Me.Cmb_RUalm)
        Me.GroupBox1.Location = New System.Drawing.Point(371, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 87)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacen"
        '
        'Cmb_RUIalm
        '
        Me.Cmb_RUIalm.Enabled = False
        Me.Cmb_RUIalm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_RUIalm.FormattingEnabled = True
        Me.Cmb_RUIalm.Location = New System.Drawing.Point(16, 46)
        Me.Cmb_RUIalm.Name = "Cmb_RUIalm"
        Me.Cmb_RUIalm.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_RUIalm.TabIndex = 1
        '
        'Cmb_RUalm
        '
        Me.Cmb_RUalm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_RUalm.FormattingEnabled = True
        Me.Cmb_RUalm.Location = New System.Drawing.Point(16, 19)
        Me.Cmb_RUalm.Name = "Cmb_RUalm"
        Me.Cmb_RUalm.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_RUalm.TabIndex = 0
        '
        'Cmd_Limpiar
        '
        Me.Cmd_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmd_Limpiar.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Limpiar.FlatAppearance.BorderSize = 0
        Me.Cmd_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Limpiar.Location = New System.Drawing.Point(414, 161)
        Me.Cmd_Limpiar.Name = "Cmd_Limpiar"
        Me.Cmd_Limpiar.Size = New System.Drawing.Size(88, 33)
        Me.Cmd_Limpiar.TabIndex = 38
        Me.Cmd_Limpiar.Text = "Limpiar"
        Me.Cmd_Limpiar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CantFinal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.CantUniforme)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.CantInicial)
        Me.GroupBox3.Location = New System.Drawing.Point(533, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 108)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cantidades"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Inventario Final:"
        '
        'CantFinal
        '
        Me.CantFinal.Location = New System.Drawing.Point(107, 67)
        Me.CantFinal.Name = "CantFinal"
        Me.CantFinal.ReadOnly = True
        Me.CantFinal.Size = New System.Drawing.Size(79, 20)
        Me.CantFinal.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cant Ingresar:"
        '
        'CantUniforme
        '
        Me.CantUniforme.Location = New System.Drawing.Point(107, 41)
        Me.CantUniforme.Name = "CantUniforme"
        Me.CantUniforme.Size = New System.Drawing.Size(79, 20)
        Me.CantUniforme.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cant Actual:"
        '
        'CantInicial
        '
        Me.CantInicial.Location = New System.Drawing.Point(107, 15)
        Me.CantInicial.Name = "CantInicial"
        Me.CantInicial.ReadOnly = True
        Me.CantInicial.Size = New System.Drawing.Size(79, 20)
        Me.CantInicial.TabIndex = 12
        '
        'Cmd_RegistrarUniforme
        '
        Me.Cmd_RegistrarUniforme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmd_RegistrarUniforme.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_RegistrarUniforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_RegistrarUniforme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_RegistrarUniforme.FlatAppearance.BorderSize = 0
        Me.Cmd_RegistrarUniforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_RegistrarUniforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_RegistrarUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_RegistrarUniforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_RegistrarUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_RegistrarUniforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_RegistrarUniforme.Location = New System.Drawing.Point(505, 161)
        Me.Cmd_RegistrarUniforme.Name = "Cmd_RegistrarUniforme"
        Me.Cmd_RegistrarUniforme.Size = New System.Drawing.Size(117, 33)
        Me.Cmd_RegistrarUniforme.TabIndex = 35
        Me.Cmd_RegistrarUniforme.Text = "Registrar"
        Me.Cmd_RegistrarUniforme.UseVisualStyleBackColor = False
        '
        'CmdAgregarUniforme
        '
        Me.CmdAgregarUniforme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmdAgregarUniforme.BackColor = System.Drawing.Color.SteelBlue
        Me.CmdAgregarUniforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdAgregarUniforme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdAgregarUniforme.FlatAppearance.BorderSize = 0
        Me.CmdAgregarUniforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdAgregarUniforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdAgregarUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAgregarUniforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAgregarUniforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CmdAgregarUniforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAgregarUniforme.Location = New System.Drawing.Point(625, 161)
        Me.CmdAgregarUniforme.Name = "CmdAgregarUniforme"
        Me.CmdAgregarUniforme.Size = New System.Drawing.Size(124, 33)
        Me.CmdAgregarUniforme.TabIndex = 33
        Me.CmdAgregarUniforme.Text = "Cargar / Agregar"
        Me.CmdAgregarUniforme.UseVisualStyleBackColor = False
        '
        'Cmb_TipoUniforme
        '
        Me.Cmb_TipoUniforme.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "tipo", True))
        Me.Cmb_TipoUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_TipoUniforme.FormattingEnabled = True
        Me.Cmb_TipoUniforme.Items.AddRange(New Object() {"Pantalon", "Camisa", "Camisa Centro", "Ligas", "Gorra", "Calzado", "Faja"})
        Me.Cmb_TipoUniforme.Location = New System.Drawing.Point(104, 25)
        Me.Cmb_TipoUniforme.Name = "Cmb_TipoUniforme"
        Me.Cmb_TipoUniforme.Size = New System.Drawing.Size(204, 21)
        Me.Cmb_TipoUniforme.TabIndex = 67
        '
        'DetalleSolicitudBindingSource
        '
        Me.DetalleSolicitudBindingSource.DataMember = "DetalleSolicitud"
        Me.DetalleSolicitudBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cmb_EstadoUniforme
        '
        Me.Cmb_EstadoUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_EstadoUniforme.FormattingEnabled = True
        Me.Cmb_EstadoUniforme.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Cmb_EstadoUniforme.Location = New System.Drawing.Point(105, 82)
        Me.Cmb_EstadoUniforme.Name = "Cmb_EstadoUniforme"
        Me.Cmb_EstadoUniforme.Size = New System.Drawing.Size(178, 21)
        Me.Cmb_EstadoUniforme.TabIndex = 65
        '
        'TallaTextBox2
        '
        Me.TallaTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UniformesBindingSource, "talla", True))
        Me.TallaTextBox2.Location = New System.Drawing.Point(104, 109)
        Me.TallaTextBox2.Name = "TallaTextBox2"
        Me.TallaTextBox2.Size = New System.Drawing.Size(183, 20)
        Me.TallaTextBox2.TabIndex = 68
        '
        'UniformesBindingSource
        '
        Me.UniformesBindingSource.DataMember = "Uniformes"
        Me.UniformesBindingSource.DataSource = Me.ABASDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fecha Registro:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(104, 135)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'IduniformeTextBox
        '
        Me.IduniformeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UniformesBindingSource, "iduniforme", True))
        Me.IduniformeTextBox.Location = New System.Drawing.Point(104, 160)
        Me.IduniformeTextBox.Name = "IduniformeTextBox"
        Me.IduniformeTextBox.ReadOnly = True
        Me.IduniformeTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IduniformeTextBox.TabIndex = 8
        '
        'EstiloTextBox
        '
        Me.EstiloTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EstiloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UniformesBindingSource, "estilo", True))
        Me.EstiloTextBox.Location = New System.Drawing.Point(104, 52)
        Me.EstiloTextBox.Name = "EstiloTextBox"
        Me.EstiloTextBox.Size = New System.Drawing.Size(240, 20)
        Me.EstiloTextBox.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.GroupBox10)
        Me.TabPage2.Controls.Add(Me.MovimientoUniformesDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(957, 616)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transferir / Recibir"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Cmd_Recibir)
        Me.Panel1.Location = New System.Drawing.Point(189, 180)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 259)
        Me.Panel1.TabIndex = 54
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Label30)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.TextBox3)
        Me.GroupBox9.Controls.Add(Me.EstiloRecibe)
        Me.GroupBox9.Controls.Add(Label23)
        Me.GroupBox9.Controls.Add(Label12)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.DescripcionRecibe)
        Me.GroupBox9.Controls.Add(Me.IdMov)
        Me.GroupBox9.Controls.Add(Label25)
        Me.GroupBox9.Controls.Add(Me.EstadoRecibe)
        Me.GroupBox9.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox9.Controls.Add(Me.ComboBox7)
        Me.GroupBox9.Controls.Add(Me.ComboRecibe)
        Me.GroupBox9.Controls.Add(Label18)
        Me.GroupBox9.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(309, 234)
        Me.GroupBox9.TabIndex = 61
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Datos del Envio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Fecha Recibe:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(94, 93)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 19
        '
        'EstiloRecibe
        '
        Me.EstiloRecibe.Location = New System.Drawing.Point(94, 149)
        Me.EstiloRecibe.Name = "EstiloRecibe"
        Me.EstiloRecibe.ReadOnly = True
        Me.EstiloRecibe.Size = New System.Drawing.Size(100, 20)
        Me.EstiloRecibe.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(37, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Almacen:"
        '
        'DescripcionRecibe
        '
        Me.DescripcionRecibe.Location = New System.Drawing.Point(94, 40)
        Me.DescripcionRecibe.Name = "DescripcionRecibe"
        Me.DescripcionRecibe.ReadOnly = True
        Me.DescripcionRecibe.Size = New System.Drawing.Size(208, 20)
        Me.DescripcionRecibe.TabIndex = 12
        '
        'IdMov
        '
        Me.IdMov.Location = New System.Drawing.Point(94, 175)
        Me.IdMov.Name = "IdMov"
        Me.IdMov.ReadOnly = True
        Me.IdMov.Size = New System.Drawing.Size(100, 20)
        Me.IdMov.TabIndex = 13
        '
        'EstadoRecibe
        '
        Me.EstadoRecibe.Location = New System.Drawing.Point(94, 123)
        Me.EstadoRecibe.Name = "EstadoRecibe"
        Me.EstadoRecibe.ReadOnly = True
        Me.EstadoRecibe.Size = New System.Drawing.Size(100, 20)
        Me.EstadoRecibe.TabIndex = 17
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(94, 14)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker3.TabIndex = 56
        '
        'ComboBox7
        '
        Me.ComboBox7.Enabled = False
        Me.ComboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox7.Location = New System.Drawing.Point(227, 66)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(73, 21)
        Me.ComboBox7.TabIndex = 58
        '
        'ComboRecibe
        '
        Me.ComboRecibe.Enabled = False
        Me.ComboRecibe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboRecibe.FormattingEnabled = True
        Me.ComboRecibe.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboRecibe.Location = New System.Drawing.Point(94, 66)
        Me.ComboRecibe.Name = "ComboRecibe"
        Me.ComboRecibe.Size = New System.Drawing.Size(127, 21)
        Me.ComboRecibe.TabIndex = 58
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.TextBox9)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.CantRecibe)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.TextBox11)
        Me.GroupBox4.Location = New System.Drawing.Point(332, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 133)
        Me.GroupBox4.TabIndex = 60
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cantidad Recibe"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Cant Final:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(85, 70)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Cant Recibir:"
        '
        'CantRecibe
        '
        Me.CantRecibe.Location = New System.Drawing.Point(85, 45)
        Me.CantRecibe.Name = "CantRecibe"
        Me.CantRecibe.ReadOnly = True
        Me.CantRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantRecibe.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Cant Actual:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(85, 20)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 12
        '
        'Cmd_Recibir
        '
        Me.Cmd_Recibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cmd_Recibir.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_Recibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Recibir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Recibir.FlatAppearance.BorderSize = 0
        Me.Cmd_Recibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_Recibir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_Recibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Recibir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Recibir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_Recibir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Recibir.Location = New System.Drawing.Point(332, 210)
        Me.Cmd_Recibir.Name = "Cmd_Recibir"
        Me.Cmd_Recibir.Size = New System.Drawing.Size(208, 33)
        Me.Cmd_Recibir.TabIndex = 55
        Me.Cmd_Recibir.Text = "Aceptar / Recibir"
        Me.Cmd_Recibir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(127, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(685, 278)
        Me.DataGridView1.TabIndex = 10
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.Cmd_Nuevo)
        Me.GroupBox10.Controls.Add(Me.Cmd_Transferir)
        Me.GroupBox10.Controls.Add(Me.GroupBox8)
        Me.GroupBox10.Controls.Add(Me.GroupBox5)
        Me.GroupBox10.Controls.Add(Me.GroupBox7)
        Me.GroupBox10.Controls.Add(Me.GroupBox6)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(943, 216)
        Me.GroupBox10.TabIndex = 55
        Me.GroupBox10.TabStop = False
        '
        'Cmd_Nuevo
        '
        Me.Cmd_Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cmd_Nuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Nuevo.FlatAppearance.BorderSize = 0
        Me.Cmd_Nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Nuevo.Location = New System.Drawing.Point(7, 177)
        Me.Cmd_Nuevo.Name = "Cmd_Nuevo"
        Me.Cmd_Nuevo.Size = New System.Drawing.Size(88, 33)
        Me.Cmd_Nuevo.TabIndex = 40
        Me.Cmd_Nuevo.Text = "Nuevo"
        Me.Cmd_Nuevo.UseVisualStyleBackColor = False
        '
        'Cmd_Transferir
        '
        Me.Cmd_Transferir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cmd_Transferir.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_Transferir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Transferir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Transferir.FlatAppearance.BorderSize = 0
        Me.Cmd_Transferir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_Transferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_Transferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Transferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Transferir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_Transferir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Transferir.Location = New System.Drawing.Point(101, 177)
        Me.Cmd_Transferir.Name = "Cmd_Transferir"
        Me.Cmd_Transferir.Size = New System.Drawing.Size(88, 33)
        Me.Cmd_Transferir.TabIndex = 39
        Me.Cmd_Transferir.Text = "Transferir"
        Me.Cmd_Transferir.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.CantFinRecibe)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.CantMovRecibe)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.CantIniRecibe)
        Me.GroupBox8.Location = New System.Drawing.Point(731, 15)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox8.TabIndex = 18
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cantidad Recibe"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Cant Final:"
        '
        'CantFinRecibe
        '
        Me.CantFinRecibe.Location = New System.Drawing.Point(85, 70)
        Me.CantFinRecibe.Name = "CantFinRecibe"
        Me.CantFinRecibe.ReadOnly = True
        Me.CantFinRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantFinRecibe.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Cant Mover:"
        '
        'CantMovRecibe
        '
        Me.CantMovRecibe.Location = New System.Drawing.Point(85, 45)
        Me.CantMovRecibe.Name = "CantMovRecibe"
        Me.CantMovRecibe.ReadOnly = True
        Me.CantMovRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantMovRecibe.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Cant Actual:"
        '
        'CantIniRecibe
        '
        Me.CantIniRecibe.Location = New System.Drawing.Point(85, 20)
        Me.CantIniRecibe.Name = "CantIniRecibe"
        Me.CantIniRecibe.ReadOnly = True
        Me.CantIniRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantIniRecibe.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.FechaMovimiento)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.ComboBox6)
        Me.GroupBox5.Controls.Add(Me.ComboHacia)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.ComboBox5)
        Me.GroupBox5.Controls.Add(Me.ComboDesde)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 131)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Almacenes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Fecha Movimiento:"
        '
        'FechaMovimiento
        '
        Me.FechaMovimiento.CustomFormat = "dd-MM-yyyy"
        Me.FechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaMovimiento.Location = New System.Drawing.Point(109, 76)
        Me.FechaMovimiento.Name = "FechaMovimiento"
        Me.FechaMovimiento.Size = New System.Drawing.Size(121, 20)
        Me.FechaMovimiento.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Hacia:"
        '
        'ComboBox6
        '
        Me.ComboBox6.Enabled = False
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox6.Location = New System.Drawing.Point(167, 44)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox6.TabIndex = 2
        '
        'ComboHacia
        '
        Me.ComboHacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboHacia.FormattingEnabled = True
        Me.ComboHacia.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboHacia.Location = New System.Drawing.Point(63, 45)
        Me.ComboHacia.Name = "ComboHacia"
        Me.ComboHacia.Size = New System.Drawing.Size(100, 21)
        Me.ComboHacia.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Desde:"
        '
        'ComboBox5
        '
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox5.Location = New System.Drawing.Point(167, 18)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox5.TabIndex = 0
        '
        'ComboDesde
        '
        Me.ComboDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboDesde.FormattingEnabled = True
        Me.ComboDesde.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboDesde.Location = New System.Drawing.Point(63, 19)
        Me.ComboDesde.Name = "ComboDesde"
        Me.ComboDesde.Size = New System.Drawing.Size(100, 21)
        Me.ComboDesde.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(TallaLabel3)
        Me.GroupBox7.Controls.Add(Me.TallaTextBox3)
        Me.GroupBox7.Controls.Add(Me.PictureBox2)
        Me.GroupBox7.Controls.Add(Me.EstiloEnvia)
        Me.GroupBox7.Controls.Add(Label22)
        Me.GroupBox7.Controls.Add(Me.EstadoMovimiento)
        Me.GroupBox7.Controls.Add(EstadoLabel1)
        Me.GroupBox7.Controls.Add(Me.DescripcionMovimiento)
        Me.GroupBox7.Controls.Add(DescripcionLabel1)
        Me.GroupBox7.Controls.Add(Me.IduniformeMovimiento)
        Me.GroupBox7.Controls.Add(IduniformeLabel)
        Me.GroupBox7.Location = New System.Drawing.Point(259, 15)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(257, 163)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Detalle Movimiento"
        '
        'TallaTextBox3
        '
        Me.TallaTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UniformesBindingSource, "talla", True))
        Me.TallaTextBox3.Location = New System.Drawing.Point(94, 74)
        Me.TallaTextBox3.Name = "TallaTextBox3"
        Me.TallaTextBox3.ReadOnly = True
        Me.TallaTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TallaTextBox3.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(223, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'EstiloEnvia
        '
        Me.EstiloEnvia.Location = New System.Drawing.Point(94, 127)
        Me.EstiloEnvia.Name = "EstiloEnvia"
        Me.EstiloEnvia.ReadOnly = True
        Me.EstiloEnvia.Size = New System.Drawing.Size(100, 20)
        Me.EstiloEnvia.TabIndex = 17
        '
        'EstadoMovimiento
        '
        Me.EstadoMovimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovimientoUniformesBindingSource, "estado", True))
        Me.EstadoMovimiento.Location = New System.Drawing.Point(94, 101)
        Me.EstadoMovimiento.Name = "EstadoMovimiento"
        Me.EstadoMovimiento.ReadOnly = True
        Me.EstadoMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.EstadoMovimiento.TabIndex = 17
        '
        'MovimientoUniformesBindingSource
        '
        Me.MovimientoUniformesBindingSource.DataMember = "MovimientoUniformes"
        Me.MovimientoUniformesBindingSource.DataSource = Me.ABASDataSet
        '
        'DescripcionMovimiento
        '
        Me.DescripcionMovimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovimientoUniformesBindingSource, "descripcion", True))
        Me.DescripcionMovimiento.Location = New System.Drawing.Point(94, 22)
        Me.DescripcionMovimiento.Name = "DescripcionMovimiento"
        Me.DescripcionMovimiento.ReadOnly = True
        Me.DescripcionMovimiento.Size = New System.Drawing.Size(150, 20)
        Me.DescripcionMovimiento.TabIndex = 12
        '
        'IduniformeMovimiento
        '
        Me.IduniformeMovimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovimientoUniformesBindingSource, "iduniforme", True))
        Me.IduniformeMovimiento.Location = New System.Drawing.Point(94, 48)
        Me.IduniformeMovimiento.Name = "IduniformeMovimiento"
        Me.IduniformeMovimiento.ReadOnly = True
        Me.IduniformeMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.IduniformeMovimiento.TabIndex = 13
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.CantFinalEnvia)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.CantMoverEnvia)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.CantIniEnvia)
        Me.GroupBox6.Location = New System.Drawing.Point(522, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cantidad Envia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cant Final:"
        '
        'CantFinalEnvia
        '
        Me.CantFinalEnvia.Location = New System.Drawing.Point(85, 70)
        Me.CantFinalEnvia.Name = "CantFinalEnvia"
        Me.CantFinalEnvia.ReadOnly = True
        Me.CantFinalEnvia.Size = New System.Drawing.Size(100, 20)
        Me.CantFinalEnvia.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cant Mover:"
        '
        'CantMoverEnvia
        '
        Me.CantMoverEnvia.Location = New System.Drawing.Point(85, 45)
        Me.CantMoverEnvia.Name = "CantMoverEnvia"
        Me.CantMoverEnvia.Size = New System.Drawing.Size(100, 20)
        Me.CantMoverEnvia.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cant Actual:"
        '
        'CantIniEnvia
        '
        Me.CantIniEnvia.Location = New System.Drawing.Point(85, 20)
        Me.CantIniEnvia.Name = "CantIniEnvia"
        Me.CantIniEnvia.ReadOnly = True
        Me.CantIniEnvia.Size = New System.Drawing.Size(100, 20)
        Me.CantIniEnvia.TabIndex = 12
        '
        'MovimientoUniformesDataGridView
        '
        Me.MovimientoUniformesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovimientoUniformesDataGridView.AutoGenerateColumns = False
        Me.MovimientoUniformesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MovimientoUniformesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MovimientoUniformesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.MovimientoUniformesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MovimientoUniformesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovimientoUniformesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.recibe_mov, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.MovimientoUniformesDataGridView.DataSource = Me.MovimientoUniformesBindingSource
        Me.MovimientoUniformesDataGridView.Location = New System.Drawing.Point(3, 233)
        Me.MovimientoUniformesDataGridView.Name = "MovimientoUniformesDataGridView"
        Me.MovimientoUniformesDataGridView.RowHeadersVisible = False
        Me.MovimientoUniformesDataGridView.Size = New System.Drawing.Size(951, 377)
        Me.MovimientoUniformesDataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "idmov_uniforme"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ID Movimiento"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 92
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 88
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "iduniforme"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID Uniforme"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 81
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "cant"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 74
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "fechamov"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Fecha Movimiento"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 109
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "almacen"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 73
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 65
        '
        'recibe_mov
        '
        Me.recibe_mov.DataPropertyName = "recibe_mov"
        Me.recibe_mov.HeaderText = "Recibe"
        Me.recibe_mov.Name = "recibe_mov"
        Me.recibe_mov.Width = 66
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "estilo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Estilo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 57
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "talla"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Talla"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.GroupBox12)
        Me.TabPage5.Controls.Add(Me.GroupBox11)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(957, 616)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Asignar Uniforme"
        '
        'GroupBox12
        '
        Me.GroupBox12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox12.Controls.Add(Me.DetalleSolicitudDataGridView)
        Me.GroupBox12.Controls.Add(Me.GroupBox14)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 151)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(945, 462)
        Me.GroupBox12.TabIndex = 99
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Detalle de Solicitud"
        '
        'DetalleSolicitudDataGridView
        '
        Me.DetalleSolicitudDataGridView.AllowUserToDeleteRows = False
        Me.DetalleSolicitudDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleSolicitudDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DetalleSolicitudDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DetalleSolicitudDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DetalleSolicitudDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetalleSolicitudDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleSolicitudDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSolicitudDetalle, Me.IdUniformeDetalle, Me.Tipo, Me.CantidadDetalle, Me.Valor, Me.Talla, Me.EstiloDetalle, Me.EstadoDetalle, Me.AlmacenDetalle})
        Me.DetalleSolicitudDataGridView.Location = New System.Drawing.Point(0, 188)
        Me.DetalleSolicitudDataGridView.Name = "DetalleSolicitudDataGridView"
        Me.DetalleSolicitudDataGridView.ReadOnly = True
        Me.DetalleSolicitudDataGridView.RowHeadersVisible = False
        Me.DetalleSolicitudDataGridView.Size = New System.Drawing.Size(945, 271)
        Me.DetalleSolicitudDataGridView.TabIndex = 0
        '
        'IDSolicitudDetalle
        '
        Me.IDSolicitudDetalle.DataPropertyName = "IDSolicitudDetalle"
        Me.IDSolicitudDetalle.HeaderText = "ID Solicitud"
        Me.IDSolicitudDetalle.Name = "IDSolicitudDetalle"
        Me.IDSolicitudDetalle.ReadOnly = True
        Me.IDSolicitudDetalle.Width = 86
        '
        'IdUniformeDetalle
        '
        Me.IdUniformeDetalle.DataPropertyName = "IdUniformeDetalle"
        Me.IdUniformeDetalle.HeaderText = "ID Uniforme"
        Me.IdUniformeDetalle.Name = "IdUniformeDetalle"
        Me.IdUniformeDetalle.ReadOnly = True
        Me.IdUniformeDetalle.Width = 88
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 53
        '
        'CantidadDetalle
        '
        Me.CantidadDetalle.DataPropertyName = "CantidadDetalle"
        Me.CantidadDetalle.HeaderText = "Cantidad"
        Me.CantidadDetalle.Name = "CantidadDetalle"
        Me.CantidadDetalle.ReadOnly = True
        Me.CantidadDetalle.Width = 74
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "Valor"
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 56
        '
        'Talla
        '
        Me.Talla.DataPropertyName = "Talla"
        Me.Talla.HeaderText = "Talla"
        Me.Talla.Name = "Talla"
        Me.Talla.ReadOnly = True
        Me.Talla.Width = 55
        '
        'EstiloDetalle
        '
        Me.EstiloDetalle.DataPropertyName = "EstiloDetalle"
        Me.EstiloDetalle.HeaderText = "Estilo"
        Me.EstiloDetalle.Name = "EstiloDetalle"
        Me.EstiloDetalle.ReadOnly = True
        Me.EstiloDetalle.Width = 57
        '
        'EstadoDetalle
        '
        Me.EstadoDetalle.DataPropertyName = "EstadoDetalle"
        Me.EstadoDetalle.HeaderText = "Estado"
        Me.EstadoDetalle.Name = "EstadoDetalle"
        Me.EstadoDetalle.ReadOnly = True
        Me.EstadoDetalle.Width = 65
        '
        'AlmacenDetalle
        '
        Me.AlmacenDetalle.DataPropertyName = "AlmacenDetalle"
        Me.AlmacenDetalle.HeaderText = "Almacen"
        Me.AlmacenDetalle.Name = "AlmacenDetalle"
        Me.AlmacenDetalle.ReadOnly = True
        Me.AlmacenDetalle.Width = 73
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.Controls.Add(Me.GroupBox13)
        Me.GroupBox14.Controls.Add(Me.Cmd_ImprimirSolicitud)
        Me.GroupBox14.Controls.Add(Me.Txt_TotalPagar)
        Me.GroupBox14.Controls.Add(Label29)
        Me.GroupBox14.Controls.Add(Me.Label28)
        Me.GroupBox14.Controls.Add(Me.ComboBox8)
        Me.GroupBox14.Controls.Add(Me.ComboBox2)
        Me.GroupBox14.Controls.Add(Me.TipoComboBox)
        Me.GroupBox14.Controls.Add(Me.Button4)
        Me.GroupBox14.Controls.Add(TipoLabel)
        Me.GroupBox14.Controls.Add(Me.Button3)
        Me.GroupBox14.Controls.Add(Me.TextBox1)
        Me.GroupBox14.Controls.Add(Me.TextBox2)
        Me.GroupBox14.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox14.Controls.Add(Label26)
        Me.GroupBox14.Controls.Add(Label27)
        Me.GroupBox14.Controls.Add(TallaLabel1)
        Me.GroupBox14.Controls.Add(CantidadLabel)
        Me.GroupBox14.Controls.Add(Me.TallaTextBox)
        Me.GroupBox14.Controls.Add(Me.EstiloTextBox1)
        Me.GroupBox14.Controls.Add(ValorLabel)
        Me.GroupBox14.Controls.Add(EstiloLabel1)
        Me.GroupBox14.Controls.Add(Me.ValorTextBox)
        Me.GroupBox14.Controls.Add(Me.EstadoComboBox)
        Me.GroupBox14.Controls.Add(EstadoLabel2)
        Me.GroupBox14.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(933, 163)
        Me.GroupBox14.TabIndex = 46
        Me.GroupBox14.TabStop = False
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.DataGridView2)
        Me.GroupBox13.Location = New System.Drawing.Point(578, 19)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(349, 135)
        Me.GroupBox13.TabIndex = 100
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Formas de Pago * Solo numeros sin comas"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSolicitudUniforme, Me.EstadoFormaDePago, Me.Veces, Me.Cantidad})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(343, 116)
        Me.DataGridView2.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.DataGridView2, "Solo se permite ingresar numero sin comas, ni letras")
        '
        'IDSolicitudUniforme
        '
        Me.IDSolicitudUniforme.HeaderText = "ID Solicitud"
        Me.IDSolicitudUniforme.Name = "IDSolicitudUniforme"
        Me.IDSolicitudUniforme.ReadOnly = True
        Me.IDSolicitudUniforme.Width = 86
        '
        'EstadoFormaDePago
        '
        Me.EstadoFormaDePago.HeaderText = "Estado"
        Me.EstadoFormaDePago.Name = "EstadoFormaDePago"
        Me.EstadoFormaDePago.ReadOnly = True
        Me.EstadoFormaDePago.Width = 65
        '
        'Veces
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Veces.DefaultCellStyle = DataGridViewCellStyle1
        Me.Veces.HeaderText = "Veces"
        Me.Veces.Name = "Veces"
        Me.Veces.ToolTipText = "Cantidad de Pagos"
        Me.Veces.Width = 62
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ToolTipText = "Cantidad en Lempiras"
        Me.Cantidad.Width = 74
        '
        'Cmd_ImprimirSolicitud
        '
        Me.Cmd_ImprimirSolicitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cmd_ImprimirSolicitud.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Print_48px_2
        Me.Cmd_ImprimirSolicitud.Location = New System.Drawing.Point(166, 125)
        Me.Cmd_ImprimirSolicitud.Name = "Cmd_ImprimirSolicitud"
        Me.Cmd_ImprimirSolicitud.Size = New System.Drawing.Size(35, 29)
        Me.Cmd_ImprimirSolicitud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cmd_ImprimirSolicitud.TabIndex = 54
        Me.Cmd_ImprimirSolicitud.TabStop = False
        '
        'Txt_TotalPagar
        '
        Me.Txt_TotalPagar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "valor", True))
        Me.Txt_TotalPagar.Location = New System.Drawing.Point(372, 125)
        Me.Txt_TotalPagar.Multiline = True
        Me.Txt_TotalPagar.Name = "Txt_TotalPagar"
        Me.Txt_TotalPagar.ReadOnly = True
        Me.Txt_TotalPagar.Size = New System.Drawing.Size(101, 23)
        Me.Txt_TotalPagar.TabIndex = 55
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(315, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Almacen:"
        '
        'ComboBox8
        '
        Me.ComboBox8.Enabled = False
        Me.ComboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox8.Location = New System.Drawing.Point(505, 20)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox8.TabIndex = 46
        '
        'ComboBox2
        '
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox2.Location = New System.Drawing.Point(372, 20)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox2.TabIndex = 46
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "tipo", True))
        Me.TipoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Items.AddRange(New Object() {"Pantalon", "Camisa", "Camisa Centro", "Ligas", "Gorra", "Calzado", "Faja"})
        Me.TipoComboBox.Location = New System.Drawing.Point(88, 19)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(183, 21)
        Me.TipoComboBox.TabIndex = 2
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
        Me.Button4.Location = New System.Drawing.Point(89, 125)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 29)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Button3.Location = New System.Drawing.Point(13, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 29)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Insertar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(372, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(505, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(61, 20)
        Me.TextBox2.TabIndex = 4
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(372, 71)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(84, 20)
        Me.CantidadTextBox.TabIndex = 4
        '
        'TallaTextBox
        '
        Me.TallaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "talla", True))
        Me.TallaTextBox.Location = New System.Drawing.Point(88, 71)
        Me.TallaTextBox.Name = "TallaTextBox"
        Me.TallaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TallaTextBox.TabIndex = 13
        '
        'EstiloTextBox1
        '
        Me.EstiloTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "estilo", True))
        Me.EstiloTextBox1.Location = New System.Drawing.Point(88, 96)
        Me.EstiloTextBox1.Name = "EstiloTextBox1"
        Me.EstiloTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.EstiloTextBox1.TabIndex = 8
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(372, 100)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(84, 20)
        Me.ValorTextBox.TabIndex = 12
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleSolicitudBindingSource, "estado", True))
        Me.EstadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"A", "B", "C"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(88, 45)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EstadoComboBox.TabIndex = 10
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Cmd_CancelarSolicitud)
        Me.GroupBox11.Controls.Add(Me.Cmd_NuevaSolicitud)
        Me.GroupBox11.Controls.Add(Me.PictureBox3)
        Me.GroupBox11.Controls.Add(Me.IdsolicitudTextBox)
        Me.GroupBox11.Controls.Add(IdsolicitudLabel)
        Me.GroupBox11.Controls.Add(Me.Cmd_CrearSolicitud)
        Me.GroupBox11.Controls.Add(CodigoLabel)
        Me.GroupBox11.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox11.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox11.Controls.Add(FechaLabel)
        Me.GroupBox11.Controls.Add(Me.EntregaTextBox)
        Me.GroupBox11.Controls.Add(EntregaLabel)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(386, 139)
        Me.GroupBox11.TabIndex = 42
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Solicitud de Uniforme"
        '
        'Cmd_CancelarSolicitud
        '
        Me.Cmd_CancelarSolicitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cmd_CancelarSolicitud.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_CancelarSolicitud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_CancelarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_CancelarSolicitud.FlatAppearance.BorderSize = 0
        Me.Cmd_CancelarSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_CancelarSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_CancelarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_CancelarSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_CancelarSolicitud.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_CancelarSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_CancelarSolicitud.Location = New System.Drawing.Point(239, 96)
        Me.Cmd_CancelarSolicitud.Name = "Cmd_CancelarSolicitud"
        Me.Cmd_CancelarSolicitud.Size = New System.Drawing.Size(121, 33)
        Me.Cmd_CancelarSolicitud.TabIndex = 44
        Me.Cmd_CancelarSolicitud.Text = "Cancelar Solicitud"
        Me.Cmd_CancelarSolicitud.UseVisualStyleBackColor = False
        '
        'Cmd_NuevaSolicitud
        '
        Me.Cmd_NuevaSolicitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cmd_NuevaSolicitud.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_NuevaSolicitud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_NuevaSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_NuevaSolicitud.FlatAppearance.BorderSize = 0
        Me.Cmd_NuevaSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_NuevaSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_NuevaSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_NuevaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_NuevaSolicitud.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_NuevaSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_NuevaSolicitud.Location = New System.Drawing.Point(32, 96)
        Me.Cmd_NuevaSolicitud.Name = "Cmd_NuevaSolicitud"
        Me.Cmd_NuevaSolicitud.Size = New System.Drawing.Size(74, 33)
        Me.Cmd_NuevaSolicitud.TabIndex = 43
        Me.Cmd_NuevaSolicitud.Text = "Nuevo"
        Me.Cmd_NuevaSolicitud.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox3.Location = New System.Drawing.Point(203, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'IdsolicitudTextBox
        '
        Me.IdsolicitudTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudUniformeBindingSource, "idsolicitud", True))
        Me.IdsolicitudTextBox.Location = New System.Drawing.Point(124, 67)
        Me.IdsolicitudTextBox.Name = "IdsolicitudTextBox"
        Me.IdsolicitudTextBox.ReadOnly = True
        Me.IdsolicitudTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdsolicitudTextBox.TabIndex = 1
        '
        'SolicitudUniformeBindingSource
        '
        Me.SolicitudUniformeBindingSource.DataMember = "SolicitudUniforme"
        Me.SolicitudUniformeBindingSource.DataSource = Me.ABASDataSet
        '
        'Cmd_CrearSolicitud
        '
        Me.Cmd_CrearSolicitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cmd_CrearSolicitud.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_CrearSolicitud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_CrearSolicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_CrearSolicitud.FlatAppearance.BorderSize = 0
        Me.Cmd_CrearSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cmd_CrearSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmd_CrearSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_CrearSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_CrearSolicitud.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_CrearSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_CrearSolicitud.Location = New System.Drawing.Point(112, 96)
        Me.Cmd_CrearSolicitud.Name = "Cmd_CrearSolicitud"
        Me.Cmd_CrearSolicitud.Size = New System.Drawing.Size(121, 33)
        Me.Cmd_CrearSolicitud.TabIndex = 41
        Me.Cmd_CrearSolicitud.Text = "Crear Solicitud"
        Me.Cmd_CrearSolicitud.UseVisualStyleBackColor = False
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SolicitudUniformeBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(124, 44)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechaDateTimePicker.TabIndex = 3
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudUniformeBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(124, 21)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 9
        '
        'EntregaTextBox
        '
        Me.EntregaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudUniformeBindingSource, "entrega", True))
        Me.EntregaTextBox.Location = New System.Drawing.Point(276, 21)
        Me.EntregaTextBox.Name = "EntregaTextBox"
        Me.EntregaTextBox.ReadOnly = True
        Me.EntregaTextBox.Size = New System.Drawing.Size(84, 20)
        Me.EntregaTextBox.TabIndex = 5
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage6.Controls.Add(Me.GroupBox16)
        Me.TabPage6.Controls.Add(Me.DevolucionUniformeDetalleDataGridView)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(957, 616)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Devolucion Uniforme"
        '
        'GroupBox16
        '
        Me.GroupBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox16.Controls.Add(Me.GroupBox18)
        Me.GroupBox16.Controls.Add(Me.GroupBox17)
        Me.GroupBox16.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(945, 316)
        Me.GroupBox16.TabIndex = 0
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Devolucion de Uniforme"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.PictureBox1)
        Me.GroupBox18.Controls.Add(Me.IddevolucionTextBox)
        Me.GroupBox18.Controls.Add(IddevolucionLabel)
        Me.GroupBox18.Controls.Add(RembolsoLabel)
        Me.GroupBox18.Controls.Add(CarnetLabel)
        Me.GroupBox18.Controls.Add(Me.RembolsoTextBox)
        Me.GroupBox18.Controls.Add(Me.Button6)
        Me.GroupBox18.Controls.Add(Me.Button1)
        Me.GroupBox18.Controls.Add(Me.CheckBox1)
        Me.GroupBox18.Controls.Add(Me.EstadoComboBox1)
        Me.GroupBox18.Controls.Add(Me.CheckBox2)
        Me.GroupBox18.Controls.Add(EstadoLabel3)
        Me.GroupBox18.Controls.Add(Me.CodigoTextBox1)
        Me.GroupBox18.Controls.Add(FechaLabel1)
        Me.GroupBox18.Controls.Add(CodigoLabel1)
        Me.GroupBox18.Controls.Add(Me.FechaDateTimePicker1)
        Me.GroupBox18.Controls.Add(Me.ObservacionTextBox)
        Me.GroupBox18.Controls.Add(RecibeLabel)
        Me.GroupBox18.Controls.Add(ObservacionLabel)
        Me.GroupBox18.Controls.Add(Me.RecibeTextBox)
        Me.GroupBox18.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(351, 291)
        Me.GroupBox18.TabIndex = 18
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Datos de Devolucion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(198, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'IddevolucionTextBox
        '
        Me.IddevolucionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeBindingSource, "iddevolucion", True))
        Me.IddevolucionTextBox.Location = New System.Drawing.Point(116, 16)
        Me.IddevolucionTextBox.Name = "IddevolucionTextBox"
        Me.IddevolucionTextBox.ReadOnly = True
        Me.IddevolucionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IddevolucionTextBox.TabIndex = 1
        '
        'DevolucionUniformeBindingSource
        '
        Me.DevolucionUniformeBindingSource.DataMember = "DevolucionUniforme"
        Me.DevolucionUniformeBindingSource.DataSource = Me.ABASDataSet
        '
        'RembolsoTextBox
        '
        Me.RembolsoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeBindingSource, "rembolso", True))
        Me.RembolsoTextBox.Location = New System.Drawing.Point(116, 147)
        Me.RembolsoTextBox.Name = "RembolsoTextBox"
        Me.RembolsoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RembolsoTextBox.TabIndex = 17
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Control
        Me.Button6.Location = New System.Drawing.Point(168, 250)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 31)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Crear"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(72, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(116, 45)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(35, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Si"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'EstadoComboBox1
        '
        Me.EstadoComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeBindingSource, "estado", True))
        Me.EstadoComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox1.FormattingEnabled = True
        Me.EstadoComboBox1.Items.AddRange(New Object() {"Pendiente", "Sin Rembolso"})
        Me.EstadoComboBox1.Location = New System.Drawing.Point(116, 120)
        Me.EstadoComboBox1.Name = "EstadoComboBox1"
        Me.EstadoComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.EstadoComboBox1.TabIndex = 16
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(155, 45)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(40, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "No"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CodigoTextBox1
        '
        Me.CodigoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeBindingSource, "codigo", True))
        Me.CodigoTextBox1.Location = New System.Drawing.Point(116, 68)
        Me.CodigoTextBox1.Name = "CodigoTextBox1"
        Me.CodigoTextBox1.ReadOnly = True
        Me.CodigoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox1.TabIndex = 7
        '
        'FechaDateTimePicker1
        '
        Me.FechaDateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.FechaDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DevolucionUniformeBindingSource, "fecha", True))
        Me.FechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker1.Location = New System.Drawing.Point(116, 94)
        Me.FechaDateTimePicker1.Name = "FechaDateTimePicker1"
        Me.FechaDateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.FechaDateTimePicker1.TabIndex = 13
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(116, 199)
        Me.ObservacionTextBox.Multiline = True
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(213, 45)
        Me.ObservacionTextBox.TabIndex = 9
        Me.ObservacionTextBox.Text = "Ninguna"
        '
        'RecibeTextBox
        '
        Me.RecibeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeBindingSource, "recibe", True))
        Me.RecibeTextBox.Location = New System.Drawing.Point(116, 173)
        Me.RecibeTextBox.Name = "RecibeTextBox"
        Me.RecibeTextBox.ReadOnly = True
        Me.RecibeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RecibeTextBox.TabIndex = 11
        '
        'GroupBox17
        '
        Me.GroupBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox17.Controls.Add(Me.PictureBox6)
        Me.GroupBox17.Controls.Add(EstadoLabel4)
        Me.GroupBox17.Controls.Add(Me.EstadoComboBox2)
        Me.GroupBox17.Controls.Add(EstiloLabel2)
        Me.GroupBox17.Controls.Add(Me.EstiloTextBox2)
        Me.GroupBox17.Controls.Add(TallaLabel)
        Me.GroupBox17.Controls.Add(Me.TallaTextBox1)
        Me.GroupBox17.Controls.Add(CantidadLabel1)
        Me.GroupBox17.Controls.Add(Me.CantidadTextBox1)
        Me.GroupBox17.Controls.Add(TipoLabel1)
        Me.GroupBox17.Controls.Add(Me.TipoComboBox1)
        Me.GroupBox17.Controls.Add(AlmacenLabel)
        Me.GroupBox17.Controls.Add(Me.ComboBox9)
        Me.GroupBox17.Controls.Add(Me.AlmacenComboBox)
        Me.GroupBox17.Controls.Add(Me.Button5)
        Me.GroupBox17.Controls.Add(Me.Button2)
        Me.GroupBox17.Location = New System.Drawing.Point(363, 19)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(576, 291)
        Me.GroupBox17.TabIndex = 2
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Detalle de Devolucion"
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Print_48px_2
        Me.PictureBox6.Location = New System.Drawing.Point(223, 250)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 55
        Me.PictureBox6.TabStop = False
        '
        'EstadoComboBox2
        '
        Me.EstadoComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeDetalleBindingSource, "estado", True))
        Me.EstadoComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox2.FormattingEnabled = True
        Me.EstadoComboBox2.Items.AddRange(New Object() {"A", "B", "C"})
        Me.EstadoComboBox2.Location = New System.Drawing.Point(74, 68)
        Me.EstadoComboBox2.Name = "EstadoComboBox2"
        Me.EstadoComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.EstadoComboBox2.TabIndex = 13
        '
        'DevolucionUniformeDetalleBindingSource
        '
        Me.DevolucionUniformeDetalleBindingSource.DataMember = "DevolucionUniformeDetalle"
        Me.DevolucionUniformeDetalleBindingSource.DataSource = Me.ABASDataSet
        '
        'EstiloTextBox2
        '
        Me.EstiloTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeDetalleBindingSource, "estilo", True))
        Me.EstiloTextBox2.Location = New System.Drawing.Point(74, 147)
        Me.EstiloTextBox2.Name = "EstiloTextBox2"
        Me.EstiloTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.EstiloTextBox2.TabIndex = 11
        '
        'TallaTextBox1
        '
        Me.TallaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeDetalleBindingSource, "talla", True))
        Me.TallaTextBox1.Location = New System.Drawing.Point(74, 120)
        Me.TallaTextBox1.Name = "TallaTextBox1"
        Me.TallaTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TallaTextBox1.TabIndex = 9
        '
        'CantidadTextBox1
        '
        Me.CantidadTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeDetalleBindingSource, "cantidad", True))
        Me.CantidadTextBox1.Location = New System.Drawing.Point(74, 94)
        Me.CantidadTextBox1.Name = "CantidadTextBox1"
        Me.CantidadTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox1.TabIndex = 7
        '
        'TipoComboBox1
        '
        Me.TipoComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeDetalleBindingSource, "tipo", True))
        Me.TipoComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoComboBox1.FormattingEnabled = True
        Me.TipoComboBox1.Items.AddRange(New Object() {"Pantalon", "Camisa", "Camisa Centro", "Ligas", "Gorra", "Calzado", "Faja"})
        Me.TipoComboBox1.Location = New System.Drawing.Point(74, 16)
        Me.TipoComboBox1.Name = "TipoComboBox1"
        Me.TipoComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.TipoComboBox1.TabIndex = 5
        '
        'ComboBox9
        '
        Me.ComboBox9.Enabled = False
        Me.ComboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox9.Location = New System.Drawing.Point(201, 43)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox9.TabIndex = 3
        '
        'AlmacenComboBox
        '
        Me.AlmacenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevolucionUniformeDetalleBindingSource, "almacen", True))
        Me.AlmacenComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AlmacenComboBox.FormattingEnabled = True
        Me.AlmacenComboBox.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.AlmacenComboBox.Location = New System.Drawing.Point(74, 42)
        Me.AlmacenComboBox.Name = "AlmacenComboBox"
        Me.AlmacenComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AlmacenComboBox.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(127, 250)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 31)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Guardar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(31, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Insertar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DevolucionUniformeDetalleDataGridView
        '
        Me.DevolucionUniformeDetalleDataGridView.AllowUserToDeleteRows = False
        Me.DevolucionUniformeDetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DevolucionUniformeDetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DevolucionUniformeDetalleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DevolucionUniformeDetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DevolucionUniformeDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DevolucionUniformeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DevolucionUniformeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iddevolucion, Me.almacendetalledevolucion, Me.tipodetalledevolucion, Me.cantidadetalledevolucion, Me.talladetalledevolucion, Me.estilodetalledevolucion, Me.estadodetalledevolucion})
        Me.DevolucionUniformeDetalleDataGridView.Location = New System.Drawing.Point(6, 328)
        Me.DevolucionUniformeDetalleDataGridView.Name = "DevolucionUniformeDetalleDataGridView"
        Me.DevolucionUniformeDetalleDataGridView.RowHeadersVisible = False
        Me.DevolucionUniformeDetalleDataGridView.Size = New System.Drawing.Size(948, 282)
        Me.DevolucionUniformeDetalleDataGridView.TabIndex = 1
        '
        'iddevolucion
        '
        Me.iddevolucion.DataPropertyName = "iddevolucion"
        Me.iddevolucion.HeaderText = "ID Devolucion"
        Me.iddevolucion.Name = "iddevolucion"
        Me.iddevolucion.ReadOnly = True
        '
        'almacendetalledevolucion
        '
        Me.almacendetalledevolucion.DataPropertyName = "almacendetalledevolucion"
        Me.almacendetalledevolucion.HeaderText = "Almacen"
        Me.almacendetalledevolucion.Name = "almacendetalledevolucion"
        Me.almacendetalledevolucion.ReadOnly = True
        Me.almacendetalledevolucion.Width = 73
        '
        'tipodetalledevolucion
        '
        Me.tipodetalledevolucion.DataPropertyName = "tipodetalledevolucion"
        Me.tipodetalledevolucion.HeaderText = "Tipo"
        Me.tipodetalledevolucion.Name = "tipodetalledevolucion"
        Me.tipodetalledevolucion.ReadOnly = True
        Me.tipodetalledevolucion.Width = 53
        '
        'cantidadetalledevolucion
        '
        Me.cantidadetalledevolucion.DataPropertyName = "cantidadetalledevolucion"
        Me.cantidadetalledevolucion.HeaderText = "Cantidad"
        Me.cantidadetalledevolucion.Name = "cantidadetalledevolucion"
        Me.cantidadetalledevolucion.ReadOnly = True
        Me.cantidadetalledevolucion.Width = 74
        '
        'talladetalledevolucion
        '
        Me.talladetalledevolucion.DataPropertyName = "talladetalledevolucion"
        Me.talladetalledevolucion.HeaderText = "Talla"
        Me.talladetalledevolucion.Name = "talladetalledevolucion"
        Me.talladetalledevolucion.ReadOnly = True
        Me.talladetalledevolucion.Width = 55
        '
        'estilodetalledevolucion
        '
        Me.estilodetalledevolucion.DataPropertyName = "estilodetalledevolucion"
        Me.estilodetalledevolucion.HeaderText = "Estilo"
        Me.estilodetalledevolucion.Name = "estilodetalledevolucion"
        Me.estilodetalledevolucion.ReadOnly = True
        Me.estilodetalledevolucion.Width = 57
        '
        'estadodetalledevolucion
        '
        Me.estadodetalledevolucion.DataPropertyName = "estadodetalledevolucion"
        Me.estadodetalledevolucion.HeaderText = "Estado"
        Me.estadodetalledevolucion.Name = "estadodetalledevolucion"
        Me.estadodetalledevolucion.ReadOnly = True
        Me.estadodetalledevolucion.Width = 65
        '
        'panelEmpleados
        '
        Me.panelEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelEmpleados.Controls.Add(Me.PictureBox4)
        Me.panelEmpleados.Controls.Add(Me.Panel2)
        Me.panelEmpleados.Controls.Add(Me.txtbuscarEmp)
        Me.panelEmpleados.Controls.Add(Me.tipodebusqueda)
        Me.panelEmpleados.Location = New System.Drawing.Point(196, 186)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(603, 354)
        Me.panelEmpleados.TabIndex = 98
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.identidad, Me.planilla, Me.DataGridViewTextBoxColumn10})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 53)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(601, 299)
        Me.EmpleadosDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 74
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 74
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
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ubicacion"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox4.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox4.Location = New System.Drawing.Point(417, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioUniformeToolStripMenuItem, Me.MovimientosDeUniformeToolStripMenuItem, Me.MovimientosDeUniformesPorTipoToolStripMenuItem, Me.ComprobanteEntregaUniformeToolStripMenuItem, Me.ComprobanteDevolucionUniformeToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.ToolStripMenuItem1.Text = "Reportes"
        '
        'InventarioUniformeToolStripMenuItem
        '
        Me.InventarioUniformeToolStripMenuItem.Name = "InventarioUniformeToolStripMenuItem"
        Me.InventarioUniformeToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.InventarioUniformeToolStripMenuItem.Text = "Inventario Uniforme Por Sucursal"
        '
        'MovimientosDeUniformeToolStripMenuItem
        '
        Me.MovimientosDeUniformeToolStripMenuItem.Name = "MovimientosDeUniformeToolStripMenuItem"
        Me.MovimientosDeUniformeToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.MovimientosDeUniformeToolStripMenuItem.Text = "Movimientos de Uniforme"
        '
        'MovimientosDeUniformesPorTipoToolStripMenuItem
        '
        Me.MovimientosDeUniformesPorTipoToolStripMenuItem.Name = "MovimientosDeUniformesPorTipoToolStripMenuItem"
        Me.MovimientosDeUniformesPorTipoToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.MovimientosDeUniformesPorTipoToolStripMenuItem.Text = "Movimientos de Uniforme por Tipo"
        '
        'ComprobanteEntregaUniformeToolStripMenuItem
        '
        Me.ComprobanteEntregaUniformeToolStripMenuItem.Name = "ComprobanteEntregaUniformeToolStripMenuItem"
        Me.ComprobanteEntregaUniformeToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ComprobanteEntregaUniformeToolStripMenuItem.Text = "Comprobante Entrega Uniforme"
        '
        'ComprobanteDevolucionUniformeToolStripMenuItem
        '
        Me.ComprobanteDevolucionUniformeToolStripMenuItem.Name = "ComprobanteDevolucionUniformeToolStripMenuItem"
        Me.ComprobanteDevolucionUniformeToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ComprobanteDevolucionUniformeToolStripMenuItem.Text = "Comprobante Devolucion Uniforme"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(965, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Inventario de Uniformes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'UniformesTableAdapter
        '
        Me.UniformesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UniformesTableAdapter = Me.UniformesTableAdapter
        Me.TableAdapterManager.UpdateNVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosModulosTableAdapter = Nothing
        Me.TableAdapterManager.VehiculosFotosTableAdapter = Nothing
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        '
        'MovimientoUniformesTableAdapter
        '
        Me.MovimientoUniformesTableAdapter.ClearBeforeFill = True
        '
        'SolicitudUniformeTableAdapter
        '
        Me.SolicitudUniformeTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'DetalleSolicitudTableAdapter
        '
        Me.DetalleSolicitudTableAdapter.ClearBeforeFill = True
        '
        'DevolucionUniformeDetalleTableAdapter
        '
        Me.DevolucionUniformeDetalleTableAdapter.ClearBeforeFill = True
        '
        'DevolucionUniformeTableAdapter
        '
        Me.DevolucionUniformeTableAdapter.ClearBeforeFill = True
        '
        'FormInventarioUniformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 691)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.panelEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormInventarioUniformes"
        Me.Text = "FormUniformes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.UniformesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DetalleSolicitudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniformesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoUniformesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.MovimientoUniformesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DetalleSolicitudDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cmd_ImprimirSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolicitudUniformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevolucionUniformeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevolucionUniformeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevolucionUniformeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelEmpleados.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents UniformesBindingSource As BindingSource
    Friend WithEvents UniformesTableAdapter As ABASDataSetTableAdapters.UniformesTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CantFinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CantUniforme As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CantInicial As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EstiloTextBox As TextBox
    Friend WithEvents UniformesDataGridView As DataGridView
    Friend WithEvents CmdAgregarUniforme As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MovimientosDeUniformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cmd_RegistrarUniforme As Button
    Friend WithEvents InventarioUniformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobanteEntregaUniformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobanteDevolucionUniformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cmd_Limpiar As Button
    Friend WithEvents MovimientoUniformesBindingSource As BindingSource
    Friend WithEvents MovimientoUniformesTableAdapter As ABASDataSetTableAdapters.MovimientoUniformesTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DescripcionMovimiento As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CantFinalEnvia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CantMoverEnvia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CantIniEnvia As TextBox
    Friend WithEvents IduniformeMovimiento As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents EstadoMovimiento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboHacia As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboDesde As ComboBox
    Friend WithEvents Cmd_Nuevo As Button
    Friend WithEvents Cmd_Transferir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CantFinRecibe As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CantMovRecibe As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CantIniRecibe As TextBox
    Friend WithEvents MovimientoUniformesDataGridView As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents FechaMovimiento As DateTimePicker
    Friend WithEvents IduniformeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cmd_Recibir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DescripcionRecibe As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents EstadoRecibe As TextBox
    Friend WithEvents ComboRecibe As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CantRecibe As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents EstiloEnvia As TextBox
    Friend WithEvents EstiloRecibe As TextBox
    Friend WithEvents IdMov As TextBox
    Friend WithEvents Cmb_EstadoUniforme As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents SolicitudUniformeBindingSource As BindingSource
    Friend WithEvents SolicitudUniformeTableAdapter As ABASDataSetTableAdapters.SolicitudUniformeTableAdapter
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents IdsolicitudTextBox As TextBox
    Friend WithEvents Cmd_CrearSolicitud As Button
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents EntregaTextBox As TextBox
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents identidad As DataGridViewTextBoxColumn
    Friend WithEvents planilla As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbuscarEmp As TextBox
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents Cmd_NuevaSolicitud As Button
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents DetalleSolicitudBindingSource As BindingSource
    Friend WithEvents DetalleSolicitudTableAdapter As ABASDataSetTableAdapters.DetalleSolicitudTableAdapter
    Friend WithEvents DetalleSolicitudDataGridView As DataGridView
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents EstiloTextBox1 As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents TallaTextBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents Cmb_TipoUniforme As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Cmd_CancelarSolicitud As Button
    Friend WithEvents Cmd_ImprimirSolicitud As PictureBox
    Friend WithEvents Txt_TotalPagar As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IDSolicitudUniforme As DataGridViewTextBoxColumn
    Friend WithEvents EstadoFormaDePago As DataGridViewTextBoxColumn
    Friend WithEvents Veces As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents IDSolicitudDetalle As DataGridViewTextBoxColumn
    Friend WithEvents IdUniformeDetalle As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDetalle As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Talla As DataGridViewTextBoxColumn
    Friend WithEvents EstiloDetalle As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDetalle As DataGridViewTextBoxColumn
    Friend WithEvents AlmacenDetalle As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents DevolucionUniformeDetalleBindingSource As BindingSource
    Friend WithEvents DevolucionUniformeDetalleTableAdapter As ABASDataSetTableAdapters.DevolucionUniformeDetalleTableAdapter
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DevolucionUniformeDetalleDataGridView As DataGridView
    Friend WithEvents DevolucionUniformeBindingSource As BindingSource
    Friend WithEvents DevolucionUniformeTableAdapter As ABASDataSetTableAdapters.DevolucionUniformeTableAdapter
    Friend WithEvents EstadoComboBox2 As ComboBox
    Friend WithEvents EstiloTextBox2 As TextBox
    Friend WithEvents TallaTextBox1 As TextBox
    Friend WithEvents CantidadTextBox1 As TextBox
    Friend WithEvents TipoComboBox1 As ComboBox
    Friend WithEvents AlmacenComboBox As ComboBox
    Friend WithEvents RembolsoTextBox As TextBox
    Friend WithEvents EstadoComboBox1 As ComboBox
    Friend WithEvents FechaDateTimePicker1 As DateTimePicker
    Friend WithEvents RecibeTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents CodigoTextBox1 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents IddevolucionTextBox As TextBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents iddevolucion As DataGridViewTextBoxColumn
    Friend WithEvents almacendetalledevolucion As DataGridViewTextBoxColumn
    Friend WithEvents tipodetalledevolucion As DataGridViewTextBoxColumn
    Friend WithEvents cantidadetalledevolucion As DataGridViewTextBoxColumn
    Friend WithEvents talladetalledevolucion As DataGridViewTextBoxColumn
    Friend WithEvents estilodetalledevolucion As DataGridViewTextBoxColumn
    Friend WithEvents estadodetalledevolucion As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cmb_RUIalm As ComboBox
    Friend WithEvents Cmb_RUalm As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents TallaTextBox2 As TextBox
    Friend WithEvents TallaTextBox3 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents recibe_mov As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MovimientosDeUniformesPorTipoToolStripMenuItem As ToolStripMenuItem
End Class
