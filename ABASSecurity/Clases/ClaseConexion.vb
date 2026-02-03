Imports System.Data.SqlClient

Module ClaseConexion
    Public cn As New SqlConnection(My.Settings.ABASConnection)
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable
    Public ds As DataSet
    Public da As SqlDataAdapter
    Public sql As String

    Sub Ejecutar(sql As String)
        cn.Close()
        cn.Open()
        cmd = New SqlCommand(sql, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

End Module
