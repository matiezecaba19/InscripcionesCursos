Imports MySqlConnector
' aca van las consultas de la base que usa login
'shared = iso directo sin hacer new 
Public Class ServiceLogin

    'busca dni y devuelve lo que encuentre
    Public Shared Function BuscarPorDni(dni As String) As DataTable

        'union all junta 4 select en una sola tabla
        Dim sql As String = "SELECT 'admin' AS rol, id, nombre, apellido, password_hash, estado FROM administradores WHERE dni = @dni " &
                            "UNION ALL SELECT 'profesor', id, nombre, apellido, password_hash, estado FROM profesores WHERE dni = @dni " &
                            "UNION ALL SELECT 'cobranza', id, nombre, apellido, password_hash, estado FROM cobranza WHERE dni = @dni " &
                            "UNION ALL SELECT 'alumno', id, nombre, apellido, password_hash, estado FROM alumnos WHERE dni = @dni;"
        'abrir conexion
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            'comando sql y conexion
            Using cmd As New MySqlCommand(sql, cn)

                'paso dni al @dni
                cmd.Parameters.AddWithValue("@dni", dni)

                'ejecuta y lee el resultado
                Using dr As MySqlDataReader = cmd.ExecuteReader()

                    'paso la lectura a la tabla en memoria
                    Dim dt As New DataTable
                    dt.Load(dr)

                    'devueve la tabla
                    Return dt
                End Using
            End Using
        End Using

    End Function

End Class
