<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        btnTablero = New Button()
        pnlLinea = New Panel()
        tabPrincipal = New TabControl()
        tabUsuarios = New TabPage()
        lbTipo = New Label()
        cmbTipo = New ComboBox()
        chkPendientes = New CheckBox()
        dgvUsuarios = New DataGridView()
        btnActivar = New Button()
        btnDesactivar = New Button()
        btnRechazar = New Button()
        tabCategorias = New TabPage()
        dgvCategorias = New DataGridView()
        lbNombreCat = New Label()
        txtNombreCat = New TextBox()
        lbDescCat = New Label()
        txtDescCat = New TextBox()
        btnNuevaCat = New Button()
        btnGuardarCat = New Button()
        btnEliminarCat = New Button()
        tabReportes = New TabPage()
        btnActualizarReporte = New Button()
        dgvReporte = New DataGridView()
        btnVistaPreviaListado = New Button()
        btnImprimirListado = New Button()
        tabPrincipal.SuspendLayout()
        tabUsuarios.SuspendLayout()
        CType(dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        tabCategorias.SuspendLayout()
        CType(dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        tabReportes.SuspendLayout()
        CType(dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lbBienvenida.Text = "Panel del Administrador"
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
        ' btnTablero
        ' 
        btnTablero.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTablero.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnTablero.Cursor = Cursors.Hand
        btnTablero.FlatAppearance.BorderSize = 0
        btnTablero.FlatStyle = FlatStyle.Flat
        btnTablero.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTablero.ForeColor = Color.White
        btnTablero.Location = New Point(626, 14)
        btnTablero.Name = "btnTablero"
        btnTablero.Size = New Size(120, 32)
        btnTablero.TabIndex = 2
        btnTablero.Text = "Tablero"
        btnTablero.UseVisualStyleBackColor = False
        ' 
        ' pnlLinea
        ' 
        pnlLinea.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLinea.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlLinea.Location = New Point(24, 56)
        pnlLinea.Name = "pnlLinea"
        pnlLinea.Size = New Size(852, 1)
        pnlLinea.TabIndex = 3
        ' 
        ' tabPrincipal
        ' 
        tabPrincipal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabPrincipal.Controls.Add(tabUsuarios)
        tabPrincipal.Controls.Add(tabCategorias)
        tabPrincipal.Controls.Add(tabReportes)
        tabPrincipal.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabPrincipal.Location = New Point(24, 72)
        tabPrincipal.Name = "tabPrincipal"
        tabPrincipal.SelectedIndex = 0
        tabPrincipal.Size = New Size(852, 512)
        tabPrincipal.TabIndex = 4
        ' 
        ' tabUsuarios
        ' 
        tabUsuarios.BackColor = Color.White
        tabUsuarios.Controls.Add(lbTipo)
        tabUsuarios.Controls.Add(cmbTipo)
        tabUsuarios.Controls.Add(chkPendientes)
        tabUsuarios.Controls.Add(dgvUsuarios)
        tabUsuarios.Controls.Add(btnActivar)
        tabUsuarios.Controls.Add(btnDesactivar)
        tabUsuarios.Controls.Add(btnRechazar)
        tabUsuarios.Location = New Point(4, 26)
        tabUsuarios.Name = "tabUsuarios"
        tabUsuarios.Padding = New Padding(3)
        tabUsuarios.Size = New Size(844, 482)
        tabUsuarios.TabIndex = 0
        tabUsuarios.Text = "Usuarios"
        ' 
        ' lbTipo
        ' 
        lbTipo.AutoSize = True
        lbTipo.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTipo.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbTipo.Location = New Point(16, 18)
        lbTipo.Name = "lbTipo"
        lbTipo.TabIndex = 0
        lbTipo.Text = "Tipo de usuario:"
        ' 
        ' cmbTipo
        ' 
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipo.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbTipo.Location = New Point(140, 14)
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Size = New Size(180, 25)
        cmbTipo.TabIndex = 1
        ' 
        ' chkPendientes
        ' 
        chkPendientes.AutoSize = True
        chkPendientes.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkPendientes.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        chkPendientes.Location = New Point(340, 16)
        chkPendientes.Name = "chkPendientes"
        chkPendientes.TabIndex = 2
        chkPendientes.Text = "Ver solo pendientes"
        chkPendientes.UseVisualStyleBackColor = True
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.AllowUserToDeleteRows = False
        dgvUsuarios.AllowUserToResizeRows = False
        dgvUsuarios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsuarios.BackgroundColor = Color.White
        dgvUsuarios.BorderStyle = BorderStyle.FixedSingle
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(16, 52)
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.RowHeadersVisible = False
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.Size = New Size(812, 360)
        dgvUsuarios.TabIndex = 3
        ' 
        ' btnActivar
        ' 
        btnActivar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnActivar.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnActivar.Cursor = Cursors.Hand
        btnActivar.FlatAppearance.BorderSize = 0
        btnActivar.FlatStyle = FlatStyle.Flat
        btnActivar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActivar.ForeColor = Color.White
        btnActivar.Location = New Point(16, 426)
        btnActivar.Name = "btnActivar"
        btnActivar.Size = New Size(160, 38)
        btnActivar.TabIndex = 4
        btnActivar.Text = "Aprobar / Activar"
        btnActivar.UseVisualStyleBackColor = False
        ' 
        ' btnDesactivar
        ' 
        btnDesactivar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnDesactivar.BackColor = Color.White
        btnDesactivar.Cursor = Cursors.Hand
        btnDesactivar.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnDesactivar.FlatStyle = FlatStyle.Flat
        btnDesactivar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDesactivar.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnDesactivar.Location = New Point(186, 426)
        btnDesactivar.Name = "btnDesactivar"
        btnDesactivar.Size = New Size(130, 38)
        btnDesactivar.TabIndex = 5
        btnDesactivar.Text = "Desactivar"
        btnDesactivar.UseVisualStyleBackColor = False
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
        btnRechazar.Location = New Point(326, 426)
        btnRechazar.Name = "btnRechazar"
        btnRechazar.Size = New Size(130, 38)
        btnRechazar.TabIndex = 6
        btnRechazar.Text = "Rechazar"
        btnRechazar.UseVisualStyleBackColor = False
        ' 
        ' tabCategorias
        ' 
        tabCategorias.BackColor = Color.White
        tabCategorias.Controls.Add(dgvCategorias)
        tabCategorias.Controls.Add(lbNombreCat)
        tabCategorias.Controls.Add(txtNombreCat)
        tabCategorias.Controls.Add(lbDescCat)
        tabCategorias.Controls.Add(txtDescCat)
        tabCategorias.Controls.Add(btnNuevaCat)
        tabCategorias.Controls.Add(btnGuardarCat)
        tabCategorias.Controls.Add(btnEliminarCat)
        tabCategorias.Location = New Point(4, 26)
        tabCategorias.Name = "tabCategorias"
        tabCategorias.Padding = New Padding(3)
        tabCategorias.Size = New Size(844, 482)
        tabCategorias.TabIndex = 1
        tabCategorias.Text = "Categorías"
        ' 
        ' dgvCategorias
        ' 
        dgvCategorias.AllowUserToAddRows = False
        dgvCategorias.AllowUserToDeleteRows = False
        dgvCategorias.AllowUserToResizeRows = False
        dgvCategorias.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCategorias.BackgroundColor = Color.White
        dgvCategorias.BorderStyle = BorderStyle.FixedSingle
        dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCategorias.Location = New Point(16, 16)
        dgvCategorias.MultiSelect = False
        dgvCategorias.Name = "dgvCategorias"
        dgvCategorias.ReadOnly = True
        dgvCategorias.RowHeadersVisible = False
        dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCategorias.Size = New Size(480, 448)
        dgvCategorias.TabIndex = 0
        ' 
        ' lbNombreCat
        ' 
        lbNombreCat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbNombreCat.AutoSize = True
        lbNombreCat.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbNombreCat.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbNombreCat.Location = New Point(516, 16)
        lbNombreCat.Name = "lbNombreCat"
        lbNombreCat.TabIndex = 1
        lbNombreCat.Text = "Nombre:"
        ' 
        ' txtNombreCat
        ' 
        txtNombreCat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNombreCat.BorderStyle = BorderStyle.FixedSingle
        txtNombreCat.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombreCat.Location = New Point(516, 40)
        txtNombreCat.MaxLength = 30
        txtNombreCat.Name = "txtNombreCat"
        txtNombreCat.Size = New Size(312, 25)
        txtNombreCat.TabIndex = 2
        ' 
        ' lbDescCat
        ' 
        lbDescCat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbDescCat.AutoSize = True
        lbDescCat.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbDescCat.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbDescCat.Location = New Point(516, 80)
        lbDescCat.Name = "lbDescCat"
        lbDescCat.TabIndex = 3
        lbDescCat.Text = "Descripción (opcional):"
        ' 
        ' txtDescCat
        ' 
        txtDescCat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDescCat.BorderStyle = BorderStyle.FixedSingle
        txtDescCat.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescCat.Location = New Point(516, 104)
        txtDescCat.MaxLength = 100
        txtDescCat.Multiline = True
        txtDescCat.Name = "txtDescCat"
        txtDescCat.ScrollBars = ScrollBars.Vertical
        txtDescCat.Size = New Size(312, 110)
        txtDescCat.TabIndex = 4
        ' 
        ' btnNuevaCat
        ' 
        btnNuevaCat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNuevaCat.BackColor = Color.White
        btnNuevaCat.Cursor = Cursors.Hand
        btnNuevaCat.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNuevaCat.FlatStyle = FlatStyle.Flat
        btnNuevaCat.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevaCat.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNuevaCat.Location = New Point(516, 232)
        btnNuevaCat.Name = "btnNuevaCat"
        btnNuevaCat.Size = New Size(96, 36)
        btnNuevaCat.TabIndex = 5
        btnNuevaCat.Text = "Nueva"
        btnNuevaCat.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarCat
        ' 
        btnGuardarCat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGuardarCat.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnGuardarCat.Cursor = Cursors.Hand
        btnGuardarCat.FlatAppearance.BorderSize = 0
        btnGuardarCat.FlatStyle = FlatStyle.Flat
        btnGuardarCat.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardarCat.ForeColor = Color.White
        btnGuardarCat.Location = New Point(624, 232)
        btnGuardarCat.Name = "btnGuardarCat"
        btnGuardarCat.Size = New Size(96, 36)
        btnGuardarCat.TabIndex = 6
        btnGuardarCat.Text = "Guardar"
        btnGuardarCat.UseVisualStyleBackColor = False
        ' 
        ' btnEliminarCat
        ' 
        btnEliminarCat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEliminarCat.BackColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnEliminarCat.Cursor = Cursors.Hand
        btnEliminarCat.FlatAppearance.BorderSize = 0
        btnEliminarCat.FlatStyle = FlatStyle.Flat
        btnEliminarCat.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminarCat.ForeColor = Color.White
        btnEliminarCat.Location = New Point(732, 232)
        btnEliminarCat.Name = "btnEliminarCat"
        btnEliminarCat.Size = New Size(96, 36)
        btnEliminarCat.TabIndex = 7
        btnEliminarCat.Text = "Eliminar"
        btnEliminarCat.UseVisualStyleBackColor = False
        ' 
        ' tabReportes
        ' 
        tabReportes.BackColor = Color.White
        tabReportes.Controls.Add(btnActualizarReporte)
        tabReportes.Controls.Add(dgvReporte)
        tabReportes.Controls.Add(btnVistaPreviaListado)
        tabReportes.Controls.Add(btnImprimirListado)
        tabReportes.Location = New Point(4, 26)
        tabReportes.Name = "tabReportes"
        tabReportes.Padding = New Padding(3)
        tabReportes.Size = New Size(844, 482)
        tabReportes.TabIndex = 2
        tabReportes.Text = "Reporte de cursos"
        ' 
        ' btnActualizarReporte
        ' 
        btnActualizarReporte.BackColor = Color.White
        btnActualizarReporte.Cursor = Cursors.Hand
        btnActualizarReporte.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnActualizarReporte.FlatStyle = FlatStyle.Flat
        btnActualizarReporte.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizarReporte.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnActualizarReporte.Location = New Point(16, 14)
        btnActualizarReporte.Name = "btnActualizarReporte"
        btnActualizarReporte.Size = New Size(120, 32)
        btnActualizarReporte.TabIndex = 0
        btnActualizarReporte.Text = "Actualizar"
        btnActualizarReporte.UseVisualStyleBackColor = False
        ' 
        ' dgvReporte
        ' 
        dgvReporte.AllowUserToAddRows = False
        dgvReporte.AllowUserToDeleteRows = False
        dgvReporte.AllowUserToResizeRows = False
        dgvReporte.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReporte.BackgroundColor = Color.White
        dgvReporte.BorderStyle = BorderStyle.FixedSingle
        dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReporte.Location = New Point(16, 56)
        dgvReporte.MultiSelect = False
        dgvReporte.Name = "dgvReporte"
        dgvReporte.ReadOnly = True
        dgvReporte.RowHeadersVisible = False
        dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReporte.Size = New Size(812, 356)
        dgvReporte.TabIndex = 1
        ' 
        ' btnVistaPreviaListado
        ' 
        btnVistaPreviaListado.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnVistaPreviaListado.BackColor = Color.White
        btnVistaPreviaListado.Cursor = Cursors.Hand
        btnVistaPreviaListado.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnVistaPreviaListado.FlatStyle = FlatStyle.Flat
        btnVistaPreviaListado.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVistaPreviaListado.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnVistaPreviaListado.Location = New Point(16, 426)
        btnVistaPreviaListado.Name = "btnVistaPreviaListado"
        btnVistaPreviaListado.Size = New Size(180, 38)
        btnVistaPreviaListado.TabIndex = 2
        btnVistaPreviaListado.Text = "Vista previa listado"
        btnVistaPreviaListado.UseVisualStyleBackColor = False
        ' 
        ' btnImprimirListado
        ' 
        btnImprimirListado.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnImprimirListado.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnImprimirListado.Cursor = Cursors.Hand
        btnImprimirListado.FlatAppearance.BorderSize = 0
        btnImprimirListado.FlatStyle = FlatStyle.Flat
        btnImprimirListado.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImprimirListado.ForeColor = Color.White
        btnImprimirListado.Location = New Point(206, 426)
        btnImprimirListado.Name = "btnImprimirListado"
        btnImprimirListado.Size = New Size(180, 38)
        btnImprimirListado.TabIndex = 3
        btnImprimirListado.Text = "Imprimir listado"
        btnImprimirListado.UseVisualStyleBackColor = False
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(900, 600)
        Controls.Add(tabPrincipal)
        Controls.Add(pnlLinea)
        Controls.Add(btnTablero)
        Controls.Add(btnCerrarSesion)
        Controls.Add(lbBienvenida)
        MinimumSize = New Size(916, 639)
        Name = "frmAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Panel Administrador"
        tabPrincipal.ResumeLayout(False)
        tabUsuarios.ResumeLayout(False)
        tabUsuarios.PerformLayout()
        CType(dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        tabCategorias.ResumeLayout(False)
        tabCategorias.PerformLayout()
        CType(dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        tabReportes.ResumeLayout(False)
        tabReportes.PerformLayout()
        CType(dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba (despues va a decir Bienvenido + nombre)
    Friend WithEvents lbBienvenida As Label
    'boton para salir y volver al login
    Friend WithEvents btnCerrarSesion As Button
    'boton azul para abrir el tablero con graficos
    Friend WithEvents btnTablero As Button
    'linea gris finita abajo del titulo
    Friend WithEvents pnlLinea As Panel
    'pestañas del panel
    Friend WithEvents tabPrincipal As TabControl
    'pestaña de usuarios
    Friend WithEvents tabUsuarios As TabPage
    'texto Tipo de usuario
    Friend WithEvents lbTipo As Label
    'combo para elegir profesores, cobranza o alumnos
    Friend WithEvents cmbTipo As ComboBox
    'tilde para ver solo los que esperan aprobacion
    Friend WithEvents chkPendientes As CheckBox
    'grilla con los usuarios
    Friend WithEvents dgvUsuarios As DataGridView
    'boton verde para aprobar o activar
    Friend WithEvents btnActivar As Button
    'boton para desactivar
    Friend WithEvents btnDesactivar As Button
    'boton rojo para rechazar un registro
    Friend WithEvents btnRechazar As Button
    'pestaña de categorias
    Friend WithEvents tabCategorias As TabPage
    'grilla con las categorias
    Friend WithEvents dgvCategorias As DataGridView
    'texto Nombre
    Friend WithEvents lbNombreCat As Label
    'caja para el nombre de la categoria
    Friend WithEvents txtNombreCat As TextBox
    'texto Descripcion
    Friend WithEvents lbDescCat As Label
    'caja para la descripcion (varias lineas)
    Friend WithEvents txtDescCat As TextBox
    'boton para limpiar y cargar una nueva
    Friend WithEvents btnNuevaCat As Button
    'boton azul para guardar
    Friend WithEvents btnGuardarCat As Button
    'boton rojo para eliminar
    Friend WithEvents btnEliminarCat As Button
    'pestaña del reporte
    Friend WithEvents tabReportes As TabPage
    'boton para recargar el reporte
    Friend WithEvents btnActualizarReporte As Button
    'grilla con el avance de los alumnos
    Friend WithEvents dgvReporte As DataGridView
    'boton para ver como sale impreso
    Friend WithEvents btnVistaPreviaListado As Button
    'boton azul para imprimir
    Friend WithEvents btnImprimirListado As Button

    'la hoja que se imprime, se dibuja en el evento PrintPage
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    'ventana de vista previa
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    'ventana para elegir la impresora
    Friend WithEvents PrintDialog1 As PrintDialog

End Class
