<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ManageMovieTab = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DeleteMovie = New System.Windows.Forms.Button()
        Me.EditMovie = New System.Windows.Forms.Button()
        Me.AddMovie = New System.Windows.Forms.Button()
        Me.ManageEmployeesTab = New System.Windows.Forms.TabPage()
        Me.ManageSalesTab = New System.Windows.Forms.TabPage()
        Me.ManageListsTab = New System.Windows.Forms.TabPage()
        Me._291ProjectDataSet1 = New _291_Project._291ProjectDataSet()
        Me.TabControl1.SuspendLayout()
        Me.ManageMovieTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._291ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ManageMovieTab)
        Me.TabControl1.Controls.Add(Me.ManageEmployeesTab)
        Me.TabControl1.Controls.Add(Me.ManageSalesTab)
        Me.TabControl1.Controls.Add(Me.ManageListsTab)
        Me.TabControl1.Location = New System.Drawing.Point(1, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 478)
        Me.TabControl1.TabIndex = 0
        '
        'ManageMovieTab
        '
        Me.ManageMovieTab.Controls.Add(Me.DataGridView1)
        Me.ManageMovieTab.Controls.Add(Me.DeleteMovie)
        Me.ManageMovieTab.Controls.Add(Me.EditMovie)
        Me.ManageMovieTab.Controls.Add(Me.AddMovie)
        Me.ManageMovieTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageMovieTab.Name = "ManageMovieTab"
        Me.ManageMovieTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ManageMovieTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageMovieTab.TabIndex = 0
        Me.ManageMovieTab.Text = "Movies"
        Me.ManageMovieTab.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(438, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'DeleteMovie
        '
        Me.DeleteMovie.Location = New System.Drawing.Point(633, 419)
        Me.DeleteMovie.Name = "DeleteMovie"
        Me.DeleteMovie.Size = New System.Drawing.Size(80, 23)
        Me.DeleteMovie.TabIndex = 2
        Me.DeleteMovie.Text = "Delete Movie"
        Me.DeleteMovie.UseVisualStyleBackColor = True
        '
        'EditMovie
        '
        Me.EditMovie.Location = New System.Drawing.Point(552, 419)
        Me.EditMovie.Name = "EditMovie"
        Me.EditMovie.Size = New System.Drawing.Size(75, 23)
        Me.EditMovie.TabIndex = 1
        Me.EditMovie.Text = "Edit Movie"
        Me.EditMovie.UseVisualStyleBackColor = True
        '
        'AddMovie
        '
        Me.AddMovie.Location = New System.Drawing.Point(24, 15)
        Me.AddMovie.Name = "AddMovie"
        Me.AddMovie.Size = New System.Drawing.Size(75, 23)
        Me.AddMovie.TabIndex = 0
        Me.AddMovie.Text = "Add Movie"
        Me.AddMovie.UseVisualStyleBackColor = True
        '
        'ManageEmployeesTab
        '
        Me.ManageEmployeesTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageEmployeesTab.Name = "ManageEmployeesTab"
        Me.ManageEmployeesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ManageEmployeesTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageEmployeesTab.TabIndex = 1
        Me.ManageEmployeesTab.Text = "Employees"
        Me.ManageEmployeesTab.UseVisualStyleBackColor = True
        '
        'ManageSalesTab
        '
        Me.ManageSalesTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageSalesTab.Name = "ManageSalesTab"
        Me.ManageSalesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ManageSalesTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageSalesTab.TabIndex = 2
        Me.ManageSalesTab.Text = "Sales"
        Me.ManageSalesTab.UseVisualStyleBackColor = True
        '
        'ManageListsTab
        '
        Me.ManageListsTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageListsTab.Name = "ManageListsTab"
        Me.ManageListsTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageListsTab.TabIndex = 3
        Me.ManageListsTab.Text = "Lists"
        Me.ManageListsTab.UseVisualStyleBackColor = True
        '
        '_291ProjectDataSet1
        '
        Me._291ProjectDataSet1.DataSetName = "_291ProjectDataSet"
        Me._291ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 506)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Management"
        Me.TabControl1.ResumeLayout(False)
        Me.ManageMovieTab.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._291ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ManageMovieTab As TabPage
    Friend WithEvents ManageEmployeesTab As TabPage
    Friend WithEvents ManageSalesTab As TabPage
    Friend WithEvents DeleteMovie As Button
    Friend WithEvents EditMovie As Button
    Friend WithEvents AddMovie As Button
    Friend WithEvents ManageListsTab As TabPage
    Friend WithEvents _291ProjectDataSet1 As _291ProjectDataSet
    Friend WithEvents DataGridView1 As DataGridView
End Class
