Imports System.Data.SqlClient
Public Class FormRRHHAspirantes

    ReadOnly obj As New ClaseBusquedasDinamicas

    Sub Cargar()
        IdentidadTextBox.Text = "0000-0000-00000"
        NombrecompletoTextBox.Clear()
        DireccionTextBox.Clear()
        Telefono1TextBox.Text = "0000-0000"
        Telefono2TextBox.Text = "0000-0000"
        AreadeaplicacionTextBox.Clear()
        ObservacionTextBox.Clear()

    End Sub


    Private Sub IdentidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdentidadTextBox.TextChanged
        If IdentidadTextBox.Text = "" Or IdentidadTextBox.Text = "0000-0000-00000" Then
            AspirantesDataGridView.DataSource = vbNull
        Else
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
                obj.llenaraspirantes(IdentidadTextBox.Text, AspirantesDataGridView)
            End If
        End If

    End Sub

    Private Sub Telefono1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Telefono1TextBox.TextChanged
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

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If MsgBox("¡Desea guardar el nuevo aspirante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "Select * From Aspirantes Where identidad ='" + IdentidadTextBox.Text + "' and fecha = '" + FechaDateTimePicker.Value + "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            dr.Read()

            If IdentidadTextBox.Text = "" Or IdentidadTextBox.Text = "0000-0000-00000" Then
                MessageBox.Show("Ingrese la identidad de la persona")
            ElseIf IdentidadTextBox.TextLength < 15 Then
                MessageBox.Show("Numero de identidad invalido")
            ElseIf Telefono1TextBox.TextLength < 9 Then
                MessageBox.Show("Numero de Telefono 1 invalido")
            ElseIf Telefono2TextBox.TextLength < 9 Then
                MessageBox.Show("Numero de Telefono 2 invalido")
            ElseIf dr.HasRows Then
                MsgBox("¡Ya existe esta identidad en el registro de aspirantes!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "insert into aspirantes values('" + NombrecompletoTextBox.Text + "',
                                                       '" + IdentidadTextBox.Text + "',
                                                       '" + DireccionTextBox.Text + "',
                                                       '" + Telefono1TextBox.Text + "',
                                                       '" + Telefono2TextBox.Text + "',
                                                       '" + Ciudad.Text + "',
                                                       '" + AreadeaplicacionTextBox.Text + "',
                                                       '" + ObservacionTextBox.Text + "',
                                                       '" + FechaDateTimePicker.Text + "',
                                                       '" + EstadoComboBox.Text + "')"

                Ejecutar(sql)
            End If
            Limpiar()
            IdentidadTextBox.Clear()
            IdentidadTextBox.Select()

            dr.Close()
            cn.Close()
            MsgBox("¡Aspirante registrado exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If
    End Sub

    Private Sub CmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Limpiar()
        IdentidadTextBox.Clear()
        IdentidadTextBox.Select()
        cmdGuardar.Enabled = True
    End Sub

    Sub Limpiar()
        NombrecompletoTextBox.Clear()
        DireccionTextBox.Clear()
        Telefono1TextBox.Text = "0000-0000"
        Telefono2TextBox.Text = "0000-0000"
        IdentidadTextBox.Text = "0000-0000-00000"
        AreadeaplicacionTextBox.Clear()
        ObservacionTextBox.Clear()
        IdaspiranteTextBox.Clear()
        AspirantesDataGridView.DataSource = vbNull
        EstadoComboBox.SelectedItem = "Seleccionar"
    End Sub

    Private Sub FormAspirantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ciudad.SelectedItem = "San Pedro Sula"
        Cargar()
        EstadoComboBox.SelectedItem = "Seleccionar"
        cmdGuardar.Enabled = True
        cmdActualizar.Enabled = True
        IdentidadTextBox.Focus()
    End Sub

    Private Sub IdentidadTextBox_Click(sender As Object, e As EventArgs) Handles IdentidadTextBox.Click
        Vacio()
    End Sub

    Private Sub Telefono1TextBox_Click(sender As Object, e As EventArgs) Handles Telefono1TextBox.Click
        Vacio()
        Telefono1TextBox.Clear()
    End Sub

    Private Sub Telefono2TextBox_Click(sender As Object, e As EventArgs) Handles Telefono2TextBox.Click
        Vacio()
        Telefono2TextBox.Clear()
    End Sub

    Sub Vacio()
        If Telefono1TextBox.Text = "" Then
            Telefono1TextBox.Text = "0000-0000"
        End If

        If Telefono2TextBox.Text = "" Then
            Telefono2TextBox.Text = "0000-0000"
        End If
        If IdentidadTextBox.Text = "" Then
            IdentidadTextBox.Text = "0000-0000-00000"
        End If
    End Sub

    Private Sub FechaDateTimePicker_Click(sender As Object, e As EventArgs) Handles FechaDateTimePicker.Click
        Vacio()
    End Sub

    Private Sub NombrecompletoTextBox_Click(sender As Object, e As EventArgs) Handles NombrecompletoTextBox.Click
        Vacio()
    End Sub

    Private Sub DireccionTextBox_Click(sender As Object, e As EventArgs) Handles DireccionTextBox.Click
        Vacio()
    End Sub

    Private Sub AreadeaplicacionTextBox_Click(sender As Object, e As EventArgs) Handles AreadeaplicacionTextBox.Click
        Vacio()
    End Sub

    Private Sub Ciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ciudad.SelectedIndexChanged
        cn.Open()
        sql = "select Top (100) * from aspirantes where ciudad = '" + Ciudad.Text + "' order by fecha desc"
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        AspirantesDataGridView.DataSource = dt
        cn.Close()
    End Sub

    Private Sub AspirantesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AspirantesDataGridView.CellContentClick
        cmdGuardar.Enabled = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = AspirantesDataGridView.Rows(index)

            NombrecompletoTextBox.Text = selectedRow.Cells(0).Value
            FechaDateTimePicker.Value = selectedRow.Cells(7).Value.ToString
            ObservacionTextBox.Text = selectedRow.Cells(8).Value
            EstadoComboBox.SelectedItem = selectedRow.Cells(9).Value.ToString
            IdaspiranteTextBox.Text = selectedRow.Cells(10).Value
            IdentidadTextBox.Text = selectedRow.Cells(1).Value.ToString
            DireccionTextBox.Text = selectedRow.Cells(2).Value.ToString
            Telefono1TextBox.Text = selectedRow.Cells(3).Value.ToString
            Telefono2TextBox.Text = selectedRow.Cells(4).Value.ToString
            Ciudad.SelectedItem = selectedRow.Cells(5).Value.ToString
            AreadeaplicacionTextBox.Text = selectedRow.Cells(6).Value.ToString

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ciudad.KeyPress
        e.Handled = True
    End Sub

    Private Sub EstadoComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstadoComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If MsgBox("¡Desea actualizar los datos del aspirante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            If IdaspiranteTextBox.Text = "" Then
                MsgBox("¡No se ha seleccionado ningun usuario para actualizar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            Else
                sql = "update Aspirantes set 
                                nombrecompleto ='" + NombrecompletoTextBox.Text + "', 
                                identidad ='" + IdentidadTextBox.Text + "', 
                                direccion ='" + DireccionTextBox.Text + "',
                                telefono1 ='" + Telefono1TextBox.Text + "', 
                                telefono2 ='" + Telefono2TextBox.Text + "',
                                ciudad ='" + Ciudad.Text + "',
                                areadeaplicacion ='" + AreadeaplicacionTextBox.Text + "',
                                observacion ='" + ObservacionTextBox.Text + "',
                                fecha ='" + FechaDateTimePicker.Text + "',
                                estado = '" + EstadoComboBox.Text + "' where idaspirante = '" + IdaspiranteTextBox.Text + "'"
                Ejecutar(sql)
            End If
            Limpiar()
            cmdGuardar.Enabled = True

            MsgBox("¡Datos actualizados exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        End If

    End Sub

    Private Sub ObservacionTextBox_Click(sender As Object, e As EventArgs) Handles ObservacionTextBox.Click
        vacio()
    End Sub
End Class

