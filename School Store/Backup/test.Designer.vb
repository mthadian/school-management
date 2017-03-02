<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Image = Global.School_Store.My.Resources.Resources.help1
        Me.Button2.Location = New System.Drawing.Point(242, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Help"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(379, 221)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(57, 31)
        Me.btnLogOut.TabIndex = 11
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 472)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLogOut)
        Me.Name = "test"
        Me.Text = "test"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
End Class
