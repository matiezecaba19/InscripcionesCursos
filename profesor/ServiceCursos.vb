Imports MySqlConnector

'consultas a la base para el ABM de cursos del profesor
Public Class ServiceCursos

    'trae las categorias para llenar el combo cmbCategoria
    Public Shared Function ListarCategorias() As DataTable

        'solo necesito el id para guardar y el nombre para mostrar
        Dim sql As String = "SELECT id, nombre FROM categorias ORDER BY nombre;"

        'tabla en memoria donde van a quedar los datos
        Dim dt As New DataTable()

        'abro la conexion, Using la cierra sola
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'ExecuteReader trae las filas y dt.Load las pasa a la tabla
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        Return dt

    End Function


    'traigo solo los cursos del profesor que entro
    Public Shared Function ListarDelProfesor(profesorId As Integer) As DataTable

        'de cursos saco los datos y de categorias el nombre
        Dim sql As String = "SELECT c.id, c.titulo, cat.nombre AS categoria, c.categoria_id, c.precio, " &
                            "c.nivel, c.estado, c.descripcion " &
                            "FROM cursos c INNER JOIN categorias cat ON cat.id = c.categoria_id " &
                            "WHERE c.profesor_id = @profesor " &
                            "ORDER BY c.titulo;"

        Dim dt As New DataTable()

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'paso el id del profesor al @profesor
                cmd.Parameters.AddWithValue("@profesor", profesorId)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        Return dt

    End Function


    'creo un curso nuevo a nombre del profesor
    Public Shared Sub Insertar(profesorId As Integer, titulo As String, categoriaId As Integer, precio As Decimal,
                               nivel As String, estado As String, descripcion As String)

        'agrego una fila nueva
        Dim sql As String = "INSERT INTO cursos (titulo, descripcion, profesor_id, categoria_id, precio, estado, nivel) " &
                            "VALUES (@titulo, @descripcion, @profesor, @categoria, @precio, @estado, @nivel);"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso cada dato a su @
                cmd.Parameters.AddWithValue("@titulo", titulo)
                cmd.Parameters.AddWithValue("@descripcion", descripcion)
                cmd.Parameters.AddWithValue("@profesor", profesorId)
                cmd.Parameters.AddWithValue("@categoria", categoriaId)
                cmd.Parameters.AddWithValue("@precio", precio)
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@nivel", nivel)

                'ExecuteNonQuery cambia datos y no devuelve filas
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'cambia los datos de un curso
    'en el WHERE va tambien el profesor, asi un profe no puede tocar el curso de otro
    Public Shared Sub Modificar(id As Integer, profesorId As Integer, titulo As String, categoriaId As Integer,
                                precio As Decimal, nivel As String, estado As String, descripcion As String)

        'UPDATE = modificar, SET = que columnas cambian, WHERE = cual
        Dim sql As String = "UPDATE cursos SET titulo = @titulo, descripcion = @descripcion, categoria_id = @categoria, " &
                            "precio = @precio, estado = @estado, nivel = @nivel " &
                            "WHERE id = @id AND profesor_id = @profesor;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso cada dato a su @
                cmd.Parameters.AddWithValue("@titulo", titulo)
                cmd.Parameters.AddWithValue("@descripcion", descripcion)
                cmd.Parameters.AddWithValue("@categoria", categoriaId)
                cmd.Parameters.AddWithValue("@precio", precio)
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@nivel", nivel)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@profesor", profesorId)

                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'borra un curso del profesor
    'si tiene alumnos inscriptos la base no deja, tira el error 1451 y traducirError lo muestra
    'si tiene lecciones la base las borra solas junto con el curso
    Public Shared Sub Eliminar(id As Integer, profesorId As Integer)

        'DELETE = borrar, tambien con el profesor en el WHERE
        Dim sql As String = "DELETE FROM cursos WHERE id = @id AND profesor_id = @profesor;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@profesor", profesorId)

                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    'guarda la portada del curso, si datos es Nothing la borra
    Public Shared Sub GuardarPortada(id As Integer, profesorId As Integer, datos As Byte())

        Dim sql As String = "UPDATE cursos SET portada = @portada WHERE id = @id AND profesor_id = @profesor;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                'si no hay imagen mando DBNull que en la base es NULL
                If datos Is Nothing Then
                    cmd.Parameters.AddWithValue("@portada", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@portada", datos)
                End If
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@profesor", profesorId)
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'trae la portada de un curso, devuelve Nothing si no tiene
    Public Shared Function TraerPortada(id As Integer) As Byte()

        Dim sql As String = "SELECT portada FROM cursos WHERE id = @id;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim resultado As Object = cmd.ExecuteScalar()

                'si no encontro el curso o la portada esta vacia devuelvo Nothing
                If resultado Is Nothing OrElse IsDBNull(resultado) Then
                    Return Nothing
                End If

                'CType lo convierte a arreglo de bytes
                Return CType(resultado, Byte())
            End Using
        End Using

    End Function

End Class
