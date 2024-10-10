<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_Inactivos
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
        Me.EInactivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RRHHDataSet = New ABASSecurity.RRHHDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EInactivoTableAdapter = New ABASSecurity.RRHHDataSetTableAdapters.EInactivoTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.EInactivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EInactivoBindingSource
        '
        Me.EInactivoBindingSource.DataMember = "EInactivo"
        Me.EInactivoBindingSource.DataSource = Me.RRHHDataSet
        '
        'ABASDataSet
        '
        Me.RRHHDataSet.DataSetName = "RRHHDataSet"
        Me.RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EInactivoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_Inactivos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 712)
        Me.ReportViewer1.TabIndex = 0
        '
        'EInactivoTableAdapter
        '
        Me.EInactivoTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.date2)
        Me.GroupBox1.Controls.Add(Me.date1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas para Inactivos"
        '
        'date2
        '
        Me.date2.Location = New System.Drawing.Point(37, 54)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(196, 20)
        Me.date2.TabIndex = 1
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(37, 28)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(196, 20)
        Me.date1.TabIndex = 0
        '
        'R_Inactivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_Inactivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EInactivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RRHHDataSet As RRHHDataSet
    Friend WithEvents EInactivoBindingSource As BindingSource
    Friend WithEvents EInactivoTableAdapter As RRHHDataSetTableAdapters.EInactivoTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents date2 As DateTimePicker
    Friend WithEvents date1 As DateTimePicker
End Class
