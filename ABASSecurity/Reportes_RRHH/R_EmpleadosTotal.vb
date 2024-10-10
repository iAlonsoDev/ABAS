Public Class R_EmpleadosTotal
    Private Sub R_EmpleadosTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RRHH.EmpleadosTodos' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTodosTableAdapter.Fill(Me.RRHH.EmpleadosTodos, DateTimePicker1.Value, DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'TODO: esta línea de código carga datos en la tabla 'RRHH.EmpleadosTodos' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTodosTableAdapter.Fill(Me.RRHH.EmpleadosTodos, DateTimePicker1.Value, DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        'TODO: esta línea de código carga datos en la tabla 'RRHH.EmpleadosTodos' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTodosTableAdapter.Fill(Me.RRHH.EmpleadosTodos, DateTimePicker1.Value, DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class