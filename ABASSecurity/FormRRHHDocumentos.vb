Imports System.Data.SqlClient

Public Class FormRRHHDocumentos

    Dim IDTIPO1, IDTIPO2, IDTIPO3, IDDOC As Integer

    Private Sub FormRRHHDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ABASDataSet.DocumentosEmpleados' table. You can move, or remove it, as needed.
        Me.DocumentosEmpleadosTableAdapter.Fill(Me.ABASDataSet.DocumentosEmpleados)

        PictureBox1.Visible = False
        LoadDocumentos()
    End Sub

    Sub LoadDocumentos()

        '' REGISTRO DE TIPO
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
        IDTIPO1 = 0
        IdtipodocTextBox.Text = ""
        IdtipodocTextBox.Enabled = True
        NombretipoTextBox.Text = ""
        LlenarTiposDocumentosDataGriw()

        '' REGISTRO DE DOCUMENTOS
        txtbusqueda.Text = ""
        LlenarTiposDocumentos()
        panelEmpleados.Visible = False
        CARGARID()

        PictureBox1.BackgroundImage = Nothing
        PictureBox1.BackgroundImage = Nothing

        '' BUSCAR DOCUMENTOS
        IDDOC = 0
        TextBox1.Text = ""
        ListBox1.DataSource = Nothing

    End Sub

    Sub LlenarTiposDocumentosDataGriw()

        sql = "SELECT TOP (1000) [idtipodoc]
                  ,[nombretipo]
              FROM [ABAS].[dbo].[TipoDocumentosEmpleados]
              ORDER BY nombretipo ASC"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            TipoDocumentosEmpleadosDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        Buscarempleado()
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

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick

        panelEmpleados.Visible = False

        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            txtId.Text = selectedRow.Cells(0).Value.ToString
            TextBox1.Text = selectedRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try

    End Sub

    Sub LlenarTiposDocumentos()

        sql = "SELECT TOP (1000) [idtipodoc]
                  ,[nombretipo]
              FROM [ABAS].[dbo].[TipoDocumentosEmpleados]
              ORDER BY nombretipo ASC"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)

        Cmb_TiposDeDocumentosR.DataSource = ds.Tables(0)
        Cmb_TiposDeDocumentosR.DisplayMember = "nombretipo"


        Cmb_TiposDeDocumentosD.DataSource = ds.Tables(0)
        Cmb_TiposDeDocumentosD.DisplayMember = "nombretipo"
    End Sub

    Private Sub Cmd_NuevoTipo_Click(sender As Object, e As EventArgs) Handles Cmd_NuevoTipo.Click
        LoadDocumentos()
    End Sub

    Private Sub Cmd_RegAct_Tipo_Click(sender As Object, e As EventArgs) Handles Cmd_RegAct_Tipo.Click

        GuardarTipo()
        LoadDocumentos()

    End Sub

    Sub GuardarTipo()

        If MsgBox("¡Desea guardar/actualizar el tipo de documento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            If IDTIPO1 = 0 Then
                If NombretipoTextBox.Text = "" Then
                    MessageBox.Show("No es permitido campos vacios")
                Else
                    ''insert
                    sql = "INSERT INTO [dbo].[TipoDocumentosEmpleados]
                           ([nombretipo]) VALUES ('" + NombretipoTextBox.Text + "')"
                    Ejecutar(sql)
                End If
            Else
                If IdtipodocTextBox.Text = "" Or NombretipoTextBox.Text = "" Then
                    MessageBox.Show("No es permitido campos vacios")
                Else
                    ''update
                    sql = "UPDATE [dbo].[TipoDocumentosEmpleados]
                           SET [nombretipo] = '" + NombretipoTextBox.Text + "'
                         WHERE [idtipodoc] = '" + IdtipodocTextBox.Text + "'"
                    Ejecutar(sql)
                End If

            End If

        End If

    End Sub


    Private Sub Cmd_EliminarTipo_Click(sender As Object, e As EventArgs) Handles Cmd_EliminarTipo.Click

        If MsgBox("¡Desea eliminar el tipo de documento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

            If IdtipodocTextBox.Text = "" Or NombretipoTextBox.Text = "" Then

                MessageBox.Show("No es permitido campos vacios")

            Else

                If IDTIPO1 > 0 Then
                    ''delete
                    sql = "DELETE FROM [dbo].[TipoDocumentosEmpleados]
                           WHERE [idtipodoc] = '" + IdtipodocTextBox.Text + "'"
                    Ejecutar(sql)
                Else
                    ''error
                    MessageBox.Show("No se ha seleccionado un registro a eliminar!")

                End If

            End If

        End If

        LoadDocumentos()
    End Sub

    Private Sub TipoDocumentosEmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TipoDocumentosEmpleadosDataGridView.CellContentClick

        IdtipodocTextBox.Enabled = False

        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = TipoDocumentosEmpleadosDataGridView.Rows(index)

            IDTIPO1 = selectedRow.Cells(0).Value
            IdtipodocTextBox.Text = selectedRow.Cells(0).Value
            NombretipoTextBox.Text = selectedRow.Cells(1).Value.ToString

        Catch ex As Exception

        End Try

    End Sub


    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click, PictureBox3.Click
        If panelEmpleados.Visible = False Then
            panelEmpleados.Visible = True
            txtbusqueda.Focus()
        Else
            panelEmpleados.Visible = False
        End If
    End Sub

    Private Sub CmdSeleccionarImagen_Click(sender As Object, e As EventArgs) Handles cmdSeleccionarImagen.Click
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            Dim dialogo As New DialogResult
            openFileDialog1.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 1
            openFileDialog1.RestoreDirectory = True
            dialogo = openFileDialog1.ShowDialog()
            If (dialogo = DialogResult.OK) Then
                Dim bmp As New Bitmap(Image.FromFile(openFileDialog1.FileName))
                ''bmp = bmp.GetThumbnailImage(720, 1080, Nothing, IntPtr.Zero) 'Redimencionamos pixeles deimagen (Opcional).
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Descargar.Click
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


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedTab Is TabPage2 Then
            txtId.Text = ""
            PictureBox1.Visible = True
            CARGARID()
        Else
            If TabControl1.SelectedTab Is TabPage3 Then
                TextBox1.Text = True
                ListBox1.DataSource = Nothing
                PictureBox1.Visible = True
                CARGARID()
            Else
                PictureBox1.Visible = False
                PictureBox1.BackgroundImage = Nothing
            End If
        End If
    End Sub

    Private Sub CmdRegistrar_Click(sender As Object, e As EventArgs) Handles cmdRegistrar.Click

        BuscarDocumentoGuardado()

    End Sub

    Sub BuscarDocumentoGuardado()

        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        sql = "SELECT 
      [idtipodoc]
      ,[codigo]
      FROM [ABAS].[dbo].[DocumentosEmpleados]
      WHERE idtipodoc = '" + Convert.ToString(IDTIPO2) + "'
      AND codigo = '" + txtId.Text + "'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then

            cn.Close()
            dr.Close()

            '' si lo encuentra advierte, para guardar mas de 1
            If MsgBox("¡Se encontro un documento previamente cargado de este tipo, desea agregar otro mas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                ValidaInsert()

            End If

        Else
            cn.Close()
            dr.Close()

            '' si no lo encuntra solo guarda
            ValidaInsert()

        End If

    End Sub

    Sub ValidaInsert()
        If PictureBox1.BackgroundImage IsNot Nothing Then
            cn.Close()
            cn.Open()

            Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.
            PictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
            sql = "INSERT INTO [dbo].[DocumentosEmpleados]
                               ([idtipodoc]
                               ,[codigo]
                               ,[documento]
                               ,[fechacreacion]
                               ,[usuariocreacion])
                         VALUES
                               ( @ID
                               , @CODIGOEMPLEADO
                               , @DOCUMENTOEMP
                               , GETDATE()
                               ,'" + Usuario + "')"

            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Add(New SqlParameter("@ID", IDTIPO2))
            cmd.Parameters.Add(New SqlParameter("@CODIGOEMPLEADO", txtId.Text))
            cmd.Parameters.Add(New SqlParameter("@DOCUMENTOEMP", ms.GetBuffer()))
            cmd.ExecuteNonQuery() 'ejecutamos el query.
            cn.Close()
            ms.Dispose()
            ms.Close()

            MsgBox("La imagen ha sido registrada", MsgBoxStyle.Information)

            LoadDocumentos()
        Else
            MessageBox.Show("No se permite guardar datos vacios")
        End If
    End Sub

    Private Sub Cmb_TiposDeDocumentosD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_TiposDeDocumentosD.SelectedIndexChanged
        CARGARID()

        If TextBox1.Text <> "" Then
            LlenarListaDeDocumentos()
        End If
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        CargarFoto()
    End Sub

    Sub LlenarListaDeDocumentos()

        sql = "SELECT 
          [iddocumento]
          FROM [ABAS].[dbo].[DocumentosEmpleados]
          WHERE idtipodoc = '" + Convert.ToString(IDTIPO3) + "'
          AND codigo = '" + TextBox1.Text + "' ORDER BY iddocumento ASC"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.DisplayMember = "iddocumento"
        ListBox1.ValueMember = "iddocumento"

    End Sub

    Sub CargarFoto()

        IDDOC = ListBox1.SelectedValue

        dt = New DataTable
        sql = "SELECT [documento]
          FROM [ABAS].[dbo].[DocumentosEmpleados]
          WHERE iddocumento = '" + Convert.ToString(IDDOC) + "'"
        da = New SqlDataAdapter(sql, cn)
        cn.Close() 'Cerramos la cn por si esta abierta.
        cn.Open()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

#Disable Warning IDE0059 ' Unnecessary assignment of a value
            Dim ms As New IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
#Enable Warning IDE0059 ' Unnecessary assignment of a value
            Dim imageBuffer() As Byte = CType(dt.Rows(0).Item("documento"), Byte()) 'Conbertimos la imagen cargada en el datatable RRHH Bytes.
            ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream cn la imagen ya cnvertida en Bytes.

            PictureBox1.BackgroundImage = Nothing
            PictureBox1.BackgroundImage = (Image.FromStream(ms))
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            cn.Close()
            dt.Clear()
            dt.Reset()

            ms.Dispose()

            ms.Close()

        End If

    End Sub

    Private Sub DocumentosPorEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosPorEmpleadoToolStripMenuItem.Click
        R_DocumentosEmpleados.Show()
    End Sub

    Private Sub DocumentosPorTiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosPorTiposToolStripMenuItem.Click
        R_TiposDocumentosEmpleados.Show()
    End Sub

    Private Sub Cmd_EliminarDoc_Click(sender As Object, e As EventArgs) Handles Cmd_EliminarDoc.Click

        If IDDOC = 0 Then
            MsgBox("no seleccionaste ningun registro", MsgBoxStyle.Critical, "Aviso")
        Else
            If MsgBox("Quieres eliminar el docuemtno con identificacion: " + Convert.ToString(IDDOC) + " ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
                cn.Close()
                cn.Open()
                cmd.CommandType = CommandType.Text
                cmd.Connection = cn
                sql = "DELETE 
                      FROM [ABAS].[dbo].[DocumentosEmpleados]
                      WHERE iddocumento = '" + Convert.ToString(IDDOC) + "'"
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                MsgBox("¡Documento eliminado con exito!", MsgBoxStyle.Information, "Eliminar")
                cn.Close()

                LoadDocumentos()

            End If

        End If

    End Sub

    Private Sub Cmb_TiposDeDocumentos_TextChanged(sender As Object, e As EventArgs) Handles Cmb_TiposDeDocumentosR.TextChanged
        CARGARID()
    End Sub

    Sub CARGARID()
        cn.Open()
        cmd = New SqlCommand("SELECT [idtipodoc]
              FROM [ABAS].[dbo].[TipoDocumentosEmpleados]
              WHERE nombretipo = '" + Cmb_TiposDeDocumentosR.Text + "'") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            IDTIPO2 = dr.Item("idtipodoc")
        End If

        dr.Close()
        cn.Close()

        cn.Open()
        cmd = New SqlCommand("SELECT [idtipodoc]
              FROM [ABAS].[dbo].[TipoDocumentosEmpleados]
              WHERE nombretipo = '" + Cmb_TiposDeDocumentosD.Text + "'") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()
        If dr.Read Then
            IDTIPO3 = dr.Item("idtipodoc")
        End If

        dr.Close()
        cn.Close()

    End Sub


End Class