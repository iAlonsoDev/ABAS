
Imports System.Data.SqlClient
Public Class FormLogin

    ReadOnly fecha As String = System.DateTime.Now.Day & "-" & System.DateTime.Now.Month & "-" & System.DateTime.Now.Year & " " & System.DateTime.Now.Hour & ":" & System.DateTime.Now.Minute & ":" & System.DateTime.Now.Second

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdentrar.Click
        Entrar()
    End Sub

    Sub Entrar()
        cn.Open()
        cmd = New SqlCommand("select [ID]
                  ,UsuariosModulos.[Codigo]
                  ,[Usuario]
                  ,[Contraseña]
                  ,[Rango1]
                  ,[Rango2]
                  ,[Rango3]
                  ,[Rango4]
                  ,[Rango5]
                  ,[Rango6]
                  ,[RRHH]
                  ,[Clientes]
                  ,[Operacion]
                  ,UsuariosModulos.[Planilla]
                  ,[Pagos]
                  ,[Graficas]
                  ,[Inventario]
                  ,[Otros]
                  ,[Usuarios]
                  ,[almacen]
                  ,[aprueba1]
                  ,[aprueba2]
                  ,[nivel]
	              ,Case when UsuariosModulos.[Codigo] = '000000' then 'Jonatan Alonso' else Empleados.nombres +' '+ Empleados.apellidos  end nombrecompleto
	              from UsuariosModulos
                left outer join empleados
                on empleados.codigo = UsuariosModulos.Codigo
             where usuario = '" + txtusuario.Text + "' and contraseña='" + txtcontraseña.Text + "'") With {
            .Connection = cn,
            .CommandType = CommandType.Text
        }
        dr = cmd.ExecuteReader()

        If dr.Read Then
            Rango1 = dr.Item("rango1")
            Rango2 = dr.Item("rango2")
            Rango3 = dr.Item("rango3")
            Rango4 = dr.Item("rango4")
            Rango5 = dr.Item("rango5")
            Rango6 = dr.Item("rango6")
            RRHH = dr.Item("RRHH")
            Clientes = dr.Item("Clientes")
            Operaciones = dr.Item("Operacion")
            Planilla = dr.Item("Planilla")
            Pagos = dr.Item("Pagos")
            Graficas = dr.Item("Graficas")
            Inventario = dr.Item("Inventario")
            Otros = dr.Item("Otros")
            Usuarios = dr.Item("Usuarios")
            Almacen = dr.Item("Almacen")
            Aprueba1 = dr.Item("Aprueba1")
            Aprueba2 = dr.Item("Aprueba2")
            Nivel = dr.Item("Nivel")
            Usuario = dr.Item("Usuario")
            Nombre = dr.Item("nombrecompleto")
            Codigo = dr.Item("Codigo")

            dr.Close()
            cn.Close()

            sql = "insert into RegistroLogin (usuario, fecha) values('" + txtusuario.Text + "','" + fecha + "')"
            Ejecutar(sql)


            FormPrincipal.Show()
            MsgBox("SISTEMA ABAS
" & "Bienvenid@ " + Nombre + "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ABAS")

            txtusuario.Text = "Usuario"
            txtcontraseña.Text = "Usuario"
            Me.Hide()
        Else
            MsgBox("¡Datos incorrectos por favor, revisar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Confirmar")
            txtusuario.Text = "Usuario"
            txtcontraseña.Text = "Usuario"
            txtusuario.Select()
        End If

        dr.Close()
        cn.Close()

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtusuario.Click
        txtusuario.Clear()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtcontraseña.Click
        txtcontraseña.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub Txtcontraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontraseña.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Entrar()
        End Select
    End Sub

End Class