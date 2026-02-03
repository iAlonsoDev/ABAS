Imports System.Data.SqlClient

Public Class R_Municion
    Private Sub R_Municion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarAlmacenes()
        ComboBox1.Text = "TODOS"
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


    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: This line of code loads data into the 'InventarioDataSet.Inventario_Municion' table. You can move, or remove it, as needed.
        Me.Inventario_MunicionTableAdapter.Fill(Me.InventarioDataSet.Inventario_Municion, ComboBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class