<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCobranza
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        PrintDialog1.UseEXDialog = True
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        lbBienvenida = New Label()
        btnCerrarSesion = New Button()
        pnlLinea = New Panel()
        lbFiltro = New Label()
        cmbFiltro = New ComboBox()
        btnActualizar = New Button()
        dgvInscripciones = New DataGridView()
        btnAceptar = New Button()
        btnRechazar = New Button()
        btnVistaPrevia = New Button()
        btnImprimir = New Button()
        CType(dgvInscripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbBienvenida
        ' 
        lbBienvenida.AutoSize = True
        lbBienvenida.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbBienvenida.ForeColor = Color.Black
        lbBienvenida.Location = New Point(22, 14)
        lbBienvenida.Name = "lbBienvenida"
        lbBienvenida.TabIndex = 0
        lbBienvenida.Text = "Panel de Cobranza"
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrarSesion.BackColor = Color.White
        btnCerrarSesion.Cursor = Cursors.Hand
        btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCerrarSesion.Location = New Point(756, 14)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(120, 32)
        btnCerrarSesion.TabIndex = 1
        btnCerrarSesion.Text = "Cerrar sesión"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' pnlLinea
        ' 
        pnlLinea.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLinea.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlLinea.Location = New Point(24, 56)
        pnlLinea.Name = "pnlLinea"
        pnlLinea.Size = New Size(852, 1)
        pnlLinea.TabIndex = 2
        ' 
        ' lbFiltro
        ' 
        lbFiltro.AutoSize = True
        lbFiltro.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbFiltro.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbFiltro.Location = New Point(24, 76)
        lbFiltro.Name = "lbFiltro"
        lbFiltro.TabIndex = 3
        lbFiltro.Text = "Mostrar:"
        ' 
        ' cmbFiltro
        ' 
        cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFiltro.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFiltro.Location = New Point(94, 72)
        cmbFiltro.Name = "cmbFiltro"
        cmbFiltro.Size = New Size(200, 25)
        cmbFiltro.TabIndex = 4
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.White
        btnActualizar.Cursor = Cursors.Hand
        btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizar.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnActualizar.Location = New Point(306, 70)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(120, 30)
        btnActualizar.TabIndex = 5
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' dgvInscripciones
        ' 
        dgvInscripciones.AllowUserToAddRows = False
        dgvInscripciones.AllowUserToDeleteRows = False
        dgvInscripciones.AllowUserToResizeRows = False
        dgvInscripciones.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInscripciones.BackgroundColor = Color.White
        dgvInscripciones.BorderStyle = BorderStyle.FixedSingle
        dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInscripciones.Location = New Point(24, 112)
        dgvInscripciones.MultiSelect = False
        dgvInscripciones.Name = "dgvInscripciones"
        dgvInscripciones.ReadOnly = True
        dgvInscripciones.RowHeadersVisible = False
        dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInscripciones.Size = New Size(852, 410)
        dgvInscripciones.TabIndex = 6
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAceptar.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnAceptar.Cursor = Cursors.Hand
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(24, 536)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(150, 40)
        btnAceptar.TabIndex = 7
        btnAceptar.Text = "Aceptar pago"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' btnRechazar
        ' 
        btnRechazar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRechazar.BackColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnRechazar.Cursor = Cursors.Hand
        btnRechazar.FlatAppearance.BorderSize = 0
        btnRechazar.FlatStyle = FlatStyle.Flat
        btnRechazar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRechazar.ForeColor = Color.White
        btnRechazar.Location = New Point(184, 536)
        btnRechazar.Name = "btnRechazar"
        btnRechazar.Size = New Size(150, 40)
        btnRechazar.TabIndex = 8
        btnRechazar.Text = "Rechazar pago"
        btnRechazar.UseVisualStyleBackColor = False
        ' 
        ' btnVistaPrevia
        ' 
        btnVistaPrevia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnVistaPrevia.BackColor = Color.White
        btnVistaPrevia.Cursor = Cursors.Hand
        btnVistaPrevia.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnVistaPrevia.FlatStyle = FlatStyle.Flat
        btnVistaPrevia.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVistaPrevia.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnVistaPrevia.Location = New Point(446, 536)
        btnVistaPrevia.Name = "btnVistaPrevia"
        btnVistaPrevia.Size = New Size(210, 40)
        btnVistaPrevia.TabIndex = 9
        btnVistaPrevia.Text = "Vista previa comprobante"
        btnVistaPrevia.UseVisualStyleBackColor = False
        ' 
        ' btnImprimir
        ' 
        btnImprimir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnImprimir.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnImprimir.Cursor = Cursors.Hand
        btnImprimir.FlatAppearance.BorderSize = 0
        btnImprimir.FlatStyle = FlatStyle.Flat
        btnImprimir.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImprimir.ForeColor = Color.White
        btnImprimir.Location = New Point(666, 536)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(210, 40)
        btnImprimir.TabIndex = 10
        btnImprimir.Text = "Imprimir comprobante"
        btnImprimir.UseVisualStyleBackColor = False
        ' 
        ' frmCobranza
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(900, 600)
        Controls.Add(btnImprimir)
        Controls.Add(btnVistaPrevia)
        Controls.Add(btnRechazar)
        Controls.Add(btnAceptar)
        Controls.Add(dgvInscripciones)
        Controls.Add(btnActualizar)
        Controls.Add(cmbFiltro)
        Controls.Add(lbFiltro)
        Controls.Add(pnlLinea)
        Controls.Add(btnCerrarSesion)
        Controls.Add(lbBienvenida)
        MinimumSize = New Size(916, 639)
        Name = "frmCobranza"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Panel Cobranza"
        CType(dgvInscripciones, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba (despues va a decir Bienvenido + nombre)
    Friend WithEvents lbBienvenida As Label
    'boton para salir y volver al login
    Friend WithEvents btnCerrarSesion As Button
    'linea gris finita abajo del titulo
    Friend WithEvents pnlLinea As Panel
    'texto Mostrar
    Friend WithEvents lbFiltro As Label
    'combo para filtrar (pendientes, aceptadas...)
    Friend WithEvents cmbFiltro As ComboBox
    'boton para recargar la grilla
    Friend WithEvents btnActualizar As Button
    'grilla con las inscripciones a cobrar
    Friend WithEvents dgvInscripciones As DataGridView
    'boton verde para aceptar el pago
    Friend WithEvents btnAceptar As Button
    'boton rojo para rechazar el pago
    Friend WithEvents btnRechazar As Button
    'boton para ver como sale el comprobante
    Friend WithEvents btnVistaPrevia As Button
    'boton azul para imprimir el comprobante
    Friend WithEvents btnImprimir As Button

    'la hoja que se imprime, se dibuja en el evento PrintPage
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    'ventana de vista previa
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    'ventana para elegir la impresora
    Friend WithEvents PrintDialog1 As PrintDialog

End Class
