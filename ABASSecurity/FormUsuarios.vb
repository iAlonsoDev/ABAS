Imports System.Data.SqlClient

Public Class FormUsuarios

    ReadOnly obj As New ClaseBusquedasDinamicas

    ''para modulos
    Dim a, b, c, d, ee, f, g, h, ii, j, k, l, m, n, o, id As String


    Private Sub UsuariosModulosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsuariosModulosDataGridView.CellContentClick
        CmdActualizar.Enabled = True
        CmdEliminar.Enabled = True
        CmdGuardar.Enabled = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = UsuariosModulosDataGridView.Rows(index)

            id = selectedRow.Cells(0).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(1).Value.ToString
            UsuarioTextBox.Text = selectedRow.Cells(2).Value.ToString
            ContraseñaTextBox.Text = selectedRow.Cells(3).Value.ToString
            ii = selectedRow.Cells(4).Value.ToString
            j = selectedRow.Cells(5).Value.ToString
            k = selectedRow.Cells(6).Value.ToString
            l = selectedRow.Cells(7).Value.ToString
            m = selectedRow.Cells(8).Value.ToString
            n = selectedRow.Cells(9).Value.ToString
            a = selectedRow.Cells(10).Value.ToString
            o = selectedRow.Cells(11).Value.ToString
            b = selectedRow.Cells(12).Value.ToString
            c = selectedRow.Cells(13).Value.ToString
            d = selectedRow.Cells(14).Value.ToString
            ee = selectedRow.Cells(15).Value.ToString
            f = selectedRow.Cells(16).Value.ToString
            g = selectedRow.Cells(17).Value.ToString
            h = selectedRow.Cells(18).Value.ToString
            AlmacenComboBox.Text = selectedRow.Cells(19).Value.ToString
            Aprueba1ComboBox.SelectedItem = selectedRow.Cells(20).Value.ToString
            Aprueba2ComboBox.SelectedItem = selectedRow.Cells(21).Value.ToString
            NivelComboBox.SelectedItem = selectedRow.Cells(22).Value.ToString

            LeerModulos()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub NivelComboBox_TextChanged(sender As Object, e As EventArgs) Handles NivelComboBox.TextChanged
        If NivelComboBox.SelectedItem = 1 Then
            Label1.Text = "Recibe en el Almacen"
        ElseIf NivelComboBox.SelectedItem = 2 Then
            Label1.Text = "Recibe y Salida en el Almacen"
        ElseIf NivelComboBox.SelectedItem = 3 Then
            Label1.Text = "Recibe, Salida, Desecha en el Almacen"
        End If
    End Sub

    Private Sub NivelComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles NivelComboBox.DropDownClosed
        If NivelComboBox.SelectedItem = 1 Then
            Label1.Text = "Recibe en el Almacen"
        ElseIf NivelComboBox.SelectedItem = 2 Then
            Label1.Text = "Recibe y Salida en el Almacen"
        ElseIf NivelComboBox.SelectedItem = 3 Then
            Label1.Text = "Recibe, Salida, Desecha en el Almacen"
        End If
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            CodigoTextBox.Text = selectedRow.Cells(0).Value.ToString
            Panel2.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles CmdEliminar.Click
        If MsgBox("¡Se borrara el usuario, desea continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If CodigoTextBox.Text = "" Then
                MsgBox("¡No ha seleccionado ningun usuario para eliminar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "delete from usuariosmodulos where ID = '" + id + "'"
                Ejecutar(sql)
            End If
            CmdGuardar.Enabled = True
            CmdActualizar.Enabled = False
            CmdEliminar.Enabled = False
            Limpiar()
            MsgBox("¡Usuario eliminado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click
        If MsgBox("¡Desea actualizar el usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            ValidarModulos()
            If CodigoTextBox.Text = "" Then
                MessageBox.Show("Escriba o seleccione un codigo de empleado")
            Else
                sql = "update usuariosmodulos set
            codigo ='" + CodigoTextBox.Text + "',
            usuario ='" + UsuarioTextBox.Text + "',
            contraseña ='" + ContraseñaTextBox.Text + "',
            rango1 = '" + ii + "',
            rango2 = '" + j + "',
            rango3 = '" + k + "',
            rango4 = '" + l + "',
            rango5 = '" + m + "',
            rango6 = '" + n + "',
            RRHH = '" + a + "',
            Clientes = '" + o + "',
            Operacion = '" + b + "',
            Planilla = '" + c + "',
            Pagos = '" + d + "',
            Graficas = '" + ee + "',
            Inventario = '" + f + "',
            Otros = '" + g + "',
            Usuarios = '" + h + "',
            almacen = '" + AlmacenComboBox.Text + "',
            aprueba1 = '" + Aprueba1ComboBox.SelectedItem + "',
            aprueba2 = '" + Aprueba2ComboBox.SelectedItem + "',
            nivel = '" + NivelComboBox.SelectedItem + "' where id = '" + id + "'"
                Ejecutar(sql)
            End If
            CmdGuardar.Enabled = True
            CmdActualizar.Enabled = False
            CmdEliminar.Enabled = False
            Limpiar()

            MsgBox("¡Usuario actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub


    Private Sub FormUsuariosModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        tipodebusqueda.SelectedItem = "Codigo"
        obj.Llamausuariosmodulos(UsuariosModulosDataGridView)
        Aprueba1ComboBox.SelectedItem = "SI"
        Aprueba2ComboBox.SelectedItem = "NO"
        NivelComboBox.SelectedItem = "1"
        Label1.Text = "Recibe en el Almacen"

        LlenarAlmacenes()

    End Sub

    Sub LlenarAlmacenes()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        AlmacenComboBox.DataSource = ds.Tables(0)
        AlmacenComboBox.DisplayMember = "Nombre"
    End Sub

    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles CmdBuscar.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
            txtbusqueda.Focus()
        End If
    End Sub

    Sub LeerModulos()
        If a = "SI" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If

        If b = "SI" Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If

        If c = "SI" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If

        If d = "SI" Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If

        If ee = "SI" Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If

        If f = "SI" Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = False
        End If

        If g = "SI" Then
            CheckBox7.Checked = True
        Else
            CheckBox7.Checked = False
        End If

        If h = "SI" Then
            CheckBox8.Checked = True
        Else
            CheckBox8.Checked = False
        End If

        If ii = "Gerencia" Then
            CheckBox9.Checked = True
        Else
            CheckBox9.Checked = False
        End If

        If j = "Administracion" Then
            CheckBox10.Checked = True
        Else
            CheckBox10.Checked = False
        End If

        If k = "RRHH" Then
            CheckBox11.Checked = True
        Else
            CheckBox11.Checked = False
        End If

        If l = "Asistente RRHH" Then
            CheckBox12.Checked = True
        Else
            CheckBox12.Checked = False
        End If

        If m = "Jefe Operaciones" Then
            CheckBox13.Checked = True
        Else
            CheckBox13.Checked = False
        End If

        If n = "Operaciones" Then
            CheckBox14.Checked = True
        Else
            CheckBox14.Checked = False
        End If

        If o = "SI" Then
            CheckBox15.Checked = True
        Else
            CheckBox15.Checked = False
        End If

    End Sub


    Sub ValidarModulos()
        If CheckBox1.Checked = True Then
            a = "SI"
        Else
            a = "NO"
        End If

        If CheckBox2.Checked = True Then
            b = "SI"
        Else
            b = "NO"
        End If
        If CheckBox3.Checked = True Then
            c = "SI"
        Else
            c = "NO"
        End If
        If CheckBox4.Checked = True Then
            d = "SI"
        Else
            d = "NO"
        End If
        If CheckBox5.Checked = True Then
            ee = "SI"
        Else
            ee = "NO"
        End If
        If CheckBox6.Checked = True Then
            f = "SI"
        Else
            f = "NO"
        End If
        If CheckBox7.Checked = True Then
            g = "SI"
        Else
            g = "NO"
        End If
        If CheckBox8.Checked = True Then
            h = "SI"
        Else
            h = "NO"
        End If
        If CheckBox9.Checked = True Then
            ii = "Gerencia"
        Else
            ii = ""
        End If
        If CheckBox10.Checked = True Then
            j = "Administracion"
        Else
            j = ""
        End If
        If CheckBox11.Checked = True Then
            k = "RRHH"
        Else
            k = ""
        End If
        If CheckBox12.Checked = True Then
            l = "Asistente RRHH"
        Else
            l = ""
        End If
        If CheckBox13.Checked = True Then
            m = "Jefe Operaciones"
        Else
            m = ""
        End If
        If CheckBox14.Checked = True Then
            n = "Operaciones"
        Else
            n = ""
        End If

        If CheckBox15.Checked = True Then
            o = "SI"
        Else
            o = "NO"
        End If

    End Sub

    Sub Limpiar()
        CodigoTextBox.Clear()
        UsuarioTextBox.Clear()
        ContraseñaTextBox.Clear()
        Panel2.Visible = False
        tipodebusqueda.SelectedItem = "Codigo"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        obj.Llamausuariosmodulos(UsuariosModulosDataGridView)
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click
        If MsgBox("¡Desea guardar el nuevo usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            ValidarModulos()
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "select * from usuariosmodulos where codigo = '" + CodigoTextBox.Text + "'"
            cmd.CommandText = sql

            'Ejecutamos una lectura a la tabla
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("¡Este codigo ya esta registrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                UsuarioTextBox.Clear()
                ContraseñaTextBox.Clear()
                CodigoTextBox.Clear()
            Else
                If CodigoTextBox.Text = "" Then
                    MsgBox("¡Seleccione un codigo para continuar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                Else
                    sql = "insert into usuariosmodulos values('" + CodigoTextBox.Text + "','" + UsuarioTextBox.Text + "','" + ContraseñaTextBox.Text + "','" + ii + "','" + j + "','" + k + "','" + l + "','" + m + "','" + n + "', '" + a + "', '" + o + "', '" + b + "', '" + c + "', '" + d + "', '" + ee + "', '" + f + "', '" + g + "', '" + h + "', '" + AlmacenComboBox.Text + "', '" + Aprueba1ComboBox.SelectedItem + "', '" + Aprueba2ComboBox.SelectedItem + "', '" + NivelComboBox.SelectedItem + "')"
                    Ejecutar(sql)
                    MsgBox("¡Usuario registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                    Limpiar()
                End If
            End If
            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If tipodebusqueda.SelectedItem.ToString = "Codigo" Then
            obj.BusquedaCodigo(txtbusqueda.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Nombre" Then
            obj.BusquedaNombre(txtbusqueda.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Identidad" Then
            obj.BusquedaIdentidad(txtbusqueda.Text, EmpleadosDataGridView)
        End If

        If txtbusqueda.Text = "" Then
            EmpleadosDataGridView.DataSource = vbNull
        End If
    End Sub
End Class