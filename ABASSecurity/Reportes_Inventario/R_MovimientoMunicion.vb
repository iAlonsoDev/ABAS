Public Class R_MovimientoMunicion
    Private Sub R_MovimientoMunicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: This line of code loads data into the 'InventarioDataSet.Inventario_MovimientoMuncion' table. You can move, or remove it, as needed.
        Me.Inventario_MovimientoMuncionTableAdapter.Fill(Me.InventarioDataSet.Inventario_MovimientoMuncion, DateTimePicker1.Text, DateTimePicker2.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class