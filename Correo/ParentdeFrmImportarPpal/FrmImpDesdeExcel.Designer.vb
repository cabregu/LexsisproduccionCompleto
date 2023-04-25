<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpDesdeExcel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpDesdeExcel))
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.CmbCodigo = New System.Windows.Forms.ComboBox()
        Me.CmbRemito = New System.Windows.Forms.ComboBox()
        Me.LblRemito = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblFechalimite = New System.Windows.Forms.Label()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblCant = New System.Windows.Forms.Label()
        Me.Dgvimportar = New System.Windows.Forms.DataGridView()
        Me.DgvNoUtilizado = New System.Windows.Forms.DataGridView()
        Me.SIN_USAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnArchivo = New System.Windows.Forms.Button()
        Me.BtnLista = New System.Windows.Forms.Button()
        Me.BtnNormalizar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.Dgvimportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvNoUtilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(6, 67)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(342, 20)
        Me.txtPath.TabIndex = 71
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Enabled = False
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSeleccionar.Location = New System.Drawing.Point(354, 62)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(28, 29)
        Me.BtnSeleccionar.TabIndex = 72
        Me.BtnSeleccionar.Text = "S"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.ForeColor = System.Drawing.Color.Maroon
        Me.LblCodigo.Location = New System.Drawing.Point(3, 8)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(46, 13)
        Me.LblCodigo.TabIndex = 69
        Me.LblCodigo.Text = "Codigo"
        '
        'CmbCodigo
        '
        Me.CmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCodigo.FormattingEnabled = True
        Me.CmbCodigo.Location = New System.Drawing.Point(6, 27)
        Me.CmbCodigo.Name = "CmbCodigo"
        Me.CmbCodigo.Size = New System.Drawing.Size(165, 21)
        Me.CmbCodigo.TabIndex = 68
        '
        'CmbRemito
        '
        Me.CmbRemito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRemito.Enabled = False
        Me.CmbRemito.FormattingEnabled = True
        Me.CmbRemito.Location = New System.Drawing.Point(203, 27)
        Me.CmbRemito.Name = "CmbRemito"
        Me.CmbRemito.Size = New System.Drawing.Size(135, 21)
        Me.CmbRemito.TabIndex = 75
        '
        'LblRemito
        '
        Me.LblRemito.AutoSize = True
        Me.LblRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemito.ForeColor = System.Drawing.Color.Maroon
        Me.LblRemito.Location = New System.Drawing.Point(200, 8)
        Me.LblRemito.Name = "LblRemito"
        Me.LblRemito.Size = New System.Drawing.Size(46, 13)
        Me.LblRemito.TabIndex = 76
        Me.LblRemito.Text = "Remito"
        '
        'DtpFecha
        '
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Location = New System.Drawing.Point(630, 27)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(240, 21)
        Me.DtpFecha.TabIndex = 81
        '
        'LblFechalimite
        '
        Me.LblFechalimite.AutoSize = True
        Me.LblFechalimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechalimite.ForeColor = System.Drawing.Color.Maroon
        Me.LblFechalimite.Location = New System.Drawing.Point(627, 8)
        Me.LblFechalimite.Name = "LblFechalimite"
        Me.LblFechalimite.Size = New System.Drawing.Size(42, 13)
        Me.LblFechalimite.TabIndex = 82
        Me.LblFechalimite.Text = "Fecha"
        '
        'BtnImportar
        '
        Me.BtnImportar.Enabled = False
        Me.BtnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnImportar.Location = New System.Drawing.Point(6, 457)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(165, 45)
        Me.BtnImportar.TabIndex = 73
        Me.BtnImportar.Text = "Importar"
        Me.BtnImportar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCant.ForeColor = System.Drawing.Color.Maroon
        Me.LblCant.Location = New System.Drawing.Point(9, 409)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(14, 13)
        Me.LblCant.TabIndex = 84
        Me.LblCant.Text = "0"
        '
        'Dgvimportar
        '
        Me.Dgvimportar.AllowUserToAddRows = False
        Me.Dgvimportar.AllowUserToDeleteRows = False
        Me.Dgvimportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvimportar.Location = New System.Drawing.Point(6, 157)
        Me.Dgvimportar.Name = "Dgvimportar"
        Me.Dgvimportar.ReadOnly = True
        Me.Dgvimportar.Size = New System.Drawing.Size(762, 275)
        Me.Dgvimportar.TabIndex = 85
        '
        'DgvNoUtilizado
        '
        Me.DgvNoUtilizado.AllowUserToAddRows = False
        Me.DgvNoUtilizado.AllowUserToDeleteRows = False
        Me.DgvNoUtilizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNoUtilizado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SIN_USAR})
        Me.DgvNoUtilizado.Location = New System.Drawing.Point(774, 157)
        Me.DgvNoUtilizado.Name = "DgvNoUtilizado"
        Me.DgvNoUtilizado.ReadOnly = True
        Me.DgvNoUtilizado.RowHeadersVisible = False
        Me.DgvNoUtilizado.Size = New System.Drawing.Size(123, 275)
        Me.DgvNoUtilizado.TabIndex = 86
        '
        'SIN_USAR
        '
        Me.SIN_USAR.HeaderText = "SIN_USAR"
        Me.SIN_USAR.Name = "SIN_USAR"
        Me.SIN_USAR.ReadOnly = True
        '
        'BtnArchivo
        '
        Me.BtnArchivo.Enabled = False
        Me.BtnArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArchivo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnArchivo.Location = New System.Drawing.Point(388, 62)
        Me.BtnArchivo.Name = "BtnArchivo"
        Me.BtnArchivo.Size = New System.Drawing.Size(191, 29)
        Me.BtnArchivo.TabIndex = 87
        Me.BtnArchivo.Text = "Modificar y Reintentar"
        Me.BtnArchivo.UseVisualStyleBackColor = True
        '
        'BtnLista
        '
        Me.BtnLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLista.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLista.Location = New System.Drawing.Point(6, 128)
        Me.BtnLista.Name = "BtnLista"
        Me.BtnLista.Size = New System.Drawing.Size(240, 23)
        Me.BtnLista.TabIndex = 92
        Me.BtnLista.Text = "Abrir un Excel con el Lista de campos"
        Me.BtnLista.UseVisualStyleBackColor = True
        '
        'BtnNormalizar
        '
        Me.BtnNormalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNormalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNormalizar.Image = Global.Correo.My.Resources.Resources.EXCELFILE
        Me.BtnNormalizar.Location = New System.Drawing.Point(821, 88)
        Me.BtnNormalizar.Name = "BtnNormalizar"
        Me.BtnNormalizar.Size = New System.Drawing.Size(49, 62)
        Me.BtnNormalizar.TabIndex = 93
        Me.BtnNormalizar.Text = "Normalizar"
        Me.BtnNormalizar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNormalizar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(856, 457)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(41, 45)
        Me.BtnSalir.TabIndex = 80
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmImpDesdeExcel
        '
        Me.AcceptButton = Me.BtnSeleccionar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(906, 514)
        Me.Controls.Add(Me.BtnNormalizar)
        Me.Controls.Add(Me.BtnLista)
        Me.Controls.Add(Me.BtnArchivo)
        Me.Controls.Add(Me.DgvNoUtilizado)
        Me.Controls.Add(Me.Dgvimportar)
        Me.Controls.Add(Me.LblCant)
        Me.Controls.Add(Me.LblFechalimite)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblRemito)
        Me.Controls.Add(Me.CmbRemito)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.CmbCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmImpDesdeExcel"
        Me.Text = "Importar Desde Excel"
        CType(Me.Dgvimportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvNoUtilizado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnImportar As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents CmbCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents CmbRemito As System.Windows.Forms.ComboBox
    Friend WithEvents LblRemito As System.Windows.Forms.Label
    Public WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechalimite As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblCant As System.Windows.Forms.Label
    Friend WithEvents Dgvimportar As System.Windows.Forms.DataGridView
    Friend WithEvents DgvNoUtilizado As System.Windows.Forms.DataGridView
    Friend WithEvents SIN_USAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnArchivo As System.Windows.Forms.Button
    Friend WithEvents BtnLista As System.Windows.Forms.Button
    Friend WithEvents BtnNormalizar As System.Windows.Forms.Button
End Class
