Imports System.Data.OleDb
Imports System.IO

Public Class FrmImprimirDesdeExcel
    Dim frmrep As FrmReportEtiquetasExcel

    Dim DTFinal As New DataTable
    Private Sub BtnSeleccionarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionarExcel.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                If impExcel(.FileName) = True Then
                    TxtPath.Text = Path.GetFileName(.FileName)
                End If
            Else
                openFD.Dispose()
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

            DTFinal.Columns.Add("NRO_CARTA")
            DTFinal.Columns.Add("REMITENTE")
            DTFinal.Columns.Add("TRABAJO")
            DTFinal.Columns.Add("FECH_TRAB")
            DTFinal.Columns.Add("APELLIDO")
            DTFinal.Columns.Add("CALLE")
            DTFinal.Columns.Add("NRO")
            DTFinal.Columns.Add("PISO_DEPTO")
            DTFinal.Columns.Add("CP")
            DTFinal.Columns.Add("LOCALIDAD")
            DTFinal.Columns.Add("PROVINCIA")
            DTFinal.Columns.Add("EMPRESA")
            DTFinal.Columns.Add("NRO_CART2")
            DTFinal.Columns.Add("SOCIO")
            DTFinal.Columns.Add("OBS")
            DTFinal.Columns.Add("OBS2")
            DTFinal.Columns.Add("OBS3")
            DTFinal.Columns.Add("OBS4")



            For Each drwd As DataRow In dt2.Rows
                Dim Dtbuscar As New DataTable
                Dtbuscar = ConfigCorreo.CN_Correo.BuscarPorNroCartaImpresion(drwd("Nro_Carta").ToString)
                For Each drw As DataRow In Dtbuscar.Rows
                    Dim Fecha As Date = drw("FECH_TRAB").ToString
                    DTFinal.Rows.Add(drw("NRO_CARTA").ToString, drw("REMITENTE").ToString, drw("TRABAJO").ToString, Fecha.ToShortDateString, drw("APELLIDO").ToString, drw("CALLE").ToString, drw("NRO").ToString, drw("PISO_DEPTO").ToString, drw("CP").ToString, drw("LOCALIDAD").ToString, drw("PROVINCIA").ToString, drw("EMPRESA").ToString, drw("NRO_CART2").ToString, drw("SOCIO").ToString, drw("OBS").ToString, drw("OBS2").ToString, drw("OBS3").ToString, drw("OBS4").ToString)

                Next

            Next

            DgvImprimir.DataSource = DTFinal



        Catch ex As Exception

        End Try



    End Function

    Private Sub BtnSelectEtic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectEtic.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.Rpt)|*.Rpt"
            .Multiselect = False
            .InitialDirectory = "C:\Crisisproduccion\Correo\Etiquetas"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TxtPath.Text = .FileName
            Else
                openFD.Dispose()
            End If
        End With

    End Sub

    Private Sub Btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprimir.Click
        frmrep = Nothing
        frmrep = New FrmReportEtiquetasExcel
        frmrep.EtiquetaSeleccionada = TxtPath.Text
        frmrep.DTRegImprimir = DTFinal
        frmrep.Cant = DgvImprimir.Rows.Count
        frmrep.Show()


    End Sub

    Private Sub FrmImprimirDesdeExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
