<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRRHHDocumentos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdtipodocLabel As System.Windows.Forms.Label
        Dim NombretipoLabel As System.Windows.Forms.Label
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TipoDocumentosEmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumentosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cmd_NuevoTipo = New System.Windows.Forms.Button()
        Me.Cmd_EliminarTipo = New System.Windows.Forms.Button()
        Me.Cmd_RegAct_Tipo = New System.Windows.Forms.Button()
        Me.NombretipoTextBox = New System.Windows.Forms.TextBox()
        Me.IdtipodocTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdRegistrar = New System.Windows.Forms.Button()
        Me.cmdSeleccionarImagen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_TiposDeDocumentosR = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Cmd_EliminarDoc = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Cmd_Descargar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmb_TiposDeDocumentosD = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosPorEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosPorTiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDocumentosEmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.TipoDocumentosEmpleadosTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.DocumentosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentosEmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.DocumentosEmpleadosTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdBuscar = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        IdtipodocLabel = New System.Windows.Forms.Label()
        NombretipoLabel = New System.Windows.Forms.Label()
        Me.panelEmpleados.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TipoDocumentosEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdtipodocLabel
        '
        IdtipodocLabel.AutoSize = True
        IdtipodocLabel.Location = New System.Drawing.Point(101, 42)
        IdtipodocLabel.Name = "IdtipodocLabel"
        IdtipodocLabel.Size = New System.Drawing.Size(45, 13)
        IdtipodocLabel.TabIndex = 0
        IdtipodocLabel.Text = "ID Tipo:"
        '
        'NombretipoLabel
        '
        NombretipoLabel.AutoSize = True
        NombretipoLabel.Location = New System.Drawing.Point(17, 68)
        NombretipoLabel.Name = "NombretipoLabel"
        NombretipoLabel.Size = New System.Drawing.Size(129, 13)
        NombretipoLabel.TabIndex = 2
        NombretipoLabel.Text = "Nombre Tipo Documento:"
        '
        'panelEmpleados
        '
        Me.panelEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleados.Controls.Add(Me.PictureBox2)
        Me.panelEmpleados.Controls.Add(Me.Panel2)
        Me.panelEmpleados.Controls.Add(Me.txtbusqueda)
        Me.panelEmpleados.Controls.Add(Me.tipodebusqueda)
        Me.panelEmpleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelEmpleados.Location = New System.Drawing.Point(153, 139)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(565, 360)
        Me.panelEmpleados.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(230, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 9
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtbusqueda.Location = New System.Drawing.Point(233, 19)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(197, 20)
        Me.txtbusqueda.TabIndex = 8
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(93, 19)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombres, Me.apellidos, Me.identidad, Me.estado})
        Me.EmpleadosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(-1, 50)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(565, 307)
        Me.EmpleadosDataGridView.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "ID Empleado"
        Me.codigo.Name = "codigo"
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "nombres"
        Me.nombres.HeaderText = "Nombre"
        Me.nombres.Name = "nombres"
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.HeaderText = "Apellido"
        Me.apellidos.Name = "apellidos"
        '
        'identidad
        '
        Me.identidad.DataPropertyName = "identidad"
        Me.identidad.HeaderText = "Identidad"
        Me.identidad.Name = "identidad"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(902, 1114)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(894, 1088)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro / Tipos de Documentos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TipoDocumentosEmpleadosDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 931)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'TipoDocumentosEmpleadosDataGridView
        '
        Me.TipoDocumentosEmpleadosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipoDocumentosEmpleadosDataGridView.AutoGenerateColumns = False
        Me.TipoDocumentosEmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TipoDocumentosEmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.TipoDocumentosEmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TipoDocumentosEmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TipoDocumentosEmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipoDocumentosEmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TipoDocumentosEmpleadosDataGridView.DataSource = Me.TipoDocumentosEmpleadosBindingSource
        Me.TipoDocumentosEmpleadosDataGridView.Location = New System.Drawing.Point(6, 14)
        Me.TipoDocumentosEmpleadosDataGridView.Name = "TipoDocumentosEmpleadosDataGridView"
        Me.TipoDocumentosEmpleadosDataGridView.RowHeadersVisible = False
        Me.TipoDocumentosEmpleadosDataGridView.Size = New System.Drawing.Size(513, 911)
        Me.TipoDocumentosEmpleadosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idtipodoc"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Tipo Documento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombretipo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Tipo Documento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TipoDocumentosEmpleadosBindingSource
        '
        Me.TipoDocumentosEmpleadosBindingSource.DataMember = "TipoDocumentosEmpleados"
        Me.TipoDocumentosEmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cmd_NuevoTipo)
        Me.GroupBox2.Controls.Add(Me.Cmd_EliminarTipo)
        Me.GroupBox2.Controls.Add(Me.Cmd_RegAct_Tipo)
        Me.GroupBox2.Controls.Add(NombretipoLabel)
        Me.GroupBox2.Controls.Add(Me.NombretipoTextBox)
        Me.GroupBox2.Controls.Add(IdtipodocLabel)
        Me.GroupBox2.Controls.Add(Me.IdtipodocTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 139)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Cmd_NuevoTipo
        '
        Me.Cmd_NuevoTipo.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_NuevoTipo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Cmd_NuevoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_NuevoTipo.ForeColor = System.Drawing.Color.White
        Me.Cmd_NuevoTipo.Location = New System.Drawing.Point(95, 101)
        Me.Cmd_NuevoTipo.Name = "Cmd_NuevoTipo"
        Me.Cmd_NuevoTipo.Size = New System.Drawing.Size(126, 23)
        Me.Cmd_NuevoTipo.TabIndex = 6
        Me.Cmd_NuevoTipo.Text = "Nuevo"
        Me.Cmd_NuevoTipo.UseVisualStyleBackColor = False
        '
        'Cmd_EliminarTipo
        '
        Me.Cmd_EliminarTipo.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_EliminarTipo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Cmd_EliminarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_EliminarTipo.ForeColor = System.Drawing.Color.White
        Me.Cmd_EliminarTipo.Location = New System.Drawing.Point(359, 101)
        Me.Cmd_EliminarTipo.Name = "Cmd_EliminarTipo"
        Me.Cmd_EliminarTipo.Size = New System.Drawing.Size(126, 23)
        Me.Cmd_EliminarTipo.TabIndex = 5
        Me.Cmd_EliminarTipo.Text = "Eliminar"
        Me.Cmd_EliminarTipo.UseVisualStyleBackColor = False
        '
        'Cmd_RegAct_Tipo
        '
        Me.Cmd_RegAct_Tipo.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_RegAct_Tipo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Cmd_RegAct_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_RegAct_Tipo.ForeColor = System.Drawing.Color.White
        Me.Cmd_RegAct_Tipo.Location = New System.Drawing.Point(227, 101)
        Me.Cmd_RegAct_Tipo.Name = "Cmd_RegAct_Tipo"
        Me.Cmd_RegAct_Tipo.Size = New System.Drawing.Size(126, 23)
        Me.Cmd_RegAct_Tipo.TabIndex = 4
        Me.Cmd_RegAct_Tipo.Text = "Guardar / Actualizar"
        Me.Cmd_RegAct_Tipo.UseVisualStyleBackColor = False
        '
        'NombretipoTextBox
        '
        Me.NombretipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoDocumentosEmpleadosBindingSource, "nombretipo", True))
        Me.NombretipoTextBox.Location = New System.Drawing.Point(152, 65)
        Me.NombretipoTextBox.Name = "NombretipoTextBox"
        Me.NombretipoTextBox.Size = New System.Drawing.Size(333, 20)
        Me.NombretipoTextBox.TabIndex = 3
        '
        'IdtipodocTextBox
        '
        Me.IdtipodocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoDocumentosEmpleadosBindingSource, "idtipodoc", True))
        Me.IdtipodocTextBox.Location = New System.Drawing.Point(152, 39)
        Me.IdtipodocTextBox.Name = "IdtipodocTextBox"
        Me.IdtipodocTextBox.ReadOnly = True
        Me.IdtipodocTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdtipodocTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(894, 1088)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registro / Documentos Empleados"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRegistrar)
        Me.GroupBox1.Controls.Add(Me.cmdSeleccionarImagen)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Cmb_TiposDeDocumentosR)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 1074)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Empleado"
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegistrar.ForeColor = System.Drawing.Color.White
        Me.cmdRegistrar.Location = New System.Drawing.Point(28, 160)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(126, 23)
        Me.cmdRegistrar.TabIndex = 54
        Me.cmdRegistrar.Text = "Guardar"
        Me.cmdRegistrar.UseVisualStyleBackColor = False
        '
        'cmdSeleccionarImagen
        '
        Me.cmdSeleccionarImagen.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdSeleccionarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdSeleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSeleccionarImagen.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSeleccionarImagen.ForeColor = System.Drawing.Color.White
        Me.cmdSeleccionarImagen.Location = New System.Drawing.Point(28, 124)
        Me.cmdSeleccionarImagen.Name = "cmdSeleccionarImagen"
        Me.cmdSeleccionarImagen.Size = New System.Drawing.Size(126, 23)
        Me.cmdSeleccionarImagen.TabIndex = 53
        Me.cmdSeleccionarImagen.Text = "Seleccionar Imagen"
        Me.cmdSeleccionarImagen.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Tipo Documento"
        '
        'Cmb_TiposDeDocumentosR
        '
        Me.Cmb_TiposDeDocumentosR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_TiposDeDocumentosR.FormattingEnabled = True
        Me.Cmb_TiposDeDocumentosR.Location = New System.Drawing.Point(7, 93)
        Me.Cmb_TiposDeDocumentosR.Name = "Cmb_TiposDeDocumentosR"
        Me.Cmb_TiposDeDocumentosR.Size = New System.Drawing.Size(170, 21)
        Me.Cmb_TiposDeDocumentosR.TabIndex = 32
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(27, 42)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(126, 20)
        Me.txtId.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Codigo Empleado"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(894, 1088)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Buscar Documentos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Cmd_EliminarDoc)
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Controls.Add(Me.Cmd_Descargar)
        Me.GroupBox5.Controls.Add(Me.PictureBox3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Cmb_TiposDeDocumentosD)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 1074)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Empleado"
        '
        'Cmd_EliminarDoc
        '
        Me.Cmd_EliminarDoc.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_EliminarDoc.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Cmd_EliminarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_EliminarDoc.ForeColor = System.Drawing.Color.White
        Me.Cmd_EliminarDoc.Location = New System.Drawing.Point(27, 155)
        Me.Cmd_EliminarDoc.Name = "Cmd_EliminarDoc"
        Me.Cmd_EliminarDoc.Size = New System.Drawing.Size(126, 23)
        Me.Cmd_EliminarDoc.TabIndex = 56
        Me.Cmd_EliminarDoc.Text = "Eliminar"
        Me.Cmd_EliminarDoc.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1, 187)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(181, 888)
        Me.ListBox1.TabIndex = 1
        '
        'Cmd_Descargar
        '
        Me.Cmd_Descargar.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_Descargar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Cmd_Descargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Descargar.ForeColor = System.Drawing.Color.White
        Me.Cmd_Descargar.Location = New System.Drawing.Point(27, 121)
        Me.Cmd_Descargar.Name = "Cmd_Descargar"
        Me.Cmd_Descargar.Size = New System.Drawing.Size(126, 23)
        Me.Cmd_Descargar.TabIndex = 55
        Me.Cmd_Descargar.Text = "Descargar"
        Me.Cmd_Descargar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Tipo Documento"
        '
        'Cmb_TiposDeDocumentosD
        '
        Me.Cmb_TiposDeDocumentosD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_TiposDeDocumentosD.FormattingEnabled = True
        Me.Cmb_TiposDeDocumentosD.Location = New System.Drawing.Point(7, 93)
        Me.Cmb_TiposDeDocumentosD.Name = "Cmb_TiposDeDocumentosD"
        Me.Cmb_TiposDeDocumentosD.Size = New System.Drawing.Size(170, 21)
        Me.Cmb_TiposDeDocumentosD.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Codigo Empleado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentosPorEmpleadoToolStripMenuItem, Me.DocumentosPorTiposToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'DocumentosPorEmpleadoToolStripMenuItem
        '
        Me.DocumentosPorEmpleadoToolStripMenuItem.Name = "DocumentosPorEmpleadoToolStripMenuItem"
        Me.DocumentosPorEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.DocumentosPorEmpleadoToolStripMenuItem.Text = "Documentos por Empleado"
        '
        'DocumentosPorTiposToolStripMenuItem
        '
        Me.DocumentosPorTiposToolStripMenuItem.Name = "DocumentosPorTiposToolStripMenuItem"
        Me.DocumentosPorTiposToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.DocumentosPorTiposToolStripMenuItem.Text = "Documentos por Tipos"
        '
        'TipoDocumentosEmpleadosTableAdapter
        '
        Me.TipoDocumentosEmpleadosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TipoDocumentosEmpleadosTableAdapter = Me.TipoDocumentosEmpleadosTableAdapter
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
        'DocumentosEmpleadosBindingSource
        '
        Me.DocumentosEmpleadosBindingSource.DataMember = "DocumentosEmpleados"
        Me.DocumentosEmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'DocumentosEmpleadosTableAdapter
        '
        Me.DocumentosEmpleadosTableAdapter.ClearBeforeFill = True
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
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(213, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(720, 1080)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscar.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.cmdBuscar.Location = New System.Drawing.Point(131, 42)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(21, 20)
        Me.cmdBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmdBuscar.TabIndex = 34
        Me.cmdBuscar.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox3.Location = New System.Drawing.Point(131, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'FormRRHHDocumentos
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(982, 684)
        Me.Controls.Add(Me.panelEmpleados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormRRHHDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDocumentos"
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelEmpleados.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TipoDocumentosEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents identidad As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentosPorEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentosPorTiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_TiposDeDocumentosR As ComboBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents TipoDocumentosEmpleadosBindingSource As BindingSource
    Friend WithEvents TipoDocumentosEmpleadosTableAdapter As ABASDataSetTableAdapters.TipoDocumentosEmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombretipoTextBox As TextBox
    Friend WithEvents IdtipodocTextBox As TextBox
    Friend WithEvents Cmd_NuevoTipo As Button
    Friend WithEvents Cmd_EliminarTipo As Button
    Friend WithEvents Cmd_RegAct_Tipo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TipoDocumentosEmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cmdRegistrar As Button
    Friend WithEvents cmdSeleccionarImagen As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Cmd_Descargar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cmb_TiposDeDocumentosD As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DocumentosEmpleadosBindingSource As BindingSource
    Friend WithEvents DocumentosEmpleadosTableAdapter As ABASDataSetTableAdapters.DocumentosEmpleadosTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Cmd_EliminarDoc As Button
End Class
