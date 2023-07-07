<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModoS
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
        Me.DgvOriginal = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        CType(Me.DgvOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(926, 429)
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.Button1)
        Me.Gb.Controls.Add(Me.Button2)
        Me.Gb.Controls.Add(Me.DgvOriginal)
        Me.Gb.Size = New System.Drawing.Size(973, 480)
        Me.Gb.Controls.SetChildIndex(Me.PBLogo, 0)
        Me.Gb.Controls.SetChildIndex(Me.BtnSalir, 0)
        Me.Gb.Controls.SetChildIndex(Me.DgvOriginal, 0)
        Me.Gb.Controls.SetChildIndex(Me.Button2, 0)
        Me.Gb.Controls.SetChildIndex(Me.Button1, 0)
        '
        'DgvOriginal
        '
        Me.DgvOriginal.AllowUserToAddRows = False
        Me.DgvOriginal.AllowUserToDeleteRows = False
        Me.DgvOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOriginal.Location = New System.Drawing.Point(110, 52)
        Me.DgvOriginal.Name = "DgvOriginal"
        Me.DgvOriginal.ReadOnly = True
        Me.DgvOriginal.Size = New System.Drawing.Size(800, 300)
        Me.DgvOriginal.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(835, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmModoS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(973, 479)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmModoS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        CType(Me.DgvOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvOriginal As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
