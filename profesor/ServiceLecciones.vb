Imports MySqlConnector

'consultas a la base para las lecciones de un curso
Public Class ServiceLecciones

    'trae los temas de un curso, en orden
    Public Shared Function Listar(cursoId As Integer) As DataTable

        Dim sql As String = "SELECT id, orden, titulo FROM lecciones WHERE curso_id = @curso ORDER BY orden;"

        'tabla en memoria donde van a quedar los datos
        Dim dt As New DataTable()

        'abro la conexion, Using la cierra sola
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso el id del curso al @curso
                cmd.Parameters.AddWithValue("@curso", cursoId)

                'ExecuteReader trae las filas y dt.Load las pasa a la tabla
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(dr)
                End Using
            End Using
        End Using

        Return dt

    End Function


    'agrega un tema al final del indice
    Public Shared Sub Insertar(cursoId As Integer, titulo As String)

        'el orden nuevo es el mas alto que haya + 1, asi queda ultimo
        'MAX da el orden mas alto de ese curso
        'IFNULL: si el curso no tiene temas MAX da NULL, lo cambio por 0 y el primero queda 1
        Dim sql As String = "INSERT INTO lecciones (curso_id, titulo, orden) " &
                            "SELECT @curso, @titulo, IFNULL(MAX(orden), 0) + 1 FROM lecciones WHERE curso_id = @curso;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso cada dato a su @
                cmd.Parameters.AddWithValue("@curso", cursoId)
                cmd.Parameters.AddWithValue("@titulo", titulo)

                'ExecuteNonQuery porque cambia datos y no devuelve filas
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'cambia el nombre de un tema
    Public Shared Sub Modificar(id As Integer, titulo As String)

        Dim sql As String = "UPDATE lecciones SET titulo = @titulo WHERE id = @id;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@titulo", titulo)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'borra un tema y corre para arriba los que estaban abajo, asi no queda un hueco en los numeros
    'ej: si borro el 2, el 3 pasa a 2 y el 4 pasa a 3
    Public Shared Sub Eliminar(id As Integer, cursoId As Integer, orden As Integer)

        'son 2 consultas seguidas: primero borro, despues acomodo los numeros
        Dim sql As String = "DELETE FROM lecciones WHERE id = @id; " &
                            "UPDATE lecciones SET orden = orden - 1 WHERE curso_id = @curso AND orden > @orden;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@curso", cursoId)
                cmd.Parameters.AddWithValue("@orden", orden)
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub


    'cambia de lugar dos temas, lo usan los botones subir y bajar
    'al tema A le pongo el orden de B, y al B el orden de A
    Public Shared Sub Intercambiar(idA As Integer, ordenA As Integer, idB As Integer, ordenB As Integer)

        Dim sql As String = "UPDATE lecciones SET orden = @ordenB WHERE id = @idA; " &
                            "UPDATE lecciones SET orden = @ordenA WHERE id = @idB;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idA", idA)
                cmd.Parameters.AddWithValue("@ordenA", ordenA)
                cmd.Parameters.AddWithValue("@idB", idB)
                cmd.Parameters.AddWithValue("@ordenB", ordenB)
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

End Class
