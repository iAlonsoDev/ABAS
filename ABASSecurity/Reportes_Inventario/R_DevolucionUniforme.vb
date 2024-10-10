Imports System.Data.SqlClient

Public Class R_DevolucionUniforme

    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub R_DevolucionUniforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tipodebusqueda.SelectedItem = "Codigo de Empleado"

        panelEmpleados.Visible = False
        Panel1.Visible = False


        TextBox1.Text = ClasePrivilegios.CodigoEmpleado
        TextBox2.Text = ClasePrivilegios.IDdevolucion
        DateTimePicker1.Text = ClasePrivilegios.FechaRecibido

        If TextBox1.Text <> "" Then
            'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Inventario_DevoluciondeUniforme' Puede moverla o quitarla según sea necesario.
            Me.Inventario_DevoluciondeUniformeTableAdapter.Fill(Me.InventarioDataSet.Inventario_DevoluciondeUniforme, TextBox1.Text, DateTimePicker1.Text, TextBox2.Text)
            Me.ReportViewer1.RefreshReport()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Inventario_DevoluciondeUniforme' Puede moverla o quitarla según sea necesario.
        Me.Inventario_DevoluciondeUniformeTableAdapter.Fill(Me.InventarioDataSet.Inventario_DevoluciondeUniforme, TextBox1.Text, DateTimePicker1.Text, TextBox2.Text)

        Me.ReportViewer1.RefreshReport()
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

            TextBox1.Text = selectedRow.Cells(0).Value.ToString
            panelEmpleados.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panelEmpleados.Visible = True Then
            panelEmpleados.Visible = False
        Else
            panelEmpleados.Visible = True
            txtbuscarEmp.Focus()
        End If
    End Sub

    Sub LlenarDevoluciones()
        sql = "SELECT TOP (10) [iddevolucion]
              ,[carnet]
              ,[codigo]
              ,[observacion]
              ,[recibe]
              ,[fecha]
              ,[estado]
              ,[rembolso]
          FROM [ABAS].[dbo].[DevolucionUniforme]
          WHERE [codigo] = '" + TextBox1.Text + "'"
        Try
            cn.Open()
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            DevolucionUniformeDataGridView.DataSource = dt
        Catch
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ''buscar solicitud
        If Panel1.Visible = True Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
            LlenarDevoluciones()
        End If
    End Sub

    Private Sub DevolucionUniformeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DevolucionUniformeDataGridView.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DevolucionUniformeDataGridView.Rows(index)

            TextBox2.Text = selectedRow.Cells(0).Value.ToString
            Panel1.Visible = False
        Catch ex As Exception

        End Try
    End Sub
End Class