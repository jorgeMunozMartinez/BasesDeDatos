Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class GestorArticulos
    Private agente As Agente
    Private listaArticulos As Collection
    Public Sub New()
        listaArticulos  = New Collection
    End Sub
    Public Property _listaArticulos() As Collection
        Get
            Return listaArticulos
        End Get
        Set(nlistaArticulos As Collection)
            listaArticulos = nlistaArticulos
        End Set
    End Property
    Public Sub leerTodos()
        Dim articulo As Articulo
        Dim lector As OleDbDataReader
        lector = Agente.getAgente.leer("SELECT * FROM Articulos")
        While lector.Read()
            articulo = New Articulo(lector(0), lector(1), lector(2), lector(3), lector(4))
            Me.listaArticulos.Add(articulo)
        End While
    End Sub
    Public Sub leerArticulo(ByVal idArticulo As Integer, ByVal articulo As Articulo)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT * FROM Articulos WHERE idArticulo =" & idArticulo & ";")
        While lector.Read()
            articulo.idArticulo = lector(0)
            articulo.titulo = lector(1)
            articulo.conferencia = lector(2)
            articulo.pag_Inicio = lector(3)
            articulo.pag_Fin = lector(4)
        End While
    End Sub
    Public Sub insertar(ByVal nuevoArticulo As Articulo)
        Agente.getAgente.modificar("INSERT INTO Articulos VALUES ('" & nuevoArticulo.idArticulo & "', '" & nuevoArticulo.titulo & "', '" & nuevoArticulo.conferencia & "', '" & nuevoArticulo.pag_Inicio & "', '" & nuevoArticulo.pag_Fin & "');")
    End Sub
    Public Sub actualizar(ByVal modificarArticulo As Articulo)
        Agente.getAgente.modificar("UPDATE Articulos SET Titulo='" & modificarArticulo.titulo & "', Conferencia='" & modificarArticulo.conferencia & "', pag_inicio='" & modificarArticulo.pag_Inicio & "', pag_fin='" & modificarArticulo.pag_Fin & "'  WHERE idArticulo=" & modificarArticulo.idArticulo & ";")
    End Sub
    Public Sub borrar(ByVal borrarArticulo As Articulo)
        Agente.getAgente.modificar("DELETE FROM ARTICULOS WHERE idArticulo=" & borrarArticulo.idArticulo & ";")
        Agente.getAgente.modificar("DELETE FROM AUTOR WHERE Articulo=" & borrarArticulo.idArticulo & ";")
    End Sub
    Public Sub maximo(ByVal articulo As Articulo)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT MAX(idArticulo) as maxid FROM ARTICULOS")
        If lector.Read() Then
            articulo.idArticulo = Convert.ToInt32(lector(0))
        End If
    End Sub
    Public Sub maximoVal(ByVal articulo As Articulo)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT MAX(idArticulo) as maxid FROM ARTICULOS")
        If lector.Read() Then
            articulo.idArticulo = Convert.ToInt32(lector(0)) + 1
        End If
    End Sub
End Class
