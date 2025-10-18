<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.panelInventario = New System.Windows.Forms.Panel()
        Me.cmdEquipo = New System.Windows.Forms.Button()
        Me.cmdMob = New System.Windows.Forms.Button()
        Me.cmdProveedores = New System.Windows.Forms.Button()
        Me.cmdUniformes = New System.Windows.Forms.Button()
        Me.cmdArmeria = New System.Windows.Forms.Button()
        Me.cmdInventario = New System.Windows.Forms.Button()
        Me.Panelrrhh = New System.Windows.Forms.Panel()
        Me.cmdexpediante = New System.Windows.Forms.Button()
        Me.cmdaspirantes = New System.Windows.Forms.Button()
        Me.cmdregistro = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.panelOperaciones = New System.Windows.Forms.Panel()
        Me.cmdDiasLibres = New System.Windows.Forms.Button()
        Me.cmdFalta = New System.Windows.Forms.Button()
        Me.cmdCambio = New System.Windows.Forms.Button()
        Me.cmdAsignaciones = New System.Windows.Forms.Button()
        Me.cmdUsuarios = New System.Windows.Forms.Button()
        Me.cmdPagos = New System.Windows.Forms.Button()
        Me.cmdPlanilla = New System.Windows.Forms.Button()
        Me.cmdDetalles = New System.Windows.Forms.Button()
        Me.cmdGraficas = New System.Windows.Forms.Button()
        Me.cmdOperaciones = New System.Windows.Forms.Button()
        Me.cmdClientes = New System.Windows.Forms.Button()
        Me.cmdRRHH = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.panelsuperior = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelcontenedor = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FechaPresentacion = New System.Windows.Forms.Label()
        Me.HoraPresentacion = New System.Windows.Forms.Label()
        Me.G_UltimoLogin = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelUpdate = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TimerFecha = New System.Windows.Forms.Timer(Me.components)
        Me.AniversarioTableAdapter1 = New ABASSecurity.RRHHDataSetTableAdapters.AniversarioTableAdapter()
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.RecordatorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordatorioTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.RecordatorioTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.panelmenu.SuspendLayout()
        Me.panelInventario.SuspendLayout()
        Me.Panelrrhh.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOperaciones.SuspendLayout()
        Me.panelsuperior.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcontenedor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.G_UltimoLogin.SuspendLayout()
        Me.PanelUpdate.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordatorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.SteelBlue
        Me.panelmenu.Controls.Add(Me.panelInventario)
        Me.panelmenu.Controls.Add(Me.cmdInventario)
        Me.panelmenu.Controls.Add(Me.Panelrrhh)
        Me.panelmenu.Controls.Add(Me.PictureBox4)
        Me.panelmenu.Controls.Add(Me.panelOperaciones)
        Me.panelmenu.Controls.Add(Me.cmdUsuarios)
        Me.panelmenu.Controls.Add(Me.cmdPagos)
        Me.panelmenu.Controls.Add(Me.cmdPlanilla)
        Me.panelmenu.Controls.Add(Me.cmdDetalles)
        Me.panelmenu.Controls.Add(Me.cmdGraficas)
        Me.panelmenu.Controls.Add(Me.cmdOperaciones)
        Me.panelmenu.Controls.Add(Me.cmdClientes)
        Me.panelmenu.Controls.Add(Me.cmdRRHH)
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(219, 682)
        Me.panelmenu.TabIndex = 0
        '
        'panelInventario
        '
        Me.panelInventario.BackColor = System.Drawing.Color.SteelBlue
        Me.panelInventario.Controls.Add(Me.cmdEquipo)
        Me.panelInventario.Controls.Add(Me.cmdMob)
        Me.panelInventario.Controls.Add(Me.cmdProveedores)
        Me.panelInventario.Controls.Add(Me.cmdUniformes)
        Me.panelInventario.Controls.Add(Me.cmdArmeria)
        Me.panelInventario.Location = New System.Drawing.Point(0, 169)
        Me.panelInventario.Name = "panelInventario"
        Me.panelInventario.Size = New System.Drawing.Size(220, 196)
        Me.panelInventario.TabIndex = 5
        '
        'cmdEquipo
        '
        Me.cmdEquipo.BackColor = System.Drawing.Color.DimGray
        Me.cmdEquipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEquipo.FlatAppearance.BorderSize = 0
        Me.cmdEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEquipo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdEquipo.Location = New System.Drawing.Point(1, 80)
        Me.cmdEquipo.Name = "cmdEquipo"
        Me.cmdEquipo.Size = New System.Drawing.Size(220, 39)
        Me.cmdEquipo.TabIndex = 4
        Me.cmdEquipo.Text = "Mobiliario y Equipo de Oficina"
        Me.cmdEquipo.UseVisualStyleBackColor = False
        '
        'cmdMob
        '
        Me.cmdMob.BackColor = System.Drawing.Color.DimGray
        Me.cmdMob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMob.FlatAppearance.BorderSize = 0
        Me.cmdMob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMob.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdMob.Location = New System.Drawing.Point(0, 41)
        Me.cmdMob.Name = "cmdMob"
        Me.cmdMob.Size = New System.Drawing.Size(220, 39)
        Me.cmdMob.TabIndex = 4
        Me.cmdMob.Text = "Materiales y Equipos de Seguridad"
        Me.cmdMob.UseVisualStyleBackColor = False
        '
        'cmdProveedores
        '
        Me.cmdProveedores.BackColor = System.Drawing.Color.DimGray
        Me.cmdProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProveedores.FlatAppearance.BorderSize = 0
        Me.cmdProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdProveedores.Location = New System.Drawing.Point(-1, 158)
        Me.cmdProveedores.Name = "cmdProveedores"
        Me.cmdProveedores.Size = New System.Drawing.Size(220, 39)
        Me.cmdProveedores.TabIndex = 3
        Me.cmdProveedores.Text = "Proveedores / Almacenes / Vehiculos"
        Me.cmdProveedores.UseVisualStyleBackColor = False
        '
        'cmdUniformes
        '
        Me.cmdUniformes.BackColor = System.Drawing.Color.DimGray
        Me.cmdUniformes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUniformes.FlatAppearance.BorderSize = 0
        Me.cmdUniformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUniformes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdUniformes.Location = New System.Drawing.Point(0, 119)
        Me.cmdUniformes.Name = "cmdUniformes"
        Me.cmdUniformes.Size = New System.Drawing.Size(220, 39)
        Me.cmdUniformes.TabIndex = 2
        Me.cmdUniformes.Text = "Uniformes / Asignacion / Devolucion"
        Me.cmdUniformes.UseVisualStyleBackColor = False
        '
        'cmdArmeria
        '
        Me.cmdArmeria.BackColor = System.Drawing.Color.DimGray
        Me.cmdArmeria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdArmeria.FlatAppearance.BorderSize = 0
        Me.cmdArmeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdArmeria.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdArmeria.Location = New System.Drawing.Point(0, 0)
        Me.cmdArmeria.Name = "cmdArmeria"
        Me.cmdArmeria.Size = New System.Drawing.Size(220, 41)
        Me.cmdArmeria.TabIndex = 0
        Me.cmdArmeria.Text = "Armeria y Municion"
        Me.cmdArmeria.UseVisualStyleBackColor = False
        '
        'cmdInventario
        '
        Me.cmdInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdInventario.FlatAppearance.BorderSize = 0
        Me.cmdInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdInventario.Image = Global.ABASSecurity.My.Resources.Resources.icons8_mover_por_carretilla_32
        Me.cmdInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInventario.Location = New System.Drawing.Point(0, 538)
        Me.cmdInventario.Name = "cmdInventario"
        Me.cmdInventario.Size = New System.Drawing.Size(221, 39)
        Me.cmdInventario.TabIndex = 9
        Me.cmdInventario.Text = "Inventario"
        Me.cmdInventario.UseVisualStyleBackColor = True
        '
        'Panelrrhh
        '
        Me.Panelrrhh.BackColor = System.Drawing.Color.SteelBlue
        Me.Panelrrhh.Controls.Add(Me.cmdexpediante)
        Me.Panelrrhh.Controls.Add(Me.cmdaspirantes)
        Me.Panelrrhh.Controls.Add(Me.cmdregistro)
        Me.Panelrrhh.Location = New System.Drawing.Point(0, 169)
        Me.Panelrrhh.Name = "Panelrrhh"
        Me.Panelrrhh.Size = New System.Drawing.Size(220, 117)
        Me.Panelrrhh.TabIndex = 4
        '
        'cmdexpediante
        '
        Me.cmdexpediante.BackColor = System.Drawing.Color.DimGray
        Me.cmdexpediante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexpediante.FlatAppearance.BorderSize = 0
        Me.cmdexpediante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdexpediante.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdexpediante.Location = New System.Drawing.Point(0, 80)
        Me.cmdexpediante.Name = "cmdexpediante"
        Me.cmdexpediante.Size = New System.Drawing.Size(220, 39)
        Me.cmdexpediante.TabIndex = 2
        Me.cmdexpediante.Text = "Expedientes / Documentos"
        Me.cmdexpediante.UseVisualStyleBackColor = False
        '
        'cmdaspirantes
        '
        Me.cmdaspirantes.BackColor = System.Drawing.Color.DimGray
        Me.cmdaspirantes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdaspirantes.FlatAppearance.BorderSize = 0
        Me.cmdaspirantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdaspirantes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdaspirantes.Location = New System.Drawing.Point(0, 41)
        Me.cmdaspirantes.Name = "cmdaspirantes"
        Me.cmdaspirantes.Size = New System.Drawing.Size(220, 39)
        Me.cmdaspirantes.TabIndex = 1
        Me.cmdaspirantes.Text = "Aspirantes"
        Me.cmdaspirantes.UseVisualStyleBackColor = False
        '
        'cmdregistro
        '
        Me.cmdregistro.BackColor = System.Drawing.Color.DimGray
        Me.cmdregistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdregistro.FlatAppearance.BorderSize = 0
        Me.cmdregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdregistro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdregistro.Location = New System.Drawing.Point(0, 0)
        Me.cmdregistro.Name = "cmdregistro"
        Me.cmdregistro.Size = New System.Drawing.Size(220, 41)
        Me.cmdregistro.TabIndex = 0
        Me.cmdregistro.Text = "Registro de Empleados"
        Me.cmdregistro.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ABASSecurity.My.Resources.Resources.final
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(221, 124)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'panelOperaciones
        '
        Me.panelOperaciones.BackColor = System.Drawing.Color.SteelBlue
        Me.panelOperaciones.Controls.Add(Me.cmdDiasLibres)
        Me.panelOperaciones.Controls.Add(Me.cmdFalta)
        Me.panelOperaciones.Controls.Add(Me.cmdCambio)
        Me.panelOperaciones.Controls.Add(Me.cmdAsignaciones)
        Me.panelOperaciones.Location = New System.Drawing.Point(-1, 252)
        Me.panelOperaciones.Name = "panelOperaciones"
        Me.panelOperaciones.Size = New System.Drawing.Size(220, 164)
        Me.panelOperaciones.TabIndex = 0
        '
        'cmdDiasLibres
        '
        Me.cmdDiasLibres.BackColor = System.Drawing.Color.DimGray
        Me.cmdDiasLibres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDiasLibres.FlatAppearance.BorderSize = 0
        Me.cmdDiasLibres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDiasLibres.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdDiasLibres.Location = New System.Drawing.Point(-1, 119)
        Me.cmdDiasLibres.Name = "cmdDiasLibres"
        Me.cmdDiasLibres.Size = New System.Drawing.Size(220, 45)
        Me.cmdDiasLibres.TabIndex = 3
        Me.cmdDiasLibres.Text = "Asignar Dias libres"
        Me.cmdDiasLibres.UseVisualStyleBackColor = False
        '
        'cmdFalta
        '
        Me.cmdFalta.BackColor = System.Drawing.Color.DimGray
        Me.cmdFalta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFalta.FlatAppearance.BorderSize = 0
        Me.cmdFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFalta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdFalta.Location = New System.Drawing.Point(0, 80)
        Me.cmdFalta.Name = "cmdFalta"
        Me.cmdFalta.Size = New System.Drawing.Size(220, 39)
        Me.cmdFalta.TabIndex = 2
        Me.cmdFalta.Text = "Registrar Faltas"
        Me.cmdFalta.UseVisualStyleBackColor = False
        '
        'cmdCambio
        '
        Me.cmdCambio.BackColor = System.Drawing.Color.DimGray
        Me.cmdCambio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCambio.FlatAppearance.BorderSize = 0
        Me.cmdCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCambio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdCambio.Location = New System.Drawing.Point(0, 41)
        Me.cmdCambio.Name = "cmdCambio"
        Me.cmdCambio.Size = New System.Drawing.Size(220, 39)
        Me.cmdCambio.TabIndex = 1
        Me.cmdCambio.Text = "Realizar Cambio de Roll"
        Me.cmdCambio.UseVisualStyleBackColor = False
        '
        'cmdAsignaciones
        '
        Me.cmdAsignaciones.BackColor = System.Drawing.Color.DimGray
        Me.cmdAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAsignaciones.FlatAppearance.BorderSize = 0
        Me.cmdAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAsignaciones.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdAsignaciones.Location = New System.Drawing.Point(0, 0)
        Me.cmdAsignaciones.Name = "cmdAsignaciones"
        Me.cmdAsignaciones.Size = New System.Drawing.Size(220, 41)
        Me.cmdAsignaciones.TabIndex = 0
        Me.cmdAsignaciones.Text = "Asignaciones / Roll Diario"
        Me.cmdAsignaciones.UseVisualStyleBackColor = False
        '
        'cmdUsuarios
        '
        Me.cmdUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUsuarios.FlatAppearance.BorderSize = 0
        Me.cmdUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdUsuarios.Image = CType(resources.GetObject("cmdUsuarios.Image"), System.Drawing.Image)
        Me.cmdUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUsuarios.Location = New System.Drawing.Point(0, 623)
        Me.cmdUsuarios.Name = "cmdUsuarios"
        Me.cmdUsuarios.Size = New System.Drawing.Size(221, 39)
        Me.cmdUsuarios.TabIndex = 5
        Me.cmdUsuarios.Text = "Registro de Usuarios"
        Me.cmdUsuarios.UseVisualStyleBackColor = True
        '
        'cmdPagos
        '
        Me.cmdPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdPagos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPagos.FlatAppearance.BorderSize = 0
        Me.cmdPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdPagos.Image = CType(resources.GetObject("cmdPagos.Image"), System.Drawing.Image)
        Me.cmdPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPagos.Location = New System.Drawing.Point(0, 457)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(221, 39)
        Me.cmdPagos.TabIndex = 6
        Me.cmdPagos.Text = "Pagos Realizados"
        Me.cmdPagos.UseVisualStyleBackColor = True
        '
        'cmdPlanilla
        '
        Me.cmdPlanilla.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdPlanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdPlanilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPlanilla.FlatAppearance.BorderSize = 0
        Me.cmdPlanilla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPlanilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlanilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdPlanilla.Image = CType(resources.GetObject("cmdPlanilla.Image"), System.Drawing.Image)
        Me.cmdPlanilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPlanilla.Location = New System.Drawing.Point(0, 418)
        Me.cmdPlanilla.Name = "cmdPlanilla"
        Me.cmdPlanilla.Size = New System.Drawing.Size(221, 38)
        Me.cmdPlanilla.TabIndex = 4
        Me.cmdPlanilla.Text = "Planilla"
        Me.cmdPlanilla.UseVisualStyleBackColor = False
        '
        'cmdDetalles
        '
        Me.cmdDetalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdDetalles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDetalles.FlatAppearance.BorderSize = 0
        Me.cmdDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdDetalles.Image = CType(resources.GetObject("cmdDetalles.Image"), System.Drawing.Image)
        Me.cmdDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDetalles.Location = New System.Drawing.Point(0, 583)
        Me.cmdDetalles.Name = "cmdDetalles"
        Me.cmdDetalles.Size = New System.Drawing.Size(221, 39)
        Me.cmdDetalles.TabIndex = 8
        Me.cmdDetalles.Text = "Otros / Detalles"
        Me.cmdDetalles.UseVisualStyleBackColor = True
        '
        'cmdGraficas
        '
        Me.cmdGraficas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdGraficas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGraficas.FlatAppearance.BorderSize = 0
        Me.cmdGraficas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdGraficas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGraficas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraficas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGraficas.Image = CType(resources.GetObject("cmdGraficas.Image"), System.Drawing.Image)
        Me.cmdGraficas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGraficas.Location = New System.Drawing.Point(0, 497)
        Me.cmdGraficas.Name = "cmdGraficas"
        Me.cmdGraficas.Size = New System.Drawing.Size(221, 39)
        Me.cmdGraficas.TabIndex = 7
        Me.cmdGraficas.Text = "Graficas / Estadisticas"
        Me.cmdGraficas.UseVisualStyleBackColor = True
        '
        'cmdOperaciones
        '
        Me.cmdOperaciones.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdOperaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdOperaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOperaciones.FlatAppearance.BorderSize = 0
        Me.cmdOperaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOperaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdOperaciones.Image = CType(resources.GetObject("cmdOperaciones.Image"), System.Drawing.Image)
        Me.cmdOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOperaciones.Location = New System.Drawing.Point(0, 209)
        Me.cmdOperaciones.Name = "cmdOperaciones"
        Me.cmdOperaciones.Size = New System.Drawing.Size(221, 41)
        Me.cmdOperaciones.TabIndex = 3
        Me.cmdOperaciones.Text = "Operaciones"
        Me.cmdOperaciones.UseVisualStyleBackColor = False
        '
        'cmdClientes
        '
        Me.cmdClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClientes.FlatAppearance.BorderSize = 0
        Me.cmdClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdClientes.Image = CType(resources.GetObject("cmdClientes.Image"), System.Drawing.Image)
        Me.cmdClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClientes.Location = New System.Drawing.Point(0, 169)
        Me.cmdClientes.Name = "cmdClientes"
        Me.cmdClientes.Size = New System.Drawing.Size(221, 39)
        Me.cmdClientes.TabIndex = 2
        Me.cmdClientes.Text = "Clientes"
        Me.cmdClientes.UseVisualStyleBackColor = True
        '
        'cmdRRHH
        '
        Me.cmdRRHH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdRRHH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRRHH.FlatAppearance.BorderSize = 0
        Me.cmdRRHH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdRRHH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmdRRHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRRHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRRHH.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRRHH.Image = CType(resources.GetObject("cmdRRHH.Image"), System.Drawing.Image)
        Me.cmdRRHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRRHH.Location = New System.Drawing.Point(0, 126)
        Me.cmdRRHH.Name = "cmdRRHH"
        Me.cmdRRHH.Size = New System.Drawing.Size(221, 39)
        Me.cmdRRHH.TabIndex = 1
        Me.cmdRRHH.Text = "Recursos Humanos"
        Me.cmdRRHH.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFecha.BackColor = System.Drawing.Color.SteelBlue
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFecha.Location = New System.Drawing.Point(8, 25)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 13)
        Me.txtFecha.TabIndex = 11
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.BackColor = System.Drawing.Color.SteelBlue
        Me.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVersion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtVersion.Location = New System.Drawing.Point(8, 6)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(100, 13)
        Me.txtVersion.TabIndex = 10
        '
        'panelsuperior
        '
        Me.panelsuperior.BackColor = System.Drawing.Color.SteelBlue
        Me.panelsuperior.Controls.Add(Me.Panel2)
        Me.panelsuperior.Controls.Add(Me.Label5)
        Me.panelsuperior.Controls.Add(Me.txtFecha)
        Me.panelsuperior.Controls.Add(Me.txtVersion)
        Me.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelsuperior.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.panelsuperior.Location = New System.Drawing.Point(219, 0)
        Me.panelsuperior.Name = "panelsuperior"
        Me.panelsuperior.Size = New System.Drawing.Size(965, 45)
        Me.panelsuperior.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(915, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(43, 39)
        Me.Panel2.TabIndex = 11
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(43, 39)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BorderColor = System.Drawing.Color.SteelBlue
        Me.OvalShape1.Location = New System.Drawing.Point(4, 3)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(34, 33)
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(462, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(450, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Usuario"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(18, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(52, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'panelcontenedor
        '
        Me.panelcontenedor.Controls.Add(Me.GroupBox1)
        Me.panelcontenedor.Controls.Add(Me.Panel1)
        Me.panelcontenedor.Controls.Add(Me.G_UltimoLogin)
        Me.panelcontenedor.Controls.Add(Me.PanelUpdate)
        Me.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcontenedor.Location = New System.Drawing.Point(219, 45)
        Me.panelcontenedor.Name = "panelcontenedor"
        Me.panelcontenedor.Size = New System.Drawing.Size(965, 637)
        Me.panelcontenedor.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CmdGuardar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(709, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 88)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bloqueo Inventario"
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.CmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdGuardar.FlatAppearance.BorderSize = 0
        Me.CmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGuardar.Location = New System.Drawing.Point(105, 49)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(88, 33)
        Me.CmdGuardar.TabIndex = 34
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Bloquear:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboBox1.Location = New System.Drawing.Point(90, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.FechaPresentacion)
        Me.Panel1.Controls.Add(Me.HoraPresentacion)
        Me.Panel1.Location = New System.Drawing.Point(692, 464)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 173)
        Me.Panel1.TabIndex = 9
        '
        'FechaPresentacion
        '
        Me.FechaPresentacion.AutoSize = True
        Me.FechaPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaPresentacion.ForeColor = System.Drawing.Color.DimGray
        Me.FechaPresentacion.Location = New System.Drawing.Point(22, 85)
        Me.FechaPresentacion.Name = "FechaPresentacion"
        Me.FechaPresentacion.Size = New System.Drawing.Size(90, 31)
        Me.FechaPresentacion.TabIndex = 1
        Me.FechaPresentacion.Text = "Fecha"
        '
        'HoraPresentacion
        '
        Me.HoraPresentacion.AutoSize = True
        Me.HoraPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraPresentacion.ForeColor = System.Drawing.Color.SteelBlue
        Me.HoraPresentacion.Location = New System.Drawing.Point(20, 28)
        Me.HoraPresentacion.Name = "HoraPresentacion"
        Me.HoraPresentacion.Size = New System.Drawing.Size(107, 46)
        Me.HoraPresentacion.TabIndex = 0
        Me.HoraPresentacion.Text = "Hora"
        '
        'G_UltimoLogin
        '
        Me.G_UltimoLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.G_UltimoLogin.Controls.Add(Me.Label7)
        Me.G_UltimoLogin.Controls.Add(Me.Label8)
        Me.G_UltimoLogin.Controls.Add(Me.Label3)
        Me.G_UltimoLogin.Controls.Add(Me.Label1)
        Me.G_UltimoLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_UltimoLogin.Location = New System.Drawing.Point(654, 6)
        Me.G_UltimoLogin.Name = "G_UltimoLogin"
        Me.G_UltimoLogin.Size = New System.Drawing.Size(289, 82)
        Me.G_UltimoLogin.TabIndex = 5
        Me.G_UltimoLogin.TabStop = False
        Me.G_UltimoLogin.Text = "Ultima modificacion en el sistema"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(30, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(22, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'PanelUpdate
        '
        Me.PanelUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelUpdate.Controls.Add(Me.Label10)
        Me.PanelUpdate.Controls.Add(Me.LinkLabel1)
        Me.PanelUpdate.Controls.Add(Me.TextBox1)
        Me.PanelUpdate.Location = New System.Drawing.Point(186, 243)
        Me.PanelUpdate.Name = "PanelUpdate"
        Me.PanelUpdate.Size = New System.Drawing.Size(564, 118)
        Me.PanelUpdate.TabIndex = 8
        Me.PanelUpdate.TabStop = False
        Me.PanelUpdate.Text = "Actualizacion - Sistema ABAS"
        Me.PanelUpdate.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(556, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Su sistema esta desactualizado, haga click en el siguiente enlace para descargar " &
    "la version mas reciente."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(213, 71)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(140, 31)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Descargar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "18"
        Me.TextBox1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Location = New System.Drawing.Point(972, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(211, 216)
        Me.Panel3.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.LinkLabel5)
        Me.GroupBox3.Controls.Add(Me.LinkLabel4)
        Me.GroupBox3.Controls.Add(Me.LinkLabel3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LinkLabel2)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(11, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 141)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enlaces"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Uso de Inventario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Agregar Maquina:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Zerotier:"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.LinkColor = System.Drawing.Color.White
        Me.LinkLabel5.Location = New System.Drawing.Point(102, 110)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(80, 18)
        Me.LinkLabel5.TabIndex = 7
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Ver"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(103, 81)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(80, 18)
        Me.LinkLabel4.TabIndex = 7
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Abrir"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(103, 49)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(80, 19)
        Me.LinkLabel3.TabIndex = 7
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Descargar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Aplicacion ABAS:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(104, 20)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 20)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Descargar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(104, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 54)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Minimizar / Salir"
        '
        'TimerFecha
        '
        Me.TimerFecha.Enabled = True
        Me.TimerFecha.Interval = 10
        '
        'AniversarioTableAdapter1
        '
        Me.AniversarioTableAdapter1.ClearBeforeFill = True
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
        'RecordatorioTableAdapter
        '
        Me.RecordatorioTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.RecordatorioTableAdapter = Me.RecordatorioTableAdapter
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
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 682)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelcontenedor)
        Me.Controls.Add(Me.panelsuperior)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelmenu.ResumeLayout(False)
        Me.panelInventario.ResumeLayout(False)
        Me.Panelrrhh.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOperaciones.ResumeLayout(False)
        Me.panelsuperior.ResumeLayout(False)
        Me.panelsuperior.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcontenedor.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.G_UltimoLogin.ResumeLayout(False)
        Me.G_UltimoLogin.PerformLayout()
        Me.PanelUpdate.ResumeLayout(False)
        Me.PanelUpdate.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordatorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents cmdRRHH As Button
    Friend WithEvents panelsuperior As Panel
    Friend WithEvents cmdPagos As Button
    Friend WithEvents cmdPlanilla As Button
    Friend WithEvents cmdOperaciones As Button
    Friend WithEvents cmdClientes As Button
    Friend WithEvents cmdGraficas As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelcontenedor As Panel
    Friend WithEvents cmdDetalles As Button
    Friend WithEvents TimerFecha As Timer
    Friend WithEvents panelOperaciones As Panel
    Friend WithEvents cmdFalta As Button
    Friend WithEvents cmdCambio As Button
    Friend WithEvents cmdAsignaciones As Button
    Friend WithEvents cmdDiasLibres As Button
    Friend WithEvents cmdUsuarios As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents FechaPresentacion As Label
    Friend WithEvents HoraPresentacion As Label
    Friend WithEvents Panelrrhh As Panel
    Friend WithEvents cmdexpediante As Button
    Friend WithEvents cmdaspirantes As Button
    Friend WithEvents cmdregistro As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents AniversarioTableAdapter1 As RRHHDataSetTableAdapters.AniversarioTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents G_UltimoLogin As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents RecordatorioBindingSource As BindingSource
    Friend WithEvents RecordatorioTableAdapter As ABASDataSetTableAdapters.RecordatorioTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents PanelUpdate As GroupBox
    Friend WithEvents cmdInventario As Button
    Friend WithEvents panelInventario As Panel
    Friend WithEvents cmdUniformes As Button
    Friend WithEvents cmdArmeria As Button
    Friend WithEvents cmdProveedores As Button
    Friend WithEvents cmdMob As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CmdGuardar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents cmdEquipo As Button
End Class
