Imports System.Data.SqlClient

Public Class R_MovimientosMateriales
    Private Sub R_MoviminetosMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarAlmacenes()
        ComboBox1.Text = "TODOS"

    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Inventario_MovimientosMateriales' Puede moverla o quitarla según sea necesario.
        Me.Inventario_MovimientosMaterialesTableAdapter.Fill(Me.InventarioDataSet.Inventario_MovimientosMateriales, ComboBox1.Text, DateTimePicker1.Text, DateTimePicker2.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub LlenarAlmacenes()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "Nombre"
    End Sub

End Class