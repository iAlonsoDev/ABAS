<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventarioProveedoresAlmacenesVehiculos
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim IdentificadorLabel As System.Windows.Forms.Label
        Dim RtnLabel As System.Windows.Forms.Label
        Dim NombrecontactoLabel As System.Windows.Forms.Label
        Dim TelefonocontactoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim AlmacenLabel As System.Windows.Forms.Label
        Dim PlacaLabel As System.Windows.Forms.Label
        Dim RevisionLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim FechadecompraLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim ChasisLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim AnioLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TelefonocontactoTextBox = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.NombrecontactoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RtnTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_telefono1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_telefono2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.Txt_web = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_cai = New System.Windows.Forms.TextBox()
        Me.Txt_correo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btm_eliminar = New System.Windows.Forms.Button()
        Me.btm_guardar = New System.Windows.Forms.Button()
        Me.btm_actualizar = New System.Windows.Forms.Button()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrecontacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonocontacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.IdentificadorTextBox = New System.Windows.Forms.TextBox()
        Me.AlmacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AlmacenesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.VehiculosDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CmdInsertarMunicion = New System.Windows.Forms.Button()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.VehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TipoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.AnioComboBox = New System.Windows.Forms.ComboBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.RevisionTextBox = New System.Windows.Forms.TextBox()
        Me.ChasisTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.FechadecompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProveedoresTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.AlmacenesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.AlmacenesTableAdapter()
        Me.VehiculosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.VehiculosTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeArmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        NombreLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        IdentificadorLabel = New System.Windows.Forms.Label()
        RtnLabel = New System.Windows.Forms.Label()
        NombrecontactoLabel = New System.Windows.Forms.Label()
        TelefonocontactoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        AlmacenLabel = New System.Windows.Forms.Label()
        PlacaLabel = New System.Windows.Forms.Label()
        RevisionLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        FechadecompraLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        ChasisLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        AnioLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AlmacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.VehiculosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(22, 48)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(108, 13)
        NombreLabel.TabIndex = 42
        NombreLabel.Text = "Nombre del Almacen:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(111, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 43
        IdLabel.Text = "Id:"
        '
        'IdentificadorLabel
        '
        IdentificadorLabel.AutoSize = True
        IdentificadorLabel.Location = New System.Drawing.Point(62, 74)
        IdentificadorLabel.Name = "IdentificadorLabel"
        IdentificadorLabel.Size = New System.Drawing.Size(68, 13)
        IdentificadorLabel.TabIndex = 44
        IdentificadorLabel.Text = "Identificador:"
        '
        'RtnLabel
        '
        RtnLabel.AutoSize = True
        RtnLabel.Location = New System.Drawing.Point(34, 144)
        RtnLabel.Name = "RtnLabel"
        RtnLabel.Size = New System.Drawing.Size(33, 13)
        RtnLabel.TabIndex = 50
        RtnLabel.Text = "RTN:"
        '
        'NombrecontactoLabel
        '
        NombrecontactoLabel.AutoSize = True
        NombrecontactoLabel.Location = New System.Drawing.Point(17, 22)
        NombrecontactoLabel.Name = "NombrecontactoLabel"
        NombrecontactoLabel.Size = New System.Drawing.Size(93, 13)
        NombrecontactoLabel.TabIndex = 0
        NombrecontactoLabel.Text = "Nombre Contacto:"
        '
        'TelefonocontactoLabel
        '
        TelefonocontactoLabel.AutoSize = True
        TelefonocontactoLabel.Location = New System.Drawing.Point(12, 48)
        TelefonocontactoLabel.Name = "TelefonocontactoLabel"
        TelefonocontactoLabel.Size = New System.Drawing.Size(98, 13)
        TelefonocontactoLabel.TabIndex = 2
        TelefonocontactoLabel.Text = "Telefono Contacto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(48, 31)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 0
        DescripcionLabel.Text = "Descripcion:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(74, 57)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 2
        MarcaLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(69, 84)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(45, 13)
        ModeloLabel.TabIndex = 4
        ModeloLabel.Text = "Modelo:"
        '
        'AlmacenLabel
        '
        AlmacenLabel.AutoSize = True
        AlmacenLabel.Location = New System.Drawing.Point(63, 110)
        AlmacenLabel.Name = "AlmacenLabel"
        AlmacenLabel.Size = New System.Drawing.Size(51, 13)
        AlmacenLabel.TabIndex = 6
        AlmacenLabel.Text = "Almacen:"
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = True
        PlacaLabel.Location = New System.Drawing.Point(77, 137)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(37, 13)
        PlacaLabel.TabIndex = 8
        PlacaLabel.Text = "Placa:"
        '
        'RevisionLabel
        '
        RevisionLabel.AutoSize = True
        RevisionLabel.Location = New System.Drawing.Point(63, 163)
        RevisionLabel.Name = "RevisionLabel"
        RevisionLabel.Size = New System.Drawing.Size(51, 13)
        RevisionLabel.TabIndex = 10
        RevisionLabel.Text = "Revision:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(61, 189)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(53, 13)
        MatriculaLabel.TabIndex = 12
        MatriculaLabel.Text = "Matricula:"
        '
        'FechadecompraLabel
        '
        FechadecompraLabel.AutoSize = True
        FechadecompraLabel.Location = New System.Drawing.Point(35, 218)
        FechadecompraLabel.Name = "FechadecompraLabel"
        FechadecompraLabel.Size = New System.Drawing.Size(79, 13)
        FechadecompraLabel.TabIndex = 14
        FechadecompraLabel.Text = "Fecha Compra:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(404, 31)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 16
        ColorLabel.Text = "Color:"
        '
        'ChasisLabel
        '
        ChasisLabel.AutoSize = True
        ChasisLabel.Location = New System.Drawing.Point(397, 58)
        ChasisLabel.Name = "ChasisLabel"
        ChasisLabel.Size = New System.Drawing.Size(41, 13)
        ChasisLabel.TabIndex = 18
        ChasisLabel.Text = "Chasis:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(369, 85)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 20
        ObservacionLabel.Text = "Observacion:"
        '
        'AnioLabel
        '
        AnioLabel.AutoSize = True
        AnioLabel.Location = New System.Drawing.Point(407, 114)
        AnioLabel.Name = "AnioLabel"
        AnioLabel.Size = New System.Drawing.Size(29, 13)
        AnioLabel.TabIndex = 22
        AnioLabel.Text = "Año:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(362, 170)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(75, 13)
        TipoLabel.TabIndex = 26
        TipoLabel.Text = "Tipo Vehiculo:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(350, 145)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(87, 13)
        CodigoLabel.TabIndex = 24
        CodigoLabel.Text = "Codigo Vehiculo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btm_eliminar)
        Me.GroupBox1.Controls.Add(Me.btm_guardar)
        Me.GroupBox1.Controls.Add(Me.btm_actualizar)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 251)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle del Proveedor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(TelefonocontactoLabel)
        Me.GroupBox3.Controls.Add(Me.TelefonocontactoTextBox)
        Me.GroupBox3.Controls.Add(NombrecontactoLabel)
        Me.GroupBox3.Controls.Add(Me.NombrecontactoTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(599, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 183)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Contacto"
        '
        'TelefonocontactoTextBox
        '
        Me.TelefonocontactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "telefonocontacto", True))
        Me.TelefonocontactoTextBox.Location = New System.Drawing.Point(118, 45)
        Me.TelefonocontactoTextBox.Name = "TelefonocontactoTextBox"
        Me.TelefonocontactoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonocontactoTextBox.TabIndex = 3
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombrecontactoTextBox
        '
        Me.NombrecontactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nombrecontacto", True))
        Me.NombrecontactoTextBox.Location = New System.Drawing.Point(118, 19)
        Me.NombrecontactoTextBox.Name = "NombrecontactoTextBox"
        Me.NombrecontactoTextBox.Size = New System.Drawing.Size(158, 20)
        Me.NombrecontactoTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(RtnLabel)
        Me.GroupBox2.Controls.Add(Me.RtnTextBox)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.txt_direccion)
        Me.GroupBox2.Controls.Add(Me.txt_telefono1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_codigo)
        Me.GroupBox2.Controls.Add(Me.txt_telefono2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_proveedor)
        Me.GroupBox2.Controls.Add(Me.Txt_web)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_cai)
        Me.GroupBox2.Controls.Add(Me.Txt_correo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 183)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Proveedor"
        '
        'RtnTextBox
        '
        Me.RtnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "rtn", True))
        Me.RtnTextBox.Location = New System.Drawing.Point(73, 141)
        Me.RtnTextBox.Name = "RtnTextBox"
        Me.RtnTextBox.Size = New System.Drawing.Size(222, 20)
        Me.RtnTextBox.TabIndex = 51
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ARMERIA", "UNIFORME", "MATERIALES", "EQUIPOS"})
        Me.ComboBox1.Location = New System.Drawing.Point(382, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 49
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(73, 65)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(222, 42)
        Me.txt_direccion.TabIndex = 40
        '
        'txt_telefono1
        '
        Me.txt_telefono1.Location = New System.Drawing.Point(382, 19)
        Me.txt_telefono1.Name = "txt_telefono1"
        Me.txt_telefono1.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono1.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Telefono 1:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(73, 19)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 31
        '
        'txt_telefono2
        '
        Me.txt_telefono2.Location = New System.Drawing.Point(382, 42)
        Me.txt_telefono2.Name = "txt_telefono2"
        Me.txt_telefono2.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono2.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "CAI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Telefono 2:"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(73, 42)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(222, 20)
        Me.txt_proveedor.TabIndex = 32
        '
        'Txt_web
        '
        Me.Txt_web.Location = New System.Drawing.Point(382, 65)
        Me.Txt_web.Name = "Txt_web"
        Me.Txt_web.Size = New System.Drawing.Size(176, 20)
        Me.Txt_web.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Sitio Web:"
        '
        'Txt_cai
        '
        Me.Txt_cai.Location = New System.Drawing.Point(73, 115)
        Me.Txt_cai.Name = "Txt_cai"
        Me.Txt_cai.Size = New System.Drawing.Size(222, 20)
        Me.Txt_cai.TabIndex = 49
        '
        'Txt_correo
        '
        Me.Txt_correo.Location = New System.Drawing.Point(382, 87)
        Me.Txt_correo.Name = "Txt_correo"
        Me.Txt_correo.Size = New System.Drawing.Size(176, 20)
        Me.Txt_correo.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(318, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Categoria:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Codigo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "E-Mail:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Button1.Location = New System.Drawing.Point(9, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 33)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btm_eliminar
        '
        Me.btm_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btm_eliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btm_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btm_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_eliminar.FlatAppearance.BorderSize = 0
        Me.btm_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btm_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btm_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btm_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btm_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btm_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btm_eliminar.Location = New System.Drawing.Point(267, 212)
        Me.btm_eliminar.Name = "btm_eliminar"
        Me.btm_eliminar.Size = New System.Drawing.Size(80, 33)
        Me.btm_eliminar.TabIndex = 38
        Me.btm_eliminar.Text = "Eliminar"
        Me.btm_eliminar.UseVisualStyleBackColor = False
        '
        'btm_guardar
        '
        Me.btm_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btm_guardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btm_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btm_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_guardar.FlatAppearance.BorderSize = 0
        Me.btm_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btm_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btm_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btm_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btm_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btm_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btm_guardar.Location = New System.Drawing.Point(95, 212)
        Me.btm_guardar.Name = "btm_guardar"
        Me.btm_guardar.Size = New System.Drawing.Size(80, 33)
        Me.btm_guardar.TabIndex = 39
        Me.btm_guardar.Text = "Guardar"
        Me.btm_guardar.UseVisualStyleBackColor = False
        '
        'btm_actualizar
        '
        Me.btm_actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btm_actualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.btm_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btm_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_actualizar.FlatAppearance.BorderSize = 0
        Me.btm_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btm_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btm_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btm_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btm_actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btm_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btm_actualizar.Location = New System.Drawing.Point(181, 212)
        Me.btm_actualizar.Name = "btm_actualizar"
        Me.btm_actualizar.Size = New System.Drawing.Size(80, 33)
        Me.btm_actualizar.TabIndex = 37
        Me.btm_actualizar.Text = "Actualizar"
        Me.btm_actualizar.UseVisualStyleBackColor = False
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ProveedoresDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ProveedoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProveedoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.nombrecontacto, Me.telefonocontacto, Me.rtn})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(3, 263)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.RowHeadersVisible = False
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(937, 353)
        Me.ProveedoresDataGridView.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idproveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idproveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 88
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreproveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreproveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 115
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefono2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telefono2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 76
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "correo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 62
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cai"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cai"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 46
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "web"
        Me.DataGridViewTextBoxColumn8.HeaderText = "web"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 52
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn9.HeaderText = "categoria"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 76
        '
        'nombrecontacto
        '
        Me.nombrecontacto.DataPropertyName = "nombrecontacto"
        Me.nombrecontacto.HeaderText = "nombrecontacto"
        Me.nombrecontacto.Name = "nombrecontacto"
        Me.nombrecontacto.Width = 109
        '
        'telefonocontacto
        '
        Me.telefonocontacto.DataPropertyName = "telefonocontacto"
        Me.telefonocontacto.HeaderText = "telefonocontacto"
        Me.telefonocontacto.Name = "telefonocontacto"
        Me.telefonocontacto.Width = 112
        '
        'rtn
        '
        Me.rtn.DataPropertyName = "rtn"
        Me.rtn.HeaderText = "rtn"
        Me.rtn.Name = "rtn"
        Me.rtn.Width = 44
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(953, 648)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ProveedoresDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(945, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proveedores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.AlmacenesDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(945, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Almacenes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(IdentificadorLabel)
        Me.GroupBox4.Controls.Add(Me.IdentificadorTextBox)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(IdLabel)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.IdTextBox)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(NombreLabel)
        Me.GroupBox4.Controls.Add(Me.NombreTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(933, 167)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle del Almacen"
        '
        'IdentificadorTextBox
        '
        Me.IdentificadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenesBindingSource, "Identificador", True))
        Me.IdentificadorTextBox.Location = New System.Drawing.Point(136, 71)
        Me.IdentificadorTextBox.Name = "IdentificadorTextBox"
        Me.IdentificadorTextBox.ReadOnly = True
        Me.IdentificadorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdentificadorTextBox.TabIndex = 45
        '
        'AlmacenesBindingSource
        '
        Me.AlmacenesBindingSource.DataMember = "Almacenes"
        Me.AlmacenesBindingSource.DataSource = Me.ABASDataSet
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
        Me.Button4.Location = New System.Drawing.Point(182, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 33)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = False
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
        Me.Button5.Location = New System.Drawing.Point(10, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 33)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "Nuevo"
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(96, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 33)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(136, 19)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 44
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Button2.Location = New System.Drawing.Point(268, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 33)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlmacenesBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(136, 45)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(201, 20)
        Me.NombreTextBox.TabIndex = 43
        '
        'AlmacenesDataGridView
        '
        Me.AlmacenesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlmacenesDataGridView.AutoGenerateColumns = False
        Me.AlmacenesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AlmacenesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.AlmacenesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.AlmacenesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlmacenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlmacenesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.Identificador})
        Me.AlmacenesDataGridView.DataSource = Me.AlmacenesBindingSource
        Me.AlmacenesDataGridView.Location = New System.Drawing.Point(6, 179)
        Me.AlmacenesDataGridView.Name = "AlmacenesDataGridView"
        Me.AlmacenesDataGridView.RowHeadersVisible = False
        Me.AlmacenesDataGridView.Size = New System.Drawing.Size(933, 437)
        Me.AlmacenesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 41
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 69
        '
        'Identificador
        '
        Me.Identificador.DataPropertyName = "Identificador"
        Me.Identificador.HeaderText = "Identificador"
        Me.Identificador.Name = "Identificador"
        Me.Identificador.Width = 90
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.VehiculosDataGridView)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(945, 622)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Vehiculos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'VehiculosDataGridView
        '
        Me.VehiculosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VehiculosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.VehiculosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.VehiculosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.VehiculosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VehiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehiculosDataGridView.Location = New System.Drawing.Point(3, 340)
        Me.VehiculosDataGridView.Name = "VehiculosDataGridView"
        Me.VehiculosDataGridView.RowHeadersVisible = False
        Me.VehiculosDataGridView.Size = New System.Drawing.Size(936, 279)
        Me.VehiculosDataGridView.TabIndex = 28
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.ComboBox2)
        Me.GroupBox5.Controls.Add(Me.CmdInsertarMunicion)
        Me.GroupBox5.Controls.Add(Me.MarcaTextBox)
        Me.GroupBox5.Controls.Add(Me.ColorTextBox)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox5.Controls.Add(TipoLabel)
        Me.GroupBox5.Controls.Add(DescripcionLabel)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Controls.Add(Me.TipoRadioButton)
        Me.GroupBox5.Controls.Add(MarcaLabel)
        Me.GroupBox5.Controls.Add(CodigoLabel)
        Me.GroupBox5.Controls.Add(Me.ModeloTextBox)
        Me.GroupBox5.Controls.Add(Me.CodigoTextBox)
        Me.GroupBox5.Controls.Add(ModeloLabel)
        Me.GroupBox5.Controls.Add(AnioLabel)
        Me.GroupBox5.Controls.Add(Me.AnioComboBox)
        Me.GroupBox5.Controls.Add(AlmacenLabel)
        Me.GroupBox5.Controls.Add(ObservacionLabel)
        Me.GroupBox5.Controls.Add(Me.PlacaTextBox)
        Me.GroupBox5.Controls.Add(Me.ObservacionTextBox)
        Me.GroupBox5.Controls.Add(PlacaLabel)
        Me.GroupBox5.Controls.Add(ChasisLabel)
        Me.GroupBox5.Controls.Add(Me.RevisionTextBox)
        Me.GroupBox5.Controls.Add(Me.ChasisTextBox)
        Me.GroupBox5.Controls.Add(RevisionLabel)
        Me.GroupBox5.Controls.Add(ColorLabel)
        Me.GroupBox5.Controls.Add(Me.MatriculaTextBox)
        Me.GroupBox5.Controls.Add(MatriculaLabel)
        Me.GroupBox5.Controls.Add(FechadecompraLabel)
        Me.GroupBox5.Controls.Add(Me.FechadecompraDateTimePicker)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(933, 328)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Vehiculo"
        '
        'ComboBox2
        '
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(121, 107)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 66
        '
        'CmdInsertarMunicion
        '
        Me.CmdInsertarMunicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdInsertarMunicion.BackColor = System.Drawing.Color.SteelBlue
        Me.CmdInsertarMunicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdInsertarMunicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdInsertarMunicion.FlatAppearance.BorderSize = 0
        Me.CmdInsertarMunicion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdInsertarMunicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdInsertarMunicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdInsertarMunicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdInsertarMunicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CmdInsertarMunicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdInsertarMunicion.Location = New System.Drawing.Point(671, 286)
        Me.CmdInsertarMunicion.Name = "CmdInsertarMunicion"
        Me.CmdInsertarMunicion.Size = New System.Drawing.Size(157, 26)
        Me.CmdInsertarMunicion.TabIndex = 65
        Me.CmdInsertarMunicion.Text = "Seleccionar Imagen"
        Me.CmdInsertarMunicion.UseVisualStyleBackColor = False
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(118, 55)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(184, 20)
        Me.MarcaTextBox.TabIndex = 49
        '
        'VehiculosBindingSource
        '
        Me.VehiculosBindingSource.DataMember = "Vehiculos"
        Me.VehiculosBindingSource.DataSource = Me.ABASDataSet
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(443, 28)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(195, 20)
        Me.ColorTextBox.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(583, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 208)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Button6.Location = New System.Drawing.Point(186, 282)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 33)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "Actualizar"
        Me.Button6.UseVisualStyleBackColor = False
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
        Me.Button7.Location = New System.Drawing.Point(14, 282)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 33)
        Me.Button7.TabIndex = 45
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
        Me.Button8.Location = New System.Drawing.Point(100, 282)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 33)
        Me.Button8.TabIndex = 46
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
        Me.Button9.Location = New System.Drawing.Point(272, 282)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 33)
        Me.Button9.TabIndex = 44
        Me.Button9.Text = "Eliminar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(118, 28)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(184, 20)
        Me.DescripcionTextBox.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(443, 194)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton1.TabIndex = 27
        Me.RadioButton1.Text = "Motocicleta"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TipoRadioButton
        '
        Me.TipoRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VehiculosBindingSource, "tipo", True))
        Me.TipoRadioButton.Location = New System.Drawing.Point(443, 164)
        Me.TipoRadioButton.Name = "TipoRadioButton"
        Me.TipoRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.TipoRadioButton.TabIndex = 27
        Me.TipoRadioButton.Text = "Automovil"
        Me.TipoRadioButton.UseVisualStyleBackColor = True
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(118, 81)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(184, 20)
        Me.ModeloTextBox.TabIndex = 5
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(443, 138)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 25
        '
        'AnioComboBox
        '
        Me.AnioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "anio", True))
        Me.AnioComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnioComboBox.FormattingEnabled = True
        Me.AnioComboBox.Location = New System.Drawing.Point(443, 111)
        Me.AnioComboBox.Name = "AnioComboBox"
        Me.AnioComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AnioComboBox.TabIndex = 23
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "placa", True))
        Me.PlacaTextBox.Location = New System.Drawing.Point(118, 134)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(184, 20)
        Me.PlacaTextBox.TabIndex = 9
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(443, 82)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ObservacionTextBox.TabIndex = 21
        '
        'RevisionTextBox
        '
        Me.RevisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "revision", True))
        Me.RevisionTextBox.Location = New System.Drawing.Point(118, 160)
        Me.RevisionTextBox.Name = "RevisionTextBox"
        Me.RevisionTextBox.Size = New System.Drawing.Size(184, 20)
        Me.RevisionTextBox.TabIndex = 11
        '
        'ChasisTextBox
        '
        Me.ChasisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "chasis", True))
        Me.ChasisTextBox.Location = New System.Drawing.Point(443, 55)
        Me.ChasisTextBox.Name = "ChasisTextBox"
        Me.ChasisTextBox.Size = New System.Drawing.Size(199, 20)
        Me.ChasisTextBox.TabIndex = 19
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "matricula", True))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(118, 186)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(184, 20)
        Me.MatriculaTextBox.TabIndex = 13
        '
        'FechadecompraDateTimePicker
        '
        Me.FechadecompraDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.FechadecompraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculosBindingSource, "fechadecompra", True))
        Me.FechadecompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechadecompraDateTimePicker.Location = New System.Drawing.Point(118, 211)
        Me.FechadecompraDateTimePicker.Name = "FechadecompraDateTimePicker"
        Me.FechadecompraDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechadecompraDateTimePicker.TabIndex = 15
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
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
        'AlmacenesTableAdapter
        '
        Me.AlmacenesTableAdapter.ClearBeforeFill = True
        '
        'VehiculosTableAdapter
        '
        Me.VehiculosTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeArmasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeArmasToolStripMenuItem
        '
        Me.ReporteDeArmasToolStripMenuItem.Name = "ReporteDeArmasToolStripMenuItem"
        Me.ReporteDeArmasToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ReporteDeArmasToolStripMenuItem.Text = "Reporte de Vehiculos por Tipo"
        '
        'FormInventarioProveedoresAlmacenesVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 691)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInventarioProveedoresAlmacenesVehiculos"
        Me.Text = "FormProveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.AlmacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.VehiculosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents btm_eliminar As Button
    Friend WithEvents btm_guardar As Button
    Friend WithEvents btm_actualizar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_proveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telefono2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_telefono1 As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_cai As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_web As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_correo As TextBox
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As ABASDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresDataGridView As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AlmacenesBindingSource As BindingSource
    Friend WithEvents AlmacenesTableAdapter As ABASDataSetTableAdapters.AlmacenesTableAdapter
    Friend WithEvents AlmacenesDataGridView As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Identificador As DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorTextBox As TextBox
    Friend WithEvents TelefonocontactoTextBox As TextBox
    Friend WithEvents NombrecontactoTextBox As TextBox
    Friend WithEvents RtnTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents nombrecontacto As DataGridViewTextBoxColumn
    Friend WithEvents telefonocontacto As DataGridViewTextBoxColumn
    Friend WithEvents rtn As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents VehiculosBindingSource As BindingSource
    Friend WithEvents VehiculosTableAdapter As ABASDataSetTableAdapters.VehiculosTableAdapter
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents RevisionTextBox As TextBox
    Friend WithEvents PlacaTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TipoRadioButton As RadioButton
    Friend WithEvents AnioComboBox As ComboBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents ChasisTextBox As TextBox
    Friend WithEvents FechadecompraDateTimePicker As DateTimePicker
    Friend WithEvents VehiculosDataGridView As DataGridView
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents CmdInsertarMunicion As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeArmasToolStripMenuItem As ToolStripMenuItem
End Class
