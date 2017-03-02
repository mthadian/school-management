Public Class frmRPTLPO
    Private tp As New TabPage("Local Purchase Order")
    Private pForm As frmMaster

    Private Sub frmRPTLPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)

        Dim cryRpt As New rptLPO
        Dim obj As New frmRPTConnection
        obj.newRPTConnection(cryRpt)
        'cryRpt.RecordSelectionFormula = "{m_Student_Entity.v_house} = '" & cmbhouse.Text & "'"

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub frmRPTLPO_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
        'frmMaster.NewToolStripMenuItem.Enabled = False
        'frmMaster.EditToolStripMenuItem.Enabled = False
        'frmMaster.CancelToolStripMenuItem.Enabled = False
        'frmMaster.SaveToolStripMenuItem.Enabled = False
    End Sub

    Private Sub frmRPTLPO_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'frmMaster.NewToolStripMenuItem.Enabled = False
        'frmMaster.EditToolStripMenuItem.Enabled = False
        'frmMaster.CancelToolStripMenuItem.Enabled = False
        'frmMaster.SaveToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class