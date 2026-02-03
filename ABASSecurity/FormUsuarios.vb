Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormUsuarios

    ReadOnly obj As New ClaseBusquedasDinamicas

    ''para modulos
    Dim a, b, c, d, ee, f, g, h, ii, j, k, l, m, n, o, id As String


    Private Sub FormUsuariosModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuariosConHash()

        Panel2.Visible = False
        tipodebusqueda.SelectedItem = "Codigo"
        ''obj.Llamausuariosmodulos(UsuariosModulosDataGridView)
        Aprueba1ComboBox.SelectedItem = "SI"
        Aprueba2ComboBox.SelectedItem = "NO"
        NivelComboBox.SelectedItem = "1"
        Label1.Text = "Recibe en el Almacen"

        LlenarAlmacenes()

    End Sub



    Sub CargarUsuariosConHash()
        Try
            cn.Close()
            cn.Open()

            Dim sql As String = "
        SELECT 
            ID, 
            Codigo, 
            Usuario, 
            LEFT(master.dbo.fn_varbintohexstr(Contraseña), 16) + '...' AS Contraseña,
            Rango1, Rango2, Rango3, Rango4, Rango5, Rango6,
            RRHH, Clientes, Operacion, Planilla, Pagos, Graficas,
            Inventario, Otros, Usuarios, almacen, aprueba1, aprueba2, nivel
        FROM dbo.UsuariosModulos
        ORDER BY ID;"

            da = New SqlDataAdapter(sql, cn)
            dt = New DataTable()
            da.Fill(dt)

            UsuariosModulosDataGridView.AutoGenerateColumns = True
            UsuariosModulosDataGridView.DataSource = Nothing
            UsuariosModulosDataGridView.DataSource = dt

            cn.Close()

        Catch ex As Exception
            MsgBox("Error al cargar usuarios: " & ex.Message, MsgBoxStyle.Critical, "Error")
            cn.Close()
        End Try
    End Sub



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
            ContraseñaTextBox.Text = "Asigne una nueva o la misma"
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

    'Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click
    '    If MsgBox("¡Desea actualizar el usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
    '        ValidarModulos()
    '        If CodigoTextBox.Text = "" Then
    '            MessageBox.Show("Escriba o seleccione un codigo de empleado")
    '        Else
    '            sql = "update usuariosmodulos set
    '        codigo ='" + CodigoTextBox.Text + "',
    '        usuario ='" + UsuarioTextBox.Text + "',
    '        contraseña ='" + ContraseñaTextBox.Text + "',
    '        rango1 = '" + ii + "',
    '        rango2 = '" + j + "',
    '        rango3 = '" + k + "',
    '        rango4 = '" + l + "',
    '        rango5 = '" + m + "',
    '        rango6 = '" + n + "',
    '        RRHH = '" + a + "',
    '        Clientes = '" + o + "',
    '        Operacion = '" + b + "',
    '        Planilla = '" + c + "',
    '        Pagos = '" + d + "',
    '        Graficas = '" + ee + "',
    '        Inventario = '" + f + "',
    '        Otros = '" + g + "',
    '        Usuarios = '" + h + "',
    '        almacen = '" + AlmacenComboBox.Text + "',
    '        aprueba1 = '" + Aprueba1ComboBox.SelectedItem + "',
    '        aprueba2 = '" + Aprueba2ComboBox.SelectedItem + "',
    '        nivel = '" + NivelComboBox.SelectedItem + "' where id = '" + id + "'"
    '            Ejecutar(sql)
    '        End If
    '        CmdGuardar.Enabled = True
    '        CmdActualizar.Enabled = False
    '        CmdEliminar.Enabled = False
    '        Limpiar()

    '        MsgBox("¡Usuario actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
    '    End If

    'End Sub


    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click
        If MsgBox("¡Desea actualizar el usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            ValidarModulos()

            If CodigoTextBox.Text.Trim() = "" Then
                MessageBox.Show("Escriba o seleccione un código de empleado")
                Exit Sub
            End If

            If ContraseñaTextBox.Text.Trim() = "" OrElse ContraseñaTextBox.Text.Trim() = "Asigne una nueva o la misma" Then
                MessageBox.Show("Error en Contraseña. Ingrese una nueva o la misma.")
                Exit Sub
            End If

            ' Generar hash de la contraseña (solo si se ingresó)
            Dim passwordBytes() As Byte = Nothing
            If Not String.IsNullOrWhiteSpace(ContraseñaTextBox.Text) Then
                Using sha256 As SHA256 = SHA256.Create()
                    passwordBytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(ContraseñaTextBox.Text.Trim()))
                End Using
            End If

            ' Query parametrizada
            Dim sql As String = "
        UPDATE UsuariosModulos SET
            Codigo = @Codigo,
            Usuario = @Usuario," &
            If(passwordBytes IsNot Nothing, " Contraseña = @Contraseña,", "") & "
            Rango1 = @R1,
            Rango2 = @R2,
            Rango3 = @R3,
            Rango4 = @R4,
            Rango5 = @R5,
            Rango6 = @R6,
            RRHH = @RRHH,
            Clientes = @Clientes,
            Operacion = @Operacion,
            Planilla = @Planilla,
            Pagos = @Pagos,
            Graficas = @Graficas,
            Inventario = @Inventario,
            Otros = @Otros,
            Usuarios = @Usuarios,
            almacen = @Almacen,
            aprueba1 = @Aprueba1,
            aprueba2 = @Aprueba2,
            nivel = @Nivel
        WHERE ID = @ID;
        "

            cn.Open()
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Codigo", CodigoTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Usuario", UsuarioTextBox.Text.Trim())
            If passwordBytes IsNot Nothing Then
                cmd.Parameters.Add("@Contraseña", SqlDbType.VarBinary, 64).Value = passwordBytes
            End If
            cmd.Parameters.AddWithValue("@R1", ii)
            cmd.Parameters.AddWithValue("@R2", j)
            cmd.Parameters.AddWithValue("@R3", k)
            cmd.Parameters.AddWithValue("@R4", l)
            cmd.Parameters.AddWithValue("@R5", m)
            cmd.Parameters.AddWithValue("@R6", n)
            cmd.Parameters.AddWithValue("@RRHH", a)
            cmd.Parameters.AddWithValue("@Clientes", o)
            cmd.Parameters.AddWithValue("@Operacion", b)
            cmd.Parameters.AddWithValue("@Planilla", c)
            cmd.Parameters.AddWithValue("@Pagos", d)
            cmd.Parameters.AddWithValue("@Graficas", ee)
            cmd.Parameters.AddWithValue("@Inventario", f)
            cmd.Parameters.AddWithValue("@Otros", g)
            cmd.Parameters.AddWithValue("@Usuarios", h)
            cmd.Parameters.AddWithValue("@Almacen", AlmacenComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Aprueba1", Aprueba1ComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Aprueba2", Aprueba2ComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Nivel", NivelComboBox.SelectedItem)
            cmd.Parameters.AddWithValue("@ID", id)
            cmd.ExecuteNonQuery()
            cn.Close()

            MsgBox("¡Usuario actualizado exitosamente!", MsgBoxStyle.Information, "Confirmar")
            CmdGuardar.Enabled = True
            CmdActualizar.Enabled = False
            CmdEliminar.Enabled = False
            Limpiar()
        End If
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
        ''obj.Llamausuariosmodulos(UsuariosModulosDataGridView)
        CargarUsuariosConHash()
    End Sub

    'Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click
    '    If MsgBox("¡Desea guardar el nuevo usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
    '        ValidarModulos()
    '        cn.Open()
    '        cmd.Connection = cn
    '        cmd.CommandType = CommandType.Text
    '        sql = "select * from usuariosmodulos where codigo = '" + CodigoTextBox.Text + "'"
    '        cmd.CommandText = sql

    '        'Ejecutamos una lectura a la tabla
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If dr.HasRows Then
    '            MsgBox("¡Este codigo ya esta registrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
    '            UsuarioTextBox.Clear()
    '            ContraseñaTextBox.Clear()
    '            CodigoTextBox.Clear()
    '        Else
    '            If CodigoTextBox.Text = "" Then
    '                MsgBox("¡Seleccione un codigo para continuar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
    '            Else
    '                sql = "insert into usuariosmodulos values('" + CodigoTextBox.Text + "','" + UsuarioTextBox.Text + "','" + ContraseñaTextBox.Text + "','" + ii + "','" + j + "','" + k + "','" + l + "','" + m + "','" + n + "', '" + a + "', '" + o + "', '" + b + "', '" + c + "', '" + d + "', '" + ee + "', '" + f + "', '" + g + "', '" + h + "', '" + AlmacenComboBox.Text + "', '" + Aprueba1ComboBox.SelectedItem + "', '" + Aprueba2ComboBox.SelectedItem + "', '" + NivelComboBox.SelectedItem + "')"
    '                Ejecutar(sql)
    '                MsgBox("¡Usuario registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
    '                Limpiar()
    '            End If
    '        End If
    '        dr.Close()
    '        cn.Close()
    '    End If
    'End Sub


    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click
        If MsgBox("¡Desea guardar el nuevo usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            ValidarModulos()

            cn.Open()
            cmd = New SqlCommand("SELECT 1 FROM UsuariosModulos WHERE Codigo = @Codigo", cn)
            cmd.Parameters.AddWithValue("@Codigo", CodigoTextBox.Text.Trim())
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("¡Este código ya está registrado!", MsgBoxStyle.Information, "Confirmar")
                dr.Close()
                cn.Close()
                UsuarioTextBox.Clear()
                ContraseñaTextBox.Clear()
                CodigoTextBox.Clear()
                Exit Sub
            End If
            dr.Close()
            cn.Close()

            If CodigoTextBox.Text.Trim() = "" OrElse UsuarioTextBox.Text.Trim() = "" OrElse ContraseñaTextBox.Text.Trim() = "" Then
                MsgBox("¡Complete los campos obligatorios!", MsgBoxStyle.Information, "Confirmar")
                Exit Sub
            End If

            Dim passwordBytes() As Byte
            Using sha256 As SHA256 = sha256.Create()
                passwordBytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(ContraseñaTextBox.Text.Trim()))
            End Using

            sql = "INSERT INTO UsuariosModulos 
               (Codigo, Usuario, Contraseña, Rango1, Rango2, Rango3, Rango4, Rango5, Rango6, RRHH, Clientes, 
                Operacion, Planilla, Pagos, Graficas, Inventario, Otros, Usuarios, almacen, aprueba1, aprueba2, nivel)
               VALUES 
               (@Codigo, @Usuario, @Contraseña, @R1, @R2, @R3, @R4, @R5, @R6, @RRHH, @Clientes, 
                @Operacion, @Planilla, @Pagos, @Graficas, @Inventario, @Otros, @Usuarios, @Almacen, @Aprueba1, @Aprueba2, @Nivel)"

            cn.Open()
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Codigo", CodigoTextBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Usuario", UsuarioTextBox.Text.Trim())
            cmd.Parameters.Add("@Contraseña", SqlDbType.VarBinary, 64).Value = passwordBytes
            cmd.Parameters.AddWithValue("@R1", ii)
            cmd.Parameters.AddWithValue("@R2", j)
            cmd.Parameters.AddWithValue("@R3", k)
            cmd.Parameters.AddWithValue("@R4", l)
            cmd.Parameters.AddWithValue("@R5", m)
            cmd.Parameters.AddWithValue("@R6", n)
            cmd.Parameters.AddWithValue("@RRHH", a)
            cmd.Parameters.AddWithValue("@Clientes", o)
            cmd.Parameters.AddWithValue("@Operacion", b)
            cmd.Parameters.AddWithValue("@Planilla", c)
            cmd.Parameters.AddWithValue("@Pagos", d)
            cmd.Parameters.AddWithValue("@Graficas", ee)
            cmd.Parameters.AddWithValue("@Inventario", f)
            cmd.Parameters.AddWithValue("@Otros", g)
            cmd.Parameters.AddWithValue("@Usuarios", h)
            cmd.Parameters.AddWithValue("@Almacen", AlmacenComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Aprueba1", Aprueba1ComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Aprueba2", Aprueba2ComboBox.Text.Trim())
            cmd.Parameters.AddWithValue("@Nivel", NivelComboBox.SelectedItem)
            cmd.ExecuteNonQuery()
            cn.Close()

            MsgBox("¡Usuario registrado exitosamente!", MsgBoxStyle.Information, "Confirmar")
            Limpiar()

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