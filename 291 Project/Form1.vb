Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Title, Copies From Movie"
        myConn.Open()

        myReader = myCmd.ExecuteReader()
        'myReader.Read()

        'Display results.

        Dim dt = New DataTable()

        dt.Load(myReader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub AddMovie_Click(sender As Object, e As EventArgs) Handles AddMovie.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub
End Class
