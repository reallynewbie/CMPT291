<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddActorForm
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
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.CancelAct = New System.Windows.Forms.Button()
        Me.AddAct = New System.Windows.Forms.Button()
        Me.ComboGender = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextLastName
        '
        Me.TextLastName.Location = New System.Drawing.Point(185, 32)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.Size = New System.Drawing.Size(188, 22)
        Me.TextLastName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "First Name"
        '
        'TextFirstName
        '
        Me.TextFirstName.Location = New System.Drawing.Point(22, 33)
        Me.TextFirstName.Name = "TextFirstName"
        Me.TextFirstName.Size = New System.Drawing.Size(140, 22)
        Me.TextFirstName.TabIndex = 6
        '
        'CancelAct
        '
        Me.CancelAct.Location = New System.Drawing.Point(192, 397)
        Me.CancelAct.Name = "CancelAct"
        Me.CancelAct.Size = New System.Drawing.Size(92, 30)
        Me.CancelAct.TabIndex = 11
        Me.CancelAct.Text = "Cancel"
        Me.CancelAct.UseVisualStyleBackColor = True
        '
        'AddAct
        '
        Me.AddAct.Location = New System.Drawing.Point(72, 397)
        Me.AddAct.Name = "AddAct"
        Me.AddAct.Size = New System.Drawing.Size(90, 30)
        Me.AddAct.TabIndex = 10
        Me.AddAct.Text = "Add"
        Me.AddAct.UseVisualStyleBackColor = True
        '
        'ComboGender
        '
        Me.ComboGender.FormattingEnabled = True
        Me.ComboGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboGender.Location = New System.Drawing.Point(22, 148)
        Me.ComboGender.Name = "ComboGender"
        Me.ComboGender.Size = New System.Drawing.Size(188, 24)
        Me.ComboGender.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Gender"
        '
        'DateBirth
        '
        Me.DateBirth.Location = New System.Drawing.Point(22, 89)
        Me.DateBirth.Name = "DateBirth"
        Me.DateBirth.Size = New System.Drawing.Size(188, 22)
        Me.DateBirth.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Date of Birth"
        '
        'AddActorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.ComboGender)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateBirth)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CancelAct)
        Me.Controls.Add(Me.AddAct)
        Me.Controls.Add(Me.TextLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextFirstName)
        Me.Name = "AddActorForm"
        Me.Text = "AddActorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents CancelAct As Button
    Friend WithEvents AddAct As Button
    Friend WithEvents ComboGender As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateBirth As DateTimePicker
    Friend WithEvents Label8 As Label
End Class
