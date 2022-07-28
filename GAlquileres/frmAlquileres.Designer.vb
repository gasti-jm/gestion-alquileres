<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlquileres
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
        Me.dgAlquileres = New System.Windows.Forms.DataGridView()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.DetectarContratos = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgAlquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAlquileres
        '
        Me.dgAlquileres.AllowUserToAddRows = False
        Me.dgAlquileres.AllowUserToDeleteRows = False
        Me.dgAlquileres.AllowUserToResizeColumns = False
        Me.dgAlquileres.AllowUserToResizeRows = False
        Me.dgAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAlquileres.Location = New System.Drawing.Point(12, 12)
        Me.dgAlquileres.MultiSelect = False
        Me.dgAlquileres.Name = "dgAlquileres"
        Me.dgAlquileres.ReadOnly = True
        Me.dgAlquileres.Size = New System.Drawing.Size(1240, 559)
        Me.dgAlquileres.TabIndex = 19
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(182, 621)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(174, 31)
        Me.btnBorrar.TabIndex = 18
        Me.btnBorrar.Text = "Borrar Alquiler"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 574)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Escriba la calle del alquiler para buscar:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Location = New System.Drawing.Point(12, 590)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(1240, 20)
        Me.txtBusqueda.TabIndex = 16
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(1088, 621)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(164, 31)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 621)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(164, 31)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar un nuevo alquiler"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'DetectarContratos
        '
        Me.DetectarContratos.Enabled = True
        Me.DetectarContratos.Interval = 150000
        '
        'frmAlquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.dgAlquileres)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlquileres"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALQUILERES"
        CType(Me.dgAlquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgAlquileres As DataGridView
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DetectarContratos As Timer
End Class
