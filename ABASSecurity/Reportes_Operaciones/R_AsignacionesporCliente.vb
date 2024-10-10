
Imports System.Data.SqlClient
Public Class R_AsignacionesporCliente

    Private Sub R_AsignacionesporCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCliente()
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.AsiganacionesporCliente' Puede moverla o quitarla según sea necesario.
        Me.AsiganacionesporClienteTableAdapter.Fill(Me.OperacionesDataSet.AsiganacionesporCliente, ClienteComboBox.Text, Fecha1.Value, Fecha2.Value)

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