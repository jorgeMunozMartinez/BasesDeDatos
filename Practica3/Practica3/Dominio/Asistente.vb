Public Class Asistente
    Public _Conferencia As Integer
    Public _Invest As Integer
    Private gestorAsistente As GestorAsistencia

    Public Sub New(ByVal conferencias As Integer, ByVal invest As Integer)
        Me.conferencia = conferencias
        Me.invest = invest
        gestorAsistente = New GestorAsistencia()
    End Sub
    Sub New()
        gestorAsistente = New GestorAsistencia()
    End Sub
    Public Property conferencia As Integer
        Get
            Return _Conferencia
        End Get
        Set(value As Integer)
            _Conferencia = value
        End Set
    End Property
    Public Property invest As Integer
        Get
            Return _Invest
        End Get
        Set(value As Integer)
            _Invest = value
        End Set
    End Property
    Function leerTodos()
        Dim todos As Collection
        Me.gestorAsistente.leerTodos()
        todos = gestorAsistente._listaAsistencia
        Return todos
    End Function
    Function leerValores(ByVal idAsistente As Integer, ByVal i As Integer)
        Dim todos As Collection
        Me.gestorAsistente.leerValores(idAsistente, i)
        todos = gestorAsistente._listaAsistencia
        Return todos
    End Function
    Public Sub insertar()
        Me.gestorAsistente.insertar(Me)
    End Sub
    Public Sub actualizar()
        Me.gestorAsistente.actualizar(Me)
    End Sub
    Public Sub borrar()
        Me.gestorAsistente.borrar(Me)
    End Sub

End Class
