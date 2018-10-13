<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarBBDD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargarBBDD))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConectarBD = New System.Windows.Forms.Button()
        Me.EstadoConex = New System.Windows.Forms.RichTextBox()
        Me.RutaBD = New System.Windows.Forms.Button()
        Me.SalidaRuta = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ModificarValores = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.ConectarBD)
        Me.GroupBox1.Controls.Add(Me.EstadoConex)
        Me.GroupBox1.Controls.Add(Me.RutaBD)
        Me.GroupBox1.Controls.Add(Me.SalidaRuta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 187)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga Base de Datos"
        '
        'ConectarBD
        '
        Me.ConectarBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConectarBD.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConectarBD.Location = New System.Drawing.Point(24, 112)
        Me.ConectarBD.Name = "ConectarBD"
        Me.ConectarBD.Size = New System.Drawing.Size(93, 50)
        Me.ConectarBD.TabIndex = 16
        Me.ConectarBD.Text = "Conectar BD"
        Me.ConectarBD.UseVisualStyleBackColor = True
        '
        'EstadoConex
        '
        Me.EstadoConex.Location = New System.Drawing.Point(144, 112)
        Me.EstadoConex.Name = "EstadoConex"
        Me.EstadoConex.Size = New System.Drawing.Size(123, 49)
        Me.EstadoConex.TabIndex = 13
        Me.EstadoConex.Text = ""
        '
        'RutaBD
        '
        Me.RutaBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RutaBD.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RutaBD.Location = New System.Drawing.Point(24, 38)
        Me.RutaBD.Name = "RutaBD"
        Me.RutaBD.Size = New System.Drawing.Size(93, 50)
        Me.RutaBD.TabIndex = 15
        Me.RutaBD.Text = "Ruta BD"
        Me.RutaBD.UseVisualStyleBackColor = True
        '
        'SalidaRuta
        '
        Me.SalidaRuta.Location = New System.Drawing.Point(144, 38)
        Me.SalidaRuta.Name = "SalidaRuta"
        Me.SalidaRuta.Size = New System.Drawing.Size(398, 56)
        Me.SalidaRuta.TabIndex = 12
        Me.SalidaRuta.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ModificarValores
        '
        Me.ModificarValores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModificarValores.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarValores.Location = New System.Drawing.Point(208, 205)
        Me.ModificarValores.Name = "ModificarValores"
        Me.ModificarValores.Size = New System.Drawing.Size(150, 65)
        Me.ModificarValores.TabIndex = 0
        Me.ModificarValores.Text = "Modificar Valores"
        Me.ModificarValores.UseVisualStyleBackColor = True
        '
        'CargarBBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(575, 276)
        Me.Controls.Add(Me.ModificarValores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CargarBBDD"
        Me.Text = "CargarBBDD"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ConectarBD As Button
    Friend WithEvents EstadoConex As RichTextBox
    Friend WithEvents RutaBD As Button
    Friend WithEvents SalidaRuta As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ModificarValores As Button
End Class
