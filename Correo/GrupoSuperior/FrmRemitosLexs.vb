
Public Class FrmRemitosLexs

    Private Sub DibujarFechaEnImagen()
        ' Obtén los valores del TextBox y otras variables
        Dim numero As String = TxtRemito.Text
        Dim fecha As Date = DtpDesde.Value
        Dim empresa As String = "SWISS MEDICAL"
        Dim direccion As String = "VIAMONTE 44456"
        Dim codigoPostal As String = "1254"

        ' Configura la fuente y el color del texto
        Dim fuente As New Font("Arial", 12, FontStyle.Bold)
        Dim colorTexto As Color = Color.Black

        ' Crea una imagen con el tamaño actual del PictureBox
        Dim bmp As New Bitmap(PbRemito.Width, PbRemito.Height)

        ' Dibuja el texto en la posición deseada
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(PbRemito.Image, Point.Empty) ' Copia la imagen original al nuevo Bitmap

            ' Dibujar el número en la posición deseada
            Dim numeroPosicion As New PointF(566, 73)
            g.DrawString(numero, fuente, New SolidBrush(colorTexto), numeroPosicion)

            ' Dibujar el texto adicional en ubicaciones diferentes
            Dim textoPosicion As New PointF(203, 180)
            g.DrawString(empresa, fuente, New SolidBrush(colorTexto), textoPosicion)

            ' Otros elementos de texto y ubicaciones
            textoPosicion = New PointF(208, 198)
            g.DrawString(direccion, fuente, New SolidBrush(colorTexto), textoPosicion)

            textoPosicion = New PointF(379, 200)
            g.DrawString(codigoPostal, fuente, New SolidBrush(colorTexto), textoPosicion)

            ' Dibujar la fecha en la posición deseada
            Dim fechaPosicion As New PointF(557, 130)
            g.DrawString(fecha.ToShortDateString(), fuente, New SolidBrush(colorTexto), fechaPosicion)
        End Using

        PbRemito.Image = bmp
    End Sub

    Private Sub FrmRemitosLexs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagenPrincipal As Image = My.Resources.RemitoLexs
        PbRemito.Image = imagenPrincipal
        PbRemito.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub BtnDibujar_Click(sender As Object, e As EventArgs) Handles BtnDibujar.Click
        DibujarFechaEnImagen()
        PegarImagenDesdePortapapeles()

    End Sub

    Private Sub PegarImagenDesdePortapapeles()
        ' Verificar si hay una imagen en el portapapeles
        If Clipboard.ContainsImage() Then
            ' Obtener la imagen del portapapeles
            Dim imagen As Image = Clipboard.GetImage()

            ' Crear una imagen con el tamaño actual del PictureBox
            Dim bmp As New Bitmap(PbRemito.Width, PbRemito.Height)

            ' Dibujar la imagen original en el nuevo Bitmap
            Using g As Graphics = Graphics.FromImage(bmp)
                g.DrawImage(PbRemito.Image, Point.Empty)

                ' Dibujar la imagen del portapapeles en la ubicación deseada (92X314)
                g.DrawImage(imagen, New Rectangle(92, 314, imagen.Width, imagen.Height))
            End Using

            ' Asignar el nuevo Bitmap al PictureBox
            PbRemito.Image = bmp
            PbRemito.SizeMode = PictureBoxSizeMode.AutoSize
        Else
            ' No se encontró una imagen en el portapapeles
            MessageBox.Show("No hay una imagen válida en el portapapeles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




End Class
