Imports System.Data.SqlClient

Public Class FormAsignacionesFaltasGuardadas
    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub FaltasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FaltasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ABASDataSet)

    End Sub

    Private Sub MostrarFaltasGuardadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.llenardgvfaltas(txtbusqueda.Text, FaltasDataGridView)


        sql = "select * from Faltas where fechadefalta >= '" & Format(DateTimePicker1.Value.Date.ToString, "short date") &
       " ' and fechadefalta <= ' " & Format(DateTimePicker2.Value.Date.ToString, "short date") & "' "
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            FaltasDataGridView.DataSource = dt
        Finally
            cn.Close()
        End Try
        txtbusqueda.Focus()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        sql = "select * from Faltas where fechadefalta >= '" & Format(DateTimePicker1.Value.Date.ToString, "short date") &
       " ' and fechadefalta <= ' " & Format(DateTimePicker2.Value.Date.ToString, "short date") & "' "
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            FaltasDataGridView.DataSource = dt
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        sql = "select * from Faltas where fechadefalta >= '" & Format(DateTimePicker1.Value.Date.ToString, "short date") &
      " ' and fechadefalta <= ' " & Format(DateTimePicker2.Value.Date.ToString, "short date") & "' "
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            FaltasDataGridView.DataSource = dt
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text <> "" Then
            sql = "SELECT [codigo]
                      ,[fechadefalta]
                      ,[observacion]
                      ,[autoriza]
                  FROM [ABAS].[dbo].[Faltas] where codigo like '" & txtbusqueda.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                FaltasDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If
    End Sub
End Class