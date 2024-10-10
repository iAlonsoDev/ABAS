Public Class R_AsignacionesGenerales

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.AsignacionesGenerales' Puede moverla o quitarla según sea necesario.
        Me.AsignacionesGeneralesTableAdapter.Fill(Me.OperacionesDataSet.AsignacionesGenerales, Fecha1.Value, Fecha2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class