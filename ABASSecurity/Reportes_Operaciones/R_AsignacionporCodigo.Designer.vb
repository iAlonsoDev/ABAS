<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R_AsignacionporCodigo
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AsignacionesPorCodigoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperacionesDataSet = New ABASSecurity.OperacionesDataSet()
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsignacionesPorCodigoTableAdapter = New ABASSecurity.OperacionesDataSetTableAdapters.AsignacionesPorCodigoTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.Texboxbuscador = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.AsignacionesPorCodigoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEmpleados.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AsignacionesPorCodigoBindingSource
        '
        Me.AsignacionesPorCodigoBindingSource.DataMember = "AsignacionesPorCodigo"
        Me.AsignacionesPorCodigoBindingSource.DataSource = Me.OperacionesDataSet
        '
        'OperacionesDataSet
        '
        Me.OperacionesDataSet.DataSetName = "OperacionesDataSet"
        Me.OperacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ABASDataSet
        '
        Me.ABASDataSet.DataSetName = "ABASDataSet"
        Me.ABASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AsignacionesPorCodigoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_AsignacionporCodigo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 101)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 610)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Codigo de Empleado:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(318, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(117, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Fecha1)
        Me.GroupBox2.Controls.Add(Me.Fecha2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 83)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de Asignaciones Por Codigo de Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Desde:"
        '
        'Fecha1
        '
        Me.Fecha1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha1.Location = New System.Drawing.Point(67, 25)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(201, 20)
        Me.Fecha1.TabIndex = 2
        '
        'Fecha2
        '
        Me.Fecha2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha2.Location = New System.Drawing.Point(67, 51)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(201, 20)
        Me.Fecha2.TabIndex = 3
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'AsignacionesPorCodigoTableAdapter
        '
        Me.AsignacionesPorCodigoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnticiposTableAdapter = Nothing
        Me.TableAdapterManager.ArmeriaTableAdapter = Nothing
        Me.TableAdapterManager.AsignacionesTableAdapter = Nothing
        Me.TableAdapterManager.AspirantesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarnetTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeTableAdapter = Nothing
        Me.TableAdapterManager.DiasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.ExpedientesTableAdapter = Nothing
        Me.TableAdapterManager.FaltasTableAdapter = Nothing
        Me.TableAdapterManager.FormaPagoTableAdapter = Nothing
        Me.TableAdapterManager.ImagenesTableAdapter = Nothing
        Me.TableAdapterManager.InactivosTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoArmasTableAdapter = Nothing
        Me.TableAdapterManager.MovimientoUniformesTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RecordatorioTableAdapter = Nothing
        Me.TableAdapterManager.RegistroCarnetTableAdapter = Nothing
        Me.TableAdapterManager.RegistroLoginTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudUniformeTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
        Me.TableAdapterManager.UbicacionesTableAdapter = Nothing
        Me.TableAdapterManager.UniformesRIngresosTableAdapter = Nothing
        Me.TableAdapterManager.UniformesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateNVTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosModulosTableAdapter = Nothing
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(361, 25)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(120, 45)
        Me.cmdActualizar.TabIndex = 34
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad", "Ubicacion", "Planilla"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(143, 24)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'Texboxbuscador
        '
        Me.Texboxbuscador.BackColor = System.Drawing.SystemColors.Control
        Me.Texboxbuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Texboxbuscador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Texboxbuscador.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Texboxbuscador.Location = New System.Drawing.Point(283, 24)
        Me.Texboxbuscador.Multiline = True
        Me.Texboxbuscador.Name = "Texboxbuscador"
        Me.Texboxbuscador.Size = New System.Drawing.Size(197, 20)
        Me.Texboxbuscador.TabIndex = 8
        Me.Texboxbuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(280, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(481, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.identidad, Me.planilla})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(-1, 52)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(673, 321)
        Me.EmpleadosDataGridView.TabIndex = 10
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
        'panelEmpleados
        '
        Me.panelEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelEmpleados.Controls.Add(Me.PictureBox1)
        Me.panelEmpleados.Controls.Add(Me.Panel2)
        Me.panelEmpleados.Controls.Add(Me.Texboxbuscador)
        Me.panelEmpleados.Controls.Add(Me.tipodebusqueda)
        Me.panelEmpleados.Location = New System.Drawing.Point(284, 179)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(673, 374)
        Me.panelEmpleados.TabIndex = 33
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtCodigo.Location = New System.Drawing.Point(120, 25)
        Me.TxtCodigo.MaxLength = 6
        Me.TxtCodigo.Multiline = True
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(197, 20)
        Me.TxtCodigo.TabIndex = 28
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 83)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Empleado"
        '
        'R_AsignacionporCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panelEmpleados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "R_AsignacionporCodigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AsignacionesPorCodigoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelEmpleados.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Fecha1 As DateTimePicker
    Friend WithEvents Fecha2 As DateTimePicker
    Friend WithEvents AsignacionesPorCodigoBindingSource As BindingSource
    Friend WithEvents OperacionesDataSet As OperacionesDataSet
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents AsignacionesPorCodigoTableAdapter As OperacionesDataSetTableAdapters.AsignacionesPorCodigoTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents Texboxbuscador As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents identidad As DataGridViewTextBoxColumn
    Friend WithEvents planilla As DataGridViewTextBoxColumn
    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
