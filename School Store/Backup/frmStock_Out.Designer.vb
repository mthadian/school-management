<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock_Out
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock_Out))
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.lblCategory = New System.Windows.Forms.Label
        Me.sprStockOut = New AxFPSpread.AxvaSpread
        Me.cmbSODepartment = New System.Windows.Forms.ComboBox
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.txtDepartmentCode = New System.Windows.Forms.TextBox
        Me.txtCategoryNo = New System.Windows.Forms.TextBox
        Me.lblSearch = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lblReciever = New System.Windows.Forms.Label
        Me.cmbReceiver = New System.Windows.Forms.ComboBox
        Me.lblQuantity = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.txtMeasurement = New System.Windows.Forms.TextBox
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.rbStkoutRemarks = New System.Windows.Forms.RichTextBox
        Me.btnIssue = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtReceiverId = New System.Windows.Forms.TextBox
        CType(Me.sprStockOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(6, 19)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Department"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(419, 19)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.Text = "Category"
        '
        'sprStockOut
        '
        Me.sprStockOut.Location = New System.Drawing.Point(34, 193)
        Me.sprStockOut.Name = "sprStockOut"
        Me.sprStockOut.OcxState = CType(resources.GetObject("sprStockOut.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sprStockOut.Size = New System.Drawing.Size(306, 384)
        Me.sprStockOut.TabIndex = 2
        '
        'cmbSODepartment
        '
        Me.cmbSODepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSODepartment.FormattingEnabled = True
        Me.cmbSODepartment.Location = New System.Drawing.Point(81, 19)
        Me.cmbSODepartment.Name = "cmbSODepartment"
        Me.cmbSODepartment.Size = New System.Drawing.Size(170, 21)
        Me.cmbSODepartment.TabIndex = 3
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(510, 19)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(170, 21)
        Me.cmbCategory.TabIndex = 4
        '
        'txtDepartmentCode
        '
        Me.txtDepartmentCode.Location = New System.Drawing.Point(257, 20)
        Me.txtDepartmentCode.Name = "txtDepartmentCode"
        Me.txtDepartmentCode.Size = New System.Drawing.Size(35, 20)
        Me.txtDepartmentCode.TabIndex = 5
        '
        'txtCategoryNo
        '
        Me.txtCategoryNo.Location = New System.Drawing.Point(686, 20)
        Me.txtCategoryNo.Name = "txtCategoryNo"
        Me.txtCategoryNo.Size = New System.Drawing.Size(33, 20)
        Me.txtCategoryNo.TabIndex = 6
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(16, 106)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 7
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(81, 103)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(178, 20)
        Me.txtSearch.TabIndex = 8
        '
        'lblReciever
        '
        Me.lblReciever.AutoSize = True
        Me.lblReciever.Location = New System.Drawing.Point(419, 110)
        Me.lblReciever.Name = "lblReciever"
        Me.lblReciever.Size = New System.Drawing.Size(50, 13)
        Me.lblReciever.TabIndex = 9
        Me.lblReciever.Text = "Receiver"
        '
        'cmbReceiver
        '
        Me.cmbReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReceiver.FormattingEnabled = True
        Me.cmbReceiver.Location = New System.Drawing.Point(510, 110)
        Me.cmbReceiver.Name = "cmbReceiver"
        Me.cmbReceiver.Size = New System.Drawing.Size(166, 21)
        Me.cmbReceiver.TabIndex = 10
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(9, 75)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 11
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(84, 68)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 12
        '
        'txtMeasurement
        '
        Me.txtMeasurement.AllowDrop = True
        Me.txtMeasurement.Location = New System.Drawing.Point(224, 68)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(108, 20)
        Me.txtMeasurement.TabIndex = 13
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(6, 147)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.lblRemarks.TabIndex = 14
        Me.lblRemarks.Text = "Remarks"
        '
        'rbStkoutRemarks
        '
        Me.rbStkoutRemarks.Location = New System.Drawing.Point(84, 144)
        Me.rbStkoutRemarks.Name = "rbStkoutRemarks"
        Me.rbStkoutRemarks.Size = New System.Drawing.Size(264, 96)
        Me.rbStkoutRemarks.TabIndex = 15
        Me.rbStkoutRemarks.Text = ""
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnIssue.Location = New System.Drawing.Point(453, 560)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(203, 40)
        Me.btnIssue.TabIndex = 16
        Me.btnIssue.Text = "ISSUE"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbStkoutRemarks)
        Me.GroupBox1.Controls.Add(Me.lblRemarks)
        Me.GroupBox1.Controls.Add(Me.txtMeasurement)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.lblQuantity)
        Me.GroupBox1.Location = New System.Drawing.Point(393, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 291)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtReceiverId)
        Me.GroupBox2.Controls.Add(Me.cmbReceiver)
        Me.GroupBox2.Controls.Add(Me.lblReciever)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.lblSearch)
        Me.GroupBox2.Controls.Add(Me.txtCategoryNo)
        Me.GroupBox2.Controls.Add(Me.txtDepartmentCode)
        Me.GroupBox2.Controls.Add(Me.cmbCategory)
        Me.GroupBox2.Controls.Add(Me.cmbSODepartment)
        Me.GroupBox2.Controls.Add(Me.lblCategory)
        Me.GroupBox2.Controls.Add(Me.lblDepartment)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 147)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'txtReceiverId
        '
        Me.txtReceiverId.Location = New System.Drawing.Point(682, 111)
        Me.txtReceiverId.Name = "txtReceiverId"
        Me.txtReceiverId.Size = New System.Drawing.Size(37, 20)
        Me.txtReceiverId.TabIndex = 11
        '
        'frmStock_Out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(790, 612)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.sprStockOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStock_Out"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock_Out"
        CType(Me.sprStockOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents sprStockOut As AxFPSpread.AxvaSpread
    Friend WithEvents cmbSODepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtDepartmentCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoryNo As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblReciever As System.Windows.Forms.Label
    Friend WithEvents cmbReceiver As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents rbStkoutRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReceiverId As System.Windows.Forms.TextBox
End Class
