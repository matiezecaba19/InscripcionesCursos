Public Class frmLecciones
    'ventana con los temas de un curso, la abre frmProfesor

    'estos 2 los llena frmProfesor antes de abrir la ventana
    Public idCurso As Integer
    Public tituloCurso As String

    'tema elegido en la grilla: su id y su numero de orden
    '0 = ninguno elegido, o sea que Guardar agrega uno nuevo
    Private idLeccion As Integer = 0
    Private ordenLeccion As Integer = 0


    'al abrir la ventana
    Private Sub frmLecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'pongo el nombre del curso arriba
        lbCurso.Text = "Índice de: " & tituloCurso

        CargarLecciones()
        LimpiarTema()

    End Sub


    'grilla de temas

    'llena la grilla con los temas del curso
    Private Sub CargarLecciones()

        Try
            dgvLecciones.DataSource = ServiceLecciones.Listar(idCurso)

            'el id no lo muestro
            dgvLecciones.Columns("id").Visible = False

            'la columna del numero la hago angosta, el resto es para el tema
            dgvLecciones.Columns("orden").HeaderText = "N°"
            dgvLecciones.Columns("orden").FillWeight = 15
            dgvLecciones.Columns("titulo").HeaderText = "Tema"
            dgvLecciones.Columns("titulo").FillWeight = 85

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'deja la caja vacia para escribir un tema nuevo
    Private Sub LimpiarTema()

        idLeccion = 0
        ordenLeccion = 0
        txtTema.Clear()
        dgvLecciones.ClearSelection()
        txtTema.Focus()

    End Sub

    'cuando hago clic en un tema, lo paso a la caja para cambiarle el nombre
    Private Sub dgvLecciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLecciones.CellClick

        'si hizo clic en el titulo de la columna no hago nada
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim fila As DataGridViewRow = dgvLecciones.Rows(e.RowIndex)
        idLeccion = Convert.ToInt32(fila.Cells("id").Value)
        ordenLeccion = Convert.ToInt32(fila.Cells("orden").Value)
        txtTema.Text = fila.Cells("titulo").Value.ToString()

    End Sub


    'botones nuevo / guardar / eliminar

    'boton Nuevo tema: limpia la caja
    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        LimpiarTema()
    End Sub

    'boton Guardar: si es nuevo lo agrega al final, si eligio uno le cambia el nombre
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'el tema no puede estar vacio
        If txtTema.Text.Trim() = "" Then
            MessageBox.Show("Escribí el tema", "Lecciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTema.Focus()
            Exit Sub
        End If

        Try
            If idLeccion = 0 Then
                ServiceLecciones.Insertar(idCurso, txtTema.Text.Trim())
            Else
                ServiceLecciones.Modificar(idLeccion, txtTema.Text.Trim())
            End If

            'no muestro mensaje asi puede cargar varios temas seguidos rapido
            'recargo y dejo la caja lista para el siguiente
            CargarLecciones()
            LimpiarTema()

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'boton Eliminar: borra el tema elegido
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If idLeccion = 0 Then
            MessageBox.Show("Elegí un tema de la lista", "Lecciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'pido confirmacion, si dice que No salgo
        If MessageBox.Show("¿Seguro que querés eliminar el tema " & txtTema.Text & "?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            'le paso tambien el curso y el orden para que acomode los numeros de los que quedan
            ServiceLecciones.Eliminar(idLeccion, idCurso, ordenLeccion)
            CargarLecciones()
            LimpiarTema()

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'botones subir / bajar

    'mueve el tema elegido un lugar: paso = -1 sube, paso = 1 baja
    Private Sub MoverTema(paso As Integer)

        If idLeccion = 0 Then
            MessageBox.Show("Elegí un tema de la lista", "Lecciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'i es la fila del tema elegido y j la de arriba o la de abajo
        Dim i As Integer = dgvLecciones.CurrentRow.Index
        Dim j As Integer = i + paso

        'si ya esta primero y quiere subir, o ultimo y quiere bajar, no hago nada
        If j < 0 Or j >= dgvLecciones.Rows.Count Then
            Exit Sub
        End If

        Dim filaA As DataGridViewRow = dgvLecciones.Rows(i)
        Dim filaB As DataGridViewRow = dgvLecciones.Rows(j)

        Try
            'cambio los numeros de orden entre los dos temas
            ServiceLecciones.Intercambiar(Convert.ToInt32(filaA.Cells("id").Value), Convert.ToInt32(filaA.Cells("orden").Value),
                                          Convert.ToInt32(filaB.Cells("id").Value), Convert.ToInt32(filaB.Cells("orden").Value))
            CargarLecciones()

            'dejo marcado el mismo tema en su lugar nuevo, asi puede seguir moviendolo
            dgvLecciones.CurrentCell = dgvLecciones.Rows(j).Cells("titulo")
            ordenLeccion = Convert.ToInt32(dgvLecciones.Rows(j).Cells("orden").Value)

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        MoverTema(-1)
    End Sub

    Private Sub btnBajar_Click(sender As Object, e As EventArgs) Handles btnBajar.Click
        MoverTema(1)
    End Sub

    'boton cerrar, tambien se cierra con Esc
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class
