<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_45
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AusenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperacionesDataSet = New ABASSecurity.OperacionesDataSet()
        Me.ABASDataSet = New ABASSecurity.ABASDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AusenciasTableAdapter = New ABASSecurity.OperacionesDataSetTableAdapters.AusenciasTableAdapter()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbuscarEmp = New System.Windows.Forms.TextBox()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.EmpleadosTableAdapter = New ABASSecurity.ABASDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New ABASSecurity.ABASDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.AusenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.panelEmpleados.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AusenciasBindingSource
        '
        Me.AusenciasBindingSource.DataMember = "Ausencias"
        Me.AusenciasBindingSource.DataSource = Me.OperacionesDataSet
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
        ReportDataSource1.Value = Me.AusenciasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_45.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 104)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1183, 607)
        Me.ReportViewer1.TabIndex = 0
        '
        'AusenciasTableAdapter
        '
        Me.AusenciasTableAdapter.ClearBeforeFill = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(372, 25)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(120, 27)
        Me.cmdActualizar.TabIndex = 41
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Codigo de Empleado:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(328, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(127, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 38
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.Location = New System.Drawing.Point(130, 25)
        Me.txtbusqueda.MaxLength = 6
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(197, 20)
        Me.txtbusqueda.TabIndex = 37
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GroupBox2.Size = New System.Drawing.Size(276, 83)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro entre fechas para faltas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 31)
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
        Me.Fecha1.Size = New System.Drawing.Size(192, 20)
        Me.Fecha1.TabIndex = 2
        '
        'Fecha2
        '
        Me.Fecha2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha2.Location = New System.Drawing.Point(67, 51)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(192, 20)
        Me.Fecha2.TabIndex = 3
        '
        'panelEmpleados
        '
        Me.panelEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelEmpleados.Controls.Add(Me.PictureBox1)
        Me.panelEmpleados.Controls.Add(Me.Panel2)
        Me.panelEmpleados.Controls.Add(Me.txtbuscarEmp)
        Me.panelEmpleados.Controls.Add(Me.tipodebusqueda)
        Me.panelEmpleados.Location = New System.Drawing.Point(296, 152)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(571, 364)
        Me.panelEmpleados.TabIndex = 42
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn18})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 48)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(569, 314)
        Me.EmpleadosDataGridView.TabIndex = 12
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "identidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Identidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 76
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "planilla"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Planilla"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 65
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ABASDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox1.Location = New System.Drawing.Point(387, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(186, 40)
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
        Me.txtbuscarEmp.Location = New System.Drawing.Point(189, 20)
        Me.txtbuscarEmp.Multiline = True
        Me.txtbuscarEmp.Name = "txtbuscarEmp"
        Me.txtbuscarEmp.Size = New System.Drawing.Size(197, 20)
        Me.txtbuscarEmp.TabIndex = 8
        Me.txtbuscarEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo", "Nombre", "Identidad"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(49, 20)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.DetalleSolicitudTableAdapter = Nothing
        Me.TableAdapterManager.DevolucionUniformeTableAdapter = Nothing
        Me.TableAdapterManager.DiasTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtbusqueda)
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 83)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Empleado"
        '
        'R_45
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panelEmpleados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_45"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AusenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelEmpleados.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AusenciasBindingSource As BindingSource
    Friend WithEvents OperacionesDataSet As OperacionesDataSet
    Friend WithEvents ABASDataSet As ABASDataSet
    Friend WithEvents AusenciasTableAdapter As OperacionesDataSetTableAdapters.AusenciasTableAdapter
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fecha1 As DateTimePicker
    Friend WithEvents Fecha2 As DateTimePicker
    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbuscarEmp As TextBox
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ABASDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ABASDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
