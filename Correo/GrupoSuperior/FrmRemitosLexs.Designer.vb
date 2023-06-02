<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRemitosLexs
    Inherits Correo.FrmPlantilla

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtRemito = New System.Windows.Forms.TextBox()
        Me.CmbDesde = New System.Windows.Forms.ComboBox()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.PbRemito = New System.Windows.Forms.PictureBox()
        Me.BtnDibujar = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.PbRemito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 1011)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1146, 1011)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnDibujar)
        Me.Gb.Controls.Add(Me.PbRemito)
        Me.Gb.Controls.Add(Me.DtpDesde)
        Me.Gb.Controls.Add(Me.CmbDesde)
        Me.Gb.Controls.Add(Me.TxtRemito)
        Me.Gb.Controls.Add(Me.BtnNuevo)
        Me.Gb.Size = New System.Drawing.Size(1193, 1062)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnNuevo, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtRemito, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.DtpDesde, 0)
        Me.Gb.Controls.SetChildIndex(Me.PbRemito, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnDibujar, 0)
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 39)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(80, 40)
        Me.BtnNuevo.TabIndex = 61
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtRemito
        '
        Me.TxtRemito.Enabled = False
        Me.TxtRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemito.Location = New System.Drawing.Point(98, 59)
        Me.TxtRemito.Name = "TxtRemito"
        Me.TxtRemito.Size = New System.Drawing.Size(120, 20)
        Me.TxtRemito.TabIndex = 62
        Me.TxtRemito.Text = "1122246"
        '
        'CmbDesde
        '
        Me.CmbDesde.FormattingEnabled = True
        Me.CmbDesde.Location = New System.Drawing.Point(272, 59)
        Me.CmbDesde.Name = "CmbDesde"
        Me.CmbDesde.Size = New System.Drawing.Size(121, 21)
        Me.CmbDesde.TabIndex = 106
        '
        'DtpDesde
        '
        Me.DtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDesde.Location = New System.Drawing.Point(492, 51)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(350, 26)
        Me.DtpDesde.TabIndex = 107
        '
        'PbRemito
        '
        Me.PbRemito.Location = New System.Drawing.Point(12, 109)
        Me.PbRemito.Name = "PbRemito"
        Me.PbRemito.Size = New System.Drawing.Size(1100, 600)
        Me.PbRemito.TabIndex = 108
        Me.PbRemito.TabStop = False
        '
        'BtnDibujar
        '
        Me.BtnDibujar.BackColor = System.Drawing.Color.Teal
        Me.BtnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDibujar.Location = New System.Drawing.Point(1032, 47)
        Me.BtnDibujar.Name = "BtnDibujar"
        Me.BtnDibujar.Size = New System.Drawing.Size(80, 40)
        Me.BtnDibujar.TabIndex = 109
        Me.BtnDibujar.Text = "Dibujar"
        Me.BtnDibujar.UseVisualStyleBackColor = False
        '
        'FrmRemitosLexs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1193, 1061)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmRemitosLexs"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.PbRemito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtRemito As TextBox
    Friend WithEvents CmbDesde As ComboBox
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents PbRemito As PictureBox
    Friend WithEvents BtnDibujar As Button
End Class
