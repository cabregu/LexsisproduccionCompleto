﻿Public Class FrmArm

    Public DtImprimir As New DataTable

    Private Sub FrmArm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ArrayRemitentes As New ArrayList
        ArrayRemitentes = ConfigCorreo.CN_Correo.CargarTodoslosremitente
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To ArrayRemitentes.Count - 1
            CmbRemitente.Items.Add(ArrayRemitentes.Item(i).ToString)
        Next

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
        Dim Dtdatos As New DataTable
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
End Class