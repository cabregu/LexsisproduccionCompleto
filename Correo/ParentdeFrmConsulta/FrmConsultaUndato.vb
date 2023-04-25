Imports ConfigCorreo.CN_Correo

Public Class FrmConsultaUndato

    Public Idstr As String


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub FrmConsultaUndato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargar(Idstr)
        Dim Comentario As String = VerificarAlerta(NRO_CARTATextBox.Text) 
        TxtComentario.Text = Comentario
        If TxtComentario.Text <> "" Then
            Gpb1.Enabled = False
        End If

    End Sub
    Private Sub cargar(ByVal ident As String)
        Dim Dt As New DataTable
        Dt = ConsultarUndato(ident)

        For Each dr As DataRow In Dt.Rows
            FECH_TRABTextBox.Text = dr("FECH_TRAB").ToString()
            NRO_CARTATextBox.Text = dr("NRO_CARTA").ToString()
            REMITENTETextBox.Text = dr("REMITENTE").ToString()
            TRABAJOTextBox.Text = dr("TRABAJO").ToString()
            NRO_CART2TextBox.Text = dr("NRO_CART2").ToString()
            NOMBRE_APELLIDOTextBox.Text = dr("APELLIDO").ToString()
            SERVICIOTextBox.Text = ObtenerServicio(dr("TRABAJO").ToString())
            CALLETextBox.Text = dr("CALLE").ToString()
            CPTextBox.Text = dr("CP").ToString()
            LOCALIDADTextBox.Text = dr("LOCALIDAD").ToString()
            PROVINCIATextBox.Text = dr("PROVINCIA").ToString()
            EMPRESATextBox.Text = dr("EMPRESA").ToString()
            ESTADOTextBox.Text = dr("ESTADO").ToString()
            SOCIOTextBox.Text = dr("SOCIO").ToString()
            OBSTextBox.Text = dr("OBS").ToString()
            OBS2TextBox.Text = dr("OBS2").ToString()
            OBS3TextBox.Text = dr("OBS3").ToString()
            OBS4TextBox.Text = dr("OBS4").ToString()

            DgvFechas.DataSource = ObtenerRecorridosPorCarta(dr("NRO_CARTA").ToString())

            'If ESTADOTextBox.Text = "DEVUELTA" Then
            DgvDevueltas.DataSource = Nothing
            DgvDevueltas.DataSource = ObtenerDevueltasPorCarta(dr("NRO_CARTA").ToString())

            'End If

            DgvTransito.DataSource = ObtenerEnTransitoPorCarta(dr("NRO_CARTA").ToString())


            Dim DtInf As New DataTable
            DtInf = CargarInformes(dr("NRO_CARTA").ToString())
            DgvInformes.DataSource = Nothing
            DgvInformes.DataSource = DtInf

            Dim DtPlanillado As New DataTable
            DtPlanillado = ObtenerNroPLanillaYFechaPorCarta(dr("NRO_CARTA").ToString)
            If DtPlanillado.Rows.Count > 0 Then
                For Each drw As DataRow In DtPlanillado.Rows
                    Dim Fech As Date = Nothing

                    If IsDate(drw("fecha_planilla").ToString) Then
                        Fech = drw("fecha_planilla").ToString
                    End If
                    TxtFechaPlanilla.Text = Fech.ToShortDateString
                    TxtPLanilla.Text = drw("nro_planilla").ToString
                Next
            End If




            'Dim DtEscaneado As New DataTable
            'DtEscaneado = ObtenerEscaneoPorCarta(dr("NRO_CARTA").ToString())
            'DgvEscaneo.DataSource = Nothing
            'DgvEscaneo.DataSource = DtEscaneado
            'DgvEscaneo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Next

    End Sub
    Private Function CargarInformes(ByVal IdentCarta As String) As DataTable

        Dim DtRecFinal As New DataTable
        DtRecFinal.Columns.Add("INFORME")
        DtRecFinal.Columns.Add("FECHA")
        DtRecFinal.Columns.Add("RENDICION")
        DtRecFinal.Columns.Add("FECHA_RENDICION")

        Dim DtVisitadas As DataTable
        DtVisitadas = ObtenerVisitadasParaConsultaDeUnDato(IdentCarta)

        For Each drw As DataRow In DtVisitadas.Rows
            DtRecFinal.Rows.Add(drw("INFORME"), drw("FECHA"), drw("RENDICION"), drw("FECHA_RENDICION"))
        Next
        Dim DtEntregadas As DataTable
        DtEntregadas = ObtenerEntregadasParaConsultaDeUnDato(IdentCarta)
        For Each drw As DataRow In DtEntregadas.Rows
            DtRecFinal.Rows.Add(drw("INFORME"), drw("FECHA"), drw("RENDICION"), drw("FECHA_RENDICION"))
        Next
        Return DtRecFinal
    End Function

    Public Sub EjecutarArchivos(ByVal ruta As String)
        Dim ejecutarShell As Object
        ejecutarShell = Shell("rundll32.exe url.dll,FileProtocolHandler " & (ruta), 1)

    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If BtnModificar.Text = "Modificar" Then
            BtnModificar.Text = "Actualizar"
            NRO_CART2TextBox.Enabled = True
            NOMBRE_APELLIDOTextBox.Enabled = True
            CALLETextBox.Enabled = True
            CPTextBox.Enabled = True
            LOCALIDADTextBox.Enabled = True
            PROVINCIATextBox.Enabled = True
            EMPRESATextBox.Enabled = True
            SOCIOTextBox.Enabled = True
            OBSTextBox.Enabled = True
            OBS2TextBox.Enabled = True
            OBS3TextBox.Enabled = True
            OBS4TextBox.Enabled = True
        Else
            NRO_CART2TextBox.Enabled = False
            NOMBRE_APELLIDOTextBox.Enabled = False
            CALLETextBox.Enabled = False
            CPTextBox.Enabled = False
            LOCALIDADTextBox.Enabled = False
            PROVINCIATextBox.Enabled = False
            EMPRESATextBox.Enabled = False
            SOCIOTextBox.Enabled = False
            OBSTextBox.Enabled = False
            OBS2TextBox.Enabled = False
            OBS3TextBox.Enabled = False
            OBS4TextBox.Enabled = False

            If MessageBox.Show("Modificar carta?", "BtnModificar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If ActualizarCartaPorId(NRO_CART2TextBox.Text, NOMBRE_APELLIDOTextBox.Text, CALLETextBox.Text, CPTextBox.Text, LOCALIDADTextBox.Text, PROVINCIATextBox.Text, EMPRESATextBox.Text, SOCIOTextBox.Text, OBSTextBox.Text, OBS2TextBox.Text, OBS3TextBox.Text, OBS4TextBox.Text, Idstr) = True Then
                    MsgBox("Carta Actualizada")
                    BtnModificar.Text = "Modificar"
                Else
                    MsgBox("Hay un error en los campos ingresados")
                End If
            End If



            '
        End If


    End Sub
    Private Sub BtnAvisoDeVisita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAvisoDeVisita.Click
        Dim frmAv As New FrmAvisoDeVisita
        frmAv.Idstr = Idstr
        frmAv.MdiParent = FrmConsultamdi
        frmAv.Show()
        Me.Close()

    End Sub


 
    'Private Sub DgvEscaneo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If DgvEscaneo.Rows.Count > 0 Then
    '        Try
    '            Dim N As String = DgvEscaneo.SelectedCells(0).RowIndex.ToString
    '            Dim Rutatx As String = DgvEscaneo.Rows(N).Cells("ruta_archivo").Value
    '            Dim NombreArchivo As String = DgvEscaneo.Rows(N).Cells("nrocartaleido").Value
    '            Dim Destination As String = "C:\Temp\" & NombreArchivo & ".jpg"
    '            System.IO.File.Copy(Rutatx, Destination, True)
    '            EjecutarArchivos(Destination)
    '        Catch ex As Exception
    '            MsgBox("Hay algun problema con la ruta, consultar")
    '        End Try

    '    End If
    'End Sub

    Private Sub BtnAlerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlerta.Click
        If TxtComentario.Text <> "" Then
            If InsertarAlerta(NRO_CARTATextBox.Text, TxtComentario.Text) = True Then
                MsgBox("Alerta Generada")
                Gpb1.Enabled = False

            End If


        End If
    End Sub
End Class