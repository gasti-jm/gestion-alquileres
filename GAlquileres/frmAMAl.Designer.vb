<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMAl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPDNI = New System.Windows.Forms.TextBox()
        Me.btnBuscarPDNI = New System.Windows.Forms.Button()
        Me.btnBuscarIDNI = New System.Windows.Forms.Button()
        Me.txtIDNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImpuestos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRecibo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHonorarios = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fFin = New System.Windows.Forms.DateTimePicker()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblPDNI = New System.Windows.Forms.Label()
        Me.lblIDNI = New System.Windows.Forms.Label()
        Me.btnRecibo = New System.Windows.Forms.Button()
        Me.btnReciboPropietario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "DNI del Propietario"
        '
        'txtPDNI
        '
        Me.txtPDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPDNI.Location = New System.Drawing.Point(16, 36)
        Me.txtPDNI.MaxLength = 8
        Me.txtPDNI.Name = "txtPDNI"
        Me.txtPDNI.Size = New System.Drawing.Size(182, 20)
        Me.txtPDNI.TabIndex = 28
        '
        'btnBuscarPDNI
        '
        Me.btnBuscarPDNI.Location = New System.Drawing.Point(204, 36)
        Me.btnBuscarPDNI.Name = "btnBuscarPDNI"
        Me.btnBuscarPDNI.Size = New System.Drawing.Size(61, 20)
        Me.btnBuscarPDNI.TabIndex = 29
        Me.btnBuscarPDNI.Text = "Buscar"
        Me.btnBuscarPDNI.UseVisualStyleBackColor = True
        '
        'btnBuscarIDNI
        '
        Me.btnBuscarIDNI.Location = New System.Drawing.Point(204, 163)
        Me.btnBuscarIDNI.Name = "btnBuscarIDNI"
        Me.btnBuscarIDNI.Size = New System.Drawing.Size(61, 20)
        Me.btnBuscarIDNI.TabIndex = 32
        Me.btnBuscarIDNI.Text = "Buscar"
        Me.btnBuscarIDNI.UseVisualStyleBackColor = True
        '
        'txtIDNI
        '
        Me.txtIDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDNI.Location = New System.Drawing.Point(16, 163)
        Me.txtIDNI.MaxLength = 8
        Me.txtIDNI.Name = "txtIDNI"
        Me.txtIDNI.Size = New System.Drawing.Size(182, 20)
        Me.txtIDNI.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DNI del Inquilino"
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Location = New System.Drawing.Point(294, 36)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(182, 20)
        Me.txtCalle.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(290, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Calle"
        '
        'txtAltura
        '
        Me.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAltura.Location = New System.Drawing.Point(294, 86)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(182, 20)
        Me.txtAltura.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(290, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Altura"
        '
        'txtImpuestos
        '
        Me.txtImpuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImpuestos.Location = New System.Drawing.Point(294, 136)
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.Size = New System.Drawing.Size(182, 20)
        Me.txtImpuestos.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(290, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Impuestos"
        '
        'txtRecibo
        '
        Me.txtRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecibo.Location = New System.Drawing.Point(294, 186)
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(182, 20)
        Me.txtRecibo.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(290, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Monto Alquiler"
        '
        'txtHonorarios
        '
        Me.txtHonorarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHonorarios.Location = New System.Drawing.Point(294, 236)
        Me.txtHonorarios.Name = "txtHonorarios"
        Me.txtHonorarios.Size = New System.Drawing.Size(182, 20)
        Me.txtHonorarios.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(290, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Honorarios"
        '
        'fInicio
        '
        Me.fInicio.Location = New System.Drawing.Point(502, 36)
        Me.fInicio.Name = "fInicio"
        Me.fInicio.Size = New System.Drawing.Size(182, 20)
        Me.fInicio.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(498, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(266, 24)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Fecha de inicio de contrato"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(498, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(300, 24)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Fecha de rescisión de contrato"
        '
        'fFin
        '
        Me.fFin.Location = New System.Drawing.Point(502, 86)
        Me.fFin.Name = "fFin"
        Me.fFin.Size = New System.Drawing.Size(182, 20)
        Me.fFin.TabIndex = 45
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Location = New System.Drawing.Point(502, 136)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(182, 20)
        Me.txtEstado.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(498, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 24)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Estado del alquiler"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(502, 245)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(284, 32)
        Me.btnAgregar.TabIndex = 49
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblPDNI
        '
        Me.lblPDNI.AutoSize = True
        Me.lblPDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDNI.ForeColor = System.Drawing.Color.White
        Me.lblPDNI.Location = New System.Drawing.Point(12, 59)
        Me.lblPDNI.Name = "lblPDNI"
        Me.lblPDNI.Size = New System.Drawing.Size(0, 16)
        Me.lblPDNI.TabIndex = 50
        '
        'lblIDNI
        '
        Me.lblIDNI.AutoSize = True
        Me.lblIDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNI.ForeColor = System.Drawing.Color.White
        Me.lblIDNI.Location = New System.Drawing.Point(12, 186)
        Me.lblIDNI.Name = "lblIDNI"
        Me.lblIDNI.Size = New System.Drawing.Size(0, 16)
        Me.lblIDNI.TabIndex = 51
        '
        'btnRecibo
        '
        Me.btnRecibo.Location = New System.Drawing.Point(502, 207)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Size = New System.Drawing.Size(284, 32)
        Me.btnRecibo.TabIndex = 52
        Me.btnRecibo.Text = "Imprimir Recibo Inquilino"
        Me.btnRecibo.UseVisualStyleBackColor = True
        Me.btnRecibo.Visible = False
        '
        'btnReciboPropietario
        '
        Me.btnReciboPropietario.Location = New System.Drawing.Point(502, 169)
        Me.btnReciboPropietario.Name = "btnReciboPropietario"
        Me.btnReciboPropietario.Size = New System.Drawing.Size(284, 32)
        Me.btnReciboPropietario.TabIndex = 53
        Me.btnReciboPropietario.Text = "Imprimir Recibo Propietario"
        Me.btnReciboPropietario.UseVisualStyleBackColor = True
        Me.btnReciboPropietario.Visible = False
        '
        'frmAMAl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 285)
        Me.Controls.Add(Me.btnReciboPropietario)
        Me.Controls.Add(Me.btnRecibo)
        Me.Controls.Add(Me.lblIDNI)
        Me.Controls.Add(Me.lblPDNI)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.fFin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.fInicio)
        Me.Controls.Add(Me.txtHonorarios)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRecibo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtImpuestos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscarIDNI)
        Me.Controls.Add(Me.txtIDNI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscarPDNI)
        Me.Controls.Add(Me.txtPDNI)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAMAl"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALQUILER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPDNI As TextBox
    Friend WithEvents btnBuscarPDNI As Button
    Friend WithEvents btnBuscarIDNI As Button
    Friend WithEvents txtIDNI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtImpuestos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRecibo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHonorarios As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fInicio As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fFin As DateTimePicker
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblPDNI As Label
    Friend WithEvents lblIDNI As Label
    Friend WithEvents btnRecibo As Button
    Friend WithEvents btnReciboPropietario As Button
End Class
