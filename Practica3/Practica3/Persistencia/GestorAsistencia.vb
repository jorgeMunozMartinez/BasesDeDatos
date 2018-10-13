Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class GestorAsistencia
    Private agente As Agente
    Private listaAsistencia As Collection

    Public Sub New()
        listaAsistencia = New Collection
    End Sub
    Public Property _listaAsistencia() As Collection
        Get
            Return listaAsistencia
        End Get
        Set(nlistaAsistencia As Collection)
            listaAsistencia = nlistaAsistencia
        End Set
    End Property
    Public Sub leerTodos()
        Dim asistente As Asistente
        Dim lector As OleDbDataReader
        lector = Agente.getAgente.leer("SELECT * FROM Asiste")
        While lector.Read()
            asistente = New Asistente(lector(0), lector(1))
            Me.listaAsistencia.Add(asistente)
        End While
    End Sub
    Public Sub leerAsistencia(ByVal idInvestigador As Integer, ByVal asistencia As Asistente)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT * FROM Asiste WHERE Invest =" & idInvestigador & ";")
        While lector.Read()
            asistencia.conferencia = lector(0)
            asistencia.invest = lector(1)
        End While
    End Sub
    Public Sub leerValores(ByVal idInvestigador As Integer, ByVal i As Integer)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT * FROM Asiste WHERE Invest =" & idInvestigador & ";")
        While lector.Read()
            Me.listaAsistencia.Add(lector(i))
        End While
    End Sub
    Public Sub insertar(ByVal nuevaAsistencia As Asistente)
        Agente.getAgente.modificar("INSERT INTO Asiste VALUES ('" & nuevaAsistencia.conferencia & "', '" & nuevaAsistencia.invest & "');")
    End Sub
    Public Sub actualizar(ByVal modificarAsistencia As Asistente)
        Agente.getAgente.modificar("UPDATE Asiste SET ='" & modificarAsistencia.invest & "'  WHERE Conferencia=" & modificarAsistencia.conferencia & ";")
    End Sub
    Public Sub borrar(ByVal borrarAsistencia As Asistente)
        Agente.getAgente.modificar("DELETE FROM Asiste WHERE Conferencia=" & borrarAsistencia.conferencia & " AND Invest=" & borrarAsistencia.invest & ";")
    End Sub

End Class
