Imports MySqlConnector

'consultas a la base para el catalogo y las inscripciones del alumno
Public Class ServiceAlumno

    'trae los cursos publicados para el catalogo
    'texto = lo que escribio en buscar, categoriaId = la categoria elegida, 0 es todas
    Public Shared Function Catalogo(texto As String, categoriaId As Integer) As DataTable

        'junto 3 tablas: cursos, categorias para el nombre de la categoria y profesores para el nombre del profe
        'solo muestro los publicados y de profes activos
        'LIKE con % busca el texto en cualquier parte del titulo
        'si categoriaId es 0 la primera parte del OR da verdadero y trae todas
        Dim sql As String = "SELECT c.id, c.titulo, cat.nombre AS categoria, " &
                            "CONCAT(p.nombre, ' ', p.apellido) AS profesor, c.nivel, c.precio, c.descripcion " &
                            "FROM cursos c " &
                            "INNER JOIN categorias cat ON cat.id = c.categoria_id " &
                            "INNER JOIN profesores p ON p.id = c.profesor_id " &
                            "WHERE c.estado = 'publicado' AND p.estado = 'activo' " &
                            "AND c.titulo LIKE @texto " &
                            "AND (@categoria = 0 OR c.categoria_id = @categoria) " &
                            "ORDER BY c.titulo;"

        Dim dt As New DataTable()

        'abro la conexion, Using la cierra sola
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le pongo % adelante y atras para que busque en cualquier parte
                cmd.Parameters.AddWithValue("@texto", "%" & texto & "%")
                cmd.Parameters.AddWithValue("@categoria", categoriaId)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        Return dt

    End Function


    'devuelve True si el alumno ya tiene una inscripcion en ese curso que no fue rechazada
    'si se la rechazaron puede volver a inscribirse
    Public Shared Function YaInscripto(alumnoId As Integer, cursoId As Integer) As Boolean

        Dim sql As String = "SELECT COUNT(*) FROM inscripciones " &
                            "WHERE alumno_id = @alumno AND curso_id = @curso AND estado <> 'rechazada';"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@alumno", alumnoId)
                cmd.Parameters.AddWithValue("@curso", cursoId)

                'ExecuteScalar devuelve un solo valor, la cantidad
                Dim cantidad As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return cantidad > 0
            End Using
        End Using

    End Function


    'crea la inscripcion pendiente de pago y devuelve el numero de orden, ej: ORD-0007
    Public Shared Function Inscribir(alumnoId As Integer, cursoId As Integer, monto As Decimal) As String

        Dim numero As String

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            'paso 1: armo el numero de orden con el id mas alto + 1
            Using cmd As New MySqlCommand("SELECT IFNULL(MAX(id), 0) + 1 FROM inscripciones;", cn)
                Dim siguiente As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                'ToString("0000") lo completa con ceros adelante, 7 queda 0007
                numero = "ORD-" & siguiente.ToString("0000")
            End Using

            'paso 2: guardo la inscripcion, el estado queda pendiente_pago solo porque es el que pone la base
            Dim sql As String = "INSERT INTO inscripciones (alumno_id, curso_id, numero_orden, monto) " &
                                "VALUES (@alumno, @curso, @numero, @monto);"

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@alumno", alumnoId)
                cmd.Parameters.AddWithValue("@curso", cursoId)
                cmd.Parameters.AddWithValue("@numero", numero)
                cmd.Parameters.AddWithValue("@monto", monto)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        'devuelvo el numero para mostrarselo al alumno
        Return numero

    End Function


    'trae las inscripciones del alumno con el nombre del curso, las mas nuevas primero
    Public Shared Function MisCursos(alumnoId As Integer) As DataTable

        Dim sql As String = "SELECT i.id, i.curso_id, i.numero_orden, c.titulo, cat.nombre AS categoria, " &
                            "i.monto, i.estado, i.fecha_solicitud " &
                            "FROM inscripciones i " &
                            "INNER JOIN cursos c ON c.id = i.curso_id " &
                            "INNER JOIN categorias cat ON cat.id = c.categoria_id " &
                            "WHERE i.alumno_id = @alumno " &
                            "ORDER BY i.fecha_solicitud DESC;"

        Dim dt As New DataTable()

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@alumno", alumnoId)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        Return dt

    End Function

End Class
