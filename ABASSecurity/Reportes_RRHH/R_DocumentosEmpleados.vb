Public Class R_DocumentosEmpleados


    ReadOnly obj As New ClaseBusquedasDinamicas

    Private Sub R_DocumentosEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelEmpleados.Visible = False
        obj.Llamadgv(EmpleadosDataGridView)
        tipodebusqueda.SelectedItem = "Codigo"

        EmpleadosDataGridView.DataSource = vbNull

    End Sub

    Private Sub TxtbuscarEmp_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarEmp.TextChanged
        If tipodebusqueda.SelectedItem.ToString = "Codigo" Then
            obj.BusquedaCodigo(txtbuscarEmp.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Nombre" Then
            obj.BusquedaNombre(txtbuscarEmp.Text, EmpleadosDataGridView)
        End If

        If tipodebusqueda.SelectedItem.ToString = "Identidad" Then
            obj.BusquedaIdentidad(txtbuscarEmp.Text, EmpleadosDataGridView)
        End If

        If txtbuscarEmp.Text = "" Then
            EmpleadosDataGridView.DataSource = vbNull
        End If
    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        If MessageBox.Show("Desea generar este reporte?", "Comfirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = EmpleadosDataGridView.Rows(index)

            txtbusqueda.Text = selectedRow.Cells(0).Value.ToString
            panelEmpleados.Visible = False


            Me.ReportViewer1.RefreshReport()
        Else


        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If panelEmpleados.Visible = False Then
            panelEmpleados.Visible = True
        Else
            panelEmpleados.Visible = False
        End If
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click

        'TODO: This line of code loads data into the 'RRHHDataSet.RRHH_DocumentosEmpleados' table. You can move, or remove it, as needed.
        Me.RRHH_DocumentosEmpleadosTableAdapter.Fill(Me.RRHHDataSet.RRHH_DocumentosEmpleados, txtbusqueda.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class