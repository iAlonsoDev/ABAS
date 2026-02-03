Public Class FormAsignacionesDiasLibres

    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub FormDias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.Llamadgv(EmpleadosDataGridView)
        obj.Llamadias(DiasDataGridView)

        obj.Llenardgvdias(txtCodeEmpleado.Text, DiasDataGridView)
        DescansoComboBox.SelectedItem = "Si"
        DescansoComboBox.Enabled = False

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        Limpiar()
        Llenar()
        txtCodeEmpleado.Focus()
    End Sub


    Sub Llenar()
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        DiaComboBox.SelectedItem = "Seleccione"
        ObservacionTextBox.Text = "Ninguna"

        panelRegistro.Visible = False
        panelEmpleados.Visible = False
    End Sub

    Private Sub CmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        If panelRegistro.Visible = True Then
            panelRegistro.Visible = False
        Else
            panelRegistro.Visible = True
        End If
        cmdActualizar.Enabled = False
        cmdGuardar.Enabled = True


        DiaComboBox.SelectedItem = "Seleccione"
        CodigoTextBox.Clear()
        ObservacionTextBox.Text = "Ninguna"
        DescansoComboBox.SelectedItem = "Si"
        CodigoTextBox.Select()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        If MsgBox("¡Desea guardar el dia libre?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If ObservacionTextBox.Text = "Ninguna" Then
                ObservacionTextBox.Text = "Ninguna"
            End If
            If CodigoTextBox.Text = "" Then
                MsgBox("¡No se ha seleccionado un codigo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                CodigoTextBox.Select()
            Else
                If DiaComboBox.SelectedItem = "Seleccione" Then
                    MsgBox("¡Seleccione el dia del empleado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                Else
                    sql = "insert into Dias values('" + CodigoTextBox.Text + "','" + FechadiaLibre.Text + "','" + DiaComboBox.SelectedItem.ToString + "','" + Usuario + "','" + DescansoComboBox.SelectedItem.ToString + "','" + ObservacionTextBox.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "')"
                    Ejecutar(sql)
                    Limpiar()
                End If
            End If
            MsgBox("¡Usuario registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub DiasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DiasDataGridView.CellContentClick
        cmdActualizar.Enabled = True
        cmdGuardar.Enabled = False
        panelRegistro.Visible = True

        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DiasDataGridView.Rows(index)

            IddialibreTextBox.Text = selectedRow.Cells(0).Value.ToString
            TextBox2.Text = selectedRow.Cells(8).Value.ToString
            TextBox1.Text = selectedRow.Cells(7).Value.ToString
            ObservacionTextBox.Text = selectedRow.Cells(6).Value.ToString
            DescansoComboBox.SelectedItem = selectedRow.Cells(5).Value.ToString
            DiaComboBox.SelectedItem = selectedRow.Cells(3).Value.ToString
            FechadiaLibre.Value = selectedRow.Cells(2).Value.ToString
            CodigoTextBox.Text = selectedRow.Cells(1).Value.ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            obj.BusquedaCodigo(txtbusqueda.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Nombre" Then
            obj.BusquedaNombre(txtbusqueda.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Identidad" Then
            obj.BusquedaIdentidad(txtbusqueda.Text, EmpleadosDataGridView)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbusqueda.Focus()
        End If
    End Sub

    Private Sub TxtDias_TextChanged(sender As Object, e As EventArgs) Handles txtCodeEmpleado.TextChanged
        obj.Llenardgvdias(txtCodeEmpleado.Text, DiasDataGridView)
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)
            CodigoTextBox.Text = selectedRow.Cells(0).Value.ToString
            TextBox1.Text = selectedRow.Cells(1).Value.ToString
            TextBox2.Text = selectedRow.Cells(2).Value.ToString
        Catch ex As Exception

        End Try

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "Select * From Dias Where Codigo ='" + CodigoTextBox.Text + "'"

        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Este empleado ya, tiene registardo un dia libre")
                CodigoTextBox.Clear()
                panelEmpleados.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dr.Close()
        cn.Close()
        cmdGuardar.Enabled = True
        panelEmpleados.Visible = False

    End Sub

    Private Sub ObservacionTextBox_Click(sender As Object, e As EventArgs) Handles ObservacionTextBox.Click
        ObservacionTextBox.Clear()
    End Sub


    Private Sub CmdOcultar_Click(sender As Object, e As EventArgs) Handles cmdOcultar.Click
        panelRegistro.Visible = False
        panelEmpleados.Visible = False
        Limpiar()
    End Sub

    Private Sub Tipodebusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipodebusqueda.KeyPress, DiaComboBox.KeyPress, DescansoComboBox.KeyPress
        e.Handled = True
    End Sub

    Sub Validar()

        If MsgBox("¡Desea guardar el nuevo dia libre?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If IddialibreTextBox.Text = "" Then
                MsgBox("¡Selecione un registro, por actualizar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                Limpiar()
            Else

                If ObservacionTextBox.Text = "" Then
                    MsgBox("¡Se debe escribir una observacion indicando, porque el cambio!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                    ObservacionTextBox.Clear()
                    ObservacionTextBox.Select()
                Else
                    If Rango5 = "Jefe Operaciones" Then
                        sql = "update Dias set 
                    codigo ='" + CodigoTextBox.Text + "', 
                    fecha ='" + FechadiaLibre.Text + "', 
                    dia ='" + DiaComboBox.SelectedItem.ToString + "',
                    autoriza ='" + Usuario + "',
                    descanso ='" + DescansoComboBox.SelectedItem.ToString + "',
                    observacion ='" + ObservacionTextBox.Text + "',
                    nombre = '" + TextBox1.Text + "',
                    apellido = '" + TextBox2.Text + "' where iddialibre = '" + IddialibreTextBox.Text + "'"
                        Ejecutar(sql)
                        Limpiar()
                    Else
                        MsgBox("¡No cuenta con los permisos necesarios para esta operacion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                    End If
                End If
            End If
            MsgBox("¡Dia libre actualizado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Private Sub Eliminar()
        If MsgBox("¡Desea eliminar el dia libre?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If IddialibreTextBox.Text = "" Then
                MsgBox("¡No se ha seleccionado un registro por actualizar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                Limpiar()
            Else
                If Rango5 = "Jefe Operaciones" Then
                    sql = "delete from dias where iddialibre = '" + IddialibreTextBox.Text + "'"
                    Ejecutar(sql)
                    Limpiar()
                Else
                    MsgBox("¡No cuenta con los permisos necearios para realizar esta operacion!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
                End If
            End If
            MsgBox("¡Registro eliminado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        Validar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Eliminar()
    End Sub

    Sub Limpiar()
        CodigoTextBox.Clear()
        ObservacionTextBox.Text = "Ninguna"
        DiaComboBox.SelectedItem = "Seleccione"
        DescansoComboBox.SelectedItem = "Si"
        CodigoTextBox.Select()
        obj.Llamadias(DiasDataGridView)
        panelRegistro.Visible = False
        panelEmpleados.Visible = False
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class