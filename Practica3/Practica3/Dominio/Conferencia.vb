Public Class Conferencia
    Public _idConferencias As Integer
    Public _siglas As String
    Public _nombre As String
    Public _lugar As String
    Public _fecha_inicio As Date
    Public _fecha_fin As Date
    Private gestorConferencias As GestorConferencias
    Public Sub New(ByVal idConferencia As Integer, ByVal siglas As String, ByVal nombre As String, ByVal lugar As String, ByVal fecha_inicio As Date, ByVal fecha_fin As Date)
        Me.idConferencias = idConferencia
        Me.siglas = siglas
        Me.nombre = nombre
        Me.lugar = lugar
        Me.fecha_inicio = fecha_inicio
        Me.fecha_fin = fecha_fin
        gestorConferencias = New GestorConferencias()
    End Sub
    Sub New()
        gestorConferencias = New GestorConferencias()
    End Sub
    Public Property fecha_fin As Date
        Get
            Return _fecha_fin
        End Get
        Set(value As Date)
            _fecha_fin = value
        End Set
    End Property
    Public Property fecha_inicio As Date
        Get
            Return _fecha_inicio
        End Get
        Set(value As Date)
            _fecha_inicio = value
        End Set
    End Property
    Public Property lugar As String
        Get
            Return _lugar
        End Get
        Set(value As String)
            _lugar = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property siglas As String
        Get
            Return _siglas
        End Get
        Set(value As String)
            _siglas = value
        End Set
    End Property
    Public Property idConferencias As Integer
        Get
            Return _idConferencias
        End Get
        Set(value As Integer)
            _idConferencias = value
        End Set
    End Property
    Function leerTodos()
        Dim todos As Collection
        Me.gestorConferencias.leerTodos()
        todos = gestorConferencias._listaConferencias
        Return todos
    End Function
    Public Sub leerConferencia(ByVal idConferencia As Integer)
        gestorConferencias.leerConferencia(idConferencia, Me)
    End Sub
    Public Sub insertar()
        Me.gestorConferencias.insertar(Me)
    End Sub
    Public Sub actualizar()
        Me.gestorConferencias.actualizar(Me)
    End Sub
    Public Sub borrar()
        Me.gestorConferencias.borrar(Me)
    End Sub
    Public Sub leerMax()
        Me.gestorConferencias.maximo(Me)
    End Sub
    Public Sub leerMaxVal()
        Me.gestorConferencias.maximoVal(Me)
    End Sub

End Class
