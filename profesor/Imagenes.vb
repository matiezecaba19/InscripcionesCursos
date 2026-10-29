Imports System.IO

'funciones para pasar una imagen a bytes y al reves, asi se puede guardar en la base
Module Imagenes

    'convierte la imagen del PictureBox en un arreglo de bytes para el BLOB
    Public Function ImagenABytes(imagen As Image) As Byte()
        'MemoryStream es como un archivo pero en memoria
        Using ms As New MemoryStream()
            'la guardo como jpg para que pese menos
            imagen.Save(ms, Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

    'convierte los bytes que vienen de la base en una imagen para el PictureBox
    Public Function BytesAImagen(datos As Byte()) As Image
        Using ms As New MemoryStream(datos)
            'hago una copia con New Bitmap porque cuando se cierra el MemoryStream la imagen se rompe
            Return New Bitmap(Image.FromStream(ms))
        End Using
    End Function

End Module
