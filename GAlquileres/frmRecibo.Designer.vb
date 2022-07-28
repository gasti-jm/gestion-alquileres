<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibo))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFechaHoy = New System.Windows.Forms.Label()
        Me.lblInquilino = New System.Windows.Forms.Label()
        Me.lblPropietario = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblFechaVence = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblHonorarios = New System.Windows.Forms.Label()
        Me.lblDescH = New System.Windows.Forms.Label()
        Me.lblFechaVence2 = New System.Windows.Forms.Label()
        Me.lblFechaVence3 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblDescI = New System.Windows.Forms.Label()
        Me.lblImpuestos = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(589, 573)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblFechaHoy
        '
        Me.lblFechaHoy.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHoy.Location = New System.Drawing.Point(467, 88)
        Me.lblFechaHoy.Name = "lblFechaHoy"
        Me.lblFechaHoy.Size = New System.Drawing.Size(69, 15)
        Me.lblFechaHoy.TabIndex = 1
        Me.lblFechaHoy.Text = "00/00/0000"
        Me.lblFechaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInquilino
        '
        Me.lblInquilino.AutoSize = True
        Me.lblInquilino.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInquilino.Location = New System.Drawing.Point(409, 267)
        Me.lblInquilino.Name = "lblInquilino"
        Me.lblInquilino.Size = New System.Drawing.Size(109, 15)
        Me.lblInquilino.TabIndex = 2
        Me.lblInquilino.Text = "Nombre y Apellido"
        Me.lblInquilino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPropietario
        '
        Me.lblPropietario.AutoSize = True
        Me.lblPropietario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropietario.Location = New System.Drawing.Point(120, 267)
        Me.lblPropietario.Name = "lblPropietario"
        Me.lblPropietario.Size = New System.Drawing.Size(109, 15)
        Me.lblPropietario.TabIndex = 3
        Me.lblPropietario.Text = "Nombre y Apellido"
        Me.lblPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(36, 309)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(521, 49)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "POR MANDATO DEL LOCADOR RECIBÍ DEL LOCATARIO LA SUMA DE ........... POR EL ALQUIL" &
    "ER DE UNA PROPIEDAD QUE OCUPA EN LA CALLE ..........."
        '
        'lblFechaVence
        '
        Me.lblFechaVence.AutoSize = True
        Me.lblFechaVence.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVence.Location = New System.Drawing.Point(36, 402)
        Me.lblFechaVence.Name = "lblFechaVence"
        Me.lblFechaVence.Size = New System.Drawing.Size(69, 15)
        Me.lblFechaVence.TabIndex = 5
        Me.lblFechaVence.Text = "00/00/0000"
        Me.lblFechaVence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(440, 539)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(110, 14)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(141, 402)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(106, 15)
        Me.lblDesc.TabIndex = 6
        Me.lblDesc.Text = "Alquiler: mes-año"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal2
        '
        Me.lblTotal2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal2.Location = New System.Drawing.Point(467, 402)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Size = New System.Drawing.Size(90, 15)
        Me.lblTotal2.TabIndex = 7
        Me.lblTotal2.Text = "0"
        Me.lblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(379, 177)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(82, 24)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(467, 177)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 24)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblHonorarios
        '
        Me.lblHonorarios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHonorarios.Location = New System.Drawing.Point(467, 432)
        Me.lblHonorarios.Name = "lblHonorarios"
        Me.lblHonorarios.Size = New System.Drawing.Size(90, 15)
        Me.lblHonorarios.TabIndex = 11
        Me.lblHonorarios.Text = "0"
        Me.lblHonorarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblHonorarios.Visible = False
        '
        'lblDescH
        '
        Me.lblDescH.AutoSize = True
        Me.lblDescH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescH.Location = New System.Drawing.Point(141, 432)
        Me.lblDescH.Name = "lblDescH"
        Me.lblDescH.Size = New System.Drawing.Size(70, 15)
        Me.lblDescH.TabIndex = 12
        Me.lblDescH.Text = "Honorarios"
        Me.lblDescH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDescH.Visible = False
        '
        'lblFechaVence2
        '
        Me.lblFechaVence2.AutoSize = True
        Me.lblFechaVence2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVence2.Location = New System.Drawing.Point(36, 432)
        Me.lblFechaVence2.Name = "lblFechaVence2"
        Me.lblFechaVence2.Size = New System.Drawing.Size(69, 15)
        Me.lblFechaVence2.TabIndex = 13
        Me.lblFechaVence2.Text = "00/00/0000"
        Me.lblFechaVence2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFechaVence2.Visible = False
        '
        'lblFechaVence3
        '
        Me.lblFechaVence3.AutoSize = True
        Me.lblFechaVence3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVence3.Location = New System.Drawing.Point(36, 460)
        Me.lblFechaVence3.Name = "lblFechaVence3"
        Me.lblFechaVence3.Size = New System.Drawing.Size(69, 15)
        Me.lblFechaVence3.TabIndex = 14
        Me.lblFechaVence3.Text = "00/00/0000"
        Me.lblFechaVence3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipo
        '
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(480, 54)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(69, 15)
        Me.lblTipo.TabIndex = 15
        Me.lblTipo.Text = "ORIGINAL"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescI
        '
        Me.lblDescI.AutoSize = True
        Me.lblDescI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescI.Location = New System.Drawing.Point(141, 460)
        Me.lblDescI.Name = "lblDescI"
        Me.lblDescI.Size = New System.Drawing.Size(67, 15)
        Me.lblDescI.TabIndex = 16
        Me.lblDescI.Text = "Impuestos"
        Me.lblDescI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblImpuestos
        '
        Me.lblImpuestos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestos.Location = New System.Drawing.Point(467, 460)
        Me.lblImpuestos.Name = "lblImpuestos"
        Me.lblImpuestos.Size = New System.Drawing.Size(90, 15)
        Me.lblImpuestos.TabIndex = 17
        Me.lblImpuestos.Text = "0"
        Me.lblImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(587, 572)
        Me.Controls.Add(Me.lblImpuestos)
        Me.Controls.Add(Me.lblDescI)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblFechaVence3)
        Me.Controls.Add(Me.lblFechaVence2)
        Me.Controls.Add(Me.lblDescH)
        Me.Controls.Add(Me.lblHonorarios)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTotal2)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFechaVence)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblPropietario)
        Me.Controls.Add(Me.lblInquilino)
        Me.Controls.Add(Me.lblFechaHoy)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecibo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIBO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFechaHoy As Label
    Friend WithEvents lblInquilino As Label
    Friend WithEvents lblPropietario As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblFechaVence As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblTotal2 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblFechaVence3 As Label
    Friend WithEvents lblFechaVence2 As Label
    Friend WithEvents lblDescH As Label
    Friend WithEvents lblHonorarios As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblImpuestos As Label
    Friend WithEvents lblDescI As Label
End Class
