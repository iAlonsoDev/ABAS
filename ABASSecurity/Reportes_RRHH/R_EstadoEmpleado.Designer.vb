<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_EstadoEmpleado
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
        Me.estadoempleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RRHHDataSet = New ABASSecurity.RRHHDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UbicacionComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.estadoempleadoTableAdapter = New ABASSecurity.RRHHDataSetTableAdapters.estadoempleadoTableAdapter()
        CType(Me.estadoempleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'estadoempleadoBindingSource
        '
        Me.estadoempleadoBindingSource.DataMember = "estadoempleado"
        Me.estadoempleadoBindingSource.DataSource = Me.RRHHDataSet
        '
        'ABASDataSet
        '
        Me.RRHHDataSet.DataSetName = "RRHHDataSet"
        Me.RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.estadoempleadoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_EstadoEmpleados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 115)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 596)
        Me.ReportViewer1.TabIndex = 0
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Activo", "Prueba", "Inactivo"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(360, 61)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 4
        Me.tipodebusqueda.Text = "Seleccione el estado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.UbicacionComboBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tipodebusqueda)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Fecha1)
        Me.GroupBox2.Controls.Add(Me.Fecha2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 97)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de empleados segun su estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Ubicacion:"
        '
        'UbicacionComboBox
        '
        Me.UbicacionComboBox.DropDownHeight = 100
        Me.UbicacionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UbicacionComboBox.FormattingEnabled = True
        Me.UbicacionComboBox.IntegralHeight = False
        Me.UbicacionComboBox.ItemHeight = 13
        Me.UbicacionComboBox.Items.AddRange(New Object() {"Azacualpa", "Choloma", "Copan Ruinas", "Cuyamel", "El Progreso", "La Ceiba", "La entrada, Copan", "La Esperanza, Intibuca", "Olanchito", "Omoa", "Peña Blanca", "Puerto Cortes", "Quimistan", "Saba, Colon", "San Juan Pueblo", "San Pedro Sula", "Santa Barbara", "Santa Cruz De Yojoa", "Santa Rita De Copan", "Santa Rosa De Copan", "Sonaguera", "Tela", "Tocoa", "Trinidad", "Villanueva", "Yamaranguila", "Yoro"})
        Me.UbicacionComboBox.Location = New System.Drawing.Point(360, 29)
        Me.UbicacionComboBox.Name = "UbicacionComboBox"
        Me.UbicacionComboBox.Size = New System.Drawing.Size(204, 21)
        Me.UbicacionComboBox.Sorted = True
        Me.UbicacionComboBox.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Desde:"
        '
        'Fecha1
        '
        Me.Fecha1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha1.Location = New System.Drawing.Point(83, 30)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(196, 20)
        Me.Fecha1.TabIndex = 2
        '
        'Fecha2
        '
        Me.Fecha2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha2.Location = New System.Drawing.Point(83, 62)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(196, 20)
        Me.Fecha2.TabIndex = 3
        '
        'estadoempleadoTableAdapter
        '
        Me.estadoempleadoTableAdapter.ClearBeforeFill = True
        '
        'R_EstadoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_EstadoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.estadoempleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RRHHDataSet As RRHHDataSet
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fecha1 As DateTimePicker
    Friend WithEvents Fecha2 As DateTimePicker
    Friend WithEvents estadoempleadoBindingSource As BindingSource
    Friend WithEvents estadoempleadoTableAdapter As RRHHDataSetTableAdapters.estadoempleadoTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents UbicacionComboBox As ComboBox
End Class
