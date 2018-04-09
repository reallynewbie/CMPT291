Imports System.Data.SqlClient
Imports System.Data

Public Class CustRep
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private test As String
    Private dt = New DataTable()
    Private Sub CustRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        RefreshCustData()
        RefreshOrderData()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DeleteOrder_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete these orders?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                myCmd = myConn.CreateCommand
                Dim Oid As Integer
                Oid = row.Cells(0).Value
                myCmd.CommandText = "Delete From Movie where MID = " + Oid.ToString
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
            RefreshOrderData()
        End If

    End Sub

    Public Sub RefreshCustData()
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT CID, FirstName, LastName, StreetAddress, City, State, ZipCode, Email, CreditCard, Rating, AccountType From Customer"
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        dt.Clear()
        dt.Load(myReader)

        DataGridView2.AutoGenerateColumns = True
        DataGridView2.DataSource = dt
        DataGridView2.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Public Sub RefreshOrderData()
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT OID, Date, ExpectedReturn, ActualReturn, MID, CID, EID From Orders"
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        dt.Clear()
        dt.Load(myReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

End Class