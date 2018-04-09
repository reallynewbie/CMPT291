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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(937, 327)
        Me.TabControl1.TabIndex = 0
        '
        'Tab_Search
        '
        Me.Tab_Search.Controls.Add(Me.TableLayoutPanel1)
        Me.Tab_Search.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Search.Name = "Tab_Search"
        Me.Tab_Search.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Search.Size = New System.Drawing.Size(929, 301)
        Me.Tab_Search.TabIndex = 0
        Me.Tab_Search.Text = "Movie Search"
        Me.Tab_Search.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 30)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(929, 108)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(188, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(188, 53)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(188, 78)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(272, 20)
        Me.TextBox4.TabIndex = 3
        '
        'Tab_History
        '
        Me.Tab_History.Location = New System.Drawing.Point(4, 22)
        Me.Tab_History.Name = "Tab_History"
        Me.Tab_History.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_History.Size = New System.Drawing.Size(929, 301)
        Me.Tab_History.TabIndex = 1
        Me.Tab_History.Text = "Order History"
        Me.Tab_History.UseVisualStyleBackColor = True
        '
        'Tab_Settings
        '
        Me.Tab_Settings.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Settings.Name = "Tab_Settings"
        Me.Tab_Settings.Size = New System.Drawing.Size(929, 301)
        Me.Tab_Settings.TabIndex = 2
        Me.Tab_Settings.Text = "Account Settings"
        Me.Tab_Settings.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label_HeldMovies)
        Me.Panel1.Controls.Add(Me.DGVHeldMovies)
        Me.Panel1.Location = New System.Drawing.Point(0, 504)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 157)
        Me.Panel1.TabIndex = 2
        '
        'Label_HeldMovies
        '
        Me.Label_HeldMovies.AutoSize = True
        Me.Label_HeldMovies.Location = New System.Drawing.Point(432, 14)
        Me.Label_HeldMovies.Name = "Label_HeldMovies"
        Me.Label_HeldMovies.Size = New System.Drawing.Size(110, 13)
        Me.Label_HeldMovies.TabIndex = 1
        Me.Label_HeldMovies.Text = "Currently Held Movies"
        '
        'DGVHeldMovies
        '
        Me.DGVHeldMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHeldMovies.Location = New System.Drawing.Point(2, 44)
        Me.DGVHeldMovies.Name = "DGVHeldMovies"
        Me.DGVHeldMovies.Size = New System.Drawing.Size(930, 113)
        Me.DGVHeldMovies.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnOrder)
        Me.Panel2.Controls.Add(Me.DGVCurOrder)
        Me.Panel2.Controls.Add(Me.LblCurOrder)
        Me.Panel2.Location = New System.Drawing.Point(3, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(929, 164)
        Me.Panel2.TabIndex = 3
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(828, 85)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrder.TabIndex = 2
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'DGVCurOrder
        '
        Me.DGVCurOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCurOrder.Location = New System.Drawing.Point(0, 37)
        Me.DGVCurOrder.Name = "DGVCurOrder"
        Me.DGVCurOrder.Size = New System.Drawing.Size(783, 127)
        Me.DGVCurOrder.TabIndex = 1
        '
        'LblCurOrder
        '
        Me.LblCurOrder.AutoSize = True
        Me.LblCurOrder.Location = New System.Drawing.Point(432, 4)
        Me.LblCurOrder.Name = "LblCurOrder"
        Me.LblCurOrder.Size = New System.Drawing.Size(70, 13)
        Me.LblCurOrder.TabIndex = 0
        Me.LblCurOrder.Text = "Current Order"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 661)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "User"
        Me.Text = "User"
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Search.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVHeldMovies As DataGridView
    Friend WithEvents Label_HeldMovies As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblCurOrder As Label
    Friend WithEvents BtnOrder As Button
    Friend WithEvents DGVCurOrder As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
