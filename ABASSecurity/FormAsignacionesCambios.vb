
Imports System.Data.SqlClient

Public Class FormAsignacionesCambios

    Private Sub FormCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCliente()
        LlenarSucursal()
        Day.Text = Day.Value.AddDays(2)
        Day2.Text = Day2.Value.AddDays(2)

        panelCambioAsignacion.Visible = False

        ComboCliente.SelectedItem = "Seleccionar"
        ObservacionTextBox.Select()
        CargarAsignaciones()
        txtbusqueda.Focus()
    End Sub

    Sub LlenarCliente()

        sql = "Select * from  cliente where estado = 'Activo'"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ClienteComboBox.DataSource = ds.Tables(0)
        ClienteComboBox.DisplayMember = "nombre"
        ClienteComboBox.ValueMember = "nombre"

    End Sub

    Sub LlenarSucursal()
        sql = "select sucursal from sucursales, cliente where Cliente.nombre = Sucursales.nombre and Cliente.nombre = '" + ClienteComboBox.Text + "' and Cliente.estado = 'Activo'"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        SucursalComboBox.DataSource = ds.Tables(0)
        SucursalComboBox.DisplayMember = "sucursal"

    End Sub

    Sub RangodeAsignacion()

        If Now > DateTimePicker1.Value.AddDays(6) Then

            If MsgBox("Para poder modificar una asignacion de 5 dias antes se debe autorizar", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                Validar()
            Else
                DateTimePicker1.Value = Now
            End If
        ElseIf DateTimePicker1.Value >= Day.Value Then

            If MsgBox("Para poder modificar una asignacion 1 dias despues se debe autorizar", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                Validar()
            Else
                DateTimePicker1.Value = Now
            End If
        End If
        CargarAsignaciones()
    End Sub

    Sub RangodeAsignacion2()

        If Now > DateTimePicker2.Value.AddDays(6) Then

            If MsgBox("Para poder modificar una asignacion de 5 dias antes se debe autorizar", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                Validar()
            Else
                DateTimePicker2.Value = Now
            End If

        ElseIf DateTimePicker2.Value >= Day.Value Then

            If MsgBox("Para poder modificar una asignacion 1 dias despues se debe autorizar", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                Validar()
            Else
                DateTimePicker2.Value = Now
            End If

        End If

        CargarAsignaciones()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CargarAsignaciones()
    End Sub


    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        CargarAsignaciones()
    End Sub

    Sub CargarAsignaciones()
        Try
            sql = "select * from Asignaciones where fecha >= '" + DateTimePicker1.Text + "' and fecha <= ' " + DateTimePicker2.Text + "' ORDER BY FECHA DESC"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            AsignacionesDataGridView.DataSource = dt
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub ClienteComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClienteComboBox.SelectedIndexChanged
        LlenarSucursal()
    End Sub

    Private Sub AsignacionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AsignacionesDataGridView.CellContentClick
        panelCambioAsignacion.Visible = True
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = AsignacionesDataGridView.Rows(index)

            CodigoTextBox.Text = selectedRow.Cells(1).Value.ToString
            ClienteComboBox.Text = selectedRow.Cells(2).Value.ToString
            TurnoComboBox.SelectedItem = selectedRow.Cells(3).Value.ToString
            FechaDateTimePicker.Value = selectedRow.Cells(4).Value.ToString
            HorasTextBox.Text = selectedRow.Cells(5).Value.ToString
            HorasextrasTextBox.Text = selectedRow.Cells(6).Value.ToString
            ObservacionTextBox.Text = selectedRow.Cells(7).Value.ToString
            SucursalComboBox.Text = selectedRow.Cells(9).Value.ToString
            TextBox1.Text = selectedRow.Cells(10).Value.ToString
            TextBox2.Text = selectedRow.Cells(11).Value.ToString
            IdasignacionTextBox.Text = selectedRow.Cells(0).Value.ToString

            ObservacionTextBox.Select()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CmdOcultar_Click(sender As Object, e As EventArgs) Handles cmdOcultar.Click
        panelCambioAsignacion.Visible = False
        IdasignacionTextBox.Clear()
        CodigoTextBox.Clear()
        HorasTextBox.Clear()
        ObservacionTextBox.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If MsgBox("¡Desea actualizar la asignacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            If ObservacionTextBox.Text = "" Then
                MessageBox.Show("Debe especificar obligatoriamente, porque realiza este cambio")
                ObservacionTextBox.Clear()
                ObservacionTextBox.Select()
            Else
                If Rango5 = "Jefe Operaciones" Then
                    sql = "update Asignaciones set 
                                codigo ='" + CodigoTextBox.Text + "', 
                                cliente ='" + ClienteComboBox.Text + "', 
                                turno ='" + TurnoComboBox.Text + "',
                                fecha ='" + FechaDateTimePicker.Text + "', 
                                horas ='" + HorasTextBox.Text + "',
                                horasextras ='" + HorasextrasTextBox.Text + "',
                                observacion ='" + ObservacionTextBox.Text + "',
                                autoriza ='" + Usuario + "',
                                sucursal ='" + SucursalComboBox.Text + "',
                                nombre = '" + TextBox1.Text + "',
                                apellido = '" + TextBox2.Text + "' where idasignacion = '" + IdasignacionTextBox.Text + "'"
                    Ejecutar(sql)
                    panelCambioAsignacion.Visible = False
                Else
                    MsgBox("¡No cuenta con los permisos necesarios para realizar esta operacion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                End If
            End If

            panelCambioAsignacion.Visible = False
            'Esto hara que carge las asignaciones del dia actual, por si requiere hacer algun cambio en la asignacion
            CargarAsignaciones()

            MsgBox("¡Se actualizo la asignacion exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")

        End If
    End Sub


    Private Sub ObservacionTextBox_Click(sender As Object, e As EventArgs) Handles ObservacionTextBox.Click
        ObservacionTextBox.Clear()
    End Sub


    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MsgBox("¡Desea eliminar la asignacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If IdasignacionTextBox.Text = "" Then
                MessageBox.Show("No selecciono una Asignacion RRHH eliminar")
            Else
                If Rango5 = "Jefe Operaciones" Then
                    sql = "delete from Asignaciones where idasignacion = '" + IdasignacionTextBox.Text + "'"
                    Ejecutar(sql)
                    panelCambioAsignacion.Visible = False
                Else
                    MsgBox("¡No cuenta con los permisos necesarios para realizar esta operacion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                End If
            End If
            'Esto hara que carge las asignaciones del dia actual, por si requiere hacer algun cambio en la asignacion
            CargarAsignaciones()
            MsgBox("¡Asignacion eliminada exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If


    End Sub



    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If ComboCliente.SelectedItem = "Codigo de Empleado" Then
            sql = "select * from Asignaciones where fecha >= '" + DateTimePicker1.Text + "' and fecha <= ' " + DateTimePicker2.Text + "' And Codigo like '" & txtbusqueda.Text + "%" & "'"
            Try
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
        Else
            If ComboCliente.SelectedItem = "Cliente" Then
                sql = "select * from Asignaciones where fecha >= '" + DateTimePicker1.Text + "' and fecha <= ' " + DateTimePicker2.Text + "' And Cliente like '" & txtbusqueda.Text + "%" & "'"
                Try
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
        End If
    End Sub

    Private Sub ClienteComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TurnoComboBox.KeyPress, SucursalComboBox.KeyPress, ComboCliente.KeyPress, ClienteComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCliente.SelectedIndexChanged
        If ComboCliente.Text = "Seleccionar" Then
            txtbusqueda.ReadOnly = True
        Else
            txtbusqueda.ReadOnly = False
        End If
    End Sub



    Private Sub DateTimePicker1_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.TextChanged
        RangodeAsignacion()
    End Sub

    Private Sub DateTimePicker2_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.TextChanged
        RangodeAsignacion2()
    End Sub


    Sub Validar()
        If Now > DateTimePicker1.Value.AddDays(6) Then
            If Rango5 = "Jefe Operaciones" Then
            Else
                MessageBox.Show("No cuenta con los permisos necesarios, Necesita ser Jefe de Operaciones", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DateTimePicker1.Value = Now
            End If

        ElseIf DateTimePicker1.Value >= Day.Value Then

            If Rango5 = "Jefe Operaciones" Then
            Else
                MessageBox.Show("No cuenta con los permisos necesarios, Necesita ser Jefe de Operaciones", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DateTimePicker1.Value = Now
            End If
        End If

        If Now > DateTimePicker2.Value.AddDays(6) Then

            If Rango5 = "Jefe Operaciones" Then
            Else
                MessageBox.Show("No cuenta con los permisos necesarios, Necesita ser Jefe de Operaciones", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DateTimePicker2.Value = Now
            End If

        ElseIf DateTimePicker2.Value >= Day.Value Then

            If Rango5 = "Jefe Operaciones" Then
            Else
                MessageBox.Show("No cuenta con los permisos necesarios, Necesita ser Jefe de Operaciones", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DateTimePicker2.Value = Now
            End If

        End If


    End Sub


End Class