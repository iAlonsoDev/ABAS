Imports System.Data.SqlClient

Public Class FormInventarioProveedoresAlmacenesVehiculos

    Dim code, correlativo, codealm, idvehiculo, tipo As String
    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Almacenes' Puede moverla o quitarla según sea necesario.
        Me.AlmacenesTableAdapter.Fill(Me.ABASDataSet.Almacenes)
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        ''Me.ProveedoresTableAdapter.Fill(Me.ABASDataSet.Proveedores)

        Llenar_codigo()

        ComboBox1.SelectedItem = "ARMERIA"

        LoadVehiculos()

    End Sub

    Sub LlenarAlmacenes()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboBox2.DataSource = ds.Tables(0)
        ComboBox2.DisplayMember = "Nombre"
    End Sub


    Private Sub Btm_guardar_Click(sender As Object, e As EventArgs) Handles btm_guardar.Click
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "Select * From Proveedores WHERE telefono = '" + txt_telefono1.Text + "'"
        cmd.CommandText = sql

        'Ejecutamos una lectura RRHH la tabla
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            MessageBox.Show("Ya existe un registro con el mismo numero de telefono", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_codigo.Clear()
        Else

            sql = "INSERT INTO [dbo].[Proveedores]
            ([nombreproveedor]
            ,[direccion]
            ,[telefono]
            ,[telefono2]
            ,[correo]
            ,[cai]
            ,[web]
            ,[categoria]
            ,[nombrecontacto]
            ,[telefonocontacto]
            ,[rtn])
     VALUES
            ('" + txt_proveedor.Text + "'
            ,'" + txt_direccion.Text + "'
            ,'" + txt_telefono1.Text + "'
            ,'" + txt_telefono2.Text + "'
            ,'" + Txt_correo.Text + "'
            ,'" + Txt_cai.Text + "'
            ,'" + Txt_web.Text + "'
            ,'" + ComboBox1.SelectedItem + "'
            ,'" + NombrecontactoTextBox.Text + "'
            ,'" + TelefonocontactoTextBox.Text + "'
            ,'" + RtnTextBox.Text + "')"
            Ejecutar(sql)


            MessageBox.Show("Registro de Proveedor Exitoso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Limpiar_codigo()
            Llenar_codigo()

        End If
        dr.Close()
        cn.Close()

    End Sub

    Private Sub Btm_actualizar_Click(sender As Object, e As EventArgs) Handles btm_actualizar.Click
        If txt_codigo.Text = "" Then
            MessageBox.Show("No hay registro por actualizar, Seleccione un registro")
        Else
            If MsgBox("¡Desea actualizar el proveedor " + txt_proveedor.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                sql = "update Proveedores set
                            direccion ='" + txt_direccion.Text + "',
                            telefono ='" + txt_telefono1.Text + "',
                            telefono2 = '" + txt_telefono2.Text + "',
                            correo ='" + Txt_correo.Text + "',
                            cai ='" + Txt_cai.Text + "',
                            web ='" + Txt_web.Text + "',
                            categoria = '" + ComboBox1.SelectedItem + "',
                            nombrecontacto = '" + NombrecontactoTextBox.Text + "',
                            telefonocontacto = '" + TelefonocontactoTextBox.Text + "',
                            rtn = '" + RtnTextBox.Text + "'
                            where idproveedor = '" + txt_codigo.Text + "'"

                Ejecutar(sql)

                Llenar_codigo()
                Limpiar_codigo()
                txt_codigo.Enabled = True
                btm_guardar.Enabled = True

                MessageBox.Show("Datos del proveedor actualizados correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        ''
    End Sub

    Private Sub Btm_eliminar_Click(sender As Object, e As EventArgs) Handles btm_eliminar.Click
        If txt_codigo.Text = "" Then
            MessageBox.Show("No hay registro por eliminar, Seleccione un registro")
        Else
            If MsgBox("¡Desea eliminar al proveedor " + txt_proveedor.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then

                sql = "delete Proveedores where idproveedor = '" + txt_codigo.Text + "'"
                Ejecutar(sql)

                Llenar_codigo()
                Limpiar_codigo()
                txt_codigo.Enabled = True
                btm_guardar.Enabled = True
                MessageBox.Show("Proveedor eliminado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

            End If
        End If
    End Sub


    Sub Llenar_codigo()
        cn.Open()
        sql = "SELECT TOP (1000) * FROM [ABAS].[dbo].[Proveedores]"
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        ProveedoresDataGridView.DataSource = dt
        cn.Close()
    End Sub

    Sub Limpiar_codigo()
        txt_codigo.Clear()
        txt_proveedor.Clear()
        txt_direccion.Clear()
        txt_telefono1.Clear()
        txt_telefono2.Clear()
        Txt_cai.Clear()
        Txt_correo.Clear()
        Txt_web.Clear()
        RtnTextBox.Clear()
        NombrecontactoTextBox.Clear()
        TelefonocontactoTextBox.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar_codigo()
    End Sub

    Private Sub ProveedoresDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = ProveedoresDataGridView.Rows(index)

            txt_codigo.Text = selectedRow.Cells(0).Value.ToString
            txt_proveedor.Text = selectedRow.Cells(1).Value.ToString
            txt_direccion.Text = selectedRow.Cells(2).Value.ToString
            txt_telefono1.Text = selectedRow.Cells(3).Value.ToString
            txt_telefono2.Text = selectedRow.Cells(4).Value.ToString
            Txt_correo.Text = selectedRow.Cells(5).Value.ToString
            Txt_cai.Text = selectedRow.Cells(6).Value.ToString
            Txt_web.Text = selectedRow.Cells(7).Value.ToString
            ComboBox1.SelectedItem = selectedRow.Cells(8).Value.ToString
            NombrecontactoTextBox.Text = selectedRow.Cells(9).Value.ToString
            TelefonocontactoTextBox.Text = selectedRow.Cells(10).Value.ToString
            RtnTextBox.Text = selectedRow.Cells(11).Value.ToString
            txt_codigo.Enabled = False
            btm_guardar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "Select * From Almacenes WHERE nombre = '" + NombreTextBox.Text + "'"
        cmd.CommandText = sql

        'Ejecutamos una lectura RRHH la tabla
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            MessageBox.Show("Ya existe un registro con el mismo nombre", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NombreTextBox.Clear()
            dr.Close()
            cn.Close()
        Else
            sql = "INSERT INTO [dbo].[Almacenes]
           ([Nombre])
           VALUES
           ('" + NombreTextBox.Text + "')"
            Ejecutar(sql)
            MessageBox.Show("Registro de Almacen Exitoso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dr.Close()
            cn.Close()

            CargarId()

            sql = "UPDATE [dbo].[Almacenes]
               SET [Identificador] = '" + correlativo + "'
             WHERE id = '" + code + "'"
            Ejecutar(sql)

        End If

        LimpiarAlmacenes()
    End Sub

    Sub CargarId()
        cmd = New SqlCommand("SELECT top(1) id
                  FROM [ABAS].[dbo].[Almacenes]
                  order by id desc", cn) With {
                .CommandType = CommandType.Text
            }
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            code = dr.Item("id").ToString
            correlativo = "ALM" & code
        Else
            correlativo = "ALM" & 1
        End If
        dr.Close()
        cn.Close()
    End Sub

    Sub LimpiarAlmacenes()
        IdTextBox.Clear()
        NombreTextBox.Clear()
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Almacenes' Puede moverla o quitarla según sea necesario.
        Me.AlmacenesTableAdapter.Fill(Me.ABASDataSet.Almacenes)
        Button3.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IdTextBox.Text = "" Then
            MessageBox.Show("No hay registro por actualizar, Seleccione un registro")
        Else
            If MsgBox("¡Desea actualizar el almacen " + NombreTextBox.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                sql = "UPDATE [dbo].[Almacenes]
                       SET [Nombre] = '" + NombreTextBox.Text + "'
                     WHERE [Id] = '" + IdTextBox.Text + "'"
                Ejecutar(sql)
                MessageBox.Show("Datos del almacen fueron actualizados correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        LimpiarAlmacenes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IdTextBox.Text = "" Then
            MessageBox.Show("No hay registro por eliminar, Seleccione un registro")
        Else
            If MsgBox("¡Desea eliminar el almacen " + NombreTextBox.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then

                sql = "DELETE FROM [dbo].[Almacenes]
                       WHERE [Id] = '" + IdTextBox.Text + "'"
                Ejecutar(sql)

                MessageBox.Show("Almacen eliminado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
        LimpiarAlmacenes()
    End Sub

    Private Sub AlmacenesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AlmacenesDataGridView.CellContentClick
        Button3.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        LimpiarVehiculo()
    End Sub

    Sub LimpiarVehiculo()
        DescripcionTextBox.Clear()
        ModeloTextBox.Clear()
        PlacaTextBox.Clear()
        RevisionTextBox.Clear()
        MatriculaTextBox.Clear()
        ChasisTextBox.Clear()
        ObservacionTextBox.Clear()
        ColorTextBox.Clear()
        MarcaTextBox.Clear()


        Button8.Enabled = True

        PictureBox1.BackgroundImage = Nothing

    End Sub


    Sub LoadVehiculos()

        TipoRadioButton.Checked = True

        Dim anio As String = Date.Now.Year
        Dim n As Integer
        With AnioComboBox
            For n = 1990 To anio + 1
                AnioComboBox.Items.Add(n)
                AnioComboBox.Text = anio
            Next
        End With

        LlenarAlmacenes()

        ComboBox2.Text = "SPS"

        ObservacionTextBox.Text = "Ninguna"

        Llenavehiculos()

    End Sub

    Sub Llenavehiculos()
        sql = "SELECT [descripcion]
      ,[marca]
      ,[modelo]
      ,[almacen]
      ,[placa]
      ,[revision]
      ,[matricula]
      ,[fechadecompra]
      ,[color]
      ,[chasis]
      ,[observacion]
      ,[anio]
      ,[codigo]
      ,[tipo]
  FROM [ABAS].[dbo].[Vehiculos]"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            VehiculosDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub TipoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TipoRadioButton.CheckedChanged

        If TipoRadioButton.Checked = True Then
            tipo = "Automovil"
        Else
            tipo = "Motocicleta"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If TipoRadioButton.Checked = True Then
            tipo = "Automovil"
        Else
            tipo = "Motocicleta"
        End If
    End Sub

    Private Sub CmdInsertarMunicion_Click(sender As Object, e As EventArgs) Handles CmdInsertarMunicion.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }
        Dim dialogo As DialogResult = openFileDialog1.ShowDialog()
        If (dialogo = DialogResult.OK) Then
            Dim bmp As New Bitmap(Image.FromFile(openFileDialog1.FileName))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureBox1.BackgroundImage = Nothing
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox1.BackgroundImage = bmp
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        codealm = ComboBox2.Text.Substring(0, 2)
        CrearCodigo()
    End Sub

    Private Sub VehiculosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VehiculosDataGridView.CellContentClick

        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = VehiculosDataGridView.Rows(index)

            DescripcionTextBox.Text = selectedRow.Cells(0).Value.ToString
            MarcaTextBox.Text = selectedRow.Cells(1).Value.ToString
            ModeloTextBox.Text = selectedRow.Cells(2).Value.ToString
            ComboBox2.SelectedItem = selectedRow.Cells(3).Value.ToString
            PlacaTextBox.Text = selectedRow.Cells(4).Value.ToString
            RevisionTextBox.Text = selectedRow.Cells(5).Value.ToString
            MatriculaTextBox.Text = selectedRow.Cells(6).Value.ToString
            FechadecompraDateTimePicker.Text = selectedRow.Cells(7).Value.ToString
            ColorTextBox.Text = selectedRow.Cells(8).Value.ToString
            ChasisTextBox.Text = selectedRow.Cells(9).Value.ToString
            ObservacionTextBox.Text = selectedRow.Cells(10).Value.ToString
            AnioComboBox.SelectedItem = selectedRow.Cells(11).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(12).Value.ToString
            tipo = selectedRow.Cells(13).Value.ToString


            If tipo = "Automovil" Then
                TipoRadioButton.Checked = True
            Else
                RadioButton1.Checked = True
            End If


        Catch ex As Exception

            ex.ToString()

        End Try



            cn.Open()
        sql = "SELECT * FROM [VehiculosFotos] WHERE [codigovehiculo] = '" + CodigoTextBox.Text + "'"
        da = New SqlDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Foto"), Byte())
            Dim ms As New System.IO.MemoryStream(imageBuffer)
            Dim bmp As New Bitmap(Image.FromStream(ms))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureBox1.BackgroundImage = Nothing
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox1.BackgroundImage = bmp
            dt.Clear()
            dt.Reset()
            ms.Dispose()
            ms.Close()
        End If
        cn.Close()

        Button8.Enabled = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CodigoTextBox.Text = "" Then
            MessageBox.Show("No hay registro por actualizar, Seleccione un registro")
        Else
            If MsgBox("¡Desea actualizar el vehiculo " + ModeloTextBox.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                sql = "UPDATE [dbo].[Vehiculos]
               SET [descripcion] = '" + DescripcionTextBox.Text + "'
                  ,[marca] = '" + MarcaTextBox.Text + "'
                  ,[modelo] = '" + ModeloTextBox.Text + "'
                  ,[almacen] = '" + ComboBox2.Text + "'
                  ,[placa] = '" + PlacaTextBox.Text + "'
                  ,[revision] = '" + RevisionTextBox.Text + "'
                  ,[matricula] = '" + MatriculaTextBox.Text + "'
                  ,[fechadecompra] = '" + FechadecompraDateTimePicker.Text + "'
                  ,[color] = '" + ColorTextBox.Text + "'
                  ,[chasis] = '" + ChasisTextBox.Text + "'
                  ,[observacion] = '" + ObservacionTextBox.Text + "'
                  ,[anio] = '" + AnioComboBox.Text + "'
                  ,[tipo] = '" + tipo + "'
             WHERE [codigo] = '" + CodigoTextBox.Text + "'"

                Ejecutar(sql)

                LimpiarVehiculo()

                MessageBox.Show("Datos del vehiculo actualizados correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If txt_codigo.Text = "" Then
            MessageBox.Show("No hay registro por eliminar, Seleccione un registro")
        Else
            If MsgBox("¡Desea eliminar el vehiculo " + ModeloTextBox.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then

                sql = "delete Vehiculos where codigo = '" + CodigoTextBox.Text + "'"
                Ejecutar(sql)

                LimpiarVehiculo()
                MessageBox.Show("Vehiculo eliminado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ReporteDeArmasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeArmasToolStripMenuItem.Click
        R_Vehiculos.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        GuardarImagen()

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "Select * From Vehiculos WHERE chasis = '" + ChasisTextBox.Text + "'"
        cmd.CommandText = sql

        'Ejecutamos una lectura RRHH la tabla
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            MessageBox.Show("Ya existe un registro de vehiculo con este chasis", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql = "INSERT INTO [dbo].[Vehiculos]
           ([descripcion]
           ,[marca]
           ,[modelo]
           ,[almacen]
           ,[placa]
           ,[revision]
           ,[matricula]
           ,[fechadecompra]
           ,[color]
           ,[chasis]
           ,[observacion]
           ,[anio]
           ,[codigo]
           ,[tipo])
     VALUES
           ('" + DescripcionTextBox.Text + "'
           ,'" + MarcaTextBox.Text + "'
           ,'" + ModeloTextBox.Text + "'
           ,'" + ComboBox2.Text + "'
           ,'" + PlacaTextBox.Text + "'
           ,'" + RevisionTextBox.Text + "'
           ,'" + MatriculaTextBox.Text + "'
           ,'" + FechadecompraDateTimePicker.Text + "'
           ,'" + ColorTextBox.Text + "'
           ,'" + ChasisTextBox.Text + "'
           ,'" + ObservacionTextBox.Text + "'
           ,'" + AnioComboBox.Text + "'
           ,'" + CodigoTextBox.Text + "'
           ,'" + tipo + "')"
            Ejecutar(sql)

            MessageBox.Show("Registro de Vehiculo Exitoso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        dr.Close()
        cn.Close()

        LimpiarVehiculo()

    End Sub

    Sub GuardarImagen()
        If PictureBox1.BackgroundImage IsNot Nothing Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * from [VehiculosFotos]  where [codigovehiculo] = '" + CodigoTextBox.Text + "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureBox1.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "UPDATE [VehiculosFotos] SET Foto=@Foto WHERE [codigovehiculo] ='" + CodigoTextBox.Text + "'"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Foto", ms1.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms1.Close()

            Else
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                PictureBox1.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "INSERT INTO [dbo].[VehiculosFotos]
                   ([codigovehiculo]
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
        cmd = New SqlCommand("SELECT top(1) [id]
            FROM [ABAS].[dbo].[Vehiculos]
            GROUP BY [id]
		    ORDER BY [id] desc", cn) With {
                .CommandType = CommandType.Text
            }

        cn.Close()
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then

            idvehiculo = Convert.ToInt16(dr.Item("id").ToString)

            If idvehiculo < 10 Then
                correlativo = "00"
            End If

            If idvehiculo >= 10 And idvehiculo < 100 Then
                correlativo = "0"
            End If

            If idvehiculo >= 100 Then
                correlativo = ""
            End If

            CodigoTextBox.Text = codealm & correlativo & (idvehiculo + 1)
        Else
            CodigoTextBox.Text = codealm & "00" & 1
        End If
        dr.Close()
        cn.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IdTextBox.Clear()
        NombreTextBox.Clear()
        IdentificadorTextBox.Clear()
        Button3.Enabled = True
    End Sub
End Class