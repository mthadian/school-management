<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Department and Category")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Items")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Supplier")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Receiver")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("School Details")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settings", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Available Items")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create LPO")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock In")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Out")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Return Note")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock In and Stock Out", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Help")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaster))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolStripMenuItemNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1273, 30)
        Me.Panel2.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1142, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 30)
        Me.Panel1.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Help"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = Global.School_Store.My.Resources.Resources.close16
        Me.btnClose.Location = New System.Drawing.Point(95, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 8
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(39, 0)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(57, 31)
        Me.btnLogOut.TabIndex = 9
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(248, 7)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(904, 24)
        Me.TabControl1.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemNew, Me.toolStripMenuItemEdit, Me.toolStripMenuItemSave, Me.toolStripMenuItemCancel})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 7)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(252, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolStripMenuItemNew
        '
        Me.toolStripMenuItemNew.Enabled = False
        Me.toolStripMenuItemNew.Image = Global.School_Store.My.Resources.Resources.add
        Me.toolStripMenuItemNew.Name = "toolStripMenuItemNew"
        Me.toolStripMenuItemNew.Size = New System.Drawing.Size(59, 20)
        Me.toolStripMenuItemNew.Text = "New"
        '
        'toolStripMenuItemEdit
        '
        Me.toolStripMenuItemEdit.Enabled = False
        Me.toolStripMenuItemEdit.Image = Global.School_Store.My.Resources.Resources.application24
        Me.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit"
        Me.toolStripMenuItemEdit.Size = New System.Drawing.Size(55, 20)
        Me.toolStripMenuItemEdit.Text = "Edit"
        '
        'toolStripMenuItemSave
        '
        Me.toolStripMenuItemSave.Enabled = False
        Me.toolStripMenuItemSave.Image = Global.School_Store.My.Resources.Resources.sav
        Me.toolStripMenuItemSave.Name = "toolStripMenuItemSave"
        Me.toolStripMenuItemSave.Size = New System.Drawing.Size(59, 20)
        Me.toolStripMenuItemSave.Text = "Save"
        '
        'toolStripMenuItemCancel
        '
        Me.toolStripMenuItemCancel.Enabled = False
        Me.toolStripMenuItemCancel.Image = Global.School_Store.My.Resources.Resources._001_29
        Me.toolStripMenuItemCancel.Name = "toolStripMenuItemCancel"
        Me.toolStripMenuItemCancel.Size = New System.Drawing.Size(71, 20)
        Me.toolStripMenuItemCancel.Text = "Cancel"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TreeView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 719)
        Me.Panel3.TabIndex = 12
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "ndDeptCat"
        TreeNode1.Text = "Department and Category"
        TreeNode2.Name = "ndAddItems"
        TreeNode2.Text = "Add Items"
        TreeNode3.Name = "ndSupplier"
        TreeNode3.Text = "Add Supplier"
        TreeNode4.Name = "ndReceiver"
        TreeNode4.Text = "Add Receiver"
        TreeNode5.Name = "ndSchoolDetails"
        TreeNode5.Text = "School Details"
        TreeNode6.Name = "ndSettings"
        TreeNode6.Text = "Settings"
        TreeNode7.Name = "ndAvailableItems"
        TreeNode7.Text = "Available Items"
        TreeNode8.Name = "ndLPO"
        TreeNode8.Text = "Create LPO"
        TreeNode9.Name = "ndStockIn"
        TreeNode9.Text = "Stock In"
        TreeNode10.Name = "ndStockOut"
        TreeNode10.Text = "Stock Out"
        TreeNode11.Name = "ndReturnNote"
        TreeNode11.Text = "Return Note"
        TreeNode12.Name = "ndStockInOut"
        TreeNode12.Text = "Stock In and Stock Out"
        TreeNode13.Name = "ndReports"
        TreeNode13.Text = "Reports"
        TreeNode14.Name = "ndHelp"
        TreeNode14.Text = "Help"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode12, TreeNode13, TreeNode14})
        Me.TreeView1.Size = New System.Drawing.Size(245, 719)
        Me.TreeView1.TabIndex = 6
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1273, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.IsMdiContainer = True
        Me.Name = "frmMaster"
        Me.Text = "Store Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents toolStripMenuItemNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItemEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItemSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItemCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button

End Class
