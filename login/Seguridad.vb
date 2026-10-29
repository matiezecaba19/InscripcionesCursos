'modulo para las contraseñas, BCrypt
'2 funciones
'CRearHash para registro / VerificarClave para login
Module Seguridad

    'recibe contraseña y devuelve hash
    Public Function CrearHash(clave As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(clave)
    End Function

    'compara clave escrita con bd
    Public Function VerificarClave(clave As String, hashDB As String) As Boolean
        Try
            Return BCrypt.Net.BCrypt.Verify(clave, hashDB)

        Catch ex As BCrypt.Net.SaltParseException

            'clave incorrecta
            Return False

        End Try
    End Function
End Module
