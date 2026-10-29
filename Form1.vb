Imports MySqlConnector
Public Class Form1
    Private Sub btnconexion_Click(sender As Object, e As EventArgs) Handles btnconexion.Click
        Try
            ObtenerDatosConexion()
            'si cadena esta vacia no sigo
            If CADENA = "" Then
                Exit Sub
            End If
            'using cierra la conexion si falla
            Using cn As New MySqlConnection(CADENA)
                'abro conexion
                cn.Open()
                MessageBox.Show("CONEXION EXITOSA")
            End Using
        Catch ex As Exception
            'aca se llama al traductor de errores 
            MessageBox.Show(traducirError(ex), "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class
