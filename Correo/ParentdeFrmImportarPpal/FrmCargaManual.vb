Public Class FrmCargaManual
    Dim m_controlPresionado As Boolean = False
    Private Sub FrmCargaManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrServi As New ArrayList
        ArrServi = ConfigCorreo.CN_Correo.CargarTodoslosServicios
        CmbRemitente.Items.Clear()
        For i As Integer = 0 To ArrServi.Count - 1
            CmbRemitente.Items.Add(ArrServi.Item(i).ToString)
        Next
    End Sub

    '*****************************************************************

    Private Sub TxtNombre_Apellido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre_Apellido.GotFocus
        TxtNombre_Apellido.BackColor = Color.White
    End Sub
    Private Sub TxtCalle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCalle.GotFocus
        TxtCalle.BackColor = Color.White
    End Sub
    Private Sub TxtCp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCp.GotFocus
        TxtCp.BackColor = Color.White
    End Sub
    Private Sub TxtLocalidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLocalidad.GotFocus
        TxtLocalidad.BackColor = Color.White
    End Sub
    Private Sub TxtProvincia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProvincia.GotFocus
        TxtProvincia.BackColor = Color.White
    End Sub
    Private Sub TxtEmpresa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmpresa.GotFocus
        TxtEmpresa.BackColor = Color.White
    End Sub
    Private Sub TxtNro_Carta2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNro_Carta2.GotFocus
        TxtNro_Carta2.BackColor = Color.White
    End Sub
    Private Sub TxtPrecio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrecio.GotFocus
        TxtPrecio.BackColor = Color.White
    End Sub
    Private Sub TxtSocio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSocio.GotFocus
        TxtSocio.BackColor = Color.White
    End Sub
    Private Sub TxtValor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtValor.GotFocus
        TxtValor.BackColor = Color.White
    End Sub
    Private Sub TxtCobrar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCobrar.GotFocus
        TxtCobrar.BackColor = Color.White
    End Sub
    Private Sub TxtTipo_Doc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTipo_Doc.GotFocus
        TxtTipo_Doc.BackColor = Color.White
    End Sub
    Private Sub TxtDocumento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDocumento.GotFocus
        TxtDocumento.BackColor = Color.White
    End Sub
    Private Sub TxtObs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs.GotFocus
        TxtObs.BackColor = Color.White
    End Sub
    Private Sub TxtObs2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs2.GotFocus
        TxtObs2.BackColor = Color.White
    End Sub
    Private Sub TxtObs3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs3.GotFocus
        TxtObs3.BackColor = Color.White
    End Sub
    Private Sub TxtObs4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs4.GotFocus
        TxtObs4.BackColor = Color.White
    End Sub

    Private Sub TxtNombre_Apellido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre_Apellido.LostFocus
        TxtNombre_Apellido.BackColor = Color.Silver
    End Sub
    Private Sub TxtCalle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCalle.LostFocus
        TxtCalle.BackColor = Color.Silver
    End Sub
    Private Sub TxtCp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCp.LostFocus
        TxtCp.BackColor = Color.Silver
    End Sub
    Private Sub TxtLocalidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLocalidad.LostFocus
        TxtLocalidad.BackColor = Color.Silver
    End Sub
    Private Sub TxtProvincia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProvincia.LostFocus
        TxtProvincia.BackColor = Color.Silver
    End Sub
    Private Sub TxtEmpresa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmpresa.LostFocus
        TxtEmpresa.BackColor = Color.Silver
    End Sub
    Private Sub TxtNro_Carta2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNro_Carta2.LostFocus
        TxtNro_Carta2.BackColor = Color.Silver
    End Sub
    Private Sub TxtPrecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrecio.LostFocus
        TxtPrecio.BackColor = Color.Silver
    End Sub
    Private Sub TxtSocio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSocio.LostFocus
        TxtSocio.BackColor = Color.Silver
    End Sub
    Private Sub TxtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtValor.LostFocus
        TxtValor.BackColor = Color.Silver
    End Sub
    Private Sub TxtCobrar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCobrar.LostFocus
        TxtCobrar.BackColor = Color.Silver
    End Sub
    Private Sub TxtTipo_Doc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTipo_Doc.LostFocus
        TxtTipo_Doc.BackColor = Color.Silver
    End Sub
    Private Sub TxtDocumento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDocumento.LostFocus
        TxtDocumento.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs.LostFocus
        TxtObs.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs2.LostFocus
        TxtObs2.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs3.LostFocus
        TxtObs3.BackColor = Color.Silver
    End Sub
    Private Sub TxtObs4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObs4.LostFocus
        TxtObs4.BackColor = Color.Silver
    End Sub
    '********************************************************************

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Activar()
    End Sub
    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    '********************************************************************
    Private Sub CmbRemitente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbRemitente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            CmbNroTrab.Enabled = True
            CmbNroTrab.Focus()
        End If
    End Sub
    Private Sub TxtNombre_Apellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre_Apellido.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtCalle.Focus()
        End If
    End Sub
    Private Sub TxtCalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCalle.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtCp.Focus()
        End If
    End Sub
    Private Sub TxtCp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCp.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtLocalidad.Focus()
        End If
    End Sub
    Private Sub TxtLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLocalidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtProvincia.Focus()
        End If
    End Sub
    Private Sub TxtProvincia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProvincia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtEmpresa.Focus()
        End If
    End Sub
    Private Sub TxtEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmpresa.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtNro_Carta2.Focus()
        End If
    End Sub
    Private Sub TxtNro_Carta2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNro_Carta2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtPrecio.Focus()
        End If
    End Sub
    Private Sub TxtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtSocio.Focus()
        End If
    End Sub
    Private Sub TxtSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSocio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtValor.Focus()
        End If
    End Sub
    Private Sub TxtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtValor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtCobrar.Focus()
        End If
    End Sub
    Private Sub TxtCobrar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCobrar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtTipo_Doc.Focus()
        End If
    End Sub
    Private Sub TxtTipo_Doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTipo_Doc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtDocumento.Focus()
        End If
    End Sub
    Private Sub TxtDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDocumento.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtObs.Focus()
        End If
    End Sub
    Private Sub TxtObs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObs.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtObs2.Focus()
        End If
    End Sub
    Private Sub TxtObs2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObs2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtObs3.Focus()
        End If
    End Sub
    Private Sub TxtObs3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObs3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtObs4.Focus()
        End If
    End Sub
    Private Sub TxtObs4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObs4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnIngresar.Focus()
        End If
    End Sub
    Private Sub CmbNroTrab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbNroTrab.KeyPress
        Dim NroCarta As Integer = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If Len(CmbNroTrab.Text) > 1 Then
                TxtNombre_Apellido.Focus()
                CmbNroTrab.Enabled = False
                CmbRemitente.Enabled = False
                NroCarta = ConfigCorreo.CN_Correo.ObtenerNroCarta
                TxtNro_Carta.Text = NroCarta
                BtnSeleccionar.Enabled = False


                If Len(CmbNroTrab.Text) > 1 Then
                    Dim CodServ As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbNroTrab.Text, CmbRemitente.Text)
                    Dim Cantdias As Integer = ConfigCorreo.CN_Correo.ObtenerDiasServicio(CodServ)
                    Dim dias As Date = Now.ToShortDateString
                    DtFechTrab.Value = dias.AddDays(Cantdias)
                    BtnSeleccionar.Enabled = True
                End If
                BtnSeleccionar.Enabled = False

            End If
        End If
    End Sub

    '********************************************************************


    Private Sub Activar()
        TxtNombre_Apellido.Enabled = True
        TxtCalle.Enabled = True
        TxtCp.Enabled = True
        TxtLocalidad.Enabled = True
        TxtProvincia.Enabled = True
        TxtEmpresa.Enabled = True
        TxtNro_Carta2.Enabled = True
        TxtPrecio.Enabled = True
        TxtSocio.Enabled = True
        TxtValor.Enabled = True
        TxtCobrar.Enabled = True
        TxtTipo_Doc.Enabled = True
        TxtDocumento.Enabled = True
        TxtObs.Enabled = True
        TxtObs2.Enabled = True
        TxtObs3.Enabled = True
        TxtObs4.Enabled = True
        CmbRemitente.Enabled = True
        CmbNroTrab.Enabled = True
        BtnSeleccionar.Enabled = True
        CmbRemitente.Focus()
        BtnIngresar.Enabled = True


    End Sub
    Private Sub Desactivar()
        CmbRemitente.Enabled = False
        TxtNombre_Apellido.Enabled = False
        TxtCalle.Enabled = False
        TxtCp.Enabled = False
        TxtLocalidad.Enabled = False
        TxtProvincia.Enabled = False
        TxtEmpresa.Enabled = False
        TxtNro_Carta2.Enabled = False
        TxtPrecio.Enabled = False
        TxtSocio.Enabled = False
        TxtValor.Enabled = False
        TxtCobrar.Enabled = False
        TxtTipo_Doc.Enabled = False
        TxtDocumento.Enabled = False
        TxtObs.Enabled = False
        TxtObs2.Enabled = False
        TxtObs3.Enabled = False
        TxtObs4.Enabled = False
    End Sub
    Private Sub Limpiar()
        CmbRemitente.Text = ""
        TxtNombre_Apellido.Text = ""
        TxtCalle.Text = ""
        TxtCp.Text = ""
        TxtLocalidad.Text = ""
        TxtProvincia.Text = ""
        TxtEmpresa.Text = ""
        TxtNro_Carta2.Text = ""
        TxtPrecio.Text = ""
        TxtSocio.Text = ""
        TxtValor.Text = ""
        TxtCobrar.Text = ""
        TxtTipo_Doc.Text = ""
        TxtDocumento.Text = ""
        TxtObs.Text = ""
        TxtObs2.Text = ""
        TxtObs3.Text = ""
        TxtObs4.Text = ""
    End Sub
    Private Sub CargarCarta()

        Dim Servicio As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbNroTrab.Text, CmbRemitente.Text)
        Dim Usuario As String
        Usuario = FrmPpal.Usuario
        Dim fecha As String = ConfigCorreo.CN_Correo.Converfecha(ConfigCorreo.CN_Correo.ObtenerFechaRemito(CmbNroTrab.Text, CmbRemitente.Text))
        ConfigCorreo.CN_Correo.InstertarRegistro(TxtNro_Carta.Text, CmbRemitente.Text, CmbNroTrab.Text, "'" & fecha & "'", TxtNombre_Apellido.Text, TxtCp.Text, TxtCalle.Text, TxtLocalidad.Text, TxtProvincia.Text, TxtEmpresa.Text, TxtNro_Carta2.Text, TxtPrecio.Text, TxtSocio.Text, TxtValor.Text, TxtCobrar.Text, TxtObs.Text, TxtObs2.Text, TxtObs3.Text, TxtObs4.Text, Usuario, Servicio, "'" & ConfigCorreo.CN_Correo.Converfecha(DtFechTrab.Value) & "'", "'" & ConfigCorreo.CN_Correo.Converfecha(Now.ToShortDateString.ToString) & "'", TxtTipo_Doc.Text, TxtDocumento.Text)
        ConfigCorreo.CN_Correo.ActualizarNroCarta(TxtNro_Carta.Text + 1)
        Limpiar()


    End Sub
    Private Sub ObtenerNroCarta()
        Dim NroCarta As String

        If Len(CmbNroTrab.Text) > 1 Then
            TxtNombre_Apellido.Focus()
            CmbNroTrab.Enabled = False
            CmbRemitente.Enabled = False
            NroCarta = ConfigCorreo.CN_Correo.ObtenerNroCarta
            TxtNro_Carta.Text = NroCarta
            BtnSeleccionar.Enabled = False


            If Len(CmbNroTrab.Text) > 1 Then
                Dim CodServ As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbNroTrab.Text, CmbRemitente.Text)
                Dim Cantdias As Integer = ConfigCorreo.CN_Correo.ObtenerDiasServicio(CodServ)
                Dim dias As Date = Now.ToShortDateString
                DtFechTrab.Value = dias.AddDays(Cantdias)
                BtnSeleccionar.Enabled = True
            End If
            BtnSeleccionar.Enabled = False

        End If
    End Sub

    '*********************************************************************
    Private Sub CmbRemitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRemitente.SelectedIndexChanged
        Dim ArrServicios As New ArrayList
        ArrServicios = ConfigCorreo.CN_Correo.RemitosdeCte(CmbRemitente.Text)
        CmbNroTrab.Items.Clear()
        For i As Integer = 0 To ArrServicios.Count - 1
            CmbNroTrab.Items.Add(ArrServicios.Item(i).ToString)
        Next

    End Sub
    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click
        Dim NroCarta As Integer = 0
        If Len(CmbNroTrab.Text) > 1 Then
            If Len(CmbRemitente.Text) > 1 Then
                TxtNombre_Apellido.Focus()
                CmbNroTrab.Enabled = False
                CmbRemitente.Enabled = False
                NroCarta = ConfigCorreo.CN_Correo.ObtenerNroCarta
                TxtNro_Carta.Text = NroCarta
                BtnSeleccionar.Enabled = False
                If Len(CmbNroTrab.Text) > 1 Then
                    Dim CodServ As String = ConfigCorreo.CN_Correo.ObtenerServicio(CmbNroTrab.Text, CmbRemitente.Text)
                    Dim Cantdias As Integer = ConfigCorreo.CN_Correo.ObtenerDiasServicio(CodServ)
                    Dim dias As Date = Now.ToShortDateString
                    DtFechTrab.Value = dias.AddDays(Cantdias)
                    BtnSeleccionar.Enabled = False

                End If

            End If
        End If

    End Sub


    Private Sub CmbRemitente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbRemitente.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtNombre_Apellido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre_Apellido.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'Hemos pulsado Ctrl+i
                MessageBox.Show("control i")
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    'Hemos pulsado Ctrl+i
                    MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtCalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCalle.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtCp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCp.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtLocalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLocalidad.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtProvincia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProvincia.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmpresa.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtNro_Carta2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNro_Carta2.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrecio.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtSocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSocio.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtValor.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtCobrar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCobrar.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtTipo_Doc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTipo_Doc.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtDocumento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDocumento.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtObs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObs.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtObs2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObs2.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtObs3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObs3.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub
    Private Sub TxtObs4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObs4.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            m_controlPresionado = True
        Else
            If (e.KeyCode = Keys.I AndAlso m_controlPresionado) Then
                'MessageBox.Show("control i")
                CargarCarta()
            Else
                If (e.KeyCode = Keys.N AndAlso m_controlPresionado) Then
                    Limpiar()
                    Activar()
                    'MessageBox.Show("control n")
                End If

            End If
            m_controlPresionado = False
        End If
    End Sub


End Class
