<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustForm
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
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.LastNameBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.AddCustButton = New System.Windows.Forms.Button()
        Me.CancelCustButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ZipBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AccountBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CreditBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Location = New System.Drawing.Point(61, 75)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(185, 20)
        Me.FirstNameBox.TabIndex = 0
        '
        'LastNameBox
        '
        Me.LastNameBox.Location = New System.Drawing.Point(60, 126)
        Me.LastNameBox.Name = "LastNameBox"
        Me.LastNameBox.Size = New System.Drawing.Size(185, 20)
        Me.LastNameBox.TabIndex = 1
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(60, 176)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(185, 20)
        Me.AddressBox.TabIndex = 2
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(60, 227)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(185, 20)
        Me.CityBox.TabIndex = 3
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(60, 279)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(86, 20)
        Me.StateBox.TabIndex = 4
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(60, 331)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(185, 20)
        Me.EmailBox.TabIndex = 5
        '
        'AddCustButton
        '
        Me.AddCustButton.Location = New System.Drawing.Point(61, 481)
        Me.AddCustButton.Name = "AddCustButton"
        Me.AddCustButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCustButton.TabIndex = 6
        Me.AddCustButton.Text = "Add"
        Me.AddCustButton.UseVisualStyleBackColor = True
        '
        'CancelCustButton
        '
        Me.CancelCustButton.Location = New System.Drawing.Point(171, 481)
        Me.CancelCustButton.Name = "CancelCustButton"
        Me.CancelCustButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelCustButton.TabIndex = 7
        Me.CancelCustButton.Text = "Cancel"
        Me.CancelCustButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "State"
        '
        'ZipBox
        '
        Me.ZipBox.Location = New System.Drawing.Point(160, 279)
        Me.ZipBox.Name = "ZipBox"
        Me.ZipBox.Size = New System.Drawing.Size(86, 20)
        Me.ZipBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Zipcode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Email"
        '
        'AccountBox
        '
        Me.AccountBox.Location = New System.Drawing.Point(61, 440)
        Me.AccountBox.Name = "AccountBox"
        Me.AccountBox.Size = New System.Drawing.Size(185, 20)
        Me.AccountBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Account Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Add/Edit Customer"
        '
        'CreditBox
        '
        Me.CreditBox.Location = New System.Drawing.Point(60, 386)
        Me.CreditBox.Name = "CreditBox"
        Me.CreditBox.Size = New System.Drawing.Size(185, 20)
        Me.CreditBox.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Credit Card"
        '
        'AddCustForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 529)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CreditBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AccountBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ZipBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelCustButton)
        Me.Controls.Add(Me.AddCustButton)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.LastNameBox)
        Me.Controls.Add(Me.FirstNameBox)
        Me.Name = "AddCustForm"
        Me.Text = "Customer Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents LastNameBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents AddCustButton As Button
    Friend WithEvents CancelCustButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ZipBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AccountBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CreditBox As TextBox
    Friend WithEvents Label10 As Label
End Class
