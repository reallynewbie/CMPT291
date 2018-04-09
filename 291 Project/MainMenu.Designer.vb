<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnCusRep = New System.Windows.Forms.Button()
        Me.BtnAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnUser
        '
        Me.BtnUser.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUser.Location = New System.Drawing.Point(31, 12)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(200, 150)
        Me.BtnUser.TabIndex = 0
        Me.BtnUser.Text = "User"
        Me.BtnUser.UseVisualStyleBackColor = True
        '
        'BtnCusRep
        '
        Me.BtnCusRep.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCusRep.Location = New System.Drawing.Point(235, 12)
        Me.BtnCusRep.Name = "BtnCusRep"
        Me.BtnCusRep.Size = New System.Drawing.Size(200, 150)
        Me.BtnCusRep.TabIndex = 1
        Me.BtnCusRep.Text = "Customer Representative"
        Me.BtnCusRep.UseVisualStyleBackColor = True
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.Location = New System.Drawing.Point(31, 176)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(404, 115)
        Me.BtnAdmin.TabIndex = 2
        Me.BtnAdmin.Text = "Admin"
        Me.BtnAdmin.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 303)
        Me.Controls.Add(Me.BtnAdmin)
        Me.Controls.Add(Me.BtnCusRep)
        Me.Controls.Add(Me.BtnUser)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnUser As Button
    Friend WithEvents BtnCusRep As Button
    Friend WithEvents BtnAdmin As Button
End Class
