

Imports System.Data.SqlClient

Public Class FormInventarioMobiliarioEquiposOficina
    Private codealm As String
    Private code As String
    Private correlativo As String
    Private codeubi As String
    Private ReadOnly alm As String
    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub FormInventarioMaterialesEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRegistroEquipos()

        LoadMovimientosEquipos()

        LoadRecibirEquipo()

        Permisos()

        LlenarAlmacenes()
        LlenarAlmacenes2()
        LlenarAlmacenes3()
        LlenarAlmacenes4()
        LlenarAlmacenes5()
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

    Sub LlenarAlmacenes2()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        AlmacenEnvia.DataSource = ds.Tables(0)
        AlmacenEnvia.DisplayMember = "Nombre"
    End Sub
    Sub LlenarAlmacenes3()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        AlmacenRecibe.DataSource = ds.Tables(0)
        AlmacenRecibe.DisplayMember = "Nombre"

        ComboAlmacenMov.DisplayMember = "Nombre"
    End Sub
    Sub LlenarAlmacenes4()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        AlmacenRecibeMov.DataSource = ds.Tables(0)
        AlmacenRecibeMov.DisplayMember = "Nombre"

    End Sub

    Sub LlenarAlmacenes5()
        sql = "SELECT [Nombre]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        ComboAlmacenMov.DataSource = ds.Tables(0)
        ComboAlmacenMov.DisplayMember = "Nombre"
    End Sub


    Sub Permisos()
        If ClasePrivilegios.Nivel = "1" Then
            TabPage2.Enabled = False
            CmdTransferir.Enabled = False
        End If

    End Sub

    Sub LoadRegistroEquipos()

        PanelProveedores.Visible = False
        obj.LlamaProvedoresEquipos(DgvProveedoresA)

        Panel1.Visible = False
        EstadoComboBox.SelectedItem = "A"
        ColorComboBox.SelectedItem = "Negro"
        UbicacionComboBox.SelectedItem = "Asistente de Gerencia"
        If ClasePrivilegios.Almacen = "TODOS" Then
            AlmacenComboBox.Text = "SPS"
            AlmacenComboBox.Enabled = True
        Else
            AlmacenComboBox.Text = ClasePrivilegios.Almacen
            AlmacenComboBox.Enabled = False
        End If
    End Sub

    Sub LimpiarRegistroEquipos()
        MarcaTextBox.Clear()
        SerieTextBox.Clear()
        DescripcionTextBox.Clear()
        txt_idproveedor.Clear()

        CmdInsertar.Enabled = True
        CmdGuardar.Enabled = True
        EquiposDataGridView.Rows.Clear()
        LoadRegistroEquipos()
        CrearCodigo()
        PictureFoto.BackgroundImage = Nothing
    End Sub

    Private Sub CmdLimpiarRegistroEquipo_Click(sender As Object, e As EventArgs) Handles CmdLimpiarRegistroEquipo.Click
        LimpiarRegistroEquipos()
    End Sub

    Private Sub CmdInsertar_Click(sender As Object, e As EventArgs) Handles CmdInsertar.Click

        If SerieTextBox.Text = "" And CodigoTextBox.Text = "" Then
            MsgBox("¡Existen campos necesarios sin llenar para poder insertar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        Else
            EquiposDataGridView.Rows.Add(UbicacionComboBox.SelectedItem, MarcaTextBox.Text, ColorComboBox.SelectedItem, SerieTextBox.Text, CodigoTextBox.Text, AlmacenComboBox.Text, EstadoComboBox.SelectedItem, DescripcionTextBox.Text, txt_idproveedor.Text)
        End If
        CmdInsertar.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            SerieTextBox.Text = "N/A"
            SerieTextBox.Enabled = False
        Else
            SerieTextBox.Clear()
            SerieTextBox.Focus()
            SerieTextBox.Enabled = True
        End If
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click
        For Each row As DataGridViewRow In EquiposDataGridView.Rows
            If row.Cells(0).Value = "" Then
                MessageBox.Show("No se ha realizado ninguna registro no es permitido guardar")
            Else
                Guardar()
            End If
        Next
    End Sub

    Sub Guardar()

        Guardar_imagen()

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()
            sql = "INSERT INTO [dbo].[Equipos]
                   ([ubicacion]
                   ,[marca]
                   ,[color]
                   ,[serie]
                   ,[codigo]
                   ,[almacen]
                   ,[estado]
                   ,[descripcion]
                    ,[idproveedor])
             VALUES
                   (@ubicacion
                   ,@marca
                   ,@color
                   ,@serie
                   ,@codigo
                   ,@almacen
                   ,@estado
                   ,@descripcion
                   ,@idproveedor)"
            cmd = New SqlCommand(sql, cn)

            Try
                For Each row As DataGridViewRow In EquiposDataGridView.Rows
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@ubicacion", CStr(row.Cells("ubicacion").Value))
                    cmd.Parameters.AddWithValue("@marca", CStr(row.Cells("marca").Value))
                    cmd.Parameters.AddWithValue("@color", CStr(row.Cells("color").Value))
                    cmd.Parameters.AddWithValue("@serie", CStr(row.Cells("serie").Value))
                    cmd.Parameters.AddWithValue("@codigo", CStr(row.Cells("codigo").Value))
                    cmd.Parameters.AddWithValue("@almacen", CStr(row.Cells("almacen").Value))
                    cmd.Parameters.AddWithValue("@estado", CStr(row.Cells("estado").Value))
                    cmd.Parameters.AddWithValue("@descripcion", CStr(row.Cells("descripcion").Value))
                    cmd.Parameters.AddWithValue("@idproveedor", CStr(row.Cells("idproveedor").Value))
                    cmd.ExecuteNonQuery()
                Next
            Catch ex As Exception
                MessageBox.Show("Se ha realizado el registro exitosamente")
                LimpiarRegistroEquipos()
            End Try

            cn.Close()
            CodigoTextBox.Clear()
        End Using
    End Sub

    Sub Guardar_imagen()
        If PictureFoto.BackgroundImage IsNot Nothing Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * from EquiposFotos  where [codigoequipo] = '" + CodigoTextBox.Text + "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureFoto.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "UPDATE EquiposFotos SET Foto=@Foto WHERE [codigoequipo] ='" + CodigoTextBox.Text + "'"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Foto", ms1.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms1.Close()

            Else
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureFoto.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "INSERT INTO [dbo].[EquiposFotos]
                   ([codigoequipo]
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

    Sub CrearCodigo()
        If Panel1.Visible = False Then
            cmd = New SqlCommand("SELECT TOP (1) [idequipo]
            FROM [ABAS].[dbo].[Equipos] 
            GROUP BY idequipo
		    ORDER BY idequipo desc", cn) With {
                .CommandType = CommandType.Text
            }

            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                code = dr.Item("idequipo").ToString

                If code < 10 Then
                    correlativo = "00"
                End If

                If code >= 10 And code < 100 Then
                    correlativo = "0"
                End If

                If code >= 100 Then
                    correlativo = ""
                End If

                CodigoTextBox.Text = codealm & codeubi & correlativo & (code + 1)
            Else
                CodigoTextBox.Text = codealm & codeubi & "00" & 1
            End If
            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub AlmacenComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlmacenComboBox.SelectedIndexChanged
        If Panel1.Visible = True Then
            LlenarEquipos()
        Else
            codealm = (AlmacenComboBox.Text).Substring(0, 2)
            CrearCodigo()
        End If
    End Sub

    Private Sub UbicacionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UbicacionComboBox.SelectedIndexChanged
        If Panel1.Visible = True Then
            LlenarEquipos()
        Else
            codeubi = UCase(UbicacionComboBox.Text).Substring(0, 3)
            CrearCodigo()
        End If
    End Sub

    Private Sub EstadoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EstadoComboBox.SelectedIndexChanged
        If Panel1.Visible = True Then
            LlenarEquipos()
        Else
            CrearCodigo()
        End If
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles CmdActualizar.Click

        Guardar_imagen()

        If MsgBox("¡Desea actualizar este equipo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            sql = "UPDATE [dbo].[Equipos]
               SET [ubicacion] = '" + UbicacionComboBox.SelectedItem + "'
                  ,[marca] = '" + MarcaTextBox.Text + "'
                  ,[color] = '" + ColorComboBox.SelectedItem + "'
                  ,[serie] = '" + SerieTextBox.Text + "'
                  ,[estado] = '" + EstadoComboBox.SelectedItem + "'
                  ,[descripcion] = '" + DescripcionTextBox.Text + "'
                  ,[idproveedor] = '" + txt_idproveedor.Text + "'
             WHERE [codigo] = '" + CodigoTextBox.Text + "'"
            Ejecutar(sql)
            LimpiarRegistroEquipos()
            MsgBox("¡Equipo actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)

            UbicacionComboBox.SelectedItem = selectedRow.Cells(1).Value.ToString
            MarcaTextBox.Text = selectedRow.Cells(2).Value.ToString
            ColorComboBox.SelectedItem = selectedRow.Cells(3).Value.ToString
            SerieTextBox.Text = selectedRow.Cells(4).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(5).Value.ToString
            AlmacenComboBox.Text = selectedRow.Cells(6).Value.ToString
            EstadoComboBox.SelectedItem = selectedRow.Cells(7).Value.ToString
            DescripcionTextBox.Text = selectedRow.Cells(8).Value.ToString
            txt_idproveedor.Text = selectedRow.Cells(9).Value.ToString
        Catch
        End Try
        AlmacenComboBox.Enabled = False
        CmdInsertar.Enabled = False
        CmdGuardar.Enabled = False
        Panel1.Visible = False

        cn.Open()
        sql = "SELECT * FROM [EquiposFotos] WHERE [codigoequipo] = '" + CodigoTextBox.Text + "'"
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

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
            CodigoTextBox.Clear()
            LlenarEquipos()
        Else
            Panel1.Visible = False
        End If
    End Sub

    Sub LlenarEquipos()
        Try
            sql = "SELECT TOP (1000) *
      FROM [ABAS].[dbo].[Equipos]
      WHERE ubicacion = '" + UbicacionComboBox.SelectedItem + "'
      AND almacen = '" + AlmacenComboBox.Text + "'
      AND estado = '" + EstadoComboBox.SelectedItem + "'"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub

    Sub LoadMovimientosEquipos()
        ComboUbicacionMov.SelectedItem = "Asistente de Gerencia"
        If ClasePrivilegios.Almacen = "TODOS" Then
            AlmacenEnvia.Text = "SPS"
        Else
            AlmacenEnvia.Text = ClasePrivilegios.Almacen
            AlmacenEnvia.Enabled = False
        End If

        If ClasePrivilegios.Almacen = "TODOS" Then
            ComboAlmacenMov.Text = "SPS"
        Else
            ComboAlmacenMov.Text = ClasePrivilegios.Almacen
            ComboAlmacenMov.Enabled = False
        End If

        CodigoenviaTextBox.Text = ClasePrivilegios.Codigo
        CodigoenviaTextBox.Enabled = False
        EstadomovimientoTextBox.Enabled = False
        CodigoTextBox1.Clear()
        CodigoTextBox1.Enabled = False

        LlenarEquipos2()
    End Sub
    Private Sub CmdLimpiarMov_Click(sender As Object, e As EventArgs) Handles CmdLimpiarMov.Click
        LoadMovimientosEquipos()
    End Sub

    Sub LlenarEquipos2()
        Try
            sql = "SELECT TOP (1000) [idequipo]
      ,[ubicacion]
      ,[marca]
      ,[color]
      ,[serie]
      ,[codigo]
      ,[almacen]
      ,[estado]
      ,[descripcion]
      FROM [ABAS].[dbo].[Equipos]
      WHERE ubicacion = '" + ComboUbicacionMov.SelectedItem + "'
      AND almacen = '" + ComboAlmacenMov.Text + "'
      AND estado = '" + ComboEstadoMov.SelectedItem + "'"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub

    Sub LlenarMovimientos()
        Try
            If ClasePrivilegios.Almacen = "TODOS" Then
                sql = "SELECT    dbo.MovimientoEquipos.idmovimientoequipo, dbo.Equipos.descripcion, dbo.Equipos.marca, dbo.Equipos.color
                                , dbo.Equipos.codigo, dbo.Equipos.estado, dbo.MovimientoEquipos.codigoenvia
                                , dbo.MovimientoEquipos.codigorecibe, dbo.MovimientoEquipos.fechaenvia, 
                                dbo.MovimientoEquipos.fecharecibe, dbo.MovimientoEquipos.estadomovimiento
                                , dbo.MovimientoEquipos.almacenenvia, dbo.MovimientoEquipos.almacenrecibe
                                FROM dbo.Equipos INNER JOIN
                                dbo.MovimientoEquipos ON dbo.Equipos.codigo = dbo.MovimientoEquipos.codigoequipo
                    WHERE dbo.MovimientoEquipos.estadomovimiento = 'No Recibida'"
            Else
                sql = "SELECT   dbo.MovimientoEquipos.idmovimientoequipo, dbo.Equipos.descripcion, dbo.Equipos.marca, dbo.Equipos.color
                                , dbo.Equipos.codigo, dbo.Equipos.estado, dbo.MovimientoEquipos.codigoenvia
                                , dbo.MovimientoEquipos.codigorecibe, dbo.MovimientoEquipos.fechaenvia, 
                                dbo.MovimientoEquipos.fecharecibe, dbo.MovimientoEquipos.estadomovimiento
                                , dbo.MovimientoEquipos.almacenenvia, dbo.MovimientoEquipos.almacenrecibe
                                FROM dbo.Equipos INNER JOIN
                                dbo.MovimientoEquipos ON dbo.Equipos.codigo = dbo.MovimientoEquipos.codigoequipo
                    WHERE dbo.MovimientoEquipos.almacenrecibe = '" + ClasePrivilegios.Almacen + "'
                    AND dbo.MovimientoEquipos.estadomovimiento = 'No Recibida'"
            End If

            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            DataGridView3.DataSource = dt
        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView2.Rows(index)

            CodigoTextBox1.Text = selectedRow.Cells(5).Value.ToString
            AlmacenEnvia.Text = selectedRow.Cells(6).Value.ToString
        Catch ex As Exception
        End Try
        AlmacenEnvia.Enabled = False
    End Sub

    Private Sub CmdTransferir_Click(sender As Object, e As EventArgs) Handles CmdTransferir.Click
        If MsgBox("¡Desea transferir este equipo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            sql = "INSERT INTO [dbo].[MovimientoEquipos]
           ([codigoequipo]
           ,[codigoenvia]
           ,[fechaenvia]
           ,[estadomovimiento]
           ,[almacenenvia]
           ,[almacenrecibe])
     VALUES
           ('" + CodigoTextBox1.Text + "'
           ,'" + CodigoenviaTextBox.Text + "'
           ,'" + FechaenviaDateTimePicker.Text + "'
           ,'" + EstadomovimientoTextBox.Text + "'
           ,'" + AlmacenEnvia.Text + "'
           ,'" + AlmacenRecibe.Text + "')"
            Ejecutar(sql)
            MsgBox("¡Equipo transferido exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
        LoadMovimientosEquipos()
    End Sub

    Sub LoadRecibirEquipo()
        LlenarMovimientos()
        Panel3.Visible = False
        TxtCodigoRecibe.Text = ClasePrivilegios.Codigo
        TxtCodigoRecibe.Enabled = False
        CodigoTextBox2.Enabled = False
        IdmovimientoequipoTextBox.Enabled = False
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView3.Rows(index)

            IdmovimientoequipoTextBox.Text = selectedRow.Cells(0).Value.ToString
            CodigoTextBox2.Text = selectedRow.Cells(4).Value.ToString
            AlmacenRecibeMov.Text = selectedRow.Cells(12).Value.ToString
        Catch ex As Exception
        End Try
        AlmacenRecibeMov.Enabled = True
        Panel3.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¡Desea rescibir este equipo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            sql = "UPDATE [dbo].[MovimientoEquipos]
                   SET [codigorecibe] = '" + TxtCodigoRecibe.Text + "'
                      ,[fecharecibe] = '" + FechaRecibe.Text + "'
                      ,[estadomovimiento] = 'Recibida'
                      ,[almacenrecibe] = '" + AlmacenRecibeMov.Text + "'
                 WHERE [idmovimientoequipo] = '" + IdmovimientoequipoTextBox.Text + "'"
            Ejecutar(sql)

            sql = "UPDATE [dbo].[Equipos]
                   SET [almacen] = '" + AlmacenRecibeMov.Text + "'
                 WHERE [codigo] = '" + CodigoTextBox2.Text + "'"
            Ejecutar(sql)
            MsgBox("¡Equipo transferido exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
        LoadRecibirEquipo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LlenarMovimientos()
    End Sub

    Private Sub MovimientosDeEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeEquiposToolStripMenuItem.Click
        R_MovimientosEquipo.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelProveedores.Visible = False Then
            PanelProveedores.Visible = True
        Else
            PanelProveedores.Visible = False
        End If
    End Sub

    Private Sub DgvProveedoresA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProveedoresA.CellContentClick
        PanelProveedores.Visible = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DgvProveedoresA.Rows(index)
            txt_idproveedor.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try
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

    Private Sub EquiposPorAlmacenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EquiposPorAlmacenToolStripMenuItem.Click
        R_Equipos.Show()
    End Sub

    'Sub CargarId()
    '    cmd = New SqlCommand("SELECT max(idmaterial) as ID FROM [ABAS].[dbo].[Materiales]", cn) With {
    '            .CommandType = CommandType.Text
    '        }
    '    cn.Open()
    '    dr = cmd.ExecuteReader()
    '    If dr.Read() Then
    '        idmaterial = dr.Item("ID").ToString
    '    End If
    '    dr.Close()
    '    cn.Close()
    'End Sub

    Private Sub ComboEstadoMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEstadoMov.SelectedIndexChanged
        LlenarEquipos2()
    End Sub

    Private Sub ComboAlmacenMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAlmacenMov.SelectedIndexChanged
        LlenarEquipos2()
    End Sub

    Private Sub ComboUbicacionMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboUbicacionMov.SelectedIndexChanged
        LlenarEquipos2()
    End Sub

End Class