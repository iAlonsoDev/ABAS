﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R_Planilla
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
        Me.PlanillaComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.P_PlanillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDataSet = New ABASSecurity.PlanillaDataSet()
        Me.P_PlanillaTableAdapter = New ABASSecurity.PlanillaDataSetTableAdapters.P_PlanillaTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.P_PlanillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlanillaComboBox
        '
        Me.PlanillaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlanillaComboBox.FormattingEnabled = True
        Me.PlanillaComboBox.Items.AddRange(New Object() {"LA01", "LA02", "VL01", "ABAS1", "ABAS2", "ADMON01", "ADMON02", "GTES01", "GTES02", "CUSTODIO"})
        Me.PlanillaComboBox.Location = New System.Drawing.Point(52, 21)
        Me.PlanillaComboBox.Name = "PlanillaComboBox"
        Me.PlanillaComboBox.Size = New System.Drawing.Size(160, 21)
        Me.PlanillaComboBox.TabIndex = 45
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
        Me.GroupBox2.Size = New System.Drawing.Size(276, 76)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de Pagos por Planilla"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Desde:"
        '
        'Fecha1
        '
        Me.Fecha1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha1.CustomFormat = "dd-MM-yyyy"
        Me.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha1.Location = New System.Drawing.Point(67, 21)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(193, 20)
        Me.Fecha1.TabIndex = 2
        '
        'Fecha2
        '
        Me.Fecha2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha2.CustomFormat = "dd-MM-yyyy"
        Me.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha2.Location = New System.Drawing.Point(67, 47)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(193, 20)
        Me.Fecha2.TabIndex = 3
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(52, 42)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(160, 25)
        Me.cmdActualizar.TabIndex = 47
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.P_PlanillaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.Reporte_Planilla.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 94)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1184, 618)
        Me.ReportViewer1.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.PlanillaComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(294, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 76)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planilla"
        '
        'P_PlanillaBindingSource
        '
        Me.P_PlanillaBindingSource.DataMember = "P_Planilla"
        Me.P_PlanillaBindingSource.DataSource = Me.PlanillaDataSet
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "PlanillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_PlanillaTableAdapter
        '
        Me.P_PlanillaTableAdapter.ClearBeforeFill = True
        '
        'R_Planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_Planilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.P_PlanillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlanillaComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fecha1 As DateTimePicker
    Friend WithEvents Fecha2 As DateTimePicker
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents P_PlanillaBindingSource As BindingSource
    Friend WithEvents PlanillaDataSet As PlanillaDataSet
    Friend WithEvents P_PlanillaTableAdapter As PlanillaDataSetTableAdapters.P_PlanillaTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
End Class
