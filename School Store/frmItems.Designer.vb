<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCatNo = New System.Windows.Forms.TextBox()
        Me.txtDeptCode = New System.Windows.Forms.TextBox()
        Me.sprItemm = New AxFPSpread.AxvaSpread()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtItemDesc = New System.Windows.Forms.RichTextBox()
        Me.txtItemmsr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sprItem = New AxFPSpread.AxvaSpread()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbItdept = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbItCat = New System.Windows.Forms.ComboBox()
        Me.AxvaSpread1 = New AxFPSpread.AxvaSpread()
        Me.Panel1.SuspendLayout()
        CType(Me.sprItemm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sprItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxvaSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCatNo)
        Me.Panel1.Controls.Add(Me.txtDeptCode)
        Me.Panel1.Controls.Add(Me.sprItemm)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 609)
        Me.Panel1.TabIndex = 0
        '
        'txtCatNo
        '
        Me.txtCatNo.Location = New System.Drawing.Point(702, 27)
        Me.txtCatNo.Name = "txtCatNo"
        Me.txtCatNo.Size = New System.Drawing.Size(29, 20)
        Me.txtCatNo.TabIndex = 4
        '
        'txtDeptCode
        '
        Me.txtDeptCode.Location = New System.Drawing.Point(327, 29)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(29, 20)
        Me.txtDeptCode.TabIndex = 3
        '
        'sprItemm
        '
        Me.sprItemm.Location = New System.Drawing.Point(26, 114)
        Me.sprItemm.Name = "sprItemm"
        Me.sprItemm.OcxState = CType(resources.GetObject("sprItemm.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sprItemm.Size = New System.Drawing.Size(348, 385)
        Me.sprItemm.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rtItemDesc)
        Me.GroupBox1.Controls.Add(Me.txtItemmsr)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(394, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 390)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Item Description"
        '
        'rtItemDesc
        '
        Me.rtItemDesc.Location = New System.Drawing.Point(160, 222)
        Me.rtItemDesc.Name = "rtItemDesc"
        Me.rtItemDesc.Size = New System.Drawing.Size(168, 96)
        Me.rtItemDesc.TabIndex = 9
        Me.rtItemDesc.Text = ""
        '
        'txtItemmsr
        '
        Me.txtItemmsr.Location = New System.Drawing.Point(160, 109)
        Me.txtItemmsr.Name = "txtItemmsr"
        Me.txtItemmsr.Size = New System.Drawing.Size(168, 20)
        Me.txtItemmsr.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Item Measurement"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(160, 26)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(168, 20)
        Me.txtItemName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Item Name"
        '
        'sprItem
        '
        Me.sprItem.Location = New System.Drawing.Point(23, 109)
        Me.sprItem.Name = "sprItem"
        Me.sprItem.OcxState = CType(resources.GetObject("sprItem.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sprItem.Size = New System.Drawing.Size(351, 350)
        Me.sprItem.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Department"
        '
        'cmbItdept
        '
        Me.cmbItdept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItdept.FormattingEnabled = True
        Me.cmbItdept.Location = New System.Drawing.Point(103, 24)
        Me.cmbItdept.Name = "cmbItdept"
        Me.cmbItdept.Size = New System.Drawing.Size(205, 21)
        Me.cmbItdept.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Category"
        '
        'cmbItCat
        '
        Me.cmbItCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItCat.FormattingEnabled = True
        Me.cmbItCat.Location = New System.Drawing.Point(471, 24)
        Me.cmbItCat.Name = "cmbItCat"
        Me.cmbItCat.Size = New System.Drawing.Size(205, 21)
        Me.cmbItCat.TabIndex = 4
        '
        'AxvaSpread1
        '
        Me.AxvaSpread1.Location = New System.Drawing.Point(48, 117)
        Me.AxvaSpread1.Name = "AxvaSpread1"
        Me.AxvaSpread1.OcxState = CType(resources.GetObject("AxvaSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxvaSpread1.Size = New System.Drawing.Size(304, 382)
        Me.AxvaSpread1.TabIndex = 2
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 609)
        Me.Controls.Add(Me.cmbItCat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbItdept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItems"
        Me.Opacity = 0.5R
        Me.Text = "Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sprItemm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sprItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxvaSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbItdept As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbItCat As System.Windows.Forms.ComboBox
    Friend WithEvents sprItem As AxFPSpread.AxvaSpread
    Friend WithEvents AxvaSpread1 As AxFPSpread.AxvaSpread
    Friend WithEvents sprItemm As AxFPSpread.AxvaSpread
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemmsr As System.Windows.Forms.TextBox
    Friend WithEvents txtDeptCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCatNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rtItemDesc As System.Windows.Forms.RichTextBox
End Class
