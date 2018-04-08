Imports System.Data.SqlClient
Imports System.Data
Public Class User
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private test As String
    Private dt = New DataTable()
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub


    Public Sub RefreshData()
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT MID, Title, Distrib_Fee, Copies, Rating From Movie"
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        dt.Clear()
        dt.Load(myReader)

        DGVHeldMovies.AutoGenerateColumns = True
        DGVHeldMovies.DataSource = dt
        DGVHeldMovies.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblCurOrder.Click

    End Sub
End Class