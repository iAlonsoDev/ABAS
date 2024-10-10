Public Class R_Clientes
    Private Sub R_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClienteComboBox.SelectedItem = "TODOS"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: This line of code loads data into the 'OtrosDataSet.Rpt_Clientes' table. You can move, or remove it, as needed.
        Me.Rpt_ClientesTableAdapter.Fill(Me.OtrosDataSet.Rpt_Clientes, ClienteComboBox.SelectedItem)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class