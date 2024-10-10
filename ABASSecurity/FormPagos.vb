Imports System.Data.SqlClient
Public Class FormPagos

    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub FormPagos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblpago.Text = ""
        lblfecha.Text = ""
        Dias_Trabajados.ReadOnly = True
        panelEmpleados.Visible = False
        obj.Llamadgv(EmpleadosDataGridView)
        tipodebusqueda.SelectedItem = "Codigo de Empleado"

        If Rango1 <> "Gerencia" Then
            GroupBox2.Visible = False
            GroupBox11.Visible = False
        End If
    End Sub



    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        LlenarPagos()
    End Sub

    Sub LlenarPagos()
        Limpiar()
        If txtbusqueda.Text <> "" Then
            sql = "select * from Pagos where desde = '" + DateTimePicker1.Text + "' and fechadepago = '" + DateTimePicker2.Text + "' And Codigo = '" + txtbusqueda.Text + "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                PagosDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub GenerarVoucherDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarVoucherDePagoToolStripMenuItem.Click
        R_Boucher.ShowDialog()
    End Sub

    Private Sub PagosPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosPorFechaToolStripMenuItem.Click
        R_Planilla.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarEmp.TextChanged
        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & txtbuscarEmp.Text + "%" & "'"
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
            obj.BusquedaNombre(txtbuscarEmp.Text, EmpleadosDataGridView)
        End If


        If tipodebusqueda.SelectedItem.ToString = "Identidad" Then
            'para condicionar un textbox
            If txtbuscarEmp.Text.Length <= 10 Then
                If txtbuscarEmp.Text.Length >= 5 Then
                    Dim s As String = txtbuscarEmp.Text.Replace("-", "")
                    For x As Integer = 4 To s.Length Step 4
                        s = s.Insert(x + ((x \ 4) - 1), "-")
                    Next
                    s = s.TrimEnd("-"c)
                    txtbuscarEmp.Text = s
                    txtbuscarEmp.SelectionStart = s.Length
                End If
            End If
            obj.BusquedaIdentidad(txtbuscarEmp.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Ubicacion" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and ubicacion like '" & txtbuscarEmp.Text + "%" & "'"
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
            sql = "select * from Empleados where estado <> 'Inactivo' and planilla like '" & txtbuscarEmp.Text + "%" & "'"
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

    End Sub


    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            txtbusqueda.Text = selectedRow.Cells(0).Value.ToString
            NombresTextBox.Text = selectedRow.Cells(1).Value.ToString
            ApellidosTextBox.Text = selectedRow.Cells(2).Value.ToString
            panelEmpleados.Visible = False
        Catch ex As Exception

        End Try

        LlenarPagos()

    End Sub

    Private Sub ReportesDeDeduccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeDeduccionesToolStripMenuItem.Click
        R_Deducciones.ShowDialog()
    End Sub

    Private Sub Tipodebusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipodebusqueda.KeyPress
        e.Handled = True
    End Sub


    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If Now <= DateTimePicker2.Value.AddDays(3) Then
            If MsgBox("¡Desea Eliminar el Pago, esta operacion no se puede regresar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                If lblpago.Text = "" Then
                    MessageBox.Show("No hay registro por actualizar, Seleccione un registro")
                Else

                    If txt_anticipo.Text <> "0" Then
                        If txt_anticipo.Text > 0 Then
                            sql = "update Anticipos set estado ='Pendiente' where codigo = '" + CodigoTextBox.Text + "'and fecha>='" + DateTimePicker1.Value + "' and fecha<='" + DateTimePicker2.Value + "'"
                            MsgBox("¡Se encontro un anticipo, se actualizo a pendiente, para cobrar posteriormente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                            Ejecutar(sql)
                        End If
                    End If

                    sql = "delete pagos where codigo = '" + CodigoTextBox.Text + "' and idpago = '" + lblpago.Text + "'"
                    Ejecutar(sql)

                    'setear no pagada a las asignaciones
                    sql = "update asignaciones set estado ='No Pagada' where idpago='" + lblpago.Text + "'"
                    Ejecutar(sql)

                    PagosDataGridView.DataSource = vbNull
                    txtbusqueda.Clear()
                End If
            Else
            End If

            MsgBox("¡Pago eliminado exitosamente, las asignaciones de actualizan a no pagadas, para realizar el pago nuevamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Limpiar()
        Else
            MsgBox("¡Los pagos solo pueden eliminarse en un rango de 3 dias!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub



    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbuscarEmp.Focus()
        End If
    End Sub

    Private Sub CmdCambiar_Click(sender As Object, e As EventArgs) Handles cmdCambiar.Click
        If MsgBox("¡Desea cambiar el salario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            CargarNuevoSalario()
            MsgBox("¡Usuario registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub


    Sub CargarNuevoSalario()
        If Txt_NuevoSalario.Text = "" Then
            MessageBox.Show("Se debe agregar un salario para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CodigoTextBox.Text = "" Then
            MessageBox.Show("Se debe seleccionar un registro para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Rango1 = "Gerencia" Then
                sql = "update Empleados set 
                    salario ='" + Txt_NuevoSalario.Text + "' where Codigo = '" + CodigoTextBox.Text + "'"
                Ejecutar(sql)
                Salariobase.Text = Txt_NuevoSalario.Text
            Else
                MsgBox("¡No cuenta con los permisos necesarios para realizar esta operacion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If
        End If
    End Sub


    Sub Limpiar()
        DateTimePicker3.Value = "2000-01-01 00:00"

        CodigoTextBox.Clear()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        txt_comentario.Clear()

        Horasextras_trabajadas.Clear()
        Horas_Trabajadas.Clear()
        valor_horasextras.Text = 0
        txt_pagohorasextras.Text = 0
        txt_pagohoras.Text = 0
        Salariobase.Text = 0
        Dias_Trabajados.Text = 0
        DialibreTextBox.Text = 0
        txt_vacaciones.Text = 0
        SubtotalTextBox.Text = 0

        UniformeTextBox.Text = 0
        AdelantoTextBox.Text = 0
        IhssTextBox.Text = 0
        RapTextBox.Text = 0
        TotalapagarTextBox.Text = 0
        txt_ajustes.Text = 0
        txtprestamo.Text = 0
        txtsaldopres.Text = 0
        txt_bono.Text = 0
        txt_bhoras.Text = 0

        horas_septimo.Text = 0
        txt_septimo.Text = 0

        txt_deducciones.Text = 0
        txt_anticipo.Text = 0
        txt_hferiado.Text = 0
        txt_pagoferiado.Text = 0
        txt_saluniforme.Text = 0
        txt_uniforme.Text = 0
        txtOtraDeduccion.Text = 0

    End Sub


    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click

        If Now <= DateTimePicker2.Value.AddDays(3) Then
            If lblpago.Text = "" Then
                MsgBox("¡No hay registros por actualizar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            ElseIf MsgBox("¡Desea actualizar el Pago?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                sql = "update pagos set 
                        salario = '" + Salariobase.Text + "',
                        bonos = '" + txt_bono.Text + "',
                        subtotal = '" + SubtotalTextBox.Text + "',
                        vacaciones = '" + txt_vacaciones.Text + "',
                        ihss = '" + IhssTextBox.Text + "', 
                        rap = '" + RapTextBox.Text + "', 
                        adelanto = '" + AdelantoTextBox.Text + "', 
                        uniforme = '" + UniformeTextBox.Text + "',
                        totalapagar ='" + TotalapagarTextBox.Text + "',
                        asignacion = '" + txt_ajustes.Text + "',
                        preciodehe = '" + txt_pagohorasextras.Text + "',
                        horassept = '" + txt_septimo.Text + "',
                        horasdialibre = '" + horas_septimo.Text + "',
                        saldoant = '" + txtprestamo.Text + "',
                        saldoact = '" + txtsaldopres.Text + "',
                        preciodeh = '" + txt_pagohoras.Text + "',
                        hferiado = '" + txt_hferiado.Text + "',
                        pagoferiado = '" + txt_pagoferiado.Text + "',
                        totdeducciones = '" + txt_deducciones.Text + "',
                        uniformeant = '" + txt_uniforme.Text + "',
                        bhoras = '" + txt_bhoras.Text + "',
                        motivoajuste = '" + txt_comentario.Text + "',
                        depreciacion = '" + txt_depreciacion.Text + "',
                        uniformeact = '" + txt_saluniforme.Text + "',
                        usuario = '" + Usuario + "',
                        otradeduccion = '" + txtOtraDeduccion.Text + "' where idpago = '" + lblpago.Text + "'"
                Ejecutar(sql)

                Limpiar()
                txtbusqueda.Clear()
            End If
        ElseIf MsgBox("Los registros solo son editables en un rango de 3 dias, para realizar este cambio debe confirmarlo el gerente", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
            UpdatePago()
        End If
    End Sub

    Private Sub AdelantoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AdelantoTextBox.TextChanged
        If Val(AdelantoTextBox.Text) > Val(txtprestamo.Text) Then
            AdelantoTextBox.Text = 0
        End If
    End Sub

    Private Sub UpdatePago()
        If CodigoTextBox.Text = "" Then
            MessageBox.Show("Se debe seleccionar un registro para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Rango1 = "Gerencia" Then
                sql = "update pagos set 
                        salario ='" + Salariobase.Text + "',
                        bonos = '" + txt_bono.Text + "',
                        subtotal ='" + SubtotalTextBox.Text + "',
                        vacaciones ='" + txt_vacaciones.Text + "',
                        ihss ='" + IhssTextBox.Text + "', 
                        rap ='" + RapTextBox.Text + "', 
                        adelanto ='" + AdelantoTextBox.Text + "', 
                        uniforme = '" + UniformeTextBox.Text + "',
                        totalapagar ='" + TotalapagarTextBox.Text + "',
                        asignacion ='" + txt_ajustes.Text + "',
                        preciodehe = '" + txt_pagohorasextras.Text + "',
                        horassept = '" + txt_septimo.Text + "',
                        horasdialibre = '" + horas_septimo.Text + "',
                        saldoant = '" + txtprestamo.Text + "',
                        saldoact = '" + txtsaldopres.Text + "',
                        preciodeh = '" + txt_pagohoras.Text + "',
                        hferiado = '" + txt_hferiado.Text + "',
                        pagoferiado = '" + txt_pagoferiado.Text + "',
                        totdeducciones= '" + txt_deducciones.Text + "',
                        uniformeant= '" + txt_uniforme.Text + "',
                        bhoras= '" + txt_bhoras.Text + "',
                        motivoajuste= '" + txt_comentario.Text + "',
                        depreciacion= '" + txt_depreciacion.Text + "',
                        uniformeact= '" + txt_saluniforme.Text + "',
                        usuario= '" + Usuario + "',
                        otradeduccion = '" + txtOtraDeduccion.Text + "'
                        where idpago = '" + lblpago.Text + "'"
                Ejecutar(sql)
                Limpiar()

                txtbusqueda.Clear()
                DateTimePicker1.Value = Now
                DateTimePicker2.Value = Now
                PagosDataGridView.DataSource = vbNull


                MsgBox("¡Pago actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
            Else
                MsgBox("¡No cuenta con los permisos necesarios, para realizar esta operacion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor As Integer
        If txt_hferiado.Text > 0 Then
            Dim txt_pagofe As Integer
            txt_pagofe = (Val(Salariobase.Text) / Val(txt_bhoras.Text)) * Val(txt_hferiado.Text)
            txt_pagoferiado.Text = txt_pagofe
        End If
        If valor_horasextras.Text = 0 Then
            txt_pagohorasextras.Text = 0
        Else
            'Calculo de horas extras
            If Horasextras_trabajadas.Text <> "" Then
                Horasextras_trabajadas.SelectionStart = 0
                Horasextras_trabajadas.SelectionLength = 3
                Dim h As Integer
                h = (Horasextras_trabajadas.SelectedText)

                Horasextras_trabajadas.SelectionStart = 4
                Horasextras_trabajadas.SelectionLength = 2
                Dim m As Integer
                m = (Horasextras_trabajadas.SelectedText)
                valor = (h * Val(valor_horasextras.Text)) + ((m / 60) * Val(valor_horasextras.Text))
                txt_pagohorasextras.Text = Format(valor, "#.##")
            End If
        End If

        'calculo de subtotal
        SubtotalTextBox.Text = Val(txt_depreciacion.Text) + Val(txt_pagoferiado.Text) + Val(txt_pagohorasextras.Text) + Val(txt_pagohoras.Text) + Val(txt_vacaciones.Text) + Val(txt_septimo.Text) + Val(txt_bono.Text) + Val(txt_ajustes.Text)

        'calculo de deducciones
        txt_deducciones.Text = Val(UniformeTextBox.Text) + Val(IhssTextBox.Text) + Val(RapTextBox.Text) + Val(AdelantoTextBox.Text) + Val(txt_anticipo.Text) + Val(txtOtraDeduccion.Text)

        TotalapagarTextBox.Text = Val(SubtotalTextBox.Text) - Val(txt_deducciones.Text)

        txtsaldopres.Text = Val(txtprestamo.Text) - Val(AdelantoTextBox.Text)
        txt_saluniforme.Text = Val(txt_uniforme.Text) - Val(UniformeTextBox.Text)

    End Sub

    Private Sub UniformeTextBox_TextChanged(sender As Object, e As EventArgs) Handles UniformeTextBox.TextChanged
        If Val(UniformeTextBox.Text) > Val(txt_uniforme.Text) Then
            txt_saluniforme.Text = 0
        End If
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LlenarPagos()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LlenarPagos()
    End Sub

    Private Sub PagosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PagosDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = PagosDataGridView.Rows(index)

            lblpago.Text = selectedRow.Cells(0).Value.ToString
            lblfecha.Text = selectedRow.Cells(2).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(3).Value.ToString
            Salariobase.Text = selectedRow.Cells(4).Value.ToString
            txt_bhoras.Text = selectedRow.Cells(5).Value.ToString
            txt_depreciacion.Text = selectedRow.Cells(6).Value.ToString
            txt_bono.Text = selectedRow.Cells(7).Value.ToString
            horas_septimo.Text = selectedRow.Cells(8).Value.ToString
            txt_septimo.Text = selectedRow.Cells(9).Value.ToString
            txt_hferiado.Text = selectedRow.Cells(10).Value.ToString
            txt_pagoferiado.Text = selectedRow.Cells(11).Value.ToString
            DialibreTextBox.Text = selectedRow.Cells(12).Value.ToString
            Dias_Trabajados.Text = selectedRow.Cells(13).Value.ToString
            Horas_Trabajadas.Text = selectedRow.Cells(14).Value.ToString
            txt_pagohoras.Text = selectedRow.Cells(15).Value.ToString
            Horasextras_trabajadas.Text = selectedRow.Cells(16).Value.ToString
            valor_horasextras.Text = selectedRow.Cells(17).Value.ToString
            txt_pagohorasextras.Text = selectedRow.Cells(18).Value.ToString
            txt_vacaciones.Text = selectedRow.Cells(19).Value.ToString
            txt_ajustes.Text = selectedRow.Cells(20).Value.ToString
            txtprestamo.Text = selectedRow.Cells(21).Value.ToString
            AdelantoTextBox.Text = selectedRow.Cells(22).Value.ToString
            txtsaldopres.Text = selectedRow.Cells(23).Value.ToString
            txt_uniforme.Text = selectedRow.Cells(24).Value.ToString
            UniformeTextBox.Text = selectedRow.Cells(25).Value.ToString
            txt_saluniforme.Text = selectedRow.Cells(26).Value.ToString
            IhssTextBox.Text = selectedRow.Cells(27).Value.ToString
            RapTextBox.Text = selectedRow.Cells(28).Value.ToString
            txt_anticipo.Text = selectedRow.Cells(29).Value.ToString
            SubtotalTextBox.Text = selectedRow.Cells(30).Value.ToString
            txt_deducciones.Text = selectedRow.Cells(31).Value.ToString
            TotalapagarTextBox.Text = selectedRow.Cells(32).Value.ToString
            DateTimePicker3.Value = selectedRow.Cells(33).Value.ToString
            txt_comentario.Text = selectedRow.Cells(34).Value.ToString
            txtOtraDeduccion.Text = selectedRow.Cells(36).Value
        Catch ex As Exception

        End Try

        If txtprestamo.Text = 0 Then
            txtprestamo.ReadOnly = False
        Else
            txtprestamo.ReadOnly = True
        End If

        If txt_uniforme.Text = 0 Then
            txt_uniforme.ReadOnly = False
        Else
            txt_uniforme.ReadOnly = True
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If CodigoTextBox.Text = "" Then
                MessageBox.Show("Se debe agregar un codigo para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Txt_NuevoPestamo.Text = "" Then
                MessageBox.Show("Se debe agregar un prestamo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Rango1 = "Gerencia" Then
                    txtprestamo.Text = Val(txtprestamo.Text) + Val(Txt_NuevoPestamo.Text)
                    MsgBox("Prestamo Actualizado")
                Else
                    MessageBox.Show("Los datos no son los correctos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtbusqueda.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class