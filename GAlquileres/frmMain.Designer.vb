<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnAlquileres = New System.Windows.Forms.Button()
        Me.btnInquilinos = New System.Windows.Forms.Button()
        Me.btnPropietarios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAlquileres
        '
        Me.btnAlquileres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlquileres.Location = New System.Drawing.Point(321, 137)
        Me.btnAlquileres.Name = "btnAlquileres"
        Me.btnAlquileres.Size = New System.Drawing.Size(136, 47)
        Me.btnAlquileres.TabIndex = 7
        Me.btnAlquileres.Text = "Alquileres"
        Me.btnAlquileres.UseVisualStyleBackColor = True
        '
        'btnInquilinos
        '
        Me.btnInquilinos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInquilinos.Location = New System.Drawing.Point(179, 137)
        Me.btnInquilinos.Name = "btnInquilinos"
        Me.btnInquilinos.Size = New System.Drawing.Size(136, 47)
        Me.btnInquilinos.TabIndex = 6
        Me.btnInquilinos.Text = "Inquilinos"
        Me.btnInquilinos.UseVisualStyleBackColor = True
        '
        'btnPropietarios
        '
        Me.btnPropietarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPropietarios.Location = New System.Drawing.Point(37, 137)
        Me.btnPropietarios.Name = "btnPropietarios"
        Me.btnPropietarios.Size = New System.Drawing.Size(136, 47)
        Me.btnPropietarios.TabIndex = 5
        Me.btnPropietarios.Text = "Propietarios"
        Me.btnPropietarios.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(477, 119)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 193)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAlquileres)
        Me.Controls.Add(Me.btnInquilinos)
        Me.Controls.Add(Me.btnPropietarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTION DE ALQUILERES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAlquileres As Button
    Friend WithEvents btnInquilinos As Button
    Friend WithEvents btnPropietarios As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
