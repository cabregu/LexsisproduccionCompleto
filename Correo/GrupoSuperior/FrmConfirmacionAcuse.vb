﻿Imports ConfigCorreo.CN_Correo
Public Class FrmConfirmacionAcuse
    Dim Listatemporal As New ArrayList

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        Dim NroRecorrido As Integer
        NroRecorrido = ConfigCorreo.CN_Correo.ObtenerNroPlanillaConfirmacionAcuse
        TxtNroplanilla.Text = NroRecorrido
        ConfigCorreo.CN_Correo.ActualizarNroPlanillaConfirmacionAcuse(TxtNroplanilla.Text)
        TxtCartas.Enabled = True
        DgvCartaConf.Rows.Clear()
        BtnNuevo.Enabled = False


    End Sub



    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        If DgvCartaConf.RowCount > 0 Then


            For Each drgv As DataGridViewRow In DgvCartaConf.Rows
                IngresarNuevoPLanillaConfAcuse(drgv.Cells("Nro_carta").Value, drgv.Cells("REMITENTE").Value, drgv.Cells("TRABAJO").Value, drgv.Cells("FECH_TRAB").Value, drgv.Cells("NOMBRE_APELLIDO").Value, drgv.Cells("CP").Value, drgv.Cells("CALLE").Value, drgv.Cells("LOCALIDAD").Value, drgv.Cells("PROVINCIA").Value, drgv.Cells("EMPRESA").Value, drgv.Cells("NRO_CARTA2").Value, drgv.Cells("ESTADO").Value, TxtNroplanilla.Text, DtpFecha.Value.ToShortDateString)
            Next

            DgvCartaConf.Rows.Clear()
            TxtCantidad.Text = ""
            TxtNroplanilla.Text = ""
            TxtCartas.Enabled = False

            BtnNuevo.Enabled = True
        End If

    End Sub




    Private Function Buscarcarta(ByVal carta As Integer) As Boolean
        'Try
        Dim DT As New DataTable
        DT = BuscarpornrodecartaParaPlanillado(carta)
        If DT.Rows.Count = 0 Then
            PlayBackgroundSoundFile()
        End If
        If Not Listatemporal.Contains(carta) Then
            For Each dr As DataRow In DT.Rows
                Dim fechtrab As Date = dr.Item("FECH_TRAB")
                DgvCartaConf.Rows.Add(carta, dr.Item("REMITENTE"), dr.Item("TRABAJO"), fechtrab.ToShortDateString, dr.Item("APELLIDO"), dr.Item("CP"), dr.Item("CALLE"), dr.Item("LOCALIDAD"), dr.Item("PROVINCIA"), dr.Item("EMPRESA"), dr.Item("NRO_CART2"), dr.Item("ESTADO"), TxtNroplanilla.Text, DtpFecha.Value.ToShortDateString)
                Listatemporal.Add(carta)
            Next
        End If

        'Catch ex As Exception
        '    Return False
        'End Try


    End Function

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("C:\errorpp.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub TxtCartas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCartas.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'quita sonido 

            Try

                If IsNumeric(TxtCartas.Text) Then

                    Buscarcarta(TxtCartas.Text)
                    TxtCartas.Text = ""
                    TxtCantidad.Text = ""
                    TxtCantidad.Text = DgvCartaConf.Rows.Count
                End If
            Catch ex As Exception
                TxtCartas.Text = ""
                PlayBackgroundSoundFile()
            End Try



        End If
    End Sub

    Private Sub FrmConfirmacionAcuse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
