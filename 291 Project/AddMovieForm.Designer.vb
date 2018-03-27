<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovieForm
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
        Me.AddMovieButton = New System.Windows.Forms.Button()
        Me.CancelMovieButton = New System.Windows.Forms.Button()
        Me.AddTitleBox = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AddFeeBox = New System.Windows.Forms.TextBox()
        Me.DistFeeLabel = New System.Windows.Forms.Label()
        Me.AddCopiesBox = New System.Windows.Forms.TextBox()
        Me.CopiesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddMovieButton
        '
        Me.AddMovieButton.Location = New System.Drawing.Point(37, 354)
        Me.AddMovieButton.Name = "AddMovieButton"
        Me.AddMovieButton.Size = New System.Drawing.Size(75, 23)
        Me.AddMovieButton.TabIndex = 0
        Me.AddMovieButton.Text = "Add"
        Me.AddMovieButton.UseVisualStyleBackColor = True
        '
        'CancelMovieButton
        '
        Me.CancelMovieButton.Location = New System.Drawing.Point(151, 354)
        Me.CancelMovieButton.Name = "CancelMovieButton"
        Me.CancelMovieButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelMovieButton.TabIndex = 1
        Me.CancelMovieButton.Text = "Cancel"
        Me.CancelMovieButton.UseVisualStyleBackColor = True
        '
        'AddTitleBox
        '
        Me.AddTitleBox.Location = New System.Drawing.Point(71, 92)
        Me.AddTitleBox.Name = "AddTitleBox"
        Me.AddTitleBox.Size = New System.Drawing.Size(100, 20)
        Me.AddTitleBox.TabIndex = 2
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(71, 73)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(59, 13)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Movie Title"
        '
        'AddFeeBox
        '
        Me.AddFeeBox.Location = New System.Drawing.Point(71, 144)
        Me.AddFeeBox.Name = "AddFeeBox"
        Me.AddFeeBox.Size = New System.Drawing.Size(100, 20)
        Me.AddFeeBox.TabIndex = 4
        '
        'DistFeeLabel
        '
        Me.DistFeeLabel.AutoSize = True
        Me.DistFeeLabel.Location = New System.Drawing.Point(74, 125)
        Me.DistFeeLabel.Name = "DistFeeLabel"
        Me.DistFeeLabel.Size = New System.Drawing.Size(80, 13)
        Me.DistFeeLabel.TabIndex = 5
        Me.DistFeeLabel.Text = "Distribution Fee"
        '
        'AddCopiesBox
        '
        Me.AddCopiesBox.Location = New System.Drawing.Point(71, 199)
        Me.AddCopiesBox.Name = "AddCopiesBox"
        Me.AddCopiesBox.Size = New System.Drawing.Size(100, 20)
        Me.AddCopiesBox.TabIndex = 6
        '
        'CopiesLabel
        '
        Me.CopiesLabel.AutoSize = True
        Me.CopiesLabel.Location = New System.Drawing.Point(74, 180)
        Me.CopiesLabel.Name = "CopiesLabel"
        Me.CopiesLabel.Size = New System.Drawing.Size(76, 13)
        Me.CopiesLabel.TabIndex = 7
        Me.CopiesLabel.Text = "Owned Copies"
        '
        'AddMovieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 450)
        Me.Controls.Add(Me.CopiesLabel)
        Me.Controls.Add(Me.AddCopiesBox)
        Me.Controls.Add(Me.DistFeeLabel)
        Me.Controls.Add(Me.AddFeeBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.AddTitleBox)
        Me.Controls.Add(Me.CancelMovieButton)
        Me.Controls.Add(Me.AddMovieButton)
        Me.Name = "AddMovieForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddMovieButton As Button
    Friend WithEvents CancelMovieButton As Button
    Friend WithEvents AddTitleBox As TextBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents AddFeeBox As TextBox
    Friend WithEvents DistFeeLabel As Label
    Friend WithEvents AddCopiesBox As TextBox
    Friend WithEvents CopiesLabel As Label
End Class
