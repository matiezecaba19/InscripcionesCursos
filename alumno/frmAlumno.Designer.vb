<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlumno
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
        picPortada = New PictureBox()
        lbBienvenida = New Label()
        btnCerrarSesion = New Button()
        pnlLinea = New Panel()
        tabPrincipal = New TabControl()
        tabCatalogo = New TabPage()
        lbBuscar = New Label()
        txtBuscar = New TextBox()
        lbCategoria = New Label()
        cmbCategoria = New ComboBox()
        btnBuscar = New Button()
        dgvCatalogo = New DataGridView()
        txtDetalle = New TextBox()
        btnInscribirse = New Button()
        tabMisCursos = New TabPage()
        btnActualizarMis = New Button()
        dgvMisCursos = New DataGridView()
        btnEntrar = New Button()
        tabPrincipal.SuspendLayout()
        tabCatalogo.SuspendLayout()
        CType(dgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        tabMisCursos.SuspendLayout()
        CType(dgvMisCursos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lbBienvenida.Text = "Panel del Alumno"
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
        ' tabPrincipal
        ' 
        tabPrincipal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabPrincipal.Controls.Add(tabCatalogo)
        tabPrincipal.Controls.Add(tabMisCursos)
        tabPrincipal.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabPrincipal.Location = New Point(24, 72)
        tabPrincipal.Name = "tabPrincipal"
        tabPrincipal.SelectedIndex = 0
        tabPrincipal.Size = New Size(852, 512)
        tabPrincipal.TabIndex = 3
        ' 
        ' tabCatalogo
        ' 
        tabCatalogo.BackColor = Color.White
        tabCatalogo.Controls.Add(picPortada)
        tabCatalogo.Controls.Add(lbBuscar)
        tabCatalogo.Controls.Add(txtBuscar)
        tabCatalogo.Controls.Add(lbCategoria)
        tabCatalogo.Controls.Add(cmbCategoria)
        tabCatalogo.Controls.Add(btnBuscar)
        tabCatalogo.Controls.Add(dgvCatalogo)
        tabCatalogo.Controls.Add(txtDetalle)
        tabCatalogo.Controls.Add(btnInscribirse)
        tabCatalogo.Location = New Point(4, 26)
        tabCatalogo.Name = "tabCatalogo"
        tabCatalogo.Padding = New Padding(3)
        tabCatalogo.Size = New Size(844, 482)
        tabCatalogo.TabIndex = 0
        tabCatalogo.Text = "Catálogo de cursos"
        ' 
        ' lbBuscar
        ' 
        lbBuscar.AutoSize = True
        lbBuscar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbBuscar.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbBuscar.Location = New Point(16, 18)
        lbBuscar.Name = "lbBuscar"
        lbBuscar.TabIndex = 0
        lbBuscar.Text = "Buscar:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.BorderStyle = BorderStyle.FixedSingle
        txtBuscar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuscar.Location = New Point(80, 14)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(220, 25)
        txtBuscar.TabIndex = 1
        ' 
        ' lbCategoria
        ' 
        lbCategoria.AutoSize = True
        lbCategoria.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbCategoria.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbCategoria.Location = New Point(318, 18)
        lbCategoria.Name = "lbCategoria"
        lbCategoria.TabIndex = 2
        lbCategoria.Text = "Categoría:"
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategoria.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbCategoria.Location = New Point(404, 14)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(180, 25)
        cmbCategoria.TabIndex = 3
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnBuscar.Cursor = Cursors.Hand
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.White
        btnBuscar.Location = New Point(598, 12)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(100, 30)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvCatalogo
        ' 
        dgvCatalogo.AllowUserToAddRows = False
        dgvCatalogo.AllowUserToDeleteRows = False
        dgvCatalogo.AllowUserToResizeRows = False
        dgvCatalogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCatalogo.BackgroundColor = Color.White
        dgvCatalogo.BorderStyle = BorderStyle.FixedSingle
        dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCatalogo.Location = New Point(16, 56)
        dgvCatalogo.MultiSelect = False
        dgvCatalogo.Name = "dgvCatalogo"
        dgvCatalogo.ReadOnly = True
        dgvCatalogo.RowHeadersVisible = False
        dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCatalogo.Size = New Size(540, 408)
        dgvCatalogo.TabIndex = 5
        ' 
        ' txtDetalle
        ' 
        txtDetalle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtDetalle.BorderStyle = BorderStyle.FixedSingle
        txtDetalle.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDetalle.Location = New Point(572, 194)
        txtDetalle.Multiline = True
        txtDetalle.Name = "txtDetalle"
        txtDetalle.ReadOnly = True
        txtDetalle.BackColor = Color.White
        txtDetalle.ScrollBars = ScrollBars.Vertical
        txtDetalle.Size = New Size(256, 218)
        txtDetalle.TabIndex = 6
        ' 
        ' btnInscribirse
        ' 
        btnInscribirse.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnInscribirse.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnInscribirse.Cursor = Cursors.Hand
        btnInscribirse.FlatAppearance.BorderSize = 0
        btnInscribirse.FlatStyle = FlatStyle.Flat
        btnInscribirse.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInscribirse.ForeColor = Color.White
        btnInscribirse.Location = New Point(572, 424)
        btnInscribirse.Name = "btnInscribirse"
        btnInscribirse.Size = New Size(256, 40)
        btnInscribirse.TabIndex = 7
        btnInscribirse.Text = "Inscribirme"
        btnInscribirse.UseVisualStyleBackColor = False
        ' 
        ' picPortada
        ' 
        picPortada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picPortada.BackColor = Color.WhiteSmoke
        picPortada.BorderStyle = BorderStyle.FixedSingle
        picPortada.Location = New Point(572, 56)
        picPortada.Name = "picPortada"
        picPortada.Size = New Size(256, 130)
        picPortada.SizeMode = PictureBoxSizeMode.Zoom
        picPortada.TabIndex = 9
        picPortada.TabStop = False
        ' 
        ' tabMisCursos
        ' 
        tabMisCursos.BackColor = Color.White
        tabMisCursos.Controls.Add(btnActualizarMis)
        tabMisCursos.Controls.Add(dgvMisCursos)
        tabMisCursos.Controls.Add(btnEntrar)
        tabMisCursos.Location = New Point(4, 26)
        tabMisCursos.Name = "tabMisCursos"
        tabMisCursos.Padding = New Padding(3)
        tabMisCursos.Size = New Size(844, 482)
        tabMisCursos.TabIndex = 1
        tabMisCursos.Text = "Mis cursos"
        ' 
        ' btnActualizarMis
        ' 
        btnActualizarMis.BackColor = Color.White
        btnActualizarMis.Cursor = Cursors.Hand
        btnActualizarMis.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnActualizarMis.FlatStyle = FlatStyle.Flat
        btnActualizarMis.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizarMis.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnActualizarMis.Location = New Point(16, 14)
        btnActualizarMis.Name = "btnActualizarMis"
        btnActualizarMis.Size = New Size(120, 32)
        btnActualizarMis.TabIndex = 0
        btnActualizarMis.Text = "Actualizar"
        btnActualizarMis.UseVisualStyleBackColor = False
        ' 
        ' dgvMisCursos
        ' 
        dgvMisCursos.AllowUserToAddRows = False
        dgvMisCursos.AllowUserToDeleteRows = False
        dgvMisCursos.AllowUserToResizeRows = False
        dgvMisCursos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMisCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMisCursos.BackgroundColor = Color.White
        dgvMisCursos.BorderStyle = BorderStyle.FixedSingle
        dgvMisCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMisCursos.Location = New Point(16, 56)
        dgvMisCursos.MultiSelect = False
        dgvMisCursos.Name = "dgvMisCursos"
        dgvMisCursos.ReadOnly = True
        dgvMisCursos.RowHeadersVisible = False
        dgvMisCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMisCursos.Size = New Size(812, 356)
        dgvMisCursos.TabIndex = 1
        ' 
        ' btnEntrar
        ' 
        btnEntrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnEntrar.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnEntrar.Cursor = Cursors.Hand
        btnEntrar.FlatAppearance.BorderSize = 0
        btnEntrar.FlatStyle = FlatStyle.Flat
        btnEntrar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEntrar.ForeColor = Color.White
        btnEntrar.Location = New Point(16, 426)
        btnEntrar.Name = "btnEntrar"
        btnEntrar.Size = New Size(180, 38)
        btnEntrar.TabIndex = 2
        btnEntrar.Text = "Entrar al curso"
        btnEntrar.UseVisualStyleBackColor = False
        ' 
        ' frmAlumno
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(900, 600)
        Controls.Add(tabPrincipal)
        Controls.Add(pnlLinea)
        Controls.Add(btnCerrarSesion)
        Controls.Add(lbBienvenida)
        MinimumSize = New Size(916, 639)
        Name = "frmAlumno"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Panel Alumno"
        tabPrincipal.ResumeLayout(False)
        tabCatalogo.ResumeLayout(False)
        tabCatalogo.PerformLayout()
        CType(dgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        tabMisCursos.ResumeLayout(False)
        tabMisCursos.PerformLayout()
        CType(dgvMisCursos, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba (despues va a decir Bienvenido + nombre)
    Friend WithEvents lbBienvenida As Label
    'boton para salir y volver al login
    Friend WithEvents btnCerrarSesion As Button
    'linea gris finita abajo del titulo
    Friend WithEvents pnlLinea As Panel
    'pestañas del panel
    Friend WithEvents tabPrincipal As TabControl
    'pestaña del catalogo
    Friend WithEvents tabCatalogo As TabPage
    'texto Buscar
    Friend WithEvents lbBuscar As Label
    'caja para buscar por titulo
    Friend WithEvents txtBuscar As TextBox
    'texto Categoria
    Friend WithEvents lbCategoria As Label
    'combo para filtrar por categoria
    Friend WithEvents cmbCategoria As ComboBox
    'boton azul para buscar
    Friend WithEvents btnBuscar As Button
    'grilla con los cursos publicados
    Friend WithEvents dgvCatalogo As DataGridView
    'caja con el detalle del curso elegido (solo lectura)
    Friend WithEvents txtDetalle As TextBox
    'boton verde para inscribirse
    Friend WithEvents btnInscribirse As Button
    'pestaña de mis cursos
    Friend WithEvents tabMisCursos As TabPage
    'boton para recargar mis cursos
    Friend WithEvents btnActualizarMis As Button
    'grilla con los cursos donde estoy inscripto
    Friend WithEvents dgvMisCursos As DataGridView
    'boton azul para entrar a ver las lecciones
    Friend WithEvents btnEntrar As Button

    'portada del curso elegido
    Friend WithEvents picPortada As PictureBox

End Class
