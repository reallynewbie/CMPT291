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
        Me.SubmissionErrorMessage = New System.Windows.Forms.Label()
        Me.ButActors = New System.Windows.Forms.Button()
        Me.ButGenres = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddMovieButton
        '
        Me.AddMovieButton.Location = New System.Drawing.Point(49, 436)
        Me.AddMovieButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddMovieButton.Name = "AddMovieButton"
        Me.AddMovieButton.Size = New System.Drawing.Size(100, 28)
        Me.AddMovieButton.TabIndex = 0
        Me.AddMovieButton.Text = "Add"
        Me.AddMovieButton.UseVisualStyleBackColor = True
        '
        'CancelMovieButton
        '
        Me.CancelMovieButton.Location = New System.Drawing.Point(201, 436)
        Me.CancelMovieButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelMovieButton.Name = "CancelMovieButton"
        Me.CancelMovieButton.Size = New System.Drawing.Size(100, 28)
        Me.CancelMovieButton.TabIndex = 1
        Me.CancelMovieButton.Text = "Cancel"
        Me.CancelMovieButton.UseVisualStyleBackColor = True
        '
        'AddTitleBox
        '
        Me.AddTitleBox.Location = New System.Drawing.Point(95, 113)
        Me.AddTitleBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddTitleBox.Name = "AddTitleBox"
        Me.AddTitleBox.Size = New System.Drawing.Size(132, 22)
        Me.AddTitleBox.TabIndex = 2
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(95, 90)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(76, 17)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Movie Title"
        '
        'AddFeeBox
        '
        Me.AddFeeBox.Location = New System.Drawing.Point(95, 177)
        Me.AddFeeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddFeeBox.Name = "AddFeeBox"
        Me.AddFeeBox.Size = New System.Drawing.Size(132, 22)
        Me.AddFeeBox.TabIndex = 4
        '
        'DistFeeLabel
        '
        Me.DistFeeLabel.AutoSize = True
        Me.DistFeeLabel.Location = New System.Drawing.Point(99, 154)
        Me.DistFeeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DistFeeLabel.Name = "DistFeeLabel"
        Me.DistFeeLabel.Size = New System.Drawing.Size(107, 17)
        Me.DistFeeLabel.TabIndex = 5
        Me.DistFeeLabel.Text = "Distribution Fee"
        '
        'AddCopiesBox
        '
        Me.AddCopiesBox.Location = New System.Drawing.Point(95, 245)
        Me.AddCopiesBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddCopiesBox.Name = "AddCopiesBox"
        Me.AddCopiesBox.Size = New System.Drawing.Size(132, 22)
        Me.AddCopiesBox.TabIndex = 6
        '
        'CopiesLabel
        '
        Me.CopiesLabel.AutoSize = True
        Me.CopiesLabel.Location = New System.Drawing.Point(99, 222)
        Me.CopiesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CopiesLabel.Name = "CopiesLabel"
        Me.CopiesLabel.Size = New System.Drawing.Size(99, 17)
        Me.CopiesLabel.TabIndex = 7
        Me.CopiesLabel.Text = "Owned Copies"
        '
        'SubmissionErrorMessage
        '
        Me.SubmissionErrorMessage.AutoSize = True
        Me.SubmissionErrorMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmissionErrorMessage.Location = New System.Drawing.Point(46, 385)
        Me.SubmissionErrorMessage.Name = "SubmissionErrorMessage"
        Me.SubmissionErrorMessage.Size = New System.Drawing.Size(212, 17)
        Me.SubmissionErrorMessage.TabIndex = 8
        Me.SubmissionErrorMessage.Text = "Copies or Fee not a Number"
        Me.SubmissionErrorMessage.Visible = False
        '
        'ButActors
        '
        Me.ButActors.Location = New System.Drawing.Point(74, 298)
        Me.ButActors.Name = "ButActors"
        Me.ButActors.Size = New System.Drawing.Size(75, 23)
        Me.ButActors.TabIndex = 9
        Me.ButActors.Text = "Actors"
        Me.ButActors.UseVisualStyleBackColor = True
        '
        'ButGenres
        '
        Me.ButGenres.Location = New System.Drawing.Point(183, 298)
        Me.ButGenres.Name = "ButGenres"
        Me.ButGenres.Size = New System.Drawing.Size(75, 23)
        Me.ButGenres.TabIndex = 10
        Me.ButGenres.Text = "Genres"
        Me.ButGenres.UseVisualStyleBackColor = True
        '
        'AddMovieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 554)
        Me.Controls.Add(Me.ButGenres)
        Me.Controls.Add(Me.ButActors)
        Me.Controls.Add(Me.SubmissionErrorMessage)
        Me.Controls.Add(Me.CopiesLabel)
        Me.Controls.Add(Me.AddCopiesBox)
        Me.Controls.Add(Me.DistFeeLabel)
        Me.Controls.Add(Me.AddFeeBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.AddTitleBox)
        Me.Controls.Add(Me.CancelMovieButton)
        Me.Controls.Add(Me.AddMovieButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddMovieForm"
        Me.Text = "Add Movie"
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
    Friend WithEvents SubmissionErrorMessage As Label
    Friend WithEvents ButActors As Button
    Friend WithEvents ButGenres As Button
End Class
