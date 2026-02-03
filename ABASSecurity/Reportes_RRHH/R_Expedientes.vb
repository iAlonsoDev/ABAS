Public Class R_Expedientes
    Private Sub ReporteExpedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "Incompleto"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.SP_Expedientes' Puede moverla o quitarla según sea necesario.
        Me.SP_ExpedientesTableAdapter.Fill(Me.RRHHDataSet.SP_Expedientes, ComboBox1.SelectedItem)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class