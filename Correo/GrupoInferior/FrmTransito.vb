Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.IO
Imports ConfigCorreo.CN_Correo
Imports System.Globalization
Imports System.Threading

Public Class FrmTransito
    Dim dt2 As New DataTable
    Dim dtnew As New DataTable
    Public path2 As String = ""



    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        Dim frmOpcion As FrmOpcionesDeTransito
        frmOpcion = Nothing
        If frmOpcion Is Nothing Then
            frmOpcion = New FrmOpcionesDeTransito
            frmOpcion.Show()
            Me.Visible = False
        ElseIf frmOpcion.IsDisposed Then
            Me.Visible = True
        End If
    End Sub
    Public Sub Seleccionar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcel(.FileName) = True Then
                    txtPath.Text = Path.GetFileName(.FileName)
                End If
            Else
                openFD.Dispose()
            End If
        End With

    End Sub
    Public Sub SeleccionarOtro()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcelOtro(.FileName) = True Then
                    txtPath.Text = Path.GetFileName(.FileName)
                End If
            Else
                openFD.Dispose()
            End If
        End With

    End Sub
    Private Function impExcel(ByVal Archivo As String) As Boolean

        Try
            Dim strconn As String
            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim ad As New OleDbDataAdapter("Select * from [" & "Lexs" & "$]", mconn)
            mconn.Open()
            ad.Fill(dt2)
            mconn.Close()

            Dim dcarr As New ArrayList
            For Each dc As DataColumn In dt2.Columns
                dcarr.Add(dc.ColumnName.ToString)
            Next

            If dcarr.Contains("Agrup") And dcarr.Contains("FECHA_ULT_ESTADO") Then
                DgvDatos.DataSource = dt2
                If Not DgvDatos.Columns.Contains("CONTRA") Then
                    DgvDatos.Columns.Add("CONTRA", "CONTRA")
                    DgvDatos.Columns.Add("LOTE", "LOTE")
                End If


                For Each drgv As DataGridViewRow In DgvDatos.Rows
                    drgv.Cells("CONTRA").Value = drgv.Cells("Agrup").Value.ToString.Substring(0, 7)
                    drgv.Cells("LOTE").Value = drgv.Cells("Agrup").Value.ToString.Substring(8, 7).TrimStart("0")
                Next

                If Not DgvDatos.Columns.Contains("NRO_CART2") Then

                    DgvDatos.Columns.Add("NRO_CARTA", "NRO_CARTA")
                    DgvDatos.Columns.Add("REMITENTE", "REMITENTE")
                    DgvDatos.Columns.Add("FECH_TRAB", "FECH_TRAB")
                    DgvDatos.Columns.Add("APELLIDO", "APELLIDO")
                    DgvDatos.Columns.Add("CALLE", "CALLE")
                    DgvDatos.Columns.Add("CP", "CP")
                    DgvDatos.Columns.Add("LOCALIDAD", "LOCALIDAD")
                    DgvDatos.Columns.Add("PROVINCIA", "PROVINCIA")
                    DgvDatos.Columns.Add("FECHA_ENTR", "FECHA_ENTR")
                    DgvDatos.Columns.Add("NRO_PLANIL", "NRO_PLANIL")
                    DgvDatos.Columns.Add("FECH_PLANI", "FECH_PLANI")
                    DgvDatos.Columns.Add("ESTADO", "ESTADO")
                    DgvDatos.Columns.Add("CARTERO", "CARTERO")
                    DgvDatos.Columns.Add("TEMA4", "TEMA4")
                    DgvDatos.Columns.Add("FECH4", "FECH4")
                    DgvDatos.Columns.Add("NRO_CART2", "NRO_CART2")
                End If


            Else
                MsgBox("La columna 'Agrup' y 'FECHA_ULT_ESTADO' es obligatoria contiene los datos para el cruzamiento y analisis")
            End If
            Return True

        Catch ex As Exception
            MsgBox("Archivo incompatible detalle de error : " & ex.ToString)
        End Try




    End Function
    Private Function impExcelOtro(ByVal Archivo As String) As Boolean


        txtPath.Text = Archivo
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & "Lexs" & "$]", mconn)
        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()

        DgvDatos.DataSource = dt2

        If Not dt2.Columns.Contains("CONTRA") Then


            For Each dr As DataRow In dt2.Rows
                dr("Socio CONTRATO") = Retornode7digitos(dr("Socio CONTRATO").ToString)
                dr("Lote ID") = Retornode7digitos(dr("Lote ID").ToString)
            Next

            dt2.Columns.Add("CONTRA")
            dt2.Columns.Add("LOTE")
            dt2.Columns.Add("NRO_CARTA")
            dt2.Columns.Add("REMITENTE")
            dt2.Columns.Add("FECH_TRAB")
            dt2.Columns.Add("APELLIDO")
            dt2.Columns.Add("CALLE")
            dt2.Columns.Add("CP")
            dt2.Columns.Add("LOCALIDAD")
            dt2.Columns.Add("PROVINCIA")
            dt2.Columns.Add("FECHA_ENTR")
            dt2.Columns.Add("NRO_PLANIL")
            dt2.Columns.Add("FECH_PLANI")
            dt2.Columns.Add("ESTADO")
            dt2.Columns.Add("CARTERO")
            dt2.Columns.Add("TEMA4")
            dt2.Columns.Add("FECH4")
            dt2.Columns.Add("NRO_CART2")

            For Each dr As DataRow In dt2.Rows
                dr("CONTRA") = Retornode7digitos(dr("Socio CONTRATO").ToString)
                dr("LOTE") = Retornode7digitos(dr("Lote ID").ToString)
            Next
        End If

        If Not dt2.Columns.Contains("ESTADOF") Then
            dt2.Columns.Add("ESTADOF")
            dt2.Columns.Add("MOTIVOF")
            dt2.Columns.Add("FECHAF")
            dt2.Columns.Add("TIPO")
            dt2.Columns.Add("FECHA_TRABAJO")
            dt2.Columns.Add("FECH1")
            dt2.Columns.Add("HISTORICO")
            dt2.Columns.Add("INFORMADO")
        End If



        'CmColumnas.Items.Clear()

        'For Each dcol As DataGridViewColumn In DgvDatos.Columns
        '    dcol.SortMode = DataGridViewColumnSortMode.NotSortable
        '    CmColumnas.Items.Add(dcol.Name.ToString)

        'Next




    End Function
    Private Sub Btncargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Eliminardatostablatemporal() = True Then

            Dim txtsql As String = ""
            Dim cadena As New System.Text.StringBuilder

            For Each drw As DataRow In dtnew.Rows
                txtsql = "(" & "'" & drw("NRO_CARTA").ToString & "' , " _
                & "'" & drw("REMITENTE").ToString & "'" & ", " _
                & "'" & Converfecha(Normalizar(drw("FECH_TRAB").ToString)) & "'" & ", " _
                & "'" & Normalizar(drw("APELLIDO").ToString) & "'" & ", " _
                & "'" & Normalizar(drw("CALLE".ToString)) & "'" & ", " _
                & "'" & Normalizar(drw("CP").ToString) & "'" & ", " _
                & "'" & drw("LOCALIDAD").ToString & "'" & ", " _
                & "'" & drw("PROVINCIA").ToString & "'" & ", " _
                & "'" & Normalizar(drw("FECHA_ENTR").ToString) & "'" & ", " _
                & "'" & drw("NRO_PLANIL").ToString & "'" & ", " _
                & "'" & Normalizar(drw("FECH_PLANI").ToString) & "'" & ", " _
                & "'" & drw("ESTADO").ToString & "'" & ", " _
                & "'" & drw("CARTERO").ToString & "'" & ", " _
                & "'" & drw("TEMA4").ToString & "'" & ", " _
                & "'" & Normalizar(drw("FECH4").ToString) & "'" & ", " _
                & "'" & drw("NRO_CART2").ToString & "'" & ", " _
                & "'" & drw("NRO_CART2").ToString.Substring(0, 15) & "'" & ")" & ", "
                cadena.Append(txtsql)
            Next

            Dim txtarch As String
            txtarch = cadena.ToString

            If Len(txtarch) > 0 Then
                txtarch = Mid(txtarch, 1, Len(txtarch) - 2)
            End If


            If MessageBox.Show("Desea Actualizar", "Actualizar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If ConfigCorreo.CN_Correo.InstertarRegistroTRANSITO(txtarch) = True Then
                    MessageBox.Show("Actualizado OK", "Actualizado OK")
                Else
                    MessageBox.Show("Error", "Error")
                End If
            End If

        End If

    End Sub
    Private Shared Function Normalizar2(ByVal Dato As String) As String

        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace("01/01/0001", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")

        Return Dato
    End Function
    Private Shared Function Convertirfecha(ByVal valor As String) As String
        Try
            Dim año As String = valor.Substring(valor.LastIndexOf("/") + 1, 4)
            Dim mes As String = valor.Substring(3, 2)
            Dim dia As String = valor.Substring(0, 2)
            Dim fecha As String = año & "-" & mes & "-" & dia
            Return fecha
        Catch ex As Exception
            Return "0000-00-00"
        End Try

    End Function
    Private Sub BTNCOLUMNAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BNBUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNBUSCAR.Click

        'Desactiva el botón mientras se está procesando
        BNBUSCAR.Enabled = False

        'Inicia un nuevo hilo para ejecutar la tarea en segundo plano
        Dim thread As New Thread(AddressOf ProcesarDatos)
        thread.Start()

    End Sub

    Private Sub ProcesarDatos()
        Dim Numero As Integer = 0

        Me.Invoke(Sub()
                      PgbAnalisis.Minimum = 0
                      PgbAnalisis.Maximum = DgvDatos.Rows.Count
                  End Sub)

        For Each DRW As DataGridViewRow In DgvDatos.Rows

            Dim result As String = ConfigCorreo.CN_Correo.ObtenerPorNrocartaCorreoProduccion(DRW.Cells("contra").Value & "-" & DRW.Cells("lote").Value)
            If result <> "" Then

                Dim values() As String = result.Split(";")

            'If values.Length = 12 Then ' Verificamos que tengamos los 12 valores esperados
            DRW.Cells("Nro_Carta").Value = values(0)
                DRW.Cells("REMITENTE").Value = values(1)
                DRW.Cells("FECH_TRAB").Value = values(2)
                DRW.Cells("APELLIDO").Value = values(3)
                DRW.Cells("CALLE").Value = values(4)
                DRW.Cells("CP").Value = values(5)
                DRW.Cells("LOCALIDAD").Value = values(6)
                DRW.Cells("PROVINCIA").Value = values(7)
                DRW.Cells("ESTADO").Value = values(8)
                DRW.Cells("NRO_PLANIL").Value = values(9)
                DRW.Cells("CARTERO").Value = ObtenerCarteroDeCorreoProduccion(values(0))
                DRW.Cells("NRO_CART2").Value = values(10)
                DRW.Cells("TEMA4").Value = ObtenerMotivoDevoDeCorreoProduccion(values(0))
                DRW.Cells("FECH4").Value = ObtenerFechaDevoDeCorreoProduccion(values(0))
            'End If

            Numero = Numero + 1
            'Actualiza la barra de progreso en el subproceso UI usando Invoke
            Me.Invoke(Sub()
                          PgbAnalisis.Value = Numero
                      End Sub)

            End If

        Next

        'Habilita el botón cuando el procesamiento ha terminado
        Me.Invoke(Sub() BNBUSCAR.Enabled = True)


    End Sub



    Private Function BuscarEntregadasPlanilladasvisitadasRecorrido(ByVal Carta As String) As String
        Dim EstadoEnRecorrido As String
        Dim EstadoEnPlanilladas As String
        Dim EstadoEnEntregadas As String
        Dim EstadoEnVisitadas As String
        Dim EstadoEnTransito As String

        EstadoEnRecorrido = ObtenerEstadoenRecorrido(Carta)
        EstadoEnPlanilladas = ObtenerEstadoenPlanilladas(Carta)
        EstadoEnEntregadas = ObtenerEstadoenentregadas(Carta)
        EstadoEnVisitadas = ObtenerEstadoenVisitadas(Carta)
        EstadoEnTransito = ObtenerEstadoenTransito(Carta)

        Return EstadoEnRecorrido & "-" & EstadoEnPlanilladas & "-" & EstadoEnEntregadas & "-" & EstadoEnVisitadas & "-" & EstadoEnTransito


    End Function






    Private Sub BtnEstados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstados.Click
        FechasEntregadas()

    End Sub


    Private Sub Btnexcel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexcel2.Click
        ExportarDataGridViewAExcel(DgvDatos)
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



    Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView, ByVal camposSeleccionados() As String)
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
            Dim NCol As Integer = camposSeleccionados.Length
            Dim NRow As Integer = dgv.RowCount

            ' Copiar los nombres de las columnas seleccionadas al libro
            Dim rg As Object = exHoja.Range(exHoja.Cells(1, 1), exHoja.Cells(1, NCol))
            For i As Integer = 0 To NCol - 1
                rg.Cells(1, i + 1).Value = camposSeleccionados(i)
            Next

            ' Copiar los datos seleccionados del DataGridView al libro
            Dim data(NRow - 1, NCol - 1) As Object
            For i As Integer = 0 To NRow - 1
                For j As Integer = 0 To NCol - 1
                    data(i, j) = dgv.Rows(i).Cells(camposSeleccionados(j)).Value
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








    Private Sub FrmTransito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPath.Text = path2

        'Dim fecha As Date = Now
        'fecha = fecha.AddDays(-60)
        ''dtpfecha.Value = fecha


    End Sub
    Private Shared Function Normalizar(ByVal Dato As String) As String
        Dato = Dato.Replace("-", "")
        Dato = Dato.Replace("(", "")
        Dato = Dato.Replace(")", "")
        Dato = Dato.Replace("  ", "")
        Dato = Dato.Replace("30/12/1899", "")
        Dato = Dato.Replace("01/01/0001", "")
        Dato = Dato.Replace(" 0:00:00", "")
        Dato = Dato.Replace("'", "")
        Dato = Dato.Replace(",", "")
        Dato = Dato.Replace("12:00:00 a.m.", "")

        Return Dato
    End Function
    Private Sub Estados()

        Dim DTCRITERIOS As DataTable = Nothing


        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        For Each dgvfechas As DataGridViewRow In DgvDatos.Rows

            If Not IsDBNull(dgvfechas.Cells("ESTADOF").Value) Then

                If dgvfechas.Cells("ESTADOF").Value = "ENTREGADA" Or dgvfechas.Cells("ESTADOF").Value = "DEVUELTA" Or dgvfechas.Cells("ESTADOF").Value = "CONF.ENTRE" Then
                Else
                    Dim fecha_swiss As Date = dgvfechas.Cells("Fecha Ultimo Estado DESC").Value
                    If Not IsDBNull(dgvfechas.Cells("FECH_TRAB").Value) Then
                        Dim fecha_lexs As Date = dgvfechas.Cells("FECH_TRAB").Value
                        fecha_swiss.ToShortDateString()
                        fecha_lexs.ToShortDateString()
                        dgvfechas.Cells("ESTADOF").Value = DiferenciaFechas(fecha_swiss, fecha_lexs)
                    End If
                End If

            End If
        Next
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        For Each DRG As DataGridViewRow In DgvDatos.Rows
            If Not IsDBNull(DRG.Cells("ESTADOF").Value) Then


                If Len(DRG.Cells("ESTADOF").Value) > 0 Then
                    DTCRITERIOS = ObtenerCRITERIOS(DRG.Cells("ESTADOF").Value)

                    If DTCRITERIOS.Rows.Count > 0 Then
                        If DTCRITERIOS.Rows(0)("CON_CRITERIO").ToString = "NO" Then

                            If DRG.Cells("ESTADOF").Value = "" Then
                                DRG.Cells("ESTADOF").Value = DTCRITERIOS.Rows(0)("PASAR_A").ToString
                                If DTCRITERIOS.Rows(0)("PASAR_A").ToString = "DEVUELTA" Then
                                    DRG.Cells("MOTIVOF").Value = DRG.Cells("TEMA4").Value
                                    DRG.Cells("FECHAF").Value = DRG.Cells("FECH4").Value

                                    If DRG.Cells("TEMA4").Value = "" Then
                                        Dim FECHADEV As Date = DRG.Cells("FECH_TRAB").Value
                                        FECHADEV.AddDays(7)
                                        FECHADEV.ToShortDateString()

                                        If FECHADEV <= Now.ToShortDateString Then
                                            DRG.Cells("MOTIVOF").Value = "7-AUSENCIA"
                                            DRG.Cells("FECHAF").Value = FECHADEV
                                        Else
                                            DRG.Cells("MOTIVOF").Value = "7-AUSENCIA"
                                            DRG.Cells("FECHAF").Value = Now.ToShortDateString
                                        End If


                                    End If

                                End If
                            End If


                        ElseIf DRG.Cells("ESTADO").Value = "Distrib." Then
                            If DRG.Cells("ESTADOF").Value = "" Then
                                Dim FECHATRAB As Date = DRG.Cells("FECH_TRAB").Value
                                Dim fechahoy1 As Date = Now.ToShortDateString
                                Dim fechahoy2 As Date = Now.ToShortDateString
                                Dim fechahoy3 As Date = Now.ToShortDateString
                                fechahoy1 = fechahoy1.AddDays(-13)

                                If FECHATRAB <= fechahoy1 Then
                                    DRG.Cells("ESTADOF").Value = "ENT_COD13"
                                ElseIf FECHATRAB <= fechahoy2 And FECHATRAB > fechahoy1 Then
                                    DRG.Cells("ESTADOF").Value = "EN_RENDICION"
                                Else
                                    DRG.Cells("ESTADOF").Value = "EN_PROCESO"
                                End If


                            End If



                        ElseIf DRG.Cells("ESTADO").Value = "ESP. PROG." Then
                            If DRG.Cells("ESTADOF").Value = "" Then
                                Dim FECHATRAB As Date = DRG.Cells("FECH_TRAB").Value
                                Dim fechahoy1 As Date = Now.ToShortDateString
                                Dim fechahoy2 As Date = Now.ToShortDateString
                                Dim fechahoy3 As Date = Now.ToShortDateString
                                fechahoy1 = fechahoy1.AddDays(-17)

                                If FECHATRAB <= fechahoy1 Then
                                    DRG.Cells("ESTADOF").Value = "ENT_COD13"
                                ElseIf FECHATRAB <= fechahoy2 And FECHATRAB > fechahoy1 Then
                                    DRG.Cells("ESTADOF").Value = "EN_RENDICION"
                                Else
                                    DRG.Cells("ESTADOF").Value = "EN_PROCESO"
                                End If
                            End If


                        ElseIf DRG.Cells("ESTADO").Value = "REPROG" Then
                            If DRG.Cells("ESTADOF").Value = "" Then
                                Dim FECHATRAB As Date = DRG.Cells("FECH_TRAB").Value
                                Dim fechahoy1 As Date = Now.ToShortDateString
                                fechahoy1 = fechahoy1.AddDays(-13)
                                If FECHATRAB <= fechahoy1 Then
                                    DRG.Cells("ESTADOF").Value = "EN_RENDICION"
                                Else
                                    DRG.Cells("ESTADOF").Value = "EN_PROCESO"
                                End If
                            End If


                        End If
                    End If
                End If
                Try


                    If DRG.Cells("PROVINCIA").Value = "REDESPACHO" Then
                        DRG.Cells("TIPO").Value = "REDESPACHO"
                        Dim FECHATRAB As Date = DRG.Cells("FECH_TRAB").Value.ToString
                        FECHATRAB.ToShortDateString()

                        DRG.Cells("FECHA_TRABAJO").Value = Normalizar(FECHATRAB)

                    End If

                Catch ex As Exception

                End Try
            End If
        Next


        For Each DRGAR As DataGridViewRow In DgvDatos.Rows

            If Not IsDBNull(DRGAR.Cells("CARTERO").Value) Then
                If DRGAR.Cells("CARTERO").Value = "AR MAESTRO" Then
                    If DRGAR.Cells("ESTADO").Value <> "DEVUELTA" And DRGAR.Cells("ESTADO").Value <> "DEVOLUCION" Then
                        If DRGAR.Cells("CP").Value >= 1000 And DRGAR.Cells("CP").Value <= 1890 Then
                            DRGAR.Cells("ESTADOF").Value = "ENTREGADA"
                        Else
                            DRGAR.Cells("ESTADOF").Value = "EN_RENDICION"
                        End If
                    End If
                End If
            End If

            If IsDBNull(DRGAR.Cells("NRO_CARTA").Value) Then
                DRGAR.Cells("ESTADOF").Value = "NO_HAY_INGRESO"
            Else
                If DRGAR.Cells("NRO_CARTA").Value = "" Then
                    DRGAR.Cells("ESTADOF").Value = "NO_HAY_INGRESO"
                End If
            End If

        Next

        For Each drw As DataGridViewRow In DgvDatos.Rows
            Dim FechaVisitada As String = Normalizar(VerificarSiFueVisitada(drw.Cells("contra").Value, drw.Cells("lote").Value))

            drw.Cells("FECH1").Value = FechaVisitada

        Next


    End Sub
    Private Sub EntregadasCod13()
        For Each drgw As DataGridViewRow In DgvDatos.Rows
            If drgw.Cells("ESTADOF").Value = "EN_DEVOLUCION" Then
                drgw.Cells("TIPO").Value = BuscarContra(drgw.Cells("CONTRA").Value)
            End If
        Next
    End Sub
    Private Sub FechasEntregadas()
        Try


            ''***************************************VISITADAS**********************************************
            'Dim FechaV As String
            'Dim Fechavisit As Date = Now.ToShortDateString
            'Fechavisit = Fechavisit.ToShortDateString
            'Fechavisit = Fechavisit.AddDays(-40)
            'FechaV = Converfecha(Fechavisit)

            'Dim dtvisitadas As New DataTable
            'dtvisitadas = ObtenerVisit(Converfecha(FechaV))
            'For Each dr As DataRow In dtvisitadas.Rows
            '    For Each drdgw As DataGridViewRow In DgvDatos.Rows
            '        If Not IsDBNull(drdgw.Cells("nro_carta").Value) Then
            '            If drdgw.Cells("nro_carta").Value = dr("nro_carta") Then
            '                drdgw.Cells("fech1").Value = dr("fech1")
            '            End If
            '        End If
            '    Next
            'Next
            '*************************************************************************************


            For Each DRG As DataGridViewRow In DgvDatos.Rows
                '*************************************************************************************
                If DRG.Cells("ESTADOF").Value = "ENTREGADA" Or DRG.Cells("ESTADOF").Value = "ENT_COD13" Then
                    Dim fechaF As Date = Nothing
                    Dim FECHA_ULT_ESTADO As Date = Nothing


                    fechaF = DRG.Cells("FECH_TRAB").Value
                    FECHA_ULT_ESTADO = DRG.Cells("FECHA_ULT_ESTADO").Value

                    fechaF = fechaF.ToShortDateString
                    FECHA_ULT_ESTADO = FECHA_ULT_ESTADO.ToShortDateString


                    Dim FECH1 As Date = Nothing
                    If Not IsDBNull(DRG.Cells("fech1").Value) Then
                        If DRG.Cells("fech1").Value <> "" Then
                            FECH1 = DRG.Cells("fech1").Value
                        End If
                    End If

                    If Not IsDBNull(DRG.Cells("CP").Value) Then
                        '***********ADICIONAL SI TIENE CODIGO POSTAL******************************
                        fechaF = fechaF.AddDays(ObtenerCantDiasCP(DRG.Cells("CP").Value))
                    Else
                        fechaF = fechaF.AddDays(3)
                        '*****FIJO 3 DIAS DESDE FECH_TRAB SI NO TIENE CODIGO POSTAL ****************

                    End If


                    fechaF = fechaF.ToShortDateString
                    fechaF = AgregardiaFeriado(fechaF)
                    '*****AGREGAR FERIADO****
                    If FECH1 <> Nothing Then
                        If fechaF <= FECH1 Then
                            fechaF = FECH1.AddDays(2)
                        End If
                    End If


                    If fechaF <= FECHA_ULT_ESTADO Then
                        '*****AGREGAR DIAS DESDE FECHA ULTIMO ESTADO SWISS
                        fechaF = FECHA_ULT_ESTADO.AddDays(2)
                    End If


                    fechaF = Sabadoydomingo(fechaF)
                    '****SABADO Y DOMINGO 

                    If fechaF > Now.ToShortDateString Then
                        fechaF = Now.ToShortDateString
                    End If

                    Dim entregada As String = ""
                    'entregada = BuscarEntregadapornrodecarta(DRG.Cells("Nro_carta").Value)

                    If entregada <> "" Then
                        DRG.Cells("FECHAF").Value = fechaF.ToShortDateString

                        'MsgBox(entregada & "-" & fechaF.ToShortDateString)
                    Else
                        DRG.Cells("FECHAF").Value = fechaF.ToShortDateString
                    End If


                End If
                '**********************************************************

            Next



        Catch ex As Exception

        End Try




    End Sub
    Private Sub FechasEntregadasReales()

        For Each DRG As DataGridViewRow In DgvDatos.Rows
            Dim fechaF As Date = Nothing
            Dim FECHA_ULT_ESTADO As Date = Nothing

            If DRG.Cells("ESTADOF").Value = "ENTREGADA" Or DRG.Cells("ESTADOF").Value = "ENT_COD13" Then

                If Not IsDBNull(DRG.Cells("FECH_TRAB").Value) Then
                    fechaF = DRG.Cells("FECH_TRAB").Value
                Else
                    fechaF = Now.ToShortDateString
                End If



                FECHA_ULT_ESTADO = DRG.Cells("Fecha Ultimo Estado DESC").Value

                fechaF = fechaF.ToShortDateString
                FECHA_ULT_ESTADO = FECHA_ULT_ESTADO.ToShortDateString


                Dim FECH1 As Date = Nothing
                If Not IsDBNull(DRG.Cells("fech1").Value) Then
                    Try
                        If DRG.Cells("fech1").Value <> "" Then
                            FECH1 = DRG.Cells("fech1").Value
                        End If
                    Catch ex As Exception

                    End Try

                End If

                fechaF = fechaF.ToShortDateString
                fechaF = AgregardiaFeriado(fechaF)

                ''*****AGREGAR FERIADO****
                If FECH1 <> Nothing Then
                    If fechaF <= FECH1 Then
                        fechaF = FECH1.AddDays(2)
                    End If
                End If

                'Dim Fechatransito As Date = VerificarSiFueEntregadaEnTransito(DRG.Cells("contra").Value, DRG.Cells("lote").Value)
                Dim FechaEntregada As Date = VerificarSiFueEntregadaEnDiario(DRG.Cells("contra").Value, DRG.Cells("lote").Value)

                'If Fechatransito <> Nothing Then
                '    If Fechatransito > FECHA_ULT_ESTADO Then
                '        fechaF = Fechatransito
                '        DRG.Cells("INFORMADO").Value = Fechatransito & " EN TRANSITO"
                '    End If
                'End If

                If FechaEntregada > Nothing Then
                    If FechaEntregada > FECHA_ULT_ESTADO Then
                        fechaF = FechaEntregada
                        DRG.Cells("INFORMADO").Value = FechaEntregada & "EN DIARIO"
                    End If
                End If


                If fechaF <= FECHA_ULT_ESTADO Then
                    '*****AGREGAR DIAS DESDE FECHA ULTIMO ESTADO SWISS
                    fechaF = FECHA_ULT_ESTADO.AddDays(2)
                End If


                fechaF = Sabadoydomingo(fechaF)
                '****SABADO Y DOMINGO 

                If fechaF > Now.ToShortDateString Then
                    fechaF = Now.ToShortDateString
                End If
            End If


            DRG.Cells("FECHAF").Value = Normalizar(fechaF.ToShortDateString)


            If DRG.Cells("ESTADOF").Value = "DEVUELTA" Then
                DRG.Cells("MOTIVOF").Value = DRG.Cells("TEMA4").Value
                DRG.Cells("FECHAF").Value = DRG.Cells("FECH4").Value
            End If
        Next



    End Sub
    Private Function DiferenciaFechas(ByVal fecha_swiss As Date, ByVal Fecha_lexs As Date) As String

        If (DateDiff(DateInterval.Day, fecha_swiss, Fecha_lexs)) > 2 Then
            Return "DIF_FECHAS_PARA_ANALIZAR"
        Else
            Return ""
        End If




    End Function
    Private Function DiferenciaFechasSwissLexs(ByVal fecha_swiss As Date, ByVal Fecha_lexs As Date) As Date

        If DateDiff(DateInterval.Day, Fecha_lexs, fecha_swiss) < 1 Then
            fecha_swiss = fecha_swiss.AddDays(1)
            Return fecha_swiss
        Else
            Return Fecha_lexs
        End If



    End Function
    Private Sub BtnAnalisisEstados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnalisisEstados.Click

        Estados()


        'filtrarEstados()

    End Sub
    Private Sub BtnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmar.Click

        For Each drw As DataGridViewRow In DgvDatos.Rows
            Try
                If Not IsDBNull(drw.Cells("nro_carta").Value) Then
                    ConfigCorreo.CN_Correo.VerificarEstadoAlerta(drw.Cells("nro_carta").Value, drw.Cells("estadof").Value)
                End If

            Catch ex As Exception

            End Try

        Next

        If Verificar_ING_ARCH(txtPath.Text) = True Then
            MsgBox("El archivo ya existe con ese nombre")
        Else

            Dim CADENASTRIM As System.Text.StringBuilder
            CADENASTRIM = CargarArchivo(txtPath.Text, Now.ToShortDateString)

            Dim txtarch As String
            txtarch = CADENASTRIM.ToString

            If Len(txtarch) > 0 Then
                txtarch = Mid(txtarch, 1, Len(txtarch) - 2)
            End If
            If InstertarRegistroTR_ANALIZADO(txtarch) = True Then
                MsgBox("OK")
            End If

        End If



    End Sub
    Private Function CargarArchivo(ByVal ARCHIVO As String, ByVal FECHAARCHIVO As String) As System.Text.StringBuilder
        Dim txtsql As String = ""
        Dim cadena As New System.Text.StringBuilder

        For Each drw As DataGridViewRow In DgvDatos.Rows
            If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then


                If Len(drw.Cells("NRO_CARTA").Value) > 0 Then


                    Dim NRO_CARTA As String = ""
                    Dim REMITENTE As String = ""
                    Dim FECH_TRAB As String = ""
                    Dim APELLIDO As String = ""
                    Dim CALLE As String = ""
                    Dim CP As String = ""
                    Dim LOCALIDAD As String = ""
                    Dim PROVINCIA As String = ""
                    Dim FECHA_ENTR As String = ""
                    Dim NRO_PLANIL As String = ""
                    Dim FECH_PLANI As String = ""
                    Dim ESTADO As String = ""
                    Dim CARTERO As String = ""
                    Dim TEMA4 As String = ""
                    Dim FECH4 As String = ""
                    Dim NRO_CART2 As String = ""
                    Dim FECHA_ULT_ESTADO As String = ""
                    Dim DENO_ESTADO As String = ""
                    Dim ESTADOF As String = ""
                    Dim MOTIVOF As String = ""
                    Dim FECHAF As String = ""
                    Dim SOCIO As String = ""

                    If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then
                        NRO_CARTA = drw.Cells("NRO_CARTA").Value
                    End If

                    If Not IsDBNull(drw.Cells("REMITENTE").Value) Then
                        REMITENTE = drw.Cells("REMITENTE").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECH_TRAB").Value) Then
                        FECH_TRAB = drw.Cells("FECH_TRAB").Value
                    End If
                    If Not IsDBNull(drw.Cells("APELLIDO").Value) Then
                        APELLIDO = drw.Cells("APELLIDO").Value
                    End If
                    If Not IsDBNull(drw.Cells("CALLE").Value) Then
                        CALLE = drw.Cells("CALLE").Value
                    End If
                    If Not IsDBNull(drw.Cells("CP").Value) Then
                        CP = drw.Cells("CP").Value
                    End If
                    If Not IsDBNull(drw.Cells("LOCALIDAD").Value) Then
                        LOCALIDAD = drw.Cells("LOCALIDAD").Value
                    End If
                    If Not IsDBNull(drw.Cells("PROVINCIA").Value) Then
                        PROVINCIA = drw.Cells("PROVINCIA").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECHA_ENTR").Value) Then
                        FECHA_ENTR = drw.Cells("FECHA_ENTR").Value
                    End If
                    If Not IsDBNull(drw.Cells("NRO_PLANIL").Value) Then
                        NRO_PLANIL = drw.Cells("NRO_PLANIL").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECH_PLANI").Value) Then
                        FECH_PLANI = drw.Cells("FECH_PLANI").Value
                    End If
                    If Not IsDBNull(drw.Cells("ESTADO").Value) Then
                        ESTADO = drw.Cells("ESTADO").Value
                    End If
                    If Not IsDBNull(drw.Cells("CARTERO").Value) Then
                        CARTERO = drw.Cells("CARTERO").Value
                    End If
                    If Not IsDBNull(drw.Cells("TEMA4").Value) Then
                        TEMA4 = drw.Cells("TEMA4").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECH4").Value) Then
                        FECH4 = drw.Cells("FECH4").Value
                    End If
                    If Not IsDBNull(drw.Cells("NRO_CART2").Value) Then
                        NRO_CART2 = drw.Cells("NRO_CART2").Value
                    End If

                    If Not IsDBNull(drw.Cells("Fecha Ultimo Estado DESC").Value) Then
                        FECHA_ULT_ESTADO = drw.Cells("Fecha Ultimo Estado DESC").Value
                    End If
                    If Not IsDBNull(drw.Cells("Ultimo Estado Homolog DESC").Value) Then
                        DENO_ESTADO = drw.Cells("Ultimo Estado Homolog DESC").Value
                    End If
                    If Not IsDBNull(drw.Cells("ESTADOF").Value) Then
                        ESTADOF = drw.Cells("ESTADOF").Value
                    End If
                    If Not IsDBNull(drw.Cells("MOTIVOF").Value) Then
                        MOTIVOF = drw.Cells("MOTIVOF").Value
                    End If
                    If Not IsDBNull(drw.Cells("FECHAF").Value) Then
                        FECHAF = drw.Cells("FECHAF").Value
                    End If
                    If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then
                        SOCIO = drw.Cells("NRO_CART2").Value.ToString.Substring(0, 7)
                    End If


                    txtsql = "(" _
                    & "'" & NRO_CARTA & "' , " _
        & "'" & REMITENTE & "'" & ", " _
        & "'" & Converfecha(FECH_TRAB) & "'" & ", " _
        & "'" & Normalizar(APELLIDO) & "'" & ", " _
        & "'" & Normalizar(CALLE) & "'" & ", " _
        & "'" & CP & "'" & ", " _
        & "'" & Normalizar(LOCALIDAD) & "'" & ", " _
        & "'" & Normalizar(PROVINCIA) & "'" & ", " _
        & "'" & FECHA_ENTR & "'" & ", " _
        & "'" & NRO_PLANIL & "'" & ", " _
        & "'" & FECH_PLANI & "'" & ", " _
        & "'" & ESTADO & "'" & ", " _
        & "'" & CARTERO & "'" & ", " _
        & "'" & TEMA4 & "'" & ", " _
        & "'" & FECH4 & "'" & ", " _
        & "'" & NRO_CART2 & "'" & ", " _
        & "'" & FECHA_ULT_ESTADO & "'" & ", " _
        & "'" & DENO_ESTADO & "'" & ", " _
        & "'" & ESTADOF & "'" & ", " _
        & "'" & MOTIVOF & "'" & ", " _
        & "'" & FECHAF & "' , " _
        & "'" & ARCHIVO & "' , " _
        & "'" & FECHAARCHIVO & "'" _
        & ")" & ", "

                    cadena.Append(txtsql)
                End If
            End If
        Next


        Return cadena


    End Function
    Private Function CargarArchivo2() As System.Text.StringBuilder
        Dim txtsql As String = ""
        Dim cadena As New System.Text.StringBuilder

        Dim NRO_CARTA As String = ""
        Dim REMITENTE As String = ""
        Dim FECH_TRAB As String = ""
        Dim APELLIDO As String = ""
        Dim CALLE As String = ""
        Dim CP As String = ""
        Dim LOCALIDAD As String = ""
        Dim PROVINCIA As String = ""
        Dim FECHA_ENTR As String = ""
        Dim NRO_PLANIL As String = ""
        Dim FECH_PLANI As String = ""
        Dim ESTADO As String = ""
        Dim CARTERO As String = ""
        Dim TEMA4 As String = ""
        Dim FECH4 As String = ""
        Dim NRO_CART2 As String = ""
        Dim Agrup As String = ""
        Dim FECHA_ULT_ESTADO As String = ""
        Dim DENO_ESTADO As String = ""
        Dim ESTADOF As String = ""
        Dim MOTIVOF As String = ""
        Dim FECHAF As String = ""
        Dim NARCHIVO As String = ""
        Dim FECHA_REGISTRO As String = ""

        For Each drw As DataGridViewRow In DgvDatos.Rows

            If Not IsDBNull(drw.Cells("NRO_CARTA").Value) Then
                NRO_CARTA = drw.Cells("NRO_CARTA").Value
            End If

            If Not IsDBNull(drw.Cells("REMITENTE").Value) Then
                REMITENTE = drw.Cells("REMITENTE").Value
            End If
            If Not IsDBNull(drw.Cells("FECH_TRAB").Value) Then
                FECH_TRAB = drw.Cells("FECH_TRAB").Value
            End If
            If Not IsDBNull(drw.Cells("APELLIDO").Value) Then
                APELLIDO = drw.Cells("APELLIDO").Value
            End If
            If Not IsDBNull(drw.Cells("CALLE").Value) Then
                CALLE = drw.Cells("CALLE").Value
            End If
            If Not IsDBNull(drw.Cells("CP").Value) Then
                CP = drw.Cells("CP").Value
            End If
            If Not IsDBNull(drw.Cells("LOCALIDAD").Value) Then
                LOCALIDAD = drw.Cells("LOCALIDAD").Value
            End If
            If Not IsDBNull(drw.Cells("PROVINCIA").Value) Then
                PROVINCIA = drw.Cells("PROVINCIA").Value
            End If
            If Not IsDBNull(drw.Cells("FECHA_ENTR").Value) Then
                FECHA_ENTR = drw.Cells("FECHA_ENTR").Value
            End If
            If Not IsDBNull(drw.Cells("NRO_PLANIL").Value) Then
                NRO_PLANIL = drw.Cells("NRO_PLANIL").Value
            End If
            If Not IsDBNull(drw.Cells("FECH_PLANI").Value) Then
                FECH_PLANI = drw.Cells("FECH_PLANI").Value
            End If
            If Not IsDBNull(drw.Cells("ESTADO").Value) Then
                ESTADO = drw.Cells("ESTADO").Value
            End If
            If Not IsDBNull(drw.Cells("CARTERO").Value) Then
                CARTERO = drw.Cells("CARTERO").Value
            End If
            If Not IsDBNull(drw.Cells("TEMA4").Value) Then
                TEMA4 = drw.Cells("TEMA4").Value
            End If
            If Not IsDBNull(drw.Cells("FECH4").Value) Then
                FECH4 = drw.Cells("FECH4").Value
            End If
            If Not IsDBNull(drw.Cells("NRO_CART2").Value) Then
                NRO_CART2 = drw.Cells("NRO_CART2").Value
            End If

            If Not IsDBNull(drw.Cells("Agrup").Value) Then
                Agrup = drw.Cells("Agrup").Value
            End If
            If Not IsDBNull(drw.Cells("FECHA_ULT_ESTADO").Value) Then
                FECHA_ULT_ESTADO = drw.Cells("FECHA_ULT_ESTADO").Value
            End If
            If Not IsDBNull(drw.Cells("DENO_ESTADO").Value) Then
                DENO_ESTADO = drw.Cells("DENO_ESTADO").Value
            End If
            If Not IsDBNull(drw.Cells("ESTADOF").Value) Then
                ESTADOF = drw.Cells("ESTADOF").Value
            End If
            If Not IsDBNull(drw.Cells("MOTIVOF").Value) Then
                MOTIVOF = drw.Cells("MOTIVOF").Value
            End If
            If Not IsDBNull(drw.Cells("FECHAF").Value) Then
                FECHAF = drw.Cells("FECHAF").Value
            End If
            If Not IsDBNull(drw.Cells("ARCHIVO").Value) Then
                NARCHIVO = drw.Cells("ARCHIVO").Value
            End If
            If Not IsDBNull(drw.Cells("FECHA_REGISTRO").Value) Then
                FECHA_REGISTRO = drw.Cells("FECHA_REGISTRO").Value
            End If

            txtsql = "(" _
            & "'" & NRO_CARTA & "' , " _
& "'" & REMITENTE & "'" & ", " _
& "'" & Converfecha(FECH_TRAB) & "'" & ", " _
& "'" & Normalizar(APELLIDO) & "'" & ", " _
& "'" & Normalizar(CALLE) & "'" & ", " _
& "'" & CP & "'" & ", " _
& "'" & Normalizar(LOCALIDAD) & "'" & ", " _
& "'" & Normalizar(PROVINCIA) & "'" & ", " _
& "'" & FECHA_ENTR & "'" & ", " _
& "'" & NRO_PLANIL & "'" & ", " _
& "'" & FECH_PLANI & "'" & ", " _
& "'" & ESTADO & "'" & ", " _
& "'" & CARTERO & "'" & ", " _
& "'" & TEMA4 & "'" & ", " _
& "'" & FECH4 & "'" & ", " _
& "'" & NRO_CART2 & "'" & ", " _
& "'" & Agrup & "'" & ", " _
& "'" & FECHA_ULT_ESTADO & "'" & ", " _
& "'" & DENO_ESTADO & "'" & ", " _
& "'" & ESTADOF & "'" & ", " _
& "'" & MOTIVOF & "'" & ", " _
& "'" & FECHAF & "' , " _
& "'" & NARCHIVO & "' , " _
& "'" & FECHA_REGISTRO & "'" _
& ")" & ", "

            cadena.Append(txtsql)
        Next


        Return cadena


    End Function
    Private Sub Btncargacompleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncargacompleta.Click
        Dim CADENASTRIM As System.Text.StringBuilder
        CADENASTRIM = CargarArchivo2()

        Dim txtarch As String
        txtarch = CADENASTRIM.ToString

        If Len(txtarch) > 0 Then
            txtarch = Mid(txtarch, 1, Len(txtarch) - 2)
        End If
        If InstertarRegistroTR_ANALIZADO(txtarch) = True Then
            MsgBox("OK")
        End If
    End Sub
    Private Sub BtnAnalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnalizar.Click
        EntregadasCod13()
    End Sub
    'Private Sub BtnHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistorico.Click
    '    For Each DRW As DataGridViewRow In DgvDatos.Rows
    '        If Not IsDBNull(DRW.Cells("CALLE").Value) Then
    '            DRW.Cells("HISTORICO").Value = ObtenerEntrHistorico(DRW.Cells("CONTRA").Value, DRW.Cells("CALLE").Value)
    '        End If

    '    Next
    'End Sub
    Private Sub BtnFechasReales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFechasReales.Click
        FechasEntregadasReales()
    End Sub
    Private Shared Function Actualizarsocio()
        'For i As Integer = 146690 To 572078
        For i As Integer = 486870 To 572078
            'Try
            Dim NroCart2 As String = ObtenerNroCart2ID(i)
            NroCart2 = NroCart2.Substring(0, 7)
            ActualizarNroCart2ID(NroCart2, i)
            'Catch ex As Exception

            'End Try

        Next
        MsgBox("ok")
    End Function
    Private Sub BtnBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBase.Click
        CheckForIllegalCrossThreadCalls = False
        Dim thread As New Threading.Thread(AddressOf Actualizarsocio)
        thread.Start()
    End Sub
    Private Sub Btn7Digitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7Digitos.Click

        For Each drw As DataGridViewRow In DgvDatos.Rows

            drw.Cells(Trim(CmColumnas.SelectedItem.ToString)).Value = Retornode7digitos(Trim(drw.Cells(CmColumnas.SelectedItem.ToString).Value))

        Next

    End Sub
    Private Function Retornode7digitos(ByVal Nro As String) As String

        If Len(Nro) = 2 Then
            Nro = "00000" & Nro
        End If
        If Len(Nro) = 3 Then
            Nro = "0000" & Nro
        End If
        If Len(Nro) = 4 Then
            Nro = "000" & Nro
        End If
        If Len(Nro) = 5 Then
            Nro = "00" & Nro
        End If
        If Len(Nro) = 6 Then
            Nro = "0" & Nro
        End If
        If Len(Nro) = 7 Then
            Nro = Nro
        End If
        Return Nro
    End Function
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtItem1.Text = "" Then
            TxtItem1.Text = CmColumnas.SelectedItem.ToString()
            TxtItem1.Enabled = False

        Else
            TxtItem2.Text = CmColumnas.SelectedItem.ToString()
            TxtItem2.Enabled = False
            CmColumnas.Enabled = False
            BtnAdd.Enabled = False
        End If


    End Sub
    Private Sub Btnjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnjuntar.Click


        DgvDatos.Columns.Add("CONTRA", "CONTRA")
        DgvDatos.Columns.Add("LOTE", "LOTE")
        DgvDatos.Columns.Add("NRO_CARTA", "NRO_CARTA")
        DgvDatos.Columns.Add("REMITENTE", "REMITENTE")
        DgvDatos.Columns.Add("FECH_TRAB", "FECH_TRAB")
        DgvDatos.Columns.Add("APELLIDO", "APELLIDO")
        DgvDatos.Columns.Add("CALLE", "CALLE")
        DgvDatos.Columns.Add("CP", "CP")
        DgvDatos.Columns.Add("LOCALIDAD", "LOCALIDAD")
        DgvDatos.Columns.Add("PROVINCIA", "PROVINCIA")
        DgvDatos.Columns.Add("FECHA_ENTR", "FECHA_ENTR")
        DgvDatos.Columns.Add("NRO_PLANIL", "NRO_PLANIL")
        DgvDatos.Columns.Add("FECH_PLANI", "FECH_PLANI")
        DgvDatos.Columns.Add("ESTADO", "ESTADO")
        DgvDatos.Columns.Add("CARTERO", "CARTERO")
        DgvDatos.Columns.Add("TEMA4", "TEMA4")
        DgvDatos.Columns.Add("FECH4", "FECH4")
        DgvDatos.Columns.Add("NRO_CART2", "NRO_CART2")

        For Each drw As DataGridViewRow In DgvDatos.Rows
            drw.Cells("CONTRA").Value = drw.Cells(TxtItem1.Text).Value
            drw.Cells("LOTE").Value = drw.Cells(TxtItem2.Text).Value
        Next


    End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Fechatransito As String = VerificarSiFueEntregadaEnTransito("", "")

    '    MsgBox(Fechatransito)
    'End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnObtenerFecha1.Click
        For Each drw As DataGridViewRow In DgvDatos.Rows
            Dim FechaVisitada As String = Normalizar(VerificarSiFueVisitada(drw.Cells("contra").Value, drw.Cells("lote").Value))

            drw.Cells("FECH1").Value = FechaVisitada

        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntxt.Click

        funciontxt("VISITADA")
        funciontxt("ENTREGADA")
        funciontxt("ENT_COD13")

        Dim camposSeleccionados() As String = {"Lote Contra Inte ID", "Socio DESC", "Socio Prepaga", "Socio CONTRATO", "Socio Integrante", "Lote ID", "Ultimo Estado Homolog DESC", "Fecha Ultimo Estado DESC", "Distribucion Empresa DESC", "Zona Envio Creden ID", "Zona Envio Creden DESC", "Grupos Creden", "CONTRA", "LOTE", "NRO_CARTA", "NRO_CART2", "ESTADOF", "MOTIVOF", "FECHAF", "TIPO", "FECHA_TRABAJO", "FECH1", "HISTORICO", "INFORMADO"}
        ExportarDataGridViewAExcel(DgvDatos, camposSeleccionados)

    End Sub

    Private Function funciontxt(ByVal tipo As String) As Boolean

        If Len(tipo) > 0 Then
            Dim Estado As String = ""

            If tipo = "VISITADA" Then
                Estado = "6"
            ElseIf tipo = "ENTREGADA" Then
                Estado = "3"
            ElseIf tipo = "ENT_COD13" Then
                Estado = "13"
            End If


            Dim cadena As New System.Text.StringBuilder
            For Each dgw As DataGridViewRow In DgvDatos.Rows
                If dgw.Cells("Estadof").Value = tipo Then



                    Dim Fechaf As Date = dgw.Cells("fechaf").Value.ToString
                    Dim fe As String
                    fe = Fechaf.ToString("dd/MM/yyyy")

                    cadena.AppendLine(dgw.Cells("Socio CONTRATO").Value & ";" & dgw.Cells("Socio INTEGRANTE").Value & ";" & Val(dgw.Cells("Lote ID").Value) & ";" & Estado & ";" & fe)
                End If

            Next
            Dim texto As String
            texto = cadena.ToString
            Dim objEscritor As IO.StreamWriter
            objEscritor = IO.File.AppendText("C:\temp\" & tipo & ".txt")
            objEscritor.Write(texto)
            objEscritor.Close()


        End If



    End Function






    Private Sub Btncsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncsv.Click

        'Dim headers = (From header As DataGridViewColumn In DgvDatos.Columns.Cast(Of DataGridViewColumn)() _
        '               Select header.HeaderText).ToArray
        'Dim rows = From row As DataGridViewRow In DgvDatos.Rows.Cast(Of DataGridViewRow)() _
        '           Where Not row.IsNewRow _
        '           Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

        'Using sw As New IO.StreamWriter("C:\Temp\archivo.csv", False, System.Text.Encoding.GetEncoding(65001))

        '    sw.WriteLine(String.Join(";", headers))
        '    For Each r In rows
        '        sw.WriteLine(String.Join(";", r))
        '    Next
        'End Using

        'Process.Start("C:\Temp\archivo.csv")

        Dim headers = (From header As DataGridViewColumn In DgvDatos.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DgvDatos.Rows.Cast(Of DataGridViewRow)() _
                   Where Not row.IsNewRow _
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, If(TypeOf c.Value Is Date, CType(c.Value, Date).ToString("yyyy/MM/dd"), c.Value.ToString().PadLeft(2, "0"c)), ""))

        Using sw As New IO.StreamWriter("C:\Temp\archivo.txt", False, System.Text.Encoding.GetEncoding(65001))
            sw.WriteLine(String.Join(";", headers))
            For Each r In rows
                sw.WriteLine(String.Join(";", r))
            Next
        End Using

        Process.Start("C:\Temp\archivo.txt")



    End Sub
End Class
