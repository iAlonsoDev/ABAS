<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecordatorio
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
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtNota
        '
        Me.txtNota.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNota.Location = New System.Drawing.Point(12, 115)
        Me.txtNota.MaxLength = 200
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(329, 254)
        Me.txtNota.TabIndex = 10
        Me.txtNota.Text = "Que deseas Recordar?"
        '
        'txtHora
        '
        Me.txtHora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtHora.Location = New System.Drawing.Point(107, 72)
        Me.txtHora.MaxLength = 8
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(93, 20)
        Me.txtHora.TabIndex = 13
        Me.txtHora.Text = "09.00.00"
        '
        'BtnConsulta
        '
        Me.BtnConsulta.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsulta.FlatAppearance.BorderSize = 0
        Me.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnConsulta.Location = New System.Drawing.Point(110, 375)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(159, 28)
        Me.BtnConsulta.TabIndex = 10
        Me.BtnConsulta.Text = "Ver Recordatorios"
        Me.BtnConsulta.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardar.Location = New System.Drawing.Point(12, 375)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(92, 28)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha a Recordar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "A la hora:"
        '
        'Titulo
        '
        Me.Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Titulo.Location = New System.Drawing.Point(0, 0)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(353, 31)
        Me.Titulo.TabIndex = 1
        Me.Titulo.Text = "Recordatorio"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        '
        'DateTimeFecha
        '
        Me.DateTimeFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimeFecha.CustomFormat = "dd-MM-yyyy"
        Me.DateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeFecha.Location = New System.Drawing.Point(107, 46)
        Me.DateTimeFecha.Name = "DateTimeFecha"
        Me.DateTimeFecha.Size = New System.Drawing.Size(93, 20)
        Me.DateTimeFecha.TabIndex = 19
        '
        'FormRecordatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(353, 418)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.DateTimeFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.BtnConsulta)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.txtNota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRecordatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNota As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents BtnConsulta As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Titulo As Label
    Friend WithEvents TimerHora As Timer
    Friend WithEvents DateTimeFecha As DateTimePicker
End Class
