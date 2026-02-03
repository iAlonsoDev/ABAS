Imports System.Data.SqlClient

Public Class R_ArmasAlmacen
    Private Sub R_ArmasAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarAlmacenes()
        ComboBox1.Text = "SPS"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: This line of code loads data into the 'InventarioDataSet.ArmasAlmacen' table. You can move, or remove it, as needed.
        Me.ArmasAlmacenTableAdapter.Fill(Me.InventarioDataSet.ArmasAlmacen, ComboBox1.Text)

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