<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLecciones
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
        lbCurso = New Label()
        lbAyuda = New Label()
        dgvLecciones = New DataGridView()
        btnSubir = New Button()
        btnBajar = New Button()
        lbTema = New Label()
        txtTema = New TextBox()
        btnNueva = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnCerrar = New Button()
        CType(dgvLecciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' lbCurso
        '
        lbCurso.AutoEllipsis = True
        lbCurso.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbCurso.ForeColor = Color.Black
        lbCurso.Location = New Point(24, 18)
        lbCurso.Name = "lbCurso"
        lbCurso.Size = New Size(472, 32)
        lbCurso.TabIndex = 0
        lbCurso.Text = "Índice del curso"
        '
        ' lbAyuda
        '
        lbAyuda.AutoSize = True
        lbAyuda.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbAyuda.ForeColor = Color.Gray
        lbAyuda.Location = New Point(26, 52)
        lbAyuda.Name = "lbAyuda"
        lbAyuda.TabIndex = 1
        lbAyuda.Text = "Estos temas los ve el alumno en el catálogo antes de inscribirse."
        '
        ' dgvLecciones
        '
        dgvLecciones.AllowUserToAddRows = False
        dgvLecciones.AllowUserToDeleteRows = False
        dgvLecciones.AllowUserToResizeRows = False
        dgvLecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLecciones.BackgroundColor = Color.White
        dgvLecciones.BorderStyle = BorderStyle.FixedSingle
        dgvLecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLecciones.Location = New Point(24, 80)
        dgvLecciones.MultiSelect = False
        dgvLecciones.Name = "dgvLecciones"
        dgvLecciones.ReadOnly = True
        dgvLecciones.RowHeadersVisible = False
        dgvLecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLecciones.Size = New Size(400, 260)
        dgvLecciones.TabIndex = 2
        '
        ' btnSubir
        '
        btnSubir.BackColor = Color.White
        btnSubir.Cursor = Cursors.Hand
        btnSubir.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSubir.FlatStyle = FlatStyle.Flat
        btnSubir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubir.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSubir.Location = New Point(436, 80)
        btnSubir.Name = "btnSubir"
        btnSubir.Size = New Size(60, 40)
        btnSubir.TabIndex = 3
        btnSubir.Text = "▲ Subir"
        btnSubir.UseVisualStyleBackColor = False
        '
        ' btnBajar
        '
        btnBajar.BackColor = Color.White
        btnBajar.Cursor = Cursors.Hand
        btnBajar.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnBajar.FlatStyle = FlatStyle.Flat
        btnBajar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBajar.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnBajar.Location = New Point(436, 128)
        btnBajar.Name = "btnBajar"
        btnBajar.Size = New Size(60, 40)
        btnBajar.TabIndex = 4
        btnBajar.Text = "▼ Bajar"
        btnBajar.UseVisualStyleBackColor = False
        '
        ' lbTema
        '
        lbTema.AutoSize = True
        lbTema.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTema.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbTema.Location = New Point(24, 352)
        lbTema.Name = "lbTema"
        lbTema.TabIndex = 5
        lbTema.Text = "Tema:"
        '
        ' txtTema
        '
        txtTema.BorderStyle = BorderStyle.FixedSingle
        txtTema.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTema.Location = New Point(24, 374)
        txtTema.MaxLength = 150
        txtTema.Name = "txtTema"
        txtTema.Size = New Size(472, 27)
        txtTema.TabIndex = 6
        '
        ' btnNueva
        '
        btnNueva.BackColor = Color.White
        btnNueva.Cursor = Cursors.Hand
        btnNueva.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNueva.FlatStyle = FlatStyle.Flat
        btnNueva.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNueva.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNueva.Location = New Point(24, 416)
        btnNueva.Name = "btnNueva"
        btnNueva.Size = New Size(150, 36)
        btnNueva.TabIndex = 7
        btnNueva.Text = "Nuevo tema"
        btnNueva.UseVisualStyleBackColor = False
        '
        ' btnGuardar
        '
        btnGuardar.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(185, 416)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(150, 36)
        btnGuardar.TabIndex = 8
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
        btnEliminar.Location = New Point(346, 416)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(150, 36)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        '
        ' btnCerrar
        '
        btnCerrar.BackColor = Color.White
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.DialogResult = DialogResult.Cancel
        btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrar.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCerrar.Location = New Point(24, 464)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(472, 36)
        btnCerrar.TabIndex = 10
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = False
        '
        ' frmLecciones
        '
        AcceptButton = btnGuardar
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = btnCerrar
        ClientSize = New Size(520, 524)
        Controls.Add(btnCerrar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNueva)
        Controls.Add(txtTema)
        Controls.Add(lbTema)
        Controls.Add(btnBajar)
        Controls.Add(btnSubir)
        Controls.Add(dgvLecciones)
        Controls.Add(lbAyuda)
        Controls.Add(lbCurso)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLecciones"
        StartPosition = FormStartPosition.CenterParent
        Text = "Lecciones del curso"
        CType(dgvLecciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba con el nombre del curso
    Friend WithEvents lbCurso As Label
    'texto gris que explica para que sirve
    Friend WithEvents lbAyuda As Label
    'grilla con los temas en orden
    Friend WithEvents dgvLecciones As DataGridView
    'sube el tema elegido un lugar
    Friend WithEvents btnSubir As Button
    'baja el tema elegido un lugar
    Friend WithEvents btnBajar As Button
    'texto Tema
    Friend WithEvents lbTema As Label
    'caja para escribir el tema (max 150 como en la base)
    Friend WithEvents txtTema As TextBox
    'limpia la caja para escribir un tema nuevo
    Friend WithEvents btnNueva As Button
    'boton azul: agrega o modifica el tema
    Friend WithEvents btnGuardar As Button
    'boton rojo: borra el tema elegido
    Friend WithEvents btnEliminar As Button
    'cierra la ventana (solo, tambien con Esc)
    Friend WithEvents btnCerrar As Button

End Class
