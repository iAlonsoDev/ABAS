Imports System.Data.SqlClient

Public Class R_UniformeSucursal
    Private Sub R_UniformeSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarAlmacenes()
        ComboBox1.Text = "TODOS"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Inventario_UniformeSucursales' Puede moverla o quitarla según sea necesario.
        Me.Inventario_UniformeSucursalesTableAdapter.Fill(Me.InventarioDataSet.Inventario_UniformeSucursales, ComboBox1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub LlenarAlmacenes()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "Nombre"
    End Sub
End Class