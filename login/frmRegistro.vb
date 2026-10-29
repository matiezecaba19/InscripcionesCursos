Public Class frmRegistro
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dejo elegido Alumno que es el primero, asi no queda vacio
        cmbRol.SelectedIndex = 0

    End Sub


    Private Sub btnRegistrarme_Click(sender As Object, e As EventArgs) Handles btnRegistrarme.Click

        'paso 1: reviso que no haya nada vacio
        If txtNombre.Text.Trim() = "" Or txtApellido.Text.Trim() = "" Or txtDni.Text.Trim() = "" Or
           txtEmail.Text.Trim() = "" Or txtClave.Text = "" Or txtClave2.Text = "" Then
            MessageBox.Show("Complete todos los campos", "faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'paso 2: el dni tiene que tener 8 numeros
        'Length = cantidad de caracteres que tiene
        If txtDni.Text.Trim().Length <> 8 Then
            MessageBox.Show("El DNI tiene que tener 8 numeros", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'dejo el cursor en el dni para que lo corrija
            txtDni.Focus()
            Exit Sub
        End If

        'paso 3: el email tiene que tener @ y . 
        'Contains = si adentro del texto esta eso
        If Not txtEmail.Text.Contains("@") Or Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("El email no es valido", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Exit Sub
        End If

        'paso 4: las dos claves tienen que ser iguales
        If txtClave.Text <> txtClave2.Text Then
            MessageBox.Show("Las contraseñas no coinciden", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'borro la segunda para que la escriba de nuevo
            txtClave2.Clear()
            txtClave2.Focus()
            Exit Sub
        End If

        'de aca para abajo se usa la base, por eso  Try
        Try
            'paso 5: reviso que el dni no este usado en ninguna tabla
            If ServiceRegistro.ExisteDni(txtDni.Text.Trim()) Then
                MessageBox.Show("Ya existe una cuenta con ese DNI", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDni.Focus()
                Exit Sub
            End If

            'paso 6: reviso que el email no este usado
            If ServiceRegistro.ExisteEmail(txtEmail.Text.Trim()) Then
                MessageBox.Show("Ya existe una cuenta con ese email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Exit Sub
            End If

            'paso 7: encripto la clave 
            'CrearHash esta en el modulo seguridad
            Dim hash As String = CrearHash(txtClave.Text)

            'paso 8: guardo en la tabla del rol
            'ToLower lo pasa a minuscula que es como lo espera NombreTabla
            ServiceRegistro.Registrar(cmbRol.Text.ToLower(), txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                                      txtDni.Text.Trim(), txtEmail.Text.Trim(), hash)

            'paso 9: aviso que quedo pendiente y cierro el form
            MessageBox.Show("Tu cuenta se creo y quedo pendiente. Un administrador la tiene que aprobar para que puedas entrar.",
                            "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'en el dni solo dejo escribir numeros igual que login
    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress

        'si no es numero y no es una tecla tipo borrar...
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'Handled = True hace que se ignore la tecla
            e.Handled = True
        End If

    End Sub

End Class