
Imports System.Data.SqlClient
Public Class R_Planilla

    Private Sub ClienteComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PlanillaComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub R_Planilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarPlanillas()
        PlanillaComboBox.SelectedItem = "ABAS1"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.sp_Planilla' Puede moverla o quitarla según sea necesario.
        Me.P_PlanillaTableAdapter.Fill(Me.PlanillaDataSet.P_Planilla, Fecha1.Value, Fecha2.Value, PlanillaComboBox.Text)
        Me.ReportViewer1.RefreshReport()
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


End Class