Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private test As String
    Private dt = New DataTable()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        

        RefreshData()


    End Sub

    Private Sub AddMovie_Click(sender As System.Object, e As System.EventArgs) Handles AddMovie.Click
        Dim box = New AddMovieForm
        box.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DeleteMovie_Click(sender As Object, e As EventArgs) Handles DeleteMovie.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete this movie(s)?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                myCmd = myConn.CreateCommand
                Dim mid As Integer
                mid = row.Cells(0).Value
                myCmd.CommandText = "Delete From Movie where MID = " + mid.ToString
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
            RefreshData()
        End If

    End Sub

    Private Sub EditMovie_Click(sender As Object, e As EventArgs) Handles EditMovie.Click
        Dim ebox = New AddMovieForm
        ' ebox.id

    End Sub

    Public Sub RefreshData()
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT MID, Title, Distrib_Fee, Copies, Rating From Movie"
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
