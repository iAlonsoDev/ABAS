
Imports System.Data.SqlClient

Public Class ClaseBusquedasDinamicas

    'Para modulo de RRHH (Empleados)'
    Sub Llamadgv(ByVal dgv As DataGridView)
        da = New SqlDataAdapter("select * from Empleados where estado <> 'Inactivo'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
    End Sub

    Sub LlamaProvedoresArmeria(ByVal dgv As DataGridView)

        da = New SqlDataAdapter("SELECT *
        FROM [ABAS].[dbo].[Proveedores] where categoria = 'ARMERIA'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub LlamaProvedoresEquipos(ByVal dgv As DataGridView)

        da = New SqlDataAdapter("SELECT *
  FROM [ABAS].[dbo].[Proveedores] where categoria = 'EQUIPOS'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub BusquedaCodigo(ByVal id As String, ByVal dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Empleados where estado <> 'Inactivo' and Codigo like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub BusquedaNombre(ByVal id As String, ByVal dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Empleados where estado <> 'Inactivo' and nombres like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub BusquedaIdentidad(ByVal id As String, ByVal dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Empleados where identidad like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    'Para modulo Clientes'
    Sub Llenardgvclientenombre(ByVal id As String, ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from cliente where nombre like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub Llenardgvclienteall(ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from cliente", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub Llenardgvcsucursal(ByVal id As String, ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select * from Sucursales, Cliente where Sucursales.nombre = Cliente.nombre and Cliente.estado <> 'Inactivo' and Sucursales.nombre like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub



    'Modulo Operaciones
    Sub Llenardgvasignaciones(ByVal id As String, ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Asignaciones, Empleados where Asignaciones.codigo = Empleados.codigo and Empleados.estado <> 'Inactivo' and Asignaciones.codigo like'" & id + "%" & "'", cn)

        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub Llamadias(ByVal dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Dias, Empleados where Dias.codigo = Empleados.codigo and Empleados.estado <> 'Inactivo'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub

    Sub Llenardgvdias(ByVal id As String, ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Dias, empleados where Dias.codigo = Empleados.codigo and Empleados.estado <> 'Inactivo' and Dias.codigo like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub


    'Para feriados
    Sub Feriado(ByVal dgv As DataGridView)

        da = New SqlDataAdapter("select top (100) iddialibre, codigo, fecha, dia, autoriza, descanso, observacion from Dias where descanso <> 'Si'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub


    'Para filtar Faltas por codigo
    Sub Llenardgvfaltas(ByVal id As String, ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Faltas, Empleados where Faltas.codigo = Empleados.codigo and Empleados.estado <> 'Inactivo' and Faltas.codigo like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub



    'Sub Llamausuariosmodulos(ByVal dgv As DataGridView)

    '    da = New SqlDataAdapter("select * from usuariosmodulos", cn)
    '    dt = New DataTable
    '    da.Fill(dt)
    '    dgv.DataSource = dt

    'End Sub

    'Para pagos
    Sub Llenardgvpagos(ByVal id As String, ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from Pagos, Empleados where Pagos.codigo = Empleados.codigo and Empleados.estado <> 'Inactivo' and Pagos.codigo like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub


    Sub Llenaraspirantes(ByVal id As String, ByRef dgv As DataGridView)

        da = New SqlDataAdapter("select top(100) * from aspirantes where identidad like'" & id + "%" & "'", cn)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt

    End Sub
End Class