Imports System.Data.SqlClient
Public Class R_ClientesSucursales
    Private Sub R_ClientesSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCliente()
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: This line of code loads data into the 'OtrosDataSet.Rpt_ClientesSucursales' table. You can move, or remove it, as needed.
        Me.Rpt_ClientesSucursalesTableAdapter.Fill(Me.OtrosDataSet.Rpt_ClientesSucursales, ClienteComboBox.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub LlenarCliente()

        sql = "Select * from  cliente where estado = 'Activo'"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ClienteComboBox.DataSource = ds.Tables(0)
        ClienteComboBox.DisplayMember = "nombre"
        ClienteComboBox.ValueMember = "nombre"

    End Sub

    Private Sub ClienteComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ClienteComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        sql = "Select * from  cliente where estado = 'Activo' and nombre like '" & TextBox1.Text & "%" & "' order by nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ClienteComboBox.DataSource = ds.Tables(0)
        ClienteComboBox.DisplayMember = "nombre"
        ClienteComboBox.ValueMember = "nombre"
    End Sub

End Class