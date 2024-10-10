<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventarioMaterialesEquiposSeguridad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DescripcionLabel1 As System.Windows.Forms.Label
        Dim EstadoLabel1 As System.Windows.Forms.Label
        Dim IduniformeLabel1 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim IduniformeLabel As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialesPorAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimeintosDeMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TipoMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.MaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.IdMaterialTextBox = New System.Windows.Forms.TextBox()
        Me.Cmd_Limpiar = New System.Windows.Forms.Button()
        Me.CmdRegistrarMateriales = New System.Windows.Forms.Button()
        Me.CmdAgregarMateriales = New System.Windows.Forms.Button()
        Me.EstadoMateriales = New System.Windows.Forms.ComboBox()
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CantFinal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CantMateriales = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CantInicial = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.DescripcionRecibe = New System.Windows.Forms.TextBox()
        Me.IDmaterialrecibe = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.IdMov = New System.Windows.Forms.TextBox()
        Me.EstadoRecibe = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.ComboRecibe = New System.Windows.Forms.ComboBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CantRecibe = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Cmd_Recibir = New System.Windows.Forms.Button()
        Me.MaterialesDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cmd_Nuevo = New System.Windows.Forms.Button()
        Me.Cmd_Transferir = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EstadoMovimiento = New System.Windows.Forms.TextBox()
        Me.DescripcionMovimiento = New System.Windows.Forms.TextBox()
        Me.IdMaterialMovimiento = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CantFinRecibe = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CantMovRecibe = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CantIniRecibe = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboHacia = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboDesde = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CantFinalEnvia = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CantMoverEnvia = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CantIniEnvia = New System.Windows.Forms.TextBox()
        Me.MovimientoMaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.MovimientoMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovimientoEquiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.MovimientoEquiposTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.MovimientoEquiposTableAdapter()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.EquiposTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EquiposTableAdapter()
        Me.MaterialesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.MaterialesTableAdapter()
        Me.MovimientoMaterialesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.MovimientoMaterialesTableAdapter()
        Me.TipoMaterialesTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.TipoMaterialesTableAdapter()
        DescripcionLabel1 = New System.Windows.Forms.Label()
        EstadoLabel1 = New System.Windows.Forms.Label()
        IduniformeLabel1 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        IduniformeLabel = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.MaterialesDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.MovimientoMaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoEquiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel1
        '
        DescripcionLabel1.AutoSize = True
        DescripcionLabel1.Location = New System.Drawing.Point(27, 32)
        DescripcionLabel1.Name = "DescripcionLabel1"
        DescripcionLabel1.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel1.TabIndex = 15
        DescripcionLabel1.Text = "Descripcion:"
        '
        'EstadoLabel1
        '
        EstadoLabel1.AutoSize = True
        EstadoLabel1.Location = New System.Drawing.Point(48, 57)
        EstadoLabel1.Name = "EstadoLabel1"
        EstadoLabel1.Size = New System.Drawing.Size(43, 13)
        EstadoLabel1.TabIndex = 16
        EstadoLabel1.Text = "Estado:"
        '
        'IduniformeLabel1
        '
        IduniformeLabel1.AutoSize = True
        IduniformeLabel1.Location = New System.Drawing.Point(70, 109)
        IduniformeLabel1.Name = "IduniformeLabel1"
        IduniformeLabel1.Size = New System.Drawing.Size(21, 13)
        IduniformeLabel1.TabIndex = 42
        IduniformeLabel1.Text = "ID:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(35, 72)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(43, 13)
        Label24.TabIndex = 23
        Label24.Text = "Estado:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(12, 21)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(66, 13)
        Label25.TabIndex = 19
        Label25.Text = "Descripcion:"
        '
        'IduniformeLabel
        '
        IduniformeLabel.AutoSize = True
        IduniformeLabel.Location = New System.Drawing.Point(17, 46)
        IduniformeLabel.Name = "IduniformeLabel"
        IduniformeLabel.Size = New System.Drawing.Size(61, 13)
        IduniformeLabel.TabIndex = 21
        IduniformeLabel.Text = "ID Material:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Location = New System.Drawing.Point(22, 43)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(66, 13)
        Label28.TabIndex = 11
        Label28.Text = "Descripcion:"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Location = New System.Drawing.Point(43, 122)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(45, 13)
        Label30.TabIndex = 12
        Label30.Text = "ID Mov:"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Location = New System.Drawing.Point(45, 96)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(43, 13)
        Label31.TabIndex = 16
        Label31.Text = "Estado:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(43, 148)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(42, 13)
        Label27.TabIndex = 12
        Label27.Text = "ID Mat:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(9, 22)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(137, 13)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Nombre de Nuevo Material:"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(949, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Inventario Materiales y Equipo de Seguridad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(949, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterialesPorAlmacenToolStripMenuItem, Me.MovimeintosDeMaterialesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MaterialesPorAlmacenToolStripMenuItem
        '
        Me.MaterialesPorAlmacenToolStripMenuItem.Name = "MaterialesPorAlmacenToolStripMenuItem"
        Me.MaterialesPorAlmacenToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.MaterialesPorAlmacenToolStripMenuItem.Text = "Materiales por Almacen"
        '
        'MovimeintosDeMaterialesToolStripMenuItem
        '
        Me.MovimeintosDeMaterialesToolStripMenuItem.Name = "MovimeintosDeMaterialesToolStripMenuItem"
        Me.MovimeintosDeMaterialesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.MovimeintosDeMaterialesToolStripMenuItem.Text = "Movimientos de Materiales"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(4, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(945, 606)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.MaterialesDataGridView)
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(937, 580)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Registro de Materiales / Equipos de Seguridad"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Nuevo Tipo Material"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_add_96
        Me.PictureBox2.Location = New System.Drawing.Point(404, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoMaterialesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(152, 19)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(248, 20)
        Me.NombreTextBox.TabIndex = 1
        '
        'TipoMaterialesBindingSource
        '
        Me.TipoMaterialesBindingSource.DataMember = "TipoMateriales"
        Me.TipoMaterialesBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesDataGridView
        '
        Me.MaterialesDataGridView.AllowUserToDeleteRows = False
        Me.MaterialesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MaterialesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MaterialesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.MaterialesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesDataGridView.Location = New System.Drawing.Point(0, 251)
        Me.MaterialesDataGridView.Name = "MaterialesDataGridView"
        Me.MaterialesDataGridView.ReadOnly = True
        Me.MaterialesDataGridView.RowHeadersVisible = False
        Me.MaterialesDataGridView.Size = New System.Drawing.Size(934, 326)
        Me.MaterialesDataGridView.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox6.Controls.Add(Me.IdMaterialTextBox)
        Me.GroupBox6.Controls.Add(IduniformeLabel1)
        Me.GroupBox6.Controls.Add(Me.Cmd_Limpiar)
        Me.GroupBox6.Controls.Add(Me.CmdRegistrarMateriales)
        Me.GroupBox6.Controls.Add(Me.CmdAgregarMateriales)
        Me.GroupBox6.Controls.Add(Me.EstadoMateriales)
        Me.GroupBox6.Controls.Add(EstadoLabel1)
        Me.GroupBox6.Controls.Add(DescripcionLabel1)
        Me.GroupBox6.Controls.Add(Me.DescripcionComboBox)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(923, 183)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalle de Materiales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Fecha Registro:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(97, 81)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 44
        '
        'IdMaterialTextBox
        '
        Me.IdMaterialTextBox.Location = New System.Drawing.Point(97, 106)
        Me.IdMaterialTextBox.Name = "IdMaterialTextBox"
        Me.IdMaterialTextBox.ReadOnly = True
        Me.IdMaterialTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IdMaterialTextBox.TabIndex = 43
        '
        'Cmd_Limpiar
        '
        Me.Cmd_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Cmd_Limpiar.Location = New System.Drawing.Point(6, 142)
        Me.Cmd_Limpiar.Name = "Cmd_Limpiar"
        Me.Cmd_Limpiar.Size = New System.Drawing.Size(88, 33)
        Me.Cmd_Limpiar.TabIndex = 41
        Me.Cmd_Limpiar.Text = "Limpiar"
        Me.Cmd_Limpiar.UseVisualStyleBackColor = False
        '
        'CmdRegistrarMateriales
        '
        Me.CmdRegistrarMateriales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdRegistrarMateriales.BackColor = System.Drawing.Color.SteelBlue
        Me.CmdRegistrarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdRegistrarMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdRegistrarMateriales.FlatAppearance.BorderSize = 0
        Me.CmdRegistrarMateriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdRegistrarMateriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdRegistrarMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRegistrarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRegistrarMateriales.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CmdRegistrarMateriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdRegistrarMateriales.Location = New System.Drawing.Point(97, 142)
        Me.CmdRegistrarMateriales.Name = "CmdRegistrarMateriales"
        Me.CmdRegistrarMateriales.Size = New System.Drawing.Size(117, 33)
        Me.CmdRegistrarMateriales.TabIndex = 40
        Me.CmdRegistrarMateriales.Text = "Registrar"
        Me.CmdRegistrarMateriales.UseVisualStyleBackColor = False
        '
        'CmdAgregarMateriales
        '
        Me.CmdAgregarMateriales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdAgregarMateriales.BackColor = System.Drawing.Color.SteelBlue
        Me.CmdAgregarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdAgregarMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdAgregarMateriales.FlatAppearance.BorderSize = 0
        Me.CmdAgregarMateriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdAgregarMateriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdAgregarMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAgregarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAgregarMateriales.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CmdAgregarMateriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAgregarMateriales.Location = New System.Drawing.Point(217, 142)
        Me.CmdAgregarMateriales.Name = "CmdAgregarMateriales"
        Me.CmdAgregarMateriales.Size = New System.Drawing.Size(124, 33)
        Me.CmdAgregarMateriales.TabIndex = 39
        Me.CmdAgregarMateriales.Text = "Cargar / Agregar"
        Me.CmdAgregarMateriales.UseVisualStyleBackColor = False
        '
        'EstadoMateriales
        '
        Me.EstadoMateriales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "estado", True))
        Me.EstadoMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoMateriales.FormattingEnabled = True
        Me.EstadoMateriales.Items.AddRange(New Object() {"A", "B", "C"})
        Me.EstadoMateriales.Location = New System.Drawing.Point(97, 54)
        Me.EstadoMateriales.Name = "EstadoMateriales"
        Me.EstadoMateriales.Size = New System.Drawing.Size(121, 21)
        Me.EstadoMateriales.TabIndex = 17
        '
        'MaterialesBindingSource
        '
        Me.MaterialesBindingSource.DataMember = "Materiales"
        Me.MaterialesBindingSource.DataSource = Me.ABASDataSet
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "descripcion", True))
        Me.DescripcionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(97, 29)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(233, 21)
        Me.DescripcionComboBox.TabIndex = 16
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.CantFinal)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.CantMateriales)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.CantInicial)
        Me.GroupBox8.Location = New System.Drawing.Point(523, 19)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(227, 108)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Cantidades"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Inventario Final:"
        '
        'CantFinal
        '
        Me.CantFinal.Location = New System.Drawing.Point(107, 67)
        Me.CantFinal.Name = "CantFinal"
        Me.CantFinal.ReadOnly = True
        Me.CantFinal.Size = New System.Drawing.Size(79, 20)
        Me.CantFinal.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Cant Ingresar:"
        '
        'CantMateriales
        '
        Me.CantMateriales.Location = New System.Drawing.Point(107, 41)
        Me.CantMateriales.Name = "CantMateriales"
        Me.CantMateriales.Size = New System.Drawing.Size(79, 20)
        Me.CantMateriales.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Cant Actual:"
        '
        'CantInicial
        '
        Me.CantInicial.Location = New System.Drawing.Point(107, 15)
        Me.CantInicial.Name = "CantInicial"
        Me.CantInicial.ReadOnly = True
        Me.CantInicial.Size = New System.Drawing.Size(79, 20)
        Me.CantInicial.TabIndex = 12
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ComboBox2)
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(352, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(151, 87)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Almacen"
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(16, 46)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.Panel4)
        Me.TabPage5.Controls.Add(Me.MaterialesDataGridView1)
        Me.TabPage5.Controls.Add(Me.Cmd_Nuevo)
        Me.TabPage5.Controls.Add(Me.Cmd_Transferir)
        Me.TabPage5.Controls.Add(Me.GroupBox12)
        Me.TabPage5.Controls.Add(Me.GroupBox9)
        Me.TabPage5.Controls.Add(Me.GroupBox10)
        Me.TabPage5.Controls.Add(Me.GroupBox11)
        Me.TabPage5.Controls.Add(Me.MovimientoMaterialesDataGridView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(937, 580)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Transferir / Recibir Materiales y Equipo de Seguridad"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox13)
        Me.Panel4.Controls.Add(Me.GroupBox14)
        Me.Panel4.Controls.Add(Me.Cmd_Recibir)
        Me.Panel4.Location = New System.Drawing.Point(165, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(614, 209)
        Me.Panel4.TabIndex = 55
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Label26)
        Me.GroupBox13.Controls.Add(Label28)
        Me.GroupBox13.Controls.Add(Me.Label29)
        Me.GroupBox13.Controls.Add(Me.DescripcionRecibe)
        Me.GroupBox13.Controls.Add(Me.IDmaterialrecibe)
        Me.GroupBox13.Controls.Add(Label27)
        Me.GroupBox13.Controls.Add(Me.ComboBox5)
        Me.GroupBox13.Controls.Add(Me.IdMov)
        Me.GroupBox13.Controls.Add(Label30)
        Me.GroupBox13.Controls.Add(Me.EstadoRecibe)
        Me.GroupBox13.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox13.Controls.Add(Me.ComboRecibe)
        Me.GroupBox13.Controls.Add(Label31)
        Me.GroupBox13.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(354, 184)
        Me.GroupBox13.TabIndex = 61
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Datos del Envio"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(11, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 13)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "Fecha Recibe:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(37, 69)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(51, 13)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Almacen:"
        '
        'DescripcionRecibe
        '
        Me.DescripcionRecibe.Location = New System.Drawing.Point(94, 40)
        Me.DescripcionRecibe.Name = "DescripcionRecibe"
        Me.DescripcionRecibe.ReadOnly = True
        Me.DescripcionRecibe.Size = New System.Drawing.Size(243, 20)
        Me.DescripcionRecibe.TabIndex = 12
        '
        'IDmaterialrecibe
        '
        Me.IDmaterialrecibe.Location = New System.Drawing.Point(94, 145)
        Me.IDmaterialrecibe.Name = "IDmaterialrecibe"
        Me.IDmaterialrecibe.ReadOnly = True
        Me.IDmaterialrecibe.Size = New System.Drawing.Size(100, 20)
        Me.IDmaterialrecibe.TabIndex = 13
        '
        'ComboBox5
        '
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox5.Location = New System.Drawing.Point(233, 66)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox5.TabIndex = 58
        '
        'IdMov
        '
        Me.IdMov.Location = New System.Drawing.Point(94, 119)
        Me.IdMov.Name = "IdMov"
        Me.IdMov.ReadOnly = True
        Me.IdMov.Size = New System.Drawing.Size(100, 20)
        Me.IdMov.TabIndex = 13
        '
        'EstadoRecibe
        '
        Me.EstadoRecibe.Location = New System.Drawing.Point(94, 93)
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
        Me.DateTimePicker3.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker3.TabIndex = 56
        '
        'ComboRecibe
        '
        Me.ComboRecibe.Enabled = False
        Me.ComboRecibe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboRecibe.FormattingEnabled = True
        Me.ComboRecibe.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboRecibe.Location = New System.Drawing.Point(94, 66)
        Me.ComboRecibe.Name = "ComboRecibe"
        Me.ComboRecibe.Size = New System.Drawing.Size(133, 21)
        Me.ComboRecibe.TabIndex = 58
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Label32)
        Me.GroupBox14.Controls.Add(Me.TextBox9)
        Me.GroupBox14.Controls.Add(Me.Label33)
        Me.GroupBox14.Controls.Add(Me.CantRecibe)
        Me.GroupBox14.Controls.Add(Me.Label34)
        Me.GroupBox14.Controls.Add(Me.TextBox11)
        Me.GroupBox14.Location = New System.Drawing.Point(389, 9)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(208, 133)
        Me.GroupBox14.TabIndex = 60
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Cantidad Recibe"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(22, 73)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(57, 13)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Cant Final:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(85, 70)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 16
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(11, 48)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 13)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Cant Recibir:"
        '
        'CantRecibe
        '
        Me.CantRecibe.Location = New System.Drawing.Point(85, 45)
        Me.CantRecibe.Name = "CantRecibe"
        Me.CantRecibe.ReadOnly = True
        Me.CantRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantRecibe.TabIndex = 14
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(14, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(65, 13)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Cant Actual:"
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
        Me.Cmd_Recibir.Location = New System.Drawing.Point(389, 160)
        Me.Cmd_Recibir.Name = "Cmd_Recibir"
        Me.Cmd_Recibir.Size = New System.Drawing.Size(208, 33)
        Me.Cmd_Recibir.TabIndex = 55
        Me.Cmd_Recibir.Text = "Aceptar / Recibir"
        Me.Cmd_Recibir.UseVisualStyleBackColor = False
        '
        'MaterialesDataGridView1
        '
        Me.MaterialesDataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaterialesDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MaterialesDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MaterialesDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.MaterialesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesDataGridView1.Location = New System.Drawing.Point(160, 108)
        Me.MaterialesDataGridView1.Name = "MaterialesDataGridView1"
        Me.MaterialesDataGridView1.RowHeadersVisible = False
        Me.MaterialesDataGridView1.Size = New System.Drawing.Size(627, 268)
        Me.MaterialesDataGridView1.TabIndex = 43
        '
        'Cmd_Nuevo
        '
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
        Me.Cmd_Nuevo.Location = New System.Drawing.Point(6, 143)
        Me.Cmd_Nuevo.Name = "Cmd_Nuevo"
        Me.Cmd_Nuevo.Size = New System.Drawing.Size(88, 33)
        Me.Cmd_Nuevo.TabIndex = 42
        Me.Cmd_Nuevo.Text = "Nuevo"
        Me.Cmd_Nuevo.UseVisualStyleBackColor = False
        '
        'Cmd_Transferir
        '
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
        Me.Cmd_Transferir.Location = New System.Drawing.Point(100, 143)
        Me.Cmd_Transferir.Name = "Cmd_Transferir"
        Me.Cmd_Transferir.Size = New System.Drawing.Size(88, 33)
        Me.Cmd_Transferir.TabIndex = 41
        Me.Cmd_Transferir.Text = "Transferir"
        Me.Cmd_Transferir.UseVisualStyleBackColor = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.PictureBox1)
        Me.GroupBox12.Controls.Add(Me.EstadoMovimiento)
        Me.GroupBox12.Controls.Add(Label24)
        Me.GroupBox12.Controls.Add(Me.DescripcionMovimiento)
        Me.GroupBox12.Controls.Add(Label25)
        Me.GroupBox12.Controls.Add(Me.IdMaterialMovimiento)
        Me.GroupBox12.Controls.Add(IduniformeLabel)
        Me.GroupBox12.Location = New System.Drawing.Point(274, 7)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(246, 130)
        Me.GroupBox12.TabIndex = 22
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Detalle Movimiento"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(213, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'EstadoMovimiento
        '
        Me.EstadoMovimiento.Location = New System.Drawing.Point(84, 69)
        Me.EstadoMovimiento.Name = "EstadoMovimiento"
        Me.EstadoMovimiento.ReadOnly = True
        Me.EstadoMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.EstadoMovimiento.TabIndex = 24
        '
        'DescripcionMovimiento
        '
        Me.DescripcionMovimiento.Location = New System.Drawing.Point(83, 18)
        Me.DescripcionMovimiento.Name = "DescripcionMovimiento"
        Me.DescripcionMovimiento.ReadOnly = True
        Me.DescripcionMovimiento.Size = New System.Drawing.Size(150, 20)
        Me.DescripcionMovimiento.TabIndex = 20
        '
        'IdMaterialMovimiento
        '
        Me.IdMaterialMovimiento.Location = New System.Drawing.Point(84, 44)
        Me.IdMaterialMovimiento.Name = "IdMaterialMovimiento"
        Me.IdMaterialMovimiento.ReadOnly = True
        Me.IdMaterialMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.IdMaterialMovimiento.TabIndex = 22
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label15)
        Me.GroupBox9.Controls.Add(Me.CantFinRecibe)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.CantMovRecibe)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.CantIniRecibe)
        Me.GroupBox9.Location = New System.Drawing.Point(730, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox9.TabIndex = 21
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Cantidad Recibe"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Cant Final:"
        '
        'CantFinRecibe
        '
        Me.CantFinRecibe.Location = New System.Drawing.Point(85, 70)
        Me.CantFinRecibe.Name = "CantFinRecibe"
        Me.CantFinRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantFinRecibe.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Cant Mover:"
        '
        'CantMovRecibe
        '
        Me.CantMovRecibe.Location = New System.Drawing.Point(85, 45)
        Me.CantMovRecibe.Name = "CantMovRecibe"
        Me.CantMovRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantMovRecibe.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Cant Actual:"
        '
        'CantIniRecibe
        '
        Me.CantIniRecibe.Location = New System.Drawing.Point(85, 20)
        Me.CantIniRecibe.Name = "CantIniRecibe"
        Me.CantIniRecibe.Size = New System.Drawing.Size(100, 20)
        Me.CantIniRecibe.TabIndex = 12
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label18)
        Me.GroupBox10.Controls.Add(Me.FechaMovimiento)
        Me.GroupBox10.Controls.Add(Me.Label19)
        Me.GroupBox10.Controls.Add(Me.ComboBox4)
        Me.GroupBox10.Controls.Add(Me.ComboHacia)
        Me.GroupBox10.Controls.Add(Me.Label20)
        Me.GroupBox10.Controls.Add(Me.ComboBox3)
        Me.GroupBox10.Controls.Add(Me.ComboDesde)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(262, 131)
        Me.GroupBox10.TabIndex = 19
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Almacenes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Fecha Movimiento:"
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Hacia:"
        '
        'ComboBox4
        '
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox4.Location = New System.Drawing.Point(181, 45)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox4.TabIndex = 2
        '
        'ComboHacia
        '
        Me.ComboHacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboHacia.FormattingEnabled = True
        Me.ComboHacia.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboHacia.Location = New System.Drawing.Point(56, 47)
        Me.ComboHacia.Name = "ComboHacia"
        Me.ComboHacia.Size = New System.Drawing.Size(121, 21)
        Me.ComboHacia.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Desde:"
        '
        'ComboBox3
        '
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboBox3.Location = New System.Drawing.Point(181, 19)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox3.TabIndex = 0
        '
        'ComboDesde
        '
        Me.ComboDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboDesde.FormattingEnabled = True
        Me.ComboDesde.Items.AddRange(New Object() {"SPS", "VILLANUEVA", "LA CEIBA"})
        Me.ComboDesde.Location = New System.Drawing.Point(56, 21)
        Me.ComboDesde.Name = "ComboDesde"
        Me.ComboDesde.Size = New System.Drawing.Size(121, 21)
        Me.ComboDesde.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label21)
        Me.GroupBox11.Controls.Add(Me.CantFinalEnvia)
        Me.GroupBox11.Controls.Add(Me.Label22)
        Me.GroupBox11.Controls.Add(Me.CantMoverEnvia)
        Me.GroupBox11.Controls.Add(Me.Label23)
        Me.GroupBox11.Controls.Add(Me.CantIniEnvia)
        Me.GroupBox11.Location = New System.Drawing.Point(525, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox11.TabIndex = 20
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Cantidad Envia"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(22, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Cant Final:"
        '
        'CantFinalEnvia
        '
        Me.CantFinalEnvia.Location = New System.Drawing.Point(85, 70)
        Me.CantFinalEnvia.Name = "CantFinalEnvia"
        Me.CantFinalEnvia.Size = New System.Drawing.Size(100, 20)
        Me.CantFinalEnvia.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Cant Mover:"
        '
        'CantMoverEnvia
        '
        Me.CantMoverEnvia.Location = New System.Drawing.Point(85, 45)
        Me.CantMoverEnvia.Name = "CantMoverEnvia"
        Me.CantMoverEnvia.Size = New System.Drawing.Size(100, 20)
        Me.CantMoverEnvia.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Cant Actual:"
        '
        'CantIniEnvia
        '
        Me.CantIniEnvia.Location = New System.Drawing.Point(85, 20)
        Me.CantIniEnvia.Name = "CantIniEnvia"
        Me.CantIniEnvia.Size = New System.Drawing.Size(100, 20)
        Me.CantIniEnvia.TabIndex = 12
        '
        'MovimientoMaterialesDataGridView
        '
        Me.MovimientoMaterialesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovimientoMaterialesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MovimientoMaterialesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MovimientoMaterialesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.MovimientoMaterialesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MovimientoMaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovimientoMaterialesDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.MovimientoMaterialesDataGridView.Location = New System.Drawing.Point(3, 182)
        Me.MovimientoMaterialesDataGridView.Name = "MovimientoMaterialesDataGridView"
        Me.MovimientoMaterialesDataGridView.RowHeadersVisible = False
        Me.MovimientoMaterialesDataGridView.Size = New System.Drawing.Size(931, 398)
        Me.MovimientoMaterialesDataGridView.TabIndex = 43
        '
        'MovimientoMaterialesBindingSource
        '
        Me.MovimientoMaterialesBindingSource.DataMember = "MovimientoMateriales"
        Me.MovimientoMaterialesBindingSource.DataSource = Me.ABASDataSet
        '
        'EquiposBindingSource
        '
        Me.EquiposBindingSource.DataMember = "Equipos"
        Me.EquiposBindingSource.DataSource = Me.ABASDataSet
        '
        'MovimientoEquiposBindingSource
        '
        Me.MovimientoEquiposBindingSource.DataMember = "MovimientoEquipos"
        Me.MovimientoEquiposBindingSource.DataSource = Me.ABASDataSet
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
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
        'MovimientoEquiposTableAdapter
        '
        Me.MovimientoEquiposTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'EquiposTableAdapter
        '
        Me.EquiposTableAdapter.ClearBeforeFill = True
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = True
        '
        'MovimientoMaterialesTableAdapter
        '
        Me.MovimientoMaterialesTableAdapter.ClearBeforeFill = True
        '
        'TipoMaterialesTableAdapter
        '
        Me.TipoMaterialesTableAdapter.ClearBeforeFill = True
        '
        'FormInventarioMaterialesEquiposSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 653)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormInventarioMaterialesEquiposSeguridad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.MaterialesDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.MovimientoMaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoEquiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoEquiposBindingSource As BindingSource
    Friend WithEvents MovimientoEquiposTableAdapter As ABASDataSetTableAdapters.MovimientoEquiposTableAdapter
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents EquiposBindingSource As BindingSource
    Friend WithEvents EquiposTableAdapter As ABASDataSetTableAdapters.EquiposTableAdapter
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CantFinal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CantMateriales As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CantInicial As TextBox
    Friend WithEvents MaterialesBindingSource As BindingSource
    Friend WithEvents MaterialesTableAdapter As ABASDataSetTableAdapters.MaterialesTableAdapter
    Friend WithEvents EstadoMateriales As ComboBox
    Friend WithEvents DescripcionComboBox As ComboBox
    Friend WithEvents Cmd_Limpiar As Button
    Friend WithEvents CmdRegistrarMateriales As Button
    Friend WithEvents CmdAgregarMateriales As Button
    Friend WithEvents MaterialesDataGridView As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents IdMaterialTextBox As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CantFinRecibe As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CantMovRecibe As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CantIniRecibe As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents FechaMovimiento As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboHacia As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboDesde As ComboBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents CantFinalEnvia As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CantMoverEnvia As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents CantIniEnvia As TextBox
    Friend WithEvents Cmd_Nuevo As Button
    Friend WithEvents Cmd_Transferir As Button
    Friend WithEvents MaterialesDataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EstadoMovimiento As TextBox
    Friend WithEvents DescripcionMovimiento As TextBox
    Friend WithEvents IdMaterialMovimiento As TextBox
    Friend WithEvents MovimientoMaterialesBindingSource As BindingSource
    Friend WithEvents MovimientoMaterialesTableAdapter As ABASDataSetTableAdapters.MovimientoMaterialesTableAdapter
    Friend WithEvents MovimientoMaterialesDataGridView As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents DescripcionRecibe As TextBox
    Friend WithEvents IdMov As TextBox
    Friend WithEvents EstadoRecibe As TextBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents ComboRecibe As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents CantRecibe As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Cmd_Recibir As Button
    Friend WithEvents IDmaterialrecibe As TextBox
    Friend WithEvents MaterialesPorAlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimeintosDeMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TipoMaterialesBindingSource As BindingSource
    Friend WithEvents TipoMaterialesTableAdapter As ABASDataSetTableAdapters.TipoMaterialesTableAdapter
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
