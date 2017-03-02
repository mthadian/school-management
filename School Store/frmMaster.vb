
Public Class frmMaster

    Public MdiChildForms() As Form = Me.MdiChildren
    Public k As Integer = MdiChildForms.Length
    Public x As Integer

    Friend Sub AddTabPage(ByVal tp As TabPage)
        With TabControl1
            .TabPages.Add(tp)
            .SelectedTab = tp
        End With
    End Sub

    Friend Sub RemoveTabPage(ByVal tp As TabPage)
        TabControl1.TabPages.Remove(tp)
    End Sub

    Public Sub ToggleControls(ByVal val As Boolean)
        toolStripMenuItemNew.Enabled = val
        toolStripMenuItemEdit.Enabled = val
        toolStripMenuItemSave.Enabled = Not val
        toolStripMenuItemCancel.Enabled = Not val
    End Sub

    'Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint



    'End Sub


    'Private Sub TreeView2_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    'End Sub

    'Private Sub TreeView1_AfterSelect_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
    '    Panel1.Show()
    'End Sub

    'Private Sub ItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockInToolStripMenuItem.Click

    '    Me.pnlParaSettings.Controls.Add(treeStockIn)
    '    TreeView1.Hide()
    '    Panel1.Hide()
    '    treeStockIn.Show()



    'End Sub

    'Private Sub treeItems_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeStockIn.AfterSelect
    '    If treeStockIn.SelectedNode.Name = "ndItems" Then
    '        frmItem.MdiParent = Me
    '        Me.Panel1.Controls.Add(frmItem)
    '        frmItem.Show()
    '    End If

    'End Sub

    'Private Sub treeItems_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles treeStockIn.MouseHover

    'End Sub

    'Private Sub pnlParaSettings_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    'End Sub

    'Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            ActiveMdiChild.Close()
        Catch ex As Exception
            MsgBox("There is no form")
        End Try
    End Sub

    Private Sub toolStripMenuItemNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripMenuItemNew.Click
        Try
            Dim activeMdi = Me.MdiChildren
            If activeMdi.Length = 0 Then
                MsgBox("Please load a form", MsgBoxStyle.Information, "School System")
            Else
                If ActiveMdiChild.Name = "frmLockAccess" Then
                    toolStripMenuItemNew.Enabled = False
                    'NewToolStripMenuItem.Visible = False
                    MsgBox("Click on Edit to make changes", MsgBoxStyle.Information, "Access Lock")
                Else
                    DirectCast(DirectCast(Me, Form).ActiveMdiChild, StoreInterface).FormNew()
                    'ToggleControls(False)
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Name = "ndDeptCat" Then
            frmDeptCategory.MdiParent = Me
            frmDeptCategory.Dock = DockStyle.Fill
            frmDeptCategory.Show()
        ElseIf TreeView1.SelectedNode.Name = "ndAddItems" Then
            frmItems.MdiParent = Me
            frmItems.Dock = DockStyle.Fill
            frmItems.Show()
        ElseIf TreeView1.SelectedNode.Name = "ndSupplier" Then
            frmSupplier.MdiParent = Me
            frmSupplier.Dock = DockStyle.Fill
            frmSupplier.Show()
        ElseIf TreeView1.SelectedNode.Name = "ndReceiver" Then
            frmReceiver.MdiParent = Me
            frmReceiver.Dock = DockStyle.Fill
            frmReceiver.Show()
        ElseIf TreeView1.SelectedNode.Name = "ndStockIn" Then
            frmStockIn.MdiParent = Me
            frmStockIn.Dock = DockStyle.Fill
            frmStockIn.Show()
        ElseIf TreeView1.SelectedNode.Name = "ndSchoolDetails" Then
            frmSchoolDetails.MdiParent = Me
            frmSchoolDetails.Dock = DockStyle.Fill
            frmSchoolDetails.Show()
        ElseIf TreeView1.SelectedNode.Name = "ndStockOut" Then
            frmStock_Out.MdiParent = Me
            frmStock_Out.Dock = DockStyle.Fill
            frmStock_Out.Show()
        ElseIf TreeView1.SelectedNode.Name = "ndLPO" Then
            frmLPO.MdiParent = Me
            frmLPO.Dock = DockStyle.Fill
            frmLPO.Show()



        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim i As Integer

        If TabControl1.TabPages.Count > 0 Then
            For i = 0 To Me.MdiChildren.Length - 1

                If i = TabControl1.SelectedIndex Then
                    Me.MdiChildren(i).WindowState = FormWindowState.Normal

                Else
                    Me.MdiChildren(i).WindowState = FormWindowState.Minimized

                End If
            Next
        End If
    End Sub

    Private Sub toolStripMenuItemEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripMenuItemEdit.Click
        Try
            Dim activeMdi = Me.MdiChildren
            If activeMdi.Length = 0 Then
                MsgBox("Please load a form", MsgBoxStyle.Information, "School System")
            Else
                DirectCast(DirectCast(Me, Form).ActiveMdiChild, StoreInterface).FormEdit()
                'ToggleControls(False)
            End If

        Catch ex As Exception
            'MessageBox.Show("Re-open the Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub toolStripMenuItemSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripMenuItemSave.Click
        Try
            Dim activeMdi = Me.MdiChildren
            If activeMdi.Length = 0 Then
                MsgBox("Please load a form", MsgBoxStyle.Information, "School System")

            Else
                DirectCast(DirectCast(Me, Form).ActiveMdiChild, StoreInterface).FormSave()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub toolStripMenuItemCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripMenuItemCancel.Click
        Try
            DirectCast(DirectCast(Me, Form).ActiveMdiChild, StoreInterface).FormCancel()
            ToggleControls(True)
        Catch
        End Try
    End Sub

    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'frmLogin.Close()
        conn.Open(cnStr)
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()
        frmLogin.Show()

    End Sub
End Class
