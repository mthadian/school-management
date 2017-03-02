<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeptCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeptCategory))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabPageDepartment = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rtDescription = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.sprDept = New AxFPSpread.AxvaSpread
        Me.tabPageCategory = New System.Windows.Forms.TabPage
        Me.txtDeptCode = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rtCatDesc = New System.Windows.Forms.RichTextBox
        Me.txtCatName = New System.Windows.Forms.TextBox
        Me.lblCatDesc = New System.Windows.Forms.Label
        Me.lblCatName = New System.Windows.Forms.Label
        Me.sprCategory = New AxFPSpread.AxvaSpread
        Me.cmbDepartment = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPageDepartment.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sprDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageCategory.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.sprCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(10, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 487)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPageDepartment)
        Me.TabControl1.Controls.Add(Me.tabPageCategory)
        Me.TabControl1.Location = New System.Drawing.Point(3, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(775, 479)
        Me.TabControl1.TabIndex = 0
        '
        'tabPageDepartment
        '
        Me.tabPageDepartment.Controls.Add(Me.GroupBox1)
        Me.tabPageDepartment.Controls.Add(Me.sprDept)
        Me.tabPageDepartment.Location = New System.Drawing.Point(4, 22)
        Me.tabPageDepartment.Name = "tabPageDepartment"
        Me.tabPageDepartment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageDepartment.Size = New System.Drawing.Size(767, 453)
        Me.tabPageDepartment.TabIndex = 0
        Me.tabPageDepartment.Text = "Department"
        Me.tabPageDepartment.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtDescription)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDepartment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(343, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 413)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rtDescription
        '
        Me.rtDescription.Location = New System.Drawing.Point(109, 70)
        Me.rtDescription.Name = "rtDescription"
        Me.rtDescription.Size = New System.Drawing.Size(234, 161)
        Me.rtDescription.TabIndex = 3
        Me.rtDescription.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(109, 14)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(234, 20)
        Me.txtDepartment.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department Name"
        '
        'sprDept
        '
        Me.sprDept.Location = New System.Drawing.Point(7, 11)
        Me.sprDept.Name = "sprDept"
        Me.sprDept.OcxState = CType(resources.GetObject("sprDept.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sprDept.Size = New System.Drawing.Size(330, 407)
        Me.sprDept.TabIndex = 0
        '
        'tabPageCategory
        '
        Me.tabPageCategory.Controls.Add(Me.txtDeptCode)
        Me.tabPageCategory.Controls.Add(Me.GroupBox2)
        Me.tabPageCategory.Controls.Add(Me.sprCategory)
        Me.tabPageCategory.Controls.Add(Me.cmbDepartment)
        Me.tabPageCategory.Controls.Add(Me.Label3)
        Me.tabPageCategory.Location = New System.Drawing.Point(4, 22)
        Me.tabPageCategory.Name = "tabPageCategory"
        Me.tabPageCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCategory.Size = New System.Drawing.Size(767, 453)
        Me.tabPageCategory.TabIndex = 1
        Me.tabPageCategory.Text = "Category"
        Me.tabPageCategory.UseVisualStyleBackColor = True
        '
        'txtDeptCode
        '
        Me.txtDeptCode.Location = New System.Drawing.Point(302, 11)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(24, 20)
        Me.txtDeptCode.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtCatDesc)
        Me.GroupBox2.Controls.Add(Me.txtCatName)
        Me.GroupBox2.Controls.Add(Me.lblCatDesc)
        Me.GroupBox2.Controls.Add(Me.lblCatName)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 378)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'rtCatDesc
        '
        Me.rtCatDesc.Location = New System.Drawing.Point(127, 94)
        Me.rtCatDesc.Name = "rtCatDesc"
        Me.rtCatDesc.Size = New System.Drawing.Size(234, 161)
        Me.rtCatDesc.TabIndex = 4
        Me.rtCatDesc.Text = ""
        '
        'txtCatName
        '
        Me.txtCatName.Location = New System.Drawing.Point(127, 26)
        Me.txtCatName.Name = "txtCatName"
        Me.txtCatName.Size = New System.Drawing.Size(234, 20)
        Me.txtCatName.TabIndex = 2
        '
        'lblCatDesc
        '
        Me.lblCatDesc.AutoSize = True
        Me.lblCatDesc.Location = New System.Drawing.Point(24, 94)
        Me.lblCatDesc.Name = "lblCatDesc"
        Me.lblCatDesc.Size = New System.Drawing.Size(63, 13)
        Me.lblCatDesc.TabIndex = 1
        Me.lblCatDesc.Text = " Description"
        '
        'lblCatName
        '
        Me.lblCatName.AutoSize = True
        Me.lblCatName.Location = New System.Drawing.Point(24, 26)
        Me.lblCatName.Name = "lblCatName"
        Me.lblCatName.Size = New System.Drawing.Size(80, 13)
        Me.lblCatName.TabIndex = 0
        Me.lblCatName.Text = "Category Name"
        '
        'sprCategory
        '
        Me.sprCategory.Location = New System.Drawing.Point(9, 59)
        Me.sprCategory.Name = "sprCategory"
        Me.sprCategory.OcxState = CType(resources.GetObject("sprCategory.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sprCategory.Size = New System.Drawing.Size(314, 370)
        Me.sprCategory.TabIndex = 3
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(82, 11)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(214, 21)
        Me.cmbDepartment.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Department"
        '
        'frmDeptCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 511)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDeptCategory"
        Me.Text = "frmDeptCategory"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabPageDepartment.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sprDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageCategory.ResumeLayout(False)
        Me.tabPageCategory.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.sprCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPageDepartment As System.Windows.Forms.TabPage
    Friend WithEvents tabPageCategory As System.Windows.Forms.TabPage
    Friend WithEvents sprDept As AxFPSpread.AxvaSpread
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rtDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sprCategory As AxFPSpread.AxvaSpread
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDeptCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCatName As System.Windows.Forms.TextBox
    Friend WithEvents lblCatDesc As System.Windows.Forms.Label
    Friend WithEvents lblCatName As System.Windows.Forms.Label
    Friend WithEvents rtCatDesc As System.Windows.Forms.RichTextBox
End Class
