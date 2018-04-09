<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployeeForm
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
        Me.AddEmploy = New System.Windows.Forms.Button()
        Me.CancelEmploy = New System.Windows.Forms.Button()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextSSN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextStreet = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextCity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextState = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextZip = New System.Windows.Forms.TextBox()
        Me.DateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextWage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboPosition = New System.Windows.Forms.ComboBox()
        Me.SubmissionErrorMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddEmploy
        '
        Me.AddEmploy.Location = New System.Drawing.Point(61, 569)
        Me.AddEmploy.Name = "AddEmploy"
        Me.AddEmploy.Size = New System.Drawing.Size(90, 30)
        Me.AddEmploy.TabIndex = 0
        Me.AddEmploy.Text = "Add"
        Me.AddEmploy.UseVisualStyleBackColor = True
        '
        'CancelEmploy
        '
        Me.CancelEmploy.Location = New System.Drawing.Point(181, 569)
        Me.CancelEmploy.Name = "CancelEmploy"
        Me.CancelEmploy.Size = New System.Drawing.Size(92, 30)
        Me.CancelEmploy.TabIndex = 1
        Me.CancelEmploy.Text = "Cancel"
        Me.CancelEmploy.UseVisualStyleBackColor = True
        '
        'TextFirstName
        '
        Me.TextFirstName.Location = New System.Drawing.Point(61, 72)
        Me.TextFirstName.Name = "TextFirstName"
        Me.TextFirstName.Size = New System.Drawing.Size(140, 22)
        Me.TextFirstName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'TextLastName
        '
        Me.TextLastName.Location = New System.Drawing.Point(224, 71)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.Size = New System.Drawing.Size(188, 22)
        Me.TextLastName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SSN"
        '
        'TextSSN
        '
        Me.TextSSN.Location = New System.Drawing.Point(61, 143)
        Me.TextSSN.Name = "TextSSN"
        Me.TextSSN.Size = New System.Drawing.Size(140, 22)
        Me.TextSSN.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Street Address"
        '
        'TextStreet
        '
        Me.TextStreet.Location = New System.Drawing.Point(61, 213)
        Me.TextStreet.Name = "TextStreet"
        Me.TextStreet.Size = New System.Drawing.Size(351, 22)
        Me.TextStreet.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "City"
        '
        'TextCity
        '
        Me.TextCity.Location = New System.Drawing.Point(61, 276)
        Me.TextCity.Name = "TextCity"
        Me.TextCity.Size = New System.Drawing.Size(140, 22)
        Me.TextCity.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "State"
        '
        'TextState
        '
        Me.TextState.Location = New System.Drawing.Point(224, 276)
        Me.TextState.Name = "TextState"
        Me.TextState.Size = New System.Drawing.Size(188, 22)
        Me.TextState.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Zip Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Start Date"
        '
        'TextZip
        '
        Me.TextZip.Location = New System.Drawing.Point(61, 343)
        Me.TextZip.Name = "TextZip"
        Me.TextZip.Size = New System.Drawing.Size(140, 22)
        Me.TextZip.TabIndex = 16
        '
        'DateStart
        '
        Me.DateStart.Location = New System.Drawing.Point(224, 342)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Size = New System.Drawing.Size(188, 22)
        Me.DateStart.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Hourly Wage"
        '
        'TextWage
        '
        Me.TextWage.Location = New System.Drawing.Point(61, 415)
        Me.TextWage.Name = "TextWage"
        Me.TextWage.Size = New System.Drawing.Size(140, 22)
        Me.TextWage.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(224, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Position"
        '
        'ComboPosition
        '
        Me.ComboPosition.FormattingEnabled = True
        Me.ComboPosition.Items.AddRange(New Object() {"Customer Representative", "Manager"})
        Me.ComboPosition.Location = New System.Drawing.Point(224, 415)
        Me.ComboPosition.Name = "ComboPosition"
        Me.ComboPosition.Size = New System.Drawing.Size(188, 24)
        Me.ComboPosition.TabIndex = 21
        '
        'SubmissionErrorMessage
        '
        Me.SubmissionErrorMessage.AutoSize = True
        Me.SubmissionErrorMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmissionErrorMessage.Location = New System.Drawing.Point(61, 479)
        Me.SubmissionErrorMessage.Name = "SubmissionErrorMessage"
        Me.SubmissionErrorMessage.Size = New System.Drawing.Size(171, 17)
        Me.SubmissionErrorMessage.TabIndex = 23
        Me.SubmissionErrorMessage.Text = "Wage is Not a Number"
        Me.SubmissionErrorMessage.Visible = False
        '
        'AddEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 635)
        Me.Controls.Add(Me.SubmissionErrorMessage)
        Me.Controls.Add(Me.ComboPosition)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextWage)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateStart)
        Me.Controls.Add(Me.TextZip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextStreet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextSSN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextFirstName)
        Me.Controls.Add(Me.CancelEmploy)
        Me.Controls.Add(Me.AddEmploy)
        Me.Name = "AddEmployeeForm"
        Me.Text = "Add Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddEmploy As Button
    Friend WithEvents CancelEmploy As Button
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextSSN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextStreet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextCity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextState As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextZip As TextBox
    Friend WithEvents DateStart As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TextWage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboPosition As ComboBox
    Friend WithEvents SubmissionErrorMessage As Label
End Class
