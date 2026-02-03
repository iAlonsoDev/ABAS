Imports System.Data.SqlClient
Public Class R_Puestos
    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub R_Puestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelEmpleados.Visible = False

        tipodebusqueda.SelectedItem = "Codigo de Empleado"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Historico' Puede moverla o quitarla según sea necesario.
        Me.HistoricoTableAdapter.Fill(Me.RRHHDataSet.Historico, txtbusqueda.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If panelEmpleados.Visible = False Then
            panelEmpleados.Visible = True
        Else
            panelEmpleados.Visible = False
        End If
    End Sub

    Private Sub Tipodebusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipodebusqueda.KeyPress
        e.Handled = True
    End Sub

    Private Sub Txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.TextLength = 6 Then
            'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Historico' Puede moverla o quitarla según sea necesario.
            Me.HistoricoTableAdapter.Fill(Me.RRHHDataSet.Historico, txtbusqueda.Text)

            Me.ReportViewer1.RefreshReport()
        Else

        End If
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

        If txtbuscarEmp.Text = "" Then
        End If
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        panelEmpleados.Visible = False
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            txtbusqueda.Text = selectedRow.Cells(1).Value.ToString
        Catch ex As Exception

        End Try
    End Sub


End Class