<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R_TiposDocumentosEmpleados
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RRHHDataSet = New ABASSecurity.RRHHDataSet()
        Me.RRHHTipoDocumentosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RRHH_TipoDocumentosEmpleadosTableAdapter = New ABASSecurity.RRHHDataSetTableAdapters.RRHH_TipoDocumentosEmpleadosTableAdapter()
        Me.RRHH_TipoDocumentosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RRHHTipoDocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RRHH_TipoDocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.cmdActualizar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 107)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de Expedientes"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Incompleto", "Completo"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(307, 21)
        Me.ComboBox1.TabIndex = 37
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(116, 68)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(70, 21)
        Me.cmdActualizar.TabIndex = 36
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Tipos de Documentos"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.RRHH_TipoDocumentosEmpleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_TiposDocumentosEmpleados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 711)
        Me.ReportViewer1.TabIndex = 39
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'RRHHDataSet
        '
        Me.RRHHDataSet.DataSetName = "RRHHDataSet"
        Me.RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RRHHTipoDocumentosEmpleadosBindingSource
        '
        Me.RRHHTipoDocumentosEmpleadosBindingSource.DataMember = "RRHH_TipoDocumentosEmpleados"
        Me.RRHHTipoDocumentosEmpleadosBindingSource.DataSource = Me.RRHHDataSet
        '
        'RRHH_TipoDocumentosEmpleadosTableAdapter
        '
        Me.RRHH_TipoDocumentosEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'RRHH_TipoDocumentosEmpleadosBindingSource
        '
        Me.RRHH_TipoDocumentosEmpleadosBindingSource.DataMember = "RRHH_TipoDocumentosEmpleados"
        Me.RRHH_TipoDocumentosEmpleadosBindingSource.DataSource = Me.RRHHDataSet
        '
        'R_TiposDocumentosEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_TiposDocumentosEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RRHHTipoDocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RRHH_TipoDocumentosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RRHHTipoDocumentosEmpleadosBindingSource As BindingSource
    Friend WithEvents RRHHDataSet As RRHHDataSet
    Friend WithEvents RRHH_TipoDocumentosEmpleadosTableAdapter As RRHHDataSetTableAdapters.RRHH_TipoDocumentosEmpleadosTableAdapter
    Friend WithEvents RRHH_TipoDocumentosEmpleadosBindingSource As BindingSource
End Class
