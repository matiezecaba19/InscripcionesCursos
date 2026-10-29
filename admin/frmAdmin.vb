Public Class frmAdmin

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'saludo con el nombre que guardo el login en Sesion
        lbBienvenida.Text = "Bienvenido/a, " & Sesion.nombreCompleto

        'cargo los tipos de usuario en el combo
        'admin no lo pongo, asi no se puede desactivar a si mismo
        cmbTipo.Items.Clear()
        cmbTipo.Items.Add("Alumnos")
        cmbTipo.Items.Add("Profesores")
        cmbTipo.Items.Add("Cobranza")

        'elijo el primero que es Alumnos
        'esto dispara cmbTipo_SelectedIndexChanged, que carga la grilla
        cmbTipo.SelectedIndex = 0

    End Sub


    'pestaña usuarios: cargar la grilla

    'llena la grilla con los usuarios del tipo elegido en el combo
    'la llamo desde varios lados, por eso es un Sub aparte
    Private Sub CargarUsuarios()

        Try
            'paso lo que dice el combo al nombre de la tabla
            Dim tabla As String = ServiceUsuarios.NombreTabla(cmbTipo.Text)

            'traigo los usuarios y los pongo en la grilla
            dgvUsuarios.DataSource = ServiceUsuarios.Listar(tabla, chkPendientes.Checked)

            'el id no lo muestro, lo uso por dentro para saber a quien cambiar
            dgvUsuarios.Columns("id").Visible = False

            'les pongo nombres lindos a las columnas
            dgvUsuarios.Columns("nombre").HeaderText = "Nombre"
            dgvUsuarios.Columns("apellido").HeaderText = "Apellido"
            dgvUsuarios.Columns("dni").HeaderText = "DNI"
            dgvUsuarios.Columns("email").HeaderText = "Email"
            dgvUsuarios.Columns("estado").HeaderText = "Estado"
            dgvUsuarios.Columns("fecha_creacion").HeaderText = "Registrado"

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'cuando cambio el tipo en el combo, recargo la grilla
    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        CargarUsuarios()
    End Sub

    'cuando tildo o destildo "ver solo pendientes", recargo la grilla
    Private Sub chkPendientes_CheckedChanged(sender As Object, e As EventArgs) Handles chkPendientes.CheckedChanged
        CargarUsuarios()
    End Sub











    'pestaña usuarios: botones

    'lo usan los 3 botones: activar, desactivar y rechazar
    'estadoNuevo = como va a quedar en la base, accion = la palabra para el mensaje
    Private Sub CambiarEstadoElegido(estadoNuevo As String, accion As String)

        'paso 1: reviso que haya un usuario elegido en la grilla
        'CurrentRow = la fila marcada, Is Nothing = no hay ninguna
        If dgvUsuarios.CurrentRow Is Nothing Then
            MessageBox.Show("Elegí un usuario de la lista", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'paso 2: saco los datos de la fila elegida
        Dim fila As DataGridViewRow = dgvUsuarios.CurrentRow
        Dim id As Integer = Convert.ToInt32(fila.Cells("id").Value)
        Dim nombre As String = fila.Cells("nombre").Value.ToString() & " " & fila.Cells("apellido").Value.ToString()
        Dim estadoActual As String = fila.Cells("estado").Value.ToString()

        'paso 3: si ya esta en ese estado no hago nada
        If estadoActual = estadoNuevo Then
            MessageBox.Show(nombre & " ya está " & estadoNuevo, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'paso 4: pido confirmacion, si dice que No salgo
        If MessageBox.Show("¿Seguro que querés " & accion & " a " & nombre & "?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        'paso 5: cambio el estado en la base y recargo la grilla
        Try
            ServiceUsuarios.CambiarEstado(ServiceUsuarios.NombreTabla(cmbTipo.Text), id, estadoNuevo)
            MessageBox.Show(nombre & " quedó " & estadoNuevo, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarUsuarios()

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'boton verde: aprueba al pendiente o vuelve a activar al desactivado
    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        CambiarEstadoElegido("activo", "activar")
    End Sub

    'boton desactivar: el usuario ya no puede entrar
    Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
        CambiarEstadoElegido("inactivo", "desactivar")
    End Sub

    'boton rojo: rechaza el registro
    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click

        'en la base los alumnos no tienen el estado "rechazado", por eso aviso
        If cmbTipo.Text = "Alumnos" Then
            MessageBox.Show("A los alumnos no se los rechaza, usá Desactivar.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        CambiarEstadoElegido("rechazado", "rechazar")
    End Sub










    'pestaña categorias

    'id de la categoria elegida en la grilla
    '0 = no hay ninguna elegida, o sea que Guardar crea una nueva
    Private idCategoria As Integer = 0

    'cuando cambio de pestaña, si entro a Categorias cargo la grilla
    Private Sub tabPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabPrincipal.SelectedIndexChanged
        If tabPrincipal.SelectedTab Is tabCategorias Then
            CargarCategorias()
            LimpiarCategoria()
        ElseIf tabPrincipal.SelectedTab Is tabReportes Then
            CargarReporte()
        End If
    End Sub

    'llena la grilla con todas las categorias
    Private Sub CargarCategorias()

        Try
            'traigo las categorias y las pongo en la grilla
            dgvCategorias.DataSource = ServiceCategorias.Listar()

            'el id no lo muestro, lo uso por dentro
            dgvCategorias.Columns("id").Visible = False

            'nombres lindos para las columnas
            dgvCategorias.Columns("nombre").HeaderText = "Nombre"
            dgvCategorias.Columns("descripcion").HeaderText = "Descripción"

            'si fallo algo con la base muestro el error traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'deja las cajas vacias para escribir una categoria nueva
    Private Sub LimpiarCategoria()

        'vuelvo a 0 = ninguna elegida
        idCategoria = 0
        txtNombreCat.Clear()
        txtDescCat.Clear()

        'saco la fila marcada en la grilla, asi no confunde
        dgvCategorias.ClearSelection()

        'dejo el cursor en el nombre
        txtNombreCat.Focus()

    End Sub

    'cuando hago clic en una fila, paso sus datos a las cajas para modificarla
    Private Sub dgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellClick

        'si hizo clic en el titulo de la columna, RowIndex es -1 y no hago nada
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        'agarro la fila donde hizo clic
        Dim fila As DataGridViewRow = dgvCategorias.Rows(e.RowIndex)

        'guardo el id y paso los datos a las cajas
        idCategoria = Convert.ToInt32(fila.Cells("id").Value)
        txtNombreCat.Text = fila.Cells("nombre").Value.ToString()
        'si la descripcion esta vacia en la base, ToString devuelve "" asi que no falla
        txtDescCat.Text = fila.Cells("descripcion").Value.ToString()

    End Sub

    'boton Nueva: limpia todo para cargar una categoria nueva
    Private Sub btnNuevaCat_Click(sender As Object, e As EventArgs) Handles btnNuevaCat.Click
        LimpiarCategoria()
    End Sub

    'boton Guardar: si es nueva la agrega, si eligio una de la grilla la modifica
    Private Sub btnGuardarCat_Click(sender As Object, e As EventArgs) Handles btnGuardarCat.Click

        'paso 1: el nombre es obligatorio
        If txtNombreCat.Text.Trim() = "" Then
            MessageBox.Show("Escribí el nombre de la categoría", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreCat.Focus()
            Exit Sub
        End If

        Try
            'paso 2: si idCategoria es 0 es nueva, sino modifico la elegida
            If idCategoria = 0 Then
                ServiceCategorias.Insertar(txtNombreCat.Text.Trim(), txtDescCat.Text.Trim())
                MessageBox.Show("Categoría agregada", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ServiceCategorias.Modificar(idCategoria, txtNombreCat.Text.Trim(), txtDescCat.Text.Trim())
                MessageBox.Show("Categoría modificada", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'paso 3: recargo la grilla y limpio las cajas
            CargarCategorias()
            LimpiarCategoria()

            'si el nombre ya existe la base tira 1062 y aca se muestra traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'boton Eliminar: borra la categoria elegida
    Private Sub btnEliminarCat_Click(sender As Object, e As EventArgs) Handles btnEliminarCat.Click

        'paso 1: tiene que haber una elegida
        If idCategoria = 0 Then
            MessageBox.Show("Elegí una categoría de la lista", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'paso 2: pido confirmacion, si dice que No salgo
        If MessageBox.Show("¿Seguro que querés eliminar la categoría " & txtNombreCat.Text & "?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            'paso 3: la borro, recargo y limpio
            ServiceCategorias.Eliminar(idCategoria)
            MessageBox.Show("Categoría eliminada", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarCategorias()
            LimpiarCategoria()

            'si tiene cursos la base tira 1451 y aca se muestra traducido
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub












    'pestaña reporte

    'llena la grilla del reporte
    Private Sub CargarReporte()
        Try
            dgvReporte.DataSource = ServiceReporte.Cursos()
            dgvReporte.Columns("curso").HeaderText = "Curso"
            dgvReporte.Columns("profesor").HeaderText = "Profesor"
            dgvReporte.Columns("estado").HeaderText = "Estado"
            dgvReporte.Columns("inscriptos").HeaderText = "Alumnos"
            dgvReporte.Columns("recaudado").HeaderText = "Recaudado $"
            dgvReporte.Columns("recaudado").DefaultCellStyle.Format = "N2"
        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizarReporte_Click(sender As Object, e As EventArgs) Handles btnActualizarReporte.Click
        CargarReporte()
    End Sub

    'boton vista previa del listado
    Private Sub btnVistaPreviaListado_Click(sender As Object, e As EventArgs) Handles btnVistaPreviaListado.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    'boton imprimir el listado
    Private Sub btnImprimirListado_Click(sender As Object, e As EventArgs) Handles btnImprimirListado.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    'aca se dibuja el listado, recorro las filas de la grilla del reporte
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fuenteTitulo As New Font("Arial", 18, FontStyle.Bold)
        Dim fuenteNegrita As New Font("Arial", 10, FontStyle.Bold)
        Dim fuenteNormal As New Font("Arial", 10, FontStyle.Regular)

        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top

        e.Graphics.DrawString("Listado de cursos", fuenteTitulo, Brushes.Black, x, y)
        y += 35
        e.Graphics.DrawString("Fecha: " & Date.Now.ToString("dd/MM/yyyy"), fuenteNormal, Brushes.Black, x, y)
        y += 35

        'titulos de las columnas, cada una corrida a la derecha
        e.Graphics.DrawString("Curso", fuenteNegrita, Brushes.Black, x, y)
        e.Graphics.DrawString("Profesor", fuenteNegrita, Brushes.Black, x + 220, y)
        e.Graphics.DrawString("Estado", fuenteNegrita, Brushes.Black, x + 380, y)
        e.Graphics.DrawString("Alumnos", fuenteNegrita, Brushes.Black, x + 480, y)
        e.Graphics.DrawString("Recaudado", fuenteNegrita, Brushes.Black, x + 560, y)
        y += 20
        e.Graphics.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y)
        y += 8

        'una linea por cada curso, y voy sumando el total
        Dim total As Decimal = 0
        For Each fila As DataGridViewRow In dgvReporte.Rows
            e.Graphics.DrawString(fila.Cells("curso").Value.ToString(), fuenteNormal, Brushes.Black, x, y)
            e.Graphics.DrawString(fila.Cells("profesor").Value.ToString(), fuenteNormal, Brushes.Black, x + 220, y)
            e.Graphics.DrawString(fila.Cells("estado").Value.ToString(), fuenteNormal, Brushes.Black, x + 380, y)
            e.Graphics.DrawString(fila.Cells("inscriptos").Value.ToString(), fuenteNormal, Brushes.Black, x + 480, y)
            e.Graphics.DrawString("$" & Convert.ToDecimal(fila.Cells("recaudado").Value).ToString("N2"), fuenteNormal, Brushes.Black, x + 560, y)
            total += Convert.ToDecimal(fila.Cells("recaudado").Value)
            y += 22
        Next

        y += 5
        e.Graphics.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y)
        y += 10
        e.Graphics.DrawString("Total recaudado: $" & total.ToString("N2"), fuenteNegrita, Brushes.Black, x + 400, y)

    End Sub


    'boton tablero, abre la ventana con los graficos
    Private Sub btnTablero_Click(sender As Object, e As EventArgs) Handles btnTablero.Click
        Dim frm As New frmTablero()
        frm.ShowDialog()
    End Sub

    'cierro el form, y el login se encarga de borrar la Sesion y volver a mostrarse
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

End Class
