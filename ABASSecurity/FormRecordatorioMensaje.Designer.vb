<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecordatorioMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecordatorioMensaje))
        Me.lbNota = New System.Windows.Forms.Label()
        Me.TimerSonido = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Icononotificacion = New System.Windows.Forms.PictureBox()
        CType(Me.Icononotificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbNota
        '
        Me.lbNota.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbNota.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNota.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbNota.Location = New System.Drawing.Point(12, 12)
        Me.lbNota.Name = "lbNota"
        Me.lbNota.Size = New System.Drawing.Size(436, 224)
        Me.lbNota.TabIndex = 3
        Me.lbNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerSonido
        '
        Me.TimerSonido.Interval = 5000
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "*Es recomendable ir eliminando los recordatorios pasados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Icononotificacion
        '
        Me.Icononotificacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Icononotificacion.Image = CType(resources.GetObject("Icononotificacion.Image"), System.Drawing.Image)
        Me.Icononotificacion.Location = New System.Drawing.Point(417, 12)
        Me.Icononotificacion.Name = "Icononotificacion"
        Me.Icononotificacion.Size = New System.Drawing.Size(31, 27)
        Me.Icononotificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Icononotificacion.TabIndex = 6
        Me.Icononotificacion.TabStop = False
        '
        'FormRecordatorioMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(460, 267)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Icononotificacion)
        Me.Controls.Add(Me.lbNota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormRecordatorioMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Icononotificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbNota As Label
    Friend WithEvents Icononotificacion As PictureBox
    Friend WithEvents TimerSonido As Timer
    Friend WithEvents Label1 As Label
End Class
