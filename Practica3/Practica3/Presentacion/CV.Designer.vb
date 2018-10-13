<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CV
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CV))
        Me.CVTexto = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ListaInvestigadoresApellidos = New System.Windows.Forms.ListBox()
        Me.ListaInvestigadoresNombre = New System.Windows.Forms.ListBox()
        Me.ListaInvestigadoresId = New System.Windows.Forms.ListBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CVTexto
        '
        Me.CVTexto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CVTexto.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CVTexto.Location = New System.Drawing.Point(339, 7)
        Me.CVTexto.Name = "CVTexto"
        Me.CVTexto.Size = New System.Drawing.Size(525, 401)
        Me.CVTexto.TabIndex = 0
        Me.CVTexto.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.ListaInvestigadoresApellidos)
        Me.GroupBox4.Controls.Add(Me.ListaInvestigadoresNombre)
        Me.GroupBox4.Controls.Add(Me.ListaInvestigadoresId)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(321, 326)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Investigadores"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(183, 14)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(49, 13)
        Me.Label40.TabIndex = 19
        Me.Label40.Text = "Apellidos"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Location = New System.Drawing.Point(66, 14)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(44, 13)
        Me.Label39.TabIndex = 19
        Me.Label39.Text = "Nombre"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(7, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(18, 13)
        Me.Label37.TabIndex = 19
        Me.Label37.Text = "ID"
        '
        'ListaInvestigadoresApellidos
        '
        Me.ListaInvestigadoresApellidos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListaInvestigadoresApellidos.FormattingEnabled = True
        Me.ListaInvestigadoresApellidos.Location = New System.Drawing.Point(139, 30)
        Me.ListaInvestigadoresApellidos.Name = "ListaInvestigadoresApellidos"
        Me.ListaInvestigadoresApellidos.Size = New System.Drawing.Size(167, 290)
        Me.ListaInvestigadoresApellidos.TabIndex = 25
        '
        'ListaInvestigadoresNombre
        '
        Me.ListaInvestigadoresNombre.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListaInvestigadoresNombre.FormattingEnabled = True
        Me.ListaInvestigadoresNombre.Location = New System.Drawing.Point(47, 30)
        Me.ListaInvestigadoresNombre.Name = "ListaInvestigadoresNombre"
        Me.ListaInvestigadoresNombre.Size = New System.Drawing.Size(86, 290)
        Me.ListaInvestigadoresNombre.TabIndex = 24
        '
        'ListaInvestigadoresId
        '
        Me.ListaInvestigadoresId.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ListaInvestigadoresId.FormattingEnabled = True
        Me.ListaInvestigadoresId.Location = New System.Drawing.Point(10, 30)
        Me.ListaInvestigadoresId.Name = "ListaInvestigadoresId"
        Me.ListaInvestigadoresId.Size = New System.Drawing.Size(31, 290)
        Me.ListaInvestigadoresId.TabIndex = 1
        '
        'Limpiar
        '
        Me.Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpiar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.Location = New System.Drawing.Point(13, 344)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(320, 64)
        Me.Limpiar.TabIndex = 29
        Me.Limpiar.Text = "Limpiar Campos CV"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'CV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(876, 422)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CVTexto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CV"
        Me.Text = "CV"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CVTexto As RichTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents ListaInvestigadoresApellidos As ListBox
    Friend WithEvents ListaInvestigadoresNombre As ListBox
    Friend WithEvents ListaInvestigadoresId As ListBox
    Friend WithEvents Limpiar As Button
End Class
