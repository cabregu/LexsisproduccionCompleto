

Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class FrmModoS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                impExcel(.FileName)
            End If

        End With
    End Sub

    Private Function impExcel(ByVal Archivo As String) As Boolean
        Try
            Dim dt2 As New DataTable

            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim ad As New OleDbDataAdapter("Select * from [" & "Lexs" & "$]", mconn)
            mconn.Open()
            ad.Fill(dt2)
            mconn.Close()

            ' Agregar la columna "NUEVA_CALLE"
            dt2.Columns.Add("NUEVA_CALLE", GetType(String))

            ' Recorrer el DataTable y aplicar la función ExtractStreetAndNumber
            For Each row As DataRow In dt2.Rows
                Dim address As String = row("CALLE").ToString()
                Dim nuevaCalle As String = ExtractStreetAndNumber(address)
                row("NUEVA_CALLE") = nuevaCalle
            Next

            DgvOriginal.DataSource = dt2
        Catch ex As Exception
            ' Manejar la excepción
        End Try
    End Function

    Public Function ExtractStreetAndNumber(address As String) As String
        Dim patterns As String() = {"11 DE SEPTIEMBRE DE 1888 ", "11 DE SEPTIEMBRE ", "25 DE MAYO ", "9 DE JULIO ", "3 DE FEBRERO ", "12 DE OCTUBRE ", "15 DE NOVIEMBRE DE 1889 ", "20 DE SEPTIEMBRE ", "33 ORIENTALES ", "11 de septiembre ", "25 de Mayo ", "3 de Febrero ", "3 de Febrero ", "3 de febrero ", "3 febrero "}

        ' Verificar si el dato contiene alguno de los textos en patterns
        For Each pattern As String In patterns
            If address.ToUpper().Contains(pattern.ToUpper()) OrElse address.ToLower().Contains(pattern.ToLower()) Then

                Return CorreccionCalleConNumeroInicial(address)
            End If
        Next

        ' Si no contiene ninguno de los textos, realizar la extracción de calle y número
        Dim components As String() = address.Split(New Char() {" "}, StringSplitOptions.RemoveEmptyEntries)
        Dim street As String = ""
        Dim number As String = ""
        Dim i As Integer = 0
        While i < components.Length
            Dim currentComponent As String = components(i)
            If IsNumeric(currentComponent) Then
                number = currentComponent
                Exit While
            End If
            street += currentComponent + " "
            i += 1
        End While

        Return street.Trim() + ";" + number
    End Function
    Public Function CorreccionCalleConNumeroInicial(calle As String) As String
        Dim patterns As HashSet(Of String) = New HashSet(Of String) From {"11 DE SEPTIEMBRE DE 1888 ", "11 DE SEPTIEMBRE ", "25 DE MAYO ", "9 DE JULIO ", "3 DE FEBRERO ", "12 DE OCTUBRE ", "15 DE NOVIEMBRE DE 1889 ", "20 DE SEPTIEMBRE ", "33 ORIENTALES ", "11 de septiembre ", "25 de Mayo ", "3 de Febrero ", "3 de Febrero ", "3 de febrero ", "3 febrero "}

        Dim calleCompleta As String = calle
        Dim callepattern As String = ""

        For Each pattern As String In patterns
            If calle.Contains(pattern) Then
                callepattern = pattern
                Exit For
            End If
        Next

        If Not String.IsNullOrEmpty(callepattern) Then
            calleCompleta = calleCompleta.Replace(callepattern, "")
        End If

        Dim spaceIndex As Integer = calleCompleta.IndexOf(" ")
        If spaceIndex <> -1 Then
            calleCompleta = calleCompleta.Substring(0, spaceIndex)
        End If

        Dim regex As New Regex("^\d+")
        Dim match As Match = regex.Match(calleCompleta)

        If match.Success Then
            calleCompleta = match.Value
        Else
            calleCompleta = ""
        End If

        Return callepattern & ";" & calleCompleta
    End Function






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExportarDataGridViewAExcel(DgvOriginal)
    End Sub
    Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView)
        Try
            ' Crear una nueva instancia de Excel
            Dim exApp As Object = CreateObject("Excel.Application")


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

            exApp.Visible = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub
End Class


