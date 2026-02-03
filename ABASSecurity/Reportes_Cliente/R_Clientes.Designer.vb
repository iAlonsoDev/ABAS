<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_Clientes
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OtrosDataSet = New ABASSecurity.OtrosDataSet()
        Me.Rpt_ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rpt_ClientesTableAdapter = New ABASSecurity.OtrosDataSetTableAdapters.Rpt_ClientesTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.OtrosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt_ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.Rpt_ClientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_Clientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 83)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(799, 365)
        Me.ReportViewer1.TabIndex = 0
        '
        'OtrosDataSet
        '
        Me.OtrosDataSet.DataSetName = "OtrosDataSet"
        Me.OtrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rpt_ClientesBindingSource
        '
        Me.Rpt_ClientesBindingSource.DataMember = "Rpt_Clientes"
        Me.Rpt_ClientesBindingSource.DataSource = Me.OtrosDataSet
        '
        'Rpt_ClientesTableAdapter
        '
        Me.Rpt_ClientesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 65)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Cliente"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(267, 19)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(121, 25)
        Me.cmdActualizar.TabIndex = 36
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DropDownHeight = 100
        Me.ClienteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.IntegralHeight = False
        Me.ClienteComboBox.Items.AddRange(New Object() {"ACTIVO", "INACTIVO", "TODOS"})
        Me.ClienteComboBox.Location = New System.Drawing.Point(62, 23)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(180, 21)
        Me.ClienteComboBox.Sorted = True
        Me.ClienteComboBox.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Cliente:"
        '
        'R_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OtrosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt_ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Rpt_ClientesBindingSource As BindingSource
    Friend WithEvents OtrosDataSet As OtrosDataSet
    Friend WithEvents Rpt_ClientesTableAdapter As OtrosDataSetTableAdapters.Rpt_ClientesTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents ClienteComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
