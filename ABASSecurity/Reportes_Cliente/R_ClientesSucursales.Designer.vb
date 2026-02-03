<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R_ClientesSucursales
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OtrosDataSet = New ABASSecurity.OtrosDataSet()
        Me.Rpt_ClientesSucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rpt_ClientesSucursalesTableAdapter = New ABASSecurity.OtrosDataSetTableAdapters.Rpt_ClientesSucursalesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OtrosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt_ClientesSucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Rpt_ClientesSucursalesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_ClientesSucursales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 101)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(798, 347)
        Me.ReportViewer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 83)
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
        Me.cmdActualizar.Location = New System.Drawing.Point(419, 24)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(121, 47)
        Me.cmdActualizar.TabIndex = 36
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(351, 20)
        Me.TextBox1.TabIndex = 39
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DropDownHeight = 100
        Me.ClienteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.IntegralHeight = False
        Me.ClienteComboBox.Location = New System.Drawing.Point(62, 48)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(351, 21)
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
        'OtrosDataSet
        '
        Me.OtrosDataSet.DataSetName = "OtrosDataSet"
        Me.OtrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rpt_ClientesSucursalesBindingSource
        '
        Me.Rpt_ClientesSucursalesBindingSource.DataMember = "Rpt_ClientesSucursales"
        Me.Rpt_ClientesSucursalesBindingSource.DataSource = Me.OtrosDataSet
        '
        'Rpt_ClientesSucursalesTableAdapter
        '
        Me.Rpt_ClientesSucursalesTableAdapter.ClearBeforeFill = True
        '
        'R_ClientesSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_ClientesSucursales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OtrosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt_ClientesSucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ClienteComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Rpt_ClientesSucursalesBindingSource As BindingSource
    Friend WithEvents OtrosDataSet As OtrosDataSet
    Friend WithEvents Rpt_ClientesSucursalesTableAdapter As OtrosDataSetTableAdapters.Rpt_ClientesSucursalesTableAdapter
End Class
