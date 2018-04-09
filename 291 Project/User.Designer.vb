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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGVActorResults = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVMovieResults = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tab_History = New System.Windows.Forms.TabPage()
        Me.Tab_Settings = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_HeldMovies = New System.Windows.Forms.Label()
        Me.DGVHeldMovies = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.DGVCurOrder = New System.Windows.Forms.DataGridView()
        Me.LblCurOrder = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Search.SuspendLayout()
        CType(Me.DGVActorResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMovieResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVHeldMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVCurOrder, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Tab_Search.Controls.Add(Me.Button2)
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(400, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Add Movie to Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DGVActorResults
        '
        Me.DGVActorResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVActorResults.Location = New System.Drawing.Point(265, 28)
        Me.DGVActorResults.Name = "DGVActorResults"
        Me.DGVActorResults.Size = New System.Drawing.Size(122, 150)
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
        Me.DGVMovieResults.Size = New System.Drawing.Size(244, 150)
        Me.DGVMovieResults.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 117)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Criteria"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"""""", "0", "1", "2", "3", "4", "5"})
        Me.ComboBox2.Location = New System.Drawing.Point(397, 17)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(93, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(397, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(93, 21)
        Me.ComboBox1.TabIndex = 8
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(55, 49)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 20)
        Me.TextBox3.TabIndex = 2
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
        Me.Panel1.Controls.Add(Me.Label_HeldMovies)
        Me.Panel1.Controls.Add(Me.DGVHeldMovies)
        Me.Panel1.Location = New System.Drawing.Point(9, 504)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 157)
        Me.Panel1.TabIndex = 2
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
        Me.DGVHeldMovies.Location = New System.Drawing.Point(6, 44)
        Me.DGVHeldMovies.Name = "DGVHeldMovies"
        Me.DGVHeldMovies.Size = New System.Drawing.Size(501, 110)
        Me.DGVHeldMovies.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnOrder)
        Me.Panel2.Controls.Add(Me.DGVCurOrder)
        Me.Panel2.Controls.Add(Me.LblCurOrder)
        Me.Panel2.Location = New System.Drawing.Point(12, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 164)
        Me.Panel2.TabIndex = 3
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(404, 138)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrder.TabIndex = 2
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'DGVCurOrder
        '
        Me.DGVCurOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCurOrder.Location = New System.Drawing.Point(4, 40)
        Me.DGVCurOrder.Name = "DGVCurOrder"
        Me.DGVCurOrder.Size = New System.Drawing.Size(350, 121)
        Me.DGVCurOrder.TabIndex = 1
        '
        'LblCurOrder
        '
        Me.LblCurOrder.AutoSize = True
        Me.LblCurOrder.Location = New System.Drawing.Point(218, 0)
        Me.LblCurOrder.Name = "LblCurOrder"
        Me.LblCurOrder.Size = New System.Drawing.Size(74, 13)
        Me.LblCurOrder.TabIndex = 0
        Me.LblCurOrder.Text = "Shopping Cart"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 673)
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
        CType(Me.DGVCurOrder, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnOrder As Button
    Friend WithEvents DGVCurOrder As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVMovieResults As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents DGVActorResults As DataGridView
End Class
