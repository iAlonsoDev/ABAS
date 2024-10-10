Imports System.Data.SqlClient

Public Class R_Carnet
    Private Sub R_Carnet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SP_CarnetTableAdapter.Fill(Me.RRHH.SP_Carnet, ClasePrivilegios.CodigoEmpleado)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent = 100
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class