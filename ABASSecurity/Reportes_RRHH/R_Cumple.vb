Public Class R_Cumple
    Private Sub R_Cumple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "Seleccionar"

        If ComboBox1.Text = "Seleccionar" Then
            TextBox1.Clear()
        Else
            If ComboBox1.Text = "Enero" Then
                TextBox1.Text = 1
            Else
                If ComboBox1.Text = "Febrero" Then
                    TextBox1.Text = 2
                Else
                    If ComboBox1.Text = "Marzo" Then
                        TextBox1.Text = 3
                    Else
                        If ComboBox1.Text = "Abril" Then
                            TextBox1.Text = 4
                        Else
                            If ComboBox1.Text = "Mayo" Then
                                TextBox1.Text = 5
                            Else
                                If ComboBox1.Text = "Junio" Then
                                    TextBox1.Text = 6
                                Else
                                    If ComboBox1.Text = "Julio" Then
                                        TextBox1.Text = 7
                                    Else
                                        If ComboBox1.Text = "Agosto" Then
                                            TextBox1.Text = 8
                                        Else
                                            If ComboBox1.Text = "Septiembre" Then
                                                TextBox1.Text = 9
                                            Else
                                                If ComboBox1.Text = "Octubre" Then
                                                    TextBox1.Text = 10
                                                Else
                                                    If ComboBox1.Text = "Noviembre" Then
                                                        TextBox1.Text = 11
                                                    Else
                                                        If ComboBox1.Text = "Diciembre" Then
                                                            TextBox1.Text = 12
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'TODO: esta línea de código carga datos en la tabla 'ABASDataSet.Cumplea' Puede moverla o quitarla según sea necesario.
        Me.CumpleaTableAdapter.Fill(Me.RRHHDataSet.Cumplea, TextBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "Seleccionar" Then
            TextBox1.Clear()
        Else
            If ComboBox1.Text = "Enero" Then
                TextBox1.Text = 1
            Else
                If ComboBox1.Text = "Febrero" Then
                    TextBox1.Text = 2
                Else
                    If ComboBox1.Text = "Marzo" Then
                        TextBox1.Text = 3
                    Else
                        If ComboBox1.Text = "Abril" Then
                            TextBox1.Text = 4
                        Else
                            If ComboBox1.Text = "Mayo" Then
                                TextBox1.Text = 5
                            Else
                                If ComboBox1.Text = "Junio" Then
                                    TextBox1.Text = 6
                                Else
                                    If ComboBox1.Text = "Julio" Then
                                        TextBox1.Text = 7
                                    Else
                                        If ComboBox1.Text = "Agosto" Then
                                            TextBox1.Text = 8
                                        Else
                                            If ComboBox1.Text = "Septiembre" Then
                                                TextBox1.Text = 9
                                            Else
                                                If ComboBox1.Text = "Octubre" Then
                                                    TextBox1.Text = 10
                                                Else
                                                    If ComboBox1.Text = "Noviembre" Then
                                                        TextBox1.Text = 11
                                                    Else
                                                        If ComboBox1.Text = "Diciembre" Then
                                                            TextBox1.Text = 12
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Class