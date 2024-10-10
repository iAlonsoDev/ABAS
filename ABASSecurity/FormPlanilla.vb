
Imports System.Data.SqlClient


Public Class FormPlanilla
    ReadOnly obj As New ClaseBusquedasDinamicas
    Private cantunifome, idforma, iddevo, cantrembolso, cantcarnet As String

    Private Sub FormPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlanilla()
    End Sub

    Sub LoadPlanilla()
        obj.Llamadgv(EmpleadosDataGridView)
        DateTimePicker3.Text = "2000-01-01"
        panelempleados.Visible = False

        Panel1.Visible = False

        DiasTextBox.ReadOnly = True
        ComboBox1.SelectedItem = "Codigo de Empleado"

        'obj.llenardgvasignaciones(CodigoTextBox.Text, AsignacionesDataGridView)
        Limpiar()
        Cargarmes()
        HorasextrasTextBox.Text = "0  :0 :0 "
        txt_pextras.Text = 0

        msj.Text = "*Advertencia: Se debe seleccionar los rangos entre fechas antes de realizar un pago!"

        If ClasePrivilegios.Rango1 = "Gerencia" Then
            ReportesGerencia.Enabled = True
            Button3.Enabled = True
        Else
            ReportesGerencia.Enabled = False
            Button3.Enabled = False
        End If


        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        EstadoComboBox.SelectedItem = "Pendiente"
        Panel3.Visible = False
    End Sub


    Sub Cargarmes()
        MESINICIAL.Text = DateTimePicker1.Value.Month
        MESFINAL.Text = DateTimePicker2.Value.Month

        FECHAINICIAL.Text = DateTimePicker1.Value.Day
        FECHAFINAL.Text = DateTimePicker2.Value.Day
    End Sub

    Sub Preciodehoras()
        Dim phoras As Integer
        If HorasTextBox.Text <> "" Then
            phoras = (Val(SalarioTextBox.Text) / Val(txt_bhoras.Text)) * Val(HorasTextBox.Text)
            txt_phoras.Text = phoras
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

    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscarEmpleado.Click
        If panelempleados.Visible = False Then
            panelempleados.Visible = True
            txtbusqueda.Focus()
            Limpiar()
        Else
            panelempleados.Visible = False
        End If
    End Sub


    Private Sub Llenarinfo()

        Validarpago()

        sql = "select * from Asignaciones where fecha between '" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'  And Codigo = '" + CodigoTextBox.Text + "' and estado = 'No Pagada' and not fecha like '%31%'"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            AsignacionesDataGridView.DataSource = dt
        Finally
            cn.Close()
        End Try

        Cargarmes()
        Llenardias()
        Llenarturno()
        Llenardias()

        Llenarhorasturno()

        Llenarextras()
        Preciodehoras()
        Precio.Focus()

        Dim valorte As Integer = (Val(SalarioTextBox.Text) / 15) * Val(txt_turnoextra.Text)

        txt_valorturnoextra.Text = valorte

        If txt_turnoextra.Text = 0 Then
            txt_valorturnoextra.Text = 0
        End If

        panelempleados.Visible = False

        'por si el empleado cambio de planilla
        BuscarAsignacionesPagadas()
        Jornada()
        Calcular()


        If txt_turnoextra.Text >= 1 Then
            MessageBox.Show("El empleado realizo " + txt_turnoextra.Text + " turno extra", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Sub Jornada()
        If HorasTextBox.Text <> "" Then


            If txtturno.Text = "Mixto" Then
                If HorasTextBox.Text >= 156 And DiasTextBox.Text >= 15 Then
                    txtJornada.Text = "Completa"
                Else
                    txtJornada.Text = "No completa"
                End If

            ElseIf txt_bhoras.Text = 180 And txtturno.Text = "Diurno" Then
                If HorasTextBox.Text >= 156 And DiasTextBox.Text >= 13 Then
                    txtJornada.Text = "Completa"
                Else
                    txtJornada.Text = "No completa"
                End If

            ElseIf txtturno.Text = "Nocturno" Then

                If HorasTextBox.Text >= 156 And DiasTextBox.Text >= 13 Then
                    txtJornada.Text = "Completa"
                Else
                    txtJornada.Text = "No completa"
                End If

            ElseIf txt_bhoras.Text = 120 And txtturno.Text = "Diurno" Then
                If HorasTextBox.Text >= 104 And DiasTextBox.Text >= 13 Then
                    txtJornada.Text = "Completa"
                Else
                    txtJornada.Text = "No completa"
                End If

            End If


        End If
    End Sub

    Sub BuscarAsignacionesPagadas()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select * from Asignaciones where codigo = '" + CodigoTextBox.Text + "' and fecha >= '" + DateTimePicker1.Value + "' and fecha <= '" + DateTimePicker2.Value + "' and estado = 'Pagada'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            MsgBox("Se encontraron asignaciones pagadas, el empleado cambio de planilla", MsgBoxStyle.Exclamation, "Cerrar")
        End If

        dr.Close()
        cn.Close()
    End Sub

    Private Sub FechaDateTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If CodigoTextBox.Text <> "" Then
            Llenarinfo()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If CodigoTextBox.Text <> "" Then
            Llenarinfo()
        End If
    End Sub

    Private Sub CodigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodigoTextBox.TextChanged
        If CodigoTextBox.Text <> "" Then

            ''VALIDACION DE COBROS AL MOMENTO DE ENTREGAR UNIFORMES DE LA NUEVA FORMA
            cn.Open()
            cmd = New SqlCommand("DECLARE @cant as int
                                Set @cant = (SELECT max(dbo.FormaPago.cantidad)
                                FROM        dbo.SolicitudUniforme INNER JOIN
                                            dbo.Empleados ON dbo.SolicitudUniforme.codigo = dbo.Empleados.codigo INNER JOIN
                                            dbo.FormaPago ON dbo.SolicitudUniforme.idsolicitud = dbo.FormaPago.idsolicitud
                                WHERE dbo.FormaPago.estado = 'Pendiente' AND dbo.Empleados.codigo = '" + CodigoTextBox.Text + "')

                                SELECT        dbo.Empleados.codigo, dbo.SolicitudUniforme.idsolicitud, dbo.SolicitudUniforme.fecha
                                                , dbo.FormaPago.idformapago, dbo.FormaPago.veces, dbo.FormaPago.cantidad, dbo.FormaPago.estado
                                FROM            dbo.SolicitudUniforme INNER JOIN
                                                dbo.Empleados ON dbo.SolicitudUniforme.codigo = dbo.Empleados.codigo INNER JOIN
                                                dbo.FormaPago ON dbo.SolicitudUniforme.idsolicitud = dbo.FormaPago.idsolicitud
                                WHERE dbo.FormaPago.cantidad = @cant AND dbo.FormaPago.estado = 'Pendiente' AND dbo.Empleados.codigo = '" + CodigoTextBox.Text + "'", cn) With {
                .CommandType = CommandType.Text,
                .Connection = cn
            }
            dr = cmd.ExecuteReader()

            If dr.Read Then
                cantunifome = dr.Item("cantidad")
                idforma = dr.Item("idformapago")
                MessageBox.Show("Se entrego uniforme al empleado
" & "La cantidad es: " + cantunifome + " Lps esta sera agregada en el campo de uniforme y se descontara de las formas de pago")
            Else
            End If
            dr.Close()
            cn.Close()


            ''Valida el rembolso
            cn.Open()
            cmd = New SqlCommand("SELECT TOP(1) [iddevolucion], [rembolso] 
                                 FROM [ABAS].[dbo].[DevolucionUniforme] 
                                 WHERE [codigo] = '" + CodigoTextBox.Text + "'
                                 AND [estado] = 'Pendiente'
                                 ORDER BY [fecha] DESC", cn) With {
                .CommandType = CommandType.Text,
                .Connection = cn
            }
            dr = cmd.ExecuteReader()

            If dr.Read Then
                iddevo = dr.Item("iddevolucion")
                cantrembolso = dr.Item("rembolso")
                MessageBox.Show("El empleado devolvio uniforme aplica rembolso
" & "La cantidad es: " + cantrembolso + " Lps esta sera agregada en el campo de ajuste")
                txt_ajustes.Text = cantrembolso
            Else
            End If
            dr.Close()
            cn.Close()


            ''Valida el cobros resagados de uniformes
            cn.Open()
            cmd = New SqlCommand("Select top 1 * From Pagos Where codigo ='" + CodigoTextBox.Text + "'", cn) With {
                .CommandType = CommandType.Text,
                .Connection = cn
            }
            dr = cmd.ExecuteReader()

            If dr.Read Then
                txtprestamo.Text = dr.Item("saldoact")
                txt_uniforme.Text = dr.Item("uniformeact") + Val(cantunifome)
            Else
                txt_uniforme.Text = Val(cantunifome)
            End If
            dr.Close()
            cn.Close()

            ''Valida el cobros de anticipos
            cn.Open()
            cmd = New SqlCommand("SELECT SUM(cantidad) as cantidad, codigo FROM ANTICIPOS WHERE codigo= '" + CodigoTextBox.Text + "' and fecha>='" + DateTimePicker1.Value + "' and fecha<='" + DateTimePicker2.Value + "' and estado='Pendiente' group by codigo ", cn) With {
                .CommandType = CommandType.Text,
                .Connection = cn
            }
            dr = cmd.ExecuteReader()

            If dr.Read Then
                txt_anticipo.Text = dr.Item("cantidad")
                'DateTimePicker3.Value = reader.Item("fecha")
            End If
            dr.Close()
            cn.Close()

            ''VALIDACION DE COBROS DE CARNET
            cn.Open()
            cmd = New SqlCommand("SELECT [Precio]
                                      FROM [ABAS].[dbo].[RegistroCarnet]
                                     WHERE Codigo = (Select identidad from Empleados where codigo = '" + CodigoTextBox.Text + "')
                                     AND Estado = 'Cobro'", cn) With {
                .CommandType = CommandType.Text,
                .Connection = cn
            }
            dr = cmd.ExecuteReader()

            If dr.Read Then
                cantcarnet = dr.Item("Precio")
                txtOtraDeduccion.Text = Val(txtOtraDeduccion.Text) + dr.Item("Precio")
                MessageBox.Show("Se entrego carnet al empleado
" & "La cantidad es: " + cantcarnet + " Lps esta sera agregada en el campo otra deduccion")
            Else
            End If
            dr.Close()
            cn.Close()


            If txtprestamo.Text = 0 Then
                txtprestamo.ReadOnly = False
            End If
            If txt_uniforme.Text = 0 Then
                txt_uniforme.ReadOnly = False
            End If

            obj.Llenardgvasignaciones(CodigoTextBox.Text, AsignacionesDataGridView)
        End If
    End Sub

    Sub CambiarEstadoDeFormaPago()

        If idforma <> "" Then
            sql = "DECLARE @veces int
              set @veces = (select (veces - 1) as veces From FormaPago where idformapago = '" + idforma + "')

              if @veces >= 1
	              UPDATE [ABAS].[dbo].[FormaPago] SET Estado = 'Pendiente', veces = @veces
	              WHERE idformapago = '" + idforma + "'
              else
	              UPDATE [ABAS].[dbo].[FormaPago] SET Estado = 'Pagado', veces = @veces
	              WHERE idformapago = '" + idforma + "'"
            Ejecutar(sql)
        End If

    End Sub

    Sub Calcular()
        Cargar()
        Cargarmes()
        Dim valor As Integer

        'calculo de horas feriadas eliminando los decimales
        If txt_hferiado.Text > 0 Then
            Dim txt_pagofe As Integer
            txt_pagofe = (Val(SalarioTextBox.Text) / Val(txt_bhoras.Text)) * Val(txt_hferiado.Text)
            txt_pagoferiado.Text = txt_pagofe
        End If

        If Precio.Text = 0 Then
            txt_pextras.Text = 0
        Else
            'Calculo de horas extras
            If HorasextrasTextBox.Text <> "" Then
                HorasextrasTextBox.SelectionStart = 0
                HorasextrasTextBox.SelectionLength = 3
                Dim h As Integer
                h = (HorasextrasTextBox.SelectedText)

                HorasextrasTextBox.SelectionStart = 4
                HorasextrasTextBox.SelectionLength = 2
                Dim m As Integer
                m = (HorasextrasTextBox.SelectedText)
                valor = (h * Val(Precio.Text)) + ((m / 60) * Val(Precio.Text))
                txt_pextras.Text = Format(valor, "#.##")
            End If
        End If

        'calculo de subtotal
        SubtotalTextBox.Text = Val(txt_depreciacion.Text) + Val(txt_pagoferiado.Text) + Val(txt_pextras.Text) + Val(txt_phoras.Text) + Val(txt_vacaciones.Text) + Val(txt_septimo.Text) + Val(txt_bono.Text) + Val(txt_ajustes.Text)

        'calculo de deducciones
        txt_deducciones.Text = Val(UniformeTextBox.Text) + Val(IhssTextBox.Text) + Val(RapTextBox.Text) + Val(AdelantoTextBox.Text) + Val(txt_anticipo.Text) + Val(txtOtraDeduccion.Text)

        TotalapagarTextBox.Text = Val(SubtotalTextBox.Text) - Val(txt_deducciones.Text)

        txtsaldopres.Text = Val(txtprestamo.Text) - Val(AdelantoTextBox.Text)
        txt_saluniforme.Text = Val(txt_uniforme.Text) - Val(UniformeTextBox.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdCalcular.Click
        If HorasextrasTextBox.Text <> "0  :0 :0 " And Precio.Text = 0 Then
            MsgBox("Debe colocar el valor de las horas extras")
        Else
            Calcular()
        End If
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Desea guardar el pago!", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If CodigoTextBox.Text = "" Then
                MessageBox.Show("Seleccione el codigo del empleado")
            Else
                sql = "insert into Pagos values('" + CodigoTextBox.Text + "',
            '" + DateTimePicker2.Value + "',
            '" + SalarioTextBox.Text + "',
            '" + DiasTextBox.Text + "',
            '" + SubtotalTextBox.Text + "',
            '" + HorasextrasTextBox.Text + "',
            '" + txt_turnoextra.Text + "',
            '" + txt_vacaciones.Text + "',
            '" + IhssTextBox.Text + "',
            '" + RapTextBox.Text + "',
            '" + AdelantoTextBox.Text + "',
            '" + UniformeTextBox.Text + "',
            '" + TotalapagarTextBox.Text + "',
            '" + txt_ajustes.Text + "',
            '" + EstadoTextBox1.Text + "',
            '" + DateTimePicker1.Value + "',
            '" + HorasTextBox.Text + "',
            '" + txt_pextras.Text + "',
            '" + txt_phoras.Text + "',
            '" + txtprestamo.Text + "',
            '" + txtsaldopres.Text + "',
            '" + txt_bono.Text + "',
            '" + horassep.Text + "',
            '" + txt_septimo.Text + "',
            '" + Precio.Text + "',
            '" + txt_uniforme.Text + "',
            '" + txt_saluniforme.Text + "',
            '" + txt_hferiado.Text + "',
            '" + txt_pagoferiado.Text + "',
            '" + txt_anticipo.Text + "',
            '" + txt_deducciones.Text + "',
            '" + DateTimePicker3.Value + "',
            '" + txt_bhoras.Text + "',
            '" + txt_comentario.Text + "',
            '" + txt_depreciacion.Text + "',
            '" + Usuario + "',
            '" + txtOtraDeduccion.Text + "',
            '" + txtJornada.Text + "')"
                Ejecutar(sql)

                If txt_anticipo.Text > 0 Then
                    sql = "update Anticipos set estado ='Pagado' where codigo = '" + CodigoTextBox.Text + "' and fecha>='" + DateTimePicker1.Value + "' and fecha<='" + DateTimePicker2.Value + "'"
                    Ejecutar(sql)

                    sql = "update Pagos set fechaanticipo ='" + DateTimePicker3.Value + "' where codigo = '" + CodigoTextBox.Text + "' and desde = '" + DateTimePicker1.Value + "' and fechadepago='" + DateTimePicker2.Value + "'"
                    Ejecutar(sql)
                End If
                Pagar_asignaciones()

                CambiarEstadoDeFormaPago()

                CobrarCarnet()

                Limpiar()
            End If
            MsgBox("¡Pago registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            DateTimePicker3.Value = "2000-01-01 00:00"
        End If
    End Sub

    Sub CobrarCarnet()

        cn.Open()
        cmd = New SqlCommand("SELECT [Precio]
                                      FROM [ABAS].[dbo].[RegistroCarnet]
                                     WHERE Codigo = (Select identidad from Empleados where codigo = '" + CodigoTextBox.Text + "')
                                     AND Estado = 'Cobro'", cn) With {
                .CommandType = CommandType.Text,
                .Connection = cn
            }
        dr = cmd.ExecuteReader()

        If dr.Read Then
            sql = "UPDATE [dbo].[RegistroCarnet]
                       SET [Estado] = 'Cobrado'
                          ,[Fecha] = GETDATE()
                          ,[Observacion] = 'Se ha realizado una deduccion de planilla'
                          ,[Precio] = 0
                     WHERE [Codigo] = (Select identidad from Empleados where codigo = '" + CodigoTextBox.Text + "')"
            Ejecutar(sql)
        End If
        dr.Close()
        cn.Close()

    End Sub

    Sub Validarpago()
        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "Select fechadepago from Pagos, Empleados where Empleados.codigo = Pagos.codigo And Pagos.codigo = '" + CodigoTextBox.Text + "' and Pagos.fechadepago = '" + DateTimePicker2.Text + "'"
        cmd.CommandText = sql

        If CodigoTextBox.Text = "" Then
            MessageBox.Show("Debe seleccionar un codigo de empleado")
            CodigoTextBox.Select()
        ElseIf TotalapagarTextBox.Text = "" Then
            MessageBox.Show("No realizo el calculo de pago, este registro debe contener el total a pagar del empleado")
        Else
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MessageBox.Show("Ya se realizo un pago a este empleado")
                Limpiar()
            End If
        End If

        dr.Close()
        cn.Close()
    End Sub

    Private Sub GenerarUnVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarUnVoucherToolStripMenuItem.Click
        R_Boucher.ShowDialog()
    End Sub

    Private Sub AsignacionesDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionesDeEmpleadoToolStripMenuItem.Click
        R_AsignacionporCodigo.ShowDialog()
    End Sub

    Private Sub PagosPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosPorFechaToolStripMenuItem.Click
        R_Planilla.ShowDialog()
    End Sub


    Sub Llenarturno()
        cmd = New SqlCommand("select top 1 (turno) from asignaciones where codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Value + "' and fecha <= '" + DateTimePicker2.Value + "'", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            txtturno.Text = dr.Item("turno").ToString
            cn.Close()
        Else
            cn.Close()
        End If
    End Sub


    Sub Llenarhorasturno()

        ''Bisiesto turno mixto
        If txtturno.Text = "Mixto" And Bisiesto.Checked = True Then
            BisiestoMixto()
        Else
            ''Bisiesto turnos normales
            If Bisiesto.Checked = True Then
                BisiestoNormal()
            Else
                ''Febrero con 29
                If MESINICIAL.Text = 2 And MESFINAL.Text = 2 And FECHAINICIAL.Text = 16 And FECHAFINAL.Text = 29 Then
                    Febrero29()
                Else
                    ''Febrero con 28
                    If MESINICIAL.Text = 2 And MESFINAL.Text = 2 And FECHAINICIAL.Text = 16 And FECHAFINAL.Text = 28 Then
                        Febrero28()
                    Else
                        ''Febrero y marzo
                        If MESINICIAL.Text = 2 And MESFINAL.Text = 3 Then
                            Febrero28yMarzo()
                        Else
                            ''Turnos Normales
                            If txtturno.Text = "Diurno" Or txtturno.Text = "Nocturno" Then
                                Normal()
                            Else
                                Mixto()
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub


    Sub Normal()
        cn.Open()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, horas))*60 + DATEPART(MI, CONVERT(time, horas)))*60+ DATEPART(SS, CONVERT(time, horas)))/60/60 as horas
        from Asignaciones where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Text + "' and fecha<= '" + DateTimePicker2.Text + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()

        Dim horasdias As Integer
        horasdias = txt_bhoras.Text / 15

        If dr.Read() Then
            If DiasTextBox.Text >= 13 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = horasdias * 2
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado trabajo su jornada normal"
            ElseIf DiasTextBox.Text = 12 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio uno de sus septimos"
            ElseIf DiasTextBox.Text = 11 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 10 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 9 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 8 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 7 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 6 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 5 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 4 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 3 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 2 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 1 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            End If
        Else
        End If

        dr.Close()
        cn.Close()

    End Sub

    Sub Febrero28yMarzo()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, horas))*60 + DATEPART(MI, CONVERT(time, horas)))*60+ DATEPART(SS, CONVERT(time, horas)))/60/60 as horas
        from Asignaciones where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Value + "' and fecha<= '" + DateTimePicker2.Value + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        Dim horasdias As Integer
        horasdias = txt_bhoras.Text / 15
        If dr.Read() Then
            If DiasTextBox.Text >= 13 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = horasdias * 2
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "Se añadieron turnos al empleado para completar el mes febrero"
            ElseIf DiasTextBox.Text = 12 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado pierde derecho RRHH un septimo"
            ElseIf DiasTextBox.Text = 11 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 10 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 9 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 8 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 7 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 6 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 5 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 4 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 3 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 2 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 1 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            End If
            dr.Close()
            cn.Close()
        Else
            dr.Close()
            cn.Close()
        End If
    End Sub
    Sub Febrero28()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, horas))*60 + DATEPART(MI, CONVERT(time, horas)))*60+ DATEPART(SS, CONVERT(time, horas)))/60/60 as horas
        from Asignaciones where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Value + "' and fecha<= '" + DateTimePicker2.Value + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        Dim horasdias As Integer
        horasdias = txt_bhoras.Text / 15
        If dr.Read() Then
            If DiasTextBox.Text >= 13 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = horasdias * 2
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "Se añadieron turnos al empleado para completar el mes febrero"
            ElseIf DiasTextBox.Text = 12 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado pierde derecho RRHH un septimo"
            ElseIf DiasTextBox.Text = 11 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 10 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 9 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 8 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 7 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 6 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 5 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 4 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 3 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 2 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 1 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + (horasdias * 2)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            End If
            dr.Close()
            cn.Close()
        Else
            dr.Close()
            cn.Close()
        End If
    End Sub

    Sub Febrero29()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, horas))*60 + DATEPART(MI, CONVERT(time, horas)))*60+ DATEPART(SS, CONVERT(time, horas)))/60/60 as horas
        from Asignaciones where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Value + "' and fecha<= '" + DateTimePicker2.Value + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        Dim horasdias As Integer
        horasdias = txt_bhoras.Text / 15
        If dr.Read() Then
            If DiasTextBox.Text >= 13 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = horasdias * 2
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "Se añadieron turnos al empleado para completar el mes febrero"
            ElseIf DiasTextBox.Text = 12 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado pierde derecho RRHH un septimo"
            ElseIf DiasTextBox.Text = 11 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 10 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 9 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 8 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 7 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 6 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 5 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 4 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 3 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 2 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 1 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            End If
            dr.Close()
            cn.Close()
        Else
            dr.Close()
            cn.Close()
        End If
    End Sub

    Sub BisiestoMixto()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, horas))*60 + DATEPART(MI, CONVERT(time, horas)))*60+ DATEPART(SS, CONVERT(time, horas)))/60/60 as horas
        from Asignaciones where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Value + "' and fecha<= '" + DateTimePicker2.Value + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        Dim horasdias As Integer
        horasdias = txt_bhoras.Text / 15
        If dr.Read() Then

            If DiasTextBox.Text >= 13 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = horasdias * 2
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "Se añadieron turnos al empleado para completar el mes febrero"
            ElseIf DiasTextBox.Text = 12 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El emepleado pierde derecho RRHH un septimo"
            ElseIf DiasTextBox.Text = 11 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 10 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 9 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 8 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 7 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 6 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 5 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 4 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 3 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 2 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 1 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            End If
            dr.Close()
            cn.Close()
        Else
            dr.Close()
            cn.Close()
        End If
    End Sub

    Sub BisiestoNormal()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, horas))*60 + DATEPART(MI, CONVERT(time, horas)))*60+ DATEPART(SS, CONVERT(time, horas)))/60/60 as horas
        from Asignaciones where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Value + "' and fecha<= '" + DateTimePicker2.Value + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()

        Dim horasdias As Integer
        horasdias = txt_bhoras.Text / 15

        If dr.Read() Then
            If DiasTextBox.Text >= 13 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = horasdias * 2
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "Se añadieron turnos al empleado para completar el mes febrero"
            ElseIf DiasTextBox.Text = 12 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El emepleado pierde derecho RRHH un septimo"
            ElseIf DiasTextBox.Text = 11 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 10 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 9 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 8 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 7 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 6 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 5 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 4 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 3 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 2 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            ElseIf DiasTextBox.Text = 1 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) + horasdias
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "el empleado perdio derecho RRHH sus dos septimos"
            End If
            dr.Close()
            cn.Close()
        Else
            dr.Close()
            cn.Close()
        End If
    End Sub


    Sub Mixto()
        cmd = New SqlCommand("select sum((DATEPART(HH, CONVERT(time, horas))*60 + DATEPART(MI, CONVERT(time, horas)))*60+ DATEPART(SS, CONVERT(time, horas)))/60/60 as horas
        from Asignaciones where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Text + "' and fecha<= '" + DateTimePicker2.Text + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()

        Dim horasdias As Integer
        horasdias = txt_bhoras.Text / 15

        If dr.Read() Then
            If DiasTextBox.Text = 15 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) - 24
                horassep.Text = horasdias * 2
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado trabajo su jornada normal"
            ElseIf DiasTextBox.Text = 14 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString) - 12
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio uno de sus septimos"
            ElseIf DiasTextBox.Text = 13 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 12 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = horasdias
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio uno de sus septimos"
            ElseIf DiasTextBox.Text = 11 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 10 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 9 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 8 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 7 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 6 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 5 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 4 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 3 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 2 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            ElseIf DiasTextBox.Text = 1 Then
                HorasTextBox.Text = Val(dr.Item("horas").ToString)
                horassep.Text = 0
                Dim sep As Integer
                sep = (SalarioTextBox.Text / txt_bhoras.Text) * Val(horassep.Text)
                txt_septimo.Text = sep
                msj.Text = "El Empleado perdio sus dos septimos"
            End If
            dr.Close()
            cn.Close()
        Else
            dr.Close()
            cn.Close()
        End If
    End Sub


    Sub Llenarextras()
        cmd = New SqlCommand("SELECT (CONVERT(CHAR(3), SUM(DATEPART(MINUTE, horasextras)) / 60 + SUM(DATEPART(HOUR, horasextras))) + ':' + CONVERT(CHAR(2), SUM(DATEPART(MINUTE, horasextras)) % 60) + ':' + CONVERT(CHAR(2), SUM(DATEPART(SECOND, horasextras)) % 60)) as horasextras
        FROM Asignaciones
        where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Text + "' and fecha<= '" + DateTimePicker2.Text + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Close()
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            HorasextrasTextBox.Text = dr.Item("horasextras").ToString
        Else
        End If

        dr.Close()
        cn.Close()
    End Sub

    Sub Llenardias()
        cmd = New SqlCommand("Select count(codigo) as dias from Asignaciones
        where Codigo = '" + CodigoTextBox.Text + "' and fecha>= '" + DateTimePicker1.Text + "' and fecha<= '" + DateTimePicker2.Text + "' and estado = 'No Pagada' and not fecha like '%31%'", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()

        dr = cmd.ExecuteReader()
        If dr.Read() Then

            '' BISIESTO Febrero con 29 y marzo (TURNOS NORMALES)
            If Bisiesto.Checked = True And txtturno.Text <> "Mixto" Then
                If dr.Item("dias") >= 16 Then
                    DiasTextBox.Text = 13
                    txt_turnoextra.Text = 2
                ElseIf dr.Item("dias") = 15 Then
                    DiasTextBox.Text = 13
                    txt_turnoextra.Text = 2
                ElseIf dr.Item("dias") = 14 Then
                    DiasTextBox.Text = 13
                    txt_turnoextra.Text = 2
                ElseIf dr.Item("dias") = 13 Then
                    DiasTextBox.Text = 13
                    txt_turnoextra.Text = 1
                ElseIf dr.Item("dias") = 12 Then
                    DiasTextBox.Text = 13
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 11 Then
                    DiasTextBox.Text = 12
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 10 Then
                    DiasTextBox.Text = 11
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 9 Then
                    DiasTextBox.Text = 10
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 8 Then
                    DiasTextBox.Text = 9
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 7 Then
                    DiasTextBox.Text = 8
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 6 Then
                    DiasTextBox.Text = 7
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 5 Then
                    DiasTextBox.Text = 6
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 4 Then
                    DiasTextBox.Text = 5
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 3 Then
                    DiasTextBox.Text = 4
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 2 Then
                    DiasTextBox.Text = 3
                    txt_turnoextra.Text = 0
                ElseIf dr.Item("dias") = 1 Then
                    DiasTextBox.Text = 2
                    txt_turnoextra.Text = 0
                End If

            Else

                ''BICISESTO Febrero con 29 y marzo (TURNOS MIXTOS)
                If Bisiesto.Checked = True And txtturno.Text = "mixto" Then
                    If dr.Item("dias") >= 17 Then
                        DiasTextBox.Text = 13
                        txt_turnoextra.Text = 2
                    ElseIf dr.Item("dias") = 16 Then
                        DiasTextBox.Text = 13
                        txt_turnoextra.Text = 1
                    ElseIf dr.Item("dias") = 15 Then
                        DiasTextBox.Text = 13
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 14 Then
                        DiasTextBox.Text = 13
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 13 Then
                        DiasTextBox.Text = 13
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 12 Then
                        DiasTextBox.Text = 13
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 11 Then
                        DiasTextBox.Text = 12
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 10 Then
                        DiasTextBox.Text = 11
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 9 Then
                        DiasTextBox.Text = 10
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 8 Then
                        DiasTextBox.Text = 9
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 7 Then
                        DiasTextBox.Text = 8
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 6 Then
                        DiasTextBox.Text = 7
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 5 Then
                        DiasTextBox.Text = 6
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 4 Then
                        DiasTextBox.Text = 5
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 3 Then
                        DiasTextBox.Text = 4
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 2 Then
                        DiasTextBox.Text = 3
                        txt_turnoextra.Text = 0
                    ElseIf dr.Item("dias") = 1 Then
                        DiasTextBox.Text = 2
                        txt_turnoextra.Text = 0
                    End If

                Else

                    ''FEBRERO 29  (TURNOS MIXTOS)
                    If MESINICIAL.Text = "2" And MESFINAL.Text = "2" And FECHAINICIAL.Text = "16" And FECHAFINAL.Text = "29" And txtturno.Text = "Mixto" Then
                        If dr.Item("dias") >= 16 Then
                            DiasTextBox.Text = 13
                            txt_turnoextra.Text = 2
                        ElseIf dr.Item("dias") = 15 Then
                            DiasTextBox.Text = 13
                            txt_turnoextra.Text = 1
                        ElseIf dr.Item("dias") = 14 Then
                            DiasTextBox.Text = 13
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 13 Then
                            DiasTextBox.Text = 13
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 12 Then
                            DiasTextBox.Text = 13
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 11 Then
                            DiasTextBox.Text = 12
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 10 Then
                            DiasTextBox.Text = 11
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 9 Then
                            DiasTextBox.Text = 10
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 8 Then
                            DiasTextBox.Text = 9
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 7 Then
                            DiasTextBox.Text = 8
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 6 Then
                            DiasTextBox.Text = 7
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 5 Then
                            DiasTextBox.Text = 6
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 4 Then
                            DiasTextBox.Text = 5
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 3 Then
                            DiasTextBox.Text = 4
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 2 Then
                            DiasTextBox.Text = 3
                            txt_turnoextra.Text = 0
                        ElseIf dr.Item("dias") = 1 Then
                            DiasTextBox.Text = 2
                            txt_turnoextra.Text = 0
                        End If

                    Else

                        ''FEBRERO 29 (TURNOS NORMALES)
                        If MESINICIAL.Text = "2" And MESFINAL.Text = "2" And FECHAINICIAL.Text = "16" And FECHAFINAL.Text = "29" Then
                            If dr.Item("dias") >= 15 Then
                                DiasTextBox.Text = 13
                                txt_turnoextra.Text = 2
                            ElseIf dr.Item("dias") = 14 Then
                                DiasTextBox.Text = 13
                                txt_turnoextra.Text = 2
                            ElseIf dr.Item("dias") = 13 Then
                                DiasTextBox.Text = 13
                                txt_turnoextra.Text = 1
                            ElseIf dr.Item("dias") = 12 Then
                                DiasTextBox.Text = 13
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 11 Then
                                DiasTextBox.Text = 12
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 10 Then
                                DiasTextBox.Text = 11
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 9 Then
                                DiasTextBox.Text = 10
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 8 Then
                                DiasTextBox.Text = 9
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 7 Then
                                DiasTextBox.Text = 8
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 6 Then
                                DiasTextBox.Text = 7
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 5 Then
                                DiasTextBox.Text = 6
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 4 Then
                                DiasTextBox.Text = 5
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 3 Then
                                DiasTextBox.Text = 4
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 2 Then
                                DiasTextBox.Text = 3
                                txt_turnoextra.Text = 0
                            ElseIf dr.Item("dias") = 1 Then
                                DiasTextBox.Text = 2
                                txt_turnoextra.Text = 0
                            End If

                        Else

                            ''FEBRERO 28 (TURNOS MIXTOS)
                            If MESINICIAL.Text = "2" And MESFINAL.Text = "2" And FECHAINICIAL.Text = "16" And FECHAFINAL.Text = "28" And txtturno.Text = "Mixto" Then
                                If dr.Item("dias") >= 15 Then
                                    DiasTextBox.Text = 13
                                    txt_turnoextra.Text = 2
                                ElseIf dr.Item("dias") = 14 Then
                                    DiasTextBox.Text = 13
                                    txt_turnoextra.Text = 1
                                ElseIf dr.Item("dias") = 13 Then
                                    DiasTextBox.Text = 13
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 12 Then
                                    DiasTextBox.Text = 13
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 11 Then
                                    DiasTextBox.Text = 13
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 10 Then
                                    DiasTextBox.Text = 12
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 9 Then
                                    DiasTextBox.Text = 11
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 8 Then
                                    DiasTextBox.Text = 10
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 7 Then
                                    DiasTextBox.Text = 9
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 6 Then
                                    DiasTextBox.Text = 8
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 5 Then
                                    DiasTextBox.Text = 7
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 4 Then
                                    DiasTextBox.Text = 6
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 3 Then
                                    DiasTextBox.Text = 5
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 2 Then
                                    DiasTextBox.Text = 4
                                    txt_turnoextra.Text = 0
                                ElseIf dr.Item("dias") = 1 Then
                                    DiasTextBox.Text = 3
                                    txt_turnoextra.Text = 0
                                End If

                            Else

                                ''FEBRERO 28 (TURNO NORMALES)

                                If MESINICIAL.Text = "2" And MESFINAL.Text = "2" And FECHAINICIAL.Text = "16" And FECHAFINAL.Text = "28" Then
                                    If dr.Item("dias") >= 13 Then
                                        DiasTextBox.Text = 13
                                        txt_turnoextra.Text = 2
                                    ElseIf dr.Item("dias") = 12 Then
                                        DiasTextBox.Text = 13
                                        txt_turnoextra.Text = 1
                                    ElseIf dr.Item("dias") = 11 Then
                                        DiasTextBox.Text = 13
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 10 Then
                                        DiasTextBox.Text = 12
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 9 Then
                                        DiasTextBox.Text = 11
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 8 Then
                                        DiasTextBox.Text = 10
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 7 Then
                                        DiasTextBox.Text = 9
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 6 Then
                                        DiasTextBox.Text = 8
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 5 Then
                                        DiasTextBox.Text = 7
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 4 Then
                                        DiasTextBox.Text = 6
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 3 Then
                                        DiasTextBox.Text = 5
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 2 Then
                                        DiasTextBox.Text = 4
                                        txt_turnoextra.Text = 0
                                    ElseIf dr.Item("dias") = 1 Then
                                        DiasTextBox.Text = 3
                                        txt_turnoextra.Text = 0
                                    End If

                                Else


                                    ''Febrero 28 y marzo (TURNOS MIXTOS)

                                    If MESINICIAL.Text = "2" And MESFINAL.Text = "3" And txtturno.Text = "Mixto" Then
                                        If dr.Item("dias") >= 15 Then
                                            DiasTextBox.Text = 13
                                            txt_turnoextra.Text = 2
                                        ElseIf dr.Item("dias") = 14 Then
                                            DiasTextBox.Text = 13
                                            txt_turnoextra.Text = 1
                                        ElseIf dr.Item("dias") = 13 Then
                                            DiasTextBox.Text = 13
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 12 Then
                                            DiasTextBox.Text = 13
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 11 Then
                                            DiasTextBox.Text = 13
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 10 Then
                                            DiasTextBox.Text = 12
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 9 Then
                                            DiasTextBox.Text = 11
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 8 Then
                                            DiasTextBox.Text = 10
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 7 Then
                                            DiasTextBox.Text = 9
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 6 Then
                                            DiasTextBox.Text = 8
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 5 Then
                                            DiasTextBox.Text = 7
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 4 Then
                                            DiasTextBox.Text = 6
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 3 Then
                                            DiasTextBox.Text = 5
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 2 Then
                                            DiasTextBox.Text = 4
                                            txt_turnoextra.Text = 0
                                        ElseIf dr.Item("dias") = 1 Then
                                            DiasTextBox.Text = 3
                                            txt_turnoextra.Text = 0
                                        End If
                                    Else



                                        ''Febrero 28 y marzo (TURNOS NORMALES)

                                        If MESINICIAL.Text = "2" And MESFINAL.Text = "3" Then
                                            If dr.Item("dias") >= 15 Then
                                                DiasTextBox.Text = 13
                                                txt_turnoextra.Text = 2
                                            ElseIf dr.Item("dias") = 14 Then
                                                DiasTextBox.Text = 13
                                                txt_turnoextra.Text = 2
                                            ElseIf dr.Item("dias") = 13 Then
                                                DiasTextBox.Text = 13
                                                txt_turnoextra.Text = 2
                                            ElseIf dr.Item("dias") = 12 Then
                                                DiasTextBox.Text = 13
                                                txt_turnoextra.Text = 1
                                            ElseIf dr.Item("dias") = 11 Then
                                                DiasTextBox.Text = 13
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 10 Then
                                                DiasTextBox.Text = 12
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 9 Then
                                                DiasTextBox.Text = 11
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 8 Then
                                                DiasTextBox.Text = 10
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 7 Then
                                                DiasTextBox.Text = 9
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 6 Then
                                                DiasTextBox.Text = 8
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 5 Then
                                                DiasTextBox.Text = 7
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 4 Then
                                                DiasTextBox.Text = 6
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 3 Then
                                                DiasTextBox.Text = 5
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 2 Then
                                                DiasTextBox.Text = 4
                                                txt_turnoextra.Text = 0
                                            ElseIf dr.Item("dias") = 1 Then
                                                DiasTextBox.Text = 3
                                                txt_turnoextra.Text = 0
                                            End If
                                        Else

                                            '' Meses normales con 30 o 31 dias (PARA TURNO MIXTO)

                                            If txtturno.Text = "Mixto" Then
                                                If dr.Item("dias") >= 17 Then
                                                    DiasTextBox.Text = 15
                                                    txt_turnoextra.Text = 2
                                                ElseIf dr.Item("dias") = 16 Then
                                                    DiasTextBox.Text = 15
                                                    txt_turnoextra.Text = 1
                                                ElseIf dr.Item("dias") = 15 Then
                                                    DiasTextBox.Text = 15
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 14 Then
                                                    DiasTextBox.Text = 14
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 13 Then
                                                    DiasTextBox.Text = 13
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 12 Then
                                                    DiasTextBox.Text = 12
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 11 Then
                                                    DiasTextBox.Text = 11
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 10 Then
                                                    DiasTextBox.Text = 10
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 9 Then
                                                    DiasTextBox.Text = 9
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 8 Then
                                                    DiasTextBox.Text = 8
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 7 Then
                                                    DiasTextBox.Text = 7
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 6 Then
                                                    DiasTextBox.Text = 6
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 5 Then
                                                    DiasTextBox.Text = 5
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 4 Then
                                                    DiasTextBox.Text = 4
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 3 Then
                                                    DiasTextBox.Text = 3
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 2 Then
                                                    DiasTextBox.Text = 2
                                                    txt_turnoextra.Text = 0
                                                ElseIf dr.Item("dias") = 1 Then
                                                    DiasTextBox.Text = 1
                                                    txt_turnoextra.Text = 0
                                                End If
                                            Else

                                                '' Meses normales con 30 o 31 dias (PARA TURNO NORMAL)

                                                If txtturno.Text = "Diurno" Or txtturno.Text = "Nocturno" Then
                                                    If dr.Item("dias") >= 16 Then
                                                        DiasTextBox.Text = dr.Item("dias")
                                                        txt_turnoextra.Text = 2
                                                    ElseIf dr.Item("dias") = 15 Then
                                                        DiasTextBox.Text = 13
                                                        txt_turnoextra.Text = 2
                                                    ElseIf dr.Item("dias") = 14 Then
                                                        DiasTextBox.Text = 13
                                                        txt_turnoextra.Text = 1
                                                    ElseIf dr.Item("dias") = 13 Then
                                                        DiasTextBox.Text = 13
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 12 Then
                                                        DiasTextBox.Text = 12
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 11 Then
                                                        DiasTextBox.Text = 11
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 10 Then
                                                        DiasTextBox.Text = 10
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 9 Then
                                                        DiasTextBox.Text = 9
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 8 Then
                                                        DiasTextBox.Text = 8
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 7 Then
                                                        DiasTextBox.Text = 7
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 6 Then
                                                        DiasTextBox.Text = 6
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 5 Then
                                                        DiasTextBox.Text = 5
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 4 Then
                                                        DiasTextBox.Text = 4
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 3 Then
                                                        DiasTextBox.Text = 3
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 2 Then
                                                        DiasTextBox.Text = 2
                                                        txt_turnoextra.Text = 0
                                                    ElseIf dr.Item("dias") = 1 Then
                                                        DiasTextBox.Text = 1
                                                        txt_turnoextra.Text = 0
                                                    End If

                                                Else

                                                    If txtturno.Text = "Comodin" Then
                                                        DiasTextBox.Text = dr.Item("dias")
                                                        txt_turnoextra.Text = 0
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
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Tipodebusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipodebusqueda.KeyPress
        e.Handled = True
    End Sub


    Sub Cargar()
        If DiasTextBox.Text = "" Then
            DiasTextBox.Text = 0
        End If
        If txt_turnoextra.Text = "" Then
            txt_turnoextra.Text = 0
        End If
        If txt_vacaciones.Text = "" Then
            txt_vacaciones.Text = 0
        End If
        If UniformeTextBox.Text = "" Then
            UniformeTextBox.Text = 0
        End If
        If IhssTextBox.Text = "" Then
            IhssTextBox.Text = 0
        End If
        If AdelantoTextBox.Text = "" Then
            AdelantoTextBox.Text = 0
        End If
        If RapTextBox.Text = "" Then
            RapTextBox.Text = 0
        End If
        If Precio.Text = "" Then
            txt_pextras.Text = 0
            Precio.Text = 0
        End If
        If txt_bono.Text = "" Then
            txt_bono.Text = 0
        End If
        If txt_ajustes.Text = "" Then
            txt_ajustes.Text = 0
        End If
        If txtprestamo.Text = "" Then
            txtprestamo.Text = 0
        End If
        If horassep.Text = "" Then
            horassep.Text = 0
        End If
        If txtOtraDeduccion.Text = "" Then
            txtOtraDeduccion.Text = 0
        End If
    End Sub



    Private Sub ReporteDeduccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeduccionesToolStripMenuItem.Click
        R_Deducciones.ShowDialog()
    End Sub


    Private Sub DiasTextBox_MouseLeave(sender As Object, e As EventArgs)
        If DiasTextBox.Text = "" Then
            DiasTextBox.Text = 0
        End If
    End Sub

    Private Sub DialibreTextBox_MouseLeave(sender As Object, e As EventArgs) Handles txt_turnoextra.MouseLeave
        If txt_turnoextra.Text = "" Then
            txt_turnoextra.Text = 0
        End If
    End Sub


    Private Sub VacacionesTextBox_MouseLeave(sender As Object, e As EventArgs)
        If txt_vacaciones.Text = "" Then
            txt_vacaciones.Text = 0
        End If
    End Sub

    Private Sub UniformeTextBox_MouseLeave(sender As Object, e As EventArgs)
        If UniformeTextBox.Text = "" Then
            UniformeTextBox.Text = 0
        End If
    End Sub

    Private Sub IhssTextBox_MouseLeave(sender As Object, e As EventArgs) Handles IhssTextBox.MouseLeave
        If IhssTextBox.Text = "" Then
            IhssTextBox.Text = 0
        End If
    End Sub

    Private Sub AdelantoTextBox_MouseLeave(sender As Object, e As EventArgs)
        If AdelantoTextBox.Text = "" Then
            AdelantoTextBox.Text = 0
        End If
    End Sub

    Private Sub RapTextBox_MouseLeave(sender As Object, e As EventArgs) Handles RapTextBox.MouseLeave
        If RapTextBox.Text = "" Then
            RapTextBox.Text = 0
        End If
    End Sub

    Private Sub CmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Limpiar()
    End Sub


    Private Sub AdelantoTextBox_TextChanged(sender As Object, e As EventArgs)
        If Val(AdelantoTextBox.Text) > Val(txtprestamo.Text) Then
            AdelantoTextBox.Clear()
        End If
    End Sub


    Private Sub BonosTextBox_MouseLeave(sender As Object, e As EventArgs) Handles txt_bono.MouseLeave
        If txt_bono.Text = "" Then
            txt_bono.Text = 0
        End If
    End Sub

    Private Sub AsignacionTextBox_MouseLeave(sender As Object, e As EventArgs)
        If txt_ajustes.Text = "" Then
            txt_ajustes.Text = 0
        End If
    End Sub


    Private Sub AsignacionPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionPorClienteToolStripMenuItem.Click
        R_AsignacionesporCliente.Show()
    End Sub

    Private Sub AsignacionesGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionesGeneralesToolStripMenuItem.Click
        R_AsignacionesGenerales.Show()
    End Sub

    Private Sub PlanillaDePagosPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillaDePagosPorUsuarioToolStripMenuItem.Click
        R_PlanillaUsuario.Show()
    End Sub

    Private Sub PlanillaDeDeduccionesPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillaDeDeduccionesPorUsuarioToolStripMenuItem.Click
        R_DeduccionesUsuario.Show()
    End Sub

    Private Sub CmdNuevoUniforme_Click(sender As Object, e As EventArgs) Handles cmdNuevoUniforme.Click
        If CodigoTextBox.Text = "" Then
            MessageBox.Show("Se debe agregar un codigo para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Txt_NuevoUniforme.Text = "" Then
            MessageBox.Show("Se debe agregar una cantidad", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Rango1 = "Gerencia" Then
                txt_uniforme.Text = Val(txt_uniforme.Text) + Val(Txt_NuevoUniforme.Text)
                MsgBox("Saldo de uniforme Actualizado")
            End If
        End If
    End Sub

    Private Sub Txtprestamo_MouseLeave(sender As Object, e As EventArgs) Handles txtprestamo.MouseLeave
        If txtprestamo.Text = "" Then
            txtprestamo.Text = 0
        End If
    End Sub

    Private Sub HistorialDeImpresionDeCarnetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeImpresionDeCarnetToolStripMenuItem.Click
        R_RegistroCarnet.Show()
    End Sub

    Private Sub DetalleDePlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDePlanillaToolStripMenuItem.Click
        R_DetalledePlanilla.Show()
    End Sub

    Private Sub DetalleDePlanillaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDePlanillaUsuarioToolStripMenuItem.Click
        R_DetallePlanilla_Usuario.Show()
    End Sub

    Private Sub Bisiesto_CheckedChanged(sender As Object, e As EventArgs) Handles Bisiesto.CheckedChanged
        MessageBox.Show("Esta opcion solo debe activarse en la planilla del 21 de febrero al 5 de marzo en año bisiesto!")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CodigoTextBox.Text <> "" Then
            If Rango1 = "Gerencia" Then

                If Panel1.Visible = True Then
                    Panel1.Visible = False
                Else
                    Panel1.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CmdCambiar_Click(sender As Object, e As EventArgs) Handles cmdCambiar.Click
        If MsgBox("¡Desea guardar un nuevo salario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If CodigoTextBox.Text = "" Then
                MessageBox.Show("Se debe agregar un codigo para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Txt_NuevoSalario.Text = "" Then
                MessageBox.Show("Se debe agregar un salario para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Rango1 = "Gerencia" Then
                sql = "update Empleados set salario ='" + Txt_NuevoSalario.Text + "' where Codigo = '" + CodigoTextBox.Text + "'"
                Ejecutar(sql)
                SalarioTextBox.Text = Txt_NuevoSalario.Text
            End If
            MsgBox("¡Nuevo salario registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CodigoTextBox.Text = "" Then
            MessageBox.Show("Se debe agregar un codigo para actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Txt_NuevoPrestamo.Text = "" Then
            MessageBox.Show("Se debe agregar un prestamo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Rango1 = "Gerencia" Then
                txtprestamo.Text = Val(txtprestamo.Text) + Val(Txt_NuevoPrestamo.Text)
                MsgBox("Prestamo Actualizado")
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        Panel1.Visible = False
    End Sub


    Sub Limpiar()
        DateTimePicker3.Value = "2000-01-01 00:00"
        CodigoTextBox.Clear()
        CodigoTextBox.Select()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        SalarioTextBox.Clear()
        txt_comentario.Clear()
        txtJornada.Clear()
        msj.Text = "*Advertencia: Se debe seleccionar los rangos entre fechas antes de realizar un pago!"

        HorasextrasTextBox.Clear()
        HorasTextBox.Clear()
        Precio.Text = 0
        txt_pextras.Text = 0
        txt_phoras.Text = 0
        txt_bhoras.Text = 0
        SalarioTextBox.Text = 0
        DiasTextBox.Text = 0
        txt_turnoextra.Text = 0
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

        horassep.Text = 0
        txt_septimo.Text = 0

        txt_deducciones.Text = 0
        txt_anticipo.Text = 0
        txt_hferiado.Text = 0
        txt_pagoferiado.Text = 0
        txt_saluniforme.Text = 0
        txt_uniforme.Text = 0
        txt_bono.Text = 0
        txt_depreciacion.Text = 0
        txtOtraDeduccion.Text = 0

        AsignacionesDataGridView.DataSource = vbNull
    End Sub

    Sub Pagar_asignaciones()
        If AsignacionesDataGridView.Rows.Count = 0 Then
            Return
        End If

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()
            cmd = New SqlCommand("select * from Pagos where codigo = '" + CodigoTextBox.Text + "' and desde= '" + DateTimePicker1.Value + "' and fechadepago <= '" + DateTimePicker2.Value + "'", cn) With {
                .CommandType = CommandType.Text
            }

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtIdPago.Text = Val(dr.Item("idpago").ToString)
                dr.Close()
            End If

            sql = "update asignaciones set estado ='Pagada', idpago='" + txtIdPago.Text + "' where codigo='" + CodigoTextBox.Text + "' and idasignacion = @idasignacion"
            cmd = New SqlCommand(sql, cn)
            Try
                For Each row As DataGridViewRow In AsignacionesDataGridView.Rows
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@idasignacion", Convert.ToString(row.Cells("idasignacion").Value))
                    cmd.ExecuteNonQuery()
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            cn.Close()
        End Using
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If ComboBox1.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & TextBox2.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If

        If ComboBox1.SelectedItem.ToString = "Nombre" Then
            obj.BusquedaNombre(TextBox2.Text, DataGridView1)
        End If


        If ComboBox1.SelectedItem.ToString = "Identidad" Then
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
            obj.BusquedaIdentidad(TextBox2.Text, DataGridView1)
        End If

        If ComboBox1.SelectedItem.ToString = "Ubicacion" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and ubicacion like '" & TextBox2.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If

        If ComboBox1.SelectedItem.ToString = "Planilla" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and planilla like '" & TextBox2.Text + "%" & "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If

        If TextBox2.Text = "" Then
            LimpiarAnticipo()
            EmpleadosDataGridView.DataSource = vbNull
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)

            TextBox1.Text = selectedRow.Cells(0).Value.ToString
            TextBox4.Text = selectedRow.Cells(1).Value.ToString
            TextBox5.Text = selectedRow.Cells(2).Value.ToString
            TextBox3.Text = selectedRow.Cells(3).Value.ToString
            TextBox6.Text = selectedRow.Cells(4).Value.ToString
            TextBox7.Text = selectedRow.Cells(5).Value.ToString
            TextBox8.Text = selectedRow.Cells(6).Value.ToString
            FechadeingresoDateTimePicker.Value = selectedRow.Cells(7).Value.ToString
        Catch ex As Exception

        End Try
        Panel3.Visible = False
    End Sub

    Private Sub CmdGuardar_Click_1(sender As Object, e As EventArgs)
        If MsgBox("¡Desea guardar el anticipo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("¡Seleccione un codigo para asignar anticipo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "insert into anticipos values('" + TextBox1.Text + "',
                                                       '" + fechaanticipo.Value + "',
                                                       '" + CantidadTextBox.Text + "',
                                                       '" + ObservacionTextBox.Text + "',
                                                       '" + EstadoComboBox.SelectedItem + "')"
                Ejecutar(sql)
                Recargar()
            End If
            Limpiar()
            MsgBox("¡Anticipo registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub
    Sub Recargar()
        If TextBox1.Text <> "" Then
            Try
                sql = "select Top (50) * from Anticipos where codigo like '" & TextBox1.Text + "%" & "' order by fecha desc"
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                AnticiposDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Recargar()
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If MsgBox("¡Desea guardar actualizar el anticipo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("¡Seleccione el codigo para actualizar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "update anticipos set 
            fecha ='" + fechaanticipo.Value + "',
            cantidad ='" + CantidadTextBox.Text + "',
            estado = '" + EstadoComboBox.SelectedItem + "',
            observacion = '" + ObservacionTextBox.Text + "' where codigo = '" + TextBox1.Text + "' and fecha = '" + fechaanticipo.Value + "'"

                Ejecutar(sql)

            End If
            Recargar()
            LimpiarAnticipo()

            MsgBox("¡Anticipo actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Sub LimpiarAnticipo()
        fechaanticipo.Enabled = True
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ObservacionTextBox.Text = "Ninguna"
        EstadoComboBox.SelectedItem = "Pendiente"
        AnticiposDataGridView.DataSource = vbNull
        CantidadTextBox.Text = 0
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        LimpiarAnticipo()
    End Sub

    Private Sub CmdEliminarAnticipo_Click(sender As Object, e As EventArgs) Handles cmdEliminarAnticipo.Click
        If MsgBox("¡Se eliminara el anticipo, desea continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("¡Seleccione codigo para eliminar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "delete from anticipos where codigo = '" + TextBox1.Text + "' and fecha = '" + fechaanticipo.Value + "'"
                Ejecutar(sql)
            End If
            Recargar()

            MsgBox("¡Anticipo eliminado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
        LimpiarAnticipo()
    End Sub

    Private Sub ComprobanteEntregaUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobanteEntregaUniformeToolStripMenuItem.Click
        R_EntregaUniforme.Show()
    End Sub

    Private Sub ComprobanteDevolucionUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobanteDevolucionUniformeToolStripMenuItem.Click
        R_DevolucionUniforme.Show()
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = EmpleadosDataGridView.Rows(index)

        CodigoTextBox.Text = selectedRow.Cells(0).Value.ToString
        NombresTextBox.Text = selectedRow.Cells(1).Value.ToString
        ApellidosTextBox.Text = selectedRow.Cells(2).Value.ToString
        SalarioTextBox.Text = selectedRow.Cells(3).Value
        txt_bhoras.Text = selectedRow.Cells(5).Value
        txt_depreciacion.Text = selectedRow.Cells(6).Value
        txt_bono.Text = selectedRow.Cells(7).Value

        If SalarioTextBox.Text = "0" Then
            MessageBox.Show("El salario del empleado esta en 0, contactar al depto de RRHH")
        Else
            If txtprestamo.Text = 0 Then
                txtprestamo.ReadOnly = False
            End If

            If txt_uniforme.Text = 0 Then
                txt_uniforme.ReadOnly = False
            End If

        End If
        panelempleados.Visible = False
        Llenarinfo()
    End Sub

    Private Sub CmdGuardar_Click_2(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If MsgBox("¡Desea guardar el anticipo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("¡Seleccione un codigo para asignar anticipo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "insert into anticipos values('" + TextBox1.Text + "',
                                                       '" + fechaanticipo.Value + "',
                                                       '" + CantidadTextBox.Text + "',
                                                       '" + ObservacionTextBox.Text + "',
                                                       '" + EstadoComboBox.SelectedItem + "')"
                Ejecutar(sql)
                Recargar()
            End If
            LimpiarAnticipo()
            MsgBox("¡Anticipo registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Private Sub AnticiposDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AnticiposDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = AnticiposDataGridView.Rows(index)

            TextBox1.Text = selectedRow.Cells(0).Value.ToString
            fechaanticipo.Text = selectedRow.Cells(1).Value.ToString
            CantidadTextBox.Text = selectedRow.Cells(2).Value.ToString
            ObservacionTextBox.Text = selectedRow.Cells(3).Value.ToString
            EstadoComboBox.SelectedItem = selectedRow.Cells(4).Value.ToString
            fechaanticipo.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
            TextBox2.Focus()
        End If
    End Sub
End Class