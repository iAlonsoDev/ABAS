Public Class R_Vehiculos
    Private Sub R_Vehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "Automovil"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'TODO: This line of code loads data into the 'InventarioDataSet.Inventario_Vehiculos' table. You can move, or remove it, as needed.
        Me.Inventario_VehiculosTableAdapter.Fill(Me.InventarioDataSet.Inventario_Vehiculos, ComboBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class