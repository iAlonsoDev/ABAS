Public Class FormRecordatorioMensaje

    ''CUANDO SUENA UNA ALARMA SE ABRE ESTE FORMULARIO, CON UN READER ABIERTO
    ''CAPTURO EL DR EN LA VARIABLE V
    ''CARGO EN EL MSJ LA NOTA COLUMNA 3
    Private Const V As Integer = 3

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        FormPrincipal.TimerFecha.Enabled = True
        TimerSonido.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerSonido.Tick
        Playnoti()
    End Sub

    Private Sub MensajeRecordatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerSonido.Enabled = True
        FormPrincipal.TimerFecha.Enabled = False
        lbNota.Text = dr(V).ToString
        Playnoti()
    End Sub

    Sub Playnoti()
        My.Computer.Audio.Play(My.Resources.TONO, AudioPlayMode.WaitToComplete)
    End Sub

End Class