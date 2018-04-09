<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab_Search = New System.Windows.Forms.TabPage()
        Me.BtnAddMovie = New System.Windows.Forms.Button()
        Me.DGVActorResults = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVMovieResults = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CmbRating = New System.Windows.Forms.ComboBox()
        Me.CmbGenre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.TxtActor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tab_History = New System.Windows.Forms.TabPage()
        Me.Tab_Settings = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label_HeldMovies = New System.Windows.Forms.Label()
        Me.DGVHeldMovies = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnRemoveMovie = New System.Windows.Forms.Button()
        Me.BtnQueue = New System.Windows.Forms.Button()
        Me.DGVCart = New System.Windows.Forms.DataGridView()
        Me.LblCurOrder = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVQueue = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Search.SuspendLayout()
        CType(Me.DGVActorResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMovieResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVHeldMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab_Search)
        Me.TabControl1.Controls.Add(Me.Tab_History)
        Me.TabControl1.Controls.Add(Me.Tab_Settings)
        Me.TabControl1.Location = New System.Drawing.Point(12, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(508, 327)
        Me.TabControl1.TabIndex = 0
        '
        'Tab_Search
        '
        Me.Tab_Search.Controls.Add(Me.BtnAddMovie)
        Me.Tab_Search.Controls.Add(Me.DGVActorResults)
        Me.Tab_Search.Controls.Add(Me.Label5)
        Me.Tab_Search.Controls.Add(Me.DGVMovieResults)
        Me.Tab_Search.Controls.Add(Me.GroupBox1)
        Me.Tab_Search.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Search.Name = "Tab_Search"
        Me.Tab_Search.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Search.Size = New System.Drawing.Size(500, 301)
        Me.Tab_Search.TabIndex = 0
        Me.Tab_Search.Text = "Movie Search"
        Me.Tab_Search.UseVisualStyleBackColor = True
        '
        'BtnAddMovie
        '
        Me.BtnAddMovie.Location = New System.Drawing.Point(400, 125)
        Me.BtnAddMovie.Name = "BtnAddMovie"
        Me.BtnAddMovie.Size = New System.Drawing.Size(93, 36)
        Me.BtnAddMovie.TabIndex = 13
        Me.BtnAddMovie.Text = "Add Movie to Cart"
        Me.BtnAddMovie.UseVisualStyleBackColor = True
        '
        'DGVActorResults
        '
        Me.DGVActorResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVActorResults.Location = New System.Drawing.Point(6, 107)
        Me.DGVActorResults.Name = "DGVActorResults"
        Me.DGVActorResults.Size = New System.Drawing.Size(381, 71)
        Me.DGVActorResults.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Movie Search"
        '
        'DGVMovieResults
        '
        Me.DGVMovieResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMovieResults.Location = New System.Drawing.Point(6, 28)
        Me.DGVMovieResults.Name = "DGVMovieResults"
        Me.DGVMovieResults.Size = New System.Drawing.Size(487, 73)
        Me.DGVMovieResults.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.CmbRating)
        Me.GroupBox1.Controls.Add(Me.CmbGenre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtTitle)
        Me.GroupBox1.Controls.Add(Me.TxtActor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 117)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Criteria"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(206, 88)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 10
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbRating
        '
        Me.CmbRating.FormattingEnabled = True
        Me.CmbRating.Items.AddRange(New Object() {"", "0", "1", "2", "3", "4", "5"})
        Me.CmbRating.Location = New System.Drawing.Point(397, 17)
        Me.CmbRating.Name = "CmbRating"
        Me.CmbRating.Size = New System.Drawing.Size(93, 21)
        Me.CmbRating.TabIndex = 9
        '
        'CmbGenre
        '
        Me.CmbGenre.FormattingEnabled = True
        Me.CmbGenre.Location = New System.Drawing.Point(397, 47)
        Me.CmbGenre.Name = "CmbGenre"
        Me.CmbGenre.Size = New System.Drawing.Size(93, 21)
        Me.CmbGenre.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Genre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rating"
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(55, 19)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(272, 20)
        Me.TxtTitle.TabIndex = 0
        '
        'TxtActor
        '
        Me.TxtActor.Location = New System.Drawing.Point(55, 49)
        Me.TxtActor.Name = "TxtActor"
        Me.TxtActor.Size = New System.Drawing.Size(272, 20)
        Me.TxtActor.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Starring"
        '
        'Tab_History
        '
        Me.Tab_History.Location = New System.Drawing.Point(4, 22)
        Me.Tab_History.Name = "Tab_History"
        Me.Tab_History.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_History.Size = New System.Drawing.Size(500, 301)
        Me.Tab_History.TabIndex = 1
        Me.Tab_History.Text = "Order History"
        Me.Tab_History.UseVisualStyleBackColor = True
        '
        'Tab_Settings
        '
        Me.Tab_Settings.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Settings.Name = "Tab_Settings"
        Me.Tab_Settings.Size = New System.Drawing.Size(500, 301)
        Me.Tab_Settings.TabIndex = 2
        Me.Tab_Settings.Text = "Account Settings"
        Me.Tab_Settings.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label_HeldMovies)
        Me.Panel1.Controls.Add(Me.DGVHeldMovies)
        Me.Panel1.Location = New System.Drawing.Point(12, 504)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 157)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Return Selected Movie"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label_HeldMovies
        '
        Me.Label_HeldMovies.AutoSize = True
        Me.Label_HeldMovies.Location = New System.Drawing.Point(207, 0)
        Me.Label_HeldMovies.Name = "Label_HeldMovies"
        Me.Label_HeldMovies.Size = New System.Drawing.Size(110, 13)
        Me.Label_HeldMovies.TabIndex = 1
        Me.Label_HeldMovies.Text = "Currently Held Movies"
        '
        'DGVHeldMovies
        '
        Me.DGVHeldMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHeldMovies.Location = New System.Drawing.Point(6, 27)
        Me.DGVHeldMovies.Name = "DGVHeldMovies"
        Me.DGVHeldMovies.Size = New System.Drawing.Size(501, 83)
        Me.DGVHeldMovies.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnRemoveMovie)
        Me.Panel2.Controls.Add(Me.BtnQueue)
        Me.Panel2.Controls.Add(Me.DGVCart)
        Me.Panel2.Controls.Add(Me.LblCurOrder)
        Me.Panel2.Location = New System.Drawing.Point(12, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 164)
        Me.Panel2.TabIndex = 3
        '
        'BtnRemoveMovie
        '
        Me.BtnRemoveMovie.Location = New System.Drawing.Point(10, 126)
        Me.BtnRemoveMovie.Name = "BtnRemoveMovie"
        Me.BtnRemoveMovie.Size = New System.Drawing.Size(75, 35)
        Me.BtnRemoveMovie.TabIndex = 3
        Me.BtnRemoveMovie.Text = "Remove Movie"
        Me.BtnRemoveMovie.UseVisualStyleBackColor = True
        '
        'BtnQueue
        '
        Me.BtnQueue.Location = New System.Drawing.Point(169, 127)
        Me.BtnQueue.Name = "BtnQueue"
        Me.BtnQueue.Size = New System.Drawing.Size(75, 34)
        Me.BtnQueue.TabIndex = 2
        Me.BtnQueue.Text = "Order"
        Me.BtnQueue.UseVisualStyleBackColor = True
        '
        'DGVCart
        '
        Me.DGVCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCart.Location = New System.Drawing.Point(7, 27)
        Me.DGVCart.Name = "DGVCart"
        Me.DGVCart.Size = New System.Drawing.Size(237, 85)
        Me.DGVCart.TabIndex = 1
        '
        'LblCurOrder
        '
        Me.LblCurOrder.AutoSize = True
        Me.LblCurOrder.Location = New System.Drawing.Point(89, 0)
        Me.LblCurOrder.Name = "LblCurOrder"
        Me.LblCurOrder.Size = New System.Drawing.Size(74, 13)
        Me.LblCurOrder.TabIndex = 0
        Me.LblCurOrder.Text = "Shopping Cart"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGVQueue)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(272, 334)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 164)
        Me.Panel3.TabIndex = 4
        '
        'DGVQueue
        '
        Me.DGVQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVQueue.Location = New System.Drawing.Point(11, 27)
        Me.DGVQueue.Name = "DGVQueue"
        Me.DGVQueue.Size = New System.Drawing.Size(226, 85)
        Me.DGVQueue.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Queue"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 673)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "User"
        Me.Text = "User"
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Search.ResumeLayout(False)
        Me.Tab_Search.PerformLayout()
        CType(Me.DGVActorResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMovieResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVHeldMovies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVQueue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tab_Search As TabPage
    Friend WithEvents Tab_History As TabPage
    Friend WithEvents Tab_Settings As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVHeldMovies As DataGridView
    Friend WithEvents Label_HeldMovies As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblCurOrder As Label
    Friend WithEvents BtnQueue As Button
    Friend WithEvents DGVCart As DataGridView
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents TxtActor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CmbRating As ComboBox
    Friend WithEvents CmbGenre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVMovieResults As DataGridView
    Friend WithEvents BtnAddMovie As Button
    Friend WithEvents DGVActorResults As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGVQueue As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnRemoveMovie As Button
End Class
