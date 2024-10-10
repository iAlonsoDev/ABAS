Imports System.Data.SqlClient
Public Class FormRRHHDocumentos_BCK

    Dim exp As Integer = 0
    'Dim sExtencion As String
    Private Sub CmdSeleccionarImagen_Click(sender As Object, e As EventArgs) Handles cmdSeleccionarImagen.Click
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'SELECCIONAMOS LA IMAGEN QUE QUEREMOS GUARDAR EN LA DB
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Cargamos la imagen en el PictureBox como .BackgroundImage solo para poder ajustar la imagen,
        'pero de igual manera la podemos cargar como .Image.
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            Dim dialogo As New DialogResult
            openFileDialog1.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 1
            openFileDialog1.RestoreDirectory = True
            dialogo = openFileDialog1.ShowDialog()
            If (dialogo = DialogResult.OK) Then
                Dim bmp As New Bitmap(Image.FromFile(openFileDialog1.FileName))
                bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero) 'Redimencionamos pixeles deimagen (Opcional).
                PictureBox1.BackgroundImage = Nothing
                PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen RRHH todo el picturebox.
                PictureBox1.BackgroundImage = bmp 'Cargamos la imagen al PictureBox.
                'sExtencion = System.IO.Path.GetExtension(openFileDialog1.FileName) 'Obtenemos la Extencion de la imagen cargada.
                cmdRegistrar.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CmdRegistrar_Click(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        If PictureBox1.BackgroundImage IsNot Nothing Then
            cn.Close()
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            sql = "select codigo from Empleados where codigo = '" + txtId.Text + "'"
            cmd.CommandText = sql
            Try
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    cn.Close()
                    cn.Open()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.Text
                    sql = "Select Empleados.codigo from Empleados, Imagenes where Empleados.codigo = '" + txtId.Text + "' And Imagenes.codigo='" + txtId.Text + "'"

                    cmd.CommandText = sql
                    Try
                        dr = cmd.ExecuteReader
                        dr.Read()
                        If dr.HasRows Then
                            dr.Close()
                        Else
                            dr.Close()
                            sql = "INSERT INTO Imagenes(codigo) VALUES (@codigo)" 'Creamos el Query.
                            cn.Close() 'Cerramos la cn por si esta abierta.
                            cn.Open() 'Abrimos la Coenxion de la base de datos.
                            Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                            cmd.Parameters.Add(New SqlParameter("@codigo", txtId.Text))
                            cmd.ExecuteNonQuery() 'ejecutamos el query.
                            sql = "INSERT INTO Expedientes(codigo) VALUES (@codigo)" 'Creamos el Query.
                            cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                            cmd.Parameters.Add(New SqlParameter("@codigo", txtId.Text))
                            cmd.ExecuteNonQuery() 'ejecutamos el query.
                            cn.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try


                    Guardar()

                    Validacion()
                    If exp = 15 Then
                        cn.Close()
                        cn.Open()
                        cmd.Connection = cn
                        cmd.CommandType = CommandType.Text
                        sql = "Select Empleados.codigo from Empleados, Imagenes where Empleados.codigo = '" + txtId.Text + "' And Imagenes.codigo='" + txtId.Text + "'"

                        cmd.CommandText = sql
                        Try
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                dr.Close()
                                sql = "UPDATE Imagenes SET estado=@estado WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                                cn.Close() 'Cerramos la cn por si esta abierta.
                                cn.Open() 'Abrimos la Coenxion de la base de datos.
                                Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                                cmd.Parameters.Add(New SqlParameter("@estado", "Completo"))
                                cmd.ExecuteNonQuery() 'ejecutamos el query.
                                cn.Close()
                            Else
                                dr.Close()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Else

                        cn.Close()
                        cn.Open()
                        cmd.Connection = cn
                        cmd.CommandType = CommandType.Text
                        sql = "Select Empleados.codigo from Empleados, Imagenes where Empleados.codigo = '" + txtId.Text + "' And Imagenes.codigo='" + txtId.Text + "'"

                        cmd.CommandText = sql
                        Try
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                dr.Close()
                                sql = "UPDATE Imagenes SET estado=@estado WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                                cn.Close() 'Cerramos la cn por si esta abierta.
                                cn.Open() 'Abrimos la Coenxion de la base de datos.
                                Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                                cmd.Parameters.Add(New SqlParameter("@estado", "Incompleto"))
                                cmd.ExecuteNonQuery() 'ejecutamos el query.
                                cn.Close()
                            Else
                                dr.Close()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                Else
                    dr.Close()
                    MsgBox("Codigo de Empleado incorrecto", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Galeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Visible = False
        cmbder.Visible = False
        cmbizq.Visible = False
        panelEmpleados.Visible = False

        tipodebusqueda.SelectedItem = "Codigo de Empleado"
    End Sub

    Private Sub Cmbizq_Click(sender As Object, e As EventArgs) Handles cmbizq.Click

        If ComboBox1.Text = "Curriculum" Then
            If Label3.Text = "2" Then
                Label3.Text = "1"
            End If
        End If

        If ComboBox1.Text = "Contrato" Then
            If Label3.Text = "3" Then
                Label3.Text = "2"
            ElseIf Label3.Text = "2" Then
                Label3.Text = "1"
            End If
        End If

        If ComboBox1.Text = "Solicitud de empleo" Then
            If Label3.Text = "3" Then
                Label3.Text = "2"
            ElseIf Label3.Text = "2" Then
                Label3.Text = "1"
            End If
        End If

        dt = New DataTable
        sql = "SELECT  * FROM Imagenes WHERE codigo = " & "'" & txtId.Text & "'"
        da = New SqlDataAdapter(sql, cn)
        cn.Close() 'Cerramos la cn por si esta abierta.
        cn.Open()
        da.Fill(dt)
        Try
            If dt.Rows.Count > 0 Then

                If ComboBox1.Text = "Curriculum" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("curriculum1"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Curriculum" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("curriculum2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato1"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "3" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato3"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("solicitud"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("solicitud2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "3" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("solicitud3"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                End If

            End If
        Catch ex As Exception
            PictureBox1.BackgroundImage = Nothing
        End Try
    End Sub

    Private Sub Cmbder_Click(sender As Object, e As EventArgs) Handles cmbder.Click

        If ComboBox1.Text = "Curriculum" Then
            If Label3.Text = "1" Then
                Label3.Text = "2"
            End If
        End If

        If ComboBox1.Text = "Contrato" Then
            If Label3.Text = "1" Then
                Label3.Text = "2"
            ElseIf Label3.Text = "2" Then
                Label3.Text = "3"
            End If
        End If

        If ComboBox1.Text = "Solicitud de empleo" Then
            If Label3.Text = "1" Then
                Label3.Text = "2"
            ElseIf Label3.Text = "2" Then
                Label3.Text = "3"
            End If
        End If
        dt = New DataTable
        sql = "SELECT  * FROM Imagenes WHERE codigo = " & "'" & txtId.Text & "'"
        da = New SqlDataAdapter(sql, cn)
        cn.Close() 'Cerramos la cn por si esta abierta.
        cn.Open()
        da.Fill(dt)
        Try
            If dt.Rows.Count > 0 Then

                If ComboBox1.Text = "Curriculum" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("curriculum1"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Curriculum" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("curriculum2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato1"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "3" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato3"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("solicitud"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("solicitud2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "3" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("solicitud3"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                End If

            End If
        Catch ex As Exception
            PictureBox1.BackgroundImage = Nothing
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmdRegistrar.Enabled = False
        Buscar()
    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        If txtId.TextLength = 6 Then
            Buscar()
            Validacion()
        Else
            PictureBox1.BackgroundImage = Nothing
            Validacion()
        End If
    End Sub
    Sub Buscar()
        Label3.Visible = False
        cmbder.Visible = False
        cmbizq.Visible = False

        If ComboBox1.Text = "Curriculum" Or ComboBox1.Text = "Contrato" Or ComboBox1.Text = "Solicitud de empleo" Then
            Label3.Visible = True
            cmbder.Visible = True
            cmbizq.Visible = True
        End If

        dt = New DataTable
        sql = "SELECT  * FROM Imagenes WHERE codigo = " & "'" & txtId.Text & "'"
        da = New SqlDataAdapter(sql, cn)
        cn.Close() 'Cerramos la cn por si esta abierta.
        cn.Open()
        da.Fill(dt)
        Try
            If dt.Rows.Count > 0 Then
                If ComboBox1.Text = "Fotografia" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Fotografia"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "1" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Solicitud1"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "2" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Solicitud2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "3" Then
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Solicitud3"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Curriculum" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("curriculum1"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Curriculum" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("curriculum2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Titulo" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("titulo"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Identidad" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("identidad"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Licencia de manejo" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("licencia"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Antecedentes Penales" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("antpenales"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Antecedentes Judiciales" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("antjudiciales"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Croquis de vivienda" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("croquis"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Tarjeta de salud" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("tarjetadesalud"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Recibo publico" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("recibopublico"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Prueba psicometrica" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("psicometrica"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Compromisos" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("compromisos"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato1"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato2"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "3" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("contrato3"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Entrevista operativa" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("entrevista"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""

                ElseIf ComboBox1.Text = "Vacaciones" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("Vacaciones"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                ElseIf ComboBox1.Text = "Otros..." Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("otros"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.
                    PictureBox1.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PictureBox1.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.
                    cn.Close()
                    dt.Clear()
                    dt.Reset()
                    ms.Dispose()
                    ms.Close()
                    sql = ""
                End If
            End If
        Catch ex As Exception
            PictureBox1.BackgroundImage = Nothing
        End Try
    End Sub
    Sub Guardar()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'GUARDAMOS LA IMAGEN EN LA BASE DE DATOS
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select Empleados.codigo from Empleados,Imagenes where Empleados.codigo = '" + txtId.Text + "' and Imagenes.codigo ='" + txtId.Text + "'"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                If ComboBox1.Text = "Fotografia" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET fotografia=@fotografia WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@fotografia", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET fotografia=@fotografia WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@fotografia", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET solicitud1=@solicitud1 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@solicitud", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET solicitud1=@solicitud1 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@solicitud1", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()

                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET solicitud2=@solicitud2 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@solicitud2", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET solicitud2=@solicitud2 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@solicitud2", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()

                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Solicitud de empleo" And Label3.Text = "3" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET solicitud3=@solicitud3 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@solicitud3", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET solicitud3=@solicitud3 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@solicitud3", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()

                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Curriculum" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET curriculum1=@curriculum1 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@curriculum1", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET curriculum=@curriculum WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@curriculum", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Curriculum" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET curriculum2=@curriculum2 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@curriculum2", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET curriculum2=@curriculum2 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@curriculum2", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Titulo" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET titulo=@titulo WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@titulo", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET titilo=@titulo WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@titulo", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)

                ElseIf ComboBox1.Text = "Identidad" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET identidad=@identidad WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@identidad", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET identidad=@identidad WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@identidad", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Licencia de manejo" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET licencia=@licencia WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@licencia", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET licencia=@licencia WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@licencia", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Antecedentes Penales" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET antpenales=@antpenales WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@antpenales", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET antpenales=@antpenales WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@antpenales", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Antecedentes Judiciales" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET antjudiciales=@antjudiciales WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@antjudiciales", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET antjudiciales=@antjudiciales WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@antjudiciales", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Croquis de vivienda" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET croquis=@croquis WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@croquis", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET croquis=@croquis WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@croquis", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Tarjeta de salud" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET tarjetadesalud=@tarjetadesalud WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@tarjetadesalud", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET tarjetadesalud=@tarjetadesalud WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@tarjetadesalud", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Recibo publico" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET recibopublico=@recibopublico WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@recibopublico", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET recibopublico=@recibopublico WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@recibopublico", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Prueba psicometrica" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET psicometrica=@psicometrica WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@psicometrica", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET psicometrica=@psicometrica WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@psicometrica", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Compromisos" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET compromisos=@compromisos WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@compromisos", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET compromisos=@compromisos WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@compromisos", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "1" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET contrato1=@contrato1 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@contrato1", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET contrato1=@contrato1 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@contrato1", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "2" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET contrato2=@contrato2 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@contrato2", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET contrato2=@contrato2 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@contrato2", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Contrato" And Label3.Text = "3" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET contrato3=@contrato3 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@contrato3", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET contrato3=@contrato3 WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@contrato3", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                ElseIf ComboBox1.Text = "Entrevista operativa" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET entrevista=@entrevista WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@entrevista", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET entrevista=@entrevista WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@entrevista", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)

                ElseIf ComboBox1.Text = "Vacaciones" Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET vacaciones=@vacaciones WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@vacaciones", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET vacaciones=@vacaciones WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@vacaciones", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)

                ElseIf ComboBox1.Text = "Otros..." Then

                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                    PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                    sql = "UPDATE Imagenes SET otros=@otros WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cn.Close() 'Cerramos la cn por si esta abierta.
                    cn.Open() 'Abrimos la Coenxion de la base de datos.
                    Dim cmd As New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@otros", ms.GetBuffer())) 'Agregamos el MemoryStream RRHH los parametros para poderlos guardar en la base de datos.
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    sql = "UPDATE Expedientes SET otros=@otros WHERE codigo =" & "'" & txtId.Text & "'" 'Creamos el Query.
                    cmd = New SqlCommand(sql, cn) 'Creamos el sql.
                    cmd.Parameters.Add(New SqlParameter("@otros", "X"))
                    cmd.ExecuteNonQuery() 'ejecutamos el query.
                    cn.Close()

                    ms.Dispose()
                    ms.Close()


                    MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)
                Else

                    MsgBox("Seleccione un documento", MsgBoxStyle.Information)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbusqueda.Focus()
        End If
    End Sub

    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        Buscarempleado()
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        panelEmpleados.Visible = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            txtId.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
    Sub Buscarempleado()
        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select codigo, nombres, apellidos, identidad, estado from Empleados where codigo like '" & txtbusqueda.Text + "%" & "'"
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
            sql = "select codigo, nombres, apellidos, identidad, estado from Empleados where nombres like '" & txtbusqueda.Text + "%" & "'"
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

        If tipodebusqueda.SelectedItem.ToString = "Identidad" Then
            'para cndicionar un textbox
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
            sql = "select codigo, nombres, apellidos, identidad, estado from Empleados where identidad like '" & txtbusqueda.Text + "%" & "'"
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

    Private Sub Tipodebusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipodebusqueda.SelectedIndexChanged
        Buscarempleado()
        txtbusqueda.Clear()
    End Sub
    Sub Validacion()
        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and fotografia is not null "
        cmd.CommandText = sql
        exp = 0

        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox1.Checked = True
                exp += 1
            Else
                CheckBox1.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and (solicitud1 is not null or solicitud2 is not null or solicitud3 is not null) "
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox2.Checked = True
                exp += 1
            Else
                CheckBox2.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and (curriculum1 is not null or curriculum2 is not null)"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox3.Checked = True
                exp += 1
            Else
                CheckBox3.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and titulo is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox4.Checked = True
                exp += 1
            Else
                CheckBox4.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and identidad is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox5.Checked = True
                exp += 1
            Else
                CheckBox5.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and licencia is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox6.Checked = True
                exp += 1
            Else
                CheckBox6.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and antpenales is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox7.Checked = True
                exp += 1
            Else
                CheckBox7.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and antjudiciales is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox8.Checked = True
                exp += 1
            Else
                CheckBox8.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and croquis is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox9.Checked = True
                exp += 1
            Else
                CheckBox9.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and recibopublico is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox10.Checked = True
                exp += 1
            Else
                CheckBox10.Checked = False
                exp += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and tarjetadesalud is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox11.Checked = True
                exp += 1
            Else
                CheckBox11.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and psicometrica is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox12.Checked = True
                exp += 1
            Else
                CheckBox12.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and entrevista is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox13.Checked = True
                exp += 1
            Else
                CheckBox13.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and compromisos is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox14.Checked = True
                exp += 1
            Else
                CheckBox14.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and (contrato1 is not null or contrato2 is not null or contrato3 is not null)"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox15.Checked = True
                exp += 1
            Else
                CheckBox15.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and vacaciones is not null"
        cmd.CommandText = sql
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CheckBox17.Checked = True
                exp += 1
            Else
                CheckBox17.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        Sql = "select codigo from Imagenes where codigo = '" + txtId.Text + "' and otros is not null"
        Cmd.CommandText = Sql
        Try
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                CheckBox16.Checked = True
                exp += 1
            Else
                CheckBox16.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PictureBox1.BackgroundImage IsNot Nothing Then
            Try
                Dim savefile As New SaveFileDialog With {
                    .FileName = "Picture",
                    .DefaultExt = "jpeg",
                    .Filter = "All files*.*|*.*"
                }
                If savefile.ShowDialog() = DialogResult.OK Then
                    'Int(Width = PictureBox1.Width)
                    'Int(Height = PictureBox1.Height)
                    Dim Bitmap As New Bitmap(720, 1080)
                    Dim rc As New Rectangle(0, 0, 720, 1080)
                    PictureBox1.DrawToBitmap(Bitmap, rc)
                    Bitmap.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    MsgBox("Descarga Exitosa", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Tipodebusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipodebusqueda.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

End Class