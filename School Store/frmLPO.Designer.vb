<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLPO
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLPOQuantity = New System.Windows.Forms.TextBox
        Me.txtLPOMeasurement = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbxItemLPO = New System.Windows.Forms.ComboBox
        Me.rtLPODescription = New System.Windows.Forms.RichTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnSubmitLPO = New System.Windows.Forms.Button
        Me.txtLPONumber = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Measurement"
        '
        'txtLPOQuantity
        '
        Me.txtLPOQuantity.Location = New System.Drawing.Point(294, 63)
        Me.txtLPOQuantity.Name = "txtLPOQuantity"
        Me.txtLPOQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtLPOQuantity.TabIndex = 4
        '
        'txtLPOMeasurement
        '
        Me.txtLPOMeasurement.Location = New System.Drawing.Point(560, 67)
        Me.txtLPOMeasurement.Name = "txtLPOMeasurement"
        Me.txtLPOMeasurement.Size = New System.Drawing.Size(100, 20)
        Me.txtLPOMeasurement.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxItemLPO)
        Me.GroupBox1.Controls.Add(Me.rtLPODescription)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnSubmitLPO)
        Me.GroupBox1.Controls.Add(Me.txtLPONumber)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLPOMeasurement)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLPOQuantity)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 382)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cbxItemLPO
        '
        Me.cbxItemLPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItemLPO.FormattingEnabled = True
        Me.cbxItemLPO.Location = New System.Drawing.Point(43, 67)
        Me.cbxItemLPO.Name = "cbxItemLPO"
        Me.cbxItemLPO.Size = New System.Drawing.Size(135, 21)
        Me.cbxItemLPO.TabIndex = 12
        '
        'rtLPODescription
        '
        Me.rtLPODescription.Location = New System.Drawing.Point(400, 153)
        Me.rtLPODescription.Name = "rtLPODescription"
        Me.rtLPODescription.Size = New System.Drawing.Size(260, 96)
        Me.rtLPODescription.TabIndex = 11
        Me.rtLPODescription.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Description"
        '
        'btnSubmitLPO
        '
        Me.btnSubmitLPO.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmitLPO.Location = New System.Drawing.Point(294, 329)
        Me.btnSubmitLPO.Name = "btnSubmitLPO"
        Me.btnSubmitLPO.Size = New System.Drawing.Size(100, 31)
        Me.btnSubmitLPO.TabIndex = 9
        Me.btnSubmitLPO.Text = "SUBMIT"
        Me.btnSubmitLPO.UseVisualStyleBackColor = False
        '
        'txtLPONumber
        '
        Me.txtLPONumber.Location = New System.Drawing.Point(123, 156)
        Me.txtLPONumber.Name = "txtLPONumber"
        Me.txtLPONumber.Size = New System.Drawing.Size(100, 20)
        Me.txtLPONumber.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "LPO Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 6
        '
        'frmLPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(734, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLPO"
        Me.Text = "frmLPO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLPOQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtLPOMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLPONumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSubmitLPO As System.Windows.Forms.Button
    Friend WithEvents rtLPODescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxItemLPO As System.Windows.Forms.ComboBox
End Class
