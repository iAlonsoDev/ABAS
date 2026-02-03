<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRecordatoriosGuardados
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
        Me.RecordatoriosDataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.RecordatoriosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecordatoriosDataGrid
        '
        Me.RecordatoriosDataGrid.AllowUserToAddRows = False
        Me.RecordatoriosDataGrid.AllowUserToDeleteRows = False
        Me.RecordatoriosDataGrid.AllowUserToOrderColumns = True
        Me.RecordatoriosDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecordatoriosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RecordatoriosDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.RecordatoriosDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.RecordatoriosDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecordatoriosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordatoriosDataGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RecordatoriosDataGrid.Location = New System.Drawing.Point(12, 12)
        Me.RecordatoriosDataGrid.Name = "RecordatoriosDataGrid"
        Me.RecordatoriosDataGrid.ReadOnly = True
        Me.RecordatoriosDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.RecordatoriosDataGrid.Size = New System.Drawing.Size(573, 247)
        Me.RecordatoriosDataGrid.TabIndex = 0
        '
        'FormRecordatoriosGuardados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(597, 271)
        Me.Controls.Add(Me.RecordatoriosDataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRecordatoriosGuardados"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.RecordatoriosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecordatoriosDataGrid As System.Windows.Forms.DataGridView
End Class
