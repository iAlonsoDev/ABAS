Imports System.Data.SqlClient

Public Class R_TiposDocumentosEmpleados


    Private Sub R_TiposDocumentosEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarTiposDocuemntos()


    End Sub

    Sub LlenarTiposDocuemntos()
        sql = "SELECT TOP (1000) [idtipodoc]
                  ,[nombretipo]
              FROM [ABAS].[dbo].[TipoDocumentosEmpleados]
              ORDER BY nombretipo ASC"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "nombretipo"

    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: This line of code loads data into the 'RRHHDataSet.RRHH_TipoDocumentosEmpleados' table. You can move, or remove it, as needed.
        Me.RRHH_TipoDocumentosEmpleadosTableAdapter.Fill(Me.RRHHDataSet.RRHH_TipoDocumentosEmpleados, ComboBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'TODO: This line of code loads data into the 'RRHHDataSet.RRHH_TipoDocumentosEmpleados' table. You can move, or remove it, as needed.
        Me.RRHH_TipoDocumentosEmpleadosTableAdapter.Fill(Me.RRHHDataSet.RRHH_TipoDocumentosEmpleados, ComboBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class