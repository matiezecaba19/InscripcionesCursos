Public Class frmCobranza
    'form de cobranza, aca se aceptan o rechazan los pagos de las inscripciones

    'al abrir el form
    Private Sub frmCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'saludo con el nombre que guardo el login en Sesion
        lbBienvenida.Text = "Bienvenido/a, " & Sesion.nombreCompleto

        'opciones del filtro
        cmbFiltro.Items.Clear()
        cmbFiltro.Items.Add("Pendientes de pago")
        cmbFiltro.Items.Add("Aceptadas")
        cmbFiltro.Items.Add("Rechazadas")
        cmbFiltro.Items.Add("Todas")

        'arranco en pendientes que es lo que hay que revisar
        'esto dispara cmbFiltro_SelectedIndexChanged que carga la grilla
        cmbFiltro.SelectedIndex = 0

    End Sub


    'grilla de inscripciones

    'llena la grilla segun lo elegido en el filtro
    Private Sub CargarInscripciones()

        'paso lo que dice el combo al estado que usa la base, vacio es todas
        Dim estado As String = ""
        Select Case cmbFiltro.Text
            Case "Pendientes de pago"
                estado = "pendiente_pago"
            Case "Aceptadas"
                estado = "aceptada"
            Case "Rechazadas"
                estado = "rechazada"
        End Select

        Try
            dgvInscripciones.DataSource = ServiceCobranza.Listar(estado)

            'el id no lo muestro
            dgvInscripciones.Columns("id").Visible = False

            'nombres lindos para las columnas
            dgvInscripciones.Columns("numero_orden").HeaderText = "N° orden"
            dgvInscripciones.Columns("alumno").HeaderText = "Alumno"
            dgvInscripciones.Columns("dni").HeaderText = "DNI"
            dgvInscripciones.Columns("curso").HeaderText = "Curso"
            dgvInscripciones.Columns("monto").HeaderText = "Monto $"
            dgvInscripciones.Columns("monto").DefaultCellStyle.Format = "N2"
            dgvInscripciones.Columns("estado").HeaderText = "Estado"
            dgvInscripciones.Columns("fecha_solicitud").HeaderText = "Fecha"
            dgvInscripciones.Columns("autorizo").HeaderText = "Autorizó"

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'cuando cambia el filtro recargo
    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        CargarInscripciones()
    End Sub

    'boton actualizar, por si entraron inscripciones nuevas
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarInscripciones()
    End Sub


    'botones aceptar / rechazar

    'lo usan los 2 botones, estadoNuevo es aceptada o rechazada y accion es la palabra para el mensaje
    Private Sub CambiarEstadoElegida(estadoNuevo As String, accion As String)

        'paso 1: tiene que haber una inscripcion elegida
        If dgvInscripciones.CurrentRow Is Nothing Then
            MessageBox.Show("Elegí una inscripción de la lista", "Cobranza", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'paso 2: saco los datos de la fila
        Dim fila As DataGridViewRow = dgvInscripciones.CurrentRow
        Dim id As Integer = Convert.ToInt32(fila.Cells("id").Value)
        Dim numero As String = fila.Cells("numero_orden").Value.ToString()
        Dim alumno As String = fila.Cells("alumno").Value.ToString()
        Dim monto As Decimal = Convert.ToDecimal(fila.Cells("monto").Value)

        'paso 3: solo se puede si esta pendiente
        If fila.Cells("estado").Value.ToString() <> "pendiente_pago" Then
            MessageBox.Show("La inscripción " & numero & " ya fue " & fila.Cells("estado").Value.ToString() & ".", "Cobranza", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'paso 4: pido confirmacion
        If MessageBox.Show("¿" & accion & " el pago de " & numero & ", " & alumno & ", $" & monto.ToString("N2") & "?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            'paso 5: cambio el estado guardando quien lo hizo, Sesion.idUsuario es el de cobranza que entro
            If ServiceCobranza.CambiarEstado(id, estadoNuevo, Sesion.idUsuario) Then
                MessageBox.Show("La inscripción " & numero & " quedó " & estadoNuevo & ".", "Cobranza", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'si devolvio False es que otro de cobranza la cambio antes
                MessageBox.Show("La inscripción " & numero & " ya no estaba pendiente.", "Cobranza", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            CargarInscripciones()

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'boton verde
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        CambiarEstadoElegida("aceptada", "Aceptar")
    End Sub

    'boton rojo
    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        CambiarEstadoElegida("rechazada", "Rechazar")
    End Sub


    'comprobante

    'revisa que haya una inscripcion aceptada elegida, la usan los 2 botones
    Private Function PuedeImprimir() As Boolean
        If dgvInscripciones.CurrentRow Is Nothing Then
            MessageBox.Show("Elegí una inscripción de la lista", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If dgvInscripciones.CurrentRow.Cells("estado").Value.ToString() <> "aceptada" Then
            MessageBox.Show("Solo se imprime el comprobante de las inscripciones aceptadas", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    'boton vista previa
    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click
        If PuedeImprimir() Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    'boton imprimir
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If PuedeImprimir() Then
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintDocument1.Print()
            End If
        End If
    End Sub

    'aca se dibuja el comprobante con los datos de la fila elegida
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fuenteTitulo As New Font("Arial", 18, FontStyle.Bold)
        Dim fuenteNormal As New Font("Arial", 12, FontStyle.Regular)
        Dim fuenteTotal As New Font("Arial", 14, FontStyle.Bold)

        Dim fila As DataGridViewRow = dgvInscripciones.CurrentRow
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top

        'recuadro alrededor del comprobante
        e.Graphics.DrawRectangle(Pens.Black, x, y, e.MarginBounds.Width, 330)

        x += 20
        y += 20
        e.Graphics.DrawString("Comprobante de inscripción", fuenteTitulo, Brushes.Black, x, y)
        y += 45
        e.Graphics.DrawString("N° de orden: " & fila.Cells("numero_orden").Value.ToString(), fuenteNormal, Brushes.Black, x, y)
        y += 25
        e.Graphics.DrawString("Fecha: " & Convert.ToDateTime(fila.Cells("fecha_solicitud").Value).ToString("dd/MM/yyyy"), fuenteNormal, Brushes.Black, x, y)
        y += 35
        e.Graphics.DrawString("Alumno: " & fila.Cells("alumno").Value.ToString() & "   DNI: " & fila.Cells("dni").Value.ToString(), fuenteNormal, Brushes.Black, x, y)
        y += 25
        e.Graphics.DrawString("Curso: " & fila.Cells("curso").Value.ToString(), fuenteNormal, Brushes.Black, x, y)
        y += 40
        e.Graphics.DrawString("Total pagado: $" & Convert.ToDecimal(fila.Cells("monto").Value).ToString("N2"), fuenteTotal, Brushes.Black, x, y)
        y += 45
        e.Graphics.DrawString("Autorizó: " & fila.Cells("autorizo").Value.ToString(), fuenteNormal, Brushes.Black, x, y)

    End Sub


    'cerrar sesion
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

End Class
