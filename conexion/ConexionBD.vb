'importo libreria Mysql - abir mariaDB
Imports MySqlConnector
'importo system,io(Entrada/salida), trae path y file para trabajar cib archivos
Imports System.IO

'module= archivo compartido que se usa en todo el proyecto
Module ConexionDB
    Public CADENA As String = ""

    'sub lle archivo conexion.ini y guarda en cadena
    Public Sub ObtenerDatosConexion()
        Try
            'path.combine une las tres partes poniendo / en medio osea la direcion de donde esta el archivo
            Dim rutaArchivo As String = Path.Combine(AppContext.BaseDirectory, "conexion", "conexion.ini")
            'file.exiast devuelve true si el archivo existe
            If Not File.Exists(rutaArchivo) Then
                'aviso al usuario y muestro la ruta
                MessageBox.Show("mp se encontro el archivo de conexion en: " & vbCrLf & rutaArchivo, "conexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            CADENA = File.ReadAllText(rutaArchivo).Trim()
        Catch ex As Exception
            MessageBox.Show("no se pudo conectar o leer el arhcivo de conexion" & ex.Message, "conexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Module