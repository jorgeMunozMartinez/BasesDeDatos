Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class GestorConferencias
    Private agente As Agente
    Private listaConferencias As Collection
    Public Sub New()
        listaConferencias = New Collection
    End Sub
    Public Property _listaConferencias() As Collection
        Get
            Return listaConferencias
        End Get
        Set(nlistaConferencias As Collection)
            listaConferencias = nlistaConferencias
        End Set
    End Property
    Public Sub maximoVal(ByVal conferencias As Conferencia)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT MAX(idConferencia) as maxid FROM CONFERENCIAS")
        If lector.Read() Then
            conferencias.idConferencias = Convert.ToInt32(lector(0)) + 1
        End If
    End Sub
    Public Sub maximo(ByVal conferencias As Conferencia)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT MAX(idConferencia) as maxid FROM CONFERENCIAS")
        If lector.Read() Then
            conferencias.idConferencias = Convert.ToInt32(lector(0))
        End If
    End Sub
    Public Sub leerConferencia(ByVal idConferencia As Integer, ByVal conferencia As Conferencia)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT * FROM Conferencias WHERE idConferencia =" & idConferencia & ";")
        While lector.Read()
            conferencia.idConferencias = lector(0)
            conferencia.siglas = lector(1)
            conferencia.nombre = lector(2)
            conferencia.lugar = lector(3)
            conferencia.fecha_inicio = lector(4)
            conferencia.fecha_fin = lector(5)
        End While
    End Sub

    Public Sub insertar(ByVal nuevaConferencia As Conferencia)
        Agente.getAgente.modificar("INSERT INTO Conferencias VALUES ('" & nuevaConferencia.idConferencias & "', '" & nuevaConferencia.siglas & "', '" & nuevaConferencia.nombre & "', '" & nuevaConferencia.lugar & "', '" & nuevaConferencia.fecha_inicio & "', '" & nuevaConferencia.fecha_fin & "');")
    End Sub
    Public Sub actualizar(ByVal modificarConferencia As Conferencia)
        Agente.getAgente.modificar("UPDATE Conferencias SET Siglas='" & modificarConferencia.siglas & "', Nombre='" & modificarConferencia.nombre & "', Lugar='" & modificarConferencia.lugar & "', Fecha_inicio='" & modificarConferencia.fecha_inicio & "', Fecha_fin='" & modificarConferencia.fecha_fin & "'  WHERE idConferencia=" & modificarConferencia.idConferencias & ";")
    End Sub
    Public Sub borrar(ByVal borrarConferencia As Conferencia)
        Agente.getAgente.modificar("DELETE FROM Conferencias WHERE idConferencia=" & borrarConferencia.idConferencias & ";")
        Agente.getAgente.modificar("DELETE FROM ASISTE WHERE Conferencia=" & borrarConferencia.idConferencias & ";")
        Agente.getAgente.modificar("DELETE FROM ARTICULOS WHERE Conferencia=" & borrarConferencia.idConferencias & ";")
    End Sub
    Public Sub leerTodos()
        Dim conferencia As Conferencia
        Dim lector As OleDbDataReader
        lector = Agente.getAgente.leer("SELECT * FROM Conferencias")
        While lector.Read()
            conferencia = New Conferencia(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            Me.listaConferencias.Add(conferencia)
        End While
    End Sub
End Class
