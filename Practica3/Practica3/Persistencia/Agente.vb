Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Agente
    Public Shared Ruta As String = Nothing
    Private Shared instancia As Agente
    Private Shared cadConexion As String
    Private Shared conexion As OleDbConnection
    Private Sub New()
        cadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Ruta
        'CargarBBDD.OpenFileDialog1.FileName
        Agente.conexion = New OleDbConnection(cadConexion)
        Agente.conexion.Open()
    End Sub

    Public Shared Function getAgente() As Agente
        If instancia Is Nothing Then
            instancia = New Agente
        End If
        Return instancia
    End Function

    Public Function leer(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, conexion)
        Return com.ExecuteReader()

    End Function
    Public Function modificar(ByVal sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, conexion)
        Return com.ExecuteNonQuery()
    End Function


End Class

