<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiver))
        Me.pnlReceiver = New System.Windows.Forms.Panel
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtRecName = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblRecID = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblRecName = New System.Windows.Forms.Label
        Me.sprReceiver = New AxFPSpread.AxvaSpread
        Me.pnlReceiver.SuspendLayout()
        CType(Me.sprReceiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReceiver
        '
        Me.pnlReceiver.Controls.Add(Me.txtPhone)
        Me.pnlReceiver.Controls.Add(Me.txtRecName)
        Me.pnlReceiver.Controls.Add(Me.txtID)
        Me.pnlReceiver.Controls.Add(Me.lblRecID)
        Me.pnlReceiver.Controls.Add(Me.lblPhone)
        Me.pnlReceiver.Controls.Add(Me.lblRecName)
        Me.pnlReceiver.Location = New System.Drawing.Point(400, 12)
        Me.pnlReceiver.Name = "pnlReceiver"
        Me.pnlReceiver.Size = New System.Drawing.Size(337, 538)
        Me.pnlReceiver.TabIndex = 0
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(146, 273)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(149, 20)
        Me.txtPhone.TabIndex = 6
        '
        'txtRecName
        '
        Me.txtRecName.Location = New System.Drawing.Point(146, 179)
        Me.txtRecName.Name = "txtRecName"
        Me.txtRecName.Size = New System.Drawing.Size(149, 20)
        Me.txtRecName.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(146, 78)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(149, 20)
        Me.txtID.TabIndex = 4
        '
        'lblRecID
        '
        Me.lblRecID.AutoSize = True
        Me.lblRecID.Location = New System.Drawing.Point(51, 81)
        Me.lblRecID.Name = "lblRecID"
        Me.lblRecID.Size = New System.Drawing.Size(21, 13)
        Me.lblRecID.TabIndex = 3
        Me.lblRecID.Text = "I.D"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(48, 280)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(58, 13)
        Me.lblPhone.TabIndex = 1
        Me.lblPhone.Text = "Phone No."
        '
        'lblRecName
        '
        Me.lblRecName.AutoSize = True
        Me.lblRecName.Location = New System.Drawing.Point(51, 182)
        Me.lblRecName.Name = "lblRecName"
        Me.lblRecName.Size = New System.Drawing.Size(35, 13)
        Me.lblRecName.TabIndex = 0
        Me.lblRecName.Text = "Name"
        '
        'sprReceiver
        '
        Me.sprReceiver.Location = New System.Drawing.Point(39, 12)
        Me.sprReceiver.Name = "sprReceiver"
        Me.sprReceiver.OcxState = CType(resources.GetObject("sprReceiver.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sprReceiver.Size = New System.Drawing.Size(342, 538)
        Me.sprReceiver.TabIndex = 1
        '
        'frmReceiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 562)
        Me.Controls.Add(Me.sprReceiver)
        Me.Controls.Add(Me.pnlReceiver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceiver"
        Me.Text = "frmReceiver"
        Me.pnlReceiver.ResumeLayout(False)
        Me.pnlReceiver.PerformLayout()
        CType(Me.sprReceiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlReceiver As System.Windows.Forms.Panel
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblRecName As System.Windows.Forms.Label
    Friend WithEvents lblRecID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtRecName As System.Windows.Forms.TextBox
    Friend WithEvents sprReceiver As AxFPSpread.AxvaSpread
End Class
