Imports System.Data.SqlClient

Public Class FormInventarioMaterialesEquiposSeguridad

    Private Sub FormInventarioMaterialesEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRegistroMateriales()

        LoadTranferenciaMateriales()

        Permisos()

        LlenarAlmacenes()
        LlenarAlmacenes2()
        LlenarAlmacenes3()
        LlenarAlmacenes4()
        LlenarTiposMateriales()
    End Sub

    Sub LlenarTiposMateriales()
        sql = "SELECT [nombre]
        FROM [ABAS].[dbo].[TipoMateriales]
        Order by Nombre Asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        DescripcionComboBox.DataSource = ds.Tables(0)
        DescripcionComboBox.DisplayMember = "Nombre"
    End Sub


    Sub LlenarAlmacenes()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "Nombre"

        ComboBox2.DataSource = ds.Tables(0)
        ComboBox2.DisplayMember = "Identificador"
    End Sub

    Sub LlenarAlmacenes2()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboDesde.DataSource = ds.Tables(0)
        ComboDesde.DisplayMember = "Nombre"

        ComboBox3.DataSource = ds.Tables(0)
        ComboBox3.DisplayMember = "Identificador"
    End Sub

    Sub LlenarAlmacenes3()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboHacia.DataSource = ds.Tables(0)
        ComboHacia.DisplayMember = "Nombre"

        ComboBox4.DataSource = ds.Tables(0)
        ComboBox4.DisplayMember = "Identificador"
    End Sub

    Sub LlenarAlmacenes4()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboRecibe.DataSource = ds.Tables(0)
        ComboRecibe.DisplayMember = "Nombre"

        ComboBox5.DataSource = ds.Tables(0)
        ComboBox5.DisplayMember = "Identificador"
    End Sub

    Sub Permisos()
        If ClasePrivilegios.Almacen = "TODOS" Then
            ComboBox1.Text = "SPS"
        Else
            ComboBox1.Text = ClasePrivilegios.Almacen
            ComboBox1.Enabled = False
        End If
    End Sub


    Sub LlenarMovimientosMateriales()
        Try
            cn.Open()

            sql = "DECLARE @ALM AS NVARCHAR(50)
            SET @ALM = '" + ClasePrivilegios.Almacen + "'
            IF @ALM = 'TODOS'
            SELECT *
              FROM [ABAS].[dbo].[MovimientoMateriales]
             WHERE recibemov = 'No recibida'
             ELSE
             SELECT *
              FROM [ABAS].[dbo].[MovimientoMateriales]
             WHERE almacen = @ALM and recibemov = 'No recibida'"

            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            MovimientoMaterialesDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Llenarmateriales()
    End Sub

    Private Sub Cmd_Limpiar_Click(sender As Object, e As EventArgs) Handles Cmd_Limpiar.Click
        LoadRegistroMateriales()
    End Sub

    Sub LoadRegistroMateriales()
        CantInicial.Text = 0
        CantInicial.Enabled = False
        CantMateriales.Text = 0
        CantFinal.Text = 0
        CantFinal.Enabled = False
        IdMaterialTextBox.Clear()
        IdMaterialTextBox.Enabled = False
        CmdRegistrarMateriales.Enabled = True
        ComboBox1.Enabled = True
        DescripcionComboBox.Enabled = True
        EstadoMateriales.Enabled = True

        EstadoMateriales.SelectedItem = "A"
        DescripcionComboBox.Text = "Aceite Maquina de Coser"
        Permisos()
        Llenarmateriales()
        LlenarTiposMateriales()
        NombreTextBox.Clear()
    End Sub

    Sub Llenarmateriales()
        Try
            sql = "SELECT TOP (1000) * FROM [ABAS].[dbo].[Materiales]"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            MaterialesDataGridView.DataSource = dt
        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub

    Sub Llenarmateriales2()
        Try
            sql = "SELECT TOP (1000) * FROM [ABAS].[dbo].[Materiales]"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            MaterialesDataGridView1.DataSource = dt
        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub CmdRegistrarMateriales_Click(sender As Object, e As EventArgs) Handles CmdRegistrarMateriales.Click
        If MsgBox("¡Desea registrar los nuevos materiales?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            cmd = New SqlCommand("SELECT * FROM [ABAS].[dbo].[Materiales]
                                                WHERE [descripcion] = '" + DescripcionComboBox.Text + "' and [estado] = '" + EstadoMateriales.SelectedItem + "'
                                                and [almacen] = '" + ComboBox1.Text + "'", cn)
            cn.Open()
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                MessageBox.Show("Ya existe un registro con estas categorias, seleccionelo y agrege mas inventario")

                dr.Close()
                cn.Close()
            Else

                sql = "INSERT INTO [dbo].[Materiales]
                       ([descripcion]
                       ,[estado]
                       ,[almacen]
                       ,[cant]
                       ,[fecharegistro])
                 VALUES
                       ('" + DescripcionComboBox.Text + "'
                       ,'" + EstadoMateriales.SelectedItem + "'
                       ,'" + ComboBox1.Text + "'
                       ,'" + CantFinal.Text + "'
                       ,'" + DateTimePicker2.Text + "')"
                Ejecutar(sql)

                dr.Close()
                cn.Close()

                CargarId()
                sql = "INSERT INTO [dbo].[MaterialesRIngresos]
                       ([almacen]
                       ,[idmaterial]
                       ,[fechaingreso]
                       ,[cant])
                 VALUES
                       ('" + ComboBox1.Text + "'
                       ,'" + IdMaterialTextBox.Text + "'
                       ,'" + DateTimePicker2.Text + "'
                       ,'" + CantMateriales.Text + "')"
                Ejecutar(sql)

                MsgBox("¡Materiales registrados exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")

            End If

        End If
        LoadRegistroMateriales()
    End Sub

    Private Sub CantMateriales_TextChanged(sender As Object, e As EventArgs) Handles CantMateriales.TextChanged
        CantFinal.Text = Val(CantInicial.Text) + Val(CantMateriales.Text)
    End Sub

    Private Sub MaterialesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MaterialesDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = MaterialesDataGridView.Rows(index)
            IdMaterialTextBox.Text = selectedRow.Cells(0).Value.ToString
            DescripcionComboBox.Text = selectedRow.Cells(1).Value.ToString
            EstadoMateriales.SelectedItem = selectedRow.Cells(2).Value.ToString
            ComboBox1.Text = selectedRow.Cells(3).Value.ToString
        Catch ex As Exception
        End Try
        LLenarCantidad()
        CmdRegistrarMateriales.Enabled = False
        ComboBox1.Enabled = False
        DescripcionComboBox.Enabled = False
        EstadoMateriales.Enabled = False
    End Sub


    Sub LLenarCantidad()
        'Try
        cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
        sql = "SELECT cant FROM [ABAS].[dbo].[Materiales]
                                  WHERE [idmaterial] = '" + IdMaterialTextBox.Text + "'"
        cmd.CommandText = sql

            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CantInicial.Text = dr.Item("CANT").ToString
            Else
                CantInicial.Text = 0
            End If

            dr.Close()
            cn.Close()
        'Catch
        'End Try

    End Sub

    Private Sub CmdAgregarMateriales_Click(sender As Object, e As EventArgs) Handles CmdAgregarMateriales.Click
        If MsgBox("¡Desea guardar los nuevos materiales?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If CantFinal.Text = 0 Then
                If MsgBox("La cantidad final sera 0, Desea confirmar", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                    AgregarMateriales()
                End If
            Else
                AgregarMateriales()
            End If
            MsgBox("¡Materiales agregados exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Sub AgregarMateriales()

        sql = "UPDATE [ABAS].[dbo].[materiales] SET [cant] = '" + CantFinal.Text + "'
                      WHERE [idmaterial] = '" + IdMaterialTextBox.Text + "'"
        Ejecutar(sql)

        Try
            sql = "INSERT INTO [dbo].[MaterialesRIngresos]
                       ([almacen]
                       ,[idmaterial]
                       ,[fechaingreso]
                       ,[cant])
                 VALUES
                       ('" + ComboBox1.Text + "'
                       ,'" + IdMaterialTextBox.Text + "'
                       ,'" + DateTimePicker2.Text + "'
                       ,'" + CantMateriales.Text + "')"
            Ejecutar(sql)
        Catch

        End Try
        LoadRegistroMateriales()

    End Sub

    Private Sub MaterialesDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MaterialesDataGridView1.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = MaterialesDataGridView1.Rows(index)

            IdMaterialMovimiento.Text = selectedRow.Cells(0).Value.ToString
            DescripcionMovimiento.Text = selectedRow.Cells(1).Value.ToString
            EstadoMovimiento.Text = selectedRow.Cells(2).Value.ToString
            ComboDesde.Text = selectedRow.Cells(3).Value.ToString
        Catch ex As Exception
        End Try

        ComboDesde.Enabled = False

        LlenarCantidades()

        MaterialesDataGridView1.Visible = False
    End Sub


    Sub LlenarCantidades()

        cmd = New SqlCommand("SELECT cant
                                  FROM [ABAS].[dbo].[Materiales]
                                  WHERE [idmaterial] = '" + IdMaterialMovimiento.Text + "'", cn) With {
                                            .CommandType = CommandType.Text
                  }
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            CantIniEnvia.Text = dr.Item("CANT").ToString
        Else
            CantIniEnvia.Text = 0
        End If

        dr.Close()
        cn.Close()

        cmd = New SqlCommand("SELECT cant
                                  FROM [ABAS].[dbo].[Materiales]
                                  WHERE [descripcion] = '" + DescripcionMovimiento.Text + "'
                                  and [almacen] = '" + ComboHacia.Text + "'
                                  and [estado] = '" + EstadoMovimiento.Text + "'", cn) With {
                                            .CommandType = CommandType.Text
                  }
            cn.Open()
            dr = cmd.ExecuteReader()

        If dr.Read() Then
            CantIniRecibe.Text = dr.Item("CANT").ToString
        Else
            CantIniRecibe.Text = 0
            MessageBox.Show("El almacen seleccionado no tiene suficiente inventario para transferir")
        End If

        dr.Close()
        cn.Close()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MaterialesDataGridView1.Visible = True Then
            MaterialesDataGridView1.Visible = False
        Else
            MaterialesDataGridView1.Visible = True
            Llenarmateriales2()
        End If
    End Sub

    Private Sub Cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles Cmd_Nuevo.Click
        LoadTranferenciaMateriales()
    End Sub

    Private Sub CantMovRecibe_TextChanged(sender As Object, e As EventArgs) Handles CantMovRecibe.TextChanged
        CantFinRecibe.Text = Val(CantIniRecibe.Text) + Val(CantMovRecibe.Text)
    End Sub

    Private Sub CantMoverEnvia_TextChanged(sender As Object, e As EventArgs) Handles CantMoverEnvia.TextChanged
        CantFinalEnvia.Text = Val(CantIniEnvia.Text) - Val(CantMoverEnvia.Text)
        CantMovRecibe.Text = CantMoverEnvia.Text
    End Sub

    Private Sub Cmd_Transferir_Click(sender As Object, e As EventArgs) Handles Cmd_Transferir.Click
        If CantMoverEnvia.Text = "" Or CantMoverEnvia.Text = 0 Then
            MessageBox.Show("Debe asignar la cantidad para transferir")
            CantMoverEnvia.Focus()
        Else
            If MsgBox("¡Desea trasnferir los materiales?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                Transferir()
                MsgBox("¡Materiales transferidos exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If

            LoadTranferenciaMateriales()

        End If

    End Sub

    Sub Transferir()
        If IdMaterialMovimiento.Text = "" Then
            MsgBox("¡Existen campos vacios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        Else
            sql = "INSERT INTO [dbo].[MovimientoMateriales]
           ([descripcion]
           ,[idmaterial]
           ,[cant]
           ,[fechaenvia]
           ,[recibemov]
           ,[almacen]
           ,[estado])
     VALUES
           ('" + DescripcionMovimiento.Text + "'
           ,'" + IdMaterialMovimiento.Text + "'
           ,'" + CantMoverEnvia.Text + "'
           ,'" + FechaMovimiento.Text + "'
           ,'No recibida'
           ,'" + ComboHacia.Text + "'
           ,'" + EstadoMovimiento.Text + "')"
            Ejecutar(sql)
        End If

        sql = "UPDATE [dbo].[Materiales]
                           SET cant = '" + CantFinalEnvia.Text + "'
                         WHERE [idmaterial] = '" + IdMaterialMovimiento.Text + "'"
        Ejecutar(sql)

    End Sub

    Private Sub MovimientoMaterialesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovimientoMaterialesDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = MovimientoMaterialesDataGridView.Rows(index)

            IdMov.Text = selectedRow.Cells(0).Value.ToString
            DescripcionRecibe.Text = selectedRow.Cells(1).Value.ToString
            IDmaterialrecibe.Text = selectedRow.Cells(2).Value.ToString
            CantRecibe.Text = selectedRow.Cells(3).Value.ToString
            ComboRecibe.Text = selectedRow.Cells(7).Value.ToString
            EstadoRecibe.Text = selectedRow.Cells(8).Value.ToString

        Catch ex As Exception
        End Try

        LlenarCantRecibir()
        Panel4.Visible = True
    End Sub

    Sub LlenarCantRecibir()
        Try
            cmd = New SqlCommand("SELECT cant
                                  FROM [ABAS].[dbo].[Materiales]
                                  WHERE [descripcion] = '" + DescripcionRecibe.Text + "'
                                  and [almacen] = '" + ComboRecibe.Text + "'
                                  and [estado] = '" + EstadoRecibe.Text + "'", cn) With {
                                            .CommandType = CommandType.Text
                  }
            cn.Open()
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                TextBox11.Text = dr.Item("CANT").ToString
            Else
                TextBox11.Text = 0
            End If

            dr.Close()
            cn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        TextBox9.Text = Val(TextBox11.Text) + Val(CantRecibe.Text)
    End Sub

    Private Sub CantRecibe_TextChanged(sender As Object, e As EventArgs) Handles CantRecibe.TextChanged
        TextBox9.Text = Val(CantRecibe.Text) + Val(TextBox11.Text)
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MsgBox("Se agregara un nuevo Material, no se puede cancelar, Desea confirmar", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
            sql = "insert into tipomateriales (nombre) values('" + NombreTextBox.Text + "')"
            Ejecutar(sql)
            LlenarTiposMateriales()
        End If
        MsgBox("¡Material registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
    End Sub

    Private Sub Cmd_Recibir_Click(sender As Object, e As EventArgs) Handles Cmd_Recibir.Click

        If TextBox9.Text = "" Then
            MsgBox("No hay inventario selecionado por recibir", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
        Else


            If MsgBox("¡Desea recibir los materiales?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then


                cmd = New SqlCommand("SELECT * FROM [ABAS].[dbo].[Materiales]
                                                WHERE [descripcion] = '" + DescripcionRecibe.Text + "' 
                                                and [estado] = '" + EstadoRecibe.Text + "'
                                                and [almacen]= '" + ComboRecibe.Text + "'", cn)
                cn.Open()
                cmd.CommandType = CommandType.Text
                dr = cmd.ExecuteReader()
                If dr.Read() Then

                    sql = "UPDATE [dbo].[Materiales]
                           SET cant = '" + TextBox9.Text + "'
                         WHERE [descripcion] = '" + DescripcionRecibe.Text + "'
                        and [almacen] = '" + ComboRecibe.Text + "'
                        and [estado] = '" + EstadoRecibe.Text + "'"
                    Ejecutar(sql)

                Else
                    sql = "INSERT INTO [dbo].[Materiales]
                           ([descripcion]
                           ,[estado]
                           ,[almacen]
                           ,[cant]
                           ,[fecharegistro])
                     VALUES
                           ('" + DescripcionRecibe.Text + "'
                           ,'" + EstadoRecibe.Text + "'
                           ,'" + ComboRecibe.Text + "'
                           ,'" + TextBox9.Text + "'
                           ,'" + DateTimePicker3.Text + "')"
                    Ejecutar(sql)
                End If


                Try
                    sql = "INSERT INTO [dbo].[MaterialesRIngresos]
                       ([almacen]
                       ,[idmaterial]
                       ,[fechaingreso]
                       ,[cant])
                        VALUES
                       ('" + ComboRecibe.Text + "'
                       ,'" + IDmaterialrecibe.Text + "'
                       ,'" + DateTimePicker3.Text + "'
                       ,'" + CantRecibe.Text + "')"
                    Ejecutar(sql)
                Catch
                End Try

                '' actualiza el movimiento
                sql = "UPDATE [dbo].[MovimientoMateriales]
                           SET [fecharecibe] = '" + DateTimePicker3.Text + "'
                              ,[recibemov] = '" + Usuario + "'
                         WHERE idmov_materiales = '" + IdMov.Text + "'"
                Ejecutar(sql)

                MsgBox("¡Nuevo inventario ingresado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If
        End If

        Panel4.Visible = False
        LoadTranferenciaMateriales()
    End Sub

    Private Sub MaterialesPorAlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialesPorAlmacenToolStripMenuItem.Click
        R_Materiales.Show()
    End Sub

    Private Sub MovimeintosDeMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimeintosDeMaterialesToolStripMenuItem.Click
        R_MovimientosMateriales.Show()
    End Sub

    Sub LoadTranferenciaMateriales()

        ComboDesde.Enabled = True

        MaterialesDataGridView1.Visible = False
        IdMaterialMovimiento.Enabled = False
        IdMaterialMovimiento.Text = 0
        EstadoMovimiento.Enabled = False
        EstadoMovimiento.Text = 0
        DescripcionMovimiento.Enabled = False
        DescripcionMovimiento.Text = 0

        CantIniEnvia.Enabled = False
        CantIniEnvia.Text = 0
        CantMoverEnvia.Text = 0
        CantFinalEnvia.Enabled = False
        CantFinalEnvia.Text = 0

        CantIniRecibe.Enabled = False
        CantIniRecibe.Text = 0
        CantMovRecibe.Enabled = False
        CantMovRecibe.Text = 0
        CantFinRecibe.Enabled = False
        CantFinRecibe.Text = 0

        ComboHacia.SelectedItem = "SPS"

        If ClasePrivilegios.Almacen = "TODOS" Then
            ComboDesde.SelectedItem = "SPS"
            ComboRecibe.SelectedItem = "SPS"
        Else
            ComboDesde.SelectedItem = ClasePrivilegios.Almacen
            ComboDesde.Enabled = False

            ComboRecibe.SelectedItem = ClasePrivilegios.Almacen
            ComboRecibe.Enabled = False
        End If

        LlenarMovimientosMateriales()

        Panel4.Visible = False

    End Sub

    Sub CargarId()
        cmd = New SqlCommand("SELECT max(idmaterial) as ID FROM [ABAS].[dbo].[Materiales]", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            IdMaterialTextBox.Text = dr.Item("ID").ToString
        End If
        dr.Close()
        cn.Close()
    End Sub

End Class