Public Class R_EstadoEmpleado

    Private Sub Tipodebusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipodebusqueda.SelectedIndexChanged
        If tipodebusqueda.Text <> "Seleccione el estado" Then
            'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.estadoempleado' Puede moverla o quitarla según sea necesario.
            Me.estadoempleadoTableAdapter.Fill(Me.RRHHDataSet.estadoempleado, tipodebusqueda.Text, Fecha1.Value, Fecha2.Value, UbicacionComboBox.Text)

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Fecha1_ValueChanged(sender As Object, e As EventArgs) Handles Fecha1.ValueChanged
        If tipodebusqueda.Text <> "Seleccione el estado" Then
            'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.estadoempleado' Puede moverla o quitarla según sea necesario.
            Me.estadoempleadoTableAdapter.Fill(Me.RRHHDataSet.estadoempleado, tipodebusqueda.Text, Fecha1.Value, Fecha2.Value, UbicacionComboBox.Text)

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Fecha2_ValueChanged(sender As Object, e As EventArgs) Handles Fecha2.ValueChanged
        If tipodebusqueda.Text <> "Seleccione el estado" Then
            'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.estadoempleado' Puede moverla o quitarla según sea necesario.
            Me.estadoempleadoTableAdapter.Fill(Me.RRHHDataSet.estadoempleado, tipodebusqueda.Text, Fecha1.Value, Fecha2.Value, UbicacionComboBox.Text)

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub R_EstadoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class