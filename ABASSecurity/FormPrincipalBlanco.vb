Public Class FormPrincipalBlanco
    Private Sub TimerFecha_Tick(sender As Object, e As EventArgs) Handles TimerFecha.Tick
        FechaPresentacion.Text = DateTime.Today
        HoraPresentacion.Text = TimeOfDay.ToString("HH.mm.ss")
    End Sub

    Private Sub FormBlanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class