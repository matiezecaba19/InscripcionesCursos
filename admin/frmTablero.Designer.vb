<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTablero
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
        FormsPlot1 = New ScottPlot.WinForms.FormsPlot()
        FormsPlot2 = New ScottPlot.WinForms.FormsPlot()
        btnCerrar = New Button()
        SuspendLayout()
        '
        ' lbTitulo
        '
        lbTitulo.AutoSize = True
        lbTitulo.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTitulo.ForeColor = Color.Black
        lbTitulo.Location = New Point(20, 16)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Tablero"
        '
        ' FormsPlot1
        '
        FormsPlot1.Location = New Point(20, 64)
        FormsPlot1.Name = "FormsPlot1"
        FormsPlot1.Size = New Size(470, 400)
        FormsPlot1.TabIndex = 1
        '
        ' FormsPlot2
        '
        FormsPlot2.Location = New Point(510, 64)
        FormsPlot2.Name = "FormsPlot2"
        FormsPlot2.Size = New Size(470, 400)
        FormsPlot2.TabIndex = 2
        '
        ' btnCerrar
        '
        btnCerrar.BackColor = Color.White
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrar.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnCerrar.Location = New Point(860, 476)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(120, 36)
        btnCerrar.TabIndex = 3
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = False
        '
        ' frmTablero
        '
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = btnCerrar
        ClientSize = New Size(1000, 526)
        Controls.Add(btnCerrar)
        Controls.Add(FormsPlot2)
        Controls.Add(FormsPlot1)
        Controls.Add(lbTitulo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmTablero"
        StartPosition = FormStartPosition.CenterParent
        Text = "Tablero"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'titulo de arriba
    Friend WithEvents lbTitulo As Label
    'grafico de barras
    Friend WithEvents FormsPlot1 As ScottPlot.WinForms.FormsPlot
    'grafico de torta
    Friend WithEvents FormsPlot2 As ScottPlot.WinForms.FormsPlot
    'cierra la ventana
    Friend WithEvents btnCerrar As Button

End Class
