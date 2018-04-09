<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustRep
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
        Me.CustRepTabs = New System.Windows.Forms.TabControl()
        Me.Orders = New System.Windows.Forms.TabPage()
        Me.DeleteOrderButton = New System.Windows.Forms.Button()
        Me.ApproveOrderButton = New System.Windows.Forms.Button()
        Me.OrdersGridView = New System.Windows.Forms.DataGridView()
        Me.Customers = New System.Windows.Forms.TabPage()
        Me.DeleteCustButton = New System.Windows.Forms.Button()
        Me.EditCustButton = New System.Windows.Forms.Button()
        Me.AddCustButton = New System.Windows.Forms.Button()
        Me.CustomerGridView = New System.Windows.Forms.DataGridView()
        Me.MailButton = New System.Windows.Forms.Button()
        Me.CustRepTabs.SuspendLayout()
        Me.Orders.SuspendLayout()
        CType(Me.OrdersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customers.SuspendLayout()
        CType(Me.CustomerGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustRepTabs
        '
        Me.CustRepTabs.Controls.Add(Me.Orders)
        Me.CustRepTabs.Controls.Add(Me.Customers)
        Me.CustRepTabs.Location = New System.Drawing.Point(12, 12)
        Me.CustRepTabs.Name = "CustRepTabs"
        Me.CustRepTabs.SelectedIndex = 0
        Me.CustRepTabs.Size = New System.Drawing.Size(776, 408)
        Me.CustRepTabs.TabIndex = 0
        '
        'Orders
        '
        Me.Orders.Controls.Add(Me.MailButton)
        Me.Orders.Controls.Add(Me.DeleteOrderButton)
        Me.Orders.Controls.Add(Me.ApproveOrderButton)
        Me.Orders.Controls.Add(Me.OrdersGridView)
        Me.Orders.Location = New System.Drawing.Point(4, 22)
        Me.Orders.Name = "Orders"
        Me.Orders.Padding = New System.Windows.Forms.Padding(3)
        Me.Orders.Size = New System.Drawing.Size(768, 382)
        Me.Orders.TabIndex = 0
        Me.Orders.Text = "Orders"
        Me.Orders.UseVisualStyleBackColor = True
        '
        'DeleteOrderButton
        '
        Me.DeleteOrderButton.Location = New System.Drawing.Point(662, 353)
        Me.DeleteOrderButton.Name = "DeleteOrderButton"
        Me.DeleteOrderButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteOrderButton.TabIndex = 2
        Me.DeleteOrderButton.Text = "Delete"
        Me.DeleteOrderButton.UseVisualStyleBackColor = True
        '
        'ApproveOrderButton
        '
        Me.ApproveOrderButton.Location = New System.Drawing.Point(581, 353)
        Me.ApproveOrderButton.Name = "ApproveOrderButton"
        Me.ApproveOrderButton.Size = New System.Drawing.Size(75, 23)
        Me.ApproveOrderButton.TabIndex = 1
        Me.ApproveOrderButton.Text = "Approve"
        Me.ApproveOrderButton.UseVisualStyleBackColor = True
        '
        'OrdersGridView
        '
        Me.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdersGridView.Location = New System.Drawing.Point(17, 16)
        Me.OrdersGridView.Name = "OrdersGridView"
        Me.OrdersGridView.Size = New System.Drawing.Size(734, 331)
        Me.OrdersGridView.TabIndex = 0
        '
        'Customers
        '
        Me.Customers.Controls.Add(Me.DeleteCustButton)
        Me.Customers.Controls.Add(Me.EditCustButton)
        Me.Customers.Controls.Add(Me.AddCustButton)
        Me.Customers.Controls.Add(Me.CustomerGridView)
        Me.Customers.Location = New System.Drawing.Point(4, 22)
        Me.Customers.Name = "Customers"
        Me.Customers.Padding = New System.Windows.Forms.Padding(3)
        Me.Customers.Size = New System.Drawing.Size(768, 382)
        Me.Customers.TabIndex = 1
        Me.Customers.Text = "Customers"
        Me.Customers.UseVisualStyleBackColor = True
        '
        'DeleteCustButton
        '
        Me.DeleteCustButton.Location = New System.Drawing.Point(661, 353)
        Me.DeleteCustButton.Name = "DeleteCustButton"
        Me.DeleteCustButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteCustButton.TabIndex = 4
        Me.DeleteCustButton.Text = "Delete"
        Me.DeleteCustButton.UseVisualStyleBackColor = True
        '
        'EditCustButton
        '
        Me.EditCustButton.Location = New System.Drawing.Point(580, 353)
        Me.EditCustButton.Name = "EditCustButton"
        Me.EditCustButton.Size = New System.Drawing.Size(75, 23)
        Me.EditCustButton.TabIndex = 3
        Me.EditCustButton.Text = "Edit"
        Me.EditCustButton.UseVisualStyleBackColor = True
        '
        'AddCustButton
        '
        Me.AddCustButton.Location = New System.Drawing.Point(499, 353)
        Me.AddCustButton.Name = "AddCustButton"
        Me.AddCustButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCustButton.TabIndex = 2
        Me.AddCustButton.Text = "Add"
        Me.AddCustButton.UseVisualStyleBackColor = True
        '
        'CustomerGridView
        '
        Me.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerGridView.Location = New System.Drawing.Point(17, 16)
        Me.CustomerGridView.Name = "CustomerGridView"
        Me.CustomerGridView.Size = New System.Drawing.Size(734, 331)
        Me.CustomerGridView.TabIndex = 0
        '
        'MailButton
        '
        Me.MailButton.Location = New System.Drawing.Point(30, 353)
        Me.MailButton.Name = "MailButton"
        Me.MailButton.Size = New System.Drawing.Size(105, 23)
        Me.MailButton.TabIndex = 3
        Me.MailButton.Text = "Generate Mail List"
        Me.MailButton.UseVisualStyleBackColor = True
        '
        'CustRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CustRepTabs)
        Me.Name = "CustRep"
        Me.Text = "Customer Representative"
        Me.CustRepTabs.ResumeLayout(False)
        Me.Orders.ResumeLayout(False)
        CType(Me.OrdersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customers.ResumeLayout(False)
        CType(Me.CustomerGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustRepTabs As TabControl
    Friend WithEvents Orders As TabPage
    Friend WithEvents Customers As TabPage
    Friend WithEvents CustomerGridView As DataGridView
    Friend WithEvents AddCustButton As Button
    Friend WithEvents EditCustButton As Button
    Friend WithEvents DeleteCustButton As Button
    Friend WithEvents OrdersGridView As DataGridView
    Friend WithEvents ApproveOrderButton As Button
    Friend WithEvents DeleteOrderButton As Button
    Friend WithEvents MailButton As Button
End Class
