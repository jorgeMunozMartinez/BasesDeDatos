Public Class OpcionesValores
    'mostrar cuadros 
    Private Sub cargarAutor()
        ListaAutoresId.Items.Clear()
        ListaAutoresArticulo.Items.Clear()
        Dim autor As New Autor
        Dim lista As New Collection
        Dim i As Integer = 1
        lista = autor.leerTodos()
        While i <= lista.Count
            ListaAutoresId.Items.Add(lista.Item(i))
            ListaAutoresArticulo.Items.Add(lista.Item(i))
            i += 1
        End While
        ListaAutoresId.DisplayMember = "Invest"
        ListaAutoresId.SelectedItem = 0
        '
        ListaAutoresArticulo.DisplayMember = "Articulo"
        ListaAutoresArticulo.SelectedItem = 0

    End Sub
    Private Sub cargarInvestigador()
        ListaInvestigadoresId.Items.Clear()
        ListaInvestigadoresNombre.Items.Clear()
        ListaInvestigadoresApellidos.Items.Clear()
        '
        InvestigadoresAsistenciaId.Items.Clear()
        InvestigadorAsistenciaNombre.Items.Clear()
        InvestigadorAsistenciaApellidos.Items.Clear()
        '
        InvestigadoresAutoresId.Items.Clear()
        InvestigadoresAutoresNombre.Items.Clear()
        InvestigadoresAutoresApellidos.Items.Clear()
        Dim invetigador As New Investigador
        Dim lista As New Collection
        Dim i As Integer = 1
        lista = invetigador.leerTodos()
        While i <= lista.Count
            ListaInvestigadoresId.Items.Add(lista.Item(i))
            ListaInvestigadoresNombre.Items.Add(lista.Item(i))
            ListaInvestigadoresApellidos.Items.Add(lista.Item(i))
            '
            InvestigadoresAsistenciaId.Items.Add(lista.Item(i))
            InvestigadorAsistenciaNombre.Items.Add(lista.Item(i))
            InvestigadorAsistenciaApellidos.Items.Add(lista.Item(i))
            '
            InvestigadoresAutoresId.Items.Add(lista.Item(i))
            InvestigadoresAutoresNombre.Items.Add(lista.Item(i))
            InvestigadoresAutoresApellidos.Items.Add(lista.Item(i))
            i += 1
        End While
        ListaInvestigadoresId.DisplayMember = "idInvest"
        ListaInvestigadoresNombre.DisplayMember = "Nombre"
        ListaInvestigadoresApellidos.DisplayMember = "Apellidos"
        ListaInvestigadoresId.SelectedItem = 0
        '
        InvestigadoresAsistenciaId.DisplayMember = "idInvest"
        InvestigadorAsistenciaNombre.DisplayMember = "Nombre"
        InvestigadorAsistenciaApellidos.DisplayMember = "Apellidos"
        InvestigadoresAsistenciaId.SelectedItem = 0
        '
        InvestigadoresAutoresId.DisplayMember = "idInvest"
        InvestigadoresAutoresNombre.DisplayMember = "Nombre"
        InvestigadoresAutoresApellidos.DisplayMember = "Apellidos"
        InvestigadoresAutoresId.SelectedItem = 0
    End Sub
    Private Sub cargarConferencia()
        ListaConferenciasId.Items.Clear()
        ListaConferenciasSiglas.Items.Clear()
        ListaConferenciasNombre.Items.Clear()
        '
        ConferenciaAsistenciaId.Items.Clear()
        ConferenciaAsistenciaSiglas.Items.Clear()
        ConferenciaAsistenciaNombre.Items.Clear()
        '
        ListaConferenciaArticuloId.Items.Clear()
        ListaConferenciaArticuloSiglas.Items.Clear()
        ListaConferenciaArticuloNombre.Items.Clear()
        Dim conferencia As New Conferencia
        Dim lista As New Collection
        Dim i As Integer = 1
        lista = conferencia.leerTodos()
        While i <= lista.Count
            '
            ListaConferenciasId.Items.Add(lista.Item(i))
            ListaConferenciasSiglas.Items.Add(lista.Item(i))
            ListaConferenciasNombre.Items.Add(lista.Item(i))
            '
            ConferenciaAsistenciaId.Items.Add(lista.Item(i))
            ConferenciaAsistenciaSiglas.Items.Add(lista.Item(i))
            ConferenciaAsistenciaNombre.Items.Add(lista.Item(i))
            '
            ListaConferenciaArticuloId.Items.Add(lista.Item(i))
            ListaConferenciaArticuloSiglas.Items.Add(lista.Item(i))
            ListaConferenciaArticuloNombre.Items.Add(lista.Item(i))
            i += 1
        End While
        ListaConferenciasId.DisplayMember = "idConferencia"
        ListaConferenciasSiglas.DisplayMember = "Siglas"
        ListaConferenciasNombre.DisplayMember = "Nombre"
        ListaConferenciasId.SelectedItem = 0
        '
        ConferenciaAsistenciaId.DisplayMember = "idConferencia"
        ConferenciaAsistenciaSiglas.DisplayMember = "Siglas"
        ConferenciaAsistenciaNombre.DisplayMember = "Nombre"
        ConferenciaAsistenciaId.SelectedItem = 0
        '
        ListaConferenciaArticuloId.DisplayMember = "idConferencia"
        ListaConferenciaArticuloSiglas.DisplayMember = "Siglas"
        ListaConferenciaArticuloNombre.DisplayMember = "Nombre"
        ListaConferenciaArticuloId.SelectedItem = 0
    End Sub
    Public Sub cargarArticulo()
        ListaArticulosId.Items.Clear()
        ListaArticulosTitulo.Items.Clear()
        ListaArticulosConferencia.Items.Clear()
        '
        ArticuloAutorId.Items.Clear()
        ArticuloAutorTitulo.Items.Clear()
        ArticuloAutorConferencia.Items.Clear()
        Dim articulo As New Articulo
        Dim lista As New Collection
        Dim i As Integer = 1
        lista = articulo.leerTodos()
        While i <= lista.Count
            ListaArticulosId.Items.Add(lista.Item(i))
            ListaArticulosTitulo.Items.Add(lista.Item(i))
            ListaArticulosConferencia.Items.Add(lista.Item(i))
            '
            ArticuloAutorId.Items.Add(lista.Item(i))
            ArticuloAutorTitulo.Items.Add(lista.Item(i))
            ArticuloAutorConferencia.Items.Add(lista.Item(i))
            i += 1
        End While
        ListaArticulosId.DisplayMember = "idArticulo"
        ListaArticulosTitulo.DisplayMember = "Titulo"
        ListaArticulosConferencia.DisplayMember = "Conferencia"
        ListaArticulosId.SelectedItem = 0
        '
        ArticuloAutorId.DisplayMember = "idArticulo"
        ArticuloAutorTitulo.DisplayMember = "Titulo"
        ArticuloAutorConferencia.DisplayMember = "Conferencia"
        ArticuloAutorId.SelectedItem = 0
    End Sub
    Public Sub cargarAsistentes()
        ListaAsistentesInvestigadorId.Items.Clear()
        ListaAsistentesConferenciaId.Items.Clear()
        '
        Dim asistente As New Asistente
        Dim lista As New Collection
        Dim i As Integer = 1
        lista = asistente.leerTodos()
        While i <= lista.Count
            ListaAsistentesInvestigadorId.Items.Add(lista.Item(i))
            ListaAsistentesConferenciaId.Items.Add(lista.Item(i))
            i += 1
        End While
        ListaAsistentesInvestigadorId.DisplayMember = "Conferencia"
        ListaAsistentesConferenciaId.DisplayMember = "Invest"
        ListaAsistentesInvestigadorId.SelectedItem = 0
    End Sub
    Public Sub borrarCampos()
        IdInvestigadorAsistente.Clear()
        ConferenciaSiglasAsistencia.Clear()
        NombreInvestigadorAsistencia.Clear()
        ApellidosInvestigadorAsistencia.Clear()
        IdConferenciaAsistencia.Clear()
        NombreConferenciaAsistencia.Clear()
        IdInvestigadorAutor.Clear()
        IdAutorArticulo.Clear()
        OrdenInvestigadorAutor.Clear()
        IdConferenciaArticulo.Clear()
        TituloArticulo.Clear()
        IdArticulo.Clear()
        Pagina_Final_Articulo.Clear()
        Pagina_Inicio_Articulo.Clear()
        idInvestigador.Clear()
        LugarConferencia.Clear()
        NombreInvestigador.Clear()
        ApellidosInvestigador.Clear()
        DespachoInvestigador.Clear()
        EdificioInvestigador.Clear()
        DepartamentoInvestigador.Clear()
        TelefonoInvestigador.Clear()
        EmailInvestigador.Clear()
        idConferencia.Clear()
        SiglasConferencia.Clear()
        NombreConferencia.Clear()
    End Sub
    'funcion teclas 
    Private Sub OpcionesValores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAsistentes()
        cargarAutor()
        cargarInvestigador()
        cargarConferencia()
        cargarArticulo()
        '
        ListaConferenciaArticuloSiglas.Enabled = False
        ListaConferenciaArticuloNombre.Enabled = False
        '
        ConferenciaAsistenciaNombre.Enabled = False
        ConferenciaAsistenciaSiglas.Enabled = False
        '
        ArticuloAutorTitulo.Enabled = False
        ArticuloAutorConferencia.Enabled = False
        '
        ListaArticulosTitulo.Enabled = False
        ListaArticulosConferencia.Enabled = False
        '
        ListaAsistentesConferenciaId.Enabled = False
        '
        ListaConferenciasSiglas.Enabled = False
        ListaConferenciasNombre.Enabled = False
        '
        ListaAutoresArticulo.Enabled = False
        '
        InvestigadorAsistenciaNombre.Enabled = False
        InvestigadorAsistenciaApellidos.Enabled = False
        '
        ListaInvestigadoresNombre.Enabled = False
        ListaInvestigadoresApellidos.Enabled = False
        '
        InvestigadoresAutoresNombre.Enabled = False
        InvestigadoresAutoresApellidos.Enabled = False
        '
        IdAutorArticulo.Enabled = False
        IdInvestigadorAutor.Enabled = False
        IdArticulo.Enabled = False
        IdConferenciaArticulo.Enabled = False
        IdConferenciaAsistencia.Enabled = False
        IdInvestigadorAsistente.Enabled = False
        NombreInvestigadorAsistencia.Enabled = False
        ApellidosInvestigadorAsistencia.Enabled = False
        ConferenciaSiglasAsistencia.Enabled = False
        NombreConferenciaAsistencia.Enabled = False
        idInvestigador.Enabled = False
        idConferencia.Enabled = False
    End Sub
    Private Sub Campos_Click(sender As Object, e As EventArgs) Handles Campos.Click
        borrarCampos()
    End Sub
    'investigadores
    Private Sub ListaInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaInvestigadoresId.SelectedIndexChanged
        If ListaInvestigadoresId.SelectedItem() Is Nothing Then
            idInvestigador.Text = ""
            NombreInvestigador.Text = ""
            ApellidosInvestigador.Text = ""
            DespachoInvestigador.Text = ""
            EdificioInvestigador.Text = ""
            DepartamentoInvestigador.Text = ""
            TelefonoInvestigador.Text = ""
            EmailInvestigador.Text = ""
        Else
            Dim investigador As Investigador = DirectCast(ListaInvestigadoresId.SelectedItem(), Investigador)
            idInvestigador.Text = investigador.idInvest
            NombreInvestigador.Text = investigador.nombre
            ApellidosInvestigador.Text = investigador.apellidos
            DespachoInvestigador.Text = investigador.despacho
            EdificioInvestigador.Text = investigador.edificio
            DepartamentoInvestigador.Text = investigador.departamento
            TelefonoInvestigador.Text = investigador.telefono
            EmailInvestigador.Text = investigador.email
        End If
        ListaInvestigadoresNombre.SelectedIndex = ListaInvestigadoresId.SelectedIndex
        ListaInvestigadoresApellidos.SelectedIndex = ListaInvestigadoresId.SelectedIndex
    End Sub
    Private Sub AñadirInvestigador_Click(sender As Object, e As EventArgs) Handles AñadirInvestigador.Click
        If ((NombreInvestigador.Text.Length = 0) Or (ApellidosInvestigador.Text.Length = 0) Or (DespachoInvestigador.Text.Length = 0) Or (EdificioInvestigador.Text.Length = 0) Or (DepartamentoInvestigador.Text.Length = 0) Or (TelefonoInvestigador.Text.Length = 0) Or (EmailInvestigador.Text.Length = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim investigador As New Investigador
                investigador.nombre = NombreInvestigador.Text
                investigador.apellidos = ApellidosInvestigador.Text
                investigador.despacho = DespachoInvestigador.Text
                investigador.edificio = EdificioInvestigador.Text
                investigador.departamento = DepartamentoInvestigador.Text
                investigador.telefono = TelefonoInvestigador.Text
                investigador.email = EmailInvestigador.Text
                Try
                    investigador.leerMaxVal()
                    investigador.insertar()
                Catch ex As Exception
                    investigador.insertar()
                    investigador.leerMax()
                End Try
                cargarInvestigador()
                borrarCampos()
                MsgBox("Añadido correctamente", MsgBoxStyle.Information, AcceptButton)
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try
        End If
    End Sub
    Private Sub ModificarInvestigador_Click(sender As Object, e As EventArgs) Handles ModificarInvestigador.Click
        If ((NombreInvestigador.TextLength = 0) Or (ApellidosInvestigador.TextLength = 0) Or (DespachoInvestigador.TextLength = 0) Or (EdificioInvestigador.TextLength = 0) Or (DepartamentoInvestigador.TextLength = 0) Or (EmailInvestigador.TextLength = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim investigador As New Investigador
                investigador.idInvest = idInvestigador.Text
                investigador.nombre = NombreInvestigador.Text
                investigador.apellidos = ApellidosInvestigador.Text
                investigador.despacho = DespachoInvestigador.Text
                investigador.edificio = EdificioInvestigador.Text
                investigador.departamento = DepartamentoInvestigador.Text
                investigador.telefono = TelefonoInvestigador.Text
                investigador.email = EmailInvestigador.Text
                investigador.actualizar()
                cargarInvestigador()
                borrarCampos()
                MsgBox("Modificado correctamente", MsgBoxStyle.Information, AcceptButton)
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try

        End If
    End Sub
    Private Sub EliminarInvestigador_Click(sender As Object, e As EventArgs) Handles EliminarInvestigador.Click
        If MessageBox.Show("Seguro que quiere eliminar el investigador", "Eliminar Investigador", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim investigador As Investigador
                investigador = ListaInvestigadoresId.SelectedItem
                investigador.borrar()
                cargarInvestigador()
                cargarAsistentes()
                cargarAutor()
                borrarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al borrar el archivo")
            End Try
        End If
    End Sub
    'conferencia
    Private Sub AñadirConferencia_Click(sender As Object, e As EventArgs) Handles AñadirConferencia.Click
        If ((SiglasConferencia.Text.Length = 0) Or (NombreConferencia.Text.Length = 0) Or (LugarConferencia.Text.Length = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim conferencia As New Conferencia
                conferencia.siglas = SiglasConferencia.Text
                conferencia.nombre = NombreConferencia.Text
                conferencia.lugar = LugarConferencia.Text
                conferencia.fecha_inicio = FechaInicio.Value.Date
                conferencia.fecha_fin = FechaFin.Value.Date
                If FechaInicio.Value.Date <= FechaFin.Value.Date Then
                    Try
                        conferencia.leerMaxVal()
                        conferencia.insertar()
                    Catch ex As Exception
                        conferencia.insertar()
                        conferencia.leerMax()
                    End Try
                    cargarConferencia()
                    borrarCampos()
                    MsgBox("Añadido correctamente", MsgBoxStyle.Information, AcceptButton)
                Else
                    MessageBox.Show("Error con el formato de las fechas")
                End If
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try
        End If
    End Sub
    Private Sub ModificarConferencia_Click(sender As Object, e As EventArgs) Handles ModificarConferencia.Click
        If ((SiglasConferencia.Text.Length = 0) Or (NombreConferencia.Text.Length = 0) Or (LugarConferencia.Text.Length = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim conferencia As New Conferencia
                conferencia.idConferencias = idConferencia.Text
                conferencia.siglas = SiglasConferencia.Text
                conferencia.nombre = NombreConferencia.Text
                conferencia.lugar = LugarConferencia.Text
                conferencia.fecha_inicio = FechaInicio.Text
                conferencia.fecha_fin = FechaFin.Text
                conferencia.actualizar()
                cargarConferencia()
                borrarCampos()
                MsgBox("Modificado correctamente", MsgBoxStyle.Information, AcceptButton)
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try
        End If
    End Sub
    Private Sub ListaConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaConferenciasId.SelectedIndexChanged
        If ListaConferenciasId.SelectedItem() Is Nothing Then
            idConferencia.Text = ""
            SiglasConferencia.Text = ""
            NombreConferencia.Text = ""
            LugarConferencia.Text = ""
            FechaInicio.Text = ""
            FechaFin.Text = ""
        Else
            Dim conferecia As Conferencia = DirectCast(ListaConferenciasId.SelectedItem(), Conferencia)
            idConferencia.Text = conferecia.idConferencias
            SiglasConferencia.Text = conferecia.siglas
            NombreConferencia.Text = conferecia.nombre
            LugarConferencia.Text = conferecia.lugar
            FechaInicio.Text = conferecia.fecha_inicio
            FechaFin.Text = conferecia.fecha_fin
        End If
        ListaConferenciasSiglas.SelectedIndex = ListaConferenciasId.SelectedIndex
        ListaConferenciasNombre.SelectedIndex = ListaConferenciasId.SelectedIndex
    End Sub
    Private Sub EliminarConferencia_Click(sender As Object, e As EventArgs) Handles EliminarConferencia.Click
        If MessageBox.Show("Seguro que quiere borrar una conferencia", "Eliminar conferencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim conferencia As Conferencia
                conferencia = ListaConferenciasId.SelectedItem
                conferencia.borrar()
                cargarConferencia()
                cargarAsistentes()
                cargarArticulo()
                borrarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al borrar el archivo")
            End Try
        End If
    End Sub
    'asistencia
    Private Sub ConfirmarAsistencia_Click(sender As Object, e As EventArgs) Handles ConfirmarAsistencia.Click
        If ((IdInvestigadorAsistente.Text.Length = 0) Or (IdConferenciaAsistencia.Text.Length = 0) Or (ConfirmacionCheck.Checked = False)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim asistencia As New Asistente
                asistencia.invest = IdInvestigadorAsistente.Text
                asistencia.conferencia = IdConferenciaAsistencia.Text
                asistencia.insertar()
                cargarInvestigador()
                cargarConferencia()
                cargarAsistentes()
                borrarCampos()
                MsgBox("Añadido correctamente", MsgBoxStyle.Information, AcceptButton)
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
                cargarConferencia()
                cargarInvestigador()

            End Try
        End If
    End Sub
    Private Sub EliminarAsistencia_Click(sender As Object, e As EventArgs) Handles EliminarAsistencia.Click
        If MessageBox.Show("Seguro que quiere eliminar esta asistencia", "Eliminar Asistente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim asistencia As Asistente
                asistencia = ListaAsistentesInvestigadorId.SelectedItem
                asistencia.borrar()
                cargarAsistentes()
                borrarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al borrar el archivo")
            End Try
        End If
    End Sub
    Private Sub ListaAsistentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaAsistentesInvestigadorId.SelectedIndexChanged
        If ListaAsistentesInvestigadorId.SelectedItem() Is Nothing Then
            IdConferenciaAsistencia.Text = ""
            IdInvestigadorAsistente.Text = ""
        Else
            Dim asistencia As Asistente = DirectCast(ListaAsistentesInvestigadorId.SelectedItem(), Asistente)
            IdConferenciaAsistencia.Text = asistencia.conferencia
            IdInvestigadorAsistente.Text = asistencia.invest
        End If
        ListaAsistentesConferenciaId.SelectedIndex = ListaAsistentesInvestigadorId.SelectedIndex
    End Sub
    Private Sub InvestigadoresAsistencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvestigadoresAsistenciaId.SelectedIndexChanged
        If InvestigadoresAsistenciaId.SelectedItem() Is Nothing Then
            IdInvestigadorAsistente.Text = ""
            NombreInvestigadorAsistencia.Text = ""
            ApellidosInvestigadorAsistencia.Text = ""
        Else
            Dim investigador As Investigador = DirectCast(InvestigadoresAsistenciaId.SelectedItem(), Investigador)
            IdInvestigadorAsistente.Text = investigador.idInvest
            NombreInvestigadorAsistencia.Text = investigador.nombre
            ApellidosInvestigadorAsistencia.Text = investigador.apellidos
        End If
        InvestigadorAsistenciaNombre.SelectedIndex = InvestigadoresAsistenciaId.SelectedIndex
        InvestigadorAsistenciaApellidos.SelectedIndex = InvestigadoresAsistenciaId.SelectedIndex
    End Sub
    Private Sub ConferenciaAsistencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConferenciaAsistenciaId.SelectedIndexChanged
        If ConferenciaAsistenciaId.SelectedItem() Is Nothing Then
            IdConferenciaAsistencia.Text = ""
            ConferenciaSiglasAsistencia.Text = ""
            NombreConferenciaAsistencia.Text = ""
        Else
            Dim conferencia As Conferencia = DirectCast(ConferenciaAsistenciaId.SelectedItem(), Conferencia)
            IdConferenciaAsistencia.Text = conferencia.idConferencias
            ConferenciaSiglasAsistencia.Text = conferencia.siglas
            NombreConferenciaAsistencia.Text = conferencia.nombre
        End If
        ConferenciaAsistenciaSiglas.SelectedIndex = ConferenciaAsistenciaId.SelectedIndex
        ConferenciaAsistenciaNombre.SelectedIndex = ConferenciaAsistenciaId.SelectedIndex
    End Sub
    'articulo
    Private Sub ListaArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaArticulosId.SelectedIndexChanged
        If ListaArticulosId.SelectedItem() Is Nothing Then
            IdArticulo.Text = ""
            TituloArticulo.Text = ""
            IdConferenciaArticulo.Text = ""
            Pagina_Inicio_Articulo.Text = ""
            Pagina_Final_Articulo.Text = ""
        Else
            Dim articulo As Articulo = DirectCast(ListaArticulosId.SelectedItem(), Articulo)
            IdArticulo.Text = articulo.idArticulo
            TituloArticulo.Text = articulo.titulo
            IdConferenciaArticulo.Text = articulo.conferencia
            Pagina_Inicio_Articulo.Text = articulo.pag_Inicio
            Pagina_Final_Articulo.Text = articulo.pag_Fin
        End If
        ListaArticulosTitulo.SelectedIndex = ListaArticulosId.SelectedIndex
        ListaArticulosConferencia.SelectedIndex = ListaArticulosId.SelectedIndex
    End Sub
    Private Sub ListaConferenciaArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaConferenciaArticuloId.SelectedIndexChanged
        If ListaConferenciaArticuloId.SelectedItem() Is Nothing Then
            IdConferenciaArticulo.Text = ""
        Else
            Dim conferecia As Conferencia = DirectCast(ListaConferenciaArticuloId.SelectedItem(), Conferencia)
            IdConferenciaArticulo.Text = conferecia.idConferencias
        End If
        ListaConferenciaArticuloSiglas.SelectedIndex = ListaConferenciaArticuloId.SelectedIndex
        ListaConferenciaArticuloNombre.SelectedIndex = ListaConferenciaArticuloId.SelectedIndex
    End Sub
    Private Sub AñadirArticulo_Click(sender As Object, e As EventArgs) Handles AñadirArticulo.Click
        If ((TituloArticulo.Text.Length = 0) Or (IdConferenciaArticulo.Text.Length = 0) Or (Pagina_Inicio_Articulo.Text.Length = 0) Or (Pagina_Final_Articulo.Text.Length = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim articulo As New Articulo
                articulo.titulo = TituloArticulo.Text
                articulo.conferencia = IdConferenciaArticulo.Text
                articulo.pag_Inicio = Pagina_Inicio_Articulo.Text
                articulo.pag_Fin = Pagina_Final_Articulo.Text
                If (Pagina_Inicio_Articulo.Text > Pagina_Final_Articulo.Text) Then
                    MessageBox.Show("Error con el orden de las paginas")

                Else
                    Try
                        articulo.leerMaxVal()
                        articulo.insertar()
                    Catch ex As Exception
                        articulo.insertar()
                        articulo.leerMax()
                    End Try
                    cargarArticulo()
                    borrarCampos()
                    MsgBox("Añadido correctamente", MsgBoxStyle.Information, AcceptButton)
                End If
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try
        End If
    End Sub
    Private Sub ModificarArticulo_Click(sender As Object, e As EventArgs) Handles ModificarArticulo.Click
        If ((TituloArticulo.Text.Length = 0) Or (IdConferenciaArticulo.Text.Length = 0) Or (Pagina_Inicio_Articulo.Text.Length = 0) Or (Pagina_Final_Articulo.Text.Length = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim articulo As New Articulo
                articulo.idArticulo = IdArticulo.Text
                articulo.titulo = TituloArticulo.Text
 
                If (Pagina_Inicio_Articulo.Text > Pagina_Final_Articulo.Text) Then
                    MessageBox.Show("Error con el orden de las paginas")
                Else
                    articulo.pag_Inicio = Pagina_Inicio_Articulo.Text
                    articulo.pag_Fin = Pagina_Final_Articulo.Text
                    articulo.actualizar()
                    cargarArticulo()
                    borrarCampos()
                    MsgBox("Modificado correctamente", MsgBoxStyle.Information, AcceptButton)
                End If
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try

        End If
    End Sub
    Private Sub EliminarArticulo_Click(sender As Object, e As EventArgs) Handles EliminarArticulo.Click
        If MessageBox.Show("Seguro que quiere eliminar el articulo", "Eliminar Articulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim articulo As Articulo
                articulo = ListaArticulosId.SelectedItem
                articulo.borrar()
                cargarArticulo()
                cargarAutor()
                borrarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al borrar el archivo")
            End Try
        End If
    End Sub
    'autores
    Private Sub ListaAutores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaAutoresId.SelectedIndexChanged
        If ListaAutoresId.SelectedItem() Is Nothing Then
            IdAutorArticulo.Text = ""
            IdAutorArticulo.Text = ""
            OrdenInvestigadorAutor.Text = ""
        Else
            Dim autor As Autor = DirectCast(ListaAutoresId.SelectedItem(), Autor)
            IdInvestigadorAutor.Text = autor.invest
            IdAutorArticulo.Text = autor.articulo
            OrdenInvestigadorAutor.Text = autor.orden
        End If
        ListaAutoresArticulo.SelectedIndex = ListaAutoresId.SelectedIndex
    End Sub
    Private Sub ArticuloAutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArticuloAutorId.SelectedIndexChanged
        If ArticuloAutorId.SelectedItem() Is Nothing Then
            IdAutorArticulo.Text = ""
        Else
            Dim articulo As Articulo = DirectCast(ArticuloAutorId.SelectedItem(), Articulo)
            IdAutorArticulo.Text = articulo.idArticulo
        End If
        ArticuloAutorTitulo.SelectedIndex = ArticuloAutorId.SelectedIndex
        ArticuloAutorConferencia.SelectedIndex = ArticuloAutorId.SelectedIndex
    End Sub
    Private Sub InvestigadoresAutores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvestigadoresAutoresId.SelectedIndexChanged
        If InvestigadoresAutoresId.SelectedItem() Is Nothing Then
            IdInvestigadorAutor.Text = ""
        Else
            Dim investigador As Investigador = DirectCast(InvestigadoresAutoresId.SelectedItem(), Investigador)
            IdInvestigadorAutor.Text = investigador.idInvest
        End If
        InvestigadoresAutoresNombre.SelectedIndex = InvestigadoresAutoresId.SelectedIndex
        InvestigadoresAutoresApellidos.SelectedIndex = InvestigadoresAutoresId.SelectedIndex
    End Sub
    Private Sub AñadirAutor_Click(sender As Object, e As EventArgs) Handles AñadirAutor.Click
        If ((IdInvestigadorAutor.Text.Length = 0) Or (IdAutorArticulo.Text.Length = 0) Or (OrdenInvestigadorAutor.Text.Length = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim autor As New Autor
                autor.invest = IdInvestigadorAutor.Text
                autor.articulo = IdAutorArticulo.Text
                autor.orden = OrdenInvestigadorAutor.Text
                autor.insertar()
                cargarAutor()
                borrarCampos()
                MsgBox("Añadido correctamente", MsgBoxStyle.Information, AcceptButton)
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try
        End If
    End Sub
    Private Sub ModificarAutor_Click(sender As Object, e As EventArgs) Handles ModificarAutor.Click
        If ((IdInvestigadorAutor.Text.Length = 0) Or (IdAutorArticulo.Text.Length = 0) Or (OrdenInvestigadorAutor.Text.Length = 0)) Then
            MsgBox("Error en los paramentos  de entrada", MsgBoxStyle.Critical, AcceptButton)
        Else
            Try
                Dim autor As New Autor
                autor.invest = IdInvestigadorAutor.Text
                autor.articulo = IdAutorArticulo.Text
                autor.orden = OrdenInvestigadorAutor.Text
                autor.actualizar()
                cargarAutor()
                borrarCampos()
                MsgBox("Añadido correctamente", MsgBoxStyle.Information, AcceptButton)
            Catch ex As Exception
                MessageBox.Show("Error con los parametros de entrada")
            End Try
        End If
    End Sub
    Private Sub EliminarAutor_Click(sender As Object, e As EventArgs) Handles EliminarAutor.Click
        If MessageBox.Show("Seguro que quiere eliminar el autor", "Eliminar Autor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim autor As Autor
                autor = ListaAutoresId.SelectedItem
                autor.borrar()
                cargarAutor()
                borrarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al borrar el archivo")
            End Try
        End If
    End Sub
    'curr
    Private Sub Curr_Click(sender As Object, e As EventArgs) Handles GenerarCV.Click
        If MessageBox.Show("Va a obtener el curriculum ", "Curriculum", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            CV.Show()
        End If
    End Sub

End Class