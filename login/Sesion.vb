'modulo para guardar los datos del usuario que inicio sesion, cargamos con el login y se vacian al cerrar sesion
Module Sesion
    'id del usuario, 0 = vacio
    Public idUsuario As Integer = 0

    'rol usuario: admin/profesor/cobranza/alumno
    'se utiliza para que el form sepa que abrir despues del login
    Public rolUsuario As String = ""

    'Dni usuario
    Public dniUsuario As String = ""

    'nombre completo 
    Public nombreCompleto As String = ""

    'subrutina que resetea valores al cerrar la sesion
    Public Sub CerrarSesion()
        idUsuario = 0
        rolUsuario = ""
        dniUsuario = ""
        nombreCompleto = ""
    End Sub

End Module
