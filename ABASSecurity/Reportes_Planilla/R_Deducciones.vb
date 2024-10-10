Imports System.Data.SqlClient

Public Class R_Deducciones

    Private Sub R_Deducciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarPlanillas()
        PlanillaComboBox.SelectedItem = "ABAS1"
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'PlanillaDataSet.Deducciones' Puede moverla o quitarla según sea necesario.
        Me.DeduccionesTableAdapter.Fill(Me.PlanillaDataSet.Deducciones, Fecha1.Value, Fecha2.Value, PlanillaComboBox.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Comboubicacion_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ClienteComboBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
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