Public Class FormClientes

    ReadOnly obj As New ClaseBusquedasDinamicas
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.llenardgvclienteall(ClienteDataGridView)
        obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)

        Telefono2TextBox.Text = "0000-0000"
        Telefono1TextBox.Text = "0000-0000"
        Telefono3TextBox.Text = "0000-0000"
        HorasTextBox.Text = "12:00:00"
        Extras.Text = "00:00:00"


        Panelregistroclientes.Visible = False
        PanelSucursales.Visible = False

        observacion_sucursal.Text = "Ninguna"

        EstadoComboBox.SelectedItem = "Seleccionar"
        EstadoSucur.SelectedItem = "Activo"
        ComboBase.SelectedItem = "12"

        Panel1.Visible = False

        cmdAgregarSucursal.Visible = False

        If txtbusqueda.Text = "" Then
            SucursalesDataGridView.DataSource = vbNull
        End If
        txtbusqueda.Focus()
    End Sub

    'Busqueda dinamica por codigo o por nombre'
    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        obj.llenardgvclientenombre(txtbusqueda.Text, ClienteDataGridView)
        obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)

        If txtbusqueda.Text = "" Then
            SucursalesDataGridView.DataSource = vbNull
        End If
    End Sub



    Private Sub CmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        limpiar2()

        If Panelregistroclientes.Visible = True Then
            Panelregistroclientes.Visible = False
        Else
            Panelregistroclientes.Visible = True
        End If

        PanelSucursales.Visible = False
        Tab_Clientes.SelectedTab = Clientes
        cmdGuardar.Enabled = True
        cmdAgregarSucursal.Enabled = False
        cmdActualizarCliente.Enabled = False
        txtbusqueda.Clear()
        ComboBase.SelectedItem = "12"
    End Sub


    Sub Limpiar()
        txt_empleados.Clear()
        IdclienteTextBox.Clear()
        CodigoTextBox.Clear()
        NombreTextBox.Clear()
        CorreoTextBox.Clear()
        Telefono2TextBox.Text = "0000-0000"
        Telefono1TextBox.Text = "0000-0000"
        Telefono3TextBox.Text = "0000-0000"
        HorasTextBox.Text = "12:00:00"
        Extras.Text = "00:00:00"
        IdsucursalTextBox.Clear()
        CodigoTextBox1.Clear()
        SucursalTextBox.Clear()
        txt_fechafinal.Clear()
        txt_observacion.Clear()
        Panelregistroclientes.Visible = False
        grupo.Visible = False
        txt_subt.Text = 0
        txt_isv.Text = 0
        txt_total.Text = 0
        txt_rtn.Text = 0
        EstadoComboBox.SelectedItem = "Seleccionar"
        txtbusqueda.Clear()
        observacion_sucursal.Text = "Ninguna"
        ComboBase.SelectedItem = "12"
    End Sub

    Sub Limpiar2()
        IdclienteTextBox.Clear()
        CodigoTextBox.Clear()
        NombreTextBox.Clear()
        CorreoTextBox.Clear()
        Telefono2TextBox.Text = "0000-0000"
        Telefono1TextBox.Text = "0000-0000"
        Telefono3TextBox.Text = "0000-0000"
        HorasTextBox.Text = "12:00:00"
        Extras.Text = "00:00:00"
        IdsucursalTextBox.Clear()
        CodigoTextBox1.Clear()
        SucursalTextBox.Clear()
        txt_fechafinal.Clear()
        txt_observacion.Clear()
        grupo.Visible = False
        txt_subt.Text = 0
        txt_isv.Text = 0
        txt_total.Text = 0
        txt_rtn.Text = 0
        EstadoComboBox.SelectedItem = "Seleccionar"
        txtbusqueda.Clear()
        observacion_sucursal.Text = "Ninguna"
        Panel1.Visible = False
    End Sub




    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If MsgBox("¡Desea guardar el nuevo cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            cmdGuardarSucursal.Enabled = True
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * From cliente Where nombre ='" + NombreTextBox.Text + "'"
            cmd.CommandText = sql

            If NombreTextBox.Text = "" Then
                MessageBox.Show("Escriba el nombre del Cliente")
            Else
                'Ejecutamos una lectura RRHH la tabla
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MessageBox.Show("Este cliente ya esta registrado en nuestra base de datos")
                    NombreTextBox.Clear()
                    NombreTextBox.Select()
                Else
                    If EstadoComboBox.SelectedItem = "Inactivo" Then
                        sql = "insert into Cliente (nombre, correo, estado, rtn, fechainicio, fechafinal, comentario) values('" + NombreTextBox.Text + "',
                    '" + CorreoTextBox.Text + "',
                    '" + EstadoComboBox.SelectedItem.ToString + "',
                    '" + txt_rtn.Text + "',
                    '" + FechainicioDateTimePicker.Text + "',
                    '" + txt_fechafinal.Text + "',
                    '" + txt_observacion.Text + "')"
                        Ejecutar(sql)

                        SucursalTextBox.Select()
                        Telefono2TextBox.Text = "0000-0000"
                        Telefono1TextBox.Text = "0000-0000"
                        Telefono3TextBox.Text = "0000-0000"
                        txtbusqueda.Text = NombreTextBox.Text
                        grupo.Visible = True

                        obj.llenardgvclienteall(ClienteDataGridView)
                        obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)
                    Else
                        sql = "insert into Cliente (nombre, correo, estado, rtn, fechainicio, fechafinal,comentario) values('" + NombreTextBox.Text + "',
                    '" + CorreoTextBox.Text + "',
                    '" + EstadoComboBox.SelectedItem.ToString + "',
                    '" + txt_rtn.Text + "',
                    '" + FechainicioDateTimePicker.Text + "',
                    '" + txt_fechafinal.Text + "',
                    '" + txt_observacion.Text + "')"
                        Ejecutar(sql)

                        SucursalTextBox.Select()
                        Telefono2TextBox.Text = "0000-0000"
                        Telefono1TextBox.Text = "0000-0000"
                        Telefono3TextBox.Text = "0000-0000"
                        txtbusqueda.Text = NombreTextBox.Text

                        grupo.Visible = True
                        cmdGuardar.Enabled = False
                        cmdActualizarSucursal.Enabled = False

                        obj.llenardgvclienteall(ClienteDataGridView)
                        obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)
                    End If
                End If
            End If
            dr.Close()
            cn.Close()

            MsgBox("¡Cliente registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
        txtbusqueda.Clear()
    End Sub

    Private Sub Telefono1TextBox_Click(sender As Object, e As EventArgs)
        Telefono1TextBox.Clear()
    End Sub

    Private Sub Telefono2TextBox_Click(sender As Object, e As EventArgs)
        Telefono2TextBox.Clear()
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles cmdAgregarSucursal.Click
        Tab_Clientes.SelectedTab = Sucursales
        PanelSucursales.Visible = True
        grupo.Visible = True
    End Sub

    Private Sub SucursalesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SucursalesDataGridView.CellContentClick
        Try
            If NombreTextBox.Text = "" Then
                MessageBox.Show("Debe seleccionar primero al cliente")
            Else
                Panelregistroclientes.Visible = True
                grupo.Visible = True
                PanelSucursales.Visible = True
                cmdGuardarSucursal.Enabled = False
                cmdActualizarSucursal.Enabled = True
                cmdAgregarSucursal.Visible = False

                Dim index As Integer
                index = e.RowIndex
                Dim selectedRow As DataGridViewRow
                selectedRow = SucursalesDataGridView.Rows(index)

                SucursalTextBox.Text = selectedRow.Cells(1).Value.ToString
                Telefono1TextBox.Text = selectedRow.Cells(2).Value.ToString
                Telefono2TextBox.Text = selectedRow.Cells(3).Value.ToString
                Telefono3TextBox.Text = selectedRow.Cells(4).Value.ToString
                HorasTextBox.Text = selectedRow.Cells(5).Value.ToString
                IdsucursalTextBox.Text = selectedRow.Cells(0).Value.ToString
                txt_empleados.Text = selectedRow.Cells(6).Value.ToString
                txt_subt.Text = selectedRow.Cells(7).Value.ToString
                txt_isv.Text = selectedRow.Cells(8).Value.ToString
                txt_total.Text = selectedRow.Cells(9).Value.ToString
                observacion_sucursal.Text = selectedRow.Cells(10).Value.ToString
                Extras.Text = selectedRow.Cells(11).Value.ToString
                ComboBase.SelectedItem = selectedRow.Cells(12).Value.ToString
                EstadoSucur.SelectedItem = selectedRow.Cells(13).Value.ToString
            End If

        Catch ex As Exception

        End Try

    End Sub




    Private Sub EstadoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstadoComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub Telefono1TextBox_TextChanged(sender As Object, e As EventArgs)
        'para condicionar un textbox
        If Telefono1TextBox.Text.Length <= 10 Then
            If Telefono1TextBox.Text.Length >= 5 Then
                Dim s As String = Telefono1TextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                Telefono1TextBox.Text = s
                Telefono1TextBox.SelectionStart = s.Length
            End If
        End If
    End Sub

    Private Sub Telefono2TextBox_TextChanged(sender As Object, e As EventArgs)
        'para condicionar un textbox
        If Telefono2TextBox.Text.Length <= 10 Then
            If Telefono2TextBox.Text.Length >= 5 Then
                Dim s As String = Telefono2TextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                Telefono2TextBox.Text = s
                Telefono2TextBox.SelectionStart = s.Length
            End If
        End If
    End Sub

    Private Sub Telefono3TextBox_TextChanged(sender As Object, e As EventArgs)
        'para condicionar un textbox
        If Telefono3TextBox.Text.Length <= 10 Then
            If Telefono3TextBox.Text.Length >= 5 Then
                Dim s As String = Telefono3TextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                Telefono3TextBox.Text = s
                Telefono3TextBox.SelectionStart = s.Length
            End If
        End If
    End Sub

    Private Sub Txt_subt_TextChanged(sender As Object, e As EventArgs)
        If txt_subt.Text = "" Then
            txt_isv.Text = 0
            txt_total.Text = 0
        Else
            Try
                txt_isv.Text = (txt_subt.Text * 0.15).ToString("N2")
                txt_total.Text = (Convert.ToDecimal(txt_subt.Text) + Convert.ToDecimal(txt_isv.Text)).ToString("N2")
            Catch ex As Exception
                txt_subt.Text = 0
                txt_isv.Text = 0
                txt_total.Text = 0
                txt_subt.Select()
                MsgBox("Ingrese numeros sin letras ni caracteres")
            End Try
        End If
    End Sub

    Private Sub Estado_sucursal_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub



    Private Sub FechafinalDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechafinalDateTimePicker.ValueChanged
        txt_fechafinal.Text = FechafinalDateTimePicker.Value.ToLongDateString
    End Sub

    Private Sub EstadoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EstadoComboBox.SelectedIndexChanged
        If EstadoComboBox.SelectedItem = "Inactivo" Then
            Panel1.Visible = True
            txt_fechafinal.Text = FechafinalDateTimePicker.Value.ToLongDateString
        Else
            If EstadoComboBox.SelectedItem = "Activo" Then
                FechafinalDateTimePicker.Value = Now
                txt_fechafinal.Clear()
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged
        txtbusqueda.Text = NombreTextBox.Text
        If NombreTextBox.Text = "" Then
            txtbusqueda.Clear()
        End If
    End Sub

    Private Sub ClienteDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClienteDataGridView.CellContentClick
        Panelregistroclientes.Visible = True
        cmdGuardar.Enabled = False
        cmdGuardarSucursal.Enabled = True
        cmdActualizarSucursal.Enabled = False
        grupo.Visible = False
        cmdAgregarSucursal.Visible = True
        cmdActualizarCliente.Enabled = True
        Try

            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = ClienteDataGridView.Rows(index)

            IdclienteTextBox.Text = selectedRow.Cells(0).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(1).Value.ToString
            CorreoTextBox.Text = selectedRow.Cells(3).Value.ToString
            EstadoComboBox.SelectedItem = selectedRow.Cells(4).Value.ToString
            txt_rtn.Text = selectedRow.Cells(5).Value.ToString
            FechainicioDateTimePicker.Value = selectedRow.Cells(6).Value.ToString
            txt_fechafinal.Text = selectedRow.Cells(7).Value.ToString
            txt_observacion.Text = selectedRow.Cells(8).Value.ToString
            NombreTextBox.Text = selectedRow.Cells(2).Value.ToString
        Catch ex As Exception

        End Try
        cmdAgregarSucursal.Enabled = True

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles cmdEliminar.Click

        If MsgBox("Al eliminar un cliente se borraran tambien las sucursales asignadas al mismo, Desea Eliminarlo?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
            If NombreTextBox.Text = "" Then
                MsgBox("¡No se ha seleccionado ningu cliente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else

                sql = "delete from Cliente where idcliente = '" + IdclienteTextBox.Text + "'"
                Ejecutar(sql)

                sql = "delete from Sucursales where nombre = '" + NombreTextBox.Text + "'"
                Ejecutar(sql)
            End If
            obj.llenardgvclienteall(ClienteDataGridView)
            obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)
            Limpiar()

            MsgBox("¡Se elimaron todos los registros correspondientes para este cliente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")

        End If
    End Sub

    Private Sub ComboBase_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CmdGuardarSucursal_Click(sender As Object, e As EventArgs) Handles cmdGuardarSucursal.Click
        If MsgBox("¡Desea guardar la sucursal?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If observacion_sucursal.Text = "" Then
                observacion_sucursal.Text = "Ninguna"
            End If

            If NombreTextBox.Text = "" Or txt_empleados.Text = "" Then
                MsgBox("¡Existen campos vacios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                NombreTextBox.Select()
            Else
                If SucursalTextBox.Text = "" Then
                    MsgBox("¡Escriba la sucursal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                Else
                    sql = "insert into Sucursales values('" + NombreTextBox.Text + "',
                '" + SucursalTextBox.Text + "',
                '" + Telefono1TextBox.Text + "',
                '" + Telefono2TextBox.Text + "',
                '" + Telefono3TextBox.Text + "',
                '" + HorasTextBox.Text + "',
                '" + txt_subt.Text + "',
                '" + txt_isv.Text + "',
                '" + txt_total.Text + "',
                '" + txt_empleados.Text + "',
                '" + observacion_sucursal.Text + "',
                '" + Extras.Text + "',
                '" + ComboBase.SelectedItem.ToString + "',
                '" + EstadoSucur.SelectedItem.ToString + "')"
                    Ejecutar(sql)

                    SucursalTextBox.Clear()
                    Telefono2TextBox.Text = "0000-0000"
                    Telefono1TextBox.Text = "0000-0000"
                    Telefono3TextBox.Text = "0000-0000"
                    HorasTextBox.Text = "12:00:00"
                    Extras.Text = "00:00:00"
                    txt_subt.Text = 0
                    txt_isv.Text = 0
                    txt_total.Text = 0
                    txt_empleados.Text = 0
                    observacion_sucursal.Text = "Ninguna"
                    SucursalTextBox.Select()
                    obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)
                End If
            End If

            PanelSucursales.Visible = False

            MsgBox("¡Sucursal registrada exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If


    End Sub

    Private Sub CmdActualizarSucursal_Click(sender As Object, e As EventArgs) Handles cmdActualizarSucursal.Click
        If MsgBox("¡Desea actualizar la sucursal del cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            Actualizar_Sucursal()
            MsgBox("¡Sucursal actualizada exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Sub Actualizar_Sucursal()
        If IdsucursalTextBox.Text = "" Then
            MessageBox.Show("Seleccione una sucursal")
        Else
            sql = "update Sucursales set  
            sucursal = '" + SucursalTextBox.Text + "',
            telefono1 = '" + Telefono1TextBox.Text + "',
            telefono2 = '" + Telefono2TextBox.Text + "',
            telefono3 = '" + Telefono3TextBox.Text + "',
            horas = '" + HorasTextBox.Text + "',
            subt = '" + txt_subt.Text + "',
            isv = '" + txt_isv.Text + "',
            total = '" + txt_total.Text + "',
            empleados = '" + txt_empleados.Text + "',
            observacion = '" + observacion_sucursal.Text + "',
            extras = '" + Extras.Text + "',
            basehoras = '" + ComboBase.SelectedItem.ToString + "',
            estado = '" + EstadoSucur.SelectedItem.ToString + "' where idsucursal = '" + IdsucursalTextBox.Text + "'"
            Ejecutar(sql)
        End If
        cmdGuardarSucursal.Enabled = True
        cmdActualizarSucursal.Enabled = False
        SucursalTextBox.Clear()
        SucursalTextBox.Select()
        Telefono2TextBox.Text = "0000-0000"
        Telefono1TextBox.Text = "0000-0000"
        Telefono3TextBox.Text = "0000-0000"
        HorasTextBox.Text = "12:00:00"
        Extras.Text = "00:00:00"
        obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)
        Limpiar()
        limpiar2()

        PanelSucursales.Visible = False

    End Sub

    Private Sub Cmdguardarnuevosaldo_Click(sender As Object, e As EventArgs)
        Actualizar_Sucursal()
    End Sub


    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizarCliente.Click
        If MsgBox("¡Desea guardar actualizar los datos del cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If NombreTextBox.Text = "" Then
                MessageBox.Show("No hay registro por actualizar, Seleccione un registro")
            Else
                sql = "update Cliente set  
            nombre ='" + NombreTextBox.Text + "',
            correo ='" + CorreoTextBox.Text + "',
            rtn ='" + txt_rtn.Text + "',
            fechainicio ='" + FechainicioDateTimePicker.Value + "',
            fechafinal ='" + txt_fechafinal.Text + "',
            comentario ='" + txt_observacion.Text + "',
            estado = '" + EstadoComboBox.SelectedItem.ToString + "' where idcliente = '" + IdclienteTextBox.Text + "'"
                Ejecutar(sql)
            End If
            obj.llenardgvclienteall(ClienteDataGridView)
            obj.llenardgvcsucursal(txtbusqueda.Text, SucursalesDataGridView)
            Limpiar()

            MsgBox("¡Cliente actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub ReporteDeTotalClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeTotalClientesToolStripMenuItem.Click
        R_Clientes.Show()
    End Sub

    Private Sub ReporteDeSucursalesPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeSucursalesPorClienteToolStripMenuItem.Click
        R_ClientesSucursales.Show()
    End Sub
End Class