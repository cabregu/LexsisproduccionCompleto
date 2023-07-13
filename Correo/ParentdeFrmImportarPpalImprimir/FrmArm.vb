Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class FrmArm

    Public DtImprimir As New DataTable
    Dim Dtdatos As New DataTable

    Private Sub FrmArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ArrayRemitentes As New ArrayList()
            ArrayRemitentes = ConfigCorreo.CN_Correo.CargarTodoslosremitente()

            If ArrayRemitentes IsNot Nothing Then
                CmbRemitente.Items.Clear()

                For i As Integer = 0 To ArrayRemitentes.Count - 1
                    CmbRemitente.Items.Add(ArrayRemitentes.Item(i).ToString())
                Next
            End If
        Catch ex As Exception
            ' Manejar la excepción aquí
        End Try

    End Sub
    Private Sub CmbRemitente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRemitente.SelectedIndexChanged
        Dim ArrServiciosremitoslexs As New ArrayList
        ArrServiciosremitoslexs = ConfigCorreo.CN_Correo.RemitosdeCteremitosLexsImportado(CmbRemitente.Text)

        For i As Integer = 0 To ArrServiciosremitoslexs.Count - 1
            CmbRemitoPendiente.Items.Add(ArrServiciosremitoslexs.Item(i).ToString)
        Next

        CmbRemitente.Enabled = False
        CmbRemitoPendiente.Enabled = True

    End Sub
    Private Sub CmbRemitoPendiente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRemitoPendiente.SelectedIndexChanged
        If Len(CmbRemitente.Text) > 0 Then
            CmbRemitoPendiente.Enabled = False
            DtImprimir = ConfigCorreo.CN_Correo.LlenarDatatableImprimirArm(CmbRemitoPendiente.Text)
            DgvSeleccion.DataSource = DtImprimir


            For Each col As DataGridViewColumn In DgvSeleccion.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            LblCant.Text = DgvSeleccion.RowCount

        End If
    End Sub
    Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView)
        Try
            ' Crear una nueva instancia de Excel
            Dim exApp As Object = CreateObject("Excel.Application")
            exApp.Visible = True

            ' Crear un nuevo libro y una nueva hoja
            Dim exLibro As Object = exApp.Workbooks.Add()
            Dim exHoja As Object = exLibro.Worksheets.Add()

            ' Establecer el formato de todas las celdas como texto
            exHoja.Cells.NumberFormat = "@"

            ' Obtener el número de filas y columnas
            Dim NCol As Integer = dgv.ColumnCount
            Dim NRow As Integer = dgv.RowCount

            ' Copiar los nombres de las columnas al libro
            Dim rg As Object = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(1, NCol))
            rg.Value = dgv.Columns.Cast(Of DataGridViewColumn).Select(Function(c) c.HeaderText).ToArray()

            ' Copiar los datos del DataGridView al libro
            Dim data(NRow - 1, NCol - 1) As Object
            For i As Integer = 0 To NRow - 1
                For j As Integer = 0 To NCol - 1
                    data(i, j) = dgv.Rows(i).Cells(j).Value
                Next
            Next
            rg = exHoja.Range(exHoja.Cells(2, 1), exHoja.Cells(NRow + 1, NCol))
            rg.Value = data

            ' Ajustar el ancho de las columnas para que se ajusten al contenido
            rg = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(NRow + 1, NCol))
            rg.EntireColumn.AutoFit()

            ' Guardar el archivo de Excel y cerrar la aplicación de Excel
            'exLibro.SaveAs("C:\temp\Transito.xls")
            'exLibro.Close(True)
            'exApp.Quit()

            MsgBox("Datos exportados exitosamente a Excel.", MsgBoxStyle.Information, "Exportar a Excel")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub
    Private Sub BtnXls_Click(sender As Object, e As EventArgs)
        ExportarDataGridViewAExcel(DgvSeleccion)
    End Sub

    Private Sub DgvSeleccion_DoubleClick(sender As Object, e As EventArgs) Handles DgvSeleccion.DoubleClick
        Dim N As String = DgvSeleccion.SelectedCells(0).RowIndex.ToString
        Dim EMPRESA As String = DgvSeleccion.Rows(N).Cells("EMPRESA").Value
        Dim CALLE As String = DgvSeleccion.Rows(N).Cells("CALLE").Value
        DgvDatos.DataSource = Nothing

        Dtdatos = ConfigCorreo.CN_Correo.LlenarDatatableImprimirArmPorEmpresaYCalle(EMPRESA, CALLE, CmbRemitoPendiente.Text)
        DgvDatos.DataSource = Dtdatos

        For Each col As DataGridViewColumn In DgvDatos.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For Each row As DataGridViewRow In DgvDatos.Rows
            Dim empresadato As String = row.Cells("empresa").Value.ToString()
            Dim calledato As String = row.Cells("calle").Value.ToString()

            For Each drws As DataGridViewRow In DgvSeleccion.Rows
                If drws.Cells("empresa").Value = empresadato And drws.Cells("calle").Value = calledato Then
                    drws.DefaultCellStyle.BackColor = Color.Green
                Else
                    drws.DefaultCellStyle.BackColor = Color.White
                End If
            Next
        Next

    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click
        GenerarPDF(Dtdatos)
    End Sub


    'Public Sub GenerarPDF()
    '    Dim doc As New Document()
    '    Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("C:\temp\archivo.pdf", FileMode.Create))
    '    doc.Open()

    '    Dim contentLeft As New Paragraph()
    '    contentLeft.Add(New Chunk("Título", New Font(Font.Italic, 16, Font.Bold)))
    '    contentLeft.Add(New Chunk(vbCrLf & vbCrLf))

    '    Dim rectangle1 As New Rectangle(doc.PageSize.Width / 2, doc.PageSize.Height)
    '    Dim canvasLeft As PdfContentByte = writer.DirectContent
    '    canvasLeft.SetColorStroke(BaseColor.BLACK) ' Establecer el color de trazo como negro
    '    canvasLeft.Rectangle(rectangle1.Left, rectangle1.Bottom, rectangle1.Width, rectangle1.Height)
    '    canvasLeft.Rectangle(10, 660, 180, 100)
    '    canvasLeft.Stroke()
    '    contentLeft.Add(New Chunk(vbCrLf))

    '    contentLeft.Add(New Chunk("Línea 1" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
    '    contentLeft.Add(New Chunk("Línea 2" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
    '    contentLeft.Add(New Chunk("Línea 3" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
    '    contentLeft.Add(New Chunk("Línea 4" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))


    '    contentLeft.Add(New Chunk(vbCrLf & vbCrLf))
    '    contentLeft.Add(New Chunk(vbCrLf & vbCrLf))

    '    contentLeft.Add(New Chunk("Firma" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
    '    contentLeft.Add(New Chunk("Aclaración" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))

    '    doc.Add(contentLeft)
    '    doc.Close()

    '    Process.Start("C:\temp\archivo.pdf")
    'End Sub

    Public Sub GenerarPDF(dataTable As DataTable)
        Dim doc As New Document()
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("C:\temp\archivo.pdf", FileMode.Create))
        doc.Open()

        Dim contentLeft As New Paragraph()
        contentLeft.Add(New Chunk("Título", New Font(Font.Italic, 16, Font.Bold)))
        contentLeft.Add(New Chunk(vbCrLf & vbCrLf))

        Dim rectangle1 As New Rectangle(doc.PageSize.Width / 2, doc.PageSize.Height)
        Dim canvasLeft As PdfContentByte = writer.DirectContent

        ' Definir colores para los bordes de los cuadrados
        Dim color1 As BaseColor = New BaseColor(255, 0, 0) ' Rojo
        Dim color2 As BaseColor = New BaseColor(0, 255, 0) ' Verde
        Dim color3 As BaseColor = New BaseColor(0, 0, 255) ' Azul

        ' Dibujar los cuadrados con bordes de colores diferentes
        canvasLeft.SetColorStroke(color1)
        canvasLeft.Rectangle(rectangle1.Left, rectangle1.Bottom, rectangle1.Width, rectangle1.Height)
        canvasLeft.Stroke()

        canvasLeft.SetColorStroke(color2)
        canvasLeft.Rectangle(10, 660, 180, 100)
        canvasLeft.Stroke()

        canvasLeft.SetColorStroke(color3)
        canvasLeft.Rectangle(50, 50, 500, 50)
        canvasLeft.Stroke()

        contentLeft.Add(New Chunk(vbCrLf))

        contentLeft.Add(New Chunk("Línea 1" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
        contentLeft.Add(New Chunk("Línea 2" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
        contentLeft.Add(New Chunk("Línea 3" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
        contentLeft.Add(New Chunk("Línea 4" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))

        Dim contentRight As New Paragraph()
        For Each row As DataRow In dataTable.Rows
            Dim nroCarta As String = row("nro_carta").ToString()
            Dim nroCart2 As String = row("nro_cart2").ToString()
            contentRight.Add(New Chunk(nroCarta & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            contentRight.Add(New Chunk(nroCart2 & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
        Next

        Dim columnRight As New ColumnText(canvasLeft)
        Dim rectangle2 As New Rectangle(doc.PageSize.Width / 2, doc.PageSize.Height)
        columnRight.SetSimpleColumn(rectangle2.Right, rectangle2.Bottom, rectangle2.Width, rectangle2.Height)
        columnRight.AddElement(contentRight)
        columnRight.Go()

        contentLeft.Add(New Chunk(vbCrLf & vbCrLf))
        contentLeft.Add(New Chunk(vbCrLf & vbCrLf))

        contentLeft.Add(New Chunk("Firma" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
        contentLeft.Add(New Chunk("Aclaración" & vbCrLf, FontFactory.GetFont(FontFactory.HELVETICA, 12)))

        doc.Add(contentLeft)
        doc.Close()

        Process.Start("C:\temp\archivo.pdf")
    End Sub




End Class
