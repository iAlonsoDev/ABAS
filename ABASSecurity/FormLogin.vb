
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class FormLogin

    ReadOnly fecha As String = System.DateTime.Now.Day & "-" & System.DateTime.Now.Month & "-" & System.DateTime.Now.Year & " " & System.DateTime.Now.Hour & ":" & System.DateTime.Now.Minute & ":" & System.DateTime.Now.Second

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdentrar.Click
        Entrar()
    End Sub

    Sub Entrar()
        Try
            Dim passwordBytes() As Byte
            Using sha256 As SHA256 = SHA256.Create()
                passwordBytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(txtcontraseña.Text.Trim()))
            End Using

            sql = "
        SELECT TOP 1 
            u.[ID], u.[Codigo], u.[Usuario],
            u.[Rango1], u.[Rango2], u.[Rango3], u.[Rango4],
            u.[Rango5], u.[Rango6], u.[RRHH], u.[Clientes],
            u.[Operacion], u.[Planilla], u.[Pagos], u.[Graficas],
            u.[Inventario], u.[Otros], u.[Usuarios], u.[almacen],
            u.[aprueba1], u.[aprueba2], u.[nivel],
            CASE WHEN u.[Codigo] = '000000' 
                 THEN 'Jonatan Alonso' 
                 ELSE e.nombres + ' ' + e.apellidos 
            END AS nombrecompleto
        FROM UsuariosModulos u
        LEFT JOIN Empleados e ON e.codigo = u.Codigo
        WHERE u.Usuario = @Usuario AND u.Contraseña = @Password;
        "

            cn.Open()
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = txtusuario.Text.Trim()
            cmd.Parameters.Add("@Password", SqlDbType.VarBinary, 64).Value = passwordBytes
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Rango1 = dr("Rango1").ToString()
                Rango2 = dr("Rango2").ToString()
                Rango3 = dr("Rango3").ToString()
                Rango4 = dr("Rango4").ToString()
                Rango5 = dr("Rango5").ToString()
                Rango6 = dr("Rango6").ToString()
                RRHH = dr("RRHH").ToString()
                Clientes = dr("Clientes").ToString()
                Operaciones = dr("Operacion").ToString()
                Planilla = dr("Planilla").ToString()
                Pagos = dr("Pagos").ToString()
                Graficas = dr("Graficas").ToString()
                Inventario = dr("Inventario").ToString()
                Otros = dr("Otros").ToString()
                Usuarios = dr("Usuarios").ToString()
                Almacen = dr("Almacen").ToString()
                Aprueba1 = dr("Aprueba1").ToString()
                Aprueba2 = dr("Aprueba2").ToString()
                Nivel = dr("Nivel").ToString()
                Usuario = dr("Usuario").ToString()
                Nombre = dr("nombrecompleto").ToString()
                Codigo = dr("Codigo").ToString()
                dr.Close()
                cn.Close()

                sql = "INSERT INTO RegistroLogin (usuario, fecha) VALUES('" & txtusuario.Text.Trim() & "', GETDATE())"
                Ejecutar(sql)

                FormPrincipal.Show()
                MsgBox("SISTEMA ABAS" & vbCrLf & "Bienvenid@ " & Nombre, MsgBoxStyle.Information, "ABAS")

                txtusuario.Text = "Usuario"
                txtcontraseña.Text = "Usuario"
                Me.Hide()

            Else
                dr.Close()
                cn.Close()
                MsgBox("¡Datos incorrectos, por favor revisar!", MsgBoxStyle.Information, "Confirmar")
                txtusuario.Text = "Usuario"
                txtcontraseña.Text = "Usuario"
                txtusuario.Select()
            End If

        Catch ex As Exception
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If cn.State = ConnectionState.Open Then cn.Close()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error de conexión")
        End Try
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtusuario.Click
        txtusuario.Clear()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtcontraseña.Click
        txtcontraseña.Clear()
    End Sub

    Private Sub Txtcontraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontraseña.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Entrar()
        End Select
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
End Class