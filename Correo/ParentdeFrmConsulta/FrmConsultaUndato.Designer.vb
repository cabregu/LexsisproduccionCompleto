<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaUndato
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim LblSeparacion As System.Windows.Forms.Label
        Dim SOCIOLabel As System.Windows.Forms.Label
        Dim NRO_CARTA2Label As System.Windows.Forms.Label
        Dim ARTICULOLabel As System.Windows.Forms.Label
        Dim EMPRESALabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim SERVICIOLabel As System.Windows.Forms.Label
        Dim NRO_CARTALabel As System.Windows.Forms.Label
        Dim OBS2Label As System.Windows.Forms.Label
        Dim FECH_TRABLabel As System.Windows.Forms.Label
        Dim OBS3Label As System.Windows.Forms.Label
        Dim OBS4Label As System.Windows.Forms.Label
        Dim REMITENTELabel As System.Windows.Forms.Label
        Dim TRABAJOLabel As System.Windows.Forms.Label
        Dim NOMBRE_APELLIDOLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim LOCALIDADLabel As System.Windows.Forms.Label
        Dim CALLELabel As System.Windows.Forms.Label
        Dim PROVINCIALabel As System.Windows.Forms.Label
        Dim F_LIMITELabel As System.Windows.Forms.Label
        Dim ESTADOLabel As System.Windows.Forms.Label
        Dim LblObservaciones As System.Windows.Forms.Label
        Dim LblVisitadasEntregadasTransito As System.Windows.Forms.Label
        Dim LblNroPLanilla As System.Windows.Forms.Label
        Dim LblFechaPlanilla As System.Windows.Forms.Label
        Dim LblDevueltas As System.Windows.Forms.Label
        Dim LblTransito As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DgvFechas = New System.Windows.Forms.DataGridView()
        Me.SOCIOTextBox = New System.Windows.Forms.TextBox()
        Me.ARTICULOTextBox = New System.Windows.Forms.TextBox()
        Me.NRO_CART2TextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.SERVICIOTextBox = New System.Windows.Forms.TextBox()
        Me.EMPRESATextBox = New System.Windows.Forms.TextBox()
        Me.OBS2TextBox = New System.Windows.Forms.TextBox()
        Me.OBS3TextBox = New System.Windows.Forms.TextBox()
        Me.OBS4TextBox = New System.Windows.Forms.TextBox()
        Me.NRO_CARTATextBox = New System.Windows.Forms.TextBox()
        Me.FECH_TRABTextBox = New System.Windows.Forms.TextBox()
        Me.REMITENTETextBox = New System.Windows.Forms.TextBox()
        Me.TRABAJOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRE_APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.CALLETextBox = New System.Windows.Forms.TextBox()
        Me.LOCALIDADTextBox = New System.Windows.Forms.TextBox()
        Me.PROVINCIATextBox = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnImagen = New System.Windows.Forms.Button()
        Me.TxtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.F_LIMITETextBox = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.ESTADOTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAvisoDeVisita = New System.Windows.Forms.Button()
        Me.DgvInformes = New System.Windows.Forms.DataGridView()
        Me.TxtPLanilla = New System.Windows.Forms.TextBox()
        Me.TxtFechaPlanilla = New System.Windows.Forms.TextBox()
        Me.DgvDevueltas = New System.Windows.Forms.DataGridView()
        Me.DgvTransito = New System.Windows.Forms.DataGridView()
        Me.BtnAlerta = New System.Windows.Forms.Button()
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.Gpb1 = New System.Windows.Forms.GroupBox()
        LblSeparacion = New System.Windows.Forms.Label()
        SOCIOLabel = New System.Windows.Forms.Label()
        NRO_CARTA2Label = New System.Windows.Forms.Label()
        ARTICULOLabel = New System.Windows.Forms.Label()
        EMPRESALabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        SERVICIOLabel = New System.Windows.Forms.Label()
        NRO_CARTALabel = New System.Windows.Forms.Label()
        OBS2Label = New System.Windows.Forms.Label()
        FECH_TRABLabel = New System.Windows.Forms.Label()
        OBS3Label = New System.Windows.Forms.Label()
        OBS4Label = New System.Windows.Forms.Label()
        REMITENTELabel = New System.Windows.Forms.Label()
        TRABAJOLabel = New System.Windows.Forms.Label()
        NOMBRE_APELLIDOLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        LOCALIDADLabel = New System.Windows.Forms.Label()
        CALLELabel = New System.Windows.Forms.Label()
        PROVINCIALabel = New System.Windows.Forms.Label()
        F_LIMITELabel = New System.Windows.Forms.Label()
        ESTADOLabel = New System.Windows.Forms.Label()
        LblObservaciones = New System.Windows.Forms.Label()
        LblVisitadasEntregadasTransito = New System.Windows.Forms.Label()
        LblNroPLanilla = New System.Windows.Forms.Label()
        LblFechaPlanilla = New System.Windows.Forms.Label()
        LblDevueltas = New System.Windows.Forms.Label()
        LblTransito = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDevueltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTransito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSeparacion
        '
        LblSeparacion.AutoSize = True
        LblSeparacion.Enabled = False
        LblSeparacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblSeparacion.Location = New System.Drawing.Point(1, 159)
        LblSeparacion.Name = "LblSeparacion"
        LblSeparacion.Size = New System.Drawing.Size(912, 16)
        LblSeparacion.TabIndex = 258
        LblSeparacion.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "--------------------"
        '
        'SOCIOLabel
        '
        SOCIOLabel.AutoSize = True
        SOCIOLabel.Enabled = False
        SOCIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOCIOLabel.Location = New System.Drawing.Point(703, 59)
        SOCIOLabel.Name = "SOCIOLabel"
        SOCIOLabel.Size = New System.Drawing.Size(57, 16)
        SOCIOLabel.TabIndex = 248
        SOCIOLabel.Text = "SOCIO:"
        '
        'NRO_CARTA2Label
        '
        NRO_CARTA2Label.AutoSize = True
        NRO_CARTA2Label.Enabled = False
        NRO_CARTA2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NRO_CARTA2Label.Location = New System.Drawing.Point(511, 5)
        NRO_CARTA2Label.Name = "NRO_CARTA2Label"
        NRO_CARTA2Label.Size = New System.Drawing.Size(97, 16)
        NRO_CARTA2Label.TabIndex = 231
        NRO_CARTA2Label.Text = "NRO CART2:"
        '
        'ARTICULOLabel
        '
        ARTICULOLabel.AutoSize = True
        ARTICULOLabel.Enabled = False
        ARTICULOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ARTICULOLabel.Location = New System.Drawing.Point(834, 54)
        ARTICULOLabel.Name = "ARTICULOLabel"
        ARTICULOLabel.Size = New System.Drawing.Size(86, 16)
        ARTICULOLabel.TabIndex = 250
        ARTICULOLabel.Text = "ARTICULO:"
        '
        'EMPRESALabel
        '
        EMPRESALabel.AutoSize = True
        EMPRESALabel.Enabled = False
        EMPRESALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMPRESALabel.Location = New System.Drawing.Point(256, 113)
        EMPRESALabel.Name = "EMPRESALabel"
        EMPRESALabel.Size = New System.Drawing.Size(84, 16)
        EMPRESALabel.TabIndex = 229
        EMPRESALabel.Text = "EMPRESA:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Enabled = False
        OBSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBSLabel.Location = New System.Drawing.Point(9, 175)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(42, 16)
        OBSLabel.TabIndex = 227
        OBSLabel.Text = "OBS:"
        '
        'SERVICIOLabel
        '
        SERVICIOLabel.AutoSize = True
        SERVICIOLabel.Enabled = False
        SERVICIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SERVICIOLabel.Location = New System.Drawing.Point(390, 5)
        SERVICIOLabel.Name = "SERVICIOLabel"
        SERVICIOLabel.Size = New System.Drawing.Size(81, 16)
        SERVICIOLabel.TabIndex = 233
        SERVICIOLabel.Text = "SERVICIO:"
        '
        'NRO_CARTALabel
        '
        NRO_CARTALabel.AutoSize = True
        NRO_CARTALabel.Enabled = False
        NRO_CARTALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NRO_CARTALabel.Location = New System.Drawing.Point(5, 6)
        NRO_CARTALabel.Name = "NRO_CARTALabel"
        NRO_CARTALabel.Size = New System.Drawing.Size(99, 16)
        NRO_CARTALabel.TabIndex = 193
        NRO_CARTALabel.Text = "NRO CARTA:"
        '
        'OBS2Label
        '
        OBS2Label.AutoSize = True
        OBS2Label.Enabled = False
        OBS2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBS2Label.Location = New System.Drawing.Point(250, 173)
        OBS2Label.Name = "OBS2Label"
        OBS2Label.Size = New System.Drawing.Size(50, 16)
        OBS2Label.TabIndex = 235
        OBS2Label.Text = "OBS2:"
        '
        'FECH_TRABLabel
        '
        FECH_TRABLabel.AutoSize = True
        FECH_TRABLabel.Enabled = False
        FECH_TRABLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FECH_TRABLabel.Location = New System.Drawing.Point(824, 5)
        FECH_TRABLabel.Name = "FECH_TRABLabel"
        FECH_TRABLabel.Size = New System.Drawing.Size(96, 16)
        FECH_TRABLabel.TabIndex = 215
        FECH_TRABLabel.Text = "FECH TRAB:"
        '
        'OBS3Label
        '
        OBS3Label.AutoSize = True
        OBS3Label.Enabled = False
        OBS3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBS3Label.Location = New System.Drawing.Point(494, 173)
        OBS3Label.Name = "OBS3Label"
        OBS3Label.Size = New System.Drawing.Size(50, 16)
        OBS3Label.TabIndex = 237
        OBS3Label.Text = "OBS3:"
        '
        'OBS4Label
        '
        OBS4Label.AutoSize = True
        OBS4Label.Enabled = False
        OBS4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OBS4Label.Location = New System.Drawing.Point(741, 173)
        OBS4Label.Name = "OBS4Label"
        OBS4Label.Size = New System.Drawing.Size(50, 16)
        OBS4Label.TabIndex = 239
        OBS4Label.Text = "OBS4:"
        '
        'REMITENTELabel
        '
        REMITENTELabel.AutoSize = True
        REMITENTELabel.Enabled = False
        REMITENTELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        REMITENTELabel.Location = New System.Drawing.Point(129, 5)
        REMITENTELabel.Name = "REMITENTELabel"
        REMITENTELabel.Size = New System.Drawing.Size(99, 16)
        REMITENTELabel.TabIndex = 195
        REMITENTELabel.Text = "REMITENTE:"
        '
        'TRABAJOLabel
        '
        TRABAJOLabel.AutoSize = True
        TRABAJOLabel.Enabled = False
        TRABAJOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TRABAJOLabel.Location = New System.Drawing.Point(251, 5)
        TRABAJOLabel.Name = "TRABAJOLabel"
        TRABAJOLabel.Size = New System.Drawing.Size(81, 16)
        TRABAJOLabel.TabIndex = 197
        TRABAJOLabel.Text = "TRABAJO:"
        '
        'NOMBRE_APELLIDOLabel
        '
        NOMBRE_APELLIDOLabel.AutoSize = True
        NOMBRE_APELLIDOLabel.Enabled = False
        NOMBRE_APELLIDOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRE_APELLIDOLabel.Location = New System.Drawing.Point(5, 61)
        NOMBRE_APELLIDOLabel.Name = "NOMBRE_APELLIDOLabel"
        NOMBRE_APELLIDOLabel.Size = New System.Drawing.Size(72, 16)
        NOMBRE_APELLIDOLabel.TabIndex = 199
        NOMBRE_APELLIDOLabel.Text = "NOMBRE"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Enabled = False
        CPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPLabel.Location = New System.Drawing.Point(513, 59)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(31, 16)
        CPLabel.TabIndex = 201
        CPLabel.Text = "CP:"
        '
        'LOCALIDADLabel
        '
        LOCALIDADLabel.AutoSize = True
        LOCALIDADLabel.Enabled = False
        LOCALIDADLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LOCALIDADLabel.Location = New System.Drawing.Point(9, 113)
        LOCALIDADLabel.Name = "LOCALIDADLabel"
        LOCALIDADLabel.Size = New System.Drawing.Size(94, 16)
        LOCALIDADLabel.TabIndex = 205
        LOCALIDADLabel.Text = "LOCALIDAD:"
        '
        'CALLELabel
        '
        CALLELabel.AutoSize = True
        CALLELabel.Enabled = False
        CALLELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CALLELabel.Location = New System.Drawing.Point(256, 61)
        CALLELabel.Name = "CALLELabel"
        CALLELabel.Size = New System.Drawing.Size(57, 16)
        CALLELabel.TabIndex = 203
        CALLELabel.Text = "CALLE:"
        '
        'PROVINCIALabel
        '
        PROVINCIALabel.AutoSize = True
        PROVINCIALabel.Enabled = False
        PROVINCIALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PROVINCIALabel.Location = New System.Drawing.Point(131, 113)
        PROVINCIALabel.Name = "PROVINCIALabel"
        PROVINCIALabel.Size = New System.Drawing.Size(92, 16)
        PROVINCIALabel.TabIndex = 207
        PROVINCIALabel.Text = "PROVINCIA:"
        '
        'F_LIMITELabel
        '
        F_LIMITELabel.AutoSize = True
        F_LIMITELabel.Enabled = False
        F_LIMITELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        F_LIMITELabel.Location = New System.Drawing.Point(583, 61)
        F_LIMITELabel.Name = "F_LIMITELabel"
        F_LIMITELabel.Size = New System.Drawing.Size(72, 16)
        F_LIMITELabel.TabIndex = 247
        F_LIMITELabel.Text = "F LIMITE:"
        '
        'ESTADOLabel
        '
        ESTADOLabel.AutoSize = True
        ESTADOLabel.Enabled = False
        ESTADOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ESTADOLabel.Location = New System.Drawing.Point(482, 113)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(73, 16)
        ESTADOLabel.TabIndex = 263
        ESTADOLabel.Text = "ESTADO:"
        '
        'LblObservaciones
        '
        LblObservaciones.AutoSize = True
        LblObservaciones.Enabled = False
        LblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblObservaciones.Location = New System.Drawing.Point(9, 280)
        LblObservaciones.Name = "LblObservaciones"
        LblObservaciones.Size = New System.Drawing.Size(237, 16)
        LblObservaciones.TabIndex = 267
        LblObservaciones.Text = "OBSERVACIONES PRINCIPALES"
        '
        'LblVisitadasEntregadasTransito
        '
        LblVisitadasEntregadasTransito.AutoSize = True
        LblVisitadasEntregadasTransito.Enabled = False
        LblVisitadasEntregadasTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblVisitadasEntregadasTransito.Location = New System.Drawing.Point(6, 491)
        LblVisitadasEntregadasTransito.Name = "LblVisitadasEntregadasTransito"
        LblVisitadasEntregadasTransito.Size = New System.Drawing.Size(194, 16)
        LblVisitadasEntregadasTransito.TabIndex = 268
        LblVisitadasEntregadasTransito.Text = "VISITADAS ENTREGADAS"
        '
        'LblNroPLanilla
        '
        LblNroPLanilla.AutoSize = True
        LblNroPLanilla.Enabled = False
        LblNroPLanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblNroPLanilla.Location = New System.Drawing.Point(703, 113)
        LblNroPLanilla.Name = "LblNroPLanilla"
        LblNroPLanilla.Size = New System.Drawing.Size(80, 16)
        LblNroPLanilla.TabIndex = 269
        LblNroPLanilla.Text = "PLANILLA:"
        '
        'LblFechaPlanilla
        '
        LblFechaPlanilla.AutoSize = True
        LblFechaPlanilla.Enabled = False
        LblFechaPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblFechaPlanilla.Location = New System.Drawing.Point(828, 113)
        LblFechaPlanilla.Name = "LblFechaPlanilla"
        LblFechaPlanilla.Size = New System.Drawing.Size(134, 16)
        LblFechaPlanilla.TabIndex = 271
        LblFechaPlanilla.Text = "FECHA PLANILLA:"
        '
        'LblDevueltas
        '
        LblDevueltas.AutoSize = True
        LblDevueltas.Enabled = False
        LblDevueltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblDevueltas.Location = New System.Drawing.Point(5, 385)
        LblDevueltas.Name = "LblDevueltas"
        LblDevueltas.Size = New System.Drawing.Size(229, 16)
        LblDevueltas.TabIndex = 276
        LblDevueltas.Text = "OBSERVACIONES DEVUELTAS"
        '
        'LblTransito
        '
        LblTransito.AutoSize = True
        LblTransito.Enabled = False
        LblTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblTransito.Location = New System.Drawing.Point(4, 592)
        LblTransito.Name = "LblTransito"
        LblTransito.Size = New System.Drawing.Size(84, 16)
        LblTransito.TabIndex = 278
        LblTransito.Text = "TRANSITO"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(42, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(163, 16)
        Label1.TabIndex = 281
        Label1.Text = "Cometario Obligatorio:"
        '
        'DgvFechas
        '
        Me.DgvFechas.AllowUserToAddRows = False
        Me.DgvFechas.AllowUserToDeleteRows = False
        Me.DgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFechas.Location = New System.Drawing.Point(8, 299)
        Me.DgvFechas.Name = "DgvFechas"
        Me.DgvFechas.ReadOnly = True
        Me.DgvFechas.Size = New System.Drawing.Size(879, 80)
        Me.DgvFechas.TabIndex = 257
        '
        'SOCIOTextBox
        '
        Me.SOCIOTextBox.Enabled = False
        Me.SOCIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOCIOTextBox.Location = New System.Drawing.Point(706, 78)
        Me.SOCIOTextBox.Name = "SOCIOTextBox"
        Me.SOCIOTextBox.Size = New System.Drawing.Size(116, 22)
        Me.SOCIOTextBox.TabIndex = 249
        '
        'ARTICULOTextBox
        '
        Me.ARTICULOTextBox.Enabled = False
        Me.ARTICULOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARTICULOTextBox.Location = New System.Drawing.Point(828, 78)
        Me.ARTICULOTextBox.Name = "ARTICULOTextBox"
        Me.ARTICULOTextBox.Size = New System.Drawing.Size(148, 22)
        Me.ARTICULOTextBox.TabIndex = 251
        '
        'NRO_CART2TextBox
        '
        Me.NRO_CART2TextBox.Enabled = False
        Me.NRO_CART2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_CART2TextBox.Location = New System.Drawing.Point(512, 25)
        Me.NRO_CART2TextBox.Name = "NRO_CART2TextBox"
        Me.NRO_CART2TextBox.Size = New System.Drawing.Size(310, 22)
        Me.NRO_CART2TextBox.TabIndex = 232
        '
        'OBSTextBox
        '
        Me.OBSTextBox.Enabled = False
        Me.OBSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBSTextBox.Location = New System.Drawing.Point(7, 192)
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(240, 22)
        Me.OBSTextBox.TabIndex = 228
        '
        'SERVICIOTextBox
        '
        Me.SERVICIOTextBox.Enabled = False
        Me.SERVICIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SERVICIOTextBox.Location = New System.Drawing.Point(393, 25)
        Me.SERVICIOTextBox.Name = "SERVICIOTextBox"
        Me.SERVICIOTextBox.Size = New System.Drawing.Size(113, 22)
        Me.SERVICIOTextBox.TabIndex = 234
        '
        'EMPRESATextBox
        '
        Me.EMPRESATextBox.Enabled = False
        Me.EMPRESATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPRESATextBox.Location = New System.Drawing.Point(253, 133)
        Me.EMPRESATextBox.Name = "EMPRESATextBox"
        Me.EMPRESATextBox.Size = New System.Drawing.Size(226, 22)
        Me.EMPRESATextBox.TabIndex = 230
        '
        'OBS2TextBox
        '
        Me.OBS2TextBox.Enabled = False
        Me.OBS2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBS2TextBox.Location = New System.Drawing.Point(253, 192)
        Me.OBS2TextBox.Name = "OBS2TextBox"
        Me.OBS2TextBox.Size = New System.Drawing.Size(236, 22)
        Me.OBS2TextBox.TabIndex = 236
        '
        'OBS3TextBox
        '
        Me.OBS3TextBox.Enabled = False
        Me.OBS3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBS3TextBox.Location = New System.Drawing.Point(495, 192)
        Me.OBS3TextBox.Name = "OBS3TextBox"
        Me.OBS3TextBox.Size = New System.Drawing.Size(240, 22)
        Me.OBS3TextBox.TabIndex = 238
        '
        'OBS4TextBox
        '
        Me.OBS4TextBox.Enabled = False
        Me.OBS4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OBS4TextBox.Location = New System.Drawing.Point(741, 192)
        Me.OBS4TextBox.Name = "OBS4TextBox"
        Me.OBS4TextBox.Size = New System.Drawing.Size(235, 22)
        Me.OBS4TextBox.TabIndex = 240
        '
        'NRO_CARTATextBox
        '
        Me.NRO_CARTATextBox.Enabled = False
        Me.NRO_CARTATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NRO_CARTATextBox.Location = New System.Drawing.Point(8, 25)
        Me.NRO_CARTATextBox.Name = "NRO_CARTATextBox"
        Me.NRO_CARTATextBox.Size = New System.Drawing.Size(100, 22)
        Me.NRO_CARTATextBox.TabIndex = 194
        '
        'FECH_TRABTextBox
        '
        Me.FECH_TRABTextBox.Enabled = False
        Me.FECH_TRABTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECH_TRABTextBox.Location = New System.Drawing.Point(828, 25)
        Me.FECH_TRABTextBox.Name = "FECH_TRABTextBox"
        Me.FECH_TRABTextBox.Size = New System.Drawing.Size(148, 22)
        Me.FECH_TRABTextBox.TabIndex = 217
        '
        'REMITENTETextBox
        '
        Me.REMITENTETextBox.Enabled = False
        Me.REMITENTETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REMITENTETextBox.Location = New System.Drawing.Point(132, 25)
        Me.REMITENTETextBox.Name = "REMITENTETextBox"
        Me.REMITENTETextBox.Size = New System.Drawing.Size(100, 22)
        Me.REMITENTETextBox.TabIndex = 196
        '
        'TRABAJOTextBox
        '
        Me.TRABAJOTextBox.Enabled = False
        Me.TRABAJOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRABAJOTextBox.Location = New System.Drawing.Point(256, 25)
        Me.TRABAJOTextBox.Name = "TRABAJOTextBox"
        Me.TRABAJOTextBox.Size = New System.Drawing.Size(118, 22)
        Me.TRABAJOTextBox.TabIndex = 198
        '
        'NOMBRE_APELLIDOTextBox
        '
        Me.NOMBRE_APELLIDOTextBox.Enabled = False
        Me.NOMBRE_APELLIDOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRE_APELLIDOTextBox.Location = New System.Drawing.Point(6, 78)
        Me.NOMBRE_APELLIDOTextBox.Name = "NOMBRE_APELLIDOTextBox"
        Me.NOMBRE_APELLIDOTextBox.Size = New System.Drawing.Size(246, 22)
        Me.NOMBRE_APELLIDOTextBox.TabIndex = 200
        '
        'CPTextBox
        '
        Me.CPTextBox.Enabled = False
        Me.CPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPTextBox.Location = New System.Drawing.Point(512, 78)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(65, 22)
        Me.CPTextBox.TabIndex = 202
        '
        'CALLETextBox
        '
        Me.CALLETextBox.Enabled = False
        Me.CALLETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALLETextBox.Location = New System.Drawing.Point(256, 78)
        Me.CALLETextBox.Name = "CALLETextBox"
        Me.CALLETextBox.Size = New System.Drawing.Size(250, 22)
        Me.CALLETextBox.TabIndex = 204
        '
        'LOCALIDADTextBox
        '
        Me.LOCALIDADTextBox.Enabled = False
        Me.LOCALIDADTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOCALIDADTextBox.Location = New System.Drawing.Point(7, 133)
        Me.LOCALIDADTextBox.Name = "LOCALIDADTextBox"
        Me.LOCALIDADTextBox.Size = New System.Drawing.Size(116, 22)
        Me.LOCALIDADTextBox.TabIndex = 206
        '
        'PROVINCIATextBox
        '
        Me.PROVINCIATextBox.Enabled = False
        Me.PROVINCIATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROVINCIATextBox.Location = New System.Drawing.Point(134, 133)
        Me.PROVINCIATextBox.Name = "PROVINCIATextBox"
        Me.PROVINCIATextBox.Size = New System.Drawing.Size(116, 22)
        Me.PROVINCIATextBox.TabIndex = 208
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Image = Global.Correo.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(973, 628)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(53, 70)
        Me.BtnSalir.TabIndex = 259
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnImagen
        '
        Me.BtnImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImagen.Location = New System.Drawing.Point(422, 245)
        Me.BtnImagen.Name = "BtnImagen"
        Me.BtnImagen.Size = New System.Drawing.Size(67, 30)
        Me.BtnImagen.TabIndex = 260
        Me.BtnImagen.Text = "Imagen"
        Me.BtnImagen.UseVisualStyleBackColor = True
        '
        'TxtRutaArchivo
        '
        Me.TxtRutaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRutaArchivo.Location = New System.Drawing.Point(154, 249)
        Me.TxtRutaArchivo.Name = "TxtRutaArchivo"
        Me.TxtRutaArchivo.Size = New System.Drawing.Size(262, 22)
        Me.TxtRutaArchivo.TabIndex = 261
        '
        'F_LIMITETextBox
        '
        Me.F_LIMITETextBox.Enabled = False
        Me.F_LIMITETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_LIMITETextBox.Location = New System.Drawing.Point(586, 78)
        Me.F_LIMITETextBox.Name = "F_LIMITETextBox"
        Me.F_LIMITETextBox.Size = New System.Drawing.Size(114, 22)
        Me.F_LIMITETextBox.TabIndex = 256
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(6, 248)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(115, 23)
        Me.BtnModificar.TabIndex = 262
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'ESTADOTextBox
        '
        Me.ESTADOTextBox.Enabled = False
        Me.ESTADOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTADOTextBox.Location = New System.Drawing.Point(485, 133)
        Me.ESTADOTextBox.Name = "ESTADOTextBox"
        Me.ESTADOTextBox.Size = New System.Drawing.Size(218, 22)
        Me.ESTADOTextBox.TabIndex = 264
        '
        'BtnAvisoDeVisita
        '
        Me.BtnAvisoDeVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAvisoDeVisita.Location = New System.Drawing.Point(495, 252)
        Me.BtnAvisoDeVisita.Name = "BtnAvisoDeVisita"
        Me.BtnAvisoDeVisita.Size = New System.Drawing.Size(240, 23)
        Me.BtnAvisoDeVisita.TabIndex = 265
        Me.BtnAvisoDeVisita.Text = "Aviso de Visita"
        Me.BtnAvisoDeVisita.UseVisualStyleBackColor = True
        '
        'DgvInformes
        '
        Me.DgvInformes.AllowUserToAddRows = False
        Me.DgvInformes.AllowUserToDeleteRows = False
        Me.DgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInformes.Location = New System.Drawing.Point(4, 510)
        Me.DgvInformes.Name = "DgvInformes"
        Me.DgvInformes.ReadOnly = True
        Me.DgvInformes.Size = New System.Drawing.Size(879, 80)
        Me.DgvInformes.TabIndex = 266
        '
        'TxtPLanilla
        '
        Me.TxtPLanilla.Enabled = False
        Me.TxtPLanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPLanilla.Location = New System.Drawing.Point(709, 134)
        Me.TxtPLanilla.Name = "TxtPLanilla"
        Me.TxtPLanilla.Size = New System.Drawing.Size(116, 22)
        Me.TxtPLanilla.TabIndex = 270
        '
        'TxtFechaPlanilla
        '
        Me.TxtFechaPlanilla.Enabled = False
        Me.TxtFechaPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaPlanilla.Location = New System.Drawing.Point(831, 133)
        Me.TxtFechaPlanilla.Name = "TxtFechaPlanilla"
        Me.TxtFechaPlanilla.Size = New System.Drawing.Size(145, 22)
        Me.TxtFechaPlanilla.TabIndex = 272
        '
        'DgvDevueltas
        '
        Me.DgvDevueltas.AllowUserToAddRows = False
        Me.DgvDevueltas.AllowUserToDeleteRows = False
        Me.DgvDevueltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDevueltas.Location = New System.Drawing.Point(4, 404)
        Me.DgvDevueltas.Name = "DgvDevueltas"
        Me.DgvDevueltas.ReadOnly = True
        Me.DgvDevueltas.Size = New System.Drawing.Size(879, 80)
        Me.DgvDevueltas.TabIndex = 275
        '
        'DgvTransito
        '
        Me.DgvTransito.AllowUserToAddRows = False
        Me.DgvTransito.AllowUserToDeleteRows = False
        Me.DgvTransito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTransito.Location = New System.Drawing.Point(6, 611)
        Me.DgvTransito.Name = "DgvTransito"
        Me.DgvTransito.ReadOnly = True
        Me.DgvTransito.Size = New System.Drawing.Size(879, 80)
        Me.DgvTransito.TabIndex = 277
        '
        'BtnAlerta
        '
        Me.BtnAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlerta.Location = New System.Drawing.Point(76, 44)
        Me.BtnAlerta.Name = "BtnAlerta"
        Me.BtnAlerta.Size = New System.Drawing.Size(173, 23)
        Me.BtnAlerta.TabIndex = 279
        Me.BtnAlerta.Text = "Generar un alerta"
        Me.BtnAlerta.UseVisualStyleBackColor = True
        '
        'TxtComentario
        '
        Me.TxtComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComentario.Location = New System.Drawing.Point(6, 19)
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(243, 22)
        Me.TxtComentario.TabIndex = 280
        '
        'Gpb1
        '
        Me.Gpb1.Controls.Add(Me.BtnAlerta)
        Me.Gpb1.Controls.Add(Label1)
        Me.Gpb1.Controls.Add(Me.TxtComentario)
        Me.Gpb1.Location = New System.Drawing.Point(741, 220)
        Me.Gpb1.Name = "Gpb1"
        Me.Gpb1.Size = New System.Drawing.Size(255, 73)
        Me.Gpb1.TabIndex = 282
        Me.Gpb1.TabStop = False
        '
        'FrmConsultaUndato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1030, 703)
        Me.Controls.Add(Me.Gpb1)
        Me.Controls.Add(LblTransito)
        Me.Controls.Add(Me.DgvTransito)
        Me.Controls.Add(LblDevueltas)
        Me.Controls.Add(Me.DgvDevueltas)
        Me.Controls.Add(LblFechaPlanilla)
        Me.Controls.Add(Me.TxtFechaPlanilla)
        Me.Controls.Add(LblNroPLanilla)
        Me.Controls.Add(Me.TxtPLanilla)
        Me.Controls.Add(LblVisitadasEntregadasTransito)
        Me.Controls.Add(LblObservaciones)
        Me.Controls.Add(Me.DgvInformes)
        Me.Controls.Add(Me.BtnAvisoDeVisita)
        Me.Controls.Add(ESTADOLabel)
        Me.Controls.Add(Me.ESTADOTextBox)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TxtRutaArchivo)
        Me.Controls.Add(Me.BtnImagen)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.F_LIMITETextBox)
        Me.Controls.Add(LblSeparacion)
        Me.Controls.Add(Me.DgvFechas)
        Me.Controls.Add(SOCIOLabel)
        Me.Controls.Add(Me.SOCIOTextBox)
        Me.Controls.Add(F_LIMITELabel)
        Me.Controls.Add(Me.ARTICULOTextBox)
        Me.Controls.Add(NRO_CARTA2Label)
        Me.Controls.Add(ARTICULOLabel)
        Me.Controls.Add(Me.NRO_CART2TextBox)
        Me.Controls.Add(EMPRESALabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(SERVICIOLabel)
        Me.Controls.Add(Me.SERVICIOTextBox)
        Me.Controls.Add(Me.EMPRESATextBox)
        Me.Controls.Add(NRO_CARTALabel)
        Me.Controls.Add(Me.OBS2TextBox)
        Me.Controls.Add(Me.OBS3TextBox)
        Me.Controls.Add(OBS2Label)
        Me.Controls.Add(FECH_TRABLabel)
        Me.Controls.Add(Me.OBS4TextBox)
        Me.Controls.Add(OBS3Label)
        Me.Controls.Add(Me.NRO_CARTATextBox)
        Me.Controls.Add(OBS4Label)
        Me.Controls.Add(Me.FECH_TRABTextBox)
        Me.Controls.Add(REMITENTELabel)
        Me.Controls.Add(Me.REMITENTETextBox)
        Me.Controls.Add(TRABAJOLabel)
        Me.Controls.Add(Me.TRABAJOTextBox)
        Me.Controls.Add(NOMBRE_APELLIDOLabel)
        Me.Controls.Add(Me.NOMBRE_APELLIDOTextBox)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(Me.CPTextBox)
        Me.Controls.Add(Me.CALLETextBox)
        Me.Controls.Add(LOCALIDADLabel)
        Me.Controls.Add(CALLELabel)
        Me.Controls.Add(PROVINCIALabel)
        Me.Controls.Add(Me.LOCALIDADTextBox)
        Me.Controls.Add(Me.PROVINCIATextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.Name = "FrmConsultaUndato"
        Me.Text = "Consulta Un dato"
        CType(Me.DgvFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvInformes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDevueltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTransito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpb1.ResumeLayout(False)
        Me.Gpb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvFechas As System.Windows.Forms.DataGridView
    Friend WithEvents SOCIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ARTICULOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NRO_CART2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SERVICIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMPRESATextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBS2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBS3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBS4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NRO_CARTATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FECH_TRABTextBox As System.Windows.Forms.TextBox
    Friend WithEvents REMITENTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRABAJOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRE_APELLIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CALLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LOCALIDADTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROVINCIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnImagen As System.Windows.Forms.Button
    Friend WithEvents TxtRutaArchivo As System.Windows.Forms.TextBox
    Friend WithEvents F_LIMITETextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents ESTADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnAvisoDeVisita As System.Windows.Forms.Button
    Friend WithEvents DgvInformes As System.Windows.Forms.DataGridView
    Friend WithEvents TxtPLanilla As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents DgvDevueltas As System.Windows.Forms.DataGridView
    Friend WithEvents DgvTransito As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAlerta As System.Windows.Forms.Button
    Friend WithEvents TxtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Gpb1 As System.Windows.Forms.GroupBox
End Class
