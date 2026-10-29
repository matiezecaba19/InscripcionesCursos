Public Class frmProfesor
    'form del profesor, aca carga sus cursos y las lecciones

    'id del curso elegido en la grilla
    '0 = no hay ninguno elegido, o sea que Guardar crea uno nuevo
    Private idCurso As Integer = 0


    'al abrir el form

    'pasa cuando se abre el form
    Private Sub frmProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'saludo con el nombre que guardo el login en Sesion
        lbBienvenida.Text = "Bienvenido/a, " & Sesion.nombreCompleto

        'nivel y estado son listas fijas, escritas igual que en la base
        cmbNivel.Items.Clear()
        cmbNivel.Items.Add("inicial")
        cmbNivel.Items.Add("intermedio")
        cmbNivel.Items.Add("avanzado")

        'borrador = lo estoy armando, publicado = lo ve el alumno, cerrado = no acepta mas inscripciones
        cmbEstado.Items.Clear()
        cmbEstado.Items.Add("borrador")
        cmbEstado.Items.Add("publicado")
        cmbEstado.Items.Add("cerrado")

        Try
            'las categorias salen de la base
            'DataSource = de donde saca los datos el combo
            'DisplayMember es lo que se ve y ValueMember es el id que uso por dentro
            cmbCategoria.DataSource = ServiceCursos.ListarCategorias()
            cmbCategoria.DisplayMember = "nombre"
            cmbCategoria.ValueMember = "id"

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'cargo la grilla con mis cursos y dejo las cajas listas para uno nuevo
        CargarCursos()
        LimpiarCurso()

    End Sub


    'grilla de cursos

    'llena la grilla con los cursos del profesor que entro
    Private Sub CargarCursos()

        Try
            'Sesion.idUsuario es el id del profe que entro
            dgvCursos.DataSource = ServiceCursos.ListarDelProfesor(Sesion.idUsuario)

            'estas columnas no las muestro, las uso por dentro o se ven en las cajas
            dgvCursos.Columns("id").Visible = False
            dgvCursos.Columns("categoria_id").Visible = False
            dgvCursos.Columns("descripcion").Visible = False

            'nombres lindos para las columnas
            dgvCursos.Columns("titulo").HeaderText = "Título"
            dgvCursos.Columns("categoria").HeaderText = "Categoría"
            dgvCursos.Columns("precio").HeaderText = "Precio $"
            dgvCursos.Columns("nivel").HeaderText = "Nivel"
            dgvCursos.Columns("estado").HeaderText = "Estado"

            'N2 muestra el precio con 2 decimales
            dgvCursos.Columns("precio").DefaultCellStyle.Format = "N2"

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'deja las cajas listas para cargar un curso nuevo
    Private Sub LimpiarCurso()

        'vuelvo a 0 = ninguno elegido
        idCurso = 0
        txtTitulo.Clear()
        txtDescripcion.Clear()

        '-1 = el combo queda sin nada elegido, asi el profe tiene que elegir la categoria
        cmbCategoria.SelectedIndex = -1

        'precio en 0 y los combos en inicial y borrador
        nudPrecio.Value = 0
        cmbNivel.SelectedIndex = 0
        cmbEstado.SelectedIndex = 0
        picPortada.Image = Nothing

        'saco la fila marcada en la grilla, asi no confunde
        dgvCursos.ClearSelection()

        'dejo el cursor en el titulo
        txtTitulo.Focus()

    End Sub

    'cuando hago clic en una fila, paso sus datos a las cajas para modificarlo
    Private Sub dgvCursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellClick

        'si hizo clic en el titulo de la columna, RowIndex es -1 y no hago nada
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        'agarro la fila donde hizo clic
        Dim fila As DataGridViewRow = dgvCursos.Rows(e.RowIndex)

        'guardo el id y paso cada dato a su caja
        idCurso = Convert.ToInt32(fila.Cells("id").Value)
        txtTitulo.Text = fila.Cells("titulo").Value.ToString()

        'SelectedValue elige en el combo la categoria que tenga ese id
        cmbCategoria.SelectedValue = fila.Cells("categoria_id").Value

        'el NumericUpDown usa Decimal
        nudPrecio.Value = Convert.ToDecimal(fila.Cells("precio").Value)

        'SelectedItem elige en el combo el texto que coincida
        cmbNivel.SelectedItem = fila.Cells("nivel").Value.ToString()
        cmbEstado.SelectedItem = fila.Cells("estado").Value.ToString()

        'si la descripcion esta vacia en la base, ToString devuelve "" asi que no falla
        txtDescripcion.Text = fila.Cells("descripcion").Value.ToString()

        'traigo la portada, si no tiene queda vacio
        picPortada.Image = Nothing
        Try
            Dim datos() As Byte = ServiceCursos.TraerPortada(idCurso)
            If datos IsNot Nothing Then
                picPortada.Image = BytesAImagen(datos)
            End If
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'botones nuevo / guardar / eliminar

    'boton Nuevo: limpia todo para cargar un curso nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCurso()
    End Sub

    'boton Guardar: si es nuevo lo agrega, si eligio uno de la grilla lo modifica
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'paso 1: el titulo es obligatorio
        If txtTitulo.Text.Trim() = "" Then
            MessageBox.Show("Escribí el título del curso", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitulo.Focus()
            Exit Sub
        End If

        'paso 2: la categoria tambien, -1 es que no eligio ninguna
        If cmbCategoria.SelectedIndex = -1 Then
            MessageBox.Show("Elegí una categoría", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategoria.Focus()
            Exit Sub
        End If

        'paso 3: junto los datos de las cajas
        'SelectedValue me da el id de la categoria elegida
        Dim categoriaId As Integer = Convert.ToInt32(cmbCategoria.SelectedValue)
        Dim precio As Decimal = nudPrecio.Value
        Dim nivel As String = cmbNivel.Text
        Dim estado As String = cmbEstado.Text

        Try
            'paso 4: si idCurso es 0 es nuevo, sino modifico el elegido
            If idCurso = 0 Then
                ServiceCursos.Insertar(Sesion.idUsuario, txtTitulo.Text.Trim(), categoriaId, precio, nivel, estado, txtDescripcion.Text.Trim())
                MessageBox.Show("Curso agregado", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ServiceCursos.Modificar(idCurso, Sesion.idUsuario, txtTitulo.Text.Trim(), categoriaId, precio, nivel, estado, txtDescripcion.Text.Trim())
                MessageBox.Show("Curso modificado", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'paso 5: recargo la grilla y limpio las cajas
            CargarCursos()
            LimpiarCurso()

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'boton Eliminar: borra el curso elegido
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'paso 1: tiene que haber uno elegido
        If idCurso = 0 Then
            MessageBox.Show("Elegí un curso de la lista", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'paso 2: pido confirmacion, si dice que No salgo
        If MessageBox.Show("¿Seguro que querés eliminar el curso " & txtTitulo.Text & "?" & vbCrLf &
                           "También se borran sus lecciones.", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            'paso 3: lo borro, recargo y limpio
            ServiceCursos.Eliminar(idCurso, Sesion.idUsuario)
            MessageBox.Show("Curso eliminado", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarCursos()
            LimpiarCurso()

            'si tiene alumnos inscriptos la base tira 1451 y aca se muestra traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'boton lecciones

    'abre la ventana con el indice de temas del curso elegido
    Private Sub btnLecciones_Click(sender As Object, e As EventArgs) Handles btnLecciones.Click

        'tiene que haber un curso elegido en la grilla
        If idCurso = 0 Then
            MessageBox.Show("Elegí un curso de la lista", "Lecciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'creo la ventana y le paso de que curso es
        Dim frm As New frmLecciones()
        frm.idCurso = idCurso
        frm.tituloCurso = txtTitulo.Text

        'ShowDialog la abre arriba y espera a que la cierre
        frm.ShowDialog()

    End Sub


    'portada del curso

    'boton buscar portada, elijo una imagen de la compu y la muestro
    Private Sub btnBuscarPortada_Click(sender As Object, e As EventArgs) Handles btnBuscarPortada.Click
        Using dlg As New OpenFileDialog()
            'solo dejo elegir imagenes
            dlg.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp"

            If dlg.ShowDialog() = DialogResult.OK Then
                'hago una copia en memoria asi no queda el archivo bloqueado
                Using temporal As Image = Image.FromFile(dlg.FileName)
                    picPortada.Image = New Bitmap(temporal)
                End Using
            End If
        End Using
    End Sub

    'boton guardar portada
    Private Sub btnGuardarPortada_Click(sender As Object, e As EventArgs) Handles btnGuardarPortada.Click
        'el curso ya tiene que estar guardado y elegido
        If idCurso = 0 Then
            MessageBox.Show("Primero elegí un curso de la lista", "Portada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If picPortada.Image Is Nothing Then
            MessageBox.Show("Buscá una imagen primero", "Portada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'paso la imagen a bytes
        Dim datos() As Byte = ImagenABytes(picPortada.Image)

        'que no pase de 1 MB como dijo el profe
        If datos.Length > 1000000 Then
            MessageBox.Show("La imagen no puede superar 1 MB", "Portada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ServiceCursos.GuardarPortada(idCurso, Sesion.idUsuario, datos)
            MessageBox.Show("Portada guardada", "Portada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'boton quitar portada
    Private Sub btnQuitarPortada_Click(sender As Object, e As EventArgs) Handles btnQuitarPortada.Click
        If idCurso = 0 Then
            MessageBox.Show("Primero elegí un curso de la lista", "Portada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            'mando Nothing y en la base queda vacia
            ServiceCursos.GuardarPortada(idCurso, Sesion.idUsuario, Nothing)
            picPortada.Image = Nothing
            MessageBox.Show("Portada quitada", "Portada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'ficha del curso

    'boton vista previa
    Private Sub btnVistaPreviaFicha_Click(sender As Object, e As EventArgs) Handles btnVistaPreviaFicha.Click
        If idCurso = 0 Then
            MessageBox.Show("Elegí un curso de la lista", "Ficha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'le digo a la vista previa que hoja tiene que mostrar
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    'boton imprimir
    Private Sub btnImprimirFicha_Click(sender As Object, e As EventArgs) Handles btnImprimirFicha.Click
        If idCurso = 0 Then
            MessageBox.Show("Elegí un curso de la lista", "Ficha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'elijo la impresora y si toca Aceptar imprimo
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    'aca se dibuja la hoja, lo llaman la vista previa y el imprimir
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'fuentes
        Dim fuenteTitulo As New Font("Arial", 18, FontStyle.Bold)
        Dim fuenteNegrita As New Font("Arial", 12, FontStyle.Bold)
        Dim fuenteNormal As New Font("Arial", 12, FontStyle.Regular)

        'margenes de la hoja, x es la izquierda y y va bajando
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top

        'titulo y una linea abajo
        e.Graphics.DrawString("Ficha del curso", fuenteTitulo, Brushes.Black, x, y)
        y += 40
        e.Graphics.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y)
        y += 20

        'si tiene portada la dibujo arriba a la derecha
        If picPortada.Image IsNot Nothing Then
            e.Graphics.DrawImage(picPortada.Image, e.MarginBounds.Right - 200, y, 200, 150)
        End If

        'datos del curso, los saco de las cajas
        e.Graphics.DrawString("Curso: " & txtTitulo.Text, fuenteNegrita, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString("Profesor: " & Sesion.nombreCompleto, fuenteNormal, Brushes.Black, x, y)
        y += 25
        e.Graphics.DrawString("Categoría: " & cmbCategoria.Text, fuenteNormal, Brushes.Black, x, y)
        y += 25
        e.Graphics.DrawString("Nivel: " & cmbNivel.Text, fuenteNormal, Brushes.Black, x, y)
        y += 25
        e.Graphics.DrawString("Precio: $" & nudPrecio.Value.ToString("N2"), fuenteNormal, Brushes.Black, x, y)
        y += 40

        'la descripcion puede ser larga, la dibujo adentro de un rectangulo asi baja de renglon sola
        e.Graphics.DrawString("Descripción:", fuenteNegrita, Brushes.Black, x, y)
        y += 25
        e.Graphics.DrawString(txtDescripcion.Text, fuenteNormal, Brushes.Black, New RectangleF(x, y, e.MarginBounds.Width, 100))
        y += 110

        'temas del curso
        e.Graphics.DrawString("Temas:", fuenteNegrita, Brushes.Black, x, y)
        y += 25

        Try
            Dim temas As DataTable = ServiceLecciones.Listar(idCurso)
            For Each tema As DataRow In temas.Rows
                e.Graphics.DrawString(tema("orden").ToString() & ". " & tema("titulo").ToString(), fuenteNormal, Brushes.Black, x + 20, y)
                y += 22
            Next
        Catch ex As Exception
            e.Graphics.DrawString("No se pudieron cargar los temas", fuenteNormal, Brushes.Red, x, y)
        End Try

        'fecha abajo de todo
        e.Graphics.DrawString("Impreso el " & Date.Now.ToString("dd/MM/yyyy"), fuenteNormal, Brushes.Gray, x, e.MarginBounds.Bottom - 20)

    End Sub


    'cerrar sesion

    'cierro el form, y el login se encarga de borrar la Sesion y volver a mostrarse
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

End Class
