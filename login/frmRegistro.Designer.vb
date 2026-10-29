<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistro
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
        lbTitulo = New Label()
        lbNombre = New Label()
        txtNombre = New TextBox()
        lbApellido = New Label()
        txtApellido = New TextBox()
        lbDni = New Label()
        txtDni = New TextBox()
        lbEmail = New Label()
        txtEmail = New TextBox()
        lbClave = New Label()
        txtClave = New TextBox()
        lbClave2 = New Label()
        txtClave2 = New TextBox()
        lbRol = New Label()
        cmbRol = New ComboBox()
        btnRegistrarme = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' lbTitulo
        ' 
        lbTitulo.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTitulo.ForeColor = Color.Black
        lbTitulo.Location = New Point(0, 22)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(400, 34)
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Registro"
        lbTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbNombre
        ' 
        lbNombre.AutoSize = True
        lbNombre.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbNombre.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbNombre.Location = New Point(40, 74)
        lbNombre.Name = "lbNombre"
        lbNombre.Size = New Size(65, 19)
        lbNombre.TabIndex = 1
        lbNombre.Text = "Nombre"
        ' 
        ' txtNombre
        ' 
        txtNombre.BorderStyle = BorderStyle.FixedSingle
        txtNombre.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombre.Location = New Point(40, 96)
        txtNombre.MaxLength = 20
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(152, 27)
        txtNombre.TabIndex = 2
        ' 
        ' lbApellido
        ' 
        lbApellido.AutoSize = True
        lbApellido.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbApellido.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbApellido.Location = New Point(208, 74)
        lbApellido.Name = "lbApellido"
        lbApellido.Size = New Size(66, 19)
        lbApellido.TabIndex = 3
        lbApellido.Text = "Apellido"
        ' 
        ' txtApellido
        ' 
        txtApellido.BorderStyle = BorderStyle.FixedSingle
        txtApellido.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtApellido.Location = New Point(208, 96)
        txtApellido.MaxLength = 20
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(152, 27)
        txtApellido.TabIndex = 4
        ' 
        ' lbDni
        ' 
        lbDni.AutoSize = True
        lbDni.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbDni.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbDni.Location = New Point(40, 136)
        lbDni.Name = "lbDni"
        lbDni.Size = New Size(34, 19)
        lbDni.TabIndex = 5
        lbDni.Text = "DNI"
        ' 
        ' txtDni
        ' 
        txtDni.BorderStyle = BorderStyle.FixedSingle
        txtDni.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDni.Location = New Point(40, 158)
        txtDni.MaxLength = 8
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(320, 27)
        txtDni.TabIndex = 6
        ' 
        ' lbEmail
        ' 
        lbEmail.AutoSize = True
        lbEmail.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEmail.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbEmail.Location = New Point(40, 198)
        lbEmail.Name = "lbEmail"
        lbEmail.Size = New Size(45, 19)
        lbEmail.TabIndex = 7
        lbEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(40, 220)
        txtEmail.MaxLength = 50
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(320, 27)
        txtEmail.TabIndex = 8
        ' 
        ' lbClave
        ' 
        lbClave.AutoSize = True
        lbClave.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbClave.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbClave.Location = New Point(40, 260)
        lbClave.Name = "lbClave"
        lbClave.Size = New Size(84, 19)
        lbClave.TabIndex = 9
        lbClave.Text = "Contraseña"
        ' 
        ' txtClave
        ' 
        txtClave.BorderStyle = BorderStyle.FixedSingle
        txtClave.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtClave.Location = New Point(40, 282)
        txtClave.MaxLength = 50
        txtClave.Name = "txtClave"
        txtClave.Size = New Size(320, 27)
        txtClave.TabIndex = 10
        txtClave.UseSystemPasswordChar = True
        ' 
        ' lbClave2
        ' 
        lbClave2.AutoSize = True
        lbClave2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbClave2.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbClave2.Location = New Point(40, 322)
        lbClave2.Name = "lbClave2"
        lbClave2.Size = New Size(135, 19)
        lbClave2.TabIndex = 11
        lbClave2.Text = "Repetir contraseña"
        ' 
        ' txtClave2
        ' 
        txtClave2.BorderStyle = BorderStyle.FixedSingle
        txtClave2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtClave2.Location = New Point(40, 344)
        txtClave2.MaxLength = 50
        txtClave2.Name = "txtClave2"
        txtClave2.Size = New Size(320, 27)
        txtClave2.TabIndex = 12
        txtClave2.UseSystemPasswordChar = True
        ' 
        ' lbRol
        ' 
        lbRol.AutoSize = True
        lbRol.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbRol.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbRol.Location = New Point(40, 384)
        lbRol.Name = "lbRol"
        lbRol.Size = New Size(180, 19)
        lbRol.TabIndex = 13
        lbRol.Text = "Quiero registrarme como"
        ' 
        ' cmbRol
        ' 
        cmbRol.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRol.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRol.FormattingEnabled = True
        cmbRol.Items.AddRange(New Object() {"Alumno", "Profesor", "Cobranza"})
        cmbRol.Location = New Point(40, 406)
        cmbRol.Name = "cmbRol"
        cmbRol.Size = New Size(320, 28)
        cmbRol.TabIndex = 14
        ' 
        ' btnRegistrarme
        ' 
        btnRegistrarme.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnRegistrarme.Cursor = Cursors.Hand
        btnRegistrarme.FlatAppearance.BorderSize = 0
        btnRegistrarme.FlatStyle = FlatStyle.Flat
        btnRegistrarme.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrarme.ForeColor = Color.White
        btnRegistrarme.Location = New Point(40, 456)
        btnRegistrarme.Name = "btnRegistrarme"
        btnRegistrarme.Size = New Size(320, 40)
        btnRegistrarme.TabIndex = 15
        btnRegistrarme.Text = "Registrarme"
        btnRegistrarme.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.White
        btnCancelar.Cursor = Cursors.Hand
        btnCancelar.DialogResult = DialogResult.Cancel
        btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCancelar.Location = New Point(40, 506)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(320, 36)
        btnCancelar.TabIndex = 16
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' frmRegistro
        ' 
        AcceptButton = btnRegistrarme
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = btnCancelar
        ClientSize = New Size(400, 566)
        Controls.Add(btnCancelar)
        Controls.Add(btnRegistrarme)
        Controls.Add(cmbRol)
        Controls.Add(lbRol)
        Controls.Add(txtClave2)
        Controls.Add(lbClave2)
        Controls.Add(txtClave)
        Controls.Add(lbClave)
        Controls.Add(txtEmail)
        Controls.Add(lbEmail)
        Controls.Add(txtDni)
        Controls.Add(lbDni)
        Controls.Add(txtApellido)
        Controls.Add(lbApellido)
        Controls.Add(txtNombre)
        Controls.Add(lbNombre)
        Controls.Add(lbTitulo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmRegistro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Crear cuenta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba (dice Registro)
    Friend WithEvents lbTitulo As Label
    'texto Nombre
    Friend WithEvents lbNombre As Label
    'caja del nombre (max 20 como en la base)
    Friend WithEvents txtNombre As TextBox
    'texto Apellido
    Friend WithEvents lbApellido As Label
    'caja del apellido (max 20)
    Friend WithEvents txtApellido As TextBox
    'texto DNI
    Friend WithEvents lbDni As Label
    'caja del dni (max 8)
    Friend WithEvents txtDni As TextBox
    'texto Email
    Friend WithEvents lbEmail As Label
    'caja del email (max 50)
    Friend WithEvents txtEmail As TextBox
    'texto Contraseña
    Friend WithEvents lbClave As Label
    'caja de la clave (muestra puntitos)
    Friend WithEvents txtClave As TextBox
    'texto Repetir contraseña
    Friend WithEvents lbClave2 As Label
    'caja para repetir la clave y ver que coincidan
    Friend WithEvents txtClave2 As TextBox
    'texto del rol
    Friend WithEvents lbRol As Label
    'combo para elegir el rol (admin no, eso lo da el administrador)
    Friend WithEvents cmbRol As ComboBox
    'boton azul para crear la cuenta
    Friend WithEvents btnRegistrarme As Button
    'boton blanco para cancelar (cierra el form solo, tambien con Esc)
    Friend WithEvents btnCancelar As Button

End Class
