Public Class frmAlumno
    'form del alumno, aca ve el catalogo, se inscribe y ve sus cursos

    'curso elegido en el catalogo, 0 es que no eligio ninguno
    Private idCursoElegido As Integer = 0
    Private tituloElegido As String = ""
    Private precioElegido As Decimal = 0


    'al abrir el form
    Private Sub frmAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'saludo con el nombre que guardo el login en Sesion
        lbBienvenida.Text = "Bienvenido/a, " & Sesion.nombreCompleto

        Try
            'traigo las categorias y le agrego arriba la opcion Todas con id 0
            Dim dt As DataTable = ServiceCursos.ListarCategorias()
            Dim filaTodas As DataRow = dt.NewRow()
            filaTodas("id") = 0
            filaTodas("nombre") = "Todas"
            dt.Rows.InsertAt(filaTodas, 0)

            'DisplayMember es lo que se ve y ValueMember es el id que uso por dentro
            cmbCategoria.DisplayMember = "nombre"
            cmbCategoria.ValueMember = "id"
            cmbCategoria.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'muestro todo el catalogo de entrada
        Buscar()

    End Sub


    'pestaña catalogo

    'llena la grilla del catalogo con lo que escribio y la categoria elegida
    Private Sub Buscar()

        Try
            'si no hay categoria elegida uso 0 que es todas
            Dim categoriaId As Integer = 0
            If cmbCategoria.SelectedValue IsNot Nothing Then
                categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue)
            End If

            dgvCatalogo.DataSource = ServiceAlumno.Catalogo(txtBuscar.Text.Trim(), categoriaId)

            'el id y la descripcion no van en la grilla, la descripcion se ve en el detalle
            dgvCatalogo.Columns("id").Visible = False
            dgvCatalogo.Columns("descripcion").Visible = False

            'nombres lindos para las columnas
            dgvCatalogo.Columns("titulo").HeaderText = "Curso"
            dgvCatalogo.Columns("categoria").HeaderText = "Categoría"
            dgvCatalogo.Columns("profesor").HeaderText = "Profesor"
            dgvCatalogo.Columns("nivel").HeaderText = "Nivel"
            dgvCatalogo.Columns("precio").HeaderText = "Precio $"
            dgvCatalogo.Columns("precio").DefaultCellStyle.Format = "N2"

            'como cambio la lista, borro lo que estaba elegido
            idCursoElegido = 0
            picPortada.Image = Nothing
            dgvCatalogo.ClearSelection()
            txtDetalle.Text = "Hacé clic en un curso para ver de qué trata y sus temas."

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'boton buscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    'si aprieta Enter en la caja de buscar tambien busca
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar()
            'SuppressKeyPress evita el ruidito de windows al apretar Enter
            e.SuppressKeyPress = True
        End If
    End Sub

    'cuando hace clic en un curso, muestro el detalle y los temas a la derecha
    Private Sub dgvCatalogo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalogo.CellClick

        'si hizo clic en el titulo de la columna no hago nada
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim fila As DataGridViewRow = dgvCatalogo.Rows(e.RowIndex)

        'guardo lo que necesito para inscribirlo
        idCursoElegido = Convert.ToInt32(fila.Cells("id").Value)
        tituloElegido = fila.Cells("titulo").Value.ToString()
        precioElegido = Convert.ToDecimal(fila.Cells("precio").Value)

        Try
            'armo el texto del detalle linea por linea, vbCrLf es un enter
            Dim texto As String = tituloElegido & vbCrLf & vbCrLf
            texto = texto & "Profesor: " & fila.Cells("profesor").Value.ToString() & vbCrLf
            texto = texto & "Categoría: " & fila.Cells("categoria").Value.ToString() & vbCrLf
            texto = texto & "Nivel: " & fila.Cells("nivel").Value.ToString() & vbCrLf
            texto = texto & "Precio: $" & precioElegido.ToString("N2") & vbCrLf & vbCrLf
            texto = texto & fila.Cells("descripcion").Value.ToString() & vbCrLf & vbCrLf

            'agrego los temas del curso, reuso el service de lecciones del profe
            Dim temas As DataTable = ServiceLecciones.Listar(idCursoElegido)
            texto = texto & "Temas del curso:" & vbCrLf

            If temas.Rows.Count = 0 Then
                texto = texto & "Todavía no tiene temas cargados."
            Else
                'recorro los temas y agrego cada uno con su numero
                For Each tema As DataRow In temas.Rows
                    texto = texto & tema("orden").ToString() & ". " & tema("titulo").ToString() & vbCrLf
                Next
            End If

            txtDetalle.Text = texto

            'muestro la portada si tiene, reuso el service de cursos del profe
            picPortada.Image = Nothing
            Dim datos() As Byte = ServiceCursos.TraerPortada(idCursoElegido)
            If datos IsNot Nothing Then
                picPortada.Image = BytesAImagen(datos)
            End If

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'boton inscribirme
    Private Sub btnInscribirse_Click(sender As Object, e As EventArgs) Handles btnInscribirse.Click

        'paso 1: tiene que haber elegido un curso
        If idCursoElegido = 0 Then
            MessageBox.Show("Elegí un curso del catálogo", "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            'paso 2: que no este inscripto ya en ese curso
            If ServiceAlumno.YaInscripto(Sesion.idUsuario, idCursoElegido) Then
                MessageBox.Show("Ya estás inscripto en " & tituloElegido & ". Fijate en Mis cursos.", "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'paso 3: confirmo, si dice que No salgo
            If MessageBox.Show("¿Te querés inscribir en " & tituloElegido & " por $" & precioElegido.ToString("N2") & "?", "Confirmar",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            'paso 4: creo la inscripcion y le muestro el numero de orden
            Dim numero As String = ServiceAlumno.Inscribir(Sesion.idUsuario, idCursoElegido, precioElegido)
            MessageBox.Show("Listo, tu número de orden es " & numero & "." & vbCrLf &
                            "Queda pendiente hasta que cobranza acepte el pago.", "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'pestaña mis cursos

    'llena la grilla con las inscripciones del alumno
    Private Sub CargarMisCursos()

        Try
            dgvMisCursos.DataSource = ServiceAlumno.MisCursos(Sesion.idUsuario)

            'los id no los muestro
            dgvMisCursos.Columns("id").Visible = False
            dgvMisCursos.Columns("curso_id").Visible = False

            dgvMisCursos.Columns("numero_orden").HeaderText = "N° orden"
            dgvMisCursos.Columns("titulo").HeaderText = "Curso"
            dgvMisCursos.Columns("categoria").HeaderText = "Categoría"
            dgvMisCursos.Columns("monto").HeaderText = "Monto $"
            dgvMisCursos.Columns("monto").DefaultCellStyle.Format = "N2"
            dgvMisCursos.Columns("estado").HeaderText = "Estado"
            dgvMisCursos.Columns("fecha_solicitud").HeaderText = "Fecha"

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'cuando entra a la pestaña mis cursos la cargo
    Private Sub tabPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabPrincipal.SelectedIndexChanged
        If tabPrincipal.SelectedTab Is tabMisCursos Then
            CargarMisCursos()
        End If
    End Sub

    'boton actualizar, por si cobranza acepto el pago mientras tanto
    Private Sub btnActualizarMis_Click(sender As Object, e As EventArgs) Handles btnActualizarMis.Click
        CargarMisCursos()
    End Sub

    'boton entrar al curso: si esta aceptada le muestro los temas
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        'tiene que haber elegido una fila
        If dgvMisCursos.CurrentRow Is Nothing Then
            MessageBox.Show("Elegí un curso de la lista", "Mis cursos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fila As DataGridViewRow = dgvMisCursos.CurrentRow
        Dim titulo As String = fila.Cells("titulo").Value.ToString()
        Dim estado As String = fila.Cells("estado").Value.ToString()

        'si todavia no pago o se lo rechazaron, le aviso y salgo
        If estado = "pendiente_pago" Then
            MessageBox.Show("Tu inscripción a " & titulo & " está esperando que cobranza acepte el pago.", "Mis cursos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf estado = "rechazada" Then
            MessageBox.Show("Tu inscripción a " & titulo & " fue rechazada por cobranza.", "Mis cursos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            'esta aceptada: le muestro los temas del curso
            Dim temas As DataTable = ServiceLecciones.Listar(Convert.ToInt32(fila.Cells("curso_id").Value))
            Dim texto As String = "Temas de " & titulo & ":" & vbCrLf & vbCrLf

            If temas.Rows.Count = 0 Then
                texto = texto & "Todavía no tiene temas cargados."
            Else
                For Each tema As DataRow In temas.Rows
                    texto = texto & tema("orden").ToString() & ". " & tema("titulo").ToString() & vbCrLf
                Next
            End If

            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'cerrar sesion
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

End Class
