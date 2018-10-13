Public Class Autor
    Private _invest As Integer
    Private _articulo As Integer
    Private _orden As Integer
    Private gestorAutores As GestorAutores

    Public Sub New(ByVal invest As Integer, ByVal articlulo As Integer, ByVal orden As Integer)
        Me.invest = invest
        Me.articulo = articlulo
        Me.orden = orden
        gestorAutores = New GestorAutores()
    End Sub
    Sub New()
        gestorAutores = New GestorAutores()
    End Sub
    Public Property articulo As Integer
        Get
            Return _articulo
        End Get
        Set(value As Integer)
            _articulo = value
        End Set
    End Property
    Public Property invest As Integer
        Get
            Return _invest
        End Get
        Set(value As Integer)
            _invest = value
        End Set
    End Property
    Public Property orden As Integer
        Get
            Return _orden
        End Get
        Set(value As Integer)
            _orden = value
        End Set
    End Property
    Function leerTodos()
        Dim todos As Collection
        Me.gestorAutores.leerTodos()
        todos = gestorAutores._listaAutores
        Return todos
    End Function
    Function leerArticulos(ByVal idArticulo As Integer)
        Dim todos As Collection
        Me.gestorAutores.leerArticulos(idArticulo)
        todos = gestorAutores._listaAutores
        Return todos
    End Function
    Function leerValores(ByVal idAutor As Integer, ByVal i As Integer)
        Dim todos As Collection
        Me.gestorAutores.leerValores(idAutor, i)
        todos = gestorAutores._listaAutores
        Return todos
    End Function
    Public Sub insertar()
        Me.gestorAutores.insertar(Me)
    End Sub
    Public Sub actualizar()
        Me.gestorAutores.actualizar(Me)
    End Sub
    Public Sub borrar()
        Me.gestorAutores.borrar(Me)
    End Sub

End Class
