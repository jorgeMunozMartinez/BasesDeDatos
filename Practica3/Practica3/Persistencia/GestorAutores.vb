Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class GestorAutores
    Private agente As Agente
    Private listaAutores As Collection
    Public Sub New()
        listaAutores = New Collection
    End Sub
    Public Property _listaAutores() As Collection
        Get
            Return listaAutores
        End Get
        Set(nlistaAutores As Collection)
            listaAutores = nlistaAutores
        End Set
    End Property
    Public Sub leerTodos()
        Dim autor As Autor
        Dim lector As OleDbDataReader
        lector = Agente.getAgente.leer("SELECT * FROM Autor")
        While lector.Read()
            autor = New Autor(lector(0), lector(1), lector(2))
            Me.listaAutores.Add(autor)
        End While
    End Sub
    Public Sub leerValores(ByVal idAutor As Integer, ByVal i As Integer)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT * FROM Autor WHERE Invest =" & idAutor & ";")
        While lector.Read()
            Me.listaAutores.Add(lector(i))
        End While
    End Sub
    Public Sub leerArticulos(ByVal idArticulo As Integer)
        Dim lector As OleDbDataReader
        lector = Agente.getAgente.leer("SELECT Invest, Orden FROM Autor WHERE Articulo=" & idArticulo & " ORDER BY ORDEN ASC;")
        While lector.Read()
            Me.listaAutores.Add(lector(0))
        End While
    End Sub
    Public Sub insertar(ByVal nuevoAutor As Autor)
        Agente.getAgente.modificar("INSERT INTO Autor VALUES ('" & nuevoAutor.invest & "', '" & nuevoAutor.articulo & "', '" & nuevoAutor.orden & "');")
    End Sub
    Public Sub actualizar(ByVal modificarAutor As Autor)
        Agente.getAgente.modificar("UPDATE Autor SET Orden=" & modificarAutor.orden & "  WHERE Invest=" & modificarAutor.invest & ";")
    End Sub
    Public Sub borrar(ByVal borrarAutor As Autor)
        'FUNCIONA Agente.getInstancia.modificar("DELETE FROM AUTOR WHERE Invest=" & borrarAutor.invest & ";")
        Agente.getAgente.modificar("DELETE FROM AUTOR WHERE  Invest=" & borrarAutor.invest & "AND Articulo=" & borrarAutor.articulo & ";")
    End Sub

End Class
