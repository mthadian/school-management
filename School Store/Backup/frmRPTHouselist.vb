Public Class frmRPTHouselist
    Private tp As New TabPage("Student House List")
    Private pForm As frmMaster

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbhouse.SelectedIndexChanged
        'Dim cryRpt As New rptHouseList

        Dim obj As New frmRPTConnection
        'obj.newRPTConnection(cryRpt)
        'cryRpt.RecordSelectionFormula = "{m_Student_Entity.v_house} = '" & cmbhouse.Text & "'"

        'CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub frmRPTHouselist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
    End Sub

    Private Sub frmRPTHouselist_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
        'frmMaster.NewToolStripMenuItem.Enabled = False
        'frmMaster.EditToolStripMenuItem.Enabled = False
        'frmMaster.CancelToolStripMenuItem.Enabled = False
        'frmMaster.SaveToolStripMenuItem.Enabled = False
    End Sub

    Private Sub frmRPTHouselist_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'frmMaster.NewToolStripMenuItem.Enabled = False
        'frmMaster.EditToolStripMenuItem.Enabled = False
        'frmMaster.CancelToolStripMenuItem.Enabled = False
        'frmMaster.SaveToolStripMenuItem.Enabled = False
    End Sub
End Class