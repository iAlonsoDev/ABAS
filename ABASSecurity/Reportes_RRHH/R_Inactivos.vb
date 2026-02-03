Public Class R_Inactivos
    Private Sub R_Inactivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Date1_ValueChanged(sender As Object, e As EventArgs) Handles date1.ValueChanged
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.EInactivo' Puede moverla o quitarla según sea necesario.
        Me.EInactivoTableAdapter.Fill(Me.RRHHDataSet.EInactivo, date1.Value, date2.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Date2_ValueChanged(sender As Object, e As EventArgs) Handles date2.ValueChanged
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.EInactivo' Puede moverla o quitarla según sea necesario.
        Me.EInactivoTableAdapter.Fill(Me.RRHHDataSet.EInactivo, date1.Value, date2.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class