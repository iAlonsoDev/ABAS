<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_MovimientosUniformesTipo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label24 As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Cmb_TipoUniforme = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InventarioDataSet = New ABASSecurity.InventarioDataSet()
        Me.Inventario_MovimientoUniforme_TipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventario_MovimientoUniforme_TipoTableAdapter = New ABASSecurity.InventarioDataSetTableAdapters.Inventario_MovimientoUniforme_TipoTableAdapter()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Label24 = New System.Windows.Forms.Label()
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_MovimientoUniforme_TipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmb_TipoUniforme
        '
        Me.Cmb_TipoUniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_TipoUniforme.FormattingEnabled = True
        Me.Cmb_TipoUniforme.Items.AddRange(New Object() {"Pantalon", "Camisa", "Camisa Centro", "Ligas", "Gorra", "Calzado", "Faja"})
        Me.Cmb_TipoUniforme.Location = New System.Drawing.Point(102, 27)
        Me.Cmb_TipoUniforme.Name = "Cmb_TipoUniforme"
        Me.Cmb_TipoUniforme.Size = New System.Drawing.Size(204, 21)
        Me.Cmb_TipoUniforme.TabIndex = 69
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(19, 30)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(76, 13)
        Label24.TabIndex = 68
        Label24.Text = "Tipo Uniforme:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Inventario_MovimientoUniforme_TipoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_MovimientosUniformesTipo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 59)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(797, 388)
        Me.ReportViewer1.TabIndex = 70
        '
        'InventarioDataSet
        '
        Me.InventarioDataSet.DataSetName = "InventarioDataSet"
        Me.InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Inventario_MovimientoUniforme_TipoBindingSource
        '
        Me.Inventario_MovimientoUniforme_TipoBindingSource.DataMember = "Inventario_MovimientoUniforme_Tipo"
        Me.Inventario_MovimientoUniforme_TipoBindingSource.DataSource = Me.InventarioDataSet
        '
        'Inventario_MovimientoUniforme_TipoTableAdapter
        '
        Me.Inventario_MovimientoUniforme_TipoTableAdapter.ClearBeforeFill = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(312, 27)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(121, 26)
        Me.cmdActualizar.TabIndex = 71
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'R_MovimientosUniformesTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Cmb_TipoUniforme)
        Me.Controls.Add(Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_MovimientosUniformesTipo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_MovimientoUniforme_TipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmb_TipoUniforme As ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Inventario_MovimientoUniforme_TipoBindingSource As BindingSource
    Friend WithEvents InventarioDataSet As InventarioDataSet
    Friend WithEvents Inventario_MovimientoUniforme_TipoTableAdapter As InventarioDataSetTableAdapters.Inventario_MovimientoUniforme_TipoTableAdapter
    Friend WithEvents cmdActualizar As Button
End Class
