Imports System.Data.OleDb
Module dbConexion
    Public IDISelected As Long
    Public IDPSelected As Long
    Public IDASelected As Long

    Public myDA As OleDbDataAdapter
    Public myDataSet As DataSet
    Public Conexion As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=Data Base.mdb")

    Public Function openConexion() As Boolean
        Try 'Intenta conectarte
            Conexion.Open()
            openConexion = True
        Catch ex As Exception 'caso contrario
            MsgBox("Error de conexion hacia la base de datos, consulte con el programador del software para mas informacion o intente nuevamente.", vbCritical, "ERROR")
            Conexion.Close()
            openConexion = False
        End Try
    End Function

    Public Sub closeConexion()
        Conexion.Close() 'Cerramos la conexion con la base de datos.
    End Sub

    Public Sub LoadUpdateDGI(Optional otherForm As Boolean = False)
        '// DATA GRID INQUILINOS!
        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Inquilinos", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Inquilinos")

        If otherForm = False Then
            frmInquilinos.dgInquilinos.DataSource = myDataSet.Tables("Inquilinos").DefaultView
        Else
            frmBuscarInq.dgInquilinos.DataSource = myDataSet.Tables("Inquilinos").DefaultView
        End If

        closeConexion()
    End Sub

    Public Sub LoadUpdateDGP(Optional otherForm As Boolean = False)
        '// DATA GRID Propietarios!
        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Propietarios", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Propietarios")

        If otherForm = False Then
            frmPropietarios.dgPropietarios.DataSource = myDataSet.Tables("Propietarios").DefaultView
        Else
            frmBuscarP.dgPropietarios.DataSource = myDataSet.Tables("Propietarios").DefaultView
        End If

        closeConexion()
    End Sub

    Public Sub LoadUpdateDGA()
        '// DATA GRID Alquileres!
        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Alquileres", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Alquileres")

        frmAlquileres.dgAlquileres.DataSource = myDataSet.Tables("Alquileres").DefaultView

        closeConexion()
    End Sub

    Public Sub AgregarAlquiler()
        If frmAMAl.txtPDNI.Text = "" Then
            MsgBox("¡No ingreso el DNI del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtIDNI.Text = "" Then
            MsgBox("¡No ingreso el DNI del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtCalle.Text = "" Then
            MsgBox("¡No escribio la calle del Alquiler!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtAltura.Text = "" Then
            MsgBox("¡No escribio la altura del Alquiler!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtImpuestos.Text = "" Then
            MsgBox("¡No escribio ninguna informacion sobre los Impuestos!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtRecibo.Text = "" Then
            MsgBox("¡No escribio el valor total que va a tener el recibo!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtHonorarios.Text = "" Then
            MsgBox("¡No escribio el valor de Honorarios!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.fFin.Value.Date = frmAMAl.fInicio.Value.Date Then
            MsgBox("¡No se ingreso una fecha de rescisión de contrato valida!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtEstado.Text = "" Then
            MsgBox("¡No escribio el estado del alquiler! Puede ser: ACTIVO, RESCINDIDO, EN PROCESO DE RENOVACION, etc..", vbCritical, "ERROR")
            Exit Sub
        End If

        If Not openConexion() Then Exit Sub

        '// Agregamos los datos ingresados a la base de datos.
        Dim Add As String = "INSERT INTO Alquileres (PDNI, IDNI, Calle, Altura, Impuestos, Recibo, Honorarios, `Contrato Inicio`, `Contrato Fin`, ESTADO) VALUES  
                                ('" & frmAMAl.txtPDNI.Text & "','" &
                                frmAMAl.txtIDNI.Text & "','" &
                                frmAMAl.txtCalle.Text & "','" &
                                frmAMAl.txtAltura.Text & "','" &
                                frmAMAl.txtImpuestos.Text & "','" &
                                frmAMAl.txtRecibo.Text & "','" &
                                frmAMAl.txtHonorarios.Text & "','" &
                                frmAMAl.fInicio.Value & "','" &
                                frmAMAl.fFin.Value & "','" &
                                frmAMAl.txtEstado.Text & "')"

        '// Guarda
        Dim COMANDO As New OleDbCommand(Add, Conexion)
        Dim DR As OleDbDataReader = COMANDO.ExecuteReader

        '// cerramos el comando
        DR.Close()
        MsgBox("¡Alquiler registrado!", vbInformation, "EXITO")

        closeConexion()

        frmAMAl.Close()
    End Sub

    Public Sub ModificarAlquiler()
        If frmAMAl.txtPDNI.Text = "" Then
            MsgBox("¡No ingreso el DNI del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtIDNI.Text = "" Then
            MsgBox("¡No ingreso el DNI del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtCalle.Text = "" Then
            MsgBox("¡No escribio la calle del Alquiler!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtAltura.Text = "" Then
            MsgBox("¡No escribio la altura del Alquiler!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtImpuestos.Text = "" Then
            MsgBox("¡No escribio ninguna informacion sobre los Impuestos!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtRecibo.Text = "" Then
            MsgBox("¡No escribio el valor total que va a tener el recibo!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtHonorarios.Text = "" Then
            MsgBox("¡No escribio el valor de Honorarios!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.fFin.Value.Date = frmAMAl.fInicio.Value.Date Then
            MsgBox("¡No se ingreso una fecha de rescisión de contrato valida!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMAl.txtEstado.Text = "" Then
            MsgBox("¡No escribio el estado del alquiler! Puede ser: ACTIVO, RESCINDIDO, EN PROCESO DE RENOVACION, etc..", vbCritical, "ERROR")
            Exit Sub
        End If

        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Alquileres WHERE Id  = " & IDASelected & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Alquileres")

        Dim ModifyAndUpdate As String = "UPDATE Alquileres SET PDNI = '" & frmAMAl.txtPDNI.Text &
                                        "',  IDNI = '" & frmAMAl.txtIDNI.Text &
                                        "', Calle = '" & frmAMAl.txtCalle.Text &
                                        "', Altura = '" & frmAMAl.txtAltura.Text &
                                        "', Impuestos = '" & frmAMAl.txtImpuestos.Text &
                                        "', Recibo = '" & frmAMAl.txtRecibo.Text &
                                        "', Honorarios = '" & frmAMAl.txtHonorarios.Text &
                                        "', `Contrato Inicio` = '" & frmAMAl.fInicio.Value &
                                        "', `Contrato Fin` = '" & frmAMAl.fFin.Value &
                                        "', ESTADO = '" & frmAMAl.txtEstado.Text & "' WHERE Id = " & IDASelected & ""

        Dim COMANDO As New OleDbCommand(ModifyAndUpdate, Conexion)
        Dim DR As OleDbDataReader = COMANDO.ExecuteReader

        Dim COMANDOtbostk As New OleDbCommand(ModifyAndUpdate, Conexion)
        Dim ahoratk As OleDbDataReader = COMANDOtbostk.ExecuteReader

        DR.Close()
        closeConexion()

        MsgBox("Datos del alquiler modificados.", vbInformation)
        frmAMAl.Close()
    End Sub

    Public Sub BorrarAlquiler()
        Dim IDBorrar As Integer
        Dim Adaptador As New OleDb.OleDbDataAdapter
        Dim Registro As New DataSet
        Dim Consulta As String
        Dim Lista As New Byte

        IDBorrar = Val(InputBox("Ingrese el ID (numero de alquiler) para eliminar: ", "BORRAR"))

        If Not openConexion() Then Exit Sub

        If IDBorrar <> 0 Then
            'PRIMERO VAMOS A VERIFICAR SI EL REGISTRO EXISTE, POR QUE SI ELIMINAMOS UNO QUE NO EXISTA SE ROMPE TODO...
            Consulta = "SELECT * FROM Alquileres WHERE Id  = " & IDBorrar & ""

            Adaptador = New OleDb.OleDbDataAdapter(Consulta, Conexion)
            Registro = New DataSet
            Adaptador.Fill(Registro, "Alquileres")
            Lista = Registro.Tables("Alquileres").Rows.Count

            If Lista <> 0 Then ' en caso de existir eliminamos.
                Dim borra As String = "DELETE * From Alquileres WHERE Id  = " & IDBorrar & ""
                Dim COMANDOb As New OleDbCommand(borra, Conexion)
                Dim DRb As OleDbDataReader = COMANDOb.ExecuteReader
                MsgBox("Se ha eliminado el Alquiler con el Id: " & IDBorrar, vbInformation)
            Else 'Caso contrario avisamo que no existe y no accionamos nada.
                MsgBox("No se encontro el alquiler " & IDBorrar & " en la tabla, asegurese de ingresar el Id correcto.", vbCritical, "ERROR")
            End If
        End If

        closeConexion()
    End Sub

    Public Sub BuscarObtenerINQ(Id As Long)
        Dim lista As New Integer

        If Not openConexion() Then Exit Sub

        'NyA AS NyA, DNI AS DNI, Motivo AS Motivo, Lote AS Lote, Fecha AS Fecha
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Inquilinos WHERE Id  = " & Id & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Inquilinos")
        lista = myDataSet.Tables("Inquilinos").Rows.Count

        If lista <> 0 Then
            frmAMInq.btnAgregar.Text = "Modificar"
            frmAMInq.txtDNI.Text = myDataSet.Tables("Inquilinos").Rows(0).Item("DNI")
            frmAMInq.txtNombre.Text = myDataSet.Tables("Inquilinos").Rows(0).Item("Nombre")
            frmAMInq.txtApellido.Text = myDataSet.Tables("Inquilinos").Rows(0).Item("Apellido")
            frmAMInq.txtTelefono.Text = myDataSet.Tables("Inquilinos").Rows(0).Item("Telefono")

            frmAMInq.Show()
        Else
            MsgBox("Inquilino inexistente", vbCritical, "ERROR")
        End If

        closeConexion()
    End Sub

    Public Sub BorrarInquilino()
        Dim DNIBorrar As Integer
        Dim Adaptador As New OleDb.OleDbDataAdapter
        Dim Registro As New DataSet
        Dim Consulta As String
        Dim Lista As New Byte

        DNIBorrar = Val(InputBox("Ingrese el DNI del Inquilino a eliminar: ", "BORRAR"))

        If Not openConexion() Then Exit Sub

        If DNIBorrar <> 0 Then
            'PRIMERO VAMOS A VERIFICAR SI EL REGISTRO EXISTE, POR QUE SI ELIMINAMOS UNO QUE NO EXISTA SE ROMPE TODO...
            Consulta = "SELECT * FROM Inquilinos WHERE DNI  = " & DNIBorrar & ""

            Adaptador = New OleDb.OleDbDataAdapter(Consulta, Conexion)
            Registro = New DataSet
            Adaptador.Fill(Registro, "Inquilinos")
            Lista = Registro.Tables("Inquilinos").Rows.Count

            If Lista <> 0 Then ' en caso de existir eliminamos.
                Dim borra As String = "DELETE * From Inquilinos WHERE DNI  = " & DNIBorrar & ""
                Dim COMANDOb As New OleDbCommand(borra, Conexion)
                Dim DRb As OleDbDataReader = COMANDOb.ExecuteReader
                MsgBox("Se ha eliminado el Inquilino con el DNI: " & DNIBorrar, vbInformation)
            Else 'Caso contrario avisamo que no existe y no accionamos nada.
                MsgBox("Inquilino inexistente.", vbCritical, "ERROR")
            End If
        End If

        closeConexion()
    End Sub

    Public Sub AgregarInquilino()
        Dim Adaptador As New OleDb.OleDbDataAdapter
        Dim Registro As New DataSet
        Dim Consulta As String
        Dim Lista As New Byte

        If frmAMInq.txtNombre.Text = "" Then
            MsgBox("¡No escribio el nombre del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMInq.txtApellido.Text = "" Then
            MsgBox("¡No escribio el apellido del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMInq.txtDNI.Text = "" Then
            MsgBox("¡No escribio el DNI del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMInq.txtTelefono.Text = "" Then
            MsgBox("¡No escribio el telefono del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        End If

        If Not openConexion() Then Exit Sub

        Consulta = "SELECT * FROM Inquilinos WHERE DNI = " & Val(frmAMInq.txtDNI.Text) & ""
        Adaptador = New OleDb.OleDbDataAdapter(Consulta, Conexion)
        Registro = New DataSet
        Adaptador.Fill(Registro, "Inquilinos")
        Lista = Registro.Tables("Inquilinos").Rows.Count

        If Lista <> 0 Then 'en caso de existir no creamos nada.
            MsgBox("ERROR: Ya existe el DNI " & Val(frmAMInq.txtDNI.Text) & " de un Inquilino!", vbCritical, "ERROR")
        Else 'caso contrario guardamos.

            'Dim CUIL As String = txtN1.Text & "-" & txtN2.Text & "-" & txtN3.Text

            '// Agregamos los datos ingresados a la base de datos.
            Dim Add As String = "INSERT INTO Inquilinos (Nombre, Apellido, DNI, Telefono) VALUES  
                                ('" & frmAMInq.txtNombre.Text & "','" &
                                frmAMInq.txtApellido.Text & "','" &
                                frmAMInq.txtDNI.Text & "','" &
                                frmAMInq.txtTelefono.Text & "')"

            '// Guarda
            Dim COMANDO As New OleDbCommand(Add, Conexion)
            Dim DR As OleDbDataReader = COMANDO.ExecuteReader

            '// cerramos
            DR.Close()
            MsgBox("¡Inquilino registrado!", vbInformation, "EXITO")
        End If

        closeConexion()
        frmAMInq.Close()
    End Sub

    Public Sub ModificarInquilino()
        'Dim CUIL As String = frmAMPro.txtN1.Text & "-" & frmAMPro.txtN2.Text & "-" & frmAMPro.txtN2.Text

        If frmAMInq.txtNombre.Text = "" Then
            MsgBox("¡No escribio el nombre del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMInq.txtApellido.Text = "" Then
            MsgBox("¡No escribio el apellido del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMInq.txtDNI.Text = "" Then
            MsgBox("¡No escribio el DNI del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMInq.txtTelefono.Text = "" Then
            MsgBox("¡No escribio el telefono del Inquilino!", vbCritical, "ERROR")
            Exit Sub
        End If

        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Inquilinos WHERE Id  = " & IDISelected & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Inquilinos")

        Dim ModifyAndUpdate As String = "UPDATE Inquilinos SET Nombre = '" & frmAMInq.txtNombre.Text &
                                        "',  Apellido = '" & frmAMInq.txtApellido.Text &
                                        "', DNI = '" & frmAMInq.txtDNI.Text &
                                        "', Telefono = '" & frmAMInq.txtTelefono.Text & "' WHERE Id = " & IDISelected & ""
        Dim COMANDO As New OleDbCommand(ModifyAndUpdate, Conexion)
        Dim DR As OleDbDataReader = COMANDO.ExecuteReader

        Dim COMANDOtbostk As New OleDbCommand(ModifyAndUpdate, Conexion)
        Dim ahoratk As OleDbDataReader = COMANDOtbostk.ExecuteReader

        DR.Close()
        closeConexion()

        MsgBox("Datos del inquilino modificados.", vbInformation)
        frmAMInq.Close()
    End Sub

    Public Sub AgregarPropietario()
        Dim Adaptador As New OleDb.OleDbDataAdapter
        Dim Registro As New DataSet
        Dim Consulta As String
        Dim Lista As New Byte

        If frmAMPro.txtNombre.Text = "" Then
            MsgBox("¡No escribio el nombre del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtApellido.Text = "" Then
            MsgBox("¡No escribio el apellido del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtDNI.Text = "" Then
            MsgBox("¡No escribio el DNI del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtTelefono.Text = "" Then
            MsgBox("¡No escribio el telefono del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtN1.Text = "" Or frmAMPro.txtN2.Text = "" Or frmAMPro.txtN3.Text = "" Then
            MsgBox("¡No se escribio el CUIL!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtMail.Text = "" Then
            MsgBox("¡No se escribio el Mail!", vbCritical, "ERROR")
            Exit Sub
        End If

        If Not openConexion() Then Exit Sub

        Consulta = "SELECT * FROM Propietarios WHERE DNI = " & Val(frmAMPro.txtDNI.Text) & ""
        Adaptador = New OleDb.OleDbDataAdapter(Consulta, Conexion)
        Registro = New DataSet
        Adaptador.Fill(Registro, "Propietarios")
        Lista = Registro.Tables("Propietarios").Rows.Count

        If Lista <> 0 Then 'en caso de existir no creamos nada.
            MsgBox("ERROR: Ya existe el DNI " & Val(frmAMPro.txtDNI.Text) & " de un propietario!", vbCritical, "ERROR")
        Else 'caso contrario guardamos.

            Dim CUIL As String = frmAMPro.txtN1.Text & "-" & frmAMPro.txtN2.Text & "-" & frmAMPro.txtN3.Text

            '// Agregamos los datos ingresados a la base de datos.
            Dim Add As String = "INSERT INTO Propietarios (Nombre, Apellido, DNI, Telefono, Cuil, Email) VALUES  
                                ('" & frmAMPro.txtNombre.Text & "','" &
                                frmAMPro.txtApellido.Text & "','" &
                                frmAMPro.txtDNI.Text & "','" &
                                frmAMPro.txtTelefono.Text & "','" &
                                CUIL & "','" &
                                frmAMPro.txtMail.Text & "')"

            '// Guarda
            Dim COMANDO As New OleDbCommand(Add, Conexion)
            Dim DR As OleDbDataReader = COMANDO.ExecuteReader

            '// cerramos
            DR.Close()
            MsgBox("¡Propietario registrado!", vbInformation, "EXITO")
        End If

        closeConexion()
        frmAMPro.Close()
    End Sub

    Public Sub BorrarPropietario()
        Dim DNIBorrar As Integer
        Dim Adaptador As New OleDb.OleDbDataAdapter
        Dim Registro As New DataSet
        Dim Consulta As String
        Dim Lista As New Byte

        DNIBorrar = Val(InputBox("Ingrese el DNI del propietario a eliminar: ", "BORRAR"))

        If Not openConexion() Then Exit Sub

        If DNIBorrar <> 0 Then
            'PRIMERO VAMOS A VERIFICAR SI EL REGISTRO EXISTE, POR QUE SI ELIMINAMOS UNO QUE NO EXISTA SE ROMPE TODO...
            Consulta = "SELECT * FROM Propietarios WHERE DNI  = " & DNIBorrar & ""

            Adaptador = New OleDb.OleDbDataAdapter(Consulta, Conexion)
            Registro = New DataSet
            Adaptador.Fill(Registro, "Propietarios")
            Lista = Registro.Tables("Propietarios").Rows.Count

            If Lista <> 0 Then ' en caso de existir eliminamos.
                Dim borra As String = "DELETE * From Propietarios WHERE DNI  = " & DNIBorrar & ""
                Dim COMANDOb As New OleDbCommand(borra, Conexion)
                Dim DRb As OleDbDataReader = COMANDOb.ExecuteReader
                MsgBox("Se ha eliminado el propietario con el DNI: " & DNIBorrar, vbInformation)
            Else 'Caso contrario avisamo que no existe y no accionamos nada.
                MsgBox("Propietario inexistente.", vbCritical, "ERROR")
            End If
        End If

        closeConexion()
    End Sub

    Public Sub ModificarPropietario()
        If frmAMPro.txtNombre.Text = "" Then
            MsgBox("¡No escribio el nombre del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtApellido.Text = "" Then
            MsgBox("¡No escribio el apellido del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtDNI.Text = "" Then
            MsgBox("¡No escribio el DNI del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtTelefono.Text = "" Then
            MsgBox("¡No escribio el telefono del Propietario!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtN1.Text = "" Or frmAMPro.txtN2.Text = "" Or frmAMPro.txtN3.Text = "" Then
            MsgBox("¡No se escribio el CUIL!", vbCritical, "ERROR")
            Exit Sub
        ElseIf frmAMPro.txtMail.Text = "" Then
            MsgBox("¡No se escribio el Mail!", vbCritical, "ERROR")
            Exit Sub
        End If

        Dim CUIL As String = frmAMPro.txtN1.Text & "-" & frmAMPro.txtN2.Text & "-" & frmAMPro.txtN3.Text

        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Propietarios WHERE Id  = " & IDPSelected & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Propietarios")

        Dim ModifyAndUpdate As String = "UPDATE Propietarios SET Nombre = '" & frmAMPro.txtNombre.Text &
                                        "',  Apellido = '" & frmAMPro.txtApellido.Text &
                                        "', DNI = '" & frmAMPro.txtDNI.Text &
                                        "', Telefono = '" & frmAMPro.txtTelefono.Text &
                                        "', Cuil = '" & CUIL &
                                        "', Email = '" & frmAMPro.txtMail.Text & "' WHERE Id = " & IDPSelected & ""
        Dim COMANDO As New OleDbCommand(ModifyAndUpdate, Conexion)
        Dim DR As OleDbDataReader = COMANDO.ExecuteReader

        Dim COMANDOtbostk As New OleDbCommand(ModifyAndUpdate, Conexion)
        Dim ahoratk As OleDbDataReader = COMANDOtbostk.ExecuteReader

        DR.Close()
        closeConexion()

        MsgBox("Datos del propietario modificados.", vbInformation)
        frmAMPro.Close()
    End Sub

    Public Sub BusquedaDinamicaP(Optional otherForm As Boolean = False)
        If otherForm = False Then
            Dim CARGAR As New OleDbDataAdapter("SELECT * FROM Propietarios WHERE Nombre LIKE '" & frmPropietarios.txtBusqueda.Text & "%'", Conexion)
            Dim DS As New DataSet

            CARGAR.Fill(DS, "Propietarios")
            frmPropietarios.dgPropietarios.DataSource = DS.Tables("Propietarios")
        Else
            Dim CARGAR As New OleDbDataAdapter("SELECT * FROM Propietarios WHERE Nombre LIKE '" & frmBuscarP.txtBusqueda.Text & "%'", Conexion)
            Dim DS As New DataSet

            CARGAR.Fill(DS, "Propietarios")
            frmBuscarP.dgPropietarios.DataSource = DS.Tables("Propietarios")
        End If
    End Sub

    Public Sub BusquedaDinamicaI(Optional otherForm As Boolean = False)
        If otherForm = False Then
            Dim CARGAR As New OleDbDataAdapter("SELECT * FROM Inquilinos WHERE Nombre LIKE '" & frmInquilinos.txtBusqueda.Text & "%'", Conexion)
            Dim DS As New DataSet

            CARGAR.Fill(DS, "Inquilinos")
            frmInquilinos.dgInquilinos.DataSource = DS.Tables("Inquilinos")
        Else
            Dim CARGAR As New OleDbDataAdapter("SELECT * FROM Inquilinos WHERE Nombre LIKE '" & frmBuscarInq.txtBusqueda.Text & "%'", Conexion)
            Dim DS As New DataSet

            CARGAR.Fill(DS, "Inquilinos")
            frmBuscarInq.dgInquilinos.DataSource = DS.Tables("Inquilinos")
        End If
    End Sub

    Public Sub BusquedaDinamicaA()
        Dim CARGAR As New OleDbDataAdapter("SELECT * FROM Alquileres WHERE Calle LIKE '" & frmAlquileres.txtBusqueda.Text & "%'", Conexion)
        Dim DS As New DataSet

        CARGAR.Fill(DS, "Alquileres")
        frmAlquileres.dgAlquileres.DataSource = DS.Tables("Alquileres")
    End Sub

    Public Sub BuscarObtenerPRO(Id As Long)
        Dim lista As New Integer
        Dim CUIL As String

        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Propietarios WHERE Id  = " & Id & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Propietarios")
        lista = myDataSet.Tables("Propietarios").Rows.Count

        If lista <> 0 Then
            frmAMPro.btnAgregar.Text = "Modificar"
            frmAMPro.txtDNI.Text = myDataSet.Tables("Propietarios").Rows(0).Item("DNI")
            frmAMPro.txtNombre.Text = myDataSet.Tables("Propietarios").Rows(0).Item("Nombre")
            frmAMPro.txtApellido.Text = myDataSet.Tables("Propietarios").Rows(0).Item("Apellido")
            frmAMPro.txtMail.Text = myDataSet.Tables("Propietarios").Rows(0).Item("Email")
            frmAMPro.txtTelefono.Text = myDataSet.Tables("Propietarios").Rows(0).Item("Telefono")
            CUIL = myDataSet.Tables("Propietarios").Rows(0).Item("CUIL")

            frmAMPro.txtN1.Text = Mid(CUIL, 1, 2)
            frmAMPro.txtN2.Text = Mid(CUIL, 4, 8)
            frmAMPro.txtN3.Text = Mid(CUIL, 13)

            frmAMPro.Show()
        Else
            MsgBox("Propietario inexistente", vbCritical, "ERROR")
        End If

        closeConexion()
    End Sub

    Public Sub BuscarObtenerALQ(Id As Long)
        Dim lista As New Integer

        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Alquileres WHERE Id  = " & Id & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Alquileres")
        lista = myDataSet.Tables("Alquileres").Rows.Count

        If lista <> 0 Then
            frmAMAl.btnAgregar.Text = "Modificar"
            frmAMAl.btnRecibo.Visible = True
            frmAMAl.btnReciboPropietario.Visible = True

            frmAMAl.txtPDNI.Text = myDataSet.Tables("Alquileres").Rows(0).Item("PDNI")
            frmAMAl.txtIDNI.Text = myDataSet.Tables("Alquileres").Rows(0).Item("IDNI")
            frmAMAl.txtCalle.Text = myDataSet.Tables("Alquileres").Rows(0).Item("Calle")
            frmAMAl.txtAltura.Text = myDataSet.Tables("Alquileres").Rows(0).Item("Altura")
            frmAMAl.txtImpuestos.Text = myDataSet.Tables("Alquileres").Rows(0).Item("Impuestos")
            frmAMAl.txtRecibo.Text = myDataSet.Tables("Alquileres").Rows(0).Item("Recibo")
            frmAMAl.txtHonorarios.Text = myDataSet.Tables("Alquileres").Rows(0).Item("Honorarios")
            frmAMAl.fInicio.Value = myDataSet.Tables("Alquileres").Rows(0).Item("Contrato Inicio")
            frmAMAl.fFin.Value = myDataSet.Tables("Alquileres").Rows(0).Item("Contrato Fin")
            frmAMAl.txtEstado.Text = myDataSet.Tables("Alquileres").Rows(0).Item("ESTADO")

            frmAMAl.Show()
        Else
            MsgBox("Alquiler inexistente...", vbCritical, "ERROR")
        End If

        closeConexion()
    End Sub

    Public Sub BuscarContratosVencidos()
        Dim lista As New Integer
        Dim i As Integer
        Dim j As Integer = 0

        If Not openConexion() Then Exit Sub

        myDA = New OleDbDataAdapter("SELECT * FROM Alquileres WHERE ESTADO LIKE'" & "ACTIVO" & "%'", Conexion)
        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Alquileres")
        lista = myDataSet.Tables("Alquileres").Rows.Count

        Dim ValorDeFecha(0 To lista) As String
        If lista <> 0 Then
            frmAlquileres.dgAlquileres.DataSource = myDataSet.Tables("Alquileres").DefaultView

            For i = 0 To (lista - 1)
                ValorDeFecha(i) = myDataSet.Tables("Alquileres").Rows(i).Item("Contrato Fin")

                If Date.Now >= ValorDeFecha(i) Then
                    frmAlquileres.dgAlquileres.Rows(i).Cells("Contrato Fin").Style.BackColor = Color.Red
                    j = j + 1
                End If
            Next i
        End If

        closeConexion()

        If j <> 0 Then
            MsgBox("Se han detectado " & j & " contratos rescindidos o con la fecha expirada. Recuerde que debera modificar su ESTADO si sigue sin renovarse, o modificar la fecha en caso de que se haya renovado el contrato.", vbInformation, "DETECCION")
        End If
    End Sub

    Public Sub ObtenerDatosIP(PDNI As Long, IDNI As Long)
        Dim lista As New Integer

        If Not openConexion() Then Exit Sub

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Propietarios WHERE DNI  = " & PDNI & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Propietarios")
        lista = myDataSet.Tables("Propietarios").Rows.Count

        If lista <> 0 Then
            frmAMAl.lblPDNI.Text = myDataSet.Tables("Propietarios").Rows(0).Item("Nombre") & " " & myDataSet.Tables("Propietarios").Rows(0).Item("Apellido")
        Else
            MsgBox("Propietario inexistente...", vbCritical, "ERROR")
        End If

        cmd = New OleDbCommand("SELECT * FROM Inquilinos WHERE DNI  = " & IDNI & "", Conexion)
        myDA = New OleDbDataAdapter(cmd)
        builder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()
        myDA.Fill(myDataSet, "Inquilinos")
        lista = myDataSet.Tables("Inquilinos").Rows.Count

        If lista <> 0 Then
            frmAMAl.lblIDNI.Text = myDataSet.Tables("Inquilinos").Rows(0).Item("Nombre") & " " & myDataSet.Tables("Inquilinos").Rows(0).Item("Apellido")
        Else
            MsgBox("Inquilino inexistente...", vbCritical, "ERROR")
        End If

        closeConexion()
    End Sub

    Public Function getNumbers(txt As String, Optional preserveseparators As Boolean = False) As String

        Dim c As String, i As Long, found As Boolean, mystr As String = ""

        If txt = "" Then
            Return ""
        Else
            For i = 0 To txt.Trim().Length - 1
                Try
                    c = txt.Substring(i, 1)
                Catch exp As Exception
                    c = ""
                End Try

                If c.IsNullOrEmpty(c) = False Then
                    If preserveseparators = False Then
                        If IsNumeric(c) = True Then
                            mystr = mystr.Trim + c.Trim
                            found = True
                        End If
                    Else
                        If IsNumeric(c) = True Or c.ToString().Trim = "." Or c.ToString().Trim = "," Then
                            mystr = mystr.Trim + c.Trim
                            found = True
                        End If
                    End If
                End If
            Next

            If found = False Then
                Return ""
            Else
                Return mystr.Trim
            End If

        End If
    End Function

End Module
