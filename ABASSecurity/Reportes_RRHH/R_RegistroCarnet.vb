
Imports System.Data.SqlClient

Public Class R_RegistroCarnet

    Private Sub R_RegistroCarnet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RRHH.SP_HistoricoCarnet' Puede moverla o quitarla según sea necesario.
        Me.SP_HistoricoCarnetTableAdapter.Fill(Me.RRHH.SP_HistoricoCarnet, PlanillaComboBox.Text, ComboBox1.Text, Fecha1.Value, Fecha2.Value)

        ComboBox1.SelectedItem = "Cobro"
        LlenarPlanillas()
        PlanillaComboBox.SelectedItem = "ABAS1"

    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'RRHH.SP_HistoricoCarnet' Puede moverla o quitarla según sea necesario.
        Me.SP_HistoricoCarnetTableAdapter.Fill(Me.RRHH.SP_HistoricoCarnet, PlanillaComboBox.Text, ComboBox1.Text, Fecha1.Value, Fecha2.Value)

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