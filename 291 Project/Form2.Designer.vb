<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActorGenreForm
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
        Me.ActorGenreDataGrid = New System.Windows.Forms.DataGridView()
        Me.AddBut = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.TextGenre = New System.Windows.Forms.TextBox()
        Me.ComboActor = New System.Windows.Forms.ComboBox()
        CType(Me.ActorGenreDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActorGenreDataGrid
        '
        Me.ActorGenreDataGrid.AllowUserToAddRows = False
        Me.ActorGenreDataGrid.AllowUserToDeleteRows = False
        Me.ActorGenreDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActorGenreDataGrid.Location = New System.Drawing.Point(13, 72)
        Me.ActorGenreDataGrid.Name = "ActorGenreDataGrid"
        Me.ActorGenreDataGrid.ReadOnly = True
        Me.ActorGenreDataGrid.RowTemplate.Height = 24
        Me.ActorGenreDataGrid.Size = New System.Drawing.Size(542, 375)
        Me.ActorGenreDataGrid.TabIndex = 0
        '
        'AddBut
        '
        Me.AddBut.Location = New System.Drawing.Point(13, 24)
        Me.AddBut.Name = "AddBut"
        Me.AddBut.Size = New System.Drawing.Size(75, 23)
        Me.AddBut.TabIndex = 1
        Me.AddBut.Text = "Add"
        Me.AddBut.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(479, 24)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(398, 24)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 23)
        Me.Edit.TabIndex = 3
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'TextGenre
        '
        Me.TextGenre.Location = New System.Drawing.Point(110, 24)
        Me.TextGenre.Name = "TextGenre"
        Me.TextGenre.Size = New System.Drawing.Size(134, 22)
        Me.TextGenre.TabIndex = 4
        Me.TextGenre.Visible = False
        '
        'ComboActor
        '
        Me.ComboActor.FormattingEnabled = True
        Me.ComboActor.Location = New System.Drawing.Point(110, 24)
        Me.ComboActor.Name = "ComboActor"
        Me.ComboActor.Size = New System.Drawing.Size(208, 24)
        Me.ComboActor.TabIndex = 5
        Me.ComboActor.Visible = False
        '
        'ActorGenreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 459)
        Me.Controls.Add(Me.ComboActor)
        Me.Controls.Add(Me.TextGenre)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.AddBut)
        Me.Controls.Add(Me.ActorGenreDataGrid)
        Me.Name = "ActorGenreForm"
        Me.Text = "ActorGenreForm"
        CType(Me.ActorGenreDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActorGenreDataGrid As DataGridView
    Friend WithEvents AddBut As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Edit As Button
    Friend WithEvents TextGenre As TextBox
    Friend WithEvents ComboActor As ComboBox
End Class
