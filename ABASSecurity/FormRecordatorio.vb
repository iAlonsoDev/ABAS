Public Class FormRecordatorio

    Private Sub RegistrodeNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titulo.Select()
        txtNota.Text = "Que deseas Recordar?"
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Sub Limpiar()
        txtNota.Text = "Que deseas Recordar?"
        DateTimeFecha.Update()
        TimerHora.Start()
    End Sub

    Private Sub TxtNota_Click(sender As Object, e As EventArgs) Handles txtNota.Click
        txtNota.Clear()
    End Sub

    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        FormRecordatoriosGuardados.ShowDialog()
    End Sub

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick
        txtHora.Text = TimeOfDay.ToString("HH:mm:ss")
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If txtNota.Text = "" Then
            MsgBox("¡Falta Nota!", MsgBoxStyle.Information, "Aviso")
            txtNota.Clear()
            txtNota.Select()
        Else
            If txtNota.Text = "Que deseas Recordar?" Then
                MsgBox("Escriba la nota para recordar", MsgBoxStyle.Information, "Aviso")
                txtNota.Clear()
                txtNota.Select()
            Else
                sql = "insert into Recordatorio values('" + DateTimeFecha.Value.ToShortDateString + "','" + txtHora.Text + "','" + txtNota.Text + "')"
                Ejecutar(sql)
            End If

        End If
        MsgBox("¡Nota registrada exitosamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
        Limpiar()
    End Sub

    Private Sub CmdVover_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TxtHora_Click(sender As Object, e As EventArgs) Handles txtHora.Click
        TimerHora.Stop()
    End Sub
End Class