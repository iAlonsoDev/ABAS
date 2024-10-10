Imports System.Data.SqlClient

Public Class R_MovimientosArmas

    Private Sub R_MovimientosArmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelBusSerie.Visible = False
        ComboBox2.SelectedItem = "Tipo"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If PanelBusSerie.Visible = False Then
            PanelBusSerie.Visible = True
        Else
            PanelBusSerie.Visible = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND estado <> 'C'"
            Try
                cn.Open()
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch
            Finally
                cn.Close()
            End Try
        Else

            If ComboBox2.SelectedItem = "Tipo" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE tipo like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND tipo like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If

            If ComboBox2.SelectedItem = "Codigo" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE Armeria.codigo like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND Armeria.codigo like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If

            If ComboBox2.SelectedItem = "Serie" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE serie like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND serie like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If

            If ComboBox2.SelectedItem = "Marca" Then
                sql = "DECLARE @ALM VARCHAR (10)
                     SET @ALM = (SELECT almacen from UsuariosModulos WHERE usuario = '" + Usuario + "')   
                     IF @ALM = 'TODOS'
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] 
					  WHERE marca like '" & TextBox4.Text + "%" & "' AND estado <> 'C'
                    ELSE  
                        SELECT TOP (1000) [idarma]
                          ,Armeria.[codigo]
                          ,[tipo]
                          ,[calibre]
                          ,[marca]
                          ,[serie]
                          ,[permisodpi]
                          ,[vdepermiso]
                          ,[estado]
                          ,[observaciones]
                          ,[ubicacion]
                          ,[color]
                          ,[idproveedor]
                          ,[code]
                          ,Armeria.[almacen]
                          ,[recibe_mov]
                      FROM [ABAS].[dbo].[Armeria] Left  outer join UsuariosModulos
                      ON UsuariosModulos.almacen = Armeria.almacen
                      WHERE usuario = '" + Usuario + "' AND marca like '" & TextBox4.Text + "%" & "' and estado <> 'C'"
                Try
                    cn.Open()
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch
                Finally
                    cn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        Dim serie As String
        If CheckBox1.Checked = True Then
            serie = "TODO"
            SerieTextBox1.Clear()
        Else
            serie = SerieTextBox1.Text
        End If

        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.MovimientosArma' Puede moverla o quitarla según sea necesario.
        Me.MovimientosArmaTableAdapter.Fill(Me.InventarioDataSet.MovimientosArma, serie, fechadesde:=Fecha1.Value.ToShortDateString, fechahasta:=Fecha2.Value.ToShortDateString)

        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            SerieTextBox1.Text = selectedRow.Cells(2).Value.ToString
        Catch ex As Exception
        End Try

        PanelBusSerie.Visible = False
    End Sub
End Class