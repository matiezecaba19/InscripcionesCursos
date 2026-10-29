Imports MySqlConnector
Imports ScottPlot

'tablero con graficos para el admin, lo abre el boton Tablero
Public Class frmTablero

    'grafico de barras: cuantas inscripciones tiene cada curso
    Sub GraficoBarras()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                'cuento las inscripciones de cada curso
                'GROUP BY junta las filas del mismo curso y COUNT las cuenta
                Dim sql As String = "SELECT c.titulo, COUNT(i.id) AS cantidad " &
                    "FROM cursos c " &
                    "JOIN inscripciones i ON i.curso_id = c.id " &
                    "GROUP BY c.titulo " &
                    "ORDER BY c.titulo;"

                Using cmd As New MySqlCommand(sql, cn)
                    'dos listas, una para los numeros y otra para los nombres
                    Dim cantidades As New List(Of Double)
                    Dim nombres As New List(Of String)

                    Using rd = cmd.ExecuteReader()
                        While rd.Read()
                            nombres.Add(rd("titulo").ToString())
                            cantidades.Add(CDbl(rd("cantidad")))
                        End While
                    End Using

                    'limpio el grafico
                    FormsPlot1.Plot.Clear()

                    'creo las barras, hay que pasar la lista a arreglo con ToArray
                    Dim barras = FormsPlot1.Plot.Add.Bars(cantidades.ToArray())

                    'colores para las barras
                    Dim colores() = {
                        ScottPlot.Colors.Blue,
                        ScottPlot.Colors.Green,
                        ScottPlot.Colors.Red,
                        ScottPlot.Colors.Orange,
                        ScottPlot.Colors.Purple
                        }

                    'a cada barra le pongo un color y la agrego a la leyenda con su nombre
                    For i As Integer = 0 To cantidades.Count - 1
                        Dim color As ScottPlot.Color = colores(i Mod colores.Length)
                        barras.Bars(i).FillColor = color
                        FormsPlot1.Plot.Legend.ManualItems.Add(New ScottPlot.LegendItem With {.LabelText = nombres(i), .FillColor = color})
                    Next

                    'leyenda abajo y en horizontal
                    FormsPlot1.Plot.ShowLegend(ScottPlot.Edge.Bottom)
                    FormsPlot1.Plot.Legend.Orientation = ScottPlot.Orientation.Horizontal

                    FormsPlot1.Plot.Title("Inscripciones por curso")
                    FormsPlot1.Plot.HideGrid()

                    'que el eje de abajo empiece en 0
                    FormsPlot1.Plot.Axes.Margins(bottom:=0)

                    FormsPlot1.Refresh()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'grafico de torta: cuantas inscripciones hay de cada estado
    Sub GraficoTorta()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT estado, COUNT(*) AS cantidad " &
                    "FROM inscripciones " &
                    "GROUP BY estado " &
                    "ORDER BY estado;"

                Using cmd As New MySqlCommand(sql, cn)
                    'lista de porciones de la torta
                    Dim porciones As New List(Of ScottPlot.PieSlice)

                    FormsPlot2.Plot.Clear()

                    Using rd = cmd.ExecuteReader()
                        While rd.Read()
                            Dim estado As String = rd("estado").ToString()
                            Dim cantidad As Double = CDbl(rd("cantidad"))

                            'creo la porcion con su numero, el nombre para la leyenda y el color
                            Dim porcion As New ScottPlot.PieSlice
                            porcion.Value = cantidad
                            porcion.Label = cantidad.ToString()
                            porcion.LegendText = estado
                            porcion.LabelBold = True

                            'cada estado con su color: verde aceptada, naranja pendiente y rojo rechazada
                            If estado = "aceptada" Then
                                porcion.FillColor = ScottPlot.Colors.Green
                            ElseIf estado = "pendiente_pago" Then
                                porcion.FillColor = ScottPlot.Colors.Orange
                            Else
                                porcion.FillColor = ScottPlot.Colors.Red
                            End If

                            porciones.Add(porcion)
                        End While
                    End Using

                    'creo la torta con las porciones
                    Dim torta = FormsPlot2.Plot.Add.Pie(porciones)
                    'separo un poco las porciones
                    torta.ExplodeFraction = 0.1
                    'donde va el numero adentro de cada porcion
                    torta.SliceLabelDistance = 0.6

                    FormsPlot2.Plot.ShowLegend(ScottPlot.Edge.Bottom)
                    FormsPlot2.Plot.Legend.Orientation = ScottPlot.Orientation.Horizontal

                    'en la torta no van ejes ni grilla
                    FormsPlot2.Plot.HideAxesAndGrid()
                    'el titulo despues, porque HideAxesAndGrid tambien lo esconde
                    FormsPlot2.Plot.Title("Inscripciones por estado")
                    FormsPlot2.Plot.Axes.Title.IsVisible = True

                    FormsPlot2.Refresh()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(traducirError(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'al abrir cargo los 2 graficos
    Private Sub frmTablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GraficoBarras()
        GraficoTorta()
    End Sub

    'boton cerrar
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class
