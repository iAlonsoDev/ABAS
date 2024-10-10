Imports System.Data.SqlClient

Public Class FormAsignaciones

    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub FormAsignaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAsignaciones()
    End Sub

    Sub LoadAsignaciones()
        'Privilegio
        HorasAsignadas.Text = "00:00:00"
        LlenarCliente()
        LlenarSucursal()
        Llenarhoras()
        Llenarcomparativo()
        LlenarhorasAsignadas()
        Llenarempleadosasignados()
        'Horasporasignar()

        panelEmpleados.Visible = False

        If txtbusqueda.Text = "" Then
        Else
            obj.Llamadgv(EmpleadosDataGridView)
        End If

        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        extras.Text = "00:00:00"
        ObservacionTextBox.Text = "Ninguna"
        ' Para asignar comodines
        If ClasePrivilegios.Rango5 = "Jefe Operaciones" Then
            CheckBox3.Enabled = True
        Else
            CheckBox3.Enabled = False
        End If
    End Sub


    Sub RangodeAsignacion()
        'valida que no se asigne un dia adelante
        Dim fe As Date
        fe = FechaDateTime.Value

        If Now = FechaDateTime.Value Then
        Else
            'valida que no se asigne 6 dias antes si no es autorizado
            If Now >= FechaDateTime.Value.AddDays(6) Then

                If MsgBox("Para poder asignar un empleado antes de 5 dias se debe autorizar", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then

                    If ClasePrivilegios.Rango5 = "Jefe Operaciones" Then

                    Else
                        MessageBox.Show("Solo el Jefe de Operaciones Puede Asignar empleados en este Rango de Fecha")
                        CodigoTextBox.Clear()
                        FechaDateTime.Value = Now
                    End If
                Else
                    FechaDateTime.Value = Now
                End If

            Else
                'valida que no se asigne un dia adelante
                If Now < fe Then
                    MessageBox.Show("Solo puede asignar empleados el dia de ahora o 5 dias anteriores")
                    CodigoTextBox.Clear()
                    FechaDateTime.Value = Now
                End If
            End If
        End If
    End Sub

    Sub LlenarCliente()
        sql = "Select * from  cliente where estado = 'Activo' order by nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.DisplayMember = "nombre"
        ListBox1.ValueMember = "nombre"

    End Sub


    Sub LlenarSucursal()
        sql = "SELECT TOP (100) PERCENT dbo.Sucursales.sucursal, dbo.Cliente.estado
                    FROM            dbo.Sucursales INNER JOIN
                         dbo.Cliente ON dbo.Sucursales.nombre = dbo.Cliente.nombre
                    WHERE        (dbo.Sucursales.estado = 'Activo') AND (dbo.Cliente.nombre = '" + ListBox1.SelectedValue + "') AND (dbo.Cliente.estado = 'Activo') AND (dbo.Sucursales.sucursal like '" & TextBox2.Text + "%" & "')
                    ORDER BY dbo.Sucursales.nombre"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox2.DataSource = ds.Tables(0)
        ListBox2.DisplayMember = "sucursal"
        ListBox2.ValueMember = "sucursal"
    End Sub

    Sub Llenarhoras()
        cmd = New SqlCommand("select s.horas, s.extras, s.empleados, s.basehoras from sucursales s
        inner join cliente c
        on c.nombre = s.nombre
        where c.nombre = '" + ListBox1.SelectedValue + "' and S.sucursal = '" + ListBox2.SelectedValue + "'", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            HorasTextBox.Text = dr.Item("horas").ToString
            extras.Text = dr.Item("extras").ToString
            Oficiales.Text = dr.Item("empleados").ToString
            HorasBase.Text = dr.Item("basehoras").ToString

            Dim bh As Integer = Val(dr.Item("horas").ToString)
            HorasComparacion.Text = (bh * Val(Oficiales.Text)) * 60

            Dim be As TimeSpan = TimeSpan.Parse(dr.Item("extras").ToString)
            HorasExtrasComparacion.Text = CStr(be.TotalMinutes) * Val(Oficiales.Text)
        End If
        dr.Close()
        cn.Close()
        Llenarcomparativo()

    End Sub

    Sub Llenarcomparativo()
        cmd = New SqlCommand("select (DATEPART(hour, a.horasextras) * 60) + (CONVERT(Char(2), DATEPART(Minute, a.horasextras))) As horasextrasasignadas
        from Asignaciones as a, sucursales as s
        where a.cliente = '" + ListBox1.SelectedValue + "' and a.sucursal = '" + ListBox2.SelectedValue + "' and a.fecha = '" + FechaDateTime.Text + "'", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            HextrasasignadasConvertidas.Text = dr.Item("horasextrasasignadas").ToString
        Else
            HextrasasignadasConvertidas.Text = 0
        End If
        dr.Close()
        cn.Close()
    End Sub

    Sub Horasporasignar()

        If HorasBase.Text = "8" Then

            If HorasAsignadas.Text >= "8" Then
                HorasTextBox.Enabled = False
                HorasTextBox.Text = "00:00:00"
                If HorasAsignadas.Text = "7" Then
                    HorasTextBox.Enabled = False
                    HorasTextBox.Text = "01:00:00"
                    If HorasAsignadas.Text = "6" Then
                        HorasTextBox.Enabled = False
                        HorasTextBox.Text = "02:00:00"
                        If HorasAsignadas.Text = "5" Then
                            HorasTextBox.Enabled = False
                            HorasTextBox.Text = "03:00:00"
                            If HorasAsignadas.Text = "4" Then
                                HorasTextBox.Enabled = False
                                HorasTextBox.Text = "04:00:00"
                                If HorasAsignadas.Text = "3" Then
                                    HorasTextBox.Enabled = False
                                    HorasTextBox.Text = "05:00:00"
                                    If HorasAsignadas.Text = "2" Then
                                        HorasTextBox.Enabled = False
                                        HorasTextBox.Text = "06:00:00"
                                        If HorasAsignadas.Text = "1" Then
                                            HorasTextBox.Enabled = False
                                            HorasTextBox.Text = "07:00:00"
                                            If HorasAsignadas.Text = "" Then
                                                HorasTextBox.Enabled = False
                                                HorasTextBox.Text = "08:00:00"
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else

            If HorasBase.Text = "12" Then

                If HorasAsignadas.Text >= "12" Then
                    HorasTextBox.Enabled = False
                    HorasTextBox.Text = "00:00:00"
                    If HorasAsignadas.Text = "11" Then
                        HorasTextBox.Enabled = False
                        HorasTextBox.Text = "01:00:00"
                        If HorasAsignadas.Text = "10" Then
                            HorasTextBox.Enabled = False
                            HorasTextBox.Text = "02:00:00"
                            If HorasAsignadas.Text = "9" Then
                                HorasTextBox.Enabled = False
                                HorasTextBox.Text = "03:00:00"
                                If HorasAsignadas.Text = "8" Then
                                    HorasTextBox.Enabled = False
                                    HorasTextBox.Text = "04:00:00"
                                    If HorasAsignadas.Text = "7" Then
                                        HorasTextBox.Enabled = False
                                        HorasTextBox.Text = "05:00:00"
                                        If HorasAsignadas.Text = "6" Then
                                            HorasTextBox.Enabled = False
                                            HorasTextBox.Text = "06:00:00"
                                            If HorasAsignadas.Text = "5" Then
                                                HorasTextBox.Enabled = False
                                                HorasTextBox.Text = "07:00:00"
                                                If HorasAsignadas.Text = "4" Then
                                                    HorasTextBox.Enabled = False
                                                    HorasTextBox.Text = "08:00:00"
                                                    If HorasAsignadas.Text = "3" Then
                                                        HorasTextBox.Enabled = False
                                                        HorasTextBox.Text = "09:00:00"
                                                        If HorasAsignadas.Text = "2" Then
                                                            HorasTextBox.Enabled = False
                                                            HorasTextBox.Text = "10:00:00"
                                                            If HorasAsignadas.Text = "1" Then
                                                                HorasTextBox.Enabled = False
                                                                HorasTextBox.Text = "11:00:00"
                                                                If HorasAsignadas.Text = "" Then
                                                                    HorasTextBox.Enabled = False
                                                                    HorasTextBox.Text = "12:00:00"
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If HorasBase.Text = "15" Then
            If HorasAsignadas.Text >= "15" Then
                HorasTextBox.Enabled = False
                HorasTextBox.Text = "00:00:00"
                If HorasAsignadas.Text = "14" Then
                    HorasTextBox.Enabled = False
                    HorasTextBox.Text = "01:00:00"
                    If HorasAsignadas.Text = "13" Then
                        HorasTextBox.Enabled = False
                        HorasTextBox.Text = "02:00:00"
                        If HorasAsignadas.Text = "12" Then
                            HorasTextBox.Enabled = False
                            HorasTextBox.Text = "03:00:00"
                            If HorasAsignadas.Text = "11" Then
                                HorasTextBox.Enabled = False
                                HorasTextBox.Text = "04:00:00"
                                If HorasAsignadas.Text = "10" Then
                                    HorasTextBox.Enabled = False
                                    HorasTextBox.Text = "05:00:00"
                                    If HorasAsignadas.Text = "9" Then
                                        HorasTextBox.Enabled = False
                                        HorasTextBox.Text = "06:00:00"
                                        If HorasAsignadas.Text = "8" Then
                                            HorasTextBox.Enabled = False
                                            HorasTextBox.Text = "07:00:00"
                                            If HorasAsignadas.Text = "7" Then
                                                HorasTextBox.Enabled = False
                                                HorasTextBox.Text = "08:00:00"
                                                If HorasAsignadas.Text = "6" Then
                                                    HorasTextBox.Enabled = False
                                                    HorasTextBox.Text = "09:00:00"
                                                    If HorasAsignadas.Text = "5" Then
                                                        HorasTextBox.Enabled = False
                                                        HorasTextBox.Text = "10:00:00"
                                                        If HorasAsignadas.Text = "4" Then
                                                            HorasTextBox.Enabled = False
                                                            HorasTextBox.Text = "11:00:00"
                                                            If HorasAsignadas.Text = "3" Then
                                                                HorasTextBox.Enabled = False
                                                                HorasTextBox.Text = "12:00:00"
                                                                If HorasAsignadas.Text = "2" Then
                                                                    HorasTextBox.Enabled = False
                                                                    HorasTextBox.Text = "13:00:00"
                                                                    If HorasAsignadas.Text = "1" Then
                                                                        HorasTextBox.Enabled = False
                                                                        HorasTextBox.Text = "14:00:00"
                                                                        If HorasAsignadas.Text = "" Then
                                                                            HorasTextBox.Enabled = False
                                                                            HorasTextBox.Text = "12:00:00"
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Sub LlenarhorasAsignadas()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, a.horas))*60 + DATEPART(MI, CONVERT(time, a.horas)))*60+ DATEPART(SS, CONVERT(time, a.horas)))/60/60 as horasasignadas,
        (CONVERT(CHAR(2), SUM(DATEPART(MINUTE, a.horasextras)) / 60 + SUM(DATEPART(HOUR, a.horasextras))) + ':' + CONVERT(CHAR(2), SUM(DATEPART(MINUTE, a.horasextras)) % 60) + ':' + CONVERT(CHAR(2), SUM(DATEPART(SECOND, a.horasextras)) % 60)) as horasextrasasignadas
        from Asignaciones as a
        where a.cliente = '" + ListBox1.SelectedValue + "' and a.sucursal = '" + ListBox2.SelectedValue + "' and a.fecha = '" + FechaDateTime.Value + "'", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            HorasAsignadas.Text = dr.Item("horasasignadas").ToString
            Horasextrasasignadas.Text = dr.Item("horasextrasasignadas").ToString
        End If
        dr.Close()
        cn.Close()
    End Sub

    Sub Llenarempleadosasignados()
        cmd = New SqlCommand("select count(idasignacion) as CantidadEmpleadosAsignados
        from Asignaciones as A
        where A.cliente = '" + ListBox1.SelectedValue + "' and A.sucursal = '" + ListBox2.SelectedValue + "' and A.fecha = '" + FechaDateTime.Value + "'", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            OficialesAsignados.Text = dr.Item("CantidadEmpleadosAsignados").ToString
        End If
        dr.Close()
        cn.Close()
    End Sub


    Sub Cambiodepuesto()
        cn.Open()
        cmd = New SqlCommand("select top 1 * from Asignaciones where codigo = '" + CodigoTextBox.Text + "'") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()

        If dr.Read Then
            txtcambio.Text = dr.Item("cambio")
            txtfcambio.Text = dr.Item("fcambio")
            Try

                If ListBox1.SelectedValue <> dr.Item("cliente") Or ListBox2.SelectedValue <> dr.Item("sucursal") Then
                    txtcambio.Text = Val(txtcambio.Text) + 1
                    txtfcambio.Text = FechaDateTime.Text
                Else
                    txtcambio.Text = dr.Item("cambio")
                    txtfcambio.Text = dr.Item("fcambio")
                End If

            Catch ex As Exception

                txtfcambio.Text = FechaDateTime.Text
            End Try

        Else
            txtcambio.Text = 1
            txtfcambio.Text = FechaDateTime.Text
        End If

        If CodigoTextBox.Text = "" Then
            txtfcambio.Clear()
            txtcambio.Clear()
        End If
        dr.Close()
        cn.Close()
    End Sub


    Private Sub CmdInsertar_Click(sender As Object, e As EventArgs) Handles cmdInsertar.Click

        '' PARA VALIDAR LA CANTIDAD DE HORAS INSERTADAS
        Dim time1 As TimeSpan = TimeSpan.Parse(HorasTextBox.Text)
        Dim time2 As Integer

        If HorasAsignadas.Text = "" Then
            time2 = (0) * 60
        Else
            time2 = (HorasAsignadas.Text) * 60
        End If

        Dim minuto1 As Integer = CStr(time1.TotalMinutes) + time2
        Dim totalasignadas As Integer = minuto1

        Dim time3 As TimeSpan = TimeSpan.Parse(extras.Text)
        Dim totalextras As Integer = CStr(time3.TotalMinutes) + Val(HextrasasignadasConvertidas.Text)

        If HorasAsignadas.Text = "" Then
            HorasAsignadas.Text = 0
        End If

        '' CONTAR ASIGNACIONES QUE SE PUEDEN HACER MAS ASIGNACIONES EN EL DATAGRIDVIEW
        If AsignacionesDataGridView.Rows.Count > 0 Then
            For Each row As DataGridViewRow In AsignacionesDataGridView.Rows
                If row.Cells(5).Value <> "" Then
                    Dim v As TimeSpan = TimeSpan.Parse(row.Cells(5).Value)
                    totalasignadas += CStr(v.TotalMinutes)
                End If

                If row.Cells(8).Value <> "" Then
                    Dim t As TimeSpan = TimeSpan.Parse(row.Cells(8).Value)
                    totalextras += CStr(t.TotalMinutes)
                End If
            Next
        End If

        TextBox4.Text = totalextras

        If totalasignadas > HorasComparacion.Text Or totalextras > HorasExtrasComparacion.Text Then
            If MsgBox("Ha sobrepasado el limite de horas, solo el Jefe de Operaciones puede asignar mas horas a un cliente", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then

                If ClasePrivilegios.Rango5 = "Jefe Operaciones" Then
                    Insertar()
                Else
                    MessageBox.Show("No cuenta con los permisos necesarios para realizar esta operacion")
                End If
            Else
                Llenarhoras()
                Llenarcomparativo()
            End If
        Else
            Insertar()
        End If

        Llenarhoras()
        Llenarcomparativo()
        LlenarhorasAsignadas()
        Llenarempleadosasignados()

    End Sub


    Private Sub Insertar()
        Cambiodepuesto()

        Dim turno As String
        Dim detalle1 As String
        Dim detalle2 As String
        Dim extras1 As String
        Dim extras2 As String
        turno = ""
        detalle1 = ""
        detalle2 = ""
        extras1 = ""
        extras2 = ""

        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            turno = "Mixto"
            detalle1 = "Entrada de Turno"
            detalle2 = "Salida de Turno"
            extras1 = "00:00:00"
            extras2 = extras.Text

        ElseIf CheckBox1.Checked = True Then
            turno = "Diurno"
        ElseIf CheckBox2.Checked = True Then
            turno = "Nocturno"
        ElseIf CheckBox3.Checked = True Then
            turno = "Comodin"
        End If

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        If turno = "Mixto" Then
            sql = "Select * From Asignaciones Where Codigo ='" + CodigoTextBox.Text + "' and Fecha ='" + FechaDateTime.Text + "' or Codigo ='" + CodigoTextBox.Text + "' and Fecha ='" + FechaDateTime.Value.AddDays(1) + "'"
        Else
            sql = "Select * From Asignaciones Where Codigo ='" + CodigoTextBox.Text + "' and Fecha ='" + FechaDateTime.Text + "' and turno <> 'Mixto'"
        End If
        cmd.CommandText = sql

        If CodigoTextBox.Text = "" Then
            MessageBox.Show("Seleccione un Empleado")
            CodigoTextBox.Select()
        ElseIf turno = "" Then
            MessageBox.Show("Seleccione al menos un turno")
        Else
            dr = cmd.ExecuteReader
            dr.Read()
            If turno = "Comodin" Then
                AsignacionesDataGridView.Rows.Add(CodigoTextBox.Text, ListBox1.SelectedValue, ListBox2.SelectedValue, turno, FechaDateTime.Value.ToShortDateString, HorasTextBox.Text, Usuario, ObservacionTextBox.Text, extras.Text, txtcambio.Text, txtfcambio.Text, DialibreTextBox.Text, txtnombre.Text, txtapellido.Text, TxtEstado_Asignacion.Text)
                Limpiar()
                CodigoTextBox.Select()
                ListBox1.Enabled = False
                ListBox2.Enabled = False
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Visible = True
            Else

                If dr.HasRows Then
                    MessageBox.Show("Este empleado ya esta asignado en otro puesto para este dia, seleccione otro empleado")
                    CodigoTextBox.Select()
                Else
                    Dim codigo As Boolean = False
                    FechaDateTime.Enabled = False
                    For Each row In AsignacionesDataGridView.Rows
                        If CodigoTextBox.Text = row.Cells("codigo").Value And FechaDateTime.Value.ToShortDateString = row.Cells("Fecha").Value Then
                            codigo = True
                            MessageBox.Show("El empleado se encuentra asignado en esta fecha")
                            Limpiar()
                            CodigoTextBox.Select()
                            FechaDateTime.Enabled = True
                            Exit For
                        End If
                    Next

                    If codigo = False Then
                        If turno <> "Mixto" Then
                            AsignacionesDataGridView.Rows.Add(CodigoTextBox.Text, ListBox1.SelectedValue, ListBox2.SelectedValue, turno, FechaDateTime.Value.ToShortDateString, HorasTextBox.Text, Usuario, ObservacionTextBox.Text, extras.Text, txtcambio.Text, txtfcambio.Text, DialibreTextBox.Text, txtnombre.Text, txtapellido.Text, TxtEstado_Asignacion.Text)

                            Limpiar()
                            CodigoTextBox.Select()
                            ListBox1.Enabled = False
                            ListBox2.Enabled = False
                            TextBox1.Enabled = False
                            TextBox2.Enabled = False
                            TextBox3.Visible = True

                        ElseIf ObservacionTextBox.Text = "Ninguna" Or ObservacionTextBox.Text = "" Then
                            AsignacionesDataGridView.Rows.Add(CodigoTextBox.Text, ListBox1.SelectedValue, ListBox2.SelectedValue, turno, FechaDateTime.Value.ToShortDateString, HorasTextBox.Text, Usuario, detalle1, extras1, txtcambio.Text, txtfcambio.Text, DialibreTextBox.Text, txtnombre.Text, txtapellido.Text, TxtEstado_Asignacion.Text)
                            AsignacionesDataGridView.Rows.Add(CodigoTextBox.Text, ListBox1.SelectedValue, ListBox2.SelectedValue, turno, FechaDateTime.Value.AddDays(1).ToShortDateString, HorasTextBox.Text, Usuario, detalle2, extras2, txtcambio.Text, txtfcambio.Text, DialibreTextBox.Text, txtnombre.Text, txtapellido.Text, TxtEstado_Asignacion.Text)
                            Limpiar()
                            CodigoTextBox.Select()
                            ListBox1.Enabled = False
                            ListBox2.Enabled = False
                            TextBox1.Enabled = False
                            TextBox2.Enabled = False
                            TextBox3.Visible = True
                        Else
                            AsignacionesDataGridView.Rows.Add(CodigoTextBox.Text, ListBox1.SelectedValue, ListBox2.SelectedValue, turno, FechaDateTime.Value.ToShortDateString, HorasTextBox.Text, Usuario, ObservacionTextBox.Text, extras1, txtcambio.Text, txtfcambio.Text, DialibreTextBox.Text, txtnombre.Text, txtapellido.Text, TxtEstado_Asignacion.Text)
                            AsignacionesDataGridView.Rows.Add(CodigoTextBox.Text, ListBox1.SelectedValue, ListBox2.SelectedValue, turno, FechaDateTime.Value.AddDays(1).ToShortDateString, HorasTextBox.Text, Usuario, detalle2, extras2, txtcambio.Text, txtfcambio.Text, DialibreTextBox.Text, txtnombre.Text, txtapellido.Text, TxtEstado_Asignacion.Text)
                            Limpiar()
                            CodigoTextBox.Select()
                            ListBox1.Enabled = False
                            ListBox2.Enabled = False
                            TextBox1.Enabled = False
                            TextBox2.Enabled = False
                            TextBox3.Visible = True
                        End If
                    End If
                End If
            End If
        End If

        DialibreTextBox.Clear()
        dr.Close()
        cn.Close()
        'HorasTextBox.Enabled = False

    End Sub


    Sub Limpiar()
        CodigoTextBox.Clear()
        ObservacionTextBox.Text = "Ninguna"
        txtnombre.Clear()
        txtapellido.Clear()
        DialibreTextBox.Clear()
        ListBox1.Enabled = True
        ListBox2.Enabled = True
        EmpleadosDataGridView.DataSource = vbNull
    End Sub




    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        For Each row As DataGridViewRow In AsignacionesDataGridView.Rows
            'en cells() coloco la columna que quiero validar si es igual a la condicion
            If row.Cells(0).Value = "" Then
                MessageBox.Show("No se ha realizado ninguna asignacion no es permitido guardar")
            Else
                Guardar()
                ListBox1.Enabled = True
                ListBox2.Enabled = True
            End If
        Next

    End Sub


    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelarAsignacion.Click
        FechaDateTime.Enabled = True
        AsignacionesDataGridView.Rows.Clear()
        ListBox1.Enabled = True
        ListBox2.Enabled = True
        FechaDateTime.Enabled = True
        TextBox3.Clear()
    End Sub


    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbusqueda.Focus()
        End If
        BuscarEmpleado()
    End Sub


    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        BuscarEmpleado()
    End Sub

    Sub BuscarEmpleado()

        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            Try
                sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & txtbusqueda.Text + "%" & "'"
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

        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then

            Try
                sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & txtbusqueda.Text + "%" & "'"
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
            Try
                sql = "select * from Empleados where estado <> 'Inactivo' and ubicacion like '" & txtbusqueda.Text + "%" & "'"
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
            Try
                sql = "select * from Empleados where estado <> 'Inactivo' and planilla like '" & txtbusqueda.Text + "%" & "'"
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
            Try
                sql = "select * from Empleados where estado <> 'Inactivo'"
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

    End Sub


    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        panelEmpleados.Visible = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            txtnombre.Text = selectedRow.Cells(1).Value.ToString
            txtapellido.Text = selectedRow.Cells(2).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception
        End Try

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select dia from Dias where dia = '" + diadelasemana.Text + "' and codigo = '" + CodigoTextBox.Text + "'"
        cmd.CommandText = sql

        'Ejecutamos una lectura a la tabla
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If MsgBox("El empleado tiene el dia libre, Desea Asignarlo?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                MsgBox("Debe agregar una justificacion, del porque esta asignando este empleado")
                Try
                    Dim index As Integer
                    index = e.RowIndex
                    Dim selectedRow As DataGridViewRow
                    selectedRow = EmpleadosDataGridView.Rows(index)

                    txtnombre.Text = selectedRow.Cells(1).Value.ToString
                    txtapellido.Text = selectedRow.Cells(2).Value.ToString
                    CodigoTextBox.Text = selectedRow.Cells(0).Value.ToString
                    DialibreTextBox.Text = "Si"

                    ObservacionTextBox.Clear()
                    ObservacionTextBox.Select()
                Catch ex As Exception

                End Try
            Else
                CodigoTextBox.Clear()
                CodigoTextBox.Select()
                txtnombre.Clear()
                txtapellido.Clear()
            End If
        End If

        dr.Close()
        cn.Close()
    End Sub
    Private Sub ReporteAsignacionesPorCodigoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReporteAsignacionesPorCodigoToolStripMenuItem.Click
        R_AsignacionporCodigo.ShowDialog()
    End Sub

    Private Sub AsignacionesGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionesGeneralesToolStripMenuItem.Click
        R_AsignacionesGenerales.ShowDialog()
    End Sub

    Private Sub AsignacionesClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionesClienteToolStripMenuItem.Click
        R_AsignacionesporCliente.ShowDialog()
    End Sub

    Private Sub HorasComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipodebusqueda.KeyPress
        e.Handled = True
    End Sub

    Private Sub FechaDateTime_ValueChanged(sender As Object, e As EventArgs) Handles FechaDateTime.ValueChanged
        diadelasemana.Value = FechaDateTime.Value
        RangodeAsignacion()
        Llenarcomparativo()
        LlenarhorasAsignadas()
        Llenarempleadosasignados()
        'Horasporasignar()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        sql = "Select * from  cliente where estado = 'Activo' and nombre like '" & TextBox1.Text & "%" & "' order by nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.DisplayMember = "nombre"
        ListBox1.ValueMember = "nombre"
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        LlenarSucursal()
        Llenarhoras()
        Llenarcomparativo()
        LlenarhorasAsignadas()
        Llenarempleadosasignados()
        'Horasporasignar() 
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        sql = "SELECT TOP (100) PERCENT dbo.Sucursales.sucursal, dbo.Cliente.estado
                    FROM            dbo.Sucursales INNER JOIN
                         dbo.Cliente ON dbo.Sucursales.nombre = dbo.Cliente.nombre
                    WHERE        (dbo.Sucursales.estado = 'Activo') AND (dbo.Cliente.nombre = '" + ListBox1.SelectedValue + "') AND (dbo.Cliente.estado = 'Activo') AND (dbo.Sucursales.sucursal like '" & TextBox2.Text + "%" & "')
                    ORDER BY dbo.Sucursales.nombre"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox2.DataSource = ds.Tables(0)
        ListBox2.DisplayMember = "sucursal"
        ListBox2.ValueMember = "sucursal"
    End Sub



    Private Sub ListBox1_TextChanged(sender As Object, e As EventArgs) Handles ListBox1.TextChanged
        LlenarSucursal()
        Llenarhoras()
        Llenarcomparativo()
        LlenarhorasAsignadas()
        Llenarempleadosasignados()
        Horasporasignar()
    End Sub


    Sub Guardar()
        If AsignacionesDataGridView.Rows.Count = 0 Then
            Return
        End If

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()

            sql = "insert into Asignaciones (codigo, cliente, turno, fecha, horas, observacion, autoriza, sucursal, horasextras, cambio, fcambio, dialibre, nombre, apellido, estado) VALUES(@codigo, @cliente, @turno, @fecha, @horas, @observacion, @autoriza, @sucursal, @hextras, @cambio, @fcambio, @dialibre, @nombre, @apellido, @estado)"
            cmd = New SqlCommand(sql, cn)
            Try
                For Each row As DataGridViewRow In AsignacionesDataGridView.Rows
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@codigo", Convert.ToString(row.Cells("Codigo").Value))
                    cmd.Parameters.AddWithValue("@cliente", Convert.ToString(row.Cells("Cliente").Value))
                    cmd.Parameters.AddWithValue("@turno", Convert.ToString(row.Cells("Turno").Value))
                    cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(row.Cells("Fecha").Value))
                    cmd.Parameters.AddWithValue("@horas", Convert.ToString(row.Cells("Horas").Value))
                    cmd.Parameters.AddWithValue("@observacion", Convert.ToString(row.Cells("Observacion").Value))
                    cmd.Parameters.AddWithValue("@autoriza", Convert.ToString(row.Cells("Autoriza").Value))
                    cmd.Parameters.AddWithValue("@sucursal", Convert.ToString(row.Cells("Sucursal").Value))
                    cmd.Parameters.AddWithValue("@hextras", Convert.ToDateTime(row.Cells("Horasextras").Value))
                    cmd.Parameters.AddWithValue("@cambio", Convert.ToInt16(row.Cells("Cambio").Value))
                    cmd.Parameters.AddWithValue("@fcambio", Convert.ToString(row.Cells("fcambio").Value))
                    cmd.Parameters.AddWithValue("@dialibre", Convert.ToString(row.Cells("dialibre").Value))
                    cmd.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells("nombre").Value))
                    cmd.Parameters.AddWithValue("@apellido", Convert.ToString(row.Cells("apellido").Value))
                    cmd.Parameters.AddWithValue("@estado", Convert.ToString(row.Cells("EstadoAsignacion").Value))
                    cmd.ExecuteNonQuery()
                Next
            Catch ex As Exception
                MessageBox.Show("Empleados han sido asignados")
                Limpiar()
            End Try

            cn.Close()
        End Using

        AsignacionesDataGridView.Rows.Clear()
        ListBox1.Enabled = True
        ListBox2.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        FechaDateTime.Enabled = True
        TextBox3.Visible = False
    End Sub



    Private Sub CodigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodigoTextBox.TextChanged
        If CodigoTextBox.Text = "" Then
            Limpiar()
        End If

    End Sub


    Private Sub ListBox2_Click(sender As Object, e As EventArgs) Handles ListBox2.Click
        Llenarhoras()
        Llenarcomparativo()
        LlenarhorasAsignadas()
        Llenarempleadosasignados()
        'Horasporasignar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormAsignacionesPendientes.Show()
    End Sub

    Private Sub ListBox2_TextChanged(sender As Object, e As EventArgs) Handles ListBox2.TextChanged
        Llenarhoras()
        Llenarcomparativo()
        LlenarhorasAsignadas()
        Llenarempleadosasignados()
        'Horasporasignar()
    End Sub

    Private Sub Habilitar_Click(sender As Object, e As EventArgs) Handles Habilitar.Click

        If ClasePrivilegios.Rango5 = "Jefe Operaciones" Then
            HorasTextBox.Enabled = True
        Else
            MessageBox.Show("Solo es permitido habilitar mas horas a un cliente para el Jefe de Operaciones")
        End If
    End Sub

    Private Sub Extras_MouseLeave(sender As Object, e As EventArgs) Handles extras.MouseLeave
        If extras.Text = "" Then
            extras.Text = "00:00:00"
        End If
    End Sub

    Private Sub ReporteFaltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteFaltasToolStripMenuItem.Click
        R_45.Show()
    End Sub

End Class