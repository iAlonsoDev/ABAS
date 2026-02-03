Public Class R_Armas
    Private Sub R_ArmasNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "TODOS"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Armas' Puede moverla o quitarla según sea necesario.
        Me.ArmasTableAdapter.Fill(Me.InventarioDataSet.Armas, ComboBox1.Text)
        Me.CantArmasTableAdapter.Fill(Me.InventarioDataSet.CantArmas)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class