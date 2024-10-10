Imports System.Data.SqlClient

Public Class FormAsignacionesFaltas

    ReadOnly obj As New ClaseBusquedasDinamicas



    Private Sub FormFaltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelEmpleados.Visible = False

        obj.Llamadgv(EmpleadosDataGridView)
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
    End Sub


    Private Sub ObservacionTextBox_Click(sender As Object, e As EventArgs) Handles ObservacionTextBox.Click
        ObservacionTextBox.Clear()
    End Sub


    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbusqueda.Focus()
        End If
    End Sub


    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & txtbusqueda.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                EmpleadosDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If

        If tipodebusqueda.SelectedItem.ToString = "Nombre" Then
            obj.BusquedaNombre(txtbusqueda.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Identidad" Then
            'para condicionar un textbox
            If txtbusqueda.Text.Length <= 10 Then
                If txtbusqueda.Text.Length >= 5 Then
                    Dim s As String = txtbusqueda.Text.Replace("-", "")
                    For x As Integer = 4 To s.Length Step 4
                        s = s.Insert(x + ((x \ 4) - 1), "-")
                    Next
                    s = s.TrimEnd("-"c)
                    txtbusqueda.Text = s
                    txtbusqueda.SelectionStart = s.Length
                End If
            End If
            obj.BusquedaIdentidad(txtbusqueda.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Ubicacion" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and ubicacion like '" & txtbusqueda.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                EmpleadosDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If

        If tipodebusqueda.SelectedItem.ToString = "Planilla" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and planilla like '" & txtbusqueda.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                EmpleadosDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If

        If txtbusqueda.Text = "" Then
            Limpiar()
        End If
    End Sub


    Sub Limpiar()
        CodigoTextBox.Clear()
        ApellidosTextBox.Clear()
        NombresTextBox.Clear()
        ObservacionTextBox.Text = "Detalles de la Falta"
    End Sub


    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If CodigoTextBox.Text = "" Then
            MessageBox.Show("Seleccione el codigo de empleado")
        Else
            If ObservacionTextBox.Text = "Detalles de la Falta" Then
                MessageBox.Show("Especifique la falta cometida")
                ObservacionTextBox.Clear()
                ObservacionTextBox.Select()
            Else
                If ObservacionTextBox.Text = "" Then
                    MessageBox.Show("Para este caso la observacion es obligatoria")
                    ObservacionTextBox.Select()
                Else
                    Validar()
                End If
            End If
        End If
    End Sub




    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)
            NombresTextBox.Text = selectedRow.Cells(1).Value.ToString
            ApellidosTextBox.Text = selectedRow.Cells(2).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(0).Value.ToString

        Catch ex As Exception

        End Try

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "Select * From Asignaciones Where Codigo ='" + CodigoTextBox.Text + "' and Fecha='" + FechadefaltaDateTimePicker.Text + "'"
        cmd.CommandText = sql
        'Ejecutamos una lectura RRHH la tabla
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MessageBox.Show("La observacion registrada, se mostrara tambien en la asignacion del empleado para este dia.")
        Else
            MessageBox.Show("No se encontro una asignacion para este empleado este dia")
            Limpiar()
            Limpiar2()
        End If
        panelEmpleados.Visible = False
        ObservacionTextBox.Select()

        dr.Close()
        cn.Close()
    End Sub


    Private Sub CmdVerFaltas_Click(sender As Object, e As EventArgs) Handles cmdVerFaltas.Click
        FormAsignacionesFaltasGuardadas.ShowDialog()
    End Sub

    Private Sub Tipodebusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipodebusqueda.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
        Limpiar2()
    End Sub

    Sub Validar()

        If CodigoTextBox.Text = "" Then
            MessageBox.Show("Seleccione un Codigo de empleado")
        Else
            If Rango5 = "Jefe Operaciones" Then
                sql = "insert into Faltas values('" + CodigoTextBox.Text + "','" + FechadefaltaDateTimePicker.Text + "','" + ObservacionTextBox.Text + "','" + Usuario + "')"
                Ejecutar(sql)

                Try
                    cn.Open()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.Text
                    sql = "Select * From Asignaciones Where Codigo ='" + CodigoTextBox.Text + "' and Fecha='" + FechadefaltaDateTimePicker.Text + "'"
                    cmd.CommandText = sql

                    'Ejecutamos una lectura RRHH la tabla
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        sql = "update Asignaciones set observacion = '" + ObservacionTextBox.Text + "'  Where Codigo ='" + CodigoTextBox.Text + "' and Fecha='" + FechadefaltaDateTimePicker.Text + "'"
                        Ejecutar(sql)
                        Limpiar2()
                    End If
                Catch ex As Exception
                End Try

                MsgBox("¡Falta añadida exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                MsgBox("¡No cuenta con los permisos para realizar esta operacion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If
            dr.Close()
            cn.Close()
        End If
    End Sub

    Sub Limpiar2()
        CodigoTextBox.Clear()
        CodigoTextBox.Select()
        ObservacionTextBox.Text = "Detalles de la Falta"
        ApellidosTextBox.Clear()
        NombresTextBox.Clear()
    End Sub


End Class