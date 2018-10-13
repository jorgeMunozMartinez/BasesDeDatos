Public Class Investigador
    Private _idInvest As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _despacho As String
    Private _edificio As String
    Private _departamento As String
    Private _telefono As Integer
    Private _email As String
    Private gestorInvestigadores As GestorInvestigadores

    Public Sub New(ByVal idInvest As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal despacho As String, ByVal edificio As String, ByVal departamento As String, ByVal telefono As Integer, ByVal email As String)
        Me.idInvest = idInvest
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.despacho = despacho
        Me.edificio = edificio
        Me.departamento = departamento
        Me.telefono = telefono
        Me.email = email
        gestorInvestigadores = New GestorInvestigadores()

    End Sub
    Sub New()
        gestorInvestigadores = New GestorInvestigadores()
    End Sub
    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property
    Public Property departamento As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property
    Public Property edificio As String
        Get
            Return _edificio
        End Get
        Set(value As String)
            _edificio = value
        End Set
    End Property
    Public Property despacho As String
        Get
            Return _despacho
        End Get
        Set(value As String)
            _despacho = value
        End Set
    End Property
    Public Property apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
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
    Public Property idInvest As Integer
        Get
            Return _idInvest
        End Get
        Set(value As Integer)
            _idInvest = value
        End Set
    End Property
    'leer todos los investigadores
    Function leerTodos()
        Dim todos As Collection
        Me.gestorInvestigadores.leerTodos()
        todos = gestorInvestigadores._listaInvestigadores
        Return todos
    End Function
    Public Sub insertar()
        Me.gestorInvestigadores.insertar(Me)
    End Sub
    Public Sub actualizar()
        Me.gestorInvestigadores.actualizar(Me)
    End Sub
    Public Sub borrar()
        Me.gestorInvestigadores.borrar(Me)
    End Sub
    Public Sub leerMax()
        Me.gestorInvestigadores.maximo(Me)
    End Sub
    Public Sub leerMaxVal()
        Me.gestorInvestigadores.maximoVal(Me)
    End Sub
    'leer un investigador con idInvest deseado
    Function leerValores(ByVal idInvest As Integer, ByVal i As Integer)
        Dim todos As Collection
        Me.gestorInvestigadores.leerValor(idInvest, i)
        todos = gestorInvestigadores._listaInvestigadores
        Return todos
    End Function
    Public Sub leerInvestigador(ByVal idInvest As Integer)
        gestorInvestigadores.leerInvestigador(idInvest, Me)
    End Sub
End Class
