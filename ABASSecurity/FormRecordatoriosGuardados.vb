Imports System.Data.SqlClient

Public Class FormRecordatoriosGuardados

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub FrmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ds = New DataSet
        sql = "Select * From Recordatorio order by fecha asc"
        da = New SqlDataAdapter(sql, cn)
        ds.Tables.Add("Tbl")
        da.Fill(ds.Tables("Tbl"))

        RecordatoriosDataGrid.DataSource = ds.Tables("Tbl")

        RecordatoriosDataGrid.Columns(0).HeaderText = "ID"
        RecordatoriosDataGrid.Columns(1).HeaderText = "Fecha"
        RecordatoriosDataGrid.Columns(2).HeaderText = "Hora"
        RecordatoriosDataGrid.Columns(3).HeaderText = "Evento"

        RecordatoriosDataGrid.Columns(0).Visible = False
        RecordatoriosDataGrid.Columns(1).Width = 100
        RecordatoriosDataGrid.Columns(2).Width = 100
        RecordatoriosDataGrid.Columns(3).Width = 500

    End Sub
End Class