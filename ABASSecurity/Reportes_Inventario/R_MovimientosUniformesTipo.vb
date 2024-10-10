Public Class R_MovimientosUniformesTipo
    Private Sub R_MovimientosUniformesTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_TipoUniforme.SelectedItem = "Pantalon"


    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: This line of code loads data into the 'InventarioDataSet.Inventario_MovimientoUniforme_Tipo' table. You can move, or remove it, as needed.
        Me.Inventario_MovimientoUniforme_TipoTableAdapter.Fill(Me.InventarioDataSet.Inventario_MovimientoUniforme_Tipo, Cmb_TipoUniforme.SelectedItem)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class