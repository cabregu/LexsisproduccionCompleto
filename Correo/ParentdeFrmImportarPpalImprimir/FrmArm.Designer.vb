<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArm
    Inherits Correo.FrmPlantilla

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblRemitente = New System.Windows.Forms.Label()
        Me.CmbRemitente = New System.Windows.Forms.ComboBox()
        Me.LblRemitoPendiente = New System.Windows.Forms.Label()
        Me.CmbRemitoPendiente = New System.Windows.Forms.ComboBox()
        Me.DgvSeleccion = New System.Windows.Forms.DataGridView()
        Me.LblCant = New System.Windows.Forms.Label()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 561)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(861, 561)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.DgvDatos)
        Me.Gb.Controls.Add(Me.BtnPdf)
        Me.Gb.Controls.Add(Me.LblCant)
        Me.Gb.Controls.Add(Me.DgvSeleccion)
        Me.Gb.Controls.Add(Me.LblRemitente)
        Me.Gb.Controls.Add(Me.CmbRemitente)
        Me.Gb.Controls.Add(Me.LblRemitoPendiente)
        Me.Gb.Controls.Add(Me.CmbRemitoPendiente)
        Me.Gb.Size = New System.Drawing.Size(928, 612)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitoPendiente, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmbRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblRemitente, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvSeleccion, 0)
        Me.Gb.Controls.SetChildIndex(Me.LblCant, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnPdf, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvDatos, 0)
        '
        'LblRemitente
        '
        Me.LblRemitente.AutoSize = True
        Me.LblRemitente.Location = New System.Drawing.Point(27, 16)
        Me.LblRemitente.Name = "LblRemitente"
        Me.LblRemitente.Size = New System.Drawing.Size(55, 13)
        Me.LblRemitente.TabIndex = 34
        Me.LblRemitente.Text = "Remitente"
        '
        'CmbRemitente
        '
        Me.CmbRemitente.FormattingEnabled = True
        Me.CmbRemitente.Location = New System.Drawing.Point(30, 36)
        Me.CmbRemitente.Name = "CmbRemitente"
        Me.CmbRemitente.Size = New System.Drawing.Size(118, 21)
        Me.CmbRemitente.TabIndex = 33
        '
        'LblRemitoPendiente
        '
        Me.LblRemitoPendiente.AutoSize = True
        Me.LblRemitoPendiente.Location = New System.Drawing.Point(209, 16)
        Me.LblRemitoPendiente.Name = "LblRemitoPendiente"
        Me.LblRemitoPendiente.Size = New System.Drawing.Size(101, 13)
        Me.LblRemitoPendiente.TabIndex = 30
        Me.LblRemitoPendiente.Text = "Remitos Pendientes"
        '
        'CmbRemitoPendiente
        '
        Me.CmbRemitoPendiente.FormattingEnabled = True
        Me.CmbRemitoPendiente.Location = New System.Drawing.Point(193, 36)
        Me.CmbRemitoPendiente.Name = "CmbRemitoPendiente"
        Me.CmbRemitoPendiente.Size = New System.Drawing.Size(117, 21)
        Me.CmbRemitoPendiente.TabIndex = 29
        '
        'DgvSeleccion
        '
        Me.DgvSeleccion.AllowUserToAddRows = False
        Me.DgvSeleccion.AllowUserToDeleteRows = False
        Me.DgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSeleccion.Location = New System.Drawing.Point(30, 77)
        Me.DgvSeleccion.Name = "DgvSeleccion"
        Me.DgvSeleccion.ReadOnly = True
        Me.DgvSeleccion.Size = New System.Drawing.Size(750, 200)
        Me.DgvSeleccion.TabIndex = 35
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(27, 280)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(13, 13)
        Me.LblCant.TabIndex = 30
        Me.LblCant.Text = "0"
        '
        'BtnPdf
        '
        Me.BtnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPdf.Image = Global.Correo.My.Resources.Resources.DefaultPrinterNetwork_32x32
        Me.BtnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPdf.Location = New System.Drawing.Point(730, 508)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(50, 47)
        Me.BtnPdf.TabIndex = 39
        Me.BtnPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPdf.UseVisualStyleBackColor = True
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Location = New System.Drawing.Point(30, 302)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(750, 200)
        Me.DgvDatos.TabIndex = 40
        '
        'FrmArm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(914, 611)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmArm"
        Me.Text = "Arm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblRemitente As Label
    Friend WithEvents CmbRemitente As ComboBox
    Friend WithEvents LblRemitoPendiente As Label
    Friend WithEvents CmbRemitoPendiente As ComboBox
    Friend WithEvents DgvSeleccion As DataGridView
    Friend WithEvents LblCant As Label
    Friend WithEvents BtnPdf As Button
    Friend WithEvents DgvDatos As DataGridView
End Class
