
Imports System.Data.SqlClient

Public Class FormOtros

    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub FormDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Para feriados
        obj.Feriado(DiasDataGridView)

        'Para Faltas
        obj.llenardgvfaltas(txtbuscarfalta.Text, FaltasDataGridView)

        'Para recordatorios
        Me.RecordatorioTableAdapter.Fill(Me.ABASDataSet.Recordatorio)

        LlenarFaltas()
        Buscarfalta()
        Registros()

        ObservacionTextBox.Text = "Ninguna"
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        EstadoComboBox.SelectedItem = "Pendiente"
        CantidadTextBox.Text = 0
        FechadeingresoDateTimePicker.Enabled = False

        If ClasePrivilegios.Rango1 = "Gerencia" Then
        Else
            If ClasePrivilegios.Rango2 = "Administracion" Then
                FaltasDataGridView.Visible = False
                FaltasEmpleado.Enabled = False
                RecordatorioDataGridView.Visible = True
                Recordatorios.Enabled = True
                RegistroLoginDataGridView.Visible = False
                IniciosdeSesion.Enabled = False
                DiasLibres.Enabled = False
                AsignacionesDataGridView.Visible = False
            End If
        End If

        txtbuscarfalta.Focus()
    End Sub


    Sub Registros()
        If TextBox1.Text = "" Then
            Try
                sql = "SELECT TOP (100) [usuario],[fecha] FROM [ABAS].[dbo].[RegistroLogin] WHERE [usuario] like '" & TextBox1.Text + "%" & "'"
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                RegistroLoginDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Sub LlenarFaltas()
        sql = "SELECT TOP (1000) [idfalta]
      ,[codigo]
      ,[fechadefalta]
      ,[observacion]
      ,[autoriza]
  FROM [ABAS].[dbo].[Faltas]"
        cn.Open()
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        FaltasDataGridView.DataSource = dt
        cn.Close()
    End Sub


    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs)
        LlenarFaltas()
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs)
        LlenarFaltas()
    End Sub


    Sub Buscarfalta()
        If txtbuscarfalta.Text = "" Then
            sql = "select top (50) Faltas.codigo, fechadefalta, Faltas.observacion, autoriza from Faltas, Empleados where Faltas.codigo = Empleados.codigo and Empleados.estado <> 'Inactivo'"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            RegistroLoginDataGridView.DataSource = dt
            cn.Close()
        End If
    End Sub


    Private Sub Txtbuscarfalta_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarfalta.TextChanged
        If txtbuscarfalta.Text <> "" Then
            sql = "SELECT [codigo]
                      ,[fechadefalta]
                      ,[observacion]
                      ,[autoriza]
                  FROM [ABAS].[dbo].[Faltas] where codigo like '" & txtbuscarfalta.Text + "%" & "'"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            FaltasDataGridView.DataSource = dt
            cn.Close()
        Else
            Buscarfalta()
        End If
    End Sub




    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If lbIdRecordatorio.Text = "" Then
            MsgBox("no seleccionaste ningun registro", MsgBoxStyle.Critical, "Aviso")
        End If
        If MsgBox("Quieres eliminar la nota de las : " + RecordatorioDataGridView.CurrentRow.Cells(3).Value.ToString + " ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then

            cn.Open()
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            sql = "Delete From Recordatorio where idrecordatorio= " + lbIdRecordatorio.Text + ""
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MsgBox("¡Nota eliminada con exito!", MsgBoxStyle.Information, "Eliminar")
            Me.RecordatorioTableAdapter.Fill(Me.ABASDataSet.Recordatorio)
        Else
        End If
        cn.Close()
        lbIdRecordatorio.Clear()

    End Sub

    Private Sub RecordatorioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RecordatorioDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = RecordatorioDataGridView.Rows(index)
            lbIdRecordatorio.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        FormRecordatorio.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Para recordatorios
        Me.RecordatorioTableAdapter.Fill(Me.ABASDataSet.Recordatorio)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            sql = "select usuario, fecha from registrologin where usuario like '" & TextBox1.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                RegistroLoginDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If

        If TextBox1.Text = "" Then
            sql = "select top (100) usuario, fecha from RegistroLogin where usuario like '" & TextBox1.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                RegistroLoginDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If
    End Sub


    Private Sub EstadoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstadoComboBox.KeyPress
        e.Handled = True
    End Sub

    Sub Diaslibre()
        If CodigoTextBox.Text <> "" Then
            Try
                sql = "select Top (100) * from asignaciones where dialibre = 'Si' order by fecha desc"
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                AsignacionesDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If
    End Sub

End Class