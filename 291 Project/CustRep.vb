Imports System.Data.SqlClient
Imports System.Data

Public Class CustRep
    Private myConn As SqlConnection = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private test As String
    Private OrderDT = New DataTable()
    Private CustDT = New DataTable()

    Private Sub CustRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrdersGridView.AllowUserToAddRows = False
        OrdersGridView.AllowUserToDeleteRows = False
        OrdersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        CustomerGridView.AllowUserToAddRows = False
        CustomerGridView.AllowUserToDeleteRows = False
        CustomerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        RefreshCustData()
        RefreshOrderData()

    End Sub

    Private Sub CustomerGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerGridView.CellContentClick

    End Sub

    Private Sub AddCustButton_Click(sender As Object, e As EventArgs) Handles AddCustButton.Click
        Dim box = New AddCustForm
        box.Show()
    End Sub

    Private Sub EditCustButton_Click(sender As Object, e As EventArgs) Handles EditCustButton.Click
        For Each row As DataGridViewRow In CustomerGridView.SelectedRows
            Dim ebox = New AddCustForm
            ebox.id = row.Cells(0).Value
            ebox.first = row.Cells(1).Value
            ebox.last = row.Cells(2).Value
            ebox.address = row.Cells(3).Value
            ebox.city = row.Cells(4).Value
            ebox.state = row.Cells(5).Value
            ebox.zip = row.Cells(6).Value
            ebox.email = row.Cells(7).Value
            ebox.credit = row.Cells(8).Value
            ebox.rating = row.Cells(9).Value
            ebox.account = row.Cells(10).Value
            ebox.Show()

        Next

    End Sub

    Private Sub DeleteCustButton_Click(sender As Object, e As EventArgs) Handles DeleteCustButton.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete these customers?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In CustomerGridView.SelectedRows
                myCmd = myConn.CreateCommand
                Dim CID As Integer
                CID = row.Cells(0).Value
                myCmd.CommandText = "Delete From Customer where CID = " + CID.ToString
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
            RefreshCustData()
        End If
    End Sub

    Private Sub ApproveOrderButton_Click(sender As Object, e As EventArgs) Handles ApproveOrderButton.Click
        Dim ApproveChoice As DialogResult
        ApproveChoice = MsgBox("We couldn't figure out how to 'record orders'. This is a placeholder.", MessageBoxButtons.OKCancel)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersGridView.CellContentClick

    End Sub

    Private Sub DeleteOrder_Click(sender As Object, e As EventArgs) Handles DeleteOrderButton.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete these orders?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In OrdersGridView.SelectedRows
                myCmd = myConn.CreateCommand
                Dim Oid As Integer
                Oid = row.Cells(0).Value
                myCmd.CommandText = "Delete From Order where OID = " + Oid.ToString
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
            RefreshOrderData()
        End If

    End Sub

    Public Sub RefreshCustData()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT CID, FirstName, LastName, StreetAddress, City, State, ZipCode, Email, CreditCard, Rating, AccountType From Customer"
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        CustDT.Clear()
        CustDT.Load(myReader)

        CustomerGridView.AutoGenerateColumns = True
        CustomerGridView.DataSource = CustDT
        CustomerGridView.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Public Sub RefreshOrderData()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT OID, Date, ExpectedReturn, ActualReturn, MID, CID, EID From Orders"
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        OrderDT.Clear()
        OrderDT.Load(myReader)

        OrdersGridView.AutoGenerateColumns = True
        OrdersGridView.DataSource = OrderDT
        OrdersGridView.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub MailButton_Click(sender As Object, e As EventArgs) Handles MailButton.Click
        Dim Mail As DialogResult
        Mail = MsgBox("Are you sure you want to generate a mail list?", MessageBoxButtons.OKCancel)
        If Mail = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In CustomerGridView.SelectedRows
                myCmd = myConn.CreateCommand
                Dim Cid As Integer
                Cid = row.Cells(0).Value
                myCmd.CommandText = "SELECT CID, Email From Customer"
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()

        End If
    End Sub
End Class