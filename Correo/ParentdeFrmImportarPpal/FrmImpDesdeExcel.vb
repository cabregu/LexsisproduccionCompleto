Imports ConfigCorreo.CN_Correo
Imports System.Data.OleDb
Imports System.Threading
Imports Microsoft.Office.Interop
Imports System.IO

Public Class FrmImpDesdeExcel
    Public dt As New DataTable
    Public Usuario As String = FrmPpal.Usuario
    Public IMP2 = New Thread(AddressOf PasarDatos)
    Public NroCarta As Integer
    'Dim Sel_th As New Thread(AddressOf Insertardesdexls)



    Private Sub FrmImpDesdeExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CheckForIllegalCrossThreadCalls = False
        Dim Servicios As New ArrayList
        Servicios = ConfigCorreo.CN_Correo.CargarTodoslosServicios
        CmbCodigo.Items.Clear()
        For i As Integer = 0 To Servicios.Count - 1
            CmbCodigo.Items.Add(Servicios.Item(i).ToString)
        Next



    End Sub
    Private Sub CmbCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCodigo.SelectedIndexChanged
        Dim ArrServicios As New ArrayList
        ArrServicios = ConfigCorreo.CN_Correo.RemitosdeCte(CmbCodigo.Text)
        CmbRemito.Items.Clear()
        For i As Integer = 0 To ArrServicios.Count - 1
            CmbRemito.Items.Add(ArrServicios.Item(i).ToString)
        Next
        CmbRemito.Enabled = True
        CmbCodigo.Enabled = False

    End Sub
    Private Sub CmbRemito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemito.SelectedIndexChanged
        If Len(CmbRemito.Text) > 1 Then

            Dim CodServ As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbRemito.Text, CmbCodigo.Text)
            Dim Cantdias As Integer = ConfigCorreo.CN_Correo.ObtenerDiasServicio(CodServ)
            Dim dias As Date = Now.ToShortDateString
            'DtpFecha.Value = dias.AddDays(Cantdias)
            BtnSeleccionar.Enabled = True
            CmbRemito.Enabled = False

        End If

    End Sub
    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click

        Try
            Seleccionar()
            Insertardesdexls(DtpFecha.Value.ToShortDateString)
            BtnImportar.Enabled = True
            BtnSeleccionar.Enabled = False
        Catch ex As Exception
            MsgBox("Verifique la planilla")

        End Try


    End Sub
    Private Sub Seleccionar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtPath.Text = .FileName
            Else
                openFD.Dispose()
            End If
            BtnArchivo.Enabled = True
        End With

    End Sub
    Private Sub Insertardesdexls(ByVal FechaImportacion As Date)
        'Try
        Dim NombreHoja As String = ""
        NombreHoja = ObtenerNombrePrimeraHoja(txtPath.Text)


        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + txtPath.Text + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & NombreHoja & "$]", mconn)
        mconn.Open()
        ad.Fill(dt)
        mconn.Close()

        Dim ArrCampos As New ArrayList
        ArrCampos.Add("APELLIDO")
        ArrCampos.Add("CALLE")
        ArrCampos.Add("NRO")
        ArrCampos.Add("PISO_DEPTO")
        ArrCampos.Add("CP")
        ArrCampos.Add("LOCALIDAD")
        ArrCampos.Add("PROVINCIA")
        ArrCampos.Add("EMPRESA")
        ArrCampos.Add("NRO_CART2")
        ArrCampos.Add("SOCIO")
        ArrCampos.Add("OBS")
        ArrCampos.Add("OBS2")
        ArrCampos.Add("OBS3")
        ArrCampos.Add("OBS4")

        Dim ArrDescartar As New ArrayList

        For Each col As DataColumn In dt.Columns
            For i As Integer = 0 To ArrCampos.Count - 1
                If ArrCampos.Item(i).ToString = col.ToString Then
                    ArrDescartar.Add(col.ToString)
                End If
            Next
        Next

        For i As Integer = 0 To ArrCampos.Count - 1
            If Not ArrDescartar.Contains(ArrCampos.Item(i).ToString) Then
                DgvNoUtilizado.Rows.Add(ArrCampos.Item(i).ToString)
            End If
        Next


        Dgvimportar.Columns.Add("NRO_CARTA", "NRO_CARTA")
        Dgvimportar.Columns.Add("REMITENTE", "REMITENTE")
        Dgvimportar.Columns.Add("TRABAJO", "TRABAJO")
        Dgvimportar.Columns.Add("FECH_TRAB", "FECH_TRAB")



        Dgvimportar.DataSource = dt
        LblCant.Text = Dgvimportar.Rows.Count

        NroCarta = ObtenerNroCarta()

        For Each drw As DataGridViewRow In Dgvimportar.Rows

            drw.Cells("NRO_CARTA").Value = NroCarta
            drw.Cells("REMITENTE").Value = CmbCodigo.Text
            drw.Cells("TRABAJO").Value = CmbRemito.Text
            drw.Cells("FECH_TRAB").Value = FechaImportacion.ToShortDateString

            drw.Cells("NRO_CARTA").Style.ForeColor = Color.Red
            drw.Cells("REMITENTE").Style.ForeColor = Color.Red
            drw.Cells("TRABAJO").Style.ForeColor = Color.Red
            drw.Cells("FECH_TRAB").Style.ForeColor = Color.Red
            NroCarta = NroCarta + 1

        Next

        For Each drwsininfo As DataGridViewRow In DgvNoUtilizado.Rows
            Dgvimportar.Columns.Add(drwsininfo.Cells("SIN_USAR").Value, drwsininfo.Cells("SIN_USAR").Value)
            Dgvimportar.Columns(drwsininfo.Cells("SIN_USAR").Value).Visible = False
        Next

        'Catch ex As OleDbException
        '    MessageBox.Show("Error detectado " & ex.ToString)
        'End Try
    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
    Private Sub BtnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportar.Click
        'Try
        PasarDatos()
        'Catch ex As Exception
        '    MsgBox("Hay un error")
        'End Try

    End Sub
    Private Sub PasarDatos()
        Dim cadena As New System.Text.StringBuilder
        Dim txtsql As String = ""

        For Each drw As DataGridViewRow In Dgvimportar.Rows

            Dim OBS As String = ""
            Dim OBS2 As String = ""
            Dim OBS3 As String = ""
            Dim OBS4 As String = ""
            Dim APELLIDO As String = ""
            Dim NRO As String = ""
            Dim PISO_DEPTO As String = ""
            Dim EMPRESA As String = ""

            If Not IsDBNull(drw.Cells("OBS").Value) Then
                OBS = drw.Cells("OBS").Value
            End If
            If Not IsDBNull(drw.Cells("OBS2").Value) Then
                OBS2 = drw.Cells("OBS2").Value
            End If
            If Not IsDBNull(drw.Cells("OBS3").Value) Then
                OBS3 = drw.Cells("OBS3").Value
            End If
            If Not IsDBNull(drw.Cells("OBS4").Value) Then
                OBS4 = drw.Cells("OBS4").Value
            End If

            If Not IsDBNull(drw.Cells("APELLIDO").Value) Then
                APELLIDO = drw.Cells("APELLIDO").Value
            End If
            If Not IsDBNull(drw.Cells("NRO").Value) Then
                NRO = drw.Cells("NRO").Value
            End If
            If Not IsDBNull(drw.Cells("PISO_DEPTO").Value) Then
                PISO_DEPTO = drw.Cells("PISO_DEPTO").Value
            End If
            If Not IsDBNull(drw.Cells("EMPRESA").Value) Then
                EMPRESA = drw.Cells("EMPRESA").Value
            End If





            txtsql = "(" & "'" & drw.Cells("NRO_CARTA").Value & "' , " _
            & "'" & drw.Cells("REMITENTE").Value & "'" & ", " _
            & "'" & drw.Cells("TRABAJO").Value & "'" & ", " _
            & "'" & Converfecha(drw.Cells("FECH_TRAB").Value) & "'" & ", " _
            & "'" & Normalizar(APELLIDO) & "'" & ", " _
            & "'" & drw.Cells("CP").Value & "'" & ", " _
            & "'" & Normalizar(Trim(drw.Cells("CALLE").Value)) & "'" & ", " _
            & "'" & Normalizar(NRO) & "', " _
            & "'" & Normalizar(PISO_DEPTO) & "', " _
            & "'" & drw.Cells("LOCALIDAD").Value & "'" & ", " _
            & "'" & drw.Cells("PROVINCIA").Value & "'" & ", " _
            & "'" & "PEND_IMPR" & "'" & ", " _
            & "'" & drw.Cells("NRO_CART2").Value & "'" & ", " _
            & "'" & Normalizar(EMPRESA) & "'" & ", " _
            & "'" & drw.Cells("SOCIO").Value & "'" & ", " _
            & "" & ObtenerAño(Now.ToShortDateString) & "" & ", " _
            & "'" & Normalizar(OBS) & "'" & ", " _
            & "'" & Normalizar(OBS2) & "'" & ", " _
            & "'" & Normalizar(OBS3) & "'" & ", " _
            & "'" & Normalizar(OBS4) & "'" & ")" & ", "
            'MsgBox(txtsql)
            cadena.Append(txtsql)
        Next
        Dim Archtxt3 As String

        Archtxt3 = cadena.ToString
        If Len(Archtxt3) > 0 Then
            Archtxt3 = Mid(Archtxt3, 1, Len(Archtxt3) - 2)
        End If

        If ConfigCorreo.CN_Correo.InstertarCARTAS(Archtxt3) = True Then
            ActualizarNroCarta(NroCarta)
            ActualizarRemito(CmbRemito.Text, CmbCodigo.Text, "PEND_IMPR", LblCant.Text)
            If MessageBox.Show(LblCant.Text & " Registros Cargados", LblCant.Text & " Registros Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If

        End If


        'ConfigCorreo.CN_Correo.ImportarcionRegistros(dt, CmbRemito.Text, CmbCodigo.Text, DtpFLimite.Value.ToShortDateString, Usuario)
    End Sub


    Public Shared Function ObtenerAño(ByVal Fecha As Date) As Integer

        Dim thisDate As Date
        Dim thisYear As Integer
        thisDate = Fecha
        thisYear = Year(thisDate)
        Return thisYear

    End Function

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not IMP2.isalive Then
            FrmProgreso.Close()
            Me.Close()
        End If

    End Sub
    Private Sub DgvNoUtilizado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Private Sub BtnArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchivo.Click
        'Dgvimportar.DataSource = Nothing
        'DgvNoUtilizado.Rows.Clear()
        System.Diagnostics.Process.Start(txtPath.Text)
        Me.Dispose()

        'txtPath.Text = ""
        'CmbCodigo.Enabled = True

    End Sub
    Private Shared Function Normalizar(ByVal Dato As String) As String

        If Dato <> Nothing Then
            Dato = Dato.Replace("'", "")
            Dato = Dato.Replace(",", "")
        End If

        Return Dato
    End Function



    Private Sub DataGridView1_ColumnAdded( _
      ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs) _
      Handles Dgvimportar.ColumnAdded

        ' Se está añadiendo una columna al control DataGridView. Indicamos
        ' que la columna sólo podrá ser ordenada mediante programación,
        ' pero a diferencia del valor Programatic, el encabezado de columna
        ' no incluirá el espacio para un glifo de ordenación.
        '
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Sub BtnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLista.Click
        'Try
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets.Add()
        exHoja.Cells.NumberFormat = "@"
        exHoja.Cells.Item(1, 1) = "APELLIDO"
        exHoja.Cells.Item(1, 2) = "CALLE"
        exHoja.Cells.Item(1, 2) = "NRO"
        exHoja.Cells.Item(1, 2) = "PISO_DEPTO"
        exHoja.Cells.Item(1, 3) = "CP"
        exHoja.Cells.Item(1, 4) = "LOCALIDAD"
        exHoja.Cells.Item(1, 5) = "PROVINCIA"
        exHoja.Cells.Item(1, 6) = "EMPRESA"
        exHoja.Cells.Item(1, 7) = "NRO_CART2"
        exHoja.Cells.Item(1, 8) = "SOCIO"
        exHoja.Cells.Item(1, 9) = "OBS"
        exHoja.Cells.Item(1, 10) = "OBS2"
        exHoja.Cells.Item(1, 11) = "OBS3"
        exHoja.Cells.Item(1, 12) = "OBS4"

        exApp.Application.Visible = True





        ' ''exLibro.Close()
        ' ''exHoja = Nothing
        ' ''exLibro = Nothing
        ' ''exApp = Nothing
    End Sub



    Private Sub BtnNormalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNormalizar.Click
        SeleccionarNormalizar()
    End Sub
    Public Sub SeleccionarNormalizar()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcelNormalizar(.FileName) = True Then
                    txtPath.Text = Path.GetFileName(.FileName)
                End If
            Else
                openFD.Dispose()
            End If
        End With

    End Sub
    Private Function impExcelNormalizar(ByVal Archivo As String) As Boolean
        Dim NombreHoja As String = ObtenerNombrePrimeraHoja(Archivo)

        Dim dt2 As New DataTable
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + Archivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & NombreHoja & "$]", mconn)
        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()


        '*********
        Dgvimportar.DataSource = dt2



        Return True

    End Function
    Private Function ObtenerNombrePrimeraHoja(ByVal rutaLibro As String) As String
        Dim app As Excel.Application = Nothing
        Try
            app = New Excel.Application()
            Dim wb As Excel.Workbook = app.Workbooks.Open(rutaLibro)
            Dim ws As Excel.Worksheet = CType(wb.Worksheets.Item(1), Excel.Worksheet)
            Dim name As String = ws.Name
            ws = Nothing
            wb.Close()
            wb = Nothing
            Return name
        Catch ex As Exception
            Throw

        Finally
            If (Not app Is Nothing) Then _
                app.Quit()
            Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImportarExcelDeswiss()
    End Sub



    Private Function ImportarExcelDeswiss()

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                LeerExcelComoDataTable(.FileName)

            Else
                openFD.Dispose()
            End If
            BtnArchivo.Enabled = True
        End With

    End Function




    Public Function LeerExcelComoDataTable(ByVal rutaArchivo As String)
        Dim NombreHoja As String = ObtenerNombrePrimeraHoja(rutaArchivo)

        Dim dt2 As New DataTable
        Dim strconn As String
        strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " + rutaArchivo + ";Extended properties=""Excel 8.0;hdr=yes;imex=1"""
        Dim mconn As New OleDbConnection(strconn)
        Dim ad As New OleDbDataAdapter("Select * from [" & NombreHoja & "$]", mconn)
        mconn.Open()
        ad.Fill(dt2)
        mconn.Close()

        ' Eliminar espacios en los nombres de los campos
        For Each column As DataColumn In dt2.Columns
            column.ColumnName = column.ColumnName.Replace(" ", "")
        Next
        '21365
        ' Agregar columna "APELLIDO"
        dt2.Columns.Add("APELLIDO", GetType(String))
        dt2.Columns.Add("NRO_CART2", GetType(String))
        dt2.Columns.Add("OBS2", GetType(String))
        dt2.Columns.Add("OBS4", GetType(String))
        dt2.Columns.Add("OBS", GetType(String))

        ' Establecer valor de la columna "APELLIDO"
        For Each row As DataRow In dt2.Rows

            'Juntar Apellido y nombre en uns sola columna ya creada llamada apellido
            Dim apellidoTitular As String = row("APELLIDO_TITULAR").ToString().TrimEnd()
            Dim nombreTitular As String = row("NOMBRE_TITULAR").ToString().TrimEnd()
            Dim calle As String = row("DOMI_ENT").ToString().TrimEnd()
            calle = calle.Replace("PISO", "").Replace("DEPTO", "").Replace("OF", "")
            Dim contra As String = row("CONTRA").ToString().TrimEnd()
            Dim creden As String = row("CREDEN").ToString().TrimEnd()
            Dim integ As String = row("INTEGRANTES").ToString().TrimEnd()
            contra = contra.PadLeft(7, "0")
            creden = creden.PadLeft(7, "0")
            Dim NroCart2 As String = contra & "-" & creden & "-" & integ
            Dim locali As String = row("LOCA_DENO_ENT").ToString().TrimEnd().ToUpper()
            Dim provin As String = row("PROV_DENO_ENT").ToString().TrimEnd().ToUpper()
            locali = locali.Replace("CIUDAD AUTONOMA BUENOS AIRES", "CAPITAL FEDERAL")
            Dim cp As String = row("POST").ToString().TrimEnd()
            Dim empres As String = row("RAZON").ToString().TrimEnd()
            Dim tele As String = row("TELE").ToString().TrimEnd()
            Dim planilla As String = row("PLANTILLA").ToString().TrimEnd()
            Dim correo As String = row("EMPRESA_ENTREGA").ToString().TrimEnd()


            '        

            row("APELLIDO") = apellidoTitular & " " & nombreTitular
            row("DOMI_ENT") = calle
            row("CREDEN") = creden
            row("NRO_CART2") = NroCart2.Replace("/", "-")
            row("LOCA_DENO_ENT") = locali
            row("PROV_DENO_ENT") = provin
            row("POST") = cp
            row("RAZON") = empres
            row("TELE") = tele
            row("PLANTILLA") = planilla
            row("EMPRESA_ENTREGA") = correo



            If row("EMPRESA_ENTREGA") = "SEPRIT" Or row("EMPRESA_ENTREGA") = "CA" Then
                row("OBS2") = "SEPRIT"
            End If
            If row("EMPRESA_ENTREGA") = "DEVOLVER A SWISS" Then
                row("OBS2") = "DEV A SWISS"
            End If
            If row("EMPRESA_ENTREGA") = "SWISS" Then
                row("OBS2") = "SWISS"
            End If
            If row("PLANTILLA").ToString.Contains("Y2") Then
                row("OBS4") = "Y2"
            End If

            If row("ARMADO").ToString.Contains("ALTA") Then
                row("OBS") = "ALTAS"
            Else
                row("OBS") = "NOVEDADES"
            End If


            '


        Next


        dt2.Columns("LOCA_DENO_ENT").ColumnName = "LOCALIDAD"
        dt2.Columns("PROV_DENO_ENT").ColumnName = "PROVINCIA"
        dt2.Columns("POST").ColumnName = "CP"
        dt2.Columns("RAZON").ColumnName = "EMPRESA"
        dt2.Columns("TELE").ColumnName = "SOCIO"
        dt2.Columns("PLANTILLA").ColumnName = "OBS3"



        dt2.Columns.Remove("APELLIDO_TITULAR")
        dt2.Columns.Remove("NOMBRE_TITULAR")

        ' Establecer posición de la columna "APELLIDO"
        dt2.Columns("APELLIDO").SetOrdinal(1)
        dt2.Columns("NRO_CART2").SetOrdinal(2)
        dt2.Columns("LOCALIDAD").SetOrdinal(4)
        dt2.Columns("PROVINCIA").SetOrdinal(5)


        Dim domicilios As New Dictionary(Of String, Integer)

        For Each row As DataRow In dt2.Rows
            Dim domicilio As String = row("DOMI_ENT").ToString().TrimEnd()
            If domicilios.ContainsKey(domicilio) AndAlso String.IsNullOrEmpty(row("OBS2").ToString().Trim()) Then
                domicilios(domicilio) += 1
                row("OBS2") = "ARM"
            ElseIf Not domicilios.ContainsKey(domicilio) Then
                domicilios.Add(domicilio, 1)
            End If
        Next



        '*********
        Dgvimportar.DataSource = dt2

    End Function



End Class