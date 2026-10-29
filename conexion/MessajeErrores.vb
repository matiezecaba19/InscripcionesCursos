Imports MySqlConnector

'la idea de este modulo es traducir los errores para los usuarios comunes y hacerme la vida mas facil al hacer exepciones con errores :v
Module MessajeErrores
    'recibe ex: el error que atrapo el catch
    Public Function traducirError(ex As Exception) As String
        'typeof is pregunta que tipo de de error es
        'si es mysql, el error es de mariadb y trae codigo de error
        If TypeOf ex Is MySqlException Then

            'ctype convierte el ex al tipo mysqlexeption para leer su codigo. exepcion comun no tiene codigo, mysqlexeption si
            Dim exBD As MySqlException = CType(ex, MySqlException)

            'segun el numero el mensaje que se devuelve es
            Select Case exBD.Number
                Case 1042
                    'mariaDB apagado o puerto mal
                    Return "no se pudo conectar con el servidor de base de datos" & vbCrLf & "Verificar que mariaDB este encendido o que el Puerto de conexion sea correcto"

                Case 1045
                    'el servidor rechazo usuario o clave
                    Return "Usuario o Contraseña incorrecta" & vbCrLf & "resivar userID o Password en conexion.ini"

                Case 1049
                    'no existe en el servidor
                    Return "No existe la base de datos indicada en conexion.ini." & vbCrLf & "Revise el valor de Database."

                Case 1062
                    'se intento guardar un dato que ya existe y no se puede repetir 
                    Return "Ese dato ya está registrado y no se puede repetir."

                Case 1451
                    'se intento borrar algo que depende de otra tabla
                    Return "No se puede eliminar porque hay otros datos que dependen de este registro."

                Case Else
                    'cualquier otro error muestro el codigo y el texto tecnico
                    Return "Error de base de datos (código " & exBD.Number & "):" & vbCrLf & exBD.Message

            End Select
        End If
        'si el error no es de Mariadb 
        Return "ocurrio un error inesperado" & vbCrLf & ex.Message
    End Function
End Module
