Imports System.Data.SqlClient
Imports System.Data
Public Class User
    Private myConn As SqlConnection = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private cartArray = New List(Of String)

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVMovieResults.AllowUserToAddRows = False
        DGVMovieResults.AllowUserToDeleteRows = False
        DGVMovieResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVCart.AllowUserToAddRows = False
        DGVCart.AllowUserToDeleteRows = False
        DGVCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVHeldMovies.AllowUserToAddRows = False
        DGVHeldMovies.AllowUserToDeleteRows = False
        DGVHeldMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVMovieResults_Init()
        DGVActorResults_Refresh()
        DGVHeldMovies_Refresh()

    End Sub

    Private Sub DGVCart_Refresh()
        myConn.Open()
        Dim queries = New DataTable()
        queries.Clear()
        For Each mid As String In cartArray
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT Title From Movie where MID = " + mid.ToString
            myReader = myCmd.ExecuteReader()
            queries.Load(myReader)
        Next
        DGVCart.AutoGenerateColumns = True
        DGVCart.DataSource = queries
        DGVCart.Refresh()
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub DGVQueue_Refresh()

    End Sub

    Private Sub DGVHeldMovies_Refresh()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT MID FROM Orders WHERE ActualReturn = null AND CID = 1"
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim dtHeldOrders = New DataTable()
        dtHeldOrders.Clear()
        dtHeldOrders.Load(myReader)

        DGVHeldMovies.AutoGenerateColumns = True
        DGVHeldMovies.DataSource = dtHeldOrders
        DGVHeldMovies.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub


    Private Sub DGVMovieResults_Init()

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT MID, Title, Copies, Rating from Movie"
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim dtMovieResults = New DataTable()
        dtMovieResults.Clear()
        dtMovieResults.Load(myReader)

        DGVMovieResults.AutoGenerateColumns = True
        DGVMovieResults.DataSource = dtMovieResults
        DGVMovieResults.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub DGVActorResults_Refresh()
        myCmd = myConn.CreateCommand
        Dim selectedMID = DGVMovieResults.SelectedRows.ToString
        System.Console.WriteLine(selectedMID)

        myCmd.CommandText = "SELECT Actor.AID, Actor.FirstName + ' ' + Actor.LastName as Name FROM Actor, MovieActor WHERE Actor.AID = MovieActor.AID and MovieActor.MID = 0"

        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim dtActorResults = New DataTable()
        dtActorResults.Clear()
        dtActorResults.Load(myReader)

        DGVActorResults.AutoGenerateColumns = True
        DGVActorResults.DataSource = dtActorResults
        DGVActorResults.Refresh()

        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub DGVMovieResults_SelectionChanged(sender As Object, e As EventArgs) Handles DGVMovieResults.SelectionChanged
        myCmd = myConn.CreateCommand
        Dim selectedMID = DGVMovieResults.SelectedRows.ToString
        System.Console.WriteLine(selectedMID)

        myCmd.CommandText = "SELECT Actor.AID, Actor.FirstName + ' ' + Actor.LastName as Name FROM Actor, MovieActor WHERE Actor.AID = MovieActor.AID and MovieActor.MID = 0"

        If (myConn.State <> ConnectionState.Open) Then
            myConn.Open()
        End If

        myReader = myCmd.ExecuteReader()

        Dim dtActorResults = New DataTable()
        dtActorResults.Clear()
        dtActorResults.Load(myReader)

        DGVActorResults.AutoGenerateColumns = True
        DGVActorResults.DataSource = dtActorResults
        DGVActorResults.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub BtnAddMovie_Click(sender As Object, e As EventArgs) Handles BtnAddMovie.Click
        For Each row As DataGridViewRow In DGVMovieResults.SelectedRows
            Dim mid = row.Cells(0).Value
            If (Not cartArray.Contains(mid.ToString)) Then
                cartArray.Add(mid.ToString)
            End If
        Next
        DGVCart_Refresh()
    End Sub

    Private Sub BtnRemoveMovie_Click(sender As Object, e As EventArgs) Handles BtnRemoveMovie.Click
        For Each row As DataGridViewRow In DGVCart.SelectedRows
            Dim mid = row.Cells(0).Value
            cartArray.Remove(mid.ToString)
        Next
        DGVCart_Refresh()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim Title = TxtTitle.Text
        Dim Actor = TxtActor.Text
        Dim Rating = CmbRating.Text
        Dim Genre = CmbGenre.Text

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT MID, Title, Copies, Rating FROM Movie WHERE " +
            "Title LIKE %" + Title + "%" +
            " AND Rating LIKE " + Rating +
            " AND Genre LIKE " + Genre


        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim dtMovieResults = New DataTable()
        dtMovieResults.Clear()
        dtMovieResults.Load(myReader)

        DGVMovieResults.AutoGenerateColumns = True
        DGVMovieResults.DataSource = dtMovieResults
        DGVMovieResults.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub BtnQueue_Click(sender As Object, e As EventArgs) Handles BtnQueue.Click

    End Sub
End Class