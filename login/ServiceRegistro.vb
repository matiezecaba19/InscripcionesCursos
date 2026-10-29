Imports MySqlConnector

'consultas a la base que usa el registro
Public Class ServiceRegistro

    'recibe el rol en minuscula alumno/profesor/cobranza y devuelve el nombre de la tabla donde se guarda
    Public Shared Function NombreTabla(rol As String) As String

        'Select Case = varios If juntos, segun lo que valga rol
        Select Case rol
            Case "profesor"
                Return "profesores"
            Case "cobranza"
                Return "cobranza"
            Case Else
                'si no es ninguno de los dos, es alumno
                Return "alumnos"
        End Select

    End Function


    ' devuelve True si el dni ya esta en alguna de las 4 tablas
    Public Shared Function ExisteDni(dni As String) As Boolean

        'reuso la busqueda que ya hice para el login y si trajo una fila o mas, el dni ya existe
        Return ServiceLogin.BuscarPorDni(dni).Rows.Count > 0

    End Function

    ' devuelve True si el email ya esta en alguna de las 4 tablas
    Public Shared Function ExisteEmail(email As String) As Boolean
        'cuento cuantas veces aparece el email en las tablas
        'COUNT(*) = cuantas filas hay
        Dim sql As String = "SELECT (SELECT COUNT(*) FROM administradores WHERE email = @email) + " &
                            "(SELECT COUNT(*) FROM profesores WHERE email = @email) + " &
                            "(SELECT COUNT(*) FROM cobranza WHERE email = @email) + " &
                            "(SELECT COUNT(*) FROM alumnos WHERE email = @email);"

        'abro la conexion, Using la cierra sola
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            'preparo el comando con el sql y la conexion
            Using cmd As New MySqlCommand(sql, cn)

                'paso el email al @email
                cmd.Parameters.AddWithValue("@email", email)

                'ExecuteScalar devuelve un solo valor, la suma
                'Convert.ToInt32 lo pasa a numero entero
                Dim cantidad As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                'si aparece 1 vez o mas, ya existe
                Return cantidad > 0
            End Using
        End Using

    End Function



    ' guarda el usuario nuevo en la tabla de su rol
    ' la base le pone 'pendiente y despues el admin lo tiene que aprobar
    Public Shared Sub Registrar(rol As String, nombre As String, apellido As String, dni As String,
                                email As String, hash As String)

        'el nombre de la tabla no se puede pasar con @, por eso lo pego en el sql
        'no es peligroso!!!!!!!!!  porque sale de NombreTabla una lista fija, no lo escribe el usuario
        Dim sql As String = "INSERT INTO " & NombreTabla(rol) & " (nombre, apellido, dni, email, password_hash) " &
                            "VALUES (@nombre, @apellido, @dni, @email, @hash);"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso cada dato a su @ 
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@apellido", apellido)
                cmd.Parameters.AddWithValue("@dni", dni)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@hash", hash)

                'executeNonQuery se usa para insert, update y delete los que cambian datos y no devuelven filas
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
