Imports MySqlConnector

'pestaña Usuarios
Public Class ServiceUsuarios

    'recibe lo que dice el combo cmbTipo y devuelve el nombre de la tabla
    'asi el nombre de la tabla sale de una lista fija y no lo escribe el usuario
    Public Shared Function NombreTabla(tipo As String) As String

        'segun lo que valga tipo
        Select Case tipo
            Case "Profesores"
                Return "profesores"
            Case "Cobranza"
                Return "cobranza"
            Case Else
                'si no es ninguno de los dos, es alumnos
                Return "alumnos"
        End Select

    End Function


    'trae los usuarios de una tabla para mostrarlos en la grilla
    'si soloPendientes es True, trae solo los que estan esperando aprobacion
    Public Shared Function Listar(tabla As String, soloPendientes As Boolean) As DataTable

        'las columnas que quiero ver
        Dim sql As String = "SELECT id, nombre, apellido, dni, email, estado, fecha_creacion FROM " & tabla

        'si tildo ver solo pendientes le agrego el filtro
        If soloPendientes Then
            sql = sql & " WHERE estado = 'pendiente'"
        End If

        'los ordeno por apellido y despues por nombre
        sql = sql & " ORDER BY apellido, nombre;"

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

        'devuelvo la tabla con los usuarios
        Return dt

    End Function


    'cambia el estado de un usuario activo/inactivo/rechazado
    Public Shared Sub CambiarEstado(tabla As String, id As Integer, estado As String)

        'UPDATE = modificar, SET = que columna cambia, WHERE = a quien
        Dim sql As String = "UPDATE " & tabla & " SET estado = @estado WHERE id = @id;"

        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Using cmd As New MySqlCommand(sql, cn)

                'le paso cada dato a su @
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@id", id)

                'ExecuteNonQuery porque cambia datos y no devuelve filas
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

End Class
