Public Class R_TipoArmas
    Private Sub R_TipoArmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoComboBox.SelectedItem = "TODO"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.TipoArmas' Puede moverla o quitarla según sea necesario.
        Me.TipoArmasTableAdapter.Fill(Me.InventarioDataSet.TipoArmas, TipoComboBox.SelectedItem)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class