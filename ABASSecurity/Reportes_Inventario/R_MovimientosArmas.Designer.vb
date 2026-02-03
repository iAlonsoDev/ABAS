<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_MovimientosArmas
    Inherits System.Windows.Forms.Form

    'Form reemplaza RRHH Dispose para limpiar la lista de componentes.
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
        Dim SerieLabel1 As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MovimientosArmaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioDataSet = New ABASSecurity.InventarioDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MovimientosArmaTableAdapter = New ABASSecurity.InventarioDataSetTableAdapters.MovimientosArmaTableAdapter()
        Me.ArmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArmasTableAdapter = New ABASSecurity.InventarioDataSetTableAdapters.ArmasTableAdapter()
        Me.PanelBusSerie = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SerieTextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        SerieLabel1 = New System.Windows.Forms.Label()
        CType(Me.MovimientosArmaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBusSerie.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerieLabel1
        '
        SerieLabel1.AutoSize = True
        SerieLabel1.Location = New System.Drawing.Point(34, 22)
        SerieLabel1.Name = "SerieLabel1"
        SerieLabel1.Size = New System.Drawing.Size(34, 13)
        SerieLabel1.TabIndex = 54
        SerieLabel1.Text = "Serie:"
        '
        'MovimientosArmaBindingSource
        '
        Me.MovimientosArmaBindingSource.DataMember = "MovimientosArma"
        Me.MovimientosArmaBindingSource.DataSource = Me.InventarioDataSet
        '
        'InventarioDataSet
        '
        Me.InventarioDataSet.DataSetName = "InventarioDataSet"
        Me.InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MovimientosArmaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ABASSecurity.R_MovimientosArmas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 101)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1181, 545)
        Me.ReportViewer1.TabIndex = 0
        '
        'MovimientosArmaTableAdapter
        '
        Me.MovimientosArmaTableAdapter.ClearBeforeFill = True
        '
        'ArmasBindingSource
        '
        Me.ArmasBindingSource.DataMember = "Armas"
        Me.ArmasBindingSource.DataSource = Me.InventarioDataSet
        '
        'ArmasTableAdapter
        '
        Me.ArmasTableAdapter.ClearBeforeFill = True
        '
        'PanelBusSerie
        '
        Me.PanelBusSerie.BackColor = System.Drawing.SystemColors.Control
        Me.PanelBusSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBusSerie.Controls.Add(Me.DataGridView1)
        Me.PanelBusSerie.Controls.Add(Me.PictureBox7)
        Me.PanelBusSerie.Controls.Add(Me.Panel4)
        Me.PanelBusSerie.Controls.Add(Me.ComboBox2)
        Me.PanelBusSerie.Controls.Add(Me.TextBox4)
        Me.PanelBusSerie.Location = New System.Drawing.Point(225, 182)
        Me.PanelBusSerie.Name = "PanelBusSerie"
        Me.PanelBusSerie.Size = New System.Drawing.Size(604, 359)
        Me.PanelBusSerie.TabIndex = 53
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ArmasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(601, 316)
        Me.DataGridView1.TabIndex = 18
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Codigo de Arma"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Tipo de Arma"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "serie"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "calibre"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Calibre"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "permisodpi"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Permiso DPI"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "vdepermiso"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Vigencia de Permiso"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "ubicacion"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "color"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox7.Location = New System.Drawing.Point(423, 15)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(222, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 1)
        Me.Panel4.TabIndex = 17
        '
        'ComboBox2
        '
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Tipo", "Codigo", "Serie", "Marca"})
        Me.ComboBox2.Location = New System.Drawing.Point(85, 17)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox4.Location = New System.Drawing.Point(225, 17)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(197, 20)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SerieTextBox1
        '
        Me.SerieTextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SerieTextBox1.Location = New System.Drawing.Point(74, 19)
        Me.SerieTextBox1.Name = "SerieTextBox1"
        Me.SerieTextBox1.Size = New System.Drawing.Size(137, 20)
        Me.SerieTextBox1.TabIndex = 55
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(213, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.SerieTextBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(SerieLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 83)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro Serie"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(74, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox1.TabIndex = 57
        Me.CheckBox1.Text = "Todo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdActualizar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Fecha1)
        Me.GroupBox2.Controls.Add(Me.Fecha2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(290, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 83)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro de Fechas"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdActualizar.FlatAppearance.BorderSize = 0
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdActualizar.Location = New System.Drawing.Point(224, 46)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(101, 21)
        Me.cmdActualizar.TabIndex = 37
        Me.cmdActualizar.Text = "Generar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 44)
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
        Me.Fecha1.Location = New System.Drawing.Point(67, 19)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(134, 20)
        Me.Fecha1.TabIndex = 2
        '
        'Fecha2
        '
        Me.Fecha2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fecha2.CustomFormat = "dd-MM-yyyy"
        Me.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha2.Location = New System.Drawing.Point(67, 44)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(134, 20)
        Me.Fecha2.TabIndex = 3
        '
        'R_MovimientosArmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 645)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelBusSerie)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "R_MovimientosArmas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MovimientosArmaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBusSerie.ResumeLayout(False)
        Me.PanelBusSerie.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MovimientosArmaBindingSource As BindingSource
    Friend WithEvents InventarioDataSet As InventarioDataSet
    Friend WithEvents MovimientosArmaTableAdapter As InventarioDataSetTableAdapters.MovimientosArmaTableAdapter
    Friend WithEvents ArmasBindingSource As BindingSource
    Friend WithEvents ArmasTableAdapter As InventarioDataSetTableAdapters.ArmasTableAdapter
    Friend WithEvents PanelBusSerie As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents SerieTextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fecha1 As DateTimePicker
    Friend WithEvents Fecha2 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmdActualizar As Button
End Class
