<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGraficas
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MCliente = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChartCantidad = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ubicaciones = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.totSucu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.empPrue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.totClie = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TotEmpl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.MCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ubicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(465, 30)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Empleado mas Asignado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MCliente
        '
        Me.MCliente.BackColor = System.Drawing.Color.Transparent
        Me.MCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MCliente.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.MCliente.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.MCliente.BorderlineColor = System.Drawing.Color.Transparent
        Me.MCliente.BorderlineWidth = 0
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.Inclination = 10
        ChartArea1.Area3DStyle.IsClustered = True
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.Rotation = 20
        ChartArea1.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.BackImageTransparentColor = System.Drawing.SystemColors.Control
        ChartArea1.BackSecondaryColor = System.Drawing.SystemColors.Control
        ChartArea1.Name = "ChartArea1"
        Me.MCliente.ChartAreas.Add(ChartArea1)
        Me.MCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.BackColor = System.Drawing.SystemColors.Control
        Legend1.IsDockedInsideChartArea = False
        Legend1.MaximumAutoSize = 0!
        Legend1.Name = "Legend1"
        Me.MCliente.Legends.Add(Legend1)
        Me.MCliente.Location = New System.Drawing.Point(3, 46)
        Me.MCliente.Name = "MCliente"
        Me.MCliente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.MCliente.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))}
        Series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Series1.BackImageTransparentColor = System.Drawing.Color.White
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Series1.IsXValueIndexed = True
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series1.LabelBorderWidth = 0
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Series1.ShadowColor = System.Drawing.Color.White
        Series1.YValuesPerPoint = 4
        Me.MCliente.Series.Add(Series1)
        Me.MCliente.Size = New System.Drawing.Size(465, 279)
        Me.MCliente.TabIndex = 13
        Me.MCliente.Text = "Chart1"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(449, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cliente con mas Sucursales"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChartCantidad
        '
        Me.ChartCantidad.BackColor = System.Drawing.Color.Transparent
        Me.ChartCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChartCantidad.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.ChartCantidad.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.ChartCantidad.BorderlineColor = System.Drawing.Color.Transparent
        Me.ChartCantidad.BorderlineWidth = 0
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.IsClustered = True
        ChartArea2.Area3DStyle.IsRightAngleAxes = False
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.BackColor = System.Drawing.SystemColors.Control
        ChartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        ChartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross
        ChartArea2.BackImageTransparentColor = System.Drawing.SystemColors.Control
        ChartArea2.BackSecondaryColor = System.Drawing.SystemColors.Control
        ChartArea2.Name = "ChartArea1"
        Me.ChartCantidad.ChartAreas.Add(ChartArea2)
        Me.ChartCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.BackColor = System.Drawing.SystemColors.Control
        Legend2.Name = "Legend1"
        Me.ChartCantidad.Legends.Add(Legend2)
        Me.ChartCantidad.Location = New System.Drawing.Point(3, 41)
        Me.ChartCantidad.Name = "ChartCantidad"
        Me.ChartCantidad.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))}
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        Series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Series2.BackImageTransparentColor = System.Drawing.Color.DimGray
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Series2.IsValueShownAsLabel = True
        Series2.IsXValueIndexed = True
        Series2.LabelBackColor = System.Drawing.Color.Transparent
        Series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series2.LabelBorderWidth = 0
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.ShadowColor = System.Drawing.Color.White
        Series2.YValuesPerPoint = 2
        Me.ChartCantidad.Series.Add(Series2)
        Me.ChartCantidad.Size = New System.Drawing.Size(449, 284)
        Me.ChartCantidad.TabIndex = 11
        Me.ChartCantidad.Text = "Chart1"
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(965, 26)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Datos Estadisticos de la Empresa"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(929, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Empleado por Ubicacion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ubicaciones
        '
        Me.Ubicaciones.BackColor = System.Drawing.Color.Transparent
        Me.Ubicaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Ubicaciones.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Ubicaciones.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea3.Area3DStyle.Enable3D = True
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.Ubicaciones.ChartAreas.Add(ChartArea3)
        Me.Ubicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.Name = "Legend1"
        Legend3.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Me.Ubicaciones.Legends.Add(Legend3)
        Me.Ubicaciones.Location = New System.Drawing.Point(3, 41)
        Me.Ubicaciones.Name = "Ubicaciones"
        Me.Ubicaciones.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Series3.IsValueShownAsLabel = True
        Series3.LabelForeColor = System.Drawing.Color.White
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Ubicaciones.Series.Add(Series3)
        Me.Ubicaciones.Size = New System.Drawing.Size(929, 438)
        Me.Ubicaciones.TabIndex = 34
        Me.Ubicaciones.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.totSucu)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.empPrue)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.totClie)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TotEmpl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(942, 92)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes y Empleados"
        '
        'totSucu
        '
        Me.totSucu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totSucu.AutoSize = True
        Me.totSucu.BackColor = System.Drawing.Color.SteelBlue
        Me.totSucu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totSucu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.totSucu.Location = New System.Drawing.Point(332, 58)
        Me.totSucu.Name = "totSucu"
        Me.totSucu.Size = New System.Drawing.Size(57, 17)
        Me.totSucu.TabIndex = 43
        Me.totSucu.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(325, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Sucursales"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox4.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Geo_fence_96px
        Me.PictureBox4.Location = New System.Drawing.Point(270, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 44
        Me.PictureBox4.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(264, 32)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(198, 53)
        Me.TextBox4.TabIndex = 46
        '
        'empPrue
        '
        Me.empPrue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.empPrue.AutoSize = True
        Me.empPrue.BackColor = System.Drawing.Color.SteelBlue
        Me.empPrue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empPrue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.empPrue.Location = New System.Drawing.Point(738, 59)
        Me.empPrue.Name = "empPrue"
        Me.empPrue.Size = New System.Drawing.Size(57, 17)
        Me.empPrue.TabIndex = 39
        Me.empPrue.Text = "Label8"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(732, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Empleados en Prueba"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox3.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Order_History_96px
        Me.PictureBox3.Location = New System.Drawing.Point(677, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(671, 32)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 53)
        Me.TextBox3.TabIndex = 42
        '
        'totClie
        '
        Me.totClie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totClie.AutoSize = True
        Me.totClie.BackColor = System.Drawing.Color.SteelBlue
        Me.totClie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totClie.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.totClie.Location = New System.Drawing.Point(129, 59)
        Me.totClie.Name = "totClie"
        Me.totClie.Size = New System.Drawing.Size(57, 17)
        Me.totClie.TabIndex = 35
        Me.totClie.Text = "Label8"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(122, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Clientes Activos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Meeting_96px
        Me.PictureBox2.Location = New System.Drawing.Point(67, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(60, 32)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(198, 53)
        Me.TextBox2.TabIndex = 38
        '
        'TotEmpl
        '
        Me.TotEmpl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TotEmpl.AutoSize = True
        Me.TotEmpl.BackColor = System.Drawing.Color.SteelBlue
        Me.TotEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotEmpl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotEmpl.Location = New System.Drawing.Point(534, 59)
        Me.TotEmpl.Name = "TotEmpl"
        Me.TotEmpl.Size = New System.Drawing.Size(57, 17)
        Me.TotEmpl.TabIndex = 31
        Me.TotEmpl.Text = "Label8"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(528, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Empleados Activos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Contacts_96px
        Me.PictureBox1.Location = New System.Drawing.Point(473, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(467, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 53)
        Me.TextBox1.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Ubicaciones)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(935, 482)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.ChartCantidad)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(455, 328)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.MCliente)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(461, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(471, 328)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 666)
        Me.Panel1.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Location = New System.Drawing.Point(7, 582)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(935, 334)
        Me.Panel2.TabIndex = 38
        '
        'FormGraficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 692)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGraficas"
        Me.Text = "FormEstadisticas"
        CType(Me.MCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ubicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents MCliente As DataVisualization.Charting.Chart
    Friend WithEvents Label6 As Label
    Friend WithEvents ChartCantidad As DataVisualization.Charting.Chart
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Ubicaciones As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents totSucu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents empPrue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents totClie As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TotEmpl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
