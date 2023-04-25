<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransito
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
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.BNBUSCAR = New System.Windows.Forms.Button()
        Me.BtnEstados = New System.Windows.Forms.Button()
        Me.Btnexcel2 = New System.Windows.Forms.Button()
        Me.GrpTransito = New System.Windows.Forms.GroupBox()
        Me.Btntxt = New System.Windows.Forms.Button()
        Me.BtnObtenerFecha1 = New System.Windows.Forms.Button()
        Me.BtnFechasReales = New System.Windows.Forms.Button()
        Me.PgbAnalisis = New System.Windows.Forms.ProgressBar()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnAnalisisEstados = New System.Windows.Forms.Button()
        Me.BtnBase = New System.Windows.Forms.Button()
        Me.BtnAnalizar = New System.Windows.Forms.Button()
        Me.Btncargacompleta = New System.Windows.Forms.Button()
        Me.CmColumnas = New System.Windows.Forms.ComboBox()
        Me.Btn7Digitos = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtItem1 = New System.Windows.Forms.TextBox()
        Me.TxtItem2 = New System.Windows.Forms.TextBox()
        Me.Btnjuntar = New System.Windows.Forms.Button()
        Me.Btncsv = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTransito.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Location = New System.Drawing.Point(5, 534)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1348, 534)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.BtnBase)
        Me.Gb.Controls.Add(Me.CmColumnas)
        Me.Gb.Controls.Add(Me.BtnAdd)
        Me.Gb.Controls.Add(Me.Btn7Digitos)
        Me.Gb.Controls.Add(Me.TxtItem1)
        Me.Gb.Controls.Add(Me.Btncargacompleta)
        Me.Gb.Controls.Add(Me.TxtItem2)
        Me.Gb.Controls.Add(Me.BtnAnalizar)
        Me.Gb.Controls.Add(Me.Btnjuntar)
        Me.Gb.Controls.Add(Me.GrpTransito)
        Me.Gb.Controls.Add(Me.BtnEstados)
        Me.Gb.Location = New System.Drawing.Point(0, 0)
        Me.Gb.Size = New System.Drawing.Size(1026, 556)
        Me.Gb.Text = "x"
        Me.Gb.Controls.SetChildIndex(Me.BtnEstados, 0)
        Me.Gb.Controls.SetChildIndex(Me.GrpTransito, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btnjuntar, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnAnalizar, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtItem2, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btncargacompleta, 0)
        Me.Gb.Controls.SetChildIndex(Me.TxtItem1, 0)
        Me.Gb.Controls.SetChildIndex(Me.Btn7Digitos, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnAdd, 0)
        Me.Gb.Controls.SetChildIndex(Me.CmColumnas, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnBase, 0)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Location = New System.Drawing.Point(6, 58)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(535, 358)
        Me.DgvDatos.TabIndex = 31
        '
        'BtnExcel
        '
        Me.BtnExcel.Location = New System.Drawing.Point(262, 26)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(17, 23)
        Me.BtnExcel.TabIndex = 33
        Me.BtnExcel.Text = "..."
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(6, 28)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(250, 20)
        Me.txtPath.TabIndex = 34
        '
        'BNBUSCAR
        '
        Me.BNBUSCAR.Location = New System.Drawing.Point(547, 27)
        Me.BNBUSCAR.Name = "BNBUSCAR"
        Me.BNBUSCAR.Size = New System.Drawing.Size(102, 23)
        Me.BNBUSCAR.TabIndex = 39
        Me.BNBUSCAR.Text = "BUSCAR"
        Me.BNBUSCAR.UseVisualStyleBackColor = True
        '
        'BtnEstados
        '
        Me.BtnEstados.Location = New System.Drawing.Point(16, 487)
        Me.BtnEstados.Name = "BtnEstados"
        Me.BtnEstados.Size = New System.Drawing.Size(102, 23)
        Me.BtnEstados.TabIndex = 40
        Me.BtnEstados.Text = "FECHAS"
        Me.BtnEstados.UseVisualStyleBackColor = True
        Me.BtnEstados.Visible = False
        '
        'Btnexcel2
        '
        Me.Btnexcel2.Location = New System.Drawing.Point(6, 422)
        Me.Btnexcel2.Name = "Btnexcel2"
        Me.Btnexcel2.Size = New System.Drawing.Size(36, 23)
        Me.Btnexcel2.TabIndex = 41
        Me.Btnexcel2.Text = "XLS"
        Me.Btnexcel2.UseVisualStyleBackColor = True
        '
        'GrpTransito
        '
        Me.GrpTransito.Controls.Add(Me.Btncsv)
        Me.GrpTransito.Controls.Add(Me.Btntxt)
        Me.GrpTransito.Controls.Add(Me.BtnObtenerFecha1)
        Me.GrpTransito.Controls.Add(Me.BtnFechasReales)
        Me.GrpTransito.Controls.Add(Me.PgbAnalisis)
        Me.GrpTransito.Controls.Add(Me.BtnConfirmar)
        Me.GrpTransito.Controls.Add(Me.BtnAnalisisEstados)
        Me.GrpTransito.Controls.Add(Me.txtPath)
        Me.GrpTransito.Controls.Add(Me.DgvDatos)
        Me.GrpTransito.Controls.Add(Me.BtnExcel)
        Me.GrpTransito.Controls.Add(Me.Btnexcel2)
        Me.GrpTransito.Controls.Add(Me.BNBUSCAR)
        Me.GrpTransito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTransito.Location = New System.Drawing.Point(10, 19)
        Me.GrpTransito.Name = "GrpTransito"
        Me.GrpTransito.Size = New System.Drawing.Size(655, 451)
        Me.GrpTransito.TabIndex = 46
        Me.GrpTransito.TabStop = False
        Me.GrpTransito.Text = "Transito"
        '
        'Btntxt
        '
        Me.Btntxt.Location = New System.Drawing.Point(562, 269)
        Me.Btntxt.Name = "Btntxt"
        Me.Btntxt.Size = New System.Drawing.Size(75, 23)
        Me.Btntxt.TabIndex = 60
        Me.Btntxt.Text = "txt"
        Me.Btntxt.UseVisualStyleBackColor = True
        '
        'BtnObtenerFecha1
        '
        Me.BtnObtenerFecha1.Location = New System.Drawing.Point(562, 198)
        Me.BtnObtenerFecha1.Name = "BtnObtenerFecha1"
        Me.BtnObtenerFecha1.Size = New System.Drawing.Size(75, 23)
        Me.BtnObtenerFecha1.TabIndex = 55
        Me.BtnObtenerFecha1.Text = "Fecha1"
        Me.BtnObtenerFecha1.UseVisualStyleBackColor = True
        '
        'BtnFechasReales
        '
        Me.BtnFechasReales.Location = New System.Drawing.Point(547, 377)
        Me.BtnFechasReales.Name = "BtnFechasReales"
        Me.BtnFechasReales.Size = New System.Drawing.Size(102, 23)
        Me.BtnFechasReales.TabIndex = 54
        Me.BtnFechasReales.Text = "FECHAS"
        Me.BtnFechasReales.UseVisualStyleBackColor = True
        '
        'PgbAnalisis
        '
        Me.PgbAnalisis.Location = New System.Drawing.Point(48, 435)
        Me.PgbAnalisis.Name = "PgbAnalisis"
        Me.PgbAnalisis.Size = New System.Drawing.Size(456, 10)
        Me.PgbAnalisis.TabIndex = 51
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Location = New System.Drawing.Point(547, 406)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(102, 39)
        Me.BtnConfirmar.TabIndex = 50
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'BtnAnalisisEstados
        '
        Me.BtnAnalisisEstados.Location = New System.Drawing.Point(547, 56)
        Me.BtnAnalisisEstados.Name = "BtnAnalisisEstados"
        Me.BtnAnalisisEstados.Size = New System.Drawing.Size(102, 25)
        Me.BtnAnalisisEstados.TabIndex = 49
        Me.BtnAnalisisEstados.Text = "ESTADOS"
        Me.BtnAnalisisEstados.UseVisualStyleBackColor = True
        '
        'BtnBase
        '
        Me.BtnBase.Location = New System.Drawing.Point(272, 487)
        Me.BtnBase.Name = "BtnBase"
        Me.BtnBase.Size = New System.Drawing.Size(75, 23)
        Me.BtnBase.TabIndex = 53
        Me.BtnBase.Text = "Base"
        Me.BtnBase.UseVisualStyleBackColor = True
        Me.BtnBase.Visible = False
        '
        'BtnAnalizar
        '
        Me.BtnAnalizar.Enabled = False
        Me.BtnAnalizar.Location = New System.Drawing.Point(369, 486)
        Me.BtnAnalizar.Name = "BtnAnalizar"
        Me.BtnAnalizar.Size = New System.Drawing.Size(102, 25)
        Me.BtnAnalizar.TabIndex = 52
        Me.BtnAnalizar.Text = "ANALIZAR"
        Me.BtnAnalizar.UseVisualStyleBackColor = True
        Me.BtnAnalizar.Visible = False
        '
        'Btncargacompleta
        '
        Me.Btncargacompleta.Location = New System.Drawing.Point(152, 479)
        Me.Btncargacompleta.Name = "Btncargacompleta"
        Me.Btncargacompleta.Size = New System.Drawing.Size(102, 39)
        Me.Btncargacompleta.TabIndex = 51
        Me.Btncargacompleta.Text = "Notocar"
        Me.Btncargacompleta.UseVisualStyleBackColor = True
        Me.Btncargacompleta.Visible = False
        '
        'CmColumnas
        '
        Me.CmColumnas.FormattingEnabled = True
        Me.CmColumnas.Location = New System.Drawing.Point(754, 48)
        Me.CmColumnas.Name = "CmColumnas"
        Me.CmColumnas.Size = New System.Drawing.Size(159, 21)
        Me.CmColumnas.TabIndex = 54
        '
        'Btn7Digitos
        '
        Me.Btn7Digitos.Location = New System.Drawing.Point(919, 46)
        Me.Btn7Digitos.Name = "Btn7Digitos"
        Me.Btn7Digitos.Size = New System.Drawing.Size(75, 23)
        Me.Btn7Digitos.TabIndex = 55
        Me.Btn7Digitos.Text = "7 Digitos"
        Me.Btn7Digitos.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(753, 75)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 56
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtItem1
        '
        Me.TxtItem1.Location = New System.Drawing.Point(758, 114)
        Me.TxtItem1.Name = "TxtItem1"
        Me.TxtItem1.Size = New System.Drawing.Size(100, 20)
        Me.TxtItem1.TabIndex = 57
        '
        'TxtItem2
        '
        Me.TxtItem2.Location = New System.Drawing.Point(864, 114)
        Me.TxtItem2.Name = "TxtItem2"
        Me.TxtItem2.Size = New System.Drawing.Size(100, 20)
        Me.TxtItem2.TabIndex = 58
        '
        'Btnjuntar
        '
        Me.Btnjuntar.Location = New System.Drawing.Point(758, 151)
        Me.Btnjuntar.Name = "Btnjuntar"
        Me.Btnjuntar.Size = New System.Drawing.Size(125, 23)
        Me.Btnjuntar.TabIndex = 59
        Me.Btnjuntar.Text = "Crear Columnas"
        Me.Btnjuntar.UseVisualStyleBackColor = True
        '
        'Btncsv
        '
        Me.Btncsv.Location = New System.Drawing.Point(562, 333)
        Me.Btncsv.Name = "Btncsv"
        Me.Btncsv.Size = New System.Drawing.Size(75, 23)
        Me.Btncsv.TabIndex = 61
        Me.Btncsv.Text = "csv"
        Me.Btncsv.UseVisualStyleBackColor = True
        '
        'FrmTransito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1020, 528)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmTransito"
        Me.Text = "Transito"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTransito.ResumeLayout(False)
        Me.GrpTransito.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents BNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BtnEstados As System.Windows.Forms.Button
    Friend WithEvents Btnexcel2 As System.Windows.Forms.Button
    Friend WithEvents GrpTransito As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAnalisisEstados As System.Windows.Forms.Button
    Friend WithEvents BtnConfirmar As System.Windows.Forms.Button
    Friend WithEvents PgbAnalisis As System.Windows.Forms.ProgressBar
    Friend WithEvents Btncargacompleta As System.Windows.Forms.Button
    Friend WithEvents BtnAnalizar As System.Windows.Forms.Button
    Friend WithEvents BtnFechasReales As System.Windows.Forms.Button
    Friend WithEvents BtnBase As System.Windows.Forms.Button
    Friend WithEvents CmColumnas As System.Windows.Forms.ComboBox
    Friend WithEvents Btn7Digitos As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtItem1 As System.Windows.Forms.TextBox
    Friend WithEvents Btnjuntar As System.Windows.Forms.Button
    Friend WithEvents TxtItem2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnObtenerFecha1 As System.Windows.Forms.Button
    Friend WithEvents Btntxt As System.Windows.Forms.Button
    Friend WithEvents Btncsv As System.Windows.Forms.Button

End Class
