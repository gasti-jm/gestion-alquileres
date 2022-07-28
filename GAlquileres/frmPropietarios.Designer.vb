<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropietarios
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
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgPropietarios = New System.Windows.Forms.DataGridView()
        CType(Me.dgPropietarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(182, 453)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(174, 31)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Borrar propietario"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Escriba el nombre del propietario para buscar:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Location = New System.Drawing.Point(12, 422)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(774, 20)
        Me.txtBusqueda.TabIndex = 10
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(624, 453)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(164, 31)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 453)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(164, 31)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar un nuevo propietario"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgPropietarios
        '
        Me.dgPropietarios.AllowUserToAddRows = False
        Me.dgPropietarios.AllowUserToDeleteRows = False
        Me.dgPropietarios.AllowUserToResizeColumns = False
        Me.dgPropietarios.AllowUserToResizeRows = False
        Me.dgPropietarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPropietarios.Location = New System.Drawing.Point(12, 12)
        Me.dgPropietarios.MultiSelect = False
        Me.dgPropietarios.Name = "dgPropietarios"
        Me.dgPropietarios.ReadOnly = True
        Me.dgPropietarios.Size = New System.Drawing.Size(774, 391)
        Me.dgPropietarios.TabIndex = 13
        '
        'frmPropietarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.Controls.Add(Me.dgPropietarios)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPropietarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propietarios"
        CType(Me.dgPropietarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgPropietarios As DataGridView
End Class
