Imports System.Data.SqlClient

Public Class FormInventarioUniformes
    Private IDuniforme As String
    Private ReadOnly Alm As String
    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub FormUniformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Registro unifome
        LoadRegistroUniforme()

        'Movimientos
        LoadMovimientoUniforme()

        'Solicitud de uniforme
        LoadSolicitudUniforme()

        'Devolucion de uniforme
        LoadDevoluciondeUniforme()

    End Sub

    Sub LlenarUniformes()
        Try
            sql = "SELECT TOP (1000) * FROM [ABAS].[dbo].[Uniformes]"
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            UniformesDataGridView.DataSource = dt
        Catch ex As Exception
        Finally
            cn.Close()
        End Try
    End Sub

    Sub LlenarUniformes2()
        Try
            sql = "SELECT TOP (1000) * FROM [ABAS].[dbo].[Uniformes]"
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

    Sub LlenarAlmacenes()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        Cmb_RUalm.DataSource = ds.Tables(0)
        Cmb_RUalm.DisplayMember = "Nombre"

        Cmb_RUIalm.DataSource = ds.Tables(0)
        Cmb_RUIalm.DisplayMember = "Identificador"
    End Sub

    Sub LoadRegistroUniforme()
        Cmb_EstadoUniforme.SelectedItem = "A"
        CantInicial.Text = 0
        CantUniforme.Text = 0
        CantFinal.Text = 0

        Cmb_TipoUniforme.SelectedItem = "Pantalon"

        LlenarUniformes()
        LlenarAlmacenes()

        If ClasePrivilegios.Almacen = "TODOS" Then
            Cmb_RUalm.Text = "SPS"
        Else
            Cmb_RUalm.Text = ClasePrivilegios.Almacen
            Cmb_RUalm.Enabled = False
        End If
    End Sub

    'Sub Llenartiposuniformes()
    '    sql = "select descripcion from tipouniformes order by descripcion asc"
    '    da = New SqlDataAdapter(sql, cn)
    '    ds = New DataSet
    '    da.Fill(ds)
    '    ListBox1.DataSource = ds.Tables(0)
    '    ListBox1.DisplayMember = "descripcion"
    '    ListBox1.ValueMember = "descripcion"
    'End Sub

    'Private Sub DescripcionUniforme_TextChanged(sender As Object, e As EventArgs)
    '    sql = "select descripcion from tipouniformes  where descripcion like '" & DescripcionUniforme.Text & "%" & "' order by descripcion asc"
    '    da = New SqlDataAdapter(sql, cn)
    '    ds = New DataSet
    '    da.Fill(ds)
    '    ListBox1.DataSource = ds.Tables(0)
    '    ListBox1.DisplayMember = "descripcion"
    '    ListBox1.ValueMember = "descripcion"
    'End Sub

    Sub LlenarCantidad()
        CantInicial.Text = 0
        CantUniforme.Text = 0
        CantFinal.Text = 0

        Try
            cmd = New SqlCommand("SELECT cant
				            FROM [ABAS].[dbo].[Uniformes]
				            WHERE [iduniforme] = '" + IduniformeTextBox.Text + "'
                            AND estado = '" + Cmb_EstadoUniforme.SelectedItem + "'
                            AND [descripcion] = '" + Cmb_TipoUniforme.SelectedItem + "'
                            AND [almacen] = '" + Cmb_RUalm.Text + "'", cn) With {
                                            .CommandType = CommandType.Text
                  }
            cn.Open()
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                CantInicial.Text = dr.Item("CANT").ToString
            Else
                If CantInicial.Text = "" Then
                    CantInicial.Text = 0
                End If
            End If
        Catch ex As Exception
        End Try

        dr.Close()
        cn.Close()
    End Sub

    Sub CargarId()
        cmd = New SqlCommand("SELECT max(iduniforme) as ID FROM [ABAS].[dbo].[Uniformes] order by ID desc", cn) With {
            .CommandType = CommandType.Text
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            IDuniforme = dr.Item("ID").ToString
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles Cmd_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub CantInicial_TextChanged(sender As Object, e As EventArgs) Handles CantInicial.TextChanged
        If CantInicial.Text = "" Then
            Limpiar()
        Else
            CantFinal.Text = Val(CantInicial.Text) + Val(CantUniforme.Text)
        End If
    End Sub


    Private Sub CmdRegistrarUniforme_Click(sender As Object, e As EventArgs) Handles Cmd_RegistrarUniforme.Click
        If MsgBox("¡Desea registrar los nuevos uniformes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            cmd = New SqlCommand("SELECT * FROM [ABAS].[dbo].[Uniformes]
                                                WHERE [descripcion] = '" + Cmb_TipoUniforme.SelectedItem + "' 
                                                and [estado] = '" + Cmb_EstadoUniforme.SelectedItem + "'
                                                and [almacen]= '" + Cmb_RUalm.Text + "'
                                                and [talla] = '" + TallaTextBox2.Text + "'
                                                and [estilo] = '" + EstiloTextBox.Text + "'", cn)
            cn.Open()
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                MessageBox.Show("Ya existe un registro con estas categorias, seleccionelo y agregue mas inventario")
            Else

                sql = "INSERT INTO [dbo].[Uniformes]
                       ([descripcion]
                       ,[estilo]
                       ,[talla]
                       ,[estado]
                       ,[almacen]
                       ,[cant])
                 VALUES
                       ('" + Cmb_TipoUniforme.SelectedItem + "'
                       ,'" + EstiloTextBox.Text + "'
                       ,'" + TallaTextBox2.Text + "'
                       ,'" + Cmb_EstadoUniforme.SelectedItem + "'
                       ,'" + Cmb_RUalm.Text + "'
                       ,'" + CantUniforme.Text + "')"
                Ejecutar(sql)


                CargarId()


                Try
                    sql = "INSERT INTO [dbo].[UniformesRIngresos]
                           ([almacen]
                              ,[iduniforme]
                              ,[cant]
                              ,[fechaingreso])
                           VALUES
                           ('" + Cmb_RUalm.Text + "'
                           , '" + IDuniforme + "'
                           , '" + CantUniforme.Text + "'
                           , '" + DateTimePicker2.Text + "')"
                    Ejecutar(sql)
                Catch
                End Try

                MsgBox("¡Uniformes registrados exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If

            dr.Close()
            cn.Close()
            Limpiar()
        End If

    End Sub

    Private Sub CantUniforme_TextChanged(sender As Object, e As EventArgs) Handles CantUniforme.TextChanged
        CantFinal.Text = Val(CantInicial.Text) + Val(CantUniforme.Text)
    End Sub


    Private Sub CmdAgregarUniforme_Click(sender As Object, e As EventArgs) Handles CmdAgregarUniforme.Click
        If MsgBox("¡Desea guardar los nuevos uniformes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If CantFinal.Text = 0 Then
                If MsgBox("La cantidad final sera 0, Desea continuar", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                    AgregarUniforme()
                End If
            Else
                AgregarUniforme()
            End If
            MsgBox("¡Uniformes agregados exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Sub AgregarUniforme()

        sql = "UPDATE [ABAS].[dbo].[Uniformes] SET [cant] = '" + CantFinal.Text + "'
                      WHERE [iduniforme] = '" + IduniformeTextBox.Text + "'"
        Ejecutar(sql)


        sql = "INSERT INTO [dbo].[UniformesRIngresos]
                           ([almacen]
                              ,[iduniforme]
                              ,[cant]
                              ,[fechaingreso])
                           VALUES
                           ('" + Cmb_RUalm.Text + "'
                           , '" + IDuniforme + "'
                           , '" + CantUniforme.Text + "'
                           , '" + DateTimePicker2.Text + "')"
        Ejecutar(sql)

        Limpiar()
    End Sub

    Sub Limpiar()
        CantUniforme.Text = 0
        CantFinal.Text = 0
        CantInicial.Text = 0
        Cmd_RegistrarUniforme.Enabled = True
        IduniformeTextBox.Clear()
        EstiloTextBox.Clear()
        TallaTextBox2.Clear()
        LlenarUniformes()
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If DataGridView1.Visible = True Then
            DataGridView1.Visible = False
        Else
            DataGridView1.Visible = True
            LlenarUniformes2()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Nuevo.Click
        LimpiarMov()
    End Sub

    Sub LimpiarMov()

        ComboDesde.Enabled = True

        DescripcionMovimiento.Clear()
        IduniformeMovimiento.Clear()
        TallaTextBox3.Clear()
        EstadoMovimiento.Clear()
        DescripcionRecibe.Clear()
        EstiloEnvia.Clear()
        EstadoRecibe.Clear()
        EstiloRecibe.Clear()

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

        IdMov.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        EstadoRecibe.Clear()
        CantRecibe.Clear()
        LlenarMovimientos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)


            IduniformeMovimiento.Text = selectedRow.Cells(0).Value.ToString
            DescripcionMovimiento.Text = selectedRow.Cells(1).Value.ToString
            EstiloEnvia.Text = selectedRow.Cells(2).Value.ToString
            TallaTextBox3.Text = selectedRow.Cells(3).Value.ToString
            EstadoMovimiento.Text = selectedRow.Cells(4).Value.ToString
            ComboDesde.Text = selectedRow.Cells(5).Value.ToString
        Catch ex As Exception
        End Try

        ComboDesde.Enabled = False
        LlenarCantidades2()
        DataGridView1.Visible = False
    End Sub

    Public Sub LlenarCantidades2()


        cmd = New SqlCommand("SELECT [cant]
                              FROM [ABAS].[dbo].[Uniformes]
                              WHERE iduniforme = '" + IduniformeMovimiento.Text + "'
                              AND almacen = '" + ComboDesde.Text + "'", cn) With {
                                                    .CommandType = CommandType.Text
                          }
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            CantIniEnvia.Text = dr.Item("cant").ToString
        Else
            CantIniEnvia.Text = 0
        End If

        dr.Close()
        cn.Close()


        cmd = New SqlCommand("SELECT cant
				                        FROM [ABAS].[dbo].[Uniformes]
				                        WHERE [descripcion] = '" + DescripcionMovimiento.Text + "'
                                        AND [almacen] = '" + ComboHacia.Text + "'
                                        AND [talla] = '" + TallaTextBox3.Text + "'
                                        AND [estilo] = '" + EstiloEnvia.Text + "'
                                        AND [estado] = '" + EstadoMovimiento.Text + "'", cn) With {
                                                   .CommandType = CommandType.Text
                         }
        cn.Open()
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            CantIniRecibe.Text = dr.Item("cant")
        Else
            CantIniRecibe.Text = 0
        End If

        dr.Close()
        cn.Close()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles CantMoverEnvia.TextChanged
        If Val(CantMoverEnvia.Text) > Val(CantIniEnvia.Text) Then
            MessageBox.Show("No existe suficiente inventario, Favor hacer un pedido!")
            EstadoMovimiento.Clear()
            CantMoverEnvia.Clear()
        Else
            CantFinalEnvia.Text = Val(CantIniEnvia.Text) - Val(CantMoverEnvia.Text)
            CantMovRecibe.Text = Val(CantMoverEnvia.Text)
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles CantMovRecibe.TextChanged
        CantFinRecibe.Text = Val(CantMovRecibe.Text) + Val(CantIniRecibe.Text)
    End Sub

    Sub LoadMovimientoUniforme()
        DataGridView1.Visible = False
        LimpiarMov()
        Panel1.Visible = False
        LlenarMovimientos()
        ComboRecibe.Enabled = False

        CantIniEnvia.Enabled = False
        CantIniEnvia.Text = 0
        CantFinalEnvia.Enabled = False
        CantFinalEnvia.Text = 0

        CantIniRecibe.Enabled = False
        CantIniRecibe.Text = 0
        CantMovRecibe.Enabled = False
        CantMovRecibe.Text = 0
        CantFinRecibe.Enabled = False
        CantFinRecibe.Text = 0

        LlenarAlmacenes2()
        LlenarAlmacenes3()
        LlenarAlmacenes4()

        If ClasePrivilegios.Almacen = "TODOS" Then
            ComboDesde.Text = "SPS"
            ComboRecibe.Text = "SPS"
        Else
            ComboDesde.SelectedItem = ClasePrivilegios.Almacen
            ComboDesde.Enabled = False
        End If

        If ClasePrivilegios.Nivel = "1" Then
            Cmd_Transferir.Enabled = False
        End If
    End Sub

    Sub LlenarAlmacenes2()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboDesde.DataSource = ds.Tables(0)
        ComboDesde.DisplayMember = "Nombre"

        ComboBox5.DataSource = ds.Tables(0)
        ComboBox5.DisplayMember = "Identificador"
    End Sub

    Sub LlenarAlmacenes3()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboHacia.DataSource = ds.Tables(0)
        ComboHacia.DisplayMember = "Nombre"

        ComboBox6.DataSource = ds.Tables(0)
        ComboBox6.DisplayMember = "Identificador"
    End Sub
    Sub LlenarAlmacenes4()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboRecibe.DataSource = ds.Tables(0)
        ComboRecibe.DisplayMember = "Nombre"

        ComboBox7.DataSource = ds.Tables(0)
        ComboBox7.DisplayMember = "Identificador"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_Transferir.Click
        If CantMoverEnvia.Text = "" Or CantMoverEnvia.Text = "0" Then
            CantMoverEnvia.Focus()
            MessageBox.Show("Ingrese una cantidad para poder tranferir")
        Else

            If MsgBox("¡Desea trasnferir los uniformes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                Guardar()
                MsgBox("¡Uniformes transferidos exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")

            End If
        End If

    End Sub

    Sub Guardar()
        If DescripcionMovimiento.Text = "" Then
            MsgBox("¡Existen campos vacios!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        Else
            sql = "INSERT INTO [dbo].[MovimientoUniformes]
           ([descripcion]
           ,[iduniforme]
           ,[cant]
           ,[fechamov]
           ,[recibe_mov]
           ,[almacen]
           ,[estado]
           ,[estilo]
           ,[talla])
            VALUES
           ('" + DescripcionMovimiento.Text + "',
           '" + IduniformeMovimiento.Text + "',
           '" + CantMovRecibe.Text + "',
           '" + FechaMovimiento.Text + "',
           'No recibido',
           '" + ComboHacia.Text + "',
           '" + EstadoMovimiento.Text + "',
           '" + EstiloEnvia.Text + "',
           '" + TallaTextBox3.Text + "')"
            Ejecutar(sql)
        End If

        sql = "UPDATE [dbo].[Uniformes]
                           SET [cant] = '" + CantFinalEnvia.Text + "'
                         WHERE [iduniforme] = '" + IduniformeMovimiento.Text + "'"
        Ejecutar(sql)
        LimpiarMov()
    End Sub

    Sub LlenarMovimientos()
        Try
            cn.Open()
            If ClasePrivilegios.Almacen = "TODOS" Then
                sql = "SELECT *
                   FROM [ABAS].[dbo].[MovimientoUniformes] where recibe_mov = 'No recibido'"
            Else
                sql = "SELECT *
                   FROM [ABAS].[dbo].[MovimientoUniformes] where recibe_mov = 'No recibido' and almacen = '" + ClasePrivilegios.Almacen + "'"
            End If

            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            MovimientoUniformesDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try
    End Sub

    'Private Sub ListBox1_Click(sender As Object, e As EventArgs)
    '    DescripcionUniforme.Text = ListBox1.SelectedValue
    'End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    '    If MsgBox("Se agregara un nuevo tipo de uniforme, no se puede cancelar, Desea confirmar", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
    '        sql = "insert into tipouniformes (descripcion) values('" + DescripcionUniforme.Text + "')"
    '        Ejecutar(sql)
    '        Llenartiposuniformes()
    '        MsgBox("¡Nueva tipo agregado, filtre el nuevo tipo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
    '    End If
    'End Sub


    Private Sub MovimientoUniformesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovimientoUniformesDataGridView.CellContentClick
        Panel1.Visible = True
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = MovimientoUniformesDataGridView.Rows(index)
            TextBox3.Text = selectedRow.Cells(9).Value.ToString
            EstiloRecibe.Text = selectedRow.Cells(8).Value.ToString
            EstadoRecibe.Text = selectedRow.Cells(6).Value.ToString
            ComboRecibe.Text = selectedRow.Cells(5).Value.ToString
            CantRecibe.Text = selectedRow.Cells(3).Value.ToString
            IDuniforme = selectedRow.Cells(2).Value.ToString
            DescripcionRecibe.Text = selectedRow.Cells(1).Value.ToString
            IdMov.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try
        LlenarCantRecibir()
    End Sub

    Sub LlenarCantRecibir()
        cmd = New SqlCommand("SELECT CANT
					        FROM [ABAS].[dbo].[Uniformes]
					        WHERE [almacen] = '" + ComboRecibe.Text + "'
                            and [descripcion] = '" + DescripcionRecibe.Text + "'", cn) With {
               .CommandType = CommandType.Text
           }
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            TextBox11.Text = dr.Item("CANT").ToString
        Else
            TextBox11.Text = 0
        End If

        TextBox9.Text = Val(TextBox11.Text) + Val(CantRecibe.Text)
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Cmd_Recibir_Click(sender As Object, e As EventArgs) Handles Cmd_Recibir.Click
        If TextBox9.Text = "" Then
            MsgBox("No hay inventario selecionado por recibir", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
        Else

            If MsgBox("¡Desea recibir los uniformes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                cmd = New SqlCommand("SELECT * FROM [ABAS].[dbo].[Uniformes]
                                                WHERE [descripcion] = '" + DescripcionRecibe.Text + "' 
                                                and [estado] = '" + EstadoRecibe.Text + "'
                                                and [almacen]= '" + ComboRecibe.Text + "'
                                                and [talla] = '" + TextBox3.Text + "'
                                                and [estilo] = '" + EstiloRecibe.Text + "'", cn)
                cn.Open()
                cmd.CommandType = CommandType.Text
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    sql = "UPDATE [dbo].[Uniformes]
                           SET [cant] = '" + TextBox9.Text + "'
                         WHERE [descripcion] = '" + DescripcionRecibe.Text + "'
                         and [almacen] = '" + ComboRecibe.Text + "'
                         and [estado] = '" + EstadoRecibe.Text + "'
                         and [estilo] = '" + EstiloRecibe.Text + "'
                         and [talla] = '" + TextBox3.Text + "'"
                    Ejecutar(sql)
                Else
                    sql = "INSERT INTO [dbo].[Uniformes]
                           ([descripcion]
                           ,[estilo]
                           ,[talla]
                           ,[estado]
                           ,[almacen]
                           ,[cant])
                     VALUES
                           ('" + DescripcionRecibe.Text + "'
                           ,'" + EstiloRecibe.Text + "'
                           ,'" + TextBox3.Text + "'
                           ,'" + EstadoRecibe.Text + "'
                           ,'" + ComboRecibe.Text + "'
                           ,'" + TextBox9.Text + "')"
                    Ejecutar(sql)
                End If

                Try
                    sql = "INSERT INTO [dbo].[UniformesRIngresos]
                           ([almacen]
                              ,[iduniforme]
                              ,[cant]
                              ,[fechaingreso])
                           VALUES
                           ('" + ComboRecibe.Text + "'
                           , '" + IDuniforme + "'
                           , '" + CantRecibe.Text + "'
                           , '" + DateTimePicker3.Text + "')"
                    Ejecutar(sql)
                Catch ex As Exception
                End Try

                sql = "UPDATE [dbo].[MovimientoUniformes]
                           SET [recibe_mov] = '" + Usuario + "'
                                ,[fecharecibe] = '" + DateTimePicker3.Text + "'
                         WHERE [idmov_uniforme] = '" + IdMov.Text + "'"
                Ejecutar(sql)

                MsgBox("¡Nuevo inventario ingresado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If
        End If

        LimpiarMov()
        Panel1.Visible = False
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        Limpiar()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Cmd_CrearSolicitud.Click
        If Rango3 <> "RRHH" Then
            MsgBox("¡No cuenta con los permisos necesarios para realizar entregas de uniforme: Necesita RRHH!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Confirmar")
        Else
            Try
                sql = "INSERT INTO [dbo].[SolicitudUniforme]
            ([codigo]
            ,[fecha]
            ,[entrega])
            VALUES
            ('" + CodigoTextBox.Text + "'
            ,'" + FechaDateTimePicker.Text + "'
            ,'" + EntregaTextBox.Text + "')"
                Ejecutar(sql)

                MsgBox("¡Solicitud Creada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Catch ex As Exception
            End Try

            cn.Open()
            cmd = New SqlCommand("SELECT TOP (1) [idsolicitud]
                          FROM [ABAS].[dbo].[SolicitudUniforme]
                          WHERE [fecha] = '" + FechaDateTimePicker.Text + "' and [entrega] ='" + EntregaTextBox.Text + "'
                          ORDER BY [idsolicitud] DESC") With {
                .Connection = cn,
                .CommandType = CommandType.Text
            }
            dr = cmd.ExecuteReader()

            If dr.Read Then
                IdsolicitudTextBox.Text = dr.Item("idsolicitud")
                dr.Close()
                cn.Close()
            End If

            ''La variable IDsolicitud es cargada de esta forma para poder imprimer la solicitud
            ClasePrivilegios.IDsolicitud = IdsolicitudTextBox.Text


            ''Crea una lista de 3 pagos donde se decidira la forma en como se deducira el pago por la entrega del uniforme
            Dim lst As New List(Of String) _
            From {IDsolicitud, IDsolicitud, IDsolicitud}
            For Each item As String In lst
                DataGridView2.Rows.Add(IDsolicitud, "Pendiente", "", "")
            Next
        End If

    End Sub

    Private Sub UniformesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UniformesDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = UniformesDataGridView.Rows(index)
            IduniformeTextBox.Text = selectedRow.Cells(0).Value.ToString
            Cmb_TipoUniforme.SelectedItem = selectedRow.Cells(1).Value.ToString
            EstiloTextBox.Text = selectedRow.Cells(2).Value.ToString
            TallaTextBox2.Text = selectedRow.Cells(3).Value.ToString
            Cmb_EstadoUniforme.SelectedItem = selectedRow.Cells(4).Value.ToString
            Cmb_RUalm.Text = selectedRow.Cells(5).Value.ToString
        Catch ex As Exception
        End Try

        LlenarCantidad()
        Cmd_RegistrarUniforme.Enabled = False
    End Sub


    Private Sub TxtbuscarEmp_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarEmp.TextChanged
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

            CodigoTextBox.Text = selectedRow.Cells(0).Value.ToString
            CodigoTextBox1.Text = selectedRow.Cells(0).Value.ToString
            panelEmpleados.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CodigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodigoTextBox.TextChanged

        cn.Open()
        cmd = New SqlCommand("SELECT *
                          FROM [ABAS].[dbo].[SolicitudUniforme]
                          where codigo ='" + CodigoTextBox.Text + "' and fecha = '" + FechaDateTimePicker.Text + "'") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()

        If dr.Read Then
            dr.Close()
            cn.Close()

            If MsgBox("¡Este empleado tiene una asignacion de uniformes creada esta fecha", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            Else
                CodigoTextBox.Clear()
            End If
        End If
    End Sub

    Sub LoadSolicitudUniforme()
        LlenarAlmacenes5()

        EntregaTextBox.Text = Codigo
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        panelEmpleados.Visible = False
        TipoComboBox.SelectedItem = "Pantalon"
        EstadoComboBox.SelectedItem = "A"

        If ClasePrivilegios.Almacen = "TODOS" Then
            ComboBox2.Text = "SPS"
        Else
            ComboBox2.Text = ClasePrivilegios.Almacen
            ComboBox2.Enabled = False
        End If

        LlenarCantAsignar()

        If Rango2 <> "Administracion" Then
            TabPage5.Enabled = False
            TabPage6.Enabled = False
        End If


    End Sub

    ''Test

    Sub LlenarAlmacenes5()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboBox2.DataSource = ds.Tables(0)
        ComboBox2.DisplayMember = "Nombre"

        ComboBox8.DataSource = ds.Tables(0)
        ComboBox8.DisplayMember = "Identificador"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbuscarEmp.Focus()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Cmd_NuevaSolicitud.Click
        LimpiarSolicitud()
    End Sub


    Sub LimpiarSolicitud()
        IdsolicitudTextBox.Clear()
        CodigoTextBox.Clear()
    End Sub

    Sub LimpiarDetalleSolicitud()
        TallaTextBox.Clear()
        EstiloTextBox1.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        CantidadTextBox.Clear()
        ValorTextBox.Clear()
        DetalleSolicitudDataGridView.Rows.Clear()
    End Sub

    Sub LimpiarFormaPago()
        Txt_TotalPagar.Clear()
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Cmd_CancelarSolicitud.Click
        Try
            sql = "DELETE FROM [dbo].[SolicitudUniforme]
                  WHERE idsolicitud = '" + IdsolicitudTextBox.Text + "'"
            Ejecutar(sql)
        Catch ex As Exception
        End Try

        LimpiarSolicitud()
        LimpiarDetalleSolicitud()
    End Sub


    Private Sub CantidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles CantidadTextBox.TextChanged
        TextBox2.Text = Val(TextBox1.Text) - Val(CantidadTextBox.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Val(TextBox1.Text) - Val(CantidadTextBox.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IdsolicitudTextBox.Text = "" Then
            MsgBox("¡Se debe crear una solicitud antes de asignar uniforme!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        Else
            If TextBox1.Text = "" Or TextBox1.Text = "0" Then
                MsgBox("¡No se puede asignar sin existencia en inventario!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                DetalleSolicitudDataGridView.Rows.Add(IdsolicitudTextBox.Text, IDuniforme, TipoComboBox.SelectedItem, CantidadTextBox.Text, ValorTextBox.Text, TallaTextBox.Text, EstiloTextBox1.Text, EstadoComboBox.SelectedItem, ComboBox2.Text)

                Dim row As DataGridViewRow
                Dim Tot As Double

                For Each row In DetalleSolicitudDataGridView.Rows
                    Tot += row.Cells(4).Value
                Next

                Txt_TotalPagar.Text = Tot

            End If

            If TextBox1.Text <> "" Then
                sql = "UPDATE [ABAS].[dbo].[Uniformes] SET [cant] = '" + TextBox2.Text + "'
                WHERE [iduniforme] = '" + IDuniforme + "'"
                Ejecutar(sql)
            End If

        End If
        LimpiarInsertDetalle()
    End Sub

    Private Sub ComprobanteEntregaUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobanteEntregaUniformeToolStripMenuItem.Click
        R_EntregaUniforme.Show()
    End Sub

    Private Sub Cmd_ImprimirSolicitud_Click(sender As Object, e As EventArgs) Handles Cmd_ImprimirSolicitud.Click

        R_EntregaUniforme.Show()
    End Sub

    Private Sub UniformesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UniformesDataGridView.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = UniformesDataGridView.Rows(index)
            Cmb_TipoUniforme.SelectedItem = selectedRow.Cells(1).Value.ToString
            EstiloTextBox.Text = selectedRow.Cells(2).Value.ToString
            Cmb_EstadoUniforme.SelectedItem = selectedRow.Cells(3).Value.ToString
        Catch ex As Exception
        End Try
        LlenarCantidad()
        Cmd_RegistrarUniforme.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GuardarSolicitudUniforme()
    End Sub

    Sub GuardarSolicitudUniforme()
        If DetalleSolicitudDataGridView.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DetalleSolicitudDataGridView.Rows
                ''Cells valida la columna
                If row.Cells(0).Value <> "" Then
                    GuardarDetalleUniforme()
                Else
                    MsgBox("¡No se ha asignado uniforme para la solicitud!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                End If
            Next
        End If
    End Sub

    Sub GuardarDetalleUniforme()

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()

            sql = "INSERT INTO [dbo].[DetalleSolicitud]
           ([idsolicitud]
           ,[tipo]
           ,[cantidad]
           ,[talla]
           ,[estilo]
           ,[valor]
           ,[estado])
            VALUES
           (@IDSolicitudDetalle
           ,@Tipo
           ,@CantidadDetalle
           ,@Talla
           ,@EstiloDetalle
           ,@Valor
           ,@EstadoDetalle)"
            cmd = New SqlCommand(sql, cn)

            Try
                For Each row As DataGridViewRow In DetalleSolicitudDataGridView.Rows
                    If row.Cells(0).Value <> "" Then
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@IDSolicitudDetalle", Convert.ToInt32(row.Cells("IDSolicitudDetalle").Value))
                        cmd.Parameters.AddWithValue("@Tipo", Convert.ToString(row.Cells("Tipo").Value))
                        cmd.Parameters.AddWithValue("@CantidadDetalle", Convert.ToInt32(row.Cells("CantidadDetalle").Value))
                        cmd.Parameters.AddWithValue("@Talla", Convert.ToString(row.Cells("Talla").Value))
                        cmd.Parameters.AddWithValue("@EstiloDetalle", Convert.ToString(row.Cells("EstiloDetalle").Value))
                        cmd.Parameters.AddWithValue("@Valor", Convert.ToInt32(row.Cells("Valor").Value))
                        cmd.Parameters.AddWithValue("@EstadoDetalle", Convert.ToString(row.Cells("EstadoDetalle").Value))
                        cmd.ExecuteNonQuery()
                    End If
                Next
            Catch ex As Exception
            End Try
            cn.Close()
            MsgBox("¡Detalle de solicitud guardado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End Using
        GuardarFormadePago()
    End Sub
    Sub GuardarFormadePago()
        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()

            sql = "INSERT INTO [dbo].[FormaPago]
           ([idsolicitud]
           ,[estado]
           ,[veces]
           ,[cantidad])
            VALUES
           (@IDSolicitudUniforme
           ,@EstadoFormaDePago
           ,@Veces
           ,@Cantidad)"
            cmd = New SqlCommand(sql, cn)
            Try
                For Each row As DataGridViewRow In DataGridView2.Rows
                    If row.Cells(2).Value <> "" Then
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@IDSolicitudUniforme", Convert.ToInt32(row.Cells("IDSolicitudUniforme").Value))
                        cmd.Parameters.AddWithValue("@EstadoFormaDePago", Convert.ToString(row.Cells("EstadoFormaDePago").Value))
                        cmd.Parameters.AddWithValue("@Veces", Convert.ToInt32(row.Cells("Veces").Value))
                        cmd.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells("Cantidad").Value))
                        cmd.ExecuteNonQuery()
                    End If
                Next

                MsgBox("¡Formas de pagos guardadas exitosamente, si gusta puede imprimir el formato ahora, mismo de lo contrario: 
" & "[+] El id de la solicitud es: " + IDsolicitud + "!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")

            Catch ex As Exception
            End Try
            cn.Close()
        End Using

        LimpiarSolicitud()
        LimpiarDetalleSolicitud()
        LimpiarFormaPago()
    End Sub


    Sub LlenarCantAsignar()

        If ComboBox8.Text = "System.Data.DataRowView" Or ComboBox8.Text = "" Then

        Else

            cn.Close()
            cmd = New SqlCommand("SELECT [iduniforme], [cant]
                        FROM [ABAS].[dbo].[Uniformes]
                        where [descripcion] = '" + TipoComboBox.SelectedItem + "'
                        and [estado] = '" + EstadoComboBox.SelectedItem + "'
                        and [almacen]= '" + ComboBox2.Text + "'", cn) With {
               .CommandType = CommandType.Text
           }
            cn.Open()
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TextBox1.Text = dr.Item("CANT").ToString
                IDuniforme = dr.Item("iduniforme").ToString
            End If
            dr.Close()
            cn.Close()

            Dim cant As Integer
            Dim selectALM As String
            selectALM = ComboBox2.Text

            If DetalleSolicitudDataGridView.Rows.Count > 0 Then
                For Each row As DataGridViewRow In DetalleSolicitudDataGridView.Rows
                    If (row.Cells(2).Value = TipoComboBox.SelectedItem) And (row.Cells(7).Value = EstadoComboBox.SelectedItem) And (row.Cells(8).Value = selectALM) Then
                        cant += TextBox1.Text - row.Cells(3).Value
                        TextBox1.Text = cant
                    End If
                Next
            End If


            ''carga variables publicas
            CodigoEmpleado = CodigoTextBox.Text
            FechaEntrega = FechaDateTimePicker.Text

            LimpiarInsertDetalle()

        End If


    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarDevoluciondeUniforme()
    End Sub

    Sub LimpiarInsertDetalle()
        TallaTextBox.Clear()
        EstiloTextBox1.Clear()
        CantidadTextBox.Clear()
        ValorTextBox.Clear()
    End Sub

    Sub LimpiarDevoluciondeUniforme()
        LoadDevoluciondeUniforme()
        IddevolucionTextBox.Clear()
        CodigoTextBox1.Clear()
        RembolsoTextBox.Text = "0"
        ObservacionTextBox.Clear()
        CantidadTextBox1.Clear()
        TallaTextBox1.Clear()
        EstiloTextBox2.Clear()
        DevolucionUniformeDetalleDataGridView.DataSource = vbNull
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbuscarEmp.Focus()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Rango3 <> "RRHH" Then
            MsgBox("¡No cuenta con los permisos necesarios para realizar devoluciones de uniforme: Necesita RRHH!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Confirmar")
        Else
            If ObservacionTextBox.Text = "" Then
                ObservacionTextBox.Text = "Ninguna"
            End If

            ''revision de checkbox
            Dim check As String

            If CheckBox1.Checked = True Then
                check = "SI"
            Else
                check = "NO"
            End If

            'Try
            sql = "INSERT INTO [dbo].[DevolucionUniforme]
           ([carnet]
           ,[codigo]
           ,[observacion]
           ,[recibe]
           ,[fecha]
           ,[estado]
           ,[rembolso])
             VALUES
                   ('" + check + "'
                   ,'" + CodigoTextBox1.Text + "'
                   ,'" + ObservacionTextBox.Text + "'
                   ,'" + RecibeTextBox.Text + "'
                   ,'" + FechaDateTimePicker1.Text + "'
                   ,'" + EstadoComboBox1.SelectedItem + "'
                   ,'" + RembolsoTextBox.Text + "')"
            Ejecutar(sql)

            MsgBox("¡Devolucion de Uniforme Creada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            'Catch ex As Exception
            ' End Try

            cn.Open()

            cmd = New SqlCommand("SELECT TOP (1) [iddevolucion]
                              FROM [ABAS].[dbo].[DevolucionUniforme]
                              WHERE [codigo] = '" + CodigoTextBox1.Text + "' AND [fecha] = '" + FechaDateTimePicker1.Text + "'
                              ORDER BY [iddevolucion] DESC") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
            dr = cmd.ExecuteReader()

            If dr.Read Then
                IddevolucionTextBox.Text = dr.Item("iddevolucion")
                dr.Close()
                cn.Close()
            End If

            ''para imprimir el reporte envio parametros
            ClasePrivilegios.IDdevolucion = IddevolucionTextBox.Text
            ClasePrivilegios.FechaRecibido = FechaDateTimePicker1.Text
            ClasePrivilegios.CodigoEmpleado = CodigoTextBox1.Text
        End If
    End Sub

    Private Sub ObservacionTextBox_Click(sender As Object, e As EventArgs) Handles ObservacionTextBox.Click
        ObservacionTextBox.Clear()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        If IddevolucionTextBox.Text = "" Then
            MsgBox("¡Se debe crear una devolucion antes de recibir uniformes!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        Else
            If CantidadTextBox1.Text = "" Or TallaTextBox1.Text = "" Or EstiloTextBox2.Text = "" Then
                MsgBox("¡Existen campos vacios, obligatorios para poder insertar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                DevolucionUniformeDetalleDataGridView.Rows.Add(IddevolucionTextBox.Text, AlmacenComboBox.Text, TipoComboBox1.SelectedItem, CantidadTextBox1.Text, TallaTextBox1.Text, EstiloTextBox2.Text, EstadoComboBox2.SelectedItem)
            End If
        End If

        '' Permite que al guardar los detalles de uniformes devueltos sean enviados tambien a la tabla principal y se muestre el inventario actualizado
        ActualizarInventariosDetalleDevolucion()

    End Sub

    Sub ActualizarInventariosDetalleDevolucion()
        cmd = New SqlCommand("SELECT [iduniforme], cant
                            FROM [ABAS].[dbo].[Uniformes]
                            where 
                            descripcion = '" + TipoComboBox1.SelectedItem + "'
                            and estado = '" + EstadoComboBox2.SelectedItem + "'
                            and [almacen] = '" + AlmacenComboBox.Text + "'", cn) With {
               .CommandType = CommandType.Text
           }
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            CantidadTextBox.Text = dr.Item("CANT").ToString
            IduniformeTextBox.Text = dr.Item("iduniforme").ToString

            CantFinal.Text = Val(CantidadTextBox.Text) + Val(CantidadTextBox1.Text)

            sql = "UPDATE [ABAS].[dbo].[Uniformes] SET [cant] = '" + CantFinal.Text + "'
                      WHERE [iduniforme] = '" + IduniformeTextBox.Text + "'"
            Ejecutar(sql)

        End If
        dr.Close()
        cn.Close()

        CantidadTextBox1.Clear()
        TallaTextBox1.Clear()
        EstiloTextBox2.Clear()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        GuardarDetalleDevolucion()
    End Sub

    Sub GuardarDetalleDevolucion()
        If DevolucionUniformeDetalleDataGridView.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DevolucionUniformeDetalleDataGridView.Rows
                ''Cells valida la columna que no este vacia para guardar
                If row.Cells(0).Value <> "" Then
                    GuardarDetalleDevolcuionUniforme()
                Else
                    MsgBox("¡No se ha asignado uniformes para la devolucion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                End If
            Next
        End If
    End Sub

    Sub GuardarDetalleDevolcuionUniforme()

        Using cn As New SqlConnection(My.Settings.ABASConnection)
            cn.Open()

            sql = "INSERT INTO [dbo].[DevolucionUniformeDetalle]
           ([iddevolucion]
           ,[almacen]
           ,[tipo]
           ,[cantidad]
           ,[talla]
           ,[estilo]
           ,[estado])
             VALUES
                   (@iddevolucion
                   ,@almacen
                   ,@tipo
                   ,@cantidad
                   ,@talla
                   ,@estilo
                   ,@estado)"

            cmd = New SqlCommand(sql, cn)

            Try
                For Each row As DataGridViewRow In DevolucionUniformeDetalleDataGridView.Rows
                    If row.Cells(0).Value <> "" Then
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@iddevolucion", Convert.ToInt32(row.Cells("iddevolucion").Value))
                        cmd.Parameters.AddWithValue("@almacen", Convert.ToString(row.Cells("almacendetalledevolucion").Value))
                        cmd.Parameters.AddWithValue("@tipo", Convert.ToString(row.Cells("tipodetalledevolucion").Value))
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells("cantidadetalledevolucion").Value))
                        cmd.Parameters.AddWithValue("@talla", Convert.ToString(row.Cells("talladetalledevolucion").Value))
                        cmd.Parameters.AddWithValue("@estilo", Convert.ToString(row.Cells("estilodetalledevolucion").Value))
                        cmd.Parameters.AddWithValue("@estado", Convert.ToString(row.Cells("estadodetalledevolucion").Value))
                        cmd.ExecuteNonQuery()
                    End If
                Next
            Catch ex As Exception
            End Try
            cn.Close()
            MsgBox("¡Detalle de devolucion guardado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End Using

        LimpiarDevoluciondeUniforme()

    End Sub

    Private Sub ComprobanteDevolucionUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobanteDevolucionUniformeToolStripMenuItem.Click
        R_DevolucionUniforme.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        R_DevolucionUniforme.Show()
    End Sub

    Private Sub InventarioUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioUniformeToolStripMenuItem.Click
        R_UniformeSucursal.Show()
    End Sub

    Private Sub MovimientosDeUniformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeUniformeToolStripMenuItem.Click
        R_MovimientosUniformes.Show()
    End Sub


    Sub LoadDevoluciondeUniforme()
        EstadoComboBox1.SelectedItem = "Sin Rembolso"
        TipoComboBox1.SelectedItem = "Pantalon"
        CheckBox1.Checked = True
        RecibeTextBox.Text = Codigo
        RembolsoTextBox.Text = "0"

        LlenarAlmacenes6()

        If ClasePrivilegios.Almacen = "TODOS" Then
            AlmacenComboBox.Text = "SPS"
        Else
            AlmacenComboBox.Text = ClasePrivilegios.Almacen
            AlmacenComboBox.Enabled = False
        End If
        EstadoComboBox2.SelectedItem = "A"
    End Sub

    Sub LlenarAlmacenes6()
        sql = "SELECT [Nombre], [Identificador]
         FROM [ABAS].[dbo].[Almacenes]"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        AlmacenComboBox.DataSource = ds.Tables(0)
        AlmacenComboBox.DisplayMember = "Nombre"

        ComboBox9.DataSource = ds.Tables(0)
        ComboBox9.DisplayMember = "Identificador"
    End Sub

    Private Sub CmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_EstadoUniforme.SelectedIndexChanged
        LlenarCantidad()
    End Sub

    Private Sub Cmb_TipoAgregar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_TipoUniforme.SelectedIndexChanged
        LlenarCantidad()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_RUalm.SelectedIndexChanged
        LlenarCantidad()
    End Sub

    Private Sub ComboBox4_TextChanged(sender As Object, e As EventArgs) Handles Cmb_RUalm.TextChanged
        LlenarCantidad()
    End Sub


    Private Sub ComboHacia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboHacia.SelectedIndexChanged
        LlenarCantidades2()
    End Sub

    Private Sub ComboHacia_TextChanged(sender As Object, e As EventArgs) Handles ComboHacia.TextChanged
        LlenarCantidades2()
    End Sub

    Private Sub CantIniRecibe_TextChanged(sender As Object, e As EventArgs) Handles CantIniRecibe.TextChanged
        If CantIniRecibe.Text = "" Then
            MessageBox.Show("El almacen que va recibir no tiene inventario, es recomendable crear el registro primero con la cantidad 0")
        End If
    End Sub

    Private Sub TipoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoComboBox.SelectedIndexChanged
        LlenarCantAsignar()
    End Sub

    Private Sub EstadoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EstadoComboBox.SelectedIndexChanged
        LlenarCantAsignar()
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        LlenarCantAsignar()
    End Sub

    Private Sub MovimientosDeUniformesPorTipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeUniformesPorTipoToolStripMenuItem.Click
        R_MovimientosUniformesTipo.Show()
    End Sub

End Class