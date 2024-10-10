<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRRHHDocumentos_BCK
    Inherits System.Windows.Forms.Form

    'Form reemplaza RRHH Dispose para limpiar la lista de componentes.
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
        Me.cmdSeleccionarImagen = New System.Windows.Forms.Button()
        Me.cmdRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelEmpleados = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.tipodebusqueda = New System.Windows.Forms.ComboBox()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.cmdBuscar = New System.Windows.Forms.PictureBox()
        Me.cmbder = New System.Windows.Forms.PictureBox()
        Me.cmbizq = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelEmpleados.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbizq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSeleccionarImagen
        '
        Me.cmdSeleccionarImagen.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdSeleccionarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdSeleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSeleccionarImagen.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSeleccionarImagen.ForeColor = System.Drawing.Color.White
        Me.cmdSeleccionarImagen.Location = New System.Drawing.Point(43, 129)
        Me.cmdSeleccionarImagen.Name = "cmdSeleccionarImagen"
        Me.cmdSeleccionarImagen.Size = New System.Drawing.Size(126, 23)
        Me.cmdSeleccionarImagen.TabIndex = 0
        Me.cmdSeleccionarImagen.Text = "Seleccionar Imagen"
        Me.cmdSeleccionarImagen.UseVisualStyleBackColor = False
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegistrar.ForeColor = System.Drawing.Color.White
        Me.cmdRegistrar.Location = New System.Drawing.Point(43, 164)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(126, 23)
        Me.cmdRegistrar.TabIndex = 1
        Me.cmdRegistrar.Text = "Guardar"
        Me.cmdRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Empleado"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(43, 41)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(126, 20)
        Me.txtId.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Fotografia", "Solicitud de empleo", "Curriculum", "Titulo", "Identidad", "Licencia de manejo", "Antecedentes Penales", "Antecedentes Judiciales", "Croquis de vivienda", "Recibo publico", "Tarjeta de salud", "Prueba psicometrica", "Entrevista operativa", "Compromisos", "Contrato", "Vacaciones", "Otros..."})
        Me.ComboBox1.Location = New System.Drawing.Point(43, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(126, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Documento"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(564, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "1"
        '
        'panelEmpleados
        '
        Me.panelEmpleados.BackColor = System.Drawing.SystemColors.Control
        Me.panelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleados.Controls.Add(Me.PictureBox2)
        Me.panelEmpleados.Controls.Add(Me.Panel2)
        Me.panelEmpleados.Controls.Add(Me.txtbusqueda)
        Me.panelEmpleados.Controls.Add(Me.tipodebusqueda)
        Me.panelEmpleados.Controls.Add(Me.EmpleadosDataGridView)
        Me.panelEmpleados.Location = New System.Drawing.Point(231, 76)
        Me.panelEmpleados.Name = "panelEmpleados"
        Me.panelEmpleados.Size = New System.Drawing.Size(682, 355)
        Me.panelEmpleados.TabIndex = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.PictureBox2.Location = New System.Drawing.Point(475, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(274, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 9
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbusqueda.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtbusqueda.Location = New System.Drawing.Point(277, 19)
        Me.txtbusqueda.Multiline = True
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(197, 20)
        Me.txtbusqueda.TabIndex = 8
        Me.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipodebusqueda
        '
        Me.tipodebusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.tipodebusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tipodebusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipodebusqueda.FormattingEnabled = True
        Me.tipodebusqueda.Items.AddRange(New Object() {"Codigo de Empleado", "Nombre", "Identidad"})
        Me.tipodebusqueda.Location = New System.Drawing.Point(137, 19)
        Me.tipodebusqueda.Name = "tipodebusqueda"
        Me.tipodebusqueda.Size = New System.Drawing.Size(131, 21)
        Me.tipodebusqueda.TabIndex = 7
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombres, Me.apellidos, Me.identidad, Me.estado})
        Me.EmpleadosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(-1, 47)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(682, 307)
        Me.EmpleadosDataGridView.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "ID Empleado"
        Me.codigo.Name = "codigo"
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "nombres"
        Me.nombres.HeaderText = "Nombre"
        Me.nombres.Name = "nombres"
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.HeaderText = "Apellido"
        Me.apellidos.Name = "apellidos"
        '
        'identidad
        '
        Me.identidad.DataPropertyName = "identidad"
        Me.identidad.HeaderText = "Identidad"
        Me.identidad.Name = "identidad"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(43, 245)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.Text = "Fotografia"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(43, 267)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(118, 17)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.Text = "Solicitud de empleo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(43, 289)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox3.TabIndex = 33
        Me.CheckBox3.Text = "Curriculum"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(43, 311)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox4.TabIndex = 34
        Me.CheckBox4.Text = "Titulo"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(43, 333)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox5.TabIndex = 35
        Me.CheckBox5.Text = "Identidad"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.Location = New System.Drawing.Point(43, 355)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(118, 17)
        Me.CheckBox6.TabIndex = 36
        Me.CheckBox6.Text = "Licencia de manejo"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Enabled = False
        Me.CheckBox7.Location = New System.Drawing.Point(43, 377)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox7.TabIndex = 37
        Me.CheckBox7.Text = "Antecedentes Penales"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Enabled = False
        Me.CheckBox8.Location = New System.Drawing.Point(43, 399)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(141, 17)
        Me.CheckBox8.TabIndex = 38
        Me.CheckBox8.Text = "Antecedentes Judiciales"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Enabled = False
        Me.CheckBox9.Location = New System.Drawing.Point(43, 421)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox9.TabIndex = 39
        Me.CheckBox9.Text = "Croquis de Vivienda"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Enabled = False
        Me.CheckBox10.Location = New System.Drawing.Point(43, 443)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox10.TabIndex = 40
        Me.CheckBox10.Text = "Recibo Publico"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Enabled = False
        Me.CheckBox11.Location = New System.Drawing.Point(43, 465)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox11.TabIndex = 41
        Me.CheckBox11.Text = "Tarjeta de salud"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Enabled = False
        Me.CheckBox12.Location = New System.Drawing.Point(43, 487)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox12.TabIndex = 42
        Me.CheckBox12.Text = "Prueba psicometrica"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Enabled = False
        Me.CheckBox16.Location = New System.Drawing.Point(43, 597)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox16.TabIndex = 50
        Me.CheckBox16.Text = "Otros..."
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Enabled = False
        Me.CheckBox15.Location = New System.Drawing.Point(43, 553)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox15.TabIndex = 49
        Me.CheckBox15.Text = "Contrato"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Enabled = False
        Me.CheckBox13.Location = New System.Drawing.Point(43, 509)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox13.TabIndex = 47
        Me.CheckBox13.Text = "Entrevista Operativa"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Enabled = False
        Me.CheckBox14.Location = New System.Drawing.Point(43, 531)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox14.TabIndex = 48
        Me.CheckBox14.Text = "Compromisos"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Documentos Archivados"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(43, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Descargar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Enabled = False
        Me.CheckBox17.Location = New System.Drawing.Point(43, 575)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox17.TabIndex = 53
        Me.CheckBox17.Text = "Vacaciones"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscar.Image = Global.ABASSecurity.My.Resources.Resources.icons8_Search_32px_1
        Me.cmdBuscar.Location = New System.Drawing.Point(148, 41)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(21, 20)
        Me.cmdBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmdBuscar.TabIndex = 29
        Me.cmdBuscar.TabStop = False
        '
        'cmbder
        '
        Me.cmbder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbder.Image = Global.ABASSecurity.My.Resources.Resources.icons8_rigth_64
        Me.cmbder.Location = New System.Drawing.Point(589, 12)
        Me.cmbder.Name = "cmbder"
        Me.cmbder.Size = New System.Drawing.Size(32, 28)
        Me.cmbder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbder.TabIndex = 13
        Me.cmbder.TabStop = False
        '
        'cmbizq
        '
        Me.cmbizq.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbizq.Image = Global.ABASSecurity.My.Resources.Resources.icons8_left_64
        Me.cmbizq.Location = New System.Drawing.Point(526, 12)
        Me.cmbizq.Name = "cmbizq"
        Me.cmbizq.Size = New System.Drawing.Size(32, 28)
        Me.cmbizq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmbizq.TabIndex = 11
        Me.cmbizq.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(206, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(737, 631)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormRRHHDocumentos_BCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(965, 684)
        Me.Controls.Add(Me.CheckBox17)
        Me.Controls.Add(Me.panelEmpleados)
        Me.Controls.Add(Me.CheckBox16)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.CheckBox13)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmbder)
        Me.Controls.Add(Me.cmbizq)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.cmdSeleccionarImagen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRRHHDocumentos_BCK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Galeria"
        Me.panelEmpleados.ResumeLayout(False)
        Me.panelEmpleados.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbizq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSeleccionarImagen As Button
    Friend WithEvents cmdRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbizq As PictureBox
    Friend WithEvents cmbder As PictureBox
    Friend WithEvents cmdBuscar As PictureBox
    Friend WithEvents panelEmpleados As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents tipodebusqueda As ComboBox
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents identidad As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox17 As CheckBox
End Class
