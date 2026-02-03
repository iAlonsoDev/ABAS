Imports System.Data.SqlClient

Public Class FormInventarioArmeriaMunicion

    ReadOnly obj As New ClaseBusquedasDinamicas

    Private idsucursal As String
    Private id As String
    Private ubi As String
    Private alm As String
    Private nombre_correlativo As String
    Private mostrarsu As String
    Private codealm As String
    Private codeubi As String
    Public idmunicion As Integer
    Private correlativo As String
    Private resul As String

    Private Sub Armeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Permisos de usuario
        ValidaNivel()

        ''Registro de armas cargas load
        LoadRegistroArmas()

        ''Buscar arma
        LoadRecibirArma()

        ''Movimiento de arma
        LoadMovimientosArmas()

        ''Municion
        LoadMunicion()

        ''Movimiento de municion
        LoadMovimientoMunicion()

        ''Funcion general
        LlenarAlmacenes()
        LlenarAlmacenes2()
        LlenarAlmacenes3()
    End Sub

    Sub LoadMunicion()
        Cmb_TipoMunicion.SelectedItem = "FUEGO ANULAR"
        LlenarTipoMunicion()
        EstadoComboBox3.SelectedItem = "A"
        CantTextBox.Text = 0
        LlenarAlmacenes4()
        LlenarAlmacenes8()

        If ClasePrivilegios.Almacen = "TODOS" Then
            ComboBox3.Text = "SPS"
        Else
            ComboBox3.Text = ClasePrivilegios.Almacen
            ComboBox3.Enabled = False
        End If

    End Sub

    Sub LlenarTipoMunicion()
        sql = "SELECT TOP (1000) [tipo]
              ,[municion]
          FROM [ABAS].[dbo].[TipoMunicion]
          WHERE [tipo] = '" + Cmb_TipoMunicion.SelectedItem + "'"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        Cmb_DescMunicion.DataSource = ds.Tables(0)
        Cmb_DescMunicion.DisplayMember = "municion"
    End Sub

    Sub LoadRecibirArma()
        ComboBox1.SelectedItem = "Tipo"
        Panel1.Visible = False

        If ClasePrivilegios.Almacen = "TODOS" Then
            AlmacenComboBox.SelectedItem = "SPS"
        Else
            AlmacenComboBox.SelectedItem = ClasePrivilegios.Almacen
            Cmb_Almacen.Enabled = False
        End If

        CargarMovimientos()

    End Sub

    Sub LoadRegistroArmas()
        PanelProveedores.Visible = False
        obj.LlamaProvedoresArmeria(DgvProveedoresA)

        EstadoComboBox.SelectedItem = "Seleccionar"
        TipoComboBox.SelectedItem = "Seleccionar"
        CalibreComboBox.SelectedItem = "Seleccionar"
        cmb_Color.SelectedItem = "Seleccionar"

        ObservacionTextBox.Text = "Ninguna"
        ListBox1.Hide()

        If ClasePrivilegios.Almacen = "TODOS" Then
            Cmb_Almacen.SelectedItem = "SPS"
        Else
            Cmb_Almacen.SelectedItem = ClasePrivilegios.Almacen
            Cmb_Almacen.Enabled = False
        End If

    End Sub

    Sub LlenarAlmacenes()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        Cmb_Almacen.DataSource = ds.Tables(0)
        Cmb_Almacen.DisplayMember = "Nombre"
    End Sub

    Sub LlenarAlmacenes2()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        Cmb_Almacen2.DataSource = ds.Tables(0)
        Cmb_Almacen2.DisplayMember = "Nombre"
    End Sub

    Sub LlenarAlmacenes3()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        AlmacenComboBox.DataSource = ds.Tables(0)
        AlmacenComboBox.DisplayMember = "Nombre"
    End Sub
    Sub LlenarAlmacenes4()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        ComboBox3.DataSource = ds.Tables(0)
        ComboBox3.DisplayMember = "Nombre"
    End Sub

    Sub LlenarAlmacenes8()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        ComboBox5.DataSource = ds.Tables(0)
        ComboBox5.DisplayMember = "Nombre"
    End Sub

    Sub LoadMovimientosArmas()
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        EstadoComboBox1.SelectedItem = "Salida"
        panelEmpleados.Visible = False
        panelMovimientos.Visible = False
        ListBox3.Visible = False
        cmdVerMov.Visible = False
        ObservacionesTextBox.Text = "Ninguna"
        LlenarCliente()
        LlenarSucursal()
        LlenarIdSucursal()
        PanelBusSerie.Visible = False

        If ClasePrivilegios.Almacen = "TODOS" Then
            AlmacenComboBox.SelectedItem = "SPS"
        Else
            AlmacenComboBox.SelectedItem = ClasePrivilegios.Almacen
            AlmacenComboBox.Enabled = False
        End If

        Cmb_ubi.SelectedItem = "Cliente"
        Group_Clie.Visible = True
        Group_Suc.Visible = True
        Group_Pro.Visible = False
        Cmb_Almacen2.Visible = False
        Cmb_Almacen2.SelectedItem = "Seleccionar"
        Lbl_Almacen.Visible = False
        ComboBox2.SelectedItem = "Tipo"
        TextBox2.Focus()
    End Sub


    Sub ValidaNivel()
        cn.Close()
        cmd = New SqlCommand("Select * from usuariosmodulos where usuario = '" + Usuario + "'", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Nivel = dr.Item("nivel").ToString

            If Nivel = "1" Then
                TabPage2.Enabled = False
            Else
                TabPage2.Enabled = True
            End If
        End If
        dr.Close()
        cn.Close()
    End Sub


    Sub Insertar()

        Dim ARUbicacion As String = "Almacen"

        If ObservacionesTextBox.Text = "" Then
            ObservacionesTextBox.Text = "Ninguna"
        End If

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "SELECT serie FROM Armeria WHERE (serie = '" + SerieTextBox.Text + "')"
        cmd.CommandText = sql

        If SerieTextBox.Text = "" Then
            MessageBox.Show("Debe llenar este campo obligatorio")
            SerieTextBox.Focus()
        Else
            'Ejecutamos una lectura RRHH la tabla
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                'Si encuentra un registro
                MessageBox.Show("Esta arma ya esta registrada")
                CodigoTextBox.Select()
            Else
                For Each row In ArmeriaDataGridView.Rows

                    If Cmb_Almacen.Text = "SPS" Then
                        ArmeriaDataGridView.Rows.Add(CodigoTextBox.Text, TipoComboBox.SelectedItem, CalibreComboBox.SelectedItem, MarcaTextBox.Text, SerieTextBox.Text, PermisodpiTextBox.Text, VdepermisoTextBox.Text, EstadoComboBox.SelectedItem, ObservacionesTextBox.Text, ARUbicacion, cmb_Color.SelectedItem, txt_idproveedor.Text, Txt_code.Text, Cmb_Almacen.Text, Usuario, FechaCompra.Text)
                    Else
                        ArmeriaDataGridView.Rows.Add(CodigoTextBox.Text, TipoComboBox.SelectedItem, CalibreComboBox.SelectedItem, MarcaTextBox.Text, SerieTextBox.Text, PermisodpiTextBox.Text, VdepermisoTextBox.Text, EstadoComboBox.SelectedItem, ObservacionesTextBox.Text, ARUbicacion, cmb_Color.SelectedItem, txt_idproveedor.Text, Txt_code.Text, Cmb_Almacen.Text, "No Recibida", FechaCompra.Text)
                    End If

                    Limpiar()
                    Exit For
                Next
            End If
        End If

        dr.Close()
        cn.Close()
    End Sub

    Sub Limpiar()
        CodigoTextBox.Clear()
        txt_idproveedor.Clear()
        TipoComboBox.SelectedItem = "Seleccionar"
        CalibreComboBox.SelectedItem = "Seleccionar"
        MarcaTextBox.Clear()
        SerieTextBox.Clear()
        PermisodpiTextBox.Clear()
        VdepermisoTextBox.Clear()
        EstadoComboBox.SelectedItem = "Seleccionar"
        cmb_Color.SelectedItem = "Seleccionar"
        Cmb_Almacen.SelectedItem = "Seleccionar"
        ObservacionesTextBox.Text = "Ninguna"
        SerieTextBox.Enabled = True
        cmdGuardar.Enabled = True
        PictureFoto.BackgroundImage = Nothing
    End Sub


    Sub Guardar()

        Guardar_imagen()

        If ArmeriaDataGridView.Rows.Count = 0 Then
            Return
        End If

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()
            sql = "INSERT INTO [dbo].[Armeria]
                                           ([codigo]
                                           ,[tipo]
                                           ,[calibre]
                                           ,[marca]
                                           ,[serie]
                                           ,[permisodpi]
                                           ,[vdepermiso]
                                           ,[estado]
                                           ,[observaciones]
                                           ,[ubicacion]
                                           ,[color]
                                           ,[idproveedor]
                                           ,[code]
                                           ,[almacen]
                                           ,[recibe_mov]
                                           ,[fechacompra])
                                     VALUES
                                           (@codigo
                                           ,@tipo
                                           ,@calibre
                                           ,@marca
                                           ,@serie
                                           ,@permisodpi
                                           ,@vdepermiso
                                           ,@estado
                                           ,@observaciones
                                           ,@ARUbicacion
                                           ,@color
                                           ,@idproveedor
                                           ,@code
                                           ,@almacen
                                           ,@user
                                           ,@fechac)"
            cmd = New SqlCommand(sql, cn)

            Try
                For Each row As DataGridViewRow In ArmeriaDataGridView.Rows
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@codigo", CStr(row.Cells("codigo").Value))
                    cmd.Parameters.AddWithValue("@tipo", CStr(row.Cells("tipo").Value))
                    cmd.Parameters.AddWithValue("@calibre", CStr(row.Cells("calibre").Value))
                    cmd.Parameters.AddWithValue("@marca", CStr(row.Cells("marca").Value))
                    cmd.Parameters.AddWithValue("@serie", CStr(row.Cells("serie").Value))
                    cmd.Parameters.AddWithValue("@permisodpi", CStr(row.Cells("permisodpi").Value))
                    cmd.Parameters.AddWithValue("@vdepermiso", CStr(row.Cells("vdepermiso").Value))
                    cmd.Parameters.AddWithValue("@estado", CStr(row.Cells("estado").Value))
                    cmd.Parameters.AddWithValue("@observaciones", CStr(row.Cells("observaciones").Value))
                    cmd.Parameters.AddWithValue("@ARUbicacion", CStr(row.Cells("ARUbicacion").Value))
                    cmd.Parameters.AddWithValue("@color", CStr(row.Cells("color").Value))
                    cmd.Parameters.AddWithValue("@idproveedor", CStr(row.Cells("idproveedor").Value))
                    cmd.Parameters.AddWithValue("@code", (row.Cells("code").Value))
                    cmd.Parameters.AddWithValue("@almacen", CStr(row.Cells("almacen").Value))
                    cmd.Parameters.AddWithValue("@user", CStr(row.Cells("user").Value))
                    cmd.Parameters.AddWithValue("@fechac", CStr(row.Cells("FechaC").Value))
                    cmd.ExecuteNonQuery()
                Next
            Catch ex As Exception

                MessageBox.Show("Se ha realizado el registro exitosamente")
                Limpiar()
                ArmeriaDataGridView.Rows.Clear()
            End Try
            cn.Close()


            CodigoTextBox.Clear()
            cmdInsertar.Enabled = True
        End Using

    End Sub

    Sub Guardar_imagen()
        If PictureFoto.BackgroundImage IsNot Nothing Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * from ArmeriaFotos  where codigoarma = '" + CodigoTextBox.Text + "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureFoto.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "UPDATE ArmeriaFotos SET Foto=@Foto WHERE [codigoarma] ='" + CodigoTextBox.Text + "'"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Foto", ms1.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms1.Close()

            Else
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureFoto.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "INSERT INTO [dbo].[ArmeriaFotos]
                   ([codigoarma]
                   ,[foto])
             VALUES
                   ('" + CodigoTextBox.Text + "'
                   , @Foto)"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Foto", ms1.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms1.Close()
            End If

            cn.Close()
        End If
    End Sub

    Private Sub CmdInsertar_Click(sender As Object, e As EventArgs) Handles cmdInsertar.Click
        Insertar()
        cmdInsertar.Enabled = False
    End Sub

    Private Sub No_edit_Combo(sender As Object, e As KeyPressEventArgs) Handles TipoComboBox.KeyPress, EstadoComboBox.KeyPress, CalibreComboBox.KeyPress, Cmb_Almacen.KeyPress, cmb_Color.KeyPress, ComboBox1.KeyPress, tipodebusqueda.KeyPress, Cmb_ubi.KeyPress, Cmb_Almacen2.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        For Each row As DataGridViewRow In ArmeriaDataGridView.Rows
            If row.Cells(0).Value = "" Then
                MessageBox.Show("No se ha realizado ninguna registro no es permitido guardar")
            Else
                Guardar()
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub


    Private Sub SerieTextBox_TextChanged(sender As Object, e As EventArgs) Handles SerieTextBox.TextChanged
        If SerieTextBox.Text <> "" Then
            ListBox1.Show()
            sql = "Select * from  armeria where ubicacion <> 'Desechada' and serie like '" & SerieTextBox.Text & "%" & "' order by serie asc"
            da = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)
            ListBox1.DataSource = ds.Tables(0)
            ListBox1.DisplayMember = "serie"
            ListBox1.ValueMember = "serie"
        Else
            ListBox1.Hide()
        End If
    End Sub

    Private Sub SerieTextBox1_TextChanged(sender As Object, e As EventArgs) Handles SerieTextBox1.TextChanged
        If SerieTextBox1.Text <> "" Then
            ListBox3.Show()
            cmdVerMov.Visible = True
        Else
            ListBox3.Hide()
            cmdVerMov.Visible = False
        End If

        If SerieTextBox1.Enabled = False Then
        Else
            cn.Open()
            sql = "Select * from  armeria where ubicacion <> 'Desechada' and serie like '" & SerieTextBox1.Text & "%" & "' order by serie asc"
            da = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)
            ListBox3.DataSource = ds.Tables(0)
            ListBox3.DisplayMember = "serie"
            ListBox3.ValueMember = "serie"
            cn.Close()
        End If
    End Sub

    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        BuscarEmpleado()
    End Sub

    Sub BuscarEmpleado()
        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & txtbusqueda.Text + "%" & "' and cargo NOT LIKE 'of%'"
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


        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & txtbusqueda.Text + "%" & "' and cargo NOT LIKE 'of%'"
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
            sql = "select * from Empleados where estado <> 'Inactivo' and ubicacion like '" & txtbusqueda.Text + "%" & "' and cargo NOT LIKE 'of%'"
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
            sql = "select * from Empleados where estado <> 'Inactivo' and planilla like '" & txtbusqueda.Text + "%" & "' and cargo NOT LIKE 'of%'"
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
            sql = "select * from Empleados where estado <> 'Inactivo' and cargo NOT LIKE 'of%'"
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
        panelEmpleados.Visible = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            txtNombre.Text = selectedRow.Cells(1).Value.ToString
            txtApellido.Text = selectedRow.Cells(2).Value.ToString
            EncargadoTextBox.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbusqueda.Focus()
        End If
    End Sub

    Private Sub ListBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox5.MouseClick
        LlenarSucursal()
        LlenarIdSucursal()
    End Sub

    Sub LlenarCliente()
        sql = "Select * from  cliente where estado = 'Activo' order by nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox5.DataSource = ds.Tables(0)
        ListBox5.DisplayMember = "nombre"
        ListBox5.ValueMember = "nombre"
    End Sub
    Sub LlenarSucursal()
        sql = "select sucursal from sucursales, cliente where Cliente.nombre = Sucursales.nombre and Cliente.nombre = '" + ListBox5.SelectedValue + "' and Cliente.estado = 'Activo' order by Sucursales.nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox4.DataSource = ds.Tables(0)
        ListBox4.DisplayMember = "sucursal"
        ListBox4.ValueMember = "sucursal"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdInsertarMov.Click

        If SerieTextBox1.Text = "" Then
            MessageBox.Show("No ha seleccionado niguna serie(arma) para su movimiento")
        Else
            If Nivel = "2" And Cmb_ubi.SelectedItem = "Desechada" Then
                MessageBox.Show("No tienes permiso para realizar este movimiento")
            Else
                For Each row As DataGridViewRow In dgvMovimientos.Rows
                    'en cells() va el indice de la columna que quiere verificar que tenga datos
                    If row.Cells(0).Value = ListBox3.SelectedValue Then
                        MessageBox.Show("Esta serie ya esta insertada, pero aun no esta en la base de datos")
                        Limpiar2()
                    End If
                Next

                If EncargadoTextBox.Text <> "" Then
                    InsertarMov()
                End If
            End If
        End If
    End Sub

    Sub InsertarMov()
        If ObservacionTextBox.Text = "" Then
            ObservacionTextBox.Text = "Ninguna"
        End If

        If Cmb_ubi.SelectedItem = "Cliente" Then
            LlenarIdSucursal()
            mostrarsu = ListBox4.Text
            nombre_correlativo = ListBox5.SelectedValue
        End If

        If Cmb_ubi.SelectedItem = "Taller" Then
            idsucursal = 0
            mostrarsu = "Taller"
            nombre_correlativo = ListBox2.SelectedValue
        End If
        If Cmb_ubi.SelectedItem = "Almacen" Then
            idsucursal = 0
            mostrarsu = "Almacen"
            nombre_correlativo = Cmb_Almacen2.Text
        End If

        If Cmb_ubi.SelectedItem = "Desechada" Then
            idsucursal = 0
            mostrarsu = "Desechada"
            nombre_correlativo = "Desechada"
        End If

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "SELECT serie FROM MovimientoArmas WHERE (serie = '" + ListBox3.SelectedValue + "' and fecha = '" + FechaMov.Text + "')"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            If MsgBox("Esta arma tiene un movimiento registrado este dia, Desea registrar un nuevo movimiento", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then

                For Each row In dgvMovimientos.Rows
                    dgvMovimientos.Rows.Add(ListBox3.SelectedValue, idsucursal, ListBox5.SelectedValue, mostrarsu, FechaMov.Value, EncargadoTextBox.Text, txtNombre.Text, txtApellido.Text, ObservacionTextBox.Text, EstadoComboBox1.SelectedItem, Cmb_ubi.SelectedItem, nombre_correlativo)
                    Limpiar2()
                    Exit For
                Next
                Limpiar2()
            Else
                Limpiar2()
            End If
        Else
            For Each row In dgvMovimientos.Rows
                dgvMovimientos.Rows.Add(ListBox3.SelectedValue, idsucursal, ListBox5.SelectedValue, mostrarsu, FechaMov.Value, EncargadoTextBox.Text, txtNombre.Text, txtApellido.Text, ObservacionTextBox.Text, EstadoComboBox1.SelectedItem, Cmb_ubi.SelectedItem, nombre_correlativo)
                Limpiar2()
                Exit For
            Next
        End If
        dr.Close()
        cn.Close()
    End Sub

    Sub GuardarMov()
        If dgvMovimientos.Rows.Count = 0 Then
            Return
        End If

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()

            sql = "INSERT INTO MovimientoArmas (serie, idsucursal, fecha, encargado, observacion, estado, ubicacion_inventario, nombre_correlativo) 
                                                        VALUES (@Mserie, @Midsucursal, @Mfecha, @Mencargado, @Mobservacion, @Mestado, @Mubinven, @Mnombre)"
            cmd = New SqlCommand(sql, cn)

            Try
                For Each row As DataGridViewRow In dgvMovimientos.Rows
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Mserie", CStr(row.Cells("mSerie").Value))
                    cmd.Parameters.AddWithValue("@Midsucursal", CStr(row.Cells("mIdsucursal").Value))
                    cmd.Parameters.AddWithValue("@Mfecha", Convert.ToDateTime(row.Cells("mFecha").Value))
                    cmd.Parameters.AddWithValue("@Mencargado", CStr(row.Cells("mEncargado").Value))
                    cmd.Parameters.AddWithValue("@Mobservacion", CStr(row.Cells("mObservacion").Value))
                    cmd.Parameters.AddWithValue("@Mestado", CStr(row.Cells("mEstado").Value))
                    cmd.Parameters.AddWithValue("@Mubinven", CStr(row.Cells("mUbicacion").Value))
                    cmd.Parameters.AddWithValue("@Mnombre", CStr(row.Cells("mNombre").Value))
                    cmd.ExecuteNonQuery()

                    Try
                        id = CStr(row.Cells("mSerie").Value)
                        ubi = CStr(row.Cells("mUbicacion").Value)
                        alm = CStr(row.Cells("mNombre").Value)

                        If ubi = "Desechada" Then
                            sql = "Update Armeria set ubicacion = '" + ubi + "', recibe_mov = '" + Usuario + "'
                                         where serie = '" + id + "'"
                        ElseIf ubi = "Almacen" Then
                            sql = "Update Armeria set ubicacion = '" + ubi + "', almacen = '" + alm + "', recibe_mov = 'No Recibida'
                                         where serie = '" + id + "'"
                        Else
                            sql = "Update Armeria set ubicacion = '" + ubi + "' where serie = '" + id + "'"
                        End If

                        Ejecutar(sql)
                    Catch ex As Exception
                        Return
                    End Try
                Next
            Catch ex As Exception

                MsgBox("¡Se han realizado los registros exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                Limpiar2()
                dgvMovimientos.Rows.Clear()
            End Try
            cn.Close()
        End Using

    End Sub


    Sub Limpiar2()
        EncargadoTextBox.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        ObservacionTextBox.Text = "Ninguna"
    End Sub

    Private Sub ListBox4_Click(sender As Object, e As EventArgs) Handles ListBox4.Click
        LlenarIdSucursal()
        Vcant()
    End Sub

    Sub Vcant()
        Dim emple As Integer
        Dim cant As Integer

        cn.Close()
        cn.Open()
        cmd = New SqlCommand("select Sucursales.empleados, count(MovimientoArmas.idmovimiento) as Cant from Sucursales 
                inner join MovimientoArmas
                on MovimientoArmas.idsucursal = Sucursales.idsucursal
                where Sucursales.idsucursal = '" + idsucursal + "' and ubicacion_inventario = 'Cliente'
                group by empleados", cn) With {
            .CommandType = CommandType.Text
        }

        dr = cmd.ExecuteReader()
        dr.Read()

        If dr.HasRows = True Then
            cant = dr.Item("Cant").ToString
            emple = dr.Item("empleados").ToString
            If cant = emple Then
                MessageBox.Show("La sucursal seleccionada ya cuenta con la cantidad limite de armas asignadas segun la cantidad de oficiales asignados, Desea asignar de todas formas?")
            End If
        End If

        cn.Close()
        dr.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdGuardarMov.Click
        For Each row As DataGridViewRow In dgvMovimientos.Rows
            If row.Cells(0).Value = "" Then
                MessageBox.Show("No se ha realizado ninguna registro no es permitido guardar")
            Else
                GuardarMov()
            End If
        Next
    End Sub

    Private Sub CmdLimpiarMov_Click(sender As Object, e As EventArgs) Handles cmdLimpiarMov.Click
        Limpiar2()
    End Sub

    Private Sub CmdVerMov_Click(sender As Object, e As EventArgs) Handles cmdVerMov.Click
        If panelMovimientos.Visible = True Then
            panelMovimientos.Visible = False
        Else
            panelMovimientos.Visible = True
            LlenarMov()
        End If
    End Sub

    Sub LlenarMov()
        Try
            sql = "IF OBJECT_ID('tempdb..#temp') IS NOT NULL
        begin
            DROP TABLE #temp;
        end
        SELECT *
	            into #temp
            FROM [ABAS].[dbo].[MovimientoArmas]
            select [serie]
	    ,'Almacen' = (select almacen from Armeria where serie = #temp.serie)
		,nombre_correlativo as cliente
        ,case when #temp.[idsucursal] = 0 
		then #temp.ubicacion_inventario 
		else (select sucursal from Sucursales where idsucursal = #temp.idsucursal) end as sucursal
        ,[fecha]
        ,case when #temp.[encargado] <> '' then (Select Empleados.nombres +' ' + dbo.Empleados.apellidos from Empleados where codigo = #temp.encargado) end as encargado
        ,[observacion]
        ,[estado]
        ,[idmovimiento]
        ,[ubicacion_inventario] from #temp where #temp.serie = '" + SerieTextBox1.Text + "' and #temp.fecha = '" + FechaMov.Text + "'"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            sql = "IF OBJECT_ID('tempdb..#temp') IS NOT NULL
                        begin
                            DROP TABLE #temp;
                        end
                        SELECT *
	                          into #temp
                          FROM [ABAS].[dbo].[MovimientoArmas]
                          select [serie]
                              ,case when #temp.[idsucursal] = 0 then #temp.ubicacion_inventario else (select sucursal from Sucursales where idsucursal = #temp.idsucursal) end as sucursal
                              ,[fecha]
                              ,case when #temp.[encargado] <> '' then (Select Empleados.nombres +' ' + dbo.Empleados.apellidos from Empleados where codigo = #temp.encargado) end as encargado
                              ,[observacion]
                              ,[estado]
                              ,[idmovimiento]
                              ,[ubicacion_inventario] from #temp where #temp.serie ='" + ListBox3.SelectedValue + "'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                dgv.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        Else
            LlenarMov()
        End If
    End Sub

    Private Sub FechaMov_ValueChanged(sender As Object, e As EventArgs) Handles FechaMov.ValueChanged
        LlenarMov()
    End Sub

    Private Sub ReporteDeArmasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeArmasToolStripMenuItem.Click
        R_Armas.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        panelEmpleados.Visible = False
    End Sub

    Private Sub Cmb_ubi_DropDownClosed(sender As Object, e As EventArgs) Handles Cmb_ubi.DropDownClosed

        If Cmb_ubi.SelectedItem = "Cliente" Then
            Group_Clie.Visible = True
            Group_Suc.Visible = True
            Group_Pro.Visible = False
            Cmb_Almacen2.Visible = False
            Lbl_Almacen.Visible = False
            EstadoComboBox1.SelectedItem = "Salida"
        End If
        If Cmb_ubi.SelectedItem = "Taller" Then
            EstadoComboBox1.SelectedItem = "Salida"
            Group_Clie.Visible = False
            Group_Suc.Visible = False
            Cmb_Almacen2.Visible = False
            Lbl_Almacen.Visible = False
            Group_Pro.Visible = True
            LlenarProveedor()

        End If
        If Cmb_ubi.SelectedItem = "Almacen" Then
            EstadoComboBox1.SelectedItem = "Entrada"
            Group_Clie.Visible = False
            Group_Suc.Visible = False
            Group_Pro.Visible = False
            Cmb_Almacen2.Visible = True
            Lbl_Almacen.Visible = True
        End If

        If Cmb_ubi.SelectedItem = "Desechada" Then
            EstadoComboBox1.SelectedItem = "Entrada"
            Group_Clie.Visible = False
            Group_Suc.Visible = False
            Group_Pro.Visible = False
            Cmb_Almacen2.Visible = False
            Lbl_Almacen.Visible = False
        End If
    End Sub


    Private Sub ReporteTipoDeArmasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteTipoDeArmasToolStripMenuItem.Click
        R_TipoArmas.Show()
    End Sub

    Private Sub TipoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoComboBox.SelectedIndexChanged

        If TipoComboBox.SelectedItem <> "Seleccionar" And SerieTextBox.Text = "" Then
            Dim cont As Integer = 0
            'recorre el grid fila por fila
            For Each row As DataGridViewRow In ArmeriaDataGridView.Rows
                'en cells() va el indice de la columna que quiere verificar que tenga datos
                If row.Cells(1).Value = TipoComboBox.SelectedItem Then
                    cont += 1
                End If
            Next

            Dim Code As Integer
            If TipoComboBox.Text <> "" Then
                Dim cadena As String = TipoComboBox.Text
                resul = cadena.Substring(0, 2)
            End If

            Dim Correlativo As String = ""

            cmd = New SqlCommand("SELECT TOP (1) code + 1 as code
            FROM [ABAS].[dbo].[Armeria] WHERE [tipo] = '" + TipoComboBox.SelectedItem + "'
            GROUP BY code
		    ORDER BY code desc", cn) With {
                .CommandType = CommandType.Text
            }

            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read() Then

                Code = dr.Item("code").ToString

                If Code < 10 Then
                    Correlativo = "00"
                End If

                If Code >= 10 And Code < 100 Then
                    Correlativo = "0"
                End If

                If Code >= 100 Then
                    Correlativo = ""
                End If

                CodigoTextBox.Text = resul & Correlativo & Code + cont
                Txt_code.Text = Code + cont
            Else
                Txt_code.Text = 1 + cont
                CodigoTextBox.Text = resul & "00" & 1 + cont

            End If
        Else
            Txt_code.Clear()
        End If

        dr.Close()
        cn.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND estado <> 'C'"
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
        Else

            If ComboBox2.SelectedItem = "Tipo" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) *
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE tipo like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND tipo like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
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

            If ComboBox2.SelectedItem = "Codigo" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE Armeria.codigo like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND Armeria.codigo like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
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

            If ComboBox2.SelectedItem = "Serie" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE serie like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND serie like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
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

            If ComboBox2.SelectedItem = "Marca" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE marca like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) *
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND marca like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
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
        End If
    End Sub

    Private Sub ReporteDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeMovimientosToolStripMenuItem.Click
        R_MovimientosArmas.Show()
    End Sub


    Private Sub ArmasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArmasDataGridView.CellContentClick
        Panel1.Visible = True

        If Nivel = 3 Then
            Panel1.Enabled = True
        End If

        If Nivel = 2 Then
            Panel1.Enabled = True
            EstadoComboBox2.Enabled = False
        End If

        If Nivel = 1 Then
            Panel1.Enabled = False
        End If

        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = ArmasDataGridView.Rows(index)

            CodigoTextBox1.Text = selectedRow.Cells(0).Value.ToString
            AlmacenComboBox.Text = selectedRow.Cells(1).Value.ToString
            TipoComboBox1.SelectedItem = selectedRow.Cells(3).Value.ToString
            SerieTextBox2.Text = selectedRow.Cells(4).Value.ToString
            MarcaTextBox1.Text = selectedRow.Cells(5).Value.ToString
            CalibreComboBox1.SelectedItem = selectedRow.Cells(6).Value.ToString
            EstadoComboBox2.SelectedItem = selectedRow.Cells(7).Value.ToString
            PermisodpiTextBox1.Text = selectedRow.Cells(8).Value.ToString
            VdepermisoTextBox1.Text = selectedRow.Cells(9).Value.ToString
            ObservacionesTextBox1.Text = selectedRow.Cells(10).Value.ToString
            ColorComboBox.SelectedItem = selectedRow.Cells(11).Value.ToString
            IdarmaTextBox.Text = selectedRow.Cells(12).Value.ToString
        Catch

        End Try

        cn.Open()
        sql = "SELECT * FROM [ArmeriaFotos] WHERE codigoarma = '" + CodigoTextBox1.Text + "'"
        da = New SqlDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Foto"), Byte())
            Dim ms As New System.IO.MemoryStream(imageBuffer)
            Dim bmp As New Bitmap(Image.FromStream(ms))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureBox6.BackgroundImage = Nothing
            PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox6.BackgroundImage = bmp
            dt.Clear()
            dt.Reset()
            ms.Dispose()
            ms.Close()
        End If
        cn.Close()

    End Sub

    Private Sub DgvProveedoresA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProveedoresA.CellContentClick
        PanelProveedores.Visible = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DgvProveedoresA.Rows(index)
            txt_idproveedor.Text = selectedRow.Cells(0).Value.ToString
            TextBox1.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelProveedores.Visible = True Then
            PanelProveedores.Visible = False
        Else
            PanelProveedores.Visible = True
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If MsgBox("¡Desea recibir el arma para su almacen?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            sql = "update Armeria set
                            marca = '" + MarcaTextBox1.Text + "',
                            tipo = '" + TipoComboBox1.SelectedItem + "',
                            calibre = '" + CalibreComboBox1.SelectedItem + "',
                            color = '" + ColorComboBox.SelectedItem + "',
                            observaciones = '" + ObservacionesTextBox1.Text + "',
                            permisodpi = '" + PermisodpiTextBox1.Text + "',
                            vdepermiso = '" + VdepermisoTextBox1.Text + "',
                            almacen = '" + AlmacenComboBox.Text + "',
                            estado = '" + EstadoComboBox2.SelectedItem + "',
                            recibe_mov = '" + Usuario + "'
                           where idarma = '" + IdarmaTextBox.Text + "'"
            Ejecutar(sql)

            sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] where estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND estado <> 'C'"

            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            ArmasDataGridView.DataSource = dt
            cn.Close()
            Panel1.Visible = False

            MsgBox("¡Arma recibida exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            SerieTextBox1.Text = selectedRow.Cells(2).Value.ToString
        Catch ex As Exception
        End Try

        PanelBusSerie.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If PanelBusSerie.Visible = False Then
            PanelBusSerie.Visible = True
        Else
            PanelBusSerie.Visible = False
        End If
    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        CargarMovimientos()
    End Sub

    Sub CargarMovimientos()
        If TextBox2.Text = "" Then
            sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND estado <> 'C'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                ArmasDataGridView.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        Else

            If ComboBox1.SelectedItem = "Tipo" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE tipo like '" & TextBox2.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND tipo like '" & TextBox2.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    ArmasDataGridView.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If

            If ComboBox1.SelectedItem = "Codigo" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE Armeria.codigo like '" & TextBox2.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND Armeria.codigo like '" & TextBox2.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    ArmasDataGridView.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If

            If ComboBox1.SelectedItem = "Serie" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE serie like '" & TextBox2.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND serie like '" & TextBox2.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    ArmasDataGridView.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If

            If ComboBox1.SelectedItem = "Marca" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE marca like '" & TextBox2.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND marca like '" & TextBox2.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    ArmasDataGridView.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub ListBox3_Click(sender As Object, e As EventArgs) Handles ListBox3.Click
        SerieTextBox1.Text = ListBox3.SelectedValue
    End Sub

    Private Sub CmdSeleccionarImagen_Click(sender As Object, e As EventArgs) Handles cmdSeleccionarImagen.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }
        Dim dialogo As DialogResult = openFileDialog1.ShowDialog()
        If (dialogo = DialogResult.OK) Then
            Dim bmp As New Bitmap(Image.FromFile(openFileDialog1.FileName))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureFoto.BackgroundImage = Nothing
            PictureFoto.BackgroundImageLayout = ImageLayout.Stretch
            PictureFoto.BackgroundImage = bmp
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
    End Sub

    Private Sub Cmb_TipoMunicion_TextChanged(sender As Object, e As EventArgs) Handles Cmb_TipoMunicion.TextChanged
        LlenarTipoMunicion()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If PanelProveedores.Visible = True Then
            PanelProveedores.Visible = False
        Else
            PanelProveedores.Visible = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles CmdInsertarMunicion.Click
        InsertarMunicion()
        CmdInsertarMunicion.Enabled = False
    End Sub

    Sub LimpiarMunicion()
        TextBox1.Clear()
        DescripcionTextBox.Clear()
        CantTextBox.Text = 0
        PictureBox9.BackgroundImage = Nothing
        DataGridView2.Rows.Clear()

        codealm = ComboBox3.Text.Substring(0, 2)
        CrearCodigoMunicion()
    End Sub

    Sub InsertarMunicion()
        If MsgBox("¡Desea insertar esta municion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            DataGridView2.Rows.Add(DescripcionTextBox.Text, Cmb_DescMunicion.Text, FechaderegistroDateTimePicker.Text, TextBox1.Text, ComboBox3.Text, EstadoComboBox3.SelectedItem, CantTextBox.Text, Cmb_TipoMunicion.SelectedItem, TxtCodigoMunicion.Text)
        End If
    End Sub

    Sub CrearCodigoMunicion()

        If codealm = "" Then
        Else
            If Panel1.Visible = False Then
                cmd = New SqlCommand("SELECT top(1) idmunicion
            FROM [ABAS].[dbo].[Municion]
            GROUP BY idmunicion
		    ORDER BY idmunicion desc", cn) With {
                    .CommandType = CommandType.Text
                }

                cn.Close()
                cn.Open()
                dr = cmd.ExecuteReader()
                If dr.Read() Then

                    idmunicion = Convert.ToInt16(dr.Item("idmunicion").ToString)

                    If idmunicion < 10 Then
                        correlativo = "00"
                    End If

                    If idmunicion >= 10 And idmunicion < 100 Then
                        correlativo = "0"
                    End If

                    If idmunicion >= 100 Then
                        correlativo = ""
                    End If

                    TxtCodigoMunicion.Text = codealm & codeubi & correlativo & (idmunicion + 1)
                Else
                    TxtCodigoMunicion.Text = codealm & codeubi & "00" & 1
                End If
                dr.Close()
                cn.Close()
            End If
        End If



    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            LlenarProveedor()
        Else
            sql = "SELECT * FROM [ABAS].[dbo].[Proveedores]
                   WHERE [Proveedores].categoria = 'Armeria' and nombreproveedor like '" & TextBox3.Text & "%" & "' order by nombreproveedor asc"
            da = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)
            ListBox2.DataSource = ds.Tables(0)
            ListBox2.DisplayMember = "nombreproveedor"
            ListBox2.ValueMember = "nombreproveedor"
        End If

    End Sub

    Sub LlenarProveedor()
        sql = "SELECT * FROM [ABAS].[dbo].[Proveedores]
                   WHERE [Proveedores].categoria = 'Armeria' and nombreproveedor like '" & TextBox3.Text & "%" & "' order by nombreproveedor asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox2.DataSource = ds.Tables(0)
        ListBox2.DisplayMember = "nombreproveedor"
        ListBox2.ValueMember = "nombreproveedor"
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        sql = "Select * from  cliente where estado = 'Activo' and nombre like '" & TextBox6.Text & "%" & "' order by nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox5.DataSource = ds.Tables(0)
        ListBox5.DisplayMember = "nombre"
        ListBox5.ValueMember = "nombre"
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        sql = "select sucursal from sucursales, cliente where Cliente.nombre = Sucursales.nombre and Cliente.nombre = '" + ListBox5.SelectedValue + "' and Cliente.estado = 'Activo' and Sucursales.sucursal like '" & TextBox5.Text + "%" & "' order by Sucursales.nombre asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox4.DataSource = ds.Tables(0)
        ListBox4.DisplayMember = "sucursal"
        ListBox4.ValueMember = "sucursal"
    End Sub

    Sub LlenarIdSucursal()
        cmd = New SqlCommand("Select idsucursal from sucursales, cliente where Cliente.nombre = Sucursales.nombre And Cliente.nombre = '" + ListBox5.SelectedValue + "' and Cliente.estado = 'Activo' order by Sucursales.nombre asc", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            idsucursal = dr.Item("idsucursal").ToString
        End If
        dr.Close()
        dr.Close()
    End Sub

    Private Sub Cmb_TipoMunicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_TipoMunicion.SelectedIndexChanged
        codeubi = Cmb_TipoMunicion.SelectedItem.Substring(0, 2)
        CrearCodigoMunicion()
    End Sub

    Private Sub ComboBox3_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedValueChanged
        If ComboBox3.Text <> "" Then
            codealm = ComboBox3.Text.Substring(0, 2)
            CrearCodigoMunicion()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles CmdGuardarMunicion.Click
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "" Then
                MessageBox.Show("No se ha realizado ninguna registro no es permitido guardar")
            Else
                GuardarMunicion()
            End If
        Next
    End Sub

    Sub GuardarMunicion()
        Guardar_imagenmunicion()

        If ArmeriaDataGridView.Rows.Count = 0 Then
            Return
        End If

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()
            sql = "INSERT INTO [dbo].[Municion]
           ([descripcion]
           ,[calibre]
           ,[fechaderegistro]
           ,[idproveedor]
           ,[almacen]
           ,[estado]
           ,[cant]
           ,[tipo]
           ,[codigo])
     VALUES
           (@descripcion
           ,@calibre
           ,@fechaderegistro
           ,@idproveedor
           ,@almacen
           ,@estado
           ,@cant
           ,@tipo
           ,@codigo)"
            cmd = New SqlCommand(sql, cn)

            Try
                For Each row As DataGridViewRow In DataGridView2.Rows
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@descripcion", CStr(row.Cells("municiondescripcion").Value))
                    cmd.Parameters.AddWithValue("@calibre", CStr(row.Cells("municioncalibre").Value))
                    cmd.Parameters.AddWithValue("@fechaderegistro", CStr(row.Cells("municionfecha").Value))
                    cmd.Parameters.AddWithValue("@idproveedor", CStr(row.Cells("municionproveedor").Value))
                    cmd.Parameters.AddWithValue("@almacen", CStr(row.Cells("municionalmacen").Value))
                    cmd.Parameters.AddWithValue("@estado", CStr(row.Cells("municionestado").Value))
                    cmd.Parameters.AddWithValue("@cant", CStr(row.Cells("municioncantidad").Value))
                    cmd.Parameters.AddWithValue("@tipo", CStr(row.Cells("municiontipo").Value))
                    cmd.Parameters.AddWithValue("@codigo", CStr(row.Cells("municioncodigo").Value))
                    cmd.ExecuteNonQuery()
                Next
            Catch ex As Exception

                MessageBox.Show("Se ha realizado el registro exitosamente")

                DataGridView2.Rows.Clear()
            End Try
            cn.Close()

            TxtCodigoMunicion.Clear()
            CmdInsertarMunicion.Enabled = True
            LimpiarMunicion()
        End Using

    End Sub

    Sub Guardar_imagenmunicion()
        If PictureBox9.BackgroundImage IsNot Nothing Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * from [MunicionFotos]  where [codigomunicion] = '" + TxtCodigoMunicion.Text + "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureBox9.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "UPDATE MunicionFotos SET Foto=@Foto WHERE [codigomunicion] ='" + TxtCodigoMunicion.Text + "'"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Foto", ms1.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms1.Close()

            Else
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureBox9.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "INSERT INTO [dbo].[MunicionFotos]
                   ([codigomunicion]
                   ,[foto])
             VALUES
                   ('" + TxtCodigoMunicion.Text + "'
                   , @Foto)"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Foto", ms1.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms1.Close()
            End If

            cn.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LimpiarMunicion()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }
        Dim dialogo As DialogResult = openFileDialog1.ShowDialog()
        If (dialogo = DialogResult.OK) Then
            Dim bmp As New Bitmap(Image.FromFile(openFileDialog1.FileName))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureBox9.BackgroundImage = Nothing
            PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox9.BackgroundImage = bmp
        End If
    End Sub

    Private Sub CmdLimpiarMunicion_Click(sender As Object, e As EventArgs) Handles CmdLimpiarMunicion.Click
        CodigomunicionTextBox.Clear()
    End Sub

    Sub LoadMovimientoMunicion()
        CodigoenviaTextBox.Text = ClasePrivilegios.Codigo
        LlenarAlmacenes5()
        LlenarAlmacenes6()
        LlenarAlmacenes7()

        Panel5.Visible = False
        Panel6.Visible = False
        ComboBox4.SelectedItem = "FUEGO ANULAR"

        If ClasePrivilegios.Almacen = "TODOS" Then
            AlmacenenviaComboBox.Text = "SPS"
        Else
            AlmacenenviaComboBox.Text = ClasePrivilegios.Almacen
            AlmacenenviaComboBox.Enabled = False
        End If

        LlenarMovMunicion()

    End Sub

    Sub LlenarAlmacenes5()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        AlmacenenviaComboBox.DataSource = ds.Tables(0)
        AlmacenenviaComboBox.DisplayMember = "Nombre"
    End Sub

    Sub LlenarAlmacenes6()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        AlmacenrecibeComboBox.DataSource = ds.Tables(0)
        AlmacenrecibeComboBox.DisplayMember = "Nombre"

    End Sub

    Sub LlenarAlmacenes7()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        ComboBox6.DataSource = ds.Tables(0)
        ComboBox6.DisplayMember = "Nombre"
    End Sub


    Sub LlenarMunicion()
        sql = "Declare @alm NVARCHAR(50)
                Set @alm = '" + ComboBox5.Text + "'

                IF @alm = 'TODOS'
                SELECT *
                  FROM [ABAS].[dbo].[Municion]
                  WHERE tipo = '" + ComboBox4.SelectedItem + "'
                  ELSE
                  SELECT *
                  FROM [ABAS].[dbo].[Municion]
                  WHERE almacen = @alm
                  AND tipo = '" + ComboBox4.SelectedItem + "'"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            DataGridView3.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try
    End Sub

    Sub LlenarMovMunicion()
        sql = "Declare @alm nvarchar(50)
            SET @alm = '" + ClasePrivilegios.Almacen + "'
            IF @alm = 'TODOS'
            SELECT *
              FROM [ABAS].[dbo].[MovimientoMunicion]
              WHERE [estadomovimiento] = 'No recibida'
              ELSE
            SELECT *
              FROM [ABAS].[dbo].[MovimientoMunicion]
              WHERE [estadomovimiento] = 'No recibida'
              AND almacenrecibe = '" + ClasePrivilegios.Almacen + "'"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            DataGridView4.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If Panel5.Visible = False Then
            Panel5.Visible = True
            LlenarMunicion()
        Else
            Panel5.Visible = False
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView3.Rows(index)

            CodigomunicionTextBox.Text = selectedRow.Cells(9).Value.ToString
        Catch

        End Try
        Panel5.Visible = False
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        LlenarMunicion()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        LlenarMunicion()
    End Sub

    Private Sub CmdTransferirMunicion_Click(sender As Object, e As EventArgs) Handles CmdTransferirMunicion.Click
        If Nivel = "1" Then
            MessageBox.Show("No cuenta con los permisos para realizar tranferencias")
        Else

            If CodigomunicionTextBox.Text = "" Then
                MessageBox.Show("El codigo de municion es requerido")
                CodigomunicionTextBox.Focus()
            Else
                sql = "INSERT INTO [dbo].[MovimientoMunicion]
                       ([codigomunicion]
                       ,[codigoenvia]
                       ,[fechaenvia]
                       ,[almacenenvia]
                       ,[almacenrecibe]
                       ,[estadomovimiento])
                 VALUES
                       ('" + CodigomunicionTextBox.Text + "'
                       ,'" + CodigoenviaTextBox.Text + "'
                       ,'" + FechaenviaDateTimePicker.Text + "'
                       ,'" + AlmacenenviaComboBox.Text + "'
                       ,'" + AlmacenrecibeComboBox.Text + "'
                       ,'" + EstadomovimientoTextBox.Text + "')"
                Ejecutar(sql)
                MsgBox("¡Municion transferida exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If

            CodigomunicionTextBox.Clear()
            LlenarMovMunicion()
        End If

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        CodigorecibeTextBox.Text = ClasePrivilegios.Codigo

        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView4.Rows(index)

            CodigomunicionTextBox1.Text = selectedRow.Cells(1).Value.ToString
            ComboBox6.Text = selectedRow.Cells(7).Value.ToString
        Catch

        End Try
        Panel6.Visible = True

        If ClasePrivilegios.Almacen <> "TODOS" Then
            ComboBox6.Enabled = False
        End If

        cn.Open()
        sql = "SELECT * FROM [MunicionFotos] WHERE [codigomunicion] = '" + CodigomunicionTextBox1.Text + "'"
        da = New SqlDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Foto"), Byte())
            Dim ms As New System.IO.MemoryStream(imageBuffer)
            Dim bmp As New Bitmap(Image.FromStream(ms))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureBox11.BackgroundImage = Nothing
            PictureBox11.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox11.BackgroundImage = bmp
            dt.Clear()
            dt.Reset()
            ms.Dispose()
            ms.Close()
        End If
        cn.Close()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("¡Desea rescibir esta municion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            sql = "UPDATE [dbo].[MovimientoMunicion]
                   SET [codigorecibe] = '" + CodigorecibeTextBox.Text + "'
                      ,[fecharecibe] = '" + FecharecibeDateTimePicker.Text + "'
                      ,[almacenrecibe] = '" + ComboBox6.Text + "'
                      ,[estadomovimiento] = 'Recibido'
                 WHERE [codigomunicion] = '" + CodigomunicionTextBox1.Text + "'"
            Ejecutar(sql)

            sql = "UPDATE [dbo].[Municion]
                   SET [almacen] = '" + ComboBox6.Text + "'
                 WHERE [codigo] = '" + CodigomunicionTextBox1.Text + "'"
            Ejecutar(sql)
            MsgBox("¡municion transferida exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

        Panel6.Visible = False
        LlenarMovMunicion()

    End Sub

    Private Sub ReporteCantidadDeMunicionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCantidadDeMunicionToolStripMenuItem.Click
        R_Municion.Show()
    End Sub

    Private Sub ReporteMovimientoMunicionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteMovimientoMunicionToolStripMenuItem.Click
        R_MovimientoMunicion.Show()
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        SerieTextBox.Text = ListBox1.SelectedValue
        CargarData()
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click
        If MsgBox("¡Desea actualizar esta arma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            Guardar_imagen()

            sql = "UPDATE [dbo].[Armeria]
                   SET [tipo] = '" + TipoComboBox.SelectedItem + "'
                      ,[calibre] = '" + CalibreComboBox.SelectedItem + "'
                      ,[marca] = '" + MarcaTextBox.Text + "'
                      ,[permisodpi] = '" + PermisodpiTextBox.Text + "'
                      ,[vdepermiso] = '" + VdepermisoTextBox.Text + "'
                      ,[estado] = '" + EstadoComboBox.SelectedItem + "'
                      ,[observaciones] = '" + ObservacionesTextBox.Text + "'
                      ,[color] = '" + cmb_Color.SelectedItem + "'
                      ,[idproveedor] = '" + txt_idproveedor.Text + "'
                      ,[almacen] = '" + AlmacenComboBox.Text + "'
                      ,[fechacompra] = '" + FechaCompra.Text + "'
                 WHERE [codigo] = '" + CodigoTextBox.Text + "'"
            Ejecutar(sql)

            MsgBox("¡Arma Actualizada Exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

        Limpiar()
    End Sub

    Sub CargarData()

        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "SELECT * FROM [ABAS].[dbo].[Armeria] where [serie] = '" + SerieTextBox.Text + "'"
            cmd.CommandText = sql

            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CodigoTextBox.Text = dr.Item("codigo").ToString
                TipoComboBox.SelectedItem = dr.Item("tipo").ToString
                CalibreComboBox.Text = dr.Item("calibre")
                MarcaTextBox.Text = dr.Item("marca").ToString
                PermisodpiTextBox.Text = dr.Item("permisodpi").ToString
                VdepermisoTextBox.Text = dr.Item("vdepermiso").ToString
                EstadoComboBox.SelectedItem = dr.Item("estado").ToString
                ObservacionesTextBox.Text = dr.Item("observaciones").ToString
                cmb_Color.SelectedItem = dr.Item("color").ToString
                txt_idproveedor.Text = dr.Item("idproveedor").ToString
                Cmb_Almacen.Text = dr.Item("almacen").ToString
                FechaCompra.Text = dr.Item("fechacompra").ToString
            End If

            dr.Close()
            cn.Close()
        Catch
        End Try

        cn.Open()
        sql = "SELECT * FROM [ArmeriaFotos] WHERE codigoarma = '" + CodigoTextBox.Text + "'"
        da = New SqlDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Foto"), Byte())
            Dim ms As New System.IO.MemoryStream(imageBuffer)
            Dim bmp As New Bitmap(Image.FromStream(ms))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureFoto.BackgroundImage = Nothing
            PictureFoto.BackgroundImageLayout = ImageLayout.Stretch
            PictureFoto.BackgroundImage = bmp
            dt.Clear()
            dt.Reset()
            ms.Dispose()
            ms.Close()
        End If
        cn.Close()

        cmdGuardar.Enabled = False

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        CargarData()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        CargarData()
    End Sub

    Private Sub ReporteDeArmasSucursalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeArmasSucursalToolStripMenuItem.Click
        R_ArmasAlmacen.Show()
    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs) Handles ComboBox3.TextChanged
        If ComboBox3.Text <> "" Then
            codealm = ComboBox3.Text.Substring(0, 2)
            CrearCodigoMunicion()
        End If
        CrearCodigoMunicion()
    End Sub

    Private Sub ComboBox3_ValueMemberChanged(sender As Object, e As EventArgs) Handles ComboBox3.ValueMemberChanged
        If ComboBox3.Text <> "" Then
            codealm = ComboBox3.Text.Substring(0, 2)
            CrearCodigoMunicion()
        End If
    End Sub
End Class