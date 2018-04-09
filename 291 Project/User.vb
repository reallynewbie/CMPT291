Imports System.Data.SqlClient
Imports System.Data
Public Class User
    Private myConn As SqlConnection = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private cid = "1"

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVMovieResults.AllowUserToAddRows = False
        DGVMovieResults.AllowUserToDeleteRows = False
        DGVMovieResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVHeldMovies.AllowUserToAddRows = False
        DGVHeldMovies.AllowUserToDeleteRows = False
        DGVHeldMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVQueue.AllowUserToAddRows = False
        DGVQueue.AllowUserToDeleteRows = False
        DGVQueue.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGVMovieResults_Init()
        DGVActorResults_Refresh()
        DGVHeldMovies_Refresh()
        DGVQueue_Refresh()

    End Sub

    Private Sub DGVQueue_Refresh()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Movie.MID, Movie.Title from Movie, Queues where Queues.MID = Movie.MID AND Queues.CID = " + cid.ToString
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim dtQueue = New DataTable()
        dtQueue.Clear()
        dtQueue.Load(myReader)

        DGVQueue.AutoGenerateColumns = True
        DGVQueue.DataSource = dtQueue
        DGVQueue.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub DGVHeldMovies_Refresh()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Movie.MID, Movie.Title FROM Orders, Movie WHERE Movie.MID = Orders.MID AND Orders.ActualReturn IS NULL AND Orders.CID = " + cid.ToString
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
        myConn.Open()

        For Each row As DataGridViewRow In DGVMovieResults.SelectedRows
            myCmd = myConn.CreateCommand
            Dim mid As Integer
            mid = row.Cells(0).Value
            myCmd.CommandText = "INSERT INTO Queues Values(" + cid.ToString + "," + mid.ToString + ")"
            myCmd.ExecuteNonQuery()

        Next
        myConn.Close()
        DGVQueue_Refresh()
    End Sub

    Private Sub BtnRemoveMovie_Click(sender As Object, e As EventArgs) Handles BtnRemoveMovie.Click
        myConn.Open()

        For Each row As DataGridViewRow In DGVQueue.SelectedRows
            myCmd = myConn.CreateCommand
            Dim mid As Integer
            mid = row.Cells(0).Value
            myCmd.CommandText = "DELETE FROM Queues WHERE CID = " + cid.ToString + " AND MID = " + mid.ToString
            myCmd.ExecuteNonQuery()

        Next
        myConn.Close()
        DGVQueue_Refresh()
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
        Dim CurDate As Date = Date.Now.Date
        Dim ExpDate As Date = expecteddate(CurDate)
        Dim formats() As String = {"yyyy-MM-dd"}
        Dim Cur As String
        Dim Exp As String

        Dim oid As Int16
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT count(*)FROM Movie"
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()
            oid = myReader.GetInt32(0)
        Loop
        oid = oid + 1

        myReader.Close()


        For Each fmt In formats
            Cur = CurDate.ToString(fmt)
            Exp = ExpDate.ToString(fmt)
        Next

        For Each row As DataGridViewRow In DGVQueue.SelectedRows

            Dim mid As Integer
            mid = row.Cells(0).Value
            myCmd.CommandText = "INSERT INTO Orders VALUES (" + oid.ToString + ", '" + Cur + "', '" + Exp + "', null, " + mid.ToString + ", " + cid.ToString + ", null)"
            myCmd.ExecuteNonQuery()
        Next
        myConn.Close()
        DGVHeldMovies_Refresh()
    End Sub

    Private Function expecteddate(orderdate As Date) As Date
        Return orderdate.AddDays(14)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myConn.Open()
        Dim Cur As String
        Dim formats() As String = {"yyyy-MM-dd"}
        For Each fmt In formats
            Cur = Date.Now.Date.ToString(fmt)
        Next

        For Each row As DataGridViewRow In DGVHeldMovies.SelectedRows
            myCmd = myConn.CreateCommand
            Dim mid As Integer
            mid = row.Cells(0).Value
            myCmd.CommandText = "UPDATE Orders SET ActualReturn = '" + Cur + "' WHERE MID = " + mid.ToString + " AND CID = " + cid.ToString
            myCmd.ExecuteNonQuery()

        Next
        myConn.Close()
        DGVHeldMovies_Refresh()
    End Sub
End Class