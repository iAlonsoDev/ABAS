Imports System.Data.SqlClient

Public Class R_DeduccionesUsuario

    Private Sub R_DeduccionesUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarPlanillas()
        PlanillaComboBox.SelectedItem = "ABAS1"
        LlenarUser()
    End Sub

    Private Sub CmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        'TODO: esta línea de código carga datos en la tabla 'PlanillaDataSet.Deduccionesporusuario' Puede moverla o quitarla según sea necesario.
        Me.DeduccionesporusuarioTableAdapter.Fill(Me.PlanillaDataSet.Deduccionesporusuario, Fecha1.Value, Fecha2.Value, PlanillaComboBox.Text, ComboBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub LlenarUser()
        sql = "SELECT Usuario 
                    FROM [ABAS].[dbo].[UsuariosModulos]
                    WHERE Rango1 = 'Gerencia' or Rango2 = 'Administracion'
                    Order by Usuario asc"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds)
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "Usuario"
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