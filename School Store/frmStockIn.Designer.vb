<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockIn
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
        Me.cbxDep = New System.Windows.Forms.ComboBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.lblCategory = New System.Windows.Forms.Label
        Me.lblSupplier = New System.Windows.Forms.Label
        Me.lblItem = New System.Windows.Forms.Label
        Me.lblQuantity = New System.Windows.Forms.Label
        Me.lblUnit = New System.Windows.Forms.Label
        Me.pnlQUnit = New System.Windows.Forms.Panel
        Me.cbxUnit = New System.Windows.Forms.ComboBox
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.cbxCategory = New System.Windows.Forms.ComboBox
        Me.cbxSupplier = New System.Windows.Forms.ComboBox
        Me.cbxItem = New System.Windows.Forms.ComboBox
        Me.lblDeliverer = New System.Windows.Forms.Label
        Me.lblReceiver = New System.Windows.Forms.Label
        Me.pnlDepCatIt = New System.Windows.Forms.Panel
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.txtdepCode = New System.Windows.Forms.TextBox
        Me.txtDeliverer = New System.Windows.Forms.TextBox
        Me.txtReceiver = New System.Windows.Forms.TextBox
        Me.btnReceive = New System.Windows.Forms.Button
        Me.lblDate = New System.Windows.Forms.Label
        Me.DateStockIn = New System.Windows.Forms.DateTimePicker
        Me.lblRemark = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.txtReceiverID = New System.Windows.Forms.TextBox
        Me.txtSupplierRef = New System.Windows.Forms.TextBox
        Me.lblRef = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.pnlQUnit.SuspendLayout()
        Me.pnlDepCatIt.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxDep
        '
        Me.cbxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDep.FormattingEnabled = True
        Me.cbxDep.Location = New System.Drawing.Point(71, 21)
        Me.cbxDep.Name = "cbxDep"
        Me.cbxDep.Size = New System.Drawing.Size(121, 21)
        Me.cbxDep.TabIndex = 0
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Location = New System.Drawing.Point(3, 24)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 1
        Me.lblDepartment.Text = "Department"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Location = New System.Drawing.Point(277, 24)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "Category"
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(-3, 219)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(45, 13)
        Me.lblSupplier.TabIndex = 3
        Me.lblSupplier.Text = "Supplier"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.BackColor = System.Drawing.Color.Transparent
        Me.lblItem.Location = New System.Drawing.Point(566, 21)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(27, 13)
        Me.lblItem.TabIndex = 4
        Me.lblItem.Text = "Item"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(3, 13)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quantity"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(259, 17)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(31, 13)
        Me.lblUnit.TabIndex = 6
        Me.lblUnit.Text = "Units"
        '
        'pnlQUnit
        '
        Me.pnlQUnit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlQUnit.Controls.Add(Me.cbxUnit)
        Me.pnlQUnit.Controls.Add(Me.txtQuantity)
        Me.pnlQUnit.Controls.Add(Me.lblQuantity)
        Me.pnlQUnit.Controls.Add(Me.lblUnit)
        Me.pnlQUnit.Location = New System.Drawing.Point(110, 108)
        Me.pnlQUnit.Name = "pnlQUnit"
        Me.pnlQUnit.Size = New System.Drawing.Size(478, 39)
        Me.pnlQUnit.TabIndex = 7
        '
        'cbxUnit
        '
        Me.cbxUnit.FormattingEnabled = True
        Me.cbxUnit.Location = New System.Drawing.Point(320, 9)
        Me.cbxUnit.Name = "cbxUnit"
        Me.cbxUnit.Size = New System.Drawing.Size(59, 21)
        Me.cbxUnit.TabIndex = 8
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(55, 10)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(53, 20)
        Me.txtQuantity.TabIndex = 7
        '
        'cbxCategory
        '
        Me.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(332, 18)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(121, 21)
        Me.cbxCategory.TabIndex = 8
        '
        'cbxSupplier
        '
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(48, 216)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(121, 21)
        Me.cbxSupplier.TabIndex = 9
        '
        'cbxItem
        '
        Me.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItem.FormattingEnabled = True
        Me.cbxItem.Location = New System.Drawing.Point(599, 18)
        Me.cbxItem.Name = "cbxItem"
        Me.cbxItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxItem.TabIndex = 10
        '
        'lblDeliverer
        '
        Me.lblDeliverer.AutoSize = True
        Me.lblDeliverer.Location = New System.Drawing.Point(217, 224)
        Me.lblDeliverer.Name = "lblDeliverer"
        Me.lblDeliverer.Size = New System.Drawing.Size(80, 13)
        Me.lblDeliverer.TabIndex = 11
        Me.lblDeliverer.Text = "Deliverer Name"
        '
        'lblReceiver
        '
        Me.lblReceiver.AutoSize = True
        Me.lblReceiver.Location = New System.Drawing.Point(564, 232)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(50, 13)
        Me.lblReceiver.TabIndex = 12
        Me.lblReceiver.Text = "Receiver"
        '
        'pnlDepCatIt
        '
        Me.pnlDepCatIt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlDepCatIt.Controls.Add(Me.txtItem)
        Me.pnlDepCatIt.Controls.Add(Me.txtdepCode)
        Me.pnlDepCatIt.Controls.Add(Me.lblDepartment)
        Me.pnlDepCatIt.Controls.Add(Me.cbxDep)
        Me.pnlDepCatIt.Controls.Add(Me.lblCategory)
        Me.pnlDepCatIt.Controls.Add(Me.cbxCategory)
        Me.pnlDepCatIt.Controls.Add(Me.lblItem)
        Me.pnlDepCatIt.Controls.Add(Me.cbxItem)
        Me.pnlDepCatIt.Location = New System.Drawing.Point(19, 12)
        Me.pnlDepCatIt.Name = "pnlDepCatIt"
        Me.pnlDepCatIt.Size = New System.Drawing.Size(795, 58)
        Me.pnlDepCatIt.TabIndex = 13
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(741, 21)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(41, 20)
        Me.txtItem.TabIndex = 12
        '
        'txtdepCode
        '
        Me.txtdepCode.Location = New System.Drawing.Point(199, 21)
        Me.txtdepCode.Name = "txtdepCode"
        Me.txtdepCode.Size = New System.Drawing.Size(32, 20)
        Me.txtdepCode.TabIndex = 11
        '
        'txtDeliverer
        '
        Me.txtDeliverer.Location = New System.Drawing.Point(305, 222)
        Me.txtDeliverer.Name = "txtDeliverer"
        Me.txtDeliverer.Size = New System.Drawing.Size(143, 20)
        Me.txtDeliverer.TabIndex = 14
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(620, 225)
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(134, 20)
        Me.txtReceiver.TabIndex = 15
        '
        'btnReceive
        '
        Me.btnReceive.Location = New System.Drawing.Point(299, 439)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(156, 44)
        Me.btnReceive.TabIndex = 16
        Me.btnReceive.Text = "Receive"
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Location = New System.Drawing.Point(224, 284)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Date"
        '
        'DateStockIn
        '
        Me.DateStockIn.Location = New System.Drawing.Point(272, 278)
        Me.DateStockIn.Name = "DateStockIn"
        Me.DateStockIn.Size = New System.Drawing.Size(200, 20)
        Me.DateStockIn.TabIndex = 18
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark.Location = New System.Drawing.Point(201, 366)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(49, 13)
        Me.lblRemark.TabIndex = 19
        Me.lblRemark.Text = "Remarks"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(272, 336)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(200, 83)
        Me.txtRemark.TabIndex = 20
        '
        'txtReceiverID
        '
        Me.txtReceiverID.Location = New System.Drawing.Point(760, 225)
        Me.txtReceiverID.Name = "txtReceiverID"
        Me.txtReceiverID.Size = New System.Drawing.Size(38, 20)
        Me.txtReceiverID.TabIndex = 21
        '
        'txtSupplierRef
        '
        Me.txtSupplierRef.Location = New System.Drawing.Point(173, 217)
        Me.txtSupplierRef.Name = "txtSupplierRef"
        Me.txtSupplierRef.Size = New System.Drawing.Size(45, 20)
        Me.txtSupplierRef.TabIndex = 22
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(173, 201)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(41, 13)
        Me.lblRef.TabIndex = 23
        Me.lblRef.Text = "Ref.No"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(826, 507)
        Me.Controls.Add(Me.lblRef)
        Me.Controls.Add(Me.txtSupplierRef)
        Me.Controls.Add(Me.txtReceiverID)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.DateStockIn)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnReceive)
        Me.Controls.Add(Me.txtReceiver)
        Me.Controls.Add(Me.txtDeliverer)
        Me.Controls.Add(Me.lblReceiver)
        Me.Controls.Add(Me.lblDeliverer)
        Me.Controls.Add(Me.cbxSupplier)
        Me.Controls.Add(Me.pnlQUnit)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.pnlDepCatIt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStockIn"
        Me.Text = "frmStockIn"
        Me.pnlQUnit.ResumeLayout(False)
        Me.pnlQUnit.PerformLayout()
        Me.pnlDepCatIt.ResumeLayout(False)
        Me.pnlDepCatIt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxDep As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents pnlQUnit As System.Windows.Forms.Panel
    Friend WithEvents cbxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents cbxUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cbxItem As System.Windows.Forms.ComboBox
    Friend WithEvents lblDeliverer As System.Windows.Forms.Label
    Friend WithEvents lblReceiver As System.Windows.Forms.Label
    Friend WithEvents pnlDepCatIt As System.Windows.Forms.Panel
    Friend WithEvents txtDeliverer As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiver As System.Windows.Forms.TextBox
    Friend WithEvents btnReceive As System.Windows.Forms.Button
    Friend WithEvents txtdepCode As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents DateStockIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiverID As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierRef As System.Windows.Forms.TextBox
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
