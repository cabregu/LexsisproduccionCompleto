﻿Public Class FrmimprimirEtiqueta
    Public DtImprimir As New DataTable

    Private Sub CmbRemitoPendiente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitoPendiente.SelectedIndexChanged
        If Len(CmbRemitente.Text) > 0 Then
            CmbRemitoPendiente.Enabled = False
            BtnSelectEtic.Enabled = True
            DtImprimir = ConfigCorreo.CN_Correo.LlenarDatatableImprimir(CmbRemitoPendiente.Text)
            DgvImprimir.DataSource = DtImprimir
            LblCant.Text = DgvImprimir.RowCount
        End If
    End Sub
    Private Sub BtnSelectEtic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectEtic.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.Rpt)|*.Rpt"
            .Multiselect = False
            .InitialDirectory = "C:\Crisis\Correo\Etiquetas"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TxtPath.Text = .FileName
            Else
                openFD.Dispose()
            End If
        End With
        Btnimprimir.Enabled = True

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub CmbRemitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitente.SelectedIndexChanged
        Dim ArrayPendImpr As New ArrayList
        ArrayPendImpr = ConfigCorreo.CN_Correo.ObtenerRemitosPendientesImpresion(CmbRemitente.Text)

        CmbRemitoPendiente.Items.Clear()
        For i As Integer = 0 To ArrayPendImpr.Count - 1
            CmbRemitoPendiente.Items.Add(ArrayPendImpr.Item(i).ToString)
        Next
        CmbRemitente.Enabled = False
    End Sub
    Private Sub FrmimprimirEtiqueta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrayRemitentes As New ArrayList
        ArrayRemitentes = ConfigCorreo.CN_Correo.CargarTodoslosremitente
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To ArrayRemitentes.Count - 1
            CmbRemitente.Items.Add(ArrayRemitentes.Item(i).ToString)
        Next
    End Sub

  
    Private Sub Btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprimir.Click

        FrmReportEtiquetas.EtiquetaSeleccionada = TxtPath.Text
        FrmReportEtiquetas.DTRegImprimir = DtImprimir
        'FrmReportEtiquetas.RemitenteNombre = CmbRemitente.Text
        'FrmReportEtiquetas.RemitoNro = CmbRemitoPendiente.Text
        FrmReportEtiquetas.Cant = DgvImprimir.Rows.Count

        FrmReportEtiquetas.Show()
    End Sub

    Private Sub BtnCambiarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCambiarEstado.Click
        If CmbRemitente.Text <> "" And CmbRemitoPendiente.Text <> "" Then

            If MessageBox.Show("Cambiar estado de todo el remito nro: " & CmbRemitoPendiente.Text & " remitente " & CmbRemitente.Text & " a ESP_PROG ?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                ConfigCorreo.CN_Correo.ActualizarRemito(CmbRemitoPendiente.Text, CmbRemitente.Text, "ESP_PROG", LblCant.Text)
                ConfigCorreo.CN_Correo.ActualizarEstado(CmbRemitoPendiente.Text, CmbRemitente.Text, "ESP_PROG")
                Me.Close()
            End If
        Else
            MsgBox("Seleccione remito y remitente")
        End If

    End Sub
End Class