Imports MySqlConnector

'consulta para el reporte de cursos del admin
Public Class ServiceReporte

    'trae cada curso con su profe, cuantos alumnos aceptados tiene y cuanto se recaudo
    Public Shared Function Cursos() As DataTable

        'LEFT JOIN con inscripciones asi aparecen tambien los cursos sin alumnos
        'solo cuento las aceptadas, y SUM suma los montos, IFNULL pone 0 si no hay ninguna
        Dim sql As String = "SELECT c.titulo AS curso, CONCAT(p.nombre, ' ', p.apellido) AS profesor, c.estado, " &
                            "COUNT(i.id) AS inscriptos, IFNULL(SUM(i.monto), 0) AS recaudado " &
                            "FROM cursos c " &
                            "INNER JOIN profesores p ON p.id = c.profesor_id " &
                            "LEFT JOIN inscripciones i ON i.curso_id = c.id AND i.estado = 'aceptada' " &
                            "GROUP BY c.id, c.titulo, p.nombre, p.apellido, c.estado " &
                            "ORDER BY c.titulo;"

        Dim dt As New DataTable()

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        Return dt

    End Function

End Class
