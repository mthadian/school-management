<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.sprSupplier = New AxFPSpread.AxvaSpread
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSupplierName = New System.Windows.Forms.TextBox
        Me.txtPhoneNo1 = New System.Windows.Forms.TextBox
        Me.txtPhoneNo2 = New System.Windows.Forms.TextBox
        Me.txtContactPerson = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        CType(Me.sprSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sprSupplier
        '
        Me.sprSupplier.Location = New System.Drawing.Point(19, 25)
        Me.sprSupplier.Name = "sprSupplier"
        Me.sprSupplier.OcxState = CType(resources.GetObject("sprSupplier.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sprSupplier.Size = New System.Drawing.Size(326, 433)
        Me.sprSupplier.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Supplier Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phone Number 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone Number 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Contact Person"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(497, 67)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(189, 20)
        Me.txtSupplierName.TabIndex = 8
        '
        'txtPhoneNo1
        '
        Me.txtPhoneNo1.Location = New System.Drawing.Point(497, 131)
        Me.txtPhoneNo1.Name = "txtPhoneNo1"
        Me.txtPhoneNo1.Size = New System.Drawing.Size(189, 20)
        Me.txtPhoneNo1.TabIndex = 9
        '
        'txtPhoneNo2
        '
        Me.txtPhoneNo2.Location = New System.Drawing.Point(497, 208)
        Me.txtPhoneNo2.Name = "txtPhoneNo2"
        Me.txtPhoneNo2.Size = New System.Drawing.Size(189, 20)
        Me.txtPhoneNo2.TabIndex = 10
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(497, 283)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(189, 20)
        Me.txtContactPerson.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Email "
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(504, 426)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(189, 20)
        Me.txtEmail.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(504, 357)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(182, 20)
        Me.txtMobile.TabIndex = 15
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 509)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.txtPhoneNo2)
        Me.Controls.Add(Me.txtPhoneNo1)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sprSupplier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSupplier"
        Me.Text = "Supplier"
        CType(Me.sprSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sprSupplier As AxFPSpread.AxvaSpread
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
End Class
