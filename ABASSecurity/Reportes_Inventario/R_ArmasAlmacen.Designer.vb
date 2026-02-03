<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_ArmasAlmacen
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InventarioDataSet = New ABASSecurity.InventarioDataSet()
        Me.ArmasAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArmasAlmacenTableAdapter = New ABASSecurity.InventarioDataSetTableAdapters.ArmasAlmacenTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmasAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.cmdActualizar)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 88)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Almacen"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Todo", "A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(35, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 37
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(35, 46)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(121, 26)
        Me.cmdActualizar.TabIndex = 36
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ArmasAlmacenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_ArmasAlmacen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 106)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(797, 347)
        Me.ReportViewer1.TabIndex = 38
        '
        'InventarioDataSet
        '
        Me.InventarioDataSet.DataSetName = "InventarioDataSet"
        Me.InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArmasAlmacenBindingSource
        '
        Me.ArmasAlmacenBindingSource.DataMember = "ArmasAlmacen"
        Me.ArmasAlmacenBindingSource.DataSource = Me.InventarioDataSet
        '
        'ArmasAlmacenTableAdapter
        '
        Me.ArmasAlmacenTableAdapter.ClearBeforeFill = True
        '
        'R_ArmasAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_ArmasAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmasAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ArmasAlmacenBindingSource As BindingSource
    Friend WithEvents InventarioDataSet As InventarioDataSet
    Friend WithEvents ArmasAlmacenTableAdapter As InventarioDataSetTableAdapters.ArmasAlmacenTableAdapter
End Class
