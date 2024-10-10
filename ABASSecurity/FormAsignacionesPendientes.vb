Imports System.Data.SqlClient

Public Class FormAsignacionesPendientes

    Private Sub CmdVover_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Sub Llenar()
        cn.Open()
        sql = "SELECT e.codigo, e.nombres+''+e.apellidos nombrecompleto, e.estado
              FROM Empleados e
              WHERE NOT EXISTS (SELECT *
                   FROM   Asignaciones RRHH
                   WHERE  RRHH.fecha = '" + Fecha.Value + "'  and e.codigo = RRHH.codigo) and e.estado <> 'inactivo'
              order by nombrecompleto asc"

        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        ds.Tables.Add("Tbl")
        da.Fill(ds.Tables("Tbl"))

        DGVNA.DataSource = ds.Tables("Tbl")

        DGVNA.Columns(0).HeaderText = "Codigo"
        DGVNA.Columns(1).HeaderText = "Nombre Completo"
        DGVNA.Columns(2).HeaderText = "Estado Laboral"


        DGVNA.Columns(0).Width = 100
        DGVNA.Columns(1).Width = 300
        DGVNA.Columns(2).Width = 100
        cn.Close()
    End Sub

    Private Sub Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Fecha.ValueChanged
        Llenar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Llenar()
    End Sub
End Class