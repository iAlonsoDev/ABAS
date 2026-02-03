<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_DetallePlanilla_Usuario
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
        Me.detalledeplanilla_usuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDataSet = New ABASSecurity.PlanillaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.detalledeplanilla_usuarioTableAdapter = New ABASSecurity.PlanillaDataSetTableAdapters.detalledeplanilla_usuarioTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PlanillaComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.detalledeplanilla_usuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'detalledeplanilla_usuarioBindingSource
        '
        Me.detalledeplanilla_usuarioBindingSource.DataMember = "detalledeplanilla_usuario"
        Me.detalledeplanilla_usuarioBindingSource.DataSource = Me.PlanillaDataSet
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "PlanillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.detalledeplanilla_usuarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_DetallePlanilla_Usuario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 101)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 614)
        Me.ReportViewer1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Planilla:"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(239, 25)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(126, 48)
        Me.cmdActualizar.TabIndex = 68
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Size = New System.Drawing.Size(285, 83)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de fechas - Planilla"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Desde:"
        '
        'Fecha1
        '
        Me.Fecha1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha1.Location = New System.Drawing.Point(63, 25)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(197, 20)
        Me.Fecha1.TabIndex = 2
        '
        'Fecha2
        '
        Me.Fecha2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha2.Location = New System.Drawing.Point(63, 51)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(197, 20)
        Me.Fecha2.TabIndex = 3
        '
        'detalledeplanilla_usuarioTableAdapter
        '
        Me.detalledeplanilla_usuarioTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Usuario:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"LA01", "LA02", "VL01", "ABAS1", "ABAS2", "ADMON01", "ADMON02"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox1.TabIndex = 73
        '
        'PlanillaComboBox
        '
        Me.PlanillaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlanillaComboBox.FormattingEnabled = True
        Me.PlanillaComboBox.Items.AddRange(New Object() {"LA01", "LA02", "VL01", "ABAS1", "ABAS2", "ADMON01", "ADMON02", "GTES01", "GTES02", "CUSTODIO", "CENTROORIENTE01", "CENTROORIENTE02"})
        Me.PlanillaComboBox.Location = New System.Drawing.Point(77, 25)
        Me.PlanillaComboBox.Name = "PlanillaComboBox"
        Me.PlanillaComboBox.Size = New System.Drawing.Size(156, 21)
        Me.PlanillaComboBox.TabIndex = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.PlanillaComboBox)
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 83)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planilla"
        '
        'R_DetallePlanilla_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 715)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_DetallePlanilla_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.detalledeplanilla_usuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fecha1 As DateTimePicker
    Friend WithEvents Fecha2 As DateTimePicker
    Friend WithEvents detalledeplanilla_usuarioBindingSource As BindingSource
    Friend WithEvents PlanillaDataSet As PlanillaDataSet
    Friend WithEvents detalledeplanilla_usuarioTableAdapter As PlanillaDataSetTableAdapters.detalledeplanilla_usuarioTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PlanillaComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
