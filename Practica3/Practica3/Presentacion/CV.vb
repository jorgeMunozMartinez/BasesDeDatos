Public Class CV
    Private Sub cargarInvestigador()
        ListaInvestigadoresId.Items.Clear()
        ListaInvestigadoresNombre.Items.Clear()
        ListaInvestigadoresApellidos.Items.Clear()
        Dim invetigador As New Investigador
        Dim lista As New Collection
        Dim i As Integer = 1
        lista = invetigador.leerTodos()
        While i <= lista.Count
            ListaInvestigadoresId.Items.Add(lista.Item(i))
            ListaInvestigadoresNombre.Items.Add(lista.Item(i))
            ListaInvestigadoresApellidos.Items.Add(lista.Item(i))
            i += 1
        End While
        ListaInvestigadoresId.DisplayMember = "idInvest"
        ListaInvestigadoresNombre.DisplayMember = "Nombre"
        ListaInvestigadoresApellidos.DisplayMember = "Apellidos"
        ListaInvestigadoresId.SelectedItem = 0
    End Sub

    Private Sub CV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarInvestigador()
    End Sub
    Private Sub mostrarInvestigadores()
        Dim investigador As Investigador = DirectCast(ListaInvestigadoresId.SelectedItem(), Investigador)
        CVTexto.AppendText("-----------------------------" & Environment.NewLine)
        CVTexto.AppendText("Datos personales" & Environment.NewLine)
        CVTexto.AppendText("Nombre Investigador: " & investigador.nombre & Environment.NewLine)
        CVTexto.AppendText("Apellidos Investigador: " & investigador.apellidos & Environment.NewLine)
        CVTexto.AppendText("Despacho Investigador: " & investigador.despacho & Environment.NewLine)
        CVTexto.AppendText("Edificio Investigador: " & investigador.edificio & Environment.NewLine)
        CVTexto.AppendText("Departamento Investigador: " & investigador.departamento & Environment.NewLine)
        CVTexto.AppendText("Telefono Investigador: " & investigador.telefono & Environment.NewLine)
        CVTexto.AppendText("Email Investigador: " & investigador.email & Environment.NewLine)
        CVTexto.AppendText("-----------------------------" & Environment.NewLine)
        CVTexto.AppendText("Relación de conferencias a las que ha asistido :" & Environment.NewLine)
        mostrarAsistencia(investigador)
        CVTexto.AppendText("-----------------------------" & Environment.NewLine)
        CVTexto.AppendText("Relación de artículos que ha publicado" & Environment.NewLine)
        mostrarAutor(investigador)
    End Sub
    Private Sub mostrarAutor(ByVal investigador As Investigador)
        Dim autor As New Autor
        Dim articulos As New Collection
        Dim i As Integer = 1
        Try
            articulos = autor.leerValores(investigador.idInvest, 1)
            CVTexto.AppendText("-----------------------------" & Environment.NewLine)
            While i <= articulos.Count
                mostarAutoresAsociados(articulos.Item(i))
                i += 1
                CVTexto.AppendText("-----------------------------" & Environment.NewLine)
            End While
        Catch ex As Exception
            If MessageBox.Show("El investigador no ha escrito nuingun libro ", "Autores", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            End If
        End Try
    End Sub
    Private Sub mostarAutoresAsociados(ByVal idArticulo As Integer)
        Dim autor As New Autor
        Dim valor As Collection
        Dim investigador As New Investigador
        Dim articulo As New Articulo
        Dim conferencia As New Conferencia
        valor = autor.leerArticulos(idArticulo)
        articulo.leerArticulo(idArticulo)
        conferencia.leerConferencia(articulo.conferencia)
        Dim i As Integer = 1
        While i <= valor.Count
            investigador.leerInvestigador(valor.Item(i))
            CVTexto.AppendText(investigador.apellidos & ", " & investigador.nombre & ", ")
            i += 1
        End While
        CVTexto.AppendText(conferencia.siglas & ": " & articulo.titulo & ". pp. " & articulo.pag_Inicio & "-" & articulo.pag_Fin & ". " & conferencia.lugar & ". " & conferencia.fecha_inicio & Environment.NewLine)
    End Sub
    Private Sub mostrarAsistencia(ByVal investigador As Investigador)
        Dim asistencia As New Asistente
        Dim conferencias As New Collection
        Dim i As Integer = 1
        Try
            conferencias = asistencia.leerValores(investigador.idInvest, 0)
            While i <= conferencias.Count
                mostrarConferencias(conferencias.Item(i))
                CVTexto.AppendText("-----------------------------" & Environment.NewLine)
                i += 1
            End While
        Catch ex As Exception
            If MessageBox.Show("El investigador no asistio a ninguna conferencia", "Asistencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            End If
        End Try
    End Sub
    Private Sub mostrarConferencias(ByVal idConferencia As Integer)
        Dim conferencias As New Conferencia
        CVTexto.AppendText("Id Conferencia : " & idConferencia & Environment.NewLine)
        conferencias.leerConferencia(idConferencia)
        CVTexto.AppendText("Siglas Conferencia: " & conferencias.siglas & Environment.NewLine)
        CVTexto.AppendText("Nombre Conferencia: " & conferencias.nombre & Environment.NewLine)
        CVTexto.AppendText("Lugar Conferencia: " & conferencias.lugar & Environment.NewLine)
        CVTexto.AppendText("Fecha Inicio Conferencia: " & conferencias.fecha_inicio & Environment.NewLine)
        CVTexto.AppendText("Fecha Fin Conferencia: " & conferencias.fecha_fin & Environment.NewLine)
    End Sub
    Private Sub ListaInvestigadoresId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaInvestigadoresId.SelectedIndexChanged
        If ListaInvestigadoresId.SelectedItem() Is Nothing Then
        Else
            mostrarInvestigadores()
        End If
        ListaInvestigadoresNombre.SelectedIndex = ListaInvestigadoresId.SelectedIndex
        ListaInvestigadoresApellidos.SelectedIndex = ListaInvestigadoresId.SelectedIndex
    End Sub
    Private Sub GenerarCV_Click(sender As Object, e As EventArgs)
        Dim investigador As Investigador = DirectCast(ListaInvestigadoresId.SelectedItem(), Investigador)

    End Sub
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        CVTexto.Clear()
    End Sub

End Class