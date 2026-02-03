Imports System.Data.SqlClient
Public Class R_AsignacionporCodigo

    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub R_AsignacionporCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelEmpleados.Visible = False
        tipodebusqueda.SelectedItem = "Codigo de Empleado"
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If panelEmpleados.Visible = False Then
            panelEmpleados.Visible = True
        Else
            panelEmpleados.Visible = False
        End If
    End Sub


    Private Sub CmdActualizar_Click_1(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.AsignacionesPorCodigo' Puede moverla o quitarla según sea necesario.
        Me.AsignacionesPorCodigoTableAdapter.Fill(Me.OperacionesDataSet.AsignacionesPorCodigo, TxtCodigo.Text, Fecha1.Value, Fecha2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Texboxbuscador.TextChanged
        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & Texboxbuscador.Text + "%" & "'"
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


        If tipodebusqueda.SelectedItem.ToString = "Codigo de Empleado" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and codigo like '" & Texboxbuscador.Text + "%" & "'"
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
            obj.BusquedaNombre(Texboxbuscador.Text, EmpleadosDataGridView)
        End If


        If tipodebusqueda.SelectedItem.ToString = "Identidad" Then
            'para condicionar un textbox
            If Texboxbuscador.Text.Length <= 10 Then
                If Texboxbuscador.Text.Length >= 5 Then
                    Dim s As String = Texboxbuscador.Text.Replace("-", "")
                    For x As Integer = 4 To s.Length Step 4
                        s = s.Insert(x + ((x \ 4) - 1), "-")
                    Next
                    s = s.TrimEnd("-"c)
                    Texboxbuscador.Text = s
                    Texboxbuscador.SelectionStart = s.Length
                End If
            End If
            obj.BusquedaIdentidad(Texboxbuscador.Text, EmpleadosDataGridView)
        End If


        If tipodebusqueda.SelectedItem.ToString = "Ubicacion" Then
            sql = "select * from Empleados where estado <> 'Inactivo' and ubicacion like '" & Texboxbuscador.Text + "%" & "'"
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
            sql = "select * from Empleados where estado <> 'Inactivo' and planilla like '" & Texboxbuscador.Text + "%" & "'"
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


        If Texboxbuscador.Text = "" Then
            sql = "select * from Empleados where estado <> 'Inactivo'"
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
        If MessageBox.Show("Desea generar este reporte?", "Comfirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            TxtCodigo.Text = selectedRow.Cells(0).Value.ToString
            panelEmpleados.Visible = False

            'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.AsignacionesPorCodigo' Puede moverla o quitarla según sea necesario.
            Me.AsignacionesPorCodigoTableAdapter.Fill(Me.OperacionesDataSet.AsignacionesPorCodigo, TxtCodigo.Text, Fecha1.Value, Fecha2.Value)

            Me.ReportViewer1.RefreshReport()
        Else

        End If

    End Sub

End Class