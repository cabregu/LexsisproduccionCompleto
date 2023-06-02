Public Class FrmRemitosLexs

    Private Sub PbRemito_Paint(sender As Object, e As PaintEventArgs) Handles PbRemito.Paint
        ' Obtén el valor actual del DateTimePicker
        Dim fecha As DateTime = DtpDesde.Value

        ' Configura la fuente y el color del texto
        Dim fuente As New Font("Arial", 12)
        Dim colorTexto As Color = Color.White

        ' Dibuja el texto en la posición deseada
        e.Graphics.DrawString(fecha.ToString(), fuente, New SolidBrush(colorTexto), New PointF(100, 100))
    End Sub

    Private Sub FrmRemitosLexs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagenPrincipal As Image = My.Resources.RemitoLexs
        PbRemito.Image = imagenPrincipal
        PbRemito.SizeMode = PictureBoxSizeMode.AutoSize
        'PbRemito.Refresh() ' Actualiza el PictureBox para que se llame al evento Paint y se dibuje el texto
    End Sub

    Private Sub BtnDibujar_Click(sender As Object, e As EventArgs) Handles BtnDibujar.Click
        PbRemito.Refresh()

    End Sub
End Class
