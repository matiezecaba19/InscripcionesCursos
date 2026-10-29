Imports MySqlConnector

'consultas a la base para que cobranza acepte o rechace los pagos
Public Class ServiceCobranza

    'trae las inscripciones con los datos del alumno y del curso
    'estado = pendiente_pago, aceptada o rechazada, si viene vacio trae todas
    Public Shared Function Listar(estado As String) As DataTable

        'junto inscripciones con alumnos y cursos para mostrar nombres en vez de numeros
        'cobranza va con LEFT JOIN porque las pendientes todavia no tienen quien las autorizo
        'LEFT JOIN trae la inscripcion igual aunque no encuentre a nadie de cobranza
        Dim sql As String = "SELECT i.id, i.numero_orden, CONCAT(a.nombre, ' ', a.apellido) AS alumno, a.dni, " &
                            "c.titulo AS curso, i.monto, i.estado, i.fecha_solicitud, " &
                            "CONCAT(co.nombre, ' ', co.apellido) AS autorizo " &
                            "FROM inscripciones i " &
                            "INNER JOIN alumnos a ON a.id = i.alumno_id " &
                            "INNER JOIN cursos c ON c.id = i.curso_id " &
                            "LEFT JOIN cobranza co ON co.id = i.autorizado_por " &
                            "WHERE (@estado = '' OR i.estado = @estado) " &
                            "ORDER BY i.fecha_solicitud;"

        Dim dt As New DataTable()

        'abro la conexion, Using la cierra sola
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'si estado viene vacio la primera parte del OR da verdadero y trae todas
                cmd.Parameters.AddWithValue("@estado", estado)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        Return dt

    End Function


    'acepta o rechaza una inscripcion y guarda quien de cobranza lo hizo
    'solo cambia si esta pendiente, asi no se acepta dos veces
    'devuelve True si la cambio
    Public Shared Function CambiarEstado(id As Integer, estado As String, cobranzaId As Integer) As Boolean

        Dim sql As String = "UPDATE inscripciones SET estado = @estado, autorizado_por = @cobranza " &
                            "WHERE id = @id AND estado = 'pendiente_pago';"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@cobranza", cobranzaId)
                cmd.Parameters.AddWithValue("@id", id)

                'ExecuteNonQuery devuelve cuantas filas cambio, si es 0 es que ya no estaba pendiente
                Dim filas As Integer = cmd.ExecuteNonQuery()
                Return filas > 0
            End Using
        End Using

    End Function

End Class
