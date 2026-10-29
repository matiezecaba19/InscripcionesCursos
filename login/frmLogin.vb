Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'se lee conexion.ini y carga CADENA
        ObtenerDatosConexion()

        'si no se pudo leer el archivo cierro el programa
        If CADENA = "" Then
            Me.Close()
        End If

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        'paso 1: verificar que los campos no esten vacios
        If txtDni.Text.Trim() = "" Or txtClave.Text = "" Then
            MessageBox.Show("Complete DNI y Contraseña", "faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'paso 2:buscar dni/ lllamo a service
        Try
            Dim dt As DataTable = ServiceLogin.BuscarPorDni(txtDni.Text.Trim())

            'sino trajo nada osea no trajo filas el dni no exite
            If dt.Rows.Count = 0 Then
                MessageBox.Show("DNI o contraseña incorrectos", "login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'guardo en fila
            Dim fila As DataRow = dt.Rows(0)

            'paso 3 comparar claves hash
            If Not VerificarClave(txtClave.Text, fila("password_hash").ToString()) Then
                'mismo mensaje para no avivar al hacker
                MessageBox.Show("DNI o contraseña incorrectos", "login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'borro la clave y dejo el cursor ahi para que la escriba de nuevo
                txtClave.Clear()
                txtClave.Focus()
                Exit Sub
            End If

            'paso 4: reviso el estado, solo entra si esta activo
            Dim estado As String = fila("estado").ToString()

            'pendiente = se registro pero el admin todavia no lo aprobo
            If estado = "pendiente" Then
                MessageBox.Show("Tu cuenta todavía no fue aprobada por un administrador.", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
                'rechazado = el admin no lo acepto
            ElseIf estado = "rechazado" Then
                MessageBox.Show("Tu registro fue rechazado.", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
                '<> = distinto, si no es activo queda inactivo
            ElseIf estado <> "activo" Then
                MessageBox.Show("Tu cuenta está desactivada.", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'paso 5: entro bien, guardo sus datos en Sesion
            'Convert.ToInt32 pasa el id a numero entero
            Sesion.idUsuario = Convert.ToInt32(fila("id"))
            'el rol sale de la columna 
            Sesion.rolUsuario = fila("rol").ToString()
            Sesion.dniUsuario = txtDni.Text.Trim()
            Sesion.nombreCompleto = fila("nombre").ToString() & " " & fila("apellido").ToString()

            'paso 6: abro el form de su rol
            AbrirFormularioDelRol()

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'abre el form segun el rol que quedo en Sesion
    Private Sub AbrirFormularioDelRol()

        'Form sirve para cualquiera de los 4 forms
        Dim frm As Form

        'elijo cual crear segun el rol
        If Sesion.rolUsuario = "admin" Then
            frm = New frmAdmin()
        ElseIf Sesion.rolUsuario = "profesor" Then
            frm = New frmProfesor()
        ElseIf Sesion.rolUsuario = "cobranza" Then
            frm = New frmCobranza()
        Else
            'si no es ninguno de los 3, es alumno
            frm = New frmAlumno()
        End If

        'escondo el login, si lo cierro se cierra todo el programa
        Me.Hide()

        'ShowDialog se queda esperando aca hasta que cierre el otro form
        frm.ShowDialog()

        'cuando lo cierra, cierro la sesion
        Sesion.CerrarSesion()

        'limpio la clave y vuelvo a mostrar el login
        txtClave.Clear()
        Me.Show()
        txtDni.Focus()

    End Sub

    'en el dni solo dejo escribir numeros
    'KeyPress pasa cada vez que aprieto una tecla en txtDni
    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress

        'si no es numero y no es una tecla tipo borrar...
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'Handled = True hace que se ignore la tecla
            e.Handled = True
        End If

    End Sub


    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        'creo el form nuevo de registro
        Dim frm As New frmRegistro()

        'ShowDialog lo abre arriba del login y no deja tocar el login hasta que se cierre
        frm.ShowDialog()

        'cuando vuelve, dejo el cursor en el dni para que pueda ingresar
        txtDni.Focus()

    End Sub
End Class
