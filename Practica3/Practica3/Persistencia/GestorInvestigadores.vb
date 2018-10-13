Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class GestorInvestigadores

    Private agente As Agente
    Private listaInvestigadores As Collection
    Public Sub New()
        listaInvestigadores = New Collection
    End Sub
    Public Property _listaInvestigadores() As Collection
        Get
            Return listaInvestigadores
        End Get
        Set(nlistaInvestigadores As Collection)
            listaInvestigadores = nlistaInvestigadores
        End Set
    End Property
    'leer todos los investigadores
    Public Sub leerTodos()
        Dim investigadores As Investigador
        Dim lector As OleDbDataReader
        lector = Agente.getAgente.leer("SELECT * FROM Investigadores")
        While lector.Read()
            investigadores = New Investigador(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
            Me.listaInvestigadores.Add(investigadores)
        End While
    End Sub
    'leer un investigador por idInvest
    Public Sub maximo(ByVal investigador As Investigador)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT MAX(idInvest) as maxid FROM INVESTIGADORES")
        If lector.Read() Then
            investigador.idInvest = Convert.ToInt32(lector(0))
        End If
    End Sub
    Public Sub maximoVal(ByVal investigador As Investigador)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT MAX(idInvest) as maxid FROM INVESTIGADORES")
        If lector.Read() Then
            investigador.idInvest = Convert.ToInt32(lector(0)) + 1
        End If
    End Sub
    'insertar investigador
    Public Sub insertar(ByVal nuevoInvestigador As Investigador)
        Agente.getAgente.modificar("INSERT INTO Investigadores VALUES ('" & nuevoInvestigador.idInvest & "','" & nuevoInvestigador.nombre & "', '" & nuevoInvestigador.apellidos & "', '" & nuevoInvestigador.despacho & "', '" & nuevoInvestigador.edificio & "', '" & nuevoInvestigador.departamento & "', '" & nuevoInvestigador.telefono & "', '" & nuevoInvestigador.email & "');")
    End Sub
    'modifica investigador
    Public Sub actualizar(ByVal modficadoInvestigador As Investigador)
        Agente.getAgente.modificar("UPDATE Investigadores SET Nombre='" & modficadoInvestigador.nombre & "', Apellidos='" & modficadoInvestigador.apellidos & "', Despacho='" & modficadoInvestigador.despacho & "', Edificio='" & modficadoInvestigador.edificio & "', Departamento='" & modficadoInvestigador.departamento & "', Teléfono='" & modficadoInvestigador.telefono & "' , Email='" & modficadoInvestigador.email & "' WHERE idInvest=" & modficadoInvestigador.idInvest & ";")
    End Sub
    'elimar investigador
    Public Sub borrar(ByVal borrarInvestigador As Investigador)
        Agente.getAgente.modificar("DELETE FROM INVESTIGADORES WHERE idInvest=" & borrarInvestigador.idInvest & ";")
        Agente.getAgente.modificar("DELETE FROM ASISTE WHERE Invest=" & borrarInvestigador.idInvest & ";")
        Agente.getAgente.modificar("DELETE FROM AUTOR WHERE Invest=" & borrarInvestigador.idInvest & ";")
    End Sub
    Public Sub leerValor(ByVal idInvest As Integer, ByVal i As Integer)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT * FROM Investigadores WHERE idInvest =" & idInvest & ";")
        While lector.Read()
            Me.listaInvestigadores.Add(lector(i))
        End While
    End Sub
    Public Sub leerInvestigador(ByVal idInvest As Integer, ByVal investigador As Investigador)
        Me.agente = Agente.getAgente
        Dim lector As OleDbDataReader
        lector = Me.agente.leer("SELECT * FROM Investigadores WHERE idInvest =" & idInvest & ";")
        While lector.Read()
            investigador.idInvest = lector(0)
            investigador.nombre = lector(1)
            investigador.apellidos = lector(2)
            investigador.despacho = lector(3)
            investigador.edificio = lector(4)
            investigador.departamento = lector(5)
            investigador.telefono = lector(6)
            investigador.email = lector(7)
        End While
    End Sub
End Class