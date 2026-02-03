
Imports System.Data.SqlClient
Imports QRCoder

Public Class FormRRHH

    ' Variables publicas
    ReadOnly obj As New ClaseBusquedasDinamicas

    'Para mapas
    'Dim markerOverlay As GMapOverlay = New GMapOverlay("markers")
    'Dim marker As GMarkerGoogle
    'Dim X As String
    'Dim Y As String
    'Ubicacion default (Oficinas ABAS)
    'Dim DX As String = 15.5248783
    'Dim DY As String = -88.0281609

    Private Sub FormRRHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ABASDataSet.PreciosCarnet' table. You can move, or remove it, as needed.
        Me.PreciosCarnetTableAdapter.Fill(Me.ABASDataSet.PreciosCarnet)
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Planillas' Puede moverla o quitarla según sea necesario.
        Me.PlanillasTableAdapter.Fill(Me.ABASDataSet.Planillas)

        If ClasePrivilegios.Rango1 <> "Gerencia" Then
            TabPage2.Enabled = False
        End If

        LoadRRHH()
    End Sub

    Sub LoadRRHH()
        txtbusqueda.Focus()
        panelnuevoregistro.Visible = False
        Panelinactivos.Visible = False
        PanelValidaCarnet.Visible = False
        'panelCoordenadas.Visible = False
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        labelsalario.Visible = False
        NomdebancoComboBox.SelectedItem = "Seleccionar"
        TipodesangreTextBox.SelectedText = "Seleccionar"
        PlanillaComboBox.SelectedText = "Seleccionar"
        EstadoComboBox.SelectedItem = "Seleccionar"
        EstadocivilComboBox.SelectedItem = "Seleccionar"
        ParentescoComboBox.SelectedItem = "Seleccionar"
        NumdecuentaTextBox.Text = 0
        ObservacionTextBox.Text = "Ninguna"
        BonosTextBox.Text = 0
        HijosTextBox.Text = 0
        SalarioTextBox.Text = 0
        ComboBox_BHORAS.SelectedItem = "120"
        txt_depreciacion.Text = 0

        LlenarDepartamentos()
        LlenarPlanillas()

        If ClasePrivilegios.Rango1 <> "Gerencia" Then
            TabPage3.Enabled = False
        End If


    End Sub

    Private Sub Cmdnuevo_Click(sender As Object, e As EventArgs) Handles cmdnuevo.Click
        If panelnuevoregistro.Visible = True Then
            panelnuevoregistro.Visible = False
        Else
            panelnuevoregistro.Visible = True
        End If
        cmdActualizar.Enabled = False
        CmdCSalario.Enabled = False
        CmdCBono.Enabled = False
        cmdGuardar.Enabled = True
        SalarioTextBox.Enabled = True
        BonosTextBox.Text = 0
        HijosTextBox.Text = 0
        SalarioTextBox.Text = 0
        ComboBox_BHORAS.SelectedItem = "120"
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If PictureFoto.BackgroundImage Is Nothing Then
            MsgBox("¡No se ha agregado foto al empleado, no es permitido guardar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ok")
        ElseIf NumdecuentaTextBox.Text = "0" Or NumdecuentaTextBox.Text = "" Then
            MsgBox("¡No se ha agregado cuenta de banco, no es permitido guardar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ok")
        Else
            GuardarEmpleado()
        End If
    End Sub

    Sub GuardarEmpleado()
        If IdentidadTextBox.Text = "" Or IdentidadTextBox.Text = "0000-0000-00000" Then
            MessageBox.Show("Ingrese la identidad de la persona")
        ElseIf IdentidadTextBox.TextLength < 15 Then
            MessageBox.Show("Numero de identidad invalido")
        ElseIf Telefono1TextBox.TextLength < 9 Then
            MessageBox.Show("Numero de Telefono 1 invalido")
        ElseIf Telefono2TextBox.TextLength < 9 Then
            MessageBox.Show("Numero de Telefono 2 invalido")
        ElseIf Telefono3TextBox.TextLength < 9 Then
            MessageBox.Show("Numero de Telefono 3 invalido")
        ElseIf Telefono4TextBox.TextLength < 9 Then
            MessageBox.Show("Numero de Telefono 4 invalido")
        ElseIf EstadoComboBox.Text = "Seleccionar" Then
            MessageBox.Show("Debe seleccionar el estado del empleado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf PlanillaComboBox.Text = "Seleccionar" Then
            MessageBox.Show("Debe seleccionar la planilla de pago", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MsgBox("¡Desea guardar el nuevo empleado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                CrearQR()

                cn.Open()
                cmd = New SqlCommand("Select * From Empleados Where identidad ='" + IdentidadTextBox.Text + "'", cn) With {
            .CommandType = CommandType.Text
        }
                dr = cmd.ExecuteReader()
                dr.Read()

                Dim b As Integer
                If dr.HasRows Then
                    MessageBox.Show("Ya existe un registro con el mimso numero de identidad", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    b = Convert.ToInt16(ComboBox_BHORAS.SelectedItem)
                    sql = "INSERT INTO [dbo].[Empleados]
               ([nombres]
               ,[apellidos]
               ,[identidad]
               ,[cargo]
               ,[telefono]
               ,[telefono2]
               ,[telefono3]
               ,[tipodesangre]
               ,[fechadenacimiento]
               ,[salario]
               ,[numdecuenta]
               ,[nomdebanco]
               ,[fechadeingreso]
               ,[estado]
               ,[ubicacion]
               ,[planilla]
               ,[direccion]
               ,[bonos]
               ,[observacion]
               ,[nombre]
               ,[estadocivil]
               ,[hijos]
               ,[parentesco]
               ,[direccion2]
               ,[telefono4]
               ,[bhoras]
               ,[depreciacion])
         VALUES
               ('" + NombresTextBox.Text + "'
               ,'" + ApellidosTextBox.Text + "'
               ,'" + IdentidadTextBox.Text + "'
               ,'" + CargoTextBox.Text + "'
               ,'" + Telefono1TextBox.Text + "'
               ,'" + Telefono2TextBox.Text + "'
               ,'" + Telefono3TextBox.Text + "'
               ,'" + TipodesangreTextBox.Text + "'
               ,'" + FechadenacimientoDateTimePicker.Text + "'
               ,'" + SalarioTextBox.Text + "'
               ,'" + NumdecuentaTextBox.Text + "'
               ,'" + NomdebancoComboBox.SelectedItem.ToString + "'
               ,'" + FechadeingresoDateTimePicker.Text + "'
               ,'" + EstadoComboBox.SelectedItem.ToString + "'
               ,'" + TextBox1.Text + "'
               ,'" + PlanillaComboBox.Text + "'
               ,'" + DireccionTextBox.Text + "'
               ,'" + BonosTextBox.Text + "'
               ,'" + ObservacionTextBox.Text + "'
               ,'" + NombreTextBox.Text + "'
               ,'" + EstadocivilComboBox.SelectedItem.ToString + "'
               ,'" + HijosTextBox.Text + "'
               ,'" + ParentescoComboBox.SelectedItem.ToString + "'
               ,'" + DireccionTextBox1.Text + "'
               ,'" + Telefono4TextBox.Text + "'
               ,'" + ComboBox_BHORAS.SelectedItem.ToString + "'
               ,'" + txt_depreciacion.Text + "')"
                    Ejecutar(sql)
                    panelnuevoregistro.Hide()
                    obj.Llamadgv(EmpleadosDataGridView)
                End If
            End If
            dr.Close()
            cn.Close()
            Guardar_imagen()
            MsgBox("¡Empleado registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub


    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If MsgBox("¡Desea actualizar los datos del empleado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            CrearQR()
            If IdentidadTextBox.Text = "" Or IdentidadTextBox.Text = "0000-0000-00000" Then
                MessageBox.Show("Ingrese la identidad de la persona")
            ElseIf IdentidadTextBox.TextLength < 15 Then
                MessageBox.Show("Numero de identidad invalido")
            ElseIf Telefono1TextBox.TextLength < 9 Then
                MessageBox.Show("Numero de Telefono 1 invalido")
            ElseIf Telefono2TextBox.TextLength < 9 Then
                MessageBox.Show("Numero de Telefono 2 invalido")
            ElseIf Telefono3TextBox.TextLength < 9 Then
                MessageBox.Show("Numero de Telefono 3 invalido")
            ElseIf Telefono4TextBox.TextLength < 9 Then
                MessageBox.Show("Numero de Telefono 4 invalido")
            ElseIf EstadoComboBox.Text = "Seleccionar" Then
                MessageBox.Show("Debe seleccionar el estado del empleado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf IdempleadoTextBox.Text = "" Then
                MessageBox.Show("Debe seleccionar un empleado para poder actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TipodesangreTextBox.SelectedItem = "Seleccionar" Then
                MessageBox.Show("Debe seleccionar el tipo de sangre para poder actualizar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql = "update Empleados set 
            nombres ='" + NombresTextBox.Text + "', 
            apellidos ='" + ApellidosTextBox.Text + "', 
            identidad ='" + IdentidadTextBox.Text + "',
            cargo ='" + CargoTextBox.Text + "',
            telefono ='" + Telefono1TextBox.Text + "',
            telefono2 ='" + Telefono2TextBox.Text + "',
            telefono3 ='" + Telefono3TextBox.Text + "',
            tipodesangre ='" + TipodesangreTextBox.SelectedItem.ToString + "',
            fechadenacimiento ='" + FechadenacimientoDateTimePicker.Text + "', 
            numdecuenta ='" + NumdecuentaTextBox.Text + "', 
            nomdebanco ='" + NomdebancoComboBox.SelectedItem.ToString + "', 
            fechadeingreso = '" + FechadeingresoDateTimePicker.Text + "',
            estado ='" + EstadoComboBox.SelectedItem.ToString + "',
            ubicacion ='" + ListBox1.SelectedValue + "',
            planilla ='" + PlanillaComboBox.Text + "',
            direccion = '" + DireccionTextBox.Text + "',
            bonos = '" + BonosTextBox.Text + "',
            observacion = '" + ObservacionTextBox.Text + "',
            nombre ='" + NombreTextBox.Text + "',
            estadocivil ='" + EstadocivilComboBox.SelectedItem.ToString + "',
            telefono4 ='" + Telefono4TextBox.Text + "',
            hijos ='" + HijosTextBox.Text + "',
            bhoras ='" + ComboBox_BHORAS.SelectedItem + "',
            depreciacion ='" + txt_depreciacion.Text + "',
            parentesco ='" + ParentescoComboBox.SelectedItem.ToString + "',
            direccion2 ='" + DireccionTextBox1.Text + "' where idempleado = '" + IdempleadoTextBox.Text + "'"
                Ejecutar(sql)
                Guardar_imagen()
                Limpiar()
                txtbusqueda.Clear()
                tipodebusqueda.SelectedItem = "Codigo de Empleado"
                panelnuevoregistro.Visible = False
                Button2.Enabled = True
                EstadoComboBox.Enabled = True
                cmdnuevo.Enabled = True
            End If
            MsgBox("¡Empleado actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub


    Private Sub CmdOcultar_Click(sender As Object, e As EventArgs)
        panelnuevoregistro.Visible = False
        Limpiar()
    End Sub

    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged

        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" And txtbusqueda.TextLength = 6 Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & txtbusqueda.Text + "%" & "'"
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            EmpleadosDataGridView.DataSource = dt
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
            sql = "select * from Empleados where ubicacion like '" & txtbusqueda.Text + "%" & "'"
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            EmpleadosDataGridView.DataSource = dt
        End If

        If tipodebusqueda.SelectedItem.ToString = "Ubicacion" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and ubicacion like '" & txtbusqueda.Text + "%" & "'"

            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            EmpleadosDataGridView.DataSource = dt
        End If

        If tipodebusqueda.SelectedItem.ToString = "Planilla" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and planilla like '" & txtbusqueda.Text + "%" & "'"

            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            EmpleadosDataGridView.DataSource = dt
        End If

        If txtbusqueda.Text = "" Then
            Limpiar()
            EmpleadosDataGridView.DataSource = vbNull
        End If
    End Sub

    Sub Limpiar()
        txt_depreciacion.Clear()
        IdempleadoTextBox.Clear()
        CodigoTextBox.Clear()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        IdentidadTextBox.Text = "0000-0000-00000"
        CargoTextBox.Clear()
        Telefono1TextBox.Text = "0000-0000"
        Telefono2TextBox.Text = "0000-0000"
        Telefono3TextBox.Text = "0000-0000"
        Telefono4TextBox.Text = "0000-0000"
        SalarioTextBox.Clear()
        NumdecuentaTextBox.Text = 0
        ObservacionTextBox.Text = "Ninguna"
        FechadeingresoDateTimePicker.Value = Date.Now
        FechadenacimientoDateTimePicker.Value = Date.Now
        obj.Llamadgv(EmpleadosDataGridView)
        EstadoComboBox.SelectedItem = "Seleccionar"
        NomdebancoComboBox.SelectedItem = "Seleccionar"
        TipodesangreTextBox.SelectedText = "Seleccionar"
        PlanillaComboBox.SelectedItem = "Seleccionar"
        DireccionTextBox.Clear()

        NombreTextBox.Clear()
        Telefono4TextBox.Clear()
        DireccionTextBox1.Clear()
        HijosTextBox.Clear()
        EstadocivilComboBox.SelectedItem = "Seleccionar"
        ParentescoComboBox.SelectedItem = "Seleccionar"

        TextBox1.Clear()
        BonosTextBox.Text = 0
        HijosTextBox.Text = 0
        SalarioTextBox.Text = 0
        ComboBox_BHORAS.SelectedItem = "120"
        txt_depreciacion.Text = 0
        PictureFoto.BackgroundImage = Nothing
        PictureQR.BackgroundImage = Nothing
    End Sub

    Sub Limpiar2()
        IdempleadoTextBox.Clear()
        CodigoTextBox.Clear()
        NombresTextBox.Clear()
        ApellidosTextBox.Clear()
        IdentidadTextBox.Text = "0000-0000-00000"
        CargoTextBox.Clear()
        Telefono1TextBox.Text = "0000-0000"
        Telefono2TextBox.Text = "0000-0000"
        Telefono3TextBox.Text = "0000-0000"
        Telefono4TextBox.Text = "0000-0000"
        SalarioTextBox.Clear()
        NumdecuentaTextBox.Text = 0
        ObservacionTextBox.Text = "Ninguna"
        FechadeingresoDateTimePicker.Value = Date.Now
        FechadenacimientoDateTimePicker.Value = Date.Now
        EstadoComboBox.SelectedItem = "Seleccionar"
        NomdebancoComboBox.SelectedItem = "Seleccionar"
        TipodesangreTextBox.SelectedText = "Seleccionar"
        PlanillaComboBox.SelectedItem = "Seleccionar"
        DireccionTextBox.Clear()
        TextBox1.Clear()
        BonosTextBox.Text = 0
        HijosTextBox.Text = 0
        SalarioTextBox.Text = 0
        ComboBox_BHORAS.SelectedItem = "120"
        txt_depreciacion.Text = 0
        PictureFoto.BackgroundImage = Nothing
        PictureQR.BackgroundImage = Nothing
    End Sub

    Private Sub SalarioTextBox_Click(sender As Object, e As EventArgs) Handles SalarioTextBox.Click
        labelsalario.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormRecordatorio.ShowDialog()
    End Sub

    Private Sub Cmdocultar_Click_1(sender As Object, e As EventArgs)
        panelnuevoregistro.Visible = False
        Limpiar()
    End Sub

    Private Sub CmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        obj.Llamadgv(EmpleadosDataGridView)
    End Sub

    Private Sub EstadoDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeEmpleadosToolStripMenuItem.Click
        R_EstadoEmpleado.Show()
    End Sub


    Private Sub IdentidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdentidadTextBox.TextChanged
        'para condicionar un textbox
        If IdentidadTextBox.Text.Length <= 10 Then
            If IdentidadTextBox.Text.Length >= 5 Then
                Dim s As String = IdentidadTextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                IdentidadTextBox.Text = s
                IdentidadTextBox.SelectionStart = s.Length
            End If
        End If
        CrearQR()
    End Sub

    Private Sub TelefonoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Telefono1TextBox.TextChanged

        'para condicionar un textbox
        If Telefono1TextBox.Text.Length <= 10 Then
            If Telefono1TextBox.Text.Length >= 5 Then
                Dim s As String = Telefono1TextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                Telefono1TextBox.Text = s
                Telefono1TextBox.SelectionStart = s.Length
            End If
        End If
        CrearQR()
    End Sub

    Private Sub Telefono2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Telefono2TextBox.TextChanged
        'para condicionar un textbox
        If Telefono2TextBox.Text.Length <= 10 Then
            If Telefono2TextBox.Text.Length >= 5 Then
                Dim s As String = Telefono2TextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                Telefono2TextBox.Text = s
                Telefono2TextBox.SelectionStart = s.Length
            End If
        End If
    End Sub

    Private Sub Telefono3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Telefono3TextBox.TextChanged
        'para condicionar un textbox
        If Telefono3TextBox.Text.Length <= 10 Then
            If Telefono3TextBox.Text.Length >= 5 Then
                Dim s As String = Telefono3TextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                Telefono3TextBox.Text = s
                Telefono3TextBox.SelectionStart = s.Length
            End If
        End If
    End Sub

    Private Sub NomdebancoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TipodesangreTextBox.KeyPress, tipodebusqueda.KeyPress, PlanillaComboBox.KeyPress, NomdebancoComboBox.KeyPress, EstadoComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        panelnuevoregistro.Visible = False
        cmdActualizar.Enabled = False
        CmdCSalario.Enabled = False
        cmdGuardar.Enabled = True
        SalarioTextBox.Enabled = True
        cmdnuevo.Enabled = True
    End Sub

    Private Sub HistoricoDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoDeEmpleadoToolStripMenuItem.Click
        R_Puestos.ShowDialog()
    End Sub

    Private Sub TelefonoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Telefono4TextBox.TextChanged
        If Telefono4TextBox.Text.Length <= 10 Then
            If Telefono4TextBox.Text.Length >= 5 Then
                Dim s As String = Telefono4TextBox.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                Telefono4TextBox.Text = s
                Telefono4TextBox.SelectionStart = s.Length
            End If
        End If
    End Sub


    Private Sub ReporteDeExpedientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeExpedientesToolStripMenuItem.Click
        R_DocumentosEmpleados.ShowDialog()
    End Sub

    Sub ImprimirCarnet()


        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = ""
        sql = "select * from RegistroCarnet where Codigo ='" + IdentidadTextBox.Text + "'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            If MsgBox("Ya se imprimio un carnet a este empleado, si se reeimprime este sera cobrado la siguiente planilla, ¿desea imprimir con cobro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Informacion") = MsgBoxResult.Yes Then
                sql = "UPDATE [dbo].[RegistroCarnet]
                       SET [Estado] = 'Cobro'
                          ,[Fecha] = GETDATE()
                          ,[Observacion] = '" + txtObservacionCarnet.Text + "'
                          ,[Precio] = (select top(1) preciocarnet from precioscarnet
                    order by fecha desc)
                     WHERE [Codigo] = '" + IdentidadTextBox.Text + "'"
                Ejecutar(sql)
                MsgBox("¡Se ha registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                R_Carnet.Show()
            Else
                PanelValidaCarnet.Show()
            End If
        Else
            If MsgBox("¡Desea guardar el registro de impresion de carnet?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                sql = "INSERT INTO [dbo].[RegistroCarnet]
           ([Codigo]
           ,[Estado]
           ,[Fecha]
           ,[Observacion]
           ,[Precio])
     VALUES
           ('" + IdentidadTextBox.Text + "'
           ,'Gratis'
           , GETDATE()
           ,'Ninguna'
           ,0)"
                Ejecutar(sql)
                MsgBox("¡Se ha registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                R_Carnet.Show()
            End If

        End If

        dr.Close()
        cn.Close()
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick

        ''estos slo estan por un pequeño bug cuando ya esta mostrado el panel y se seleccona otro empleado a veces se pega la data
        panelnuevoregistro.Visible = False
        Limpiar2()
        cmdActualizar.Enabled = False
        CmdCSalario.Enabled = False
        cmdGuardar.Enabled = True
        SalarioTextBox.Enabled = True
        cmdnuevo.Enabled = True
        ''-----------------------------------

        panelnuevoregistro.Visible = True
        cmdGuardar.Enabled = False
        CmdCSalario.Enabled = True
        CmdCBono.Enabled = True
        cmdActualizar.Enabled = True

        If Rango1 <> "Gerencia" Then
            SalarioTextBox.Enabled = False
            BonosTextBox.Enabled = False
        End If

        cmdnuevo.Enabled = False

        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)
            CodigoTextBox.Text = selectedRow.Cells(1).Value.ToString
            NombresTextBox.Text = selectedRow.Cells(2).Value.ToString
            ApellidosTextBox.Text = selectedRow.Cells(3).Value.ToString
            IdentidadTextBox.Text = selectedRow.Cells(4).Value.ToString
            CargoTextBox.Text = selectedRow.Cells(5).Value.ToString
            Telefono1TextBox.Text = selectedRow.Cells(6).Value.ToString
            Telefono2TextBox.Text = selectedRow.Cells(7).Value.ToString
            Telefono3TextBox.Text = selectedRow.Cells(8).Value.ToString
            TipodesangreTextBox.SelectedItem = selectedRow.Cells(9).Value.ToString
            FechadenacimientoDateTimePicker.Value = selectedRow.Cells(10).Value.ToString
            SalarioTextBox.Text = selectedRow.Cells(11).Value.ToString
            NumdecuentaTextBox.Text = selectedRow.Cells(12).Value.ToString
            NomdebancoComboBox.SelectedItem = selectedRow.Cells(13).Value.ToString
            FechadeingresoDateTimePicker.Value = selectedRow.Cells(14).Value.ToString
            EstadoComboBox.SelectedItem = selectedRow.Cells(15).Value.ToString
            TextBox1.Text = selectedRow.Cells(16).Value.ToString
            DireccionTextBox.Text = selectedRow.Cells(18).Value.ToString
            BonosTextBox.Text = selectedRow.Cells(19).Value.ToString
            ObservacionTextBox.Text = selectedRow.Cells(20).Value.ToString
            NombreTextBox.Text = selectedRow.Cells(21).Value.ToString
            EstadocivilComboBox.SelectedItem = selectedRow.Cells(22).Value.ToString
            HijosTextBox.Text = selectedRow.Cells(23).Value.ToString
            ParentescoComboBox.SelectedItem = selectedRow.Cells(24).Value.ToString
            DireccionTextBox1.Text = selectedRow.Cells(25).Value.ToString
            Telefono4TextBox.Text = selectedRow.Cells(26).Value.ToString
            ComboBox_BHORAS.SelectedItem = selectedRow.Cells(27).Value.ToString
            txt_depreciacion.Text = selectedRow.Cells(28).Value.ToString
            IdempleadoTextBox.Text = selectedRow.Cells(0).Value.ToString
            PlanillaComboBox.SelectedItem = selectedRow.Cells(17).Value.ToString
        Catch

        End Try

        cn.Open()
        sql = "SELECT * FROM Carnet WHERE Codigo = '" + IdentidadTextBox.Text + "'"
        da = New SqlDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Fotografia"), Byte())
            Dim imageBuffer2() As Byte = CType(dt.Rows(0).Item("QR"), Byte())
            Dim ms As New System.IO.MemoryStream(imageBuffer)
            Dim ms2 As New System.IO.MemoryStream(imageBuffer2)
            Dim bmp As New Bitmap(Image.FromStream(ms))
            Dim bmp2 As New Bitmap(Image.FromStream(ms2))
            bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            bmp2 = bmp2.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero)
            PictureFoto.BackgroundImage = Nothing
            PictureFoto.BackgroundImageLayout = ImageLayout.Stretch
            PictureFoto.BackgroundImage = bmp
            PictureQR.BackgroundImage = Nothing
            PictureQR.BackgroundImageLayout = ImageLayout.Stretch
            PictureQR.BackgroundImage = bmp2
            dt.Clear()
            dt.Reset()
            ms.Dispose()
            ms.Close()
            ms2.Dispose()
            ms2.Close()
        End If
        cn.Close()

        CodigoEmpleado = CodigoTextBox.Text
        Identidad = IdentidadTextBox.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        panelnuevoregistro.Enabled = True
        Button2.Enabled = True
        Panelinactivos.Visible = False
        EstadoComboBox.Text = "Seleccionar"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles ButtonGuardarInactivos.Click
        If MsgBox("Desea inactivar al empleado, los empleados inactivos solo se pueden filtrar por identidad?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * From Inactivos Where codigo ='" + CodigoTextBox.Text + "'"
            cmd.CommandText = sql

            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("¡Este empleado ya esta en estado inactivo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "insert into Inactivos values('" + CodigoTextBox1.Text + "',
                                    '" + FechadesalidaDateTimePicker.Text + "',
                                    '" + MotivoComboBox.Text + "',
                                    '" + CarnetComboBox.Text + "',
                                    '" + uniformecombo.SelectedItem + "',
                                    '" + ComentarioTextBox.Text + "')"
                Ejecutar(sql)
                panelnuevoregistro.Enabled = True
                Panelinactivos.Visible = False
                EstadoComboBox.Enabled = False
                Button2.Enabled = False
            End If
            dr.Close()
            cn.Close()
            MsgBox("¡El empleado ha sido inactivado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonActualizarIncativos.Click
        If MsgBox("¡Desea inactivar al empleado, los empleados inactivos solo se pueden filtrar por identidad?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            Button2.Enabled = False
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * From Inactivos Where codigo ='" + CodigoTextBox.Text + "'"
            cmd.CommandText = sql

            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                sql = "update Inactivos set 
                                fechadesalida ='" + FechadesalidaDateTimePicker.Value + "', 
                                motivo ='" + MotivoComboBox.SelectedItem + "', 
                                carnet ='" + CarnetComboBox.SelectedItem + "',
                                uniforme ='" + uniformecombo.SelectedItem + "',
                                comentario ='" + ComentarioTextBox.Text + "' where codigo ='" + CodigoTextBox1.Text + "'"
                Ejecutar(sql)
                Panelinactivos.Visible = False
            End If
            dr.Close()
            cn.Close()
            MsgBox("¡El empleado ha sido inactivado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Private Sub ReporteDeCumpleañerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCumpleañerosToolStripMenuItem.Click
        R_Cumple.ShowDialog()
    End Sub

    Private Sub ReporteDeInactivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeInactivosToolStripMenuItem.Click
        R_Inactivos.ShowDialog()
    End Sub


    Private Sub SalarioTextBox_MouseLeave(sender As Object, e As EventArgs) Handles SalarioTextBox.MouseLeave
        labelsalario.Visible = False
    End Sub
    Private Sub EstadoComboBox_TextChanged(sender As Object, e As EventArgs) Handles EstadoComboBox.TextChanged
        If EstadoComboBox.Text = "Inactivo" And CodigoTextBox.Text <> "" Then
            Panelinactivos.Visible = True
            cn.Open()
            cmd.Connection = cn
            cmd = New SqlCommand("Select * From Inactivos Where codigo ='" + CodigoTextBox.Text + "'", cn) With {
                .CommandType = CommandType.Text
            }
            dr = cmd.ExecuteReader()

            If dr.Read Then

                CodigoTextBox1.Text = dr.Item("codigo")
                FechadesalidaDateTimePicker.Value = dr.Item("fechadesalida")
                MotivoComboBox.Text = dr.Item("motivo")
                CarnetComboBox.Text = dr.Item("carnet")
                uniformecombo.Text = dr.Item("uniforme")
                ComentarioTextBox.Text = dr.Item("comentario")
            Else
                CodigoTextBox1.Text = CodigoTextBox.Text
                FechadesalidaDateTimePicker.Value = Now
                MotivoComboBox.Text = "Despido"
                CarnetComboBox.Text = "No"
                uniformecombo.Text = "No"
                ComentarioTextBox.Clear()
                dr.Close()
            End If

            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub IdentidadTextBox_Click(sender As Object, e As EventArgs) Handles IdentidadTextBox.Click
        IdentidadTextBox.Clear()
    End Sub

    Private Sub Telefono1TextBox_Click(sender As Object, e As EventArgs) Handles Telefono1TextBox.Click
        Telefono1TextBox.Clear()
    End Sub

    Private Sub Telefono2TextBox_Click(sender As Object, e As EventArgs) Handles Telefono2TextBox.Click
        Telefono2TextBox.Clear()
    End Sub

    Private Sub FaltasDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormAsignacionesFaltasGuardadas.ShowDialog()
    End Sub

    Private Sub RollDiarioDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RollDiarioDeEmpleadoToolStripMenuItem.Click
        R_AsignacionporCodigo.ShowDialog()
    End Sub

    Private Sub AsignacionesPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionesPorClienteToolStripMenuItem.Click
        R_AsignacionesporCliente.ShowDialog()
    End Sub

    Private Sub AsignacionesGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionesGeneralesToolStripMenuItem.Click
        R_AsignacionesGenerales.ShowDialog()
    End Sub

    Private Sub FaltasDeEmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FaltasDeEmpleadoToolStripMenuItem1.Click
        R_45.ShowDialog()
    End Sub

    Private Sub VoucherDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoucherDePagoToolStripMenuItem.Click
        R_Boucher.ShowDialog()
    End Sub

    Private Sub PlanillaDeDeduccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillaDeDeduccionesToolStripMenuItem.Click
        R_Deducciones.ShowDialog()
    End Sub

    Private Sub PlanillaDePagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillaDePagosToolStripMenuItem.Click
        R_Planilla.ShowDialog()
    End Sub

    Private Sub UbicacionComboBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ParentescoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ParentescoComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub EstadocivilComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstadocivilComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub EstadoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EstadoComboBox.SelectedIndexChanged
        If CodigoTextBox.Text = "" And EstadoComboBox.SelectedItem = "Inactivo" Then
            MessageBox.Show("Se debe crear el empleado para colocarlo como inactivo.")
            EstadoComboBox.SelectedItem = "Seleccionar"
        End If
    End Sub

    Private Sub ReporteAniversariosEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteAniversariosEmpleadosToolStripMenuItem.Click
        R_Aniversarios.ShowDialog()
    End Sub

    Private Sub TodosLosEmpleadosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TodosLosEmpleadosToolStripMenuItem.Click
        R_EmpleadosTotal.Show()
    End Sub


    Private Sub TextBoxQR_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQR.TextChanged
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(TextBoxQR.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        PictureQR.Image = code.GetGraphic(6)
        PictureQR.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Sub CrearQR()
        TextBoxQR.Text = NombresTextBox.Text & " " & ApellidosTextBox.Text & "
" & IdentidadTextBox.Text & "
" & DireccionTextBox.Text & "
" & Telefono1TextBox.Text & ""
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles cmdImprimirCarnet.Click
        'CrearQR()
        'Guardar_imagen()

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = ""
        sql = "select * from RegistroCarnet where Codigo ='" + IdentidadTextBox.Text + "' and Estado = 'Cobro'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            dr.Close()
            cn.Close()
            MsgBox("Este empleado tiene un cobro de carnet pendiente, no se permite reimprimir sin antes deducir", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
        Else
            dr.Close()
            cn.Close()
            ImprimirCarnet()
        End If



    End Sub

    Private Sub HistorialDeCarnetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeCarnetToolStripMenuItem.Click
        R_RegistroCarnet.Show()
    End Sub


    Private Sub CmdReparar_Click(sender As Object, e As EventArgs) Handles cmdReparar.Click
        If MsgBox("Esta Opcion solo debe usuarse, cuando la aplicacion se salta un codigo (Pierde el correlativo), Desea continuar", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
            sql = "DECLARE @max int
                     delete from Empleados where idempleado = '" + IdempleadoTextBox.Text + "'
                     SELECT @max=max(idempleado) FROM Empleados
                     IF @max IS NULL
                    SET @max = 0
                    ELSE
                    DBCC CHECKIDENT ('[Empleados]', RESEED,@max)"
            Ejecutar(sql)
            obj.Llamadgv(EmpleadosDataGridView)
            cmdGuardar.Enabled = True
        End If
        MsgBox("¡Ahora proceda a guardar el empleado, para que el sistema asigne el codigo correcto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
    End Sub

    Private Sub Cmdcambiosalario_Click(sender As Object, e As EventArgs) Handles CmdCSalario.Click
        If SalarioTextBox.Text = "" Then
            MsgBox("¡Debe escribir el nuevo salario!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            SalarioTextBox.Focus()
        Else
            If MsgBox("¡Desea guardar el nuevo salario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                If Rango1 = "Gerencia" Then
                    sql = "update Empleados set salario ='" + SalarioTextBox.Text + "' where idempleado = '" + IdempleadoTextBox.Text + "'"
                    Ejecutar(sql)
                End If
                MsgBox("¡Nuevo salario registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            End If
        End If
    End Sub


    Private Sub Telefono3TextBox_Click(sender As Object, e As EventArgs) Handles Telefono3TextBox.Click
        Telefono3TextBox.Clear()
    End Sub



    Private Sub Telefono4TextBox_Click(sender As Object, e As EventArgs) Handles Telefono4TextBox.Click
        Telefono4TextBox.Clear()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If TextBox1.Text = "" Then
        Else
            If MsgBox("Se agregara un nueva ubicacion, no se puede cancelar, Desea confirmar", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                cn.Open()
                cmd.Connection = cn
                cmd = New SqlCommand("SELECT * FROM [ABAS].[dbo].[Departamento] WHERE ubicacion = '" + TextBox1.Text + "'", cn) With {
                .CommandType = CommandType.Text
            }
                dr = cmd.ExecuteReader()

                If dr.Read Then
                    MsgBox("¡La Ubicacion ha sido registrada anteriormente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ok")
                Else
                    sql = "insert into departamento (ubicacion) values('" + TextBox1.Text + "')"
                    Ejecutar(sql)
                    LlenarDepartamentos()
                    MsgBox("¡Ubicacion registrada exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                End If

                cn.Close()
                dr.Close()
            End If

        End If

    End Sub

    Sub Guardar_imagen()
        If PictureFoto.BackgroundImage IsNot Nothing Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * from Carnet where codigo = '" + IdentidadTextBox.Text + "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                Dim ms2 As New System.IO.MemoryStream()
                PictureFoto.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                PictureQR.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "UPDATE Carnet SET Fotografia=@Fotografia, QR=@QR WHERE Codigo ='" + IdentidadTextBox.Text + "'"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Fotografia", ms1.GetBuffer()))
                cmd.Parameters.Add(New SqlParameter("@QR", ms2.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms2.Dispose()
                ms1.Close()
                ms2.Close()

            Else
                dr.Close()

                Dim ms1 As New System.IO.MemoryStream()
                Dim ms2 As New System.IO.MemoryStream()
                PictureFoto.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
                PictureQR.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
                sql = "INSERT INTO Carnet VALUES ('" + IdentidadTextBox.Text + "', @Fotografia, @QR)"
                cmd = New SqlCommand(sql, cn)
                cmd.Parameters.Add(New SqlParameter("@Fotografia", ms1.GetBuffer()))
                cmd.Parameters.Add(New SqlParameter("@QR", ms2.GetBuffer()))
                cmd.ExecuteNonQuery()
                ms1.Dispose()
                ms2.Dispose()
                ms1.Close()
                ms2.Close()
            End If

            cn.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles CmdCBono.Click
        If MsgBox("¡Desea guardar el nuevo bono para el empleado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If SalarioTextBox.Text = "" Then
                MsgBox("¡Agregue una cantidad!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                SalarioTextBox.Focus()
            Else
                If Rango1 = "Gerencia" Then
                    sql = "update Empleados set bonos ='" + BonosTextBox.Text + "' where idempleado = '" + IdempleadoTextBox.Text + "'"
                    Ejecutar(sql)
                    txtbusqueda.Select()
                End If
            End If
            MsgBox("¡Bono registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        TextBox1.Text = ListBox1.SelectedValue
    End Sub

    Sub LlenarDepartamentos()
        sql = "select ubicacion from departamento order by ubicacion asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.DisplayMember = "ubicacion"
        ListBox1.ValueMember = "ubicacion"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        sql = "select ubicacion from departamento  where ubicacion like '" & TextBox1.Text & "%" & "' order by ubicacion asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.DisplayMember = "ubicacion"
        ListBox1.ValueMember = "ubicacion"
    End Sub

    Sub LlenarPlanillas()
        sql = "SELECT [Planilla]
        FROM [ABAS].[dbo].[Planillas]
        ORDER BY PLANILLA ASC"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        PlanillaComboBox.DataSource = ds.Tables(0)
        PlanillaComboBox.DisplayMember = "Planilla"
    End Sub

    Private Sub DireccionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DireccionTextBox.TextChanged
        CrearQR()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Limpiar()
        Limpiar2()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Planillas()
    End Sub

    Sub Planillas()
        IdTextBox.Clear()
        PlanillaTextBox.Clear()
        Button8.Enabled = True
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "Select * From Planillas WHERE planilla = '" + PlanillaTextBox.Text + "'"
        cmd.CommandText = sql

        'Ejecutamos una lectura RRHH la tabla
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            MessageBox.Show("Ya existe un registro con el mismo nombre", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PlanillaTextBox.Clear()
        Else
            sql = "INSERT INTO [dbo].[Planillas]
           ([planilla])
           VALUES
           ('" + PlanillaTextBox.Text + "')"
            Ejecutar(sql)
            MessageBox.Show("Registro de Planilla Exitoso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        dr.Close()
        cn.Close()

        Planillas()
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Planillas' Puede moverla o quitarla según sea necesario.
        Me.PlanillasTableAdapter.Fill(Me.ABASDataSet.Planillas)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IdTextBox.Text = "" Then
            MessageBox.Show("No hay registro por actualizar, Seleccione un registro")
        Else
            If MsgBox("¡Desea actualizar la planilla " + PlanillaTextBox.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                sql = "UPDATE [dbo].[Planillas]
                       SET [planilla] = '" + PlanillaTextBox.Text + "'
                     WHERE [Id] = '" + IdTextBox.Text + "'"
                Ejecutar(sql)
                MessageBox.Show("Datos de la planilla fueron actualizados correctamente, si existen empleados en la planilla con el nombre anterior por favor actualizar los empleados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Planillas()
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Planillas' Puede moverla o quitarla según sea necesario.
        Me.PlanillasTableAdapter.Fill(Me.ABASDataSet.Planillas)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        If IdTextBox.Text = "" Then
            MessageBox.Show("No hay registro por eliminar, Seleccione un registro")
        Else
            If MsgBox("¡Desea eliminar la planilla " + PlanillaTextBox.Text + "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then

                sql = "DELETE FROM [dbo].[Planillas]
                       WHERE [Id] = '" + IdTextBox.Text + "'"
                Ejecutar(sql)

                MessageBox.Show("Planilla eliminado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Planillas()
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Planillas' Puede moverla o quitarla según sea necesario.
        Me.PlanillasTableAdapter.Fill(Me.ABASDataSet.Planillas)
    End Sub

    Private Sub PlanillasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PlanillasDataGridView.CellContentClick
        Button8.Enabled = False
    End Sub

    Private Sub CmdCarnetGratis_Click(sender As Object, e As EventArgs) Handles CmdCarnetGratis.Click
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = ""
        sql = "SELECT [Usuario]
              ,[Contraseña]
              FROM [ABAS].[dbo].[UsuariosModulos]
              WHERE Rango1 = 'Gerencia' and [Usuario] = '" + txtUsuarioGer.Text + "' and [Contraseña] = '" + txtClaveGer.Text + "'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If MsgBox("Desea guardar el registro de carnet?, se registrara como gratis no se hara deduccion", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Informacion") = MsgBoxResult.Yes Then
                sql = "UPDATE [dbo].[RegistroCarnet]
                       SET [Estado] = 'Gratis'
                          ,[Fecha] = GETDATE()
                          ,[Observacion] = '" + txtObservacionCarnet.Text + "'
                          ,[Precio] = 0
                     WHERE [Codigo] = '" + IdentidadTextBox.Text + "'"
                Ejecutar(sql)
                MsgBox("¡Se ha registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                LimpiarCarnetValidacion()
                R_Carnet.Show()
            Else
                LimpiarCarnetValidacion()
            End If
        Else
            MsgBox("Datos incorrectos, solo gerencia puede validar esta impresion", MsgBoxStyle.OkCancel, "Informacion")
            LimpiarCarnetValidacion()
        End If

        dr.Close()
        cn.Close()
    End Sub

    Sub LimpiarCarnetValidacion()
        PanelValidaCarnet.Visible = False
        txtObservacionCarnet.Text = "Ninguna"
        txtUsuarioGer.Text = ""
        txtClaveGer.Text = ""
    End Sub

    Private Sub TxtObservacionCarnet_Click(sender As Object, e As EventArgs) Handles txtObservacionCarnet.Click
        txtObservacionCarnet.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sql = "INSERT INTO [dbo].[PreciosCarnet]
           ([PrecioCarnet]
           ,[Fecha])
     VALUES
           ('" + PrecioCarnetTextBox.Text + "'
           ,'" + FechaDateTimePicker.Text + "')"
        Ejecutar(sql)
        MsgBox("Nuevo precio de carnet ha sido asignado", MsgBoxStyle.OkCancel, "Informacion")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PanelValidaCarnet.Hide()
    End Sub


    ''MAPAS
    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    '    cn.Open()
    '    Cmd.Connection = cn
    '    Cmd.CommandType = CommandType.Text
    '    Sql = "Select * from ubicaciones where codigo = '" + CodigoTextBox.Text + "'"

    '    Cmd.CommandText = Sql

    '    Dr = Cmd.ExecuteReader
    '    Dr.Read()
    '    If Dr.HasRows Then
    '        sql = "update ubicaciones set latitud = '" + Y + "', longitud ='" + X + "' where codigo = '" + CodigoTextBox.Text + "'"
    '        mensaje = "Registro Actualizado"
    '        Ejecutar(sql, mensaje)
    '    Else
    '        sql = "insert into ubicaciones values('" + CodigoTextBox.Text + "', '" + Y + "', '" + X + "')"
    '        mensaje = "Registro Exitoso"
    '        Ejecutar(sql, mensaje)
    '    End If

    '    Dr.Close()
    '    cn.Close()
    '    panelCoordenadas.Visible = False

    'End Sub


    'Private Sub cmdCoordenadas_Click(sender As Object, e As EventArgs)
    '    If panelCoordenadas.Visible = False Then
    '        panelCoordenadas.Visible = True
    '        CargarLocation()
    '    Else
    '        panelCoordenadas.Visible = False
    '        txt_Coordenadas.Clear()
    '        mapa.ReloadMap()
    '        mapa.Refresh()
    '        mapa.CacheLocation.DefaultIfEmpty
    '        markerOverlay.Clear()
    '    End If

    'End Sub

    'Sub CargarLocation()

    '    If CodigoTextBox.Text <> "" Then

    '        Cmd.Connection = cn
    '        Cmd.CommandType = CommandType.Text
    '        Sql = "select codigo, left(latitud, 10) X, left(longitud, 11) Y from Ubicaciones where codigo = '" + CodigoTextBox.Text + "'"
    '        Cmd.CommandText = Sql

    '        Dr = Cmd.ExecuteReader
    '        Dr.Read()

    '        If Dr.HasRows Then
    '            X = Dr.Item("X").ToString
    '            Y = Dr.Item("Y").ToString

    '            mapa.DragButton = MouseButtons.Left
    '            mapa.CanDragMap = True
    '            mapa.MapProvider = GMapProviders.GoogleMap
    '            mapa.Position = New PointLatLng(X, Y)
    '            mapa.MinZoom = 0
    '            mapa.MaxZoom = 24
    '            mapa.Zoom = 18
    '            mapa.AutoScroll = True

    '            marker = New GMarkerGoogle(New PointLatLng(Y, X), GMarkerGoogleType.red)
    '            markerOverlay.Markers.Add(marker)
    '            mapa.Overlays.Add(markerOverlay)
    '            marker.ToolTipMode = MarkerTooltipMode.Always = 2

    '            txt_Coordenadas.Text = X & " " & Y
    '        Else

    '        End If

    '        Dr.Close()
    '        cn.Close()

    '        X = ""
    '        Y = ""

    '    Else
    '        mapa.DragButton = MouseButtons.Left
    '        mapa.CanDragMap = True
    '        mapa.MapProvider = GMapProviders.GoogleMap
    '        mapa.Position = New PointLatLng(DX, DY)
    '        mapa.MinZoom = 0
    '        mapa.MaxZoom = 24
    '        mapa.Zoom = 18
    '        mapa.AutoScroll = True
    '    End If

    'End Sub

    'Private Sub mapa_MouseDown(sender As Object, e As MouseEventArgs) Handles mapa.MouseDown
    '    X = mapa.FromLocalToLatLng(e.X, e.Y).Lng
    '    Y = mapa.FromLocalToLatLng(e.X, e.Y).Lat

    '    markerOverlay.Clear()
    '    marker = New GMarkerGoogle(New PointLatLng(Y, X), GMarkerGoogleType.red)
    '    markerOverlay.Markers.Add(marker)
    '    mapa.Overlays.Add(markerOverlay)
    '    marker.ToolTipMode = MarkerTooltipMode.Always = 2

    '    txt_Coordenadas.Text = Y & " " & X


    'End Sub


End Class