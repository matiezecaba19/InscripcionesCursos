<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        lbDni = New Label()
        txtDni = New TextBox()
        lbClave = New Label()
        txtClave = New TextBox()
        btnIngresar = New Button()
        btnRegistrarse = New Button()
        SuspendLayout()
        ' 
        ' lbTitulo
        ' 
        lbTitulo.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTitulo.ForeColor = Color.Black
        lbTitulo.Location = New Point(0, 30)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(360, 34)
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Login"
        lbTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbDni
        ' 
        lbDni.AutoSize = True
        lbDni.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbDni.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbDni.Location = New Point(40, 90)
        lbDni.Name = "lbDni"
        lbDni.Size = New Size(34, 19)
        lbDni.TabIndex = 1
        lbDni.Text = "DNI"
        ' 
        ' txtDni
        ' 
        txtDni.BorderStyle = BorderStyle.FixedSingle
        txtDni.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDni.Location = New Point(40, 114)
        txtDni.MaxLength = 8
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(280, 29)
        txtDni.TabIndex = 2
        ' 
        ' lbClave
        ' 
        lbClave.AutoSize = True
        lbClave.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbClave.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lbClave.Location = New Point(40, 160)
        lbClave.Name = "lbClave"
        lbClave.Size = New Size(84, 19)
        lbClave.TabIndex = 3
        lbClave.Text = "Contraseña"
        ' 
        ' txtClave
        ' 
        txtClave.BorderStyle = BorderStyle.FixedSingle
        txtClave.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtClave.Location = New Point(40, 184)
        txtClave.Name = "txtClave"
        txtClave.Size = New Size(280, 29)
        txtClave.TabIndex = 4
        txtClave.UseSystemPasswordChar = True
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnIngresar.Cursor = Cursors.Hand
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.ForeColor = Color.White
        btnIngresar.Location = New Point(40, 242)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(280, 40)
        btnIngresar.TabIndex = 5
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarse
        ' 
        btnRegistrarse.BackColor = Color.White
        btnRegistrarse.Cursor = Cursors.Hand
        btnRegistrarse.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnRegistrarse.FlatStyle = FlatStyle.Flat
        btnRegistrarse.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrarse.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnRegistrarse.Location = New Point(40, 294)
        btnRegistrarse.Name = "btnRegistrarse"
        btnRegistrarse.Size = New Size(280, 36)
        btnRegistrarse.TabIndex = 6
        btnRegistrarse.Text = "Crear una cuenta"
        btnRegistrarse.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AcceptButton = btnIngresar
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(360, 360)
        Controls.Add(btnRegistrarse)
        Controls.Add(btnIngresar)
        Controls.Add(txtClave)
        Controls.Add(lbClave)
        Controls.Add(txtDni)
        Controls.Add(lbDni)
        Controls.Add(lbTitulo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar Sesion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba (dice Login)
    Friend WithEvents lbTitulo As Label
    'texto "DNI"
    Friend WithEvents lbDni As Label
    'caja donde escribe el dni (max 8 numeros)
    Friend WithEvents txtDni As TextBox
    'texto "Contraseña"
    Friend WithEvents lbClave As Label
    'caja de la clave (muestra puntitos)
    Friend WithEvents txtClave As TextBox
    'boton azul para entrar
    Friend WithEvents btnIngresar As Button
    'boton blanco para ir al registro
    Friend WithEvents btnRegistrarse As Button

End Class
