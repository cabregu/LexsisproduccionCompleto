﻿Public Class FrmImportarPpal
    Private Sub CargarRemitoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarRemitoToolStripMenuItem1.Click
        FrmCargarRemito.MdiParent = Me
        FrmCargarRemito.Show()
    End Sub

    Private Sub ImportarDesdeXlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarDesdeXlsToolStripMenuItem.Click
        FrmImpDesdeExcel.MdiParent = Me
        FrmImpDesdeExcel.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub EliminarRemitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRemitoToolStripMenuItem.Click
        FrmEliminarRemito.MdiParent = Me
        FrmEliminarRemito.Show()
    End Sub

    Private Sub FrmImportarPpal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmPpal.Visible = True
    End Sub

    Private Sub EtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetasToolStripMenuItem.Click
        FrmimprimirEtiqueta.MdiParent = Me
        FrmimprimirEtiqueta.Show()
    End Sub


    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        FrmCargaManual.MdiParent = Me
        FrmCargaManual.Show()
    End Sub

 
    
    Private Sub AplocativoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplocativoToolStripMenuItem.Click
        FrmCrearRemitente.MdiParent = Me
        FrmCrearRemitente.Show()
    End Sub

 
    Private Sub BusquedaExcelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusquedaExcelsToolStripMenuItem.Click
        FrmImprimirDesdeExcel.MdiParent = Me
        FrmImprimirDesdeExcel.Show()
    End Sub

  
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

        FrmImprimirAvisos.MdiParent = Me
        FrmImprimirAvisos.Show()

    End Sub
End Class