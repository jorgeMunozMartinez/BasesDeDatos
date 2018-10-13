Public Class CargarBBDD
    Private Sub RutaBD_Click(sender As Object, e As EventArgs) Handles RutaBD.Click
        OpenFileDialog1.ShowDialog()
        If SalidaRuta.TextLength > 0 Then
            Agente.Ruta = SalidaRuta.Text
            ConectarBD.Enabled = True
        End If
        ConectarBD.Enabled = True
    End Sub

    Private Sub ConectarBD_Click(sender As Object, e As EventArgs) Handles ConectarBD.Click
        EstadoConex.Clear()
        Try
            Agente.getAgente()
            EstadoConex.Text = "Conectado"
            EstadoConex.ForeColor = Color.Green
            ConectarBD.Enabled = False
            RutaBD.Enabled = False
            ModificarValores.Enabled = True
        Catch ex As Exception
            MsgBox("Error Conexion BBDD", MsgBoxStyle.Critical, AcceptButton)
        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        SalidaRuta.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub CargarBBDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SalidaRuta.Enabled = False
        EstadoConex.Enabled = False
        ConectarBD.Enabled = False
        ModificarValores.Enabled = False
        EstadoConex.Text = "Sin conexión"
        EstadoConex.ForeColor = Color.Red
    End Sub

    Private Sub ModificarValores_Click(sender As Object, e As EventArgs) Handles ModificarValores.Click
        OpcionesValores.ShowDialog()
    End Sub
End Class