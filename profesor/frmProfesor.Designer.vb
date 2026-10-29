<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfesor
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
        btnBuscarPortada = New Button()
        btnGuardarPortada = New Button()
        btnQuitarPortada = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        PrintDialog1.UseEXDialog = True
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        lbBienvenida = New Label()
        btnCerrarSesion = New Button()
        pnlLinea = New Panel()
        dgvCursos = New DataGridView()
        grpCurso = New GroupBox()
        lbTitulo = New Label()
        txtTitulo = New TextBox()
        lbCategoria = New Label()
        cmbCategoria = New ComboBox()
        lbPrecio = New Label()
        nudPrecio = New NumericUpDown()
        lbNivel = New Label()
        cmbNivel = New ComboBox()
        lbEstado = New Label()
        cmbEstado = New ComboBox()
        lbDescripcion = New Label()
        txtDescripcion = New TextBox()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnLecciones = New Button()
        btnVistaPreviaFicha = New Button()
        btnImprimirFicha = New Button()
        CType(dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        grpCurso.SuspendLayout()
        CType(nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lbBienvenida.Text = "Panel del Profesor"
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
        ' dgvCursos
        ' 
        dgvCursos.AllowUserToAddRows = False
        dgvCursos.AllowUserToDeleteRows = False
        dgvCursos.AllowUserToResizeRows = False
        dgvCursos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCursos.BackgroundColor = Color.White
        dgvCursos.BorderStyle = BorderStyle.FixedSingle
        dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCursos.Location = New Point(24, 72)
        dgvCursos.MultiSelect = False
        dgvCursos.Name = "dgvCursos"
        dgvCursos.ReadOnly = True
        dgvCursos.RowHeadersVisible = False
        dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCursos.Size = New Size(500, 352)
        dgvCursos.TabIndex = 3
        ' 
        ' grpCurso
        ' 
        grpCurso.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        grpCurso.Controls.Add(lbTitulo)
        grpCurso.Controls.Add(txtTitulo)
        grpCurso.Controls.Add(lbCategoria)
        grpCurso.Controls.Add(cmbCategoria)
        grpCurso.Controls.Add(lbPrecio)
        grpCurso.Controls.Add(nudPrecio)
        grpCurso.Controls.Add(lbNivel)
        grpCurso.Controls.Add(cmbNivel)
        grpCurso.Controls.Add(lbEstado)
        grpCurso.Controls.Add(cmbEstado)
        grpCurso.Controls.Add(lbDescripcion)
        grpCurso.Controls.Add(txtDescripcion)
        grpCurso.Controls.Add(btnNuevo)
        grpCurso.Controls.Add(btnGuardar)
        grpCurso.Controls.Add(btnEliminar)
        grpCurso.Controls.Add(btnLecciones)
        grpCurso.Controls.Add(btnVistaPreviaFicha)
        grpCurso.Controls.Add(btnImprimirFicha)
        grpCurso.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpCurso.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        grpCurso.Location = New Point(540, 72)
        grpCurso.Name = "grpCurso"
        grpCurso.Size = New Size(336, 512)
        grpCurso.TabIndex = 4
        grpCurso.Text = "Datos del curso"
        ' 
        ' lbTitulo
        ' 
        lbTitulo.AutoSize = True
        lbTitulo.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTitulo.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbTitulo.Location = New Point(16, 30)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Título:"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.BorderStyle = BorderStyle.FixedSingle
        txtTitulo.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitulo.Location = New Point(16, 52)
        txtTitulo.MaxLength = 30
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(304, 25)
        txtTitulo.TabIndex = 1
        ' 
        ' lbCategoria
        ' 
        lbCategoria.AutoSize = True
        lbCategoria.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbCategoria.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbCategoria.Location = New Point(16, 88)
        lbCategoria.Name = "lbCategoria"
        lbCategoria.TabIndex = 2
        lbCategoria.Text = "Categoría:"
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategoria.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbCategoria.Location = New Point(16, 110)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(304, 25)
        cmbCategoria.TabIndex = 3
        ' 
        ' lbPrecio
        ' 
        lbPrecio.AutoSize = True
        lbPrecio.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbPrecio.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbPrecio.Location = New Point(16, 146)
        lbPrecio.Name = "lbPrecio"
        lbPrecio.TabIndex = 4
        lbPrecio.Text = "Precio $:"
        ' 
        ' nudPrecio
        ' 
        nudPrecio.DecimalPlaces = 2
        nudPrecio.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudPrecio.Location = New Point(16, 168)
        nudPrecio.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudPrecio.Name = "nudPrecio"
        nudPrecio.Size = New Size(140, 25)
        nudPrecio.TabIndex = 5
        nudPrecio.ThousandsSeparator = True
        ' 
        ' lbNivel
        ' 
        lbNivel.AutoSize = True
        lbNivel.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbNivel.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbNivel.Location = New Point(172, 146)
        lbNivel.Name = "lbNivel"
        lbNivel.TabIndex = 6
        lbNivel.Text = "Nivel:"
        ' 
        ' cmbNivel
        ' 
        cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNivel.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbNivel.Location = New Point(172, 168)
        cmbNivel.Name = "cmbNivel"
        cmbNivel.Size = New Size(148, 25)
        cmbNivel.TabIndex = 7
        ' 
        ' lbEstado
        ' 
        lbEstado.AutoSize = True
        lbEstado.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEstado.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbEstado.Location = New Point(16, 204)
        lbEstado.Name = "lbEstado"
        lbEstado.TabIndex = 8
        lbEstado.Text = "Estado:"
        ' 
        ' cmbEstado
        ' 
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbEstado.Location = New Point(16, 226)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(304, 25)
        cmbEstado.TabIndex = 9
        ' 
        ' lbDescripcion
        ' 
        lbDescripcion.AutoSize = True
        lbDescripcion.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbDescripcion.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbDescripcion.Location = New Point(16, 262)
        lbDescripcion.Name = "lbDescripcion"
        lbDescripcion.TabIndex = 10
        lbDescripcion.Text = "Descripción:"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.BorderStyle = BorderStyle.FixedSingle
        txtDescripcion.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescripcion.Location = New Point(16, 284)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.ScrollBars = ScrollBars.Vertical
        txtDescripcion.Size = New Size(304, 90)
        txtDescripcion.TabIndex = 11
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.White
        btnNuevo.Cursor = Cursors.Hand
        btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevo.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNuevo.Location = New Point(16, 390)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(96, 36)
        btnNuevo.TabIndex = 12
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(120, 390)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(96, 36)
        btnGuardar.TabIndex = 13
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(224, 390)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(96, 36)
        btnEliminar.TabIndex = 14
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLecciones
        ' 
        btnLecciones.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnLecciones.Cursor = Cursors.Hand
        btnLecciones.FlatAppearance.BorderSize = 0
        btnLecciones.FlatStyle = FlatStyle.Flat
        btnLecciones.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLecciones.ForeColor = Color.White
        btnLecciones.Location = New Point(16, 434)
        btnLecciones.Name = "btnLecciones"
        btnLecciones.Size = New Size(304, 34)
        btnLecciones.TabIndex = 15
        btnLecciones.Text = "Ver / cargar lecciones del curso"
        btnLecciones.UseVisualStyleBackColor = False
        ' 
        ' btnVistaPreviaFicha
        ' 
        btnVistaPreviaFicha.BackColor = Color.White
        btnVistaPreviaFicha.Cursor = Cursors.Hand
        btnVistaPreviaFicha.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnVistaPreviaFicha.FlatStyle = FlatStyle.Flat
        btnVistaPreviaFicha.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVistaPreviaFicha.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnVistaPreviaFicha.Location = New Point(16, 474)
        btnVistaPreviaFicha.Name = "btnVistaPreviaFicha"
        btnVistaPreviaFicha.Size = New Size(148, 30)
        btnVistaPreviaFicha.TabIndex = 16
        btnVistaPreviaFicha.Text = "Vista previa ficha"
        btnVistaPreviaFicha.UseVisualStyleBackColor = False
        ' 
        ' btnImprimirFicha
        ' 
        btnImprimirFicha.BackColor = Color.White
        btnImprimirFicha.Cursor = Cursors.Hand
        btnImprimirFicha.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnImprimirFicha.FlatStyle = FlatStyle.Flat
        btnImprimirFicha.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImprimirFicha.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnImprimirFicha.Location = New Point(172, 474)
        btnImprimirFicha.Name = "btnImprimirFicha"
        btnImprimirFicha.Size = New Size(148, 30)
        btnImprimirFicha.TabIndex = 17
        btnImprimirFicha.Text = "Imprimir ficha"
        btnImprimirFicha.UseVisualStyleBackColor = False
        ' 
        ' picPortada
        ' 
        picPortada.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        picPortada.BackColor = Color.WhiteSmoke
        picPortada.BorderStyle = BorderStyle.FixedSingle
        picPortada.Location = New Point(24, 436)
        picPortada.Name = "picPortada"
        picPortada.Size = New Size(200, 148)
        picPortada.SizeMode = PictureBoxSizeMode.Zoom
        picPortada.TabIndex = 20
        picPortada.TabStop = False
        ' 
        ' btnBuscarPortada
        ' 
        btnBuscarPortada.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnBuscarPortada.BackColor = Color.White
        btnBuscarPortada.Cursor = Cursors.Hand
        btnBuscarPortada.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnBuscarPortada.FlatStyle = FlatStyle.Flat
        btnBuscarPortada.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarPortada.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnBuscarPortada.Location = New Point(236, 436)
        btnBuscarPortada.Name = "btnBuscarPortada"
        btnBuscarPortada.Size = New Size(150, 36)
        btnBuscarPortada.TabIndex = 21
        btnBuscarPortada.Text = "Buscar portada"
        btnBuscarPortada.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarPortada
        ' 
        btnGuardarPortada.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGuardarPortada.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnGuardarPortada.Cursor = Cursors.Hand
        btnGuardarPortada.FlatAppearance.BorderSize = 0
        btnGuardarPortada.FlatStyle = FlatStyle.Flat
        btnGuardarPortada.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardarPortada.ForeColor = Color.White
        btnGuardarPortada.Location = New Point(236, 482)
        btnGuardarPortada.Name = "btnGuardarPortada"
        btnGuardarPortada.Size = New Size(150, 36)
        btnGuardarPortada.TabIndex = 22
        btnGuardarPortada.Text = "Guardar portada"
        btnGuardarPortada.UseVisualStyleBackColor = False
        ' 
        ' btnQuitarPortada
        ' 
        btnQuitarPortada.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnQuitarPortada.BackColor = Color.White
        btnQuitarPortada.Cursor = Cursors.Hand
        btnQuitarPortada.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnQuitarPortada.FlatStyle = FlatStyle.Flat
        btnQuitarPortada.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuitarPortada.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnQuitarPortada.Location = New Point(236, 528)
        btnQuitarPortada.Name = "btnQuitarPortada"
        btnQuitarPortada.Size = New Size(150, 36)
        btnQuitarPortada.TabIndex = 23
        btnQuitarPortada.Text = "Quitar portada"
        btnQuitarPortada.UseVisualStyleBackColor = False
        ' 
        ' frmProfesor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(900, 600)
        Controls.Add(picPortada)
        Controls.Add(btnBuscarPortada)
        Controls.Add(btnGuardarPortada)
        Controls.Add(btnQuitarPortada)
        Controls.Add(grpCurso)
        Controls.Add(dgvCursos)
        Controls.Add(pnlLinea)
        Controls.Add(btnCerrarSesion)
        Controls.Add(lbBienvenida)
        MinimumSize = New Size(916, 639)
        Name = "frmProfesor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Panel Profesor"
        CType(dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        grpCurso.ResumeLayout(False)
        grpCurso.PerformLayout()
        CType(nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba (despues va a decir Bienvenido + nombre)
    Friend WithEvents lbBienvenida As Label
    'boton para salir y volver al login
    Friend WithEvents btnCerrarSesion As Button
    'linea gris finita abajo del titulo
    Friend WithEvents pnlLinea As Panel
    'grilla con mis cursos
    Friend WithEvents dgvCursos As DataGridView
    'recuadro con los datos del curso
    Friend WithEvents grpCurso As GroupBox
    'texto Titulo
    Friend WithEvents lbTitulo As Label
    'caja para el titulo del curso
    Friend WithEvents txtTitulo As TextBox
    'texto Categoria
    Friend WithEvents lbCategoria As Label
    'combo con las categorias
    Friend WithEvents cmbCategoria As ComboBox
    'texto Precio
    Friend WithEvents lbPrecio As Label
    'caja de numeros para el precio
    Friend WithEvents nudPrecio As NumericUpDown
    'texto Nivel
    Friend WithEvents lbNivel As Label
    'combo con el nivel (inicial, intermedio...)
    Friend WithEvents cmbNivel As ComboBox
    'texto Estado
    Friend WithEvents lbEstado As Label
    'combo con el estado (borrador, publicado...)
    Friend WithEvents cmbEstado As ComboBox
    'texto Descripcion
    Friend WithEvents lbDescripcion As Label
    'caja para la descripcion (varias lineas)
    Friend WithEvents txtDescripcion As TextBox
    'boton para limpiar y cargar uno nuevo
    Friend WithEvents btnNuevo As Button
    'boton azul para guardar
    Friend WithEvents btnGuardar As Button
    'boton rojo para eliminar
    Friend WithEvents btnEliminar As Button
    'boton para ir a las lecciones
    Friend WithEvents btnLecciones As Button
    'boton para ver como sale la ficha
    Friend WithEvents btnVistaPreviaFicha As Button
    'boton para imprimir la ficha
    Friend WithEvents btnImprimirFicha As Button

    'la hoja que se imprime, se dibuja en el evento PrintPage
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    'ventana de vista previa
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    'ventana para elegir la impresora
    Friend WithEvents PrintDialog1 As PrintDialog

    'portada del curso
    Friend WithEvents picPortada As PictureBox
    'busca una imagen en la compu
    Friend WithEvents btnBuscarPortada As Button
    'guarda la imagen en la base
    Friend WithEvents btnGuardarPortada As Button
    'borra la portada del curso
    Friend WithEvents btnQuitarPortada As Button

End Class
