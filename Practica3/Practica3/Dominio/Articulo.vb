Public Class Articulo
    Private _idArticulo As Integer
    Private _titulo As String
    Private _conferencia As Integer
    Private _pag_Inicio As Integer
    Private _pag_Fin As Integer
    Private gestorArticulos As GestorArticulos
    Public Sub New(ByVal idArticulo As Integer, ByVal titulo As String, ByVal conferencia As Integer, ByVal pag_Inicio As Integer, ByVal pag_Fin As Integer)
        Me.idArticulo = idArticulo
        Me.titulo = titulo
        Me.conferencia = conferencia
        Me.pag_Inicio = pag_Inicio
        Me.pag_Fin = pag_Fin
        gestorArticulos = New GestorArticulos()
    End Sub
    Sub New()
        gestorArticulos = New GestorArticulos()
    End Sub
    Public Property idArticulo As Integer
        Get
            Return _idArticulo
        End Get
        Set(value As Integer)
            _idArticulo = value
        End Set
    End Property
    Public Property titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property
    Public Property conferencia As Integer
        Get
            Return _conferencia
        End Get
        Set(value As Integer)
            _conferencia = value
        End Set
    End Property
    Public Property pag_Inicio As Integer
        Get
            Return _pag_Inicio
        End Get
        Set(value As Integer)
            _pag_Inicio = value
        End Set
    End Property
    Public Property pag_Fin As Integer
        Get
            Return _pag_Fin
        End Get
        Set(value As Integer)
            _pag_Fin = value
        End Set
    End Property
    Function leerTodos()
        Dim todos As Collection
        Me.gestorArticulos.leerTodos()
        todos = gestorArticulos._listaArticulos
        Return todos
    End Function
    Public Sub leerArticulo(ByVal idArticulo As Integer)
        gestorArticulos.leerArticulo(idArticulo, Me)
    End Sub
    Public Sub insertar()
        Me.gestorArticulos.insertar(Me)
    End Sub
    Public Sub actualizar()
        Me.gestorArticulos.actualizar(Me)
    End Sub
    Public Sub borrar()
        Me.gestorArticulos.borrar(Me)
    End Sub
    Public Sub leerMax()
        Me.gestorArticulos.maximo(Me)
    End Sub
    Public Sub leerMaxVal()
        Me.gestorArticulos.maximoVal(Me)
    End Sub
End Class
