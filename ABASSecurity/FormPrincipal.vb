Imports System.Data.SqlClient

Public Class FormPrincipal

    Dim Download, Estado As String

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Volver()
        Permisos()
        Label5.Text = ClasePrivilegios.Nombre
        Foto()
        PanelUpdate.Hide()
        Version()
        EstadoInventario()
        Panel3.Visible = False
    End Sub

    Sub Foto()
        cn.Open()
        sql = "SELECT dbo.Empleados.codigo, dbo.UsuariosModulos.Usuario, dbo.Carnet.Fotografia
            FROM            dbo.Carnet INNER JOIN
            dbo.Empleados ON dbo.Carnet.Codigo = dbo.Empleados.identidad INNER JOIN
            dbo.UsuariosModulos ON dbo.Empleados.codigo = dbo.UsuariosModulos.Codigo
            WHERE        (dbo.Empleados.codigo = '" + Codigo + "')"
        da = New SqlDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Fotografia"), Byte())
            Dim ms As New System.IO.MemoryStream(imageBuffer)
            Dim bmp As New Bitmap(Image.FromStream(ms))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            OvalShape1.BackgroundImage = Nothing
            OvalShape1.BackgroundImageLayout = ImageLayout.Stretch
            OvalShape1.BackgroundImage = bmp
            dt.Clear()
            dt.Reset()
            ms.Dispose()
            ms.Close()
        End If
        cn.Close()
    End Sub

    Sub Permisos()
        '''''condicional de persimos
        If RRHH = "SI" Then
            cmdRRHH.Enabled = True
        Else
            cmdRRHH.Enabled = False
        End If

        If Clientes = "SI" Then
            cmdClientes.Enabled = True
        Else
            cmdClientes.Enabled = False
        End If

        If Operaciones = "SI" Then
            cmdOperaciones.Enabled = True
        Else
            cmdOperaciones.Enabled = False
        End If

        If Planilla = "SI" Then
            cmdPlanilla.Enabled = True
        Else
            cmdPlanilla.Enabled = False
        End If

        If Pagos = "SI" Then
            cmdPagos.Enabled = True
        Else
            cmdPagos.Enabled = False
        End If

        If Graficas = "SI" Then
            cmdGraficas.Enabled = True
        Else
            cmdGraficas.Enabled = False
        End If

        If Inventario = "SI" Then
            cmdInventario.Enabled = True
        Else
            cmdInventario.Enabled = False
        End If

        If Otros = "SI" Then
            cmdDetalles.Enabled = True
        Else
            cmdDetalles.Enabled = False
        End If

        If Usuarios = "SI" Then
            cmdUsuarios.Enabled = True
        Else
            cmdUsuarios.Enabled = False
        End If

        If ClasePrivilegios.Rango1 = "Gerencia" Then
            UltimoLogin()

        Else
            G_UltimoLogin.Visible = False
            GroupBox1.Visible = False
        End If

    End Sub

    Sub Version()
        cn.Open()
        cmd = New SqlCommand("select * from UpdateNV") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            txtVersion.Text = dr.Item("Version").ToString
            txtFecha.Text = (dr.Item("Fecha").ToString).Substring(0, 10)
            Download = dr.Item("Link").ToString
            If txtVersion.Text <> TextBox1.Text Then
                PanelUpdate.Show()
                cmdRRHH.Enabled = False
                cmdClientes.Enabled = False
                cmdOperaciones.Enabled = False
                cmdPlanilla.Enabled = False
                cmdPagos.Enabled = False
                cmdGraficas.Enabled = False
                cmdDetalles.Enabled = False
                cmdUsuarios.Enabled = False
                cmdInventario.Enabled = False
            End If
        End If

        txtVersion.Text = "Version " + dr.Item("Version").ToString

        dr.Close()
        cn.Close()

    End Sub

    Sub Volver()
        G_UltimoLogin.Visible = False
        panelOperaciones.Visible = False
        Panelrrhh.Visible = False
        panelInventario.Visible = False
        cmdRRHH.Location = New Point(0, 142)
        cmdClientes.Location = New Point(0, 182)
        cmdOperaciones.Location = New Point(0, 222)
        cmdPlanilla.Location = New Point(0, 262)
        cmdPagos.Location = New Point(0, 302)
        cmdGraficas.Location = New Point(0, 342)
        cmdInventario.Location = New Point(0, 382)
        cmdDetalles.Location = New Point(0, 422)
        cmdUsuarios.Location = New Point(0, 462)
    End Sub

    Private Sub CmdRRHH_Click(sender As Object, e As EventArgs) Handles cmdRRHH.Click
        If Panelrrhh.Visible = True Then
            Panelrrhh.Visible = False
            Volver()
        Else
            Panelrrhh.Visible = True
            panelOperaciones.Visible = False
            Panelrrhh.Location = New Point(0, 181)
            cmdClientes.Location = New Point(0, 298)
            cmdOperaciones.Location = New Point(0, 338)
            cmdPlanilla.Location = New Point(0, 378)
            cmdPagos.Location = New Point(0, 418)
            cmdGraficas.Location = New Point(0, 458)
            cmdInventario.Location = New Point(0, 498)
            cmdDetalles.Location = New Point(0, 538)
            cmdUsuarios.Location = New Point(0, 578)
            panelInventario.Visible = False
        End If
    End Sub

    Private Sub CmdClientes_Click(sender As Object, e As EventArgs) Handles cmdClientes.Click
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormClientes With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdOperacion_Click(sender As Object, e As EventArgs) Handles cmdOperaciones.Click

        If panelOperaciones.Visible = True Then
            panelOperaciones.Visible = False
            Volver()
        Else
            panelOperaciones.Visible = True
            Panelrrhh.Visible = False
            panelInventario.Visible = False
            cmdClientes.Location = New Point(0, 182)
            cmdOperaciones.Location = New Point(0, 222)
            panelOperaciones.Location = New Point(0, 262)
            cmdPlanilla.Location = New Point(0, 425)
            cmdPagos.Location = New Point(0, 465)
            cmdGraficas.Location = New Point(0, 505)
            cmdInventario.Location = New Point(0, 545)
            cmdDetalles.Location = New Point(0, 585)
            cmdUsuarios.Location = New Point(0, 625)
        End If

    End Sub

    Sub EstadoInventario()
        cmd = New SqlCommand("SELECT [estado]
                              FROM [ABAS].[dbo].[BloqueoInventario]", cn) With {
            .CommandType = CommandType.Text
        }

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Estado = dr.Item("estado").ToString
            ComboBox1.SelectedItem = Estado
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub CmdInventario_Click(sender As Object, e As EventArgs) Handles cmdInventario.Click
        EstadoInventario()
        If Estado = "NO" Then
            If panelInventario.Visible = True Then
                panelInventario.Visible = False
                Volver()
            Else
                panelInventario.Visible = True
                panelInventario.Location = New Point(0, 421)
                Panelrrhh.Visible = False
                panelOperaciones.Visible = False
                cmdClientes.Location = New Point(0, 182)
                cmdOperaciones.Location = New Point(0, 222)
                cmdPlanilla.Location = New Point(0, 262)
                cmdPagos.Location = New Point(0, 302)
                cmdGraficas.Location = New Point(0, 342)
                cmdInventario.Location = New Point(0, 382)
                cmdDetalles.Location = New Point(0, 580)
                cmdUsuarios.Location = New Point(0, 620)
            End If
        Else
            If Rango1 = "Gerencia" Then
                If panelInventario.Visible = True Then
                    panelInventario.Visible = False
                    Volver()
                Else
                    panelInventario.Visible = True
                    panelInventario.Location = New Point(0, 421)
                    Panelrrhh.Visible = False
                    panelOperaciones.Visible = False
                    cmdClientes.Location = New Point(0, 182)
                    cmdOperaciones.Location = New Point(0, 222)
                    cmdPlanilla.Location = New Point(0, 262)
                    cmdPagos.Location = New Point(0, 302)
                    cmdGraficas.Location = New Point(0, 342)
                    cmdInventario.Location = New Point(0, 382)
                    cmdDetalles.Location = New Point(0, 580)
                    cmdUsuarios.Location = New Point(0, 620)
                End If
            Else
                MessageBox.Show("El inventario esta bloqueado por auditoria")
            End If
        End If
    End Sub


    Private Sub CmdPlanilla_Click(sender As Object, e As EventArgs) Handles cmdPlanilla.Click
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormPlanilla With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub


    Private Sub CmdReportes_Click(sender As Object, e As EventArgs) Handles cmdGraficas.Click
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormGraficas With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo

        hijo.Show()
    End Sub

    Private Sub CmdPagos_Click(sender As Object, e As EventArgs) Handles cmdPagos.Click
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormPagos With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdDetalles_Click(sender As Object, e As EventArgs) Handles cmdDetalles.Click
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormOtros With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()

    End Sub


    Private Sub TimerFecha_Tick(sender As Object, e As EventArgs) Handles TimerFecha.Tick
        FechaPresentacion.Text = DateTime.Today
        HoraPresentacion.Text = TimeOfDay.ToString("HH:mm:ss")

        LlamaNoti()
    End Sub

    Sub LlamaNoti()
        If Rango1 = "Gerencia" Or Rango3 = "RRHH" Then
            Try
                cn.Open()
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                sql = "Select * From Recordatorio Where Fecha='" + FechaPresentacion.Text + "' and Hora='" + HoraPresentacion.Text + "'"
                cmd.CommandText = sql
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    FormRecordatorioMensaje.Show()
                End If
            Catch ex As Exception
            End Try
        End If
        cn.Close()
        dr.Close()

    End Sub

    Private Sub CmdAsignaciones_Click(sender As Object, e As EventArgs) Handles cmdAsignaciones.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignaciones With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdCambio_Click(sender As Object, e As EventArgs) Handles cmdCambio.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignacionesCambios With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdFalta_Click(sender As Object, e As EventArgs) Handles cmdFalta.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignacionesFaltas With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdDiasLibres.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignacionesDiasLibres With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MsgBox("¡Desea cerrar sesion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
            If Me.panelcontenedor.Controls.Count > 0 Then
                Me.panelcontenedor.Controls.RemoveAt(0)
            End If

            Dim hijo As New FormPrincipalBlanco With {
                .TopLevel = False,
                .FormBorderStyle = FormBorderStyle.None,
                .Dock = DockStyle.Fill
            }
            Me.panelcontenedor.Controls.Add(hijo)
            Me.panelcontenedor.Tag = hijo
            hijo.Show()

            cn.Close()
            FormLogin.Show()
            Me.Dispose()
        Else
        End If
    End Sub


    Private Sub CmdClientes_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdClientes.MouseClick
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormClientes With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdAsignaciones_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdAsignaciones.MouseClick
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignaciones With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdCambio_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdCambio.MouseClick
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignacionesCambios With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdFalta_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdFalta.MouseClick
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignacionesFaltas With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdDiasLibres_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdDiasLibres.MouseClick
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormAsignacionesDiasLibres With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdPlanilla_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdPlanilla.MouseClick
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormPlanilla With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()

    End Sub

    Private Sub CmdPagos_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdPagos.MouseClick
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormPagos With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdReportes_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdGraficas.MouseClick
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormGraficas With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdDetalles_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdDetalles.MouseClick
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormOtros With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub


    Private Sub Cmdregistro_Click(sender As Object, e As EventArgs) Handles cmdregistro.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormRRHH With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub Cmdregistro_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdregistro.MouseClick
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormRRHH With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub Cmdaspirantes_Click(sender As Object, e As EventArgs) Handles cmdaspirantes.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormRRHHAspirantes With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub Cmdaspirantes_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdaspirantes.MouseClick
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormRRHHAspirantes With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub Cmdexpediante_Click(sender As Object, e As EventArgs) Handles cmdexpediante.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormRRHHDocumentos With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub Cmdexpediante_MouseClick(sender As Object, e As MouseEventArgs) Handles cmdexpediante.MouseClick
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormRRHHDocumentos With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Sub UltimoLogin()
        cn.Open()
        cmd = New SqlCommand("select top(1) * from registrologin", cn) With {
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Label1.Text = dr.Item("usuario").ToString
            Label3.Text = dr.Item("fecha").ToString
            G_UltimoLogin.Visible = Visible
        End If
        dr.Close()
        cn.Close()
    End Sub


    Private Sub CmdUsuarios_Click(sender As Object, e As EventArgs) Handles cmdUsuarios.Click
        Volver()
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormUsuarios With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo

        hijo.Show()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.Links.Add(4, 9, Download)
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start(Download)
    End Sub

    Sub OcultarNoti()
        Panel1.Visible = False
        GroupBox1.Visible = False
        G_UltimoLogin.Visible = False
    End Sub

    Private Sub CmdArmeria_Click(sender As Object, e As EventArgs) Handles cmdArmeria.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormInventarioArmeriaMunicion With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdProveedores_Click(sender As Object, e As EventArgs) Handles cmdProveedores.Click

        If ClasePrivilegios.Rango1 <> "Gerencia" Then
            MessageBox.Show("No tiene permisos para utilizar esta seccion, Rango Gerencia")
        Else
            OcultarNoti()

            If Me.panelcontenedor.Controls.Count > 0 Then
                Me.panelcontenedor.Controls.RemoveAt(0)
            End If

            Dim hijo As New FormInventarioProveedoresAlmacenesVehiculos With {
                .TopLevel = False,
                .FormBorderStyle = FormBorderStyle.None,
                .Dock = DockStyle.Fill
            }
            Me.panelcontenedor.Controls.Add(hijo)
            Me.panelcontenedor.Tag = hijo
            hijo.Show()
        End If

    End Sub

    Private Sub CmdUniformes_Click(sender As Object, e As EventArgs) Handles cmdUniformes.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormInventarioUniformes With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdMobyEqui_Click(sender As Object, e As EventArgs) Handles cmdMob.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormInventarioMaterialesEquiposSeguridad With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub OvalShape1_Click(sender As Object, e As EventArgs) Handles OvalShape1.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            LinkLabel1.Links.Add(1, 9, Download)
            LinkLabel1.LinkVisited = True
            System.Diagnostics.Process.Start(Download)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            LinkLabel1.Links.Add(2, 9, "https://www.zerotier.com/download/")
            LinkLabel1.LinkVisited = True
            System.Diagnostics.Process.Start("https://www.zerotier.com/download/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked, LinkLabel5.LinkClicked
        Try
            LinkLabel1.Links.Add(3, 9, "https://mega.nz/folder/itQnzCwb#PkGr_q6iLDAEPCiOFgoQFQ")
            LinkLabel1.LinkVisited = True
            System.Diagnostics.Process.Start("https://mega.nz/folder/itQnzCwb#PkGr_q6iLDAEPCiOFgoQFQ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmdEquipo_Click(sender As Object, e As EventArgs) Handles cmdEquipo.Click
        OcultarNoti()

        If Me.panelcontenedor.Controls.Count > 0 Then
            Me.panelcontenedor.Controls.RemoveAt(0)
        End If

        Dim hijo As New FormInventarioMobiliarioEquiposOficina With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        Me.panelcontenedor.Controls.Add(hijo)
        Me.panelcontenedor.Tag = hijo
        hijo.Show()
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click
        sql = "UPDATE [dbo].[BloqueoInventario]
             SET [estado] = '" + ComboBox1.SelectedItem + "'"
        Ejecutar(sql)
    End Sub
End Class