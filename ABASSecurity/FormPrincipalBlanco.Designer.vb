<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipalBlanco
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
        Me.components = New System.ComponentModel.Container()
        Me.TimerFecha = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FechaPresentacion = New System.Windows.Forms.Label()
        Me.HoraPresentacion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerFecha
        '
        Me.TimerFecha.Enabled = True
        Me.TimerFecha.Interval = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.FechaPresentacion)
        Me.Panel1.Controls.Add(Me.HoraPresentacion)
        Me.Panel1.Location = New System.Drawing.Point(692, 519)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 173)
        Me.Panel1.TabIndex = 10
        '
        'FechaPresentacion
        '
        Me.FechaPresentacion.AutoSize = True
        Me.FechaPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaPresentacion.ForeColor = System.Drawing.Color.DimGray
        Me.FechaPresentacion.Location = New System.Drawing.Point(22, 85)
        Me.FechaPresentacion.Name = "FechaPresentacion"
        Me.FechaPresentacion.Size = New System.Drawing.Size(90, 31)
        Me.FechaPresentacion.TabIndex = 1
        Me.FechaPresentacion.Text = "Fecha"
        '
        'HoraPresentacion
        '
        Me.HoraPresentacion.AutoSize = True
        Me.HoraPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraPresentacion.ForeColor = System.Drawing.Color.SteelBlue
        Me.HoraPresentacion.Location = New System.Drawing.Point(20, 28)
        Me.HoraPresentacion.Name = "HoraPresentacion"
        Me.HoraPresentacion.Size = New System.Drawing.Size(107, 46)
        Me.HoraPresentacion.TabIndex = 0
        Me.HoraPresentacion.Text = "Hora"
        '
        'FormSplashBlanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 692)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSplashBlanco"
        Me.Text = "FormBlanco"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerFecha As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FechaPresentacion As Label
    Friend WithEvents HoraPresentacion As Label
End Class
