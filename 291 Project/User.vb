Imports System.Data.SqlClient
Imports System.Data
Public Class User
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private dtMovieResults = New DataTable()
    Private dtActorResults = New DataTable()
    Private dtCurOrder = New DataTable()
    Private dtHeldOrders = New DataTable()

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVMovieResults.AllowUserToAddRows = False
        DGVMovieResults.AllowUserToDeleteRows = False
        DGVMovieResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVCurOrder.AllowUserToAddRows = False
        DGVCurOrder.AllowUserToDeleteRows = False
        DGVCurOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVHeldMovies.AllowUserToAddRows = False
        DGVHeldMovies.AllowUserToDeleteRows = False
        DGVHeldMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        DGVMovieResults_Init()


    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DGVMovieResults_Init()
        myCmd.CommandText = "SELECT MID, Title, Copies, Rating from Movie"
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        dtMovieResults.Clear()
        dtMovieResults.Load(myReader)

        DGVMovieResults.AutoGenerateColumns = True
        DGVMovieResults.DataSource = dtMovieResults
        DGVMovieResults.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub DGVActorResults_Init()
        Dim selectedMID = DGVMovieResults.SelectedCells.Value
        myCmd.CommandText = "SELECT Actor.AID, Actor.FirstName + ' ' + Actor.LastName as Name FROM Actor, MovieActor WHERE Actor.AID = MovieActor.AID and MovieActor.MID = " + selectedMID

        myConn.Open()

        myReader = myCmd.ExecuteReader()

        dtMovieResults.Clear()
        dtMovieResults.Load(myReader)
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblCurOrder.Click

    End Sub

    Private Sub DGVMovieResults_SelectionChanged(sender As Object, e As EventArgs) Handles DGVMovieResults.SelectionChanged

    End Sub
End Class