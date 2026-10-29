Imports MySqlConnector

'consultas a la base para el ABM de categorias
Public Class ServiceCategorias

    'trae todas las categorias para mostrarlas en la grilla
    Public Shared Function Listar() As DataTable

        'las ordeno por nombre
        Dim sql As String = "SELECT id, nombre, descripcion FROM categorias ORDER BY nombre;"

        'tabla en memoria donde van a quedar los datos
        Dim dt As New DataTable()

        'abro la conexion, Using la cierra sola
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            'preparo el comando con el sql y la conexion
            Using cmd As New MySqlCommand(sql, cn)

                'ExecuteReader trae las filas y dt.Load las pasa a la tabla
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        'devuelvo la tabla con las categorias
        Return dt

    End Function


    'agrega una categoria nueva
    'si el nombre ya existe la base tira el error 1062 y traducirError lo muestra
    Public Shared Sub Insertar(nombre As String, descripcion As String)

        'INSERT = agregar una fila nueva
        Dim sql As String = "INSERT INTO categorias (nombre, descripcion) VALUES (@nombre, @descripcion);"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso cada dato a su @
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@descripcion", descripcion)

                'ExecuteNonQuery porque cambia datos y no devuelve filas
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'cambia el nombre y la descripcion de la categoria con ese id
    Public Shared Sub Modificar(id As Integer, nombre As String, descripcion As String)

        'UPDATE = modificar, SET = que columnas cambian, WHERE = cual
        Dim sql As String = "UPDATE categorias SET nombre = @nombre, descripcion = @descripcion WHERE id = @id;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso cada dato a su @
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@descripcion", descripcion)
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'borra la categoria con ese id
    'si tiene cursos la base no deja borrarla, tira el error 1451 y traducirError lo muestra
    Public Shared Sub Eliminar(id As Integer)

        'DELETE = borrar, WHERE = cual
        Dim sql As String = "DELETE FROM categorias WHERE id = @id;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso el id a su @
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

End Class
