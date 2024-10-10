
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlParameter
Public Class FormGraficas

    ''Graficos
    ReadOnly Codigo = New ArrayList
    ReadOnly Nombres = New ArrayList
    ReadOnly Apellidos = New ArrayList
    ReadOnly TopAsignaciones = New ArrayList
    ReadOnly NombresC = New ArrayList
    ReadOnly Sucursal = New ArrayList
    ReadOnly TotUbicacion = New ArrayList
    ReadOnly Cant = New ArrayList


    Private Sub FormEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargasload()
    End Sub

    Sub Cargasload()
        GrafAsignaciones()
        GrafUbicacion()
        Estadisticas()
        TotEmpleado()
        TotClientes()
        TotSucursales()
        Eprueba()
    End Sub

    'Metodo para grafico de Asignacion
    Public Sub GrafAsignaciones()
        cmd = New SqlCommand("TopAsignacion", cn) With {
            .CommandType = CommandType.StoredProcedure
        }
        cn.Open()
        dr = cmd.ExecuteReader()

        While (dr.Read)
            Codigo.Add(dr.GetString(0))
            Nombres.Add(dr.GetString(2))
            TopAsignaciones.Add(dr.GetInt32(1))
            MCliente.Series(0).Points.DataBindXY(Nombres, TopAsignaciones)
        End While
        dr.Close()
        cn.Close()
    End Sub


    Public Sub GrafUbicacion()
        cmd = New SqlCommand("totUbicacion", cn) With {
            .CommandType = CommandType.StoredProcedure
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        While (dr.Read)
            Cant.Add(dr.GetInt32(0))
            TotUbicacion.Add(dr.GetString(1))
            Ubicaciones.Series(0).Points.DataBindXY(TotUbicacion, Cant)
        End While
        dr.Close()
        cn.Close()
    End Sub


    Public Sub Estadisticas()
        cmd = New SqlCommand("MaxCliente", cn) With {
            .CommandType = CommandType.StoredProcedure
        }
        cn.Open()
        dr = cmd.ExecuteReader()
        While (dr.Read)
            NombresC.Add(dr.GetString(0))
            Sucursal.Add(dr.GetInt32(1))
            ChartCantidad.Series(0).Points.DataBindXY(NombresC, Sucursal)
        End While
        dr.Close()
        cn.Close()
    End Sub


    Sub TotEmpleado()
        Try
            cn.Open()
            cmd = New SqlCommand("TotEmpleados", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            Dim Parameters = New SqlParameter
            cmd.Parameters.Add("@totEmpleado", SqlDbType.Int, ParameterDirection.Input)
            cmd.Parameters("@totEmpleado").Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            TotEmpl.Text = cmd.Parameters("@totEmpleado").Value.ToString()
        Catch ex As Exception
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub


    Sub TotClientes()
        Try
            cmd = New SqlCommand("TotClientes", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            Dim Parameters = New SqlParameter
            cmd.Parameters.Add("@totClientes", SqlDbType.Int, ParameterDirection.Input)
            cmd.Parameters("@totClientes").Direction = ParameterDirection.Output
            cn.Open()
            cmd.ExecuteNonQuery()
            totClie.Text = cmd.Parameters("@totClientes").Value.ToString()
        Catch ex As Exception
            Exit Sub
        Finally
            cn.Close()
        End Try

    End Sub


    Sub TotSucursales()
        Try
            cmd = New SqlCommand("TotSucursales", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            Dim Parameters = New SqlParameter
            cmd.Parameters.Add("@totSucursales", SqlDbType.Int, ParameterDirection.Input)
            cmd.Parameters("@totSucursales").Direction = ParameterDirection.Output
            cn.Open()
            cmd.ExecuteNonQuery()
            totSucu.Text = cmd.Parameters("@totSucursales").Value.ToString()
        Catch ex As Exception
            Exit Sub
        Finally
            cn.Close()
        End Try

    End Sub


    Sub Eprueba()
        Try
            cmd = New SqlCommand("EmpPrue", cn) With {
                .CommandType = CommandType.StoredProcedure
            }
            Dim Parameters = New SqlParameter
            cmd.Parameters.Add("@empPrueba", SqlDbType.Int, ParameterDirection.Input)
            cmd.Parameters("@empPrueba").Direction = ParameterDirection.Output
            cn.Open()
            cmd.ExecuteNonQuery()
            empPrue.Text = cmd.Parameters("@empPrueba").Value.ToString()
        Catch ex As Exception
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub



End Class