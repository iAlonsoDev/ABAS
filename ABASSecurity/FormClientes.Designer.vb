<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim FechainicioLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim Telefono3Label As System.Windows.Forms.Label
        Dim Telefono1Label As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim Telefono2Label As System.Windows.Forms.Label
        Dim SucursalLabel As System.Windows.Forms.Label
        Dim IdsucursalLabel As System.Windows.Forms.Label
        Dim CodigoLabel1 As System.Windows.Forms.Label
        Dim HorasLabel As System.Windows.Forms.Label
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linea = New System.Windows.Forms.Panel()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Panelregistroclientes = New System.Windows.Forms.Panel()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdActualizarCliente = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAgregarSucursal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FechafinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.txt_fechafinal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.FechainicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txt_rtn = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SucursalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.idsucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.basehoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tab_Clientes = New System.Windows.Forms.TabControl()
        Me.Clientes = New System.Windows.Forms.TabPage()
        Me.Sucursales = New System.Windows.Forms.TabPage()
        Me.PanelSucursales = New System.Windows.Forms.Panel()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.EstadoSucur = New System.Windows.Forms.ComboBox()
        Me.ComboBase = New System.Windows.Forms.ComboBox()
        Me.Extras = New System.Windows.Forms.TextBox()
        Me.observacion_sucursal = New System.Windows.Forms.TextBox()
        Me.txt_empleados = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_isv = New System.Windows.Forms.TextBox()
        Me.txt_subt = New System.Windows.Forms.TextBox()
        Me.SucursalTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono1TextBox = New System.Windows.Forms.TextBox()
        Me.Telefono3TextBox = New System.Windows.Forms.TextBox()
        Me.Telefono2TextBox = New System.Windows.Forms.TextBox()
        Me.HorasTextBox = New System.Windows.Forms.TextBox()
        Me.cmdActualizarSucursal = New System.Windows.Forms.Button()
        Me.cmdGuardarSucursal = New System.Windows.Forms.Button()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox1 = New System.Windows.Forms.TextBox()
        Me.IdsucursalTextBox = New System.Windows.Forms.TextBox()
        Me.SucursalesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.SucursalesTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.ClienteTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeTotalClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeSucursalesPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        NombreLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        FechainicioLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        Telefono3Label = New System.Windows.Forms.Label()
        Telefono1Label = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        Telefono2Label = New System.Windows.Forms.Label()
        SucursalLabel = New System.Windows.Forms.Label()
        IdsucursalLabel = New System.Windows.Forms.Label()
        CodigoLabel1 = New System.Windows.Forms.Label()
        HorasLabel = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelregistroclientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Clientes.SuspendLayout()
        Me.Clientes.SuspendLayout()
        Me.Sucursales.SuspendLayout()
        Me.PanelSucursales.SuspendLayout()
        Me.grupo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(54, 59)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(58, 111)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 43
        EstadoLabel.Text = "Estado:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(4, 85)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(97, 13)
        CorreoLabel.TabIndex = 45
        CorreoLabel.Text = "Correo Electronico:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(68, 35)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(33, 13)
        Label5.TabIndex = 52
        Label5.Text = "RTN:"
        '
        'FechainicioLabel
        '
        FechainicioLabel.AutoSize = True
        FechainicioLabel.Location = New System.Drawing.Point(4, 136)
        FechainicioLabel.Name = "FechainicioLabel"
        FechainicioLabel.Size = New System.Drawing.Size(97, 13)
        FechainicioLabel.TabIndex = 52
        FechainicioLabel.Text = "Fecha de Registro:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(31, 162)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(70, 13)
        Label12.TabIndex = 55
        Label12.Text = "Observacion:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(29, 71)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(70, 13)
        Label14.TabIndex = 60
        Label14.Text = "Horas Extras:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(29, 146)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 57
        ObservacionLabel.Text = "Observacion:"
        '
        'Telefono3Label
        '
        Telefono3Label.AutoSize = True
        Telefono3Label.Location = New System.Drawing.Point(205, 119)
        Telefono3Label.Name = "Telefono3Label"
        Telefono3Label.Size = New System.Drawing.Size(58, 13)
        Telefono3Label.TabIndex = 46
        Telefono3Label.Text = "Telefono3:"
        '
        'Telefono1Label
        '
        Telefono1Label.AutoSize = True
        Telefono1Label.Location = New System.Drawing.Point(41, 96)
        Telefono1Label.Name = "Telefono1Label"
        Telefono1Label.Size = New System.Drawing.Size(58, 13)
        Telefono1Label.TabIndex = 6
        Telefono1Label.Text = "Telefono1:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(500, 230)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(45, 13)
        NombreLabel1.TabIndex = 35
        NombreLabel1.Text = "nombre:"
        NombreLabel1.Visible = False
        '
        'Telefono2Label
        '
        Telefono2Label.AutoSize = True
        Telefono2Label.Location = New System.Drawing.Point(41, 121)
        Telefono2Label.Name = "Telefono2Label"
        Telefono2Label.Size = New System.Drawing.Size(58, 13)
        Telefono2Label.TabIndex = 8
        Telefono2Label.Text = "Telefono2:"
        '
        'SucursalLabel
        '
        SucursalLabel.AutoSize = True
        SucursalLabel.Location = New System.Drawing.Point(17, 21)
        SucursalLabel.Name = "SucursalLabel"
        SucursalLabel.Size = New System.Drawing.Size(82, 13)
        SucursalLabel.TabIndex = 12
        SucursalLabel.Text = "Sucursal/Local:"
        '
        'IdsucursalLabel
        '
        IdsucursalLabel.AutoSize = True
        IdsucursalLabel.Location = New System.Drawing.Point(439, 230)
        IdsucursalLabel.Name = "IdsucursalLabel"
        IdsucursalLabel.Size = New System.Drawing.Size(57, 13)
        IdsucursalLabel.TabIndex = 10
        IdsucursalLabel.Text = "idsucursal:"
        IdsucursalLabel.Visible = False
        '
        'CodigoLabel1
        '
        CodigoLabel1.AutoSize = True
        CodigoLabel1.Location = New System.Drawing.Point(393, 230)
        CodigoLabel1.Name = "CodigoLabel1"
        CodigoLabel1.Size = New System.Drawing.Size(42, 13)
        CodigoLabel1.TabIndex = 14
        CodigoLabel1.Text = "codigo:"
        CodigoLabel1.Visible = False
        '
        'HorasLabel
        '
        HorasLabel.AutoSize = True
        HorasLabel.Location = New System.Drawing.Point(26, 46)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(73, 13)
        HorasLabel.TabIndex = 44
        HorasLabel.Text = "Cliente Horas:"
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(340, 230)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(49, 13)
        IdclienteLabel.TabIndex = 0
        IdclienteLabel.Text = "idcliente:"
        IdclienteLabel.Visible = False
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(345, 100)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(80, 13)
        Label11.TabIndex = 56
        Label11.Text = "N° de Oficiales:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(391, 172)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(34, 13)
        Label8.TabIndex = 55
        Label8.Text = "Total:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(375, 148)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(50, 13)
        Label7.TabIndex = 54
        Label7.Text = "ISV 15%:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(369, 124)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(56, 13)
        Label6.TabIndex = 53
        Label6.Text = "Sub Total:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(205, 49)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(65, 13)
        Label15.TabIndex = 62
        Label15.Text = "Base Horas:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(348, 49)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(43, 13)
        Label16.TabIndex = 63
        Label16.Text = "Estado:"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.Location = New System.Drawing.Point(365, 13)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(241, 20)
        Me.txtbusqueda.TabIndex = 1
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(611, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'linea
        '
        Me.linea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.linea.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.linea.Location = New System.Drawing.Point(361, 35)
        Me.linea.Name = "linea"
        Me.linea.Size = New System.Drawing.Size(244, 1)
        Me.linea.TabIndex = 7
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmdNuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNuevo.FlatAppearance.BorderSize = 0
        Me.cmdNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(13, 10)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(123, 30)
        Me.cmdNuevo.TabIndex = 29
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NombreTextBox.Location = New System.Drawing.Point(105, 56)
        Me.NombreTextBox.MaxLength = 100
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(345, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'Panelregistroclientes
        '
        Me.Panelregistroclientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panelregistroclientes.BackColor = System.Drawing.SystemColors.Control
        Me.Panelregistroclientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelregistroclientes.Controls.Add(Me.cmdEliminar)
        Me.Panelregistroclientes.Controls.Add(Me.Button1)
        Me.Panelregistroclientes.Controls.Add(Me.cmdActualizarCliente)
        Me.Panelregistroclientes.Controls.Add(Me.cmdGuardar)
        Me.Panelregistroclientes.Controls.Add(Me.Label1)
        Me.Panelregistroclientes.Controls.Add(Me.cmdAgregarSucursal)
        Me.Panelregistroclientes.Controls.Add(Me.GroupBox1)
        Me.Panelregistroclientes.Location = New System.Drawing.Point(25, 62)
        Me.Panelregistroclientes.Name = "Panelregistroclientes"
        Me.Panelregistroclientes.Size = New System.Drawing.Size(902, 307)
        Me.Panelregistroclientes.TabIndex = 30
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
        Me.cmdEliminar.Location = New System.Drawing.Point(281, 255)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(128, 33)
        Me.cmdEliminar.TabIndex = 50
        Me.cmdEliminar.Text = "Eliminar Cliente"
        Me.cmdEliminar.UseVisualStyleBackColor = False
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
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, -3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 26)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Ocultar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdActualizarCliente
        '
        Me.cmdActualizarCliente.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdActualizarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdActualizarCliente.FlatAppearance.BorderSize = 0
        Me.cmdActualizarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdActualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdActualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdActualizarCliente.Location = New System.Drawing.Point(150, 255)
        Me.cmdActualizarCliente.Name = "cmdActualizarCliente"
        Me.cmdActualizarCliente.Size = New System.Drawing.Size(125, 33)
        Me.cmdActualizarCliente.TabIndex = 32
        Me.cmdActualizarCliente.Text = "Actualizar Cliente"
        Me.cmdActualizarCliente.UseVisualStyleBackColor = False
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
        Me.cmdGuardar.Location = New System.Drawing.Point(20, 255)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(126, 33)
        Me.cmdGuardar.TabIndex = 31
        Me.cmdGuardar.Text = "Guardar Cliente"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(900, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Registro de Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAgregarSucursal
        '
        Me.cmdAgregarSucursal.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdAgregarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdAgregarSucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAgregarSucursal.FlatAppearance.BorderSize = 0
        Me.cmdAgregarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAgregarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdAgregarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarSucursal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdAgregarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAgregarSucursal.Location = New System.Drawing.Point(415, 255)
        Me.cmdAgregarSucursal.Name = "cmdAgregarSucursal"
        Me.cmdAgregarSucursal.Size = New System.Drawing.Size(128, 33)
        Me.cmdAgregarSucursal.TabIndex = 42
        Me.cmdAgregarSucursal.Text = "Agregar Sucursal"
        Me.cmdAgregarSucursal.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Me.txt_observacion)
        Me.GroupBox1.Controls.Add(FechainicioLabel)
        Me.GroupBox1.Controls.Add(Me.FechainicioDateTimePicker)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.txt_rtn)
        Me.GroupBox1.Controls.Add(Me.CorreoTextBox)
        Me.GroupBox1.Controls.Add(CorreoLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.EstadoComboBox)
        Me.GroupBox1.Controls.Add(EstadoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 220)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.FechafinalDateTimePicker)
        Me.Panel1.Controls.Add(Me.txt_fechafinal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(491, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 154)
        Me.Panel1.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(22, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Razon/Inactivo:"
        '
        'FechafinalDateTimePicker
        '
        Me.FechafinalDateTimePicker.CustomFormat = ""
        Me.FechafinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "fechafinal", True))
        Me.FechafinalDateTimePicker.Location = New System.Drawing.Point(25, 46)
        Me.FechafinalDateTimePicker.Name = "FechafinalDateTimePicker"
        Me.FechafinalDateTimePicker.Size = New System.Drawing.Size(198, 20)
        Me.FechafinalDateTimePicker.TabIndex = 54
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_fechafinal
        '
        Me.txt_fechafinal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_fechafinal.Location = New System.Drawing.Point(24, 89)
        Me.txt_fechafinal.MaxLength = 200
        Me.txt_fechafinal.Multiline = True
        Me.txt_fechafinal.Name = "txt_fechafinal"
        Me.txt_fechafinal.Size = New System.Drawing.Size(300, 57)
        Me.txt_fechafinal.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(22, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Fecha de Inactivo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(4, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(342, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "*Seleccione la fecha y especifique porque inhabilita RRHH este cliente"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(105, 159)
        Me.txt_observacion.MaxLength = 200
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(345, 47)
        Me.txt_observacion.TabIndex = 54
        '
        'FechainicioDateTimePicker
        '
        Me.FechainicioDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechainicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "fechainicio", True))
        Me.FechainicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechainicioDateTimePicker.Location = New System.Drawing.Point(105, 133)
        Me.FechainicioDateTimePicker.Name = "FechainicioDateTimePicker"
        Me.FechainicioDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechainicioDateTimePicker.TabIndex = 53
        '
        'txt_rtn
        '
        Me.txt_rtn.Location = New System.Drawing.Point(105, 32)
        Me.txt_rtn.Name = "txt_rtn"
        Me.txt_rtn.Size = New System.Drawing.Size(137, 20)
        Me.txt_rtn.TabIndex = 51
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.Location = New System.Drawing.Point(105, 82)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(345, 20)
        Me.CorreoTextBox.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label4.Location = New System.Drawing.Point(5, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(405, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "*Registre primero al cliente luego proceda RRHH registar sus sucursales"
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EstadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"Seleccionar", "Activo", "Inactivo"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(105, 108)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.EstadoComboBox.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nombre del Cliente:"
        '
        'SucursalesDataGridView
        '
        Me.SucursalesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SucursalesDataGridView.AutoGenerateColumns = False
        Me.SucursalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.SucursalesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SucursalesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.SucursalesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SucursalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SucursalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idsucursal, Me.SucursalDataGridViewTextBoxColumn, Me.Telefono1DataGridViewTextBoxColumn, Me.Telefono2DataGridViewTextBoxColumn, Me.Telefono3DataGridViewTextBoxColumn, Me.horas, Me.empleados, Me.subt, Me.isv, Me.total, Me.observacion, Me.DataGridViewTextBoxColumn11, Me.basehoras, Me.estado})
        Me.SucursalesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SucursalesDataGridView.DataSource = Me.SucursalesBindingSource
        Me.SucursalesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SucursalesDataGridView.Name = "SucursalesDataGridView"
        Me.SucursalesDataGridView.RowHeadersVisible = False
        Me.SucursalesDataGridView.Size = New System.Drawing.Size(946, 578)
        Me.SucursalesDataGridView.TabIndex = 31
        '
        'idsucursal
        '
        Me.idsucursal.DataPropertyName = "idsucursal"
        Me.idsucursal.HeaderText = "Id"
        Me.idsucursal.Name = "idsucursal"
        Me.idsucursal.ReadOnly = True
        Me.idsucursal.Width = 41
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        Me.SucursalDataGridViewTextBoxColumn.Width = 73
        '
        'Telefono1DataGridViewTextBoxColumn
        '
        Me.Telefono1DataGridViewTextBoxColumn.DataPropertyName = "telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.Name = "Telefono1DataGridViewTextBoxColumn"
        Me.Telefono1DataGridViewTextBoxColumn.Width = 80
        '
        'Telefono2DataGridViewTextBoxColumn
        '
        Me.Telefono2DataGridViewTextBoxColumn.DataPropertyName = "telefono2"
        Me.Telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono2"
        Me.Telefono2DataGridViewTextBoxColumn.Name = "Telefono2DataGridViewTextBoxColumn"
        Me.Telefono2DataGridViewTextBoxColumn.Width = 80
        '
        'Telefono3DataGridViewTextBoxColumn
        '
        Me.Telefono3DataGridViewTextBoxColumn.DataPropertyName = "telefono3"
        Me.Telefono3DataGridViewTextBoxColumn.HeaderText = "Telefono3"
        Me.Telefono3DataGridViewTextBoxColumn.Name = "Telefono3DataGridViewTextBoxColumn"
        Me.Telefono3DataGridViewTextBoxColumn.Width = 80
        '
        'horas
        '
        Me.horas.DataPropertyName = "horas"
        Me.horas.HeaderText = "Horas Cliente"
        Me.horas.Name = "horas"
        Me.horas.Width = 95
        '
        'empleados
        '
        Me.empleados.DataPropertyName = "empleados"
        Me.empleados.HeaderText = "N° de Oficiales"
        Me.empleados.Name = "empleados"
        Me.empleados.Width = 102
        '
        'subt
        '
        Me.subt.DataPropertyName = "subt"
        Me.subt.HeaderText = "Subtotal"
        Me.subt.Name = "subt"
        Me.subt.Width = 71
        '
        'isv
        '
        Me.isv.DataPropertyName = "isv"
        Me.isv.HeaderText = "ISV"
        Me.isv.Name = "isv"
        Me.isv.Width = 49
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.Width = 56
        '
        'observacion
        '
        Me.observacion.DataPropertyName = "observacion"
        Me.observacion.HeaderText = "Observacion"
        Me.observacion.Name = "observacion"
        Me.observacion.Width = 92
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "extras"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Extras"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 61
        '
        'basehoras
        '
        Me.basehoras.DataPropertyName = "basehoras"
        Me.basehoras.HeaderText = "BaseHoras"
        Me.basehoras.Name = "basehoras"
        Me.basehoras.Width = 84
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Width = 65
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.ABASDataSet
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ClienteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.comentario})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.RowHeadersVisible = False
        Me.ClienteDataGridView.Size = New System.Drawing.Size(946, 561)
        Me.ClienteDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 72
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 63
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "rtn"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RTN"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 55
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechainicio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Inicial"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 92
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechafinal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Inactividad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 84
        '
        'comentario
        '
        Me.comentario.DataPropertyName = "comentario"
        Me.comentario.HeaderText = "Observacion"
        Me.comentario.Name = "comentario"
        Me.comentario.Width = 92
        '
        'Tab_Clientes
        '
        Me.Tab_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Clientes.Controls.Add(Me.Clientes)
        Me.Tab_Clientes.Controls.Add(Me.Sucursales)
        Me.Tab_Clientes.Location = New System.Drawing.Point(5, 91)
        Me.Tab_Clientes.Name = "Tab_Clientes"
        Me.Tab_Clientes.SelectedIndex = 0
        Me.Tab_Clientes.Size = New System.Drawing.Size(960, 593)
        Me.Tab_Clientes.TabIndex = 32
        '
        'Clientes
        '
        Me.Clientes.Controls.Add(Me.Panelregistroclientes)
        Me.Clientes.Controls.Add(Me.ClienteDataGridView)
        Me.Clientes.Location = New System.Drawing.Point(4, 22)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.Clientes.Size = New System.Drawing.Size(952, 567)
        Me.Clientes.TabIndex = 0
        Me.Clientes.Text = "Clientes"
        Me.Clientes.UseVisualStyleBackColor = True
        '
        'Sucursales
        '
        Me.Sucursales.Controls.Add(Me.PanelSucursales)
        Me.Sucursales.Controls.Add(Me.SucursalesDataGridView)
        Me.Sucursales.Location = New System.Drawing.Point(4, 22)
        Me.Sucursales.Name = "Sucursales"
        Me.Sucursales.Padding = New System.Windows.Forms.Padding(3)
        Me.Sucursales.Size = New System.Drawing.Size(952, 567)
        Me.Sucursales.TabIndex = 1
        Me.Sucursales.Text = "Sucursales"
        Me.Sucursales.UseVisualStyleBackColor = True
        '
        'PanelSucursales
        '
        Me.PanelSucursales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelSucursales.BackColor = System.Drawing.SystemColors.Control
        Me.PanelSucursales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSucursales.Controls.Add(Me.grupo)
        Me.PanelSucursales.Controls.Add(Me.cmdActualizarSucursal)
        Me.PanelSucursales.Controls.Add(Me.cmdGuardarSucursal)
        Me.PanelSucursales.Controls.Add(Me.NombreTextBox1)
        Me.PanelSucursales.Controls.Add(Me.CodigoTextBox)
        Me.PanelSucursales.Controls.Add(Me.IdclienteTextBox)
        Me.PanelSucursales.Controls.Add(IdclienteLabel)
        Me.PanelSucursales.Controls.Add(Me.CodigoTextBox1)
        Me.PanelSucursales.Controls.Add(CodigoLabel1)
        Me.PanelSucursales.Controls.Add(Me.IdsucursalTextBox)
        Me.PanelSucursales.Controls.Add(IdsucursalLabel)
        Me.PanelSucursales.Controls.Add(NombreLabel1)
        Me.PanelSucursales.Location = New System.Drawing.Point(178, 111)
        Me.PanelSucursales.Name = "PanelSucursales"
        Me.PanelSucursales.Size = New System.Drawing.Size(591, 290)
        Me.PanelSucursales.TabIndex = 32
        '
        'grupo
        '
        Me.grupo.Controls.Add(Me.EstadoSucur)
        Me.grupo.Controls.Add(Label16)
        Me.grupo.Controls.Add(Me.ComboBase)
        Me.grupo.Controls.Add(Label14)
        Me.grupo.Controls.Add(Me.Extras)
        Me.grupo.Controls.Add(ObservacionLabel)
        Me.grupo.Controls.Add(Me.observacion_sucursal)
        Me.grupo.Controls.Add(Me.txt_empleados)
        Me.grupo.Controls.Add(Me.txt_total)
        Me.grupo.Controls.Add(Me.txt_isv)
        Me.grupo.Controls.Add(Me.txt_subt)
        Me.grupo.Controls.Add(Me.SucursalTextBox)
        Me.grupo.Controls.Add(Telefono3Label)
        Me.grupo.Controls.Add(Telefono1Label)
        Me.grupo.Controls.Add(Me.Telefono1TextBox)
        Me.grupo.Controls.Add(Me.Telefono3TextBox)
        Me.grupo.Controls.Add(Telefono2Label)
        Me.grupo.Controls.Add(SucursalLabel)
        Me.grupo.Controls.Add(Me.Telefono2TextBox)
        Me.grupo.Controls.Add(Me.HorasTextBox)
        Me.grupo.Controls.Add(HorasLabel)
        Me.grupo.Controls.Add(Label11)
        Me.grupo.Controls.Add(Label8)
        Me.grupo.Controls.Add(Label7)
        Me.grupo.Controls.Add(Label6)
        Me.grupo.Controls.Add(Label15)
        Me.grupo.Location = New System.Drawing.Point(32, 23)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(522, 205)
        Me.grupo.TabIndex = 50
        Me.grupo.TabStop = False
        Me.grupo.Text = "Datos Sucursales"
        '
        'EstadoSucur
        '
        Me.EstadoSucur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EstadoSucur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoSucur.FormattingEnabled = True
        Me.EstadoSucur.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.EstadoSucur.Location = New System.Drawing.Point(395, 46)
        Me.EstadoSucur.Name = "EstadoSucur"
        Me.EstadoSucur.Size = New System.Drawing.Size(100, 21)
        Me.EstadoSucur.TabIndex = 64
        '
        'ComboBase
        '
        Me.ComboBase.DropDownHeight = 100
        Me.ComboBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBase.FormattingEnabled = True
        Me.ComboBase.IntegralHeight = False
        Me.ComboBase.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.ComboBase.Location = New System.Drawing.Point(269, 46)
        Me.ComboBase.Name = "ComboBase"
        Me.ComboBase.Size = New System.Drawing.Size(71, 21)
        Me.ComboBase.TabIndex = 61
        '
        'Extras
        '
        Me.Extras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Extras.Location = New System.Drawing.Point(105, 68)
        Me.Extras.MaxLength = 8
        Me.Extras.Name = "Extras"
        Me.Extras.Size = New System.Drawing.Size(71, 20)
        Me.Extras.TabIndex = 59
        Me.Extras.Text = "00:00:00"
        '
        'observacion_sucursal
        '
        Me.observacion_sucursal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SucursalesBindingSource, "observacion", True))
        Me.observacion_sucursal.Location = New System.Drawing.Point(105, 143)
        Me.observacion_sucursal.Multiline = True
        Me.observacion_sucursal.Name = "observacion_sucursal"
        Me.observacion_sucursal.Size = New System.Drawing.Size(235, 46)
        Me.observacion_sucursal.TabIndex = 58
        '
        'txt_empleados
        '
        Me.txt_empleados.Location = New System.Drawing.Point(423, 97)
        Me.txt_empleados.MaxLength = 9
        Me.txt_empleados.Name = "txt_empleados"
        Me.txt_empleados.Size = New System.Drawing.Size(72, 20)
        Me.txt_empleados.TabIndex = 57
        Me.txt_empleados.Text = "0"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(423, 169)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(72, 20)
        Me.txt_total.TabIndex = 50
        Me.txt_total.Text = "0"
        '
        'txt_isv
        '
        Me.txt_isv.Location = New System.Drawing.Point(423, 145)
        Me.txt_isv.Name = "txt_isv"
        Me.txt_isv.Size = New System.Drawing.Size(72, 20)
        Me.txt_isv.TabIndex = 49
        Me.txt_isv.Text = "0"
        '
        'txt_subt
        '
        Me.txt_subt.Location = New System.Drawing.Point(423, 121)
        Me.txt_subt.Name = "txt_subt"
        Me.txt_subt.Size = New System.Drawing.Size(72, 20)
        Me.txt_subt.TabIndex = 48
        Me.txt_subt.Text = "0"
        '
        'SucursalTextBox
        '
        Me.SucursalTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SucursalTextBox.Location = New System.Drawing.Point(105, 18)
        Me.SucursalTextBox.MaxLength = 100
        Me.SucursalTextBox.Name = "SucursalTextBox"
        Me.SucursalTextBox.Size = New System.Drawing.Size(390, 20)
        Me.SucursalTextBox.TabIndex = 13
        '
        'Telefono1TextBox
        '
        Me.Telefono1TextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Telefono1TextBox.Location = New System.Drawing.Point(105, 93)
        Me.Telefono1TextBox.MaxLength = 9
        Me.Telefono1TextBox.Name = "Telefono1TextBox"
        Me.Telefono1TextBox.Size = New System.Drawing.Size(71, 20)
        Me.Telefono1TextBox.TabIndex = 7
        '
        'Telefono3TextBox
        '
        Me.Telefono3TextBox.Location = New System.Drawing.Point(269, 115)
        Me.Telefono3TextBox.MaxLength = 9
        Me.Telefono3TextBox.Name = "Telefono3TextBox"
        Me.Telefono3TextBox.Size = New System.Drawing.Size(71, 20)
        Me.Telefono3TextBox.TabIndex = 47
        '
        'Telefono2TextBox
        '
        Me.Telefono2TextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Telefono2TextBox.Location = New System.Drawing.Point(105, 118)
        Me.Telefono2TextBox.MaxLength = 9
        Me.Telefono2TextBox.Name = "Telefono2TextBox"
        Me.Telefono2TextBox.Size = New System.Drawing.Size(71, 20)
        Me.Telefono2TextBox.TabIndex = 9
        '
        'HorasTextBox
        '
        Me.HorasTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HorasTextBox.Location = New System.Drawing.Point(105, 43)
        Me.HorasTextBox.MaxLength = 8
        Me.HorasTextBox.Name = "HorasTextBox"
        Me.HorasTextBox.Size = New System.Drawing.Size(71, 20)
        Me.HorasTextBox.TabIndex = 45
        Me.HorasTextBox.Text = "00:00:00"
        '
        'cmdActualizarSucursal
        '
        Me.cmdActualizarSucursal.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdActualizarSucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdActualizarSucursal.FlatAppearance.BorderSize = 0
        Me.cmdActualizarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdActualizarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdActualizarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizarSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdActualizarSucursal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdActualizarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdActualizarSucursal.Location = New System.Drawing.Point(178, 233)
        Me.cmdActualizarSucursal.Name = "cmdActualizarSucursal"
        Me.cmdActualizarSucursal.Size = New System.Drawing.Size(140, 33)
        Me.cmdActualizarSucursal.TabIndex = 41
        Me.cmdActualizarSucursal.Text = "Actualizar Sucursal"
        Me.cmdActualizarSucursal.UseVisualStyleBackColor = False
        '
        'cmdGuardarSucursal
        '
        Me.cmdGuardarSucursal.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdGuardarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdGuardarSucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGuardarSucursal.FlatAppearance.BorderSize = 0
        Me.cmdGuardarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdGuardarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdGuardarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardarSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardarSucursal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGuardarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardarSucursal.Location = New System.Drawing.Point(31, 233)
        Me.cmdGuardarSucursal.Name = "cmdGuardarSucursal"
        Me.cmdGuardarSucursal.Size = New System.Drawing.Size(141, 33)
        Me.cmdGuardarSucursal.TabIndex = 37
        Me.cmdGuardarSucursal.Text = "Guardar Sucursal"
        Me.cmdGuardarSucursal.UseVisualStyleBackColor = False
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.Location = New System.Drawing.Point(542, 246)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(21, 20)
        Me.NombreTextBox1.TabIndex = 36
        Me.NombreTextBox1.Visible = False
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Location = New System.Drawing.Point(343, 246)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(21, 20)
        Me.CodigoTextBox.TabIndex = 3
        Me.CodigoTextBox.Visible = False
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.Location = New System.Drawing.Point(385, 246)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(21, 20)
        Me.IdclienteTextBox.TabIndex = 1
        Me.IdclienteTextBox.Visible = False
        '
        'CodigoTextBox1
        '
        Me.CodigoTextBox1.Location = New System.Drawing.Point(438, 246)
        Me.CodigoTextBox1.Name = "CodigoTextBox1"
        Me.CodigoTextBox1.Size = New System.Drawing.Size(21, 20)
        Me.CodigoTextBox1.TabIndex = 15
        Me.CodigoTextBox1.Visible = False
        '
        'IdsucursalTextBox
        '
        Me.IdsucursalTextBox.Location = New System.Drawing.Point(490, 246)
        Me.IdsucursalTextBox.Name = "IdsucursalTextBox"
        Me.IdsucursalTextBox.Size = New System.Drawing.Size(21, 20)
        Me.IdsucursalTextBox.TabIndex = 11
        Me.IdsucursalTextBox.Visible = False
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
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
        Me.TableAdapterManager.SucursalesTableAdapter = Me.SucursalesTableAdapter
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
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txtbusqueda)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cmdNuevo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.linea)
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(965, 51)
        Me.Panel2.TabIndex = 33
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeTotalClientesToolStripMenuItem, Me.ReporteDeSucursalesPorClienteToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeTotalClientesToolStripMenuItem
        '
        Me.ReporteDeTotalClientesToolStripMenuItem.Name = "ReporteDeTotalClientesToolStripMenuItem"
        Me.ReporteDeTotalClientesToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ReporteDeTotalClientesToolStripMenuItem.Text = "Reporte de Total Clientes"
        '
        'ReporteDeSucursalesPorClienteToolStripMenuItem
        '
        Me.ReporteDeSucursalesPorClienteToolStripMenuItem.Name = "ReporteDeSucursalesPorClienteToolStripMenuItem"
        Me.ReporteDeSucursalesPorClienteToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ReporteDeSucursalesPorClienteToolStripMenuItem.Text = "Reporte de Sucursales por Cliente"
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 684)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Tab_Clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormClientes"
        Me.Text = "Nuevo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelregistroclientes.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Clientes.ResumeLayout(False)
        Me.Clientes.ResumeLayout(False)
        Me.Sucursales.ResumeLayout(False)
        Me.PanelSucursales.ResumeLayout(False)
        Me.PanelSucursales.PerformLayout()
        Me.grupo.ResumeLayout(False)
        Me.grupo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents linea As Panel
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Panelregistroclientes As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdActualizarCliente As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SucursalesDataGridView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdAgregarSucursal As Button
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents SucursalesTableAdapter As ABASDataSetTableAdapters.SucursalesTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteTableAdapter As ABASDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents txt_rtn As TextBox
    Friend WithEvents FechainicioDateTimePicker As DateTimePicker
    Friend WithEvents FechafinalDateTimePicker As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_fechafinal As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_observacion As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents comentario As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents Tab_Clientes As TabControl
    Friend WithEvents Clientes As TabPage
    Friend WithEvents Sucursales As TabPage
    Friend WithEvents PanelSucursales As Panel
    Friend WithEvents grupo As GroupBox
    Friend WithEvents ComboBase As ComboBox
    Friend WithEvents Extras As TextBox
    Friend WithEvents observacion_sucursal As TextBox
    Friend WithEvents txt_empleados As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_isv As TextBox
    Friend WithEvents txt_subt As TextBox
    Friend WithEvents SucursalTextBox As TextBox
    Friend WithEvents Telefono1TextBox As TextBox
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents Telefono3TextBox As TextBox
    Friend WithEvents Telefono2TextBox As TextBox
    Friend WithEvents IdsucursalTextBox As TextBox
    Friend WithEvents HorasTextBox As TextBox
    Friend WithEvents CodigoTextBox1 As TextBox
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents cmdActualizarSucursal As Button
    Friend WithEvents cmdGuardarSucursal As Button
    Friend WithEvents EstadoSucur As ComboBox
    Friend WithEvents idsucursal As DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefono1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefono2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefono3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents horas As DataGridViewTextBoxColumn
    Friend WithEvents empleados As DataGridViewTextBoxColumn
    Friend WithEvents subt As DataGridViewTextBoxColumn
    Friend WithEvents isv As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents observacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents basehoras As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeTotalClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeSucursalesPorClienteToolStripMenuItem As ToolStripMenuItem
End Class
